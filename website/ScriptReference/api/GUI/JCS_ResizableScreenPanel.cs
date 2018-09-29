/**
 * $File: JCS_ResizableScreenPanel.cs $
 * $Date: 2018-09-07 22:05:46 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright © 2018 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace JCSUnity
{
    /// <summary>
    /// Resizable screen panel, the invisible area of the screen.
    /// </summary>
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(Image))]
    public class JCS_ResizableScreenPanel
        : MonoBehaviour
    {

        /*******************************************/
        /*            Public Variables             */
        /*******************************************/

        /*******************************************/
        /*           Private Variables             */
        /*******************************************/

        private RectTransform mRectTransform = null;
        private Image mImage = null;


        [Header("** Check Variables (JCS_AspectScreenPanel) **")]

        [Tooltip("Type of the Aspect screen panel direction.")]
        [SerializeField]
        private JCS_2D4Direction mPlaceDirection = JCS_2D4Direction.TOP;

        /*******************************************/
        /*           Protected Variables           */
        /*******************************************/

        /*******************************************/
        /*             setter / getter             */
        /*******************************************/
        public Image image { get { return this.mImage; } }
        public RectTransform sRectTransform { get { return this.mRectTransform; } }
        public JCS_2D4Direction PlaceDirection { get { return this.mPlaceDirection; } set { this.mPlaceDirection = value; } }

        /*******************************************/
        /*            Unity's function             */
        /*******************************************/
        private void Awake()
        {
            this.mRectTransform = this.GetComponent<RectTransform>();
            this.mImage = this.GetComponent<Image>();
        }

        private void Start()
        {
            // Set the canvas to be our root.
            this.transform.SetParent(JCS_Canvas.instance.transform);

            // Add panel root without losing the original size.
            {
                Vector2 originalSize = mRectTransform.sizeDelta;

                this.gameObject.AddComponent<JCS_PanelRoot>();

                mRectTransform.sizeDelta = originalSize;
            }

            SetToScreenEdge();
        }

        private void LateUpdate()
        {
            JCS_Utility.MoveToTheLastChild(this.mRectTransform);
        }

        /*******************************************/
        /*              Self-Define                */
        /*******************************************/
        //----------------------
        // Public Functions

        /// <summary>
        /// Show the panel.
        /// </summary>
        public void ShowPanel()
        {
            this.mImage.enabled = true;
        }

        /// <summary>
        /// Hide the panel.
        /// </summary>
        public void HidePanel()
        {
            this.mImage.enabled = false;
        }

        //----------------------
        // Protected Functions

        //----------------------
        // Private Functions

        /// <summary>
        /// Set the panel to the edge of the screen.
        /// </summary>
        private void SetToScreenEdge()
        {
            JCS_ScreenSettings ss = JCS_ScreenSettings.instance;

            Vector2 halfAppRect = (new Vector2(ss.STARTING_SCREEN_WIDTH, ss.STARTING_SCREEN_HEIGHT)) / 2.0f;

            float halfScreenWidth = (mRectTransform.sizeDelta.x / 2.0f) + halfAppRect.x;
            float halfScreenHeight = (mRectTransform.sizeDelta.y / 2.0f) + halfAppRect.y;


            Vector3 newPos = mRectTransform.localPosition;

            switch (mPlaceDirection)
            {
                case JCS_2D4Direction.TOP:
                    {
                        newPos.y += halfScreenHeight;
                    }
                    break;
                case JCS_2D4Direction.BOTTOM:
                    {
                        newPos.y -= halfScreenHeight;
                    }
                    break;
                case JCS_2D4Direction.LEFT:
                    {
                        newPos.x -= halfScreenWidth;
                    }
                    break;
                case JCS_2D4Direction.RIGHT:
                    {
                        newPos.x += halfScreenWidth;
                    }
                    break;
            }

            mRectTransform.localPosition = newPos;
        }

    }
}
