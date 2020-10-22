// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ResourceNavigationLinksListResult
    {
        internal static ResourceNavigationLinksListResult DeserializeResourceNavigationLinksListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ResourceNavigationLink>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ResourceNavigationLink> array = new List<ResourceNavigationLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceNavigationLink.DeserializeResourceNavigationLink(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceNavigationLinksListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}