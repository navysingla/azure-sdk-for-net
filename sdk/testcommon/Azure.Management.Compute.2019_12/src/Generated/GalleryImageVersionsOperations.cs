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
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The GalleryImageVersions service client. </summary>
    public partial class GalleryImageVersionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GalleryImageVersionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of GalleryImageVersionsOperations for mocking. </summary>
        protected GalleryImageVersionsOperations()
        {
        }
        /// <summary> Initializes a new instance of GalleryImageVersionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal GalleryImageVersionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new GalleryImageVersionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves information about a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GalleryImageVersion>> GetAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GalleryImageVersion> Get(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery Image Versions in a gallery Image Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the Shared Image Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, or <paramref name="galleryImageName"/> is null. </exception>
        public virtual AsyncPageable<GalleryImageVersion> ListByGalleryImageAsync(string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            async Task<Page<GalleryImageVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.ListByGalleryImage");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByGalleryImageAsync(resourceGroupName, galleryName, galleryImageName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryImageVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.ListByGalleryImage");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByGalleryImageNextPageAsync(nextLink, resourceGroupName, galleryName, galleryImageName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> List gallery Image Versions in a gallery Image Definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the Shared Image Gallery Image Definition from which the Image Versions are to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, or <paramref name="galleryImageName"/> is null. </exception>
        public virtual Pageable<GalleryImageVersion> ListByGalleryImage(string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }

            Page<GalleryImageVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.ListByGalleryImage");
                scope.Start();
                try
                {
                    var response = RestClient.ListByGalleryImage(resourceGroupName, galleryName, galleryImageName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryImageVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.ListByGalleryImage");
                scope.Start();
                try
                {
                    var response = RestClient.ListByGalleryImageNextPage(nextLink, resourceGroupName, galleryName, galleryImageName, cancellationToken);
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

        /// <summary> Create or update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be created. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the create or update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, <paramref name="galleryImageName"/>, <paramref name="galleryImageVersionName"/>, or <paramref name="galleryImageVersion"/> is null. </exception>
        public virtual async Task<GalleryImageVersionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, cancellationToken).ConfigureAwait(false);
                return new GalleryImageVersionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be created. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the create or update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, <paramref name="galleryImageName"/>, <paramref name="galleryImageVersionName"/>, or <paramref name="galleryImageVersion"/> is null. </exception>
        public virtual GalleryImageVersionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersion galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, cancellationToken);
                return new GalleryImageVersionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be updated. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, <paramref name="galleryImageName"/>, <paramref name="galleryImageVersionName"/>, or <paramref name="galleryImageVersion"/> is null. </exception>
        public virtual async Task<GalleryImageVersionsUpdateOperation> StartUpdateAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, cancellationToken).ConfigureAwait(false);
                return new GalleryImageVersionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version is to be updated. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be updated. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the update gallery Image Version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, <paramref name="galleryImageName"/>, <paramref name="galleryImageVersionName"/>, or <paramref name="galleryImageVersion"/> is null. </exception>
        public virtual GalleryImageVersionsUpdateOperation StartUpdate(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }
            if (galleryImageVersion == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, cancellationToken);
                return new GalleryImageVersionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, <paramref name="galleryImageName"/>, or <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<GalleryImageVersionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, cancellationToken).ConfigureAwait(false);
                return new GalleryImageVersionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a gallery Image Version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="galleryName"> The name of the Shared Image Gallery in which the Image Definition resides. </param>
        /// <param name="galleryImageName"> The name of the gallery Image Definition in which the Image Version resides. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery Image Version to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="galleryName"/>, <paramref name="galleryImageName"/>, or <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual GalleryImageVersionsDeleteOperation StartDelete(string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (galleryName == null)
            {
                throw new ArgumentNullException(nameof(galleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageVersionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, cancellationToken);
                return new GalleryImageVersionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
