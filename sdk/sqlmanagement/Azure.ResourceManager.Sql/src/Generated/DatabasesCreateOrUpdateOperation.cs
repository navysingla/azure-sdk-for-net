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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> Creates a new database or updates an existing database. </summary>
    public partial class DatabasesCreateOrUpdateOperation : Operation<Database>, IOperationSource<Database>
    {
        private readonly ArmOperationHelpers<Database> _operation;
        internal DatabasesCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<Database>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DatabasesCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Database Value => _operation.Value;

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
        public override ValueTask<Response<Database>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Database>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Database IOperationSource<Database>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return Database.DeserializeDatabase(document.RootElement);
        }

        async ValueTask<Database> IOperationSource<Database>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return Database.DeserializeDatabase(document.RootElement);
        }
    }
}
