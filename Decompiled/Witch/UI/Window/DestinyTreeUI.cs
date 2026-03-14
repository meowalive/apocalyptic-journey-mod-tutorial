using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Data.Save;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZLinq;
using ZLinq.Linq;

namespace Witch.UI.Window
{
	// Token: 0x020002C3 RID: 707
	public class DestinyTreeUI : ShopUI
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000B1158 File Offset: 0x000AF358
		public int Cost
		{
			[DebuggerStepThrough]
			get
			{
				Modifiable modifiable = new Modifiable();
				MethodContext methodContext = RougamoPool<MethodContext>.Get();
				methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
				{
					modifiable
				};
				methodContext.Target = this;
				methodContext.TargetType = typeof(DestinyTreeUI);
				methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DestinyTreeUI.get_Cost()).MethodHandle, typeof(DestinyTreeUI).TypeHandle);
				methodContext.Arguments = new object[0];
				int num;
				try
				{
					modifiable.OnEntry(methodContext);
					if (methodContext.ReturnValueReplaced)
					{
						num = (int)methodContext.ReturnValue;
						modifiable.OnExit(methodContext);
					}
					else
					{
						do
						{
							try
							{
								num = this.$Rougamo_get_Cost();
							}
							catch (Exception exception)
							{
								methodContext.Exception = exception;
								modifiable.OnException(methodContext);
								if (methodContext.RetryCount > 0)
								{
									continue;
								}
								bool exceptionHandled = methodContext.ExceptionHandled;
								if (exceptionHandled)
								{
									num = (int)methodContext.ReturnValue;
								}
								modifiable.OnExit(methodContext);
								if (exceptionHandled)
								{
									goto IL_10D;
								}
								throw;
							}
							methodContext.ReturnValue = num;
							modifiable.OnSuccess(methodContext);
						}
						while (methodContext.RetryCount > 0);
						if (methodContext.ReturnValueReplaced)
						{
							num = (int)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						IL_10D:;
					}
				}
				finally
				{
					RougamoPool<MethodContext>.Return(methodContext);
				}
				return num;
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000B129C File Offset: 0x000AF49C
		[DebuggerStepThrough]
		public override void DataUpdate()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DestinyTreeUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DestinyTreeUI.DataUpdate()).MethodHandle, typeof(DestinyTreeUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_DataUpdate();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000B1398 File Offset: 0x000AF598
		[DebuggerStepThrough]
		private void Start()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DestinyTreeUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DestinyTreeUI.Start()).MethodHandle, typeof(DestinyTreeUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Start();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000B1494 File Offset: 0x000AF694
		[DebuggerStepThrough]
		public void Divination()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DestinyTreeUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DestinyTreeUI.Divination()).MethodHandle, typeof(DestinyTreeUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_Divination();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x000B1590 File Offset: 0x000AF790
		[DebuggerStepThrough]
		public void GenerateBless()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(DestinyTreeUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(DestinyTreeUI.GenerateBless()).MethodHandle, typeof(DestinyTreeUI).TypeHandle);
			methodContext.Arguments = new object[0];
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					do
					{
						try
						{
							this.$Rougamo_GenerateBless();
						}
						catch (Exception exception)
						{
							methodContext.Exception = exception;
							modifiable.OnException(methodContext);
							if (methodContext.RetryCount > 0)
							{
								continue;
							}
							bool exceptionHandled = methodContext.ExceptionHandled;
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_C8;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C8:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000B168C File Offset: 0x000AF88C
		public override void SetShopItems()
		{
			bool flag = RoleTable.Instance.BuyBlessCount > 6;
			if (flag)
			{
				this.Increasing = 50;
				bool flag2 = RoleTable.Instance.BuyBlessCount > 9;
				if (flag2)
				{
					this.Increasing = 70;
				}
			}
			foreach (object obj in this.ShopTran)
			{
				Transform item = (Transform)obj;
				bool flag3 = item.name == "Item";
				if (!flag3)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			List<Dictionary<string, string>> blessing = (from x in Singleton<GameConfigManager>.Instance.GetTable(DataType.Bless).Getlines().AsValueEnumerable<Dictionary<string, string>>()
			where int.Parse(x["Rarity"]) < 3
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
			blessing = new RandomPool(blessing, base.dice).DrawByRarity(RoleTable.Instance.BuyBlessCount + 3);
			bool flag4 = this.ItemPrefab.GetComponent<ShopItem>() == null;
			if (flag4)
			{
				this.ItemPrefab.AddComponent<ShopItem>();
			}
			for (int i = 0; i < RoleTable.Instance.BuyBlessCount + 3; i++)
			{
				GameObject item2 = Singleton<ObjectPool>.Instance.Get(this.ItemPrefab, this.ItemPrefab.transform.parent);
				item2.SetActive(true);
				item2.name = "Blessing" + (i + 1).ToString();
				ShopItem blessingItem = item2.GetComponent<ShopItem>();
				string id = blessing[i]["Id"];
				GameSaveAnalyser.Instance.TryPush(blessing[i]["Name"], OperObj.Blessings, OperType.ShopShow);
				blessingItem.itemId = id;
				blessingItem.ItemType = "Bless";
				blessingItem.shop = this;
				bool flag5 = blessingItem == null;
				if (flag5)
				{
					blessingItem = item2.AddComponent<ShopItem>();
				}
				blessingItem.Init(new DataConfig(id, DataType.Bless));
			}
			GameObject RanBless = Singleton<ObjectPool>.Instance.Get(this.ItemPrefab, this.ItemPrefab.transform.parent);
			RanBless.SetActive(true);
			RanBless.name = "RandomBlessing";
			ShopItem RanBlessingItem = RanBless.GetComponent<ShopItem>();
			bool flag6 = RanBlessingItem == null;
			if (flag6)
			{
				RanBlessingItem = RanBless.AddComponent<ShopItem>();
			}
			RanBlessingItem.ItemType = "RandomBlessing";
			RanBlessingItem.shop = this;
			RanBlessingItem.Init();
			RanBlessingItem.itemPrice = this.Cost;
			RanBlessingItem.UpdateItem();
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000B1961 File Offset: 0x000AFB61
		private int $Rougamo_get_Cost()
		{
			return this.InitCost + RoleTable.Instance.BuyBlessCount * this.Increasing;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000B197C File Offset: 0x000AFB7C
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Content/List View Custom/Title").GetComponent<TMP_Text>().text = "Shop".Localize("ShopUI");
			base.transform.Find("Content/Backpack/Title").GetComponent<TMP_Text>().text = "Back".Localize("ShopUI");
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000B19E0 File Offset: 0x000AFBE0
		private void $Rougamo_Start()
		{
			bool flag = UIManager.Instance.GetUI<EventUI>("EventUI") == null;
			if (flag)
			{
				GameApp.Instance.NowBackground.SetActive(true);
			}
			bool flag2 = RoleTable.Instance.BuyBlessCount > 6;
			if (flag2)
			{
				this.Increasing = 50;
				bool flag3 = RoleTable.Instance.BuyBlessCount > 9;
				if (flag3)
				{
					this.Increasing = 70;
				}
			}
			base.transform.Find("Content/Backpack/Money/text").GetComponent<TMP_Text>().text = RoleTable.Instance.Money.ToString();
			bool flag4 = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
			if (flag4)
			{
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").HideLeftUp();
				UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.SetAsLastSibling();
			}
			((INotifyPropertyChanged)RoleTable.Instance).PropertyChanged += base.OnRoleTableChanged;
			this.DataUpdate();
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x000B1AF0 File Offset: 0x000AFCF0
		private void $Rougamo_Divination()
		{
			bool flag = RoleTable.Instance.Money >= this.Cost;
			if (flag)
			{
				RoleTable.Instance.BuyBlessCount++;
				bool flag2 = RoleTable.Instance.BuyBlessCount > 6;
				if (flag2)
				{
					this.Increasing = 50;
					bool flag3 = RoleTable.Instance.BuyBlessCount > 9;
					if (flag3)
					{
						this.Increasing = 70;
					}
				}
				this.GenerateBless();
			}
			else
			{
				UIManager.Instance.GetUI<CaptionUI>("CaptionUI").ShowCaption("金钱不足", CaptionStyle.Top, 3f, 1.5f, 3);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000B1B98 File Offset: 0x000AFD98
		private void $Rougamo_GenerateBless()
		{
			bool canget = true;
			GameObject obj = UnityEngine.Object.Instantiate<GameObject>(ResourceLoader.Load("UI/BlessChoice") as GameObject, base.transform);
			Transform Tran = obj.transform.Find("Window Manager/Windows/牌堆/Content/List View Custom/List");
			List<Tuple<List<DataConfig>, List<DataConfig>>> List1 = UIManager.Instance.GetUI<BackpackUI>("BackpackUI").statusUI.GenerateThreeOptions();
			for (int i = 0; i < 3; i++)
			{
				int index = i;
				GameObject Thisobj = Tran.Find("Blessing" + (i + 1).ToString()).gameObject;
				GameObject Sample = Thisobj.transform.Find("BlessingList/SampleItem").gameObject;
				GameObject TextItem = Thisobj.transform.Find("BlessingList/TextItem").gameObject;
				GameObject NullItem = Thisobj.transform.Find("BlessingList/Null").gameObject;
				NullItem.SetActive(true);
				Sample.SetActive(true);
				TextItem.SetActive(true);
				PointUse p = Thisobj.GetComponent<PointUse>();
				p.RewardType = "BlessAll";
				List<string> keywords = new List<string>();
				KeywordDisplay keywordDisplay = Thisobj.GetComponent<KeywordDisplay>();
				for (int j = 0; j < List1[i].Item1.Count; j++)
				{
					GameSaveAnalyser.Instance.TryPush(List1[i].Item1[j].data["Name"], OperObj.Blessings, OperType.ShopShow);
					GameObject child = UnityEngine.Object.Instantiate<GameObject>(Sample, Sample.transform.parent);
					DataConfig cfg = List1[i].Item1[j];
					PointUse pointUse = p;
					pointUse.DesList = pointUse.DesList + cfg.Description() + "\n";
					List<string> kwItem = new List<string>();
					string descParsed = cfg.Description().Highlight(kwItem);
					child.transform.Find("text/text").GetComponent<TMP_Text>().text = cfg.data.Localize("Name") + ":" + descParsed;
					child.transform.Find("Icon/Icon").GetComponent<Image>().sprite = ResourceLoader.Load<Sprite>(cfg.data["Icon"], true);
				}
				for (int k = 0; k < List1[i].Item2.Count - 1; k += 2)
				{
					GameSaveAnalyser.Instance.TryPush(List1[i].Item2[k].data["Name"], OperObj.Blessings, OperType.ShopShow);
					GameObject child2 = UnityEngine.Object.Instantiate<GameObject>(TextItem, TextItem.transform.parent);
					DataConfig c = List1[i].Item2[k];
					DataConfig c2 = List1[i].Item2[k + 1];
					PointUse pointUse2 = p;
					pointUse2.DesList = string.Concat(new string[]
					{
						pointUse2.DesList,
						c.Description(),
						"\n",
						c2.Description(),
						"\n"
					});
					List<string> kw = new List<string>();
					List<string> kw2 = new List<string>();
					child2.transform.Find("text/text").GetComponent<TMP_Text>().text = c.Description().Highlight(kw) + "    " + c2.Description().Highlight(kw2);
				}
				bool flag = List1[i].Item2.Count % 2 == 1;
				if (flag)
				{
					GameSaveAnalyser instance = GameSaveAnalyser.Instance;
					List<DataConfig> item = List1[i].Item2;
					instance.TryPush(item[item.Count - 1].data["Name"], OperObj.Blessings, OperType.ShopShow);
					GameObject child3 = UnityEngine.Object.Instantiate<GameObject>(TextItem, TextItem.transform.parent);
					List<DataConfig> item2 = List1[i].Item2;
					DataConfig cfg2 = item2[item2.Count - 1];
					PointUse pointUse3 = p;
					pointUse3.DesList += cfg2.Description();
					List<string> kwOdd = new List<string>();
					child3.transform.Find("text/text").GetComponent<TMP_Text>().text = cfg2.Description().Highlight(kwOdd);
				}
				Sample.SetActive(false);
				TextItem.SetActive(false);
				NullItem.SetActive(false);
				string text = Singleton<TextTranslator>.Instance.Translate(p.DesList, keywords);
				keywordDisplay.SetText("命运", text, keywords, null, null, null);
				Thisobj.transform.Find("button").GetComponent<Button>().onClick.AddListener(delegate
				{
					bool flag2 = !canget;
					if (!flag2)
					{
						canget = false;
						foreach (DataConfig item3 in List1[index].Item1)
						{
							GameSaveAnalyser.Instance.TryPush(item3.data["Name"], OperObj.Blessings, OperType.Buy);
							RoleTable.Instance.blessingConfigs.Add(item3);
						}
						foreach (DataConfig item4 in List1[index].Item2)
						{
							GameSaveAnalyser.Instance.TryPush(item4.data["Name"], OperObj.Blessings, OperType.Buy);
							RoleTable.Instance.blessingConfigs.Add(item4);
						}
						this.AnimationPlay(obj);
					}
				});
			}
		}

		// Token: 0x0400115D RID: 4445
		public int InitCost = 70;

		// Token: 0x0400115E RID: 4446
		private int Increasing = 40;
	}
}
