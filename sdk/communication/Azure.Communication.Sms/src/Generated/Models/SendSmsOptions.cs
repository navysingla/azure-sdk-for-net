// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Sms
{
    /// <summary> Optional configuration for sending SMS messages. </summary>
    public partial class SendSmsOptions
    {
        /// <summary> Initializes a new instance of SendSmsOptions. </summary>
        public SendSmsOptions()
        {
        }

        /// <summary> Enable this flag to receive a delivery report for this message on the Azure Resource EventGrid. </summary>
        public bool? EnableDeliveryReport { get; set; }
    }
}
