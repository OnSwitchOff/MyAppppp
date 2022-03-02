﻿using System.IO;
using MyApp.Database;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Windows.Storage;

namespace  MyApp.Configurations.Database;

internal static class DatabaseConfiguration
{
    private const string DatabaseName = "MyApp.db";

    internal static DbContextOptions<DatabaseContext> GetOprions()
    {
        var builder = new DbContextOptionsBuilder<DatabaseContext>();

        builder.UseSqlite(GetConnectionString());

        return builder.Options;
    }

    private static string GetConnectionString()
    {
        var fullPath = Path.Combine(GetDatabaseLocation(), DatabaseName);

        return new SqliteConnectionStringBuilder()
        {
            DataSource = fullPath,
        }
        .ToString();
    }

    private static string GetDatabaseLocation()
    {
        return ApplicationData.Current.LocalFolder.Path;
    }
}