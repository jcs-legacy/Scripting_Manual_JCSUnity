﻿/**
 * $File: JCS_ShootAllAngle.cs $
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
    /// Do the shooting action in all angle.
    /// </summary>
    [RequireComponent(typeof(JCS_ShootAction))]
    public class JCS_ShootAllAngle
        : MonoBehaviour
        , JCS_Action
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables
        private JCS_ShootAction mShootAction = null;


        [Header("** Runtime Variables (JCS_ShootAllAngle) **")]

        [Tooltip("Automatically shoot the bullet itself, use of AI!")]
        [SerializeField]
        private bool mAutoShootInFrame = false;

        [Tooltip("Automatically shoot the bullet itself, use of AI!")]
        [SerializeField]
        private bool mAutoShootByOrder = false;

        [Tooltip("Degree per bullet shoot.")]
        [SerializeField] [Range(1, 360)]
        private float mDegreePerShoot = 10;

        [Tooltip("Check if the enemy can shoot or not depends on the Delay Time!")]
        [SerializeField]
        private bool mCanShoot = true;


        [Tooltip("How long it take to shoot a bullet.")]
        [SerializeField] [Range(0.01f, 15.0f)]
        private float mDelayTime = 1.0f;

        [Tooltip("Time that will randomly affect the Time Zone.")]
        [SerializeField] [Range(0.0f, 3.0f)]
        private float mAdjustTimeZone = 1.5f;

        [Tooltip("Axis of the bullet shooting.")]
        [SerializeField]
        private JCS_Axis mShootAxis = JCS_Axis.AXIS_Z;

        private float mDelayTimer = 0;

        private bool mShooted = false;

        private float mRealTimeZone = 0;

        private float mCount = 0;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------
        public bool AutoShootInFrame { get { return this.mAutoShootInFrame; } set { this.mAutoShootInFrame = value; } }
        public bool AutoShootByOrder { get { return this.mAutoShootByOrder; } set { this.mAutoShootByOrder = value; } }
        public bool CanShoot { get { return this.mCanShoot; } set { this.mCanShoot = value; } }

        //========================================
        //      Unity's function
        //------------------------------
        private void Awake()
        {
            this.mShootAction = this.GetComponent<JCS_ShootAction>();

            mShootAction.CanShoot = false;

            // disable auto shoot be default
            mShootAction.AutoShoot = false;
        }

        private void Update()
        {
            if (AutoShootInFrame)
                AutoShootActionByFrame();

            if (AutoShootByOrder)
                AutoShootActionByOrder();
        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        /// <summary>
        /// 
        /// </summary>
        public void ShootAllAngleByFrame()
        {
            Vector3 newRotation = this.transform.localEulerAngles;
            Vector3 recordRotation = newRotation;

            for (int count = 0;
                count < 360 / mDegreePerShoot;
                ++count)
            {
                switch (mShootAxis)
                {
                    case JCS_Axis.AXIS_X:
                        newRotation.x = mDegreePerShoot * count;
                        break;

                    case JCS_Axis.AXIS_Y:
                        newRotation.y = mDegreePerShoot * count;
                        break;

                    case JCS_Axis.AXIS_Z:
                        newRotation.z = mDegreePerShoot * count;
                        break;
                }

                transform.localEulerAngles = newRotation;

                mShootAction.Shoot();
            }
            transform.localEulerAngles = recordRotation;

            mShooted = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShootAllAngleByOrder()
        {
            Vector3 newRotation = this.transform.localEulerAngles;
            Vector3 recordRotation = newRotation;

            switch (mShootAxis)
            {
                case JCS_Axis.AXIS_X:
                    newRotation.x = mDegreePerShoot * mCount;
                    break;

                case JCS_Axis.AXIS_Y:
                    newRotation.y = mDegreePerShoot * mCount;
                    break;

                case JCS_Axis.AXIS_Z:
                    newRotation.z = mDegreePerShoot * mCount;
                    break;
            }

            transform.localEulerAngles = newRotation;

            mShootAction.Shoot();

            ++mCount;

            transform.localEulerAngles = recordRotation;

            mShooted = true;
        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

        /// <summary>
        /// 
        /// </summary>
        private void AutoShootActionByFrame()
        {
            if (!CanShoot)
                return;

            if (mShooted)
                ResetTimeZone();

            mDelayTimer += Time.deltaTime;

            if (mRealTimeZone < mDelayTimer)
            {
                ShootAllAngleByFrame();

                // reset timer
                mDelayTimer = 0;
            }
        }

        /// <summary>
        /// Automatically shoot by the timer.
        /// </summary>
        private void AutoShootActionByOrder()
        {
            if (!CanShoot)
                return;

            if (mShooted)
                ResetTimeZone();

            mDelayTimer += Time.deltaTime;

            if (mRealTimeZone < mDelayTimer)
            {
                ShootAllAngleByOrder();

                // reset timer
                mDelayTimer = 0;
            }
        }

        /// <summary>
        /// Reset the timer.
        /// </summary>
        private void ResetTimeZone()
        {
            float adjustTime = JCS_Random.Range(-mAdjustTimeZone, mAdjustTimeZone);
            mRealTimeZone = mDelayTime + adjustTime;

            mShooted = false;
            mDelayTimer = 0;
        }

    }
}
