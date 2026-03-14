using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02000032 RID: 50
public class Dice
{
	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000142 RID: 322 RVA: 0x0000CA9D File Offset: 0x0000AC9D
	// (set) Token: 0x06000143 RID: 323 RVA: 0x0000CAA5 File Offset: 0x0000ACA5
	[JsonProperty]
	public string Type { get; private set; }

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000144 RID: 324 RVA: 0x0000CAAE File Offset: 0x0000ACAE
	public static Dice Default
	{
		get
		{
			return new Dice
			{
				Type = "Default",
				Range = new ValueTuple<int, int>(1, 100)
			};
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000145 RID: 325 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
	public static Dice Value
	{
		get
		{
			return new Dice
			{
				Type = "Value",
				Range = new ValueTuple<int, int>(1, 100)
			};
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000146 RID: 326 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
	public static Dice Check
	{
		get
		{
			return new Dice
			{
				Type = "Check",
				Range = new ValueTuple<int, int>(1, 100)
			};
		}
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0000CB14 File Offset: 0x0000AD14
	private Dice(Dice dice)
	{
		this.Type = dice.Type;
		this.Range = dice.Range;
		this._cursor = dice._cursor;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000CB50 File Offset: 0x0000AD50
	internal Dice WithCursor(int cursor)
	{
		return new Dice(this)
		{
			_cursor = new Dice.RandomCursor(cursor)
		};
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0000CB78 File Offset: 0x0000AD78
	public Dice WithType(string type)
	{
		return new Dice(this)
		{
			Type = type
		};
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0000CB9A File Offset: 0x0000AD9A
	private Dice()
	{
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600014B RID: 331 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
	// (set) Token: 0x0600014C RID: 332 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
	[TupleElementNames(new string[]
	{
		"min",
		"max"
	})]
	[JsonProperty]
	public ValueTuple<int, int> Range { [return: TupleElementNames(new string[]
	{
		"min",
		"max"
	})] get; [param: TupleElementNames(new string[]
	{
		"min",
		"max"
	})] private set; }

	// Token: 0x0600014D RID: 333 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
	public Dice WithRange(int min, int max)
	{
		bool flag = this.Type == "Check";
		if (flag)
		{
			throw new Exception("Check dice can't set range");
		}
		return new Dice(this)
		{
			Range = new ValueTuple<int, int>(min, max)
		};
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600014E RID: 334 RVA: 0x0000CC0C File Offset: 0x0000AE0C
	private float[] pool
	{
		get
		{
			return TempDataManager.seeds;
		}
	}

	// Token: 0x0600014F RID: 335 RVA: 0x0000CC14 File Offset: 0x0000AE14
	private int GetRange(int min, int max)
	{
		bool flag = this.pool == null || this.pool.Length == 0;
		if (flag)
		{
			throw new Exception("Pool is empty");
		}
		float val = this.pool[this._cursor.val];
		this._cursor.val = (this._cursor.val + 1) % this.pool.Length;
		return (int)(val * (float)(max - min + 1)) + min;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000CC8C File Offset: 0x0000AE8C
	public Dice.State Roll()
	{
		int val = this.GetRange(this.Range.Item1, this.Range.Item2);
		int bonus = 0;
		string type = this.Type;
		string a = type;
		if (!(a == "Default"))
		{
			if (!(a == "Value"))
			{
				if (!(a == "Check"))
				{
					throw new Exception("Unknown dice type: " + this.Type);
				}
				bool flag = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
				if (flag)
				{
					bonus = -FightManager.Instance.TempVarsMap["Lucky"];
				}
				else
				{
					bonus = -RoleTable.Instance.VarsMap["Lucky"];
				}
			}
			else
			{
				bool flag2 = FightManager.Instance != null && FightManager.Instance.fightType > FightType.None;
				if (flag2)
				{
					bonus = FightManager.Instance.TempVarsMap["Lucky"] * (this.Range.Item2 - this.Range.Item1) / 100;
				}
				else
				{
					bonus = RoleTable.Instance.VarsMap["Lucky"] * (this.Range.Item2 - this.Range.Item1) / 100;
				}
			}
		}
		bool flag3 = this.Type == "Check";
		if (flag3)
		{
			val += bonus;
		}
		else
		{
			val = Math.Max(this.Range.Item1, val + bonus);
			val = Math.Min(this.Range.Item2, val);
		}
		return new Dice.State(val, bonus);
	}

	// Token: 0x040000C3 RID: 195
	[JsonProperty]
	internal Dice.RandomCursor _cursor = new Dice.RandomCursor(0);

	// Token: 0x02000033 RID: 51
	public class State
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000CE41 File Offset: 0x0000B041
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000CE49 File Offset: 0x0000B049
		public int Value { get; private set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000CE52 File Offset: 0x0000B052
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000CE5A File Offset: 0x0000B05A
		public int Bonus { get; private set; }

		// Token: 0x06000155 RID: 341 RVA: 0x0000CE63 File Offset: 0x0000B063
		public State(int value, int bonus)
		{
			this.Value = value;
			this.Bonus = bonus;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000CE7D File Offset: 0x0000B07D
		public void CopyTo(Dice.State state)
		{
			state.Value = this.Value;
			state.Bonus = this.Bonus;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000CE9C File Offset: 0x0000B09C
		public static Dice.State operator +(Dice.State a, Dice.State b)
		{
			return new Dice.State(a.Value + b.Value, a.Bonus + b.Bonus);
		}
	}

	// Token: 0x02000034 RID: 52
	internal class RandomCursor
	{
		// Token: 0x06000158 RID: 344 RVA: 0x0000CECD File Offset: 0x0000B0CD
		public RandomCursor(int val)
		{
			this.val = val;
		}

		// Token: 0x040000C6 RID: 198
		public int val;
	}
}
