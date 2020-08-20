// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The authentication type to be used to connect to the HTTP server. </summary>
    public readonly partial struct HttpAuthenticationType : IEquatable<HttpAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="HttpAuthenticationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HttpAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string AnonymousValue = "Anonymous";
        private const string DigestValue = "Digest";
        private const string WindowsValue = "Windows";
        private const string ClientCertificateValue = "ClientCertificate";

        /// <summary> Basic. </summary>
        public static HttpAuthenticationType Basic { get; } = new HttpAuthenticationType(BasicValue);
        /// <summary> Anonymous. </summary>
        public static HttpAuthenticationType Anonymous { get; } = new HttpAuthenticationType(AnonymousValue);
        /// <summary> Digest. </summary>
        public static HttpAuthenticationType Digest { get; } = new HttpAuthenticationType(DigestValue);
        /// <summary> Windows. </summary>
        public static HttpAuthenticationType Windows { get; } = new HttpAuthenticationType(WindowsValue);
        /// <summary> ClientCertificate. </summary>
        public static HttpAuthenticationType ClientCertificate { get; } = new HttpAuthenticationType(ClientCertificateValue);
        /// <summary> Determines if two <see cref="HttpAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(HttpAuthenticationType left, HttpAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HttpAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(HttpAuthenticationType left, HttpAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HttpAuthenticationType"/>. </summary>
        public static implicit operator HttpAuthenticationType(string value) => new HttpAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HttpAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HttpAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
