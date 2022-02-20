#region License
/*
MIT License

Copyright(c) 2022 Petteri Kautonen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace VPKSoft.ApplicationSettingsJson;

/// <summary>
/// A class to limit the <see cref="ApplicationJsonSettings"/> serialization to properties tagged with the <see cref="SettingsAttribute"/> attribute,
/// Implements the <see cref="Newtonsoft.Json.Serialization.DefaultContractResolver" />
/// </summary>
/// <seealso cref="Newtonsoft.Json.Serialization.DefaultContractResolver" />
public class JsonIgnoreResolver : DefaultContractResolver
{
    /// <summary>
    /// Creates properties for the given <see cref="T:Newtonsoft.Json.Serialization.JsonContract" />.
    /// </summary>
    /// <param name="type">The type to create properties for.</param>
    /// <param name="memberSerialization">The member serialization mode for the type.</param>
    /// <returns>Properties for the given <see cref="T:Newtonsoft.Json.Serialization.JsonContract" />.</returns>
    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        var jsonProperties = base.CreateProperties(type, memberSerialization);

        var propertyNames = type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(f => f.GetCustomAttribute<SettingsAttribute>() != null).Select(f => f.Name).ToList();

        return jsonProperties.Where(f => f.PropertyName != null && propertyNames.Contains(f.PropertyName)).ToList();
    }
}