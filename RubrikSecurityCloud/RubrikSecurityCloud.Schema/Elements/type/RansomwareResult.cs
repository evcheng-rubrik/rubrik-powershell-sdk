// RansomwareResult.cs
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
    #region RansomwareResult
    public class RansomwareResult: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        [JsonProperty("encryptionProbability")]
        public System.Single? EncryptionProbability { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        [JsonProperty("snapshotData")]
        public DateTime? SnapshotData { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareResult";
    }

    public RansomwareResult Set(
        System.String? ClusterUuid = null,
        System.Single? EncryptionProbability = null,
        System.String? Id = null,
        System.Boolean? IsEncrypted = null,
        System.String? ManagedId = null,
        DateTime? SnapshotData = null,
        System.String? SnapshotFid = null,
        System.String? SnapshotId = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( EncryptionProbability != null ) {
            this.EncryptionProbability = EncryptionProbability;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( SnapshotData != null ) {
            this.SnapshotData = SnapshotData;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        if (this.EncryptionProbability != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionProbability\n" ;
            } else {
                s += ind + "encryptionProbability\n" ;
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
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEncrypted\n" ;
            } else {
                s += ind + "isEncrypted\n" ;
            }
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managedId\n" ;
            } else {
                s += ind + "managedId\n" ;
            }
        }
        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        if (this.SnapshotData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotData\n" ;
            } else {
                s += ind + "snapshotData\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        if (ec.Includes("encryptionProbability",true))
        {
            if(this.EncryptionProbability == null) {

                this.EncryptionProbability = new System.Single();

            } else {


            }
        }
        else if (this.EncryptionProbability != null && ec.Excludes("encryptionProbability",true))
        {
            this.EncryptionProbability = null;
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
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (ec.Includes("isEncrypted",true))
        {
            if(this.IsEncrypted == null) {

                this.IsEncrypted = true;

            } else {


            }
        }
        else if (this.IsEncrypted != null && ec.Excludes("isEncrypted",true))
        {
            this.IsEncrypted = null;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (ec.Includes("managedId",true))
        {
            if(this.ManagedId == null) {

                this.ManagedId = "FETCH";

            } else {


            }
        }
        else if (this.ManagedId != null && ec.Excludes("managedId",true))
        {
            this.ManagedId = null;
        }
        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        if (ec.Includes("snapshotData",true))
        {
            if(this.SnapshotData == null) {

                this.SnapshotData = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotData != null && ec.Excludes("snapshotData",true))
        {
            this.SnapshotData = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
    }


    #endregion

    } // class RansomwareResult
    
    #endregion

    public static class ListRansomwareResultExtensions
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
            this List<RansomwareResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RansomwareResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RansomwareResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types