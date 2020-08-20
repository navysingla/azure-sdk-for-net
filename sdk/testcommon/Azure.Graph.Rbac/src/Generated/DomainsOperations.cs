// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    /// <summary> The Domains service client. </summary>
    public partial class DomainsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DomainsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of DomainsOperations for mocking. </summary>
        protected DomainsOperations()
        {
        }
        /// <summary> Initializes a new instance of DomainsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tenantID"> The tenant ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DomainsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string tenantID, Uri endpoint = null, string apiVersion = "1.6")
        {
            RestClient = new DomainsRestOperations(clientDiagnostics, pipeline, tenantID, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a specific domain in the current tenant. </summary>
        /// <param name="domainName"> name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Domain>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DomainsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(domainName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specific domain in the current tenant. </summary>
        /// <param name="domainName"> name of the domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Domain> Get(string domainName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DomainsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(domainName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of domains for the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Domain> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Domain>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DomainsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a list of domains for the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Domain> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<Domain> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DomainsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
