// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for list ip configurations API service call. </summary>
    public partial class NetworkInterfaceIPConfigurationListResult
    {
        /// <summary> Initializes a new instance of NetworkInterfaceIPConfigurationListResult. </summary>
        internal NetworkInterfaceIPConfigurationListResult()
        {
            Value = new ChangeTrackingList<NetworkInterfaceIPConfiguration>();
        }

        /// <summary> Initializes a new instance of NetworkInterfaceIPConfigurationListResult. </summary>
        /// <param name="value"> A list of ip configurations. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal NetworkInterfaceIPConfigurationListResult(IReadOnlyList<NetworkInterfaceIPConfiguration> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of ip configurations. </summary>
        public IReadOnlyList<NetworkInterfaceIPConfiguration> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
