// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationDefinitionListResult
    {
        internal static ApplicationDefinitionListResult DeserializeApplicationDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApplicationDefinition>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ApplicationDefinition> array = new List<ApplicationDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationDefinition.DeserializeApplicationDefinition(item));
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
            return new ApplicationDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
