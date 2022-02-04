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
    /// The type DeviceCompliancePolicyRequestBuilder.
    /// </summary>
    public partial class DeviceCompliancePolicyRequestBuilder : EntityRequestBuilder, IDeviceCompliancePolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceCompliancePolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceCompliancePolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceCompliancePolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceCompliancePolicyRequest Request(IEnumerable<Option> options)
        {
            return new DeviceCompliancePolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ScheduledActionsForRule.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyScheduledActionsForRuleCollectionRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyScheduledActionsForRuleCollectionRequestBuilder ScheduledActionsForRule
        {
            get
            {
                return new DeviceCompliancePolicyScheduledActionsForRuleCollectionRequestBuilder(this.AppendSegmentToRequestUrl("scheduledActionsForRule"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyDeviceStatusesCollectionRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyDeviceStatusesCollectionRequestBuilder DeviceStatuses
        {
            get
            {
                return new DeviceCompliancePolicyDeviceStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyUserStatusesCollectionRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyUserStatusesCollectionRequestBuilder UserStatuses
        {
            get
            {
                return new DeviceCompliancePolicyUserStatusesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userStatuses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStatusOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceComplianceDeviceOverviewRequestBuilder"/>.</returns>
        public IDeviceComplianceDeviceOverviewRequestBuilder DeviceStatusOverview
        {
            get
            {
                return new DeviceComplianceDeviceOverviewRequestBuilder(this.AppendSegmentToRequestUrl("deviceStatusOverview"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStatusOverview.
        /// </summary>
        /// <returns>The <see cref="IDeviceComplianceUserOverviewRequestBuilder"/>.</returns>
        public IDeviceComplianceUserOverviewRequestBuilder UserStatusOverview
        {
            get
            {
                return new DeviceComplianceUserOverviewRequestBuilder(this.AppendSegmentToRequestUrl("userStatusOverview"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceSettingStateSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyDeviceSettingStateSummariesCollectionRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyDeviceSettingStateSummariesCollectionRequestBuilder DeviceSettingStateSummaries
        {
            get
            {
                return new DeviceCompliancePolicyDeviceSettingStateSummariesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceSettingStateSummaries"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyAssignmentsCollectionRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new DeviceCompliancePolicyAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyAssignRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyAssignRequestBuilder Assign(
            IEnumerable<DeviceCompliancePolicyAssignment> assignments = null)
        {
            return new DeviceCompliancePolicyAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                assignments);
        }

        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyScheduleActionsForRules.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyScheduleActionsForRulesRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyScheduleActionsForRulesRequestBuilder ScheduleActionsForRules(
            IEnumerable<DeviceComplianceScheduledActionForRule> deviceComplianceScheduledActionForRules = null)
        {
            return new DeviceCompliancePolicyScheduleActionsForRulesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.scheduleActionsForRules"),
                this.Client,
                deviceComplianceScheduledActionForRules);
        }
    
    }
}