// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PersonOrGroupColumn.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PersonOrGroupColumn
    {

        /// <summary>
        /// Gets or sets allowMultipleSelection.
        /// Indicates whether multiple values can be selected from the source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowMultipleSelection", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowMultipleSelection { get; set; }
    
        /// <summary>
        /// Gets or sets chooseFromType.
        /// Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chooseFromType", Required = Newtonsoft.Json.Required.Default)]
        public string ChooseFromType { get; set; }
    
        /// <summary>
        /// Gets or sets displayAs.
        /// How to display the information about the person or group chosen. See below.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayAs", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayAs { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}