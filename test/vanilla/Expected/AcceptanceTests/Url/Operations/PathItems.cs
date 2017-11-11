// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsUrl
{
    using Microsoft.Rest;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PathItems operations.
    /// </summary>
    public partial class PathItems : IPathItems
    {
        /// <summary>
        /// Initializes a new instance of the PathItems class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public PathItems(IPathItemsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IPathItemsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IPathItemsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery',
        /// pathItemStringQuery='pathItemStringQuery', localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        public void GetAllWithValues(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
        {
            GetAllWithValuesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery',
        /// pathItemStringQuery='pathItemStringQuery', localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetAllWithValuesAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetAllWithValuesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
        /// localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        public void GetGlobalQueryNull(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
        {
            GetGlobalQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
        /// localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetGlobalQueryNullAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetGlobalQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// send globalStringPath=globalStringPath, pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
        /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery', localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain null value
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        public void GetGlobalAndLocalQueryNull(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
        {
            GetGlobalAndLocalQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// send globalStringPath=globalStringPath, pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
        /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery', localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain null value
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetGlobalAndLocalQueryNullAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetGlobalAndLocalQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery', pathItemStringQuery=null,
        /// localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// should contain value null
        /// </param>
        public void GetLocalPathItemQueryNull(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
        {
            GetLocalPathItemQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery', pathItemStringQuery=null,
        /// localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task GetLocalPathItemQueryNullAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.GetLocalPathItemQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}