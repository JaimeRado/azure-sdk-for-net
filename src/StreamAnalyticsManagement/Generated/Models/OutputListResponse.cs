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
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The response of the output list operation.
    /// </summary>
    public partial class OutputListResponse : OperationResponse
    {
        private string _nextLink;
        
        /// <summary>
        /// Optional. The url returned by the output list operation. It can be
        /// used by the client side to fetch the next page of Outputs.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<Output> _value;
        
        /// <summary>
        /// Optional. The list of the outputs in response. In public preview,
        /// the response only has one output.
        /// </summary>
        public IList<Output> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OutputListResponse class.
        /// </summary>
        public OutputListResponse()
        {
            this.Value = new LazyList<Output>();
        }
    }
}
