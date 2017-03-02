// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow trigger.
    /// </summary>
    [JsonTransformation]
    public partial class WorkflowTrigger : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTrigger class.
        /// </summary>
        public WorkflowTrigger() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowTrigger class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="provisioningState">Gets the provisioning state.
        /// Possible values include: 'NotSpecified', 'Accepted', 'Running',
        /// 'Ready', 'Creating', 'Created', 'Deleting', 'Deleted', 'Canceled',
        /// 'Failed', 'Succeeded', 'Moving', 'Updating', 'Registering',
        /// 'Registered', 'Unregistering', 'Unregistered', 'Completed'</param>
        /// <param name="createdTime">Gets the created time.</param>
        /// <param name="changedTime">Gets the changed time.</param>
        /// <param name="state">Gets the state. Possible values include:
        /// 'NotSpecified', 'Completed', 'Enabled', 'Disabled', 'Deleted',
        /// 'Suspended'</param>
        /// <param name="status">Gets the status. Possible values include:
        /// 'NotSpecified', 'Paused', 'Running', 'Waiting', 'Succeeded',
        /// 'Skipped', 'Suspended', 'Cancelled', 'Failed', 'Faulted',
        /// 'TimedOut', 'Aborted', 'Ignored'</param>
        /// <param name="lastExecutionTime">Gets the last execution
        /// time.</param>
        /// <param name="nextExecutionTime">Gets the next execution
        /// time.</param>
        /// <param name="recurrence">Gets the workflow trigger
        /// recurrence.</param>
        /// <param name="workflow">Gets the reference to workflow.</param>
        /// <param name="name">Gets the workflow trigger name.</param>
        /// <param name="type">Gets the workflow trigger type.</param>
        public WorkflowTrigger(string id = default(string), WorkflowTriggerProvisioningState? provisioningState = default(WorkflowTriggerProvisioningState?), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), WorkflowState? state = default(WorkflowState?), WorkflowStatus? status = default(WorkflowStatus?), System.DateTime? lastExecutionTime = default(System.DateTime?), System.DateTime? nextExecutionTime = default(System.DateTime?), WorkflowTriggerRecurrence recurrence = default(WorkflowTriggerRecurrence), ResourceReference workflow = default(ResourceReference), string name = default(string), string type = default(string))
            : base(id)
        {
            ProvisioningState = provisioningState;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            State = state;
            Status = status;
            LastExecutionTime = lastExecutionTime;
            NextExecutionTime = nextExecutionTime;
            Recurrence = recurrence;
            Workflow = workflow;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Gets the provisioning state. Possible values include:
        /// 'NotSpecified', 'Accepted', 'Running', 'Ready', 'Creating',
        /// 'Created', 'Deleting', 'Deleted', 'Canceled', 'Failed',
        /// 'Succeeded', 'Moving', 'Updating', 'Registering', 'Registered',
        /// 'Unregistering', 'Unregistered', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public WorkflowTriggerProvisioningState? ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; protected set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public System.DateTime? ChangedTime { get; protected set; }

        /// <summary>
        /// Gets the state. Possible values include: 'NotSpecified',
        /// 'Completed', 'Enabled', 'Disabled', 'Deleted', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public WorkflowState? State { get; protected set; }

        /// <summary>
        /// Gets the status. Possible values include: 'NotSpecified', 'Paused',
        /// 'Running', 'Waiting', 'Succeeded', 'Skipped', 'Suspended',
        /// 'Cancelled', 'Failed', 'Faulted', 'TimedOut', 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public WorkflowStatus? Status { get; protected set; }

        /// <summary>
        /// Gets the last execution time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastExecutionTime")]
        public System.DateTime? LastExecutionTime { get; protected set; }

        /// <summary>
        /// Gets the next execution time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextExecutionTime")]
        public System.DateTime? NextExecutionTime { get; protected set; }

        /// <summary>
        /// Gets the workflow trigger recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recurrence")]
        public WorkflowTriggerRecurrence Recurrence { get; protected set; }

        /// <summary>
        /// Gets the reference to workflow.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workflow")]
        public ResourceReference Workflow { get; protected set; }

        /// <summary>
        /// Gets the workflow trigger name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Gets the workflow trigger type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }

    }
}

