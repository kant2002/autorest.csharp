// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OdataOperations operations.
    /// </summary>
    public partial interface IOdataOperations
    {
        IOdataOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Specify filter parameter with value '$filter=id gt 5 and name eq 'foo'&amp;$orderby=id&amp;$top=10'
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        void GetWithFilter(ODataQuery<OdataFilter> odataQuery = default(ODataQuery<OdataFilter>));

        /// <summary>
        /// Specify filter parameter with value '$filter=id gt 5 and name eq 'foo'&amp;$orderby=id&amp;$top=10'
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task GetWithFilterAsync(ODataQuery<OdataFilter> odataQuery = default(ODataQuery<OdataFilter>), CancellationToken cancellationToken = default(CancellationToken));
    }
}