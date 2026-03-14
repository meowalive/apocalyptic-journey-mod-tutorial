using System;
using System.Linq;

namespace XLua
{
	// Token: 0x02000180 RID: 384
	internal static class TypeExtensions
	{
		// Token: 0x06000B6F RID: 2927 RVA: 0x0005ABCC File Offset: 0x00058DCC
		public static bool IsValueType(this Type type)
		{
			return type.IsValueType;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0005ABE4 File Offset: 0x00058DE4
		public static bool IsEnum(this Type type)
		{
			return type.IsEnum;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0005ABFC File Offset: 0x00058DFC
		public static bool IsPrimitive(this Type type)
		{
			return type.IsPrimitive;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0005AC14 File Offset: 0x00058E14
		public static bool IsAbstract(this Type type)
		{
			return type.IsAbstract;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0005AC2C File Offset: 0x00058E2C
		public static bool IsSealed(this Type type)
		{
			return type.IsSealed;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0005AC44 File Offset: 0x00058E44
		public static bool IsInterface(this Type type)
		{
			return type.IsInterface;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0005AC5C File Offset: 0x00058E5C
		public static bool IsClass(this Type type)
		{
			return type.IsClass;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0005AC74 File Offset: 0x00058E74
		public static Type BaseType(this Type type)
		{
			return type.BaseType;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0005AC8C File Offset: 0x00058E8C
		public static bool IsGenericType(this Type type)
		{
			return type.IsGenericType;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0005ACA4 File Offset: 0x00058EA4
		public static bool IsGenericTypeDefinition(this Type type)
		{
			return type.IsGenericTypeDefinition;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0005ACBC File Offset: 0x00058EBC
		public static bool IsNestedPublic(this Type type)
		{
			return type.IsNestedPublic;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0005ACD4 File Offset: 0x00058ED4
		public static bool IsPublic(this Type type)
		{
			return type.IsPublic;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0005ACEC File Offset: 0x00058EEC
		public static string GetFriendlyName(this Type type)
		{
			bool flag = type == typeof(int);
			string result;
			if (flag)
			{
				result = "int";
			}
			else
			{
				bool flag2 = type == typeof(short);
				if (flag2)
				{
					result = "short";
				}
				else
				{
					bool flag3 = type == typeof(byte);
					if (flag3)
					{
						result = "byte";
					}
					else
					{
						bool flag4 = type == typeof(bool);
						if (flag4)
						{
							result = "bool";
						}
						else
						{
							bool flag5 = type == typeof(long);
							if (flag5)
							{
								result = "long";
							}
							else
							{
								bool flag6 = type == typeof(float);
								if (flag6)
								{
									result = "float";
								}
								else
								{
									bool flag7 = type == typeof(double);
									if (flag7)
									{
										result = "double";
									}
									else
									{
										bool flag8 = type == typeof(decimal);
										if (flag8)
										{
											result = "decimal";
										}
										else
										{
											bool flag9 = type == typeof(string);
											if (flag9)
											{
												result = "string";
											}
											else
											{
												bool flag10 = type.IsGenericType();
												if (flag10)
												{
													result = type.FullName.Split('`', StringSplitOptions.None)[0] + "<" + string.Join(", ", (from x in type.GetGenericArguments()
													select x.GetFriendlyName()).ToArray<string>()) + ">";
												}
												else
												{
													result = type.FullName;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}
	}
}
