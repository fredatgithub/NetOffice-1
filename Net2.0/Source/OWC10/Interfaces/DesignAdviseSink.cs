//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{
	///<summary>
	/// Interface DesignAdviseSink SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class DesignAdviseSink : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DesignAdviseSink(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DesignAdviseSink(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DesignAdviseSink(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DesignAdviseSink()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="dscobjtyp">LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp</param>
		/// <param name="varObject">object varObject</param>
		/// <param name="fGrid">Int32 fGrid</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ObjectAdded(LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp, object varObject, Int32 fGrid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dscobjtyp, varObject, fGrid);
			object returnItem = Invoker.MethodReturn(this, "ObjectAdded", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="dscobjtyp">LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp</param>
		/// <param name="varObject">object varObject</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ObjectDeleted(LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp, object varObject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dscobjtyp, varObject);
			object returnItem = Invoker.MethodReturn(this, "ObjectDeleted", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="dscobjtyp">LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp</param>
		/// <param name="varObject">object varObject</param>
		/// <param name="bstrRsd">string bstrRsd</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ObjectMoved(LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp, object varObject, string bstrRsd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dscobjtyp, varObject, bstrRsd);
			object returnItem = Invoker.MethodReturn(this, "ObjectMoved", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 DataModelLoad()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DataModelLoad", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="dscobjtyp">LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp</param>
		/// <param name="varObject">object varObject</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ObjectChanged(LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp, object varObject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dscobjtyp, varObject);
			object returnItem = Invoker.MethodReturn(this, "ObjectChanged", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="dscobjtyp">LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ObjectDeleteComplete(LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dscobjtyp);
			object returnItem = Invoker.MethodReturn(this, "ObjectDeleteComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="dscobjtyp">LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp</param>
		/// <param name="varObject">object varObject</param>
		/// <param name="bstrPreviousName">string bstrPreviousName</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 ObjectRenamed(LateBindingApi.OWC10Api.Enums.DscObjectTypeEnum dscobjtyp, object varObject, string bstrPreviousName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dscobjtyp, varObject, bstrPreviousName);
			object returnItem = Invoker.MethodReturn(this, "ObjectRenamed", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}