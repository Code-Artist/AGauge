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

using System.Collections;

namespace System.Windows.Forms
{
  #region[ Gauge Range ]
  #endregion

  #region [ Gauge Label ]
  public class AGaugeLabelCollection : CollectionBase
  {
    private AGauge Owner;
    public AGaugeLabelCollection(AGauge sender) { Owner = sender; }
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


    public AGaugeLabel this[int index] { get { return (AGaugeLabel)List[index]; } }
    public bool Contains(AGaugeLabel itemType) { return List.Contains(itemType); }
    public int Add(AGaugeLabel itemType)
    {
      itemType.SetOwner(Owner);
      if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
      var ret = List.Add(itemType);
      if (Owner != null) Owner.RepaintControl();
      return ret;
    }
    public void Remove(AGaugeLabel itemType)
    {
      List.Remove(itemType);
      if (Owner != null) Owner.RepaintControl();
    }
    public void Insert(int index, AGaugeLabel itemType)
    {
      itemType.SetOwner(Owner);
      if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
      List.Insert(index, itemType);
      if (Owner != null) Owner.RepaintControl();
    }
    public int IndexOf(AGaugeLabel itemType) { return List.IndexOf(itemType); }
    public AGaugeLabel FindByName(string name)
    {
      foreach (AGaugeLabel ptrRange in List)
      {
        if (ptrRange.Name == name) return ptrRange;
      }
      return null;
    }

    protected override void OnInsert(int index, object value)
    {
      NotifyChanging();
      if (string.IsNullOrEmpty(((AGaugeLabel)value).Name)) ((AGaugeLabel)value).Name = GetUniqueName();
      base.OnInsert(index, value);
      ((AGaugeLabel)value).SetOwner(Owner);
      NotifyChanged();
    }
    protected override void OnRemove(int index, object value)
    {
      NotifyChanging();
      if (Owner != null) Owner.RepaintControl();
      NotifyChanged();
    }
    protected override void OnClear()
    {
      NotifyChanging();
      if (Owner != null) Owner.RepaintControl();
      NotifyChanged();
    }

    private string GetUniqueName()
    {
      const string Prefix = "GaugeLabel";
      int index = 1;
      while (this.Count != 0)
      {
        for (int x = 0; x < this.Count; x++)
        {
          if (this[x].Name == (Prefix + index.ToString()))
            continue;
          else
            return Prefix + index.ToString();
        }
        index++;
      };
      return Prefix + index.ToString();
    }
  }
}
