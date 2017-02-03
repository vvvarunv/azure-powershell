﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.EventHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.EventHub.Models
{    /// <summary>
    /// 
    /// </summary>
    /// 
    public class SharedAccessAuthorizationRuleAttributes
    {

        public SharedAccessAuthorizationRuleAttributes()
        { }

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultClaimType = "SharedAccessKey";
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultClaimValue = "None";

        /// <summary>
        /// 
        /// </summary>
        internal const string DefaultNamespaceAuthorizationRule = "RootManageSharedAccessKey";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="authRuleResource"></param>
        public SharedAccessAuthorizationRuleAttributes(SharedAccessAuthorizationRuleResource authRuleResource)
        {
            if (authRuleResource != null)
            {
                Id = authRuleResource.Id;
                Name = authRuleResource.Name;
                Type = authRuleResource.Type;
                Location = authRuleResource.Location;               
                Rights = authRuleResource.Rights.ToList();
            }
        }

        /// <summary>
        /// Gets or sets the Id of the Namespace
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Type of the Namespace
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the Namespace
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location the Namespace is in
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags associated with the Namespace.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The rights associated with the rule.
        /// </summary>
        public IList<AccessRights?> Rights { get; set; }
       
    }
}
