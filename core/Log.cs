using System;
using System.Text.Json;

namespace core;

public static class Log
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        WriteIndented = true,
    };

    public static void Debug(object data)
    {
        Write("DEBUG", data, ConsoleColor.Yellow);
    }

    public static void Info(object data)
    {
        Write("INFO", data, ConsoleColor.Green);
    }

    public static void Error(object data)
    {
        Write("ERROR", data, ConsoleColor.Red);
    }

    private static void Write(string level, object data, ConsoleColor color)
    {
        var prevColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        string message = JsonSerializer.Serialize(data, SerializerOptions);
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {level}: {message}");
        Console.ForegroundColor = prevColor;
    }
}
