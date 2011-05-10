//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface SmartTagType SupportByLibrary WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD11","WD12","WD14")]
	public class SmartTagType : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagType(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagType(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagType(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagType()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
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
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.SmartTagActions SmartTagActions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTagActions", paramsArray);
				NetOffice.WordApi.SmartTagActions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.SmartTagActions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.SmartTagRecognizers SmartTagRecognizers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTagRecognizers", paramsArray);
				NetOffice.WordApi.SmartTagRecognizers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.SmartTagRecognizers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public string FriendlyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FriendlyName", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}