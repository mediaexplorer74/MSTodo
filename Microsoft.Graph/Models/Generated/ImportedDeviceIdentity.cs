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
    /// The type Imported Device Identity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ImportedDeviceIdentity : Entity
    {
    
        /// <summary>
        /// Gets or sets imported device identifier.
        /// Imported Device Identifier
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedDeviceIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ImportedDeviceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets imported device identity type.
        /// Type of Imported Device Identity
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importedDeviceIdentityType", Required = Newtonsoft.Json.Required.Default)]
        public ImportedDeviceIdentityType? ImportedDeviceIdentityType { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last Modified DateTime of the description
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Created Date Time of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last contacted date time.
        /// Last Contacted Date Time of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastContactedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastContactedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// The state of the device in Intune
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentState", Required = Newtonsoft.Json.Required.Default)]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// The platform of the Device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platform", Required = Newtonsoft.Json.Required.Default)]
        public Platform? Platform { get; set; }
    
    }
}
