// AwsFeatureConfig.cs
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
    #region AwsFeatureConfig
    public class AwsFeatureConfig: BaseType
    {
        #region members

        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        [JsonProperty("exocomputeConfigs")]
        public List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs { get; set; }

        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        [JsonProperty("featureDetail")]
        public FeatureDetail? FeatureDetail { get; set; }

        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        [JsonProperty("mappedExocomputeAccount")]
        public CloudAccountDetails? MappedExocomputeAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsFeatureConfig";
    }

    public AwsFeatureConfig Set(
        AwsCloudAccount? AwsCloudAccount = null,
        List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs = null,
        FeatureDetail? FeatureDetail = null,
        CloudAccountDetails? MappedExocomputeAccount = null
    ) 
    {
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( MappedExocomputeAccount != null ) {
            this.MappedExocomputeAccount = MappedExocomputeAccount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount != null) {
            var fspec = this.AwsCloudAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsCloudAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.ExocomputeConfigs != null) {
            var fspec = this.ExocomputeConfigs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "exocomputeConfigs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureDetail {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (this.MappedExocomputeAccount != null) {
            var fspec = this.MappedExocomputeAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mappedExocomputeAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount == null && ec.Includes("awsCloudAccount",false))
        {
            this.AwsCloudAccount = new AwsCloudAccount();
            this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.ExocomputeConfigs == null && ec.Includes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = new List<AwsExocomputeGetConfigResponse>();
            this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail == null && ec.Includes("featureDetail",false))
        {
            this.FeatureDetail = new FeatureDetail();
            this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (this.MappedExocomputeAccount == null && ec.Includes("mappedExocomputeAccount",false))
        {
            this.MappedExocomputeAccount = new CloudAccountDetails();
            this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));
        }
    }


    #endregion

    } // class AwsFeatureConfig
    
    #endregion

    public static class ListAwsFeatureConfigExtensions
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
            this List<AwsFeatureConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsFeatureConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsFeatureConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsFeatureConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types