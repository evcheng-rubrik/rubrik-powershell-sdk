// CreateO365AppKickoffInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CreateO365AppKickoffInput

    public class CreateO365AppKickoffInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("appType")]
        public System.String? AppType { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class CreateO365AppKickoffInput
    #endregion

} // namespace RubrikSecurityCloud.Types