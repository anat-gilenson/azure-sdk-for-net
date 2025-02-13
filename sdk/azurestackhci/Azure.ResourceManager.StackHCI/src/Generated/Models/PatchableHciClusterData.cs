// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StackHCI.Models
{
    /// <summary> Cluster details to update. </summary>
    public partial class PatchableHciClusterData
    {
        /// <summary> Initializes a new instance of PatchableHciClusterData. </summary>
        public PatchableHciClusterData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Endpoint configured for management from the Azure portal. </summary>
        public string CloudManagementEndpoint { get; set; }
        /// <summary> App id of cluster AAD identity. </summary>
        public string AadClientId { get; set; }
        /// <summary> Tenant id of cluster AAD identity. </summary>
        public string AadTenantId { get; set; }
        /// <summary> Desired properties of the cluster. </summary>
        public ClusterDesiredProperties DesiredProperties { get; set; }
    }
}
