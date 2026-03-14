using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json;
using Steamworks;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000347 RID: 839
	public sealed class SteamWorkshopDownloadService
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x000DF1CB File Offset: 0x000DD3CB
		public static SteamWorkshopDownloadService Instance { get; } = new SteamWorkshopDownloadService();

		// Token: 0x06001A52 RID: 6738 RVA: 0x000DF1D4 File Offset: 0x000DD3D4
		public bool IsDownloading(ulong publishedFileId)
		{
			object obj = this.syncRoot;
			bool result;
			lock (obj)
			{
				result = this.activeDownloads.ContainsKey(publishedFileId);
			}
			return result;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000DF220 File Offset: 0x000DD420
		public bool IsDownloadedToMods(SteamWorkshopModInfo info)
		{
			bool flag = info == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string targetDirectory = this.GetModsTargetDirectory(info);
				result = (Directory.Exists(targetDirectory) && File.Exists(Path.Combine(targetDirectory, "ModConfig.json")));
			}
			return result;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000DF264 File Offset: 0x000DD464
		public string GetModsTargetDirectory(SteamWorkshopModInfo info)
		{
			bool flag = info == null;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = this.GetModsTargetDirectory(info.PublishedFileId);
			}
			return result;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000DF290 File Offset: 0x000DD490
		public string GetModsTargetDirectory(ulong publishedFileId)
		{
			string existingDirectory = this.FindDownloadedModDirectory(publishedFileId);
			bool flag = !string.IsNullOrWhiteSpace(existingDirectory);
			string result;
			if (flag)
			{
				result = existingDirectory;
			}
			else
			{
				result = Path.Combine(Globals.ModsPath, publishedFileId.ToString());
			}
			return result;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000DF2D0 File Offset: 0x000DD4D0
		public void CancelDownload(ulong publishedFileId)
		{
			object obj = this.syncRoot;
			CancellationTokenSource cancellationTokenSource;
			lock (obj)
			{
				bool flag2 = !this.activeDownloads.TryGetValue(publishedFileId, out cancellationTokenSource);
				if (flag2)
				{
					return;
				}
			}
			cancellationTokenSource.Cancel();
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000DF330 File Offset: 0x000DD530
		[DebuggerStepThrough]
		public UniTask ToggleDownloadAsync(SteamWorkshopModInfo info, Action<SteamWorkshopDownloadProgress> onProgress, CancellationToken cancellationToken)
		{
			SteamWorkshopDownloadService.<ToggleDownloadAsync>d__11 <ToggleDownloadAsync>d__ = new SteamWorkshopDownloadService.<ToggleDownloadAsync>d__11();
			<ToggleDownloadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ToggleDownloadAsync>d__.<>4__this = this;
			<ToggleDownloadAsync>d__.info = info;
			<ToggleDownloadAsync>d__.onProgress = onProgress;
			<ToggleDownloadAsync>d__.cancellationToken = cancellationToken;
			<ToggleDownloadAsync>d__.<>1__state = -1;
			<ToggleDownloadAsync>d__.<>t__builder.Start<SteamWorkshopDownloadService.<ToggleDownloadAsync>d__11>(ref <ToggleDownloadAsync>d__);
			return <ToggleDownloadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000DF38C File Offset: 0x000DD58C
		[DebuggerStepThrough]
		private UniTask DownloadToModsAsync(SteamWorkshopModInfo info, Action<SteamWorkshopDownloadProgress> onProgress, CancellationToken cancellationToken)
		{
			SteamWorkshopDownloadService.<DownloadToModsAsync>d__12 <DownloadToModsAsync>d__ = new SteamWorkshopDownloadService.<DownloadToModsAsync>d__12();
			<DownloadToModsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DownloadToModsAsync>d__.<>4__this = this;
			<DownloadToModsAsync>d__.info = info;
			<DownloadToModsAsync>d__.onProgress = onProgress;
			<DownloadToModsAsync>d__.cancellationToken = cancellationToken;
			<DownloadToModsAsync>d__.<>1__state = -1;
			<DownloadToModsAsync>d__.<>t__builder.Start<SteamWorkshopDownloadService.<DownloadToModsAsync>d__12>(ref <DownloadToModsAsync>d__);
			return <DownloadToModsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000DF3E8 File Offset: 0x000DD5E8
		[DebuggerStepThrough]
		private static UniTask<T> AwaitCallResultAsync<T>(SteamAPICall_t apiCall, CancellationToken cancellationToken) where T : struct
		{
			SteamWorkshopDownloadService.<AwaitCallResultAsync>d__13<T> <AwaitCallResultAsync>d__ = new SteamWorkshopDownloadService.<AwaitCallResultAsync>d__13<T>();
			<AwaitCallResultAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<AwaitCallResultAsync>d__.apiCall = apiCall;
			<AwaitCallResultAsync>d__.cancellationToken = cancellationToken;
			<AwaitCallResultAsync>d__.<>1__state = -1;
			<AwaitCallResultAsync>d__.<>t__builder.Start<SteamWorkshopDownloadService.<AwaitCallResultAsync>d__13<T>>(ref <AwaitCallResultAsync>d__);
			return <AwaitCallResultAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000DF434 File Offset: 0x000DD634
		private static bool TryGetInstalledWorkshopDirectory(PublishedFileId_t publishedFileId, out string modDirectory)
		{
			modDirectory = null;
			ulong num;
			string installFolder;
			uint num2;
			bool flag = !SteamUGC.GetItemInstallInfo(publishedFileId, out num, out installFolder, 2048U, out num2);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				modDirectory = (SteamWorkshopDownloadService.ResolveWorkshopModDirectory(installFolder) ?? installFolder);
				result = (!string.IsNullOrWhiteSpace(modDirectory) && Directory.Exists(modDirectory));
			}
			return result;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000DF48C File Offset: 0x000DD68C
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

		// Token: 0x06001A5C RID: 6748 RVA: 0x000DF520 File Offset: 0x000DD720
		private string CopyDirectoryToMods(string sourceDirectory, ulong publishedFileId)
		{
			string targetDirectory = this.BuildModsTargetDirectory(sourceDirectory, publishedFileId);
			bool flag = Directory.Exists(targetDirectory);
			if (flag)
			{
				Directory.Delete(targetDirectory, true);
			}
			SteamWorkshopDownloadService.CopyDirectoryRecursive(sourceDirectory, targetDirectory);
			File.WriteAllText(Path.Combine(targetDirectory, ".workshop-id"), publishedFileId.ToString());
			return targetDirectory;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000DF570 File Offset: 0x000DD770
		private string BuildModsTargetDirectory(string sourceDirectory, ulong publishedFileId)
		{
			string existingDirectory = this.FindDownloadedModDirectory(publishedFileId);
			bool flag = !string.IsNullOrWhiteSpace(existingDirectory);
			string result;
			if (flag)
			{
				result = existingDirectory;
			}
			else
			{
				string folderName = SteamWorkshopDownloadService.ResolveModFolderName(sourceDirectory);
				bool flag2 = string.IsNullOrWhiteSpace(folderName);
				if (flag2)
				{
					folderName = publishedFileId.ToString();
				}
				string targetDirectory = Path.Combine(Globals.ModsPath, folderName);
				bool flag3 = !Directory.Exists(targetDirectory);
				if (flag3)
				{
					result = targetDirectory;
				}
				else
				{
					string markerPath = Path.Combine(targetDirectory, ".workshop-id");
					bool flag4 = File.Exists(markerPath) && string.Equals(File.ReadAllText(markerPath).Trim(), publishedFileId.ToString(), StringComparison.Ordinal);
					if (flag4)
					{
						result = targetDirectory;
					}
					else
					{
						result = Path.Combine(Globals.ModsPath, ZString.Format<object, object>("{0}_{1}", folderName, publishedFileId));
					}
				}
			}
			return result;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000DF638 File Offset: 0x000DD838
		private static string ResolveModFolderName(string sourceDirectory)
		{
			string configPath = Path.Combine(sourceDirectory, "ModConfig.json");
			bool flag = File.Exists(configPath);
			if (flag)
			{
				try
				{
					WorkshopLocalModConfig modConfig = JsonConvert.DeserializeObject<WorkshopLocalModConfig>(File.ReadAllText(configPath));
					string sanitizedModName = SteamWorkshopDownloadService.SanitizeDirectoryName((modConfig != null) ? modConfig.ModName : null);
					bool flag2 = !string.IsNullOrWhiteSpace(sanitizedModName);
					if (flag2)
					{
						return sanitizedModName;
					}
				}
				catch (Exception exception)
				{
					Debug.LogWarning("[Mod] 读取下载 Mod 的 ModConfig 失败，回退为原目录名: " + exception.Message);
				}
			}
			string sourceFolderName = Path.GetFileName(sourceDirectory.TrimEnd(new char[]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar
			}));
			return SteamWorkshopDownloadService.SanitizeDirectoryName(sourceFolderName);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000DF6F4 File Offset: 0x000DD8F4
		private static string SanitizeDirectoryName(string folderName)
		{
			bool flag = string.IsNullOrWhiteSpace(folderName);
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				foreach (char invalidChar in Path.GetInvalidFileNameChars())
				{
					folderName = folderName.Replace(invalidChar, '_');
				}
				result = folderName.Trim().Trim('.');
			}
			return result;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000DF74C File Offset: 0x000DD94C
		private string FindDownloadedModDirectory(ulong publishedFileId)
		{
			bool flag = !Directory.Exists(Globals.ModsPath);
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				foreach (string directory in Directory.GetDirectories(Globals.ModsPath))
				{
					string markerPath = Path.Combine(directory, ".workshop-id");
					bool flag2 = File.Exists(markerPath) && string.Equals(File.ReadAllText(markerPath).Trim(), publishedFileId.ToString(), StringComparison.Ordinal);
					if (flag2)
					{
						return directory;
					}
					bool flag3 = string.Equals(Path.GetFileName(directory), publishedFileId.ToString(), StringComparison.Ordinal) && File.Exists(Path.Combine(directory, "ModConfig.json"));
					if (flag3)
					{
						return directory;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x000DF814 File Offset: 0x000DDA14
		private static void CopyDirectoryRecursive(string sourceDirectory, string targetDirectory)
		{
			Directory.CreateDirectory(targetDirectory);
			foreach (string filePath in Directory.GetFiles(sourceDirectory))
			{
				string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(filePath));
				File.Copy(filePath, targetFilePath, true);
			}
			foreach (string directoryPath in Directory.GetDirectories(sourceDirectory))
			{
				string targetSubDirectory = Path.Combine(targetDirectory, Path.GetFileName(directoryPath));
				SteamWorkshopDownloadService.CopyDirectoryRecursive(directoryPath, targetSubDirectory);
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x000DF89C File Offset: 0x000DDA9C
		private static bool HasFlag(EItemState state, EItemState flag)
		{
			return (state & flag) > EItemState.k_EItemStateNone;
		}

		// Token: 0x0400142C RID: 5164
		private const string WorkshopMarkerFileName = ".workshop-id";

		// Token: 0x0400142E RID: 5166
		private readonly Dictionary<ulong, CancellationTokenSource> activeDownloads = new Dictionary<ulong, CancellationTokenSource>();

		// Token: 0x0400142F RID: 5167
		private readonly object syncRoot = new object();
	}
}
