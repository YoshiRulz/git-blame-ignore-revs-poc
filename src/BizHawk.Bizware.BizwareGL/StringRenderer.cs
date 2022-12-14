//http://www.angelcode.com/products/bmfont/
//http://cyotek.com/blog/angelcode-bitmap-font-parsing-using-csharp

using System;
using System.Collections.Generic;
using System.IO;
using Cyotek.Drawing.BitmapFont;
using sd=System.Drawing;

namespace BizHawk.Bizware.BizwareGL
{
	public class StringRenderer : IDisposable
	{
		public StringRenderer(IGL owner, Stream xml, params Stream[] textures)
		{
			Owner = owner;
			FontInfo = new();
			FontInfo.LoadXml(xml);
			
			// load textures
			for(int i=0;i<FontInfo.Pages.Length;i++)
			{
				TexturePages.Add(owner.LoadTexture(textures[i]));
			}
		}

		public void Dispose()
		{
			foreach (var tex in TexturePages)
				tex.Dispose();
			TexturePages = null;
		}

		public sd.SizeF Measure(string str)
		{
			float x = 0;
			float y = FontInfo.LineHeight;
			float ox = x;
			int len = str.Length;

			for (int i = 0; i < len; i++)
			{
				var c = str[i];

				if (c == '\r')
				{
					if (i != len - 1 && str[i + 1] == '\n')
						i++;
				}

				if (c == '\r')
				{
					c = '\n';
				}

				if (c == '\n')
				{
					if (x > ox)
						ox = x;
					x = 0;
					y += FontInfo.LineHeight;
					continue;
				}

				var bfc = FontInfo[c];

				x += bfc.XAdvance;
			}

			return new sd.SizeF(Math.Max(x, ox), y);
		}

		public void RenderString(IGuiRenderer renderer, float x, float y, string str)
		{
			float ox = x;
			int len = str.Length;

			for (int i = 0; i < len; i++)
			{
				var c = str[i];

				if (c == '\r')
				{
					if (i != len - 1 && str[i + 1] == '\n')
						i++;
				}

				if (c == '\r')
				{
					c = '\n';
				}

				if(c == '\n')
				{
					x = ox;
					y += FontInfo.LineHeight;
					continue;
				}

				var bfc = FontInfo[c];
				
				// calculate texcoords (we shouldve already had this cached, but im speedcoding now)
				Texture2d tex = TexturePages[bfc.TexturePage];
				float w = tex.Width;
				float h = tex.Height;
				sd.Rectangle bounds = new(bfc.X, bfc.Y, bfc.Width, bfc.Height);
				float u0 = bounds.Left / w;
				float v0 = bounds.Top / h;
				float u1 = bounds.Right / w;
				float v1 = bounds.Bottom / h;

				float gx = x + bfc.XOffset;
				float gy = y + bfc.YOffset;
				renderer.DrawSubrect(tex, gx, gy, bfc.Width, bfc.Height, u0, v0, u1, v1);

				x += bfc.XAdvance;
			}
		}

		public IGL Owner { get; }

		private readonly BitmapFont FontInfo;
		private List<Texture2d> TexturePages = new List<Texture2d>();
	}
}