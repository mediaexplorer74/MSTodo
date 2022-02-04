// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AndroidForWorkSettingsCompleteSignupRequestBuilder.
    /// </summary>
    public partial class AndroidForWorkSettingsCompleteSignupRequestBuilder : BaseActionMethodRequestBuilder<IAndroidForWorkSettingsCompleteSignupRequest>, IAndroidForWorkSettingsCompleteSignupRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="AndroidForWorkSettingsCompleteSignupRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="enterpriseToken">A enterpriseToken parameter for the OData method call.</param>
        public AndroidForWorkSettingsCompleteSignupRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string enterpriseToken)
            : base(requestUrl, client)
        {
            this.SetParameter("enterpriseToken", enterpriseToken, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IAndroidForWorkSettingsCompleteSignupRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new AndroidForWorkSettingsCompleteSignupRequest(functionUrl, this.Client, options);

            if (this.HasParameter("enterpriseToken"))
            {
                request.RequestBody.EnterpriseToken = this.GetParameter<string>("enterpriseToken");
            }

            return request;
        }
    }
}