﻿/**
 * $File: JCS_GameWindow.cs $
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
    /// Game Window base on the Dialogue object.
    /// 
    /// Specialize class for panel/dialogue object. This class provide 
    /// more than just the normal panel/dialogue interface.
    /// </summary>
    public class JCS_GameWindow 
        : MonoBehaviour
    {

        //----------------------
        // Public Variables


        //----------------------
        // Private Variables
        private enum DragDrop
        {
            Drag,
            Drop
        };

        private JCS_DialogueObject mDialogueObject = null;


        [Header("** Initialize Variables (JCS_GameWindow) **")]

        [Tooltip("")]
        [SerializeField]
        private JCS_DragDropType mType = JCS_DragDropType.DialogueBox;

        //----------------------
        // Protected Variables

        //========================================
        //      setter / getter
        //------------------------------

        //========================================
        //      Unity's function
        //------------------------------
        public void Awake()
        {
            mDialogueObject = this.GetComponent<JCS_DialogueObject>();
        }

        //========================================
        //      Self-Define
        //------------------------------
        //----------------------
        // Public Functions

        /// <summary>
        /// 
        /// </summary>
        public void JCS_PointerDown()
        {
            mDialogueObject.MoveToTheLastChild();
            if (mDialogueObject.GetDialogueType() == JCS_DialogueType.PLAYER_DIALOGUE)
                JCS_UIManager.instance.SetJCSDialogue(JCS_DialogueType.PLAYER_DIALOGUE, mDialogueObject);
        }

        /// <summary>
        /// 
        /// </summary>
        public void JCS_Click()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void JCS_OnDrag()
        {

            switch (mType)
            {
                case JCS_DragDropType.DialogueBox:
                    ProcessGUI(DragDrop.Drag);
                    break;

                case JCS_DragDropType.Inventory:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void JCS_OnDrop()
        {

        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        private void ProcessGUI(DragDrop type)
        {
            switch (type)
            {
                // Process Drag
                case DragDrop.Drag:
                    Vector3 delta = JCS_Input.MouseDeltaPosition();
                    this.transform.localPosition += delta;
                    break;

                // Process Drop
                case DragDrop.Drop:
                    break;
            }
        }

    }
}
