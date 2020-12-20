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
  public class AGaugeRange
  {
    public AGaugeRange() { }

    public AGaugeRange(Color color, Single startValue, Single endValue)
    {
      Color = color;
      _StartValue = startValue;
      _EndValue = endValue;
    }

    public AGaugeRange(Color color, Single startValue, Single endValue, Int32 innerRadius, Int32 outerRadius)
    {
      Color = color;
      _StartValue = startValue;
      _EndValue = endValue;
      InnerRadius = innerRadius;
      OuterRadius = outerRadius;
    }

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Design"),
    System.ComponentModel.DisplayName("(Name)"),
    System.ComponentModel.Description("Instance Name.")]
    public string Name { get { return _Name; } set { NotifyChanging(); _Name = value; NotifyChanged(); } }
    private string _Name; 

    [System.ComponentModel.Browsable(false)]
    public Boolean InRange { get; set; }

    private AGauge Owner;
    [System.ComponentModel.Browsable(false)]
    public void SetOwner(AGauge value) { Owner = value; }
    private void NotifyOwner() { if (Owner != null) Owner.RepaintControl(); }
    private void NotifyChanging()
    {
      if (Owner != null)
      {
        Owner.NotifyChanging(nameof(AGauge.GaugeRanges));
      }
    }

    private void NotifyChanged()
    {
      if (Owner != null)
      {
        Owner.NotifyChanged(nameof(AGauge.GaugeRanges));
      }
    }

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("The color of the range.")]
    public Color Color { get { return _Color; } set { NotifyChanging(); _Color = value; NotifyOwner(); NotifyChanged(); } }
    private Color _Color;

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Limits"),
    System.ComponentModel.Description("The start value of the range, must be less than RangeEndValue.")]
    public Single StartValue
    {
      get { return _StartValue; }
      set
      {
        NotifyChanging();
        if (Owner != null)
        {
          if (value < Owner.MinValue) value = Owner.MinValue;
          if (value > Owner.MaxValue) value = Owner.MaxValue;
        }
        _StartValue = value;
        NotifyOwner();
        NotifyChanged();
      }
    }
    private Single _StartValue;

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Limits"),
    System.ComponentModel.Description("The end value of the range. Must be greater than RangeStartValue.")]
    public Single EndValue
    {
      get { return _EndValue; }
      set
      {
        NotifyChanging();
        if (Owner != null)
        {
          if (value < Owner.MinValue) value = Owner.MinValue;
          if (value > Owner.MaxValue) value = Owner.MaxValue;
        }
        _EndValue = value;
        NotifyOwner();
        NotifyChanged();
      }
    }
    private Single _EndValue;

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("The inner radius of the range.")]
    public Int32 InnerRadius
    {
      get { return _InnerRadius; }
      set { if (value > 0) { NotifyChanging(); _InnerRadius = value; NotifyOwner(); NotifyChanged(); } }
    }
    private Int32 _InnerRadius = 70;

    [System.ComponentModel.Browsable(true),
    System.ComponentModel.Category("Appearance"),
    System.ComponentModel.Description("The outer radius of the range.")]
    public Int32 OuterRadius
    {
      get { return _OuterRadius; }
      set { if (value > 0) { NotifyChanging(); _OuterRadius = value; NotifyOwner(); NotifyChanged(); } }
    }
    private Int32 _OuterRadius = 80;
  }
}
