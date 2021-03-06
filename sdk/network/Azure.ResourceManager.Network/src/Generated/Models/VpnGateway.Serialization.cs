// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnGateway : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub");
                writer.WriteObjectValue(VirtualHub);
            }
            if (Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections");
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BgpSettings))
            {
                writer.WritePropertyName("bgpSettings");
                writer.WriteObjectValue(BgpSettings);
            }
            if (Optional.IsDefined(VpnGatewayScaleUnit))
            {
                writer.WritePropertyName("vpnGatewayScaleUnit");
                writer.WriteNumberValue(VpnGatewayScaleUnit.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnGateway DeserializeVpnGateway(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SubResource> virtualHub = default;
            Optional<IList<VpnConnection>> connections = default;
            Optional<BgpSettings> bgpSettings = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<int> vpnGatewayScaleUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualHub"))
                        {
                            virtualHub = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connections"))
                        {
                            List<VpnConnection> array = new List<VpnConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnConnection.DeserializeVpnConnection(item));
                            }
                            connections = array;
                            continue;
                        }
                        if (property0.NameEquals("bgpSettings"))
                        {
                            bgpSettings = BgpSettings.DeserializeBgpSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayScaleUnit"))
                        {
                            vpnGatewayScaleUnit = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnGateway(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, virtualHub.Value, Optional.ToList(connections), bgpSettings.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(vpnGatewayScaleUnit));
        }
    }
}
