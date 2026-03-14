using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Rougamo;
using Rougamo.Context;

// Token: 0x02000073 RID: 115
public class PropertyWatcher : Singleton<PropertyWatcher>
{
	// Token: 0x060003A6 RID: 934 RVA: 0x0001E644 File Offset: 0x0001C844
	[DebuggerStepThrough]
	public PropertyChangedEventHandler AddListener(INotifyPropertyChanged classBody, string propertyName, Action action)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(PropertyWatcher);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(PropertyWatcher.AddListener(INotifyPropertyChanged, string, Action)).MethodHandle, typeof(PropertyWatcher).TypeHandle);
		methodContext.Arguments = new object[]
		{
			classBody,
			propertyName,
			action
		};
		PropertyChangedEventHandler propertyChangedEventHandler;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						classBody = null;
					}
					else
					{
						classBody = (INotifyPropertyChanged)arguments[0];
					}
					if (arguments[1] == null)
					{
						propertyName = null;
					}
					else
					{
						propertyName = (string)arguments[1];
					}
					if (arguments[2] == null)
					{
						action = null;
					}
					else
					{
						action = (Action)arguments[2];
					}
				}
				do
				{
					try
					{
						propertyChangedEventHandler = this.$Rougamo_AddListener(classBody, propertyName, action);
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
							propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_17F;
						}
						throw;
					}
					methodContext.ReturnValue = propertyChangedEventHandler;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_17F:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return propertyChangedEventHandler;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0001E810 File Offset: 0x0001CA10
	[DebuggerStepThrough]
	public PropertyChangedEventHandler AddListener(INotifyPropertyChanged classBody, string propertyName, Action<int> action)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(PropertyWatcher);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(PropertyWatcher.AddListener(INotifyPropertyChanged, string, Action<int>)).MethodHandle, typeof(PropertyWatcher).TypeHandle);
		methodContext.Arguments = new object[]
		{
			classBody,
			propertyName,
			action
		};
		PropertyChangedEventHandler propertyChangedEventHandler;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						classBody = null;
					}
					else
					{
						classBody = (INotifyPropertyChanged)arguments[0];
					}
					if (arguments[1] == null)
					{
						propertyName = null;
					}
					else
					{
						propertyName = (string)arguments[1];
					}
					if (arguments[2] == null)
					{
						action = null;
					}
					else
					{
						action = (Action<int>)arguments[2];
					}
				}
				do
				{
					try
					{
						propertyChangedEventHandler = this.$Rougamo_AddListener(classBody, propertyName, action);
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
							propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_17F;
						}
						throw;
					}
					methodContext.ReturnValue = propertyChangedEventHandler;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_17F:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return propertyChangedEventHandler;
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0001E9DC File Offset: 0x0001CBDC
	[DebuggerStepThrough]
	public PropertyChangedEventHandler AddListener(INotifyPropertyChanged classBody, string propertyName, Action<string> action)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(PropertyWatcher);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(PropertyWatcher.AddListener(INotifyPropertyChanged, string, Action<string>)).MethodHandle, typeof(PropertyWatcher).TypeHandle);
		methodContext.Arguments = new object[]
		{
			classBody,
			propertyName,
			action
		};
		PropertyChangedEventHandler propertyChangedEventHandler;
		try
		{
			modifiable.OnEntry(methodContext);
			if (methodContext.ReturnValueReplaced)
			{
				propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
				modifiable.OnExit(methodContext);
			}
			else
			{
				if (methodContext.RewriteArguments)
				{
					object[] arguments = methodContext.Arguments;
					if (arguments[0] == null)
					{
						classBody = null;
					}
					else
					{
						classBody = (INotifyPropertyChanged)arguments[0];
					}
					if (arguments[1] == null)
					{
						propertyName = null;
					}
					else
					{
						propertyName = (string)arguments[1];
					}
					if (arguments[2] == null)
					{
						action = null;
					}
					else
					{
						action = (Action<string>)arguments[2];
					}
				}
				do
				{
					try
					{
						propertyChangedEventHandler = this.$Rougamo_AddListener(classBody, propertyName, action);
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
							propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
						}
						modifiable.OnExit(methodContext);
						if (exceptionHandled)
						{
							goto IL_17F;
						}
						throw;
					}
					methodContext.ReturnValue = propertyChangedEventHandler;
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				if (methodContext.ReturnValueReplaced)
				{
					propertyChangedEventHandler = (PropertyChangedEventHandler)methodContext.ReturnValue;
				}
				modifiable.OnExit(methodContext);
				IL_17F:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
		return propertyChangedEventHandler;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
	[DebuggerStepThrough]
	public void RemoveListener(INotifyPropertyChanged classBody, PropertyChangedEventHandler handler)
	{
		Modifiable modifiable = new Modifiable();
		MethodContext methodContext = RougamoPool<MethodContext>.Get();
		methodContext.Mos = (IReadOnlyList<IMo>)new IMo[]
		{
			modifiable
		};
		methodContext.Target = this;
		methodContext.TargetType = typeof(PropertyWatcher);
		methodContext.Method = MethodBase.GetMethodFromHandle(methodof(PropertyWatcher.RemoveListener(INotifyPropertyChanged, PropertyChangedEventHandler)).MethodHandle, typeof(PropertyWatcher).TypeHandle);
		methodContext.Arguments = new object[]
		{
			classBody,
			handler
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
						classBody = null;
					}
					else
					{
						classBody = (INotifyPropertyChanged)arguments[0];
					}
					if (arguments[1] == null)
					{
						handler = null;
					}
					else
					{
						handler = (PropertyChangedEventHandler)arguments[1];
					}
				}
				do
				{
					try
					{
						this.$Rougamo_RemoveListener(classBody, handler);
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
							goto IL_11D;
						}
						throw;
					}
					modifiable.OnSuccess(methodContext);
				}
				while (methodContext.RetryCount > 0);
				modifiable.OnExit(methodContext);
				IL_11D:;
			}
		}
		finally
		{
			RougamoPool<MethodContext>.Return(methodContext);
		}
	}

	// Token: 0x060003AB RID: 939 RVA: 0x0001ED08 File Offset: 0x0001CF08
	private PropertyChangedEventHandler $Rougamo_AddListener(INotifyPropertyChanged classBody, string propertyName, Action action)
	{
		PropertyChangedEventHandler handler = delegate(object sender, PropertyChangedEventArgs args)
		{
			bool flag = args.PropertyName == propertyName;
			if (flag)
			{
				action();
			}
		};
		classBody.PropertyChanged += handler;
		return handler;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0001ED44 File Offset: 0x0001CF44
	private PropertyChangedEventHandler $Rougamo_AddListener(INotifyPropertyChanged classBody, string propertyName, Action<int> action)
	{
		PropertyChangedEventHandler handler = delegate(object sender, PropertyChangedEventArgs args)
		{
			bool flag = args.PropertyName == propertyName;
			if (flag)
			{
				int value = int.Parse(classBody.GetType().GetProperty(propertyName).GetValue(classBody).ToString());
				action(value);
			}
		};
		classBody.PropertyChanged += handler;
		return handler;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x0001ED8C File Offset: 0x0001CF8C
	private PropertyChangedEventHandler $Rougamo_AddListener(INotifyPropertyChanged classBody, string propertyName, Action<string> action)
	{
		PropertyChangedEventHandler handler = delegate(object sender, PropertyChangedEventArgs args)
		{
			bool flag = args.PropertyName == propertyName;
			if (flag)
			{
				string value = classBody.GetType().GetProperty(propertyName).GetValue(classBody).ToString();
				action(value);
			}
		};
		classBody.PropertyChanged += handler;
		return handler;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0001EDD4 File Offset: 0x0001CFD4
	private void $Rougamo_RemoveListener(INotifyPropertyChanged classBody, PropertyChangedEventHandler handler)
	{
		classBody.PropertyChanged -= handler;
	}
}
