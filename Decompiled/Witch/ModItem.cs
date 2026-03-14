using System;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Michsky.MUIP;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Witch.UI.Window;

namespace Witch
{
	// Token: 0x0200024C RID: 588
	public class ModItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06001303 RID: 4867 RVA: 0x00095C48 File Offset: 0x00093E48
		public void Init(SteamWorkshopModInfo fromdata, bool inShopList = false)
		{
			this.data = fromdata;
			this.InShopList = inShopList;
			Image icon = base.transform.Find("Icon").GetComponent<Image>();
			bool flag = this.defaultSprite == null;
			if (flag)
			{
				this.defaultSprite = icon.sprite;
			}
			this.mainSprite = this.defaultSprite;
			icon.sprite = this.defaultSprite;
			base.transform.Find("Name").GetComponent<TMP_Text>().SetText(this.data.Title);
			this.SetupActionControls();
			this.RefreshActionButtonText();
			this.LoadPreviewImage().Forget();
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00095CF4 File Offset: 0x00093EF4
		public void OnPointerClick(PointerEventData eventData)
		{
			this.modManager.InitDes(this);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00095D04 File Offset: 0x00093F04
		public void OnClickDownloadButton()
		{
			bool flag = this.data == null;
			if (!flag)
			{
				bool flag2 = !this.InShopList;
				if (flag2)
				{
					this.OnLocalEnableToggleChanged(!this.data.LocalEnabled);
				}
				else
				{
					ModItem.DownloadService.ToggleDownloadAsync(this.data, new Action<SteamWorkshopDownloadProgress>(this.UpdateDownloadProgress), this.GetCancellationTokenOnDestroy()).Forget();
				}
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00095D70 File Offset: 0x00093F70
		private void UpdateDownloadProgress(SteamWorkshopDownloadProgress progress)
		{
			bool flag = progress == null;
			if (!flag)
			{
				switch (progress.State)
				{
				case SteamWorkshopDownloadState.Preparing:
					this.SetDownloadButtonText("准备下载");
					break;
				case SteamWorkshopDownloadState.Downloading:
					this.SetDownloadButtonText(string.IsNullOrWhiteSpace(progress.Message) ? "停止" : ("停止 " + progress.Message));
					break;
				case SteamWorkshopDownloadState.Stopping:
					this.SetDownloadButtonText("停止中");
					break;
				case SteamWorkshopDownloadState.Stopped:
					this.SetDownloadButtonText("下载");
					break;
				case SteamWorkshopDownloadState.Completed:
				{
					this.data.IsDownloadedToModsPath = true;
					this.data.ModsInstallDirectory = progress.TargetDirectory;
					this.SetDownloadButtonText("下载完");
					bool flag2 = this.modManager != null;
					if (flag2)
					{
						this.modManager.HasChangeMod = true;
					}
					ModManagerUI modManagerUI = this.modManager;
					if (modManagerUI != null)
					{
						modManagerUI.RefreshLocalModList();
					}
					break;
				}
				case SteamWorkshopDownloadState.Error:
					this.SetDownloadButtonText(progress.Message);
					break;
				}
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00095E80 File Offset: 0x00094080
		private void RefreshDownloadButtonText()
		{
			bool flag = this.data == null;
			if (!flag)
			{
				bool flag2 = !this.InShopList;
				if (flag2)
				{
					this.RefreshLocalToggleState();
				}
				else
				{
					this.data.IsDownloadedToModsPath = ModItem.DownloadService.IsDownloadedToMods(this.data);
					bool isDownloadedToModsPath = this.data.IsDownloadedToModsPath;
					if (isDownloadedToModsPath)
					{
						this.data.ModsInstallDirectory = ModItem.DownloadService.GetModsTargetDirectory(this.data);
						this.SetDownloadButtonText("下载完");
					}
					else
					{
						bool flag3 = ModItem.DownloadService.IsDownloading(this.data.PublishedFileId);
						if (flag3)
						{
							this.SetDownloadButtonText("停止");
						}
						else
						{
							this.SetDownloadButtonText("下载");
						}
					}
				}
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00095F43 File Offset: 0x00094143
		public void RefreshActionButtonText()
		{
			this.RefreshDownloadButtonText();
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00095F50 File Offset: 0x00094150
		public void OnLocalEnableToggleChanged(bool isOn)
		{
			bool flag = this.syncingLocalToggleState || this.data == null || this.InShopList;
			if (!flag)
			{
				bool flag2 = isOn == this.data.LocalEnabled;
				if (!flag2)
				{
					ModManagerUI modManagerUI = this.modManager;
					if (modManagerUI != null)
					{
						modManagerUI.ToggleLocalMod(this.data);
					}
					bool flag3 = this.LocalEnableToggle != null && this.data.LocalEnabled != isOn;
					if (flag3)
					{
						this.syncingLocalToggleState = true;
						this.LocalEnableToggle.SetIsOnWithoutNotify(this.data.LocalEnabled);
						this.syncingLocalToggleState = false;
					}
				}
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00095FF8 File Offset: 0x000941F8
		private void SetupActionControls()
		{
			bool flag = this.DownButton != null;
			if (flag)
			{
				this.DownButton.gameObject.SetActive(this.InShopList);
			}
			bool flag2 = this.LocalEnableToggle == null;
			if (!flag2)
			{
				this.LocalEnableToggle.onValueChanged.RemoveListener(new UnityAction<bool>(this.OnLocalEnableToggleChanged));
				this.LocalEnableToggle.gameObject.SetActive(!this.InShopList);
				bool flag3 = !this.InShopList;
				if (flag3)
				{
					this.RefreshLocalToggleState();
					this.LocalEnableToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnLocalEnableToggleChanged));
				}
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000960AC File Offset: 0x000942AC
		private void RefreshLocalToggleState()
		{
			bool flag = this.LocalEnableToggle == null || this.data == null;
			if (!flag)
			{
				this.syncingLocalToggleState = true;
				this.LocalEnableToggle.SetIsOnWithoutNotify(this.data.LocalEnabled);
				this.syncingLocalToggleState = false;
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00096100 File Offset: 0x00094300
		private void SetDownloadButtonText(string text)
		{
			bool flag = this.DownButton != null;
			if (flag)
			{
				this.DownButton.SetText(text);
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00096130 File Offset: 0x00094330
		[DebuggerStepThrough]
		private UniTaskVoid LoadPreviewImage()
		{
			ModItem.<LoadPreviewImage>d__19 <LoadPreviewImage>d__ = new ModItem.<LoadPreviewImage>d__19();
			<LoadPreviewImage>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
			<LoadPreviewImage>d__.<>4__this = this;
			<LoadPreviewImage>d__.<>1__state = -1;
			<LoadPreviewImage>d__.<>t__builder.Start<ModItem.<LoadPreviewImage>d__19>(ref <LoadPreviewImage>d__);
			return <LoadPreviewImage>d__.<>t__builder.Task;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00096174 File Offset: 0x00094374
		private void LoadLocalPreviewImage()
		{
			bool flag = string.IsNullOrWhiteSpace(this.data.LocalIconPath) || !ResourceLoader.Exists(this.data.LocalIconPath, false);
			if (!flag)
			{
				try
				{
					this.mainSprite = ResourceLoader.Load<Sprite>(this.data.LocalIconPath, false);
					bool flag2 = this.mainSprite != null;
					if (flag2)
					{
						base.transform.Find("Icon").GetComponent<Image>().sprite = this.mainSprite;
					}
				}
				catch (Exception exception)
				{
					Debug.LogWarning("加载本地 Mod 图标失败: " + exception.Message);
				}
			}
		}

		// Token: 0x04000F6C RID: 3948
		private static readonly SteamWorkshopDownloadService DownloadService = SteamWorkshopDownloadService.Instance;

		// Token: 0x04000F6D RID: 3949
		public ModManagerUI modManager;

		// Token: 0x04000F6E RID: 3950
		public SteamWorkshopModInfo data;

		// Token: 0x04000F6F RID: 3951
		public Sprite mainSprite;

		// Token: 0x04000F70 RID: 3952
		public ButtonManager DownButton;

		// Token: 0x04000F71 RID: 3953
		public Toggle LocalEnableToggle;

		// Token: 0x04000F72 RID: 3954
		private Sprite defaultSprite;

		// Token: 0x04000F73 RID: 3955
		private bool syncingLocalToggleState;

		// Token: 0x04000F74 RID: 3956
		public bool InShopList = false;
	}
}
