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

namespace System.Windows.Forms
{
  #region [ Gauge Enum ]

  #endregion

  #region [ EventArgs ]
  /// <summary>
  /// Event argument for <see cref="ValueInRangeChanged"/> event.
  /// </summary>
  public class ValueInRangeChangedEventArgs : EventArgs
  {
    /// <summary>
    /// Affected GaugeRange
    /// </summary>
    public AGaugeRange Range { get; private set; }
    /// <summary>
    /// Gauge Value
    /// </summary>
    public Single Value { get; private set; }
    /// <summary>
    /// True if value is within current range.
    /// </summary>
    public bool InRange { get; private set; }
    public ValueInRangeChangedEventArgs(AGaugeRange range, Single value, bool inRange)
    {
      this.Range = range;
      this.Value = value;
      this.InRange = inRange;
    }
  }
}
