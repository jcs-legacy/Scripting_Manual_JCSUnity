/**
 * $File: main.js $
 * $Date: 2018-09-27 16:02:42 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *                   Copyright © 2018 by Shen, Jen-Chieh $
 */

"use strict";

const fs = require('fs');
const path = require('path');

/* Include `express.js' */
const express = require('express');
const app = express();

/* `directory-tree' */
const dirTree = require('directory-tree');

const config = require('./config');


/* Conversion Keywords */
const spaceKey = "_sp_";  // Must be the same as client.


// Setup website directory.
app.use(express.static(config.WEBSITE_DIR));

/* Register all request. */
app.get('/api_index_data', api_index_data);
app.get('/manual_index_data', manual_index_data);

app.get('/search_manual/:search_keyword', search_manual);
app.get('/search_api/:search_keyword', search_api);


// Error handler
app.use(function(err, req, res, next) {
  res.status(422).send({ error: err.message });
});;


app.set('port', process.env.PORT || config.PORT);

// Start listening..
const server = app.listen(app.get('port'), function () {
  console.log("Server active successfully... Port: " + app.get('port'));
});


//=============== functions ========================//

/**
 * Send the manual index data.
 *
 * @param { typename } req : request handler.
 * @param { typename } res : response handler.
 * @param { typename } next : error handler.
 * @returns { JSON } : tree structure of the API.
 */
function manual_index_data(req, res, next) {
  let tree = getManualTree();

  res.send(JSON.stringify(tree));
}

/**
 * Send the scripting reference index data.
 *
 * @param { typename } req : request handler.
 * @param { typename } res : response handler.
 * @param { typename } next : error handler.
 * @returns { JSON } : tree structure of the API.
 */
function api_index_data(req, res, next) {
  let tree = getAPITree();

  res.send(JSON.stringify(tree));
}

/**
 * Search the manual files and return the all mathc result.
 *
 * @param { typename } req : request handler.
 * @param { typename } res : response handler.
 * @param { typename } next : error handler.
 * @returns { JSON } : Search result.
 */
function search_manual(req, res, next) {
  let data = req.params;  // get all params
  let searchKeyword = data.search_keyword;

  /* Conversion base on the rule. */
  // This rule must match client side.
  searchKeyword = searchKeyword.split(spaceKey).join(" ");


  let searchResults = [];
  let tree = getManualTree();

  searchMatchPath(tree.children, searchKeyword, searchResults);

  res.send(JSON.stringify(searchResults));
}

/**
 * Search the api files and return the all match result.
 *
 * @param { typename } req : request handler.
 * @param { typename } res : response handler.
 * @param { typename } next : error handler.
 * @returns { JSON } : Search result.
 */
function search_api(req, res, next) {
  let data = req.params;  // get all params
  let searchKeyword = data.search_keyword;

  /* Conversion base on the rule. */
  // This rule must match client side.
  searchKeyword = searchKeyword.split(spaceKey).join(" ");


  let searchResults = [];
  let tree = getAPITree();

  searchMatchPath(tree.children, searchKeyword, searchResults);

  res.send(JSON.stringify(searchResults));
}

/* Get the Manual tree. */
function getManualTree() {
  const tree = dirTree(config.MANUAL_DIR_PATH, { extensions: config.CONTENT_EXTENSION, normalizePath: true });

  // Sort it.
  sortTreeByType(tree.children, config.SORT_ORDER);

  // Modefied the `MANUAL_DIR_PATH' to the correct format string.
  var removePath = config.MANUAL_DIR_PATH;
  removePath = removePath.replace("./", "");

  removeLeadPath(tree.children, removePath);

  return tree;
}

/* Get the API tree. */
function getAPITree() {
  const tree = dirTree(config.API_DIR_PATH, { extensions: config.CONTENT_EXTENSION, normalizePath: true });

  // Sort it.
  sortTreeByType(tree.children, config.SORT_ORDER);

  // Modefied the `API_DIR_PATH' to the correct format string.
  var removePath = config.API_DIR_PATH;
  removePath = removePath.replace("./", "");

  removeLeadPath(tree.children, removePath);

  return tree;
}


/**
 * Remove the `MANUAL_DIR_PATH' or `API_DIR_PATH', so when the client
 * receive the data would not need to care where is the api directory located.
 * @param { JSON } dir : directory JSON object.
 * @param { typename } rmPath : Param desc here..
 */
function removeLeadPath(dir, rmPath) {
  for (let index = 0;
       index < dir.length;
       ++index)
  {
    let pathObj = dir[index];

    if (pathObj.children != null && pathObj.children.length != 0) {
      removeLeadPath(pathObj.children, rmPath);
    }

    // Remove the `MANUAL_DIR_PATH' or `API_DIR_PATH' path.
    pathObj.path = pathObj.path.replace(rmPath, "");
  }
}

/**
 * Search the match result.
 * @param { JSON } dir : directory JSON object.
 * @param { string } match : stirng check to match.
 * @param { array } arr : Array to store search result.
 */
function searchMatchPath(dir, match, arr) {
  for (let index = 0;
       index < dir.length;
       ++index)
  {
    let pathObj = dir[index];

    if (pathObj.children != null && pathObj.children.length != 0) {
      searchMatchPath(pathObj.children, match, arr);
    }

    /* Make it case insensitive. */
    let nameUpper = pathObj.name.toUpperCase();
    let matchUpper = match.toUpperCase();

    // If match add it to search result.
    if (nameUpper.includes(matchUpper) && pathObj.type == 'file') {
      arr.push(pathObj);
    }
  }
}

/**
 * Sort the tree result by directory/file type.
 * @param { tree.children } tree : Tree children.
 * @param { string } type : Sort type, enter 'directory' or 'file'.
 */
function sortTreeByType(tree, type = 'directory') {
  if (type != 'directory' && type != 'file')
    return;

  let tarList = [];  // target list.
  let anoList = [];  // another list.

  /* Split path object into two arrays by type. */
  {
    for (let index = 0;
         index < tree.length;
         ++index)
    {
      let pathObj = tree[index];
      if (pathObj.children != null && pathObj.children.length != 0) {
        sortTreeByType(pathObj.children, type);
      }

      // Add path object by type.
      if (pathObj.type == type)
        tarList.push(pathObj);
      else
        anoList.push(pathObj);
    }
  }

  /* Copy array over. */
  {
    let resultTree = tarList.concat(anoList);

    for (let index = 0;
         index < tree.length;
         ++index)
    {
      tree[index] = resultTree[index];
    }
  }
}
