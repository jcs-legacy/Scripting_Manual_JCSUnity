/**
 * $File: JCS_FreezeScaleAction.cs $
 * $Date: 2017-05-11 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *                   Copyright (c) 2017 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JCSUnity
{
    /// <summary>
    /// Do freezing for scale from transform.
    /// </summary>
    public class JCS_FreezeScaleAction
        : JCS_UnityObject
    {

        /*******************************************/
        /*            Public Variables             */
        /*******************************************/

        /*******************************************/
        /*           Private Variables             */
        /*******************************************/

        [Header("** Check Variables (JCS_FreezeScaleAction) **")]

        [Tooltip("Scale where we freeze at.")]
        [SerializeField]
        private Vector3 mScaleToFreeze = Vector3.zero;


        [Header("** Runtime Variables (JCS_FreezeScaleAction) **")]

        [Tooltip("Is this action active?")]
        [SerializeField]
        private bool mActive = true;

        [Tooltip("Freeze the scale?")]
        [SerializeField]
        private JCS_Bool3 mFreezeScale = JCS_Bool3.allFalse;
        /*******************************************/
        /*           Protected Variables           */
        /*******************************************/

        /*******************************************/
        /*             setter / getter             */
        /*******************************************/
        public bool Active { get { return this.mActive; } set { this.mActive = value; } }
        public JCS_Bool3 FreezeScale { get { return this.mFreezeScale; } set { this.mFreezeScale = value; } }
        public Vector3 ScaleToFreeze { get { return this.mScaleToFreeze; } set { this.mScaleToFreeze = value; } }

        /*******************************************/
        /*            Unity's function             */
        /*******************************************/
        private void Start()
        {
            // record down all the transform info value.
            this.mScaleToFreeze = this.LocalScale;
        }

        private void LateUpdate()
        {
            if (!mActive)
                return;

            DoFreezeScale();
        }

        /*******************************************/
        /*              Self-Define                */
        /*******************************************/
        //----------------------
        // Public Functions

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

        /// <summary>
        /// Freeze position.
        /// </summary>
        private void DoFreezeScale()
        {
            Vector3 newScale = this.LocalScale;

            /* Freeze scale */
            if (mFreezeScale.check1)
                newScale.x = mScaleToFreeze.x;
            if (mFreezeScale.check2)
                newScale.y = mScaleToFreeze.y;
            if (mFreezeScale.check3)
                newScale.z = mScaleToFreeze.z;

            this.LocalScale = newScale;
        }
    }
}
