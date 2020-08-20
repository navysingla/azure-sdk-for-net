// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleGroupOverride
    {
        /// <summary> Initializes a new instance of ManagedRuleGroupOverride. </summary>
        /// <param name="ruleGroupName"> The managed rule group to override. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleGroupName"/> is null. </exception>
        public ManagedRuleGroupOverride(string ruleGroupName)
        {
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            RuleGroupName = ruleGroupName;
            Rules = new ChangeTrackingList<ManagedRuleOverride>();
        }

        /// <summary> Initializes a new instance of ManagedRuleGroupOverride. </summary>
        /// <param name="ruleGroupName"> The managed rule group to override. </param>
        /// <param name="rules"> List of rules that will be disabled. If none specified, all rules in the group will be disabled. </param>
        internal ManagedRuleGroupOverride(string ruleGroupName, IList<ManagedRuleOverride> rules)
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
        }

        /// <summary> The managed rule group to override. </summary>
        public string RuleGroupName { get; set; }
        /// <summary> List of rules that will be disabled. If none specified, all rules in the group will be disabled. </summary>
        public IList<ManagedRuleOverride> Rules { get; }
    }
}
