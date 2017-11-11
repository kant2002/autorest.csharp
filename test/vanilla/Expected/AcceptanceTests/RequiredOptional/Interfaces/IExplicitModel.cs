// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsRequiredOptional
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ExplicitModel operations.
    /// </summary>
    public partial interface IExplicitModel
    {
        IExplicitModelWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Test explicitly required integer. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        Error PostRequiredIntegerParameter(int bodyParameter);

        /// <summary>
        /// Test explicitly required integer. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredIntegerParameterAsync(int bodyParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        void PostOptionalIntegerParameter(int? bodyParameter = default(int?));

        /// <summary>
        /// Test explicitly optional integer. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalIntegerParameterAsync(int? bodyParameter = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required integer. Please put a valid int-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        Error PostRequiredIntegerProperty(int value);

        /// <summary>
        /// Test explicitly required integer. Please put a valid int-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredIntegerPropertyAsync(int value, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a valid int-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        void PostOptionalIntegerProperty(int? value = default(int?));

        /// <summary>
        /// Test explicitly optional integer. Please put a valid int-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalIntegerPropertyAsync(int? value = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required integer. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        Error PostRequiredIntegerHeader(int headerParameter);

        /// <summary>
        /// Test explicitly required integer. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredIntegerHeaderAsync(int headerParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        void PostOptionalIntegerHeader(int? headerParameter = default(int?));

        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalIntegerHeaderAsync(int? headerParameter = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required string. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        Error PostRequiredStringParameter(string bodyParameter);

        /// <summary>
        /// Test explicitly required string. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredStringParameterAsync(string bodyParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional string. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        void PostOptionalStringParameter(string bodyParameter = default(string));

        /// <summary>
        /// Test explicitly optional string. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalStringParameterAsync(string bodyParameter = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required string. Please put a valid string-wrapper with 'value' = null and the client library
        /// should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        Error PostRequiredStringProperty(string value);

        /// <summary>
        /// Test explicitly required string. Please put a valid string-wrapper with 'value' = null and the client library
        /// should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredStringPropertyAsync(string value, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a valid string-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        void PostOptionalStringProperty(string value = default(string));

        /// <summary>
        /// Test explicitly optional integer. Please put a valid string-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalStringPropertyAsync(string value = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required string. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        Error PostRequiredStringHeader(string headerParameter);

        /// <summary>
        /// Test explicitly required string. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredStringHeaderAsync(string headerParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional string. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        void PostOptionalStringHeader(string bodyParameter = default(string));

        /// <summary>
        /// Test explicitly optional string. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalStringHeaderAsync(string bodyParameter = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required complex object. Please put null and the client library should throw before the request is
        /// sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        Error PostRequiredClassParameter(Product bodyParameter);

        /// <summary>
        /// Test explicitly required complex object. Please put null and the client library should throw before the request is
        /// sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredClassParameterAsync(Product bodyParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional complex object. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        void PostOptionalClassParameter(Product bodyParameter = default(Product));

        /// <summary>
        /// Test explicitly optional complex object. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalClassParameterAsync(Product bodyParameter = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required complex object. Please put a valid class-wrapper with 'value' = null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        Error PostRequiredClassProperty(Product value);

        /// <summary>
        /// Test explicitly required complex object. Please put a valid class-wrapper with 'value' = null and the client
        /// library should throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredClassPropertyAsync(Product value, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional complex object. Please put a valid class-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        void PostOptionalClassProperty(Product value = default(Product));

        /// <summary>
        /// Test explicitly optional complex object. Please put a valid class-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalClassPropertyAsync(Product value = default(Product), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required array. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        Error PostRequiredArrayParameter(IList<string> bodyParameter);

        /// <summary>
        /// Test explicitly required array. Please put null and the client library should throw before the request is sent.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredArrayParameterAsync(IList<string> bodyParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional array. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        void PostOptionalArrayParameter(IList<string> bodyParameter = default(IList<string>));

        /// <summary>
        /// Test explicitly optional array. Please put null.
        /// </summary>
        /// <param name='bodyParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalArrayParameterAsync(IList<string> bodyParameter = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required array. Please put a valid array-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        Error PostRequiredArrayProperty(IList<string> value);

        /// <summary>
        /// Test explicitly required array. Please put a valid array-wrapper with 'value' = null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredArrayPropertyAsync(IList<string> value, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional array. Please put a valid array-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        void PostOptionalArrayProperty(IList<string> value = default(IList<string>));

        /// <summary>
        /// Test explicitly optional array. Please put a valid array-wrapper with 'value' = null.
        /// </summary>
        /// <param name='value'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalArrayPropertyAsync(IList<string> value = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly required array. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        Error PostRequiredArrayHeader(IList<string> headerParameter);

        /// <summary>
        /// Test explicitly required array. Please put a header 'headerParameter' =&gt; null and the client library should
        /// throw before the request is sent.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<Error> PostRequiredArrayHeaderAsync(IList<string> headerParameter, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        void PostOptionalArrayHeader(IList<string> headerParameter = default(IList<string>));

        /// <summary>
        /// Test explicitly optional integer. Please put a header 'headerParameter' =&gt; null.
        /// </summary>
        /// <param name='headerParameter'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PostOptionalArrayHeaderAsync(IList<string> headerParameter = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken));
    }
}