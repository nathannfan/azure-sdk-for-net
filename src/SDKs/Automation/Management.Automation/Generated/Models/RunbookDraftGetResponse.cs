// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the get runbook draft operation.
    /// </summary>
    public partial class RunbookDraftGetResponse : AzureOperationResponse
    {
        private RunbookDraft _runbookDraft;
        
        /// <summary>
        /// Optional. Gets or sets the runbook draft.
        /// </summary>
        public RunbookDraft RunbookDraft
        {
            get { return this._runbookDraft; }
            set { this._runbookDraft = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookDraftGetResponse class.
        /// </summary>
        public RunbookDraftGetResponse()
        {
        }
    }
}
