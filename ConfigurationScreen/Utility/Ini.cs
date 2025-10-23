using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Ini
{
    private readonly string filePath;
    private readonly Dictionary<string, Dictionary<string, string>> ini =
        new(StringComparer.InvariantCultureIgnoreCase);

    public Ini(string path)
    {
        filePath = path;

        if (File.Exists(filePath))
            Load();
        else
        {
            File.Create(filePath).Dispose();
        }
    }

    // ------------------------
    // Loading and Saving
    // ------------------------

    private void Load()
    {
        var lines = File.ReadAllLines(filePath);
        string currentSection = "";

        ini[currentSection] = new(StringComparer.InvariantCultureIgnoreCase);

        foreach (var rawLine in lines)
        {
            var line = rawLine.Trim();

            if (string.IsNullOrWhiteSpace(line) || line.StartsWith(";"))
                continue;

            if (line.StartsWith("[") && line.EndsWith("]"))
            {
                currentSection = line.Substring(1, line.Length - 2).Trim();
                if (!ini.ContainsKey(currentSection))
                    ini[currentSection] = new(StringComparer.InvariantCultureIgnoreCase);
                continue;
            }

            var parts = line.Split(new[] { '=' }, 2);
            var key = parts[0].Trim();
            var value = parts.Length > 1 ? parts[1].Trim() : "";

            ini[currentSection][key] = value;
        }
    }

    public void Save()
    {
        var sb = new StringBuilder();

        if (ini.ContainsKey("") && ini[""].Count > 0)
        {
            foreach (var kv in ini[""])
                sb.AppendLine($"{kv.Key}={kv.Value}");
            sb.AppendLine();
        }

        foreach (var section in ini.Where(s => s.Key != ""))
        {
            sb.AppendLine($"[{section.Key}]");
            foreach (var kv in section.Value)
                sb.AppendLine($"{kv.Key}={kv.Value}");
            sb.AppendLine();
        }

        File.WriteAllText(filePath, sb.ToString());
    }

    // ------------------------
    // GetValue
    // ------------------------

    public string GetValue(string key) => GetValue(key, "", "");
    public string GetValue(string key, string section) => GetValue(key, section, "");
    public string GetValue(string key, string section, string defaultValue)
    {
        if (!ini.ContainsKey(section))
            return defaultValue;

        if (!ini[section].ContainsKey(key))
            return defaultValue;

        return ini[section][key];
    }

    // ------------------------
    // WriteValue
    // ------------------------

    public void WriteValue(string key, string value) => WriteValue(key, "", value);
    public void WriteValue(string key, string section, string value)
    {
        if (!ini.ContainsKey(section))
            ini[section] = new(StringComparer.InvariantCultureIgnoreCase);

        ini[section][key] = value;
    }

    // ------------------------
    // DeleteKey
    // ------------------------

    public bool DeleteKey(string key, string section, string value)
    {
        if (ini.ContainsKey(section) &&
            ini[section].TryGetValue(key, out var existingValue) &&
            existingValue == value)
        {
            ini[section].Remove(key);
            return true;
        }
        return false;
    }

    // ------------------------
    // DeleteSection
    // ------------------------

    public bool DeleteSection(string section)
    {
        return ini.Remove(section);
    }

    // ------------------------
    // UpdateValue
    // ------------------------

    public bool UpdateValue(string key, string section, string value)
    {
        if (ini.ContainsKey(section) && ini[section].ContainsKey(key))
        {
            ini[section][key] = value;
            return true;
        }
        return false;
    }

    // ------------------------
    // UpdateKey
    // ------------------------

    public bool UpdateKey(string oldKey, string section, string newKey)
    {
        if (ini.ContainsKey(section) && ini[section].ContainsKey(oldKey))
        {
            var value = ini[section][oldKey];
            ini[section].Remove(oldKey);
            ini[section][newKey] = value;
            return true;
        }
        return false;
    }

    // ------------------------
    // UpdateSection
    // ------------------------

    public bool UpdateSection(string oldSection, string newSection)
    {
        if (ini.ContainsKey(oldSection))
        {
            if (ini.ContainsKey(newSection))
                throw new InvalidOperationException($"Section '{newSection}' already exists.");

            ini[newSection] = new(ini[oldSection], StringComparer.InvariantCultureIgnoreCase);
            ini.Remove(oldSection);
            return true;
        }
        return false;
    }
}
