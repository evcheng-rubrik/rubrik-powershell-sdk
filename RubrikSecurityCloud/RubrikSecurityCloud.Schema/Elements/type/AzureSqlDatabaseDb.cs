// AzureSqlDatabaseDb.cs
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
    #region AzureSqlDatabaseDb
 
    public class AzureSqlDatabaseDb: BaseType, HierarchyObject, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members

        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> AzureSqlDbBackupSetupStatus? BackupSetupStatus
        // GraphQL -> backupSetupStatus: AzureSqlDbBackupSetupStatus! (enum)
        [JsonProperty("backupSetupStatus")]
        public AzureSqlDbBackupSetupStatus? BackupSetupStatus { get; set; }

        //      C# -> AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy
        // GraphQL -> backupStorageRedundancy: AzureSqlBackupStorageRedundancyType! (enum)
        [JsonProperty("backupStorageRedundancy")]
        public AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        [JsonProperty("region")]
        public AzureNativeRegion? Region { get; set; }

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

        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        [JsonProperty("databaseName")]
        public System.String? DatabaseName { get; set; }

        //      C# -> System.String? ElasticPoolName
        // GraphQL -> elasticPoolName: String! (scalar)
        [JsonProperty("elasticPoolName")]
        public System.String? ElasticPoolName { get; set; }

        //      C# -> System.Boolean? ExocomputeConfigured
        // GraphQL -> exocomputeConfigured: Boolean! (scalar)
        [JsonProperty("exocomputeConfigured")]
        public System.Boolean? ExocomputeConfigured { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEligibleForPersistentBackups
        // GraphQL -> isEligibleForPersistentBackups: Boolean! (scalar)
        [JsonProperty("isEligibleForPersistentBackups")]
        public System.Boolean? IsEligibleForPersistentBackups { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Int64? MaximumSizeInBytes
        // GraphQL -> maximumSizeInBytes: Long! (scalar)
        [JsonProperty("maximumSizeInBytes")]
        public System.Int64? MaximumSizeInBytes { get; set; }

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

        //      C# -> System.String? ServiceObjectiveName
        // GraphQL -> serviceObjectiveName: String! (scalar)
        [JsonProperty("serviceObjectiveName")]
        public System.String? ServiceObjectiveName { get; set; }

        //      C# -> System.String? ServiceTier
        // GraphQL -> serviceTier: String! (scalar)
        [JsonProperty("serviceTier")]
        public System.String? ServiceTier { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> AzureSqlDatabaseServer? AzureSqlDatabaseServer
        // GraphQL -> azureSqlDatabaseServer: AzureSqlDatabaseServer! (type)
        [JsonProperty("azureSqlDatabaseServer")]
        public AzureSqlDatabaseServer? AzureSqlDatabaseServer { get; set; }

        //      C# -> CloudNativeDatabaseBackupSetupSpecs? BackupSetupSpecs
        // GraphQL -> backupSetupSpecs: CloudNativeDatabaseBackupSetupSpecs (type)
        [JsonProperty("backupSetupSpecs")]
        public CloudNativeDatabaseBackupSetupSpecs? BackupSetupSpecs { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestIndexedSnapshot")]
        public PolarisSnapshot? NewestIndexedSnapshot { get; set; }

        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public PolarisSnapshot? NewestSnapshot { get; set; }

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        [JsonProperty("persistentStorage")]
        public PersistentStorage? PersistentStorage { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public PolarisSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public PolarisSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        [JsonProperty("snapshotGroupByNewConnection")]
        public PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection { get; set; }

        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureTag>? Tags { get; set; }

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSqlDatabaseDb";
    }

    public AzureSqlDatabaseDb Set(
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        AzureSqlDbBackupSetupStatus? BackupSetupStatus = null,
        AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? DatabaseName = null,
        System.String? ElasticPoolName = null,
        System.Boolean? ExocomputeConfigured = null,
        System.String? Id = null,
        System.Boolean? IsEligibleForPersistentBackups = null,
        System.Boolean? IsRelic = null,
        System.Int64? MaximumSizeInBytes = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? ServiceObjectiveName = null,
        System.String? ServiceTier = null,
        System.Boolean? SlaPauseStatus = null,
        List<Org>? AllOrgs = null,
        AzureSqlDatabaseServer? AzureSqlDatabaseServer = null,
        CloudNativeDatabaseBackupSetupSpecs? BackupSetupSpecs = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        PolarisSnapshot? OldestSnapshot = null,
        PersistentStorage? PersistentStorage = null,
        List<PathNode>? PhysicalPath = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        List<AzureTag>? Tags = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( BackupSetupStatus != null ) {
            this.BackupSetupStatus = BackupSetupStatus;
        }
        if ( BackupStorageRedundancy != null ) {
            this.BackupStorageRedundancy = BackupStorageRedundancy;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Region != null ) {
            this.Region = Region;
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
        if ( DatabaseName != null ) {
            this.DatabaseName = DatabaseName;
        }
        if ( ElasticPoolName != null ) {
            this.ElasticPoolName = ElasticPoolName;
        }
        if ( ExocomputeConfigured != null ) {
            this.ExocomputeConfigured = ExocomputeConfigured;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEligibleForPersistentBackups != null ) {
            this.IsEligibleForPersistentBackups = IsEligibleForPersistentBackups;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( MaximumSizeInBytes != null ) {
            this.MaximumSizeInBytes = MaximumSizeInBytes;
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
        if ( ServiceObjectiveName != null ) {
            this.ServiceObjectiveName = ServiceObjectiveName;
        }
        if ( ServiceTier != null ) {
            this.ServiceTier = ServiceTier;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AzureSqlDatabaseServer != null ) {
            this.AzureSqlDatabaseServer = AzureSqlDatabaseServer;
        }
        if ( BackupSetupSpecs != null ) {
            this.BackupSetupSpecs = BackupSetupSpecs;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( NewestIndexedSnapshot != null ) {
            this.NewestIndexedSnapshot = NewestIndexedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PersistentStorage != null ) {
            this.PersistentStorage = PersistentStorage;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
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
        if ( SnapshotGroupByNewConnection != null ) {
            this.SnapshotGroupByNewConnection = SnapshotGroupByNewConnection;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> AzureSqlDbBackupSetupStatus? BackupSetupStatus
        // GraphQL -> backupSetupStatus: AzureSqlDbBackupSetupStatus! (enum)
        if (this.BackupSetupStatus != null) {
            s += ind + "backupSetupStatus\n" ;
        }
        //      C# -> AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy
        // GraphQL -> backupStorageRedundancy: AzureSqlBackupStorageRedundancyType! (enum)
        if (this.BackupStorageRedundancy != null) {
            s += ind + "backupStorageRedundancy\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configuredSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveRetentionSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (this.DatabaseName != null) {
            s += ind + "databaseName\n" ;
        }
        //      C# -> System.String? ElasticPoolName
        // GraphQL -> elasticPoolName: String! (scalar)
        if (this.ElasticPoolName != null) {
            s += ind + "elasticPoolName\n" ;
        }
        //      C# -> System.Boolean? ExocomputeConfigured
        // GraphQL -> exocomputeConfigured: Boolean! (scalar)
        if (this.ExocomputeConfigured != null) {
            s += ind + "exocomputeConfigured\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsEligibleForPersistentBackups
        // GraphQL -> isEligibleForPersistentBackups: Boolean! (scalar)
        if (this.IsEligibleForPersistentBackups != null) {
            s += ind + "isEligibleForPersistentBackups\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.Int64? MaximumSizeInBytes
        // GraphQL -> maximumSizeInBytes: Long! (scalar)
        if (this.MaximumSizeInBytes != null) {
            s += ind + "maximumSizeInBytes\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.String? ServiceObjectiveName
        // GraphQL -> serviceObjectiveName: String! (scalar)
        if (this.ServiceObjectiveName != null) {
            s += ind + "serviceObjectiveName\n" ;
        }
        //      C# -> System.String? ServiceTier
        // GraphQL -> serviceTier: String! (scalar)
        if (this.ServiceTier != null) {
            s += ind + "serviceTier\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureSqlDatabaseServer? AzureSqlDatabaseServer
        // GraphQL -> azureSqlDatabaseServer: AzureSqlDatabaseServer! (type)
        if (this.AzureSqlDatabaseServer != null) {
            var fspec = this.AzureSqlDatabaseServer.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureSqlDatabaseServer {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CloudNativeDatabaseBackupSetupSpecs? BackupSetupSpecs
        // GraphQL -> backupSetupSpecs: CloudNativeDatabaseBackupSetupSpecs (type)
        if (this.BackupSetupSpecs != null) {
            var fspec = this.BackupSetupSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "backupSetupSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            var fspec = this.NewestIndexedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestIndexedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        if (this.PersistentStorage != null) {
            var fspec = this.PersistentStorage.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "persistentStorage {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection != null) {
            var fspec = this.SnapshotGroupByNewConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByNewConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tags {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection != null) {
            var fspec = this.WorkloadSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "workloadSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations == null && ec.Includes("authorizedOperations",true))
        {
            this.AuthorizedOperations = new List<PolarisSnappableAuthorizedOperationsEnum>();
        }
        //      C# -> AzureSqlDbBackupSetupStatus? BackupSetupStatus
        // GraphQL -> backupSetupStatus: AzureSqlDbBackupSetupStatus! (enum)
        if (this.BackupSetupStatus == null && ec.Includes("backupSetupStatus",true))
        {
            this.BackupSetupStatus = new AzureSqlDbBackupSetupStatus();
        }
        //      C# -> AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy
        // GraphQL -> backupStorageRedundancy: AzureSqlBackupStorageRedundancyType! (enum)
        if (this.BackupStorageRedundancy == null && ec.Includes("backupStorageRedundancy",true))
        {
            this.BackupStorageRedundancy = new AzureSqlBackupStorageRedundancyType();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region == null && ec.Includes("region",true))
        {
            this.Region = new AzureNativeRegion();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && ec.Includes("slaAssignment",true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && ec.Includes("configuredSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && ec.Includes("effectiveRetentionSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && ec.Includes("effectiveSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (this.DatabaseName == null && ec.Includes("databaseName",true))
        {
            this.DatabaseName = "FETCH";
        }
        //      C# -> System.String? ElasticPoolName
        // GraphQL -> elasticPoolName: String! (scalar)
        if (this.ElasticPoolName == null && ec.Includes("elasticPoolName",true))
        {
            this.ElasticPoolName = "FETCH";
        }
        //      C# -> System.Boolean? ExocomputeConfigured
        // GraphQL -> exocomputeConfigured: Boolean! (scalar)
        if (this.ExocomputeConfigured == null && ec.Includes("exocomputeConfigured",true))
        {
            this.ExocomputeConfigured = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsEligibleForPersistentBackups
        // GraphQL -> isEligibleForPersistentBackups: Boolean! (scalar)
        if (this.IsEligibleForPersistentBackups == null && ec.Includes("isEligibleForPersistentBackups",true))
        {
            this.IsEligibleForPersistentBackups = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && ec.Includes("isRelic",true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.Int64? MaximumSizeInBytes
        // GraphQL -> maximumSizeInBytes: Long! (scalar)
        if (this.MaximumSizeInBytes == null && ec.Includes("maximumSizeInBytes",true))
        {
            this.MaximumSizeInBytes = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && ec.Includes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && ec.Includes("onDemandSnapshotCount",true))
        {
            this.OnDemandSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? ServiceObjectiveName
        // GraphQL -> serviceObjectiveName: String! (scalar)
        if (this.ServiceObjectiveName == null && ec.Includes("serviceObjectiveName",true))
        {
            this.ServiceObjectiveName = "FETCH";
        }
        //      C# -> System.String? ServiceTier
        // GraphQL -> serviceTier: String! (scalar)
        if (this.ServiceTier == null && ec.Includes("serviceTier",true))
        {
            this.ServiceTier = "FETCH";
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && ec.Includes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && ec.Includes("allOrgs",false))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));
        }
        //      C# -> AzureSqlDatabaseServer? AzureSqlDatabaseServer
        // GraphQL -> azureSqlDatabaseServer: AzureSqlDatabaseServer! (type)
        if (this.AzureSqlDatabaseServer == null && ec.Includes("azureSqlDatabaseServer",false))
        {
            this.AzureSqlDatabaseServer = new AzureSqlDatabaseServer();
            this.AzureSqlDatabaseServer.ApplyExploratoryFieldSpec(ec.NewChild("azureSqlDatabaseServer"));
        }
        //      C# -> CloudNativeDatabaseBackupSetupSpecs? BackupSetupSpecs
        // GraphQL -> backupSetupSpecs: CloudNativeDatabaseBackupSetupSpecs (type)
        if (this.BackupSetupSpecs == null && ec.Includes("backupSetupSpecs",false))
        {
            this.BackupSetupSpecs = new CloudNativeDatabaseBackupSetupSpecs();
            this.BackupSetupSpecs.ApplyExploratoryFieldSpec(ec.NewChild("backupSetupSpecs"));
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && ec.Includes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && ec.Includes("logicalPath",false))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot == null && ec.Includes("newestIndexedSnapshot",false))
        {
            this.NewestIndexedSnapshot = new PolarisSnapshot();
            this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot == null && ec.Includes("newestSnapshot",false))
        {
            this.NewestSnapshot = new PolarisSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot == null && ec.Includes("oldestSnapshot",false))
        {
            this.OldestSnapshot = new PolarisSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));
        }
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        if (this.PersistentStorage == null && ec.Includes("persistentStorage",false))
        {
            this.PersistentStorage = new PersistentStorage();
            this.PersistentStorage.ApplyExploratoryFieldSpec(ec.NewChild("persistentStorage"));
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && ec.Includes("physicalPath",false))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection == null && ec.Includes("snapshotConnection",false))
        {
            this.SnapshotConnection = new PolarisSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && ec.Includes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && ec.Includes("snapshotGroupByConnection",false))
        {
            this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection == null && ec.Includes("snapshotGroupByNewConnection",false))
        {
            this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
            this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByNewConnection"));
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags == null && ec.Includes("tags",false))
        {
            this.Tags = new List<AzureTag>();
            this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection == null && ec.Includes("workloadSnapshotConnection",false))
        {
            this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
            this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("workloadSnapshotConnection"));
        }
    }


    #endregion

    } // class AzureSqlDatabaseDb
    
    #endregion

    public static class ListAzureSqlDatabaseDbExtensions
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
            this List<AzureSqlDatabaseDb> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSqlDatabaseDb> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSqlDatabaseDb());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureSqlDatabaseDb> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types