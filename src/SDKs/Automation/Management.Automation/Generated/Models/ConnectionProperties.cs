// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the connection properties.
    /// </summary>
    public partial class ConnectionProperties : ResourceCommonPropertiesBase
    {
        private ConnectionTypeAssociationProperty _connectionType;
        
        /// <summary>
        /// Optional. Gets or sets the connectionType of the connection.
        /// </summary>
        public ConnectionTypeAssociationProperty ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }
        
        private IDictionary<string, string> _fieldDefinitionValues;
        
        /// <summary>
        /// Optional. Gets or sets the field definition values of the
        /// connection.
        /// </summary>
        public IDictionary<string, string> FieldDefinitionValues
        {
            get { return this._fieldDefinitionValues; }
            set { this._fieldDefinitionValues = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ConnectionProperties class.
        /// </summary>
        public ConnectionProperties()
        {
            this.FieldDefinitionValues = new LazyDictionary<string, string>();
        }
    }
}
