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

using System.Web;
using System.Xml;
using System.Web.Configuration;

namespace Newtonsoft.Sitemaps
{
  /// <summary>
  /// Manages Google Sitemaps writing. This class cannot be inherited. 
  /// </summary>
  public static class Sitemaps
  {
    private static readonly object _initLock = new object();
    private static bool _initialized = false;

    private static Formatting _formatting;
    private static bool _useFileModifiedDate;

    private static void Initialize()
    {
      if (!_initialized)
      {
        lock (_initLock)
        {
          if (!_initialized)
          {
            SitemapSection sitemapSection = (SitemapSection)WebConfigurationManager.GetWebApplicationSection("sitemaps");

            if (sitemapSection != null)
            {
              _formatting = sitemapSection.Formatting;
              _useFileModifiedDate = sitemapSection.UseFileModifiedDate;
            }
            else
            {
              _formatting = Formatting.Indented;
              _useFileModifiedDate = false;
            }

            _initialized = true;
          }
        }
      }
    }

    /// <summary>
    /// Gets a value indicating how the output XML is formatted.
    /// </summary>
    public static Formatting Formatting
    {
      get
      {
        Initialize();
        return _formatting;
      }
    }

    /// <summary>
    /// Gets whether GoogleSitemap.NET should attempt to get the last modified date
    /// of the file the <see cref="SiteMapNode"/> points to if no lastmod was defined.
    /// </summary>
    public static bool UseFileModifiedDate
    {
      get
      {
        Initialize();
        return _useFileModifiedDate;
      }
    }
  }
}