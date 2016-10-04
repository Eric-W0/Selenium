// Selenium Framework
// Copyright(C) 2016 Eric Blond
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see <http://www.gnu.org/licenses/>.



// This file was automatically generated!

using Hyperplan.Fluor;
using Hyperplan.Selenium.Core;
using System;
using System.Windows;
using System.Reflection;
using System.Collections.Generic;

namespace Hyperplan.Selenium
{
	public class AccessText : System.Windows.Controls.AccessText
	{
		DependencyPropertyBridge<AccessText> bridgeHeight;
		DependencyPropertyBridge<AccessText> bridgeHorizontalAlignment;
		DependencyPropertyBridge<AccessText> bridgeIsEnabled;
		DependencyPropertyBridge<AccessText> bridgeMargin;
		DependencyPropertyBridge<AccessText> bridgeName;
		DependencyPropertyBridge<AccessText> bridgeToolTip;
		DependencyPropertyBridge<AccessText> bridgeVerticalAlignment;
		DependencyPropertyBridge<AccessText> bridgeWidth;

		public AccessText()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<AccessText>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<AccessText>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<AccessText>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<AccessText>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<AccessText>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<AccessText>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<AccessText>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<AccessText>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class AdornedElementPlaceholder : System.Windows.Controls.AdornedElementPlaceholder
	{
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeHeight;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeHorizontalAlignment;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeIsEnabled;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeMargin;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeName;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeToolTip;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeVerticalAlignment;
		DependencyPropertyBridge<AdornedElementPlaceholder> bridgeWidth;

		public AdornedElementPlaceholder()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<AdornedElementPlaceholder>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class AdornerDecorator : System.Windows.Documents.AdornerDecorator
	{
		DependencyPropertyBridge<AdornerDecorator> bridgeHeight;
		DependencyPropertyBridge<AdornerDecorator> bridgeHorizontalAlignment;
		DependencyPropertyBridge<AdornerDecorator> bridgeIsEnabled;
		DependencyPropertyBridge<AdornerDecorator> bridgeMargin;
		DependencyPropertyBridge<AdornerDecorator> bridgeName;
		DependencyPropertyBridge<AdornerDecorator> bridgeToolTip;
		DependencyPropertyBridge<AdornerDecorator> bridgeVerticalAlignment;
		DependencyPropertyBridge<AdornerDecorator> bridgeWidth;

		public AdornerDecorator()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<AdornerDecorator>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<AdornerDecorator>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<AdornerDecorator>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<AdornerDecorator>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<AdornerDecorator>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<AdornerDecorator>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<AdornerDecorator>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<AdornerDecorator>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Block : System.Windows.Documents.Block
	{
		DependencyPropertyBridge<Block> bridgeContextMenu;
		DependencyPropertyBridge<Block> bridgeCursor;
		DependencyPropertyBridge<Block> bridgeLanguage;
		DependencyPropertyBridge<Block> bridgeName;
		DependencyPropertyBridge<Block> bridgeTag;
		DependencyPropertyBridge<Block> bridgeToolTip;

		public Block()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Block>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Block>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Block>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Block>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Block>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Block>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class BlockUIContainer : System.Windows.Documents.BlockUIContainer
	{
		DependencyPropertyBridge<BlockUIContainer> bridgeContextMenu;
		DependencyPropertyBridge<BlockUIContainer> bridgeCursor;
		DependencyPropertyBridge<BlockUIContainer> bridgeLanguage;
		DependencyPropertyBridge<BlockUIContainer> bridgeName;
		DependencyPropertyBridge<BlockUIContainer> bridgeTag;
		DependencyPropertyBridge<BlockUIContainer> bridgeToolTip;

		public BlockUIContainer()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<BlockUIContainer>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<BlockUIContainer>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<BlockUIContainer>(this, "Language");
			bridgeName = new DependencyPropertyBridge<BlockUIContainer>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<BlockUIContainer>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<BlockUIContainer>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Bold : System.Windows.Documents.Bold
	{
		DependencyPropertyBridge<Bold> bridgeContextMenu;
		DependencyPropertyBridge<Bold> bridgeCursor;
		DependencyPropertyBridge<Bold> bridgeLanguage;
		DependencyPropertyBridge<Bold> bridgeName;
		DependencyPropertyBridge<Bold> bridgeTag;
		DependencyPropertyBridge<Bold> bridgeToolTip;

		public Bold()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Bold>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Bold>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Bold>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Bold>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Bold>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Bold>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Border : System.Windows.Controls.Border
	{
		DependencyPropertyBridge<Border> bridgeHeight;
		DependencyPropertyBridge<Border> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Border> bridgeIsEnabled;
		DependencyPropertyBridge<Border> bridgeMargin;
		DependencyPropertyBridge<Border> bridgeName;
		DependencyPropertyBridge<Border> bridgeToolTip;
		DependencyPropertyBridge<Border> bridgeVerticalAlignment;
		DependencyPropertyBridge<Border> bridgeWidth;

		public Border()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Border>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Border>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Border>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Border>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Border>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Border>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Border>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Border>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class BulletDecorator : System.Windows.Controls.Primitives.BulletDecorator
	{
		DependencyPropertyBridge<BulletDecorator> bridgeHeight;
		DependencyPropertyBridge<BulletDecorator> bridgeHorizontalAlignment;
		DependencyPropertyBridge<BulletDecorator> bridgeIsEnabled;
		DependencyPropertyBridge<BulletDecorator> bridgeMargin;
		DependencyPropertyBridge<BulletDecorator> bridgeName;
		DependencyPropertyBridge<BulletDecorator> bridgeToolTip;
		DependencyPropertyBridge<BulletDecorator> bridgeVerticalAlignment;
		DependencyPropertyBridge<BulletDecorator> bridgeWidth;

		public BulletDecorator()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<BulletDecorator>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<BulletDecorator>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<BulletDecorator>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<BulletDecorator>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<BulletDecorator>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<BulletDecorator>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<BulletDecorator>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<BulletDecorator>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Button : System.Windows.Controls.Button
	{
		DependencyPropertyBridge<Button> bridgeBackground;
		DependencyPropertyBridge<Button> bridgeContent;
		DependencyPropertyBridge<Button> bridgeFontFamily;
		DependencyPropertyBridge<Button> bridgeFontSize;
		DependencyPropertyBridge<Button> bridgeFontStretch;
		DependencyPropertyBridge<Button> bridgeFontStyle;
		DependencyPropertyBridge<Button> bridgeFontWeight;
		DependencyPropertyBridge<Button> bridgeForeground;
		DependencyPropertyBridge<Button> bridgeHeight;
		DependencyPropertyBridge<Button> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Button> bridgeIsEnabled;
		DependencyPropertyBridge<Button> bridgeMargin;
		DependencyPropertyBridge<Button> bridgeName;
		DependencyPropertyBridge<Button> bridgeToolTip;
		DependencyPropertyBridge<Button> bridgeVerticalAlignment;
		DependencyPropertyBridge<Button> bridgeWidth;

		public Button()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Button>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<Button>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<Button>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Button>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Button>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Button>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Button>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Button>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Button>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Button>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Button>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Button>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Button>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Button>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Button>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Button>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ButtonBase : System.Windows.Controls.Primitives.ButtonBase
	{
		DependencyPropertyBridge<ButtonBase> bridgeBackground;
		DependencyPropertyBridge<ButtonBase> bridgeContent;
		DependencyPropertyBridge<ButtonBase> bridgeFontFamily;
		DependencyPropertyBridge<ButtonBase> bridgeFontSize;
		DependencyPropertyBridge<ButtonBase> bridgeFontStretch;
		DependencyPropertyBridge<ButtonBase> bridgeFontStyle;
		DependencyPropertyBridge<ButtonBase> bridgeFontWeight;
		DependencyPropertyBridge<ButtonBase> bridgeForeground;
		DependencyPropertyBridge<ButtonBase> bridgeHeight;
		DependencyPropertyBridge<ButtonBase> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ButtonBase> bridgeIsEnabled;
		DependencyPropertyBridge<ButtonBase> bridgeMargin;
		DependencyPropertyBridge<ButtonBase> bridgeName;
		DependencyPropertyBridge<ButtonBase> bridgeToolTip;
		DependencyPropertyBridge<ButtonBase> bridgeVerticalAlignment;
		DependencyPropertyBridge<ButtonBase> bridgeWidth;

		public ButtonBase()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ButtonBase>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ButtonBase>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ButtonBase>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ButtonBase>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ButtonBase>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ButtonBase>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ButtonBase>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ButtonBase>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ButtonBase>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ButtonBase>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ButtonBase>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ButtonBase>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ButtonBase>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ButtonBase>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ButtonBase>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ButtonBase>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Calendar : System.Windows.Controls.Calendar
	{
		DependencyPropertyBridge<Calendar> bridgeBackground;
		DependencyPropertyBridge<Calendar> bridgeFontFamily;
		DependencyPropertyBridge<Calendar> bridgeFontSize;
		DependencyPropertyBridge<Calendar> bridgeFontStretch;
		DependencyPropertyBridge<Calendar> bridgeFontStyle;
		DependencyPropertyBridge<Calendar> bridgeFontWeight;
		DependencyPropertyBridge<Calendar> bridgeForeground;
		DependencyPropertyBridge<Calendar> bridgeHeight;
		DependencyPropertyBridge<Calendar> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Calendar> bridgeIsEnabled;
		DependencyPropertyBridge<Calendar> bridgeMargin;
		DependencyPropertyBridge<Calendar> bridgeName;
		DependencyPropertyBridge<Calendar> bridgeToolTip;
		DependencyPropertyBridge<Calendar> bridgeVerticalAlignment;
		DependencyPropertyBridge<Calendar> bridgeWidth;

		public Calendar()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Calendar>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Calendar>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Calendar>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Calendar>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Calendar>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Calendar>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Calendar>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Calendar>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Calendar>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Calendar>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Calendar>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Calendar>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Calendar>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Calendar>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Calendar>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Canvas : System.Windows.Controls.Canvas
	{
		DependencyPropertyBridge<Canvas> bridgeHeight;
		DependencyPropertyBridge<Canvas> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Canvas> bridgeIsEnabled;
		DependencyPropertyBridge<Canvas> bridgeMargin;
		DependencyPropertyBridge<Canvas> bridgeName;
		DependencyPropertyBridge<Canvas> bridgeToolTip;
		DependencyPropertyBridge<Canvas> bridgeVerticalAlignment;
		DependencyPropertyBridge<Canvas> bridgeWidth;
		CollectionPropertyBridge<Canvas> bridgeChildren;


		public Canvas()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Canvas>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Canvas>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Canvas>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Canvas>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Canvas>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Canvas>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Canvas>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Canvas>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<Canvas>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class CheckBox : System.Windows.Controls.CheckBox
	{
		DependencyPropertyBridge<CheckBox> bridgeBackground;
		DependencyPropertyBridge<CheckBox> bridgeContent;
		DependencyPropertyBridge<CheckBox> bridgeFontFamily;
		DependencyPropertyBridge<CheckBox> bridgeFontSize;
		DependencyPropertyBridge<CheckBox> bridgeFontStretch;
		DependencyPropertyBridge<CheckBox> bridgeFontStyle;
		DependencyPropertyBridge<CheckBox> bridgeFontWeight;
		DependencyPropertyBridge<CheckBox> bridgeForeground;
		DependencyPropertyBridge<CheckBox> bridgeHeight;
		DependencyPropertyBridge<CheckBox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<CheckBox> bridgeIsChecked;
		DependencyPropertyBridge<CheckBox> bridgeIsEnabled;
		DependencyPropertyBridge<CheckBox> bridgeMargin;
		DependencyPropertyBridge<CheckBox> bridgeName;
		DependencyPropertyBridge<CheckBox> bridgeToolTip;
		DependencyPropertyBridge<CheckBox> bridgeVerticalAlignment;
		DependencyPropertyBridge<CheckBox> bridgeWidth;

		public CheckBox()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsChecked = new Cache<System.Nullable<bool>>(() => base.IsChecked);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<CheckBox>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<CheckBox>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<CheckBox>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<CheckBox>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<CheckBox>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<CheckBox>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<CheckBox>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<CheckBox>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<CheckBox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<CheckBox>(this, "HorizontalAlignment");
			bridgeIsChecked = new DependencyPropertyBridge<CheckBox>(this, "IsChecked");
			bridgeIsEnabled = new DependencyPropertyBridge<CheckBox>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<CheckBox>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<CheckBox>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<CheckBox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<CheckBox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<CheckBox>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<System.Nullable<bool>> _IsChecked;

		public new virtual System.Nullable<bool> IsChecked
		{
			get
			{
				return _IsChecked.Get();
			}

			set
			{
				_IsChecked.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ColumnDefinition : System.Windows.Controls.ColumnDefinition
	{
		DependencyPropertyBridge<ColumnDefinition> bridgeContextMenu;
		DependencyPropertyBridge<ColumnDefinition> bridgeCursor;
		DependencyPropertyBridge<ColumnDefinition> bridgeLanguage;
		DependencyPropertyBridge<ColumnDefinition> bridgeName;
		DependencyPropertyBridge<ColumnDefinition> bridgeTag;
		DependencyPropertyBridge<ColumnDefinition> bridgeToolTip;
		DependencyPropertyBridge<ColumnDefinition> bridgeWidth;

		public ColumnDefinition()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_Width = new Cache<System.Windows.GridLength>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<ColumnDefinition>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<ColumnDefinition>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<ColumnDefinition>(this, "Language");
			bridgeName = new DependencyPropertyBridge<ColumnDefinition>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<ColumnDefinition>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<ColumnDefinition>(this, "ToolTip");
			bridgeWidth = new DependencyPropertyBridge<ColumnDefinition>(this, "Width");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.GridLength> _Width;

		public new virtual System.Windows.GridLength Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ComboBox : System.Windows.Controls.ComboBox
	{
		DependencyPropertyBridge<ComboBox> bridgeBackground;
		DependencyPropertyBridge<ComboBox> bridgeFontFamily;
		DependencyPropertyBridge<ComboBox> bridgeFontSize;
		DependencyPropertyBridge<ComboBox> bridgeFontStretch;
		DependencyPropertyBridge<ComboBox> bridgeFontStyle;
		DependencyPropertyBridge<ComboBox> bridgeFontWeight;
		DependencyPropertyBridge<ComboBox> bridgeForeground;
		DependencyPropertyBridge<ComboBox> bridgeHeight;
		DependencyPropertyBridge<ComboBox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ComboBox> bridgeIsDropDownOpen;
		DependencyPropertyBridge<ComboBox> bridgeIsEditable;
		DependencyPropertyBridge<ComboBox> bridgeIsEnabled;
		DependencyPropertyBridge<ComboBox> bridgeIsReadOnly;
		DependencyPropertyBridge<ComboBox> bridgeItemTemplate;
		DependencyPropertyBridge<ComboBox> bridgeMargin;
		DependencyPropertyBridge<ComboBox> bridgeMaxDropDownHeight;
		DependencyPropertyBridge<ComboBox> bridgeName;
		DependencyPropertyBridge<ComboBox> bridgeSelectedItem;
		DependencyPropertyBridge<ComboBox> bridgeShouldPreserveUserEnteredPrefix;
		DependencyPropertyBridge<ComboBox> bridgeText;
		DependencyPropertyBridge<ComboBox> bridgeToolTip;
		DependencyPropertyBridge<ComboBox> bridgeVerticalAlignment;
		DependencyPropertyBridge<ComboBox> bridgeWidth;
		CollectionPropertyBridge<ComboBox> bridgeItems;


		public ComboBox()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsDropDownOpen = new Cache<bool>(() => base.IsDropDownOpen);
			_IsEditable = new Cache<bool>(() => base.IsEditable);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_IsReadOnly = new Cache<bool>(() => base.IsReadOnly);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_MaxDropDownHeight = new Cache<double>(() => base.MaxDropDownHeight);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_ShouldPreserveUserEnteredPrefix = new Cache<bool>(() => base.ShouldPreserveUserEnteredPrefix);
			_Text = new Cache<string>(() => base.Text);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ComboBox>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ComboBox>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ComboBox>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ComboBox>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ComboBox>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ComboBox>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ComboBox>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ComboBox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ComboBox>(this, "HorizontalAlignment");
			bridgeIsDropDownOpen = new DependencyPropertyBridge<ComboBox>(this, "IsDropDownOpen");
			bridgeIsEditable = new DependencyPropertyBridge<ComboBox>(this, "IsEditable");
			bridgeIsEnabled = new DependencyPropertyBridge<ComboBox>(this, "IsEnabled");
			bridgeIsReadOnly = new DependencyPropertyBridge<ComboBox>(this, "IsReadOnly");
			bridgeItemTemplate = new DependencyPropertyBridge<ComboBox>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<ComboBox>(this, "Margin");
			bridgeMaxDropDownHeight = new DependencyPropertyBridge<ComboBox>(this, "MaxDropDownHeight");
			bridgeName = new DependencyPropertyBridge<ComboBox>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<ComboBox>(this, "SelectedItem");
			bridgeShouldPreserveUserEnteredPrefix = new DependencyPropertyBridge<ComboBox>(this, "ShouldPreserveUserEnteredPrefix");
			bridgeText = new DependencyPropertyBridge<ComboBox>(this, "Text");
			bridgeToolTip = new DependencyPropertyBridge<ComboBox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ComboBox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ComboBox>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<ComboBox>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsDropDownOpen;

		public new virtual bool IsDropDownOpen
		{
			get
			{
				return _IsDropDownOpen.Get();
			}

			set
			{
				_IsDropDownOpen.Set(value);
			}
		}

		Cache<bool> _IsEditable;

		public new virtual bool IsEditable
		{
			get
			{
				return _IsEditable.Get();
			}

			set
			{
				_IsEditable.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<bool> _IsReadOnly;

		public new virtual bool IsReadOnly
		{
			get
			{
				return _IsReadOnly.Get();
			}

			set
			{
				_IsReadOnly.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<double> _MaxDropDownHeight;

		public new virtual double MaxDropDownHeight
		{
			get
			{
				return _MaxDropDownHeight.Get();
			}

			set
			{
				_MaxDropDownHeight.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<bool> _ShouldPreserveUserEnteredPrefix;

		public new virtual bool ShouldPreserveUserEnteredPrefix
		{
			get
			{
				return _ShouldPreserveUserEnteredPrefix.Get();
			}

			set
			{
				_ShouldPreserveUserEnteredPrefix.Set(value);
			}
		}

		Cache<string> _Text;

		public new virtual string Text
		{
			get
			{
				return _Text.Get();
			}

			set
			{
				_Text.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class ComboBoxItem : System.Windows.Controls.ComboBoxItem
	{
		DependencyPropertyBridge<ComboBoxItem> bridgeBackground;
		DependencyPropertyBridge<ComboBoxItem> bridgeContent;
		DependencyPropertyBridge<ComboBoxItem> bridgeFontFamily;
		DependencyPropertyBridge<ComboBoxItem> bridgeFontSize;
		DependencyPropertyBridge<ComboBoxItem> bridgeFontStretch;
		DependencyPropertyBridge<ComboBoxItem> bridgeFontStyle;
		DependencyPropertyBridge<ComboBoxItem> bridgeFontWeight;
		DependencyPropertyBridge<ComboBoxItem> bridgeForeground;
		DependencyPropertyBridge<ComboBoxItem> bridgeHeight;
		DependencyPropertyBridge<ComboBoxItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ComboBoxItem> bridgeIsEnabled;
		DependencyPropertyBridge<ComboBoxItem> bridgeMargin;
		DependencyPropertyBridge<ComboBoxItem> bridgeName;
		DependencyPropertyBridge<ComboBoxItem> bridgeToolTip;
		DependencyPropertyBridge<ComboBoxItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<ComboBoxItem> bridgeWidth;

		public ComboBoxItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ComboBoxItem>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ComboBoxItem>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ComboBoxItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ComboBoxItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ComboBoxItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ComboBoxItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ComboBoxItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ComboBoxItem>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ComboBoxItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ComboBoxItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ComboBoxItem>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ComboBoxItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ComboBoxItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ComboBoxItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ComboBoxItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ComboBoxItem>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ContentControl : System.Windows.Controls.ContentControl
	{
		DependencyPropertyBridge<ContentControl> bridgeBackground;
		DependencyPropertyBridge<ContentControl> bridgeContent;
		DependencyPropertyBridge<ContentControl> bridgeFontFamily;
		DependencyPropertyBridge<ContentControl> bridgeFontSize;
		DependencyPropertyBridge<ContentControl> bridgeFontStretch;
		DependencyPropertyBridge<ContentControl> bridgeFontStyle;
		DependencyPropertyBridge<ContentControl> bridgeFontWeight;
		DependencyPropertyBridge<ContentControl> bridgeForeground;
		DependencyPropertyBridge<ContentControl> bridgeHeight;
		DependencyPropertyBridge<ContentControl> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ContentControl> bridgeIsEnabled;
		DependencyPropertyBridge<ContentControl> bridgeMargin;
		DependencyPropertyBridge<ContentControl> bridgeName;
		DependencyPropertyBridge<ContentControl> bridgeToolTip;
		DependencyPropertyBridge<ContentControl> bridgeVerticalAlignment;
		DependencyPropertyBridge<ContentControl> bridgeWidth;

		public ContentControl()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ContentControl>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ContentControl>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ContentControl>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ContentControl>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ContentControl>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ContentControl>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ContentControl>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ContentControl>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ContentControl>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ContentControl>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ContentControl>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ContentControl>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ContentControl>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ContentControl>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ContentControl>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ContentControl>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ContentPresenter : System.Windows.Controls.ContentPresenter
	{
		DependencyPropertyBridge<ContentPresenter> bridgeHeight;
		DependencyPropertyBridge<ContentPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ContentPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<ContentPresenter> bridgeMargin;
		DependencyPropertyBridge<ContentPresenter> bridgeName;
		DependencyPropertyBridge<ContentPresenter> bridgeToolTip;
		DependencyPropertyBridge<ContentPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<ContentPresenter> bridgeWidth;

		public ContentPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<ContentPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ContentPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ContentPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ContentPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ContentPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ContentPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ContentPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ContentPresenter>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ContextMenu : System.Windows.Controls.ContextMenu
	{
		DependencyPropertyBridge<ContextMenu> bridgeBackground;
		DependencyPropertyBridge<ContextMenu> bridgeFontFamily;
		DependencyPropertyBridge<ContextMenu> bridgeFontSize;
		DependencyPropertyBridge<ContextMenu> bridgeFontStretch;
		DependencyPropertyBridge<ContextMenu> bridgeFontStyle;
		DependencyPropertyBridge<ContextMenu> bridgeFontWeight;
		DependencyPropertyBridge<ContextMenu> bridgeForeground;
		DependencyPropertyBridge<ContextMenu> bridgeHeight;
		DependencyPropertyBridge<ContextMenu> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ContextMenu> bridgeIsEnabled;
		DependencyPropertyBridge<ContextMenu> bridgeItemTemplate;
		DependencyPropertyBridge<ContextMenu> bridgeMargin;
		DependencyPropertyBridge<ContextMenu> bridgeName;
		DependencyPropertyBridge<ContextMenu> bridgeToolTip;
		DependencyPropertyBridge<ContextMenu> bridgeVerticalAlignment;
		DependencyPropertyBridge<ContextMenu> bridgeWidth;
		CollectionPropertyBridge<ContextMenu> bridgeItems;


		public ContextMenu()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ContextMenu>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ContextMenu>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ContextMenu>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ContextMenu>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ContextMenu>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ContextMenu>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ContextMenu>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ContextMenu>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ContextMenu>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ContextMenu>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<ContextMenu>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<ContextMenu>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ContextMenu>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ContextMenu>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ContextMenu>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ContextMenu>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<ContextMenu>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class Control : System.Windows.Controls.Control
	{
		DependencyPropertyBridge<Control> bridgeBackground;
		DependencyPropertyBridge<Control> bridgeFontFamily;
		DependencyPropertyBridge<Control> bridgeFontSize;
		DependencyPropertyBridge<Control> bridgeFontStretch;
		DependencyPropertyBridge<Control> bridgeFontStyle;
		DependencyPropertyBridge<Control> bridgeFontWeight;
		DependencyPropertyBridge<Control> bridgeForeground;
		DependencyPropertyBridge<Control> bridgeHeight;
		DependencyPropertyBridge<Control> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Control> bridgeIsEnabled;
		DependencyPropertyBridge<Control> bridgeMargin;
		DependencyPropertyBridge<Control> bridgeName;
		DependencyPropertyBridge<Control> bridgeToolTip;
		DependencyPropertyBridge<Control> bridgeVerticalAlignment;
		DependencyPropertyBridge<Control> bridgeWidth;

		public Control()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Control>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Control>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Control>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Control>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Control>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Control>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Control>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Control>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Control>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Control>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Control>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Control>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Control>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Control>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Control>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DataGrid : System.Windows.Controls.DataGrid
	{
		DependencyPropertyBridge<DataGrid> bridgeBackground;
		DependencyPropertyBridge<DataGrid> bridgeFontFamily;
		DependencyPropertyBridge<DataGrid> bridgeFontSize;
		DependencyPropertyBridge<DataGrid> bridgeFontStretch;
		DependencyPropertyBridge<DataGrid> bridgeFontStyle;
		DependencyPropertyBridge<DataGrid> bridgeFontWeight;
		DependencyPropertyBridge<DataGrid> bridgeForeground;
		DependencyPropertyBridge<DataGrid> bridgeHeight;
		DependencyPropertyBridge<DataGrid> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGrid> bridgeIsEnabled;
		DependencyPropertyBridge<DataGrid> bridgeItemTemplate;
		DependencyPropertyBridge<DataGrid> bridgeMargin;
		DependencyPropertyBridge<DataGrid> bridgeName;
		DependencyPropertyBridge<DataGrid> bridgeSelectedItem;
		DependencyPropertyBridge<DataGrid> bridgeToolTip;
		DependencyPropertyBridge<DataGrid> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGrid> bridgeWidth;
		CollectionPropertyBridge<DataGrid> bridgeItems;


		public DataGrid()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGrid>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DataGrid>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGrid>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGrid>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGrid>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGrid>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGrid>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGrid>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGrid>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGrid>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<DataGrid>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<DataGrid>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGrid>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<DataGrid>(this, "SelectedItem");
			bridgeToolTip = new DependencyPropertyBridge<DataGrid>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGrid>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGrid>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<DataGrid>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class DataGridCell : System.Windows.Controls.DataGridCell
	{
		DependencyPropertyBridge<DataGridCell> bridgeBackground;
		DependencyPropertyBridge<DataGridCell> bridgeContent;
		DependencyPropertyBridge<DataGridCell> bridgeFontFamily;
		DependencyPropertyBridge<DataGridCell> bridgeFontSize;
		DependencyPropertyBridge<DataGridCell> bridgeFontStretch;
		DependencyPropertyBridge<DataGridCell> bridgeFontStyle;
		DependencyPropertyBridge<DataGridCell> bridgeFontWeight;
		DependencyPropertyBridge<DataGridCell> bridgeForeground;
		DependencyPropertyBridge<DataGridCell> bridgeHeight;
		DependencyPropertyBridge<DataGridCell> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridCell> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridCell> bridgeMargin;
		DependencyPropertyBridge<DataGridCell> bridgeName;
		DependencyPropertyBridge<DataGridCell> bridgeToolTip;
		DependencyPropertyBridge<DataGridCell> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridCell> bridgeWidth;

		public DataGridCell()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGridCell>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<DataGridCell>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<DataGridCell>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGridCell>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGridCell>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGridCell>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGridCell>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGridCell>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGridCell>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridCell>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridCell>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridCell>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridCell>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridCell>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridCell>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridCell>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DataGridCellsPanel : System.Windows.Controls.DataGridCellsPanel
	{
		DependencyPropertyBridge<DataGridCellsPanel> bridgeHeight;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeMargin;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeName;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeToolTip;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridCellsPanel> bridgeWidth;
		CollectionPropertyBridge<DataGridCellsPanel> bridgeChildren;


		public DataGridCellsPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<DataGridCellsPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridCellsPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridCellsPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridCellsPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridCellsPanel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridCellsPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridCellsPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridCellsPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<DataGridCellsPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class DataGridCellsPresenter : System.Windows.Controls.Primitives.DataGridCellsPresenter
	{
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeBackground;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeFontFamily;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeFontSize;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeFontStretch;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeFontStyle;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeFontWeight;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeForeground;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeHeight;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeItemTemplate;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeMargin;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeName;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeToolTip;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridCellsPresenter> bridgeWidth;
		CollectionPropertyBridge<DataGridCellsPresenter> bridgeItems;


		public DataGridCellsPresenter()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridCellsPresenter>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<DataGridCellsPresenter>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class DataGridColumnHeader : System.Windows.Controls.Primitives.DataGridColumnHeader
	{
		DependencyPropertyBridge<DataGridColumnHeader> bridgeBackground;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeContent;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeFontFamily;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeFontSize;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeFontStretch;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeFontStyle;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeFontWeight;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeForeground;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeHeight;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeMargin;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeName;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeToolTip;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridColumnHeader> bridgeWidth;

		public DataGridColumnHeader()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<DataGridColumnHeader>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGridColumnHeader>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGridColumnHeader>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGridColumnHeader>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGridColumnHeader>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridColumnHeader>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridColumnHeader>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridColumnHeader>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridColumnHeader>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridColumnHeader>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DataGridColumnHeadersPresenter : System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter
	{
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeBackground;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeFontFamily;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeFontSize;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeFontStretch;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeFontStyle;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeFontWeight;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeForeground;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeHeight;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeItemTemplate;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeMargin;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeName;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeToolTip;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridColumnHeadersPresenter> bridgeWidth;
		CollectionPropertyBridge<DataGridColumnHeadersPresenter> bridgeItems;


		public DataGridColumnHeadersPresenter()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridColumnHeadersPresenter>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<DataGridColumnHeadersPresenter>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class DataGridDetailsPresenter : System.Windows.Controls.Primitives.DataGridDetailsPresenter
	{
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeHeight;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeMargin;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeName;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeToolTip;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridDetailsPresenter> bridgeWidth;

		public DataGridDetailsPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridDetailsPresenter>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DataGridRow : System.Windows.Controls.DataGridRow
	{
		DependencyPropertyBridge<DataGridRow> bridgeBackground;
		DependencyPropertyBridge<DataGridRow> bridgeFontFamily;
		DependencyPropertyBridge<DataGridRow> bridgeFontSize;
		DependencyPropertyBridge<DataGridRow> bridgeFontStretch;
		DependencyPropertyBridge<DataGridRow> bridgeFontStyle;
		DependencyPropertyBridge<DataGridRow> bridgeFontWeight;
		DependencyPropertyBridge<DataGridRow> bridgeForeground;
		DependencyPropertyBridge<DataGridRow> bridgeHeight;
		DependencyPropertyBridge<DataGridRow> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridRow> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridRow> bridgeMargin;
		DependencyPropertyBridge<DataGridRow> bridgeName;
		DependencyPropertyBridge<DataGridRow> bridgeToolTip;
		DependencyPropertyBridge<DataGridRow> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridRow> bridgeWidth;

		public DataGridRow()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGridRow>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DataGridRow>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGridRow>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGridRow>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGridRow>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGridRow>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGridRow>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGridRow>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridRow>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridRow>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridRow>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridRow>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridRow>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridRow>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridRow>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DataGridRowHeader : System.Windows.Controls.Primitives.DataGridRowHeader
	{
		DependencyPropertyBridge<DataGridRowHeader> bridgeBackground;
		DependencyPropertyBridge<DataGridRowHeader> bridgeContent;
		DependencyPropertyBridge<DataGridRowHeader> bridgeFontFamily;
		DependencyPropertyBridge<DataGridRowHeader> bridgeFontSize;
		DependencyPropertyBridge<DataGridRowHeader> bridgeFontStretch;
		DependencyPropertyBridge<DataGridRowHeader> bridgeFontStyle;
		DependencyPropertyBridge<DataGridRowHeader> bridgeFontWeight;
		DependencyPropertyBridge<DataGridRowHeader> bridgeForeground;
		DependencyPropertyBridge<DataGridRowHeader> bridgeHeight;
		DependencyPropertyBridge<DataGridRowHeader> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridRowHeader> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridRowHeader> bridgeMargin;
		DependencyPropertyBridge<DataGridRowHeader> bridgeName;
		DependencyPropertyBridge<DataGridRowHeader> bridgeToolTip;
		DependencyPropertyBridge<DataGridRowHeader> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridRowHeader> bridgeWidth;

		public DataGridRowHeader()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DataGridRowHeader>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<DataGridRowHeader>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<DataGridRowHeader>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DataGridRowHeader>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DataGridRowHeader>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DataGridRowHeader>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DataGridRowHeader>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DataGridRowHeader>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DataGridRowHeader>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridRowHeader>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridRowHeader>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridRowHeader>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridRowHeader>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridRowHeader>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridRowHeader>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridRowHeader>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DataGridRowsPresenter : System.Windows.Controls.Primitives.DataGridRowsPresenter
	{
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeHeight;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeMargin;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeName;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeToolTip;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<DataGridRowsPresenter> bridgeWidth;
		CollectionPropertyBridge<DataGridRowsPresenter> bridgeChildren;


		public DataGridRowsPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DataGridRowsPresenter>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<DataGridRowsPresenter>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class DatePicker : System.Windows.Controls.DatePicker
	{
		DependencyPropertyBridge<DatePicker> bridgeBackground;
		DependencyPropertyBridge<DatePicker> bridgeFontFamily;
		DependencyPropertyBridge<DatePicker> bridgeFontSize;
		DependencyPropertyBridge<DatePicker> bridgeFontStretch;
		DependencyPropertyBridge<DatePicker> bridgeFontStyle;
		DependencyPropertyBridge<DatePicker> bridgeFontWeight;
		DependencyPropertyBridge<DatePicker> bridgeForeground;
		DependencyPropertyBridge<DatePicker> bridgeHeight;
		DependencyPropertyBridge<DatePicker> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DatePicker> bridgeIsEnabled;
		DependencyPropertyBridge<DatePicker> bridgeMargin;
		DependencyPropertyBridge<DatePicker> bridgeName;
		DependencyPropertyBridge<DatePicker> bridgeToolTip;
		DependencyPropertyBridge<DatePicker> bridgeVerticalAlignment;
		DependencyPropertyBridge<DatePicker> bridgeWidth;

		public DatePicker()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DatePicker>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DatePicker>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DatePicker>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DatePicker>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DatePicker>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DatePicker>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DatePicker>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DatePicker>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DatePicker>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DatePicker>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DatePicker>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DatePicker>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DatePicker>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DatePicker>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DatePicker>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Decorator : System.Windows.Controls.Decorator
	{
		DependencyPropertyBridge<Decorator> bridgeHeight;
		DependencyPropertyBridge<Decorator> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Decorator> bridgeIsEnabled;
		DependencyPropertyBridge<Decorator> bridgeMargin;
		DependencyPropertyBridge<Decorator> bridgeName;
		DependencyPropertyBridge<Decorator> bridgeToolTip;
		DependencyPropertyBridge<Decorator> bridgeVerticalAlignment;
		DependencyPropertyBridge<Decorator> bridgeWidth;

		public Decorator()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Decorator>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Decorator>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Decorator>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Decorator>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Decorator>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Decorator>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Decorator>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Decorator>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DockPanel : System.Windows.Controls.DockPanel
	{
		DependencyPropertyBridge<DockPanel> bridgeHeight;
		DependencyPropertyBridge<DockPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DockPanel> bridgeIsEnabled;
		DependencyPropertyBridge<DockPanel> bridgeLastChildFill;
		DependencyPropertyBridge<DockPanel> bridgeMargin;
		DependencyPropertyBridge<DockPanel> bridgeName;
		DependencyPropertyBridge<DockPanel> bridgeToolTip;
		DependencyPropertyBridge<DockPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<DockPanel> bridgeWidth;
		CollectionPropertyBridge<DockPanel> bridgeChildren;


		public DockPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_LastChildFill = new Cache<bool>(() => base.LastChildFill);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<DockPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DockPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DockPanel>(this, "IsEnabled");
			bridgeLastChildFill = new DependencyPropertyBridge<DockPanel>(this, "LastChildFill");
			bridgeMargin = new DependencyPropertyBridge<DockPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DockPanel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DockPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DockPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DockPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<DockPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<bool> _LastChildFill;

		public new virtual bool LastChildFill
		{
			get
			{
				return _LastChildFill.Get();
			}

			set
			{
				_LastChildFill.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class DocumentPageView : System.Windows.Controls.Primitives.DocumentPageView
	{
		DependencyPropertyBridge<DocumentPageView> bridgeHeight;
		DependencyPropertyBridge<DocumentPageView> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DocumentPageView> bridgeIsEnabled;
		DependencyPropertyBridge<DocumentPageView> bridgeMargin;
		DependencyPropertyBridge<DocumentPageView> bridgeName;
		DependencyPropertyBridge<DocumentPageView> bridgeToolTip;
		DependencyPropertyBridge<DocumentPageView> bridgeVerticalAlignment;
		DependencyPropertyBridge<DocumentPageView> bridgeWidth;

		public DocumentPageView()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<DocumentPageView>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DocumentPageView>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DocumentPageView>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DocumentPageView>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DocumentPageView>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DocumentPageView>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DocumentPageView>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DocumentPageView>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DocumentViewer : System.Windows.Controls.DocumentViewer
	{
		DependencyPropertyBridge<DocumentViewer> bridgeBackground;
		DependencyPropertyBridge<DocumentViewer> bridgeFontFamily;
		DependencyPropertyBridge<DocumentViewer> bridgeFontSize;
		DependencyPropertyBridge<DocumentViewer> bridgeFontStretch;
		DependencyPropertyBridge<DocumentViewer> bridgeFontStyle;
		DependencyPropertyBridge<DocumentViewer> bridgeFontWeight;
		DependencyPropertyBridge<DocumentViewer> bridgeForeground;
		DependencyPropertyBridge<DocumentViewer> bridgeHeight;
		DependencyPropertyBridge<DocumentViewer> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DocumentViewer> bridgeIsEnabled;
		DependencyPropertyBridge<DocumentViewer> bridgeMargin;
		DependencyPropertyBridge<DocumentViewer> bridgeName;
		DependencyPropertyBridge<DocumentViewer> bridgeToolTip;
		DependencyPropertyBridge<DocumentViewer> bridgeVerticalAlignment;
		DependencyPropertyBridge<DocumentViewer> bridgeWidth;

		public DocumentViewer()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DocumentViewer>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DocumentViewer>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DocumentViewer>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DocumentViewer>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DocumentViewer>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DocumentViewer>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DocumentViewer>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DocumentViewer>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DocumentViewer>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DocumentViewer>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DocumentViewer>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DocumentViewer>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DocumentViewer>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DocumentViewer>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DocumentViewer>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class DocumentViewerBase : System.Windows.Controls.Primitives.DocumentViewerBase
	{
		DependencyPropertyBridge<DocumentViewerBase> bridgeBackground;
		DependencyPropertyBridge<DocumentViewerBase> bridgeFontFamily;
		DependencyPropertyBridge<DocumentViewerBase> bridgeFontSize;
		DependencyPropertyBridge<DocumentViewerBase> bridgeFontStretch;
		DependencyPropertyBridge<DocumentViewerBase> bridgeFontStyle;
		DependencyPropertyBridge<DocumentViewerBase> bridgeFontWeight;
		DependencyPropertyBridge<DocumentViewerBase> bridgeForeground;
		DependencyPropertyBridge<DocumentViewerBase> bridgeHeight;
		DependencyPropertyBridge<DocumentViewerBase> bridgeHorizontalAlignment;
		DependencyPropertyBridge<DocumentViewerBase> bridgeIsEnabled;
		DependencyPropertyBridge<DocumentViewerBase> bridgeMargin;
		DependencyPropertyBridge<DocumentViewerBase> bridgeName;
		DependencyPropertyBridge<DocumentViewerBase> bridgeToolTip;
		DependencyPropertyBridge<DocumentViewerBase> bridgeVerticalAlignment;
		DependencyPropertyBridge<DocumentViewerBase> bridgeWidth;

		public DocumentViewerBase()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<DocumentViewerBase>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<DocumentViewerBase>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<DocumentViewerBase>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<DocumentViewerBase>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<DocumentViewerBase>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<DocumentViewerBase>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<DocumentViewerBase>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<DocumentViewerBase>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<DocumentViewerBase>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<DocumentViewerBase>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<DocumentViewerBase>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<DocumentViewerBase>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<DocumentViewerBase>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<DocumentViewerBase>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<DocumentViewerBase>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Expander : System.Windows.Controls.Expander
	{
		DependencyPropertyBridge<Expander> bridgeBackground;
		DependencyPropertyBridge<Expander> bridgeContent;
		DependencyPropertyBridge<Expander> bridgeFontFamily;
		DependencyPropertyBridge<Expander> bridgeFontSize;
		DependencyPropertyBridge<Expander> bridgeFontStretch;
		DependencyPropertyBridge<Expander> bridgeFontStyle;
		DependencyPropertyBridge<Expander> bridgeFontWeight;
		DependencyPropertyBridge<Expander> bridgeForeground;
		DependencyPropertyBridge<Expander> bridgeHeader;
		DependencyPropertyBridge<Expander> bridgeHeight;
		DependencyPropertyBridge<Expander> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Expander> bridgeIsEnabled;
		DependencyPropertyBridge<Expander> bridgeIsExpanded;
		DependencyPropertyBridge<Expander> bridgeMargin;
		DependencyPropertyBridge<Expander> bridgeName;
		DependencyPropertyBridge<Expander> bridgeToolTip;
		DependencyPropertyBridge<Expander> bridgeVerticalAlignment;
		DependencyPropertyBridge<Expander> bridgeWidth;

		public Expander()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_IsExpanded = new Cache<bool>(() => base.IsExpanded);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Expander>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<Expander>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<Expander>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Expander>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Expander>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Expander>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Expander>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Expander>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<Expander>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<Expander>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Expander>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Expander>(this, "IsEnabled");
			bridgeIsExpanded = new DependencyPropertyBridge<Expander>(this, "IsExpanded");
			bridgeMargin = new DependencyPropertyBridge<Expander>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Expander>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Expander>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Expander>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Expander>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<bool> _IsExpanded;

		public new virtual bool IsExpanded
		{
			get
			{
				return _IsExpanded.Get();
			}

			set
			{
				_IsExpanded.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Figure : System.Windows.Documents.Figure
	{
		DependencyPropertyBridge<Figure> bridgeContextMenu;
		DependencyPropertyBridge<Figure> bridgeCursor;
		DependencyPropertyBridge<Figure> bridgeLanguage;
		DependencyPropertyBridge<Figure> bridgeName;
		DependencyPropertyBridge<Figure> bridgeTag;
		DependencyPropertyBridge<Figure> bridgeToolTip;

		public Figure()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Figure>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Figure>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Figure>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Figure>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Figure>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Figure>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class FixedDocument : System.Windows.Documents.FixedDocument
	{
		DependencyPropertyBridge<FixedDocument> bridgeContextMenu;
		DependencyPropertyBridge<FixedDocument> bridgeCursor;
		DependencyPropertyBridge<FixedDocument> bridgeLanguage;
		DependencyPropertyBridge<FixedDocument> bridgeName;
		DependencyPropertyBridge<FixedDocument> bridgeTag;
		DependencyPropertyBridge<FixedDocument> bridgeToolTip;

		public FixedDocument()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<FixedDocument>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<FixedDocument>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<FixedDocument>(this, "Language");
			bridgeName = new DependencyPropertyBridge<FixedDocument>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<FixedDocument>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<FixedDocument>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class FixedDocumentSequence : System.Windows.Documents.FixedDocumentSequence
	{
		DependencyPropertyBridge<FixedDocumentSequence> bridgeContextMenu;
		DependencyPropertyBridge<FixedDocumentSequence> bridgeCursor;
		DependencyPropertyBridge<FixedDocumentSequence> bridgeLanguage;
		DependencyPropertyBridge<FixedDocumentSequence> bridgeName;
		DependencyPropertyBridge<FixedDocumentSequence> bridgeTag;
		DependencyPropertyBridge<FixedDocumentSequence> bridgeToolTip;

		public FixedDocumentSequence()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<FixedDocumentSequence>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<FixedDocumentSequence>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<FixedDocumentSequence>(this, "Language");
			bridgeName = new DependencyPropertyBridge<FixedDocumentSequence>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<FixedDocumentSequence>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<FixedDocumentSequence>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Floater : System.Windows.Documents.Floater
	{
		DependencyPropertyBridge<Floater> bridgeContextMenu;
		DependencyPropertyBridge<Floater> bridgeCursor;
		DependencyPropertyBridge<Floater> bridgeLanguage;
		DependencyPropertyBridge<Floater> bridgeName;
		DependencyPropertyBridge<Floater> bridgeTag;
		DependencyPropertyBridge<Floater> bridgeToolTip;

		public Floater()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Floater>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Floater>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Floater>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Floater>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Floater>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Floater>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class FlowDocument : System.Windows.Documents.FlowDocument
	{
		DependencyPropertyBridge<FlowDocument> bridgeContextMenu;
		DependencyPropertyBridge<FlowDocument> bridgeCursor;
		DependencyPropertyBridge<FlowDocument> bridgeLanguage;
		DependencyPropertyBridge<FlowDocument> bridgeName;
		DependencyPropertyBridge<FlowDocument> bridgeTag;
		DependencyPropertyBridge<FlowDocument> bridgeToolTip;

		public FlowDocument()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<FlowDocument>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<FlowDocument>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<FlowDocument>(this, "Language");
			bridgeName = new DependencyPropertyBridge<FlowDocument>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<FlowDocument>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<FlowDocument>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class FlowDocumentPageViewer : System.Windows.Controls.FlowDocumentPageViewer
	{
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeBackground;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeFontFamily;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeFontSize;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeFontStretch;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeFontStyle;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeFontWeight;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeForeground;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeHeight;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeHorizontalAlignment;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeIsEnabled;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeMargin;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeName;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeToolTip;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeVerticalAlignment;
		DependencyPropertyBridge<FlowDocumentPageViewer> bridgeWidth;

		public FlowDocumentPageViewer()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<FlowDocumentPageViewer>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class FlowDocumentReader : System.Windows.Controls.FlowDocumentReader
	{
		DependencyPropertyBridge<FlowDocumentReader> bridgeBackground;
		DependencyPropertyBridge<FlowDocumentReader> bridgeFontFamily;
		DependencyPropertyBridge<FlowDocumentReader> bridgeFontSize;
		DependencyPropertyBridge<FlowDocumentReader> bridgeFontStretch;
		DependencyPropertyBridge<FlowDocumentReader> bridgeFontStyle;
		DependencyPropertyBridge<FlowDocumentReader> bridgeFontWeight;
		DependencyPropertyBridge<FlowDocumentReader> bridgeForeground;
		DependencyPropertyBridge<FlowDocumentReader> bridgeHeight;
		DependencyPropertyBridge<FlowDocumentReader> bridgeHorizontalAlignment;
		DependencyPropertyBridge<FlowDocumentReader> bridgeIsEnabled;
		DependencyPropertyBridge<FlowDocumentReader> bridgeMargin;
		DependencyPropertyBridge<FlowDocumentReader> bridgeName;
		DependencyPropertyBridge<FlowDocumentReader> bridgeToolTip;
		DependencyPropertyBridge<FlowDocumentReader> bridgeVerticalAlignment;
		DependencyPropertyBridge<FlowDocumentReader> bridgeWidth;

		public FlowDocumentReader()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<FlowDocumentReader>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<FlowDocumentReader>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<FlowDocumentReader>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<FlowDocumentReader>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<FlowDocumentReader>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<FlowDocumentReader>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<FlowDocumentReader>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<FlowDocumentReader>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<FlowDocumentReader>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<FlowDocumentReader>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<FlowDocumentReader>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<FlowDocumentReader>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<FlowDocumentReader>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<FlowDocumentReader>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<FlowDocumentReader>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class FlowDocumentScrollViewer : System.Windows.Controls.FlowDocumentScrollViewer
	{
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeBackground;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeFontFamily;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeFontSize;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeFontStretch;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeFontStyle;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeFontWeight;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeForeground;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeHeight;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeHorizontalAlignment;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeIsEnabled;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeMargin;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeName;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeToolTip;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeVerticalAlignment;
		DependencyPropertyBridge<FlowDocumentScrollViewer> bridgeWidth;

		public FlowDocumentScrollViewer()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<FlowDocumentScrollViewer>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Frame : System.Windows.Controls.Frame
	{
		DependencyPropertyBridge<Frame> bridgeBackground;
		DependencyPropertyBridge<Frame> bridgeContent;
		DependencyPropertyBridge<Frame> bridgeFontFamily;
		DependencyPropertyBridge<Frame> bridgeFontSize;
		DependencyPropertyBridge<Frame> bridgeFontStretch;
		DependencyPropertyBridge<Frame> bridgeFontStyle;
		DependencyPropertyBridge<Frame> bridgeFontWeight;
		DependencyPropertyBridge<Frame> bridgeForeground;
		DependencyPropertyBridge<Frame> bridgeHeight;
		DependencyPropertyBridge<Frame> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Frame> bridgeIsEnabled;
		DependencyPropertyBridge<Frame> bridgeMargin;
		DependencyPropertyBridge<Frame> bridgeName;
		DependencyPropertyBridge<Frame> bridgeToolTip;
		DependencyPropertyBridge<Frame> bridgeVerticalAlignment;
		DependencyPropertyBridge<Frame> bridgeWidth;

		public Frame()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Frame>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<Frame>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<Frame>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Frame>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Frame>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Frame>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Frame>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Frame>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Frame>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Frame>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Frame>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Frame>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Frame>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Frame>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Frame>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Frame>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class FrameworkContentElement : System.Windows.FrameworkContentElement
	{
		DependencyPropertyBridge<FrameworkContentElement> bridgeContextMenu;
		DependencyPropertyBridge<FrameworkContentElement> bridgeCursor;
		DependencyPropertyBridge<FrameworkContentElement> bridgeLanguage;
		DependencyPropertyBridge<FrameworkContentElement> bridgeName;
		DependencyPropertyBridge<FrameworkContentElement> bridgeTag;
		DependencyPropertyBridge<FrameworkContentElement> bridgeToolTip;

		public FrameworkContentElement()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<FrameworkContentElement>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<FrameworkContentElement>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<FrameworkContentElement>(this, "Language");
			bridgeName = new DependencyPropertyBridge<FrameworkContentElement>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<FrameworkContentElement>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<FrameworkContentElement>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class FrameworkElement : System.Windows.FrameworkElement
	{
		DependencyPropertyBridge<FrameworkElement> bridgeHeight;
		DependencyPropertyBridge<FrameworkElement> bridgeHorizontalAlignment;
		DependencyPropertyBridge<FrameworkElement> bridgeIsEnabled;
		DependencyPropertyBridge<FrameworkElement> bridgeMargin;
		DependencyPropertyBridge<FrameworkElement> bridgeName;
		DependencyPropertyBridge<FrameworkElement> bridgeToolTip;
		DependencyPropertyBridge<FrameworkElement> bridgeVerticalAlignment;
		DependencyPropertyBridge<FrameworkElement> bridgeWidth;

		public FrameworkElement()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<FrameworkElement>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<FrameworkElement>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<FrameworkElement>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<FrameworkElement>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<FrameworkElement>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<FrameworkElement>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<FrameworkElement>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<FrameworkElement>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Grid : System.Windows.Controls.Grid
	{
		DependencyPropertyBridge<Grid> bridgeHeight;
		DependencyPropertyBridge<Grid> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Grid> bridgeIsEnabled;
		DependencyPropertyBridge<Grid> bridgeMargin;
		DependencyPropertyBridge<Grid> bridgeName;
		DependencyPropertyBridge<Grid> bridgeToolTip;
		DependencyPropertyBridge<Grid> bridgeVerticalAlignment;
		DependencyPropertyBridge<Grid> bridgeWidth;
		CollectionPropertyBridge<Grid> bridgeChildren;

		CollectionPropertyBridge<Grid> bridgeColumnDefinitions;

		CollectionPropertyBridge<Grid> bridgeRowDefinitions;


		public Grid()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
			_ColumnDefinitions = new Cache<IEnumerable<System.Windows.Controls.ColumnDefinition>>(() =>
			{
				var result = new List<System.Windows.Controls.ColumnDefinition>();
				foreach (var element in base.ColumnDefinitions)
                {
                    result.Add((System.Windows.Controls.ColumnDefinition)element);
				}
				return result;
			});
			_RowDefinitions = new Cache<IEnumerable<System.Windows.Controls.RowDefinition>>(() =>
			{
				var result = new List<System.Windows.Controls.RowDefinition>();
				foreach (var element in base.RowDefinitions)
                {
                    result.Add((System.Windows.Controls.RowDefinition)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Grid>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Grid>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Grid>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Grid>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Grid>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Grid>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Grid>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Grid>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<Grid>(this, "Children");
			bridgeColumnDefinitions = new CollectionPropertyBridge<Grid>(this, "ColumnDefinitions");
			bridgeRowDefinitions = new CollectionPropertyBridge<Grid>(this, "RowDefinitions");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

		Cache<IEnumerable<System.Windows.Controls.ColumnDefinition>> _ColumnDefinitions;

		public new virtual IEnumerable<System.Windows.Controls.ColumnDefinition> ColumnDefinitions
		{
			get
			{
				return _ColumnDefinitions.Get();
			}

			set
			{
				_ColumnDefinitions.Set(value);
			}
		}

		Cache<IEnumerable<System.Windows.Controls.RowDefinition>> _RowDefinitions;

		public new virtual IEnumerable<System.Windows.Controls.RowDefinition> RowDefinitions
		{
			get
			{
				return _RowDefinitions.Get();
			}

			set
			{
				_RowDefinitions.Set(value);
			}
		}

	}

	public class GridSplitter : System.Windows.Controls.GridSplitter
	{
		DependencyPropertyBridge<GridSplitter> bridgeBackground;
		DependencyPropertyBridge<GridSplitter> bridgeFontFamily;
		DependencyPropertyBridge<GridSplitter> bridgeFontSize;
		DependencyPropertyBridge<GridSplitter> bridgeFontStretch;
		DependencyPropertyBridge<GridSplitter> bridgeFontStyle;
		DependencyPropertyBridge<GridSplitter> bridgeFontWeight;
		DependencyPropertyBridge<GridSplitter> bridgeForeground;
		DependencyPropertyBridge<GridSplitter> bridgeHeight;
		DependencyPropertyBridge<GridSplitter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<GridSplitter> bridgeIsEnabled;
		DependencyPropertyBridge<GridSplitter> bridgeMargin;
		DependencyPropertyBridge<GridSplitter> bridgeName;
		DependencyPropertyBridge<GridSplitter> bridgeToolTip;
		DependencyPropertyBridge<GridSplitter> bridgeVerticalAlignment;
		DependencyPropertyBridge<GridSplitter> bridgeWidth;

		public GridSplitter()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<GridSplitter>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<GridSplitter>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<GridSplitter>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<GridSplitter>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<GridSplitter>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<GridSplitter>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<GridSplitter>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<GridSplitter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<GridSplitter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<GridSplitter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<GridSplitter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<GridSplitter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<GridSplitter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<GridSplitter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<GridSplitter>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class GridViewColumnHeader : System.Windows.Controls.GridViewColumnHeader
	{
		DependencyPropertyBridge<GridViewColumnHeader> bridgeBackground;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeContent;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeFontFamily;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeFontSize;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeFontStretch;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeFontStyle;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeFontWeight;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeForeground;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeHeight;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeHorizontalAlignment;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeIsEnabled;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeMargin;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeName;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeToolTip;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeVerticalAlignment;
		DependencyPropertyBridge<GridViewColumnHeader> bridgeWidth;

		public GridViewColumnHeader()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<GridViewColumnHeader>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<GridViewColumnHeader>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<GridViewColumnHeader>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<GridViewColumnHeader>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<GridViewColumnHeader>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<GridViewColumnHeader>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<GridViewColumnHeader>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<GridViewColumnHeader>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<GridViewColumnHeader>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<GridViewColumnHeader>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class GridViewHeaderRowPresenter : System.Windows.Controls.GridViewHeaderRowPresenter
	{
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeHeight;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeMargin;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeName;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeToolTip;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<GridViewHeaderRowPresenter> bridgeWidth;

		public GridViewHeaderRowPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<GridViewHeaderRowPresenter>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class GridViewRowPresenter : System.Windows.Controls.GridViewRowPresenter
	{
		DependencyPropertyBridge<GridViewRowPresenter> bridgeHeight;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeMargin;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeName;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeToolTip;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<GridViewRowPresenter> bridgeWidth;

		public GridViewRowPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<GridViewRowPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<GridViewRowPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<GridViewRowPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<GridViewRowPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<GridViewRowPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<GridViewRowPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<GridViewRowPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<GridViewRowPresenter>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class GroupBox : System.Windows.Controls.GroupBox
	{
		DependencyPropertyBridge<GroupBox> bridgeBackground;
		DependencyPropertyBridge<GroupBox> bridgeContent;
		DependencyPropertyBridge<GroupBox> bridgeFontFamily;
		DependencyPropertyBridge<GroupBox> bridgeFontSize;
		DependencyPropertyBridge<GroupBox> bridgeFontStretch;
		DependencyPropertyBridge<GroupBox> bridgeFontStyle;
		DependencyPropertyBridge<GroupBox> bridgeFontWeight;
		DependencyPropertyBridge<GroupBox> bridgeForeground;
		DependencyPropertyBridge<GroupBox> bridgeHeader;
		DependencyPropertyBridge<GroupBox> bridgeHeight;
		DependencyPropertyBridge<GroupBox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<GroupBox> bridgeIsEnabled;
		DependencyPropertyBridge<GroupBox> bridgeMargin;
		DependencyPropertyBridge<GroupBox> bridgeName;
		DependencyPropertyBridge<GroupBox> bridgeToolTip;
		DependencyPropertyBridge<GroupBox> bridgeVerticalAlignment;
		DependencyPropertyBridge<GroupBox> bridgeWidth;

		public GroupBox()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<GroupBox>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<GroupBox>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<GroupBox>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<GroupBox>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<GroupBox>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<GroupBox>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<GroupBox>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<GroupBox>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<GroupBox>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<GroupBox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<GroupBox>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<GroupBox>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<GroupBox>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<GroupBox>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<GroupBox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<GroupBox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<GroupBox>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class GroupItem : System.Windows.Controls.GroupItem
	{
		DependencyPropertyBridge<GroupItem> bridgeBackground;
		DependencyPropertyBridge<GroupItem> bridgeContent;
		DependencyPropertyBridge<GroupItem> bridgeFontFamily;
		DependencyPropertyBridge<GroupItem> bridgeFontSize;
		DependencyPropertyBridge<GroupItem> bridgeFontStretch;
		DependencyPropertyBridge<GroupItem> bridgeFontStyle;
		DependencyPropertyBridge<GroupItem> bridgeFontWeight;
		DependencyPropertyBridge<GroupItem> bridgeForeground;
		DependencyPropertyBridge<GroupItem> bridgeHeight;
		DependencyPropertyBridge<GroupItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<GroupItem> bridgeIsEnabled;
		DependencyPropertyBridge<GroupItem> bridgeMargin;
		DependencyPropertyBridge<GroupItem> bridgeName;
		DependencyPropertyBridge<GroupItem> bridgeToolTip;
		DependencyPropertyBridge<GroupItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<GroupItem> bridgeWidth;

		public GroupItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<GroupItem>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<GroupItem>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<GroupItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<GroupItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<GroupItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<GroupItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<GroupItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<GroupItem>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<GroupItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<GroupItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<GroupItem>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<GroupItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<GroupItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<GroupItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<GroupItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<GroupItem>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class HeaderedContentControl : System.Windows.Controls.HeaderedContentControl
	{
		DependencyPropertyBridge<HeaderedContentControl> bridgeBackground;
		DependencyPropertyBridge<HeaderedContentControl> bridgeContent;
		DependencyPropertyBridge<HeaderedContentControl> bridgeFontFamily;
		DependencyPropertyBridge<HeaderedContentControl> bridgeFontSize;
		DependencyPropertyBridge<HeaderedContentControl> bridgeFontStretch;
		DependencyPropertyBridge<HeaderedContentControl> bridgeFontStyle;
		DependencyPropertyBridge<HeaderedContentControl> bridgeFontWeight;
		DependencyPropertyBridge<HeaderedContentControl> bridgeForeground;
		DependencyPropertyBridge<HeaderedContentControl> bridgeHeader;
		DependencyPropertyBridge<HeaderedContentControl> bridgeHeight;
		DependencyPropertyBridge<HeaderedContentControl> bridgeHorizontalAlignment;
		DependencyPropertyBridge<HeaderedContentControl> bridgeIsEnabled;
		DependencyPropertyBridge<HeaderedContentControl> bridgeMargin;
		DependencyPropertyBridge<HeaderedContentControl> bridgeName;
		DependencyPropertyBridge<HeaderedContentControl> bridgeToolTip;
		DependencyPropertyBridge<HeaderedContentControl> bridgeVerticalAlignment;
		DependencyPropertyBridge<HeaderedContentControl> bridgeWidth;

		public HeaderedContentControl()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<HeaderedContentControl>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<HeaderedContentControl>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<HeaderedContentControl>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<HeaderedContentControl>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<HeaderedContentControl>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<HeaderedContentControl>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<HeaderedContentControl>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<HeaderedContentControl>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<HeaderedContentControl>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<HeaderedContentControl>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<HeaderedContentControl>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<HeaderedContentControl>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<HeaderedContentControl>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<HeaderedContentControl>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<HeaderedContentControl>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<HeaderedContentControl>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<HeaderedContentControl>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class HeaderedItemsControl : System.Windows.Controls.HeaderedItemsControl
	{
		DependencyPropertyBridge<HeaderedItemsControl> bridgeBackground;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeFontFamily;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeFontSize;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeFontStretch;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeFontStyle;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeFontWeight;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeForeground;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeHeader;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeHeight;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeHorizontalAlignment;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeIsEnabled;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeItemTemplate;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeMargin;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeName;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeToolTip;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeVerticalAlignment;
		DependencyPropertyBridge<HeaderedItemsControl> bridgeWidth;
		CollectionPropertyBridge<HeaderedItemsControl> bridgeItems;


		public HeaderedItemsControl()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<HeaderedItemsControl>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<HeaderedItemsControl>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<HeaderedItemsControl>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<HeaderedItemsControl>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<HeaderedItemsControl>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<HeaderedItemsControl>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<HeaderedItemsControl>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<HeaderedItemsControl>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<HeaderedItemsControl>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<HeaderedItemsControl>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<HeaderedItemsControl>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<HeaderedItemsControl>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class Hyperlink : System.Windows.Documents.Hyperlink
	{
		DependencyPropertyBridge<Hyperlink> bridgeContextMenu;
		DependencyPropertyBridge<Hyperlink> bridgeCursor;
		DependencyPropertyBridge<Hyperlink> bridgeLanguage;
		DependencyPropertyBridge<Hyperlink> bridgeName;
		DependencyPropertyBridge<Hyperlink> bridgeTag;
		DependencyPropertyBridge<Hyperlink> bridgeToolTip;

		public Hyperlink()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Hyperlink>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Hyperlink>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Hyperlink>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Hyperlink>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Hyperlink>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Hyperlink>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Image : System.Windows.Controls.Image
	{
		DependencyPropertyBridge<Image> bridgeHeight;
		DependencyPropertyBridge<Image> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Image> bridgeIsEnabled;
		DependencyPropertyBridge<Image> bridgeMargin;
		DependencyPropertyBridge<Image> bridgeName;
		DependencyPropertyBridge<Image> bridgeSource;
		DependencyPropertyBridge<Image> bridgeToolTip;
		DependencyPropertyBridge<Image> bridgeVerticalAlignment;
		DependencyPropertyBridge<Image> bridgeWidth;

		public Image()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Source = new Cache<System.Windows.Media.ImageSource>(() => base.Source);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Image>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Image>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Image>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Image>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Image>(this, "Name");
			bridgeSource = new DependencyPropertyBridge<Image>(this, "Source");
			bridgeToolTip = new DependencyPropertyBridge<Image>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Image>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Image>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<System.Windows.Media.ImageSource> _Source;

		public new virtual System.Windows.Media.ImageSource Source
		{
			get
			{
				return _Source.Get();
			}

			set
			{
				_Source.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class InkCanvas : System.Windows.Controls.InkCanvas
	{
		DependencyPropertyBridge<InkCanvas> bridgeHeight;
		DependencyPropertyBridge<InkCanvas> bridgeHorizontalAlignment;
		DependencyPropertyBridge<InkCanvas> bridgeIsEnabled;
		DependencyPropertyBridge<InkCanvas> bridgeMargin;
		DependencyPropertyBridge<InkCanvas> bridgeName;
		DependencyPropertyBridge<InkCanvas> bridgeToolTip;
		DependencyPropertyBridge<InkCanvas> bridgeVerticalAlignment;
		DependencyPropertyBridge<InkCanvas> bridgeWidth;

		public InkCanvas()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<InkCanvas>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<InkCanvas>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<InkCanvas>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<InkCanvas>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<InkCanvas>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<InkCanvas>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<InkCanvas>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<InkCanvas>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class InkPresenter : System.Windows.Controls.InkPresenter
	{
		DependencyPropertyBridge<InkPresenter> bridgeHeight;
		DependencyPropertyBridge<InkPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<InkPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<InkPresenter> bridgeMargin;
		DependencyPropertyBridge<InkPresenter> bridgeName;
		DependencyPropertyBridge<InkPresenter> bridgeToolTip;
		DependencyPropertyBridge<InkPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<InkPresenter> bridgeWidth;

		public InkPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<InkPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<InkPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<InkPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<InkPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<InkPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<InkPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<InkPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<InkPresenter>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Inline : System.Windows.Documents.Inline
	{
		DependencyPropertyBridge<Inline> bridgeContextMenu;
		DependencyPropertyBridge<Inline> bridgeCursor;
		DependencyPropertyBridge<Inline> bridgeLanguage;
		DependencyPropertyBridge<Inline> bridgeName;
		DependencyPropertyBridge<Inline> bridgeTag;
		DependencyPropertyBridge<Inline> bridgeToolTip;

		public Inline()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Inline>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Inline>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Inline>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Inline>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Inline>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Inline>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class InlineUIContainer : System.Windows.Documents.InlineUIContainer
	{
		DependencyPropertyBridge<InlineUIContainer> bridgeContextMenu;
		DependencyPropertyBridge<InlineUIContainer> bridgeCursor;
		DependencyPropertyBridge<InlineUIContainer> bridgeLanguage;
		DependencyPropertyBridge<InlineUIContainer> bridgeName;
		DependencyPropertyBridge<InlineUIContainer> bridgeTag;
		DependencyPropertyBridge<InlineUIContainer> bridgeToolTip;

		public InlineUIContainer()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<InlineUIContainer>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<InlineUIContainer>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<InlineUIContainer>(this, "Language");
			bridgeName = new DependencyPropertyBridge<InlineUIContainer>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<InlineUIContainer>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<InlineUIContainer>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Italic : System.Windows.Documents.Italic
	{
		DependencyPropertyBridge<Italic> bridgeContextMenu;
		DependencyPropertyBridge<Italic> bridgeCursor;
		DependencyPropertyBridge<Italic> bridgeLanguage;
		DependencyPropertyBridge<Italic> bridgeName;
		DependencyPropertyBridge<Italic> bridgeTag;
		DependencyPropertyBridge<Italic> bridgeToolTip;

		public Italic()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Italic>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Italic>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Italic>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Italic>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Italic>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Italic>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class ItemsControl : System.Windows.Controls.ItemsControl
	{
		DependencyPropertyBridge<ItemsControl> bridgeBackground;
		DependencyPropertyBridge<ItemsControl> bridgeFontFamily;
		DependencyPropertyBridge<ItemsControl> bridgeFontSize;
		DependencyPropertyBridge<ItemsControl> bridgeFontStretch;
		DependencyPropertyBridge<ItemsControl> bridgeFontStyle;
		DependencyPropertyBridge<ItemsControl> bridgeFontWeight;
		DependencyPropertyBridge<ItemsControl> bridgeForeground;
		DependencyPropertyBridge<ItemsControl> bridgeHeight;
		DependencyPropertyBridge<ItemsControl> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ItemsControl> bridgeIsEnabled;
		DependencyPropertyBridge<ItemsControl> bridgeItemTemplate;
		DependencyPropertyBridge<ItemsControl> bridgeMargin;
		DependencyPropertyBridge<ItemsControl> bridgeName;
		DependencyPropertyBridge<ItemsControl> bridgeToolTip;
		DependencyPropertyBridge<ItemsControl> bridgeVerticalAlignment;
		DependencyPropertyBridge<ItemsControl> bridgeWidth;
		CollectionPropertyBridge<ItemsControl> bridgeItems;


		public ItemsControl()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ItemsControl>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ItemsControl>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ItemsControl>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ItemsControl>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ItemsControl>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ItemsControl>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ItemsControl>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ItemsControl>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ItemsControl>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ItemsControl>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<ItemsControl>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<ItemsControl>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ItemsControl>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ItemsControl>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ItemsControl>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ItemsControl>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<ItemsControl>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class ItemsPresenter : System.Windows.Controls.ItemsPresenter
	{
		DependencyPropertyBridge<ItemsPresenter> bridgeHeight;
		DependencyPropertyBridge<ItemsPresenter> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ItemsPresenter> bridgeIsEnabled;
		DependencyPropertyBridge<ItemsPresenter> bridgeMargin;
		DependencyPropertyBridge<ItemsPresenter> bridgeName;
		DependencyPropertyBridge<ItemsPresenter> bridgeToolTip;
		DependencyPropertyBridge<ItemsPresenter> bridgeVerticalAlignment;
		DependencyPropertyBridge<ItemsPresenter> bridgeWidth;

		public ItemsPresenter()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<ItemsPresenter>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ItemsPresenter>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ItemsPresenter>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ItemsPresenter>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ItemsPresenter>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ItemsPresenter>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ItemsPresenter>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ItemsPresenter>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Label : System.Windows.Controls.Label
	{
		DependencyPropertyBridge<Label> bridgeBackground;
		DependencyPropertyBridge<Label> bridgeContent;
		DependencyPropertyBridge<Label> bridgeFontFamily;
		DependencyPropertyBridge<Label> bridgeFontSize;
		DependencyPropertyBridge<Label> bridgeFontStretch;
		DependencyPropertyBridge<Label> bridgeFontStyle;
		DependencyPropertyBridge<Label> bridgeFontWeight;
		DependencyPropertyBridge<Label> bridgeForeground;
		DependencyPropertyBridge<Label> bridgeHeight;
		DependencyPropertyBridge<Label> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Label> bridgeIsEnabled;
		DependencyPropertyBridge<Label> bridgeMargin;
		DependencyPropertyBridge<Label> bridgeName;
		DependencyPropertyBridge<Label> bridgeToolTip;
		DependencyPropertyBridge<Label> bridgeVerticalAlignment;
		DependencyPropertyBridge<Label> bridgeWidth;

		public Label()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Label>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<Label>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<Label>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Label>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Label>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Label>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Label>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Label>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Label>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Label>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Label>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Label>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Label>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Label>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Label>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Label>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class LineBreak : System.Windows.Documents.LineBreak
	{
		DependencyPropertyBridge<LineBreak> bridgeContextMenu;
		DependencyPropertyBridge<LineBreak> bridgeCursor;
		DependencyPropertyBridge<LineBreak> bridgeLanguage;
		DependencyPropertyBridge<LineBreak> bridgeName;
		DependencyPropertyBridge<LineBreak> bridgeTag;
		DependencyPropertyBridge<LineBreak> bridgeToolTip;

		public LineBreak()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<LineBreak>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<LineBreak>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<LineBreak>(this, "Language");
			bridgeName = new DependencyPropertyBridge<LineBreak>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<LineBreak>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<LineBreak>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class List : System.Windows.Documents.List
	{
		DependencyPropertyBridge<List> bridgeContextMenu;
		DependencyPropertyBridge<List> bridgeCursor;
		DependencyPropertyBridge<List> bridgeLanguage;
		DependencyPropertyBridge<List> bridgeName;
		DependencyPropertyBridge<List> bridgeTag;
		DependencyPropertyBridge<List> bridgeToolTip;

		public List()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<List>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<List>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<List>(this, "Language");
			bridgeName = new DependencyPropertyBridge<List>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<List>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<List>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class ListBox : System.Windows.Controls.ListBox
	{
		DependencyPropertyBridge<ListBox> bridgeBackground;
		DependencyPropertyBridge<ListBox> bridgeFontFamily;
		DependencyPropertyBridge<ListBox> bridgeFontSize;
		DependencyPropertyBridge<ListBox> bridgeFontStretch;
		DependencyPropertyBridge<ListBox> bridgeFontStyle;
		DependencyPropertyBridge<ListBox> bridgeFontWeight;
		DependencyPropertyBridge<ListBox> bridgeForeground;
		DependencyPropertyBridge<ListBox> bridgeHeight;
		DependencyPropertyBridge<ListBox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ListBox> bridgeIsEnabled;
		DependencyPropertyBridge<ListBox> bridgeItemTemplate;
		DependencyPropertyBridge<ListBox> bridgeMargin;
		DependencyPropertyBridge<ListBox> bridgeName;
		DependencyPropertyBridge<ListBox> bridgeSelectedItem;
		DependencyPropertyBridge<ListBox> bridgeSelectionMode;
		DependencyPropertyBridge<ListBox> bridgeToolTip;
		DependencyPropertyBridge<ListBox> bridgeVerticalAlignment;
		DependencyPropertyBridge<ListBox> bridgeWidth;
		CollectionPropertyBridge<ListBox> bridgeItems;

		CollectionPropertyBridge<ListBox> bridgeSelectedItems;


		public ListBox()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_SelectionMode = new Cache<System.Windows.Controls.SelectionMode>(() => base.SelectionMode);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
			_SelectedItems = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.SelectedItems)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ListBox>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ListBox>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ListBox>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ListBox>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ListBox>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ListBox>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ListBox>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ListBox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ListBox>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ListBox>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<ListBox>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<ListBox>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ListBox>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<ListBox>(this, "SelectedItem");
			bridgeSelectionMode = new DependencyPropertyBridge<ListBox>(this, "SelectionMode");
			bridgeToolTip = new DependencyPropertyBridge<ListBox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ListBox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ListBox>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<ListBox>(this, "Items");
			bridgeSelectedItems = new CollectionPropertyBridge<ListBox>(this, "SelectedItems");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<System.Windows.Controls.SelectionMode> _SelectionMode;

		public new virtual System.Windows.Controls.SelectionMode SelectionMode
		{
			get
			{
				return _SelectionMode.Get();
			}

			set
			{
				_SelectionMode.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

		Cache<IEnumerable<object>> _SelectedItems;

		public new virtual IEnumerable<object> SelectedItems
		{
			get
			{
				return _SelectedItems.Get();
			}

			set
			{
				_SelectedItems.Set(value);
			}
		}

	}

	public class ListBoxItem : System.Windows.Controls.ListBoxItem
	{
		DependencyPropertyBridge<ListBoxItem> bridgeBackground;
		DependencyPropertyBridge<ListBoxItem> bridgeContent;
		DependencyPropertyBridge<ListBoxItem> bridgeFontFamily;
		DependencyPropertyBridge<ListBoxItem> bridgeFontSize;
		DependencyPropertyBridge<ListBoxItem> bridgeFontStretch;
		DependencyPropertyBridge<ListBoxItem> bridgeFontStyle;
		DependencyPropertyBridge<ListBoxItem> bridgeFontWeight;
		DependencyPropertyBridge<ListBoxItem> bridgeForeground;
		DependencyPropertyBridge<ListBoxItem> bridgeHeight;
		DependencyPropertyBridge<ListBoxItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ListBoxItem> bridgeIsEnabled;
		DependencyPropertyBridge<ListBoxItem> bridgeMargin;
		DependencyPropertyBridge<ListBoxItem> bridgeName;
		DependencyPropertyBridge<ListBoxItem> bridgeToolTip;
		DependencyPropertyBridge<ListBoxItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<ListBoxItem> bridgeWidth;

		public ListBoxItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ListBoxItem>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ListBoxItem>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ListBoxItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ListBoxItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ListBoxItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ListBoxItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ListBoxItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ListBoxItem>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ListBoxItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ListBoxItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ListBoxItem>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ListBoxItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ListBoxItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ListBoxItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ListBoxItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ListBoxItem>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ListItem : System.Windows.Documents.ListItem
	{
		DependencyPropertyBridge<ListItem> bridgeContextMenu;
		DependencyPropertyBridge<ListItem> bridgeCursor;
		DependencyPropertyBridge<ListItem> bridgeLanguage;
		DependencyPropertyBridge<ListItem> bridgeName;
		DependencyPropertyBridge<ListItem> bridgeTag;
		DependencyPropertyBridge<ListItem> bridgeToolTip;

		public ListItem()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<ListItem>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<ListItem>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<ListItem>(this, "Language");
			bridgeName = new DependencyPropertyBridge<ListItem>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<ListItem>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<ListItem>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class ListView : System.Windows.Controls.ListView
	{
		DependencyPropertyBridge<ListView> bridgeBackground;
		DependencyPropertyBridge<ListView> bridgeFontFamily;
		DependencyPropertyBridge<ListView> bridgeFontSize;
		DependencyPropertyBridge<ListView> bridgeFontStretch;
		DependencyPropertyBridge<ListView> bridgeFontStyle;
		DependencyPropertyBridge<ListView> bridgeFontWeight;
		DependencyPropertyBridge<ListView> bridgeForeground;
		DependencyPropertyBridge<ListView> bridgeHeight;
		DependencyPropertyBridge<ListView> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ListView> bridgeIsEnabled;
		DependencyPropertyBridge<ListView> bridgeItemTemplate;
		DependencyPropertyBridge<ListView> bridgeMargin;
		DependencyPropertyBridge<ListView> bridgeName;
		DependencyPropertyBridge<ListView> bridgeSelectedItem;
		DependencyPropertyBridge<ListView> bridgeSelectionMode;
		DependencyPropertyBridge<ListView> bridgeToolTip;
		DependencyPropertyBridge<ListView> bridgeVerticalAlignment;
		DependencyPropertyBridge<ListView> bridgeView;
		DependencyPropertyBridge<ListView> bridgeWidth;
		CollectionPropertyBridge<ListView> bridgeItems;

		CollectionPropertyBridge<ListView> bridgeSelectedItems;


		public ListView()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_SelectionMode = new Cache<System.Windows.Controls.SelectionMode>(() => base.SelectionMode);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_View = new Cache<System.Windows.Controls.ViewBase>(() => base.View);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
			_SelectedItems = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.SelectedItems)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ListView>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ListView>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ListView>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ListView>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ListView>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ListView>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ListView>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ListView>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ListView>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ListView>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<ListView>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<ListView>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ListView>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<ListView>(this, "SelectedItem");
			bridgeSelectionMode = new DependencyPropertyBridge<ListView>(this, "SelectionMode");
			bridgeToolTip = new DependencyPropertyBridge<ListView>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ListView>(this, "VerticalAlignment");
			bridgeView = new DependencyPropertyBridge<ListView>(this, "View");
			bridgeWidth = new DependencyPropertyBridge<ListView>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<ListView>(this, "Items");
			bridgeSelectedItems = new CollectionPropertyBridge<ListView>(this, "SelectedItems");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<System.Windows.Controls.SelectionMode> _SelectionMode;

		public new virtual System.Windows.Controls.SelectionMode SelectionMode
		{
			get
			{
				return _SelectionMode.Get();
			}

			set
			{
				_SelectionMode.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<System.Windows.Controls.ViewBase> _View;

		public new virtual System.Windows.Controls.ViewBase View
		{
			get
			{
				return _View.Get();
			}

			set
			{
				_View.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

		Cache<IEnumerable<object>> _SelectedItems;

		public new virtual IEnumerable<object> SelectedItems
		{
			get
			{
				return _SelectedItems.Get();
			}

			set
			{
				_SelectedItems.Set(value);
			}
		}

	}

	public class ListViewItem : System.Windows.Controls.ListViewItem
	{
		DependencyPropertyBridge<ListViewItem> bridgeBackground;
		DependencyPropertyBridge<ListViewItem> bridgeContent;
		DependencyPropertyBridge<ListViewItem> bridgeFontFamily;
		DependencyPropertyBridge<ListViewItem> bridgeFontSize;
		DependencyPropertyBridge<ListViewItem> bridgeFontStretch;
		DependencyPropertyBridge<ListViewItem> bridgeFontStyle;
		DependencyPropertyBridge<ListViewItem> bridgeFontWeight;
		DependencyPropertyBridge<ListViewItem> bridgeForeground;
		DependencyPropertyBridge<ListViewItem> bridgeHeight;
		DependencyPropertyBridge<ListViewItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ListViewItem> bridgeIsEnabled;
		DependencyPropertyBridge<ListViewItem> bridgeMargin;
		DependencyPropertyBridge<ListViewItem> bridgeName;
		DependencyPropertyBridge<ListViewItem> bridgeToolTip;
		DependencyPropertyBridge<ListViewItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<ListViewItem> bridgeWidth;

		public ListViewItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ListViewItem>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ListViewItem>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ListViewItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ListViewItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ListViewItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ListViewItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ListViewItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ListViewItem>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ListViewItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ListViewItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ListViewItem>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ListViewItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ListViewItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ListViewItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ListViewItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ListViewItem>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class MediaElement : System.Windows.Controls.MediaElement
	{
		DependencyPropertyBridge<MediaElement> bridgeHeight;
		DependencyPropertyBridge<MediaElement> bridgeHorizontalAlignment;
		DependencyPropertyBridge<MediaElement> bridgeIsEnabled;
		DependencyPropertyBridge<MediaElement> bridgeMargin;
		DependencyPropertyBridge<MediaElement> bridgeName;
		DependencyPropertyBridge<MediaElement> bridgeToolTip;
		DependencyPropertyBridge<MediaElement> bridgeVerticalAlignment;
		DependencyPropertyBridge<MediaElement> bridgeWidth;

		public MediaElement()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<MediaElement>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<MediaElement>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<MediaElement>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<MediaElement>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<MediaElement>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<MediaElement>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<MediaElement>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<MediaElement>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Menu : System.Windows.Controls.Menu
	{
		DependencyPropertyBridge<Menu> bridgeBackground;
		DependencyPropertyBridge<Menu> bridgeFontFamily;
		DependencyPropertyBridge<Menu> bridgeFontSize;
		DependencyPropertyBridge<Menu> bridgeFontStretch;
		DependencyPropertyBridge<Menu> bridgeFontStyle;
		DependencyPropertyBridge<Menu> bridgeFontWeight;
		DependencyPropertyBridge<Menu> bridgeForeground;
		DependencyPropertyBridge<Menu> bridgeHeight;
		DependencyPropertyBridge<Menu> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Menu> bridgeIsEnabled;
		DependencyPropertyBridge<Menu> bridgeItemTemplate;
		DependencyPropertyBridge<Menu> bridgeMargin;
		DependencyPropertyBridge<Menu> bridgeName;
		DependencyPropertyBridge<Menu> bridgeToolTip;
		DependencyPropertyBridge<Menu> bridgeVerticalAlignment;
		DependencyPropertyBridge<Menu> bridgeWidth;
		CollectionPropertyBridge<Menu> bridgeItems;


		public Menu()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Menu>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Menu>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Menu>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Menu>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Menu>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Menu>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Menu>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Menu>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Menu>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Menu>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<Menu>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<Menu>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Menu>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Menu>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Menu>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Menu>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<Menu>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class MenuBase : System.Windows.Controls.Primitives.MenuBase
	{
		DependencyPropertyBridge<MenuBase> bridgeBackground;
		DependencyPropertyBridge<MenuBase> bridgeFontFamily;
		DependencyPropertyBridge<MenuBase> bridgeFontSize;
		DependencyPropertyBridge<MenuBase> bridgeFontStretch;
		DependencyPropertyBridge<MenuBase> bridgeFontStyle;
		DependencyPropertyBridge<MenuBase> bridgeFontWeight;
		DependencyPropertyBridge<MenuBase> bridgeForeground;
		DependencyPropertyBridge<MenuBase> bridgeHeight;
		DependencyPropertyBridge<MenuBase> bridgeHorizontalAlignment;
		DependencyPropertyBridge<MenuBase> bridgeIsEnabled;
		DependencyPropertyBridge<MenuBase> bridgeItemTemplate;
		DependencyPropertyBridge<MenuBase> bridgeMargin;
		DependencyPropertyBridge<MenuBase> bridgeName;
		DependencyPropertyBridge<MenuBase> bridgeToolTip;
		DependencyPropertyBridge<MenuBase> bridgeVerticalAlignment;
		DependencyPropertyBridge<MenuBase> bridgeWidth;
		CollectionPropertyBridge<MenuBase> bridgeItems;


		public MenuBase()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<MenuBase>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<MenuBase>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<MenuBase>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<MenuBase>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<MenuBase>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<MenuBase>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<MenuBase>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<MenuBase>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<MenuBase>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<MenuBase>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<MenuBase>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<MenuBase>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<MenuBase>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<MenuBase>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<MenuBase>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<MenuBase>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<MenuBase>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class MenuItem : System.Windows.Controls.MenuItem
	{
		DependencyPropertyBridge<MenuItem> bridgeBackground;
		DependencyPropertyBridge<MenuItem> bridgeFontFamily;
		DependencyPropertyBridge<MenuItem> bridgeFontSize;
		DependencyPropertyBridge<MenuItem> bridgeFontStretch;
		DependencyPropertyBridge<MenuItem> bridgeFontStyle;
		DependencyPropertyBridge<MenuItem> bridgeFontWeight;
		DependencyPropertyBridge<MenuItem> bridgeForeground;
		DependencyPropertyBridge<MenuItem> bridgeHeader;
		DependencyPropertyBridge<MenuItem> bridgeHeight;
		DependencyPropertyBridge<MenuItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<MenuItem> bridgeIcon;
		DependencyPropertyBridge<MenuItem> bridgeIsCheckable;
		DependencyPropertyBridge<MenuItem> bridgeIsChecked;
		DependencyPropertyBridge<MenuItem> bridgeIsEnabled;
		DependencyPropertyBridge<MenuItem> bridgeItemTemplate;
		DependencyPropertyBridge<MenuItem> bridgeMargin;
		DependencyPropertyBridge<MenuItem> bridgeName;
		DependencyPropertyBridge<MenuItem> bridgeToolTip;
		DependencyPropertyBridge<MenuItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<MenuItem> bridgeWidth;
		CollectionPropertyBridge<MenuItem> bridgeItems;


		public MenuItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_Icon = new Cache<object>(() => base.Icon);
			_IsCheckable = new Cache<bool>(() => base.IsCheckable);
			_IsChecked = new Cache<bool>(() => base.IsChecked);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<MenuItem>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<MenuItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<MenuItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<MenuItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<MenuItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<MenuItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<MenuItem>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<MenuItem>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<MenuItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<MenuItem>(this, "HorizontalAlignment");
			bridgeIcon = new DependencyPropertyBridge<MenuItem>(this, "Icon");
			bridgeIsCheckable = new DependencyPropertyBridge<MenuItem>(this, "IsCheckable");
			bridgeIsChecked = new DependencyPropertyBridge<MenuItem>(this, "IsChecked");
			bridgeIsEnabled = new DependencyPropertyBridge<MenuItem>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<MenuItem>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<MenuItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<MenuItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<MenuItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<MenuItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<MenuItem>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<MenuItem>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<object> _Icon;

		public new virtual object Icon
		{
			get
			{
				return _Icon.Get();
			}

			set
			{
				_Icon.Set(value);
			}
		}

		Cache<bool> _IsCheckable;

		public new virtual bool IsCheckable
		{
			get
			{
				return _IsCheckable.Get();
			}

			set
			{
				_IsCheckable.Set(value);
			}
		}

		Cache<bool> _IsChecked;

		public new virtual bool IsChecked
		{
			get
			{
				return _IsChecked.Get();
			}

			set
			{
				_IsChecked.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class MultiSelector : System.Windows.Controls.Primitives.MultiSelector
	{
		DependencyPropertyBridge<MultiSelector> bridgeBackground;
		DependencyPropertyBridge<MultiSelector> bridgeFontFamily;
		DependencyPropertyBridge<MultiSelector> bridgeFontSize;
		DependencyPropertyBridge<MultiSelector> bridgeFontStretch;
		DependencyPropertyBridge<MultiSelector> bridgeFontStyle;
		DependencyPropertyBridge<MultiSelector> bridgeFontWeight;
		DependencyPropertyBridge<MultiSelector> bridgeForeground;
		DependencyPropertyBridge<MultiSelector> bridgeHeight;
		DependencyPropertyBridge<MultiSelector> bridgeHorizontalAlignment;
		DependencyPropertyBridge<MultiSelector> bridgeIsEnabled;
		DependencyPropertyBridge<MultiSelector> bridgeItemTemplate;
		DependencyPropertyBridge<MultiSelector> bridgeMargin;
		DependencyPropertyBridge<MultiSelector> bridgeName;
		DependencyPropertyBridge<MultiSelector> bridgeSelectedItem;
		DependencyPropertyBridge<MultiSelector> bridgeToolTip;
		DependencyPropertyBridge<MultiSelector> bridgeVerticalAlignment;
		DependencyPropertyBridge<MultiSelector> bridgeWidth;
		CollectionPropertyBridge<MultiSelector> bridgeItems;


		public MultiSelector()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<MultiSelector>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<MultiSelector>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<MultiSelector>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<MultiSelector>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<MultiSelector>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<MultiSelector>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<MultiSelector>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<MultiSelector>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<MultiSelector>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<MultiSelector>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<MultiSelector>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<MultiSelector>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<MultiSelector>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<MultiSelector>(this, "SelectedItem");
			bridgeToolTip = new DependencyPropertyBridge<MultiSelector>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<MultiSelector>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<MultiSelector>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<MultiSelector>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class NavigationWindow : System.Windows.Navigation.NavigationWindow
	{
		DependencyPropertyBridge<NavigationWindow> bridgeBackground;
		DependencyPropertyBridge<NavigationWindow> bridgeContent;
		DependencyPropertyBridge<NavigationWindow> bridgeFontFamily;
		DependencyPropertyBridge<NavigationWindow> bridgeFontSize;
		DependencyPropertyBridge<NavigationWindow> bridgeFontStretch;
		DependencyPropertyBridge<NavigationWindow> bridgeFontStyle;
		DependencyPropertyBridge<NavigationWindow> bridgeFontWeight;
		DependencyPropertyBridge<NavigationWindow> bridgeForeground;
		DependencyPropertyBridge<NavigationWindow> bridgeHeight;
		DependencyPropertyBridge<NavigationWindow> bridgeHorizontalAlignment;
		DependencyPropertyBridge<NavigationWindow> bridgeIsEnabled;
		DependencyPropertyBridge<NavigationWindow> bridgeMargin;
		DependencyPropertyBridge<NavigationWindow> bridgeName;
		DependencyPropertyBridge<NavigationWindow> bridgeTitle;
		DependencyPropertyBridge<NavigationWindow> bridgeToolTip;
		DependencyPropertyBridge<NavigationWindow> bridgeVerticalAlignment;
		DependencyPropertyBridge<NavigationWindow> bridgeWidth;
		RegularPropertyBridge<NavigationWindow> bridgeWindowStartupLocation;

		public NavigationWindow()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Title = new Cache<string>(() => base.Title);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_WindowStartupLocation = new Cache<System.Windows.WindowStartupLocation>(() => base.WindowStartupLocation);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<NavigationWindow>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<NavigationWindow>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<NavigationWindow>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<NavigationWindow>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<NavigationWindow>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<NavigationWindow>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<NavigationWindow>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<NavigationWindow>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<NavigationWindow>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<NavigationWindow>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<NavigationWindow>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<NavigationWindow>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<NavigationWindow>(this, "Name");
			bridgeTitle = new DependencyPropertyBridge<NavigationWindow>(this, "Title");
			bridgeToolTip = new DependencyPropertyBridge<NavigationWindow>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<NavigationWindow>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<NavigationWindow>(this, "Width");
			bridgeWindowStartupLocation = new RegularPropertyBridge<NavigationWindow>(this, "WindowStartupLocation");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<string> _Title;

		public new virtual string Title
		{
			get
			{
				return _Title.Get();
			}

			set
			{
				_Title.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}

		Cache<System.Windows.WindowStartupLocation> _WindowStartupLocation;

		public new virtual System.Windows.WindowStartupLocation WindowStartupLocation
		{
			get
			{
				return _WindowStartupLocation.Get();
			}

			set
			{
				_WindowStartupLocation.Set(value);
			}
		}


	}

	public class Page : System.Windows.Controls.Page
	{
		DependencyPropertyBridge<Page> bridgeHeight;
		DependencyPropertyBridge<Page> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Page> bridgeIsEnabled;
		DependencyPropertyBridge<Page> bridgeMargin;
		DependencyPropertyBridge<Page> bridgeName;
		DependencyPropertyBridge<Page> bridgeToolTip;
		DependencyPropertyBridge<Page> bridgeVerticalAlignment;
		DependencyPropertyBridge<Page> bridgeWidth;

		public Page()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Page>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Page>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Page>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Page>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Page>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Page>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Page>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Page>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class PageFunctionBase : System.Windows.Navigation.PageFunctionBase
	{
		DependencyPropertyBridge<PageFunctionBase> bridgeHeight;
		DependencyPropertyBridge<PageFunctionBase> bridgeHorizontalAlignment;
		DependencyPropertyBridge<PageFunctionBase> bridgeIsEnabled;
		DependencyPropertyBridge<PageFunctionBase> bridgeMargin;
		DependencyPropertyBridge<PageFunctionBase> bridgeName;
		DependencyPropertyBridge<PageFunctionBase> bridgeToolTip;
		DependencyPropertyBridge<PageFunctionBase> bridgeVerticalAlignment;
		DependencyPropertyBridge<PageFunctionBase> bridgeWidth;

		public PageFunctionBase()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<PageFunctionBase>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<PageFunctionBase>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<PageFunctionBase>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<PageFunctionBase>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<PageFunctionBase>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<PageFunctionBase>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<PageFunctionBase>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<PageFunctionBase>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Panel : System.Windows.Controls.Panel
	{
		DependencyPropertyBridge<Panel> bridgeHeight;
		DependencyPropertyBridge<Panel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Panel> bridgeIsEnabled;
		DependencyPropertyBridge<Panel> bridgeMargin;
		DependencyPropertyBridge<Panel> bridgeName;
		DependencyPropertyBridge<Panel> bridgeToolTip;
		DependencyPropertyBridge<Panel> bridgeVerticalAlignment;
		DependencyPropertyBridge<Panel> bridgeWidth;
		CollectionPropertyBridge<Panel> bridgeChildren;


		public Panel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Panel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Panel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Panel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Panel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Panel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Panel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Panel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Panel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<Panel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class Paragraph : System.Windows.Documents.Paragraph
	{
		DependencyPropertyBridge<Paragraph> bridgeContextMenu;
		DependencyPropertyBridge<Paragraph> bridgeCursor;
		DependencyPropertyBridge<Paragraph> bridgeLanguage;
		DependencyPropertyBridge<Paragraph> bridgeName;
		DependencyPropertyBridge<Paragraph> bridgeTag;
		DependencyPropertyBridge<Paragraph> bridgeToolTip;

		public Paragraph()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Paragraph>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Paragraph>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Paragraph>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Paragraph>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Paragraph>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Paragraph>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Popup : System.Windows.Controls.Primitives.Popup
	{
		DependencyPropertyBridge<Popup> bridgeHeight;
		DependencyPropertyBridge<Popup> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Popup> bridgeIsEnabled;
		DependencyPropertyBridge<Popup> bridgeMargin;
		DependencyPropertyBridge<Popup> bridgeName;
		DependencyPropertyBridge<Popup> bridgeToolTip;
		DependencyPropertyBridge<Popup> bridgeVerticalAlignment;
		DependencyPropertyBridge<Popup> bridgeWidth;

		public Popup()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Popup>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Popup>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Popup>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Popup>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Popup>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Popup>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Popup>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Popup>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ProgressBar : System.Windows.Controls.ProgressBar
	{
		DependencyPropertyBridge<ProgressBar> bridgeBackground;
		DependencyPropertyBridge<ProgressBar> bridgeFontFamily;
		DependencyPropertyBridge<ProgressBar> bridgeFontSize;
		DependencyPropertyBridge<ProgressBar> bridgeFontStretch;
		DependencyPropertyBridge<ProgressBar> bridgeFontStyle;
		DependencyPropertyBridge<ProgressBar> bridgeFontWeight;
		DependencyPropertyBridge<ProgressBar> bridgeForeground;
		DependencyPropertyBridge<ProgressBar> bridgeHeight;
		DependencyPropertyBridge<ProgressBar> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ProgressBar> bridgeIsEnabled;
		DependencyPropertyBridge<ProgressBar> bridgeMargin;
		DependencyPropertyBridge<ProgressBar> bridgeName;
		DependencyPropertyBridge<ProgressBar> bridgeToolTip;
		DependencyPropertyBridge<ProgressBar> bridgeVerticalAlignment;
		DependencyPropertyBridge<ProgressBar> bridgeWidth;

		public ProgressBar()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ProgressBar>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ProgressBar>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ProgressBar>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ProgressBar>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ProgressBar>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ProgressBar>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ProgressBar>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ProgressBar>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ProgressBar>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ProgressBar>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ProgressBar>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ProgressBar>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ProgressBar>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ProgressBar>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ProgressBar>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class RadioButton : System.Windows.Controls.RadioButton
	{
		DependencyPropertyBridge<RadioButton> bridgeBackground;
		DependencyPropertyBridge<RadioButton> bridgeContent;
		DependencyPropertyBridge<RadioButton> bridgeFontFamily;
		DependencyPropertyBridge<RadioButton> bridgeFontSize;
		DependencyPropertyBridge<RadioButton> bridgeFontStretch;
		DependencyPropertyBridge<RadioButton> bridgeFontStyle;
		DependencyPropertyBridge<RadioButton> bridgeFontWeight;
		DependencyPropertyBridge<RadioButton> bridgeForeground;
		DependencyPropertyBridge<RadioButton> bridgeHeight;
		DependencyPropertyBridge<RadioButton> bridgeHorizontalAlignment;
		DependencyPropertyBridge<RadioButton> bridgeIsChecked;
		DependencyPropertyBridge<RadioButton> bridgeIsEnabled;
		DependencyPropertyBridge<RadioButton> bridgeMargin;
		DependencyPropertyBridge<RadioButton> bridgeName;
		DependencyPropertyBridge<RadioButton> bridgeToolTip;
		DependencyPropertyBridge<RadioButton> bridgeVerticalAlignment;
		DependencyPropertyBridge<RadioButton> bridgeWidth;

		public RadioButton()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsChecked = new Cache<System.Nullable<bool>>(() => base.IsChecked);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<RadioButton>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<RadioButton>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<RadioButton>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<RadioButton>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<RadioButton>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<RadioButton>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<RadioButton>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<RadioButton>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<RadioButton>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<RadioButton>(this, "HorizontalAlignment");
			bridgeIsChecked = new DependencyPropertyBridge<RadioButton>(this, "IsChecked");
			bridgeIsEnabled = new DependencyPropertyBridge<RadioButton>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<RadioButton>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<RadioButton>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<RadioButton>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<RadioButton>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<RadioButton>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<System.Nullable<bool>> _IsChecked;

		public new virtual System.Nullable<bool> IsChecked
		{
			get
			{
				return _IsChecked.Get();
			}

			set
			{
				_IsChecked.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class RangeBase : System.Windows.Controls.Primitives.RangeBase
	{
		DependencyPropertyBridge<RangeBase> bridgeBackground;
		DependencyPropertyBridge<RangeBase> bridgeFontFamily;
		DependencyPropertyBridge<RangeBase> bridgeFontSize;
		DependencyPropertyBridge<RangeBase> bridgeFontStretch;
		DependencyPropertyBridge<RangeBase> bridgeFontStyle;
		DependencyPropertyBridge<RangeBase> bridgeFontWeight;
		DependencyPropertyBridge<RangeBase> bridgeForeground;
		DependencyPropertyBridge<RangeBase> bridgeHeight;
		DependencyPropertyBridge<RangeBase> bridgeHorizontalAlignment;
		DependencyPropertyBridge<RangeBase> bridgeIsEnabled;
		DependencyPropertyBridge<RangeBase> bridgeMargin;
		DependencyPropertyBridge<RangeBase> bridgeName;
		DependencyPropertyBridge<RangeBase> bridgeToolTip;
		DependencyPropertyBridge<RangeBase> bridgeVerticalAlignment;
		DependencyPropertyBridge<RangeBase> bridgeWidth;

		public RangeBase()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<RangeBase>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<RangeBase>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<RangeBase>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<RangeBase>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<RangeBase>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<RangeBase>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<RangeBase>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<RangeBase>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<RangeBase>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<RangeBase>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<RangeBase>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<RangeBase>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<RangeBase>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<RangeBase>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<RangeBase>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class RepeatButton : System.Windows.Controls.Primitives.RepeatButton
	{
		DependencyPropertyBridge<RepeatButton> bridgeBackground;
		DependencyPropertyBridge<RepeatButton> bridgeContent;
		DependencyPropertyBridge<RepeatButton> bridgeFontFamily;
		DependencyPropertyBridge<RepeatButton> bridgeFontSize;
		DependencyPropertyBridge<RepeatButton> bridgeFontStretch;
		DependencyPropertyBridge<RepeatButton> bridgeFontStyle;
		DependencyPropertyBridge<RepeatButton> bridgeFontWeight;
		DependencyPropertyBridge<RepeatButton> bridgeForeground;
		DependencyPropertyBridge<RepeatButton> bridgeHeight;
		DependencyPropertyBridge<RepeatButton> bridgeHorizontalAlignment;
		DependencyPropertyBridge<RepeatButton> bridgeIsEnabled;
		DependencyPropertyBridge<RepeatButton> bridgeMargin;
		DependencyPropertyBridge<RepeatButton> bridgeName;
		DependencyPropertyBridge<RepeatButton> bridgeToolTip;
		DependencyPropertyBridge<RepeatButton> bridgeVerticalAlignment;
		DependencyPropertyBridge<RepeatButton> bridgeWidth;

		public RepeatButton()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<RepeatButton>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<RepeatButton>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<RepeatButton>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<RepeatButton>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<RepeatButton>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<RepeatButton>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<RepeatButton>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<RepeatButton>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<RepeatButton>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<RepeatButton>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<RepeatButton>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<RepeatButton>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<RepeatButton>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<RepeatButton>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<RepeatButton>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<RepeatButton>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ResizeGrip : System.Windows.Controls.Primitives.ResizeGrip
	{
		DependencyPropertyBridge<ResizeGrip> bridgeBackground;
		DependencyPropertyBridge<ResizeGrip> bridgeFontFamily;
		DependencyPropertyBridge<ResizeGrip> bridgeFontSize;
		DependencyPropertyBridge<ResizeGrip> bridgeFontStretch;
		DependencyPropertyBridge<ResizeGrip> bridgeFontStyle;
		DependencyPropertyBridge<ResizeGrip> bridgeFontWeight;
		DependencyPropertyBridge<ResizeGrip> bridgeForeground;
		DependencyPropertyBridge<ResizeGrip> bridgeHeight;
		DependencyPropertyBridge<ResizeGrip> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ResizeGrip> bridgeIsEnabled;
		DependencyPropertyBridge<ResizeGrip> bridgeMargin;
		DependencyPropertyBridge<ResizeGrip> bridgeName;
		DependencyPropertyBridge<ResizeGrip> bridgeToolTip;
		DependencyPropertyBridge<ResizeGrip> bridgeVerticalAlignment;
		DependencyPropertyBridge<ResizeGrip> bridgeWidth;

		public ResizeGrip()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ResizeGrip>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ResizeGrip>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ResizeGrip>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ResizeGrip>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ResizeGrip>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ResizeGrip>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ResizeGrip>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ResizeGrip>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ResizeGrip>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ResizeGrip>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ResizeGrip>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ResizeGrip>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ResizeGrip>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ResizeGrip>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ResizeGrip>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class RichTextBox : System.Windows.Controls.RichTextBox
	{
		DependencyPropertyBridge<RichTextBox> bridgeBackground;
		DependencyPropertyBridge<RichTextBox> bridgeFontFamily;
		DependencyPropertyBridge<RichTextBox> bridgeFontSize;
		DependencyPropertyBridge<RichTextBox> bridgeFontStretch;
		DependencyPropertyBridge<RichTextBox> bridgeFontStyle;
		DependencyPropertyBridge<RichTextBox> bridgeFontWeight;
		DependencyPropertyBridge<RichTextBox> bridgeForeground;
		DependencyPropertyBridge<RichTextBox> bridgeHeight;
		DependencyPropertyBridge<RichTextBox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<RichTextBox> bridgeIsEnabled;
		DependencyPropertyBridge<RichTextBox> bridgeIsReadOnly;
		DependencyPropertyBridge<RichTextBox> bridgeMargin;
		DependencyPropertyBridge<RichTextBox> bridgeName;
		DependencyPropertyBridge<RichTextBox> bridgeToolTip;
		DependencyPropertyBridge<RichTextBox> bridgeVerticalAlignment;
		DependencyPropertyBridge<RichTextBox> bridgeWidth;

		public RichTextBox()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_IsReadOnly = new Cache<bool>(() => base.IsReadOnly);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<RichTextBox>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<RichTextBox>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<RichTextBox>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<RichTextBox>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<RichTextBox>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<RichTextBox>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<RichTextBox>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<RichTextBox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<RichTextBox>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<RichTextBox>(this, "IsEnabled");
			bridgeIsReadOnly = new DependencyPropertyBridge<RichTextBox>(this, "IsReadOnly");
			bridgeMargin = new DependencyPropertyBridge<RichTextBox>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<RichTextBox>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<RichTextBox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<RichTextBox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<RichTextBox>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<bool> _IsReadOnly;

		public new virtual bool IsReadOnly
		{
			get
			{
				return _IsReadOnly.Get();
			}

			set
			{
				_IsReadOnly.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class RowDefinition : System.Windows.Controls.RowDefinition
	{
		DependencyPropertyBridge<RowDefinition> bridgeContextMenu;
		DependencyPropertyBridge<RowDefinition> bridgeCursor;
		DependencyPropertyBridge<RowDefinition> bridgeHeight;
		DependencyPropertyBridge<RowDefinition> bridgeLanguage;
		DependencyPropertyBridge<RowDefinition> bridgeName;
		DependencyPropertyBridge<RowDefinition> bridgeTag;
		DependencyPropertyBridge<RowDefinition> bridgeToolTip;

		public RowDefinition()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Height = new Cache<System.Windows.GridLength>(() => base.Height);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<RowDefinition>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<RowDefinition>(this, "Cursor");
			bridgeHeight = new DependencyPropertyBridge<RowDefinition>(this, "Height");
			bridgeLanguage = new DependencyPropertyBridge<RowDefinition>(this, "Language");
			bridgeName = new DependencyPropertyBridge<RowDefinition>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<RowDefinition>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<RowDefinition>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.GridLength> _Height;

		public new virtual System.Windows.GridLength Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class Run : System.Windows.Documents.Run
	{
		DependencyPropertyBridge<Run> bridgeContextMenu;
		DependencyPropertyBridge<Run> bridgeCursor;
		DependencyPropertyBridge<Run> bridgeLanguage;
		DependencyPropertyBridge<Run> bridgeName;
		DependencyPropertyBridge<Run> bridgeTag;
		DependencyPropertyBridge<Run> bridgeToolTip;

		public Run()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Run>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Run>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Run>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Run>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Run>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Run>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class ScrollBar : System.Windows.Controls.Primitives.ScrollBar
	{
		DependencyPropertyBridge<ScrollBar> bridgeBackground;
		DependencyPropertyBridge<ScrollBar> bridgeFontFamily;
		DependencyPropertyBridge<ScrollBar> bridgeFontSize;
		DependencyPropertyBridge<ScrollBar> bridgeFontStretch;
		DependencyPropertyBridge<ScrollBar> bridgeFontStyle;
		DependencyPropertyBridge<ScrollBar> bridgeFontWeight;
		DependencyPropertyBridge<ScrollBar> bridgeForeground;
		DependencyPropertyBridge<ScrollBar> bridgeHeight;
		DependencyPropertyBridge<ScrollBar> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ScrollBar> bridgeIsEnabled;
		DependencyPropertyBridge<ScrollBar> bridgeMargin;
		DependencyPropertyBridge<ScrollBar> bridgeName;
		DependencyPropertyBridge<ScrollBar> bridgeToolTip;
		DependencyPropertyBridge<ScrollBar> bridgeVerticalAlignment;
		DependencyPropertyBridge<ScrollBar> bridgeWidth;

		public ScrollBar()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ScrollBar>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ScrollBar>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ScrollBar>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ScrollBar>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ScrollBar>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ScrollBar>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ScrollBar>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ScrollBar>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ScrollBar>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ScrollBar>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ScrollBar>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ScrollBar>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ScrollBar>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ScrollBar>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ScrollBar>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ScrollViewer : System.Windows.Controls.ScrollViewer
	{
		DependencyPropertyBridge<ScrollViewer> bridgeBackground;
		DependencyPropertyBridge<ScrollViewer> bridgeContent;
		DependencyPropertyBridge<ScrollViewer> bridgeFontFamily;
		DependencyPropertyBridge<ScrollViewer> bridgeFontSize;
		DependencyPropertyBridge<ScrollViewer> bridgeFontStretch;
		DependencyPropertyBridge<ScrollViewer> bridgeFontStyle;
		DependencyPropertyBridge<ScrollViewer> bridgeFontWeight;
		DependencyPropertyBridge<ScrollViewer> bridgeForeground;
		DependencyPropertyBridge<ScrollViewer> bridgeHeight;
		DependencyPropertyBridge<ScrollViewer> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ScrollViewer> bridgeIsEnabled;
		DependencyPropertyBridge<ScrollViewer> bridgeMargin;
		DependencyPropertyBridge<ScrollViewer> bridgeName;
		DependencyPropertyBridge<ScrollViewer> bridgeToolTip;
		DependencyPropertyBridge<ScrollViewer> bridgeVerticalAlignment;
		DependencyPropertyBridge<ScrollViewer> bridgeWidth;

		public ScrollViewer()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ScrollViewer>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ScrollViewer>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ScrollViewer>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ScrollViewer>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ScrollViewer>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ScrollViewer>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ScrollViewer>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ScrollViewer>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ScrollViewer>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ScrollViewer>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ScrollViewer>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ScrollViewer>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ScrollViewer>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ScrollViewer>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ScrollViewer>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ScrollViewer>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Section : System.Windows.Documents.Section
	{
		DependencyPropertyBridge<Section> bridgeContextMenu;
		DependencyPropertyBridge<Section> bridgeCursor;
		DependencyPropertyBridge<Section> bridgeLanguage;
		DependencyPropertyBridge<Section> bridgeName;
		DependencyPropertyBridge<Section> bridgeTag;
		DependencyPropertyBridge<Section> bridgeToolTip;

		public Section()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Section>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Section>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Section>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Section>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Section>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Section>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class SelectiveScrollingGrid : System.Windows.Controls.Primitives.SelectiveScrollingGrid
	{
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeHeight;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeHorizontalAlignment;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeIsEnabled;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeMargin;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeName;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeToolTip;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeVerticalAlignment;
		DependencyPropertyBridge<SelectiveScrollingGrid> bridgeWidth;
		CollectionPropertyBridge<SelectiveScrollingGrid> bridgeChildren;

		CollectionPropertyBridge<SelectiveScrollingGrid> bridgeColumnDefinitions;

		CollectionPropertyBridge<SelectiveScrollingGrid> bridgeRowDefinitions;


		public SelectiveScrollingGrid()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
			_ColumnDefinitions = new Cache<IEnumerable<System.Windows.Controls.ColumnDefinition>>(() =>
			{
				var result = new List<System.Windows.Controls.ColumnDefinition>();
				foreach (var element in base.ColumnDefinitions)
                {
                    result.Add((System.Windows.Controls.ColumnDefinition)element);
				}
				return result;
			});
			_RowDefinitions = new Cache<IEnumerable<System.Windows.Controls.RowDefinition>>(() =>
			{
				var result = new List<System.Windows.Controls.RowDefinition>();
				foreach (var element in base.RowDefinitions)
                {
                    result.Add((System.Windows.Controls.RowDefinition)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<SelectiveScrollingGrid>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<SelectiveScrollingGrid>(this, "Children");
			bridgeColumnDefinitions = new CollectionPropertyBridge<SelectiveScrollingGrid>(this, "ColumnDefinitions");
			bridgeRowDefinitions = new CollectionPropertyBridge<SelectiveScrollingGrid>(this, "RowDefinitions");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

		Cache<IEnumerable<System.Windows.Controls.ColumnDefinition>> _ColumnDefinitions;

		public new virtual IEnumerable<System.Windows.Controls.ColumnDefinition> ColumnDefinitions
		{
			get
			{
				return _ColumnDefinitions.Get();
			}

			set
			{
				_ColumnDefinitions.Set(value);
			}
		}

		Cache<IEnumerable<System.Windows.Controls.RowDefinition>> _RowDefinitions;

		public new virtual IEnumerable<System.Windows.Controls.RowDefinition> RowDefinitions
		{
			get
			{
				return _RowDefinitions.Get();
			}

			set
			{
				_RowDefinitions.Set(value);
			}
		}

	}

	public class Selector : System.Windows.Controls.Primitives.Selector
	{
		DependencyPropertyBridge<Selector> bridgeBackground;
		DependencyPropertyBridge<Selector> bridgeFontFamily;
		DependencyPropertyBridge<Selector> bridgeFontSize;
		DependencyPropertyBridge<Selector> bridgeFontStretch;
		DependencyPropertyBridge<Selector> bridgeFontStyle;
		DependencyPropertyBridge<Selector> bridgeFontWeight;
		DependencyPropertyBridge<Selector> bridgeForeground;
		DependencyPropertyBridge<Selector> bridgeHeight;
		DependencyPropertyBridge<Selector> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Selector> bridgeIsEnabled;
		DependencyPropertyBridge<Selector> bridgeItemTemplate;
		DependencyPropertyBridge<Selector> bridgeMargin;
		DependencyPropertyBridge<Selector> bridgeName;
		DependencyPropertyBridge<Selector> bridgeSelectedItem;
		DependencyPropertyBridge<Selector> bridgeToolTip;
		DependencyPropertyBridge<Selector> bridgeVerticalAlignment;
		DependencyPropertyBridge<Selector> bridgeWidth;
		CollectionPropertyBridge<Selector> bridgeItems;


		public Selector()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Selector>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Selector>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Selector>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Selector>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Selector>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Selector>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Selector>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Selector>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Selector>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Selector>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<Selector>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<Selector>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Selector>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<Selector>(this, "SelectedItem");
			bridgeToolTip = new DependencyPropertyBridge<Selector>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Selector>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Selector>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<Selector>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class Separator : System.Windows.Controls.Separator
	{
		DependencyPropertyBridge<Separator> bridgeBackground;
		DependencyPropertyBridge<Separator> bridgeFontFamily;
		DependencyPropertyBridge<Separator> bridgeFontSize;
		DependencyPropertyBridge<Separator> bridgeFontStretch;
		DependencyPropertyBridge<Separator> bridgeFontStyle;
		DependencyPropertyBridge<Separator> bridgeFontWeight;
		DependencyPropertyBridge<Separator> bridgeForeground;
		DependencyPropertyBridge<Separator> bridgeHeight;
		DependencyPropertyBridge<Separator> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Separator> bridgeIsEnabled;
		DependencyPropertyBridge<Separator> bridgeMargin;
		DependencyPropertyBridge<Separator> bridgeName;
		DependencyPropertyBridge<Separator> bridgeToolTip;
		DependencyPropertyBridge<Separator> bridgeVerticalAlignment;
		DependencyPropertyBridge<Separator> bridgeWidth;

		public Separator()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Separator>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Separator>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Separator>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Separator>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Separator>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Separator>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Separator>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Separator>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Separator>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Separator>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Separator>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Separator>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Separator>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Separator>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Separator>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Slider : System.Windows.Controls.Slider
	{
		DependencyPropertyBridge<Slider> bridgeBackground;
		DependencyPropertyBridge<Slider> bridgeFontFamily;
		DependencyPropertyBridge<Slider> bridgeFontSize;
		DependencyPropertyBridge<Slider> bridgeFontStretch;
		DependencyPropertyBridge<Slider> bridgeFontStyle;
		DependencyPropertyBridge<Slider> bridgeFontWeight;
		DependencyPropertyBridge<Slider> bridgeForeground;
		DependencyPropertyBridge<Slider> bridgeHeight;
		DependencyPropertyBridge<Slider> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Slider> bridgeIsEnabled;
		DependencyPropertyBridge<Slider> bridgeMargin;
		DependencyPropertyBridge<Slider> bridgeName;
		DependencyPropertyBridge<Slider> bridgeToolTip;
		DependencyPropertyBridge<Slider> bridgeVerticalAlignment;
		DependencyPropertyBridge<Slider> bridgeWidth;

		public Slider()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Slider>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Slider>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Slider>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Slider>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Slider>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Slider>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Slider>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Slider>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Slider>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Slider>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Slider>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Slider>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Slider>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Slider>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Slider>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Span : System.Windows.Documents.Span
	{
		DependencyPropertyBridge<Span> bridgeContextMenu;
		DependencyPropertyBridge<Span> bridgeCursor;
		DependencyPropertyBridge<Span> bridgeLanguage;
		DependencyPropertyBridge<Span> bridgeName;
		DependencyPropertyBridge<Span> bridgeTag;
		DependencyPropertyBridge<Span> bridgeToolTip;

		public Span()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Span>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Span>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Span>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Span>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Span>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Span>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class StackPanel : System.Windows.Controls.StackPanel
	{
		DependencyPropertyBridge<StackPanel> bridgeHeight;
		DependencyPropertyBridge<StackPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<StackPanel> bridgeIsEnabled;
		DependencyPropertyBridge<StackPanel> bridgeMargin;
		DependencyPropertyBridge<StackPanel> bridgeName;
		DependencyPropertyBridge<StackPanel> bridgeOrientation;
		DependencyPropertyBridge<StackPanel> bridgeToolTip;
		DependencyPropertyBridge<StackPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<StackPanel> bridgeWidth;
		CollectionPropertyBridge<StackPanel> bridgeChildren;


		public StackPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Orientation = new Cache<System.Windows.Controls.Orientation>(() => base.Orientation);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<StackPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<StackPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<StackPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<StackPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<StackPanel>(this, "Name");
			bridgeOrientation = new DependencyPropertyBridge<StackPanel>(this, "Orientation");
			bridgeToolTip = new DependencyPropertyBridge<StackPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<StackPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<StackPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<StackPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<System.Windows.Controls.Orientation> _Orientation;

		public new virtual System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return _Orientation.Get();
			}

			set
			{
				_Orientation.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class StatusBar : System.Windows.Controls.Primitives.StatusBar
	{
		DependencyPropertyBridge<StatusBar> bridgeBackground;
		DependencyPropertyBridge<StatusBar> bridgeFontFamily;
		DependencyPropertyBridge<StatusBar> bridgeFontSize;
		DependencyPropertyBridge<StatusBar> bridgeFontStretch;
		DependencyPropertyBridge<StatusBar> bridgeFontStyle;
		DependencyPropertyBridge<StatusBar> bridgeFontWeight;
		DependencyPropertyBridge<StatusBar> bridgeForeground;
		DependencyPropertyBridge<StatusBar> bridgeHeight;
		DependencyPropertyBridge<StatusBar> bridgeHorizontalAlignment;
		DependencyPropertyBridge<StatusBar> bridgeIsEnabled;
		DependencyPropertyBridge<StatusBar> bridgeItemTemplate;
		DependencyPropertyBridge<StatusBar> bridgeMargin;
		DependencyPropertyBridge<StatusBar> bridgeName;
		DependencyPropertyBridge<StatusBar> bridgeToolTip;
		DependencyPropertyBridge<StatusBar> bridgeVerticalAlignment;
		DependencyPropertyBridge<StatusBar> bridgeWidth;
		CollectionPropertyBridge<StatusBar> bridgeItems;


		public StatusBar()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<StatusBar>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<StatusBar>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<StatusBar>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<StatusBar>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<StatusBar>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<StatusBar>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<StatusBar>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<StatusBar>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<StatusBar>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<StatusBar>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<StatusBar>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<StatusBar>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<StatusBar>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<StatusBar>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<StatusBar>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<StatusBar>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<StatusBar>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class StatusBarItem : System.Windows.Controls.Primitives.StatusBarItem
	{
		DependencyPropertyBridge<StatusBarItem> bridgeBackground;
		DependencyPropertyBridge<StatusBarItem> bridgeContent;
		DependencyPropertyBridge<StatusBarItem> bridgeFontFamily;
		DependencyPropertyBridge<StatusBarItem> bridgeFontSize;
		DependencyPropertyBridge<StatusBarItem> bridgeFontStretch;
		DependencyPropertyBridge<StatusBarItem> bridgeFontStyle;
		DependencyPropertyBridge<StatusBarItem> bridgeFontWeight;
		DependencyPropertyBridge<StatusBarItem> bridgeForeground;
		DependencyPropertyBridge<StatusBarItem> bridgeHeight;
		DependencyPropertyBridge<StatusBarItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<StatusBarItem> bridgeIsEnabled;
		DependencyPropertyBridge<StatusBarItem> bridgeMargin;
		DependencyPropertyBridge<StatusBarItem> bridgeName;
		DependencyPropertyBridge<StatusBarItem> bridgeToolTip;
		DependencyPropertyBridge<StatusBarItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<StatusBarItem> bridgeWidth;

		public StatusBarItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<StatusBarItem>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<StatusBarItem>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<StatusBarItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<StatusBarItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<StatusBarItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<StatusBarItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<StatusBarItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<StatusBarItem>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<StatusBarItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<StatusBarItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<StatusBarItem>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<StatusBarItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<StatusBarItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<StatusBarItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<StatusBarItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<StatusBarItem>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class TabControl : System.Windows.Controls.TabControl
	{
		DependencyPropertyBridge<TabControl> bridgeBackground;
		DependencyPropertyBridge<TabControl> bridgeFontFamily;
		DependencyPropertyBridge<TabControl> bridgeFontSize;
		DependencyPropertyBridge<TabControl> bridgeFontStretch;
		DependencyPropertyBridge<TabControl> bridgeFontStyle;
		DependencyPropertyBridge<TabControl> bridgeFontWeight;
		DependencyPropertyBridge<TabControl> bridgeForeground;
		DependencyPropertyBridge<TabControl> bridgeHeight;
		DependencyPropertyBridge<TabControl> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TabControl> bridgeIsEnabled;
		DependencyPropertyBridge<TabControl> bridgeItemTemplate;
		DependencyPropertyBridge<TabControl> bridgeMargin;
		DependencyPropertyBridge<TabControl> bridgeName;
		DependencyPropertyBridge<TabControl> bridgeSelectedItem;
		DependencyPropertyBridge<TabControl> bridgeToolTip;
		DependencyPropertyBridge<TabControl> bridgeVerticalAlignment;
		DependencyPropertyBridge<TabControl> bridgeWidth;
		CollectionPropertyBridge<TabControl> bridgeItems;


		public TabControl()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<TabControl>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<TabControl>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<TabControl>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<TabControl>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<TabControl>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<TabControl>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<TabControl>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<TabControl>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TabControl>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TabControl>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<TabControl>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<TabControl>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TabControl>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<TabControl>(this, "SelectedItem");
			bridgeToolTip = new DependencyPropertyBridge<TabControl>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TabControl>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TabControl>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<TabControl>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class TabItem : System.Windows.Controls.TabItem
	{
		DependencyPropertyBridge<TabItem> bridgeBackground;
		DependencyPropertyBridge<TabItem> bridgeContent;
		DependencyPropertyBridge<TabItem> bridgeFontFamily;
		DependencyPropertyBridge<TabItem> bridgeFontSize;
		DependencyPropertyBridge<TabItem> bridgeFontStretch;
		DependencyPropertyBridge<TabItem> bridgeFontStyle;
		DependencyPropertyBridge<TabItem> bridgeFontWeight;
		DependencyPropertyBridge<TabItem> bridgeForeground;
		DependencyPropertyBridge<TabItem> bridgeHeader;
		DependencyPropertyBridge<TabItem> bridgeHeight;
		DependencyPropertyBridge<TabItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TabItem> bridgeIsEnabled;
		DependencyPropertyBridge<TabItem> bridgeMargin;
		DependencyPropertyBridge<TabItem> bridgeName;
		DependencyPropertyBridge<TabItem> bridgeToolTip;
		DependencyPropertyBridge<TabItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<TabItem> bridgeWidth;

		public TabItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<TabItem>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<TabItem>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<TabItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<TabItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<TabItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<TabItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<TabItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<TabItem>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<TabItem>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<TabItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TabItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TabItem>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<TabItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TabItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<TabItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TabItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TabItem>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Table : System.Windows.Documents.Table
	{
		DependencyPropertyBridge<Table> bridgeContextMenu;
		DependencyPropertyBridge<Table> bridgeCursor;
		DependencyPropertyBridge<Table> bridgeLanguage;
		DependencyPropertyBridge<Table> bridgeName;
		DependencyPropertyBridge<Table> bridgeTag;
		DependencyPropertyBridge<Table> bridgeToolTip;

		public Table()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Table>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Table>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Table>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Table>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Table>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Table>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class TableCell : System.Windows.Documents.TableCell
	{
		DependencyPropertyBridge<TableCell> bridgeContextMenu;
		DependencyPropertyBridge<TableCell> bridgeCursor;
		DependencyPropertyBridge<TableCell> bridgeLanguage;
		DependencyPropertyBridge<TableCell> bridgeName;
		DependencyPropertyBridge<TableCell> bridgeTag;
		DependencyPropertyBridge<TableCell> bridgeToolTip;

		public TableCell()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<TableCell>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<TableCell>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<TableCell>(this, "Language");
			bridgeName = new DependencyPropertyBridge<TableCell>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<TableCell>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<TableCell>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class TableColumn : System.Windows.Documents.TableColumn
	{
		DependencyPropertyBridge<TableColumn> bridgeContextMenu;
		DependencyPropertyBridge<TableColumn> bridgeCursor;
		DependencyPropertyBridge<TableColumn> bridgeLanguage;
		DependencyPropertyBridge<TableColumn> bridgeName;
		DependencyPropertyBridge<TableColumn> bridgeTag;
		DependencyPropertyBridge<TableColumn> bridgeToolTip;

		public TableColumn()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<TableColumn>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<TableColumn>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<TableColumn>(this, "Language");
			bridgeName = new DependencyPropertyBridge<TableColumn>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<TableColumn>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<TableColumn>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class TableRow : System.Windows.Documents.TableRow
	{
		DependencyPropertyBridge<TableRow> bridgeContextMenu;
		DependencyPropertyBridge<TableRow> bridgeCursor;
		DependencyPropertyBridge<TableRow> bridgeLanguage;
		DependencyPropertyBridge<TableRow> bridgeName;
		DependencyPropertyBridge<TableRow> bridgeTag;
		DependencyPropertyBridge<TableRow> bridgeToolTip;

		public TableRow()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<TableRow>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<TableRow>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<TableRow>(this, "Language");
			bridgeName = new DependencyPropertyBridge<TableRow>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<TableRow>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<TableRow>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class TableRowGroup : System.Windows.Documents.TableRowGroup
	{
		DependencyPropertyBridge<TableRowGroup> bridgeContextMenu;
		DependencyPropertyBridge<TableRowGroup> bridgeCursor;
		DependencyPropertyBridge<TableRowGroup> bridgeLanguage;
		DependencyPropertyBridge<TableRowGroup> bridgeName;
		DependencyPropertyBridge<TableRowGroup> bridgeTag;
		DependencyPropertyBridge<TableRowGroup> bridgeToolTip;

		public TableRowGroup()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<TableRowGroup>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<TableRowGroup>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<TableRowGroup>(this, "Language");
			bridgeName = new DependencyPropertyBridge<TableRowGroup>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<TableRowGroup>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<TableRowGroup>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class TabPanel : System.Windows.Controls.Primitives.TabPanel
	{
		DependencyPropertyBridge<TabPanel> bridgeHeight;
		DependencyPropertyBridge<TabPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TabPanel> bridgeIsEnabled;
		DependencyPropertyBridge<TabPanel> bridgeMargin;
		DependencyPropertyBridge<TabPanel> bridgeName;
		DependencyPropertyBridge<TabPanel> bridgeToolTip;
		DependencyPropertyBridge<TabPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<TabPanel> bridgeWidth;
		CollectionPropertyBridge<TabPanel> bridgeChildren;


		public TabPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<TabPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TabPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TabPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<TabPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TabPanel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<TabPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TabPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TabPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<TabPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class TextBlock : System.Windows.Controls.TextBlock
	{
		DependencyPropertyBridge<TextBlock> bridgeBackground;
		DependencyPropertyBridge<TextBlock> bridgeFontSize;
		DependencyPropertyBridge<TextBlock> bridgeFontWeight;
		DependencyPropertyBridge<TextBlock> bridgeHeight;
		DependencyPropertyBridge<TextBlock> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TextBlock> bridgeIsEnabled;
		DependencyPropertyBridge<TextBlock> bridgeMargin;
		DependencyPropertyBridge<TextBlock> bridgeName;
		DependencyPropertyBridge<TextBlock> bridgePadding;
		DependencyPropertyBridge<TextBlock> bridgeText;
		DependencyPropertyBridge<TextBlock> bridgeTextAlignment;
		DependencyPropertyBridge<TextBlock> bridgeToolTip;
		DependencyPropertyBridge<TextBlock> bridgeVerticalAlignment;
		DependencyPropertyBridge<TextBlock> bridgeWidth;

		public TextBlock()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Padding = new Cache<System.Windows.Thickness>(() => base.Padding);
			_Text = new Cache<string>(() => base.Text);
			_TextAlignment = new Cache<System.Windows.TextAlignment>(() => base.TextAlignment);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<TextBlock>(this, "Background");
			bridgeFontSize = new DependencyPropertyBridge<TextBlock>(this, "FontSize");
			bridgeFontWeight = new DependencyPropertyBridge<TextBlock>(this, "FontWeight");
			bridgeHeight = new DependencyPropertyBridge<TextBlock>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TextBlock>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TextBlock>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<TextBlock>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TextBlock>(this, "Name");
			bridgePadding = new DependencyPropertyBridge<TextBlock>(this, "Padding");
			bridgeText = new DependencyPropertyBridge<TextBlock>(this, "Text");
			bridgeTextAlignment = new DependencyPropertyBridge<TextBlock>(this, "TextAlignment");
			bridgeToolTip = new DependencyPropertyBridge<TextBlock>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TextBlock>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TextBlock>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Padding;

		public new virtual System.Windows.Thickness Padding
		{
			get
			{
				return _Padding.Get();
			}

			set
			{
				_Padding.Set(value);
			}
		}

		Cache<string> _Text;

		public new virtual string Text
		{
			get
			{
				return _Text.Get();
			}

			set
			{
				_Text.Set(value);
			}
		}

		Cache<System.Windows.TextAlignment> _TextAlignment;

		public new virtual System.Windows.TextAlignment TextAlignment
		{
			get
			{
				return _TextAlignment.Get();
			}

			set
			{
				_TextAlignment.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class TextBox : System.Windows.Controls.TextBox
	{
		DependencyPropertyBridge<TextBox> bridgeBackground;
		DependencyPropertyBridge<TextBox> bridgeFontFamily;
		DependencyPropertyBridge<TextBox> bridgeFontSize;
		DependencyPropertyBridge<TextBox> bridgeFontStretch;
		DependencyPropertyBridge<TextBox> bridgeFontStyle;
		DependencyPropertyBridge<TextBox> bridgeFontWeight;
		DependencyPropertyBridge<TextBox> bridgeForeground;
		DependencyPropertyBridge<TextBox> bridgeHeight;
		DependencyPropertyBridge<TextBox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TextBox> bridgeIsEnabled;
		DependencyPropertyBridge<TextBox> bridgeIsReadOnly;
		DependencyPropertyBridge<TextBox> bridgeMargin;
		DependencyPropertyBridge<TextBox> bridgeName;
		DependencyPropertyBridge<TextBox> bridgeText;
		DependencyPropertyBridge<TextBox> bridgeToolTip;
		DependencyPropertyBridge<TextBox> bridgeVerticalAlignment;
		DependencyPropertyBridge<TextBox> bridgeWidth;

		public TextBox()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_IsReadOnly = new Cache<bool>(() => base.IsReadOnly);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Text = new Cache<string>(() => base.Text);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<TextBox>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<TextBox>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<TextBox>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<TextBox>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<TextBox>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<TextBox>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<TextBox>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<TextBox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TextBox>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TextBox>(this, "IsEnabled");
			bridgeIsReadOnly = new DependencyPropertyBridge<TextBox>(this, "IsReadOnly");
			bridgeMargin = new DependencyPropertyBridge<TextBox>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TextBox>(this, "Name");
			bridgeText = new DependencyPropertyBridge<TextBox>(this, "Text");
			bridgeToolTip = new DependencyPropertyBridge<TextBox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TextBox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TextBox>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<bool> _IsReadOnly;

		public new virtual bool IsReadOnly
		{
			get
			{
				return _IsReadOnly.Get();
			}

			set
			{
				_IsReadOnly.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<string> _Text;

		public new virtual string Text
		{
			get
			{
				return _Text.Get();
			}

			set
			{
				_Text.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Thumb : System.Windows.Controls.Primitives.Thumb
	{
		DependencyPropertyBridge<Thumb> bridgeBackground;
		DependencyPropertyBridge<Thumb> bridgeFontFamily;
		DependencyPropertyBridge<Thumb> bridgeFontSize;
		DependencyPropertyBridge<Thumb> bridgeFontStretch;
		DependencyPropertyBridge<Thumb> bridgeFontStyle;
		DependencyPropertyBridge<Thumb> bridgeFontWeight;
		DependencyPropertyBridge<Thumb> bridgeForeground;
		DependencyPropertyBridge<Thumb> bridgeHeight;
		DependencyPropertyBridge<Thumb> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Thumb> bridgeIsEnabled;
		DependencyPropertyBridge<Thumb> bridgeMargin;
		DependencyPropertyBridge<Thumb> bridgeName;
		DependencyPropertyBridge<Thumb> bridgeToolTip;
		DependencyPropertyBridge<Thumb> bridgeVerticalAlignment;
		DependencyPropertyBridge<Thumb> bridgeWidth;

		public Thumb()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Thumb>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<Thumb>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Thumb>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Thumb>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Thumb>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Thumb>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Thumb>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Thumb>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Thumb>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Thumb>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Thumb>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Thumb>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Thumb>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Thumb>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Thumb>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class TickBar : System.Windows.Controls.Primitives.TickBar
	{
		DependencyPropertyBridge<TickBar> bridgeHeight;
		DependencyPropertyBridge<TickBar> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TickBar> bridgeIsEnabled;
		DependencyPropertyBridge<TickBar> bridgeMargin;
		DependencyPropertyBridge<TickBar> bridgeName;
		DependencyPropertyBridge<TickBar> bridgeToolTip;
		DependencyPropertyBridge<TickBar> bridgeVerticalAlignment;
		DependencyPropertyBridge<TickBar> bridgeWidth;

		public TickBar()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<TickBar>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TickBar>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TickBar>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<TickBar>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TickBar>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<TickBar>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TickBar>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TickBar>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ToggleButton : System.Windows.Controls.Primitives.ToggleButton
	{
		DependencyPropertyBridge<ToggleButton> bridgeBackground;
		DependencyPropertyBridge<ToggleButton> bridgeContent;
		DependencyPropertyBridge<ToggleButton> bridgeFontFamily;
		DependencyPropertyBridge<ToggleButton> bridgeFontSize;
		DependencyPropertyBridge<ToggleButton> bridgeFontStretch;
		DependencyPropertyBridge<ToggleButton> bridgeFontStyle;
		DependencyPropertyBridge<ToggleButton> bridgeFontWeight;
		DependencyPropertyBridge<ToggleButton> bridgeForeground;
		DependencyPropertyBridge<ToggleButton> bridgeHeight;
		DependencyPropertyBridge<ToggleButton> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ToggleButton> bridgeIsChecked;
		DependencyPropertyBridge<ToggleButton> bridgeIsEnabled;
		DependencyPropertyBridge<ToggleButton> bridgeMargin;
		DependencyPropertyBridge<ToggleButton> bridgeName;
		DependencyPropertyBridge<ToggleButton> bridgeToolTip;
		DependencyPropertyBridge<ToggleButton> bridgeVerticalAlignment;
		DependencyPropertyBridge<ToggleButton> bridgeWidth;

		public ToggleButton()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsChecked = new Cache<System.Nullable<bool>>(() => base.IsChecked);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ToggleButton>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ToggleButton>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ToggleButton>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ToggleButton>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ToggleButton>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ToggleButton>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ToggleButton>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ToggleButton>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ToggleButton>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ToggleButton>(this, "HorizontalAlignment");
			bridgeIsChecked = new DependencyPropertyBridge<ToggleButton>(this, "IsChecked");
			bridgeIsEnabled = new DependencyPropertyBridge<ToggleButton>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ToggleButton>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ToggleButton>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ToggleButton>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ToggleButton>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ToggleButton>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<System.Nullable<bool>> _IsChecked;

		public new virtual System.Nullable<bool> IsChecked
		{
			get
			{
				return _IsChecked.Get();
			}

			set
			{
				_IsChecked.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ToolBar : System.Windows.Controls.ToolBar
	{
		DependencyPropertyBridge<ToolBar> bridgeBackground;
		DependencyPropertyBridge<ToolBar> bridgeFontFamily;
		DependencyPropertyBridge<ToolBar> bridgeFontSize;
		DependencyPropertyBridge<ToolBar> bridgeFontStretch;
		DependencyPropertyBridge<ToolBar> bridgeFontStyle;
		DependencyPropertyBridge<ToolBar> bridgeFontWeight;
		DependencyPropertyBridge<ToolBar> bridgeForeground;
		DependencyPropertyBridge<ToolBar> bridgeHeader;
		DependencyPropertyBridge<ToolBar> bridgeHeight;
		DependencyPropertyBridge<ToolBar> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ToolBar> bridgeIsEnabled;
		DependencyPropertyBridge<ToolBar> bridgeItemTemplate;
		DependencyPropertyBridge<ToolBar> bridgeMargin;
		DependencyPropertyBridge<ToolBar> bridgeName;
		DependencyPropertyBridge<ToolBar> bridgeToolTip;
		DependencyPropertyBridge<ToolBar> bridgeVerticalAlignment;
		DependencyPropertyBridge<ToolBar> bridgeWidth;
		CollectionPropertyBridge<ToolBar> bridgeItems;


		public ToolBar()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ToolBar>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<ToolBar>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ToolBar>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ToolBar>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ToolBar>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ToolBar>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ToolBar>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<ToolBar>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<ToolBar>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ToolBar>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ToolBar>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<ToolBar>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<ToolBar>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ToolBar>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ToolBar>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ToolBar>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ToolBar>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<ToolBar>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class ToolBarOverflowPanel : System.Windows.Controls.Primitives.ToolBarOverflowPanel
	{
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeHeight;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeIsEnabled;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeMargin;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeName;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeToolTip;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<ToolBarOverflowPanel> bridgeWidth;
		CollectionPropertyBridge<ToolBarOverflowPanel> bridgeChildren;


		public ToolBarOverflowPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ToolBarOverflowPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<ToolBarOverflowPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class ToolBarPanel : System.Windows.Controls.Primitives.ToolBarPanel
	{
		DependencyPropertyBridge<ToolBarPanel> bridgeHeight;
		DependencyPropertyBridge<ToolBarPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ToolBarPanel> bridgeIsEnabled;
		DependencyPropertyBridge<ToolBarPanel> bridgeMargin;
		DependencyPropertyBridge<ToolBarPanel> bridgeName;
		DependencyPropertyBridge<ToolBarPanel> bridgeOrientation;
		DependencyPropertyBridge<ToolBarPanel> bridgeToolTip;
		DependencyPropertyBridge<ToolBarPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<ToolBarPanel> bridgeWidth;
		CollectionPropertyBridge<ToolBarPanel> bridgeChildren;


		public ToolBarPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Orientation = new Cache<System.Windows.Controls.Orientation>(() => base.Orientation);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<ToolBarPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ToolBarPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ToolBarPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ToolBarPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ToolBarPanel>(this, "Name");
			bridgeOrientation = new DependencyPropertyBridge<ToolBarPanel>(this, "Orientation");
			bridgeToolTip = new DependencyPropertyBridge<ToolBarPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ToolBarPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ToolBarPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<ToolBarPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<System.Windows.Controls.Orientation> _Orientation;

		public new virtual System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return _Orientation.Get();
			}

			set
			{
				_Orientation.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class ToolBarTray : System.Windows.Controls.ToolBarTray
	{
		DependencyPropertyBridge<ToolBarTray> bridgeHeight;
		DependencyPropertyBridge<ToolBarTray> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ToolBarTray> bridgeIsEnabled;
		DependencyPropertyBridge<ToolBarTray> bridgeMargin;
		DependencyPropertyBridge<ToolBarTray> bridgeName;
		DependencyPropertyBridge<ToolBarTray> bridgeToolTip;
		DependencyPropertyBridge<ToolBarTray> bridgeVerticalAlignment;
		DependencyPropertyBridge<ToolBarTray> bridgeWidth;

		public ToolBarTray()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<ToolBarTray>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ToolBarTray>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ToolBarTray>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ToolBarTray>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ToolBarTray>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<ToolBarTray>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ToolBarTray>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ToolBarTray>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class ToolTip : System.Windows.Controls.ToolTip
	{
		DependencyPropertyBridge<ToolTip> bridgeBackground;
		DependencyPropertyBridge<ToolTip> bridgeContent;
		DependencyPropertyBridge<ToolTip> bridgeFontFamily;
		DependencyPropertyBridge<ToolTip> bridgeFontSize;
		DependencyPropertyBridge<ToolTip> bridgeFontStretch;
		DependencyPropertyBridge<ToolTip> bridgeFontStyle;
		DependencyPropertyBridge<ToolTip> bridgeFontWeight;
		DependencyPropertyBridge<ToolTip> bridgeForeground;
		DependencyPropertyBridge<ToolTip> bridgeHeight;
		DependencyPropertyBridge<ToolTip> bridgeHorizontalAlignment;
		DependencyPropertyBridge<ToolTip> bridgeIsEnabled;
		DependencyPropertyBridge<ToolTip> bridgeMargin;
		DependencyPropertyBridge<ToolTip> bridgeName;
		DependencyPropertyBridge<ToolTip> bridgeVerticalAlignment;
		DependencyPropertyBridge<ToolTip> bridgeWidth;

		public ToolTip()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<ToolTip>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<ToolTip>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<ToolTip>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<ToolTip>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<ToolTip>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<ToolTip>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<ToolTip>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<ToolTip>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<ToolTip>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<ToolTip>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<ToolTip>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<ToolTip>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<ToolTip>(this, "Name");
			bridgeVerticalAlignment = new DependencyPropertyBridge<ToolTip>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<ToolTip>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Track : System.Windows.Controls.Primitives.Track
	{
		DependencyPropertyBridge<Track> bridgeHeight;
		DependencyPropertyBridge<Track> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Track> bridgeIsEnabled;
		DependencyPropertyBridge<Track> bridgeMargin;
		DependencyPropertyBridge<Track> bridgeName;
		DependencyPropertyBridge<Track> bridgeToolTip;
		DependencyPropertyBridge<Track> bridgeVerticalAlignment;
		DependencyPropertyBridge<Track> bridgeWidth;

		public Track()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Track>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Track>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Track>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Track>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Track>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Track>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Track>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Track>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class TreeView : System.Windows.Controls.TreeView
	{
		DependencyPropertyBridge<TreeView> bridgeBackground;
		DependencyPropertyBridge<TreeView> bridgeFontFamily;
		DependencyPropertyBridge<TreeView> bridgeFontSize;
		DependencyPropertyBridge<TreeView> bridgeFontStretch;
		DependencyPropertyBridge<TreeView> bridgeFontStyle;
		DependencyPropertyBridge<TreeView> bridgeFontWeight;
		DependencyPropertyBridge<TreeView> bridgeForeground;
		DependencyPropertyBridge<TreeView> bridgeHeight;
		DependencyPropertyBridge<TreeView> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TreeView> bridgeIsEnabled;
		DependencyPropertyBridge<TreeView> bridgeItemTemplate;
		DependencyPropertyBridge<TreeView> bridgeMargin;
		DependencyPropertyBridge<TreeView> bridgeName;
		DependencyPropertyBridge<TreeView> bridgeSelectedItem;
		DependencyPropertyBridge<TreeView> bridgeToolTip;
		DependencyPropertyBridge<TreeView> bridgeVerticalAlignment;
		DependencyPropertyBridge<TreeView> bridgeWidth;
		CollectionPropertyBridge<TreeView> bridgeItems;


		public TreeView()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_SelectedItem = new Cache<object>(() => base.SelectedItem);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<TreeView>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<TreeView>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<TreeView>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<TreeView>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<TreeView>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<TreeView>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<TreeView>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<TreeView>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TreeView>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TreeView>(this, "IsEnabled");
			bridgeItemTemplate = new DependencyPropertyBridge<TreeView>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<TreeView>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TreeView>(this, "Name");
			bridgeSelectedItem = new DependencyPropertyBridge<TreeView>(this, "SelectedItem");
			bridgeToolTip = new DependencyPropertyBridge<TreeView>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TreeView>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TreeView>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<TreeView>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _SelectedItem;

		public new virtual object SelectedItem
		{
			get
			{
				return _SelectedItem.Get();
			}

			set
			{
				_SelectedItem.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class TreeViewItem : System.Windows.Controls.TreeViewItem
	{
		DependencyPropertyBridge<TreeViewItem> bridgeBackground;
		DependencyPropertyBridge<TreeViewItem> bridgeFontFamily;
		DependencyPropertyBridge<TreeViewItem> bridgeFontSize;
		DependencyPropertyBridge<TreeViewItem> bridgeFontStretch;
		DependencyPropertyBridge<TreeViewItem> bridgeFontStyle;
		DependencyPropertyBridge<TreeViewItem> bridgeFontWeight;
		DependencyPropertyBridge<TreeViewItem> bridgeForeground;
		DependencyPropertyBridge<TreeViewItem> bridgeHeader;
		DependencyPropertyBridge<TreeViewItem> bridgeHeight;
		DependencyPropertyBridge<TreeViewItem> bridgeHorizontalAlignment;
		DependencyPropertyBridge<TreeViewItem> bridgeIsEnabled;
		DependencyPropertyBridge<TreeViewItem> bridgeIsSelected;
		DependencyPropertyBridge<TreeViewItem> bridgeItemTemplate;
		DependencyPropertyBridge<TreeViewItem> bridgeMargin;
		DependencyPropertyBridge<TreeViewItem> bridgeName;
		DependencyPropertyBridge<TreeViewItem> bridgeToolTip;
		DependencyPropertyBridge<TreeViewItem> bridgeVerticalAlignment;
		DependencyPropertyBridge<TreeViewItem> bridgeWidth;
		CollectionPropertyBridge<TreeViewItem> bridgeItems;


		public TreeViewItem()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Header = new Cache<object>(() => base.Header);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_IsSelected = new Cache<bool>(() => base.IsSelected);
			_ItemTemplate = new Cache<System.Windows.DataTemplate>(() => base.ItemTemplate);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Items = new Cache<IEnumerable<object>>(() =>
			{
				var result = new List<object>();
				foreach (var element in base.Items)
                {
                    result.Add((object)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<TreeViewItem>(this, "Background");
			bridgeFontFamily = new DependencyPropertyBridge<TreeViewItem>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<TreeViewItem>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<TreeViewItem>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<TreeViewItem>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<TreeViewItem>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<TreeViewItem>(this, "Foreground");
			bridgeHeader = new DependencyPropertyBridge<TreeViewItem>(this, "Header");
			bridgeHeight = new DependencyPropertyBridge<TreeViewItem>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<TreeViewItem>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<TreeViewItem>(this, "IsEnabled");
			bridgeIsSelected = new DependencyPropertyBridge<TreeViewItem>(this, "IsSelected");
			bridgeItemTemplate = new DependencyPropertyBridge<TreeViewItem>(this, "ItemTemplate");
			bridgeMargin = new DependencyPropertyBridge<TreeViewItem>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<TreeViewItem>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<TreeViewItem>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<TreeViewItem>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<TreeViewItem>(this, "Width");
			bridgeItems = new CollectionPropertyBridge<TreeViewItem>(this, "Items");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<object> _Header;

		public new virtual object Header
		{
			get
			{
				return _Header.Get();
			}

			set
			{
				_Header.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<bool> _IsSelected;

		public new virtual bool IsSelected
		{
			get
			{
				return _IsSelected.Get();
			}

			set
			{
				_IsSelected.Set(value);
			}
		}

		Cache<System.Windows.DataTemplate> _ItemTemplate;

		public new virtual System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return _ItemTemplate.Get();
			}

			set
			{
				_ItemTemplate.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<object>> _Items;

		public new virtual IEnumerable<object> Items
		{
			get
			{
				return _Items.Get();
			}

			set
			{
				_Items.Set(value);
			}
		}

	}

	public class Underline : System.Windows.Documents.Underline
	{
		DependencyPropertyBridge<Underline> bridgeContextMenu;
		DependencyPropertyBridge<Underline> bridgeCursor;
		DependencyPropertyBridge<Underline> bridgeLanguage;
		DependencyPropertyBridge<Underline> bridgeName;
		DependencyPropertyBridge<Underline> bridgeTag;
		DependencyPropertyBridge<Underline> bridgeToolTip;

		public Underline()
		{
			_ContextMenu = new Cache<System.Windows.Controls.ContextMenu>(() => base.ContextMenu);
			_Cursor = new Cache<System.Windows.Input.Cursor>(() => base.Cursor);
			_Language = new Cache<System.Windows.Markup.XmlLanguage>(() => base.Language);
			_Name = new Cache<string>(() => base.Name);
			_Tag = new Cache<object>(() => base.Tag);
			_ToolTip = new Cache<object>(() => base.ToolTip);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeContextMenu = new DependencyPropertyBridge<Underline>(this, "ContextMenu");
			bridgeCursor = new DependencyPropertyBridge<Underline>(this, "Cursor");
			bridgeLanguage = new DependencyPropertyBridge<Underline>(this, "Language");
			bridgeName = new DependencyPropertyBridge<Underline>(this, "Name");
			bridgeTag = new DependencyPropertyBridge<Underline>(this, "Tag");
			bridgeToolTip = new DependencyPropertyBridge<Underline>(this, "ToolTip");
		}

		Cache<System.Windows.Controls.ContextMenu> _ContextMenu;

		public new virtual System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return _ContextMenu.Get();
			}

			set
			{
				_ContextMenu.Set(value);
			}
		}

		Cache<System.Windows.Input.Cursor> _Cursor;

		public new virtual System.Windows.Input.Cursor Cursor
		{
			get
			{
				return _Cursor.Get();
			}

			set
			{
				_Cursor.Set(value);
			}
		}

		Cache<System.Windows.Markup.XmlLanguage> _Language;

		public new virtual System.Windows.Markup.XmlLanguage Language
		{
			get
			{
				return _Language.Get();
			}

			set
			{
				_Language.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _Tag;

		public new virtual object Tag
		{
			get
			{
				return _Tag.Get();
			}

			set
			{
				_Tag.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}


	}

	public class UniformGrid : System.Windows.Controls.Primitives.UniformGrid
	{
		DependencyPropertyBridge<UniformGrid> bridgeHeight;
		DependencyPropertyBridge<UniformGrid> bridgeHorizontalAlignment;
		DependencyPropertyBridge<UniformGrid> bridgeIsEnabled;
		DependencyPropertyBridge<UniformGrid> bridgeMargin;
		DependencyPropertyBridge<UniformGrid> bridgeName;
		DependencyPropertyBridge<UniformGrid> bridgeToolTip;
		DependencyPropertyBridge<UniformGrid> bridgeVerticalAlignment;
		DependencyPropertyBridge<UniformGrid> bridgeWidth;
		CollectionPropertyBridge<UniformGrid> bridgeChildren;


		public UniformGrid()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<UniformGrid>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<UniformGrid>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<UniformGrid>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<UniformGrid>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<UniformGrid>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<UniformGrid>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<UniformGrid>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<UniformGrid>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<UniformGrid>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class UserControl : System.Windows.Controls.UserControl
	{
		DependencyPropertyBridge<UserControl> bridgeBackground;
		DependencyPropertyBridge<UserControl> bridgeContent;
		DependencyPropertyBridge<UserControl> bridgeFontFamily;
		DependencyPropertyBridge<UserControl> bridgeFontSize;
		DependencyPropertyBridge<UserControl> bridgeFontStretch;
		DependencyPropertyBridge<UserControl> bridgeFontStyle;
		DependencyPropertyBridge<UserControl> bridgeFontWeight;
		DependencyPropertyBridge<UserControl> bridgeForeground;
		DependencyPropertyBridge<UserControl> bridgeHeight;
		DependencyPropertyBridge<UserControl> bridgeHorizontalAlignment;
		DependencyPropertyBridge<UserControl> bridgeIsEnabled;
		DependencyPropertyBridge<UserControl> bridgeMargin;
		DependencyPropertyBridge<UserControl> bridgeName;
		DependencyPropertyBridge<UserControl> bridgeToolTip;
		DependencyPropertyBridge<UserControl> bridgeVerticalAlignment;
		DependencyPropertyBridge<UserControl> bridgeWidth;

		public UserControl()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<UserControl>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<UserControl>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<UserControl>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<UserControl>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<UserControl>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<UserControl>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<UserControl>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<UserControl>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<UserControl>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<UserControl>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<UserControl>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<UserControl>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<UserControl>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<UserControl>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<UserControl>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<UserControl>(this, "Width");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Viewbox : System.Windows.Controls.Viewbox
	{
		DependencyPropertyBridge<Viewbox> bridgeHeight;
		DependencyPropertyBridge<Viewbox> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Viewbox> bridgeIsEnabled;
		DependencyPropertyBridge<Viewbox> bridgeMargin;
		DependencyPropertyBridge<Viewbox> bridgeName;
		DependencyPropertyBridge<Viewbox> bridgeToolTip;
		DependencyPropertyBridge<Viewbox> bridgeVerticalAlignment;
		DependencyPropertyBridge<Viewbox> bridgeWidth;

		public Viewbox()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Viewbox>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Viewbox>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Viewbox>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Viewbox>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Viewbox>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Viewbox>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Viewbox>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Viewbox>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class Viewport3D : System.Windows.Controls.Viewport3D
	{
		DependencyPropertyBridge<Viewport3D> bridgeHeight;
		DependencyPropertyBridge<Viewport3D> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Viewport3D> bridgeIsEnabled;
		DependencyPropertyBridge<Viewport3D> bridgeMargin;
		DependencyPropertyBridge<Viewport3D> bridgeName;
		DependencyPropertyBridge<Viewport3D> bridgeToolTip;
		DependencyPropertyBridge<Viewport3D> bridgeVerticalAlignment;
		DependencyPropertyBridge<Viewport3D> bridgeWidth;

		public Viewport3D()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<Viewport3D>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Viewport3D>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Viewport3D>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Viewport3D>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Viewport3D>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<Viewport3D>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Viewport3D>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Viewport3D>(this, "Width");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


	}

	public class VirtualizingPanel : System.Windows.Controls.VirtualizingPanel
	{
		DependencyPropertyBridge<VirtualizingPanel> bridgeHeight;
		DependencyPropertyBridge<VirtualizingPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<VirtualizingPanel> bridgeIsEnabled;
		DependencyPropertyBridge<VirtualizingPanel> bridgeMargin;
		DependencyPropertyBridge<VirtualizingPanel> bridgeName;
		DependencyPropertyBridge<VirtualizingPanel> bridgeToolTip;
		DependencyPropertyBridge<VirtualizingPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<VirtualizingPanel> bridgeWidth;
		CollectionPropertyBridge<VirtualizingPanel> bridgeChildren;


		public VirtualizingPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<VirtualizingPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<VirtualizingPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<VirtualizingPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<VirtualizingPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<VirtualizingPanel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<VirtualizingPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<VirtualizingPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<VirtualizingPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<VirtualizingPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class VirtualizingStackPanel : System.Windows.Controls.VirtualizingStackPanel
	{
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeHeight;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeIsEnabled;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeMargin;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeName;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeToolTip;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<VirtualizingStackPanel> bridgeWidth;
		CollectionPropertyBridge<VirtualizingStackPanel> bridgeChildren;


		public VirtualizingStackPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "Name");
			bridgeToolTip = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<VirtualizingStackPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<VirtualizingStackPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

	public class Window : System.Windows.Window
	{
		DependencyPropertyBridge<Window> bridgeBackground;
		DependencyPropertyBridge<Window> bridgeContent;
		DependencyPropertyBridge<Window> bridgeFontFamily;
		DependencyPropertyBridge<Window> bridgeFontSize;
		DependencyPropertyBridge<Window> bridgeFontStretch;
		DependencyPropertyBridge<Window> bridgeFontStyle;
		DependencyPropertyBridge<Window> bridgeFontWeight;
		DependencyPropertyBridge<Window> bridgeForeground;
		DependencyPropertyBridge<Window> bridgeHeight;
		DependencyPropertyBridge<Window> bridgeHorizontalAlignment;
		DependencyPropertyBridge<Window> bridgeIsEnabled;
		DependencyPropertyBridge<Window> bridgeMargin;
		DependencyPropertyBridge<Window> bridgeName;
		DependencyPropertyBridge<Window> bridgeTitle;
		DependencyPropertyBridge<Window> bridgeToolTip;
		DependencyPropertyBridge<Window> bridgeVerticalAlignment;
		DependencyPropertyBridge<Window> bridgeWidth;
		RegularPropertyBridge<Window> bridgeWindowStartupLocation;

		public Window()
		{
			_Background = new Cache<System.Windows.Media.Brush>(() => base.Background);
			_Content = new Cache<object>(() => base.Content);
			_FontFamily = new Cache<System.Windows.Media.FontFamily>(() => base.FontFamily);
			_FontSize = new Cache<double>(() => base.FontSize);
			_FontStretch = new Cache<System.Windows.FontStretch>(() => base.FontStretch);
			_FontStyle = new Cache<System.Windows.FontStyle>(() => base.FontStyle);
			_FontWeight = new Cache<System.Windows.FontWeight>(() => base.FontWeight);
			_Foreground = new Cache<System.Windows.Media.Brush>(() => base.Foreground);
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Title = new Cache<string>(() => base.Title);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_WindowStartupLocation = new Cache<System.Windows.WindowStartupLocation>(() => base.WindowStartupLocation);
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeBackground = new DependencyPropertyBridge<Window>(this, "Background");
			bridgeContent = new DependencyPropertyBridge<Window>(this, "Content");
			bridgeFontFamily = new DependencyPropertyBridge<Window>(this, "FontFamily");
			bridgeFontSize = new DependencyPropertyBridge<Window>(this, "FontSize");
			bridgeFontStretch = new DependencyPropertyBridge<Window>(this, "FontStretch");
			bridgeFontStyle = new DependencyPropertyBridge<Window>(this, "FontStyle");
			bridgeFontWeight = new DependencyPropertyBridge<Window>(this, "FontWeight");
			bridgeForeground = new DependencyPropertyBridge<Window>(this, "Foreground");
			bridgeHeight = new DependencyPropertyBridge<Window>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<Window>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<Window>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<Window>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<Window>(this, "Name");
			bridgeTitle = new DependencyPropertyBridge<Window>(this, "Title");
			bridgeToolTip = new DependencyPropertyBridge<Window>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<Window>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<Window>(this, "Width");
			bridgeWindowStartupLocation = new RegularPropertyBridge<Window>(this, "WindowStartupLocation");
		}

		Cache<System.Windows.Media.Brush> _Background;

		public new virtual System.Windows.Media.Brush Background
		{
			get
			{
				return _Background.Get();
			}

			set
			{
				_Background.Set(value);
			}
		}

		Cache<object> _Content;

		public new virtual object Content
		{
			get
			{
				return _Content.Get();
			}

			set
			{
				_Content.Set(value);
			}
		}

		Cache<System.Windows.Media.FontFamily> _FontFamily;

		public new virtual System.Windows.Media.FontFamily FontFamily
		{
			get
			{
				return _FontFamily.Get();
			}

			set
			{
				_FontFamily.Set(value);
			}
		}

		Cache<double> _FontSize;

		public new virtual double FontSize
		{
			get
			{
				return _FontSize.Get();
			}

			set
			{
				_FontSize.Set(value);
			}
		}

		Cache<System.Windows.FontStretch> _FontStretch;

		public new virtual System.Windows.FontStretch FontStretch
		{
			get
			{
				return _FontStretch.Get();
			}

			set
			{
				_FontStretch.Set(value);
			}
		}

		Cache<System.Windows.FontStyle> _FontStyle;

		public new virtual System.Windows.FontStyle FontStyle
		{
			get
			{
				return _FontStyle.Get();
			}

			set
			{
				_FontStyle.Set(value);
			}
		}

		Cache<System.Windows.FontWeight> _FontWeight;

		public new virtual System.Windows.FontWeight FontWeight
		{
			get
			{
				return _FontWeight.Get();
			}

			set
			{
				_FontWeight.Set(value);
			}
		}

		Cache<System.Windows.Media.Brush> _Foreground;

		public new virtual System.Windows.Media.Brush Foreground
		{
			get
			{
				return _Foreground.Get();
			}

			set
			{
				_Foreground.Set(value);
			}
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<string> _Title;

		public new virtual string Title
		{
			get
			{
				return _Title.Get();
			}

			set
			{
				_Title.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}

		Cache<System.Windows.WindowStartupLocation> _WindowStartupLocation;

		public new virtual System.Windows.WindowStartupLocation WindowStartupLocation
		{
			get
			{
				return _WindowStartupLocation.Get();
			}

			set
			{
				_WindowStartupLocation.Set(value);
			}
		}


	}

	public class WrapPanel : System.Windows.Controls.WrapPanel
	{
		DependencyPropertyBridge<WrapPanel> bridgeHeight;
		DependencyPropertyBridge<WrapPanel> bridgeHorizontalAlignment;
		DependencyPropertyBridge<WrapPanel> bridgeIsEnabled;
		DependencyPropertyBridge<WrapPanel> bridgeMargin;
		DependencyPropertyBridge<WrapPanel> bridgeName;
		DependencyPropertyBridge<WrapPanel> bridgeOrientation;
		DependencyPropertyBridge<WrapPanel> bridgeToolTip;
		DependencyPropertyBridge<WrapPanel> bridgeVerticalAlignment;
		DependencyPropertyBridge<WrapPanel> bridgeWidth;
		CollectionPropertyBridge<WrapPanel> bridgeChildren;


		public WrapPanel()
		{
			_Height = new Cache<double>(() => base.Height);
			_HorizontalAlignment = new Cache<System.Windows.HorizontalAlignment>(() => base.HorizontalAlignment);
			_IsEnabled = new Cache<bool>(() => base.IsEnabled);
			_Margin = new Cache<System.Windows.Thickness>(() => base.Margin);
			_Name = new Cache<string>(() => base.Name);
			_Orientation = new Cache<System.Windows.Controls.Orientation>(() => base.Orientation);
			_ToolTip = new Cache<object>(() => base.ToolTip);
			_VerticalAlignment = new Cache<System.Windows.VerticalAlignment>(() => base.VerticalAlignment);
			_Width = new Cache<double>(() => base.Width);
			_Children = new Cache<IEnumerable<System.Windows.UIElement>>(() =>
			{
				var result = new List<System.Windows.UIElement>();
				foreach (var element in base.Children)
                {
                    result.Add((System.Windows.UIElement)element);
				}
				return result;
			});
		}

		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			bridgeHeight = new DependencyPropertyBridge<WrapPanel>(this, "Height");
			bridgeHorizontalAlignment = new DependencyPropertyBridge<WrapPanel>(this, "HorizontalAlignment");
			bridgeIsEnabled = new DependencyPropertyBridge<WrapPanel>(this, "IsEnabled");
			bridgeMargin = new DependencyPropertyBridge<WrapPanel>(this, "Margin");
			bridgeName = new DependencyPropertyBridge<WrapPanel>(this, "Name");
			bridgeOrientation = new DependencyPropertyBridge<WrapPanel>(this, "Orientation");
			bridgeToolTip = new DependencyPropertyBridge<WrapPanel>(this, "ToolTip");
			bridgeVerticalAlignment = new DependencyPropertyBridge<WrapPanel>(this, "VerticalAlignment");
			bridgeWidth = new DependencyPropertyBridge<WrapPanel>(this, "Width");
			bridgeChildren = new CollectionPropertyBridge<WrapPanel>(this, "Children");
		}

		Cache<double> _Height;

		public new virtual double Height
		{
			get
			{
				return _Height.Get();
			}

			set
			{
				_Height.Set(value);
			}
		}

		Cache<System.Windows.HorizontalAlignment> _HorizontalAlignment;

		public new virtual System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return _HorizontalAlignment.Get();
			}

			set
			{
				_HorizontalAlignment.Set(value);
			}
		}

		Cache<bool> _IsEnabled;

		public new virtual bool IsEnabled
		{
			get
			{
				return _IsEnabled.Get();
			}

			set
			{
				_IsEnabled.Set(value);
			}
		}

		Cache<System.Windows.Thickness> _Margin;

		public new virtual System.Windows.Thickness Margin
		{
			get
			{
				return _Margin.Get();
			}

			set
			{
				_Margin.Set(value);
			}
		}

		Cache<string> _Name;

		public new virtual string Name
		{
			get
			{
				return _Name.Get();
			}

			set
			{
				_Name.Set(value);
			}
		}

		Cache<System.Windows.Controls.Orientation> _Orientation;

		public new virtual System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return _Orientation.Get();
			}

			set
			{
				_Orientation.Set(value);
			}
		}

		Cache<object> _ToolTip;

		public new virtual object ToolTip
		{
			get
			{
				return _ToolTip.Get();
			}

			set
			{
				_ToolTip.Set(value);
			}
		}

		Cache<System.Windows.VerticalAlignment> _VerticalAlignment;

		public new virtual System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return _VerticalAlignment.Get();
			}

			set
			{
				_VerticalAlignment.Set(value);
			}
		}

		Cache<double> _Width;

		public new virtual double Width
		{
			get
			{
				return _Width.Get();
			}

			set
			{
				_Width.Set(value);
			}
		}


		Cache<IEnumerable<System.Windows.UIElement>> _Children;

		public new virtual IEnumerable<System.Windows.UIElement> Children
		{
			get
			{
				return _Children.Get();
			}

			set
			{
				_Children.Set(value);
			}
		}

	}

}

