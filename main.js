/**
 * $File: main.js $
 * $Date: 2018-09-27 16:02:42 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *                   Copyright © 2018 by Shen, Jen-Chieh $
 */

"use strict";

/* Include `express.js' */
const express = require('express');
const app = express();

const config = require('./config');

// Error handler
app.use(function(err, req, res, next) {
  res.status(422).send({ error: err.message });
});;


// Start listening..
const server = app.listen(config.PORT, function () {
  console.log("Server active successfully... Port: " + config.PORT);
});
