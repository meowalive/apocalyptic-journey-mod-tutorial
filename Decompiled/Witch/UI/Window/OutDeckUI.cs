using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rougamo;
using Rougamo.Context;
using TMPro;
using UnityEngine;

namespace Witch.UI.Window
{
	// Token: 0x02000295 RID: 661
	public class OutDeckUI : UIBase
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x000A3834 File Offset: 0x000A1A34
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
			methodContext.TargetType = typeof(OutDeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutDeckUI.OnEnable()).MethodHandle, typeof(OutDeckUI).TypeHandle);
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

		// Token: 0x060014BF RID: 5311 RVA: 0x000A3930 File Offset: 0x000A1B30
		[DebuggerStepThrough]
		public void SetRole(OutDeckUIData data)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutDeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutDeckUI.SetRole(OutDeckUIData)).MethodHandle, typeof(OutDeckUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				data
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							data = default(OutDeckUIData);
						}
						else
						{
							data = (OutDeckUIData)arguments[0];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_SetRole(data);
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
								goto IL_105;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_105:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000A3A6C File Offset: 0x000A1C6C
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
			methodContext.TargetType = typeof(OutDeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutDeckUI.DataUpdate()).MethodHandle, typeof(OutDeckUI).TypeHandle);
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

		// Token: 0x060014C1 RID: 5313 RVA: 0x000A3B68 File Offset: 0x000A1D68
		public void ShowMsg()
		{
			Transform equipNullItem = this.equipCardTransform.Find("NullPrefab");
			Transform unequipNullItem = this.unequipCardTransform.Find("NullPrefab");
			foreach (object obj3 in this.equipCardTransform)
			{
				Transform item = (Transform)obj3;
				bool flag = item.name == "Item" || item.name == "NullPrefab";
				if (!flag)
				{
					Singleton<ObjectPool>.Instance.Release(item.gameObject);
				}
			}
			foreach (object obj4 in this.unequipCardTransform)
			{
				Transform item2 = (Transform)obj4;
				bool flag2 = item2.name == "Item" || item2.name == "NullPrefab";
				if (!flag2)
				{
					Singleton<ObjectPool>.Instance.Release(item2.gameObject);
				}
			}
			for (int i = 0; i < this.OutDeckUIData.MaxAlCardCount; i++)
			{
				GameObject obj = Singleton<ObjectPool>.Instance.Get(unequipNullItem.gameObject, this.unequipCardTransform);
				obj.name = "Null";
			}
			for (int j = 0; j < this.OutDeckUIData.CardTopCount; j++)
			{
				GameObject obj2 = Singleton<ObjectPool>.Instance.Get(equipNullItem.gameObject, this.equipCardTransform);
				obj2.name = "Null";
			}
			List<DataConfig> TempCardList = (from x in this.OutDeckUIData.cardList
			orderby x.data["Expend"], x.data.Localize("Name")
			select x).ToList<DataConfig>();
			for (int k = 0; k < this.OutDeckUIData.cardList.Count; k++)
			{
				DataConfig cardId = TempCardList[k];
				this.CreateItem(cardId, true);
			}
			TempCardList = (from x in this.OutDeckUIData.UnCardList
			orderby x.data["Expend"], x.data.Localize("Name")
			select x).ToList<DataConfig>();
			for (int l = 0; l < this.OutDeckUIData.UnCardList.Count; l++)
			{
				DataConfig cardId2 = TempCardList[l];
				this.CreateItem(cardId2, false);
			}
			this.unequipCard.SetActive(false);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x000A3E78 File Offset: 0x000A2078
		[DebuggerStepThrough]
		public void ChangeCardShow()
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutDeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutDeckUI.ChangeCardShow()).MethodHandle, typeof(OutDeckUI).TypeHandle);
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
							this.$Rougamo_ChangeCardShow();
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

		// Token: 0x060014C3 RID: 5315 RVA: 0x000A3F74 File Offset: 0x000A2174
		[DebuggerStepThrough]
		public void CreateItem(DataConfig cardData, bool ifequipped)
		{
			Modifiable modifiable = new Modifiable();
			MethodContext methodContext = RougamoPool<MethodContext>.Get();
			methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
			{
				modifiable
			};
			methodContext.Target = this;
			methodContext.TargetType = typeof(OutDeckUI);
			methodContext.Method = MethodBase.GetMethodFromHandle(methodof(OutDeckUI.CreateItem(DataConfig, bool)).MethodHandle, typeof(OutDeckUI).TypeHandle);
			methodContext.Arguments = new object[]
			{
				cardData,
				ifequipped
			};
			try
			{
				modifiable.OnEntry(methodContext);
				if (methodContext.ReturnValueReplaced)
				{
					modifiable.OnExit(methodContext);
				}
				else
				{
					if (methodContext.RewriteArguments)
					{
						object[] arguments = methodContext.Arguments;
						if (arguments[0] == null)
						{
							cardData = null;
						}
						else
						{
							cardData = (DataConfig)arguments[0];
						}
						if (arguments[1] == null)
						{
							ifequipped = default(bool);
						}
						else
						{
							ifequipped = (bool)arguments[1];
						}
					}
					do
					{
						try
						{
							this.$Rougamo_CreateItem(cardData, ifequipped);
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
								goto IL_125;
							}
							throw;
						}
						modifiable.OnSuccess(methodContext);
					}
					while (methodContext.RetryCount > 0);
					modifiable.OnExit(methodContext);
					IL_125:;
				}
			}
			finally
			{
				RougamoPool<MethodContext>.Return(methodContext);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000A40EC File Offset: 0x000A22EC
		private void $Rougamo_OnEnable()
		{
			base.OnEnable();
			bool flag = string.IsNullOrEmpty(this.OutDeckUIData.Id);
			if (flag)
			{
				this.OutDeckUIData = new OutDeckUIData(RoleTable.Instance);
			}
			this.isSelf = (this.OutDeckUIData.Id == RoleTable.Instance.Id);
			base.transform.Find("Window Manager").localScale = Vector3.zero;
			base.transform.Find("Window Manager").DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
			base.transform.SetAsLastSibling();
			this.ChangeCardShow();
			UniTask.WaitForEndOfFrame(default(CancellationToken)).ContinueWith(delegate()
			{
				this.ShowMsg();
			}).Forget();
			base.transform.SetAsLastSibling();
			this.DataUpdate();
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000A41D4 File Offset: 0x000A23D4
		private void $Rougamo_SetRole(OutDeckUIData data)
		{
			this.OutDeckUIData = data;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x000A41E0 File Offset: 0x000A23E0
		private void $Rougamo_DataUpdate()
		{
			base.transform.Find("Window Manager/Windows/牌堆/Content/equipCard/Title/Text").GetComponent<TMP_Text>().text = "card".Localize("BackpackUI");
			base.transform.Find("Window Manager/Windows/牌堆/Content/unequipCard/Title/Text").GetComponent<TMP_Text>().text = "Alternative".Localize("BackpackUI");
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000A4244 File Offset: 0x000A2444
		private void $Rougamo_ChangeCardShow()
		{
			TMP_Text txt = base.transform.Find("Window Manager/Windows/牌堆/Left/Top/Equip/Text").GetComponent<TMP_Text>();
			txt.richText = true;
			txt.text = ZString.Format<object, object, object>("<color=#FFD700>{0}</color>/<color=#FF69B4>{1}</color>/<color=#1E90FF>{2}</color>", this.OutDeckUIData.CardBottomCount, this.OutDeckUIData.cardList.Count, this.OutDeckUIData.CardTopCount);
			base.transform.Find("Window Manager/Windows/牌堆/Left/Top/Out/Text").GetComponent<TMP_Text>().text = this.OutDeckUIData.UnCardList.Count.ToString() + "/" + this.OutDeckUIData.MaxAlCardCount.ToString();
			Transform PreList = base.transform.Find("Window Manager/Windows/牌堆/Left/Area/List");
			GameObject WithPre = PreList.Find("WithPre").gameObject;
			WithPre.SetActive(true);
			GameObject TotalPre = PreList.Find("TotalPre").gameObject;
			TotalPre.SetActive(true);
			for (int i = PreList.childCount - 1; i >= 2; i--)
			{
				Transform item = PreList.GetChild(i);
				UnityEngine.Object.Destroy(item.gameObject);
			}
			for (int j = 0; j < Mathf.Min(this.OutDeckUIData.cardList.Count, 40); j++)
			{
				GameObject obj = UnityEngine.Object.Instantiate<GameObject>(WithPre, PreList);
			}
			for (int k = 0; k < Mathf.Min(this.OutDeckUIData.CardTopCount, 40) - this.OutDeckUIData.cardList.Count; k++)
			{
				GameObject obj2 = UnityEngine.Object.Instantiate<GameObject>(TotalPre, PreList);
			}
			TotalPre.SetActive(false);
			WithPre.SetActive(false);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000A440C File Offset: 0x000A260C
		private void $Rougamo_CreateItem(DataConfig cardData, bool ifequipped)
		{
			bool flag = cardData == null || cardData.data == null;
			if (flag)
			{
				Debug.LogError("卡牌数据为空");
			}
			else
			{
				GameObject obj;
				if (ifequipped)
				{
					obj = Singleton<ObjectPool>.Instance.Get(this.equipCard, this.equipCardTransform);
				}
				else
				{
					obj = Singleton<ObjectPool>.Instance.Get(this.unequipCard, this.unequipCardTransform);
				}
				ShowCard item = obj.GetComponent<ShowCard>();
				item.cardShowUI = this;
				item.Init(cardData, ifequipped, this.isSelf);
			}
		}

		// Token: 0x040010A3 RID: 4259
		private bool isSelf = true;

		// Token: 0x040010A4 RID: 4260
		public OutDeckUIData OutDeckUIData;

		// Token: 0x040010A5 RID: 4261
		[SerializeField]
		private GameObject equipCard;

		// Token: 0x040010A6 RID: 4262
		public Transform equipCardTransform;

		// Token: 0x040010A7 RID: 4263
		public Transform unequipCardTransform;

		// Token: 0x040010A8 RID: 4264
		[SerializeField]
		private GameObject unequipCard;

		// Token: 0x040010A9 RID: 4265
		public GameObject shouldButton;
	}
}
