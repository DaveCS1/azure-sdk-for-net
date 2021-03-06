// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the DSC Meta Configuration.
    /// </summary>
    public partial class DscMetaConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DscMetaConfiguration class.
        /// </summary>
        public DscMetaConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscMetaConfiguration class.
        /// </summary>
        /// <param name="configurationModeFrequencyMins">Gets or sets the
        /// ConfigurationModeFrequencyMins value of the meta
        /// configuration.</param>
        /// <param name="rebootNodeIfNeeded">Gets or sets the
        /// RebootNodeIfNeeded value of the meta configuration.</param>
        /// <param name="configurationMode">Gets or sets the ConfigurationMode
        /// value of the meta configuration.</param>
        /// <param name="actionAfterReboot">Gets or sets the ActionAfterReboot
        /// value of the meta configuration.</param>
        /// <param name="certificateId">Gets or sets the CertificateId value of
        /// the meta configuration.</param>
        /// <param name="refreshFrequencyMins">Gets or sets the
        /// RefreshFrequencyMins value of the meta configuration.</param>
        /// <param name="allowModuleOverwrite">Gets or sets the
        /// AllowModuleOverwrite value of the meta configuration.</param>
        public DscMetaConfiguration(int? configurationModeFrequencyMins = default(int?), bool? rebootNodeIfNeeded = default(bool?), string configurationMode = default(string), string actionAfterReboot = default(string), string certificateId = default(string), int? refreshFrequencyMins = default(int?), bool? allowModuleOverwrite = default(bool?))
        {
            ConfigurationModeFrequencyMins = configurationModeFrequencyMins;
            RebootNodeIfNeeded = rebootNodeIfNeeded;
            ConfigurationMode = configurationMode;
            ActionAfterReboot = actionAfterReboot;
            CertificateId = certificateId;
            RefreshFrequencyMins = refreshFrequencyMins;
            AllowModuleOverwrite = allowModuleOverwrite;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ConfigurationModeFrequencyMins value of the meta
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "configurationModeFrequencyMins")]
        public int? ConfigurationModeFrequencyMins { get; set; }

        /// <summary>
        /// Gets or sets the RebootNodeIfNeeded value of the meta
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rebootNodeIfNeeded")]
        public bool? RebootNodeIfNeeded { get; set; }

        /// <summary>
        /// Gets or sets the ConfigurationMode value of the meta configuration.
        /// </summary>
        [JsonProperty(PropertyName = "configurationMode")]
        public string ConfigurationMode { get; set; }

        /// <summary>
        /// Gets or sets the ActionAfterReboot value of the meta configuration.
        /// </summary>
        [JsonProperty(PropertyName = "actionAfterReboot")]
        public string ActionAfterReboot { get; set; }

        /// <summary>
        /// Gets or sets the CertificateId value of the meta configuration.
        /// </summary>
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }

        /// <summary>
        /// Gets or sets the RefreshFrequencyMins value of the meta
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "refreshFrequencyMins")]
        public int? RefreshFrequencyMins { get; set; }

        /// <summary>
        /// Gets or sets the AllowModuleOverwrite value of the meta
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "allowModuleOverwrite")]
        public bool? AllowModuleOverwrite { get; set; }

    }
}
