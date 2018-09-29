/**
 * $File: main.js $
 * $Date: 2018-09-27 20:38:08 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *                   Copyright © 2018 by Shen, Jen-Chieh $
 */

"use strict";


/**
 * jQuery entry.
 */
(function ($) {

  /* Others */
  var layerNum = -1;

  /* Collect Config */
  var manualName = $('.manual-name');
  var versionJCSUnity = $('.version-jcsunity');
  var versionUnity = $('.version-unity');
  var copyright = $('.copyright');

  /* Collect all pages. */
  var manualPage = $('#manual-page');
  var scriptReferencePage = $('#script-reference-page');

  /* Collect Require Components. */
  var scrollBarTitle = $('#scroll-bar-title');
  var indexPos = $('#index-pos');

  /* Content */
  var content = $('#content');

  /* Buttons */

  /* Regular Decoration */
  var sbContainer = $('#scroll-bar-container');


  //---------------------- Functions ---------------------------//

  /* Register button event */
  function addSBDirButtonEvent() {
    var sbDir = $('.sb-dir');

    sbDir.click(function (e) {
      // Stop overlaping `div' tag's click event trigger.
      e.stopPropagation();

      if ($(this).children().is(":visible"))
        $(this).children().hide();
      else
        $(this).children().show();
    });
  }
  // Do it once at initialize time.
  addSBDirButtonEvent();


  /* Check if the page id <div> exists? */
  function checkPageFound (pageObj) { return (pageObj.length != 0); }

  /* Initialize the page. */
  function initPage() {
    initGlobalPage();

    if (checkPageFound(manualPage)) {
      initManulPage();
    } else if (checkPageFound(scriptReferencePage)) {
      initScriptReferencePage();
    }
  }

  /* Initialize components that exists in all pages.*/
  function initGlobalPage() {
    manualName.text(manual_name);
    versionJCSUnity.text(version_jcsunity);
    versionUnity.text(version_unity);
    copyright.text(copyright_text);
  }

  /* Initialzie the manual page. */
  function initManulPage() {
    scrollBarTitle.text(manual_name + " Manul");
  }

  /* Initialize the script reference page. */
  function initScriptReferencePage() {
    scrollBarTitle.text("Scripting API");

    /* Make AJAX request. */
    {
      /* Get API index. */
      $.ajax({
        url: 'http://localhost:3000/api_index_data',
        type: 'GET',
        contentType: "application/json",
        success : function (data) {
          var dir = JSON.parse(data);

          console.log(dir);

          createIndexWithDir(dir.children, indexPos);

          addSBDirButtonEvent();
        },
        error : function (e) {
          console.log(e.message);
        }
      });
    }
  }

  loadContentPage('intro');


  /* Create index with directory. */
  function createIndexWithDir(dir, parent) {
    ++layerNum;

    var currentDir = "";
    var currentParent = parent;

    for (let index = 0;
         index < dir.length;
         ++index)
    {
      if (index == 0) {
        //parent.append("<ul></ul>");
      }

      let pathObj = dir[index];

      if (pathObj.path.charAt(0) != "/")
        currentDir = pathObj.path;

      var sbType = "sb-dir";
      if (pathObj.type == "file") {
        sbType = "sb-file";
      }

      var newId = pathObj.path;
      newId = newId.replace(/\//g, "-");
      if (pathObj.type == "file") {
        // Remove extension
        newId = newId.replace(/\.[^/.]+$/, "");
      }

      var dirOfFileName = pathObj.name;
      dirOfFileName = dirOfFileName.replace(/\.[^/.]+$/, "");  // Remove extension if there is.

      currentParent.append("<div class=" + sbType +" id=" + newId + ">" +
                           dirOfFileName +
                           "</div>");

      var newParent = $('#' + newId);

      newParent.addClass(getLayerByNum(layerNum));

      if (pathObj.children != null && pathObj.children.length != 0) {
        createIndexWithDir(pathObj.children, newParent);
      }
    }

    --layerNum;
  }

  /*  */
  function getLayerByNum(layerNum) { return "sb-layer-" + layerNum; }

  /**
   * Load the content HTML file.
   * @param { typename } contentPage : Content page name.
   */
  function loadContentPage(contentPage) { content.load(contentPage + '.html'); }

  /**
   * jQuery program entry.
   */
  function jQueryMain() {
    initPage();
  }
  jQueryMain();  // Execute the program entry.

}(this.jQuery));


/**
 * Program Entry
 */
function main() {

}
main();
