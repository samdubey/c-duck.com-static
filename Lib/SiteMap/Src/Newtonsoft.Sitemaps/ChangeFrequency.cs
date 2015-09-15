#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

namespace Newtonsoft.Sitemaps
{
  /// <summary>
  /// Specifies the frequency with which a page's content changes.. 
  /// </summary>
  public enum ChangeFrequency
  {
    /// <summary>
    /// Page content aways changes.
    /// </summary>
    Always,
    /// <summary>
    /// Page content changes hourly.
    /// </summary>
    Hourly,
    /// <summary>
    /// Page content changes daily.
    /// </summary>
    Daily,
    /// <summary>
    /// Page content changes weekly.
    /// </summary>
    Weekly,
    /// <summary>
    /// Page content changes monthly.
    /// </summary>
    Monthly,
    /// <summary>
    /// Page content changes yearly.
    /// </summary>
    Yearly,
    /// <summary>
    /// Page content never changes.
    /// </summary>
    Never
  }
}