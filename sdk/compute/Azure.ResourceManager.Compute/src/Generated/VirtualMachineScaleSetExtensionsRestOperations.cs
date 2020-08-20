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
    internal partial class VirtualMachineScaleSetExtensionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetExtensionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public VirtualMachineScaleSetExtensionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, VirtualMachineScaleSetExtension extensionParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(vmScaleSetName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmssExtensionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(extensionParameters);
            request.Content = content;
            return message;
        }

        /// <summary> The operation to create or update an extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set where the extension should be create or updated. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, <paramref name="vmssExtensionName"/>, or <paramref name="extensionParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, VirtualMachineScaleSetExtension extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, vmScaleSetName, vmssExtensionName, extensionParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to create or update an extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set where the extension should be create or updated. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, <paramref name="vmssExtensionName"/>, or <paramref name="extensionParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, VirtualMachineScaleSetExtension extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, vmScaleSetName, vmssExtensionName, extensionParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, VirtualMachineScaleSetExtensionUpdate extensionParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(vmScaleSetName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmssExtensionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(extensionParameters);
            request.Content = content;
            return message;
        }

        /// <summary> The operation to update an extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set where the extension should be updated. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, <paramref name="vmssExtensionName"/>, or <paramref name="extensionParameters"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, VirtualMachineScaleSetExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var message = CreateUpdateRequest(resourceGroupName, vmScaleSetName, vmssExtensionName, extensionParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to update an extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set where the extension should be updated. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, <paramref name="vmssExtensionName"/>, or <paramref name="extensionParameters"/> is null. </exception>
        public Response Update(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, VirtualMachineScaleSetExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var message = CreateUpdateRequest(resourceGroupName, vmScaleSetName, vmssExtensionName, extensionParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string vmScaleSetName, string vmssExtensionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(vmScaleSetName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmssExtensionName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> The operation to delete the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set where the extension should be deleted. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, or <paramref name="vmssExtensionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, vmScaleSetName, vmssExtensionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to delete the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set where the extension should be deleted. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, or <paramref name="vmssExtensionName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, vmScaleSetName, vmssExtensionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(vmScaleSetName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmssExtensionName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> The operation to get the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set containing the extension. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, or <paramref name="vmssExtensionName"/> is null. </exception>
        public async Task<Response<VirtualMachineScaleSetExtension>> GetAsync(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }

            using var message = CreateGetRequest(resourceGroupName, vmScaleSetName, vmssExtensionName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetExtension value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineScaleSetExtension.DeserializeVirtualMachineScaleSetExtension(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get the extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set containing the extension. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmScaleSetName"/>, or <paramref name="vmssExtensionName"/> is null. </exception>
        public Response<VirtualMachineScaleSetExtension> Get(string resourceGroupName, string vmScaleSetName, string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (vmssExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmssExtensionName));
            }

            using var message = CreateGetRequest(resourceGroupName, vmScaleSetName, vmssExtensionName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetExtension value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineScaleSetExtension.DeserializeVirtualMachineScaleSetExtension(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string vmScaleSetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(vmScaleSetName, true);
            uri.AppendPath("/extensions", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets a list of all extensions in a VM scale set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set containing the extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vmScaleSetName"/> is null. </exception>
        public async Task<Response<VirtualMachineScaleSetExtensionListResult>> ListAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var message = CreateListRequest(resourceGroupName, vmScaleSetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetExtensionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineScaleSetExtensionListResult.DeserializeVirtualMachineScaleSetExtensionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all extensions in a VM scale set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set containing the extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vmScaleSetName"/> is null. </exception>
        public Response<VirtualMachineScaleSetExtensionListResult> List(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var message = CreateListRequest(resourceGroupName, vmScaleSetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetExtensionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineScaleSetExtensionListResult.DeserializeVirtualMachineScaleSetExtensionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string vmScaleSetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets a list of all extensions in a VM scale set. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set containing the extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="vmScaleSetName"/> is null. </exception>
        public async Task<Response<VirtualMachineScaleSetExtensionListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, vmScaleSetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetExtensionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineScaleSetExtensionListResult.DeserializeVirtualMachineScaleSetExtensionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of all extensions in a VM scale set. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set containing the extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="vmScaleSetName"/> is null. </exception>
        public Response<VirtualMachineScaleSetExtensionListResult> ListNextPage(string nextLink, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, vmScaleSetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetExtensionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineScaleSetExtensionListResult.DeserializeVirtualMachineScaleSetExtensionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
