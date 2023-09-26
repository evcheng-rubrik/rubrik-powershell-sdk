// FilesetArraySpec.cs
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
    #region FilesetArraySpec
    public class FilesetArraySpec: BaseType
    {
        #region members

        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        [JsonProperty("proxyHostId")]
        public System.String? ProxyHostId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetArraySpec";
    }

    public FilesetArraySpec Set(
        System.String? ProxyHostId = null
    ) 
    {
        if ( ProxyHostId != null ) {
            this.ProxyHostId = ProxyHostId;
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
        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        if (this.ProxyHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxyHostId\n" ;
            } else {
                s += ind + "proxyHostId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        if (ec.Includes("proxyHostId",true))
        {
            if(this.ProxyHostId == null) {

                this.ProxyHostId = "FETCH";

            } else {


            }
        }
        else if (this.ProxyHostId != null && ec.Excludes("proxyHostId",true))
        {
            this.ProxyHostId = null;
        }
    }


    #endregion

    } // class FilesetArraySpec
    
    #endregion

    public static class ListFilesetArraySpecExtensions
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
            this List<FilesetArraySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetArraySpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetArraySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetArraySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types