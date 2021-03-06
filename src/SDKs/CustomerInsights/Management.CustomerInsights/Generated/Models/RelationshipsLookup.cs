// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The definition of suggested relationship for the type.
    /// </summary>
    public partial class RelationshipsLookup
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipsLookup class.
        /// </summary>
        public RelationshipsLookup() { }

        /// <summary>
        /// Initializes a new instance of the RelationshipsLookup class.
        /// </summary>
        /// <param name="profileName">The relationship profile.</param>
        /// <param name="profilePropertyReferences">The property references for
        /// the profile type.</param>
        /// <param name="relatedProfileName">The related profile.</param>
        /// <param name="relatedProfilePropertyReferences">The property
        /// references for the related profile type.</param>
        /// <param name="existingRelationshipName">The name of existing
        /// Relationship.</param>
        public RelationshipsLookup(string profileName = default(string), IList<ParticipantPropertyReference> profilePropertyReferences = default(IList<ParticipantPropertyReference>), string relatedProfileName = default(string), IList<ParticipantPropertyReference> relatedProfilePropertyReferences = default(IList<ParticipantPropertyReference>), string existingRelationshipName = default(string))
        {
            ProfileName = profileName;
            ProfilePropertyReferences = profilePropertyReferences;
            RelatedProfileName = relatedProfileName;
            RelatedProfilePropertyReferences = relatedProfilePropertyReferences;
            ExistingRelationshipName = existingRelationshipName;
        }

        /// <summary>
        /// Gets the relationship profile.
        /// </summary>
        [JsonProperty(PropertyName = "profileName")]
        public string ProfileName { get; protected set; }

        /// <summary>
        /// Gets the property references for the profile type.
        /// </summary>
        [JsonProperty(PropertyName = "profilePropertyReferences")]
        public IList<ParticipantPropertyReference> ProfilePropertyReferences { get; protected set; }

        /// <summary>
        /// Gets the related profile.
        /// </summary>
        [JsonProperty(PropertyName = "relatedProfileName")]
        public string RelatedProfileName { get; protected set; }

        /// <summary>
        /// Gets the property references for the related profile type.
        /// </summary>
        [JsonProperty(PropertyName = "relatedProfilePropertyReferences")]
        public IList<ParticipantPropertyReference> RelatedProfilePropertyReferences { get; protected set; }

        /// <summary>
        /// Gets the name of existing Relationship.
        /// </summary>
        [JsonProperty(PropertyName = "existingRelationshipName")]
        public string ExistingRelationshipName { get; protected set; }

    }
}

