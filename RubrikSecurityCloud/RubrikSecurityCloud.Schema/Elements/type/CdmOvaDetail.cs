// CdmOvaDetail.cs
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
    #region CdmOvaDetail
    public class CdmOvaDetail: BaseType
    {
        #region members

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        [JsonProperty("ovaDownloadLink")]
        public System.String? OvaDownloadLink { get; set; }

        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        [JsonProperty("ovaSize")]
        public System.String? OvaSize { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmOvaDetail";
    }

    public CdmOvaDetail Set(
        System.String? CdmVersion = null,
        System.String? OvaDownloadLink = null,
        System.String? OvaSize = null
    ) 
    {
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( OvaDownloadLink != null ) {
            this.OvaDownloadLink = OvaDownloadLink;
        }
        if ( OvaSize != null ) {
            this.OvaSize = OvaSize;
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
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVersion\n" ;
            } else {
                s += ind + "cdmVersion\n" ;
            }
        }
        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        if (this.OvaDownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ovaDownloadLink\n" ;
            } else {
                s += ind + "ovaDownloadLink\n" ;
            }
        }
        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        if (this.OvaSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ovaSize\n" ;
            } else {
                s += ind + "ovaSize\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (ec.Includes("cdmVersion",true))
        {
            if(this.CdmVersion == null) {

                this.CdmVersion = "FETCH";

            } else {


            }
        }
        else if (this.CdmVersion != null && ec.Excludes("cdmVersion",true))
        {
            this.CdmVersion = null;
        }
        //      C# -> System.String? OvaDownloadLink
        // GraphQL -> ovaDownloadLink: String! (scalar)
        if (ec.Includes("ovaDownloadLink",true))
        {
            if(this.OvaDownloadLink == null) {

                this.OvaDownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.OvaDownloadLink != null && ec.Excludes("ovaDownloadLink",true))
        {
            this.OvaDownloadLink = null;
        }
        //      C# -> System.String? OvaSize
        // GraphQL -> ovaSize: String! (scalar)
        if (ec.Includes("ovaSize",true))
        {
            if(this.OvaSize == null) {

                this.OvaSize = "FETCH";

            } else {


            }
        }
        else if (this.OvaSize != null && ec.Excludes("ovaSize",true))
        {
            this.OvaSize = null;
        }
    }


    #endregion

    } // class CdmOvaDetail
    
    #endregion

    public static class ListCdmOvaDetailExtensions
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
            this List<CdmOvaDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmOvaDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmOvaDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmOvaDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types