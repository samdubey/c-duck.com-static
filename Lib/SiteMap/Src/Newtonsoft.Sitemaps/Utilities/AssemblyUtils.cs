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
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Newtonsoft.Sitemaps.Utilities
{
  internal static class AssemblyUtils
  {
    public static string GetCompleteProductName(Assembly assembly)
    {
      return GetProductName(assembly) + " " + FormatVersion(assembly.GetName().Version);
    }

    public static string GetProductName(Assembly assembly)
    {
      AssemblyProductAttribute productAttribute = GetAttribute<AssemblyProductAttribute>(assembly);

      return productAttribute.Product;
    }

    public static string FormatVersion(Version assemblyVersion)
    {
      if (assemblyVersion.Build == 0)
        return assemblyVersion.Major + "." + assemblyVersion.Minor;
      else
        return assemblyVersion.Major + "." + assemblyVersion.Minor + "." + assemblyVersion.Build;
    }

    public static string GetCopyright(Assembly assembly)
    {
      AssemblyCopyrightAttribute copyrightAttribute = GetAttribute<AssemblyCopyrightAttribute>(assembly);

      return copyrightAttribute.Copyright;
    }

    public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider) where T : Attribute
    {
      return GetAttribute<T>(attributeProvider, false, true);
    }

    public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider, bool errorOnMultiple) where T : Attribute
    {
      return GetAttribute<T>(attributeProvider, errorOnMultiple, true);
    }

    public static T GetAttribute<T>(ICustomAttributeProvider attributeProvider, bool errorOnMultiple, bool inherit) where T : Attribute
    {
      T[] attributes = GetAttributes<T>(attributeProvider, inherit);

      if (CollectionUtils.IsNullOrEmpty<T>(attributes))
        return null;
      else if (attributes.Length == 1)
        return attributes[0];
      else
        throw new AmbiguousMatchException(string.Format("Multiple attributes of type '{0}' found.", typeof(T).Name));
    }

    public static T[] GetAttributes<T>(ICustomAttributeProvider attributeProvider, bool inherit) where T : Attribute
    {
      return (T[]) attributeProvider.GetCustomAttributes(typeof(T), inherit);
    }
  }
}
