// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceType. </summary>
    public partial class ResourceType
    {
        /// <summary> Initializes a new instance of ResourceType. </summary>
        internal ResourceType()
        {
            AllowedUnauthorizedActions = new ChangeTrackingList<string>();
            AuthorizationActionMappings = new ChangeTrackingList<AuthorizationActionMapping>();
            LinkedAccessChecks = new ChangeTrackingList<LinkedAccessCheck>();
            LoggingRules = new ChangeTrackingList<LoggingRule>();
            ThrottlingRules = new ChangeTrackingList<ThrottlingRule>();
            Endpoints = new ChangeTrackingList<ResourceProviderEndpoint>();
            RequiredFeatures = new ChangeTrackingList<string>();
            SubscriptionStateRules = new ChangeTrackingList<SubscriptionStateRule>();
            ServiceTreeInfos = new ChangeTrackingList<ServiceTreeInfo>();
            DisallowedActionVerbs = new ChangeTrackingList<string>();
            ExtendedLocations = new ChangeTrackingList<ExtendedLocationOptions>();
            LinkedOperationRules = new ChangeTrackingList<LinkedOperationRule>();
        }

        /// <summary> Initializes a new instance of ResourceType. </summary>
        /// <param name="name"></param>
        /// <param name="routingType"></param>
        /// <param name="resourceValidation"></param>
        /// <param name="allowedUnauthorizedActions"></param>
        /// <param name="authorizationActionMappings"></param>
        /// <param name="linkedAccessChecks"></param>
        /// <param name="defaultApiVersion"></param>
        /// <param name="loggingRules"></param>
        /// <param name="throttlingRules"></param>
        /// <param name="endpoints"></param>
        /// <param name="marketplaceType"></param>
        /// <param name="identityManagement"></param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="requiredFeatures"></param>
        /// <param name="featuresRule"></param>
        /// <param name="subscriptionStateRules"></param>
        /// <param name="serviceTreeInfos"></param>
        /// <param name="requestHeaderOptions"></param>
        /// <param name="skuLink"></param>
        /// <param name="disallowedActionVerbs"></param>
        /// <param name="templateDeploymentPolicy"></param>
        /// <param name="extendedLocations"></param>
        /// <param name="linkedOperationRules"></param>
        /// <param name="resourceDeletionPolicy"></param>
        internal ResourceType(string name, RoutingType? routingType, ResourceValidation? resourceValidation, IReadOnlyList<string> allowedUnauthorizedActions, IReadOnlyList<AuthorizationActionMapping> authorizationActionMappings, IReadOnlyList<LinkedAccessCheck> linkedAccessChecks, string defaultApiVersion, IReadOnlyList<LoggingRule> loggingRules, IReadOnlyList<ThrottlingRule> throttlingRules, IReadOnlyList<ResourceProviderEndpoint> endpoints, ResourceTypeMarketplaceType? marketplaceType, ResourceTypeIdentityManagement identityManagement, BinaryData metadata, IReadOnlyList<string> requiredFeatures, ResourceTypeFeaturesRule featuresRule, IReadOnlyList<SubscriptionStateRule> subscriptionStateRules, IReadOnlyList<ServiceTreeInfo> serviceTreeInfos, ResourceTypeRequestHeaderOptions requestHeaderOptions, string skuLink, IReadOnlyList<string> disallowedActionVerbs, ResourceTypeTemplateDeploymentPolicy templateDeploymentPolicy, IReadOnlyList<ExtendedLocationOptions> extendedLocations, IReadOnlyList<LinkedOperationRule> linkedOperationRules, ManifestResourceDeletionPolicy? resourceDeletionPolicy)
        {
            Name = name;
            RoutingType = routingType;
            ResourceValidation = resourceValidation;
            AllowedUnauthorizedActions = allowedUnauthorizedActions;
            AuthorizationActionMappings = authorizationActionMappings;
            LinkedAccessChecks = linkedAccessChecks;
            DefaultApiVersion = defaultApiVersion;
            LoggingRules = loggingRules;
            ThrottlingRules = throttlingRules;
            Endpoints = endpoints;
            MarketplaceType = marketplaceType;
            IdentityManagement = identityManagement;
            Metadata = metadata;
            RequiredFeatures = requiredFeatures;
            FeaturesRule = featuresRule;
            SubscriptionStateRules = subscriptionStateRules;
            ServiceTreeInfos = serviceTreeInfos;
            RequestHeaderOptions = requestHeaderOptions;
            SkuLink = skuLink;
            DisallowedActionVerbs = disallowedActionVerbs;
            TemplateDeploymentPolicy = templateDeploymentPolicy;
            ExtendedLocations = extendedLocations;
            LinkedOperationRules = linkedOperationRules;
            ResourceDeletionPolicy = resourceDeletionPolicy;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the routing type. </summary>
        public RoutingType? RoutingType { get; }
        /// <summary> Gets the resource validation. </summary>
        public ResourceValidation? ResourceValidation { get; }
        /// <summary> Gets the allowed unauthorized actions. </summary>
        public IReadOnlyList<string> AllowedUnauthorizedActions { get; }
        /// <summary> Gets the authorization action mappings. </summary>
        public IReadOnlyList<AuthorizationActionMapping> AuthorizationActionMappings { get; }
        /// <summary> Gets the linked access checks. </summary>
        public IReadOnlyList<LinkedAccessCheck> LinkedAccessChecks { get; }
        /// <summary> Gets the default api version. </summary>
        public string DefaultApiVersion { get; }
        /// <summary> Gets the logging rules. </summary>
        public IReadOnlyList<LoggingRule> LoggingRules { get; }
        /// <summary> Gets the throttling rules. </summary>
        public IReadOnlyList<ThrottlingRule> ThrottlingRules { get; }
        /// <summary> Gets the endpoints. </summary>
        public IReadOnlyList<ResourceProviderEndpoint> Endpoints { get; }
        /// <summary> Gets the marketplace type. </summary>
        public ResourceTypeMarketplaceType? MarketplaceType { get; }
        /// <summary> Gets the identity management. </summary>
        internal ResourceTypeIdentityManagement IdentityManagement { get; }
        /// <summary> Gets the management type. </summary>
        public IdentityManagementType? ManagementType
        {
            get => IdentityManagement?.ManagementType;
        }

        /// <summary>
        /// Anything
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Metadata { get; }
        /// <summary> Gets the required features. </summary>
        public IReadOnlyList<string> RequiredFeatures { get; }
        /// <summary> Gets the features rule. </summary>
        internal ResourceTypeFeaturesRule FeaturesRule { get; }
        /// <summary> Gets the required features policy. </summary>
        public FeaturesPolicy? RequiredFeaturesPolicy
        {
            get => FeaturesRule?.RequiredFeaturesPolicy;
        }

        /// <summary> Gets the subscription state rules. </summary>
        public IReadOnlyList<SubscriptionStateRule> SubscriptionStateRules { get; }
        /// <summary> Gets the service tree infos. </summary>
        public IReadOnlyList<ServiceTreeInfo> ServiceTreeInfos { get; }
        /// <summary> Gets the request header options. </summary>
        internal ResourceTypeRequestHeaderOptions RequestHeaderOptions { get; }
        /// <summary> Gets the opt in headers. </summary>
        public OptInHeaderType? OptInHeaders
        {
            get => RequestHeaderOptions?.OptInHeaders;
        }

        /// <summary> Gets the sku link. </summary>
        public string SkuLink { get; }
        /// <summary> Gets the disallowed action verbs. </summary>
        public IReadOnlyList<string> DisallowedActionVerbs { get; }
        /// <summary> Gets the template deployment policy. </summary>
        public ResourceTypeTemplateDeploymentPolicy TemplateDeploymentPolicy { get; }
        /// <summary> Gets the extended locations. </summary>
        public IReadOnlyList<ExtendedLocationOptions> ExtendedLocations { get; }
        /// <summary> Gets the linked operation rules. </summary>
        public IReadOnlyList<LinkedOperationRule> LinkedOperationRules { get; }
        /// <summary> Gets the resource deletion policy. </summary>
        public ManifestResourceDeletionPolicy? ResourceDeletionPolicy { get; }
    }
}
