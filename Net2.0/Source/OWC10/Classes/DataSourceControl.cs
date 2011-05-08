//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{

	#region Delegates

	#pragma warning disable
	public delegate void DataSourceControl_CurrentEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeExpandEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeCollapseEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeFirstPageEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforePreviousPageEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeNextPageEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeLastPageEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_DataErrorEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_DataPageCompleteEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeInitialBindEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_RecordsetSaveProgressEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_AfterDeleteEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_AfterInsertEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_AfterUpdateEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeDeleteEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeInsertEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeOverwriteEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_BeforeUpdateEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_DirtyEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_RecordExitEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_UndoEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	public delegate void DataSourceControl_FocusEventHandler(LateBindingApi.OWC10Api.DSCEventInfo DSCEventInfo);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass DataSourceControl SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class DataSourceControl : IDataSourceControl, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_DataSourceControlEvent_SinkHelper __DataSourceControlEvent_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSourceControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public DataSourceControl()
		{
			CreateFromProgId("OWC10.DataSourceControl");
		}
		
		/// <param name="progId">progId</param>
		public DataSourceControl(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _DataSourceControlEvent_SinkHelper.Id);


			if(_DataSourceControlEvent_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__DataSourceControlEvent_SinkHelper = new _DataSourceControlEvent_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_CurrentEventHandler _CurrentEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_CurrentEventHandler CurrentEvent
		{
			add
			{
				CreateEventBridge();
				_CurrentEvent += value;
			}
			remove
			{
				_CurrentEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeExpandEventHandler _BeforeExpandEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeExpandEventHandler BeforeExpandEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeExpandEvent += value;
			}
			remove
			{
				_BeforeExpandEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeCollapseEventHandler _BeforeCollapseEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeCollapseEventHandler BeforeCollapseEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCollapseEvent += value;
			}
			remove
			{
				_BeforeCollapseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeFirstPageEventHandler _BeforeFirstPageEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeFirstPageEventHandler BeforeFirstPageEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeFirstPageEvent += value;
			}
			remove
			{
				_BeforeFirstPageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforePreviousPageEventHandler _BeforePreviousPageEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforePreviousPageEventHandler BeforePreviousPageEvent
		{
			add
			{
				CreateEventBridge();
				_BeforePreviousPageEvent += value;
			}
			remove
			{
				_BeforePreviousPageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeNextPageEventHandler _BeforeNextPageEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeNextPageEventHandler BeforeNextPageEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeNextPageEvent += value;
			}
			remove
			{
				_BeforeNextPageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeLastPageEventHandler _BeforeLastPageEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeLastPageEventHandler BeforeLastPageEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeLastPageEvent += value;
			}
			remove
			{
				_BeforeLastPageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_DataErrorEventHandler _DataErrorEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_DataErrorEventHandler DataErrorEvent
		{
			add
			{
				CreateEventBridge();
				_DataErrorEvent += value;
			}
			remove
			{
				_DataErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_DataPageCompleteEventHandler _DataPageCompleteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_DataPageCompleteEventHandler DataPageCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_DataPageCompleteEvent += value;
			}
			remove
			{
				_DataPageCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeInitialBindEventHandler _BeforeInitialBindEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeInitialBindEventHandler BeforeInitialBindEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeInitialBindEvent += value;
			}
			remove
			{
				_BeforeInitialBindEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_RecordsetSaveProgressEventHandler _RecordsetSaveProgressEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_RecordsetSaveProgressEventHandler RecordsetSaveProgressEvent
		{
			add
			{
				CreateEventBridge();
				_RecordsetSaveProgressEvent += value;
			}
			remove
			{
				_RecordsetSaveProgressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_AfterDeleteEventHandler _AfterDeleteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_AfterDeleteEventHandler AfterDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_AfterDeleteEvent += value;
			}
			remove
			{
				_AfterDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_AfterInsertEventHandler _AfterInsertEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_AfterInsertEventHandler AfterInsertEvent
		{
			add
			{
				CreateEventBridge();
				_AfterInsertEvent += value;
			}
			remove
			{
				_AfterInsertEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeDeleteEventHandler _BeforeDeleteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeDeleteEventHandler BeforeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDeleteEvent += value;
			}
			remove
			{
				_BeforeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeInsertEventHandler _BeforeInsertEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeInsertEventHandler BeforeInsertEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeInsertEvent += value;
			}
			remove
			{
				_BeforeInsertEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeOverwriteEventHandler _BeforeOverwriteEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeOverwriteEventHandler BeforeOverwriteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeOverwriteEvent += value;
			}
			remove
			{
				_BeforeOverwriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_DirtyEventHandler _DirtyEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_DirtyEventHandler DirtyEvent
		{
			add
			{
				CreateEventBridge();
				_DirtyEvent += value;
			}
			remove
			{
				_DirtyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_RecordExitEventHandler _RecordExitEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_RecordExitEventHandler RecordExitEvent
		{
			add
			{
				CreateEventBridge();
				_RecordExitEvent += value;
			}
			remove
			{
				_RecordExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_UndoEventHandler _UndoEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_UndoEventHandler UndoEvent
		{
			add
			{
				CreateEventBridge();
				_UndoEvent += value;
			}
			remove
			{
				_UndoEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		private event DataSourceControl_FocusEventHandler _FocusEvent;

		/// <summary>
		/// SupportByLibrary XWC1.0
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public event DataSourceControl_FocusEventHandler FocusEvent
		{
			add
			{
				CreateEventBridge();
				_FocusEvent += value;
			}
			remove
			{
				_FocusEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != __DataSourceControlEvent_SinkHelper)
			{
				__DataSourceControlEvent_SinkHelper.Dispose();
				__DataSourceControlEvent_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}