using System;
using System.Collections.Generic;
using Newtonsoft.Json;

// Token: 0x020000F5 RID: 245
public class AchivementTable
{
	// Token: 0x06000818 RID: 2072 RVA: 0x00040588 File Offset: 0x0003E788
	public void Init()
	{
		bool flag = this.table.ContainsKey("剧情");
		if (!flag)
		{
			this.table.Add("剧情", new List<AchievementBase>());
			this.table.Add("战斗", new List<AchievementBase>());
			this.table.Add("探索", new List<AchievementBase>());
			AchievementBase tmp = new AchievementBase(new AchievementBase.AchievementInfo("银河铁道之夜", "在列车到站时醒来。", "什么叫做幸福,我不知道。无论是多么痛苦的事情,只要能朝着理想的方向前进,不管是上高山,还是下陡坡,都能一步步地接近幸福。", "银", "0"));
			this.table["剧情"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("创伤性", "踏上贪婪之路。", "", "铜", "2"));
			this.table["剧情"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("永恒轮回", "好吧？再来一次。", "", "铜", "2"));
			this.table["剧情"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("他人即地狱", "来到新世界。", "地狱并不是什么刀山火海，永远和他人在一起，这本身就是地狱。", "银", "1"));
			this.table["剧情"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("此岸与彼岸", "第一次通过“贪婪之路”的试炼。", "", "金", "2"));
			this.table["剧情"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("存在与虚无", "※※※", "存在先于本质。", "王", "0"));
			this.table["探索"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("无为而治", "连续5个事件中均选择了消极选项。", "无为而治，顺其自然。", "铜", "0"));
			this.table["探索"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("知行合一", "在实践中验证理论。", "知行合一，方能成事。", "银", "0"));
			this.table["探索"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("百战百胜", "在战斗中取得100次胜利。", "战无不胜，攻无不克。", "金", "0"));
			this.table["战斗"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("不屈不挠", "在一场战斗中总回合数超过10", "", "银", "0"));
			this.table["战斗"].Add(tmp);
			tmp = new AchievementBase(new AchievementBase.AchievementInfo("一骑当千", "单枪匹马击败10个敌人。", "一人之力，胜千军万马。", "金", "1"));
			this.table["战斗"].Add(tmp);
		}
	}

	/// <summary>
	/// 添加某成就
	/// </summary>
	/// <param name="type"></param>
	/// <param name="achievement"></param>
	/// <returns></returns>
	// Token: 0x06000819 RID: 2073 RVA: 0x0004087C File Offset: 0x0003EA7C
	public AchivementTable Add(string type, AchievementBase achievement)
	{
		bool flag = !this.table.ContainsKey(type);
		if (flag)
		{
			this.table.Add(type, new List<AchievementBase>());
		}
		this.table[type].Add(achievement);
		return this;
	}

	/// <summary>
	/// 删除某名称的成就
	/// </summary>
	/// <param name="type"></param>
	/// <param name="name"></param>
	/// <returns></returns>
	// Token: 0x0600081A RID: 2074 RVA: 0x000408CC File Offset: 0x0003EACC
	public AchivementTable Del(string type, string name)
	{
		bool flag = this.table.ContainsKey(type);
		if (flag)
		{
			this.table[type].Remove(this.table[type].Find((AchievementBase x) => x.info.name == name));
		}
		return this;
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00040930 File Offset: 0x0003EB30
	public AchivementTable SetAchievementStatus(string type, string name, string status)
	{
		bool flag = this.table.ContainsKey(type);
		if (flag)
		{
			this.table[type].Find((AchievementBase x) => x.info.name == name).SetStatus(status);
			bool flag2 = status == "2";
			if (flag2)
			{
				Dictionary<string, int> dictionary = this.count;
				int num = dictionary[type];
				dictionary[type] = num + 1;
			}
		}
		return this;
	}

	/// <summary>
	/// 对成就状态的优先级排序
	/// </summary>
	/// <param name="type"></param>
	/// <returns></returns>
	// Token: 0x0600081C RID: 2076 RVA: 0x000409B8 File Offset: 0x0003EBB8
	public AchivementTable SortByStatus(string type)
	{
		bool flag = this.table.ContainsKey(type);
		if (flag)
		{
			this.table[type].Sort((AchievementBase a, AchievementBase b) => string.Compare(a.info.status, b.info.status));
		}
		return this;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00040A10 File Offset: 0x0003EC10
	public AchivementTable CountCalculate()
	{
		this.count = new Dictionary<string, int>();
		foreach (string type in this.table.Keys)
		{
			this.count.Add(type, 0);
			foreach (AchievementBase achievement in this.table[type])
			{
				bool flag = achievement.info.status == "2";
				if (flag)
				{
					Dictionary<string, int> dictionary = this.count;
					string key = type;
					int num = dictionary[key];
					dictionary[key] = num + 1;
				}
			}
		}
		return this;
	}

	// Token: 0x04000B8C RID: 2956
	public Dictionary<string, List<AchievementBase>> table = new Dictionary<string, List<AchievementBase>>();

	// Token: 0x04000B8D RID: 2957
	public Dictionary<string, HashSet<string>> ItemDic = new Dictionary<string, HashSet<string>>
	{
		{
			"Relic",
			new HashSet<string>()
		},
		{
			"Bless",
			new HashSet<string>()
		},
		{
			"Card",
			new HashSet<string>()
		},
		{
			"Item",
			new HashSet<string>()
		}
	};

	// Token: 0x04000B8E RID: 2958
	[JsonIgnore]
	public Dictionary<string, int> count = new Dictionary<string, int>();
}
