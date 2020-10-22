// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorDestination DeserializeConnectionMonitorDestination(JsonElement element)
        {
            Optional<string> resourceId = default;
            Optional<string> address = default;
            Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
            }
            return new ConnectionMonitorDestination(resourceId.Value, address.Value, Optional.ToNullable(port));
        }
    }
}