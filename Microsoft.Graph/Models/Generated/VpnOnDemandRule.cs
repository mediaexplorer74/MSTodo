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
    /// The type VpnOnDemandRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class VpnOnDemandRule
    {

        /// <summary>
        /// Gets or sets ssids.
        /// Network Service Set Identifiers (SSIDs).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ssids", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Ssids { get; set; }
    
        /// <summary>
        /// Gets or sets dnsSearchDomains.
        /// DNS Search Domains.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsSearchDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DnsSearchDomains { get; set; }
    
        /// <summary>
        /// Gets or sets probeUrl.
        /// A URL to probe. If this URL is successfully fetched (returning a 200 HTTP status code) without redirection, this rule matches.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "probeUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ProbeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets action.
        /// Action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public VpnOnDemandRuleConnectionAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets domainAction.
        /// Domain Action (Only applicable when Action is evaluate connection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainAction", Required = Newtonsoft.Json.Required.Default)]
        public VpnOnDemandRuleConnectionDomainAction? DomainAction { get; set; }
    
        /// <summary>
        /// Gets or sets domains.
        /// Domains (Only applicable when Action is evaluate connection).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Domains { get; set; }
    
        /// <summary>
        /// Gets or sets probeRequiredUrl.
        /// Probe Required Url (Only applicable when Action is evaluate connection and DomainAction is connect if needed).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "probeRequiredUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ProbeRequiredUrl { get; set; }
    
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