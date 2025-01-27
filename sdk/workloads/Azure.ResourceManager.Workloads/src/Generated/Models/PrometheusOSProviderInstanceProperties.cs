// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the PrometheusOS provider properties. </summary>
    public partial class PrometheusOSProviderInstanceProperties : ProviderSpecificProperties
    {
        /// <summary> Initializes a new instance of PrometheusOSProviderInstanceProperties. </summary>
        public PrometheusOSProviderInstanceProperties()
        {
            ProviderType = "PrometheusOS";
        }

        /// <summary> Initializes a new instance of PrometheusOSProviderInstanceProperties. </summary>
        /// <param name="providerType"> The provider type. For example, the value can be SapHana. </param>
        /// <param name="prometheusUri"> URL of the Node Exporter endpoint. </param>
        /// <param name="sslPreference"> Gets or sets certificate preference if secure communication is enabled. </param>
        /// <param name="sslCertificateUri"> Gets or sets the blob URI to SSL certificate for the prometheus node exporter. </param>
        /// <param name="sapSid"> Gets or sets the SAP System Identifier. </param>
        internal PrometheusOSProviderInstanceProperties(string providerType, Uri prometheusUri, SslPreference? sslPreference, Uri sslCertificateUri, string sapSid) : base(providerType)
        {
            PrometheusUri = prometheusUri;
            SslPreference = sslPreference;
            SslCertificateUri = sslCertificateUri;
            SapSid = sapSid;
            ProviderType = providerType ?? "PrometheusOS";
        }

        /// <summary> URL of the Node Exporter endpoint. </summary>
        public Uri PrometheusUri { get; set; }
        /// <summary> Gets or sets certificate preference if secure communication is enabled. </summary>
        public SslPreference? SslPreference { get; set; }
        /// <summary> Gets or sets the blob URI to SSL certificate for the prometheus node exporter. </summary>
        public Uri SslCertificateUri { get; set; }
        /// <summary> Gets or sets the SAP System Identifier. </summary>
        public string SapSid { get; set; }
    }
}
