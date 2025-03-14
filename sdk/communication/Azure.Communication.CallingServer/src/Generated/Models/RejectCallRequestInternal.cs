// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The request payload for rejecting the call. </summary>
    internal partial class RejectCallRequestInternal
    {
        /// <summary> Initializes a new instance of RejectCallRequestInternal. </summary>
        /// <param name="incomingCallContext"> The context associated with the call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="incomingCallContext"/> is null. </exception>
        public RejectCallRequestInternal(string incomingCallContext)
        {
            Argument.AssertNotNull(incomingCallContext, nameof(incomingCallContext));

            IncomingCallContext = incomingCallContext;
        }

        /// <summary> The context associated with the call. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The rejection reason. </summary>
        public CallRejectReason? CallRejectReason { get; set; }
    }
}
