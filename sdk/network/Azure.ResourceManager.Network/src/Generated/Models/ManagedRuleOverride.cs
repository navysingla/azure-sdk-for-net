// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleOverride
    {
        /// <summary> Initializes a new instance of ManagedRuleOverride. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public ManagedRuleOverride(string ruleId)
        {
            if (ruleId == null)
            {
                throw new ArgumentNullException(nameof(ruleId));
            }

            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of ManagedRuleOverride. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <param name="state"> The state of the managed rule. Defaults to Disabled if not specified. </param>
        internal ManagedRuleOverride(string ruleId, ManagedRuleEnabledState? state)
        {
            RuleId = ruleId;
            State = state;
        }

        /// <summary> Identifier for the managed rule. </summary>
        public string RuleId { get; set; }
        /// <summary> The state of the managed rule. Defaults to Disabled if not specified. </summary>
        public ManagedRuleEnabledState? State { get; set; }
    }
}
