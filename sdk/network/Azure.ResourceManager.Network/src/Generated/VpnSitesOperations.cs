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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The VpnSites service client. </summary>
    public partial class VpnSitesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VpnSitesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VpnSitesOperations for mocking. </summary>
        protected VpnSitesOperations()
        {
        }
        /// <summary> Initializes a new instance of VpnSitesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VpnSitesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VpnSitesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the details of a VPN site. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnSite>> GetAsync(string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, vpnSiteName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VPN site. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSite> Get(string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, vpnSiteName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VpnSite tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being updated. </param>
        /// <param name="vpnSiteParameters"> Parameters supplied to update VpnSite tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnSite>> UpdateTagsAsync(string resourceGroupName, string vpnSiteName, TagsObject vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, vpnSiteName, vpnSiteParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VpnSite tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being updated. </param>
        /// <param name="vpnSiteParameters"> Parameters supplied to update VpnSite tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSite> UpdateTags(string resourceGroupName, string vpnSiteName, TagsObject vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, vpnSiteName, vpnSiteParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the vpnSites in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<VpnSite> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<VpnSite>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSite>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the vpnSites in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<VpnSite> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<VpnSite> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSite> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VpnSites in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VpnSite> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnSite>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSite>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VpnSites in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VpnSite> List(CancellationToken cancellationToken = default)
        {
            Page<VpnSite> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSite> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a VpnSite resource if it doesn&apos;t exist else updates the existing VpnSite. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being created or updated. </param>
        /// <param name="vpnSiteParameters"> Parameters supplied to create or update VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/>, or <paramref name="vpnSiteParameters"/> is null. </exception>
        public virtual async Task<VpnSitesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string vpnSiteName, VpnSite vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }
            if (vpnSiteParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, vpnSiteName, vpnSiteParameters, cancellationToken).ConfigureAwait(false);
                return new VpnSitesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vpnSiteName, vpnSiteParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VpnSite resource if it doesn&apos;t exist else updates the existing VpnSite. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being created or updated. </param>
        /// <param name="vpnSiteParameters"> Parameters supplied to create or update VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/>, or <paramref name="vpnSiteParameters"/> is null. </exception>
        public virtual VpnSitesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string vpnSiteName, VpnSite vpnSiteParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }
            if (vpnSiteParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, vpnSiteName, vpnSiteParameters, cancellationToken);
                return new VpnSitesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vpnSiteName, vpnSiteParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VpnSite. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        public virtual async Task<VpnSitesDeleteOperation> StartDeleteAsync(string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, vpnSiteName, cancellationToken).ConfigureAwait(false);
                return new VpnSitesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vpnSiteName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VpnSite. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        public virtual VpnSitesDeleteOperation StartDelete(string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnSiteName == null)
            {
                throw new ArgumentNullException(nameof(vpnSiteName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSitesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, vpnSiteName, cancellationToken);
                return new VpnSitesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vpnSiteName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
