// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error message received in an Azure Batch error response.
    /// </summary>
    public partial class ErrorMessage : IPropertyMetadata
    {
        private readonly string language;
        private readonly string value;

        #region Constructors

        internal ErrorMessage(Models.ErrorMessage protocolObject)
        {
            this.language = protocolObject.Lang;
            this.value = protocolObject.Value;
        }

        #endregion Constructors

        #region ErrorMessage

        /// <summary>
        /// Gets the language code of the error message.
        /// </summary>
        public string Language
        {
            get { return this.language; }
        }

        /// <summary>
        /// Gets the text of the message.
        /// </summary>
        public string Value
        {
            get { return this.value; }
        }

        #endregion // ErrorMessage

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}