// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure or AzureStack blob information.
    /// </summary>
    public partial class AzureBlob
    {
        /// <summary>
        /// Initializes a new instance of the AzureBlob class.
        /// </summary>
        public AzureBlob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBlob class.
        /// </summary>
        /// <param name="uri">URI to Azure or AzureStack blob.</param>
        public AzureBlob(string uri = default(string))
        {
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URI to Azure or AzureStack blob.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

    }
}
