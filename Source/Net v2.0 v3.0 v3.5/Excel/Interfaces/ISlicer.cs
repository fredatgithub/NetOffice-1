//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISlicer SupportByLibrary Excel, 14
	///</summary>
	[SupportByLibrary("Excel", 14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISlicer : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ISlicer);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicer(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicer(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicer(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicer() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISlicer(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
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
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
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
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Double Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Double Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public bool DisableMoveResizeUI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisableMoveResizeUI", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisableMoveResizeUI", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Double Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Double Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Double RowHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowHeight", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RowHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Double ColumnWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnWidth", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColumnWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Int32 NumberOfColumns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberOfColumns", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberOfColumns", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public bool DisplayHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayHeader", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayHeader", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public bool Locked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Locked", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Locked", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.SlicerCache SlicerCache
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlicerCache", paramsArray);
				NetOffice.ExcelApi.SlicerCache newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SlicerCache.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCache;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.SlicerCacheLevel SlicerCacheLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlicerCacheLevel", paramsArray);
				NetOffice.ExcelApi.SlicerCacheLevel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SlicerCacheLevel.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerCacheLevel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.ExcelApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Shape.LateBindingApiWrapperType) as NetOffice.ExcelApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public object Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public NetOffice.ExcelApi.SlicerItem ActiveItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveItem", paramsArray);
				NetOffice.ExcelApi.SlicerItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.SlicerItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.SlicerItem;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Int32 Cut()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Cut", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		[SupportByLibrary("Excel", 14)]
		public Int32 Copy()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}