using System;
using System.Text;
using Cysharp.Text;
using TMPro;

namespace Witch.UI.Component
{
	// Token: 0x02000282 RID: 642
	public static class TMPNumberToSprite
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x0009F2A7 File Offset: 0x0009D4A7
		public static void SetDigitText(this TMP_Text tmp, string text)
		{
			tmp.text = TMPNumberToSprite.ConvertText(text);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0009F2B8 File Offset: 0x0009D4B8
		private static string ConvertText(string source)
		{
			StringBuilder sb = new StringBuilder();
			bool insideTag = false;
			foreach (char c in source)
			{
				bool flag = c == '<';
				if (flag)
				{
					insideTag = true;
					sb.Append(c);
				}
				else
				{
					bool flag2 = c == '>';
					if (flag2)
					{
						insideTag = false;
						sb.Append(c);
					}
					else
					{
						bool flag3 = !insideTag && char.IsDigit(c);
						if (flag3)
						{
							sb.Append(ZString.Format<object>("<sprite name=\"{0}\">", c));
						}
						else
						{
							bool flag4 = c == '*';
							if (flag4)
							{
								sb.Append("<sprite name=\"*\">");
							}
							else
							{
								sb.Append(c);
							}
						}
					}
				}
			}
			return sb.ToString();
		}
	}
}
