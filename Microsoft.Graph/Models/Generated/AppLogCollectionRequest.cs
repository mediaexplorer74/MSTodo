// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type App Log Collection Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AppLogCollectionRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets status.
        /// Log upload status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public AppLogUploadState? Status { get; set; }
    
        /// <summary>
        /// Gets or sets error message.
        /// Error message if any during the upload process
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorMessage", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or sets custom log folders.
        /// List of log folders. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customLogFolders", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> CustomLogFolders { get; set; }
    
        /// <summary>
        /// Gets or sets completed date time.
        /// Time at which the upload log request reached a terminal state
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CompletedDateTime { get; set; }
    
    }
}
