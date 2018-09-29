﻿/**
 * $File: JCS_GUITextPool.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


namespace JCSUnity
{
    /// <summary>
    /// Text pool using Unity Engine's UGUI system.
    /// </summary>
    public class JCS_GUITextPool
        : MonoBehaviour
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables

        [Header("** Initialize Variables (JCS_GUITextPool) **")]

        [Tooltip("")]
        [SerializeField]
        private JCS_LogText mLogText = null;

        [SerializeField] [Range(3, 50)]
        private int mNumberOfHandle = 10;

        // optimize
        private int mLastSpawnPos = 0;

        private JCS_Vector<JCS_LogText> mLogTexts = null;

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
            SpawnTextPool();
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

        /// <summary>
        /// Spawn the text pool base on number of handle.
        /// </summary>
        private void SpawnTextPool()
        {
            if (mLogText == null)
            {
                JCS_Debug.LogReminders( 
                    "No log text assign in the text pool...");

                return;
            }


            // NOTE(JenChieh): this might change in
            // the future.
            // Get the log system from the 
            // same transfrom/node.
            JCS_IGLogSystem logSystem = this.GetComponent<JCS_IGLogSystem>();


            mLogTexts = new JCS_Vector<JCS_LogText>(mNumberOfHandle);

            for (int count = 0;
                count < mNumberOfHandle;
                ++count)
            {
                // spawn a new game object, 
                // and get the component
                JCS_LogText logText = (JCS_LogText)JCS_Utility.SpawnGameObject(mLogText);

                // add to array
                mLogTexts.set(count, logText);

                // set parent
                JCS_Utility.SetParentWithoutLosingInfo(logText.transform, this.transform);

                // NOTE(JenChieh): this might change in
                // the future.
                // set the log system if there is one.
                logText.SetIGLogSystem(logSystem);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="secondSearch"></param>
        /// <returns></returns>
        public JCS_LogText ExecuteOneFromPool(bool secondSearch = false)
        {
            if (mNumberOfHandle == 0)
                return null;

            JCS_LogText logText;

            // loop through and see any not active 
            // log text we can use in the pool
            for (int index = mLastSpawnPos;
                index < mNumberOfHandle;
                ++index)
            {
                logText = mLogTexts.at(index);

                // if not active, meaning we can 
                // active the log text
                if (!logText.isActive())
                {
                    // set the last spawn count
                    mLastSpawnPos = index;

                    return logText;
                }

            }

            // if we get here mean we cycle once but we
            // did not spawn a text!
            // so reset the spawn pos and 
            // try to search agian until we find one!
            mLastSpawnPos = 0;

            // if function call the second time, 
            // and try to call the third time, 
            // exit the function call.
            // so prevent "stack overflow 
            // search/infinite function call".
            // IMPORTANT(JenChieh): it wont spawn damage text this time, 
            // if this happens.
            if (secondSearch)
            {
#if (UNITY_EDITOR)
                if (JCS_GameSettings.instance.DEBUG_MODE)
                {
                    JCS_Debug.LogWarning(
                        "Prevent, stack overflow function call.");
                }
#endif
                return null;
            }

            // dangerious, use carefully!
            // make sure u have enough number of handle
            // or else the program might crash? (too many delay?)
            return ExecuteOneFromPool(true);
        }

    }
}
