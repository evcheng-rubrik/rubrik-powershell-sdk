// PolarisInventorySubHierarchyRoot.cs
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
    #region PolarisInventorySubHierarchyRoot
    public class PolarisInventorySubHierarchyRoot: BaseType
    {
        #region members

        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("rootEnum")]
        public InventorySubHierarchyRootEnum? RootEnum { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("childConnection")]
        public PolarisHierarchyObjectConnection? ChildConnection { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public PolarisHierarchyObjectConnection? DescendantConnection { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("topLevelDescendantConnection")]
        public PolarisHierarchyObjectConnection? TopLevelDescendantConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisInventorySubHierarchyRoot";
    }

    public PolarisInventorySubHierarchyRoot Set(
        InventorySubHierarchyRootEnum? RootEnum = null,
        PolarisHierarchyObjectConnection? ChildConnection = null,
        PolarisHierarchyObjectConnection? DescendantConnection = null,
        PolarisHierarchyObjectConnection? TopLevelDescendantConnection = null
    ) 
    {
        if ( RootEnum != null ) {
            this.RootEnum = RootEnum;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( TopLevelDescendantConnection != null ) {
            this.TopLevelDescendantConnection = TopLevelDescendantConnection;
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
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootEnum\n" ;
            } else {
                s += ind + "rootEnum\n" ;
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(conf.Child("childConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(conf.Child("descendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "descendantConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection != null) {
            var fspec = this.TopLevelDescendantConnection.AsFieldSpec(conf.Child("topLevelDescendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "topLevelDescendantConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (ec.Includes("rootEnum",true))
        {
            if(this.RootEnum == null) {

                this.RootEnum = new InventorySubHierarchyRootEnum();

            } else {


            }
        }
        else if (this.RootEnum != null && ec.Excludes("rootEnum",true))
        {
            this.RootEnum = null;
        }
        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        if (ec.Includes("childConnection",false))
        {
            if(this.ChildConnection == null) {

                this.ChildConnection = new PolarisHierarchyObjectConnection();
                this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));

            } else {

                this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));

            }
        }
        else if (this.ChildConnection != null && ec.Excludes("childConnection",false))
        {
            this.ChildConnection = null;
        }
        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        if (ec.Includes("descendantConnection",false))
        {
            if(this.DescendantConnection == null) {

                this.DescendantConnection = new PolarisHierarchyObjectConnection();
                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            } else {

                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            }
        }
        else if (this.DescendantConnection != null && ec.Excludes("descendantConnection",false))
        {
            this.DescendantConnection = null;
        }
        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        if (ec.Includes("topLevelDescendantConnection",false))
        {
            if(this.TopLevelDescendantConnection == null) {

                this.TopLevelDescendantConnection = new PolarisHierarchyObjectConnection();
                this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("topLevelDescendantConnection"));

            } else {

                this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("topLevelDescendantConnection"));

            }
        }
        else if (this.TopLevelDescendantConnection != null && ec.Excludes("topLevelDescendantConnection",false))
        {
            this.TopLevelDescendantConnection = null;
        }
    }


    #endregion

    } // class PolarisInventorySubHierarchyRoot
    
    #endregion

    public static class ListPolarisInventorySubHierarchyRootExtensions
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
            this List<PolarisInventorySubHierarchyRoot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisInventorySubHierarchyRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisInventorySubHierarchyRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisInventorySubHierarchyRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types