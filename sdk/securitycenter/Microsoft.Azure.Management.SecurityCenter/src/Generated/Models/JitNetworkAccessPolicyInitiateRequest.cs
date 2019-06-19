// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class JitNetworkAccessPolicyInitiateRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// JitNetworkAccessPolicyInitiateRequest class.
        /// </summary>
        public JitNetworkAccessPolicyInitiateRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// JitNetworkAccessPolicyInitiateRequest class.
        /// </summary>
        /// <param name="virtualMachines">A list of virtual machines &amp;
        /// ports to open access for</param>
        public JitNetworkAccessPolicyInitiateRequest(IList<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines)
        {
            VirtualMachines = virtualMachines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of virtual machines &amp;amp; ports to open
        /// access for
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachines")]
        public IList<JitNetworkAccessPolicyInitiateVirtualMachine> VirtualMachines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualMachines == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualMachines");
            }
            if (VirtualMachines != null)
            {
                foreach (var element in VirtualMachines)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}