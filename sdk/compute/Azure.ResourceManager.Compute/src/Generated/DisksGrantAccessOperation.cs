// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> Grants access to a disk. </summary>
    public partial class DisksGrantAccessOperation : Operation<AccessUri>, IOperationSource<AccessUri>
    {
        private readonly ArmOperationHelpers<AccessUri> _operation;
        internal DisksGrantAccessOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<AccessUri>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DisksGrantAccessOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AccessUri Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AccessUri>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AccessUri>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AccessUri IOperationSource<AccessUri>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return AccessUri.DeserializeAccessUri(document.RootElement);
        }

        async ValueTask<AccessUri> IOperationSource<AccessUri>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return AccessUri.DeserializeAccessUri(document.RootElement);
        }
    }
}
