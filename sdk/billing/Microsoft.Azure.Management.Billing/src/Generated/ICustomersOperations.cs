// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CustomersOperations operations.
    /// </summary>
    public partial interface ICustomersOperations
    {
        /// <summary>
        /// Lists the customers that are billed to a billing profile. The
        /// operation is supported only for billing accounts with agreement
        /// type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='billingProfileName'>
        /// The ID that uniquely identifies a billing profile.
        /// </param>
        /// <param name='search'>
        /// Used for searching customers by their name. Any customer with name
        /// containing the search text will be included in the response
        /// </param>
        /// <param name='filter'>
        /// May be used to filter the list of customers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Customer>>> ListByBillingProfileWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string search = default(string), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the customers that are billed to a billing account. The
        /// operation is supported only for billing accounts with agreement
        /// type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='search'>
        /// Used for searching customers by their name. Any customer with name
        /// containing the search text will be included in the response
        /// </param>
        /// <param name='filter'>
        /// May be used to filter the list of customers.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Customer>>> ListByBillingAccountWithHttpMessagesAsync(string billingAccountName, string search = default(string), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a customer by its ID. The operation is supported only for
        /// billing accounts with agreement type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='billingAccountName'>
        /// The ID that uniquely identifies a billing account.
        /// </param>
        /// <param name='customerName'>
        /// The ID that uniquely identifies a customer.
        /// </param>
        /// <param name='expand'>
        /// May be used to expand enabledAzurePlans and resellers
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Customer>> GetWithHttpMessagesAsync(string billingAccountName, string customerName, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the customers that are billed to a billing profile. The
        /// operation is supported only for billing accounts with agreement
        /// type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Customer>>> ListByBillingProfileNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the customers that are billed to a billing account. The
        /// operation is supported only for billing accounts with agreement
        /// type Microsoft Partner Agreement.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/billing/" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Customer>>> ListByBillingAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
