using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace XLua.TemplateEngine
{
	// Token: 0x02000192 RID: 402
	public class Parser
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0005E10E File Offset: 0x0005C30E
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x0005E115 File Offset: 0x0005C315
		public static string RegexString { get; private set; } = Parser.GetRegexString();

		/// <summary>
		/// Replaces special characters with their literal representation.
		/// </summary>
		/// <returns>Resulting string.</returns>
		/// <param name="input">Input string.</param>
		// Token: 0x06000BCC RID: 3020 RVA: 0x0005E12C File Offset: 0x0005C32C
		private static string EscapeString(string input)
		{
			return input.Replace("\\", "\\\\").Replace("'", "\\'").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\t", "\\t").Replace("\r", "\\r").Replace("\b", "\\b").Replace("\f", "\\f").Replace("\a", "\\a").Replace("\v", "\\v").Replace("\0", "\\0");
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		private static string GetRegexString()
		{
			string regexBadUnopened = "(?<error>((?!<%).)*%>)";
			string regexText = "(?<text>((?!<%).)+)";
			string regexNoCode = "(?<nocode><%=?%>)";
			string regexCode = "<%(?<code>[^=]((?!<%|%>).)*)%>";
			string regexEval = "<%=(?<eval>((?!<%|%>).)*)%>";
			string regexBadUnclosed = "(?<error><%.*)";
			string regexBadEmpty = "(?<error>^$)";
			return string.Concat(new string[]
			{
				"(",
				regexBadUnopened,
				"|",
				regexText,
				"|",
				regexNoCode,
				"|",
				regexCode,
				"|",
				regexEval,
				"|",
				regexBadUnclosed,
				"|",
				regexBadEmpty,
				")*"
			});
		}

		/// <summary>
		/// Parses the string into regex groups, 
		/// stores group:value pairs in List of Chunk
		/// <returns>List of group:value pairs.</returns>;
		/// </summary>
		// Token: 0x06000BCE RID: 3022 RVA: 0x0005E29C File Offset: 0x0005C49C
		public static List<Chunk> Parse(string snippet)
		{
			Regex templateRegex = new Regex(Parser.RegexString, RegexOptions.ExplicitCapture | RegexOptions.Singleline);
			Match matches = templateRegex.Match(snippet);
			bool flag = matches.Groups["error"].Length > 0;
			if (flag)
			{
				throw new TemplateFormatException("Messed up brackets");
			}
			List<Chunk> Chunks = (from p in (from Capture p in matches.Groups["code"].Captures
			select new
			{
				Type = TokenType.Code,
				Value = p.Value,
				Index = p.Index
			}).Concat(from Capture p in matches.Groups["text"].Captures
			select new
			{
				Type = TokenType.Text,
				Value = Parser.EscapeString(p.Value),
				Index = p.Index
			}).Concat(from Capture p in matches.Groups["eval"].Captures
			select new
			{
				Type = TokenType.Eval,
				Value = p.Value,
				Index = p.Index
			})
			orderby p.Index
			select p into m
			select new Chunk(m.Type, m.Value)).ToList<Chunk>();
			bool flag2 = Chunks.Count == 0;
			if (flag2)
			{
				throw new TemplateFormatException("Empty template");
			}
			return Chunks;
		}
	}
}
