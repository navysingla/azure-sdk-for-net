// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineListResult
    {
        internal static VirtualMachineListResult DeserializeVirtualMachineListResult(JsonElement element)
        {
            IReadOnlyList<VirtualMachine> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<VirtualMachine> array = new List<VirtualMachine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachine.DeserializeVirtualMachine(item));
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
            return new VirtualMachineListResult(value, nextLink.Value);
        }
    }
}
