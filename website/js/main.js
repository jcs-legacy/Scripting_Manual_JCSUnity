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

  function showChildren(obj) { obj.children().show(); }
  function hideChildren(obj) { obj.children().hide(); }

  /* Open the SB directory and turn the arrow text off. */
  function openSBDir(items, arrow) {
    showChildren(items);
    arrow.text("-");
  }

  /* Close the SB directory and turn the arrow text on. */
  function closeSBDir(items, arrow) {
    hideChildren(items);
    arrow.text("+");
  }

  /* Toggle the SB directory and turn the arrow text on/off. */
  function toggleSBDir(items, arrow) {
    if (arrow.text() == "+")
      openSBDir(items, arrow);
    else
      closeSBDir(items, arrow);
  }


  /* Register button event */
  function addSBDirButtonEvent() {
    let sbDir = $('.sb-dir');
    let arrows = $('.arrow');
    let arrowsText = $('.arrow + span');

    arrows.click(function (e) {
      // Stop overlaping `li' tag's click event trigger.
      e.stopPropagation();

      let items = $(this).siblings('ul');

      toggleSBDir(items, $(this));
    });

    arrowsText.click(function (e) {
      // Stop overlaping `li' tag's click event trigger.
      e.stopPropagation();

      let items = $(this).siblings('ul');
      let arrow = $(this).siblings('.arrow');

      toggleSBDir(items, arrow);
    });

    let currentContentPage = getUrlParameter('page');

    let pathDir = [];

    if (currentContentPage != null)
      pathDir = currentContentPage.split('-');

    let currentPathDir = pathDir[0];

    let dirLayer = 0;

    // Initialize by URL param.
    sbDir.each(function () {
      let items = $(this).find('ul');
      let arrow = $(this).find('.arrow');

      let path = $(this).attr('id');

      if (currentPathDir == path) {
        openSBDir(items, arrow);

        // Add up directory layer.
        ++dirLayer;

        // Setup the next directory tree.
        currentPathDir += '-' + pathDir[dirLayer];
      } else {
        // Close the directory as default.
        closeSBDir(items, arrow);
      }
    });
  }
  addSBDirButtonEvent();  // Do it once at initialize time.

  function addSBFileButtonEvent() {
    var sbFile = $('.sb-file');

    sbFile.click(function (e) {
      // Stop overlaping `div' tag's click event trigger.
      e.stopPropagation();

      var contentPage = $(this).attr('id');

      var contentPageName = contentPage.replace(/-/g, "/");

      loadContentPage(contentPageName);

      addParamToURL("page", contentPage, true);
    });

    let currentContentPage = getUrlParameter('page');

    let selectedFilename = [];

    if (currentContentPage != null) {
      selectedFilename = currentContentPage.split('-');
      selectedFilename = selectedFilename[selectedFilename.length - 1];
    }

    // Check if current file selected. Highlight it!
    sbFile.each(function () {
      let filePath = $(this).attr('id');

      let filename = filePath.split('-');
      filename = filename[filename.length - 1];

      if (selectedFilename == filename) {
        /* Selected file's CSS configurations. */
        $(this).css('background-color', '#222C37');
        $(this).css('color', '#FFFFFF');
        $(this).css('padding-left', '10px');
        $(this).css('margin-top', '5px');
        $(this).css('margin-bottom', '5px');

        // Scroll to that file selected.
        sbContainer.animate({
          scrollTop: $(this).offset().top
        });
      }
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
    loadCurrentContentPage();
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
   * Load the current content page if defined. If not load the default
   * content page.
   */
  function loadCurrentContentPage() {

    // Get the current content page in the URL.
    let currentContentPage = getUrlParameter('page');

    let contentPageName = currentContentPage;

    // If the page does not define load the intro page.
    if (currentContentPage == null)
      contentPageName = intro_content;
    else
      contentPageName = currentContentPage.replace(/-/g, "/");

    loadContentPage(contentPageName);
  }

  /**
   * Load the content HTML file.
   * @param { typename } contentPage : Content page name.
   */
  function loadContentPage(contentPage) {
    var fullPath = contentPage + content_extension;

    // Load content page base on the current page tab.
    if (contentPage != intro_content) {
      if (checkPageFound(manualPage)) {
        fullPath = "./doc/" + fullPath;
      } else if (checkPageFound(scriptReferencePage)) {
        fullPath = "./api/" + fullPath;
      }
    } else {
      cleanParamFromURL();
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
   * Add a parameter to current URL.
   *
   * @param { string } paramName : parameter name.
   * @param { string } paramValue : parameter value.
   * @param { boolean } clean : Clean param?
   */
  function addParamToURL(paramName, paramValue, clean) {
    var url = document.location.href;

    // Remove all parameters?
    if (clean)
      url = url.split('?')[0];

    if(url.indexOf('?') != -1) {
      url += "&";
    }else{
      url += "?";
    }

    url += paramName + "=" + paramValue;

    // Set URL and reload the page.
    document.location = url;
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
 * Get URL parameter.
 *
 * SOURCE(jenchieh): https://stackoverflow.com/questions/19491336/get-url-parameter-jquery-or-how-to-get-query-string-values-in-js
 * @param { string } paramName : name of the parameter.
 */
function getUrlParameter(paramName) {
  var sPageURL = decodeURIComponent(window.location.search.substring(1));
  var sURLVariables = sPageURL.split('&');

  for (let index = 0; index < sURLVariables.length; index++) {
    let sParameterName = sURLVariables[index].split('=');

    if (sParameterName[0] === paramName) {
      return sParameterName[1] === undefined ? true : sParameterName[1];
    }
  }

  return null;
}

/**
 * Clean all URL parameters.
 */
function cleanParamFromURL() {
  var url = document.location.href;
  url = url.split('?')[0];

  // Remove param without reload page.
  history.pushState({ }, null, url);
}
