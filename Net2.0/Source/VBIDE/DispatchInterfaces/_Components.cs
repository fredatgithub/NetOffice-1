//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.VBIDEApi
{
	///<summary>
	/// DispatchInterface _Components SupportByLibrary VBE5.3 VBE12 
	///</summary>
	[SupportByLibrary("VBE5.3","VBE12")]
	public class _Components : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Components(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Components(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Components(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Components()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.VBIDEApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.VBIDEApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.VBProject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.VBIDEApi.VBProject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.VBIDEApi.VBProject;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		[SupportByLibrary("VBE5.3","VBE12")]
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
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				LateBindingApi.VBIDEApi.VBE newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.VBIDEApi.VBE;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.Component Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.VBIDEApi.Component newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.VBIDEApi.Component;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="Component">LateBindingApi.VBIDEApi.Component Component</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public void Remove(LateBindingApi.VBIDEApi.Component component)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(component);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="ComponentType">LateBindingApi.VBIDEApi.Enums.vbext_ComponentType ComponentType</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.Component Add(LateBindingApi.VBIDEApi.Enums.vbext_ComponentType componentType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(componentType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.VBIDEApi.Component newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.VBIDEApi.Component;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public LateBindingApi.VBIDEApi.Component Import(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Import", paramsArray);
			LateBindingApi.VBIDEApi.Component newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.VBIDEApi.Component;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("VBE5.3","VBE12")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
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