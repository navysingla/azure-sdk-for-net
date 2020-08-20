// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchError
    {
        internal static SearchError DeserializeSearchError(JsonElement element)
        {
            Optional<string> code = default;
            string message = default;
            Optional<IReadOnlyList<SearchError>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    List<SearchError> array = new List<SearchError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeSearchError(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new SearchError(code.Value, message, Optional.ToList(details));
        }
    }
}
