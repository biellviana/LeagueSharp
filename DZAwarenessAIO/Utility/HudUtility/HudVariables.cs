﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZAwarenessAIO.Properties;
using DZAwarenessAIO.Utility.HudUtility.HudElements;
using DZAwarenessAIO.Utility.MenuUtility;
using LeagueSharp.Common;
using SharpDX;

namespace DZAwarenessAIO.Utility.HudUtility
{
    class HudVariables
    {

        /// <summary>
        /// The list containing the hud elements
        /// </summary>
        public static List<HudElement> HudElements = new List<HudElement>(); 

        /// <summary>
        /// Gets or sets the hud sprite.
        /// </summary>
        /// <value>
        /// The hud sprite.
        /// </value>
        public static Render.Sprite HudSprite { get; set; }

        /// <summary>
        /// Gets or sets the expand button sprite.
        /// </summary>
        /// <value>
        /// The expand button.
        /// </value>
        public static Render.Sprite ExpandShrinkButton { get; set; }

        /// <summary>
        /// Gets the current position of the HUD.
        /// </summary>
        /// <value>
        /// The current position.
        /// </value>
        public static Vector2 CurrentPosition => IsDragging ? DraggingPosition : new Vector2(
            MenuExtensions.GetItemValue<Slider>("dz191.dza.hud.x").Value,
            MenuExtensions.GetItemValue<Slider>("dz191.dza.hud.y").Value
            );

        /// <summary>
        /// The dragging position of the hud
        /// </summary>
        public static Vector2 DraggingPosition = new Vector2();

        /// <summary>
        /// The HUD sprite width
        /// </summary>
        public static readonly float SpriteWidth = Resources.TFHelperBG.Width;

        /// <summary>
        /// The HUD sprite height
        /// </summary>
        public static readonly float SpriteHeight = Resources.TFHelperBG.Height;

        /// <summary>
        /// Indicates whether or not the hud is being dragged
        /// </summary>
        public static bool IsDragging = false;

        /// <summary>
        /// The cropped height of the sprite
        /// </summary>
        public const int CroppedHeight = 80;

        /// <summary>
        /// Gets a value indicating whether the hud should be visible
        /// </summary>
        /// <value>
        ///   <c>true</c> if the hud should be visible; otherwise, <c>false</c>.
        /// </value>
        public static bool ShouldBeVisible => MenuExtensions.GetItemValue<bool>("dz191.dza.hud.show");

        /// <summary>
        /// The current status of the hud
        /// </summary>
        public static SpriteStatus CurrentStatus = SpriteStatus.Shrinked;

    }
}