// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment script object. </summary>
    public partial class DeploymentScript : AzureResourceBase
    {
        /// <summary> Initializes a new instance of DeploymentScript. </summary>
        /// <param name="identity"> Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/> or <paramref name="location"/> is null. </exception>
        public DeploymentScript(ManagedServiceIdentity identity, string location)
        {
            if (identity == null)
            {
                throw new ArgumentNullException(nameof(identity));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Identity = identity;
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
            Kind = new ScriptType("DeploymentScript");
        }

        /// <summary> Initializes a new instance of DeploymentScript. </summary>
        /// <param name="id"> String Id used to locate any resource on Azure. </param>
        /// <param name="name"> Name of this resource. </param>
        /// <param name="type"> Type of this resource. </param>
        /// <param name="identity"> Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="kind"> Type of the script. </param>
        /// <param name="systemData"> The system metadata related to this resource. </param>
        internal DeploymentScript(string id, string name, string type, ManagedServiceIdentity identity, string location, IDictionary<string, string> tags, ScriptType kind, SystemData systemData) : base(id, name, type)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Kind = kind;
            SystemData = systemData;
        }

        /// <summary> Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The location of the ACI and the storage account for the deployment script. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Type of the script. </summary>
        internal ScriptType Kind { get; set; }
        /// <summary> The system metadata related to this resource. </summary>
        public SystemData SystemData { get; }
    }
}
