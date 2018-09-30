﻿/**
 * $File: JCS_WeatherType.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *                   Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using UnityEngine;
using System.Collections;


namespace JCSUnity
{ 
    /// <summary>
    /// List of type of the possible weather.
    /// </summary>
    public enum JCS_WeatherType 
    {
        UNKNOWN,

        SUNNY,
        CLOUDY,
        FOG,
        RAINY,
        SNOWY,
        WINDY,
        STORM
    }
}