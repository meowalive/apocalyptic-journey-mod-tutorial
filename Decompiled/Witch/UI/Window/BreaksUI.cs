using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mirror;
using Network.Query;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x020002A5 RID: 677
	public class BreaksUI : MonoBehaviour
	{
		// Token: 0x06001553 RID: 5459 RVA: 0x000A9834 File Offset: 0x000A7A34
		private void Awake()
		{
			this.startTime = Time.time;
			base.gameObject.GetComponent<Canvas>().overrideSorting = true;
			base.gameObject.GetComponent<Canvas>().worldCamera = Camera.main;
			WarehouseUI.ResetCount();
			bool flag = GameEntryUI.playerCount == 1;
			if (flag)
			{
				base.transform.Find("Break-Night/com/LeftBox").gameObject.SetActive(false);
			}
			base.transform.Find("Content/CloseRole/WhiteBack").GetComponent<SpriteRenderer>().DOFade(0f, 2f).SetLoops(-1, LoopType.Yoyo);
			RoleTable.Instance.SafeBoxGetMoneyCount = 5;
			Singleton<EventCenter>.Instance.EventTrigger("BreaksUIOpen");
			bool flag2 = MapManager.Instance.WinTheGame();
			if (flag2)
			{
				SafeBoxUI.ResetCount();
			}
			bool isServer = PlayerManager.Instance.isServer;
			if (isServer)
			{
				this.CreateFood();
			}
			else
			{
				PlayerManager.Instance.SendQuery<List<DataConfig>>(new QueryFood(), new Action<List<DataConfig>>(this.CreateFoodItem));
			}
			UIManager.Instance.CheckUI();
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x000A9944 File Offset: 0x000A7B44
		private void Start()
		{
			PlayerManager.Instance.SendQuery<ValueTuple<string, DataConfig>[]>(new QueryCareers(), new Action<ValueTuple<string, DataConfig>[]>(this.CreateRole));
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000A9964 File Offset: 0x000A7B64
		public void CreateRole(ValueTuple<string, DataConfig>[] roleList)
		{
			Transform tempParent = base.transform.Find("Content/RoleList/RolePre");
			tempParent.gameObject.SetActive(false);
			int i = 0;
			foreach (ValueTuple<string, DataConfig> item in roleList)
			{
				string id = item.Item1;
				DataConfig career = item.Item2;
				bool flag = id == null || career == null;
				if (!flag)
				{
					Transform tempItem = UnityEngine.Object.Instantiate<Transform>(tempParent, base.transform.Find("Content/RoleList"));
					tempItem.gameObject.SetActive(true);
					tempItem.Find("role").GetComponent<SceneRole>().Init(i, career, id, true);
					tempItem.SetAsFirstSibling();
					i++;
				}
			}
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000A9A2C File Offset: 0x000A7C2C
		public virtual void Close()
		{
			bool flag = UIManager.Instance.GetUI<CurtainTurnUI>("CurtainTurnUI") != null || this.hasClosed;
			if (!flag)
			{
				this.hasClosed = true;
				UIManager.Instance.ShowUI<CurtainTurnUI>("CurtainTurnUI", true).Play(delegate
				{
					bool flag2 = PlayerManager.Instance == null || MapManager.Instance.WinTheGame();
					if (flag2)
					{
						UIManager.Instance.ShowUI<GameExitUI>("GameExitUI", true);
						base.transform.Find("Break-Night/com/GlobalLight").gameObject.SetActive(false);
						UnityEngine.Object.Destroy(base.gameObject);
					}
					else
					{
						base.transform.Find("Break-Night/com/GlobalLight").gameObject.SetActive(false);
						UnityEngine.Object.Destroy(base.gameObject);
						GameApp.Instance.NowBackground.SetActive(true);
						MapManager.Instance.TryChange();
					}
				});
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000A9A8A File Offset: 0x000A7C8A
		public void ShowWarehouse()
		{
			UIManager.Instance.ShowUI<WarehouseUI>("WarehouseUI", true);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000A9A9E File Offset: 0x000A7C9E
		public void RelicBackPoint()
		{
			UIManager.Instance.ShowUI<SafeBoxUI>("SafeBoxUI", true);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
		public void ReturnHome()
		{
			bool flag = PlayerManager.Instance == null || (GameServer.Instance != null && GameServer.Instance.isServer);
			if (flag)
			{
				UIManager.Instance.ShowModalWindow("回归", "你确定要现在“回归”了吗？", delegate
				{
					UnityEngine.Object.Destroy(base.gameObject);
					UIManager.Instance.CloseUI("MapSelectUI");
					GameApp.Instance.GameOver();
				}, 1f, null, true, true, "Yes", "No", true);
			}
			else
			{
				UIManager.Instance.ShowModalWindow("无法回归", "你不是房主，请联系房主进行“回归”", null, 0f, null, true, true, "Yes", "No", true);
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000A9B54 File Offset: 0x000A7D54
		public void CreateFood()
		{
			int foodCount = 10;
			bool flag = GameEntryUI.playerCount != 1;
			if (flag)
			{
				foodCount += 15;
			}
			List<DataConfig> foodList = this.SelectBlessings(Singleton<GameConfigManager>.Instance.GetTable(DataType.Food).Getlines(), foodCount);
			SyncList<DataConfig> shares = PlayerManager.Instance.ShareFood;
			shares.Clear();
			foreach (DataConfig food in foodList)
			{
				shares.Add(food);
			}
			PlayerManager.Instance.SendQuery<List<DataConfig>>(new QueryFood(), new Action<List<DataConfig>>(this.CreateFoodItem));
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000A9C0C File Offset: 0x000A7E0C
		public void CreateFoodItem(List<DataConfig> foods)
		{
			Transform prefab = base.transform.Find("Break-Night/com/eatList/foodPre");
			Transform lastFood = prefab;
			foreach (DataConfig fooddata in foods)
			{
				Transform foodItem = UnityEngine.Object.Instantiate<Transform>(prefab, prefab.parent);
				foodItem.gameObject.GetComponent<FoodItem>().Init(fooddata);
				foodItem.gameObject.SetActive(true);
				foodItem.position = new Vector3(foodItem.GetComponent<SpriteRenderer>().sprite.bounds.size.x / 2f + lastFood.GetComponent<SpriteRenderer>().sprite.bounds.size.x / 2f + lastFood.position.x, foodItem.position.y, 0f);
				lastFood = foodItem;
				this.foodList.Add(foodItem.gameObject);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000A9D2C File Offset: 0x000A7F2C
		private List<DataConfig> SelectBlessings(List<Dictionary<string, string>> pool, int maxQuota)
		{
			List<DataConfig> result = new List<DataConfig>();
			result.Clear();
			int hasCount = 0;
			int remainingQuota = maxQuota;
			List<Dictionary<string, string>> shuffled = (from x in pool
			orderby Guid.NewGuid()
			select x).ToList<Dictionary<string, string>>();
			foreach (Dictionary<string, string> blessing in shuffled)
			{
				bool flag = int.Parse(blessing["Rarity"]) > remainingQuota;
				if (!flag)
				{
					hasCount++;
					result.Add(new DataConfig(blessing["Id"], DataType.Food));
					remainingQuota -= int.Parse(blessing["Rarity"]);
					bool flag2 = remainingQuota <= 0 || hasCount >= 8;
					if (flag2)
					{
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x040010ED RID: 4333
		private bool hasClosed = false;

		// Token: 0x040010EE RID: 4334
		public float startTime;

		// Token: 0x040010EF RID: 4335
		public List<GameObject> foodList = new List<GameObject>();
	}
}
