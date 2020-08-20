// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ACL for a private endpoint
    /// </summary>
    public partial class PrivateEndpointACL : NetworkACL
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpointACL class.
        /// </summary>
        public PrivateEndpointACL()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpointACL class.
        /// </summary>
        /// <param name="name">Name of the private endpoint connection</param>
        /// <param name="allow">Allowed request types. The value can be one or
        /// more of: ClientConnection, ServerConnection, RESTAPI.</param>
        /// <param name="deny">Denied request types. The value can be one or
        /// more of: ClientConnection, ServerConnection, RESTAPI.</param>
        public PrivateEndpointACL(string name, IList<string> allow = default(IList<string>), IList<string> deny = default(IList<string>))
            : base(allow, deny)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the private endpoint connection
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
