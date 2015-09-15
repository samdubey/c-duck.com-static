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

using System.Configuration;
using System.Xml;
using System.Web;

namespace Newtonsoft.Sitemaps
{
  /// <summary>
  /// Configures the how Google Sitemaps XML is written. This class cannot be inherited.
  /// </summary>
  public sealed class SitemapSection : ConfigurationSection
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SitemapSection"/> class.
    /// </summary>
    public SitemapSection()
    {
    }

    /// <summary>
    /// Gets or sets a value indicating how the output XML is formatted.
    /// </summary>
    [ConfigurationProperty("formatting", DefaultValue = Formatting.Indented)]
    public Formatting Formatting
    {
      get { return (Formatting) base["formatting"]; }
      set { base["formatting"] = value; }
    }

    /// <summary>
    /// Gets or sets whether GoogleSitemap.NET should attempt to get the last modified date
    /// of the file the <see cref="SiteMapNode"/> points to if no lastmod was defined.
    /// </summary>
    [ConfigurationProperty("useFileModifiedDate", DefaultValue = false)]
    public bool UseFileModifiedDate
    {
      get { return (bool) base["useFileModifiedDate"]; }
      set { base["useFileModifiedDate"] = value; }
    }
  }
}