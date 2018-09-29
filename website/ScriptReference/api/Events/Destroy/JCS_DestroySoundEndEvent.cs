﻿/**
 * $File: JCS_DestroySoundEndEvent.cs $
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
    /// Play the sound and destroy the game object itself.
    /// </summary>
    [RequireComponent(typeof(JCS_SoundPlayer))]
    public class JCS_DestroySoundEndEvent
        : MonoBehaviour
    {

        //----------------------
        // Public Variables

        //----------------------
        // Private Variables
        private JCS_SoundPlayer mSoundPlayer = null;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------
        public void SetAudioClipAndPlayOneShot(AudioClip clip, JCS_SoundSettingType type)
        {
            if (mSoundPlayer == null)
                mSoundPlayer = this.GetComponent<JCS_SoundPlayer>();

            this.mSoundPlayer.GetAudioSource().clip = clip;
            this.mSoundPlayer.PlayOneShot(clip, type);
        }

        //========================================
        //      Unity's function
        //------------------------------
        private void Update()
        {
            if (mSoundPlayer.GetAudioSource().isPlaying)
                return;

            Destroy(this.gameObject);
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
