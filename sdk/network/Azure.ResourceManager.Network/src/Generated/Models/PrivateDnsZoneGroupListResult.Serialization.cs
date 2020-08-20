// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrivateDnsZoneGroupListResult
    {
        internal static PrivateDnsZoneGroupListResult DeserializePrivateDnsZoneGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateDnsZoneGroup>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PrivateDnsZoneGroup> array = new List<PrivateDnsZoneGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateDnsZoneGroup.DeserializePrivateDnsZoneGroup(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateDnsZoneGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
