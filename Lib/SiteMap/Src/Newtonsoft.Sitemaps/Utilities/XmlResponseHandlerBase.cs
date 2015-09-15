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
using System.Web.Caching;
using System.Xml;
using System.Text;
using System.Security.Principal;

namespace Newtonsoft.Sitemaps.Utilities
{
  public abstract class XmlResponseHandlerBase : Handler, IHttpHandler
  {
    public event EventHandler Error;

    protected abstract void WriteResult(XmlTextWriter result);

    public static void XmlResponse(HttpResponse response, Action<XmlTextWriter> writeAction)
    {
      response.ClearHeaders();
      response.ClearContent();
      response.ContentType = "text/xml";

      XmlTextWriter writer = new XmlTextWriter(response.Output);

      writeAction(writer);

      writer.Flush();
    }

    protected virtual void OnError(EventArgs e)
    {
      if (Error != null)
      {
        Error(this, e);
      }
    }

    void IHttpHandler.ProcessRequest(HttpContext context)
    {
      if (context == null)
        throw new ArgumentNullException("context");

      Context = context;

      try
      {
        XmlResponseHandlerBase.XmlResponse(context.Response, new Action<XmlTextWriter>(WriteResult));
      }
      catch (Exception exception)
      {
        context.AddError(exception);
        OnError(EventArgs.Empty);
        if (context.Error != null)
        {
          throw new HttpUnhandledException("blah", exception);
        }
      }
    }

    bool IHttpHandler.IsReusable
    {
      get { return false; }
    }
  }
}