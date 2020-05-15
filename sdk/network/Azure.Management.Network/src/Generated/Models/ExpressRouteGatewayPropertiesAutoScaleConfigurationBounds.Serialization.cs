// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Min != null)
            {
                writer.WritePropertyName("min");
                writer.WriteNumberValue(Min.Value);
            }
            if (Max != null)
            {
                writer.WritePropertyName("max");
                writer.WriteNumberValue(Max.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds DeserializeExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(JsonElement element)
        {
            int? min = default;
            int? max = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("min"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    min = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("max"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    max = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(min, max);
        }
    }
}