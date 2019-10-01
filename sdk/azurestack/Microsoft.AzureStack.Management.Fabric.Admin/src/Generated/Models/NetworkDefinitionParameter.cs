// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A definition of the network received from a new cluster operation.
    /// </summary>
    public partial class NetworkDefinitionParameter
    {
        /// <summary>
        /// Initializes a new instance of the NetworkDefinitionParameter class.
        /// </summary>
        public NetworkDefinitionParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkDefinitionParameter class.
        /// </summary>
        /// <param name="subnet">The subnet IP mask in the example format
        /// 10.0.0.0/25.</param>
        /// <param name="vlanId">The Vlan ID of the subnet.</param>
        public NetworkDefinitionParameter(IList<string> subnet = default(IList<string>), IList<string> vlanId = default(IList<string>))
        {
            Subnet = subnet;
            VlanId = vlanId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subnet IP mask in the example format 10.0.0.0/25.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public IList<string> Subnet { get; set; }

        /// <summary>
        /// Gets or sets the Vlan ID of the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "vlanId")]
        public IList<string> VlanId { get; set; }

    }
}
