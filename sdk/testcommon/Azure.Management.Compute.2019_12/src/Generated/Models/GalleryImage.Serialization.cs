// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class GalleryImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula");
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri");
                writer.WriteStringValue(PrivacyStatementUri);
            }
            if (Optional.IsDefined(ReleaseNoteUri))
            {
                writer.WritePropertyName("releaseNoteUri");
                writer.WriteStringValue(ReleaseNoteUri);
            }
            if (Optional.IsDefined(OsType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OsType.Value.ToSerialString());
            }
            if (Optional.IsDefined(OsState))
            {
                writer.WritePropertyName("osState");
                writer.WriteStringValue(OsState.Value.ToSerialString());
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Optional.IsDefined(EndOfLifeDate))
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeDate.Value, "O");
            }
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier");
                writer.WriteObjectValue(Identifier);
            }
            if (Optional.IsDefined(Recommended))
            {
                writer.WritePropertyName("recommended");
                writer.WriteObjectValue(Recommended);
            }
            if (Optional.IsDefined(Disallowed))
            {
                writer.WritePropertyName("disallowed");
                writer.WriteObjectValue(Disallowed);
            }
            if (Optional.IsDefined(PurchasePlan))
            {
                writer.WritePropertyName("purchasePlan");
                writer.WriteObjectValue(PurchasePlan);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static GalleryImage DeserializeGalleryImage(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> description = default;
            Optional<string> eula = default;
            Optional<string> privacyStatementUri = default;
            Optional<string> releaseNoteUri = default;
            Optional<OperatingSystemTypes> osType = default;
            Optional<OperatingSystemStateTypes> osState = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<GalleryImageIdentifier> identifier = default;
            Optional<RecommendedMachineConfiguration> recommended = default;
            Optional<Disallowed> disallowed = default;
            Optional<ImagePurchasePlan> purchasePlan = default;
            Optional<GalleryImagePropertiesProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eula"))
                        {
                            eula = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privacyStatementUri"))
                        {
                            privacyStatementUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("releaseNoteUri"))
                        {
                            releaseNoteUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            osType = property0.Value.GetString().ToOperatingSystemTypes();
                            continue;
                        }
                        if (property0.NameEquals("osState"))
                        {
                            osState = property0.Value.GetString().ToOperatingSystemStateTypes();
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"))
                        {
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endOfLifeDate"))
                        {
                            endOfLifeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("identifier"))
                        {
                            identifier = GalleryImageIdentifier.DeserializeGalleryImageIdentifier(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("recommended"))
                        {
                            recommended = RecommendedMachineConfiguration.DeserializeRecommendedMachineConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("disallowed"))
                        {
                            disallowed = Disallowed.DeserializeDisallowed(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"))
                        {
                            purchasePlan = ImagePurchasePlan.DeserializeImagePurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new GalleryImagePropertiesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new GalleryImage(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), description.Value, eula.Value, privacyStatementUri.Value, releaseNoteUri.Value, Optional.ToNullable(osType), Optional.ToNullable(osState), Optional.ToNullable(hyperVGeneration), Optional.ToNullable(endOfLifeDate), identifier.Value, recommended.Value, disallowed.Value, purchasePlan.Value, Optional.ToNullable(provisioningState));
        }
    }
}
