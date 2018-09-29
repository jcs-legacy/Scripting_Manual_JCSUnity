/**
 * $File: JCS_RevolutioAction.cs $
 * $Date: 2017-09-19 12:27:05 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright (c) 2017 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JCSUnity
{
    /// <summary>
    /// Revolution rotation.
    /// </summary>
    public class JCS_RevolutioAction
        : MonoBehaviour
    {

        /*******************************************/
        /*            Public Variables             */
        /*******************************************/

        /*******************************************/
        /*           Private Variables             */
        /*******************************************/

        [Header("** Runtime Variables (JCS_RevolutioAction) **")]

        [Tooltip("Current angle.")]
        [SerializeField]
        private int mDegree = 0;

        [Tooltip("Radisu to revolution.")]
        [SerializeField] [Range(0.0f, 1000.0f)]
        private float mRadius = 10.0f;

        [Tooltip("Origin transform.")]
        [SerializeField]
        private Transform mOrigin = null;

        [Tooltip("Axis on revolution.")]
        [SerializeField]
        private JCS_Axis mAxis = JCS_Axis.AXIS_X;

        [Tooltip("Revolute to local position instead of global position.")]
        [SerializeField]
        private bool mRevoluteAsLocalPosition = false;

        /*******************************************/
        /*           Protected Variables           */
        /*******************************************/

        /*******************************************/
        /*             setter / getter             */
        /*******************************************/
        public JCS_Axis Axis { get { return this.mAxis; } set { this.mAxis = value; } }
        public bool RevoluteAsLocalPosition { get { return this.mRevoluteAsLocalPosition; } set { this.mRevoluteAsLocalPosition = value; } }
        public Transform Origin { get { return this.mOrigin; } set { this.mOrigin = value; } }
        public float Radius { get { return this.mRadius; } set { this.mRadius = value; } }
        public int Degree { get { return this.mDegree; } set { this.mDegree = value; } }

        /*******************************************/
        /*            Unity's function             */
        /*******************************************/
        private void Update()
        {
            DoRevolution();
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
        /// 
        /// </summary>
        private void DoRevolution()
        {
            if (mOrigin == null)
                return;

            switch (mAxis)
            {
                case JCS_Axis.AXIS_X:
                    {
                        if (mRevoluteAsLocalPosition)
                        {
                            this.transform.localPosition
                                = JCS_Mathf.CirclePositionX(
                                    this.mOrigin.localPosition,
                                    this.mDegree,
                                    this.mRadius,
                                    this.transform.localPosition);
                        }
                        else
                        {
                            this.transform.position
                                = JCS_Mathf.CirclePositionX(
                                    this.mOrigin.position,
                                    this.mDegree,
                                    this.mRadius,
                                    this.transform.position);
                        }
                    }
                    break;
                case JCS_Axis.AXIS_Y:
                    {
                        if (mRevoluteAsLocalPosition)
                        {
                            this.transform.localPosition
                                = JCS_Mathf.CirclePositionY(
                                    this.mOrigin.localPosition,
                                    this.mDegree,
                                    this.mRadius,
                                    this.transform.localPosition);
                        }
                        else
                        {
                            this.transform.position
                                = JCS_Mathf.CirclePositionY(
                                    this.mOrigin.position,
                                    this.mDegree,
                                    this.mRadius,
                                    this.transform.position);
                        }
                    }
                    break;
                case JCS_Axis.AXIS_Z:
                    {
                        if (mRevoluteAsLocalPosition)
                        {
                            this.transform.localPosition
                                = JCS_Mathf.CirclePositionZ(
                                    this.mOrigin.localPosition,
                                    this.mDegree,
                                    this.mRadius,
                                    this.transform.localPosition);
                        }
                        else
                        {
                            this.transform.position
                                = JCS_Mathf.CirclePositionZ(
                                    this.mOrigin.position,
                                    this.mDegree,
                                    this.mRadius,
                                    this.transform.position);
                        }
                    }
                    break;
            }
        }

    }
}
