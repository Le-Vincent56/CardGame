using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardGame
{
    public class UIElement
    {
        // FIELDS =================================================================================================================
        protected Texture2D sprite;
        protected Rectangle position;

        // PROPERTIES =============================================================================================================
        public Rectangle Position
        {
            get { return position; }
        }

        public int X
        {
            get { return position.X; }
            set { position.X = value; }
        }

        public int Y
        {
            get { return position.Y; }
            set { position.Y = value; }
        }

        // CONSTRUCTOR ============================================================================================================
        public UIElement(Texture2D sprite, Rectangle position)
        {
            this.sprite = sprite;
            this.position = position;
        }

        // METHODS ================================================================================================================
        /// <summary>
        /// Draw the UI Element
        /// </summary>
        /// <param name="sb">The SpriteBatch</param>
        public void Draw(SpriteBatch sb)
        {
            sb.Draw(sprite, position, Color.White);
        }
    }
}
