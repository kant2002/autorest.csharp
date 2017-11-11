// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyDateTime
{
    using Microsoft.Rest;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Datetime operations.
    /// </summary>
    public partial class Datetime : IDatetime
    {
        /// <summary>
        /// Initializes a new instance of the Datetime class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public Datetime(IDatetimeWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IDatetimeWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IDatetimeWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get null datetime value
        /// </summary>
        public System.DateTime? GetNull()
        {
            return GetNullAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get null datetime value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetNullAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetNullAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get invalid datetime value
        /// </summary>
        public System.DateTime? GetInvalid()
        {
            return GetInvalidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get invalid datetime value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetInvalidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetInvalidAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get overflow datetime value
        /// </summary>
        public System.DateTime? GetOverflow()
        {
            return GetOverflowAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get overflow datetime value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetOverflowAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetOverflowAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get underflow datetime value
        /// </summary>
        public System.DateTime? GetUnderflow()
        {
            return GetUnderflowAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get underflow datetime value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetUnderflowAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetUnderflowAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put max datetime value 9999-12-31T23:59:59.9999999Z
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        public void PutUtcMaxDateTime(System.DateTime datetimeBody)
        {
            PutUtcMaxDateTimeAsync(datetimeBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put max datetime value 9999-12-31T23:59:59.9999999Z
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutUtcMaxDateTimeAsync(System.DateTime datetimeBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutUtcMaxDateTimeAsync(datetimeBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get max datetime value 9999-12-31t23:59:59.9999999z
        /// </summary>
        public System.DateTime? GetUtcLowercaseMaxDateTime()
        {
            return GetUtcLowercaseMaxDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get max datetime value 9999-12-31t23:59:59.9999999z
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetUtcLowercaseMaxDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetUtcLowercaseMaxDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get max datetime value 9999-12-31T23:59:59.9999999Z
        /// </summary>
        public System.DateTime? GetUtcUppercaseMaxDateTime()
        {
            return GetUtcUppercaseMaxDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get max datetime value 9999-12-31T23:59:59.9999999Z
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetUtcUppercaseMaxDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetUtcUppercaseMaxDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put max datetime value with positive numoffset 9999-12-31t23:59:59.9999999+14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        public void PutLocalPositiveOffsetMaxDateTime(System.DateTime datetimeBody)
        {
            PutLocalPositiveOffsetMaxDateTimeAsync(datetimeBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put max datetime value with positive numoffset 9999-12-31t23:59:59.9999999+14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutLocalPositiveOffsetMaxDateTimeAsync(System.DateTime datetimeBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutLocalPositiveOffsetMaxDateTimeAsync(datetimeBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31t23:59:59.9999999+14:00
        /// </summary>
        public System.DateTime? GetLocalPositiveOffsetLowercaseMaxDateTime()
        {
            return GetLocalPositiveOffsetLowercaseMaxDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31t23:59:59.9999999+14:00
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetLocalPositiveOffsetLowercaseMaxDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetLocalPositiveOffsetLowercaseMaxDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31T23:59:59.9999999+14:00
        /// </summary>
        public System.DateTime? GetLocalPositiveOffsetUppercaseMaxDateTime()
        {
            return GetLocalPositiveOffsetUppercaseMaxDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31T23:59:59.9999999+14:00
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetLocalPositiveOffsetUppercaseMaxDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetLocalPositiveOffsetUppercaseMaxDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put max datetime value with positive numoffset 9999-12-31t23:59:59.9999999-14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        public void PutLocalNegativeOffsetMaxDateTime(System.DateTime datetimeBody)
        {
            PutLocalNegativeOffsetMaxDateTimeAsync(datetimeBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put max datetime value with positive numoffset 9999-12-31t23:59:59.9999999-14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutLocalNegativeOffsetMaxDateTimeAsync(System.DateTime datetimeBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutLocalNegativeOffsetMaxDateTimeAsync(datetimeBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31T23:59:59.9999999-14:00
        /// </summary>
        public System.DateTime? GetLocalNegativeOffsetUppercaseMaxDateTime()
        {
            return GetLocalNegativeOffsetUppercaseMaxDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31T23:59:59.9999999-14:00
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetLocalNegativeOffsetUppercaseMaxDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetLocalNegativeOffsetUppercaseMaxDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31t23:59:59.9999999-14:00
        /// </summary>
        public System.DateTime? GetLocalNegativeOffsetLowercaseMaxDateTime()
        {
            return GetLocalNegativeOffsetLowercaseMaxDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get max datetime value with positive num offset 9999-12-31t23:59:59.9999999-14:00
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetLocalNegativeOffsetLowercaseMaxDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetLocalNegativeOffsetLowercaseMaxDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put min datetime value 0001-01-01T00:00:00Z
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        public void PutUtcMinDateTime(System.DateTime datetimeBody)
        {
            PutUtcMinDateTimeAsync(datetimeBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put min datetime value 0001-01-01T00:00:00Z
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutUtcMinDateTimeAsync(System.DateTime datetimeBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutUtcMinDateTimeAsync(datetimeBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get min datetime value 0001-01-01T00:00:00Z
        /// </summary>
        public System.DateTime? GetUtcMinDateTime()
        {
            return GetUtcMinDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get min datetime value 0001-01-01T00:00:00Z
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetUtcMinDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetUtcMinDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put min datetime value 0001-01-01T00:00:00+14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        public void PutLocalPositiveOffsetMinDateTime(System.DateTime datetimeBody)
        {
            PutLocalPositiveOffsetMinDateTimeAsync(datetimeBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put min datetime value 0001-01-01T00:00:00+14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutLocalPositiveOffsetMinDateTimeAsync(System.DateTime datetimeBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutLocalPositiveOffsetMinDateTimeAsync(datetimeBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get min datetime value 0001-01-01T00:00:00+14:00
        /// </summary>
        public System.DateTime? GetLocalPositiveOffsetMinDateTime()
        {
            return GetLocalPositiveOffsetMinDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get min datetime value 0001-01-01T00:00:00+14:00
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetLocalPositiveOffsetMinDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetLocalPositiveOffsetMinDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put min datetime value 0001-01-01T00:00:00-14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        public void PutLocalNegativeOffsetMinDateTime(System.DateTime datetimeBody)
        {
            PutLocalNegativeOffsetMinDateTimeAsync(datetimeBody).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put min datetime value 0001-01-01T00:00:00-14:00
        /// </summary>
        /// <param name='datetimeBody'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutLocalNegativeOffsetMinDateTimeAsync(System.DateTime datetimeBody, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutLocalNegativeOffsetMinDateTimeAsync(datetimeBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get min datetime value 0001-01-01T00:00:00-14:00
        /// </summary>
        public System.DateTime? GetLocalNegativeOffsetMinDateTime()
        {
            return GetLocalNegativeOffsetMinDateTimeAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get min datetime value 0001-01-01T00:00:00-14:00
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<System.DateTime?> GetLocalNegativeOffsetMinDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetLocalNegativeOffsetMinDateTimeAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}