// RubrikSyncStatus.cs
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
    #region RubrikSyncStatus
    public class RubrikSyncStatus: BaseType
    {
        #region members

        //      C# -> DateTime? ClusterSyncLastSuccessTime
        // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("clusterSyncLastSuccessTime")]
        public DateTime? ClusterSyncLastSuccessTime { get; set; }

        //      C# -> DateTime? EventsSyncLastSuccessTime
        // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("eventsSyncLastSuccessTime")]
        public DateTime? EventsSyncLastSuccessTime { get; set; }

        //      C# -> System.Boolean? IsClusterSyncHealthy
        // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
        [JsonProperty("isClusterSyncHealthy")]
        public System.Boolean? IsClusterSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsEventsSyncHealthy
        // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
        [JsonProperty("isEventsSyncHealthy")]
        public System.Boolean? IsEventsSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
        // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
        [JsonProperty("isJobMonitoringSyncHealthy")]
        public System.Boolean? IsJobMonitoringSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsMetadataSyncHealthy
        // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
        [JsonProperty("isMetadataSyncHealthy")]
        public System.Boolean? IsMetadataSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsReportsSyncHealthy
        // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
        [JsonProperty("isReportsSyncHealthy")]
        public System.Boolean? IsReportsSyncHealthy { get; set; }

        //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
        // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("jobMonitoringSyncLastSuccessTime")]
        public DateTime? JobMonitoringSyncLastSuccessTime { get; set; }

        //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
        // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("objectMetadataSyncLastSuccessTime")]
        public DateTime? ObjectMetadataSyncLastSuccessTime { get; set; }

        //      C# -> DateTime? ReportsSyncLastSuccessTime
        // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("reportsSyncLastSuccessTime")]
        public DateTime? ReportsSyncLastSuccessTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RubrikSyncStatus";
    }

    public RubrikSyncStatus Set(
        DateTime? ClusterSyncLastSuccessTime = null,
        DateTime? EventsSyncLastSuccessTime = null,
        System.Boolean? IsClusterSyncHealthy = null,
        System.Boolean? IsEventsSyncHealthy = null,
        System.Boolean? IsJobMonitoringSyncHealthy = null,
        System.Boolean? IsMetadataSyncHealthy = null,
        System.Boolean? IsReportsSyncHealthy = null,
        DateTime? JobMonitoringSyncLastSuccessTime = null,
        DateTime? ObjectMetadataSyncLastSuccessTime = null,
        DateTime? ReportsSyncLastSuccessTime = null
    ) 
    {
        if ( ClusterSyncLastSuccessTime != null ) {
            this.ClusterSyncLastSuccessTime = ClusterSyncLastSuccessTime;
        }
        if ( EventsSyncLastSuccessTime != null ) {
            this.EventsSyncLastSuccessTime = EventsSyncLastSuccessTime;
        }
        if ( IsClusterSyncHealthy != null ) {
            this.IsClusterSyncHealthy = IsClusterSyncHealthy;
        }
        if ( IsEventsSyncHealthy != null ) {
            this.IsEventsSyncHealthy = IsEventsSyncHealthy;
        }
        if ( IsJobMonitoringSyncHealthy != null ) {
            this.IsJobMonitoringSyncHealthy = IsJobMonitoringSyncHealthy;
        }
        if ( IsMetadataSyncHealthy != null ) {
            this.IsMetadataSyncHealthy = IsMetadataSyncHealthy;
        }
        if ( IsReportsSyncHealthy != null ) {
            this.IsReportsSyncHealthy = IsReportsSyncHealthy;
        }
        if ( JobMonitoringSyncLastSuccessTime != null ) {
            this.JobMonitoringSyncLastSuccessTime = JobMonitoringSyncLastSuccessTime;
        }
        if ( ObjectMetadataSyncLastSuccessTime != null ) {
            this.ObjectMetadataSyncLastSuccessTime = ObjectMetadataSyncLastSuccessTime;
        }
        if ( ReportsSyncLastSuccessTime != null ) {
            this.ReportsSyncLastSuccessTime = ReportsSyncLastSuccessTime;
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
        //      C# -> DateTime? ClusterSyncLastSuccessTime
        // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
        if (this.ClusterSyncLastSuccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterSyncLastSuccessTime\n" ;
            } else {
                s += ind + "clusterSyncLastSuccessTime\n" ;
            }
        }
        //      C# -> DateTime? EventsSyncLastSuccessTime
        // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
        if (this.EventsSyncLastSuccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventsSyncLastSuccessTime\n" ;
            } else {
                s += ind + "eventsSyncLastSuccessTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsClusterSyncHealthy
        // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
        if (this.IsClusterSyncHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isClusterSyncHealthy\n" ;
            } else {
                s += ind + "isClusterSyncHealthy\n" ;
            }
        }
        //      C# -> System.Boolean? IsEventsSyncHealthy
        // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
        if (this.IsEventsSyncHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEventsSyncHealthy\n" ;
            } else {
                s += ind + "isEventsSyncHealthy\n" ;
            }
        }
        //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
        // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
        if (this.IsJobMonitoringSyncHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isJobMonitoringSyncHealthy\n" ;
            } else {
                s += ind + "isJobMonitoringSyncHealthy\n" ;
            }
        }
        //      C# -> System.Boolean? IsMetadataSyncHealthy
        // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
        if (this.IsMetadataSyncHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMetadataSyncHealthy\n" ;
            } else {
                s += ind + "isMetadataSyncHealthy\n" ;
            }
        }
        //      C# -> System.Boolean? IsReportsSyncHealthy
        // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
        if (this.IsReportsSyncHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReportsSyncHealthy\n" ;
            } else {
                s += ind + "isReportsSyncHealthy\n" ;
            }
        }
        //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
        // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
        if (this.JobMonitoringSyncLastSuccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobMonitoringSyncLastSuccessTime\n" ;
            } else {
                s += ind + "jobMonitoringSyncLastSuccessTime\n" ;
            }
        }
        //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
        // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
        if (this.ObjectMetadataSyncLastSuccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectMetadataSyncLastSuccessTime\n" ;
            } else {
                s += ind + "objectMetadataSyncLastSuccessTime\n" ;
            }
        }
        //      C# -> DateTime? ReportsSyncLastSuccessTime
        // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
        if (this.ReportsSyncLastSuccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportsSyncLastSuccessTime\n" ;
            } else {
                s += ind + "reportsSyncLastSuccessTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? ClusterSyncLastSuccessTime
        // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
        if (ec.Includes("clusterSyncLastSuccessTime",true))
        {
            if(this.ClusterSyncLastSuccessTime == null) {

                this.ClusterSyncLastSuccessTime = new DateTime();

            } else {


            }
        }
        else if (this.ClusterSyncLastSuccessTime != null && ec.Excludes("clusterSyncLastSuccessTime",true))
        {
            this.ClusterSyncLastSuccessTime = null;
        }
        //      C# -> DateTime? EventsSyncLastSuccessTime
        // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
        if (ec.Includes("eventsSyncLastSuccessTime",true))
        {
            if(this.EventsSyncLastSuccessTime == null) {

                this.EventsSyncLastSuccessTime = new DateTime();

            } else {


            }
        }
        else if (this.EventsSyncLastSuccessTime != null && ec.Excludes("eventsSyncLastSuccessTime",true))
        {
            this.EventsSyncLastSuccessTime = null;
        }
        //      C# -> System.Boolean? IsClusterSyncHealthy
        // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
        if (ec.Includes("isClusterSyncHealthy",true))
        {
            if(this.IsClusterSyncHealthy == null) {

                this.IsClusterSyncHealthy = true;

            } else {


            }
        }
        else if (this.IsClusterSyncHealthy != null && ec.Excludes("isClusterSyncHealthy",true))
        {
            this.IsClusterSyncHealthy = null;
        }
        //      C# -> System.Boolean? IsEventsSyncHealthy
        // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
        if (ec.Includes("isEventsSyncHealthy",true))
        {
            if(this.IsEventsSyncHealthy == null) {

                this.IsEventsSyncHealthy = true;

            } else {


            }
        }
        else if (this.IsEventsSyncHealthy != null && ec.Excludes("isEventsSyncHealthy",true))
        {
            this.IsEventsSyncHealthy = null;
        }
        //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
        // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
        if (ec.Includes("isJobMonitoringSyncHealthy",true))
        {
            if(this.IsJobMonitoringSyncHealthy == null) {

                this.IsJobMonitoringSyncHealthy = true;

            } else {


            }
        }
        else if (this.IsJobMonitoringSyncHealthy != null && ec.Excludes("isJobMonitoringSyncHealthy",true))
        {
            this.IsJobMonitoringSyncHealthy = null;
        }
        //      C# -> System.Boolean? IsMetadataSyncHealthy
        // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
        if (ec.Includes("isMetadataSyncHealthy",true))
        {
            if(this.IsMetadataSyncHealthy == null) {

                this.IsMetadataSyncHealthy = true;

            } else {


            }
        }
        else if (this.IsMetadataSyncHealthy != null && ec.Excludes("isMetadataSyncHealthy",true))
        {
            this.IsMetadataSyncHealthy = null;
        }
        //      C# -> System.Boolean? IsReportsSyncHealthy
        // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
        if (ec.Includes("isReportsSyncHealthy",true))
        {
            if(this.IsReportsSyncHealthy == null) {

                this.IsReportsSyncHealthy = true;

            } else {


            }
        }
        else if (this.IsReportsSyncHealthy != null && ec.Excludes("isReportsSyncHealthy",true))
        {
            this.IsReportsSyncHealthy = null;
        }
        //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
        // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
        if (ec.Includes("jobMonitoringSyncLastSuccessTime",true))
        {
            if(this.JobMonitoringSyncLastSuccessTime == null) {

                this.JobMonitoringSyncLastSuccessTime = new DateTime();

            } else {


            }
        }
        else if (this.JobMonitoringSyncLastSuccessTime != null && ec.Excludes("jobMonitoringSyncLastSuccessTime",true))
        {
            this.JobMonitoringSyncLastSuccessTime = null;
        }
        //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
        // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
        if (ec.Includes("objectMetadataSyncLastSuccessTime",true))
        {
            if(this.ObjectMetadataSyncLastSuccessTime == null) {

                this.ObjectMetadataSyncLastSuccessTime = new DateTime();

            } else {


            }
        }
        else if (this.ObjectMetadataSyncLastSuccessTime != null && ec.Excludes("objectMetadataSyncLastSuccessTime",true))
        {
            this.ObjectMetadataSyncLastSuccessTime = null;
        }
        //      C# -> DateTime? ReportsSyncLastSuccessTime
        // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
        if (ec.Includes("reportsSyncLastSuccessTime",true))
        {
            if(this.ReportsSyncLastSuccessTime == null) {

                this.ReportsSyncLastSuccessTime = new DateTime();

            } else {


            }
        }
        else if (this.ReportsSyncLastSuccessTime != null && ec.Excludes("reportsSyncLastSuccessTime",true))
        {
            this.ReportsSyncLastSuccessTime = null;
        }
    }


    #endregion

    } // class RubrikSyncStatus
    
    #endregion

    public static class ListRubrikSyncStatusExtensions
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
            this List<RubrikSyncStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikSyncStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikSyncStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RubrikSyncStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types