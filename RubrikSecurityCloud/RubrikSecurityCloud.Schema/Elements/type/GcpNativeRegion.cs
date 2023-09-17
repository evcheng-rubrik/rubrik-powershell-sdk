// GcpNativeRegion.cs
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
    #region GcpNativeRegion
    public class GcpNativeRegion: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        [JsonProperty("zones")]
        public List<System.String>? Zones { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeRegion";
    }

    public GcpNativeRegion Set(
        System.String? Name = null,
        List<System.String>? Zones = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Zones != null ) {
            this.Zones = Zones;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        if (this.Zones != null) {
            s += ind + "zones\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<System.String>? Zones
        // GraphQL -> zones: [String!]! (scalar)
        if (this.Zones == null && ec.Includes("zones",true))
        {
            this.Zones = new List<System.String>();
        }
    }


    #endregion

    } // class GcpNativeRegion
    
    #endregion

    public static class ListGcpNativeRegionExtensions
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
            this List<GcpNativeRegion> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeRegion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeRegion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeRegion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types