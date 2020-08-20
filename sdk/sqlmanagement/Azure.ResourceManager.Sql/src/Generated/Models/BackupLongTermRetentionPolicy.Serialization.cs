// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class BackupLongTermRetentionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(WeeklyRetention))
            {
                writer.WritePropertyName("weeklyRetention");
                writer.WriteStringValue(WeeklyRetention);
            }
            if (Optional.IsDefined(MonthlyRetention))
            {
                writer.WritePropertyName("monthlyRetention");
                writer.WriteStringValue(MonthlyRetention);
            }
            if (Optional.IsDefined(YearlyRetention))
            {
                writer.WritePropertyName("yearlyRetention");
                writer.WriteStringValue(YearlyRetention);
            }
            if (Optional.IsDefined(WeekOfYear))
            {
                writer.WritePropertyName("weekOfYear");
                writer.WriteNumberValue(WeekOfYear.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BackupLongTermRetentionPolicy DeserializeBackupLongTermRetentionPolicy(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> weeklyRetention = default;
            Optional<string> monthlyRetention = default;
            Optional<string> yearlyRetention = default;
            Optional<int> weekOfYear = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("weeklyRetention"))
                        {
                            weeklyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("monthlyRetention"))
                        {
                            monthlyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("yearlyRetention"))
                        {
                            yearlyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weekOfYear"))
                        {
                            weekOfYear = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BackupLongTermRetentionPolicy(id.Value, name.Value, type.Value, weeklyRetention.Value, monthlyRetention.Value, yearlyRetention.Value, Optional.ToNullable(weekOfYear));
        }
    }
}
