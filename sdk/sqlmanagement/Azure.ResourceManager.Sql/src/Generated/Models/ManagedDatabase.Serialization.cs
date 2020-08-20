// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedDatabase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation");
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(StorageContainerUri))
            {
                writer.WritePropertyName("storageContainerUri");
                writer.WriteStringValue(StorageContainerUri);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId");
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId");
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(StorageContainerSasToken))
            {
                writer.WritePropertyName("storageContainerSasToken");
                writer.WriteStringValue(StorageContainerSasToken);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId");
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId");
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(AutoCompleteRestore))
            {
                writer.WritePropertyName("autoCompleteRestore");
                writer.WriteBooleanValue(AutoCompleteRestore.Value);
            }
            if (Optional.IsDefined(LastBackupName))
            {
                writer.WritePropertyName("lastBackupName");
                writer.WriteStringValue(LastBackupName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedDatabase DeserializeManagedDatabase(JsonElement element)
        {
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> collation = default;
            Optional<ManagedDatabaseStatus> status = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<DateTimeOffset> earliestRestorePoint = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<string> defaultSecondaryLocation = default;
            Optional<CatalogCollationType> catalogCollation = default;
            Optional<ManagedDatabaseCreateMode> createMode = default;
            Optional<string> storageContainerUri = default;
            Optional<string> sourceDatabaseId = default;
            Optional<string> restorableDroppedDatabaseId = default;
            Optional<string> storageContainerSasToken = default;
            Optional<string> failoverGroupId = default;
            Optional<string> recoverableDatabaseId = default;
            Optional<string> longTermRetentionBackupResourceId = default;
            Optional<bool> autoCompleteRestore = default;
            Optional<string> lastBackupName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("collation"))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = new ManagedDatabaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("earliestRestorePoint"))
                        {
                            earliestRestorePoint = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"))
                        {
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("defaultSecondaryLocation"))
                        {
                            defaultSecondaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("catalogCollation"))
                        {
                            catalogCollation = new CatalogCollationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createMode"))
                        {
                            createMode = new ManagedDatabaseCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageContainerUri"))
                        {
                            storageContainerUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseId"))
                        {
                            sourceDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorableDroppedDatabaseId"))
                        {
                            restorableDroppedDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageContainerSasToken"))
                        {
                            storageContainerSasToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("failoverGroupId"))
                        {
                            failoverGroupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recoverableDatabaseId"))
                        {
                            recoverableDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("longTermRetentionBackupResourceId"))
                        {
                            longTermRetentionBackupResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoCompleteRestore"))
                        {
                            autoCompleteRestore = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastBackupName"))
                        {
                            lastBackupName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedDatabase(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), collation.Value, Optional.ToNullable(status), Optional.ToNullable(creationDate), Optional.ToNullable(earliestRestorePoint), Optional.ToNullable(restorePointInTime), defaultSecondaryLocation.Value, Optional.ToNullable(catalogCollation), Optional.ToNullable(createMode), storageContainerUri.Value, sourceDatabaseId.Value, restorableDroppedDatabaseId.Value, storageContainerSasToken.Value, failoverGroupId.Value, recoverableDatabaseId.Value, longTermRetentionBackupResourceId.Value, Optional.ToNullable(autoCompleteRestore), lastBackupName.Value);
        }
    }
}
