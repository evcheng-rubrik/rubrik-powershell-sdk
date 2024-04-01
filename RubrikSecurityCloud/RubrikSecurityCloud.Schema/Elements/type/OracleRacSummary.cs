// OracleRacSummary.cs
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
    #region OracleRacSummary
    public class OracleRacSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        [JsonProperty("numDbs")]
        public System.Int32? NumDbs { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        [JsonProperty("shouldDistributeBackupsAutomatically")]
        public System.Boolean? ShouldDistributeBackupsAutomatically { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> List<OracleNodeOrder>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrder!]! (type)
        [JsonProperty("nodeOrder")]
        public List<OracleNodeOrder>? NodeOrder { get; set; }

        //      C# -> List<OracleNodeProperties>? Nodes
        // GraphQL -> nodes: [OracleNodeProperties!]! (type)
        [JsonProperty("nodes")]
        public List<OracleNodeProperties>? Nodes { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleRacSummary";
    }

    public OracleRacSummary Set(
        System.Boolean? HasLogConfigFromSla = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumDbs = null,
        System.Int32? NumNodes = null,
        System.String? PrimaryClusterId = null,
        System.Boolean? ShouldDistributeBackupsAutomatically = null,
        System.String? Status = null,
        List<OracleNodeOrder>? NodeOrder = null,
        List<OracleNodeProperties>? Nodes = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumDbs != null ) {
            this.NumDbs = NumDbs;
        }
        if ( NumNodes != null ) {
            this.NumNodes = NumNodes;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( ShouldDistributeBackupsAutomatically != null ) {
            this.ShouldDistributeBackupsAutomatically = ShouldDistributeBackupsAutomatically;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( NodeOrder != null ) {
            this.NodeOrder = NodeOrder;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasLogConfigFromSla\n" ;
            } else {
                s += ind + "hasLogConfigFromSla\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (this.NumDbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDbs\n" ;
            } else {
                s += ind + "numDbs\n" ;
            }
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (this.NumNodes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numNodes\n" ;
            } else {
                s += ind + "numNodes\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        if (this.ShouldDistributeBackupsAutomatically != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldDistributeBackupsAutomatically\n" ;
            } else {
                s += ind + "shouldDistributeBackupsAutomatically\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> List<OracleNodeOrder>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrder!]! (type)
        if (this.NodeOrder != null) {
            var fspec = this.NodeOrder.AsFieldSpec(conf.Child("nodeOrder"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodeOrder" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<OracleNodeProperties>? Nodes
        // GraphQL -> nodes: [OracleNodeProperties!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (ec.Includes("hasLogConfigFromSla",true))
        {
            if(this.HasLogConfigFromSla == null) {

                this.HasLogConfigFromSla = true;

            } else {


            }
        }
        else if (this.HasLogConfigFromSla != null && ec.Excludes("hasLogConfigFromSla",true))
        {
            this.HasLogConfigFromSla = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? NumDbs
        // GraphQL -> numDbs: Int! (scalar)
        if (ec.Includes("numDbs",true))
        {
            if(this.NumDbs == null) {

                this.NumDbs = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDbs != null && ec.Excludes("numDbs",true))
        {
            this.NumDbs = null;
        }
        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        if (ec.Includes("numNodes",true))
        {
            if(this.NumNodes == null) {

                this.NumNodes = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumNodes != null && ec.Excludes("numNodes",true))
        {
            this.NumNodes = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        if (ec.Includes("shouldDistributeBackupsAutomatically",true))
        {
            if(this.ShouldDistributeBackupsAutomatically == null) {

                this.ShouldDistributeBackupsAutomatically = true;

            } else {


            }
        }
        else if (this.ShouldDistributeBackupsAutomatically != null && ec.Excludes("shouldDistributeBackupsAutomatically",true))
        {
            this.ShouldDistributeBackupsAutomatically = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> List<OracleNodeOrder>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrder!]! (type)
        if (ec.Includes("nodeOrder",false))
        {
            if(this.NodeOrder == null) {

                this.NodeOrder = new List<OracleNodeOrder>();
                this.NodeOrder.ApplyExploratoryFieldSpec(ec.NewChild("nodeOrder"));

            } else {

                this.NodeOrder.ApplyExploratoryFieldSpec(ec.NewChild("nodeOrder"));

            }
        }
        else if (this.NodeOrder != null && ec.Excludes("nodeOrder",false))
        {
            this.NodeOrder = null;
        }
        //      C# -> List<OracleNodeProperties>? Nodes
        // GraphQL -> nodes: [OracleNodeProperties!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<OracleNodeProperties>();
                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            } else {

                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            }
        }
        else if (this.Nodes != null && ec.Excludes("nodes",false))
        {
            this.Nodes = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class OracleRacSummary
    
    #endregion

    public static class ListOracleRacSummaryExtensions
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
            this List<OracleRacSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleRacSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleRacSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleRacSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleRacSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types