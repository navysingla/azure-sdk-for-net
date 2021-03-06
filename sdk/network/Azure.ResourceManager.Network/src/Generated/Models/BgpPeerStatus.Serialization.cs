// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BgpPeerStatus
    {
        internal static BgpPeerStatus DeserializeBgpPeerStatus(JsonElement element)
        {
            Optional<string> localAddress = default;
            Optional<string> neighbor = default;
            Optional<long> asn = default;
            Optional<BgpPeerState> state = default;
            Optional<string> connectedDuration = default;
            Optional<long> routesReceived = default;
            Optional<long> messagesSent = default;
            Optional<long> messagesReceived = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddress"))
                {
                    localAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("neighbor"))
                {
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asn"))
                {
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = new BgpPeerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectedDuration"))
                {
                    connectedDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routesReceived"))
                {
                    routesReceived = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesSent"))
                {
                    messagesSent = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesReceived"))
                {
                    messagesReceived = property.Value.GetInt64();
                    continue;
                }
            }
            return new BgpPeerStatus(localAddress.Value, neighbor.Value, Optional.ToNullable(asn), Optional.ToNullable(state), connectedDuration.Value, Optional.ToNullable(routesReceived), Optional.ToNullable(messagesSent), Optional.ToNullable(messagesReceived));
        }
    }
}
