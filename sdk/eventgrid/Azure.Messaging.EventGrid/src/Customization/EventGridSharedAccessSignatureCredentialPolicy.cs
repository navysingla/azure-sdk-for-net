﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Messaging.EventGrid
{
    internal class EventGridSharedAccessSignatureCredentialPolicy : HttpPipelineSynchronousPolicy
    {
        private readonly EventGridSharedAccessSignatureCredential _credential;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventGridSharedAccessSignatureCredentialPolicy"/> class.
        /// </summary>
        /// <param name="credential">The <see cref="EventGridSharedAccessSignatureCredential"/> used to authenticate requests.</param>
        public EventGridSharedAccessSignatureCredentialPolicy(EventGridSharedAccessSignatureCredential credential)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            _credential = credential;
        }

        /// <inheritdoc/>
        public override void OnSendingRequest(HttpMessage message)
        {
            base.OnSendingRequest(message);
            message.Request.Headers.SetValue(Constants.SasTokenName, _credential.Signature);
        }
    }
}
