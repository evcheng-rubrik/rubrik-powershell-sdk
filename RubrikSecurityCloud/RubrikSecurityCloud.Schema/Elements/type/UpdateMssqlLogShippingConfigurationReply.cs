// UpdateMssqlLogShippingConfigurationReply.cs
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
    #region UpdateMssqlLogShippingConfigurationReply
    public class UpdateMssqlLogShippingConfigurationReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
        // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
        [JsonProperty("shouldDisconnectStandbyUsers")]
        public System.Boolean? ShouldDisconnectStandbyUsers { get; set; }

        //      C# -> MssqlLogShippingLinks? Links
        // GraphQL -> links: MssqlLogShippingLinks (type)
        [JsonProperty("links")]
        public MssqlLogShippingLinks? Links { get; set; }

        //      C# -> MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2
        // GraphQL -> mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2 (type)
        [JsonProperty("mssqlLogShippingSummaryV2")]
        public MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateMssqlLogShippingConfigurationReply";
    }

    public UpdateMssqlLogShippingConfigurationReply Set(
        System.Boolean? ShouldDisconnectStandbyUsers = null,
        MssqlLogShippingLinks? Links = null,
        MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2 = null
    ) 
    {
        if ( ShouldDisconnectStandbyUsers != null ) {
            this.ShouldDisconnectStandbyUsers = ShouldDisconnectStandbyUsers;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( MssqlLogShippingSummaryV2 != null ) {
            this.MssqlLogShippingSummaryV2 = MssqlLogShippingSummaryV2;
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
        //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
        // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
        if (this.ShouldDisconnectStandbyUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldDisconnectStandbyUsers\n" ;
            } else {
                s += ind + "shouldDisconnectStandbyUsers\n" ;
            }
        }
        //      C# -> MssqlLogShippingLinks? Links
        // GraphQL -> links: MssqlLogShippingLinks (type)
        if (this.Links != null) {
            var fspec = this.Links.AsFieldSpec(conf.Child("links"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "links {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2
        // GraphQL -> mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2 (type)
        if (this.MssqlLogShippingSummaryV2 != null) {
            var fspec = this.MssqlLogShippingSummaryV2.AsFieldSpec(conf.Child("mssqlLogShippingSummaryV2"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlLogShippingSummaryV2 {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
        // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
        if (ec.Includes("shouldDisconnectStandbyUsers",true))
        {
            if(this.ShouldDisconnectStandbyUsers == null) {

                this.ShouldDisconnectStandbyUsers = true;

            } else {


            }
        }
        else if (this.ShouldDisconnectStandbyUsers != null && ec.Excludes("shouldDisconnectStandbyUsers",true))
        {
            this.ShouldDisconnectStandbyUsers = null;
        }
        //      C# -> MssqlLogShippingLinks? Links
        // GraphQL -> links: MssqlLogShippingLinks (type)
        if (ec.Includes("links",false))
        {
            if(this.Links == null) {

                this.Links = new MssqlLogShippingLinks();
                this.Links.ApplyExploratoryFieldSpec(ec.NewChild("links"));

            } else {

                this.Links.ApplyExploratoryFieldSpec(ec.NewChild("links"));

            }
        }
        else if (this.Links != null && ec.Excludes("links",false))
        {
            this.Links = null;
        }
        //      C# -> MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2
        // GraphQL -> mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2 (type)
        if (ec.Includes("mssqlLogShippingSummaryV2",false))
        {
            if(this.MssqlLogShippingSummaryV2 == null) {

                this.MssqlLogShippingSummaryV2 = new MssqlLogShippingSummaryV2();
                this.MssqlLogShippingSummaryV2.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummaryV2"));

            } else {

                this.MssqlLogShippingSummaryV2.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummaryV2"));

            }
        }
        else if (this.MssqlLogShippingSummaryV2 != null && ec.Excludes("mssqlLogShippingSummaryV2",false))
        {
            this.MssqlLogShippingSummaryV2 = null;
        }
    }


    #endregion

    } // class UpdateMssqlLogShippingConfigurationReply
    
    #endregion

    public static class ListUpdateMssqlLogShippingConfigurationReplyExtensions
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
            this List<UpdateMssqlLogShippingConfigurationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateMssqlLogShippingConfigurationReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateMssqlLogShippingConfigurationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateMssqlLogShippingConfigurationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types