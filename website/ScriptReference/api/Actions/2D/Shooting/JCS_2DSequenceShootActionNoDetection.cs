﻿/**
 * $File: JCS_2DSequenceShootActionNoDetection.cs $
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
    /// Shoot a bullet toward the cursor position.
    /// </summary>
    [RequireComponent(typeof(JCS_ShootAction))]
    [RequireComponent(typeof(JCS_2DCursorShootAction))]
    public class JCS_2DSequenceShootActionNoDetection
        : MonoBehaviour
        , JCS_Action
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables
        [Header("** Check Variables (JCS_2DCursorShootAction) **")]
        [SerializeField]
        private JCS_ShootAction mShootAction = null;
        [SerializeField]
        private JCS_2DCursorShootAction mCursorShootAction = null;

        [Header("** Sequence Shoot Settings (JCS_2DCursorShootAction) **")]

        [Tooltip("How many shoot in sequence?")]
        [SerializeField]
        [Range(1, 30)]
        private int mHit = 8;

        [Tooltip("Time to a shoot in sequence.")]
        [SerializeField]
        [Range(0.01f, 0.5f)]
        private float mTimePerShoot = 0.1f;

        [Tooltip("")]
        [SerializeField]
        private bool mSequenceStay = true;

        [Tooltip("Keep all the bullet in the same angle per sequence.")]
        [SerializeField]
        private bool mKeepShootAngle = true;

        [Header("** Shoot Gap Effect (JCS_2DCursorShootAction) **")]

        [Tooltip("")]
        [SerializeField]
        private bool mShootGapEffect = false;

        [Tooltip("")]
        [SerializeField]
        private float mShootGap = 0.1f;


        //** Sequence Data **
        private JCS_Vector<int> mThread = null;        // main thread
        private JCS_Vector<float> mTimers = null;           // timer per thread
        private JCS_Vector<int> mShootCount = null;         // how many shoot should process per thread
        private JCS_Vector<int> mShootCounter = null;         // counter per thread
        private JCS_Vector<Vector3> mShootPos = null;
        private JCS_Vector<Vector3> mShootAngles = null;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------

        /// <summary>
        /// Call back during shooting a bullet.
        /// </summary>
        /// <param name="func"> function to set. </param>
        public void SetShootCallback(ShootCallback func)
        {
            this.mShootAction.SetShootCallback(func);
        }

        public void SetCheckAbleToShootFunction(CheckAbleToShoot func)
        {
            this.mShootAction.SetCheckAbleToShootFunction(func);
        }


        //========================================
        //      Unity's function
        //------------------------------
        private void Awake()
        {
            mShootAction = this.GetComponent<JCS_ShootAction>();
            mCursorShootAction = this.GetComponent<JCS_2DCursorShootAction>();

            // overwrite both shoot action, 
            // so they won't process the input.
            mShootAction.OverrideShoot = true;
            mCursorShootAction.OverrideShoot = true;

            mThread = new JCS_Vector<int>();
            mTimers = new JCS_Vector<float>();
            mShootCount = new JCS_Vector<int>();
            mShootCounter = new JCS_Vector<int>();
            mShootPos = new JCS_Vector<Vector3>();
            mShootAngles = new JCS_Vector<Vector3>();
        }

        private void Update()
        {
            ProcessInput();

            ProccessSequences();
        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        /// <summary>
        /// Shoot bullets in sequence queue.
        /// </summary>
        public void ShootsInSequence()
        {
            ShootsInSequence(mHit, this.transform.position);
        }
        /// <summary>
        /// Shoot bullets in sequence queue.
        /// </summary>
        /// <param name="hit"></param>
        /// <param name="pos"></param>
        public void ShootsInSequence(int hit, Vector3 pos)
        {
            if (mShootAction.Bullet == null)
            {
                JCS_Debug.LogReminders(
                    "There is no bullet assign to \"JCS_ShootAction\", so we cannot shoot a sequence...");

                return;
            }

            if (hit <= 0)
            {
                JCS_Debug.LogReminders(
                    "Cannot shoot sequence of bullet with lower than 0 hit...");

                return;
            }

            // thread itself
            mThread.push(mThread.length);

            // needed data
            mTimers.push(0);                // timer to calculate between each shoot.
            mShootCount.push(hit);          // hit per sequence.
            mShootCounter.push(0);          // counter to count how many shoot left?
            mShootPos.push(pos);            // position to spawn the bullet implements the position stay effect!
            mShootAngles.push(mShootAction.SpawnPoint.eulerAngles);

        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

        /// <summary>
        /// Process/Handle the inputs from the user.
        /// </summary>
        private void ProcessInput()
        {
            if (JCS_Input.GetMouseByAction(mShootAction.KeyAct, mShootAction.MouseButton) ||
                JCS_Input.GetKeyByAction(mShootAction.KeyAct, mShootAction.ShootKeyCode))
            {
                // check we are able to shoot.
                // like enough mana to cast? or something like this.
                if (mShootAction.GetCheckAbleToShootFunction().Invoke())
                {
                    // do callback
                    mShootAction.GetShootCallback().Invoke();

                    ShootsInSequence();
                }
            }
        }

        /// <summary>
        /// Process the sequence of threads queue.
        /// </summary>
        private void ProccessSequences()
        {
            for (int processIndex = 0;
                processIndex < mThread.length;
                ++processIndex)
            {
                // process all the thread
                Sequence(processIndex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processIndex"></param>
        private void Sequence(int processIndex)
        {
            // get the timer from the thread
            float newTimer = mTimers.at(processIndex);

            // add time to timer
            newTimer += Time.deltaTime;

            // check if we can shoot or not
            if (mTimePerShoot < newTimer)
            {
                int totalShootCount = mShootCount.at(processIndex);
                int currentShootCount = mShootCounter.at(processIndex);
                if (currentShootCount == totalShootCount)
                {
                    // Remove Thread.
                    EndProcessSequence(processIndex);
                    return;
                }

                Vector3 spawnPos = this.transform.position;
                Vector3 shootAngle = this.mShootAction.SpawnPoint.eulerAngles;

                // if stay in the same position
                if (mSequenceStay)
                    spawnPos = mShootPos.at(processIndex);

                if (mShootGapEffect)
                    spawnPos.y += currentShootCount * mShootGap;

                if (mKeepShootAngle)
                    shootAngle = mShootAngles.at(processIndex);

                // do shooting
                mShootAction.ShootWithShootCount(spawnPos, shootAngle);

                ++currentShootCount;

                // update new count, in order 
                // to spawn next bullet
                mShootCounter.set(processIndex, currentShootCount);
                newTimer = 0;
            }

            // update timer
            mTimers.set(processIndex, newTimer);
        }

        /// <summary>
        /// End the thread, kill the process.
        /// </summary>
        /// <param name="processIndex"> thread id to kill. </param>
        private void EndProcessSequence(int processIndex)
        {
            mThread.slice(processIndex);

            mTimers.slice(processIndex);
            mShootCount.slice(processIndex);
            mShootCounter.slice(processIndex);
            mShootPos.slice(processIndex);
            mShootAngles.slice(processIndex);
        }

    }
}
