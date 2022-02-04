// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type RoleScopeTagRequestBuilder.
    /// </summary>
    public partial class RoleScopeTagRequestBuilder : EntityRequestBuilder, IRoleScopeTagRequestBuilder
    {

        /// <summary>
        /// Constructs a new RoleScopeTagRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RoleScopeTagRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRoleScopeTagRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRoleScopeTagRequest Request(IEnumerable<Option> options)
        {
            return new RoleScopeTagRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IRoleScopeTagAssignmentsCollectionRequestBuilder"/>.</returns>
        public IRoleScopeTagAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new RoleScopeTagAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for RoleScopeTagAssign.
        /// </summary>
        /// <returns>The <see cref="IRoleScopeTagAssignRequestBuilder"/>.</returns>
        public IRoleScopeTagAssignRequestBuilder Assign(
            IEnumerable<RoleScopeTagAutoAssignment> assignments = null)
        {
            return new RoleScopeTagAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                assignments);
        }
    
    }
}