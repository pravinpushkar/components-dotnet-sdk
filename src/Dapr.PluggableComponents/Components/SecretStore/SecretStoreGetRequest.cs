﻿// ------------------------------------------------------------------------
// Copyright 2023 The Dapr Authors
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//     http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ------------------------------------------------------------------------

using Dapr.Proto.Components.V1;

namespace Dapr.PluggableComponents.Components.SecretStore;

/// <summary>
/// Represents properties associated with a request to retrieve a secret from a secret store.
/// </summary>
/// <param name="SecretName">The secret that should be retrieved.</param>
public sealed record SecretStoreGetRequest(string SecretName)
{
    /// <summary>
    /// Gets the metadata associated with the request.
    /// </summary>
    public IReadOnlyDictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();

    internal static SecretStoreGetRequest FromGetRequest(GetSecretRequest request)
    {
        return new SecretStoreGetRequest(request.Key)
        {
            Metadata = request.Metadata
        };
    }
}
