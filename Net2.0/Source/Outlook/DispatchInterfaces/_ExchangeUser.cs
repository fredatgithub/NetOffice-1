//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{
	///<summary>
	/// DispatchInterface _ExchangeUser SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	public class _ExchangeUser : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeUser(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeUser(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeUser(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ExchangeUser()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				LateBindingApi.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
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
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlDisplayType DisplayType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayType", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlDisplayType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressEntry Manager
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Manager", paramsArray);
				LateBindingApi.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.AddressEntry;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public COMObject MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MAPIOBJECT", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressEntries Members
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Members", paramsArray);
				LateBindingApi.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.AddressEntries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlAddressEntryUserType AddressEntryUserType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressEntryUserType", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlAddressEntryUserType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.PropertyAccessor PropertyAccessor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyAccessor", paramsArray);
				LateBindingApi.OutlookApi.PropertyAccessor newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.PropertyAccessor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Alias
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string AssistantName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AssistantName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AssistantName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string BusinessTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BusinessTelephoneNumber", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BusinessTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string City
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "City", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "City", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Comments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comments", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string CompanyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CompanyName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CompanyName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string Department
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Department", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Department", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string FirstName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FirstName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string JobTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "JobTitle", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "JobTitle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string LastName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LastName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string MobileTelephoneNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MobileTelephoneNumber", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MobileTelephoneNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string OfficeLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OfficeLocation", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OfficeLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string PostalCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PostalCode", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PostalCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string PrimarySmtpAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PrimarySmtpAddress", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string StateOrProvince
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StateOrProvince", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StateOrProvince", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string StreetAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StreetAddress", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StreetAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string YomiCompanyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiCompanyName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiCompanyName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string YomiFirstName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiFirstName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiFirstName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string YomiLastName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiLastName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiLastName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string YomiDisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiDisplayName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiDisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string YomiDepartment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "YomiDepartment", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "YomiDepartment", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="HWnd">optional object HWnd</param>
		[SupportByLibrary("OL12","OL14")]
		public void Details(object hWnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hWnd);
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public void Details()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Details", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Start">DateTime Start</param>
		/// <param name="MinPerChar">Int32 MinPerChar</param>
		/// <param name="CompleteFormat">optional object CompleteFormat</param>
		[SupportByLibrary("OL12","OL14")]
		public string GetFreeBusy(DateTime start, Int32 minPerChar, object completeFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar, completeFormat);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Start">DateTime Start</param>
		/// <param name="MinPerChar">Int32 MinPerChar</param>
		[SupportByLibrary("OL12","OL14")]
		public string GetFreeBusy(DateTime start, Int32 minPerChar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, minPerChar);
			object returnItem = Invoker.MethodReturn(this, "GetFreeBusy", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="MakePermanent">optional object MakePermanent</param>
		/// <param name="Refresh">optional object Refresh</param>
		[SupportByLibrary("OL12","OL14")]
		public void Update(object makePermanent, object refresh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(makePermanent, refresh);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public void UpdateFreeBusy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateFreeBusy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi._ContactItem GetContact()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetContact", paramsArray);
			LateBindingApi.OutlookApi._ContactItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi._ContactItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.ExchangeUser GetExchangeUser()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeUser", paramsArray);
			LateBindingApi.OutlookApi.ExchangeUser newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.ExchangeUser;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.ExchangeDistributionList GetExchangeDistributionList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeDistributionList", paramsArray);
			LateBindingApi.OutlookApi.ExchangeDistributionList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.ExchangeDistributionList;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressEntries GetDirectReports()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetDirectReports", paramsArray);
			LateBindingApi.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.AddressEntries;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressEntries GetMemberOfList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetMemberOfList", paramsArray);
			LateBindingApi.OutlookApi.AddressEntries newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.AddressEntries;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.ExchangeUser GetExchangeUserManager()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetExchangeUserManager", paramsArray);
			LateBindingApi.OutlookApi.ExchangeUser newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.ExchangeUser;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		[SupportByLibrary("OL14")]
		public stdole.Picture GetPicture()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetPicture", paramsArray);
			stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as stdole.Picture;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}