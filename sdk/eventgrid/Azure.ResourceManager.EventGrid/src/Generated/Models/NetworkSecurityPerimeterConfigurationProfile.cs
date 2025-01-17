// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Nsp configuration with profile information. </summary>
    public partial class NetworkSecurityPerimeterConfigurationProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterConfigurationProfile"/>. </summary>
        public NetworkSecurityPerimeterConfigurationProfile()
        {
            AccessRules = new ChangeTrackingList<NetworkSecurityPerimeterProfileAccessRule>();
            EnabledLogCategories = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterConfigurationProfile"/>. </summary>
        /// <param name="name"> Nsp configuration profile name. </param>
        /// <param name="accessRulesVersion"> Access rules version number for nsp profile. </param>
        /// <param name="accessRules"> List of inbound or outbound access rule setup on the nsp profile. </param>
        /// <param name="diagnosticSettingsVersion"> Diagnostic settings version number for nsp profile. </param>
        /// <param name="enabledLogCategories"> Enabled log categories for nsp profile. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterConfigurationProfile(string name, string accessRulesVersion, IList<NetworkSecurityPerimeterProfileAccessRule> accessRules, string diagnosticSettingsVersion, IList<string> enabledLogCategories, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AccessRulesVersion = accessRulesVersion;
            AccessRules = accessRules;
            DiagnosticSettingsVersion = diagnosticSettingsVersion;
            EnabledLogCategories = enabledLogCategories;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Nsp configuration profile name. </summary>
        public string Name { get; set; }
        /// <summary> Access rules version number for nsp profile. </summary>
        public string AccessRulesVersion { get; set; }
        /// <summary> List of inbound or outbound access rule setup on the nsp profile. </summary>
        public IList<NetworkSecurityPerimeterProfileAccessRule> AccessRules { get; }
        /// <summary> Diagnostic settings version number for nsp profile. </summary>
        public string DiagnosticSettingsVersion { get; set; }
        /// <summary> Enabled log categories for nsp profile. </summary>
        public IList<string> EnabledLogCategories { get; }
    }
}
