﻿/**
 * $File: JCS_OneShotObject.cs $
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
    /// One shot object.
    /// </summary>
    public class JCS_OneShotObject 
        : MonoBehaviour
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

        [Tooltip("")]
        [SerializeField]
        private JCS_Axis mAxis = JCS_Axis.AXIS_X;

        [Tooltip("")]
        [SerializeField]
        private bool mEffectOnAwake = true;

        [Tooltip("")]
        [SerializeField]
        private bool mLoop = false;

        [Tooltip("")]
        [SerializeField]
        private bool mStayAtLastPosition = false;

        [Tooltip("")]
        [SerializeField]
        private float mMoveSpeed = 5.0f;

        [Tooltip("")]
        [SerializeField]
        private float mDistance = 100.0f;

        private bool mEffect = false;

        private Vector3 mRecordPosition = Vector3.zero;
        private float mDistanceRecorder = 0.0f;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------

        //========================================
        //      Unity's function
        //------------------------------
        private void Start()
        {
            mRecordPosition = this.transform.position;
            mEffect = mEffectOnAwake;

            if (mStayAtLastPosition)
                mLoop = false;
        }

        private void Update()
        {
            if (!mEffect)
                return;

            mDistanceRecorder += JCS_Mathf.AbsoluteValue(mMoveSpeed) * Time.deltaTime;

            if (mDistanceRecorder > mDistance)
            {
                mDistanceRecorder = 0;

                if (!mStayAtLastPosition)
                    this.transform.position = mRecordPosition;

                // if is not loop disable the effect
                if (!mLoop)
                    mEffect = false;
            }


            DoMovement(mAxis, mMoveSpeed);

        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos"></param>
        public void PlayOneShot(Vector3 pos)
        {
            PlayOneShot(pos, mDistance);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="distance"></param>
        public void PlayOneShot(Vector3 pos, float distance)
        {
            mRecordPosition = pos;
            mDistance = distance;
            mEffect = true;
        }
        
        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ax"></param>
        /// <param name="speed"></param>
        private void DoMovement(JCS_Axis ax, float speed)
        {
            switch (ax)
            {
                case JCS_Axis.AXIS_X:
                    this.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
                    break;
                case JCS_Axis.AXIS_Y:
                    this.transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
                    break;
                case JCS_Axis.AXIS_Z:
                    this.transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
                    break;
            }
        }

    }
}
