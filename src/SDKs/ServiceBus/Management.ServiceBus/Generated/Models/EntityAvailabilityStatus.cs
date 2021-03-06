// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Azure;
    using Management;
    using ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EntityAvailabilityStatus.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntityAvailabilityStatus
    {
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Limited")]
        Limited,
        [EnumMember(Value = "Renaming")]
        Renaming,
        [EnumMember(Value = "Restoring")]
        Restoring,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
}

