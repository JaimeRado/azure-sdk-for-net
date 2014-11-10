// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    /// <summary>
    /// Operations for managing the output of the stream analytics job.
    /// </summary>
    public partial interface IOutputOperations
    {
        /// <summary>
        /// Test an output for a stream analytics job. Asynchronous call.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// The output Name of the stream analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginTestConnectionAsync(string resourceGroupName, string jobName, string outputName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create an output for a stream analytics job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update an output for a stream
        /// analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the output create operation.
        /// </returns>
        Task<OutputCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string jobName, OutputCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create an output for a stream analytics job. The raw json content
        /// will be used.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// The name of the output for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update an output for a stream
        /// analytics job. It is in json format
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the output create operation.
        /// </returns>
        Task<OutputCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(string resourceGroupName, string jobName, string outputName, OutputCreateOrUpdateWithRawJsonContentParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete an output for a stream analytics job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// The name of the output for the stream analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string resourceGroupName, string jobName, string outputName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get an output for a stream analytics job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// The name of the output for the stream analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the output get operation.
        /// </returns>
        Task<OutputGetResponse> GetAsync(string resourceGroupName, string jobName, string outputName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get a list of the outputs defined in a stream analytics job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the output list operation.
        /// </returns>
        Task<OutputListResponse> ListOutputInJobAsync(string resourceGroupName, string jobName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Test an output for a stream analytics job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// The output Name of the stream analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> TestConnectionAsync(string resourceGroupName, string jobName, string outputName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Update an output for a stream analytics job.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// The name of the stream analytics job.
        /// </param>
        /// <param name='outputName'>
        /// The name of the output for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update an output for a stream
        /// analytics job.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response of the output patch operation.
        /// </returns>
        Task<OutputPatchResponse> UpdateAsync(string resourceGroupName, string jobName, string outputName, OutputPatchParameters parameters, CancellationToken cancellationToken);
    }
}
