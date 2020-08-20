// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a virtual machines scale sets network configuration&apos;s DNS settings. </summary>
    public partial class VirtualMachineScaleSetNetworkConfigurationDnsSettings
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetNetworkConfigurationDnsSettings. </summary>
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings()
        {
            DnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetNetworkConfigurationDnsSettings. </summary>
        /// <param name="dnsServers"> List of DNS servers IP addresses. </param>
        internal VirtualMachineScaleSetNetworkConfigurationDnsSettings(IList<string> dnsServers)
        {
            DnsServers = dnsServers;
        }

        /// <summary> List of DNS servers IP addresses. </summary>
        public IList<string> DnsServers { get; }
    }
}
