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
  var hostPort = host + ':' + port;

  /* Collect all pages. */
  var manualPage = $('#manual-page');
  var scriptReferencePage = $('#script-reference-page');

  /* Collect Require Components. */
  var scrollBarTitle = $('#scroll-bar-title');
  var indexPos = $('#index-pos');

  /* Logo */
  var logo = $('#logo');

  /* Content */
  var content = $('#content');

  /* Buttons */


  /* Regular Decoration */
  var sbContainer = $('#scroll-bar-container');


  //---------------------- Functions ---------------------------//

  // Make logo load the `intro' content.
  logo.click(function () { loadContentPage(intro_content); });

  function showChilren(obj) { obj.children().show(); }
  function hideChilren(obj) { obj.children().hide(); }

  /* Register button event */
  function addSBDirButtonEvent() {
    var sbDir = $('.sb-dir');

    sbDir.click(function (e) {
      // Stop overlaping `div' tag's click event trigger.
      e.stopPropagation();

      if ($(this).children().is(":visible"))
        hideChilren($(this));
      else
        showChilren($(this));
    });

    sbDir.each(function () {
      hideChilren($(this));
    });
  }
  addSBDirButtonEvent();  // Do it once at initialize time.

  function addSBFileButtonEvent() {
    var sbFile = $('.sb-file');

    sbFile.click(function (e) {
      // Stop overlaping `div' tag's click event trigger.
      e.stopPropagation();

      console.log($(this).text());

      var contentPage = $(this).text();

      if (checkPageFound(manualPage))
        contentPage = contentPage.replace(/ /g, "_");

      loadContentPage(contentPage);
    });
  }
  addSBFileButtonEvent();  // Do it once at initialize time.

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
    loadContentPage(intro_content);
  }

  /* Initialzie the manual page. */
  function initManulPage() {
    scrollBarTitle.text(manual_name + " Manul");

    /* Make AJAX request. */
    {
      /* Get API index. */
      $.ajax({
        url: 'http://' + hostPort + '/manual_index_data',
        type: 'GET',
        contentType: "application/json",
        success : function (data) {
          var dir = JSON.parse(data);

          createIndexWithDir(dir.children, indexPos);

          addSBDirButtonEvent();
          addSBFileButtonEvent();
        },
        error : function (e) {
          console.log(e.message);
        }
      });
    }
  }

  /* Initialize the script reference page. */
  function initScriptReferencePage() {
    scrollBarTitle.text("Scripting API");

    /* Make AJAX request. */
    {
      /* Get API index. */
      $.ajax({
        url: 'http://' + hostPort + '/api_index_data',
        type: 'GET',
        contentType: "application/json",
        success : function (data) {
          var dir = JSON.parse(data);

          createIndexWithDir(dir.children, indexPos);

          addSBDirButtonEvent();
          addSBFileButtonEvent();
        },
        error : function (e) {
          console.log(e.message);
        }
      });
    }
  }

  /* Create index with directory. */
  function createIndexWithDir(dir, parent) {
    ++layerNum;

    var currentDir = "";

    for (let index = 0;
         index < dir.length;
         ++index)
    {

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

      if (checkPageFound(manualPage)) {
        // Replace underscore with space.
        dirOfFileName = dirOfFileName.replace(/_/g, ' ');
      }

      parent.append("<div class=" + sbType +" id=" + newId + ">" +
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
  function loadContentPage(contentPage) {
    var fullPath = contentPage + '.html';

    // Load content page base on the current page tab.
    if (contentPage != 'intro') {
      if (checkPageFound(manualPage)) {
        fullPath = "./doc/" + fullPath;
      } else if (checkPageFound(scriptReferencePage)) {
        fullPath = "./api/" + fullPath;
      }
    }

    content.load(fullPath, function () {
      let manualName = $('.manual-name');
      let versionJCSUnity = $('.version-jcsunity');
      let versionUnity = $('.version-unity');
      let copyright = $('.copyright');

      manualName.text(manual_name);
      versionJCSUnity.text(version_jcsunity);
      versionUnity.text(version_unity);
      copyright.text(copyright_text);
    });
  }

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
