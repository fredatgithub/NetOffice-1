//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{
	///<summary>
	/// DispatchInterface Windows SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
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
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.ISpreadsheet Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OWC10Api.ISpreadsheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OWC10Api.ISpreadsheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
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
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
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
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Window get_Item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.OWC10Api.Window newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OWC10Api.Window;
			return newObject;
		}

		#endregion

		#region Methods

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XWC1.0")]
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