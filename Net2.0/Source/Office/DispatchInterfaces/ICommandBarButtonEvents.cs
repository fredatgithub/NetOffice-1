//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface ICommandBarButtonEvents SupportByLibrary OF09 OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
	public class ICommandBarButtonEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICommandBarButtonEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICommandBarButtonEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICommandBarButtonEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICommandBarButtonEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Ctrl">LateBindingApi.OfficeApi.CommandBarButton Ctrl</param>
		/// <param name="CancelDefault">ref bool CancelDefault</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void Click(LateBindingApi.OfficeApi.CommandBarButton ctrl, ref bool cancelDefault)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(ctrl, cancelDefault);
			Invoker.Method(this, "Click", paramsArray, modifiers);
			cancelDefault = (bool)paramsArray[1];
		}

		#endregion
		#pragma warning restore
	}
}