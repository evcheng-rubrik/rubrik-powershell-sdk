// UpgradeAzureCloudAccountPermissionsWithoutOauthReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UpgradeAzureCloudAccountPermissionsWithoutOauthReply
    public class UpgradeAzureCloudAccountPermissionsWithoutOauthReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean! (scalar)
        [JsonProperty("status")]
        public System.Boolean? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeAzureCloudAccountPermissionsWithoutOauthReply";
    }

    public UpgradeAzureCloudAccountPermissionsWithoutOauthReply Set(
        System.Boolean? Status = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = true;

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class UpgradeAzureCloudAccountPermissionsWithoutOauthReply
    
    #endregion

    public static class ListUpgradeAzureCloudAccountPermissionsWithoutOauthReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<UpgradeAzureCloudAccountPermissionsWithoutOauthReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeAzureCloudAccountPermissionsWithoutOauthReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeAzureCloudAccountPermissionsWithoutOauthReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeAzureCloudAccountPermissionsWithoutOauthReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types