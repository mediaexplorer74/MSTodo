// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IUserGetLoggedOnManagedDevicesCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<UserGetLoggedOnManagedDevicesCollectionPage>))]
    public interface IUserGetLoggedOnManagedDevicesCollectionPage : ICollectionPage<ManagedDevice>
    {
        /// <summary>
        /// Gets the next page <see cref="IUserGetLoggedOnManagedDevicesRequest"/> instance.
        /// </summary>
        IUserGetLoggedOnManagedDevicesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}