using System;
using System.IO;
using System.Text.Json;

namespace Stanok.Services;

public class DbConfig
{
    public string Server { get; set; } = "localhost";
    public string Port { get; set; } = "3306";
    public string Database { get; set; } = "cnc_calc";
    public string User { get; set; } = "root";
    public string Password { get; set; } = "";
}

public static class DbConfigManager
{
    private static readonly string ConfigFilePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "dbconfig.json"
    );

    public static DbConfig Load()
    {
        try
        {
            if (File.Exists(ConfigFilePath))
            {
                var json = File.ReadAllText(ConfigFilePath);
                return JsonSerializer.Deserialize<DbConfig>(json) ?? new DbConfig();
            }
        }
        catch
        {
            // Если ошибка при чтении, вернуть настройки по умолчанию
        }

        return new DbConfig();
    }

    public static void Save(DbConfig config)
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(config, options);
            File.WriteAllText(ConfigFilePath, json);
        }
        catch (Exception ex)
        {
            throw new Exception($"Не удалось сохранить настройки: {ex.Message}");
        }
    }

    public static string GetConfigFilePath() => ConfigFilePath;
}
