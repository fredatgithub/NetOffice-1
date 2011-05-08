//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.DAOApi
{
	///<summary>
	/// DispatchInterface Containers SupportByLibrary DAO3.6 DAO12 
	///</summary>
	[SupportByLibrary("DAO3.6","DAO12")]
	public class Containers : _Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Containers(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Containers(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Containers(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Containers()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public LateBindingApi.DAOApi.Container get_Item(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.DAOApi.Container newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.DAOApi.Container;
			return newObject;
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}