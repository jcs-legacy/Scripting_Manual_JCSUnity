/**
 * $File: JCS_PushThrowAction.cs $
 * $Date: 2016-11-04 23:28:10 $
 * $Revision: $
 * $Creator: Tony Wei & Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using UnityEngine;
using System.Collections;


namespace JCSUnity
{
    /// <summary>
    /// Do the throw action like "Plants vs Zombies"'s 
    /// corn plants. 
    /// 
    /// Base on the angle only. Push force does not change.
    /// </summary>
    public class JCS_PushThrowAction
        : MonoBehaviour
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

        private Vector3 mVelocity = Vector3.zero;

        [Header("** Runtime Variables (JCS_PushThrowAction) **")]

        [Tooltip("Do effect?")]
        [SerializeField]
        private bool mEffect = false;

        [Tooltip("Angle u want to throw to.")]
        [SerializeField]
        private float mAngle = 0;

        [Tooltip("Speed of this projectile. ")]
        [SerializeField]
        private float mG = 2;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------
        public bool Effect { get { return this.mEffect; } set { this.mEffect = value; } }

        //========================================
        //      Unity's function
        //------------------------------
        private void Update()
        {
            // check do the effect or not?
            if (!mEffect)
                return;

            this.mVelocity.y -= mG * Time.deltaTime;
            this.transform.position += this.mVelocity * Time.deltaTime;
        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        /// <summary>
        /// Call this function to start the projectile.
        /// </summary>
        /// <param name="start"> start position </param>
        /// <param name="target"> target position </param>
        public void SetStart(Vector3 start, Vector3 target)
        {
            SetStart(start, target, mG);
        }

        /// <summary>
        /// Call this function to start the projectile.
        /// </summary>
        /// <param name="start"> start position </param>
        /// <param name="target"> target position </param>
        /// <param name="force"> speed to the target </param>
        public void SetStart(Vector3 start, Vector3 target, float force)
        {
            SetStart(start, target, mAngle, force);
        }

        /// <summary>
        /// Call this function to start the projectile.
        /// </summary>
        /// <param name="start"> start position </param>
        /// <param name="target"> target position </param>
        /// <param name="angle"> angle u want to shoot </param>
        /// <param name="force"> speed to the target </param>
        public void SetStart(Vector3 start, Vector3 target, float angle, float force)
        {
            // set the starting position.
            this.transform.position = start;

            // get the force.
            this.mG = force;

            //calculate start velocity
            float tan = Mathf.Tan(angle * Mathf.Deg2Rad);
            float h = Mathf.Abs(start.y - target.y);
            float w = Mathf.Abs(target.x - start.x);


            float vX = Mathf.Sqrt((force * w * w) / (2 * (h + w * tan)));
            float vY = tan * vX;

            vX = (target.x - start.x) < 0 ? vX : -vX;
            this.mVelocity = new Vector2(-vX, vY);
        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

    }
}
