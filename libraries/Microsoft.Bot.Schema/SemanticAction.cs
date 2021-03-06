// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a reference to a programmatic action
    /// </summary>
    public partial class SemanticAction
    {
        /// <summary>
        /// Initializes a new instance of the SemanticAction class.
        /// </summary>
        public SemanticAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SemanticAction class.
        /// </summary>
        /// <param name="id">ID of this action</param>
        /// <param name="entities">Entities associated with this action</param>
        public SemanticAction(string id = default(string), IDictionary<string, object> entities = default(IDictionary<string, object>))
        {
            Id = id;
            Entities = entities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of this action
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets entities associated with this action
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IDictionary<string, object> Entities { get; set; }

    }
}
