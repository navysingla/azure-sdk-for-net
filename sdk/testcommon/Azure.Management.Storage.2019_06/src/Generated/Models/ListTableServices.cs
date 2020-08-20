// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    /// <summary> The ListTableServices. </summary>
    public partial class ListTableServices
    {
        /// <summary> Initializes a new instance of ListTableServices. </summary>
        internal ListTableServices()
        {
            Value = new ChangeTrackingList<TableServiceProperties>();
        }

        /// <summary> Initializes a new instance of ListTableServices. </summary>
        /// <param name="value"> List of table services returned. </param>
        internal ListTableServices(IReadOnlyList<TableServiceProperties> value)
        {
            Value = value;
        }

        /// <summary> List of table services returned. </summary>
        public IReadOnlyList<TableServiceProperties> Value { get; }
    }
}
