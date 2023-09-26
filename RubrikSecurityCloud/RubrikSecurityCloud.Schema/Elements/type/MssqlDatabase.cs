// MssqlDatabase.cs
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
    #region MssqlDatabase
 
    public class MssqlDatabase: BaseType, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, MssqlAvailabilityGroupDescendantType, MssqlAvailabilityGroupLogicalChildType, MssqlInstanceDescendantType, MssqlInstanceLogicalChildType, MssqlTopLevelDescendantType, PhysicalHostDescendantType, WindowsClusterDescendantType
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> System.Int32? CdmOnDemandSnapshotCount
        // GraphQL -> cdmOnDemandSnapshotCount: Int! (scalar)
        [JsonProperty("cdmOnDemandSnapshotCount")]
        public System.Int32? CdmOnDemandSnapshotCount { get; set; }

        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        [JsonProperty("copyOnly")]
        public System.Boolean? CopyOnly { get; set; }

        //      C# -> System.String? DagId
        // GraphQL -> dagId: UUID! (scalar)
        [JsonProperty("dagId")]
        public System.String? DagId { get; set; }

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean! (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.Int64? HostLogRetention
        // GraphQL -> hostLogRetention: Long! (scalar)
        [JsonProperty("hostLogRetention")]
        public System.Int64? HostLogRetention { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        [JsonProperty("isInAvailabilityGroup")]
        public System.Boolean? IsInAvailabilityGroup { get; set; }

        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        [JsonProperty("isLogShippingSecondary")]
        public System.Boolean? IsLogShippingSecondary { get; set; }

        //      C# -> System.Boolean? IsMount
        // GraphQL -> isMount: Boolean! (scalar)
        [JsonProperty("isMount")]
        public System.Boolean? IsMount { get; set; }

        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        [JsonProperty("isOnline")]
        public System.Boolean? IsOnline { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Single? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Float! (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Single? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogBackupRetentionInHours
        // GraphQL -> logBackupRetentionInHours: Int! (scalar)
        [JsonProperty("logBackupRetentionInHours")]
        public System.Int32? LogBackupRetentionInHours { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String! (scalar)
        [JsonProperty("postBackupScript")]
        public System.String? PostBackupScript { get; set; }

        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String! (scalar)
        [JsonProperty("preBackupScript")]
        public System.String? PreBackupScript { get; set; }

        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        [JsonProperty("recoveryModel")]
        public System.String? RecoveryModel { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<System.String>? UnprotectableReasons
        // GraphQL -> unprotectableReasons: [String!]! (scalar)
        [JsonProperty("unprotectableReasons")]
        public List<System.String>? UnprotectableReasons { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> CdmGroupedSnapshotConnection? CdmGroupedSnapshots
        // GraphQL -> cdmGroupedSnapshots: CdmGroupedSnapshotConnection! (type)
        [JsonProperty("cdmGroupedSnapshots")]
        public CdmGroupedSnapshotConnection? CdmGroupedSnapshots { get; set; }

        //      C# -> CdmWorkloadSnapshot? CdmNewestSnapshot
        // GraphQL -> cdmNewestSnapshot: CdmWorkloadSnapshot (type)
        [JsonProperty("cdmNewestSnapshot")]
        public CdmWorkloadSnapshot? CdmNewestSnapshot { get; set; }

        //      C# -> CdmWorkloadSnapshot? CdmOldestSnapshot
        // GraphQL -> cdmOldestSnapshot: CdmWorkloadSnapshot (type)
        [JsonProperty("cdmOldestSnapshot")]
        public CdmWorkloadSnapshot? CdmOldestSnapshot { get; set; }

        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        [JsonProperty("cdmSnapshots")]
        public CdmWorkloadSnapshotConnection? CdmSnapshots { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> MssqlDatabaseLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: MssqlDatabaseLiveMountConnection! (type)
        [JsonProperty("liveMounts")]
        public MssqlDatabaseLiveMountConnection? LiveMounts { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        [JsonProperty("missedSnapshotGroupByConnection")]
        public MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestArchivedSnapshot")]
        public CdmSnapshot? NewestArchivedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestReplicatedSnapshot")]
        public CdmSnapshot? NewestReplicatedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public CdmSnapshot? NewestSnapshot { get; set; }

        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public CdmSnapshot? OldestSnapshot { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> List<CdmMssqlDbReplica>? Replicas
        // GraphQL -> replicas: [CdmMssqlDbReplica!]! (type)
        [JsonProperty("replicas")]
        public List<CdmMssqlDbReplica>? Replicas { get; set; }

        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public CdmSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public CdmSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        [JsonProperty("snapshotGroupBySummary")]
        public CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDatabase";
    }

    public MssqlDatabase Set(
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null,
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.Int32? CdmOnDemandSnapshotCount = null,
        System.Boolean? CopyOnly = null,
        System.String? DagId = null,
        System.Boolean? HasLogConfigFromSla = null,
        System.Boolean? HasPermissions = null,
        System.Int64? HostLogRetention = null,
        System.String? Id = null,
        System.Boolean? IsInAvailabilityGroup = null,
        System.Boolean? IsLogShippingSecondary = null,
        System.Boolean? IsMount = null,
        System.Boolean? IsOnline = null,
        System.Boolean? IsRelic = null,
        System.Single? LogBackupFrequencyInSeconds = null,
        System.Int32? LogBackupRetentionInHours = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PostBackupScript = null,
        System.String? PreBackupScript = null,
        System.String? RecoveryModel = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        List<System.String>? UnprotectableReasons = null,
        List<Org>? AllOrgs = null,
        CdmGroupedSnapshotConnection? CdmGroupedSnapshots = null,
        CdmWorkloadSnapshot? CdmNewestSnapshot = null,
        CdmWorkloadSnapshot? CdmOldestSnapshot = null,
        CdmWorkloadSnapshotConnection? CdmSnapshots = null,
        Cluster? Cluster = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        MssqlDatabaseLiveMountConnection? LiveMounts = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        List<CdmMssqlDbReplica>? Replicas = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( CdmOnDemandSnapshotCount != null ) {
            this.CdmOnDemandSnapshotCount = CdmOnDemandSnapshotCount;
        }
        if ( CopyOnly != null ) {
            this.CopyOnly = CopyOnly;
        }
        if ( DagId != null ) {
            this.DagId = DagId;
        }
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( HostLogRetention != null ) {
            this.HostLogRetention = HostLogRetention;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsInAvailabilityGroup != null ) {
            this.IsInAvailabilityGroup = IsInAvailabilityGroup;
        }
        if ( IsLogShippingSecondary != null ) {
            this.IsLogShippingSecondary = IsLogShippingSecondary;
        }
        if ( IsMount != null ) {
            this.IsMount = IsMount;
        }
        if ( IsOnline != null ) {
            this.IsOnline = IsOnline;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogBackupRetentionInHours != null ) {
            this.LogBackupRetentionInHours = LogBackupRetentionInHours;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( UnprotectableReasons != null ) {
            this.UnprotectableReasons = UnprotectableReasons;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( CdmGroupedSnapshots != null ) {
            this.CdmGroupedSnapshots = CdmGroupedSnapshots;
        }
        if ( CdmNewestSnapshot != null ) {
            this.CdmNewestSnapshot = CdmNewestSnapshot;
        }
        if ( CdmOldestSnapshot != null ) {
            this.CdmOldestSnapshot = CdmOldestSnapshot;
        }
        if ( CdmSnapshots != null ) {
            this.CdmSnapshots = CdmSnapshots;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LiveMounts != null ) {
            this.LiveMounts = LiveMounts;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByConnection != null ) {
            this.MissedSnapshotGroupByConnection = MissedSnapshotGroupByConnection;
        }
        if ( NewestArchivedSnapshot != null ) {
            this.NewestArchivedSnapshot = NewestArchivedSnapshot;
        }
        if ( NewestReplicatedSnapshot != null ) {
            this.NewestReplicatedSnapshot = NewestReplicatedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( Replicas != null ) {
            this.Replicas = Replicas;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupBySummary != null ) {
            this.SnapshotGroupBySummary = SnapshotGroupBySummary;
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
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizedOperations\n" ;
            } else {
                s += ind + "authorizedOperations\n" ;
            }
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(conf.Child("configuredSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configuredSlaDomain {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(conf.Child("effectiveRetentionSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveRetentionSlaDomain {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(conf.Child("effectiveSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(conf.Child("pendingSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSla {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects != null) {
                var fspec = this.ReplicatedObjects.AsFieldSpec(conf.Child("replicatedObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicatedObjects {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmLink\n" ;
            } else {
                s += ind + "cdmLink\n" ;
            }
        }
        //      C# -> System.Int32? CdmOnDemandSnapshotCount
        // GraphQL -> cdmOnDemandSnapshotCount: Int! (scalar)
        if (this.CdmOnDemandSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmOnDemandSnapshotCount\n" ;
            } else {
                s += ind + "cdmOnDemandSnapshotCount\n" ;
            }
        }
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        if (this.CopyOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "copyOnly\n" ;
            } else {
                s += ind + "copyOnly\n" ;
            }
        }
        //      C# -> System.String? DagId
        // GraphQL -> dagId: UUID! (scalar)
        if (this.DagId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dagId\n" ;
            } else {
                s += ind + "dagId\n" ;
            }
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean! (scalar)
        if (this.HasLogConfigFromSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasLogConfigFromSla\n" ;
            } else {
                s += ind + "hasLogConfigFromSla\n" ;
            }
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPermissions\n" ;
            } else {
                s += ind + "hasPermissions\n" ;
            }
        }
        //      C# -> System.Int64? HostLogRetention
        // GraphQL -> hostLogRetention: Long! (scalar)
        if (this.HostLogRetention != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetention\n" ;
            } else {
                s += ind + "hostLogRetention\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        if (this.IsInAvailabilityGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInAvailabilityGroup\n" ;
            } else {
                s += ind + "isInAvailabilityGroup\n" ;
            }
        }
        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        if (this.IsLogShippingSecondary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLogShippingSecondary\n" ;
            } else {
                s += ind + "isLogShippingSecondary\n" ;
            }
        }
        //      C# -> System.Boolean? IsMount
        // GraphQL -> isMount: Boolean! (scalar)
        if (this.IsMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMount\n" ;
            } else {
                s += ind + "isMount\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        if (this.IsOnline != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnline\n" ;
            } else {
                s += ind + "isOnline\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.Single? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Float! (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyInSeconds\n" ;
            } else {
                s += ind + "logBackupFrequencyInSeconds\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupRetentionInHours
        // GraphQL -> logBackupRetentionInHours: Int! (scalar)
        if (this.LogBackupRetentionInHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupRetentionInHours\n" ;
            } else {
                s += ind + "logBackupRetentionInHours\n" ;
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
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloadDescendants\n" ;
            } else {
                s += ind + "numWorkloadDescendants\n" ;
            }
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onDemandSnapshotCount\n" ;
            } else {
                s += ind + "onDemandSnapshotCount\n" ;
            }
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String! (scalar)
        if (this.PostBackupScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postBackupScript\n" ;
            } else {
                s += ind + "postBackupScript\n" ;
            }
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String! (scalar)
        if (this.PreBackupScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preBackupScript\n" ;
            } else {
                s += ind + "preBackupScript\n" ;
            }
        }
        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        if (this.RecoveryModel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryModel\n" ;
            } else {
                s += ind + "recoveryModel\n" ;
            }
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicatedObjectCount\n" ;
            } else {
                s += ind + "replicatedObjectCount\n" ;
            }
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaPauseStatus\n" ;
            } else {
                s += ind + "slaPauseStatus\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasons
        // GraphQL -> unprotectableReasons: [String!]! (scalar)
        if (this.UnprotectableReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasons\n" ;
            } else {
                s += ind + "unprotectableReasons\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmGroupedSnapshotConnection? CdmGroupedSnapshots
        // GraphQL -> cdmGroupedSnapshots: CdmGroupedSnapshotConnection! (type)
        if (this.CdmGroupedSnapshots != null) {
            var fspec = this.CdmGroupedSnapshots.AsFieldSpec(conf.Child("cdmGroupedSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmGroupedSnapshots {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkloadSnapshot? CdmNewestSnapshot
        // GraphQL -> cdmNewestSnapshot: CdmWorkloadSnapshot (type)
        if (this.CdmNewestSnapshot != null) {
            var fspec = this.CdmNewestSnapshot.AsFieldSpec(conf.Child("cdmNewestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmNewestSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkloadSnapshot? CdmOldestSnapshot
        // GraphQL -> cdmOldestSnapshot: CdmWorkloadSnapshot (type)
        if (this.CdmOldestSnapshot != null) {
            var fspec = this.CdmOldestSnapshot.AsFieldSpec(conf.Child("cdmOldestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmOldestSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        if (this.CdmSnapshots != null) {
            var fspec = this.CdmSnapshots.AsFieldSpec(conf.Child("cdmSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmSnapshots {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(conf.Child("effectiveSlaSourceObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(conf.Child("latestUserNote"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestUserNote {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlDatabaseLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: MssqlDatabaseLiveMountConnection! (type)
        if (this.LiveMounts != null) {
            var fspec = this.LiveMounts.AsFieldSpec(conf.Child("liveMounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "liveMounts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(conf.Child("missedSnapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            var fspec = this.MissedSnapshotGroupByConnection.AsFieldSpec(conf.Child("missedSnapshotGroupByConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot != null) {
            var fspec = this.NewestArchivedSnapshot.AsFieldSpec(conf.Child("newestArchivedSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestArchivedSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot != null) {
            var fspec = this.NewestReplicatedSnapshot.AsFieldSpec(conf.Child("newestReplicatedSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestReplicatedSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(conf.Child("newestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(conf.Child("oldestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldestSnapshot {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            var fspec = this.PendingObjectDeletionStatus.AsFieldSpec(conf.Child("pendingObjectDeletionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingObjectDeletionStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(conf.Child("physicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            var fspec = this.PrimaryClusterLocation.AsFieldSpec(conf.Child("primaryClusterLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryClusterLocation {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CdmMssqlDbReplica>? Replicas
        // GraphQL -> replicas: [CdmMssqlDbReplica!]! (type)
        if (this.Replicas != null) {
            var fspec = this.Replicas.AsFieldSpec(conf.Child("replicas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicas {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(conf.Child("snapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(conf.Child("snapshotDistribution"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(conf.Child("snapshotGroupByConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary != null) {
            var fspec = this.SnapshotGroupBySummary.AsFieldSpec(conf.Child("snapshotGroupBySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupBySummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (ec.Includes("authorizedOperations",true))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new List<Operation>();

            } else {


            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",true))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignmentTypeEnum();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (ec.Includes("configuredSlaDomain",false))
        {
            if(this.ConfiguredSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ConfiguredSlaDomain != null && ec.Excludes("configuredSlaDomain",false))
        {
            this.ConfiguredSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (ec.Includes("effectiveRetentionSlaDomain",false))
        {
            if(this.EffectiveRetentionSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveRetentionSlaDomain != null && ec.Excludes("effectiveRetentionSlaDomain",false))
        {
            this.EffectiveRetentionSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (ec.Includes("effectiveSlaDomain",false))
        {
            if(this.EffectiveSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (ec.Includes("pendingSla",false))
        {
            if(this.PendingSla == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.PendingSla != null && ec.Excludes("pendingSla",false))
        {
            this.PendingSla = null;
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (ec.Includes("replicatedObjects",false))
        {
            if(this.ReplicatedObjects == null) {

                this.ReplicatedObjects = new List<CdmHierarchyObject>();
                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            } else {

                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            }
        }
        else if (this.ReplicatedObjects != null && ec.Excludes("replicatedObjects",false))
        {
            this.ReplicatedObjects = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (ec.Includes("cdmLink",true))
        {
            if(this.CdmLink == null) {

                this.CdmLink = "FETCH";

            } else {


            }
        }
        else if (this.CdmLink != null && ec.Excludes("cdmLink",true))
        {
            this.CdmLink = null;
        }
        //      C# -> System.Int32? CdmOnDemandSnapshotCount
        // GraphQL -> cdmOnDemandSnapshotCount: Int! (scalar)
        if (ec.Includes("cdmOnDemandSnapshotCount",true))
        {
            if(this.CdmOnDemandSnapshotCount == null) {

                this.CdmOnDemandSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.CdmOnDemandSnapshotCount != null && ec.Excludes("cdmOnDemandSnapshotCount",true))
        {
            this.CdmOnDemandSnapshotCount = null;
        }
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        if (ec.Includes("copyOnly",true))
        {
            if(this.CopyOnly == null) {

                this.CopyOnly = true;

            } else {


            }
        }
        else if (this.CopyOnly != null && ec.Excludes("copyOnly",true))
        {
            this.CopyOnly = null;
        }
        //      C# -> System.String? DagId
        // GraphQL -> dagId: UUID! (scalar)
        if (ec.Includes("dagId",true))
        {
            if(this.DagId == null) {

                this.DagId = "FETCH";

            } else {


            }
        }
        else if (this.DagId != null && ec.Excludes("dagId",true))
        {
            this.DagId = null;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean! (scalar)
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
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (ec.Includes("hasPermissions",true))
        {
            if(this.HasPermissions == null) {

                this.HasPermissions = true;

            } else {


            }
        }
        else if (this.HasPermissions != null && ec.Excludes("hasPermissions",true))
        {
            this.HasPermissions = null;
        }
        //      C# -> System.Int64? HostLogRetention
        // GraphQL -> hostLogRetention: Long! (scalar)
        if (ec.Includes("hostLogRetention",true))
        {
            if(this.HostLogRetention == null) {

                this.HostLogRetention = new System.Int64();

            } else {


            }
        }
        else if (this.HostLogRetention != null && ec.Excludes("hostLogRetention",true))
        {
            this.HostLogRetention = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        if (ec.Includes("isInAvailabilityGroup",true))
        {
            if(this.IsInAvailabilityGroup == null) {

                this.IsInAvailabilityGroup = true;

            } else {


            }
        }
        else if (this.IsInAvailabilityGroup != null && ec.Excludes("isInAvailabilityGroup",true))
        {
            this.IsInAvailabilityGroup = null;
        }
        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        if (ec.Includes("isLogShippingSecondary",true))
        {
            if(this.IsLogShippingSecondary == null) {

                this.IsLogShippingSecondary = true;

            } else {


            }
        }
        else if (this.IsLogShippingSecondary != null && ec.Excludes("isLogShippingSecondary",true))
        {
            this.IsLogShippingSecondary = null;
        }
        //      C# -> System.Boolean? IsMount
        // GraphQL -> isMount: Boolean! (scalar)
        if (ec.Includes("isMount",true))
        {
            if(this.IsMount == null) {

                this.IsMount = true;

            } else {


            }
        }
        else if (this.IsMount != null && ec.Excludes("isMount",true))
        {
            this.IsMount = null;
        }
        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        if (ec.Includes("isOnline",true))
        {
            if(this.IsOnline == null) {

                this.IsOnline = true;

            } else {


            }
        }
        else if (this.IsOnline != null && ec.Excludes("isOnline",true))
        {
            this.IsOnline = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.Single? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Float! (scalar)
        if (ec.Includes("logBackupFrequencyInSeconds",true))
        {
            if(this.LogBackupFrequencyInSeconds == null) {

                this.LogBackupFrequencyInSeconds = new System.Single();

            } else {


            }
        }
        else if (this.LogBackupFrequencyInSeconds != null && ec.Excludes("logBackupFrequencyInSeconds",true))
        {
            this.LogBackupFrequencyInSeconds = null;
        }
        //      C# -> System.Int32? LogBackupRetentionInHours
        // GraphQL -> logBackupRetentionInHours: Int! (scalar)
        if (ec.Includes("logBackupRetentionInHours",true))
        {
            if(this.LogBackupRetentionInHours == null) {

                this.LogBackupRetentionInHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupRetentionInHours != null && ec.Excludes("logBackupRetentionInHours",true))
        {
            this.LogBackupRetentionInHours = null;
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
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (ec.Includes("numWorkloadDescendants",true))
        {
            if(this.NumWorkloadDescendants == null) {

                this.NumWorkloadDescendants = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumWorkloadDescendants != null && ec.Excludes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = null;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (ec.Includes("onDemandSnapshotCount",true))
        {
            if(this.OnDemandSnapshotCount == null) {

                this.OnDemandSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.OnDemandSnapshotCount != null && ec.Excludes("onDemandSnapshotCount",true))
        {
            this.OnDemandSnapshotCount = null;
        }
        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String! (scalar)
        if (ec.Includes("postBackupScript",true))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = "FETCH";

            } else {


            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",true))
        {
            this.PostBackupScript = null;
        }
        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String! (scalar)
        if (ec.Includes("preBackupScript",true))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = "FETCH";

            } else {


            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",true))
        {
            this.PreBackupScript = null;
        }
        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        if (ec.Includes("recoveryModel",true))
        {
            if(this.RecoveryModel == null) {

                this.RecoveryModel = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryModel != null && ec.Excludes("recoveryModel",true))
        {
            this.RecoveryModel = null;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (ec.Includes("replicatedObjectCount",true))
        {
            if(this.ReplicatedObjectCount == null) {

                this.ReplicatedObjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ReplicatedObjectCount != null && ec.Excludes("replicatedObjectCount",true))
        {
            this.ReplicatedObjectCount = null;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (ec.Includes("slaPauseStatus",true))
        {
            if(this.SlaPauseStatus == null) {

                this.SlaPauseStatus = true;

            } else {


            }
        }
        else if (this.SlaPauseStatus != null && ec.Excludes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = null;
        }
        //      C# -> List<System.String>? UnprotectableReasons
        // GraphQL -> unprotectableReasons: [String!]! (scalar)
        if (ec.Includes("unprotectableReasons",true))
        {
            if(this.UnprotectableReasons == null) {

                this.UnprotectableReasons = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasons != null && ec.Excludes("unprotectableReasons",true))
        {
            this.UnprotectableReasons = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> CdmGroupedSnapshotConnection? CdmGroupedSnapshots
        // GraphQL -> cdmGroupedSnapshots: CdmGroupedSnapshotConnection! (type)
        if (ec.Includes("cdmGroupedSnapshots",false))
        {
            if(this.CdmGroupedSnapshots == null) {

                this.CdmGroupedSnapshots = new CdmGroupedSnapshotConnection();
                this.CdmGroupedSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmGroupedSnapshots"));

            } else {

                this.CdmGroupedSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmGroupedSnapshots"));

            }
        }
        else if (this.CdmGroupedSnapshots != null && ec.Excludes("cdmGroupedSnapshots",false))
        {
            this.CdmGroupedSnapshots = null;
        }
        //      C# -> CdmWorkloadSnapshot? CdmNewestSnapshot
        // GraphQL -> cdmNewestSnapshot: CdmWorkloadSnapshot (type)
        if (ec.Includes("cdmNewestSnapshot",false))
        {
            if(this.CdmNewestSnapshot == null) {

                this.CdmNewestSnapshot = new CdmWorkloadSnapshot();
                this.CdmNewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("cdmNewestSnapshot"));

            } else {

                this.CdmNewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("cdmNewestSnapshot"));

            }
        }
        else if (this.CdmNewestSnapshot != null && ec.Excludes("cdmNewestSnapshot",false))
        {
            this.CdmNewestSnapshot = null;
        }
        //      C# -> CdmWorkloadSnapshot? CdmOldestSnapshot
        // GraphQL -> cdmOldestSnapshot: CdmWorkloadSnapshot (type)
        if (ec.Includes("cdmOldestSnapshot",false))
        {
            if(this.CdmOldestSnapshot == null) {

                this.CdmOldestSnapshot = new CdmWorkloadSnapshot();
                this.CdmOldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("cdmOldestSnapshot"));

            } else {

                this.CdmOldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("cdmOldestSnapshot"));

            }
        }
        else if (this.CdmOldestSnapshot != null && ec.Excludes("cdmOldestSnapshot",false))
        {
            this.CdmOldestSnapshot = null;
        }
        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        if (ec.Includes("cdmSnapshots",false))
        {
            if(this.CdmSnapshots == null) {

                this.CdmSnapshots = new CdmWorkloadSnapshotConnection();
                this.CdmSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshots"));

            } else {

                this.CdmSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("cdmSnapshots"));

            }
        }
        else if (this.CdmSnapshots != null && ec.Excludes("cdmSnapshots",false))
        {
            this.CdmSnapshots = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (ec.Includes("effectiveSlaSourceObject",false))
        {
            if(this.EffectiveSlaSourceObject == null) {

                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            } else {

                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            }
        }
        else if (this.EffectiveSlaSourceObject != null && ec.Excludes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = null;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (ec.Includes("latestUserNote",false))
        {
            if(this.LatestUserNote == null) {

                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));

            } else {

                this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));

            }
        }
        else if (this.LatestUserNote != null && ec.Excludes("latestUserNote",false))
        {
            this.LatestUserNote = null;
        }
        //      C# -> MssqlDatabaseLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: MssqlDatabaseLiveMountConnection! (type)
        if (ec.Includes("liveMounts",false))
        {
            if(this.LiveMounts == null) {

                this.LiveMounts = new MssqlDatabaseLiveMountConnection();
                this.LiveMounts.ApplyExploratoryFieldSpec(ec.NewChild("liveMounts"));

            } else {

                this.LiveMounts.ApplyExploratoryFieldSpec(ec.NewChild("liveMounts"));

            }
        }
        else if (this.LiveMounts != null && ec.Excludes("liveMounts",false))
        {
            this.LiveMounts = null;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (ec.Includes("logicalPath",false))
        {
            if(this.LogicalPath == null) {

                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            } else {

                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            }
        }
        else if (this.LogicalPath != null && ec.Excludes("logicalPath",false))
        {
            this.LogicalPath = null;
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (ec.Includes("missedSnapshotConnection",false))
        {
            if(this.MissedSnapshotConnection == null) {

                this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
                this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));

            } else {

                this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));

            }
        }
        else if (this.MissedSnapshotConnection != null && ec.Excludes("missedSnapshotConnection",false))
        {
            this.MissedSnapshotConnection = null;
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (ec.Includes("missedSnapshotGroupByConnection",false))
        {
            if(this.MissedSnapshotGroupByConnection == null) {

                this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
                this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));

            } else {

                this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));

            }
        }
        else if (this.MissedSnapshotGroupByConnection != null && ec.Excludes("missedSnapshotGroupByConnection",false))
        {
            this.MissedSnapshotGroupByConnection = null;
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestArchivedSnapshot",false))
        {
            if(this.NewestArchivedSnapshot == null) {

                this.NewestArchivedSnapshot = new CdmSnapshot();
                this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestArchivedSnapshot"));

            } else {

                this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestArchivedSnapshot"));

            }
        }
        else if (this.NewestArchivedSnapshot != null && ec.Excludes("newestArchivedSnapshot",false))
        {
            this.NewestArchivedSnapshot = null;
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestReplicatedSnapshot",false))
        {
            if(this.NewestReplicatedSnapshot == null) {

                this.NewestReplicatedSnapshot = new CdmSnapshot();
                this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestReplicatedSnapshot"));

            } else {

                this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestReplicatedSnapshot"));

            }
        }
        else if (this.NewestReplicatedSnapshot != null && ec.Excludes("newestReplicatedSnapshot",false))
        {
            this.NewestReplicatedSnapshot = null;
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestSnapshot",false))
        {
            if(this.NewestSnapshot == null) {

                this.NewestSnapshot = new CdmSnapshot();
                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            } else {

                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            }
        }
        else if (this.NewestSnapshot != null && ec.Excludes("newestSnapshot",false))
        {
            this.NewestSnapshot = null;
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (ec.Includes("oldestSnapshot",false))
        {
            if(this.OldestSnapshot == null) {

                this.OldestSnapshot = new CdmSnapshot();
                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            } else {

                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            }
        }
        else if (this.OldestSnapshot != null && ec.Excludes("oldestSnapshot",false))
        {
            this.OldestSnapshot = null;
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (ec.Includes("pendingObjectDeletionStatus",false))
        {
            if(this.PendingObjectDeletionStatus == null) {

                this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
                this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("pendingObjectDeletionStatus"));

            } else {

                this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("pendingObjectDeletionStatus"));

            }
        }
        else if (this.PendingObjectDeletionStatus != null && ec.Excludes("pendingObjectDeletionStatus",false))
        {
            this.PendingObjectDeletionStatus = null;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (ec.Includes("physicalPath",false))
        {
            if(this.PhysicalPath == null) {

                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            } else {

                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            }
        }
        else if (this.PhysicalPath != null && ec.Excludes("physicalPath",false))
        {
            this.PhysicalPath = null;
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (ec.Includes("primaryClusterLocation",false))
        {
            if(this.PrimaryClusterLocation == null) {

                this.PrimaryClusterLocation = new DataLocation();
                this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryClusterLocation"));

            } else {

                this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryClusterLocation"));

            }
        }
        else if (this.PrimaryClusterLocation != null && ec.Excludes("primaryClusterLocation",false))
        {
            this.PrimaryClusterLocation = null;
        }
        //      C# -> List<CdmMssqlDbReplica>? Replicas
        // GraphQL -> replicas: [CdmMssqlDbReplica!]! (type)
        if (ec.Includes("replicas",false))
        {
            if(this.Replicas == null) {

                this.Replicas = new List<CdmMssqlDbReplica>();
                this.Replicas.ApplyExploratoryFieldSpec(ec.NewChild("replicas"));

            } else {

                this.Replicas.ApplyExploratoryFieldSpec(ec.NewChild("replicas"));

            }
        }
        else if (this.Replicas != null && ec.Excludes("replicas",false))
        {
            this.Replicas = null;
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (ec.Includes("snapshotConnection",false))
        {
            if(this.SnapshotConnection == null) {

                this.SnapshotConnection = new CdmSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            } else {

                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            }
        }
        else if (this.SnapshotConnection != null && ec.Excludes("snapshotConnection",false))
        {
            this.SnapshotConnection = null;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (ec.Includes("snapshotDistribution",false))
        {
            if(this.SnapshotDistribution == null) {

                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            } else {

                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            }
        }
        else if (this.SnapshotDistribution != null && ec.Excludes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = null;
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (ec.Includes("snapshotGroupByConnection",false))
        {
            if(this.SnapshotGroupByConnection == null) {

                this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            } else {

                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            }
        }
        else if (this.SnapshotGroupByConnection != null && ec.Excludes("snapshotGroupByConnection",false))
        {
            this.SnapshotGroupByConnection = null;
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (ec.Includes("snapshotGroupBySummary",false))
        {
            if(this.SnapshotGroupBySummary == null) {

                this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
                this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupBySummary"));

            } else {

                this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupBySummary"));

            }
        }
        else if (this.SnapshotGroupBySummary != null && ec.Excludes("snapshotGroupBySummary",false))
        {
            this.SnapshotGroupBySummary = null;
        }
    }


    #endregion

    } // class MssqlDatabase
    
    #endregion

    public static class ListMssqlDatabaseExtensions
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
            this List<MssqlDatabase> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDatabase> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDatabase());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDatabase> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types