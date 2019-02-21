/**
 * $File: config.js $
 * $Date: 2018-09-27 17:11:04 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *                   Copyright © 2018 by Shen, Jen-Chieh $
 */

"use strict";


const DEBUG = false;  // Debug mode?

const HOST = "localhost";  // Host [Default: localhost]
const PORT = 3001;         // Server Port [Default: 3000]

const WEBSITE_DIR = "website";

/* Paths */
const API_DIR_PATH = "./website/ScriptReference/api/";
const MANUAL_DIR_PATH = "./website/Manual/doc/";

/* Action */
const SORT_ORDER = 'directory';

// Content extension to load.
//
// NOTE(jenchieh): have to be the same with 'client' side's
// config file.
//
// SEE : ./website/js/config.js
const CONTENT_EXTENSION = /\.html/;

//------------------ Exports modules ------------------//

module.exports.DEBUG = DEBUG;

module.exports.HOST = HOST;
module.exports.PORT = PORT;

module.exports.WEBSITE_DIR = WEBSITE_DIR;

module.exports.API_DIR_PATH = API_DIR_PATH;
module.exports.MANUAL_DIR_PATH = MANUAL_DIR_PATH;

module.exports.SORT_ORDER = SORT_ORDER;

module.exports.CONTENT_EXTENSION = CONTENT_EXTENSION;
