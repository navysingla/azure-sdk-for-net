// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the CheckPrivateLinkServiceVisibility API service call. </summary>
    public partial class PrivateLinkServiceVisibility
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceVisibility. </summary>
        internal PrivateLinkServiceVisibility()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceVisibility. </summary>
        /// <param name="visible"> Private Link Service Visibility (True/False). </param>
        internal PrivateLinkServiceVisibility(bool? visible)
        {
            Visible = visible;
        }

        /// <summary> Private Link Service Visibility (True/False). </summary>
        public bool? Visible { get; }
    }
}
