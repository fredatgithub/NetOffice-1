//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.WordApi
{
	///<summary>
	/// DispatchInterface _Font SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	public class _Font : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Font(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Font(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Font(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Font()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Font Duplicate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Duplicate", paramsArray);
				LateBindingApi.WordApi.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Font;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Bold
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bold", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Bold", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Italic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Italic", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Italic", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Hidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hidden", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Hidden", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 SmallCaps
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmallCaps", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SmallCaps", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 AllCaps
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllCaps", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllCaps", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 StrikeThrough
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StrikeThrough", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StrikeThrough", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 DoubleStrikeThrough
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DoubleStrikeThrough", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DoubleStrikeThrough", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdColorIndex ColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorIndex", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Subscript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subscript", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subscript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Superscript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Superscript", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Superscript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdUnderline Underline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Underline", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdUnderline)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Underline", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Size", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Position
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Position", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Position", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single Spacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Spacing", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Spacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Scaling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Scaling", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Scaling", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Outline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Outline", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Outline", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Emboss
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Emboss", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Emboss", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single Kerning
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Kerning", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Kerning", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Engrave
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Engrave", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Engrave", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdAnimation Animation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Animation", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdAnimation)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Animation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				LateBindingApi.WordApi.Borders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Borders;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Borders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shading Shading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shading", paramsArray);
				LateBindingApi.WordApi.Shading newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Shading;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdEmphasisMark EmphasisMark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EmphasisMark", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdEmphasisMark)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EmphasisMark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool DisableCharacterSpaceGrid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisableCharacterSpaceGrid", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisableCharacterSpaceGrid", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string NameFarEast
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameFarEast", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameFarEast", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string NameAscii
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameAscii", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameAscii", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string NameOther
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameOther", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameOther", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdColor Color
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Color", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdColor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Color", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 BoldBi
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoldBi", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BoldBi", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 ItalicBi
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItalicBi", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ItalicBi", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single SizeBi
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SizeBi", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SizeBi", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string NameBi
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameBi", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameBi", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdColorIndex ColorIndexBi
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorIndexBi", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColorIndexBi", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdColor DiacriticColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DiacriticColor", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdColor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DiacriticColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Enums.WdColor UnderlineColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnderlineColor", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdColor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UnderlineColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.GlowFormat Glow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Glow", paramsArray);
				LateBindingApi.WordApi.GlowFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.GlowFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Glow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.ReflectionFormat Reflection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reflection", paramsArray);
				LateBindingApi.WordApi.ReflectionFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.ReflectionFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Reflection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.ShadowFormat TextShadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextShadow", paramsArray);
				LateBindingApi.WordApi.ShadowFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.ShadowFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextShadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.FillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				LateBindingApi.WordApi.FillFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.FillFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Fill", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.LineFormat Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				LateBindingApi.WordApi.LineFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.LineFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Line", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.ThreeDFormat ThreeD
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThreeD", paramsArray);
				LateBindingApi.WordApi.ThreeDFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.ThreeDFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ThreeD", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.ColorFormat TextColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextColor", paramsArray);
				LateBindingApi.WordApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.Enums.WdLigatures Ligatures
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Ligatures", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdLigatures)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Ligatures", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.Enums.WdNumberForm NumberForm
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberForm", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdNumberForm)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberForm", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.Enums.WdNumberSpacing NumberSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberSpacing", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdNumberSpacing)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public Int32 ContextualAlternates
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContextualAlternates", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ContextualAlternates", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public LateBindingApi.WordApi.Enums.WdStylisticSet StylisticSet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StylisticSet", paramsArray);
				return (LateBindingApi.WordApi.Enums.WdStylisticSet)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StylisticSet", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Grow()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Grow", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Shrink()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Shrink", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void SetAsTemplateDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetAsTemplateDefault", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}