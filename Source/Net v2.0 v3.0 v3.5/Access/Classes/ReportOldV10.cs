//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void ReportOldV10_OpenEventHandler(ref Int16 Cancel);
	public delegate void ReportOldV10_CloseEventHandler();
	public delegate void ReportOldV10_ActivateEventHandler();
	public delegate void ReportOldV10_DeactivateEventHandler();
	public delegate void ReportOldV10_ErrorEventHandler(ref Int16 DataErr, ref Int16 Response);
	public delegate void ReportOldV10_NoDataEventHandler(ref Int16 Cancel);
	public delegate void ReportOldV10_PageEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass ReportOldV10 SupportByLibrary Access, 12,14
	///</summary>
	[SupportByLibrary("Access", 12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class ReportOldV10 : _Report2, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_ReportEvents_SinkHelper __ReportEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ReportOldV10);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public ReportOldV10(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ReportOldV10(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ReportOldV10(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of ReportOldV10 
        /// </summary>		
		public ReportOldV10():base("Access.ReportOldV10")
		{
		}
		
		/// <summary>
        /// creates a new instance of ReportOldV10
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public ReportOldV10(string progId):base(progId)
		{
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _ReportEvents_SinkHelper.Id);


			if(_ReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__ReportEvents_SinkHelper = new _ReportEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_ErrorEventHandler _ErrorEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_ErrorEventHandler ErrorEvent
		{
			add
			{
				CreateEventBridge();
				_ErrorEvent += value;
			}
			remove
			{
				_ErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_NoDataEventHandler _NoDataEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_NoDataEventHandler NoDataEvent
		{
			add
			{
				CreateEventBridge();
				_NoDataEvent += value;
			}
			remove
			{
				_NoDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event ReportOldV10_PageEventHandler _PageEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event ReportOldV10_PageEventHandler PageEvent
		{
			add
			{
				CreateEventBridge();
				_PageEvent += value;
			}
			remove
			{
				_PageEvent -= value;
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
			if( null != __ReportEvents_SinkHelper)
			{
				__ReportEvents_SinkHelper.Dispose();
				__ReportEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}