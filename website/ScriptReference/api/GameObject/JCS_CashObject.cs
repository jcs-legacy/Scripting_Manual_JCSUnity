﻿/**
 * $File: JCS_CashObject.cs $
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
    /// In game item stand for cash.
    /// </summary>
    public class JCS_CashObject
        : JCS_Item
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

        //----------------------
        // Protected Variables

        
        [Header("** Initialize Variables (JCS_CashObject) **")]

        [Tooltip("Cash in the game.")]
        [SerializeField] [Range(1, 99999999)]
        protected int mCashValue = 1;


        [Header("** Randomize Value Settings ** (JCS_CashObject) ")]

        [Tooltip("Randomize the cash value at init time?")]
        [SerializeField]
        protected bool mRandomizeCashValueEffect = false;

        [Tooltip("How much it effect the actual cash value.")]
        [SerializeField] [Range(0, 500)]
        protected int mRandomizeCashValue = 0;

        //========================================
        //      setter / getter
        //------------------------------
        public int CashValue { get { return this.mCashValue; } set { this.mCashValue = value; } }
        public bool RandomizeCashValueEffect { get { return this.mRandomizeCashValueEffect; } set { this.mRandomizeCashValueEffect = value; } }
        public int RandomizeCashValue { get { return this.mRandomizeCashValue; } set { this.mRandomizeCashValue = value; } }

        //========================================
        //      Unity's function
        //------------------------------

        protected override void Awake()
        {
            base.Awake();

            // no effect happens
            if (!RandomizeCashValueEffect || 
                mRandomizeCashValue == 0)
                return;

            // randomize the cash value a bit.
            mCashValue += JCS_Random.Range(-mRandomizeCashValue, mRandomizeCashValue + 1);
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
