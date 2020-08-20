// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class OAuth2Permission : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AdminConsentDescription))
            {
                writer.WritePropertyName("adminConsentDescription");
                writer.WriteStringValue(AdminConsentDescription);
            }
            if (Optional.IsDefined(AdminConsentDisplayName))
            {
                writer.WritePropertyName("adminConsentDisplayName");
                writer.WriteStringValue(AdminConsentDisplayName);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(UserConsentDescription))
            {
                writer.WritePropertyName("userConsentDescription");
                writer.WriteStringValue(UserConsentDescription);
            }
            if (Optional.IsDefined(UserConsentDisplayName))
            {
                writer.WritePropertyName("userConsentDisplayName");
                writer.WriteStringValue(UserConsentDisplayName);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            writer.WriteEndObject();
        }

        internal static OAuth2Permission DeserializeOAuth2Permission(JsonElement element)
        {
            Optional<string> adminConsentDescription = default;
            Optional<string> adminConsentDisplayName = default;
            Optional<string> id = default;
            Optional<bool> isEnabled = default;
            Optional<string> type = default;
            Optional<string> userConsentDescription = default;
            Optional<string> userConsentDisplayName = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminConsentDescription"))
                {
                    adminConsentDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminConsentDisplayName"))
                {
                    adminConsentDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userConsentDescription"))
                {
                    userConsentDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userConsentDisplayName"))
                {
                    userConsentDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new OAuth2Permission(adminConsentDescription.Value, adminConsentDisplayName.Value, id.Value, Optional.ToNullable(isEnabled), type.Value, userConsentDescription.Value, userConsentDisplayName.Value, value.Value);
        }
    }
}
