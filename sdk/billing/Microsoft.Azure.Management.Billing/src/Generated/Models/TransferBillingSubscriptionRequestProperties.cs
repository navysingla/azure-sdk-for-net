// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request parameters to transfer billing subscription.
    /// </summary>
    public partial class TransferBillingSubscriptionRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TransferBillingSubscriptionRequestProperties class.
        /// </summary>
        public TransferBillingSubscriptionRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TransferBillingSubscriptionRequestProperties class.
        /// </summary>
        /// <param name="destinationInvoiceSectionId">The destination invoice
        /// section id.</param>
        public TransferBillingSubscriptionRequestProperties(string destinationInvoiceSectionId)
        {
            DestinationInvoiceSectionId = destinationInvoiceSectionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the destination invoice section id.
        /// </summary>
        [JsonProperty(PropertyName = "destinationInvoiceSectionId")]
        public string DestinationInvoiceSectionId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DestinationInvoiceSectionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationInvoiceSectionId");
            }
        }
    }
}
