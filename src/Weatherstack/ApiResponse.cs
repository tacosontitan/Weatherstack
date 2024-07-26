﻿// Copyright (c) 2024 tacosontitan
// This file is part of the Weatherstack project, which is distributed under the MIT license.
// See LICENSE for more information.

using System.Text.Json.Serialization;

namespace Weatherstack;

/// <summary>
///     Represents a response from the Weatherstack API.
/// </summary>
/// <typeparam name="TRequest">
///     Specifies the type of the request that generated the response.
/// </typeparam>
public abstract class ApiResponse<TRequest>
    where TRequest : ApiRequest
{
    /// <summary>
    ///     Gets or sets the request that generated this response.
    /// </summary>
    [JsonPropertyName("request")]
    public TRequest? Request { get; set; }
}
