// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for GetConnectionSharedKey API service call. </summary>
    public partial class ConnectionSharedKey : SubResource
    {
        /// <summary> Initializes a new instance of ConnectionSharedKey. </summary>
        /// <param name="value"> The virtual network connection shared key value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionSharedKey(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary> Initializes a new instance of ConnectionSharedKey. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="value"> The virtual network connection shared key value. </param>
        internal ConnectionSharedKey(string id, string value) : base(id)
        {
            Value = value;
        }

        /// <summary> The virtual network connection shared key value. </summary>
        public string Value { get; set; }
    }
}