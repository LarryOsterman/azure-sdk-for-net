// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    /// <summary> Resource type managed by the resource provider. </summary>
    public partial class ProviderResourceType
    {
        /// <summary> Initializes a new instance of ProviderResourceType. </summary>
        internal ProviderResourceType()
        {
            Locations = new ChangeTrackingList<string>();
            Aliases = new ChangeTrackingList<AliasType>();
            ApiVersions = new ChangeTrackingList<string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ProviderResourceType. </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="locations"> The collection of locations where this resource type can be created. </param>
        /// <param name="aliases"> The aliases that are supported by this resource type. </param>
        /// <param name="apiVersions"> The API version. </param>
        /// <param name="properties"> The properties. </param>
        internal ProviderResourceType(string resourceType, IReadOnlyList<string> locations, IReadOnlyList<AliasType> aliases, IReadOnlyList<string> apiVersions, IReadOnlyDictionary<string, string> properties)
        {
            ResourceType = resourceType;
            Locations = locations;
            Aliases = aliases;
            ApiVersions = apiVersions;
            Properties = properties;
        }

        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The collection of locations where this resource type can be created. </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> The aliases that are supported by this resource type. </summary>
        public IReadOnlyList<AliasType> Aliases { get; }
        /// <summary> The API version. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> The properties. </summary>
        public IReadOnlyDictionary<string, string> Properties { get; }
    }
}