// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Learn.Computation.Models
{
    public partial class LinuxComputeNode : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sshPublicKey");
            writer.WriteStringValue(SshPublicKey);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static LinuxComputeNode DeserializeLinuxComputeNode(JsonElement element)
        {
            string sshPublicKey = default;
            Optional<string> eTag = default;
            string name = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sshPublicKey"))
                {
                    sshPublicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new LinuxComputeNode(eTag.Value, name, kind, sshPublicKey);
        }
    }
}