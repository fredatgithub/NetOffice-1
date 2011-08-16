//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void _SectionInReport_FormatEventHandler(ref Int16 Cancel, ref Int16 FormatCount);
	public delegate void _SectionInReport_PrintEventHandler(ref Int16 Cancel, ref Int16 PrintCount);
	public delegate void _SectionInReport_RetreatEventHandler();
	public delegate void _SectionInReport_ClickEventHandler();
	public delegate void _SectionInReport_DblClickEventHandler(ref Int16 Cancel);
	public delegate void _SectionInReport_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void _SectionInReport_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void _SectionInReport_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void _SectionInReport_PaintEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass _SectionInReport SupportByLibrary Access, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class _SectionInReport : _Section, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_SectionInReportEvents_SinkHelper __SectionInReportEvents_SinkHelper;
		DispSectionInReportEvents_SinkHelper _dispSectionInReportEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_SectionInReport);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public _SectionInReport(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SectionInReport(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _SectionInReport(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of _SectionInReport 
        /// </summary>		
		public _SectionInReport():base("Access._SectionInReport")
		{
		}
		
		/// <summary>
        /// creates a new instance of _SectionInReport
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public _SectionInReport(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _SectionInReportEvents_SinkHelper.Id,DispSectionInReportEvents_SinkHelper.Id);


			if(_SectionInReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__SectionInReportEvents_SinkHelper = new _SectionInReportEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispSectionInReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispSectionInReportEvents_SinkHelper = new DispSectionInReportEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event _SectionInReport_FormatEventHandler _FormatEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event _SectionInReport_FormatEventHandler FormatEvent
		{
			add
			{
				CreateEventBridge();
				_FormatEvent += value;
			}
			remove
			{
				_FormatEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event _SectionInReport_PrintEventHandler _PrintEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event _SectionInReport_PrintEventHandler PrintEvent
		{
			add
			{
				CreateEventBridge();
				_PrintEvent += value;
			}
			remove
			{
				_PrintEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event _SectionInReport_RetreatEventHandler _RetreatEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event _SectionInReport_RetreatEventHandler RetreatEvent
		{
			add
			{
				CreateEventBridge();
				_RetreatEvent += value;
			}
			remove
			{
				_RetreatEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 12,14
		/// </summary>
		private event _SectionInReport_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Access 12 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public event _SectionInReport_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 12,14
		/// </summary>
		private event _SectionInReport_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary Access 12 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public event _SectionInReport_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 12,14
		/// </summary>
		private event _SectionInReport_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Access 12 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public event _SectionInReport_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 12,14
		/// </summary>
		private event _SectionInReport_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Access 12 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public event _SectionInReport_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 12,14
		/// </summary>
		private event _SectionInReport_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Access 12 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public event _SectionInReport_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 12,14
		/// </summary>
		private event _SectionInReport_PaintEventHandler _PaintEvent;

		/// <summary>
		/// SupportByLibrary Access 12 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public event _SectionInReport_PaintEventHandler PaintEvent
		{
			add
			{
				CreateEventBridge();
				_PaintEvent += value;
			}
			remove
			{
				_PaintEvent -= value;
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
			if( null != __SectionInReportEvents_SinkHelper)
			{
				__SectionInReportEvents_SinkHelper.Dispose();
				__SectionInReportEvents_SinkHelper = null;
			}
			if( null != _dispSectionInReportEvents_SinkHelper)
			{
				_dispSectionInReportEvents_SinkHelper.Dispose();
				_dispSectionInReportEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}