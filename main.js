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



// Setup website directory.
app.use(express.static(config.WEBSITE_DIR));

/* Register all request. */
app.get('/api_index_data', api_index_data);
app.get('/manual_index_data', manual_index_data);


// Error handler
app.use(function(err, req, res, next) {
  res.status(422).send({ error: err.message });
});;


// Start listening..
const server = app.listen(config.PORT, function () {
  console.log("Server active successfully... Port: " + config.PORT);
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
  const tree = dirTree(config.MANUAL_DIR_PATH, { normalizePath: true });

  // Modefied the `MANUAL_DIR_PATH' to the correct format string.
  var removePath = config.MANUAL_DIR_PATH;
  removePath = removePath.replace("./", "");

  removeLeadPath(tree.children, removePath);

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
  const tree = dirTree(config.API_DIR_PATH, { normalizePath: true });

  // Modefied the `API_DIR_PATH' to the correct format string.
  var removePath = config.API_DIR_PATH;
  removePath = removePath.replace("./", "");

  removeLeadPath(tree.children, removePath);

  res.send(JSON.stringify(tree));
}

/**
 * Remove the `API_DIR_PATH', so when the client receive the data
 * would not need to care where is the api directory located.
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

    // Remove the `API_DIR_PATH' path.
    pathObj.path = pathObj.path.replace(rmPath, "");
  }
}
