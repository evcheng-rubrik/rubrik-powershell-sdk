// AzureExocomputeConfigValidationInfo.cs
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
    #region AzureExocomputeConfigValidationInfo
    public class AzureExocomputeConfigValidationInfo: BaseType
    {
        #region members

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Boolean? HasBlockedSecurityRules
        // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
        [JsonProperty("hasBlockedSecurityRules")]
        public System.Boolean? HasBlockedSecurityRules { get; set; }

        //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
        // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
        [JsonProperty("hasRestrictedAddressRangeOverlap")]
        public System.Boolean? HasRestrictedAddressRangeOverlap { get; set; }

        //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
        // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
        [JsonProperty("isClusterSubnetSizeTooSmall")]
        public System.Boolean? IsClusterSubnetSizeTooSmall { get; set; }

        //      C# -> System.Boolean? IsPodAndClusterSubnetSame
        // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
        [JsonProperty("isPodAndClusterSubnetSame")]
        public System.Boolean? IsPodAndClusterSubnetSame { get; set; }

        //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
        // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
        [JsonProperty("isPodAndClusterVnetDifferent")]
        public System.Boolean? IsPodAndClusterVnetDifferent { get; set; }

        //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
        // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
        [JsonProperty("isPodSubnetSizeTooSmall")]
        public System.Boolean? IsPodSubnetSizeTooSmall { get; set; }

        //      C# -> System.Boolean? IsSubnetDelegated
        // GraphQL -> isSubnetDelegated: Boolean! (scalar)
        [JsonProperty("isSubnetDelegated")]
        public System.Boolean? IsSubnetDelegated { get; set; }

        //      C# -> AzureExocomputeRegionConfig? Config
        // GraphQL -> config: AzureExocomputeRegionConfig (type)
        [JsonProperty("config")]
        public AzureExocomputeRegionConfig? Config { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureExocomputeConfigValidationInfo";
    }

    public AzureExocomputeConfigValidationInfo Set(
        System.String? ErrorMessage = null,
        System.Boolean? HasBlockedSecurityRules = null,
        System.Boolean? HasRestrictedAddressRangeOverlap = null,
        System.Boolean? IsClusterSubnetSizeTooSmall = null,
        System.Boolean? IsPodAndClusterSubnetSame = null,
        System.Boolean? IsPodAndClusterVnetDifferent = null,
        System.Boolean? IsPodSubnetSizeTooSmall = null,
        System.Boolean? IsSubnetDelegated = null,
        AzureExocomputeRegionConfig? Config = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( HasBlockedSecurityRules != null ) {
            this.HasBlockedSecurityRules = HasBlockedSecurityRules;
        }
        if ( HasRestrictedAddressRangeOverlap != null ) {
            this.HasRestrictedAddressRangeOverlap = HasRestrictedAddressRangeOverlap;
        }
        if ( IsClusterSubnetSizeTooSmall != null ) {
            this.IsClusterSubnetSizeTooSmall = IsClusterSubnetSizeTooSmall;
        }
        if ( IsPodAndClusterSubnetSame != null ) {
            this.IsPodAndClusterSubnetSame = IsPodAndClusterSubnetSame;
        }
        if ( IsPodAndClusterVnetDifferent != null ) {
            this.IsPodAndClusterVnetDifferent = IsPodAndClusterVnetDifferent;
        }
        if ( IsPodSubnetSizeTooSmall != null ) {
            this.IsPodSubnetSizeTooSmall = IsPodSubnetSizeTooSmall;
        }
        if ( IsSubnetDelegated != null ) {
            this.IsSubnetDelegated = IsSubnetDelegated;
        }
        if ( Config != null ) {
            this.Config = Config;
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
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Boolean? HasBlockedSecurityRules
        // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
        if (this.HasBlockedSecurityRules != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasBlockedSecurityRules\n" ;
            } else {
                s += ind + "hasBlockedSecurityRules\n" ;
            }
        }
        //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
        // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
        if (this.HasRestrictedAddressRangeOverlap != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasRestrictedAddressRangeOverlap\n" ;
            } else {
                s += ind + "hasRestrictedAddressRangeOverlap\n" ;
            }
        }
        //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
        // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
        if (this.IsClusterSubnetSizeTooSmall != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isClusterSubnetSizeTooSmall\n" ;
            } else {
                s += ind + "isClusterSubnetSizeTooSmall\n" ;
            }
        }
        //      C# -> System.Boolean? IsPodAndClusterSubnetSame
        // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
        if (this.IsPodAndClusterSubnetSame != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPodAndClusterSubnetSame\n" ;
            } else {
                s += ind + "isPodAndClusterSubnetSame\n" ;
            }
        }
        //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
        // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
        if (this.IsPodAndClusterVnetDifferent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPodAndClusterVnetDifferent\n" ;
            } else {
                s += ind + "isPodAndClusterVnetDifferent\n" ;
            }
        }
        //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
        // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
        if (this.IsPodSubnetSizeTooSmall != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPodSubnetSizeTooSmall\n" ;
            } else {
                s += ind + "isPodSubnetSizeTooSmall\n" ;
            }
        }
        //      C# -> System.Boolean? IsSubnetDelegated
        // GraphQL -> isSubnetDelegated: Boolean! (scalar)
        if (this.IsSubnetDelegated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubnetDelegated\n" ;
            } else {
                s += ind + "isSubnetDelegated\n" ;
            }
        }
        //      C# -> AzureExocomputeRegionConfig? Config
        // GraphQL -> config: AzureExocomputeRegionConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Boolean? HasBlockedSecurityRules
        // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
        if (ec.Includes("hasBlockedSecurityRules",true))
        {
            if(this.HasBlockedSecurityRules == null) {

                this.HasBlockedSecurityRules = true;

            } else {


            }
        }
        else if (this.HasBlockedSecurityRules != null && ec.Excludes("hasBlockedSecurityRules",true))
        {
            this.HasBlockedSecurityRules = null;
        }
        //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
        // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
        if (ec.Includes("hasRestrictedAddressRangeOverlap",true))
        {
            if(this.HasRestrictedAddressRangeOverlap == null) {

                this.HasRestrictedAddressRangeOverlap = true;

            } else {


            }
        }
        else if (this.HasRestrictedAddressRangeOverlap != null && ec.Excludes("hasRestrictedAddressRangeOverlap",true))
        {
            this.HasRestrictedAddressRangeOverlap = null;
        }
        //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
        // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
        if (ec.Includes("isClusterSubnetSizeTooSmall",true))
        {
            if(this.IsClusterSubnetSizeTooSmall == null) {

                this.IsClusterSubnetSizeTooSmall = true;

            } else {


            }
        }
        else if (this.IsClusterSubnetSizeTooSmall != null && ec.Excludes("isClusterSubnetSizeTooSmall",true))
        {
            this.IsClusterSubnetSizeTooSmall = null;
        }
        //      C# -> System.Boolean? IsPodAndClusterSubnetSame
        // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
        if (ec.Includes("isPodAndClusterSubnetSame",true))
        {
            if(this.IsPodAndClusterSubnetSame == null) {

                this.IsPodAndClusterSubnetSame = true;

            } else {


            }
        }
        else if (this.IsPodAndClusterSubnetSame != null && ec.Excludes("isPodAndClusterSubnetSame",true))
        {
            this.IsPodAndClusterSubnetSame = null;
        }
        //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
        // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
        if (ec.Includes("isPodAndClusterVnetDifferent",true))
        {
            if(this.IsPodAndClusterVnetDifferent == null) {

                this.IsPodAndClusterVnetDifferent = true;

            } else {


            }
        }
        else if (this.IsPodAndClusterVnetDifferent != null && ec.Excludes("isPodAndClusterVnetDifferent",true))
        {
            this.IsPodAndClusterVnetDifferent = null;
        }
        //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
        // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
        if (ec.Includes("isPodSubnetSizeTooSmall",true))
        {
            if(this.IsPodSubnetSizeTooSmall == null) {

                this.IsPodSubnetSizeTooSmall = true;

            } else {


            }
        }
        else if (this.IsPodSubnetSizeTooSmall != null && ec.Excludes("isPodSubnetSizeTooSmall",true))
        {
            this.IsPodSubnetSizeTooSmall = null;
        }
        //      C# -> System.Boolean? IsSubnetDelegated
        // GraphQL -> isSubnetDelegated: Boolean! (scalar)
        if (ec.Includes("isSubnetDelegated",true))
        {
            if(this.IsSubnetDelegated == null) {

                this.IsSubnetDelegated = true;

            } else {


            }
        }
        else if (this.IsSubnetDelegated != null && ec.Excludes("isSubnetDelegated",true))
        {
            this.IsSubnetDelegated = null;
        }
        //      C# -> AzureExocomputeRegionConfig? Config
        // GraphQL -> config: AzureExocomputeRegionConfig (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new AzureExocomputeRegionConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
        }
    }


    #endregion

    } // class AzureExocomputeConfigValidationInfo
    
    #endregion

    public static class ListAzureExocomputeConfigValidationInfoExtensions
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
            this List<AzureExocomputeConfigValidationInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeConfigValidationInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeConfigValidationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureExocomputeConfigValidationInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types