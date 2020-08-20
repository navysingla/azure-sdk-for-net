// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required). </summary>
    public readonly partial struct ManagedDatabaseCreateMode : IEquatable<ManagedDatabaseCreateMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ManagedDatabaseCreateMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedDatabaseCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string RestoreExternalBackupValue = "RestoreExternalBackup";
        private const string PointInTimeRestoreValue = "PointInTimeRestore";
        private const string RecoveryValue = "Recovery";
        private const string RestoreLongTermRetentionBackupValue = "RestoreLongTermRetentionBackup";

        /// <summary> Default. </summary>
        public static ManagedDatabaseCreateMode Default { get; } = new ManagedDatabaseCreateMode(DefaultValue);
        /// <summary> RestoreExternalBackup. </summary>
        public static ManagedDatabaseCreateMode RestoreExternalBackup { get; } = new ManagedDatabaseCreateMode(RestoreExternalBackupValue);
        /// <summary> PointInTimeRestore. </summary>
        public static ManagedDatabaseCreateMode PointInTimeRestore { get; } = new ManagedDatabaseCreateMode(PointInTimeRestoreValue);
        /// <summary> Recovery. </summary>
        public static ManagedDatabaseCreateMode Recovery { get; } = new ManagedDatabaseCreateMode(RecoveryValue);
        /// <summary> RestoreLongTermRetentionBackup. </summary>
        public static ManagedDatabaseCreateMode RestoreLongTermRetentionBackup { get; } = new ManagedDatabaseCreateMode(RestoreLongTermRetentionBackupValue);
        /// <summary> Determines if two <see cref="ManagedDatabaseCreateMode"/> values are the same. </summary>
        public static bool operator ==(ManagedDatabaseCreateMode left, ManagedDatabaseCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedDatabaseCreateMode"/> values are not the same. </summary>
        public static bool operator !=(ManagedDatabaseCreateMode left, ManagedDatabaseCreateMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedDatabaseCreateMode"/>. </summary>
        public static implicit operator ManagedDatabaseCreateMode(string value) => new ManagedDatabaseCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedDatabaseCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedDatabaseCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
