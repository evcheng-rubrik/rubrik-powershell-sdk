// FilterPreviewResultListResponse.cs
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
    #region FilterPreviewResultListResponse
    public class FilterPreviewResultListResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }

        //      C# -> List<FilterPreviewResult>? Data
        // GraphQL -> data: [FilterPreviewResult!]! (type)
        [JsonProperty("data")]
        public List<FilterPreviewResult>? Data { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilterPreviewResultListResponse";
    }

    public FilterPreviewResultListResponse Set(
        System.Boolean? HasMore = null,
        System.Int32? Total = null,
        List<FilterPreviewResult>? Data = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore != null) {
            s += ind + "hasMore\n" ;
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total != null) {
            s += ind + "total\n" ;
        }
        //      C# -> List<FilterPreviewResult>? Data
        // GraphQL -> data: [FilterPreviewResult!]! (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "data {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore == null && ec.Includes("hasMore",true))
        {
            this.HasMore = true;
        }
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int (scalar)
        if (this.Total == null && ec.Includes("total",true))
        {
            this.Total = Int32.MinValue;
        }
        //      C# -> List<FilterPreviewResult>? Data
        // GraphQL -> data: [FilterPreviewResult!]! (type)
        if (this.Data == null && ec.Includes("data",false))
        {
            this.Data = new List<FilterPreviewResult>();
            this.Data.ApplyExploratoryFieldSpec(ec.NewChild("data"));
        }
    }


    #endregion

    } // class FilterPreviewResultListResponse
    
    #endregion

    public static class ListFilterPreviewResultListResponseExtensions
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
            this List<FilterPreviewResultListResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilterPreviewResultListResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilterPreviewResultListResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilterPreviewResultListResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types