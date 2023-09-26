// ManagedVolumeStats.cs
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
    #region ManagedVolumeStats
    public class ManagedVolumeStats: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        [JsonProperty("provisionedSize")]
        public System.Int64? ProvisionedSize { get; set; }

        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        [JsonProperty("usedSize")]
        public System.Int64? UsedSize { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeStats";
    }

    public ManagedVolumeStats Set(
        System.Int32? Count = null,
        System.Int64? ProvisionedSize = null,
        System.Int64? UsedSize = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( ProvisionedSize != null ) {
            this.ProvisionedSize = ProvisionedSize;
        }
        if ( UsedSize != null ) {
            this.UsedSize = UsedSize;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        if (this.ProvisionedSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisionedSize\n" ;
            } else {
                s += ind + "provisionedSize\n" ;
            }
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (this.UsedSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedSize\n" ;
            } else {
                s += ind + "usedSize\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        if (ec.Includes("provisionedSize",true))
        {
            if(this.ProvisionedSize == null) {

                this.ProvisionedSize = new System.Int64();

            } else {


            }
        }
        else if (this.ProvisionedSize != null && ec.Excludes("provisionedSize",true))
        {
            this.ProvisionedSize = null;
        }
        //      C# -> System.Int64? UsedSize
        // GraphQL -> usedSize: Long! (scalar)
        if (ec.Includes("usedSize",true))
        {
            if(this.UsedSize == null) {

                this.UsedSize = new System.Int64();

            } else {


            }
        }
        else if (this.UsedSize != null && ec.Excludes("usedSize",true))
        {
            this.UsedSize = null;
        }
    }


    #endregion

    } // class ManagedVolumeStats
    
    #endregion

    public static class ListManagedVolumeStatsExtensions
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
            this List<ManagedVolumeStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types