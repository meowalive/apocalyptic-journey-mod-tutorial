using System;

namespace XLua.TemplateEngine
{
	// Token: 0x02000190 RID: 400
	public class Chunk
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0005E0D0 File Offset: 0x0005C2D0
		public TokenType Type { get; private set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0005E0D9 File Offset: 0x0005C2D9
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0005E0E1 File Offset: 0x0005C2E1
		public string Text { get; private set; }

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0005E0EA File Offset: 0x0005C2EA
		public Chunk(TokenType type, string text)
		{
			this.Type = type;
			this.Text = text;
		}
	}
}
