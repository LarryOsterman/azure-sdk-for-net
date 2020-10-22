// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DedicatedHostAvailableCapacity
    {
        internal static DedicatedHostAvailableCapacity DeserializeDedicatedHostAvailableCapacity(JsonElement element)
        {
            Optional<IReadOnlyList<DedicatedHostAllocatableVM>> allocatableVMs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocatableVMs"))
                {
                    List<DedicatedHostAllocatableVM> array = new List<DedicatedHostAllocatableVM>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHostAllocatableVM.DeserializeDedicatedHostAllocatableVM(item));
                    }
                    allocatableVMs = array;
                    continue;
                }
            }
            return new DedicatedHostAvailableCapacity(Optional.ToList(allocatableVMs));
        }
    }
}