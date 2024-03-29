// HypervConfigurationFileInfo.cs
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
    #region HypervConfigurationFileInfo
    public class HypervConfigurationFileInfo: BaseType
    {
        #region members

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.String? FileType
        // GraphQL -> fileType: String! (scalar)
        [JsonProperty("fileType")]
        public System.String? FileType { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervConfigurationFileInfo";
    }

    public HypervConfigurationFileInfo Set(
        System.String? FileName = null,
        System.String? FileType = null,
        System.Int64? SizeInBytes = null
    ) 
    {
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FileType != null ) {
            this.FileType = FileType;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
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
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.String? FileType
        // GraphQL -> fileType: String! (scalar)
        if (this.FileType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileType\n" ;
            } else {
                s += ind + "fileType\n" ;
            }
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (this.SizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInBytes\n" ;
            } else {
                s += ind + "sizeInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
        //      C# -> System.String? FileType
        // GraphQL -> fileType: String! (scalar)
        if (ec.Includes("fileType",true))
        {
            if(this.FileType == null) {

                this.FileType = "FETCH";

            } else {


            }
        }
        else if (this.FileType != null && ec.Excludes("fileType",true))
        {
            this.FileType = null;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long! (scalar)
        if (ec.Includes("sizeInBytes",true))
        {
            if(this.SizeInBytes == null) {

                this.SizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SizeInBytes != null && ec.Excludes("sizeInBytes",true))
        {
            this.SizeInBytes = null;
        }
    }


    #endregion

    } // class HypervConfigurationFileInfo
    
    #endregion

    public static class ListHypervConfigurationFileInfoExtensions
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
            this List<HypervConfigurationFileInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<HypervConfigurationFileInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervConfigurationFileInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervConfigurationFileInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervConfigurationFileInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types