using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CardGame
{
	public class TextBox : UIElement
    {
		// FIELDS =================================================================================================================
		private Button okButton;
		private SpriteFont font;
		private int maxLineWidth;
		private string text;
		private bool show;
		private int margin;

		// PROPERTIES =============================================================================================================
		public Button BoxButton
		{
			get { return okButton; }
		}

		public int MaxLineWidth
		{
			get { return maxLineWidth; }
			set { maxLineWidth = value; }
		}

		public bool Show
		{
			get { return show; }
			set { show = value; }
		}

		// CONSTRUCTOR ============================================================================================================
		public TextBox(Texture2D sprite, Rectangle position, Button okButton, SpriteFont font, int maxLineWidth, string text) : base(sprite, position)
		{
			this.okButton = okButton;
			this.font = font;
			margin = 15;
			this.maxLineWidth = maxLineWidth - margin;
			this.text = text;
			show = false;
		}

		public TextBox(Texture2D sprite, Rectangle position, SpriteFont font, int maxLineWidth, string text) : base(sprite, position)
        {
			this.okButton = null;
			this.font = font;
			margin = 15;
			this.maxLineWidth = maxLineWidth - margin;
			this.text = text;
			show = false;
        }

		// METHODS ================================================================================================================
		/// <summary>
		/// Wrap a given text within the dialog box
		/// </summary>
		/// <param name="text">The text to wrap</param>
		/// <returns>A wrapped tetx that will fit inside the dialog box</returns>
		public string WrapText(string text)
		{
			if (font.MeasureString(text).X < MaxLineWidth)
			{
				return text;
			}

			string[] words = text.Split(' ');
			StringBuilder wrappedText = new StringBuilder();
			float linewidth = 0f;
			float spaceWidth = font.MeasureString(" ").X;
			for (int i = 0; i < words.Length; ++i)
			{
				Vector2 size = font.MeasureString(words[i]);
				if (linewidth + size.X < MaxLineWidth)
				{
					linewidth += size.X + spaceWidth;
				}
				else
				{
					wrappedText.Append("\n");
					linewidth = size.X + spaceWidth;
				}
				wrappedText.Append(words[i]);
				wrappedText.Append(" ");
			}

			return wrappedText.ToString();
		}

		/// <summary>
		/// Draw the button
		/// </summary>
		/// <param name="sb">The SpriteBatch</param>
		/// <param name="boxColor">The color of the box</param>
		/// <param name="textColor">The color of the text</param>
		public void Draw(SpriteBatch sb, Color boxColor, Color textColor)
		{
			sb.Draw(sprite, position, boxColor);

			// Wrap Text
			string wrappedText = WrapText(text);

			// Create Vector from Rectangle
			Vector2 positionVec = new Vector2(position.X + margin, position.Y);

			// Draw the text within the box
			sb.DrawString(font, wrappedText, positionVec, textColor);
		}

		public void Draw(SpriteBatch sb, string enterText, Rectangle bounds, Alignment align, Color boxColor, Color textColor)
		{
			sb.Draw(sprite, position, boxColor);

			// Create centralized location
			Vector2 size = font.MeasureString(enterText);
			Vector2 positionVec = new Vector2(bounds.Center.X, bounds.Center.Y);
			Vector2 origin = size * 0.5f;

			// Check alignments
			if (align.HasFlag(Alignment.Left))
			{
				origin.X += bounds.Width / 2 - size.X / 2;
			}

			if (align.HasFlag(Alignment.Right))
			{
				origin.X -= bounds.Width / 2 - size.X / 2;
			}

			if (align.HasFlag(Alignment.Top))
			{
				origin.Y += bounds.Height / 2 - size.Y / 2;
			}

			if (align.HasFlag(Alignment.Bottom))
			{
				origin.Y -= bounds.Height / 2 - size.Y / 2;
			}

			// Draw the text within the box
			sb.DrawString(font, enterText, positionVec, textColor, 0, origin, 1, SpriteEffects.None, 0);
		}
	}
}
