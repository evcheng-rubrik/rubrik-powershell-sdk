// VappTemplateExportOptionsUnion.cs
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
    #region VappTemplateExportOptionsUnion
    public class VappTemplateExportOptionsUnion: BaseType
    {
        #region members

        //      C# -> VappTemplateExportOptions? AdvancedExportOptions
        // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
        [JsonProperty("advancedExportOptions")]
        public VappTemplateExportOptions? AdvancedExportOptions { get; set; }

        //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
        // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
        [JsonProperty("defaultCatalogExportOptions")]
        public VappTemplateExportOptions? DefaultCatalogExportOptions { get; set; }

        //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
        // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
        [JsonProperty("originalVdcExportOptions")]
        public VappTemplateExportOptions? OriginalVdcExportOptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VappTemplateExportOptionsUnion";
    }

    public VappTemplateExportOptionsUnion Set(
        VappTemplateExportOptions? AdvancedExportOptions = null,
        VappTemplateExportOptions? DefaultCatalogExportOptions = null,
        VappTemplateExportOptions? OriginalVdcExportOptions = null
    ) 
    {
        if ( AdvancedExportOptions != null ) {
            this.AdvancedExportOptions = AdvancedExportOptions;
        }
        if ( DefaultCatalogExportOptions != null ) {
            this.DefaultCatalogExportOptions = DefaultCatalogExportOptions;
        }
        if ( OriginalVdcExportOptions != null ) {
            this.OriginalVdcExportOptions = OriginalVdcExportOptions;
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
        //      C# -> VappTemplateExportOptions? AdvancedExportOptions
        // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
        if (this.AdvancedExportOptions != null) {
            var fspec = this.AdvancedExportOptions.AsFieldSpec(conf.Child("advancedExportOptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "advancedExportOptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
        // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
        if (this.DefaultCatalogExportOptions != null) {
            var fspec = this.DefaultCatalogExportOptions.AsFieldSpec(conf.Child("defaultCatalogExportOptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "defaultCatalogExportOptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
        // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
        if (this.OriginalVdcExportOptions != null) {
            var fspec = this.OriginalVdcExportOptions.AsFieldSpec(conf.Child("originalVdcExportOptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "originalVdcExportOptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VappTemplateExportOptions? AdvancedExportOptions
        // GraphQL -> advancedExportOptions: VappTemplateExportOptions (type)
        if (ec.Includes("advancedExportOptions",false))
        {
            if(this.AdvancedExportOptions == null) {

                this.AdvancedExportOptions = new VappTemplateExportOptions();
                this.AdvancedExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("advancedExportOptions"));

            } else {

                this.AdvancedExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("advancedExportOptions"));

            }
        }
        else if (this.AdvancedExportOptions != null && ec.Excludes("advancedExportOptions",false))
        {
            this.AdvancedExportOptions = null;
        }
        //      C# -> VappTemplateExportOptions? DefaultCatalogExportOptions
        // GraphQL -> defaultCatalogExportOptions: VappTemplateExportOptions (type)
        if (ec.Includes("defaultCatalogExportOptions",false))
        {
            if(this.DefaultCatalogExportOptions == null) {

                this.DefaultCatalogExportOptions = new VappTemplateExportOptions();
                this.DefaultCatalogExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("defaultCatalogExportOptions"));

            } else {

                this.DefaultCatalogExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("defaultCatalogExportOptions"));

            }
        }
        else if (this.DefaultCatalogExportOptions != null && ec.Excludes("defaultCatalogExportOptions",false))
        {
            this.DefaultCatalogExportOptions = null;
        }
        //      C# -> VappTemplateExportOptions? OriginalVdcExportOptions
        // GraphQL -> originalVdcExportOptions: VappTemplateExportOptions (type)
        if (ec.Includes("originalVdcExportOptions",false))
        {
            if(this.OriginalVdcExportOptions == null) {

                this.OriginalVdcExportOptions = new VappTemplateExportOptions();
                this.OriginalVdcExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("originalVdcExportOptions"));

            } else {

                this.OriginalVdcExportOptions.ApplyExploratoryFieldSpec(ec.NewChild("originalVdcExportOptions"));

            }
        }
        else if (this.OriginalVdcExportOptions != null && ec.Excludes("originalVdcExportOptions",false))
        {
            this.OriginalVdcExportOptions = null;
        }
    }


    #endregion

    } // class VappTemplateExportOptionsUnion
    
    #endregion

    public static class ListVappTemplateExportOptionsUnionExtensions
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
            this List<VappTemplateExportOptionsUnion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VappTemplateExportOptionsUnion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VappTemplateExportOptionsUnion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VappTemplateExportOptionsUnion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VappTemplateExportOptionsUnion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types