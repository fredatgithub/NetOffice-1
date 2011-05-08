//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// DispatchInterface Windows SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	public class Windows : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Windows(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Windows(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Windows(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Windows()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Window get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.ExcelApi.Window newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Window;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("IndexerItem")]
		public LateBindingApi.ExcelApi.Window this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			LateBindingApi.ExcelApi.Window newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Window;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool SyncScrollingSideBySide
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SyncScrollingSideBySide", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SyncScrollingSideBySide", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="ArrangeStyle">LateBindingApi.ExcelApi.Enums.XlArrangeStyle ArrangeStyle</param>
		/// <param name="ActiveWorkbook">optional object ActiveWorkbook</param>
		/// <param name="SyncHorizontal">optional object SyncHorizontal</param>
		/// <param name="SyncVertical">optional object SyncVertical</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object Arrange(LateBindingApi.ExcelApi.Enums.XlArrangeStyle arrangeStyle, object activeWorkbook, object syncHorizontal, object syncVertical)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arrangeStyle, activeWorkbook, syncHorizontal, syncVertical);
			object returnItem = Invoker.MethodReturn(this, "Arrange", paramsArray);
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
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		/// <param name="ArrangeStyle">LateBindingApi.ExcelApi.Enums.XlArrangeStyle ArrangeStyle</param>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public object Arrange(LateBindingApi.ExcelApi.Enums.XlArrangeStyle arrangeStyle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arrangeStyle);
			object returnItem = Invoker.MethodReturn(this, "Arrange", paramsArray);
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
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="WindowName">object WindowName</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool CompareSideBySideWith(object windowName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(windowName);
			object returnItem = Invoker.MethodReturn(this, "CompareSideBySideWith", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool BreakSideBySide()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "BreakSideBySide", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void ResetPositionsSideBySide()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetPositionsSideBySide", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}