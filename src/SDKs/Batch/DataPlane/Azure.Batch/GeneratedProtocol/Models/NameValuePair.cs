// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Represents a name-value pair.
    /// </summary>
    public partial class NameValuePair
    {
        /// <summary>
        /// Initializes a new instance of the NameValuePair class.
        /// </summary>
        public NameValuePair() { }

        /// <summary>
        /// Initializes a new instance of the NameValuePair class.
        /// </summary>
        /// <param name="name">The name in the name-value pair.</param>
        /// <param name="value">The value in the name-value pair.</param>
        public NameValuePair(string name = default(string), string value = default(string))
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the name in the name-value pair.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value in the name-value pair.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
