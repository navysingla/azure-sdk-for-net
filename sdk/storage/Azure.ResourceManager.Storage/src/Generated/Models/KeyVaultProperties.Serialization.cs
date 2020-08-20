// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class KeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyname");
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyversion");
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyvaulturi");
                writer.WriteStringValue(KeyVaultUri);
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element)
        {
            Optional<string> keyname = default;
            Optional<string> keyversion = default;
            Optional<string> keyvaulturi = default;
            Optional<string> currentVersionedKeyIdentifier = default;
            Optional<DateTimeOffset> lastKeyRotationTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyname"))
                {
                    keyname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyversion"))
                {
                    keyversion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaulturi"))
                {
                    keyvaulturi = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyIdentifier"))
                {
                    currentVersionedKeyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastKeyRotationTimestamp"))
                {
                    lastKeyRotationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new KeyVaultProperties(keyname.Value, keyversion.Value, keyvaulturi.Value, currentVersionedKeyIdentifier.Value, Optional.ToNullable(lastKeyRotationTimestamp));
        }
    }
}
