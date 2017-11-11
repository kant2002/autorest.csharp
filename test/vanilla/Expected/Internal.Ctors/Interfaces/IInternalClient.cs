// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.InternalCtors
{
    using Newtonsoft.Json;

    /// <summary>
    /// A sample API that uses a petstore as an example to demonstrate features in the swagger-2.0 specification
    /// </summary>
    public partial interface IInternalClient : System.IDisposable
    {
        /// <summary>
        /// Gets or sets the base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets JSON serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets JSON deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IPets.
        /// </summary>
        IPets Pets { get; }

    }
}