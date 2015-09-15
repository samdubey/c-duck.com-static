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

namespace Newtonsoft.Sitemaps
{
  /// <summary>
  /// Represents the exception thrown when an error is encountered while Google Sitemap XML is being written. 
  /// </summary>
  public class SitemapWriterException : Exception
  {
    private readonly string _siteMapNodeKey;

    /// <summary>
    /// Gets the key of the <see cref="SiteMapNode"/> being written when the error occured.
    /// </summary>
    public string SiteMapNodeKey
    {
      get { return _siteMapNodeKey; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SitemapWriterException"/> class with the exception message
    /// specified, the <see cref="SiteMapNode"/> key being written when the exception occured and the original Exception object. 
    /// </summary>
    /// <param name="message">A description of the error condition.</param>
    /// <param name="siteMapNodeKey">The key of the <see cref="SiteMapNode"/> being written when the error occured</param>
    /// <param name="innerException">The original <see cref="Exception"/> object that caused this exception.</param>
    public SitemapWriterException(string message, string siteMapNodeKey, Exception innerException)
      : base(message, innerException)
    {
      _siteMapNodeKey = siteMapNodeKey;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SitemapWriterException"/> class with the exception message
    /// specified and the <see cref="SiteMapNode"/> key being written when the exception occured. 
    /// </summary>
    /// <param name="message">A description of the error condition.</param>
    /// <param name="siteMapNodeKey">The key of the <see cref="SiteMapNode"/> being written when the error occured</param>
    public SitemapWriterException(string message, string siteMapNodeKey)
      : this(message, siteMapNodeKey, null)
    {
    }
  }
}