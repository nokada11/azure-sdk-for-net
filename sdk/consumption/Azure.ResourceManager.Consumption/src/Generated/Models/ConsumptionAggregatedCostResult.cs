// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Consumption;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> A management group aggregated cost resource. </summary>
    public partial class ConsumptionAggregatedCostResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ConsumptionAggregatedCostResult"/>. </summary>
        internal ConsumptionAggregatedCostResult()
        {
            Children = new ChangeTrackingList<ConsumptionAggregatedCostResult>();
            IncludedSubscriptions = new ChangeTrackingList<string>();
            ExcludedSubscriptions = new ChangeTrackingList<string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionAggregatedCostResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="billingPeriodId"> The id of the billing period resource that the aggregated cost belongs to. </param>
        /// <param name="usageStartOn"> The start of the date time range covered by aggregated cost. </param>
        /// <param name="usageEndOn"> The end of the date time range covered by the aggregated cost. </param>
        /// <param name="azureCharges"> Azure Charges. </param>
        /// <param name="marketplaceCharges"> Marketplace Charges. </param>
        /// <param name="chargesBilledSeparately"> Charges Billed Separately. </param>
        /// <param name="currency"> The ISO currency in which the meter is charged, for example, USD. </param>
        /// <param name="children"> Children of a management group. </param>
        /// <param name="includedSubscriptions"> List of subscription Guids included in the calculation of aggregated cost. </param>
        /// <param name="excludedSubscriptions"> List of subscription Guids excluded from the calculation of aggregated cost. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionAggregatedCostResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string billingPeriodId, DateTimeOffset? usageStartOn, DateTimeOffset? usageEndOn, decimal? azureCharges, decimal? marketplaceCharges, decimal? chargesBilledSeparately, string currency, IReadOnlyList<ConsumptionAggregatedCostResult> children, IReadOnlyList<string> includedSubscriptions, IReadOnlyList<string> excludedSubscriptions, ETag? etag, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            BillingPeriodId = billingPeriodId;
            UsageStartOn = usageStartOn;
            UsageEndOn = usageEndOn;
            AzureCharges = azureCharges;
            MarketplaceCharges = marketplaceCharges;
            ChargesBilledSeparately = chargesBilledSeparately;
            Currency = currency;
            Children = children;
            IncludedSubscriptions = includedSubscriptions;
            ExcludedSubscriptions = excludedSubscriptions;
            ETag = etag;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the billing period resource that the aggregated cost belongs to. </summary>
        public string BillingPeriodId { get; }
        /// <summary> The start of the date time range covered by aggregated cost. </summary>
        public DateTimeOffset? UsageStartOn { get; }
        /// <summary> The end of the date time range covered by the aggregated cost. </summary>
        public DateTimeOffset? UsageEndOn { get; }
        /// <summary> Azure Charges. </summary>
        public decimal? AzureCharges { get; }
        /// <summary> Marketplace Charges. </summary>
        public decimal? MarketplaceCharges { get; }
        /// <summary> Charges Billed Separately. </summary>
        public decimal? ChargesBilledSeparately { get; }
        /// <summary> The ISO currency in which the meter is charged, for example, USD. </summary>
        public string Currency { get; }
        /// <summary> Children of a management group. </summary>
        public IReadOnlyList<ConsumptionAggregatedCostResult> Children { get; }
        /// <summary> List of subscription Guids included in the calculation of aggregated cost. </summary>
        public IReadOnlyList<string> IncludedSubscriptions { get; }
        /// <summary> List of subscription Guids excluded from the calculation of aggregated cost. </summary>
        public IReadOnlyList<string> ExcludedSubscriptions { get; }
        /// <summary> The etag for the resource. </summary>
        public ETag? ETag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
