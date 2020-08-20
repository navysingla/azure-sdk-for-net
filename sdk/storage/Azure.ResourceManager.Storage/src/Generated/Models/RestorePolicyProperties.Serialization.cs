// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class RestorePolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsDefined(Days))
            {
                writer.WritePropertyName("days");
                writer.WriteNumberValue(Days.Value);
            }
            writer.WriteEndObject();
        }

        internal static RestorePolicyProperties DeserializeRestorePolicyProperties(JsonElement element)
        {
            bool enabled = default;
            Optional<int> days = default;
            Optional<DateTimeOffset> lastEnabledTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("days"))
                {
                    days = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastEnabledTime"))
                {
                    lastEnabledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new RestorePolicyProperties(enabled, Optional.ToNullable(days), Optional.ToNullable(lastEnabledTime));
        }
    }
}
