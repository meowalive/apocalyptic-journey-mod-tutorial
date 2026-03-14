using System;
using System.Collections.Generic;

namespace XLua
{
	// Token: 0x02000175 RID: 373
	public class ObjectPool
	{
		// Token: 0x17000108 RID: 264
		public object this[int i]
		{
			get
			{
				bool flag = i >= 0 && i < this.count;
				object result;
				if (flag)
				{
					result = this.list[i].obj;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0005A528 File Offset: 0x00058728
		public void Clear()
		{
			this.freelist = -1;
			this.count = 0;
			this.list = new ObjectPool.Slot[512];
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0005A54C File Offset: 0x0005874C
		private void extend_capacity()
		{
			ObjectPool.Slot[] new_list = new ObjectPool.Slot[this.list.Length * 2];
			for (int i = 0; i < this.list.Length; i++)
			{
				new_list[i] = this.list[i];
			}
			this.list = new_list;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0005A5A0 File Offset: 0x000587A0
		public int Add(object obj)
		{
			bool flag = this.freelist != -1;
			int index;
			if (flag)
			{
				index = this.freelist;
				this.list[index].obj = obj;
				this.freelist = this.list[index].next;
				this.list[index].next = -2;
			}
			else
			{
				bool flag2 = this.count == this.list.Length;
				if (flag2)
				{
					this.extend_capacity();
				}
				index = this.count;
				this.list[index] = new ObjectPool.Slot(-2, obj);
				this.count = index + 1;
			}
			return index;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0005A650 File Offset: 0x00058850
		public bool TryGetValue(int index, out object obj)
		{
			bool flag = index >= 0 && index < this.count && this.list[index].next == -2;
			bool result;
			if (flag)
			{
				obj = this.list[index].obj;
				result = true;
			}
			else
			{
				obj = null;
				result = false;
			}
			return result;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0005A6A8 File Offset: 0x000588A8
		public object Get(int index)
		{
			bool flag = index >= 0 && index < this.count;
			object result;
			if (flag)
			{
				result = this.list[index].obj;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0005A6E4 File Offset: 0x000588E4
		public object Remove(int index)
		{
			bool flag = index >= 0 && index < this.count && this.list[index].next == -2;
			object result;
			if (flag)
			{
				object o = this.list[index].obj;
				this.list[index].obj = null;
				this.list[index].next = this.freelist;
				this.freelist = index;
				result = o;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0005A768 File Offset: 0x00058968
		public object Replace(int index, object o)
		{
			bool flag = index >= 0 && index < this.count;
			object result;
			if (flag)
			{
				object obj = this.list[index].obj;
				this.list[index].obj = o;
				result = obj;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0005A7B8 File Offset: 0x000589B8
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map)
		{
			bool flag = this.count == 0;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				for (int i = 0; i < Math.Min(max_check, this.count); i++)
				{
					check_pos %= this.count;
					bool flag2 = this.list[check_pos].next == -2 && this.list[check_pos].obj != null;
					if (flag2)
					{
						bool flag3 = !checker(this.list[check_pos].obj);
						if (flag3)
						{
							object obj = this.Replace(check_pos, null);
							int obj_index;
							bool flag4 = reverse_map.TryGetValue(obj, out obj_index) && obj_index == check_pos;
							if (flag4)
							{
								reverse_map.Remove(obj);
							}
						}
					}
					check_pos++;
				}
				check_pos = (result = check_pos % this.count);
			}
			return result;
		}

		// Token: 0x04000D7C RID: 3452
		private const int LIST_END = -1;

		// Token: 0x04000D7D RID: 3453
		private const int ALLOCED = -2;

		// Token: 0x04000D7E RID: 3454
		private ObjectPool.Slot[] list = new ObjectPool.Slot[512];

		// Token: 0x04000D7F RID: 3455
		private int freelist = -1;

		// Token: 0x04000D80 RID: 3456
		private int count = 0;

		// Token: 0x02000176 RID: 374
		private struct Slot
		{
			// Token: 0x06000B5D RID: 2909 RVA: 0x0005A8CA File Offset: 0x00058ACA
			public Slot(int next, object obj)
			{
				this.next = next;
				this.obj = obj;
			}

			// Token: 0x04000D81 RID: 3457
			public int next;

			// Token: 0x04000D82 RID: 3458
			public object obj;
		}
	}
}
