using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Mirror;
using Newtonsoft.Json;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using UnityEngine;

namespace Data.Save
{
	// Token: 0x02000228 RID: 552
	public class GameSaveAnalyser
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0008B24C File Offset: 0x0008944C
		public GameOperInfo ItemInfos
		{
			get
			{
				return GameSaveManager.GetItemOpers();
			}
		}

		/// <summary>
		/// 尝试将物品操作记录添加到GameOperInfo中
		/// </summary>
		/// <param name="name">物品中文名</param>
		/// <param name="itemType">物品类型</param>
		/// <param name="operType">操作类型</param>
		// Token: 0x06001198 RID: 4504 RVA: 0x0008B254 File Offset: 0x00089454
		[Command(requiresAuthority = false)]
		public void TryPush(string name, OperObj itemType, OperType operType)
		{
			bool flag = !GameApp.STEAMBUILD;
			if (!flag)
			{
				GameOperInfo.ItemsInfo itemsInfos;
				switch (itemType)
				{
				case OperObj.Cards:
					itemsInfos = this.ItemInfos.Cards;
					break;
				case OperObj.Relics:
					itemsInfos = this.ItemInfos.Relics;
					break;
				case OperObj.Blessings:
					itemsInfos = this.ItemInfos.Blessings;
					break;
				case OperObj.HardTags:
					itemsInfos = this.ItemInfos.HardTags;
					break;
				default:
					Debug.LogError("未知的物品类型");
					return;
				}
				GameOperInfo.ItemsInfo.Info info = new GameOperInfo.ItemsInfo.Info(name);
				switch (operType)
				{
				case OperType.RewardShow:
				{
					List<GameOperInfo.ItemsInfo.Info> rewardShow = itemsInfos.RewardShow;
					if (rewardShow != null)
					{
						rewardShow.Add(info);
					}
					break;
				}
				case OperType.ShopShow:
				{
					List<GameOperInfo.ItemsInfo.Info> shopShow = itemsInfos.ShopShow;
					if (shopShow != null)
					{
						shopShow.Add(info);
					}
					break;
				}
				case OperType.Select:
				{
					List<GameOperInfo.ItemsInfo.Info> select = itemsInfos.Select;
					if (select != null)
					{
						select.Add(info);
					}
					break;
				}
				case OperType.Buy:
				{
					List<GameOperInfo.ItemsInfo.Info> buy = itemsInfos.Buy;
					if (buy != null)
					{
						buy.Add(info);
					}
					break;
				}
				case OperType.Delete:
				{
					List<GameOperInfo.ItemsInfo.Info> delete = itemsInfos.Delete;
					if (delete != null)
					{
						delete.Add(info);
					}
					break;
				}
				default:
					Debug.LogError("未知的操作类型");
					break;
				}
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0008B37C File Offset: 0x0008957C
		[DebuggerStepThrough]
		public UniTask UpdateToSupabase()
		{
			GameSaveAnalyser.<UpdateToSupabase>d__5 <UpdateToSupabase>d__ = new GameSaveAnalyser.<UpdateToSupabase>d__5();
			<UpdateToSupabase>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateToSupabase>d__.<>4__this = this;
			<UpdateToSupabase>d__.<>1__state = -1;
			<UpdateToSupabase>d__.<>t__builder.Start<GameSaveAnalyser.<UpdateToSupabase>d__5>(ref <UpdateToSupabase>d__);
			return <UpdateToSupabase>d__.<>t__builder.Task;
		}

		// Token: 0x04000EC0 RID: 3776
		public static GameSaveAnalyser Instance = new GameSaveAnalyser();

		// Token: 0x02000229 RID: 553
		[Table("save_selection")]
		private class SaveSelection : BaseModel
		{
			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600119C RID: 4508 RVA: 0x0008B3CC File Offset: 0x000895CC
			// (set) Token: 0x0600119D RID: 4509 RVA: 0x0008B3D4 File Offset: 0x000895D4
			[Column("data", NullValueHandling.Include, false, false)]
			public string data { get; set; }
		}
	}
}
