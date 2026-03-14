using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Steamworks;

namespace Witch.UI.Window
{
	// Token: 0x0200033F RID: 831
	public sealed class SteamWorkshopBrowser
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x000DE5B0 File Offset: 0x000DC7B0
		[DebuggerStepThrough]
		public UniTask<SteamWorkshopQueryResult> QueryAllModsAsync(string searchText, CancellationToken cancellationToken)
		{
			SteamWorkshopBrowser.<QueryAllModsAsync>d__0 <QueryAllModsAsync>d__ = new SteamWorkshopBrowser.<QueryAllModsAsync>d__0();
			<QueryAllModsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SteamWorkshopQueryResult>.Create();
			<QueryAllModsAsync>d__.<>4__this = this;
			<QueryAllModsAsync>d__.searchText = searchText;
			<QueryAllModsAsync>d__.cancellationToken = cancellationToken;
			<QueryAllModsAsync>d__.<>1__state = -1;
			<QueryAllModsAsync>d__.<>t__builder.Start<SteamWorkshopBrowser.<QueryAllModsAsync>d__0>(ref <QueryAllModsAsync>d__);
			return <QueryAllModsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000DE604 File Offset: 0x000DC804
		[DebuggerStepThrough]
		private UniTask<SteamWorkshopQueryPage> QueryPageAsync(uint page, string searchText, CancellationToken cancellationToken)
		{
			SteamWorkshopBrowser.<QueryPageAsync>d__1 <QueryPageAsync>d__ = new SteamWorkshopBrowser.<QueryPageAsync>d__1();
			<QueryPageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SteamWorkshopQueryPage>.Create();
			<QueryPageAsync>d__.<>4__this = this;
			<QueryPageAsync>d__.page = page;
			<QueryPageAsync>d__.searchText = searchText;
			<QueryPageAsync>d__.cancellationToken = cancellationToken;
			<QueryPageAsync>d__.<>1__state = -1;
			<QueryPageAsync>d__.<>t__builder.Start<SteamWorkshopBrowser.<QueryPageAsync>d__1>(ref <QueryPageAsync>d__);
			return <QueryPageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000DE660 File Offset: 0x000DC860
		private static SteamWorkshopModInfo BuildItem(UGCQueryHandle_t handle, uint index, SteamUGCDetails_t details)
		{
			PublishedFileId_t publishedFileId = details.m_nPublishedFileId;
			EItemState itemState = (EItemState)SteamUGC.GetItemState(publishedFileId);
			bool isInstalled = SteamWorkshopBrowser.HasFlag(itemState, EItemState.k_EItemStateInstalled);
			bool isSubscribed = SteamWorkshopBrowser.HasFlag(itemState, EItemState.k_EItemStateSubscribed);
			bool isDownloadPending = SteamWorkshopBrowser.HasFlag(itemState, EItemState.k_EItemStateDownloadPending);
			bool isDownloading = SteamWorkshopBrowser.HasFlag(itemState, EItemState.k_EItemStateDownloading);
			string previewUrl = string.Empty;
			string tempPreviewUrl;
			bool queryUGCPreviewURL = SteamUGC.GetQueryUGCPreviewURL(handle, index, out tempPreviewUrl, 2048U);
			if (queryUGCPreviewURL)
			{
				previewUrl = tempPreviewUrl;
			}
			List<string> additionalPreviewUrls = new List<string>();
			uint additionalPreviewCount = SteamUGC.GetQueryUGCNumAdditionalPreviews(handle, index);
			for (uint previewIndex = 0U; previewIndex < additionalPreviewCount; previewIndex += 1U)
			{
				string additionalPreviewUrl;
				string text;
				EItemPreviewType previewType;
				bool flag = !SteamUGC.GetQueryUGCAdditionalPreview(handle, index, previewIndex, out additionalPreviewUrl, 2048U, out text, 512U, out previewType);
				if (!flag)
				{
					bool flag2 = previewType > EItemPreviewType.k_EItemPreviewType_Image;
					if (!flag2)
					{
						bool flag3 = !string.IsNullOrWhiteSpace(additionalPreviewUrl);
						if (flag3)
						{
							additionalPreviewUrls.Add(additionalPreviewUrl);
						}
					}
				}
			}
			bool flag4 = string.IsNullOrWhiteSpace(previewUrl) && additionalPreviewUrls.Count > 0;
			if (flag4)
			{
				previewUrl = additionalPreviewUrls[0];
			}
			string metadata = string.Empty;
			string tempMetadata;
			bool queryUGCMetadata = SteamUGC.GetQueryUGCMetadata(handle, index, out tempMetadata, 2048U);
			if (queryUGCMetadata)
			{
				metadata = tempMetadata;
			}
			string installDirectory = string.Empty;
			bool loadedInGame = false;
			ulong num;
			string installFolder;
			uint num2;
			bool itemInstallInfo = SteamUGC.GetItemInstallInfo(publishedFileId, out num, out installFolder, 2048U, out num2);
			if (itemInstallInfo)
			{
				installDirectory = (SteamWorkshopBrowser.ResolveWorkshopModDirectory(installFolder) ?? installFolder);
				loadedInGame = SteamWorkshopBrowser.IsLoadedInGame(installDirectory);
			}
			string ownerName = SteamFriends.GetFriendPersonaName(new CSteamID(details.m_ulSteamIDOwner));
			bool flag5 = string.IsNullOrWhiteSpace(ownerName);
			if (flag5)
			{
				ownerName = details.m_ulSteamIDOwner.ToString();
			}
			return new SteamWorkshopModInfo
			{
				PublishedFileId = details.m_nPublishedFileId.m_PublishedFileId,
				Title = details.m_rgchTitle,
				Description = details.m_rgchDescription,
				CoverImageUrl = previewUrl,
				PreviewUrl = previewUrl,
				AdditionalPreviewUrls = additionalPreviewUrls,
				Metadata = metadata,
				Tags = details.m_rgchTags,
				OwnerId = details.m_ulSteamIDOwner,
				OwnerName = ownerName,
				VotesUp = details.m_unVotesUp,
				VotesDown = details.m_unVotesDown,
				Score = details.m_flScore,
				UpdatedAt = DateTimeOffset.FromUnixTimeSeconds((long)((ulong)details.m_rtimeUpdated)).LocalDateTime,
				IsSubscribed = isSubscribed,
				IsInstalled = isInstalled,
				IsDownloadPending = isDownloadPending,
				IsDownloading = isDownloading,
				IsLoadedInGame = loadedInGame,
				InstallDirectory = installDirectory
			};
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x000DE8D0 File Offset: 0x000DCAD0
		private static bool IsLoadedInGame(string installDirectory)
		{
			bool flag = string.IsNullOrWhiteSpace(installDirectory) || Singleton<GameConfigManager>.Instance == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string normalized = SteamWorkshopBrowser.NormalizePath(installDirectory);
				foreach (ModConfig modConfig in Singleton<GameConfigManager>.Instance.modConfigs)
				{
					bool flag2 = SteamWorkshopBrowser.NormalizePath(modConfig.DirectoryName) == normalized;
					if (flag2)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000DE96C File Offset: 0x000DCB6C
		private static string ResolveWorkshopModDirectory(string installFolder)
		{
			bool flag = string.IsNullOrWhiteSpace(installFolder) || !Directory.Exists(installFolder);
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				string configPath = Path.Combine(installFolder, "ModConfig.json");
				bool flag2 = File.Exists(configPath);
				if (flag2)
				{
					result = installFolder;
				}
				else
				{
					foreach (string childDirectory in Directory.GetDirectories(installFolder, "*", SearchOption.AllDirectories))
					{
						bool flag3 = File.Exists(Path.Combine(childDirectory, "ModConfig.json"));
						if (flag3)
						{
							return childDirectory;
						}
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000DEA00 File Offset: 0x000DCC00
		private static string NormalizePath(string path)
		{
			return ((path != null) ? path.Replace('\\', '/').TrimEnd('/').ToLowerInvariant() : null) ?? string.Empty;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000DEA38 File Offset: 0x000DCC38
		private static bool HasFlag(EItemState state, EItemState flag)
		{
			return (state & flag) > EItemState.k_EItemStateNone;
		}

		// Token: 0x02000340 RID: 832
		private sealed class WorkshopQueryCall
		{
			// Token: 0x06001A3F RID: 6719 RVA: 0x000DEA50 File Offset: 0x000DCC50
			public WorkshopQueryCall(UGCQueryHandle_t handle)
			{
				this.handle = handle;
				this.callResult = CallResult<SteamUGCQueryCompleted_t>.Create(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(this.OnCompleted));
			}

			// Token: 0x06001A40 RID: 6720 RVA: 0x000DEA84 File Offset: 0x000DCC84
			public UniTask<SteamUGCQueryCompleted_t> SendAsync(CancellationToken cancellationToken)
			{
				SteamAPICall_t apiCall = SteamUGC.SendQueryUGCRequest(this.handle);
				this.callResult.Set(apiCall, null);
				bool canBeCanceled = cancellationToken.CanBeCanceled;
				if (canBeCanceled)
				{
					cancellationToken.Register(delegate()
					{
						this.completionSource.TrySetCanceled(cancellationToken);
					});
				}
				return this.completionSource.Task;
			}

			// Token: 0x06001A41 RID: 6721 RVA: 0x000DEAF8 File Offset: 0x000DCCF8
			private void OnCompleted(SteamUGCQueryCompleted_t callback, bool ioFailure)
			{
				if (ioFailure)
				{
					this.completionSource.TrySetException(new InvalidOperationException("Steam UGC 查询 I/O 失败。"));
				}
				else
				{
					this.completionSource.TrySetResult(callback);
				}
			}

			// Token: 0x040013EB RID: 5099
			private readonly UGCQueryHandle_t handle;

			// Token: 0x040013EC RID: 5100
			private readonly UniTaskCompletionSource<SteamUGCQueryCompleted_t> completionSource = new UniTaskCompletionSource<SteamUGCQueryCompleted_t>();

			// Token: 0x040013ED RID: 5101
			private readonly CallResult<SteamUGCQueryCompleted_t> callResult;
		}
	}
}
