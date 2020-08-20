// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RestorePoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RestorePoint DeserializeRestorePoint(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<RestorePointType> restorePointType = default;
            Optional<DateTimeOffset> earliestRestoreDate = default;
            Optional<DateTimeOffset> restorePointCreationDate = default;
            Optional<string> restorePointLabel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("restorePointType"))
                        {
                            restorePointType = property0.Value.GetString().ToRestorePointType();
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreDate"))
                        {
                            earliestRestoreDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointCreationDate"))
                        {
                            restorePointCreationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointLabel"))
                        {
                            restorePointLabel = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RestorePoint(id.Value, name.Value, type.Value, location.Value, Optional.ToNullable(restorePointType), Optional.ToNullable(earliestRestoreDate), Optional.ToNullable(restorePointCreationDate), restorePointLabel.Value);
        }
    }
}
