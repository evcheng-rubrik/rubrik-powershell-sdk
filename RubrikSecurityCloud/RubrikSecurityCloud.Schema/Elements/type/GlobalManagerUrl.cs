// GlobalManagerUrl.cs
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
    #region GlobalManagerUrl
    public class GlobalManagerUrl: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsReachable
        // GraphQL -> isReachable: Boolean! (scalar)
        [JsonProperty("isReachable")]
        public System.Boolean? IsReachable { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalManagerUrl";
    }

    public GlobalManagerUrl Set(
        System.Boolean? IsReachable = null,
        System.String? Url = null
    ) 
    {
        if ( IsReachable != null ) {
            this.IsReachable = IsReachable;
        }
        if ( Url != null ) {
            this.Url = Url;
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
        //      C# -> System.Boolean? IsReachable
        // GraphQL -> isReachable: Boolean! (scalar)
        if (this.IsReachable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReachable\n" ;
            } else {
                s += ind + "isReachable\n" ;
            }
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url != null) {
            if (conf.Flat) {
                s += conf.Prefix + "url\n" ;
            } else {
                s += ind + "url\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsReachable
        // GraphQL -> isReachable: Boolean! (scalar)
        if (ec.Includes("isReachable",true))
        {
            if(this.IsReachable == null) {

                this.IsReachable = true;

            } else {


            }
        }
        else if (this.IsReachable != null && ec.Excludes("isReachable",true))
        {
            this.IsReachable = null;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (ec.Includes("url",true))
        {
            if(this.Url == null) {

                this.Url = "FETCH";

            } else {


            }
        }
        else if (this.Url != null && ec.Excludes("url",true))
        {
            this.Url = null;
        }
    }


    #endregion

    } // class GlobalManagerUrl
    
    #endregion

    public static class ListGlobalManagerUrlExtensions
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
            this List<GlobalManagerUrl> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalManagerUrl> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalManagerUrl());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalManagerUrl> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types