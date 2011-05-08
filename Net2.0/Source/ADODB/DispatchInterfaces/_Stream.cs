//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ADODBApi
{
	///<summary>
	/// DispatchInterface _Stream SupportByLibrary ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.5")]
	public class _Stream : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Stream(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Stream(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Stream(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Stream()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public Int32 Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public bool EOS
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EOS", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public Int32 Position
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Position", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Position", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.StreamTypeEnum Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.StreamTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.LineSeparatorEnum LineSeparator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineSeparator", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.LineSeparatorEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LineSeparator", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.ObjectStateEnum State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.ObjectStateEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.ConnectModeEnum Mode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mode", paramsArray);
				return (LateBindingApi.ADODBApi.Enums.ConnectModeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public string Charset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Charset", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Charset", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="NumBytes">Int32 NumBytes</param>
		[SupportByLibrary("ADO2.5")]
		public object Read(Int32 numBytes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numBytes);
			object returnItem = Invoker.MethodReturn(this, "Read", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="Mode">LateBindingApi.ADODBApi.Enums.ConnectModeEnum Mode</param>
		/// <param name="Options">LateBindingApi.ADODBApi.Enums.StreamOpenOptionsEnum Options</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		[SupportByLibrary("ADO2.5")]
		public void Open(object source, LateBindingApi.ADODBApi.Enums.ConnectModeEnum mode, LateBindingApi.ADODBApi.Enums.StreamOpenOptionsEnum options, string userName, string password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, mode, options, userName, password);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public void SkipLine()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SkipLine", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="Buffer">object Buffer</param>
		[SupportByLibrary("ADO2.5")]
		public void Write(object buffer)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(buffer);
			Invoker.Method(this, "Write", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public void SetEOS()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetEOS", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="DestStream">LateBindingApi.ADODBApi._Stream DestStream</param>
		/// <param name="CharNumber">Int32 CharNumber</param>
		[SupportByLibrary("ADO2.5")]
		public void CopyTo(LateBindingApi.ADODBApi._Stream destStream, Int32 charNumber)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destStream, charNumber);
			Invoker.Method(this, "CopyTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public void Flush()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Flush", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="Options">LateBindingApi.ADODBApi.Enums.SaveOptionsEnum Options</param>
		[SupportByLibrary("ADO2.5")]
		public void SaveToFile(string fileName, LateBindingApi.ADODBApi.Enums.SaveOptionsEnum options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, options);
			Invoker.Method(this, "SaveToFile", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("ADO2.5")]
		public void LoadFromFile(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "LoadFromFile", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="NumChars">Int32 NumChars</param>
		[SupportByLibrary("ADO2.5")]
		public string ReadText(Int32 numChars)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numChars);
			object returnItem = Invoker.MethodReturn(this, "ReadText", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="Data">string Data</param>
		/// <param name="Options">LateBindingApi.ADODBApi.Enums.StreamWriteEnum Options</param>
		[SupportByLibrary("ADO2.5")]
		public void WriteText(string data, LateBindingApi.ADODBApi.Enums.StreamWriteEnum options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(data, options);
			Invoker.Method(this, "WriteText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.5")]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}