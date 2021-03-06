// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class FacetResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Count != null)
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            foreach (var item in this)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
        internal static FacetResult DeserializeFacetResult(JsonElement element)
        {
            FacetResult result = new FacetResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Count = property.Value.GetInt64();
                    continue;
                }
                result.Add(property.Name, property.Value.GetObject());
            }
            return result;
        }
    }
}
