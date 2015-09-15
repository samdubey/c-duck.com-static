Sitemaps.NET
http://james.newtonking.com/projects/sitemaps-net.aspx


Description:

Sitemaps.NET is a website plugin that automatically generates an XML sitemap of your content. Sitemaps.NET reuses ASP.NET's sitemap functionality and automatically mirrors changes in your site to search engines. Features include:

- Quickly generate XML sitemaps for search engines
- Integrates with the ASP.NET sitemap functionality, automatically mirrors changes to search engines
- Specify the priority and update frequency of content within your site on a page by page basis.
- Simple plug in installation 



Instructions:

1. Extract Newtonsoft.Sitemaps.dll from the archive's /bin directory into your own applications.
2. Add the SitemapHandler to your web.config's httpHandler section.

  <add verb="*" path="sitemap.axd" type="Newtonsoft.Sitemaps.SitemapHandler, Newtonsoft.Sitemaps"/>

The path will determine the URL you submit to search engines.
3. That's it. Now let search engines know about your sitemap file.



License:

Copyright (c) 2007 James Newton-King

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.