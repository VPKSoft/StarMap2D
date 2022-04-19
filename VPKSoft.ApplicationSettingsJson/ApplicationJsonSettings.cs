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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace VPKSoft.ApplicationSettingsJson;

/// <summary>
/// Simple JSON application settings class.
/// </summary>
public abstract class ApplicationJsonSettings
{
    /// <summary>
    /// Loads application settings from the specified file name.
    /// </summary>
    /// <param name="fileName">Name of the file to load the settings from.</param>
    public virtual void Load(string fileName)
    {
        object? data = default;

        if (File.Exists(fileName))
        {
            var file = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var reader = new StreamReader(file);

            var json = new StringBuilder();

            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                json.AppendLine(line);
            }

            data = JsonConvert.DeserializeObject(json.ToString(), GetType());
        }

        var savedProperties = data?.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(f => f.GetCustomAttribute<SettingsAttribute>() != null).ToList();

        var existingProperties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(f => f.GetCustomAttribute<SettingsAttribute>() != null).ToList();

        foreach (var existingProperty in existingProperties)
        {
            var saved = savedProperties?.FirstOrDefault(f => f.Name == existingProperty.Name);

            var attribute = existingProperty.GetCustomAttribute<SettingsAttribute>();

            if (attribute.DefaultValueConverter != null)
            {
                var jsonStringConverter = (IDefaultValueConverter)Activator.CreateInstance(attribute.DefaultValueConverter);
                existingProperty.SetValue(this, jsonStringConverter.ConvertFromString(saved?.GetValue(data) ?? attribute.Default));
            }
            else
            {
                existingProperty.SetValue(this, saved?.GetValue(data) ?? attribute.Default);
            }
        }
    }

    /// <summary>
    /// Creates the application settings folder if it does not exist.
    /// </summary>
    /// <param name="company">The company of the application copyright.</param>
    /// <param name="applicationName">Name of the application.</param>
    /// <returns>The application settings folder location.</returns>
    public virtual string CreateApplicationSettingsFolder(string company, string applicationName)
    {
        var path = GetApplicationSettingsFolder(company, applicationName);

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        return path;
    }

    /// <summary>
    /// Gets the application settings folder name combined with the application name.
    /// </summary>
    /// <param name="company">The company of the application copyright.</param>
    /// <param name="applicationName">Name of the application.</param>
    /// <returns>The application settings path.</returns>
    public virtual string GetApplicationSettingsFolder(string company, string applicationName)
    {
        foreach (var nameChar in Path.GetInvalidFileNameChars())
        {
            int index;
            while ((index = applicationName.IndexOf(nameChar)) != -1)
            {
                applicationName = applicationName.Remove(index, 1);
            }

            while ((index = company.IndexOf(nameChar)) != -1)
            {
                company = company.Remove(index, 1);
            }
        }

        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            company,
            applicationName);

        return path;
    }

    /// <summary>
    /// Gets the application settings file and path.
    /// </summary>
    /// <param name="company">The company of the application copyright.</param>
    /// <param name="applicationName">Name of the application.</param>
    /// <returns>The application settings file name with path.</returns>
    public virtual string GetApplicationSettingsFile(string company, string applicationName)
    {
        foreach (var nameChar in Path.GetInvalidFileNameChars())
        {
            int index;
            while ((index = applicationName.IndexOf(nameChar)) != -1)
            {
                applicationName = applicationName.Remove(index, 1);
            }

            while ((index = company.IndexOf(nameChar)) != -1)
            {
                company = company.Remove(index, 1);
            }
        }

        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            company,
            applicationName, $"{applicationName}.json");

        return path;
    }

    /// <summary>
    /// Saves the settings to a specified file name.
    /// </summary>
    /// <param name="fileName">Name of the file to save the settings into.</param>
    public virtual void Save(string fileName)
    {
        File.WriteAllText(fileName,
            JsonConvert.SerializeObject(this,
                new JsonSerializerSettings
                { ContractResolver = new JsonIgnoreResolver(), Formatting = Formatting.Indented }));
    }
}