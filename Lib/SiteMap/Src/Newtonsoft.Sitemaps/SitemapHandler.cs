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

using System;
using System.Web;
using System.Xml;
using System.IO;
using Newtonsoft.Sitemaps.Utilities;

namespace Newtonsoft.Sitemaps
{
  /// <summary>
  /// Provides an HTTP handler for generating Google site map XML from <see cref="SiteMap"/> node structure. This class cannot be inherited. 
  /// </summary>
  public sealed class SitemapHandler : XmlResponseHandlerBase
  {
    /// <summary>
    /// Writes the Google site map XML.
    /// </summary>
    /// <param name="result">The <see cref="XmlTextWriter"/> to which the result is written to.</param>
    protected override void WriteResult(XmlTextWriter result)
    {
      Formatting formatting = Sitemaps.Formatting;
      bool useFileModifiedDate = Sitemaps.UseFileModifiedDate;

      // get formatting override from querystring if it exists
      if (!string.IsNullOrEmpty(Request.QueryString["formatting"]))
      {
        try
        {
          formatting = EnumUtils.Parse<Formatting>(Request.QueryString["formatting"], true);
        }
        catch (Exception ex)
        {
          throw new ArgumentException("Error parsing 'formatting'. Valid values are Indented or None.", "formatting", ex);
        }
      }

      // get useFileModifiedDate override from querystring if it exists
      if (!string.IsNullOrEmpty(Request.QueryString["useFileModifiedDate"]))
      {
        try
        {
          useFileModifiedDate = Convert.ToBoolean(Request.QueryString["useFileModifiedDate"]);
        }
        catch (Exception ex)
        {
          throw new ArgumentException("Error parsing 'useFileModifiedDate'. Valid values are True or False.", "useFileModifiedDate", ex);
        }
      }

      result.Formatting = formatting;

      
      string siteUrl = Request.Url.Scheme + "://" + Request.Url.Host;
      
      // append non-default port
      int port = Request.Url.Port;
      if (port != 80 && port != 443)
        siteUrl += ":" + port;

      SitemapWriter writer = new SitemapWriter(result, siteUrl);

      if (useFileModifiedDate)
      {
        // if no lastmod was explicitly defined, attempt to find the physical file
        // on the server and use its last modified date
        writer.LastModifiedResolve += delegate(object sender, LastModifiedResolveEventArgs e)
        {
          SiteMapNode siteMapNode = e.SiteMapNode;

          if (string.IsNullOrEmpty(siteMapNode["lastmod"]))
          {
            string physicalPath = Request.MapPath(siteMapNode.Url);

            if (File.Exists(physicalPath))
              return File.GetLastWriteTimeUtc(physicalPath);
            else if (string.IsNullOrEmpty(Path.GetFileName(physicalPath)) && File.Exists(physicalPath + "default.aspx"))
              return File.GetLastWriteTimeUtc(physicalPath + "default.aspx");
          }

          return null;
        };
      }

      writer.WriteSiteMap(SiteMap.RootNode);
    }
  }
}