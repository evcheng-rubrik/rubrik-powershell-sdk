// K8sSnapshotSummary.cs
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
    #region K8sSnapshotSummary
    public class K8sSnapshotSummary: BaseType
    {
        #region members

        //      C# -> System.String? K8SprotectionSetName
        // GraphQL -> k8SProtectionSetName: String (scalar)
        [JsonProperty("k8SProtectionSetName")]
        public System.String? K8SprotectionSetName { get; set; }

        //      C# -> System.String? K8SresourceSetName
        // GraphQL -> k8SResourceSetName: String (scalar)
        [JsonProperty("k8SResourceSetName")]
        public System.String? K8SresourceSetName { get; set; }

        //      C# -> System.String? K8SsnapshotMetadata
        // GraphQL -> k8SSnapshotMetadata: String (scalar)
        [JsonProperty("k8SSnapshotMetadata")]
        public System.String? K8SsnapshotMetadata { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sSnapshotSummary";
    }

    public K8sSnapshotSummary Set(
        System.String? K8SprotectionSetName = null,
        System.String? K8SresourceSetName = null,
        System.String? K8SsnapshotMetadata = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( K8SprotectionSetName != null ) {
            this.K8SprotectionSetName = K8SprotectionSetName;
        }
        if ( K8SresourceSetName != null ) {
            this.K8SresourceSetName = K8SresourceSetName;
        }
        if ( K8SsnapshotMetadata != null ) {
            this.K8SsnapshotMetadata = K8SsnapshotMetadata;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
        //      C# -> System.String? K8SprotectionSetName
        // GraphQL -> k8SProtectionSetName: String (scalar)
        if (this.K8SprotectionSetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "k8SProtectionSetName\n" ;
            } else {
                s += ind + "k8SProtectionSetName\n" ;
            }
        }
        //      C# -> System.String? K8SresourceSetName
        // GraphQL -> k8SResourceSetName: String (scalar)
        if (this.K8SresourceSetName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "k8SResourceSetName\n" ;
            } else {
                s += ind + "k8SResourceSetName\n" ;
            }
        }
        //      C# -> System.String? K8SsnapshotMetadata
        // GraphQL -> k8SSnapshotMetadata: String (scalar)
        if (this.K8SsnapshotMetadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "k8SSnapshotMetadata\n" ;
            } else {
                s += ind + "k8SSnapshotMetadata\n" ;
            }
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(conf.Child("baseSnapshotSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? K8SprotectionSetName
        // GraphQL -> k8SProtectionSetName: String (scalar)
        if (ec.Includes("k8SProtectionSetName",true))
        {
            if(this.K8SprotectionSetName == null) {

                this.K8SprotectionSetName = "FETCH";

            } else {


            }
        }
        else if (this.K8SprotectionSetName != null && ec.Excludes("k8SProtectionSetName",true))
        {
            this.K8SprotectionSetName = null;
        }
        //      C# -> System.String? K8SresourceSetName
        // GraphQL -> k8SResourceSetName: String (scalar)
        if (ec.Includes("k8SResourceSetName",true))
        {
            if(this.K8SresourceSetName == null) {

                this.K8SresourceSetName = "FETCH";

            } else {


            }
        }
        else if (this.K8SresourceSetName != null && ec.Excludes("k8SResourceSetName",true))
        {
            this.K8SresourceSetName = null;
        }
        //      C# -> System.String? K8SsnapshotMetadata
        // GraphQL -> k8SSnapshotMetadata: String (scalar)
        if (ec.Includes("k8SSnapshotMetadata",true))
        {
            if(this.K8SsnapshotMetadata == null) {

                this.K8SsnapshotMetadata = "FETCH";

            } else {


            }
        }
        else if (this.K8SsnapshotMetadata != null && ec.Excludes("k8SSnapshotMetadata",true))
        {
            this.K8SsnapshotMetadata = null;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (ec.Includes("baseSnapshotSummary",false))
        {
            if(this.BaseSnapshotSummary == null) {

                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            } else {

                this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("baseSnapshotSummary"));

            }
        }
        else if (this.BaseSnapshotSummary != null && ec.Excludes("baseSnapshotSummary",false))
        {
            this.BaseSnapshotSummary = null;
        }
    }


    #endregion

    } // class K8sSnapshotSummary
    
    #endregion

    public static class ListK8sSnapshotSummaryExtensions
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
            this List<K8sSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<K8sSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types