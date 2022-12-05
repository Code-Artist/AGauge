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
  public class AGaugeRangeCollection : CollectionBase
  {
    private AGauge m_Owner;
    public AGaugeRangeCollection(AGauge sender) { m_Owner = sender; }
    private void NotifyChanging()
    {
      if (m_Owner != null)
      {
        m_Owner.NotifyChanging(nameof(AGauge.GaugeRanges));
      }
    }

    private void NotifyChanged()
    {
      if (m_Owner != null)
      {
        m_Owner.NotifyChanged(nameof(AGauge.GaugeRanges));
      }
    }

    public AGaugeRange this[int index] { get { return (AGaugeRange)List[index]; } }
    public bool Contains(AGaugeRange itemType) { return List.Contains(itemType); }
    public int Add(AGaugeRange itemType)
    {
      itemType.SetOwner(m_Owner);
      if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
      var ret = List.Add(itemType);
      if (m_Owner != null) m_Owner.RepaintControl();
      return ret;
    }
    public void Remove(AGaugeRange itemType)
    {
      List.Remove(itemType);
      if (m_Owner != null) m_Owner.RepaintControl();
    }
    public void Insert(int index, AGaugeRange itemType)
    {
      itemType.SetOwner(m_Owner);
      if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
      List.Insert(index, itemType);
      if (m_Owner != null) m_Owner.RepaintControl();
    }
    public int IndexOf(AGaugeRange itemType) { return List.IndexOf(itemType); }
    public AGaugeRange FindByName(string name)
    {
      foreach (AGaugeRange ptrRange in List)
      {
        if (ptrRange.Name == name) return ptrRange;
      }
      return null;
    }

    protected override void OnSet(int index, object oldValue, object newValue)
    {
      NotifyChanging();
    }

    protected override void OnSetComplete(int index, object oldValue, object newValue)
    {
      m_Owner?.RepaintControl();
      NotifyChanged();
    }

    protected override void OnInsert(int index, object value)
    {
      NotifyChanging();
      var Range = (AGaugeRange)value;
      if (string.IsNullOrEmpty(Range.Name))
      {
        Range.Name = GetUniqueName();
      }
      Range.SetOwner(m_Owner);
    }

    protected override void OnInsertComplete(int index, object value)
    {
      if (m_Owner != null)
      {
        m_Owner.RepaintControl();
      }
      NotifyChanged();
    }

    protected override void OnRemove(int index, object value)
    {
      NotifyChanging();
    }

    protected override void OnRemoveComplete(int index, object value)
    {
      if (m_Owner != null)
      {
        m_Owner.RepaintControl();
      }
      NotifyChanged();
    }

    protected override void OnClear()
    {
      NotifyChanging();
    }

    protected override void OnClearComplete()
    {
      if (m_Owner != null)
      {
        m_Owner.RepaintControl();
      }
      NotifyChanged();
    }

    private string GetUniqueName()
    {
      const string Prefix = "GaugeRange";
      int index = 1;
      bool valid;
      while (this.Count != 0)
      {
        valid = true;
        for (int x = 0; x < this.Count; x++)
        {
          if (this[x].Name == (Prefix + index.ToString()))
          {
            valid = false;
            break;
          }
        }
        if (valid) break;
        index++;
      };
      return Prefix + index.ToString();
    }
  }
}
