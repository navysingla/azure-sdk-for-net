// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ImageOSDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("osType");
            writer.WriteStringValue(OsType.ToSerialString());
            writer.WritePropertyName("osState");
            writer.WriteStringValue(OsState.ToSerialString());
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot");
                writer.WriteObjectValue(Snapshot);
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk");
                writer.WriteObjectValue(ManagedDisk);
            }
            if (Optional.IsDefined(BlobUri))
            {
                writer.WritePropertyName("blobUri");
                writer.WriteStringValue(BlobUri);
            }
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching");
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(DiskEncryptionSet))
            {
                writer.WritePropertyName("diskEncryptionSet");
                writer.WriteObjectValue(DiskEncryptionSet);
            }
            writer.WriteEndObject();
        }

        internal static ImageOSDisk DeserializeImageOSDisk(JsonElement element)
        {
            OperatingSystemTypes osType = default;
            OperatingSystemStateTypes osState = default;
            Optional<SubResource> snapshot = default;
            Optional<SubResource> managedDisk = default;
            Optional<string> blobUri = default;
            Optional<CachingTypes> caching = default;
            Optional<int> diskSizeGB = default;
            Optional<StorageAccountTypes> storageAccountType = default;
            Optional<SubResource> diskEncryptionSet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString().ToOperatingSystemTypes();
                    continue;
                }
                if (property.NameEquals("osState"))
                {
                    osState = property.Value.GetString().ToOperatingSystemStateTypes();
                    continue;
                }
                if (property.NameEquals("snapshot"))
                {
                    snapshot = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("managedDisk"))
                {
                    managedDisk = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("blobUri"))
                {
                    blobUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    caching = property.Value.GetString().ToCachingTypes();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    storageAccountType = new StorageAccountTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionSet"))
                {
                    diskEncryptionSet = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
            }
            return new ImageOSDisk(snapshot.Value, managedDisk.Value, blobUri.Value, Optional.ToNullable(caching), Optional.ToNullable(diskSizeGB), Optional.ToNullable(storageAccountType), diskEncryptionSet.Value, osType, osState);
        }
    }
}
