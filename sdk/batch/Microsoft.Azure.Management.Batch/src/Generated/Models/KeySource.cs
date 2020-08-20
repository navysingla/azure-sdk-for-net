// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for KeySource.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeySource
    {
        /// <summary>
        /// Batch creates and manages the encryption keys used to protect the
        /// account data.
        /// </summary>
        [EnumMember(Value = "Microsoft.Batch")]
        MicrosoftBatch,
        /// <summary>
        /// The encryption keys used to protect the account data are stored in
        /// an external key vault. If this is set then the Batch Account
        /// identity must be set to `SystemAssigned` and a valid Key Identifier
        /// must also be supplied under the keyVaultProperties.
        /// </summary>
        [EnumMember(Value = "Microsoft.KeyVault")]
        MicrosoftKeyVault
    }
    internal static class KeySourceEnumExtension
    {
        internal static string ToSerializedValue(this KeySource? value)
        {
            return value == null ? null : ((KeySource)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this KeySource value)
        {
            switch( value )
            {
                case KeySource.MicrosoftBatch:
                    return "Microsoft.Batch";
                case KeySource.MicrosoftKeyVault:
                    return "Microsoft.KeyVault";
            }
            return null;
        }

        internal static KeySource? ParseKeySource(this string value)
        {
            switch( value )
            {
                case "Microsoft.Batch":
                    return KeySource.MicrosoftBatch;
                case "Microsoft.KeyVault":
                    return KeySource.MicrosoftKeyVault;
            }
            return null;
        }
    }
}
