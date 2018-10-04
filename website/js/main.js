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
    let sbDir = $('.sb-dir');
    let arrows = $('.arrow');
    let arrowsText = $('.arrow + span');

    arrows.click(function (e) {
      // Stop overlaping `li' tag's click event trigger.
      e.stopPropagation();

      let items = $(this).siblings('ul');

      if ($(this).text() == "+")
      {
        showChilren(items);
        $(this).text("-");
      }
      else
      {
        hideChilren(items);
        $(this).text("+");
      }
    });

    arrowsText.click(function (e) {
      // Stop overlaping `li' tag's click event trigger.
      e.stopPropagation();


      let items = $(this).siblings('ul');
      let arrow = $(this).siblings('.arrow');

      if (arrow.text() == "+")
      {
        showChilren(items);
        arrow.text("-");
      }
      else
      {
        hideChilren(items);
        arrow.text("+");
      }
    });

    // Initialize as hide.
    sbDir.each(function () {
      let items = $(this).find('ul');
      hideChilren(items);
    });
  }
  addSBDirButtonEvent();  // Do it once at initialize time.

  function addSBFileButtonEvent() {
    var sbFile = $('.sb-file');

    sbFile.click(function (e) {
      // Stop overlaping `div' tag's click event trigger.
      e.stopPropagation();

      var contentPage = $(this).attr('id');

      contentPage = contentPage.replace(/-/g, "/");

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
        url: '../../manual_index_data',
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
        url: '../../api_index_data',
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
  function createIndexWithDir(dir, inParent) {

    inParent.append("<ul></ul>");

    let parent = inParent.find('ul');

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

      var isDir = (pathObj.type != "file");

      var newPath = pathObj.path;
      newPath = newPath.replace(/\//g, "-");  // slash to dash
      if (!isDir) {
        // Remove extension
        newPath = newPath.replace(/\.[^/.]+$/, "");
      }

      var dirOrFileName = pathObj.name;
      dirOrFileName = dirOrFileName.replace(/\.[^/.]+$/, "");  // Remove extension if there is.

      if (checkPageFound(manualPage)) {
        // Replace underscore with space.
        dirOrFileName = dirOrFileName.replace(/_/g, ' ');
      }

      parent.append("<li class=" + sbType +" id=" + newPath + "></li>");

      var newPathNode = $('#' + newPath);

      var htmlDirOrFileName = "<span>" + dirOrFileName + "</span>";

      if (isDir) {
        htmlDirOrFileName = "<div class='arrow'>+</div>" + htmlDirOrFileName;
      }

      newPathNode.append(htmlDirOrFileName);

      newPathNode.addClass(getLayerByNum(layerNum));

      if (pathObj.children != null && pathObj.children.length != 0) {
        createIndexWithDir(pathObj.children, newPathNode);
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
    var fullPath = contentPage + content_extension;

    // Load content page base on the current page tab.
    if (contentPage != 'intro') {
      if (checkPageFound(manualPage)) {
        fullPath = "./doc/" + fullPath;
      } else if (checkPageFound(scriptReferencePage)) {
        fullPath = "./api/" + fullPath;
      }
    }

    content.load(
      fullPath,
      // Done loading callback.
      function () {
        /* Reload possible changing variables. */
        {
          let manualName = $('.manual-name');
          let versionJCSUnity = $('.version-jcsunity');
          let versionUnity = $('.version-unity');
          let copyright = $('.copyright');

          manualName.text(manual_name);
          versionJCSUnity.text(version_jcsunity);
          versionUnity.text(version_unity);
          copyright.text(copyright_text);
        }

        let codeBlocks = $('.code-block');
        codeBlocks.each(function (index) {
          let codeText = $(this).text();
          // Replace all line break to '<br/>'.
          codeText = codeText.replace(/(?:\r\n|\r|\n)/g, '<br/>');

          // Replace all space to &nbsp.
          codeText = codeText.replace(/\s/g, '&nbsp;');

          // Clean the text.
          $(this).text("");

          // Turn it into HTML.
          $(this).html(codeText);
        });
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
