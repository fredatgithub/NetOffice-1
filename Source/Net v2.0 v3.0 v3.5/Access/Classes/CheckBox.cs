//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void CheckBox_ClickEventHandler();
	public delegate void CheckBox_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void CheckBox_AfterUpdateEventHandler();
	public delegate void CheckBox_EnterEventHandler();
	public delegate void CheckBox_ExitEventHandler(ref Int16 Cancel);
	public delegate void CheckBox_GotFocusEventHandler();
	public delegate void CheckBox_LostFocusEventHandler();
	public delegate void CheckBox_DblClickEventHandler(ref Int16 Cancel);
	public delegate void CheckBox_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void CheckBox_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void CheckBox_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void CheckBox_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void CheckBox_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void CheckBox_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass CheckBox SupportByLibrary Access, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class CheckBox : _Checkbox, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_CheckBoxEvents_SinkHelper __CheckBoxEvents_SinkHelper;
		DispCheckBoxEvents_SinkHelper _dispCheckBoxEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public CheckBox(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CheckBox(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CheckBox(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public CheckBox()
		{
			CreateFromProgId("Access.CheckBox");
		}
		
		/// <param name="progId">progId</param>
		public CheckBox(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _CheckBoxEvents_SinkHelper.Id,DispCheckBoxEvents_SinkHelper.Id);


			if(_CheckBoxEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__CheckBoxEvents_SinkHelper = new _CheckBoxEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispCheckBoxEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispCheckBoxEvents_SinkHelper = new DispCheckBoxEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_ClickEventHandler ClickEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_BeforeUpdateEventHandler BeforeUpdateEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_AfterUpdateEventHandler AfterUpdateEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_DblClickEventHandler DblClickEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Access, 9,10,11,12,14
		/// </summary>
		private event CheckBox_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary Access 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public event CheckBox_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
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
			if( null != __CheckBoxEvents_SinkHelper)
			{
				__CheckBoxEvents_SinkHelper.Dispose();
				__CheckBoxEvents_SinkHelper = null;
			}
			if( null != _dispCheckBoxEvents_SinkHelper)
			{
				_dispCheckBoxEvents_SinkHelper.Dispose();
				_dispCheckBoxEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}