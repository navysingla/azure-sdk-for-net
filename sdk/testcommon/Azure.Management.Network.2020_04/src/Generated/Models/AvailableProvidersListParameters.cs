// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Constraints that determine the list of available Internet service providers. </summary>
    public partial class AvailableProvidersListParameters
    {
        /// <summary> Initializes a new instance of AvailableProvidersListParameters. </summary>
        public AvailableProvidersListParameters()
        {
            AzureLocations = new ChangeTrackingList<string>();
        }

        /// <summary> A list of Azure regions. </summary>
        public IList<string> AzureLocations { get; }
        /// <summary> The country for available providers list. </summary>
        public string Country { get; set; }
        /// <summary> The state for available providers list. </summary>
        public string State { get; set; }
        /// <summary> The city or town for available providers list. </summary>
        public string City { get; set; }
    }
}
