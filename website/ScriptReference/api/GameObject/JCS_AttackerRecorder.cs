﻿/**
 * $File: JCS_AttackerRecorder.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                    Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using UnityEngine;
using System.Collections;


namespace JCSUnity
{
    /// <summary>
    /// Record down the attacker that attacked
    /// this transform object.
    /// </summary>
    public class JCS_AttackerRecorder
        : MonoBehaviour
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

        [Header("** Check Variables **")]

        // Every time this object get damage will 
        // record down the last attacker.
        [SerializeField]
        private Transform mLastAttacker= null;

        // Record all the attacker attack this enemy!
        private JCS_Vector<Transform> mAttackers = null;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------
        public Transform LastAttacker { get { return this.mLastAttacker; } set { this.mLastAttacker = value; } }
        public JCS_Vector<Transform> GetAttackers() { return this.mAttackers; }

        //========================================
        //      Unity's function
        //------------------------------
        private void Awake()
        {
            mAttackers = new JCS_Vector<Transform>();
        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

    }
}
