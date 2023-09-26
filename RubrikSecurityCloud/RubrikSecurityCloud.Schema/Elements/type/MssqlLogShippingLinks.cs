// MssqlLogShippingLinks.cs
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
    #region MssqlLogShippingLinks
    public class MssqlLogShippingLinks: BaseType
    {
        #region members

        //      C# -> Link? PrimaryDatabase
        // GraphQL -> primaryDatabase: Link (type)
        [JsonProperty("primaryDatabase")]
        public Link? PrimaryDatabase { get; set; }

        //      C# -> Link? SecondaryDatabase
        // GraphQL -> secondaryDatabase: Link (type)
        [JsonProperty("secondaryDatabase")]
        public Link? SecondaryDatabase { get; set; }

        //      C# -> Link? SecondaryInstance
        // GraphQL -> secondaryInstance: Link (type)
        [JsonProperty("secondaryInstance")]
        public Link? SecondaryInstance { get; set; }

        //      C# -> Link? SeedRequest
        // GraphQL -> seedRequest: Link (type)
        [JsonProperty("seedRequest")]
        public Link? SeedRequest { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlLogShippingLinks";
    }

    public MssqlLogShippingLinks Set(
        Link? PrimaryDatabase = null,
        Link? SecondaryDatabase = null,
        Link? SecondaryInstance = null,
        Link? SeedRequest = null
    ) 
    {
        if ( PrimaryDatabase != null ) {
            this.PrimaryDatabase = PrimaryDatabase;
        }
        if ( SecondaryDatabase != null ) {
            this.SecondaryDatabase = SecondaryDatabase;
        }
        if ( SecondaryInstance != null ) {
            this.SecondaryInstance = SecondaryInstance;
        }
        if ( SeedRequest != null ) {
            this.SeedRequest = SeedRequest;
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
        //      C# -> Link? PrimaryDatabase
        // GraphQL -> primaryDatabase: Link (type)
        if (this.PrimaryDatabase != null) {
            var fspec = this.PrimaryDatabase.AsFieldSpec(conf.Child("primaryDatabase"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryDatabase {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Link? SecondaryDatabase
        // GraphQL -> secondaryDatabase: Link (type)
        if (this.SecondaryDatabase != null) {
            var fspec = this.SecondaryDatabase.AsFieldSpec(conf.Child("secondaryDatabase"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryDatabase {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Link? SecondaryInstance
        // GraphQL -> secondaryInstance: Link (type)
        if (this.SecondaryInstance != null) {
            var fspec = this.SecondaryInstance.AsFieldSpec(conf.Child("secondaryInstance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryInstance {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Link? SeedRequest
        // GraphQL -> seedRequest: Link (type)
        if (this.SeedRequest != null) {
            var fspec = this.SeedRequest.AsFieldSpec(conf.Child("seedRequest"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "seedRequest {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Link? PrimaryDatabase
        // GraphQL -> primaryDatabase: Link (type)
        if (ec.Includes("primaryDatabase",false))
        {
            if(this.PrimaryDatabase == null) {

                this.PrimaryDatabase = new Link();
                this.PrimaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("primaryDatabase"));

            } else {

                this.PrimaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("primaryDatabase"));

            }
        }
        else if (this.PrimaryDatabase != null && ec.Excludes("primaryDatabase",false))
        {
            this.PrimaryDatabase = null;
        }
        //      C# -> Link? SecondaryDatabase
        // GraphQL -> secondaryDatabase: Link (type)
        if (ec.Includes("secondaryDatabase",false))
        {
            if(this.SecondaryDatabase == null) {

                this.SecondaryDatabase = new Link();
                this.SecondaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("secondaryDatabase"));

            } else {

                this.SecondaryDatabase.ApplyExploratoryFieldSpec(ec.NewChild("secondaryDatabase"));

            }
        }
        else if (this.SecondaryDatabase != null && ec.Excludes("secondaryDatabase",false))
        {
            this.SecondaryDatabase = null;
        }
        //      C# -> Link? SecondaryInstance
        // GraphQL -> secondaryInstance: Link (type)
        if (ec.Includes("secondaryInstance",false))
        {
            if(this.SecondaryInstance == null) {

                this.SecondaryInstance = new Link();
                this.SecondaryInstance.ApplyExploratoryFieldSpec(ec.NewChild("secondaryInstance"));

            } else {

                this.SecondaryInstance.ApplyExploratoryFieldSpec(ec.NewChild("secondaryInstance"));

            }
        }
        else if (this.SecondaryInstance != null && ec.Excludes("secondaryInstance",false))
        {
            this.SecondaryInstance = null;
        }
        //      C# -> Link? SeedRequest
        // GraphQL -> seedRequest: Link (type)
        if (ec.Includes("seedRequest",false))
        {
            if(this.SeedRequest == null) {

                this.SeedRequest = new Link();
                this.SeedRequest.ApplyExploratoryFieldSpec(ec.NewChild("seedRequest"));

            } else {

                this.SeedRequest.ApplyExploratoryFieldSpec(ec.NewChild("seedRequest"));

            }
        }
        else if (this.SeedRequest != null && ec.Excludes("seedRequest",false))
        {
            this.SeedRequest = null;
        }
    }


    #endregion

    } // class MssqlLogShippingLinks
    
    #endregion

    public static class ListMssqlLogShippingLinksExtensions
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
            this List<MssqlLogShippingLinks> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingLinks> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingLinks());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlLogShippingLinks> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types