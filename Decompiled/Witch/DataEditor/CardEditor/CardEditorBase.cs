using System;
using System.Collections.Generic;
using Cysharp.Text;

namespace DataEditor.CardEditor
{
	// Token: 0x02000219 RID: 537
	public class CardEditorBase
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x0008AE05 File Offset: 0x00089005
		[EffectName("设定卡牌类型")]
		[EffectDes("设定卡牌类型为{type}")]
		[EffectLimit(1)]
		[EffectTarget(0f)]
		[EffectCardDes("")]
		public static ValueTuple<string, int> SetCardType(CardEditorBase.CardTypeDes type)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self.Vars:set_Item(\"BaseScript\", \"{0}\");", (CardEditorBase.CardType)type), 0);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0008AE1D File Offset: 0x0008901D
		[EffectName("触发时机为")]
		[EffectDes("当{type}")]
		[EffectTarget(0f)]
		[EffectCardDes("")]
		public static ValueTuple<string, int> GetTime(CardEditorBase.TimeType type)
		{
			return new ValueTuple<string, int>("", 0);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0008AE2A File Offset: 0x0008902A
		[EffectName("增加护盾")]
		[EffectDes("增加{val}点护盾")]
		[EffectTarget(-1f)]
		[EffectCardDes("增加{{desValIndex}}点护盾")]
		[AddDesVal("({val})")]
		public static ValueTuple<string, int> Change(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:ChangeDefence(\"{0}\");", val), val * 10);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0008AE45 File Offset: 0x00089045
		[EffectName("造成伤害")]
		[EffectDes("造成{val}点{damagetype}伤害")]
		[EffectTarget(-1.5f)]
		[EffectLimit(2)]
		[EffectCardDes("造成{{desValIndex}}点{damagetype}伤害")]
		[AddDesVal("({val})")]
		public static ValueTuple<string, int> Damage(int val, CardEditorBase.DamageTypeDes damagetype)
		{
			return new ValueTuple<string, int>(ZString.Format<object, object>("self:Damage(\"{0}\",\"{1}\");", val, (CardEditorBase.DamageType)damagetype), (val != 0) ? (-(13 + 7 * val)) : 0);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0008AE6F File Offset: 0x0008906F
		[EffectName("获得能量")]
		[EffectDes("获得{val}点能量")]
		[EffectTarget(1f)]
		[EffectCardDes("获得{{desValIndex}}点能量")]
		[AddDesVal("({val})")]
		public static ValueTuple<string, int> ChangePower(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:ChangePower(\"{0}\");", val), Math.Max(0, 70 * val));
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0008AE90 File Offset: 0x00089090
		[EffectName("抽卡")]
		[EffectDes("抽取{val}张卡牌")]
		[EffectTarget(1f)]
		[EffectCardDes("抽取{{desValIndex}}张卡牌")]
		[AddDesVal("({val})")]
		public static ValueTuple<string, int> DrawCount(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:DrawCount(\"{0}\");", val), Math.Max(0, 75 * val));
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0008AEB1 File Offset: 0x000890B1
		[EffectName("回合切换")]
		[EffectDes("结束当前回合")]
		[EffectTarget(1f)]
		public static ValueTuple<string, int> ChangeRound()
		{
			return new ValueTuple<string, int>("self:ChangeRound();", -100);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0008AEBF File Offset: 0x000890BF
		[EffectName("丢弃卡牌")]
		[EffectDes("丢弃{val}张卡牌")]
		[EffectTarget(1f)]
		public static ValueTuple<string, int> ThrowCard(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object, object>("self:ThrowCard(\"{0}\",\"{1}\");", val, 0), 25);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0008AEDE File Offset: 0x000890DE
		[EffectName("焚毁卡牌")]
		[EffectDes("焚毁{val}张卡牌")]
		[EffectTarget(1f)]
		public static ValueTuple<string, int> BurnCard(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object, object>("self:BurnCard(\"{0}\",\"{1}\");", val, 0), 25);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0008AF00 File Offset: 0x00089100
		[EffectName("添加一个buff")]
		[EffectDes("添加{level}层的{data}")]
		[EffectTarget(-1f)]
		[EffectCardDes("添加{{desValIndex}}层的{data}")]
		[AddDesVal("({level})")]
		public static ValueTuple<string, int> AddBuff(BuffData data, int level)
		{
			string item = ZString.Format<object, object>("self:AddBuff(\"{0}\" ,\"{1}\");", (data != null) ? data.Id : null, level);
			int num = level * (Math.Max(12 - level, 6) + 7 * ((data != null && Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id) != null && Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id).ContainsKey("Rarity")) ? Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id).GetValueOrDefault("Rarity", "1").ToInt() : 999));
			Dictionary<string, string> one = Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, (data != null) ? data.Id : null);
			return new ValueTuple<string, int>(item, num * ((((one != null) ? one.GetValueOrDefault("Type", "正面") : null) == "负面") ? -1 : 1) * ((data != null && Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id) != null && Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id).ContainsKey("Rarity")) ? Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id).GetValueOrDefault("Rarity", "1").ToInt() : 999));
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0008B044 File Offset: 0x00089244
		[EffectName("移除buff")]
		[EffectDes("移除{data}")]
		[EffectTarget(-1.5f)]
		public static ValueTuple<string, int> RemoveBuff(BuffData data)
		{
			string item = "self:RemoveBuff(\"" + ((data != null) ? data.Id : null) + "\");";
			Dictionary<string, string> one = Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, (data != null) ? data.Id : null);
			return new ValueTuple<string, int>(item, (((one != null) ? one.GetValueOrDefault("Type", "正面") : null) == "负面") ? 15 : (-15 * ((data != null && Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id) != null && Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id).ContainsKey("Rarity")) ? Singleton<GameConfigManager>.Instance.GetOne(DataType.Buff, data.Id).GetValueOrDefault("Rarity", "1").ToInt() : 999)));
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0008B114 File Offset: 0x00089314
		[EffectName("增加血量")]
		[EffectDes("增加{val}点血量")]
		[EffectTarget(-0.3f)]
		public static ValueTuple<string, int> ChangeHp(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:ChangeHp(\"{0}\");", val), 20 * val);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0008B12F File Offset: 0x0008932F
		[EffectName("增加最大血量")]
		[EffectDes("增加{val}点最大血量")]
		[EffectTarget(-0.3f)]
		public static ValueTuple<string, int> ChangeMaxHp(int val)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:ChangeMaxHp(\"{0}\");", val), 70 * val);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0008B14A File Offset: 0x0008934A
		[EffectName("选卡加入手牌")]
		[EffectDes("从抽牌堆中选{count}张卡牌加入手卡")]
		[EffectTarget(-1f)]
		[EffectCardDes("从抽牌堆中选{{desValIndex}}张卡牌加入手卡")]
		[AddDesVal("({count})")]
		public static ValueTuple<string, int> AddCardByCardList(int count)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:AddCardByCardList(\"{0}\",\"all\");", count), count * 50 * 2);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0008B167 File Offset: 0x00089367
		[EffectName("重新洗牌")]
		[EffectDes("重新洗牌")]
		[EffectTarget(-1f)]
		public static ValueTuple<string, int> ShuffleDeck()
		{
			return new ValueTuple<string, int>("self:ShuffleDeck();", 30);
		}

		/// <summary>
		/// 根据筛选条件决定效果对象
		/// </summary>
		/// <param name="filter">
		/// Player:玩家|
		/// Enemy:敌人|
		/// Self:自己|
		/// Target:目标|
		/// All:所有|
		/// AllRandom[count]:随机对象count个|
		/// AllRandom[Player/Enemy/Target][count]:随机[]对象count个|
		/// </param>
		// Token: 0x06001191 RID: 4497 RVA: 0x0008B175 File Offset: 0x00089375
		[EffectName("设定对象")]
		[EffectDes("设定效果对象为{filter}")]
		[EffectTarget(0f)]
		[EffectCardDes("对{filter}")]
		public static ValueTuple<string, int> SetStatus(CardEditorBase.TargetTypeDes filter)
		{
			return new ValueTuple<string, int>(ZString.Format<object>("self:SetStatus(\"{0}\");", (CardEditorBase.TargetType)filter), 0);
		}

		// Token: 0x0200021A RID: 538
		public enum CardType
		{
			// Token: 0x04000E86 RID: 3718
			AttackCardItem,
			// Token: 0x04000E87 RID: 3719
			CommonCardItem
		}

		// Token: 0x0200021B RID: 539
		public enum CardTypeDes
		{
			// Token: 0x04000E89 RID: 3721
			选中目标,
			// Token: 0x04000E8A RID: 3722
			非选目标
		}

		// Token: 0x0200021C RID: 540
		public enum ValueSelect
		{
			// Token: 0x04000E8C RID: 3724
			DesVal1,
			// Token: 0x04000E8D RID: 3725
			DesVal2,
			// Token: 0x04000E8E RID: 3726
			DesVal3,
			// Token: 0x04000E8F RID: 3727
			DesVal4
		}

		// Token: 0x0200021D RID: 541
		public enum ValueSelectDes
		{
			// Token: 0x04000E91 RID: 3729
			数值1,
			// Token: 0x04000E92 RID: 3730
			数值2,
			// Token: 0x04000E93 RID: 3731
			数值3,
			// Token: 0x04000E94 RID: 3732
			数值4
		}

		// Token: 0x0200021E RID: 542
		public enum TimeType
		{
			// Token: 0x04000E96 RID: 3734
			抽到时,
			// Token: 0x04000E97 RID: 3735
			使用时,
			// Token: 0x04000E98 RID: 3736
			丢弃时
		}

		// Token: 0x0200021F RID: 543
		public enum TargetType
		{
			// Token: 0x04000E9A RID: 3738
			Self,
			// Token: 0x04000E9B RID: 3739
			Target,
			// Token: 0x04000E9C RID: 3740
			All,
			// Token: 0x04000E9D RID: 3741
			AllTarget
		}

		// Token: 0x02000220 RID: 544
		public enum TargetTypeDes
		{
			// Token: 0x04000E9F RID: 3743
			自己,
			// Token: 0x04000EA0 RID: 3744
			目标,
			// Token: 0x04000EA1 RID: 3745
			所有,
			// Token: 0x04000EA2 RID: 3746
			所有敌人
		}

		// Token: 0x02000221 RID: 545
		public enum DamageType
		{
			// Token: 0x04000EA4 RID: 3748
			Normal,
			// Token: 0x04000EA5 RID: 3749
			True
		}

		// Token: 0x02000222 RID: 546
		public enum DamageTypeDes
		{
			// Token: 0x04000EA7 RID: 3751
			普通,
			// Token: 0x04000EA8 RID: 3752
			真实
		}
	}
}
