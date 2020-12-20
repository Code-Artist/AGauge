// Copyright (C) 2007 A.J.Bauer
//
//  This software is provided as-is, without any express or implied
//  warranty.  In no event will the authors be held liable for any damages
//  arising from the use of this software.

//  Permission is granted to anyone to use this software for any purpose,
//  including commercial applications, and to alter it and redistribute it
//  freely, subject to the following restrictions:
//  1. The origin of this software must not be misrepresented; you must not
//     claim that you wrote the original software. if you use this software
//     in a product, an acknowledgment in the product documentation would be
//     appreciated but is not required.
//  2. Altered source versions must be plainly marked as such, and must not be
//     misrepresented as being the original software.
//  3. This notice may not be removed or altered from any source distribution.
//
// -----------------------------------------------------------------------------------
// Copyright (C) 2012 Code Artist
// 
// Added several improvement to original code created by A.J.Bauer.
// Visit: http://codearteng.blogspot.com for more information on change history.
//
// -----------------------------------------------------------------------------------

using System.Drawing;

namespace System.Windows.Forms
{
  #region [ Gauge Label ]

  public class AGaugeLabel
  {
    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Design"),
    System.ComponentModel.DisplayName("(Name)"),
    System.ComponentModel.Description("Instance Name.")]
    public string Name { get { return _Name; } set { NotifyChanging(); _Name = value; NotifyChanged(); } }
    private string _Name;

    [System.ComponentModel.Browsable(false)]
    public void SetOwner(AGauge value) { Owner = value; }
    private AGauge Owner;

    private void NotifyOwner() { if (Owner != null) Owner.RepaintControl(); }

    private void NotifyChanging()
    {
      if (Owner != null)
      {
        Owner.NotifyChanging();
      }
    }

    private void NotifyChanged()
    {
      if (Owner != null)
      {
        Owner.NotifyChanged();
      }
    }

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("The color of the caption text.")]
    public Color Color { get { return _Color; } set { NotifyChanging(); _Color = value; NotifyOwner(); NotifyChanged();  } }
    private Color _Color = Color.FromKnownColor(KnownColor.WindowText);

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("The text of the caption.")]
    public String Text { get { return _Text; } set { NotifyChanging(); _Text = value; NotifyOwner(); NotifyChanged(); } }
    private String _Text;

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("The position of the caption.")]
    public Point Position { get { return _Position; } set { NotifyChanging(); _Position = value; NotifyOwner(); NotifyChanged(); } }
    private Point _Position;

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("Font of Text.")]
    public Font Font { get { return _Font; } set { NotifyChanging(); _Font = value; NotifyOwner(); NotifyChanged(); } }
    private Font _Font = DefaultFont;

    public void ResetFont() { NotifyChanging(); _Font = DefaultFont; NotifyChanged(); }
    private Boolean ShouldSerializeFont() { return (_Font != DefaultFont); }
    private static Font DefaultFont = System.Windows.Forms.Control.DefaultFont;
  }
}
