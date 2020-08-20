// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class WebApplicationFirewallPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicySettings))
            {
                writer.WritePropertyName("policySettings");
                writer.WriteObjectValue(PolicySettings);
            }
            if (Optional.IsCollectionDefined(CustomRules))
            {
                writer.WritePropertyName("customRules");
                writer.WriteStartArray();
                foreach (var item in CustomRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagedRules))
            {
                writer.WritePropertyName("managedRules");
                writer.WriteObjectValue(ManagedRules);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebApplicationFirewallPolicy DeserializeWebApplicationFirewallPolicy(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<PolicySettings> policySettings = default;
            Optional<IList<WebApplicationFirewallCustomRule>> customRules = default;
            Optional<IReadOnlyList<ApplicationGateway>> applicationGateways = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<WebApplicationFirewallPolicyResourceState> resourceState = default;
            Optional<ManagedRulesDefinition> managedRules = default;
            Optional<IReadOnlyList<SubResource>> httpListeners = default;
            Optional<IReadOnlyList<SubResource>> pathBasedRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policySettings"))
                        {
                            policySettings = PolicySettings.DeserializePolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"))
                        {
                            List<WebApplicationFirewallCustomRule> array = new List<WebApplicationFirewallCustomRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebApplicationFirewallCustomRule.DeserializeWebApplicationFirewallCustomRule(item));
                            }
                            customRules = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationGateways"))
                        {
                            List<ApplicationGateway> array = new List<ApplicationGateway>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGateway.DeserializeApplicationGateway(item));
                            }
                            applicationGateways = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            resourceState = new WebApplicationFirewallPolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedRules"))
                        {
                            managedRules = ManagedRulesDefinition.DeserializeManagedRulesDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpListeners"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            httpListeners = array;
                            continue;
                        }
                        if (property0.NameEquals("pathBasedRules"))
                        {
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            pathBasedRules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebApplicationFirewallPolicy(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, policySettings.Value, Optional.ToList(customRules), Optional.ToList(applicationGateways), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceState), managedRules.Value, Optional.ToList(httpListeners), Optional.ToList(pathBasedRules));
        }
    }
}
