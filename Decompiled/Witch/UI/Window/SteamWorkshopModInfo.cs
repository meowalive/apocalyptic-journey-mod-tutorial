using System;
using System.Collections.Generic;
using Cysharp.Text;

namespace Witch.UI.Window
{
	// Token: 0x02000346 RID: 838
	[Serializable]
	public sealed class SteamWorkshopModInfo
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x000DF0DC File Offset: 0x000DD2DC
		public string WorkshopUrl
		{
			get
			{
				return ZString.Format<object>("https://steamcommunity.com/sharedfiles/filedetails/?id={0}", this.PublishedFileId);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x000DF0F3 File Offset: 0x000DD2F3
		public string PrimaryImageUrl
		{
			get
			{
				return (!string.IsNullOrWhiteSpace(this.CoverImageUrl)) ? this.CoverImageUrl : this.PreviewUrl;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000DF110 File Offset: 0x000DD310
		public string StatusText
		{
			get
			{
				bool isLoadedInGame = this.IsLoadedInGame;
				string result;
				if (isLoadedInGame)
				{
					result = "已安装并已载入";
				}
				else
				{
					bool isInstalled = this.IsInstalled;
					if (isInstalled)
					{
						result = "已安装";
					}
					else
					{
						bool isDownloading = this.IsDownloading;
						if (isDownloading)
						{
							result = "下载中";
						}
						else
						{
							bool isDownloadPending = this.IsDownloadPending;
							if (isDownloadPending)
							{
								result = "等待下载";
							}
							else
							{
								bool isSubscribed = this.IsSubscribed;
								if (isSubscribed)
								{
									result = "已订阅";
								}
								else
								{
									result = "未订阅";
								}
							}
						}
					}
				}
				return result;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x000DF18A File Offset: 0x000DD38A
		public string SummaryText
		{
			get
			{
				return ZString.Format<object, object, object>("赞成 {0}  反对 {1}  评分 {2:0.00}", this.VotesUp, this.VotesDown, this.Score);
			}
		}

		// Token: 0x04001412 RID: 5138
		public ulong PublishedFileId;

		// Token: 0x04001413 RID: 5139
		public string Title;

		// Token: 0x04001414 RID: 5140
		public string Description;

		// Token: 0x04001415 RID: 5141
		public string CoverImageUrl;

		// Token: 0x04001416 RID: 5142
		public string PreviewUrl;

		// Token: 0x04001417 RID: 5143
		public List<string> AdditionalPreviewUrls = new List<string>();

		// Token: 0x04001418 RID: 5144
		public string Metadata;

		// Token: 0x04001419 RID: 5145
		public string Tags;

		// Token: 0x0400141A RID: 5146
		public ulong OwnerId;

		// Token: 0x0400141B RID: 5147
		public string OwnerName;

		// Token: 0x0400141C RID: 5148
		public uint VotesUp;

		// Token: 0x0400141D RID: 5149
		public uint VotesDown;

		// Token: 0x0400141E RID: 5150
		public float Score;

		// Token: 0x0400141F RID: 5151
		public DateTime UpdatedAt;

		// Token: 0x04001420 RID: 5152
		public bool IsSubscribed;

		// Token: 0x04001421 RID: 5153
		public bool IsInstalled;

		// Token: 0x04001422 RID: 5154
		public bool IsDownloadPending;

		// Token: 0x04001423 RID: 5155
		public bool IsDownloading;

		// Token: 0x04001424 RID: 5156
		public bool IsLoadedInGame;

		// Token: 0x04001425 RID: 5157
		public string InstallDirectory;

		// Token: 0x04001426 RID: 5158
		public bool IsDownloadedToModsPath;

		// Token: 0x04001427 RID: 5159
		public string ModsInstallDirectory;

		// Token: 0x04001428 RID: 5160
		public bool IsLocalMod;

		// Token: 0x04001429 RID: 5161
		public bool LocalEnabled;

		// Token: 0x0400142A RID: 5162
		public string LocalDirectory;

		// Token: 0x0400142B RID: 5163
		public string LocalIconPath;
	}
}
