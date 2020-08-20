// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class GalleryArtifactPublishingProfileBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TargetRegions))
            {
                writer.WritePropertyName("targetRegions");
                writer.WriteStartArray();
                foreach (var item in TargetRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount");
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(ExcludeFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest");
                writer.WriteBooleanValue(ExcludeFromLatest.Value);
            }
            if (Optional.IsDefined(EndOfLifeDate))
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeDate.Value, "O");
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static GalleryArtifactPublishingProfileBase DeserializeGalleryArtifactPublishingProfileBase(JsonElement element)
        {
            Optional<IList<TargetRegion>> targetRegions = default;
            Optional<int> replicaCount = default;
            Optional<bool> excludeFromLatest = default;
            Optional<DateTimeOffset> publishedDate = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<StorageAccountType> storageAccountType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetRegions"))
                {
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetRegion.DeserializeTargetRegion(item));
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"))
                {
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"))
                {
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"))
                {
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"))
                {
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    storageAccountType = new StorageAccountType(property.Value.GetString());
                    continue;
                }
            }
            return new GalleryArtifactPublishingProfileBase(Optional.ToList(targetRegions), Optional.ToNullable(replicaCount), Optional.ToNullable(excludeFromLatest), Optional.ToNullable(publishedDate), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(storageAccountType));
        }
    }
}
