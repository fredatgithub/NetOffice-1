using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void MailItem_OpenEventHandler(ref bool Cancel);
	public delegate void MailItem_CustomActionEventHandler(COMObject Action, COMObject Response, ref bool Cancel);
	public delegate void MailItem_CustomPropertyChangeEventHandler(string Name);
	public delegate void MailItem_ForwardEventHandler(COMObject Forward, ref bool Cancel);
	public delegate void MailItem_CloseEventHandler(ref bool Cancel);
	public delegate void MailItem_PropertyChangeEventHandler(string Name);
	public delegate void MailItem_ReadEventHandler();
	public delegate void MailItem_ReplyEventHandler(COMObject Response, ref bool Cancel);
	public delegate void MailItem_ReplyAllEventHandler(COMObject Response, ref bool Cancel);
	public delegate void MailItem_SendEventHandler(ref bool Cancel);
	public delegate void MailItem_WriteEventHandler(ref bool Cancel);
	public delegate void MailItem_BeforeCheckNamesEventHandler(ref bool Cancel);
	public delegate void MailItem_AttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void MailItem_AttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void MailItem_BeforeAttachmentSaveEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void MailItem_BeforeDeleteEventHandler(COMObject Item, ref bool Cancel);
	public delegate void MailItem_AttachmentRemoveEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void MailItem_BeforeAttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void MailItem_BeforeAttachmentPreviewEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void MailItem_BeforeAttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void MailItem_BeforeAttachmentWriteToTempFileEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void MailItem_UnloadEventHandler();
	public delegate void MailItem_BeforeAutoSaveEventHandler(ref bool Cancel);
	public delegate void MailItem_BeforeReadEventHandler();
	public delegate void MailItem_AfterWriteEventHandler();
	public delegate void MailItem_ReadCompleteEventHandler(ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass MailItem 
	/// SupportByVersion Outlook, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861332.aspx
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class MailItem : _MailItem,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ItemEvents_SinkHelper _itemEvents_SinkHelper;
		ItemEvents_10_SinkHelper _itemEvents_10_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(MailItem);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public MailItem(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public MailItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailItem(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{
			
		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailItem(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		///<summary>
        ///creates a new instance of MailItem 
        ///</summary>		
		public MailItem():base("Outlook.MailItem")
		{
			
		}
		
		///<summary>
        ///creates a new instance of MailItem
        ///</summary>
        ///<param name="progId">registered ProgID</param>
		public MailItem(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Outlook.MailItem objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Outlook.MailItem array</returns>
		public static NetOffice.OutlookApi.MailItem[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Outlook","MailItem");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.OutlookApi.MailItem> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.OutlookApi.MailItem>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.OutlookApi.MailItem(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Outlook.MailItem object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Outlook.MailItem object or null</returns>
		public static NetOffice.OutlookApi.MailItem GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Outlook","MailItem", false);
			if(null != proxy)
				return new NetOffice.OutlookApi.MailItem(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Outlook.MailItem object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Outlook.MailItem object or null</returns>
		public static NetOffice.OutlookApi.MailItem GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Outlook","MailItem", throwOnError);
			if(null != proxy)
				return new NetOffice.OutlookApi.MailItem(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865989.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_OpenEventHandler OpenEvent
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
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_CustomActionEventHandler _CustomActionEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862186.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_CustomActionEventHandler CustomActionEvent
		{
			add
			{
				CreateEventBridge();
				_CustomActionEvent += value;
			}
			remove
			{
				_CustomActionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_CustomPropertyChangeEventHandler _CustomPropertyChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865310.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_CustomPropertyChangeEventHandler CustomPropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_CustomPropertyChangeEvent += value;
			}
			remove
			{
				_CustomPropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_ForwardEventHandler _ForwardEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862702.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_ForwardEventHandler ForwardEvent
		{
			add
			{
				CreateEventBridge();
				_ForwardEvent += value;
			}
			remove
			{
				_ForwardEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867865.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_CloseEventHandler CloseEvent
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
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_PropertyChangeEventHandler _PropertyChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff866739.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_PropertyChangeEventHandler PropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PropertyChangeEvent += value;
			}
			remove
			{
				_PropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_ReadEventHandler _ReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869872.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_ReadEventHandler ReadEvent
		{
			add
			{
				CreateEventBridge();
				_ReadEvent += value;
			}
			remove
			{
				_ReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_ReplyEventHandler _ReplyEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860938.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_ReplyEventHandler ReplyEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyEvent += value;
			}
			remove
			{
				_ReplyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_ReplyAllEventHandler _ReplyAllEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869905.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_ReplyAllEventHandler ReplyAllEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyAllEvent += value;
			}
			remove
			{
				_ReplyAllEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_SendEventHandler _SendEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff865379.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_SendEventHandler SendEvent
		{
			add
			{
				CreateEventBridge();
				_SendEvent += value;
			}
			remove
			{
				_SendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_WriteEventHandler _WriteEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868664.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_WriteEventHandler WriteEvent
		{
			add
			{
				CreateEventBridge();
				_WriteEvent += value;
			}
			remove
			{
				_WriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_BeforeCheckNamesEventHandler _BeforeCheckNamesEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff870099.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_BeforeCheckNamesEventHandler BeforeCheckNamesEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCheckNamesEvent += value;
			}
			remove
			{
				_BeforeCheckNamesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_AttachmentAddEventHandler _AttachmentAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868540.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_AttachmentAddEventHandler AttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentAddEvent += value;
			}
			remove
			{
				_AttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_AttachmentReadEventHandler _AttachmentReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868187.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_AttachmentReadEventHandler AttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentReadEvent += value;
			}
			remove
			{
				_AttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14,15
		/// </summary>
		private event MailItem_BeforeAttachmentSaveEventHandler _BeforeAttachmentSaveEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868639.aspx </remarks>
		[SupportByVersion("Outlook", 9,10,11,12,14,15)]
		public event MailItem_BeforeAttachmentSaveEventHandler BeforeAttachmentSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentSaveEvent += value;
			}
			remove
			{
				_BeforeAttachmentSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15
		/// </summary>
		private event MailItem_BeforeDeleteEventHandler _BeforeDeleteEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff861266.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15)]
		public event MailItem_BeforeDeleteEventHandler BeforeDeleteEvent
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
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_AttachmentRemoveEventHandler _AttachmentRemoveEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863737.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_AttachmentRemoveEventHandler AttachmentRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentRemoveEvent += value;
			}
			remove
			{
				_AttachmentRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_BeforeAttachmentAddEventHandler _BeforeAttachmentAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869219.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_BeforeAttachmentAddEventHandler BeforeAttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentAddEvent += value;
			}
			remove
			{
				_BeforeAttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_BeforeAttachmentPreviewEventHandler _BeforeAttachmentPreviewEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862669.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_BeforeAttachmentPreviewEventHandler BeforeAttachmentPreviewEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentPreviewEvent += value;
			}
			remove
			{
				_BeforeAttachmentPreviewEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_BeforeAttachmentReadEventHandler _BeforeAttachmentReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860316.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_BeforeAttachmentReadEventHandler BeforeAttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentReadEvent += value;
			}
			remove
			{
				_BeforeAttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_BeforeAttachmentWriteToTempFileEventHandler _BeforeAttachmentWriteToTempFileEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff870101.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_BeforeAttachmentWriteToTempFileEventHandler BeforeAttachmentWriteToTempFileEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentWriteToTempFileEvent += value;
			}
			remove
			{
				_BeforeAttachmentWriteToTempFileEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff868564.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14,15
		/// </summary>
		private event MailItem_BeforeAutoSaveEventHandler _BeforeAutoSaveEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860949.aspx </remarks>
		[SupportByVersion("Outlook", 12,14,15)]
		public event MailItem_BeforeAutoSaveEventHandler BeforeAutoSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAutoSaveEvent += value;
			}
			remove
			{
				_BeforeAutoSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 14,15
		/// </summary>
		private event MailItem_BeforeReadEventHandler _BeforeReadEvent;

		/// <summary>
		/// SupportByVersion Outlook 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869497.aspx </remarks>
		[SupportByVersion("Outlook", 14,15)]
		public event MailItem_BeforeReadEventHandler BeforeReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReadEvent += value;
			}
			remove
			{
				_BeforeReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 14,15
		/// </summary>
		private event MailItem_AfterWriteEventHandler _AfterWriteEvent;

		/// <summary>
		/// SupportByVersion Outlook 14 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869691.aspx </remarks>
		[SupportByVersion("Outlook", 14,15)]
		public event MailItem_AfterWriteEventHandler AfterWriteEvent
		{
			add
			{
				CreateEventBridge();
				_AfterWriteEvent += value;
			}
			remove
			{
				_AfterWriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 15
		/// </summary>
		private event MailItem_ReadCompleteEventHandler _ReadCompleteEvent;

		/// <summary>
		/// SupportByVersion Outlook 15
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228313.aspx </remarks>
		[SupportByVersion("Outlook", 15)]
		public event MailItem_ReadCompleteEventHandler ReadCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ReadCompleteEvent += value;
			}
			remove
			{
				_ReadCompleteEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == Factory.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ItemEvents_SinkHelper.Id,ItemEvents_10_SinkHelper.Id);


			if(ItemEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_SinkHelper = new ItemEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ItemEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_10_SinkHelper = new ItemEvents_10_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
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
        public int GetCountOfEventRecipients(string eventName)
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
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
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
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        Factory.Console.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _itemEvents_SinkHelper)
			{
				_itemEvents_SinkHelper.Dispose();
				_itemEvents_SinkHelper = null;
			}
			if( null != _itemEvents_10_SinkHelper)
			{
				_itemEvents_10_SinkHelper.Dispose();
				_itemEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}