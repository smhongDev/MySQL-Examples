using System.Text.Json;
using MySqlConnector;

namespace StudentManager.Data;

/// <summary>
/// 설정 파일을 읽고 MySQL 연결 객체를 만드는 클래스입니다.
/// </summary>
public static class MySqlDatabase
{
    public static string LoadConnectionString()
    {
        string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

        if (!File.Exists(path))
        {
            throw new FileNotFoundException("appsettings.json 파일을 찾을 수 없습니다.", path);
        }

        using JsonDocument document = JsonDocument.Parse(File.ReadAllText(path));

        if (!document.RootElement.TryGetProperty("ConnectionStrings", out JsonElement section) ||
            !section.TryGetProperty("StudentDb", out JsonElement value) ||
            string.IsNullOrWhiteSpace(value.GetString()))
        {
            throw new InvalidOperationException(
                "appsettings.json에 ConnectionStrings:StudentDb 설정이 없습니다.");
        }

        return value.GetString()!;
    }

    public static MySqlConnection CreateConnection(string connectionString) =>
        new(connectionString);
}
