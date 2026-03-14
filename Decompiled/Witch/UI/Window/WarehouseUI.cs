using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Rougamo;
using Rougamo.Context;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000371 RID: 881
	public class WarehouseUI : UIBase
	{
		// Token: 0x06001BD7 RID: 7127 RVA: 0x000EDF90 File Offset: 0x000EC190
		[DebuggerStepThrough]
		public override void OnEnable()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(WarehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(WarehouseUI.OnEnable()).MethodHandle, typeof(WarehouseUI).TypeHandle);
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
							this.$Rougamo_OnEnable();
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

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000EE08C File Offset: 0x000EC28C
		public void ShowCard()
		{
			foreach (object obj in this.warehouseParent)
			{
				Transform child = (Transform)obj;
				bool flag = child.name != "Item";
				if (flag)
				{
					Singleton<ObjectPool>.Instance.Release(child.gameObject);
				}
			}
			foreach (object obj2 in this.withCardParent)
			{
				Transform child2 = (Transform)obj2;
				bool flag2 = child2.name != "Item";
				if (flag2)
				{
					Singleton<ObjectPool>.Instance.Release(child2.gameObject);
				}
			}
			List<DataConfig> cardlist = PlayerManager.Instance.ShareCards.ToList<DataConfig>();
			for (int i = 0; i < cardlist.Count; i++)
			{
				GameObject item = Singleton<ObjectPool>.Instance.Get(this.warehouseParent.Find("Item").gameObject, this.warehouseParent);
				item.GetComponent<WarehouseItem>().ItemType = "Card";
				item.GetComponent<WarehouseItem>().Init(true, false, cardlist[i]);
				item.GetComponent<WarehouseItem>().warehouseUI = this;
				ICard.SetCardMsg(item.transform.Find("CardItem"), cardlist[i], null);
			}
			for (int j = 0; j < RoleTable.Instance.cardList.Count; j++)
			{
				GameObject item2 = Singleton<ObjectPool>.Instance.Get(this.withCardParent.Find("Item").gameObject, this.withCardParent);
				item2.GetComponent<WarehouseItem>().ItemType = "Card";
				item2.GetComponent<WarehouseItem>().Init(false, true, RoleTable.Instance.cardList[j]);
				item2.GetComponent<WarehouseItem>().warehouseUI = this;
				ICard.SetCardMsg(item2.transform.Find("CardItem"), RoleTable.Instance.cardList[j], null);
			}
			for (int k = 0; k < RoleTable.Instance.UnCardList.Count; k++)
			{
				GameObject item3 = Singleton<ObjectPool>.Instance.Get(this.withCardParent.Find("Item").gameObject, this.withCardParent);
				item3.GetComponent<WarehouseItem>().ItemType = "Card";
				item3.GetComponent<WarehouseItem>().Init(false, false, RoleTable.Instance.UnCardList[k]);
				item3.GetComponent<WarehouseItem>().warehouseUI = this;
				ICard.SetCardMsg(item3.transform.Find("CardItem"), RoleTable.Instance.UnCardList[k], null);
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000EE3A8 File Offset: 0x000EC5A8
		[DebuggerStepThrough]
		public static void ResetCount()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.TargetType = typeof(WarehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(WarehouseUI.ResetCount()).MethodHandle, typeof(WarehouseUI).TypeHandle);
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
							WarehouseUI.$Rougamo_ResetCount();
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
								goto IL_C0;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_C0:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000EE49C File Offset: 0x000EC69C
		[DebuggerStepThrough]
		public bool MoveCheck(string itemType, bool isGet)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(WarehouseUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(WarehouseUI.MoveCheck(string, bool)).MethodHandle, typeof(WarehouseUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				itemType,
				isGet
			};
			bool flag;
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					flag = (bool)methodContext.ReturnValue;
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							itemType = null;
						}
						else
						{
							itemType = (string)arguments[0];
						}
						if (arguments[1] == null)
						{
							isGet = default(bool);
						}
						else
						{
							isGet = (bool)arguments[1];
						}
					}
					do
					{
						try
						{
							flag = this.$Rougamo_MoveCheck(itemType, isGet);
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
								flag = (bool)methodContext.ReturnValue;
							}
							modifiable.OnExit(methodContext);
							if (exceptionHandled)
							{
								goto IL_16A;
							}
							throw;
						}
						methodContext.ReturnValue = flag;
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					if (methodContext.ReturnValueReplaced)
					{
						flag = (bool)methodContext.ReturnValue;
					}
					modifiable.OnExit(methodContext);
					IL_16A:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
			return flag;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x000EE654 File Offset: 0x000EC854
		public void ShowRelic()
		{
			foreach (object obj in this.withRelicParent)
			{
				Transform child = (Transform)obj;
				bool flag = child.name != "Item";
				if (flag)
				{
					Singleton<ObjectPool>.Instance.Release(child.gameObject);
				}
			}
			List<DataConfig> relicList = PlayerManager.Instance.ShareRelics.ToList<DataConfig>();
			for (int i = 0; i < relicList.Count; i++)
			{
				GameObject item = Singleton<ObjectPool>.Instance.Get(this.warehouseParent.Find("Item").gameObject, this.warehouseParent);
				item.GetComponent<WarehouseItem>().ItemType = "Relic";
				item.GetComponent<WarehouseItem>().Init(true, false, relicList[i]);
				item.GetComponent<WarehouseItem>().warehouseUI = this;
			}
			for (int j = 0; j < RoleTable.Instance.relicList.Count; j++)
			{
				GameObject item2 = Singleton<ObjectPool>.Instance.Get(this.withRelicParent.Find("Item").gameObject, this.withRelicParent);
				item2.GetComponent<WarehouseItem>().ItemType = "Relic";
				item2.GetComponent<WarehouseItem>().Init(false, true, RoleTable.Instance.relicList[j]);
				item2.GetComponent<WarehouseItem>().warehouseUI = this;
			}
			for (int k = 0; k < RoleTable.Instance.WithoutArmedRelicList.Count; k++)
			{
				GameObject item3 = Singleton<ObjectPool>.Instance.Get(this.withRelicParent.Find("Item").gameObject, this.withRelicParent);
				item3.GetComponent<WarehouseItem>().ItemType = "Relic";
				item3.GetComponent<WarehouseItem>().Init(false, false, RoleTable.Instance.WithoutArmedRelicList[k]);
				item3.GetComponent<WarehouseItem>().warehouseUI = this;
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000EE87C File Offset: 0x000ECA7C
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			this.ShowCard();
			this.ShowRelic();
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000EE894 File Offset: 0x000ECA94
		private static void $Rougamo_ResetCount()
		{
			WarehouseUI.GetCard = 0;
			WarehouseUI.GetRelic = 0;
			WarehouseUI.SendCard = 0;
			WarehouseUI.SendRelic = 0;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000EE8B0 File Offset: 0x000ECAB0
		private bool $Rougamo_MoveCheck(string itemType, bool isGet)
		{
			bool result;
			if (isGet)
			{
				bool flag = itemType == "Card" && WarehouseUI.GetCard == 0;
				if (flag)
				{
					WarehouseUI.GetCard++;
					result = true;
				}
				else
				{
					bool flag2 = itemType == "Relic" && WarehouseUI.GetRelic == 0;
					if (flag2)
					{
						WarehouseUI.GetRelic++;
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				bool flag3 = itemType == "Card" && WarehouseUI.SendCard < 2;
				if (flag3)
				{
					WarehouseUI.SendCard++;
					result = true;
				}
				else
				{
					bool flag4 = itemType == "Relic" && WarehouseUI.SendRelic == 0;
					if (flag4)
					{
						WarehouseUI.SendRelic++;
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x040014D9 RID: 5337
		public Transform withCardParent;

		// Token: 0x040014DA RID: 5338
		public Transform warehouseParent;

		// Token: 0x040014DB RID: 5339
		public Transform withRelicParent;

		// Token: 0x040014DC RID: 5340
		private static int GetCard;

		// Token: 0x040014DD RID: 5341
		private static int GetRelic;

		// Token: 0x040014DE RID: 5342
		private static int SendCard;

		// Token: 0x040014DF RID: 5343
		private static int SendRelic;
	}
}
