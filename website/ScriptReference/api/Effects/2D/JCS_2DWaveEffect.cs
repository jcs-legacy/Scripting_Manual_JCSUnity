﻿/**
 * $File: JCS_2DWaveEffect.cs $
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
    /// Make the attached transform do the wave effect.
    /// </summary>
    public class JCS_2DWaveEffect
        : JCS_2DEffect
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

#if (UNITY_EDITOR)
        [Header("** Helper Variables (JCS_2DWaveEffect) **")]

        [Tooltip("Test with key?")]
        [SerializeField]
        private bool mTestWithKey = false;

        [Tooltip("Do wave effect key.")]
        [SerializeField]
        private KeyCode mDoWaveEffectKey = KeyCode.T;
#endif


        [Header("** Runtime Variables (JCS_2DWaveEffect) **")]

        private float mTime = 0;

        [Tooltip("height offset.")]
        [SerializeField]
        private float mWaveRestPosition = 0.0f;

        [Tooltip("How intense the wave is.")]
        [SerializeField]
        private float mAmplitude = 1.0f;

        [Tooltip("How fast per period in wave.")]
        [SerializeField]
        private float mFrequency = 2;
        private Vector3 mOrigin = Vector3.zero;

        [Tooltip("Effect Axis(Effect will do only on axis!, for random plz use the 3D version!)")]
        [SerializeField]
        private JCS_Axis mEffectAxis = JCS_Axis.AXIS_X;

        [Tooltip("")]
        [SerializeField]
        private float mEffectTime = 0;


        [Header("NOTE: If the effect object is camera, plz fill the camera in here.")]

        [SerializeField]
        private JCS_2DCamera mJCS_2DCamera = null;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------

        //========================================
        //      Unity's function
        //------------------------------
        private void Awake()
        {
            if (mJCS_2DCamera == null)
                mJCS_2DCamera = this.GetComponent<JCS_2DCamera>();
        }

        private void Update()
        {
#if (UNITY_EDITOR)
            Test();
#endif

            DoEffect();
        }

#if (UNITY_EDITOR)
        private void Test()
        {
            if (!mTestWithKey)
                return;

            if (JCS_Input.GetKeyDown(mDoWaveEffectKey))
            {
                DoWaveEffect(1, mFrequency);
            }
        }
#endif

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        /// <summary>
        /// Active the wave effect.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="frequency"></param>
        public void DoWaveEffect(float time, float frequency)
        {
            // if is doing the effect
            if (mEffect)
                return;

            mTime = 0;
            mEffectTime = time;
            mFrequency = frequency;

            mOrigin = this.transform.position;

            // cps = cycle per second = wave speed

            mEffect = true;
        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions
        private void DoEffect()
        {
            if (!mEffect)
                return;

            if (mJCS_2DCamera != null)
            {
                this.mOrigin.x = mJCS_2DCamera.GetTargetTransform().position.x;
                this.mOrigin.y = mJCS_2DCamera.GetTargetTransform().position.y;
            }

            mTime += Time.deltaTime;

            if (mEffectTime > mTime)
            {
                Vector3 newPos = mOrigin;


                float force =
                    (mAmplitude *
                    Mathf.Cos(mTime * Mathf.PI * mFrequency * 2));

                switch (mEffectAxis)
                {
                    case JCS_Axis.AXIS_X:
                        newPos.x = force + 
                            (mWaveRestPosition + mOrigin.x);
                        break;
                    case JCS_Axis.AXIS_Y:
                        newPos.y = force + 
                            (mWaveRestPosition + mOrigin.y);
                        break;
                    case JCS_Axis.AXIS_Z:
                        newPos.z = force +
                            (mWaveRestPosition + mOrigin.z);
                        break;
                }
                

                this.transform.position = newPos;
            }
            else
            {
                this.transform.position = mOrigin;

                mEffect = false;
            }
        }

    }
}
