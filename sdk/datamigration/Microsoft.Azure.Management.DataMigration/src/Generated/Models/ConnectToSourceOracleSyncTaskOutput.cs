// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for the task that validates Oracle database connection
    /// </summary>
    public partial class ConnectToSourceOracleSyncTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceOracleSyncTaskOutput class.
        /// </summary>
        public ConnectToSourceOracleSyncTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceOracleSyncTaskOutput class.
        /// </summary>
        /// <param name="sourceServerVersion">Version of the source
        /// server</param>
        /// <param name="databases">List of schemas on source server</param>
        /// <param name="sourceServerBrandVersion">Source server brand
        /// version</param>
        /// <param name="validationErrors">Validation errors associated with
        /// the task</param>
        public ConnectToSourceOracleSyncTaskOutput(string sourceServerVersion = default(string), IList<string> databases = default(IList<string>), string sourceServerBrandVersion = default(string), IList<ReportableException> validationErrors = default(IList<ReportableException>))
        {
            SourceServerVersion = sourceServerVersion;
            Databases = databases;
            SourceServerBrandVersion = sourceServerBrandVersion;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets version of the source server
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerVersion")]
        public string SourceServerVersion { get; private set; }

        /// <summary>
        /// Gets list of schemas on source server
        /// </summary>
        [JsonProperty(PropertyName = "databases")]
        public IList<string> Databases { get; private set; }

        /// <summary>
        /// Gets source server brand version
        /// </summary>
        [JsonProperty(PropertyName = "sourceServerBrandVersion")]
        public string SourceServerBrandVersion { get; private set; }

        /// <summary>
        /// Gets validation errors associated with the task
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
