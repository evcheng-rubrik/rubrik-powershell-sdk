// ClusterDnsReply.cs
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
    #region ClusterDnsReply
    public class ClusterDnsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        [JsonProperty("domains")]
        public List<System.String>? Domains { get; set; }

        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        [JsonProperty("servers")]
        public List<System.String>? Servers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterDnsReply";
    }

    public ClusterDnsReply Set(
        List<System.String>? Domains = null,
        List<System.String>? Servers = null
    ) 
    {
        if ( Domains != null ) {
            this.Domains = Domains;
        }
        if ( Servers != null ) {
            this.Servers = Servers;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        if (this.Domains != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domains\n" ;
            } else {
                s += ind + "domains\n" ;
            }
        }
        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        if (this.Servers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "servers\n" ;
            } else {
                s += ind + "servers\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        if (ec.Includes("domains",true))
        {
            if(this.Domains == null) {

                this.Domains = new List<System.String>();

            } else {


            }
        }
        else if (this.Domains != null && ec.Excludes("domains",true))
        {
            this.Domains = null;
        }
        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        if (ec.Includes("servers",true))
        {
            if(this.Servers == null) {

                this.Servers = new List<System.String>();

            } else {


            }
        }
        else if (this.Servers != null && ec.Excludes("servers",true))
        {
            this.Servers = null;
        }
    }


    #endregion

    } // class ClusterDnsReply
    
    #endregion

    public static class ListClusterDnsReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterDnsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterDnsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterDnsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterDnsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterDnsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types