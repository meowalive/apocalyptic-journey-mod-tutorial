using System;
using Cysharp.Text;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Witch.UI.Window
{
	// Token: 0x0200030C RID: 780
	public class HouseUI : MonoBehaviour
	{
		// Token: 0x0600185F RID: 6239 RVA: 0x000CDA68 File Offset: 0x000CBC68
		private void Awake()
		{
			HouseUI.CanScroll = true;
			this.globalLight = GameObject.Find("GlobalLight");
			this.globalLight.SetActive(false);
			base.transform.Find("globallight").gameObject.SetActive(true);
			Singleton<EventCenter>.Instance.EventTrigger("HouseUIOpen");
			DOTween.Init(null, null, null);
			this.targetCamera = Camera.main;
			this.oriCameraPos = this.targetCamera.transform.position;
			GameApp.Instance.SetSteamRichState("AtMainMenu");
			base.transform.Find("House/Task/task/Level/level").GetComponent<TMP_Text>().text = Singleton<GameRuntimeData>.Instance.Level.ToString();
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000CDB48 File Offset: 0x000CBD48
		private void Update()
		{
			bool flag = UIManager.Instance == null || this.houseRect == null || this.targetCamera == null || Mouse.current == null;
			if (!flag)
			{
				bool flag2 = UIManager.Instance.GetUI<DialogueUI>("DialogueUI") != null;
				if (!flag2)
				{
					bool flag3 = this.IsNull("Object") || !base.gameObject.activeInHierarchy || !HouseUI.CanScroll;
					if (!flag3)
					{
						float scroll = Mouse.current.scroll.ReadValue().y;
						bool flag4 = Mathf.Abs(scroll) > 0.01f;
						if (flag4)
						{
							float currentScale = this.houseRect.localScale.x;
							float newScale = Mathf.Clamp(currentScale + scroll * this.zoomSpeed, this.minScale, this.maxScale);
							this.houseRect.localScale = new Vector3(newScale, newScale, newScale);
							this.AdjustCameraWithinBounds();
						}
						bool wasReleasedThisFrame = Mouse.current.leftButton.wasReleasedThisFrame;
						if (wasReleasedThisFrame)
						{
							this.isDragging = false;
						}
						bool wasPressedThisFrame = Mouse.current.leftButton.wasPressedThisFrame;
						if (wasPressedThisFrame)
						{
							this.isDragging = true;
							this.prevMousePos = Mouse.current.position.ReadValue();
						}
						bool flag5 = this.isDragging;
						if (flag5)
						{
							Vector2 currentMousePos = Mouse.current.position.ReadValue();
							Vector2 delta = currentMousePos - this.prevMousePos;
							Vector3 movement = new Vector3(-delta.x * this.xfactor, -delta.y * this.yfactor, 0f);
							Vector3 newCamPos = this.targetCamera.transform.position + movement;
							newCamPos = this.ClampCameraPosition(newCamPos);
							Vector3 velocity = Vector3.zero;
							this.targetCamera.transform.position = newCamPos;
							this.prevMousePos = currentMousePos;
						}
					}
				}
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000CDD4C File Offset: 0x000CBF4C
		private void AdjustCameraWithinBounds()
		{
			Vector3 currentCamPos = this.targetCamera.transform.position;
			this.targetCamera.transform.position = this.ClampCameraPosition(currentCamPos);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000CDD84 File Offset: 0x000CBF84
		private Vector3 ClampCameraPosition(Vector3 camPos)
		{
			SpriteRenderer backgroundRenderer = base.transform.Find("Background").GetComponent<SpriteRenderer>();
			Bounds bounds = backgroundRenderer.bounds;
			float cameraHeight = 2f * Mathf.Tan(this.targetCamera.fieldOfView * 0.5f * 0.017453292f) * Mathf.Abs(camPos.z - 4f);
			float cameraWidth = cameraHeight * this.targetCamera.aspect;
			float minX = bounds.min.x + cameraWidth / 2f;
			float maxX = bounds.max.x - cameraWidth / 2f;
			float minY = bounds.min.y + cameraHeight / 2f;
			float maxY = bounds.max.y - cameraHeight / 2f;
			camPos.x = Mathf.Clamp(camPos.x, minX, maxX);
			camPos.y = Mathf.Clamp(camPos.y, minY, maxY);
			camPos.z = -5f;
			return camPos;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000CDE8C File Offset: 0x000CC08C
		public void ShadowChat()
		{
			bool flag = !Singleton<GameRuntimeData>.Instance.IsTutorialCompleted.ContainsKey("FirstTalk");
			if (flag)
			{
				Singleton<EventCenter>.Instance.EventTrigger("FirstTalk");
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000CDEC7 File Offset: 0x000CC0C7
		public void StartShop()
		{
			UIManager.Instance.ShowUI<OutsiderShopUI>("OutsiderShopUI", true);
			this.isDragging = false;
			HouseUI.CanScroll = false;
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000CDEE8 File Offset: 0x000CC0E8
		public void OnClickCardEditor()
		{
			HouseUI.CanScroll = false;
			this.isDragging = false;
			UIManager.Instance.ShowUI<CardEditorUI>("CardEditorUI", true).onEdited = delegate(DataConfig dataConfig)
			{
				bool flag = Singleton<GameRuntimeData>.Instance.Truth < 50 * int.Parse(dataConfig.data["Rarity"]);
				if (flag)
				{
					UIManager.Instance.ShowModalWindow("费用不足", ZString.Format<object>("你当前的真理之晶不足以购买该卡牌（需要{0}真理之晶）", 50 * int.Parse(dataConfig.data["Rarity"])), null, 0f, null, true, false, "Yes", "No", true);
				}
				else
				{
					Singleton<GameRuntimeData>.Instance.Truth -= 50 * int.Parse(dataConfig.data["Rarity"]);
					Singleton<GameRuntimeData>.Instance.CardData.Add(dataConfig);
					Singleton<GameRuntimeData>.Instance.Save();
				}
			};
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000CDF37 File Offset: 0x000CC137
		public void OpenStorehouse()
		{
			this.storehouseUI.Show();
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000CDF46 File Offset: 0x000CC146
		public void OpenDictionary()
		{
			HouseUI.CanScroll = false;
			this.isDragging = false;
			UIManager.Instance.ShowUI<DictionaryUI>("DictionaryUI", true);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000CDF67 File Offset: 0x000CC167
		public void OnClickMod()
		{
			UIManager.Instance.ShowUI<ModManagerUI>("ModManagerUI", true);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000CDF7C File Offset: 0x000CC17C
		public void ReturnMenu()
		{
			bool flag = !GameServer.EndCommit;
			if (flag)
			{
				UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("请等待结算完成,这可能需要一点时间", CaptionStyle.Top, 3f, 1.5f, 3);
			}
			else
			{
				bool flag2 = UIManager.Instance.GetUI<ModeChoiceUI>("ModeChoiceUI") != null;
				if (!flag2)
				{
					AudioManager instance = AudioManager.Instance;
					if (instance != null)
					{
						instance.PlayEffect("NewSounds/电梯门开启");
					}
					HouseUI.CanScroll = false;
					this.isDragging = false;
					UIManager.Instance.ShowUI<ModeChoiceUI>("ModeChoiceUI", true).Init();
				}
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000CE014 File Offset: 0x000CC214
		public void ClickItem(HouseItem.HouseItemType houseItemType)
		{
			switch (houseItemType)
			{
			case HouseItem.HouseItemType.CardEditor:
				this.OnClickCardEditor();
				break;
			case HouseItem.HouseItemType.OutsiderShop:
				this.StartShop();
				break;
			case HouseItem.HouseItemType.ModManager:
				this.OnClickMod();
				break;
			case HouseItem.HouseItemType.GameMenu:
				this.ReturnMenu();
				break;
			case HouseItem.HouseItemType.store:
				this.OpenStorehouse();
				break;
			case HouseItem.HouseItemType.Dictionary:
				this.OpenDictionary();
				break;
			case HouseItem.HouseItemType.shadow:
				this.ShadowChat();
				break;
			case HouseItem.HouseItemType.announcement:
				this.OpenAnnouncement();
				break;
			case HouseItem.HouseItemType.task:
				UIManager.Instance.ShowUI<TaskUI>("TaskUI", true);
				break;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000CE0B3 File Offset: 0x000CC2B3
		public void OpenAnnouncement()
		{
			UIManager.Instance.ShowUI<AnnouncementUI>("AnnouncementUI", true).ShowAnnouncement();
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000CE0CC File Offset: 0x000CC2CC
		public void OnDestroy()
		{
			bool flag = this.targetCamera != null;
			if (flag)
			{
				this.targetCamera.transform.position = this.oriCameraPos;
			}
			Singleton<EventCenter>.Instance.Clear(this);
			base.transform.Find("globallight").gameObject.SetActive(false);
			this.globalLight.SetActive(true);
		}

		// Token: 0x0400131C RID: 4892
		public StorehouseUI storehouseUI;

		// Token: 0x0400131D RID: 4893
		[UnityInject(false)]
		public RectTransform houseRect;

		// Token: 0x0400131E RID: 4894
		public static bool CanScroll = true;

		// Token: 0x0400131F RID: 4895
		public Camera targetCamera;

		// Token: 0x04001320 RID: 4896
		private Vector3 oriCameraPos;

		// Token: 0x04001321 RID: 4897
		private GameObject globalLight;

		// Token: 0x04001322 RID: 4898
		private bool isDragging = false;

		// Token: 0x04001323 RID: 4899
		[SerializeField]
		private float cameraSmooth = 12f;

		// Token: 0x04001324 RID: 4900
		[SerializeField]
		private float xfactor = 0.01f;

		// Token: 0x04001325 RID: 4901
		[SerializeField]
		private float yfactor = 0.01f;

		// Token: 0x04001326 RID: 4902
		private Vector2 prevMousePos;

		// Token: 0x04001327 RID: 4903
		public float minScale = 1f;

		// Token: 0x04001328 RID: 4904
		private float maxScale = 2f;

		// Token: 0x04001329 RID: 4905
		private float zoomSpeed = 0.1f;
	}
}
