// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request body for a request to Bot Service Management to check
    /// availability of a bot name.
    /// </summary>
    public partial class CheckNameAvailabilityRequestBody
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityRequestBody
        /// class.
        /// </summary>
        public CheckNameAvailabilityRequestBody()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityRequestBody
        /// class.
        /// </summary>
        /// <param name="name">the name of the bot for which availability needs
        /// to be checked.</param>
        /// <param name="type">the type of the bot for which availability needs
        /// to be checked</param>
        public CheckNameAvailabilityRequestBody(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the bot for which availability needs to be
        /// checked.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the bot for which availability needs to be
        /// checked
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
