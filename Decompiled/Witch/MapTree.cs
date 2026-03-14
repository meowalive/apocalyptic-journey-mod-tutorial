using System;
using System.Collections.Generic;
using System.Linq;
using Data.Save;
using UnityEngine;
using ZLinq;
using ZLinq.Linq;

/// <summary>
/// MapTree类用于生成地图树，地图树是一个树形结构，每个节点代表一个地点，每个地点有一个类型、名称、标签、描述和最多三个子节点。
/// </summary>
// Token: 0x02000102 RID: 258
public class MapTree
{
	// Token: 0x06000879 RID: 2169 RVA: 0x0004362C File Offset: 0x0004182C
	public MapTree()
	{
		this.DefaultNode.Clear();
		this.SelectNode.Clear();
		this.root = new MapTree.Node("Root");
		this.currentNode = this.root;
		this.treedice = Dice.Default.WithRange(0, 1000);
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x000436AC File Offset: 0x000418AC
	public MapTree.Node TypeGenerate(string type)
	{
		List<Dictionary<string, string>> mapData = Singleton<GameConfigManager>.Instance.GetTable(DataType.Map).Getlines();
		mapData = (from x in mapData.AsValueEnumerable<Dictionary<string, string>>()
		where x["Note"] == type
		select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		bool flag = type == "首领" || type == "精英" || type == "普通";
		if (flag)
		{
			mapData = (from x in mapData.AsValueEnumerable<Dictionary<string, string>>()
			where int.Parse(x["Level"]) == MapManager.Instance.ModeMapManager.Level / 12 || x["Level"] == "-1"
			select x).ToList<ListWhere<Dictionary<string, string>>, Dictionary<string, string>>();
		}
		Dictionary<string, string> map = new RandomPool(mapData, this.treedice).DrawByNote(1, null)[0];
		MapTree.Node node = new MapTree.Node(type);
		bool flag2 = type == "普通事件";
		if (flag2)
		{
			node.data = new Dictionary<string, string>(map);
		}
		else
		{
			node.data = map;
		}
		node.NodeDice = this.treedice.WithCursor(this.treedice.Roll().Value);
		bool flag3 = type == "首领" || type == "精英" || type == "普通";
		if (flag3)
		{
			int LastFeat = 1;
			bool flag4 = type == "精英";
			if (flag4)
			{
				LastFeat = 2;
			}
			bool flag5 = type == "首领";
			if (flag5)
			{
				LastFeat = 3;
			}
			node.data["Money"] = (LastFeat * 35 + 10 + node.NodeDice.WithRange(-10, 10).Roll().Value + int.Parse(GameSaveManager.GetValue<string>("Difficulty")) * 2).ToString();
		}
		return node;
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000438AC File Offset: 0x00041AAC
	public MapTree.Node GetNodeByNodeId(string nodeId)
	{
		Dictionary<string, string> map = Singleton<GameConfigManager>.Instance.GetTable(DataType.Map).Getlines().FirstOrDefault((Dictionary<string, string> x) => x["NodeId"] == nodeId);
		string type = map["Note"];
		MapTree.Node node = new MapTree.Node(type);
		node.data = map;
		node.NodeDice = this.treedice.WithCursor(this.treedice.Roll().Value);
		bool flag = type == "首领" || type == "精英" || type == "普通";
		if (flag)
		{
			int LastFeat = 1;
			bool flag2 = type == "精英";
			if (flag2)
			{
				LastFeat = 2;
			}
			bool flag3 = type == "首领";
			if (flag3)
			{
				LastFeat = 3;
			}
			node.data["Money"] = (LastFeat * 35 + 10 + node.NodeDice.WithRange(-10, 10).Roll().Value + int.Parse(GameSaveManager.GetValue<string>("Difficulty")) * 2).ToString();
		}
		return node;
	}

	// Token: 0x04000BC8 RID: 3016
	public MapTree.Node root;

	// Token: 0x04000BC9 RID: 3017
	public MapTree.Node currentNode;

	// Token: 0x04000BCA RID: 3018
	public Dice treedice;

	// Token: 0x04000BCB RID: 3019
	public List<MapTree.Node> SelectNode = new List<MapTree.Node>();

	// Token: 0x04000BCC RID: 3020
	public List<MapTree.Node> DefaultNode = new List<MapTree.Node>();

	// Token: 0x04000BCD RID: 3021
	public List<int> hasUsed = new List<int>();

	/// <summary>
	/// Node代表节点，包含节点的类型、名称、标签、描述、子节点。Node的方法采用链式调用。
	/// Node的子节点只能通过SetChild方法设定，设定后子节点的父节点和深度会自动设定。
	/// </summary>
	// Token: 0x02000103 RID: 259
	public class Node
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000439D8 File Offset: 0x00041BD8
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000439E0 File Offset: 0x00041BE0
		public MapTree.Node[] childrens { get; set; }

		// Token: 0x0600087E RID: 2174 RVA: 0x000439E9 File Offset: 0x00041BE9
		public Node(string type)
		{
			this.depth = 0;
			this.type = type;
		}

		/// <summary>
		/// 根据下标设定子节点
		/// </summary>
		/// <param name="index">下标，0-2</param>
		/// <param name="child">子节点</param>
		/// <returns></returns>
		// Token: 0x0600087F RID: 2175 RVA: 0x00043A04 File Offset: 0x00041C04
		public MapTree.Node SetChild(int index, MapTree.Node child)
		{
			bool flag = this.childrens == null;
			if (flag)
			{
				this.childrens = new MapTree.Node[3];
			}
			bool flag2 = index < 0 || index >= this.childrens.Length;
			MapTree.Node result;
			if (flag2)
			{
				Debug.LogError("Index out of range");
				result = this;
			}
			else
			{
				child.depth = this.depth + 1;
				this.childrens[index] = child;
				result = this;
			}
			return result;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00043A74 File Offset: 0x00041C74
		public MapTree.Node GetChild(int index)
		{
			bool flag = this.childrens != null;
			MapTree.Node result;
			if (flag)
			{
				result = this.childrens[index];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000BCE RID: 3022
		public int depth;

		// Token: 0x04000BCF RID: 3023
		public string type;

		// Token: 0x04000BD0 RID: 3024
		public Dictionary<string, string> data;

		// Token: 0x04000BD1 RID: 3025
		public Dice NodeDice;
	}
}
