//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Recordset15 SupportByLibrary ADODB, 2.1,2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Recordset15 : _ADO
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Recordset15);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset15(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset15(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset15(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset15() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset15(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.PositionEnum AbsolutePosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePosition", paramsArray);
				return (NetOffice.ADODBApi.Enums.PositionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public COMObject ActiveConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveConnection", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActiveConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool BOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object Bookmark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bookmark", paramsArray);
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
				Invoker.PropertySet(this, "Bookmark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 CacheSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CacheSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CursorTypeEnum CursorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorType", paramsArray);
				return (NetOffice.ADODBApi.Enums.CursorTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool EOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.ADODBApi.Fields newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Fields.LateBindingApiWrapperType) as NetOffice.ADODBApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.LockTypeEnum LockType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockType", paramsArray);
				return (NetOffice.ADODBApi.Enums.LockTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 MaxRecords
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxRecords", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxRecords", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 RecordCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public COMObject Source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Source", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Source", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.PositionEnum AbsolutePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePage", paramsArray);
				return (NetOffice.ADODBApi.Enums.PositionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.EditModeEnum EditMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EditMode", paramsArray);
				return (NetOffice.ADODBApi.Enums.EditModeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
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
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 PageCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 PageSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PageSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string Sort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sort", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sort", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 Status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Status", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CursorLocationEnum CursorLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorLocation", paramsArray);
				return (NetOffice.ADODBApi.Enums.CursorLocationEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object get_Collect(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Collect", paramsArray);
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

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void set_Collect(object index, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "Collect", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.MarshalOptionsEnum MarshalOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarshalOptions", paramsArray);
				return (NetOffice.ADODBApi.Enums.MarshalOptionsEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarshalOptions", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="FieldList">optional object FieldList</param>
		/// <param name="Values">optional object Values</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void AddNew(object fieldList, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldList, values);
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void AddNew()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void CancelUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CancelUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Delete(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		/// <param name="Start">optional object Start</param>
		/// <param name="Fields">optional object Fields</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object GetRows(Int32 rows, object start, object fields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows, start, fields);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
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

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object GetRows(Int32 rows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
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

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="NumRecords">Int32 NumRecords</param>
		/// <param name="Start">optional object Start</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Move(Int32 numRecords, object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRecords, start);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="NumRecords">Int32 NumRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Move(Int32 numRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRecords);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MoveNext()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveNext", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MovePrevious()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MovePrevious", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MoveFirst()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveFirst", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MoveLast()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveLast", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="ActiveConnection">object ActiveConnection</param>
		/// <param name="CursorType">NetOffice.ADODBApi.Enums.CursorTypeEnum CursorType</param>
		/// <param name="LockType">NetOffice.ADODBApi.Enums.LockTypeEnum LockType</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Open(object source, object activeConnection, NetOffice.ADODBApi.Enums.CursorTypeEnum cursorType, NetOffice.ADODBApi.Enums.LockTypeEnum lockType, Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, activeConnection, cursorType, lockType, options);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Requery(Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void _xResync(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "_xResync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Fields">optional object Fields</param>
		/// <param name="Values">optional object Values</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Update(object fields, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fields, values);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset _xClone()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_xClone", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void UpdateBatch(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "UpdateBatch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void CancelBatch(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "CancelBatch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="RecordsAffected">optional object RecordsAffected</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset NextRecordset(object recordsAffected)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recordsAffected);
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset NextRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="CursorOptions">NetOffice.ADODBApi.Enums.CursorOptionEnum CursorOptions</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool Supports(NetOffice.ADODBApi.Enums.CursorOptionEnum cursorOptions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cursorOptions);
			object returnItem = Invoker.MethodReturn(this, "Supports", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		/// <param name="SkipRecords">Int32 SkipRecords</param>
		/// <param name="SearchDirection">NetOffice.ADODBApi.Enums.SearchDirectionEnum SearchDirection</param>
		/// <param name="Start">optional object Start</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Find(string criteria, Int32 skipRecords, NetOffice.ADODBApi.Enums.SearchDirectionEnum searchDirection, object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria, skipRecords, searchDirection, start);
			Invoker.Method(this, "Find", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		/// <param name="SkipRecords">Int32 SkipRecords</param>
		/// <param name="SearchDirection">NetOffice.ADODBApi.Enums.SearchDirectionEnum SearchDirection</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Find(string criteria, Int32 skipRecords, NetOffice.ADODBApi.Enums.SearchDirectionEnum searchDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria, skipRecords, searchDirection);
			Invoker.Method(this, "Find", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}