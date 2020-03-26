// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class IndexingResult
    {
        internal static IndexingResult DeserializeIndexingResult(JsonElement element)
        {
            string key = default;
            string errorMessage = default;
            bool status = default;
            int statusCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    statusCode = property.Value.GetInt32();
                    continue;
                }
            }
            return new IndexingResult(key, errorMessage, status, statusCode);
        }
    }
}