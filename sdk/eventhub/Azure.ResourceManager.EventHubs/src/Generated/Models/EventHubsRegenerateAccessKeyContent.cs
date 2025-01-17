// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Parameters supplied to the Regenerate Authorization Rule operation, specifies which key needs to be reset. </summary>
    public partial class EventHubsRegenerateAccessKeyContent
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

        /// <summary> Initializes a new instance of <see cref="EventHubsRegenerateAccessKeyContent"/>. </summary>
        /// <param name="keyType"> The access key to regenerate. </param>
        public EventHubsRegenerateAccessKeyContent(EventHubsAccessKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsRegenerateAccessKeyContent"/>. </summary>
        /// <param name="keyType"> The access key to regenerate. </param>
        /// <param name="key"> Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsRegenerateAccessKeyContent(EventHubsAccessKeyType keyType, string key, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            Key = key;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsRegenerateAccessKeyContent"/> for deserialization. </summary>
        internal EventHubsRegenerateAccessKeyContent()
        {
        }

        /// <summary> The access key to regenerate. </summary>
        public EventHubsAccessKeyType KeyType { get; }
        /// <summary> Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType. </summary>
        public string Key { get; set; }
    }
}
