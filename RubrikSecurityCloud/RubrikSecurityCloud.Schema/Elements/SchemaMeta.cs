// SchemaMeta.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

using System;
using System.Collections;
using System.Collections.Generic;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    public static class SchemaMeta
    {
        /// <summary>
        /// The version of the schema used to generate the SDK.
        /// </summary>
        public static string GraphqlSchemaVersion = "v20230913-54" ;

        /// <summary>
        /// All GraphQL interface names.
        /// </summary>
        public enum GqlInterfaceName
        {
            Unknown,
            AwsNativeAccountDescendantType,
            AwsNativeAccountLogicalChildType,
            AwsNativeHierarchyObject,
            AzureNativeHierarchyObjectType,
            CassandraKeyspaceDescendantType,
            CassandraKeyspacePhysicalChildType,
            CassandraSourceDescendantType,
            CassandraSourcePhysicalChildType,
            CdmHierarchyObject,
            CdmHierarchySnappableNew,
            CloudAccount,
            CloudDirectHierarchyObject,
            CloudDirectHierarchyWorkload,
            Db2InstanceDescendantType,
            Db2InstancePhysicalChildType,
            DisplayableValue,
            ExchangeDagDescendantType,
            ExchangeServerDescendantType,
            FailoverClusterAppDescendantType,
            FailoverClusterAppPhysicalChildType,
            FailoverClusterTopLevelDescendantType,
            FilesetTemplateDescendantType,
            FilesetTemplatePhysicalChildType,
            GcpNativeProjectDescendantType,
            GcpNativeProjectLogicalChildType,
            GenericSnapshot,
            HierarchyObject,
            HierarchySnappable,
            HostFailoverClusterDescendantType,
            HostFailoverClusterPhysicalChildType,
            HostShareDescendantType,
            HostSharePhysicalChildType,
            HyperVclusterDescendantType,
            HyperVclusterLogicalChildType,
            HyperVscvmmDescendantType,
            HyperVscvmmLogicalChildType,
            HypervServerDescendantType,
            HypervServerLogicalChildType,
            HypervTopLevelDescendantType,
            K8sClusterDescendant,
            ManagedVolumeDescendantType,
            ManagedVolumeMountDescendantType,
            ManagedVolumeMountPhysicalChildType,
            ManagedVolumePhysicalChildType,
            MongoCollectionSetDescendantType,
            MongoCollectionSetPhysicalChildType,
            MongoDatabaseDescendantType,
            MongoDatabasePhysicalChildType,
            MongodbDatabaseDescendantType,
            MongodbDatabasePhysicalChildType,
            MongodbSourceDescendantType,
            MongodbSourcePhysicalChildType,
            MongoSourceDescendantType,
            MongoSourcePhysicalChildType,
            MssqlAvailabilityGroupDescendantType,
            MssqlAvailabilityGroupLogicalChildType,
            MssqlInstanceDescendantType,
            MssqlInstanceLogicalChildType,
            MssqlTopLevelDescendantType,
            NasNamespaceDescendantType,
            NasNamespaceLogicalChildType,
            NasShareDescendantType,
            NasShareLogicalChildType,
            NasSystemDescendantType,
            NasSystemLogicalChildType,
            NasVolumeDescendantType,
            NasVolumeLogicalChildType,
            NutanixCategoryDescendantType,
            NutanixCategoryLogicalChildType,
            NutanixCategoryValueDescendantType,
            NutanixCategoryValueLogicalChildType,
            NutanixClusterDescendantType,
            NutanixClusterLogicalChildType,
            NutanixPrismCentralDescendantType,
            NutanixPrismCentralLogicalChildType,
            NutanixTopLevelDescendantType,
            O365AppObject,
            O365ExchangeObject,
            O365FullSpObject,
            O365OnedriveObject,
            O365OrgDescendant,
            O365SharepointObject,
            O365TeamsChannelObject,
            O365UserDescendant,
            O365UserDescendantMetadata,
            OracleDataGuardGroupDescendantType,
            OracleDataGuardGroupLogicalChildType,
            OracleHostDescendantType,
            OracleHostLogicalChildType,
            OracleRacDescendantType,
            OracleRacLogicalChildType,
            OracleTopLevelDescendantType,
            PhysicalHostDescendantType,
            PhysicalHostPhysicalChildType,
            PolarisHierarchyObject,
            PolarisHierarchySnappable,
            PolarisSpecificSnapshot,
            ProtectedObjectSummary,
            SapHanaSystemDescendantType,
            SapHanaSystemPhysicalChildType,
            SlaDomain,
            Target,
            TargetTemplate,
            Value,
            VcdCatalogDescendantType,
            VcdCatalogLogicalChildType,
            VcdDescendantType,
            VcdLogicalChildType,
            VcdOrgDescendantType,
            VcdOrgLogicalChildType,
            VcdOrgVdcDescendantType,
            VcdOrgVdcLogicalChildType,
            VcdTopLevelDescendantType,
            VcdVappDescendantType,
            VcdVappLogicalChildType,
            VsphereComputeClusterDescendantType,
            VsphereComputeClusterPhysicalChildType,
            VsphereDatacenterDescendantType,
            VsphereDatacenterFolderDescendantType,
            VsphereDatacenterFolderLogicalChildType,
            VsphereDatacenterLogicalChildType,
            VsphereDatacenterPhysicalChildType,
            VsphereDatastoreClusterDescendantType,
            VsphereDatastoreClusterPhysicalChildType,
            VsphereFolderDescendantType,
            VsphereFolderLogicalChildType,
            VsphereHostDescendantType,
            VsphereHostPhysicalChildType,
            VsphereResourcePoolDescendantType,
            VsphereResourcePoolPhysicalChildType,
            VsphereTagCategoryDescendantType,
            VsphereTagCategoryTagChildType,
            VsphereTagDescendantType,
            VsphereTagTagChildType,
            VsphereVcenterDescendantType,
            VsphereVcenterLogicalChildType,
            VsphereVcenterPhysicalChildType,
            VsphereVcenterTagChildType,
            WindowsClusterDescendantType,
            WindowsClusterLogicalChildType,
        }

        /// <summary>
        /// All GraphQL type names.
        /// </summary>
        public enum GqlTypeName
        {
            Unknown,
            AboutInformation,
            AbsoluteMonthlyRecurrencePattern,
            AbsoluteYearlyRecurrencePattern,
            AccessGroup,
            AccessGroupConnection,
            AccessGroupEdge,
            AccessUser,
            AccessUserConnection,
            AccessUserEdge,
            AccountProduct,
            AccountSetting,
            ActiveDirectoryAppMetadata,
            ActiveDirectoryObjectsCount,
            Activity,
            ActivityChart,
            ActivityConnection,
            ActivityEdge,
            ActivityResult,
            ActivitySeries,
            ActivitySeriesConnection,
            ActivitySeriesEdge,
            ActivitySeverityLevel,
            ActivityTable,
            ActivityTimelineResult,
            ActivityTimelineResultConnection,
            ActivityTimelineResultEdge,
            AddAndJoinSmbDomainReply,
            AddAwsAuthenticationServerBasedCloudAccountReply,
            AddAwsIamUserBasedCloudAccountReply,
            AddAzureCloudAccountExocomputeConfigurationsReply,
            AddAzureCloudAccountReply,
            AddAzureCloudAccountStatus,
            AddAzureCloudAccountWithoutOauthReply,
            AddCloudNativeSqlServerBackupCredentialsReply,
            AddClusterCertificateReply,
            AddClusterNodesReply,
            AddConfiguredGroupToHierarchyReply,
            AddDb2InstanceReply,
            AddManagedVolumeReply,
            AddMongoSourceReply,
            AddO365OrgResponse,
            AddSapHanaSystemReply,
            AddStorageArrayReply,
            AddStorageArraysReply,
            AddSyslogExportRuleReply,
            AddVmAppConsistentSpecsReply,
            AdGroup,
            AdvancedVirtualMachineSummary,
            AgentStatus,
            AggregatedValues,
            AllEnabledFeaturesForAccountReply,
            AllStorageArraysReply,
            AmiTypeForAwsNativeArchivedSnapshotExportReply,
            Analyzer,
            AnalyzerAccessUsage,
            AnalyzerAccessUsageConnection,
            AnalyzerAccessUsageEdge,
            AnalyzerConnection,
            AnalyzerEdge,
            AnalyzerGroup,
            AnalyzerGroupConnection,
            AnalyzerGroupEdge,
            AnalyzerGroupResult,
            AnalyzerHits,
            AnalyzerMapping,
            AnalyzerResult,
            AnalyzerRiskInstance,
            AnalyzerUsage,
            AnalyzerUsageConnection,
            AnalyzerUsageEdge,
            AnomalyChart,
            AnomalyInfo,
            AnomalyResult,
            AnomalyResultAggregation,
            AnomalyResultConnection,
            AnomalyResultEdge,
            AnomalyResultGroupedData,
            AnomalyResultGroupedDataConnection,
            AnomalyResultGroupedDataEdge,
            AnomalyStatus,
            AnomalyTable,
            AppIdForType,
            AppManifestInfo,
            ArchivalGroupConnectionStatus,
            ArchivalLocationToClusterMapping,
            ArchivalSpec,
            ArchivalStorageUsage,
            ArchivalTieringSpec,
            ArchiveK8sClusterReply,
            ArtifactPolicy,
            ArtifactsToDelete,
            AssignmentResourceDetails,
            AssignmentResourceDetailsConnection,
            AssignmentResourceDetailsEdge,
            AssignMssqlSlaDomainPropertiesAsyncReply,
            AsyncDownloadReply,
            AsyncJobStatus,
            AsyncJobStatusJobError,
            AsyncJobStatusJobId,
            AsyncRequestStatus,
            AttachmentSpecForEbsVolume,
            AttachmentSpecForEc2Instance,
            AttachmentSpecsForManagedDisk,
            AttachmentSpecsForVirtualMachine,
            AuthCounts,
            AuthorizedOperations,
            AuthorizedPrincipal,
            AuthorizedPrincipalConnection,
            AuthorizedPrincipalEdge,
            AutoEnablePolicyClusterConfigReply,
            AwsAccount,
            AwsAccountValidationResponse,
            AwsArtifactsToDelete,
            AwsAuthServerDetail,
            AwsCdmVersion,
            AwsCdmVersionTag,
            AwsCloudAccount,
            AwsCloudAccountCreateResponse,
            AwsCloudAccountFeatureVersion,
            AwsCloudAccountListSecurityGroupsResponse,
            AwsCloudAccountListSubnetsResponse,
            AwsCloudAccountListVpcResponse,
            AwsCloudAccountValidateResponse,
            AwsCloudAccountWithFeatures,
            AwsComputeSettings,
            AwsExocomputeConfig,
            AwsExocomputeConfigsDeletionStatusType,
            AwsExocomputeGetConfigResponse,
            AwsExocomputeSubnetType,
            AwsFeatureConfig,
            AwsImmutabilitySettingsType,
            AwsNativeAccount,
            AwsNativeAccountConnection,
            AwsNativeAccountEdge,
            AwsNativeEbsVolume,
            AwsNativeEbsVolumeConnection,
            AwsNativeEbsVolumeEdge,
            AwsNativeEc2Instance,
            AwsNativeEc2InstanceConnection,
            AwsNativeEc2InstanceEdge,
            AwsNativeEc2InstanceSpecificSnapshot,
            AwsNativeHierarchyObjectConnection,
            AwsNativeHierarchyObjectEdge,
            AwsNativeRdsInstance,
            AwsNativeRdsInstanceConnection,
            AwsNativeRdsInstanceEdge,
            AwsNativeRdsPointInTimeRestoreWindow,
            AwsNativeRegionSpec,
            AwsNativeRoot,
            AwsNativeS3Bucket,
            AwsNativeS3SlaConfig,
            AwsNativeSubnet,
            AwsRdsConfig,
            AwsReplicationTarget,
            AwsRoleBasedAccount,
            AwsRscAccountDetails,
            AwsSecurityGroup,
            AwsSubnet,
            AwsTargetTemplate,
            AwsTrustPolicy,
            AwsTrustPolicyResult,
            AwsVpc,
            AzureAccount,
            AzureAdDirectory,
            AzureAdDirectoryConnection,
            AzureAdDirectoryEdge,
            AzureAdGroup,
            AzureAdObject,
            AzureAdObjectConnection,
            AzureAdObjectEdge,
            AzureAdObjects,
            AzureAdUser,
            AzureArmTemplateByFeature,
            AzureBlobConfig,
            AzureCdmVersion,
            AzureCdmVersionTag,
            AzureCloudAccountFeatureDetail,
            AzureCloudAccountPermissionConfigResponse,
            AzureCloudAccountRolePermission,
            AzureCloudAccountSubscription,
            AzureCloudAccountSubscriptionDetail,
            AzureCloudAccountSubscriptionWithFeatures,
            AzureCloudAccountTenant,
            AzureCloudAccountTenantWithExoConfigs,
            AzureCloudNativeTargetCompanion,
            AzureCmk,
            AzureComputeSettings,
            AzureEncryptionKey,
            AzureExocomputeConfigDetails,
            AzureExocomputeConfigsInAccount,
            AzureExocomputeConfigValidationInfo,
            AzureExocomputeGetConfigResponse,
            AzureExocomputeRegionConfig,
            AzureImmutabilitySettingsType,
            AzureKeyVault,
            AzureManagedIdentity,
            AzureMappedExocomputeSubscription,
            AzureNativeAttachedDiskSpecificSnapshot,
            AzureNativeAvailabilitySet,
            AzureNativeDiskEncryptionSet,
            AzureNativeExportCompatibleDiskTypes,
            AzureNativeExportCompatibleVmSizes,
            AzureNativeHierarchyObjectTypeConnection,
            AzureNativeHierarchyObjectTypeEdge,
            AzureNativeManagedDisk,
            AzureNativeManagedDiskConnection,
            AzureNativeManagedDiskEdge,
            AzureNativeRegionSpec,
            AzureNativeResourceGroup,
            AzureNativeResourceGroupConnection,
            AzureNativeResourceGroupEdge,
            AzureNativeResourceGroupSlaAssignment,
            AzureNativeRoot,
            AzureNativeSecurityGroup,
            AzureNativeSqlDatabasePointInTimeRestoreWindow,
            AzureNativeStorageAccount,
            AzureNativeSubnet,
            AzureNativeSubscription,
            AzureNativeSubscriptionConnection,
            AzureNativeSubscriptionEdge,
            AzureNativeSubscriptionEnabledFeature,
            AzureNativeVirtualMachine,
            AzureNativeVirtualMachineConnection,
            AzureNativeVirtualMachineEdge,
            AzureNativeVirtualNetwork,
            AzureNativeVmSpecificSnapshot,
            AzureNetworkSecurityGroupResp,
            AzureNetworkSubnetResp,
            AzureNetworkSubnetUnusedAddrResp,
            AzureO365ExocomputeCluster,
            AzureOauthConsentKickoffReply,
            AzureRegionsResp,
            AzureReplicationTarget,
            AzureResourceAvailabilityResp,
            AzureResourceGroup,
            AzureResourceGroupInfo,
            AzureRole,
            AzureRoleBasedAccount,
            AzureSnappableLocation,
            AzureSqlDatabaseDb,
            AzureSqlDatabaseDbConfig,
            AzureSqlDatabaseDbConnection,
            AzureSqlDatabaseDbEdge,
            AzureSqlDatabaseServer,
            AzureSqlDatabaseServerConnection,
            AzureSqlDatabaseServerEdge,
            AzureSqlDatabaseServerElasticPool,
            AzureSqlManagedInstanceDatabase,
            AzureSqlManagedInstanceDatabaseConnection,
            AzureSqlManagedInstanceDatabaseEdge,
            AzureSqlManagedInstanceDbConfig,
            AzureSqlManagedInstanceServer,
            AzureSqlManagedInstanceServerConnection,
            AzureSqlManagedInstanceServerEdge,
            AzureStorageAccount,
            AzureSubscription,
            AzureSubscriptionConnection,
            AzureSubscriptionEdge,
            AzureSubscriptionMissingPermissions,
            AzureSubscriptionWithExocomputeMapping,
            AzureSubscriptionWithExoConfigs,
            AzureSubscriptionWithFeaturesType,
            AzureTag,
            AzureTargetTemplate,
            AzureUserAssignedManagedIdentity,
            AzureUserRoleResp,
            BackupEventStatus,
            BackupTaskDiagnosticInfo,
            BackupWindow,
            BaseGuestCredentialDetail,
            BaseSnapshotSummary,
            BasicSnapshotSchedule,
            BatchAsyncJobStatus,
            BatchAsyncRequestStatus,
            BatchExportHypervVmReply,
            BatchExportNutanixVmReply,
            BatchInstantRecoverHypervVmReply,
            BatchMountHypervVmReply,
            BatchMountNutanixVmReply,
            BatchOnDemandBackupHypervVmReply,
            BatchQuarantineSnapshotReply,
            BatchReleaseFromQuarantineSnapshotReply,
            BatchVmwareCdpLiveInfo,
            BatchVmwareVmRecoverableRanges,
            BeginManagedVolumeSnapshotReply,
            BidirectionalReplicationSpec,
            BlackoutWindow,
            BlackoutWindowResponseInfo,
            BlackoutWindows,
            BlackoutWindowStatus,
            BootstrappableNodeInfo,
            BootstrappableNodeInfoListResponse,
            BrowseMssqlDatabaseSnapshotReply,
            BrowseResponse,
            BrowseResponseListResponse,
            BulkCreateFilesetsReply,
            BulkCreateFilesetTemplatesReply,
            BulkCreateNasFilesetsReply,
            BulkDeleteAwsCloudAccountWithoutCftReply,
            BulkOnDemandSnapshotNutanixVmReply,
            BulkRefreshHostsReply,
            BulkRegisterHostReply,
            BulkUpdateFilesetTemplateReply,
            BulkUpdateHostReply,
            BulkUpdateMssqlDbsReply,
            BulkUpdateOracleDatabasesReply,
            BulkUpdateOracleHostsReply,
            BulkUpdateOracleRacsReply,
            CancelJobReply,
            CapacityContribution,
            CascadingArchivalSpec,
            CassandraBackupParams,
            CassandraColumnFamily,
            CassandraColumnFamilyConnection,
            CassandraColumnFamilyEdge,
            CassandraColumnObject,
            CassandraKeyspace,
            CassandraKeyspaceConnection,
            CassandraKeyspaceDescendantTypeConnection,
            CassandraKeyspaceDescendantTypeEdge,
            CassandraKeyspaceEdge,
            CassandraKeyspacePhysicalChildTypeConnection,
            CassandraKeyspacePhysicalChildTypeEdge,
            CassandraSchemaObject,
            CassandraSource,
            CassandraSourceConnection,
            CassandraSourceDescendantTypeConnection,
            CassandraSourceDescendantTypeEdge,
            CassandraSourceEdge,
            CassandraSourcePhysicalChildTypeConnection,
            CassandraSourcePhysicalChildTypeEdge,
            CassandraSslOptions,
            CcprovisionInfo,
            CcProvisionJobReply,
            CcWithCloudInfo,
            CdmAgentStatus,
            CdmClusterStatus,
            CdmClusterStatusInfo,
            CdmGroupByInfo,
            CdmGroupedSnapshot,
            CdmGroupedSnapshotConnection,
            CdmGroupedSnapshotEdge,
            CdmGuestCredential,
            CdmHierarchyObjectConnection,
            CdmHierarchyObjectEdge,
            CdmHostVolume,
            CdmInventorySubHierarchyRoot,
            CdmManagedAwsTarget,
            CdmManagedAzureTarget,
            CdmManagedGcpTarget,
            CdmManagedGlacierTarget,
            CdmManagedNfsTarget,
            CdmManagedS3CompatibleTarget,
            CdmManagedTapeTarget,
            CdmMongoNode,
            CdmMongoSslParams,
            CdmMssqlDbReplica,
            CdmMssqlDbReplicaAvailabilityInfo,
            CdmNodeDetail,
            CdmOracleRacNode,
            CdmOracleRacNodeOrder,
            CdmOvaDetail,
            CdmSnappableLocation,
            CdmSnapshot,
            CdmSnapshotConnection,
            CdmSnapshotEdge,
            CdmSnapshotGroupBy,
            CdmSnapshotGroupByConnection,
            CdmSnapshotGroupByEdge,
            CdmSnapshotGroupBySummary,
            CdmSnapshotGroupBySummaryConnection,
            CdmSnapshotGroupBySummaryEdge,
            CdmSnapshotLocationRetentionInfo,
            CdmSnapshotRetentionInfo,
            CdmTarget,
            CdmUpgradeAvailabilityReply,
            CdmUpgradeInfo,
            CdmUpgradeRecommendationReply,
            CdmUpgradeReleaseDetail,
            CdmUpgradeReleaseDetailsFromSupportPortalReply,
            CdmWorkload,
            CdmWorkloadSnapshot,
            CdmWorkloadSnapshotConnection,
            CdmWorkloadSnapshotEdge,
            CdpVmInfo,
            CdpVmInfoConnection,
            CdpVmInfoEdge,
            CellData,
            Certificate,
            CertificateConnection,
            CertificateEdge,
            CertificateSummaryListResponse,
            ChangeVfdOnHostReply,
            CheckArchivedSnapshotsLockedReply,
            CheckAzurePersistentStorageSubscriptionCanUnmapReply,
            ClassificationPolicyDetail,
            ClassificationPolicyDetailConnection,
            ClassificationPolicyDetailEdge,
            ClassificationPolicySummary,
            ClassificationPolicyWhitelistDetailedEntry,
            ClearCloudNativeSqlServerBackupCredentialsReply,
            ClosestSnapshotDetail,
            ClosestSnapshotSearchResult,
            CloudAccountAddressBlockV4,
            CloudAccountDetails,
            CloudAccountFeaturePermission,
            CloudAccountsExocomputeAccountMapping,
            CloudAccountSub,
            CloudAccountSubnet,
            CloudAccountVpc,
            CloudAccountWithExocomputeMapping,
            CloudDirectCluster,
            CloudDirectClusterRansomwareInvestigationEnablement,
            CloudDirectNasExport,
            CloudDirectSite,
            CloudDirectSystems,
            CloudInstantiationSpec,
            CloudNativeAccountIdWithName,
            CloudNativeCheckRbaConnectivityReply,
            CloudNativeCustomerTagsReply,
            CloudNativeDatabaseBackupSetupSpecs,
            CloudNativeFileRecoveryFeasibility,
            CloudNativeFileVersion,
            CloudNativeLabel,
            CloudNativeRegion,
            CloudNativeSnapshotDetailsForRecovery,
            CloudNativeSnapshotDetailsForRecoveryReply,
            CloudNativeSnapshotInfo,
            CloudNativeSnapshotTypeDetails,
            CloudNativeSnapshotTypeDetailsReply,
            CloudNativeSqlServerSetupScript,
            CloudNativeTagRule,
            CloudNativeVersionedFile,
            CloudNativeVersionedFileConnection,
            CloudNativeVersionedFileEdge,
            Cluster,
            ClusterArchivalSpec,
            ClusterConnection,
            ClusterCsr,
            ClusterDisk,
            ClusterDiskConnection,
            ClusterDiskEdge,
            ClusterDnsReply,
            ClusterEdge,
            ClusterGeolocation,
            ClusterGroupBy,
            ClusterGroupByConnection,
            ClusterGroupByEdge,
            ClusterHealthAggregation,
            ClusterHostGroupInfo,
            ClusterInfCidrs,
            ClusterIpMapping,
            ClusterIpv6ModeReply,
            ClusterLicenseCapacityValidations,
            ClusterLicenseInfo,
            ClusterMetric,
            ClusterNode,
            ClusterNodeConnection,
            ClusterNodeEdge,
            ClusterNodeInterfaceCidr,
            ClusterNodeStats,
            ClusterOperationJobProgress,
            ClusterProxyReply,
            ClusterRegistrationProductInfoType,
            ClusterRegistrationToken,
            ClusterReplicationTarget,
            ClusterReportMigrationJobStatus,
            ClusterSlaDomain,
            ClusterSlaDomainConnection,
            ClusterSlaDomainEdge,
            ClusterState,
            ClusterStatsAggregation,
            ClusterStorageArrays,
            ClusterTimezone,
            ClusterType,
            ClusterVisibilityConfig,
            ClusterVisibilityInfo,
            ClusterWebCertAndIpmi,
            ClusterWebSignedCertificateReply,
            Column,
            CompleteAzureAdAppSetupReply,
            CompleteAzureCloudAccountOauthReply,
            ComplianceStatus,
            ComputeClusterDetail,
            ComputeClusterSummary,
            ConfigProtectionInfo,
            ConnectionStatusDetails,
            ContentNode,
            ContentNodeAttribute,
            CountOfObjectsProtectedBySlAsResult,
            Crawl,
            CrawlConnection,
            CrawlEdge,
            CrawlObj,
            CrawlObjConnection,
            CrawlObjEdge,
            CreateAwsExocomputeConfigsReply,
            CreateAzureSaasAppAadReply,
            CreateCloudNativeAwsStorageSettingReply,
            CreateCloudNativeAzureStorageSettingReply,
            CreateCloudNativeLabelRuleReply,
            CreateCloudNativeRcvAzureStorageSettingReply,
            CreateCloudNativeTagRuleReply,
            CreateCustomReportReply,
            CreateFailoverClusterAppReply,
            CreateFailoverClusterReply,
            CreateGuestCredentialReply,
            CreateIntegrationReply,
            CreateIntegrationsReply,
            CreateK8sAgentManifestReply,
            CreateK8sClusterReply,
            CreateO365AppKickoffResp,
            CreateOnDemandJobReply,
            CreateOrgReply,
            CreateOrgSwitchSessionReply,
            CreateRcvPrivateEndpointApprovalRequestReply,
            CreateScheduledReportReply,
            CreateServiceAccountReply,
            CreateVappsInstantRecoveryReply,
            CreateVsphereAdvancedTagReply,
            CreateVsphereVcenterReply,
            CreateWebhookReply,
            Csr,
            CsrConnection,
            CsrEdge,
            CurrentStateInfo,
            CustomAnalyzerMatch,
            CustomerManagedPolicy,
            CustomReportFilters,
            DailyAnalysisDetails,
            DailyRecurrencePattern,
            DailySnapshotSchedule,
            DataCenterSummary,
            DataGuardGroupMember,
            DataLocation,
            DataLocationSupportedCluster,
            Datastore,
            DatastoreFreespaceThresholdType,
            DataStoreSummary,
            DayOfWeekOpt,
            Db2AppMetadata,
            Db2Config,
            Db2DataBackupFile,
            Db2Database,
            Db2DatabaseConnection,
            Db2DatabaseEdge,
            Db2HadrInstanceInfo,
            Db2HadrMetadata,
            Db2Instance,
            Db2InstanceConnection,
            Db2InstanceDescendantTypeConnection,
            Db2InstanceDescendantTypeEdge,
            Db2InstanceEdge,
            Db2InstancePhysicalChildTypeConnection,
            Db2InstancePhysicalChildTypeEdge,
            Db2InstanceSummary,
            Db2LogBackupFile,
            Db2LogSnapshot,
            Db2LogSnapshotAppMetadata,
            Db2LogSnapshotConnection,
            Db2LogSnapshotEdge,
            Db2RecoverableRange,
            Db2RecoverableRangeConnection,
            Db2RecoverableRangeEdge,
            Db2WorkloadDataBackupFile,
            Db2WorkloadDataSnapshotMetadata,
            DbLogReportProperties,
            DbLogReportSummary,
            DbLogReportSummaryListReply,
            DbParameterGroup,
            DeleteAwsCloudAccountWithoutCftResp,
            DeleteAwsExocomputeConfigsReply,
            DeleteAzureCloudAccountExocomputeConfigurationsReply,
            DeleteAzureCloudAccountReply,
            DeleteAzureCloudAccountStatus,
            DeleteAzureCloudAccountWithoutOauthReply,
            DeleteManagedVolumeReply,
            DeleteStorageArraysReply,
            DevicePathToVolumeSnapshotId,
            DevicePathToVolumeSnapshotIdMap,
            DhrcActiveRecommendation,
            DhrcCollectedMetric,
            DhrcKeyValue,
            DhrcScore,
            DhrcScoreContext,
            DhrcScoreMetric,
            DiffData,
            DiffResult,
            DisableTargetReply,
            DiscoverNasSystemSummary,
            DiskInfo,
            DiskStatus,
            DisplayableValueBoolean,
            DisplayableValueComplianceRange,
            DisplayableValueDateRange,
            DisplayableValueDateTime,
            DisplayableValueFloat,
            DisplayableValueInteger,
            DisplayableValueLong,
            DisplayableValueNull,
            DisplayableValueString,
            DlpConfig,
            DlpConfigGenericNas,
            DlpConfigVmwareVm,
            DlpStatus,
            DlsArchivalLocation,
            DownloadCdmUpgradesPdfReply,
            DownloadCsvReply,
            DownloadFilesReply,
            DownloadJobInfo,
            DownloadPackageReply,
            DownloadPackageReplyWithUuid,
            DownloadPackageStatusReply,
            DownloadResultsCsvReply,
            DownloadThreatHuntCsvReply,
            DuplicatedVapp,
            DuplicatedVm,
            Duration,
            EdgeWindowsToolLink,
            EffectiveSlaHolder,
            ElasticStorageConfig,
            EnableAutomaticFmdUploadReply,
            EnableDisableAppConsistencyReply,
            EnableTargetReply,
            EndDateRecurrenceRange,
            EndManagedVolumeSnapshotReply,
            ErrorInfo,
            EulaState,
            EventDigest,
            ExchangeDag,
            ExchangeDagConnection,
            ExchangeDagDescendantTypeConnection,
            ExchangeDagDescendantTypeEdge,
            ExchangeDagEdge,
            ExchangeDagSummary,
            ExchangeDatabase,
            ExchangeDatabaseConnection,
            ExchangeDatabaseEdge,
            ExchangeLiveMount,
            ExchangeLiveMountConnection,
            ExchangeLiveMountEdge,
            ExchangeServer,
            ExchangeServerConnection,
            ExchangeServerDescendantTypeConnection,
            ExchangeServerDescendantTypeEdge,
            ExchangeServerEdge,
            ExistingUser,
            ExocomputeHealthCheckStatus,
            ExocomputeStorageAccountIds,
            ExportUrlSpecs,
            ExternalArtifactMapReply,
            FailoverChart,
            FailoverClusterApp,
            FailoverClusterAppConfig,
            FailoverClusterAppConnection,
            FailoverClusterAppDescendantTypeConnection,
            FailoverClusterAppDescendantTypeEdge,
            FailoverClusterAppEdge,
            FailoverClusterAppPhysicalChildTypeConnection,
            FailoverClusterAppPhysicalChildTypeEdge,
            FailoverClusterAppSource,
            FailoverClusterAppSummary,
            FailoverClusterDetail,
            FailoverClusterNode,
            FailoverClusterNodeOrder,
            FailoverClusterStatus,
            FailoverClusterSummary,
            FailoverClusterTopLevelDescendantTypeConnection,
            FailoverClusterTopLevelDescendantTypeEdge,
            FailoverTable,
            Failure,
            FeatureCdmVersionReply,
            FeatureDetail,
            FeatureListMinimumCdmVersionReply,
            FeaturePermission,
            FederatedLoginStatus,
            FileAccessResult,
            FileDetails,
            FileResult,
            FileResultConnection,
            FileResultEdge,
            FilesetArraySpec,
            FilesetDetail,
            FilesetOptions,
            FilesetSnapshotDetail,
            FilesetSnapshotSummary,
            FilesetSnapshotVerbose,
            FilesetSummary,
            FilesetTemplate,
            FilesetTemplateConnection,
            FilesetTemplateCreate,
            FilesetTemplateDescendantTypeConnection,
            FilesetTemplateDescendantTypeEdge,
            FilesetTemplateDetail,
            FilesetTemplateEdge,
            FilesetTemplatePhysicalChildTypeConnection,
            FilesetTemplatePhysicalChildTypeEdge,
            FilesetUpdate,
            FileVersion,
            FilterCreateResponse,
            FilterOption,
            FilterPreviewResult,
            FilterPreviewResultListResponse,
            FinalizeAwsCloudAccountDeletionReply,
            FinalizeAwsCloudAccountProtectionReply,
            FullSpObjectExclusion,
            FullSpSiteExclusions,
            GatewayInfo,
            GcpCloudAccountAddProjectDetail,
            GcpCloudAccountAddProjectsReply,
            GcpCloudAccountDeleteProjectsReply,
            GcpCloudAccountFeatureDetail,
            GcpCloudAccountMissingPermissionsForAddition,
            GcpCloudAccountOauthCompleteReply,
            GcpCloudAccountOauthInitiateReply,
            GcpCloudAccountProject,
            GcpCloudAccountProjectDeleteStatus,
            GcpCloudAccountProjectDetail,
            GcpCloudAccountProjectForOauth,
            GcpCloudAccountProjectUpgradeStatus,
            GcpCloudAccountUpgradeProjectsReply,
            GcpNativeAttachmentDetails,
            GcpNativeDisk,
            GcpNativeDiskConnection,
            GcpNativeDiskEdge,
            GcpNativeFirewallRule,
            GcpNativeGceInstance,
            GcpNativeGceInstanceConnection,
            GcpNativeGceInstanceEdge,
            GcpNativeKmsCryptoKey,
            GcpNativeNetwork,
            GcpNativeProject,
            GcpNativeProjectConnection,
            GcpNativeProjectEdge,
            GcpNativeProjectLogicalChildTypeConnection,
            GcpNativeProjectLogicalChildTypeEdge,
            GcpNativeRegion,
            GcpNativeSubnetwork,
            GcpOauthUserInfo,
            GcpPermission,
            GenerateConfigProtectionRestoreFormReply,
            GenerateTotpSecretReply,
            GenericSnapshotConnection,
            GenericSnapshotEdge,
            GenericTimeRange,
            GeoLocation,
            GetAnomalyDetailsReply,
            GetAzureHostTypeResp,
            GetAzureO365ExocomputeResp,
            GetCloudNativeLabelRulesReply,
            GetCloudNativeTagRulesReply,
            GetDashboardSummaryReply,
            GetHealthMonitorPolicyStatusReply,
            GetImplicitlyAuthorizedAncestorSummariesResponse,
            GetImplicitlyAuthorizedObjectSummariesResponse,
            GetLambdaConfigReply,
            GetLicensedProductsInfoReply,
            GetMfaSettingReply,
            GetMosaicRecoverableRangeResponse,
            GetO365ServiceStatusResp,
            GetO365StorageStatsResp,
            GetPendingSlaAssignmentsReply,
            GetPipelineHealthReply,
            GetPoliciesTimelineReply,
            GetS3BucketStateForRecoveryReply,
            GetSchemaResponse,
            GetSmbConfigurationReply,
            GetTaskchainStatusReply,
            GetTotpStatusReply,
            GetUserDetailReply,
            GetUserSessionManagementConfigReply,
            GetWhitelistReply,
            GetWorkloadAlertSettingReply,
            GlobalFileSearchReply,
            GlobalManagerConnectivity,
            GlobalManagerUrl,
            GlobalSearchFile,
            GlobalSlaForFilter,
            GlobalSlaForFilterConnection,
            GlobalSlaForFilterEdge,
            GlobalSlaReply,
            GlobalSlaStatus,
            GlobalSlaStatusConnection,
            GlobalSlaStatusEdge,
            GlobalSlaSyncStatus,
            Group,
            GroupConnection,
            GroupCount,
            GroupCountListWithTotal,
            GroupEdge,
            GuestCredentialDetailListResponse,
            GuestOsCredential,
            GuestOsCredentialConnection,
            GuestOsCredentialEdge,
            HashDetail,
            HdfsBaseConfig,
            HdfsHost,
            HealthPolicyStatus,
            HelpContentSnippet,
            HelpContentSnippetConnection,
            HelpContentSnippetEdge,
            HierarchyObjectCommon,
            HierarchyObjectConnection,
            HierarchyObjectEdge,
            HierarchySnappableConnection,
            HierarchySnappableEdge,
            HierarchySnappableFileVersion,
            Hits,
            HostConnectionStatus,
            HostConnectivitySummary,
            HostDetail,
            HostDiagnosisSummary,
            HostFailoverCluster,
            HostFailoverClusterConnection,
            HostFailoverClusterDescendantTypeConnection,
            HostFailoverClusterDescendantTypeEdge,
            HostFailoverClusterEdge,
            HostFailoverClusterPhysicalChildTypeConnection,
            HostFailoverClusterPhysicalChildTypeEdge,
            HostGroupInfo,
            HostInfo,
            HostShare,
            HostShareConnection,
            HostShareDescendantTypeConnection,
            HostShareDescendantTypeEdge,
            HostShareEdge,
            HostSharePhysicalChildTypeConnection,
            HostSharePhysicalChildTypeEdge,
            HostSummary,
            HostVfdInstallResponse,
            HostVolumeSummary,
            HotAddBandwidthInfo,
            HotAddNetworkConfigWithName,
            HotAddProxyVmInfo,
            HotAddProxyVmInfoListResponse,
            HourlySnapshotSchedule,
            HypervAsyncRequestFailureSummary,
            HypervAsyncRequestSuccessSummary,
            HyperVcluster,
            HyperVclusterDescendantTypeConnection,
            HyperVclusterDescendantTypeEdge,
            HyperVclusterLogicalChildTypeConnection,
            HyperVclusterLogicalChildTypeEdge,
            HypervHostSummary,
            HypervHostSummaryListResponse,
            HyperVliveMount,
            HyperVliveMountConnection,
            HyperVliveMountEdge,
            HyperVscvmm,
            HyperVscvmmConnection,
            HyperVscvmmDescendantTypeConnection,
            HyperVscvmmDescendantTypeEdge,
            HyperVscvmmEdge,
            HyperVscvmmLogicalChildTypeConnection,
            HyperVscvmmLogicalChildTypeEdge,
            HypervScvmmSummary,
            HypervScvmmUpdate,
            HypervScvmmUpdateReply,
            HypervServer,
            HypervServerDescendantTypeConnection,
            HypervServerDescendantTypeEdge,
            HypervServerLogicalChildTypeConnection,
            HypervServerLogicalChildTypeEdge,
            HyperVstatus,
            HypervTopLevelDescendantTypeConnection,
            HypervTopLevelDescendantTypeEdge,
            HypervVirtualDiskInfo,
            HyperVvirtualMachine,
            HyperVvirtualMachineConnection,
            HypervVirtualMachineDetail,
            HyperVvirtualMachineEdge,
            HypervVirtualMachineMountSummary,
            HypervVirtualMachineSummary,
            HypervVirtualMachineUpdate,
            HypervVmAgentStatus,
            IbmCosDetailsType,
            IdentityProvider,
            IndicatorOfCompromise,
            InfrastructureChart,
            InfrastructureTable,
            InstalledVersionGroupCount,
            Integration,
            IntegrationConfig,
            InterfaceCidr,
            InternalBulkUpdateHostResponse,
            InternalChangeVfdOnHostResponse,
            InternalGetClusterIpsResponse,
            InternalGetDefaultGatewayResponse,
            InternalReplicationBandwidthIncomingResponse,
            InternalReplicationBandwidthOutgoingResponse,
            InventoryRoot,
            InventorySubHierarchyRoot,
            InvestigationCsvDownloadLinkReply,
            IpmiAccess,
            IpRule,
            IsCloudNativeTagRuleNameUniqueReply,
            Issue,
            IssueConnection,
            IssueEdge,
            IssueEvent,
            IsVolumeSnapshotRestorableReply,
            JobMetadata,
            JobReply,
            JobsReply,
            K8sAgentManifestInfo,
            K8sAppManifest,
            K8sCluster,
            K8sClusterConnection,
            K8sClusterDescendantConnection,
            K8sClusterDescendantEdge,
            K8sClusterEdge,
            K8sClusterInfo,
            K8sClusterPortsInfo,
            K8sNamespace,
            K8sNamespaceConnection,
            K8sNamespaceEdge,
            K8sRbsInfo,
            K8sSnapshotInfo,
            KmsEncryptionKey,
            KmsSpec,
            KnowledgeBaseArticle,
            Label,
            LabelRule,
            LambdaFeatureHistory,
            LambdaSettings,
            LatestUserNote,
            LdapIntegration,
            LdapIntegrationConnection,
            LdapIntegrationEdge,
            LdapServer,
            LdapTotpStatus,
            LegalHoldInfo,
            LegalHoldSnappableDetail,
            LegalHoldSnappableDetailConnection,
            LegalHoldSnappableDetailEdge,
            LegalHoldSnapshotDetail,
            LegalHoldSnapshotDetailConnection,
            LegalHoldSnapshotDetailEdge,
            License,
            LicensedClusterProduct,
            LicensesForClusterProductReply,
            Link,
            LinuxFileset,
            ListCidrsForComputeSettingReply,
            ListIntegrationsReply,
            ListLocationsReply,
            ListStoredDiskLocationsReply,
            ListStoreResponse,
            ListVersionResponse,
            LocationImmutabilityType,
            LocationPathPoint,
            LockoutConfig,
            LockoutState,
            LogConfigResult,
            LookupAccountReply,
            M365Region,
            M365RegionsResp,
            M365Snapshot,
            MalwareMatch,
            MalwareScanFileCriteria,
            MalwareScanFileSizeLimits,
            MalwareScanFileTimeLimits,
            MalwareScanInSnapshotResult,
            MalwareScanPathFilter,
            MalwareScanResult,
            MalwareScanSnapshotLimit,
            MalwareScanStats,
            ManagedHierarchyObjectAncestor,
            ManagedObjectPendingSlaInfo,
            ManagedObjectSlaInfo,
            ManagedVolume,
            ManagedVolumeAppMetadata,
            ManagedVolumeChannelConfig,
            ManagedVolumeConnection,
            ManagedVolumeDescendantTypeConnection,
            ManagedVolumeDescendantTypeEdge,
            ManagedVolumeEdge,
            ManagedVolumeExport,
            ManagedVolumeExportChannel,
            ManagedVolumeExportChannelStats,
            ManagedVolumeExportConfig,
            ManagedVolumeHostDetail,
            ManagedVolumeInventoryStats,
            ManagedVolumeMount,
            ManagedVolumeMountConnection,
            ManagedVolumeMountDescendantTypeConnection,
            ManagedVolumeMountDescendantTypeEdge,
            ManagedVolumeMountEdge,
            ManagedVolumeMountPhysicalChildTypeConnection,
            ManagedVolumeMountPhysicalChildTypeEdge,
            ManagedVolumeMountSpec,
            ManagedVolumePatchConfig,
            ManagedVolumePhysicalChildTypeConnection,
            ManagedVolumePhysicalChildTypeEdge,
            ManagedVolumeQueuedSnapshot,
            ManagedVolumeQueuedSnapshotConnection,
            ManagedVolumeQueuedSnapshotEdge,
            ManagedVolumeQueuedSnapshotGroupBy,
            ManagedVolumeQueuedSnapshotGroupByConnection,
            ManagedVolumeQueuedSnapshotGroupByEdge,
            ManagedVolumeSlaClientConfig,
            ManagedVolumeSlaConfig,
            ManagedVolumeSlaScriptConfig,
            ManagedVolumeSmbShare,
            ManagedVolumeSnapshotLinks,
            ManagedVolumeSnapshotStats,
            ManagedVolumeSnapshotSummary,
            ManagedVolumeStats,
            MapAzureCloudAccountExocomputeSubscriptionReply,
            MapAzureCloudAccountToPersistentStorageLocationReply,
            MapCloudAccountExocomputeAccountReply,
            Metadata,
            MetricTimeSeries,
            Microsoft365RansomwareInvestigationEnablement,
            MinuteSnapshotSchedule,
            MissedSnapshot,
            MissedSnapshotCommon,
            MissedSnapshotCommonConnection,
            MissedSnapshotCommonEdge,
            MissedSnapshotGroupBy,
            MissedSnapshotGroupByConnection,
            MissedSnapshotGroupByEdge,
            MissedSnapshotListResponse,
            MissedSnapshotTimeUnitConfig,
            ModifyIpmiReply,
            MongoCollection,
            MongoCollectionConnection,
            MongoCollectionEdge,
            MongoCollectionSet,
            MongoCollectionSetDescendantTypeConnection,
            MongoCollectionSetDescendantTypeEdge,
            MongoCollectionSetPhysicalChildTypeConnection,
            MongoCollectionSetPhysicalChildTypeEdge,
            MongoConfig,
            MongoDatabase,
            MongoDatabaseConnection,
            MongoDatabaseDescendantTypeConnection,
            MongoDatabaseDescendantTypeEdge,
            MongoDatabaseEdge,
            MongoDatabasePhysicalChildTypeConnection,
            MongoDatabasePhysicalChildTypeEdge,
            MongodbBackupParams,
            MongodbCollection,
            MongodbCollectionConnection,
            MongodbCollectionEdge,
            MongodbDatabase,
            MongodbDatabaseConnection,
            MongodbDatabaseDescendantTypeConnection,
            MongodbDatabaseDescendantTypeEdge,
            MongodbDatabaseEdge,
            MongodbDatabasePhysicalChildTypeConnection,
            MongodbDatabasePhysicalChildTypeEdge,
            MongodbHost,
            MongodbSource,
            MongodbSourceConfigParams,
            MongodbSourceConnection,
            MongodbSourceDescendantTypeConnection,
            MongodbSourceDescendantTypeEdge,
            MongodbSourceEdge,
            MongodbSourcePhysicalChildTypeConnection,
            MongodbSourcePhysicalChildTypeEdge,
            MongodbSslOptions,
            MongoRecoverableRange,
            MongoRecoverableRanges,
            MongoSnapshotGroupBy,
            MongoSnapshotGroupByConnection,
            MongoSnapshotGroupByEdge,
            MongoSource,
            MongoSourceConnection,
            MongoSourceDescendantTypeConnection,
            MongoSourceDescendantTypeEdge,
            MongoSourceEdge,
            MongoSourcePhysicalChildTypeConnection,
            MongoSourcePhysicalChildTypeEdge,
            MonthlySnapshotSchedule,
            MosaicAsyncResponse,
            MosaicRecoverableRangeObject,
            MosaicRecoveryRangeObject,
            MosaicRecoveryRangeResponse,
            MosaicSnapshot,
            MosaicSnapshotConnection,
            MosaicSnapshotEdge,
            MosaicSnapshotGroupByType,
            MosaicSnapshotGroupByTypeConnection,
            MosaicSnapshotGroupByTypeEdge,
            MosaicStorageLocation,
            MosaicStoreConnectionParameters,
            MosaicStoreObject,
            MosaicVersionObject,
            MountDiskReply,
            MountedVolume,
            MssqlAvailabilityGroup,
            MssqlAvailabilityGroupDescendantTypeConnection,
            MssqlAvailabilityGroupDescendantTypeEdge,
            MssqlAvailabilityGroupLogicalChildTypeConnection,
            MssqlAvailabilityGroupLogicalChildTypeEdge,
            MssqlBackup,
            MssqlConfig,
            MssqlDatabase,
            MssqlDatabaseConnection,
            MssqlDatabaseEdge,
            MssqlDatabaseLiveMount,
            MssqlDatabaseLiveMountConnection,
            MssqlDatabaseLiveMountEdge,
            MssqlDbDetail,
            MssqlDbReplica,
            MssqlDbReplicaAvailabilityInfo,
            MssqlDbSummary,
            MssqlInstance,
            MssqlInstanceDescendantTypeConnection,
            MssqlInstanceDescendantTypeEdge,
            MssqlInstanceLogicalChildTypeConnection,
            MssqlInstanceLogicalChildTypeEdge,
            MssqlInstanceSummary,
            MssqlInstanceSummaryListResponse,
            MssqlLogShippingLinks,
            MssqlLogShippingStatusInfo,
            MssqlLogShippingSummary,
            MssqlLogShippingSummaryV2,
            MssqlLogShippingSummaryV2ListResponse,
            MssqlLogShippingTarget,
            MssqlLogShippingTargetConnection,
            MssqlLogShippingTargetEdge,
            MssqlMissedRecoverableRange,
            MssqlMissedRecoverableRangeError,
            MssqlMissedRecoverableRangeListResponse,
            MssqlNonSlaProperties,
            MssqlRecoverableRange,
            MssqlRecoverableRangeListResponse,
            MssqlRestoreEstimateResult,
            MssqlRestoreFile,
            MssqlRootProperties,
            MssqlScriptDetail,
            MssqlSlaRelatedProperties,
            MssqlTopLevelDescendantTypeConnection,
            MssqlTopLevelDescendantTypeEdge,
            MssqlUnprotectableReason,
            NasBaseConfig,
            NasFileset,
            NasNamespace,
            NasNamespaceConnection,
            NasNamespaceDescendantTypeConnection,
            NasNamespaceDescendantTypeEdge,
            NasNamespaceEdge,
            NasNamespaceLogicalChildTypeConnection,
            NasNamespaceLogicalChildTypeEdge,
            NasShare,
            NasShareDescendantTypeConnection,
            NasShareDescendantTypeEdge,
            NasShareLogicalChildTypeConnection,
            NasShareLogicalChildTypeEdge,
            NasSystem,
            NasSystemConnection,
            NasSystemDescendantTypeConnection,
            NasSystemDescendantTypeEdge,
            NasSystemEdge,
            NasSystemLogicalChildTypeConnection,
            NasSystemLogicalChildTypeEdge,
            NasVolume,
            NasVolumeDescendantTypeConnection,
            NasVolumeDescendantTypeEdge,
            NasVolumeLogicalChildTypeConnection,
            NasVolumeLogicalChildTypeEdge,
            NcdBackEndCapacity,
            NcdFilesObjectProtectionStatusData,
            NcdFrontEndCapacity,
            NcdObjectProtectionStatus,
            NcdObjectsOverTimeData,
            NcdSharesObjectProtectionStatusData,
            NcdSlaComplianceData,
            NcdTaskData,
            NcdUsageOverTimeData,
            NetworkHostProject,
            NetworkInfo,
            NetworkInfoListResponse,
            NetworkInterface,
            NetworkInterfaceListResponse,
            NetworkRuleSet,
            NetworkThrottle,
            NetworkThrottleSchedule,
            NetworkThrottleScheduleSummary,
            NetworkThrottleSummaryListResponse,
            NfAnomalyResult,
            NfAnomalyResultConnection,
            NfAnomalyResultEdge,
            NfAnomalyResultGroupedData,
            NfAnomalyResultGroupedDataConnection,
            NfAnomalyResultGroupedDataEdge,
            NodeIp,
            NodePolicyCheckResult,
            NodeRemovalCancelPermissionReply,
            NodeStatus,
            NodeStatusListResponse,
            NodeToReplaceReply,
            NoEndRecurrenceRange,
            NotificationForGetLicenseReply,
            NotificationSettingSummary,
            NotificationSettingSummaryListResponse,
            NtpServerConfiguration,
            NtpServerConfigurationListResponse,
            NtpSymmKeyConfiguration,
            NumberedRecurrenceRange,
            NutanixAsyncRequestFailureSummary,
            NutanixAsyncRequestSuccessSummary,
            NutanixBackupScript,
            NutanixBatchAsyncApiResponse,
            NutanixCategory,
            NutanixCategoryDescendantTypeConnection,
            NutanixCategoryDescendantTypeEdge,
            NutanixCategoryLogicalChildTypeConnection,
            NutanixCategoryLogicalChildTypeEdge,
            NutanixCategoryValue,
            NutanixCategoryValueDescendantTypeConnection,
            NutanixCategoryValueDescendantTypeEdge,
            NutanixCategoryValueLogicalChildTypeConnection,
            NutanixCategoryValueLogicalChildTypeEdge,
            NutanixCluster,
            NutanixClusterConnection,
            NutanixClusterDescendantTypeConnection,
            NutanixClusterDescendantTypeEdge,
            NutanixClusterEdge,
            NutanixClusterLogicalChildTypeConnection,
            NutanixClusterLogicalChildTypeEdge,
            NutanixClusterSummary,
            NutanixContainer,
            NutanixContainerListResponse,
            NutanixLiveMount,
            NutanixLiveMountConnection,
            NutanixLiveMountEdge,
            NutanixNetwork,
            NutanixNetworkListResponse,
            NutanixPrismCentral,
            NutanixPrismCentralConnection,
            NutanixPrismCentralDescendantTypeConnection,
            NutanixPrismCentralDescendantTypeEdge,
            NutanixPrismCentralEdge,
            NutanixPrismCentralLogicalChildTypeConnection,
            NutanixPrismCentralLogicalChildTypeEdge,
            NutanixVm,
            NutanixVmAgentStatus,
            NutanixVmConnection,
            NutanixVmDisk,
            NutanixVmEdge,
            NutanixVmMountSummary,
            NutanixVmSnapshotDetail,
            NutanixVmSnapshotSummary,
            O365App,
            O365AppConnection,
            O365AppEdge,
            O365Calendar,
            O365CalendarEvent,
            O365CalendarEventRecurrence,
            O365CalendarFolder,
            O365ConfiguredGroupMember,
            O365ConfiguredGroupMemberConnection,
            O365ConfiguredGroupMemberEdge,
            O365ConfiguredGroupMetadata,
            O365ConfiguredGroupSpec,
            O365Contact,
            O365ContactFolder,
            O365Email,
            O365ExchangeObjectConnection,
            O365ExchangeObjectEdge,
            O365Folder,
            O365FullSpDescendant,
            O365FullSpObjectConnection,
            O365FullSpObjectEdge,
            O365Group,
            O365GroupConnection,
            O365GroupEdge,
            O365GroupMetadata,
            O365License,
            O365LicenseDetails,
            O365Mailbox,
            O365MailboxConnection,
            O365MailboxEdge,
            O365OauthConsentCompleteReply,
            O365OauthConsentKickoffReply,
            O365Onedrive,
            O365OnedriveConnection,
            O365OnedriveEdge,
            O365OnedriveFile,
            O365OnedriveFolder,
            O365OnedriveObjectConnection,
            O365OnedriveObjectEdge,
            O365Org,
            O365OrgConnection,
            O365OrgDescendantConnection,
            O365OrgDescendantEdge,
            O365OrgEdge,
            O365OrgInfo,
            O365PdlAndWorkloadPair,
            O365PdlGroup,
            O365PdlGroupsReply,
            O365PhysicalDataSizeTimeStamp,
            O365ReplyFields,
            O365SaasSetupKickoffReply,
            O365ServiceAccountStatusResp,
            O365SetupKickoffResp,
            O365SharepointDrive,
            O365SharePointDrive,
            O365SharepointDriveConnection,
            O365SharepointDriveEdge,
            O365SharepointList,
            O365SharepointListConnection,
            O365SharepointListEdge,
            O365SharepointObjectConnection,
            O365SharepointObjectEdge,
            O365Site,
            O365SiteConnection,
            O365SiteEdge,
            O365SiteSpecificSnapshot,
            O365SnapshotItemInfo,
            O365SubscriptionAppTypeCounts,
            O365TeamConvChannel,
            O365TeamConvChannelConnection,
            O365TeamConvChannelEdge,
            O365TeamConversationsSender,
            O365TeamConversationsSenderConnection,
            O365TeamConversationsSenderEdge,
            O365Teams,
            O365TeamsChannel,
            O365TeamsChannelConnection,
            O365TeamsChannelEdge,
            O365TeamsConnection,
            O365TeamsConversations,
            O365TeamsConversationsConnection,
            O365TeamsConversationsEdge,
            O365TeamsEdge,
            O365User,
            O365UserConnection,
            O365UserDescendantConnection,
            O365UserDescendantEdge,
            O365UserDescendantMetadataConnection,
            O365UserDescendantMetadataEdge,
            O365UserEdge,
            OauthAccessToken,
            OauthCodesForEdgeRegReply,
            ObjectIdsForHierarchyType,
            ObjectIdToSnapshotIds,
            ObjectSpecificConfigs,
            ObjectStatus,
            ObjectSummary,
            ObjectType,
            OptionGroup,
            OracleAcoParameterDetail,
            OracleAcoParameterList,
            OracleAcoValueErrorDetail,
            OracleConfig,
            OracleDatabase,
            OracleDatabaseConnection,
            OracleDatabaseEdge,
            OracleDatabaseInstance,
            OracleDatabaseLastValidationStatus,
            OracleDataGuardGroup,
            OracleDataGuardGroupDescendantTypeConnection,
            OracleDataGuardGroupDescendantTypeEdge,
            OracleDataGuardGroupLogicalChildTypeConnection,
            OracleDataGuardGroupLogicalChildTypeEdge,
            OracleDbDetail,
            OracleDbSnapshotSummary,
            OracleDbSummary,
            OracleDirectoryPaths,
            OracleFileDownloadLink,
            OracleHost,
            OracleHostDescendantTypeConnection,
            OracleHostDescendantTypeEdge,
            OracleHostDetail,
            OracleHostLogicalChildTypeConnection,
            OracleHostLogicalChildTypeEdge,
            OracleHostSummary,
            OracleInstanceProperties,
            OracleLastValidationResult,
            OracleLiveMount,
            OracleLiveMountConnection,
            OracleLiveMountEdge,
            OracleLogBackupConfig,
            OracleMissedRecoverableRange,
            OracleMissedRecoverableRangeListResponse,
            OracleNodeOrder,
            OracleNodeProperties,
            OracleNonSlaProperties,
            OraclePdb,
            OraclePdbApplicationContainer,
            OraclePdbDetails,
            OracleRac,
            OracleRacDescendantTypeConnection,
            OracleRacDescendantTypeEdge,
            OracleRacDetail,
            OracleRacLogicalChildTypeConnection,
            OracleRacLogicalChildTypeEdge,
            OracleRacSummary,
            OracleRecoverableRange,
            OracleRecoverableRangeListResponse,
            OracleTopLevelDescendantTypeConnection,
            OracleTopLevelDescendantTypeEdge,
            OracleUserDetails,
            Org,
            OrgConnection,
            OrgEdge,
            OrgSecurityPolicy,
            OrgsForPrincipalReply,
            OverallRansomwareInvestigationSummary,
            PageInfo,
            ParentAppInfo,
            PasskeyCredentialMetadata,
            PasskeyMetadata,
            PasswordComplexityPolicy,
            PasswordComplexityPolicyTemplate,
            PatchDb2DatabaseReply,
            PatchDb2InstanceReply,
            PatchNutanixMountV1Reply,
            PatchSapHanaSystemReply,
            PathInfo,
            PathNode,
            PathSecInfo,
            PausedClustersInfo,
            PauseSlaReply,
            PauseTargetReply,
            PendingAction,
            PendingActionType,
            PendingEvaluationResults,
            PendingEvaluationResultsReply,
            PendingSnapshotDeletion,
            PendingSnapshotsOfObjectDeletion,
            PerLocationCloudStorageTier,
            Permission,
            PermissionPolicy,
            PermissionsGroupWithVersion,
            PersistentStorage,
            PhoenixRolloutProgress,
            PhysicalHost,
            PhysicalHostConnection,
            PhysicalHostDescendantTypeConnection,
            PhysicalHostDescendantTypeEdge,
            PhysicalHostEdge,
            PhysicalHostPhysicalChildTypeConnection,
            PhysicalHostPhysicalChildTypeEdge,
            PolarisHierarchyObjectConnection,
            PolarisHierarchyObjectEdge,
            PolarisInventorySubHierarchyRoot,
            PolarisSnapshot,
            PolarisSnapshotConnection,
            PolarisSnapshotEdge,
            PolarisSnapshotGroupBy,
            PolarisSnapshotGroupByConnection,
            PolarisSnapshotGroupByEdge,
            PolarisSnapshotGroupByNew,
            PolarisSnapshotGroupByNewConnection,
            PolarisSnapshotGroupByNewEdge,
            PolicyCheckResult,
            PolicyDetail,
            PolicyDetailConnection,
            PolicyDetailEdge,
            PolicyObj,
            PolicyObjConnection,
            PolicyObjectUsage,
            PolicyObjectUsageConnection,
            PolicyObjectUsageEdge,
            PolicyObjEdge,
            PolicyStatus,
            PolicySummary,
            PrecheckFailure,
            PrechecksJobReply,
            PrechecksStatusReply,
            PrecheckStatusNextRunInfo,
            PrepareAwsCloudAccountDeletionReply,
            PrepareFeatureUpdateForAwsCloudAccountReply,
            PrePostScript,
            PreviewerClusterConfig,
            Principal,
            PrincipalAccessInfo,
            PrincipalConnection,
            PrincipalCounts,
            PrincipalEdge,
            PrivateEndpointConnection,
            ProcessedRansomwareInvestigationWorkloadCountReply,
            ProductDocumentation,
            ProductTypeInfo,
            ProtectedObjects,
            ProtectedObjectsConnection,
            ProtectedObjectsEdge,
            ProtectedObjectTypeToSla,
            ProtectedRansomwareInvestigationWorkload,
            ProtectedRansomwareInvestigationWorkloadCountReply,
            ProtectionStatus,
            ProtectionTaskDetailsTableFilter,
            ProxySettings,
            PutSmbConfigurationReply,
            PvcInformation,
            QuarantineInfo,
            QuarantineSpec,
            QuarterlySnapshotSchedule,
            QueryDatastoreFreespaceThresholdsReply,
            QuerySddlReply,
            RansomwareInvestigationAnalysisSummaryReply,
            RansomwareInvestigationEnablementReply,
            RansomwareInvestigationWorkloadScannedCountReply,
            RansomwareResult,
            RansomwareResultConnection,
            RansomwareResultEdge,
            RansomwareResultGroupedData,
            RansomwareResultGroupedDataConnection,
            RansomwareResultGroupedDataEdge,
            RbacObject,
            RbacPermission,
            RbaInstallerUrls,
            RcsArchivalLocationConsumptionStats,
            RcsArchivalLocationStatsRecord,
            RcsAzureArchivalLocationsConsumptionStatsOutput,
            RcsAzureTargetTemplate,
            RcsImmutabilitySettings,
            RcvAccountEntitlement,
            RcvEntitlement,
            RcvEntitlementsUsageDetails,
            RdsInstanceDetailsFromAws,
            RdsInstanceExportDefaults,
            ReadIntegrationReply,
            RecoverableRange,
            RecoverableRangeResponse,
            RecoveryTaskDetailsTableFilter,
            RefreshableObjectConnectionStatus,
            RefreshHostReply,
            RefreshNasSystemsReply,
            RefreshStorageArraysReply,
            Region,
            RegionConnection,
            RegionEdge,
            RegisterAwsFeatureArtifactsReply,
            RegisterCloudClusterReply,
            RegisterNasSystemReply,
            RelatedContent,
            RelativeMonthlyRecurrencePattern,
            RelativeTimeRange,
            RelativeYearlyRecurrencePattern,
            RemoveNodeForReplacementReply,
            RemoveVlansReply,
            ReplaceClusterNodeReply,
            ReplicatedSnapshotInfo,
            ReplicationCluster,
            ReplicationPair,
            ReplicationPairConfigDetails,
            ReplicationPairConnection,
            ReplicationPairEdge,
            ReplicationSource,
            ReplicationSpec,
            ReplicationSpecV2,
            ReplicationTarget,
            ReplicationToCloudLocationSpec,
            ReplicationToCloudRegionSpec,
            ReportMigrationStatus,
            ReportMigrationStatusConnection,
            ReportMigrationStatusCountItem,
            ReportMigrationStatusEdge,
            ReportsMigrationCount,
            RequestedMatchDetails,
            RequestErrorInfo,
            RequestStatus,
            RequestSuccess,
            ResourceGroup,
            ResourceGroupConnection,
            ResourceGroupEdge,
            ResponseSuccess,
            RestoreAzureAdObjectsWithPasswordsReply,
            RestoreFormArchivalProxyConfig,
            RestoreFormComputeProxyConfig,
            RestoreFormConfigurationGuestOs,
            RestoreFormConfigurationKmipServer,
            RestoreFormConfigurationLdapServer,
            RestoreFormConfigurationNasHost,
            RestoreFormConfigurationObjectStoreArchivalLocation,
            RestoreFormConfigurationOrganization,
            RestoreFormConfigurationReplicationTarget,
            RestoreFormConfigurationReport,
            RestoreFormConfigurationRole,
            RestoreFormConfigurations,
            RestoreFormConfigurationS3ArchivalLocation,
            RestoreFormConfigurationSlaDomain,
            RestoreFormConfigurationSmtp,
            RestoreFormConfigurationSnmp,
            RestoreFormConfigurationUser,
            RestoreFormConfigurationVcenterServer,
            RestoreFormConfigurationWinAndUnixHost,
            ResumeTargetReply,
            RetryBackupClusterResp,
            RetryBackupResp,
            Role,
            RoleConnection,
            RoleEdge,
            RoleStatus,
            RoleTemplate,
            RoleTemplateConnection,
            RoleTemplateEdge,
            RollingUpgradeInfo,
            RollingUpgradeNodeInfo,
            RollingUpgradeNodeInfoEntry,
            RotateServiceAccountSecretReply,
            RouteConfig,
            Row,
            RowConnection,
            RowEdge,
            RubrikCloudVaultLocation,
            RubrikCloudVaultRansomwareInvestigationEnablement,
            RubrikManagedAwsTarget,
            RubrikManagedAzureTarget,
            RubrikManagedGcpTarget,
            RubrikManagedGlacierTarget,
            RubrikManagedNfsTarget,
            RubrikManagedRcsTarget,
            RubrikManagedS3CompatibleTarget,
            RubrikManagedTapeTargetType,
            RubrikSyncStatus,
            RunCustomAnalyzerReply,
            S3BucketDetails,
            SapHanaAppMetadata,
            SapHanaConfig,
            SapHanaDataBackupFile,
            SapHanaDatabase,
            SapHanaDatabaseConnection,
            SapHanaDatabaseEdge,
            SapHanaDatabaseInfoObject,
            SapHanaDataPathSpecObject,
            SapHanaHost,
            SapHanaHostObject,
            SapHanaLogBackup,
            SapHanaLogBackupFiles,
            SapHanaLogPositionInterval,
            SapHanaLogSnapshot,
            SapHanaLogSnapshotAppMetadata,
            SapHanaLogSnapshotConnection,
            SapHanaLogSnapshotEdge,
            SapHanaRecoverableRange,
            SapHanaRecoverableRangeConnection,
            SapHanaRecoverableRangeEdge,
            SapHanaSslInfo,
            SapHanaSslInformation,
            SapHanaSystem,
            SapHanaSystemAuthTypeSpec,
            SapHanaSystemConnection,
            SapHanaSystemDescendantTypeConnection,
            SapHanaSystemDescendantTypeEdge,
            SapHanaSystemEdge,
            SapHanaSystemInfo,
            SapHanaSystemInformation,
            SapHanaSystemPhysicalChildTypeConnection,
            SapHanaSystemPhysicalChildTypeEdge,
            SapHanaSystemSummary,
            ScaleRuntime,
            ScheduledReport,
            ScheduledReportConnection,
            ScheduledReportEdge,
            ScvmmInfo,
            SddlPermission,
            SearchResponse,
            SearchResponseListResponse,
            SecurityGroup,
            SeedEnabledPoliciesReply,
            SeedInitialPoliciesReply,
            SelfServicePermission,
            SendPdfReportReply,
            SensitiveFiles,
            SensitiveHits,
            ServiceAccount,
            ServiceAccountConnection,
            ServiceAccountEdge,
            SetAnalyzerRisksReply,
            SetDatastoreFreespaceThresholdsReply,
            SetupAzureO365ExocomputeResp,
            SetUpgradeTypeReply,
            SetWorkloadAlertSettingReply,
            ShareExportIdPair,
            ShareFileset,
            SlaArchivalCluster,
            SlaAssignable,
            SlaAssignResult,
            SlaAssociatedOrganization,
            SlaAuditDetail,
            SlaConfig,
            SlaDomainConnection,
            SlaDomainEdge,
            SlaIdToObjectCount,
            SlaInfo,
            SlaLogFrequencyConfigResult,
            SlaManagedVolumeDetail,
            SlaManagedVolumeHostSummary,
            SlaManagedVolumeLogExportSummary,
            SlaManagedVolumeScriptSummary,
            SlaReplicationCluster,
            SlaUpgrade,
            SlaUpgradeEligibility,
            SlaUpgradeInfo,
            SmbConfig,
            SmbDomain,
            SmbDomainConnection,
            SmbDomainDetail,
            SmbDomainEdge,
            Snappable,
            SnappableAggregation,
            SnappableChart,
            SnappableConnection,
            SnappableEdge,
            SnappableGroupBy,
            SnappableGroupByConnection,
            SnappableGroupByEdge,
            SnappableTable,
            SnappableTypeSummary,
            SnapshotDelta,
            SnapshotDistribution,
            SnapshotFile,
            SnapshotFileConnection,
            SnapshotFileDelta,
            SnapshotFileDeltaConnection,
            SnapshotFileDeltaEdge,
            SnapshotFileDeltaV2,
            SnapshotFileDeltaV2Connection,
            SnapshotFileDeltaV2Edge,
            SnapshotFileEdge,
            SnapshotLocationRetentionInfo,
            SnapshotResult,
            SnapshotResultConnection,
            SnapshotResultEdge,
            SnapshotRetentionInfo,
            SnapshotSchedule,
            SnapshotSubObj,
            SnapshotSubObject,
            SnapshotSummary,
            SnapshotSummaryConnection,
            SnapshotSummaryEdge,
            SnmpConfiguration,
            SnmpTrapReceiverConfig,
            SonarContentReport,
            SonarContentReportChart,
            SonarContentReportConnection,
            SonarContentReportEdge,
            SonarContentReportTable,
            SonarReport,
            SonarReportChart,
            SonarReportConnection,
            SonarReportEdge,
            SonarReportRow,
            SonarReportRowConnection,
            SonarReportRowEdge,
            SonarReportTable,
            SourceConfigParams,
            SpecificReplicationSpec,
            SsoGroup,
            StartAzureAdAppSetupReply,
            StartAzureAdAppUpdateReply,
            StartAzureCloudAccountOauthReply,
            StartClusterReportMigrationJobReply,
            StartCrawlReply,
            StartThreatHuntReply,
            StartTimeAttributes,
            StaticIpInfo,
            Status,
            StatusResponse,
            StopJobInstanceReply,
            StorageAccount,
            StorageAccountConnection,
            StorageAccountEdge,
            StorageArrayDetail,
            StorageArrayOperationOutputType,
            StoreMetadata,
            StrainInfo,
            Subnet,
            SubnetConnection,
            SubnetEdge,
            SubnetGroup,
            SubscriptionSeverity,
            SubscriptionType,
            Success,
            SummaryCount,
            SummaryHits,
            SupportPortalLoginReply,
            SupportPortalLogoutReply,
            SupportPortalStatusReply,
            SupportTunnelInfo,
            SupportUserAccess,
            SupportUserAccessConnection,
            SupportUserAccessEdge,
            SuspiciousFileInfo,
            SyslogCertificateInfo,
            SyslogExportRuleFull,
            SyslogExportRuleSummary,
            SyslogExportRuleSummaryListResponse,
            SyslogServerTestResult,
            TableFilters,
            Tag,
            TagObject,
            TagRuleEffectiveSla,
            TagRuleTag,
            TakeOnDemandSnapshotError,
            TakeOnDemandSnapshotReply,
            TakeOnDemandSnapshotTaskchainUuid,
            TargetConnection,
            TargetEdge,
            TargetMapping,
            TargetMappingBasic,
            Taskchain,
            TaskDetail,
            TaskDetailChart,
            TaskDetailClusterType,
            TaskDetailConnection,
            TaskDetailEdge,
            TaskDetailGroupBy,
            TaskDetailGroupByConnection,
            TaskDetailGroupByEdge,
            TaskDetailObjectType,
            TaskDetailTable,
            TaskSummaryChart,
            TaskSummaryTable,
            TestExistingWebhookReply,
            TestSyslogExportRuleReply,
            TestWebhookReply,
            ThreatHunt,
            ThreatHuntConfig,
            ThreatHuntConnection,
            ThreatHuntDetails,
            ThreatHuntEdge,
            ThreatHuntResult,
            ThreatHuntResultObjectsSummary,
            ThreatHuntResultSnapshotStats,
            ThreatHuntStats,
            ThreatHuntSummaryReply,
            TimelineCountEntry,
            TimelineEntry,
            TimeRange,
            TimeRangeWithUnit,
            TimeSeriesResult,
            TimeStat,
            TotpStatus,
            TriggerExocomputeHealthCheckReply,
            TriggerRansomwareDetectionReply,
            UnidirectionalReplicationSpec,
            UnmanagedObjectDetail,
            UnmanagedObjectDetailConnection,
            UnmanagedObjectDetailEdge,
            UnmapAzureCloudAccountExocomputeSubscriptionReply,
            UnmapCloudAccountExocomputeAccountReply,
            UpdateAutoEnablePolicyClusterConfigReply,
            UpdateAwsCloudAccountFeatureReply,
            UpdateAwsExocomputeConfigsReply,
            UpdateAzureCloudAccountReply,
            UpdateAzureCloudAccountStatus,
            UpdateBadDiskLedStatusReply,
            UpdateCertificateHostReply,
            UpdateCloudNativeAwsStorageSettingReply,
            UpdateCloudNativeAzureStorageSettingReply,
            UpdateCloudNativeIndexingStatusReply,
            UpdateCloudNativeRcvAzureStorageSettingReply,
            UpdateClusterDefaultAddressReply,
            UpdateClusterSettingsReply,
            UpdateCustomReportReply,
            UpdateEventDigestReply,
            UpdateFailoverClusterAppReply,
            UpdateFailoverClusterReply,
            UpdateFloatingIpsReply,
            UpdateGuestCredentialReply,
            UpdateHealthMonitorPolicyStatusReply,
            UpdateHypervVirtualMachineReply,
            UpdateHypervVirtualMachineSnapshotMountReply,
            UpdateIndexingStatusError,
            UpdateInsightStateReply,
            UpdateLockoutConfigReply,
            UpdateManagedVolumeReply,
            UpdateMssqlDefaultPropertiesReply,
            UpdateMssqlLogShippingConfigurationReply,
            UpdateNasSystemReply,
            UpdateNetworkThrottleReply,
            UpdateNutanixClusterReply,
            UpdateNutanixPrismCentralReply,
            UpdateO365AppAuthStatusReply,
            UpdateO365OrgCustomNameReply,
            UpdateOrgReply,
            UpdateProxyConfigReply,
            UpdateScheduledReportReply,
            UpdateServiceAccountReply,
            UpdateSnmpConfigReply,
            UpdateStorageArrayReplyType,
            UpdateStorageArraysReply,
            UpdateSyslogExportRuleReply,
            UpdateTunnelStatusReply,
            UpdateVcenterReply,
            UpdateVolumeGroupReply,
            UpdateVsphereAdvancedTagReply,
            UpdateWebhookReply,
            UpgradeAzureCloudAccountPermissionsWithoutOauthReply,
            UpgradeAzureCloudAccountReply,
            UpgradeAzureCloudAccountStatus,
            UpgradeDurationReply,
            UpgradeGcpCloudAccountPermissionsWithoutOauthReply,
            UpgradeJobReply,
            UpgradeJobReplyWithUuid,
            UpgradeRecommendationInfo,
            UpgradeStatusReply,
            User,
            UserActivityResult,
            UserActivityResultConnection,
            UserActivityResultEdge,
            UserAudit,
            UserAuditChart,
            UserAuditConnection,
            UserAuditEdge,
            UserAuditTable,
            UserConnection,
            UserDownload,
            UserDownloadUrl,
            UserEdge,
            UserLoginContext,
            UserNotifications,
            UserSessionManagementConfig,
            UserSetting,
            UserSettings,
            V1BulkUpdateExchangeDagResponse,
            V1MssqlGetRestoreFilesV1Response,
            ValidateAndCreateAwsCloudAccountReply,
            ValidateAndSaveCustomerKmsInfoReply,
            ValidateAwsNativeRdsClusterNameForExportReply,
            ValidateAwsNativeRdsInstanceNameForExportReply,
            ValidateAzureNativeSqlDatabaseDbNameForExportReply,
            ValidateAzureNativeSqlManagedInstanceDbNameForExportReply,
            ValidateAzureSubnetsForCloudAccountExocomputeReply,
            ValidateCloudNativeFileRecoveryFeasibilityReply,
            ValidateOracleAcoFileReply,
            ValidateOrgNameReply,
            ValidReplicationTarget,
            ValidReplicationTargetConnection,
            ValidReplicationTargetEdge,
            ValueBoolean,
            ValueDateTime,
            ValueFloat,
            ValueInteger,
            ValueLong,
            ValueNull,
            ValueString,
            VappAppMetadata,
            VappInstantRecoveryOptions,
            VappNetworkSummary,
            VappTemplateExportOptions,
            VappTemplateExportOptionsUnion,
            VappVmNetworkConnection,
            VappVmRestoreSpec,
            Vcd,
            VcdDescendantTypeConnection,
            VcdDescendantTypeEdge,
            VcdLogicalChildTypeConnection,
            VcdLogicalChildTypeEdge,
            VcdOrg,
            VcdOrgDescendantTypeConnection,
            VcdOrgDescendantTypeEdge,
            VcdOrgLogicalChildTypeConnection,
            VcdOrgLogicalChildTypeEdge,
            VcdOrgVdc,
            VcdOrgVdcDescendantTypeConnection,
            VcdOrgVdcDescendantTypeEdge,
            VcdOrgVdcLogicalChildTypeConnection,
            VcdOrgVdcLogicalChildTypeEdge,
            VcdOrgVdcStorageProfile,
            VcdVapp,
            VcdVappLogicalChildTypeConnection,
            VcdVappLogicalChildTypeEdge,
            VcdVcenterConnectionInfo,
            VcdVcenterConnectionState,
            VcdVimServer,
            VcdVmInfo,
            VcenterAdvancedTagPreviewReply,
            VcenterHotAddProxyVmInfo,
            VcenterPatch,
            VcenterPreAddInfo,
            VcenterSummary,
            VerifySlaWithReplicationToClusterResponse,
            VersionedFile,
            VersionedFileConnection,
            VersionedFileEdge,
            VirtualMachineFileInfo,
            VirtualMachineFilesReply,
            VirtualMachineScriptDetail,
            VirtualMachineSummary,
            VlanConfig,
            VlanConfigListResponse,
            VmAppConsistentSpecsInternal,
            VmNetworkConnection,
            VmPathPoint,
            VmRecoveryJobInfo,
            VmwareAppMetadata,
            VmwareCdpLiveInfo,
            VmwareCdpStateInfo,
            VmwareDatastoreFreespaceThreshold,
            VmwareHostDetail,
            VmwareHostSummary,
            VmwareHostUpdate,
            VmwareNetworkConfig,
            VmwareNetworkDeviceInfo,
            VmwareRecoverableRange,
            VmwareSnapshotVmConfig,
            VmwareVmConfig,
            VmwareVmMountSummaryV1,
            VmwareVmRecoverableRanges,
            VmwareVmSubObject,
            Vnet,
            VnetConnection,
            VnetEdge,
            VolumeGroupLiveMount,
            VolumeGroupLiveMountConnection,
            VolumeGroupLiveMountEdge,
            VolumeGroupSnapshotVolumeSummary,
            VolumeGroupSubObject,
            VolumeGroupSummary,
            VsphereAsyncRequestStatus,
            VsphereComputeCluster,
            VsphereComputeClusterConnection,
            VsphereComputeClusterDescendantTypeConnection,
            VsphereComputeClusterDescendantTypeEdge,
            VsphereComputeClusterEdge,
            VsphereComputeClusterPhysicalChildTypeConnection,
            VsphereComputeClusterPhysicalChildTypeEdge,
            VsphereDatacenter,
            VsphereDatacenterDescendantTypeConnection,
            VsphereDatacenterDescendantTypeEdge,
            VsphereDatacenterLogicalChildTypeConnection,
            VsphereDatacenterLogicalChildTypeEdge,
            VsphereDatacenterPhysicalChildTypeConnection,
            VsphereDatacenterPhysicalChildTypeEdge,
            VsphereDatastore,
            VsphereDatastoreCluster,
            VsphereDatastoreClusterConnection,
            VsphereDatastoreClusterDescendantTypeConnection,
            VsphereDatastoreClusterDescendantTypeEdge,
            VsphereDatastoreClusterEdge,
            VsphereDatastoreClusterPhysicalChildTypeConnection,
            VsphereDatastoreClusterPhysicalChildTypeEdge,
            VsphereDatastoreConnection,
            VsphereDatastoreEdge,
            VsphereFolder,
            VsphereFolderConnection,
            VsphereFolderDescendantTypeConnection,
            VsphereFolderDescendantTypeEdge,
            VsphereFolderEdge,
            VsphereFolderLogicalChildTypeConnection,
            VsphereFolderLogicalChildTypeEdge,
            VsphereHost,
            VsphereHostConnection,
            VsphereHostDescendantTypeConnection,
            VsphereHostDescendantTypeEdge,
            VsphereHostEdge,
            VsphereHostPhysicalChildTypeConnection,
            VsphereHostPhysicalChildTypeEdge,
            VsphereLink,
            VsphereLiveMount,
            VsphereLiveMountConnection,
            VsphereLiveMountEdge,
            VsphereMount,
            VsphereMountConnection,
            VsphereMountEdge,
            VsphereNetwork,
            VsphereRequestErrorInfo,
            VsphereResourcePool,
            VsphereResourcePoolDescendantTypeConnection,
            VsphereResourcePoolDescendantTypeEdge,
            VsphereResourcePoolPhysicalChildTypeConnection,
            VsphereResourcePoolPhysicalChildTypeEdge,
            VsphereTag,
            VsphereTagCategory,
            VsphereTagCategoryTagChildTypeConnection,
            VsphereTagCategoryTagChildTypeEdge,
            VsphereTagTagChildTypeConnection,
            VsphereTagTagChildTypeEdge,
            VsphereVcenter,
            VsphereVcenterConnection,
            VsphereVcenterDescendantTypeConnection,
            VsphereVcenterDescendantTypeEdge,
            VsphereVcenterEdge,
            VsphereVcenterLogicalChildTypeConnection,
            VsphereVcenterLogicalChildTypeEdge,
            VsphereVcenterPhysicalChildTypeConnection,
            VsphereVcenterPhysicalChildTypeEdge,
            VsphereVcenterTagChildTypeConnection,
            VsphereVcenterTagChildTypeEdge,
            VsphereVirtualDisk,
            VsphereVirtualDiskConnection,
            VsphereVirtualDiskEdge,
            VsphereVm,
            VsphereVmConnection,
            VsphereVmEdge,
            VsphereVmListEsxiDatastoresReply,
            VsphereVmPowerOnOffLiveMountReply,
            Webhook,
            WebhookConnection,
            WebhookEdge,
            WeeklyRecurrencePattern,
            WeeklySnapshotSchedule,
            WhitelistedAnalyzer,
            WindowsCluster,
            WindowsClusterDescendantTypeConnection,
            WindowsClusterDescendantTypeEdge,
            WindowsClusterLogicalChildTypeConnection,
            WindowsClusterLogicalChildTypeEdge,
            WindowsFileset,
            WorkloadAnomaly,
            WorkloadAnomalyConnection,
            WorkloadAnomalyEdge,
            WorkloadFields,
            WorkloadIdToSnapshotIds,
            WorkloadLocation,
            WorkloadRecoveryInfo,
            WorkloadScanned,
            WorkloadTypeToBackupSetupSpecs,
            YaraMatchDetail,
            YearlySnapshotSchedule,
            ZeusDatabaseIds,
            ZrsAvailabilityReply,
        }

        /// <summary>
        /// All GraphQL input type names.
        /// </summary>
        public enum GqlInputName
        {
            Unknown,
            ActivitySeriesFilter,
            ActivitySeriesInput,
            AddAdGroupsToHierarchyInput,
            AddAndJoinSmbDomainInput,
            AddAwsAuthenticationServerBasedCloudAccountInput,
            AddAwsIamUserBasedCloudAccountInput,
            AddAzureCloudAccountExocomputeConfigurationsInput,
            AddAzureCloudAccountFeatureInput,
            AddAzureCloudAccountFeatureInputWithoutOauth,
            AddAzureCloudAccountInput,
            AddAzureCloudAccountResourceGroupInput,
            AddAzureCloudAccountSpecificFeatureInput,
            AddAzureCloudAccountSubscriptionInput,
            AddAzureCloudAccountSubscriptionInputWithoutOauth,
            AddAzureCloudAccountUserAssignedManagedIdentityInput,
            AddAzureCloudAccountWithoutOauthInput,
            AddCloudNativeSqlServerBackupCredentialsInput,
            AddClusterCertificateInput,
            AddClusterNodesInput,
            AddConfiguredGroupToHierarchyInput,
            AddDb2InstanceInput,
            AddInventoryWorkloadsInput,
            AddManagedVolumeInput,
            AddMongoSourceInput,
            AddMosaicSourceInput,
            AddMosaicStoreInput,
            AddNodesConfigInput,
            AddNodesToCloudClusterInput,
            AddO365OrgInput,
            AddSapHanaSystemInput,
            AddStorageArrayInput,
            AddStorageArraysInput,
            AddSyslogExportRuleInput,
            AddVlanInput,
            AddVmAppConsistentSpecsInput,
            AdvancedRecoveryConfigMap,
            AllCloudDirectSharesInput,
            AllEventDigestsInput,
            AllVmRecoveryJobsInfoInput,
            AmiTypeForAwsNativeArchivedSnapshotExportInput,
            AnalyzerGroupInput,
            AnalyzerRiskInstanceInput,
            AnomalyResultFilterInput,
            AppFilter,
            AppSortByParam,
            ArchivalLocationToClusterMappingInput,
            ArchivalSpecInput,
            ArchivalTieringSpecInput,
            ArchiveK8sClusterInput,
            AssignMssqlSlaDomainPropertiesAsyncInput,
            AssignMssqlSlaDomainPropertiesInput,
            AssignProtectionInput,
            AssignSlaInput,
            AssignSlaToMongoDbCollectionInput,
            AuthInfoInput,
            AwsAccountFeatureArtifact,
            AwsArtifactsToDeleteInput,
            AwsAuthServerCertificateIdInput,
            AwsAuthServerRegionsInput,
            AwsAuthServerRoleNameInput,
            AwsCdmVersionRequest,
            AwsCloudAccountConfigsInput,
            AwsCloudAccountFeatureVersionInput,
            AwsCloudAccountInput,
            AwsCloudAccountsWithFeaturesInput,
            AwsCloudAccountWithFeaturesInput,
            AwsCloudComputeSettingFilterInput,
            AwsCloudComputeSettingsInput,
            AwsCloudTypeFilter,
            AwsEsConfigInput,
            AwsExocomputeConfigInput,
            AwsExocomputeSubnetInputType,
            AwsGetPermissionPoliciesInput,
            AwsImmutabilitySettings,
            AwsInstanceCcOrCnpRbsConnectionStatusFilter,
            AwsNativeAccountFilter,
            AwsNativeAccountFilters,
            AwsNativeAccountInput,
            AwsNativeAttachedInstanceFilter,
            AwsNativeEbsVolumeFileRecoveryStatusFilter,
            AwsNativeEbsVolumeFilters,
            AwsNativeEbsVolumeNameOrIdSubstringFilter,
            AwsNativeEbsVolumeTypeFilter,
            AwsNativeEc2InstanceFileRecoveryStatusFilter,
            AwsNativeEc2InstanceFilters,
            AwsNativeEc2InstanceNameOrIdSubstringFilter,
            AwsNativeEc2InstanceTypeFilter,
            AwsNativeRdsDbEngineFilter,
            AwsNativeRdsDbInstanceClassFilter,
            AwsNativeRdsInstanceFilters,
            AwsNativeRegionFilter,
            AwsNativeS3SlaConfigInput,
            AwsNativeTagFilter,
            AwsNativeVpcFilter,
            AwsRdsConfigInput,
            AwsRegionsInput,
            AwsRoleArnInput,
            AwsRoleCustomization,
            AwsTrustPolicyInput,
            AwsUserKeysInput,
            AwsVmConfig,
            AzureAdApp,
            AzureAdObjectTypeInput,
            AzureArmTemplatesByFeatureInput,
            AzureBlobConfigInput,
            AzureCdmVersionReq,
            AzureCloudAccountSubscriptionInput,
            AzureCloudComputeSettingsInput,
            AzureCmkInput,
            AzureEncryptionKeysInput,
            AzureEsConfigInput,
            AzureExocomputeAddConfigInputType,
            AzureGetResourceGroupsInfoIfExistInput,
            AzureImmutabilitySettings,
            AzureKeyVaultsInput,
            AzureManagedIdentitiesRequest,
            AzureNativeAttachedVmFilter,
            AzureNativeCommonResourceGroupFilters,
            AzureNativeCommonRgSubscriptionFilter,
            AzureNativeDiskExocomputeConnectedFilter,
            AzureNativeDiskFileIndexingFilter,
            AzureNativeDiskFilters,
            AzureNativeDiskResourceGroupFilter,
            AzureNativeDiskSubscriptionFilter,
            AzureNativeDiskTypeFilter,
            AzureNativeRegionFilter,
            AzureNativeResourceGroupInfoInput,
            AzureNativeRgSlaFilter,
            AzureNativeSubscriptionFilters,
            AzureNativeTagFilter,
            AzureNativeVirtualMachineFilters,
            AzureNativeVmExocomputeConnectedFilter,
            AzureNativeVmFileIndexingFilter,
            AzureNativeVmResourceGroupFilter,
            AzureNativeVmSizeFilter,
            AzureNativeVmSubscriptionFilter,
            AzureNativeVnetFilter,
            AzureNsgRequest,
            AzureO365ExocomputeConfig,
            AzureOauthConsentCompleteInput,
            AzureRoleArmTemplateFeature,
            AzureSqlDatabaseDbConfigInput,
            AzureSqlDatabaseDbLtrExport,
            AzureSqlDatabaseDbPitExport,
            AzureSqlDatabaseFilters,
            AzureSqlDatabaseResourceGroupFilter,
            AzureSqlDatabaseServerFilters,
            AzureSqlDatabaseServerResourceGroupFilter,
            AzureSqlDatabaseServerSubscriptionFilter,
            AzureSqlDatabaseSubscriptionFilter,
            AzureSqlManagedInstanceDatabaseFilters,
            AzureSqlManagedInstanceDatabaseResourceGroupFilter,
            AzureSqlManagedInstanceDatabaseSubscriptionFilter,
            AzureSqlManagedInstanceDbConfigInput,
            AzureSqlManagedInstanceDbLtrExport,
            AzureSqlManagedInstanceDbPitExport,
            AzureSqlManagedInstanceServerFilters,
            AzureSqlManagedInstanceServerResourceGroupFilter,
            AzureSqlManagedInstanceServerSubscriptionFilter,
            AzureSqlPersistentBackupExportInput,
            AzureStorageAccountsReq,
            AzureSubnetReq,
            AzureSubscriptionInput,
            AzureVmCcOrCnpRbsConnectionStatusFilter,
            AzureVmConfig,
            AzureVnetReq,
            BackupAzureAdDirectoryInput,
            BackupM365MailboxInput,
            BackupM365OnedriveInput,
            BackupM365SharepointDriveInput,
            BackupM365TeamInput,
            BackupO365OnedriveInput,
            BackupO365SharepointDriveInput,
            BackupO365SharePointListInput,
            BackupO365SharePointSiteInput,
            BackupO365TeamInput,
            BackupObject,
            BackupRunConfig,
            BackupWindowInput,
            BaseGuestCredentialInput,
            BaseOnDemandSnapshotConfigInput,
            BasicSnapshotScheduleInput,
            BatchExportHypervVmInput,
            BatchExportNutanixVmInput,
            BatchExportSnapshotJobConfigInput,
            BatchExportSnapshotJobConfigV3Input,
            BatchInPlaceRecoveryJobConfigInput,
            BatchInstantRecoverHypervVmInput,
            BatchInstantRecoveryJobConfigInput,
            BatchMountHypervVmInput,
            BatchMountNutanixVmInput,
            BatchMountSnapshotJobConfigV2Input,
            BatchOnDemandBackupHypervVmInput,
            BatchQuarantineSnapshotInput,
            BatchReleaseFromQuarantineSnapshotInput,
            BatchVmwareVmRecoverableRangesRequestInput,
            BeginManagedVolumeSnapshotInput,
            BeginSnapshotManagedVolumeRequestInput,
            BidirectionalReplicationSpecInput,
            BrowseMssqlDatabaseSnapshotInput,
            BrowseNutanixSnapshotInput,
            BulkClusterWebCertAndIpmiInput,
            BulkCreateFilesetsInput,
            BulkCreateFilesetTemplatesInput,
            BulkCreateNasFilesetInput,
            BulkCreateNasFilesetsInput,
            BulkCreateOnDemandMssqlBackupInput,
            BulkDeleteAwsCloudAccountWithoutCftInput,
            BulkDeleteFailoverClusterAppInput,
            BulkDeleteFailoverClusterInput,
            BulkDeleteFilesetInput,
            BulkDeleteFilesetTemplateInput,
            BulkDeleteHostInput,
            BulkDeleteMosaicSourcesInput,
            BulkDeleteNasSystemRequestInput,
            BulkDeleteNasSystemsInput,
            BulkDeleteSourceRequestInput,
            BulkOnDemandSnapshotJobConfigInput,
            BulkOnDemandSnapshotNutanixVmInput,
            BulkRefreshHostsInput,
            BulkRegisterHostInput,
            BulkTierExistingSnapshotsInput,
            BulkTierSnapshotsConfigInput,
            BulkUpdateExchangeDagInput,
            BulkUpdateFilesetTemplateInput,
            BulkUpdateHostInput,
            BulkUpdateMssqlDbsInput,
            BulkUpdateOracleDatabasesInput,
            BulkUpdateOracleHostsInput,
            BulkUpdateOracleRacsInput,
            CalendarEmailAddressFilter,
            CalendarGroupInfo,
            CalendarInfo,
            CalendarRecurrenceFilter,
            CalendarRestoreConfig,
            CalendarSearchFilter,
            CalendarSearchKeywordFilter,
            CalendarSearchObjectFilter,
            CancelActivitySeriesInput,
            CancelThreatHuntInput,
            CascadingArchivalSpecInput,
            CdmUpgradeInfoFilterInput,
            CdpPerfDashboardFilterParam,
            CdpPerfDashboardSortParam,
            CertificateImportRequestInput,
            ChangePasswordInput,
            ChangeVfdOnHostInput,
            ClearCloudNativeSqlServerBackupCredentialsInput,
            CloudAccountFilterInput,
            CloudDirectSystemsInput,
            CloudDownloadLocationDetailsInput,
            CloudInstantiationSpecInput,
            CloudNativeCheckRbaConnectivityInput,
            CloudNativeDatabaseServerFilter,
            CloudNativeDownloadFilesInput,
            CloudNativeFeatureForPermissionsCheck,
            CloudNativeFilter,
            CloudNativeIds,
            CloudNativeInstaceAppProtectionFilter,
            ClusterConfigInput,
            ClusterFilterInput,
            ClusterFilterPerProductInput,
            ClusterGeolocationInput,
            ClusterInfCidrsInput,
            ClusterIpv6ModeInput,
            ClusterLocationEdit,
            ClusterOperationJobProgressInput,
            ClusterTimezoneInput,
            ClusterUpdateInput,
            ClusterUuidWithDbIdInput,
            ClusterVisibilityConfigInput,
            ClusterWebSignedCertificateInput,
            CommonClusterFilterInput,
            CompleteAzureAdAppSetupInput,
            CompleteAzureAdAppUpdateInput,
            CompleteAzureCloudAccountOauthInput,
            ConfigureSapHanaRestoreInput,
            ContactFolderInfo,
            ContactInfo,
            ContactsRestoreConfig,
            ContactsSearchFilter,
            ContactsSearchKeywordFilter,
            ContactsSearchObjectFilter,
            ContextFilterInputField,
            ConversationsRestoreConfig,
            CreateAutomaticAwsTargetMappingInput,
            CreateAutomaticAzureTargetMappingInput,
            CreateAutomaticRcsTargetMappingInput,
            CreateAwsAccountInput,
            CreateAwsClusterInput,
            CreateAwsComputeSettingInput,
            CreateAwsExocomputeConfigsInput,
            CreateAwsReaderTargetInput,
            CreateAwsTargetInput,
            CreateAzureAccountInput,
            CreateAzureClusterInput,
            CreateAzureReaderTargetInput,
            CreateAzureTargetInput,
            CreateCloudNativeAwsStorageSettingInput,
            CreateCloudNativeAzureStorageSettingInput,
            CreateCloudNativeLabelRuleInput,
            CreateCloudNativeRcvAzureStorageSettingInput,
            CreateCloudNativeTagRuleInput,
            CreateCustomAnalyzerInput,
            CreateCustomReportInput,
            CreateDownloadSnapshotForVolumeGroupInput,
            CreateExchangeSnapshotMountInput,
            CreateExportOracleDbInput,
            CreateFailoverClusterAppInput,
            CreateFailoverClusterInput,
            CreateFilesetSnapshotInput,
            CreateGcpReaderTargetInput,
            CreateGcpTargetInput,
            CreateGlacierReaderTargetInput,
            CreateGlobalSlaInput,
            CreateGuestCredentialInput,
            CreateHypervVirtualMachineSnapshotMountInput,
            CreateIntegrationInput,
            CreateIntegrationsInput,
            CreateK8sAgentManifestInput,
            CreateK8sClusterInput,
            CreateK8sNamespaceSnapshotsInput,
            CreateManualTargetMappingInput,
            CreateMssqlLiveMountInput,
            CreateMssqlLogShippingConfigurationInput,
            CreateNfsReaderTargetInput,
            CreateNfsTargetInput,
            CreateNutanixClusterInput,
            CreateNutanixPrismCentralInput,
            CreateO365AppCompleteInput,
            CreateO365AppKickoffInput,
            CreateOnDemandDb2BackupInput,
            CreateOnDemandExchangeDatabaseBackupInput,
            CreateOnDemandMssqlBackupInput,
            CreateOnDemandNutanixBackupInput,
            CreateOnDemandSapHanaBackupInput,
            CreateOnDemandVolumeGroupBackupInput,
            CreateOracleMountInput,
            CreateOraclePdbRestoreInput,
            CreateOrgInput,
            CreateOrgSwitchSessionInput,
            CreatePolicyInput,
            CreateRcsReaderTargetInput,
            CreateRcsTargetInput,
            CreateRcvLocationsFromTemplateInput,
            CreateRcvPrivateEndpointApprovalRequestInput,
            CreateReplicationPairInput,
            CreateS3CompatibleReaderTargetInput,
            CreateS3CompatibleTargetInput,
            CreateSapHanaSystemRefreshInput,
            CreateScheduledReportInput,
            CreateServiceAccountInput,
            CreateTapeReaderTargetInput,
            CreateTapeTargetInput,
            CreateUserWithPasswordInput,
            CreateVappInstantRecoveryInput,
            CreateVappsInstantRecoveryInput,
            CreateVsphereAdvancedTagInput,
            CreateVsphereVcenterInput,
            CreateWebhookInput,
            CustomHeader,
            CustomReportCreate,
            CustomReportFiltersConfig,
            DailySnapshotScheduleInput,
            DayOfWeekOptInput,
            Db2ConfigInput,
            Db2DatabaseConfigInput,
            Db2DownloadRecoverableRangeRequestInput,
            Db2InstancePatchRequestConfigInput,
            Db2InstanceRequestConfigInput,
            Db2LogSnapshotFilterInput,
            Db2RecoverableRangeFilterInput,
            DbLogReportPropertiesUpdateInput,
            DeleteAdGroupsFromHierarchyInput,
            DeleteAllOracleDatabaseSnapshotsInput,
            DeleteAwsClusterInput,
            DeleteAwsComputeSettingInput,
            DeleteAwsExocomputeConfigsInput,
            DeleteAzureAdDirectoryInput,
            DeleteAzureCloudAccountExocomputeConfigurationsInput,
            DeleteAzureCloudAccountInput,
            DeleteAzureCloudAccountWithoutOauthInput,
            DeleteAzureClusterInput,
            DeleteCloudNativeLabelRuleInput,
            DeleteCloudNativeTagRuleInput,
            DeleteCloudWorkloadSnapshotInput,
            DeleteCsrInput,
            DeleteCustomReportInput,
            DeleteDb2DatabaseInput,
            DeleteDb2InstanceInput,
            DeleteEventDigestInput,
            DeleteExchangeSnapshotMountInput,
            DeleteFailoverClusterAppInput,
            DeleteFailoverClusterInput,
            DeleteFilesetSnapshotsInput,
            DeleteGuestCredentialByIdInput,
            DeleteHypervVirtualMachineSnapshotInput,
            DeleteHypervVirtualMachineSnapshotMountInput,
            DeleteIntegrationInput,
            DeleteIntegrationsInput,
            DeleteLogShippingInput,
            DeleteManagedVolumeInput,
            DeleteManagedVolumeSnapshotExportInput,
            DeleteMongoSourceInput,
            DeleteMosaicSourceInput,
            DeleteMosaicStoreInput,
            DeleteMssqlDbSnapshotsInput,
            DeleteMssqlLiveMountInput,
            DeleteNasSystemInput,
            DeleteNutanixClusterInput,
            DeleteNutanixMountV1Input,
            DeleteNutanixPrismCentralInput,
            DeleteNutanixSnapshotInput,
            DeleteNutanixSnapshotsInput,
            DeleteOracleMountInput,
            DeleteOrgInput,
            DeleteReplicationPairInput,
            DeleteSapHanaDbSnapshotInput,
            DeleteSapHanaSystemInput,
            DeleteScheduledReportInput,
            DeleteServiceAccountsFromAccountInput,
            DeleteSmbDomainInput,
            DeleteStorageArraysInput,
            DeleteSyslogExportRuleInput,
            DeleteTargetInput,
            DeleteTargetMappingInput,
            DeleteTotpConfigsInput,
            DeleteVolumeGroupMountInput,
            DeleteVsphereAdvancedTagInput,
            DeleteVsphereLiveMountInput,
            DeleteWebhookInput,
            DeltaRecoveryInput,
            DisablePerLocationPauseInput,
            DisableReplicationPauseInput,
            DisableSupportUserAccessInput,
            DisableTargetInput,
            DiscoverDb2InstanceInput,
            DiscoverMongoSourceInput,
            DiscoverNasSystemRequestInput,
            DiskIdToIsExcluded,
            DlpConfigGenericNasInput,
            DlpConfigInput,
            DlpConfigVmwareVmInput,
            DlpStatusInput,
            DownloadAuditLogCsvAsyncInput,
            DownloadCdmUpgradesPdfFiltersInput,
            DownloadDb2SnapshotInput,
            DownloadDb2SnapshotsForPointInTimeRecoveryInput,
            DownloadExchangeSnapshotInput,
            DownloadFilesetSnapshotFromLocationInput,
            DownloadFilesetSnapshotInput,
            DownloadFilesNutanixSnapshotInput,
            DownloadHypervSnapshotFromLocationInput,
            DownloadHypervVirtualMachineSnapshotFilesInput,
            DownloadHypervVirtualMachineSnapshotInput,
            DownloadManagedVolumeFilesInput,
            DownloadManagedVolumeFromLocationInput,
            DownloadManagedVolumeRequestInput,
            DownloadMssqlBackupFilesByIdJobConfigInput,
            DownloadMssqlDatabaseBackupFilesInput,
            DownloadMssqlDatabaseFilesFromArchivalLocationInput,
            DownloadNutanixSnapshotInput,
            DownloadNutanixVmFromLocationInput,
            DownloadObjectFilesCsvInput,
            DownloadObjectsListCsvInput,
            DownloadOracleDatabaseSnapshotInput,
            DownloadReportCsvAsyncInput,
            DownloadReportPdfAsyncInput,
            DownloadResultsCsvFiltersInput,
            DownloadSapHanaSnapshotFromLocationInput,
            DownloadSapHanaSnapshotInput,
            DownloadSapHanaSnapshotsForPointInTimeRecoveryInput,
            DownloadThreatHuntCsvInput,
            DownloadUserActivityCsvInput,
            DownloadUserFileActivityCsvInput,
            DownloadVirtualMachineFileJobConfigInput,
            DownloadVolumeGroupSnapshotFilesInput,
            DownloadVolumeGroupSnapshotFromLocationInput,
            DownloadVsphereVirtualMachineFilesInput,
            DriveRestoreConfig,
            EffectiveSlaFilter,
            EmailAddressFilter,
            EnableAutomaticFmdUploadInput,
            EnableDisableAppConsistencyInput,
            EnableO365SharePointInput,
            EnablePerLocationPauseInput,
            EnablePerLocationPauseInputVariable,
            EnableSupportUserAccessInput,
            EnableTargetInput,
            EnableThreatMonitoringInput,
            EndManagedVolumeSnapshotInput,
            EndSnapshotManagedVolumeRequestInput,
            EventDigestConfig,
            EventInfo,
            ExchangeBackupJobConfigInput,
            ExchangeDagUpdateConfigInput,
            ExchangeDagUpdateInput,
            ExchangeLiveMountFilterInput,
            ExchangeLiveMountSortByInput,
            ExchangeMountSnapshotConfigInput,
            ExcludeAwsNativeEbsVolumesFromSnapshotInput,
            ExcludeAzureNativeManagedDisksFromSnapshotInput,
            ExcludeSharepointObjectsFromProtectionInput,
            ExcludeVmDisksInput,
            ExistingComputeConfig,
            ExistingSsoGroupInput,
            ExistingStorageAccountConfig,
            ExistingUserInput,
            ExpireDownloadedDb2SnapshotsInput,
            ExpireDownloadedSapHanaSnapshotsInput,
            ExportHypervVirtualMachineInput,
            ExportK8sNamespaceInput,
            ExportManagedVolumeSnapshotInput,
            ExportMssqlDatabaseInput,
            ExportMssqlDbJobConfigInput,
            ExportNutanixSnapshotInput,
            ExportO365MailboxInput,
            ExportOracleDatabaseInput,
            ExportOracleDbConfigInput,
            ExportOracleTablespaceConfigInput,
            ExportOracleTablespaceInput,
            ExportPathPairInput,
            ExportSlaManagedVolumeSnapshotInput,
            ExportSnapshotJobConfigForBatchInput,
            ExportSnapshotJobConfigForBatchV3Input,
            ExportSnapshotJobConfigV2Input,
            ExportSnapshotJobConfigV3Input,
            ExportSnapshotToStandaloneHostRequestInput,
            ExternalArtifactMap,
            ExternalArtifacts,
            FailoverClusterAppConfigInput,
            FailoverClusterAppSourceInput,
            FailoverClusterConfigInput,
            FailoverClusterNodeOrderInput,
            FeatureCdmVersionInput,
            FeatureListMinimumCdmVersionInputType,
            FeatureSpecificDetailsInput,
            FileActivitiesSort,
            FileDetailsInput,
            FileInfo,
            FileRecoveryLocationDetailsInput,
            FileResultSortInput,
            FilesetArraySpecInput,
            FilesetCreateInput,
            FilesetDownloadFilesJobConfigInput,
            FilesetDownloadRequestInput,
            FilesetDownloadSnapshotFilesInput,
            FilesetExportFilesJobConfigInput,
            FilesetExportPathPairInput,
            FilesetExportSnapshotFilesInput,
            FilesetOptionsInput,
            FilesetRecoverFilesInput,
            FilesetRestoreFilesJobConfigInput,
            FilesetRestorePathPairInput,
            FilesetTemplateCreateInput,
            FilesetTemplatePatchInput,
            FileSnapshotInfo,
            Filter,
            FilterInfoInput,
            FinalizeAwsCloudAccountDeletionInput,
            FinalizeAwsCloudAccountProtectionInput,
            FlashBladeSystemParametersInput,
            FolderInfo,
            FullyQualifiedDomainNameInfoInput,
            GcpCloudAccountAddManualAuthProjectInput,
            GcpCloudAccountAddProjectsInput,
            GcpCloudAccountDeleteProjectsInput,
            GcpCloudAccountOauthCompleteInput,
            GcpCloudAccountOauthInitiateInput,
            GcpCloudAccountUpgradeProjectsInput,
            GcpNativeDisableProjectInput,
            GcpNativeDiskFilters,
            GcpNativeDiskLocationFilter,
            GcpNativeDiskNameOrIdSubstringFilter,
            GcpNativeDiskProjectFilter,
            GcpNativeDiskTypeFilter,
            GcpNativeExcludeDisksFromInstanceSnapshotInput,
            GcpNativeExportDiskInput,
            GcpNativeExportGceInstanceInput,
            GcpNativeGceInstanceFilters,
            GcpNativeInstanceNameOrIdSubstringFilter,
            GcpNativeLabelFilter,
            GcpNativeMachineTypeFilter,
            GcpNativeNetworkFilter,
            GcpNativeProjectFilter,
            GcpNativeProjectFilters,
            GcpNativeProjectIdSubstringFilter,
            GcpNativeProjectNameOrNumberSubstringFilter,
            GcpNativeRefreshProjectsInput,
            GcpNativeRegionFilter,
            GcpNativeRestoreGceInstanceInput,
            GcpSetDefaultServiceAccountJwtConfigInput,
            GenerateClusterRegistrationTokenInput,
            GenerateConfigProtectionRestoreFormInput,
            GenerateSupportBundleInput,
            GenerateSupportBundleRequestInput,
            GenericNasSystemCredentialsInput,
            GenericNasSystemParametersInput,
            GenericTimeRangeInput,
            GetCloudComputeConnectivityCheckRequestStatusInput,
            GetClusterCsrInput,
            GetClusterIpsInput,
            GetClusterNtpServersInput,
            GetCompatibleMssqlInstancesV1Input,
            GetComputeClusterInput,
            GetContainersInput,
            GetCsrInput,
            GetDefaultDbPropertiesV1Input,
            GetDefaultGatewayInput,
            GetFilesetAsyncRequestStatusInput,
            GetHealthMonitorPolicyStatusInput,
            GetHotAddBandwidthInput,
            GetHotAddNetworkInput,
            GetHypervHostAsyncRequestStatusInput,
            GetHypervScvmmAsyncRequestStatusInput,
            GetHypervVirtualMachineAsyncRequestStatusInput,
            GetHypervVirtualMachineInput,
            GetIpmiInput,
            GetMissedMssqlDbSnapshotsInput,
            GetMissedOracleDbSnapshotsInput,
            GetMosaicRecoverableRangeInput,
            GetMosaicStoreInput,
            GetMosaicTableSchemaInput,
            GetMosaicVersionInput,
            GetMssqlDbMissedRecoverableRangesInput,
            GetMssqlDbRecoverableRangesInput,
            GetNetworkInterfaceInput,
            GetNetworksInput,
            GetNodesInput,
            GetNumProxiesNeededInput,
            GetNutanixClusterAsyncRequestStatusInput,
            GetNutanixNetworksInput,
            GetNutanixSnapshotDetailInput,
            GetNutanixVmAsyncRequestStatusInput,
            GetOracleDbMissedRecoverableRangesInput,
            GetOracleDbRecoverableRangesInput,
            GetOraclePdbDetailsRequestInput,
            GetPendingSlaAssignmentsInput,
            GetSmbConfigurationInput,
            GetSnmpConfigurationInput,
            GetSyslogExportRulesInput,
            GetTunnelStatusInput,
            GetVlanInput,
            GetVmwareHostInput,
            GlobalFileSearchInput,
            GlobalFileSearchQueryInput,
            GlobalSlaFilterInput,
            GlobalSnapshotScheduleInput,
            GroupConfig,
            GroupFilterInput,
            GroupSortByParam,
            GuestCredentialDefinitionInput,
            GuestOsCredentialFilterInput,
            GuestOsCredentialSortBy,
            HdfsBaseConfigInput,
            HdfsConfigInput,
            HdfsHostInput,
            HelpContentSnippetsFilterInput,
            HideNasNamespacesRequestInput,
            HideNasSharesRequestInput,
            HideRevealNasNamespacesInput,
            HideRevealNasSharesInput,
            HostRegisterInput,
            HostUpdateIdInput,
            HostUpdateInput,
            HostVfdInstallRequestInput,
            HotAddBandwidthInfoInput,
            HotAddNetworkConfigWithIdInput,
            HourlySnapshotScheduleInput,
            HypervBatchExportSnapshotJobConfigInput,
            HypervBatchInstantRecoverSnapshotJobConfigInput,
            HypervBatchMountSnapshotJobConfigInput,
            HypervBatchOnDemandBackupJobConfigInput,
            HypervDeleteAllSnapshotsInput,
            HypervDownloadFilesJobConfigInput,
            HypervExportSnapshotJobConfigForBatchInput,
            HypervExportSnapshotJobConfigInput,
            HypervInstantRecoverConfigForBatchInput,
            HypervInstantRecoveryJobConfigInput,
            HypervLiveMountFilterInput,
            HypervLiveMountSortByInput,
            HypervMountSnapshotConfigForBatchInput,
            HypervMountSnapshotJobConfigInput,
            HypervOnDemandBackupJobConfigForBatchInput,
            HypervOnDemandSnapshotInput,
            HypervRestoreFileConfigInput,
            HypervRestoreFilesConfigInput,
            HypervScvmmDeleteInput,
            HypervScvmmRegisterInput,
            HypervScvmmUpdateInput,
            HypervUpdateMountConfigInput,
            HypervVirtualMachineSnapshotDownloadConfigInput,
            HypervVirtualMachineUpdateInput,
            IbmCosDetails,
            IndicatorOfCompromiseInput,
            InPlaceRecoveryJobConfigForBatchInput,
            InPlaceRecoveryJobConfigV2Input,
            InsertCustomerO365AppInput,
            InstallIoFilterInput,
            InstantRecoverHypervVirtualMachineSnapshotInput,
            InstantRecoverOracleSnapshotInput,
            InstantRecoveryJobConfigForBatchInput,
            InstantRecoveryJobConfigV2Input,
            IntegrationConfigInput,
            InterfaceCidrInput,
            InviteSsoGroupInput,
            IpConfigInput,
            IpMappingInput,
            IpmiAccessUpdateInput,
            IpmiUpdateInput,
            JoinSmbDomainInput,
            K8sNamespaceSnapshot,
            KmsCryptoKey,
            KmsSpecInput,
            LabelFilterParams,
            LabelSelector,
            LabelSelectorRequirement,
            LabelType,
            LambdaPathFilters,
            LdapServerInput,
            LegalHoldDownloadConfigInput,
            LegalHoldQueryFilter,
            LegalHoldSnapshotsForSnappableInput,
            LegalHoldSortParam,
            LicensesForClusterProductSummaryInput,
            ListAccessGroupsFilterInput,
            ListAccessUsersFilterInput,
            ListAccessUsersSortInput,
            ListCidrsForComputeSettingInput,
            ListFileActivitiesInput,
            ListObjectFilesFiltersInput,
            LocationImmutabilitySettings,
            LockUsersByAdminInput,
            LogConfig,
            LoginCredentials,
            LookupAccountInput,
            LsnRecoveryPointInput,
            MailboxRestoreConfig,
            MalwareScanFileCriteriaInput,
            MalwareScanFileSizeLimitsInput,
            MalwareScanFileTimeLimitsInput,
            MalwareScanPathFilterInput,
            MalwareScanSnapshotLimitInput,
            ManagedDiskExclusion,
            ManagedVolumeConfigInput,
            ManagedVolumeDownloadFilesJobConfigInput,
            ManagedVolumeExportConfigInput,
            ManagedVolumeExportRequestInput,
            ManagedVolumePatchConfigInput,
            ManagedVolumePatchSlaClientConfigInput,
            ManagedVolumeResizeInput,
            ManagedVolumeSlaConfigInput,
            ManagedVolumeSlaExportConfigInput,
            ManagedVolumeSlaExportRequestInput,
            ManagedVolumeSnapshotConfigInput,
            ManagedVolumeSnapshotReferenceDefinitionInput,
            ManagedVolumeSnapshotReferenceInput,
            ManagedVolumeSnapshotReferencePatchInput,
            ManagedVolumeSnapshotReferenceWrapperInput,
            ManagedVolumeUpdateInput,
            MapAzureCloudAccountExocomputeSubscriptionInput,
            MapAzureCloudAccountToPersistentStorageLocationInput,
            MapCloudAccountExocomputeAccountInput,
            MigrateNutanixMountV1Input,
            MinuteSnapshotScheduleInput,
            ModifyIpmiInput,
            ModifyMosaicSourceInput,
            ModifyMosaicStoreInput,
            MongoClientHostInput,
            MongoCollectionAssignSlaConfigInput,
            MongoConfigInput,
            MongoRecoveryRequestConfigInput,
            MongoSourceAddRequestConfigInput,
            MongoSourcePatchRequestConfigInput,
            MonthlySnapshotScheduleInput,
            MosaicAddStoreRequestInput,
            MosaicBackupStoreInfoInput,
            MosaicBulkRecoverableRangeRequestInput,
            MosaicBulkRecoveryRangeInput,
            MosaicDatabaseManagementObjectInput,
            MosaicDatabaseObjectInput,
            MosaicGetSchemaRequestInput,
            MosaicModifyStoreRequestInput,
            MosaicMonitorInfoInput,
            MosaicRecoverableRangeRequestInput,
            MosaicRestoreDataInput,
            MosaicRetrieveRequestInput,
            MosaicSlaInfoInput,
            MosaicStorageLocationFilterInput,
            MountDiskInput,
            MountDiskJobConfigInput,
            MountExportSnapshotJobCommonOptionsInput,
            MountExportSnapshotJobCommonOptionsV2Input,
            MountMssqlDbConfigInput,
            MountNutanixSnapshotV1Input,
            MountOracleDatabaseInput,
            MountOracleDbConfigInput,
            MountSnapshotJobConfigForBatchV2Input,
            MountSnapshotJobConfigV2Input,
            MssqlBackupJobConfigInput,
            MssqlBackupSelectionInput,
            MssqlBatchBackupJobConfigInput,
            MssqlConfigInput,
            MssqlDatabaseLiveMountFilterInput,
            MssqlDatabaseLiveMountSortByInput,
            MssqlDbDefaultsUpdateInput,
            MssqlDbFileExportPathInput,
            MssqlDbUpdateIdInput,
            MssqlDbUpdateInput,
            MssqlDownloadFromArchiveConfigInput,
            MssqlGetRestoreFilesV1Input,
            MssqlLogShippingCreateConfigInput,
            MssqlLogShippingCreateConfigV2Input,
            MssqlLogShippingReseedConfigInput,
            MssqlLogShippingTargetFilterInput,
            MssqlLogShippingTargetSortByInput,
            MssqlLogShippingTargetStateOptionsInput,
            MssqlLogShippingUpdateV2Input,
            MssqlNonSlaPropertiesInput,
            MssqlRecoveryPointInput,
            MssqlRestoreEstimateV1Input,
            MssqlScriptDetailInput,
            MssqlSlaDomainAssignInfoInput,
            MssqlSlaPatchPropertiesInput,
            MssqlSlaRelatedPropertiesInput,
            NameSubstringFilter,
            NasApiCredentialsInput,
            NascdRestorePathPairInput,
            NasConfigInput,
            NasSharePropertiesInput,
            NasSystemRegisterInput,
            NasSystemUpdateInput,
            NetworkInterfaceDetails,
            NetworkThrottleScheduleSummaryInput,
            NetworkThrottleUpdateInput,
            NewComputeConfig,
            NewSsoGroupInput,
            NewStorageAccountConfig,
            NfAnomalyResultFilterInput,
            NodeConfigInput,
            NodeIpInput,
            NodeRegistrationConfigsInput,
            NodeRemovalCancelPermissionInput,
            NodesMapInput,
            NodeToReplaceInput,
            NtpServerConfigurationInput,
            NtpSymmKeyConfigurationInput,
            NutanixBatchExportSnapshotJobConfigInput,
            NutanixBatchMountSnapshotJobConfigInput,
            NutanixBulkOnDemandSnapshotJobConfigInput,
            NutanixClusterConfigInput,
            NutanixClusterPatchInput,
            NutanixDownloadFilesJobConfigInput,
            NutanixExportSnapshotJobConfigForBatchInput,
            NutanixLiveMountFilterInput,
            NutanixLiveMountSortByInput,
            NutanixMissedSnapshotsInput,
            NutanixMountSnapshotJobConfigForBatchInput,
            NutanixOnDemandSnapshotJobConfigForBulkInput,
            NutanixPatchVmMountConfigInput,
            NutanixPrismCentralConfigInput,
            NutanixPrismCentralPatchInput,
            NutanixRestoreFileConfigInput,
            NutanixRestoreFilesConfigInput,
            NutanixVirtualMachineScriptDetailInput,
            NutanixVmDownloadRequestInput,
            NutanixVmExportSnapshotJobConfigInput,
            NutanixVmMountSnapshotJobConfigInput,
            NutanixVmPatchInput,
            O365FullSpExclusion,
            O365FullSpSiteExclusions,
            O365OauthConsentCompleteInput,
            O365OauthConsentKickoffInput,
            O365PdlAndWorkloadPairInput,
            O365PdlGroupsInput,
            O365SaasSetupCompleteInput,
            O365SharePointSite,
            O365SharepointSnapshotFileDeltaInput,
            O365SnapshotFileDeltaInput,
            O365TeamConvChannelInput,
            ObjectIdsForHierarchyTypeInput,
            ObjectIdToSnapshotIdsInput,
            ObjectInfoType,
            ObjectSpecificConfigsInput,
            OldRestorePathPairInput,
            OnedriveSearchFilter,
            OnedriveSearchKeywordFilter,
            OnedriveSearchObjectFilter,
            OracleBackupJobConfigInput,
            OracleBulkUpdateInput,
            OracleConfigInput,
            OracleDataGuardGroupUpdateInput,
            OracleDbInput,
            OracleHostInput,
            OracleLiveMountFilterInput,
            OracleLiveMountSortBy,
            OracleLogRecoveryRangeInput,
            OracleNodeOrderInput,
            OraclePdbDetailsInput,
            OraclePdbRestoreConfigInput,
            OracleRacInput,
            OracleRecoveryPointInput,
            OracleTimeRangeInput,
            OracleUpdateCommonInput,
            OracleUpdateInput,
            OracleValidateConfigInput,
            OrgFilter,
            PasswordByUserId,
            PasswordComplexityPolicyInput,
            PasswordComplexityPolicyTemplateInput,
            PatchAwsAuthenticationServerBasedCloudAccountInput,
            PatchAwsIamUserBasedCloudAccountInput,
            PatchDb2DatabaseInput,
            PatchDb2InstanceInput,
            PatchMongoSourceInput,
            PatchNutanixMountV1Input,
            PatchSapHanaSystemInput,
            PauseSlaInput,
            PauseTargetInput,
            PendingSlaOperationsRequestInput,
            PermissionInput,
            PortRange,
            PreAddVcenterInput,
            PrepareAwsCloudAccountDeletionInput,
            PrepareFeatureUpdateForAwsCloudAccountInput,
            PreviewerClusterConfigInput,
            PreviewFilterInput,
            PrismElementCdmTuple,
            PromoteReaderTargetInput,
            ProxyConfigInput,
            ProxySettingsInput,
            PutSmbConfigurationInput,
            QuarantineSpecInput,
            QuarterlySnapshotScheduleInput,
            QueryCertificatesInput,
            QueryDatastoreFreespaceThresholdInput,
            QueryGuestCredentialInput,
            QueryHypervHostInput,
            QueryLogReportInput,
            QueryLogShippingConfigurationsV2Input,
            QueryNetworkThrottleInput,
            QueryReportPropertiesInput,
            QuerySupportBundleInput,
            QueryUnmanagedObjectSnapshotsV1Input,
            RansomwareResultFilterInput,
            RcsConsumptionStatsInput,
            RecoverableRangeInput,
            RecoverCloudClusterInput,
            RecoverCloudDirectMultiPathsInput,
            RecoverCloudDirectPathInput,
            RecoverMongoSourceInput,
            RecoverOracleDbConfigInput,
            RefreshDb2DatabaseInput,
            RefreshHostInput,
            RefreshHypervScvmmInput,
            RefreshHypervServerInput,
            RefreshK8sClusterInput,
            RefreshNasSystemsInput,
            RefreshNutanixClusterInput,
            RefreshNutanixPrismCentralInput,
            RefreshOracleDatabaseInput,
            RefreshReaderTargetInput,
            RefreshStorageArraysInput,
            RefreshVsphereVcenterInput,
            RegisterAgentHypervVirtualMachineInput,
            RegisterAgentNutanixVmInput,
            RegisterAwsFeatureArtifactsInput,
            RegisterCloudClusterInput,
            RegisterHypervScvmmInput,
            RegisterNasSystemInput,
            RelativeTimeRangeInput,
            RelicFilter,
            RelocateMountConfigInput,
            RelocateMountConfigV2Input,
            RemoveCloudClusterNodesInput,
            RemoveClusterNodesInput,
            RemoveDiskInput,
            RemoveInventoryWorkloadsInput,
            RemoveNodeForReplacementInput,
            RemovePrivateEndpointConnectionInput,
            RemoveProxyConfigInput,
            RemoveVlansInput,
            ReplaceClusterNodeInput,
            ReplicationBandwidthIncomingInput,
            ReplicationBandwidthOutgoingInput,
            ReplicationGatewayInfo,
            ReplicationPairsQueryFilter,
            ReplicationSpecInput,
            ReplicationSpecV2Input,
            ReplicationToCloudLocationSpecInput,
            ReplicationToCloudRegionSpecInput,
            ReportChartCreate,
            ReportFilterInput,
            ReportTableCreate,
            RequestedMatchDetailsInput,
            RequiredRecoveryParametersInput,
            ReseedLogShippingSecondaryInput,
            ResetUsersPasswordsWithUserIdsInput,
            ResizeDiskInput,
            ResizeManagedVolumeInput,
            ResolveVolumeGroupsConflictInput,
            ResourceInput,
            RestoreAzureAdObjectsWithPasswordsInput,
            RestoreConfig,
            RestoreFileConfig,
            RestoreFilesJobConfigInput,
            RestoreFilesNutanixSnapshotInput,
            RestoreFormRequestInput,
            RestoreHypervVirtualMachineSnapshotFilesInput,
            RestoreK8sNamespaceInput,
            RestoreMssqlDatabaseInput,
            RestoreMssqlDbJobConfigInput,
            RestoreO365MailboxInput,
            RestoreO365SnappableInput,
            RestoreO365TeamsConversationsInput,
            RestoreO365TeamsFilesInput,
            RestoreObjectConfig,
            RestoreOracleLogsConfigInput,
            RestoreOracleLogsInput,
            RestorePathPairInput,
            RestoreVolumeGroupSnapshotFilesInput,
            ResumeTargetInput,
            RetryAddMongoSourceInput,
            RevokeAllOrgRolesInput,
            RiskInput,
            RotateServiceAccountSecretInput,
            RunCustomAnalyzerInput,
            RunPolicyArgInput,
            SapHanaConfigInput,
            SapHanaDownloadRecoverableRangeRequestInput,
            SapHanaDownloadRequestInput,
            SapHanaLogSnapshotFilterInput,
            SapHanaRecoverableRangeFilterInput,
            SapHanaRestoreSourceConfigInput,
            SapHanaSslInfoInput,
            SapHanaSystemAuthTypeSpecInput,
            SapHanaSystemConfigInput,
            SapHanaSystemDataPathSpecInput,
            SapHanaSystemPatchInput,
            ScheduledReportCreate,
            ScheduledReportFilterInput,
            SddlRequestFiltersInput,
            SearchAzureAdSnapshotInput,
            SearchFilter,
            SearchKeywordFilter,
            SearchNutanixVmInput,
            SearchObjectFilter,
            SelfServicePermissionInput,
            SendPdfReportInput,
            SendScheduledReportAsyncInput,
            SetAnalyzerRisksInput,
            SetAzureCloudAccountCustomerAppCredentialsInput,
            SetCustomerTagsInput,
            SetDatastoreFreespaceThresholdInput,
            SetDatastoreFreespaceThresholdsInput,
            SetLdapMfaSettingInput,
            SetMfaSettingInput,
            SetPasswordComplexityPolicyInput,
            SetSsoCertificateInput,
            SetTotpConfigInput,
            SetupCloudNativeSqlServerBackupInput,
            SetupDiskInput,
            SetUpgradeTypeInput,
            SetUserLevelTotpEnforcementInput,
            SetWebSignedCertificateInput,
            SetWorkloadAlertSettingInput,
            SharePointDriveRestoreConfig,
            SharePointFullRestoreConfig,
            SharePointItems,
            SharePointListItem,
            SharePointListItemSnapshot,
            SharePointListRestoreConfig,
            SharePointObject,
            SharePointSearchFilter,
            SharePointSearchKeywordFilter,
            SharePointSearchObjectFilter,
            ShouldApplyToExistingSnapshots,
            ShouldApplyToNonPolicySnapshots,
            SlaAuditDetailFilterInput,
            SlaDurationInput,
            SlaLogFrequencyConfig,
            SlaManagedVolumeClientConfigInput,
            SlaManagedVolumeScriptConfigInput,
            SlaStatusFilterInput,
            SmbConfigInput,
            SmbDomainAddRequestInput,
            SmbDomainFilterInput,
            SmbDomainJoinRequestInput,
            SmbDomainSortByInput,
            SnappableFilterInput,
            SnappableFilterInputWithSearch,
            SnappableGroupByFilterInput,
            SnappablePathInput,
            SnappableRestoreConfig,
            SnappableSlaDomainFilterInput,
            SnappablesWithLegalHoldSnapshotsInput,
            SnapshotDeltaFilterInput,
            SnapshotQueryFilterInput,
            SnmpConfigurationInput,
            SnmpConfigurationPatchInput,
            SnmpTrapReceiverConfigInput,
            SnmpUserConfigInput,
            SonarContentReportFilter,
            SourceInput,
            SpecificReplicationSpecInput,
            StartAwsExocomputeDisableJobInput,
            StartAwsNativeAccountDisableJobInput,
            StartAwsNativeEc2InstanceSnapshotsJobInput,
            StartAwsNativeRdsInstanceSnapshotsJobInput,
            StartAzureAdAppSetupInput,
            StartAzureAdAppUpdateInput,
            StartAzureCloudAccountOauthInput,
            StartCloudNativeSnapshotsIndexJobInput,
            StartClusterReportMigrationJobInput,
            StartCreateAwsNativeEbsVolumeSnapshotsJobInput,
            StartCreateAzureNativeManagedDiskSnapshotsJobInput,
            StartCreateAzureNativeVirtualMachineSnapshotsJobInput,
            StartDisableAzureCloudAccountJobInput,
            StartDisableAzureNativeSubscriptionProtectionJobInput,
            StartEc2InstanceSnapshotExportJobInput,
            StartExportAwsNativeEbsVolumeSnapshotJobInput,
            StartExportAzureNativeManagedDiskJobInput,
            StartExportAzureNativeVirtualMachineJobInput,
            StartExportAzureSqlDatabaseDbJobInput,
            StartExportAzureSqlManagedInstanceDbJobInput,
            StartExportRdsInstanceJobInput,
            StartRecoverS3SnapshotJobInput,
            StartRefreshAwsNativeAccountsJobInput,
            StartRefreshAzureNativeSubscriptionsJobInput,
            StartRestoreAwsNativeEc2InstanceSnapshotJobInput,
            StartRestoreAzureNativeVirtualMachineJobInput,
            StartThreatHuntInput,
            StartTimeAttributesInput,
            StartVolumeGroupMountInput,
            StaticIpInfoInput,
            StopJobInstanceFromEventSeriesInput,
            StopJobInstanceInput,
            StorageAccountConfigItem,
            StorageArrayDefinitionInput,
            StorageArrayInput,
            SubscriptionSeverityInput,
            SubscriptionTypeInput,
            SupportPortalLoginInput,
            SupportUserAccessFilterInput,
            SyslogCertificateInfoInput,
            SyslogExportRuleFullInput,
            SyslogExportRuleInput,
            SyslogExportRulePartialInput,
            SyslogExportRuleUpdateInput,
            TagFilterParams,
            TagInput,
            TagsInput,
            TagType,
            TakeManagedVolumeOnDemandSnapshotInput,
            TakeMssqlLogBackupInput,
            TakeOnDemandOracleDatabaseSnapshotInput,
            TakeOnDemandOracleLogSnapshotInput,
            TakeOnDemandSnapshotInput,
            TargetFilterInput,
            TargetMappingFilterInput,
            TargetStorageAccountConfigInput,
            TargetToClusterMapping,
            TaskDetailFilterInput,
            TeamsChannelInfo,
            TeamsConvChannelInfo,
            TeamsConversationsSearchFilter,
            TeamsConversationsSearchFilterJson,
            TeamsRestoreConfig,
            TestExistingWebhookInput,
            TestSyslogExportRuleInput,
            TestWebhookInput,
            ThreatMonitoringEnablementStatusInput,
            TimeFilterInput,
            TimeRangeFilter,
            TimeRangeFilterJson,
            TimeRangeInput,
            TriggerCloudComputeConnectivityCheckInput,
            TriggerExocomputeHealthCheckInput,
            TriggerRansomwareDetectionInput,
            UnconfigureSapHanaRestoreInput,
            UnidirectionalReplicationSpecInput,
            UninstallIoFilterInput,
            UnlockUsersByAdminInput,
            UnmanagedObjectsInput,
            UnmanagedObjectsSortParam,
            UnmapAzureCloudAccountExocomputeSubscriptionInput,
            UnmapAzurePersistentStorageSubscriptionInput,
            UnmapCloudAccountExocomputeAccountInput,
            UnmountDiskInput,
            UpdateAuthDomainUsersHiddenStatusInput,
            UpdateAutoEnablePolicyClusterConfigInput,
            UpdateAutomaticAwsTargetMappingInput,
            UpdateAutomaticAzureTargetMappingInput,
            UpdateAwsAccountInput,
            UpdateAwsCloudAccountFeatureInput,
            UpdateAwsCloudAccountInput,
            UpdateAwsComputeSettingInput,
            UpdateAwsExocomputeConfigsInput,
            UpdateAwsTargetInput,
            UpdateAzureAccountInput,
            UpdateAzureCloudAccountInput,
            UpdateAzureTargetInput,
            UpdateBadDiskLedStatusInput,
            UpdateCertificateHostInput,
            UpdateCloudNativeAwsStorageSettingInput,
            UpdateCloudNativeAzureStorageSettingInput,
            UpdateCloudNativeIndexingStatusInput,
            UpdateCloudNativeLabelRuleInput,
            UpdateCloudNativeRcvAzureStorageSettingInput,
            UpdateCloudNativeTagRuleInput,
            UpdateClusterDefaultAddressInput,
            UpdateClusterNtpServersInput,
            UpdateClusterSettingsInput,
            UpdateConfiguredGroupInput,
            UpdateCustomReportInput,
            UpdateDatabaseLogReportingPropertiesForClusterInput,
            UpdateDnsServersAndSearchDomainsInput,
            UpdateEventDigestInput,
            UpdateFailoverClusterAppInput,
            UpdateFailoverClusterInput,
            UpdateFloatingIpsInput,
            UpdateGcpTargetInput,
            UpdateGlacierTargetInput,
            UpdateGlobalSlaInput,
            UpdateGuestCredentialInput,
            UpdateHealthMonitorPolicyStatusInput,
            UpdateHypervScvmmUpdatePropertiesInput,
            UpdateHypervVirtualMachineInput,
            UpdateHypervVirtualMachineSnapshotMountInput,
            UpdateInsightStateInput,
            UpdateIntegrationInput,
            UpdateIntegrationsInput,
            UpdateLockoutConfigInput,
            UpdateManagedVolumeInput,
            UpdateManualTargetMappingInput,
            UpdateMountConfigInput,
            UpdateMssqlDefaultPropertiesInput,
            UpdateMssqlLogShippingConfigurationInput,
            UpdateNasSharesInput,
            UpdateNasSharesRequestInput,
            UpdateNasSystemInput,
            UpdateNetworkThrottleInput,
            UpdateNfsTargetInput,
            UpdateNutanixClusterInput,
            UpdateNutanixPrismCentralInput,
            UpdateNutanixVmInput,
            UpdateO365AppAuthStatusInput,
            UpdateO365AppPermissionsInput,
            UpdateO365OrgCustomNameInput,
            UpdateOracleDataGuardGroupInput,
            UpdateOrgInput,
            UpdateOrgSecurityPolicyInput,
            UpdatePolicyInput,
            UpdateProxyConfigInput,
            UpdateRcsAutomaticTargetMappingInput,
            UpdateRcvTargetInput,
            UpdateReplicationTargetInput,
            UpdateS3CompatibleTargetInput,
            UpdateScheduledReportInput,
            UpdateServiceAccountInput,
            UpdateSnmpConfigInput,
            UpdateStorageArrayInput,
            UpdateStorageArraysInput,
            UpdateSupportTunnelConfigInput,
            UpdateSupportUserAccessInput,
            UpdateSyslogExportRuleInput,
            UpdateTapeTargetInput,
            UpdateTunnelStatusInput,
            UpdateVcenterHotAddBandwidthInput,
            UpdateVcenterHotAddNetworkInput,
            UpdateVcenterInput,
            UpdateVolumeGroupInput,
            UpdateVsphereAdvancedTagInput,
            UpdateVsphereVmInput,
            UpdateWebhookInput,
            UpgradeAwsCloudAccountFeaturesWithoutCftInput,
            UpgradeAwsIamUserBasedCloudAccountPermissionsInput,
            UpgradeAzureCloudAccountFeatureInput,
            UpgradeAzureCloudAccountInput,
            UpgradeAzureCloudAccountPermissionsWithoutOauthInput,
            UpgradeCdmManagedTargetInput,
            UpgradeGcpCloudAccountPermissionsWithoutOauthInput,
            UpgradeIoFilterInput,
            UploadDatabaseSnapshotToBlobstoreInput,
            UserAuditFilter,
            UserCredentials,
            UserFilterInput,
            UserGroupToRolesInput,
            UserInviteInput,
            UserSortByParam,
            UserTimeRangeInput,
            ValidateAndCreateAwsCloudAccountInput,
            ValidateAndSaveCustomerKmsInfoInput,
            ValidateAzureCloudAccountExocomputeConfigurationsInput,
            ValidateClusterLicenseCapacityInput,
            ValidateOracleAcoFileInput,
            ValidateOracleDatabaseBackupsInput,
            ValidateOrgNameInput,
            VappInstantRecoveryJobConfigInput,
            VappSnapshotInstantRecoveryOptionsInput,
            VappTemplateSnapshotExportOptionsInput,
            VappVmNetworkConnectionInput,
            VappVmRestoreSpecInput,
            VcenterConfigInput,
            VcenterConfigV2Input,
            VcenterConnectionConfigInput,
            VcenterPreAddConfigInput,
            VersionInput,
            VirtualMachineFilesInput,
            VirtualMachineScriptDetailInput,
            VirtualMachineUpdateInput,
            VirtualMachineUpdateWithSecretInput,
            VlanConfigInput,
            VlanIpInput,
            VmDownloadLocationDetailsInput,
            VmRestorePathPairInput,
            VmwareAdaptiveThrottlingSettingsInput,
            VmwareDatastoreFreespaceThresholdInput,
            VmwareDeviceKeywithNetworkNameV2Input,
            VmwareDownloadSnapshotFromLocationInput,
            VmwareNetworkDeviceInfoV2Input,
            VmwareNetworkInfoV2Input,
            VmwareSnapshotDownloadRequestInput,
            VmwareStorageIdWithDeviceKeyV2Input,
            VmwareVmConfigInput,
            VmwareVnicBindingInfoV2Input,
            VolumeGroupDownloadFilesJobConfigInput,
            VolumeGroupLiveMountFilterInput,
            VolumeGroupLiveMountSortByInput,
            VolumeGroupMountSnapshotJobConfigInput,
            VolumeGroupOnDemandSnapshotConfigInput,
            VolumeGroupPatchInput,
            VolumeGroupRestoreFileConfigInput,
            VolumeGroupRestoreFilesConfigInput,
            VolumeGroupSnapshotDownloadConfigInput,
            VolumeGroupVolumeMountConfigInput,
            VolumeIdExclusion,
            VsphereBulkOnDemandSnapshotInput,
            VsphereDeleteVcenterInput,
            VsphereExcludeVmDisksInput,
            VsphereExportSnapshotToStandaloneHostV2Input,
            VsphereLiveMountFilterInput,
            VsphereLiveMountSortBy,
            VsphereLoginInfoInput,
            VsphereMountFilter,
            VsphereOnDemandSnapshotInput,
            VsphereVmBatchExportInput,
            VsphereVmBatchExportV3Input,
            VsphereVmBatchInPlaceRecoveryInput,
            VsphereVmDeleteSnapshotInput,
            VsphereVmDownloadSnapshotFilesInput,
            VsphereVmDownloadSnapshotInput,
            VsphereVmExportSnapshotV2Input,
            VsphereVmExportSnapshotV3Input,
            VsphereVmExportSnapshotWithDownloadFromCloudInput,
            VsphereVmInitiateBatchInstantRecoveryInput,
            VsphereVmInitiateBatchLiveMountV2Input,
            VsphereVmInitiateDiskMountInput,
            VsphereVmInitiateInPlaceRecoveryInput,
            VsphereVmInitiateInstantRecoveryV2Input,
            VsphereVmInitiateLiveMountV2Input,
            VsphereVmListEsxiDatastoresInput,
            VsphereVmMountRelocateInput,
            VsphereVmMountRelocateV2Input,
            VsphereVmPowerOnOffLiveMountInput,
            VsphereVmRecoverFilesInput,
            VsphereVmRecoverFilesNewInput,
            VsphereVmRegisterAgentInput,
            WarmSearchCacheInput,
            WebServerCertificatePayloadInput,
            WeeklySnapshotScheduleInput,
            WorkloadFieldsInput,
            YearlySnapshotScheduleInput,
        }

        /// <summary>
        /// All GraphQL query names.
        /// </summary>
        public enum GqlQueryName
        {
            Unknown,
            accountId,
            accountSettings,
            activeCustomAnalyzers,
            activitySeries,
            activitySeriesConnection,
            allAccountOwners,
            allAccountProducts,
            allAccountsWithExocomputeMappings,
            allAllowedOrgAdminOperations,
            allAuthorizationsForGlobalResource,
            allAuthorizationsForObject,
            allAuthorizationsForObjects,
            allAvailabilityZonesByRegionFromAws,
            allAwsCdmVersions,
            allAwsCloudAccountConfigs,
            allAwsCloudAccountsWithFeatures,
            allAwsComputeSettings,
            allAwsExocomputeConfigs,
            allAwsInstanceProfileNames,
            allAwsPermissionPolicies,
            allAwsRegions,
            allAzureArmTemplatesByFeature,
            allAzureCdmVersions,
            allAzureCloudAccountMissingPermissions,
            allAzureCloudAccountSubnetsByRegion,
            allAzureCloudAccountSubscriptionsByFeature,
            allAzureCloudAccountTenants,
            allAzureDiskEncryptionSetsByRegion,
            allAzureEncryptionKeys,
            allAzureExocomputeConfigsInAccount,
            allAzureKeyVaultsByRegion,
            allAzureManagedIdentities,
            allAzureNativeAvailabilitySetsByRegionFromAzure,
            allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
            allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
            allAzureNativeResourceGroupsInfoIfExist,
            allAzureNativeSecurityGroupsByRegionFromAzure,
            allAzureNativeStorageAccountsFromAzure,
            allAzureNativeSubnetsByRegionFromAzure,
            allAzureNativeVirtualMachineSizes,
            allAzureNativeVirtualNetworks,
            allAzureNsgs,
            allAzureRegions,
            allAzureResourceGroups,
            allAzureSqlDatabaseServerElasticPools,
            allAzureStorageAccounts,
            allAzureSubnets,
            allAzureSubscriptionWithExocomputeMappings,
            allAzureVnets,
            allCdmGuestCredentials,
            allCdmOvaDetails,
            allCdpVmsInfos,
            allCloudAccountExocomputeMappings,
            allCloudAccounts,
            allCloudDirectShares,
            allCloudDirectSites,
            allCloudNativeFileRecoveryEligibleSnapshots,
            allCloudNativeLabelKeys,
            allCloudNativeLabelValues,
            allCloudNativeTagKeys,
            allCloudNativeTagValues,
            allClusterConnection,
            allClusterGlobalSlas,
            allClusterReplicationTargets,
            allClustersTotpAckStatus,
            allClusterWebCertsAndIpmis,
            allConnectedClusters,
            allCurrentFeaturePermissionsForCloudAccounts,
            allCurrentOrgIdentityProviders,
            allDbParameterGroupsByRegionFromAws,
            allDbSubnetGroupsByRegionFromAws,
            allDeploymentIpAddresses,
            allDhrcActiveRecommendations,
            allDhrcLatestMetrics,
            allDhrcScores,
            allEc2KeyPairsByRegionFromAws,
            allEffectiveRbacPermissions,
            allEnabledFeaturesForAccount,
            allEventDigests,
            allFeaturePermissionsForGcpCloudAccount,
            allFileActivities,
            allGcpCloudAccountMissingPermissionsForAddition,
            allGcpCloudAccountProjectsByFeature,
            allGcpCloudAccountProjectsForOauth,
            allGcpNativeAvailableKmsCryptoKeys,
            allGcpNativeCompatibleMachineTypes,
            allGcpNativeNetworks,
            allGcpNativeProjectsWithAccessibleNetworks,
            allGcpNativeRegions,
            allGcpNativeStoredMachineTypes,
            allGcpNativeStoredMachineTypesInProject,
            allGcpNativeStoredNetworkNames,
            allGcpNativeStoredNetworkNamesInProject,
            allGcpNativeStoredRegions,
            allGcpNativeStoredRegionsInProject,
            allHostedAzureRegions,
            allIntegrations,
            allInventoryWorkloads,
            allIssuesJobIds,
            allK8sReplicaSnapshotInfos,
            allKmsEncryptionKeysByRegionFromAws,
            allLatestFeaturePermissionsForCloudAccounts,
            allLicensedProducts,
            allMssqlDatabaseRestoreFiles,
            allNcdObjectsOverTimeData,
            allNcdSlaComplianceData,
            allNcdTaskData,
            allNcdUsageOverTimeData,
            allNosqlStorageLocations,
            allO365AdGroups,
            allO365OrgStatuses,
            allO365SubscriptionsAppTypeCounts,
            allObjectsAlreadyAssignedToOrgs,
            allOptionGroupsByRegionFromAws,
            allOrgsByIds,
            allPendingActions,
            allQuarantinedDetailsForSnapshots,
            allQuarantinedDetailsForWorkload,
            allResourceGroupsFromAzure,
            allS3BucketsDetailsFromAws,
            allS3BucketsFromAws,
            allSharepointSiteExclusions,
            allSlaSummariesByIds,
            allSnapshotPvcs,
            allSnapshotsClosestToPointInTime,
            allStorageArrays,
            allSupportedAwsRdsDatabaseInstanceClasses,
            allTargetMappings,
            allTargets,
            allTopRiskPolicySummaries,
            allUnmanagedObjectsSupportedTypes,
            allUsersOnAccount,
            allUsersOnAccountConnection,
            allValidReplicationTargets,
            allVcenterHotAddProxyVms,
            allVirtualMachineFiles,
            allVmRecoveryJobsInfo,
            allVmwareCdpStateInfos,
            allVpcsByRegionFromAws,
            allVpcsFromAws,
            allWebhooks,
            amiTypeForAwsNativeArchivedSnapshotExport,
            analyzerGroups,
            analyzerUsages,
            anomalyResultOpt,
            anomalyResults,
            anomalyResultsGrouped,
            archivalStorageUsage,
            areMultiGeoBackupsEnabled,
            awsArtifactsToDelete,
            awsCloudAccountListSecurityGroups,
            awsCloudAccountListSubnets,
            awsCloudAccountListVpcs,
            awsCloudAccountWithFeatures,
            awsComputeSettings,
            awsNativeAccount,
            awsNativeAccounts,
            awsNativeEbsVolume,
            awsNativeEbsVolumes,
            awsNativeEbsVolumesByName,
            awsNativeEc2Instance,
            awsNativeEc2Instances,
            awsNativeEc2InstancesByName,
            awsNativeRdsExportDefaults,
            awsNativeRdsInstance,
            awsNativeRdsInstances,
            awsNativeRdsPointInTimeRestoreWindow,
            awsNativeRoot,
            awsNativeS3Bucket,
            awsTrustPolicy,
            azureAdDirectories,
            azureAdDirectory,
            azureAdObjectsByType,
            azureCloudAccountPermissionConfig,
            azureCloudAccountSubscriptionWithFeatures,
            azureCloudAccountTenant,
            azureCloudAccountTenantWithExoConfigs,
            azureNativeManagedDisk,
            azureNativeManagedDisks,
            azureNativeResourceGroup,
            azureNativeResourceGroups,
            azureNativeRoot,
            azureNativeSubscription,
            azureNativeSubscriptions,
            azureNativeVirtualMachine,
            azureNativeVirtualMachines,
            azureO365CheckNetworkSubnet,
            azureO365CheckNSGOutboundRules,
            azureO365CheckResourceGroupName,
            azureO365CheckStorageAccountAccessibility,
            azureO365CheckStorageAccountName,
            azureO365CheckSubscriptionQuota,
            azureO365CheckVirtualNetworkName,
            azureO365Exocompute,
            azureO365GetAzureHostType,
            azureO365GetNetworkSubnetUnusedAddr,
            azureO365ValidateUserRoles,
            azureRegions,
            azureResourceGroups,
            azureSqlDatabase,
            azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
            azureSqlDatabases,
            azureSqlDatabaseServer,
            azureSqlDatabaseServers,
            azureSqlManagedInstanceDatabase,
            azureSqlManagedInstanceDatabases,
            azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
            azureSqlManagedInstanceServer,
            azureSqlManagedInstanceServers,
            azureStorageAccounts,
            azureSubnets,
            azureSubscriptions,
            azureVNets,
            browseCalendar,
            browseContacts,
            browseFolder,
            browseO365TeamConvChannels,
            browseOnedrive,
            browseSharepointDrive,
            browseSharepointList,
            browseSnapshotFileConnection,
            browseTeamsChannels,
            browseTeamsDrive,
            cassandraColumnFamilies,
            cassandraColumnFamily,
            cassandraColumnFamilyRecoverableRange,
            cassandraColumnFamilySchema,
            cassandraKeyspace,
            cassandraKeyspaces,
            cassandraSource,
            cassandraSources,
            cdmHierarchySnappableNew,
            cdmHierarchySnappablesNew,
            cdmInventorySubHierarchyRoot,
            cdmMssqlLogShippingTarget,
            cdmMssqlLogShippingTargets,
            cdmVersionCheck,
            certificates,
            certificateSigningRequest,
            certificateSigningRequests,
            certificatesWithKey,
            checkAzurePersistentStorageSubscriptionCanUnmap,
            checkCloudComputeConnectivityJobProgress,
            checkCloudNativeLabelRuleNameUniqueness,
            checkCloudNativeTagRuleNameUniqueness,
            cloudAccount,
            cloudDirectNasExport,
            cloudDirectSystems,
            cloudNativeCheckArchivedSnapshotsLocked,
            cloudNativeCheckRequiredPermissionsForFeature,
            cloudNativeCustomerTags,
            cloudNativeLabelRules,
            cloudNativeRbaInstallers,
            cloudNativeSnapshotDetailsForRecovery,
            cloudNativeSnapshots,
            cloudNativeSnapshotTypeDetails,
            cloudNativeSqlServerSetupScript,
            cloudNativeTagRules,
            cloudNativeWorkloadVersionedFiles,
            cluster,
            clusterCertificates,
            clusterConnection,
            clusterCsr,
            clusterDefaultGateway,
            clusterDns,
            clusterFloatingIps,
            clusterGroupByConnection,
            clusterIpmi,
            clusterIpv6Mode,
            clusterNetworkInterfaces,
            clusterNodes,
            clusterNtpServers,
            clusterOperationJobProgress,
            clusterProxy,
            clusterRegistrationProductInfo,
            clusterReportMigrationCount,
            clusterReportMigrationJobStatus,
            clusterReportMigrationStatus,
            clusterSlaDomains,
            clusterTypeList,
            clusterVlans,
            clusterWebSignedCertificate,
            clusterWithUpgradesInfo,
            computeClusterStatus,
            configuredGroupMembers,
            countOfObjectsProtectedBySlas,
            crawl,
            crawls,
            currentIpAddress,
            currentOrg,
            currentOrgAuthDomainConfig,
            currentUser,
            currentUserLoginContext,
            customAnalyzer,
            dashboardSummary,
            databaseLogReportForCluster,
            databaseLogReportingPropertiesForCluster,
            datagovSecDesc,
            db2Database,
            db2Databases,
            db2Instance,
            db2Instances,
            db2LogSnapshot,
            db2LogSnapshots,
            db2RecoverableRange,
            db2RecoverableRanges,
            decryptExportUrl,
            deploymentVersion,
            diffFmd,
            discoverNodes,
            discoveryTimeline,
            doesAzureNativeResourceGroupExist,
            downloadCdmUpgradesPdf,
            downloadedVersionList,
            downloadPackageStatus,
            dummyFieldWithAdminOnlyTag,
            edgeWindowsToolLink,
            exchangeDag,
            exchangeDags,
            exchangeDatabase,
            exchangeDatabases,
            exchangeLiveMounts,
            exchangeServer,
            exchangeServers,
            externalDeploymentName,
            failoverClusterApp,
            failoverClusterApps,
            failoverClusterTopLevelDescendants,
            federatedLoginStatus,
            filesetRequestStatus,
            filesetSnapshot,
            filesetSnapshotFiles,
            filesetTemplate,
            filesetTemplates,
            gcpGetDefaultCredentialsServiceAccount,
            gcpNativeDisk,
            gcpNativeDisks,
            gcpNativeGceInstance,
            gcpNativeGceInstances,
            gcpNativeProject,
            gcpNativeProjects,
            gcpNativeStoredDiskLocations,
            geoLocationList,
            getAllRolesInOrgConnection,
            getCdmReleaseDetailsForClusterFromSupportPortal,
            getCdmReleaseDetailsForVersionFromSupportPortal,
            getCdmReleaseDetailsFromSupportPortal,
            getGroupCountByCdmClusterStatus,
            getGroupCountByPrechecksStatus,
            getGroupCountByUpgradeJobStatus,
            getGroupCountByVersionStatus,
            getKorgTaskchainStatus,
            getPermissions,
            getRolesByIds,
            getUserDownloads,
            globalFileSearch,
            globalLockoutConfig,
            globalMfaSetting,
            globalSearchResults,
            globalSlaFilterConnection,
            globalSlaStatuses,
            groupsInCurrentAndDescendantOrganization,
            guestCredentials,
            guestCredentialsV2,
            hasIdpConfigured,
            helpContentSnippets,
            hierarchyObject,
            hierarchyObjects,
            hierarchySnappables,
            hostDiagnosis,
            hostFailoverCluster,
            hostFailoverClusters,
            hostShare,
            hostShares,
            hypervCluster,
            hypervHostAsyncRequestStatus,
            hypervMounts,
            hypervScvmm,
            hypervScvmmAsyncRequestStatus,
            hypervScvmms,
            hypervServer,
            hypervServers,
            hypervTopLevelDescendants,
            hypervVirtualMachine,
            hypervVirtualMachineAsyncRequestStatus,
            hypervVirtualMachines,
            hypervVmDetail,
            installedVersionList,
            integration,
            inventoryRoot,
            inventorySubHierarchyRoot,
            investigationCsvDownloadLink,
            ipWhitelist,
            isAwsNativeEbsVolumeSnapshotRestorable,
            isAwsNativeRdsInstanceLaunchConfigurationValid,
            isAwsS3BucketNameAvailable,
            isAzureNativeManagedDiskSnapshotRestorable,
            isAzureNativeSqlDatabaseSnapshotPersistent,
            isAzureStorageAccountNameAvailable,
            isCloudNativeFileRecoveryFeasible,
            isLoggedIntoRubrikSupportPortal,
            isSfdcReachable,
            issue,
            issues,
            isTotpAckNecessaryForCluster,
            isTotpMandatoryInTargetVersion,
            isUpgradeAvailable,
            isUpgradeRecommended,
            isVMwareManagementEnabled,
            isZrsAvailableForLocation,
            k8sAppManifest,
            k8sCluster,
            k8sClusters,
            k8sNamespace,
            k8sNamespaces,
            k8sSnapshotInfo,
            knowledgeBaseArticle,
            lambdaSettings,
            ldapAuthorizedPrincipalConnection,
            ldapIntegrationConnection,
            ldapPrincipalConnection,
            legalHoldSnapshotsForSnappable,
            licensesForClusterProductSummary,
            linuxFileset,
            listO365Apps,
            lockoutConfig,
            lookupAccount,
            m365Regions,
            managedVolume,
            managedVolumeInventoryStats,
            managedVolumeLiveMounts,
            managedVolumes,
            maxProtectedAppsCount,
            mfaSetting,
            minimumCdmVersionForFeatureSet,
            mongoBulkRecoverableRanges,
            mongoCollection,
            mongoCollections,
            mongoDatabase,
            mongoDatabases,
            mongodbBulkRecoverableRange,
            mongodbCollection,
            mongodbCollectionRecoverableRange,
            mongodbCollections,
            mongodbDatabase,
            mongodbDatabases,
            mongodbSource,
            mongodbSources,
            mongoRecoverableRanges,
            mongoSource,
            mongoSources,
            mosaicBulkRecoveryRange,
            mosaicSnapshots,
            mosaicStores,
            mosaicVersions,
            mssqlAvailabilityGroup,
            mssqlCompatibleInstances,
            mssqlDatabase,
            mssqlDatabaseLiveMounts,
            mssqlDatabaseMissedRecoverableRanges,
            mssqlDatabaseMissedSnapshots,
            mssqlDatabaseRestoreEstimate,
            mssqlDatabases,
            mssqlDefaultProperties,
            mssqlInstance,
            mssqlLogShippingTargets,
            mssqlRecoverableRanges,
            mssqlTopLevelDescendants,
            nasFileset,
            nasNamespace,
            nasNamespaces,
            nasShare,
            nasSystem,
            nasSystems,
            nasTopLevelDescendants,
            nasVolume,
            ncdBackEndCapacity,
            ncdFrontEndCapacity,
            ncdObjectProtectionStatus,
            networkThrottle,
            nfAnomalyResults,
            nfAnomalyResultsGrouped,
            nodeRemovalCancelPermission,
            nodeToReplace,
            nutanixBrowseSnapshot,
            nutanixCategory,
            nutanixCategoryValue,
            nutanixCluster,
            nutanixClusterAsyncRequestStatus,
            nutanixClusterContainers,
            nutanixClusterNetworks,
            nutanixClusters,
            nutanixMounts,
            nutanixPrismCentral,
            nutanixPrismCentrals,
            nutanixSnapshotDetail,
            nutanixTopLevelDescendants,
            nutanixVm,
            nutanixVmAsyncRequestStatus,
            nutanixVmMissedSnapshots,
            nutanixVms,
            o365Calendar,
            o365Groups,
            o365License,
            o365Mailbox,
            o365Mailboxes,
            o365ObjectAncestors,
            o365Onedrive,
            o365Onedrives,
            o365Org,
            o365OrgAtSnappableLevel,
            o365Orgs,
            o365OrgSummaries,
            o365ServiceAccount,
            o365ServiceStatus,
            o365SharepointDrive,
            o365SharepointDrives,
            o365SharepointList,
            o365SharepointLists,
            o365SharepointObjectList,
            o365SharepointObjects,
            o365SharepointSite,
            o365SharepointSites,
            o365Site,
            o365Sites,
            o365StorageStats,
            o365Team,
            o365TeamChannels,
            o365TeamConversationsFolderID,
            o365TeamPostedBy,
            o365Teams,
            o365User,
            o365UserObjects,
            oauthCodesForEdgeReg,
            objectFiles,
            oracleAcoExampleDownloadLink,
            oracleAcoParameters,
            oracleDatabase,
            oracleDatabaseLogBackupConfig,
            oracleDatabases,
            oracleDataGuardGroup,
            oracleHost,
            oracleHostLogBackupConfig,
            oracleLiveMounts,
            oracleMissedRecoverableRanges,
            oracleMissedSnapshots,
            oraclePdbDetails,
            oracleRac,
            oracleRacLogBackupConfig,
            oracleRecoverableRanges,
            oracleTopLevelDescendants,
            org,
            orgs,
            orgSecurityPolicy,
            orgsForPrincipal,
            overallRansomwareInvestigationSummary,
            passwordComplexityPolicy,
            pendingAction,
            pendingRansomwareInvestigationResultsCount,
            phoenixRolloutProgress,
            physicalHost,
            physicalHosts,
            pipelineHealthForTimeRange,
            polarisInventorySubHierarchyRoot,
            polarisSnapshot,
            policies,
            policy,
            policyDetails,
            policyObj,
            policyObjectUsages,
            policyObjs,
            prechecksStatus,
            prechecksStatusWithNextJobInfo,
            processedRansomwareInvestigationWorkloadCount,
            productDocumentation,
            protectedObjectsConnection,
            protectedRansomwareInvestigationWorkloadCount,
            queryDatastoreFreespaceThresholds,
            radarClusterConnection,
            ransomwareDetectionWorkloadLocations,
            ransomwareInvestigationAnalysisSummary,
            ransomwareInvestigationEnablement,
            ransomwareInvestigationWorkloadScannedCount,
            ransomwareResult,
            ransomwareResultOpt,
            ransomwareResults,
            ransomwareResultsGrouped,
            rcsArchivalLocationsConsumptionStats,
            rcvAccountEntitlement,
            rdsInstanceDetailsFromAws,
            replicationIncomingStats,
            replicationOutgoingStats,
            replicationPairs,
            reportData,
            roleTemplates,
            s3BucketStateForRecovery,
            sapHanaDatabase,
            sapHanaDatabases,
            sapHanaLogSnapshot,
            sapHanaLogSnapshots,
            sapHanaRecoverableRange,
            sapHanaRecoverableRanges,
            sapHanaSystem,
            sapHanaSystems,
            scheduledReport,
            scheduledReports,
            searchAzureAdSnapshot,
            searchFileByPrefix,
            searchHost,
            searchNutanixVm,
            searchSnappableConnection,
            searchSnappableVersionedFiles,
            serviceAccounts,
            shareFileset,
            sharepointSiteDescendants,
            sharepointSiteSearch,
            slaAuditDetail,
            slaConflictObjects,
            slaDomain,
            slaDomains,
            slaManagedVolume,
            slaManagedVolumes,
            smbConfiguration,
            smbDomains,
            snappableConnection,
            snappableContactSearch,
            snappableEmailSearch,
            snappableEventSearch,
            snappableGroupByConnection,
            snappableOnedriveSearch,
            snappableSharepointDriveSearch,
            snappableSharepointListSearch,
            snappablesWithLegalHoldSnapshotsSummary,
            snappableTeamsConversationsSearch,
            snappableTeamsDriveSearch,
            snapshot,
            snapshotEmailSearch,
            snapshotEventSearch,
            snapshotFilesDelta,
            snapshotFilesDeltaV2,
            snapshotOfASnappableConnection,
            snapshotOfSnappablesConnection,
            snapshotOnedriveSearch,
            snapshotResults,
            snapshotsForUnmanagedObject,
            snapshotSharepointDriveSearch,
            snmpConfigurations,
            sonarContentReport,
            sonarReport,
            sonarReportRow,
            sonarUserGroups,
            sonarUsers,
            supportBundle,
            supportUserAccesses,
            syslogExportRules,
            tableFilters,
            target,
            targetMapping,
            targets,
            taskDetailConnection,
            taskDetailGroupByConnection,
            teamChannelNameAvailable,
            threatHuntDetail,
            threatHuntResult,
            threatHunts,
            threatHuntSummary,
            totpConfigStatus,
            tunnelStatus,
            uniqueHypervServersCount,
            uniqueVcdCount,
            unmanagedObjects,
            upgradeStatus,
            userActivities,
            userActivityTimeline,
            userAnalyzerAccess,
            userAuditConnection,
            userDetail,
            userFileActivityTimeline,
            userGroups,
            userNotifications,
            userSessionManagementConfig,
            userSettings,
            usersInCurrentAndDescendantOrganization,
            validateAwsNativeRdsClusterNameForExport,
            validateAwsNativeRdsInstanceNameForExport,
            validateAzureCloudAccountExocomputeConfigurations,
            validateAzureNativeSqlDatabaseDbNameForExport,
            validateAzureNativeSqlManagedInstanceDbNameForExport,
            validateClusterLicenseCapacity,
            validateOrgName,
            vappSnapshotInstantRecoveryOptions,
            vappTemplateSnapshotExportOptions,
            vcdVappVms,
            vCenterAdvancedTagPreview,
            vCenterHotAddBandwidth,
            vCenterHotAddNetwork,
            vCenterNetworks,
            vCenterNumProxiesNeeded,
            vCenterPreAddInfo,
            verifySlaWithReplicationToCluster,
            volumeGroupMounts,
            vSphereComputeCluster,
            vSphereComputeClusters,
            vSphereDatacenter,
            vSphereDatastore,
            vSphereDatastoreCluster,
            vSphereDatastoreClusters,
            vSphereDatastoreConnection,
            vSphereFolder,
            vSphereFolders,
            vSphereHost,
            vSphereHostConnection,
            vSphereHostDetails,
            vSphereHostsByFids,
            vSphereLiveMounts,
            vSphereMount,
            vSphereMountConnection,
            vSphereNetwork,
            vSphereResourcePool,
            vSphereRootRecoveryHierarchy,
            vSphereTag,
            vSphereTagCategory,
            vSphereTopLevelDescendantsConnection,
            vSphereVCenter,
            vSphereVCenterConnection,
            vSphereVMAsyncRequestStatus,
            vsphereVMMissedRecoverableRange,
            vSphereVmNew,
            vSphereVmNewConnection,
            vsphereVMRecoverableRange,
            vsphereVMRecoverableRangeInBatch,
            vsphereVmwareCdpLiveInfo,
            windowsCluster,
            windowsFileset,
            workloadAlertSetting,
            workloadAnomalies,
        }

        /// <summary>
        /// All GraphQL mutation names.
        /// </summary>
        public enum GqlMutationName
        {
            Unknown,
            addAdGroupsToHierarchy,
            addAndJoinSmbDomain,
            addAwsAuthenticationServerBasedCloudAccount,
            addAwsIamUserBasedCloudAccount,
            addAzureCloudAccount,
            addAzureCloudAccountExocomputeConfigurations,
            addAzureCloudAccountWithoutOauth,
            addCloudNativeSqlServerBackupCredentials,
            addClusterCertificate,
            addClusterNodes,
            addConfiguredGroupToHierarchy,
            addDb2Instance,
            addInventoryWorkloads,
            addManagedVolume,
            addMongoSource,
            addMosaicStore,
            addNodesToCloudCluster,
            addO365Org,
            addPolicyObjects,
            addRoleAssignments,
            addSapHanaSystem,
            addStorageArrays,
            addSyslogExportRule,
            addVlan,
            addVmAppConsistentSpecs,
            archiveCrawl,
            archiveK8sCluster,
            assignMssqlSlaDomainProperties,
            assignMssqlSlaDomainPropertiesAsync,
            assignProtection,
            assignRetentionSLAToSnappables,
            assignRetentionSLAToSnapshots,
            assignSla,
            assignSlasForSnappableHierarchies,
            assignSlaToMongoDbCollection,
            azureOauthConsentComplete,
            azureOauthConsentKickoff,
            backupAzureAdDirectory,
            backupM365Mailbox,
            backupM365Onedrive,
            backupM365SharepointDrive,
            backupM365Team,
            backupO365Mailbox,
            backupO365Onedrive,
            backupO365SharepointDrive,
            backupO365SharepointList,
            backupO365SharePointSite,
            backupO365Team,
            batchDeassignRoleFromUserGroups,
            batchExportHypervVm,
            batchExportNutanixVm,
            batchInstantRecoverHypervVm,
            batchMountHypervVm,
            batchMountNutanixVm,
            batchOnDemandBackupHypervVm,
            batchQuarantineSnapshot,
            batchReleaseFromQuarantineSnapshot,
            beginManagedVolumeSnapshot,
            browseMssqlDatabaseSnapshot,
            bulkCreateFilesets,
            bulkCreateFilesetTemplates,
            bulkCreateNasFilesets,
            bulkCreateOnDemandMssqlBackup,
            bulkDeleteAwsCloudAccountWithoutCft,
            bulkDeleteCassandraSources,
            bulkDeleteFailoverCluster,
            bulkDeleteFailoverClusterApp,
            bulkDeleteFileset,
            bulkDeleteFilesetTemplate,
            bulkDeleteHost,
            bulkDeleteMongodbSources,
            bulkDeleteNasSystems,
            bulkOnDemandSnapshotNutanixVm,
            bulkRefreshHosts,
            bulkRegisterHost,
            bulkTierExistingSnapshots,
            bulkUpdateExchangeDag,
            bulkUpdateFilesetTemplate,
            bulkUpdateHost,
            bulkUpdateMssqlDbs,
            bulkUpdateOracleDatabases,
            bulkUpdateOracleHosts,
            bulkUpdateOracleRacs,
            cancelActivitySeries,
            cancelDownloadPackage,
            cancelScheduledUpgrade,
            cancelTaskchain,
            cancelThreatHunt,
            changePassword,
            changeVfdOnHost,
            clearCloudNativeSqlServerBackupCredentials,
            cloudNativeCheckRbaConnectivity,
            cloudNativeDownloadFiles,
            completeAzureAdAppSetup,
            completeAzureAdAppUpdate,
            completeAzureCloudAccountOauth,
            configureSapHanaRestore,
            createAutomaticAwsTargetMapping,
            createAutomaticAzureTargetMapping,
            createAutomaticRcsTargetMapping,
            createAwsAccount,
            createAwsCluster,
            createAwsComputeSetting,
            createAwsExocomputeConfigs,
            createAwsReaderTarget,
            createAwsTarget,
            createAzureAccount,
            createAzureCluster,
            createAzureReaderTarget,
            createAzureSaasAppAad,
            createAzureTarget,
            createCassandraSource,
            createCloudNativeAwsStorageSetting,
            createCloudNativeAzureStorageSetting,
            createCloudNativeLabelRule,
            createCloudNativeRcvAzureStorageSetting,
            createCloudNativeTagRule,
            createCustomAnalyzer,
            createCustomReport,
            createDownloadSnapshotForVolumeGroup,
            createExchangeMount,
            createFailoverCluster,
            createFailoverClusterApp,
            createFilesetSnapshot,
            createGcpReaderTarget,
            createGcpTarget,
            createGlacierReaderTarget,
            createGlobalSla,
            createGuestCredential,
            createHypervVirtualMachineSnapshotMount,
            createIntegration,
            createIntegrations,
            createK8sAgentManifest,
            createK8sCluster,
            createK8sNamespaceSnapshots,
            createManualTargetMapping,
            createMongodbSource,
            createMssqlLiveMount,
            createMssqlLogShippingConfiguration,
            createNfsReaderTarget,
            createNfsTarget,
            createNutanixCluster,
            createNutanixPrismCentral,
            createO365AppComplete,
            createO365AppKickoff,
            createOnDemandDb2Backup,
            createOnDemandExchangeBackup,
            createOnDemandMssqlBackup,
            createOnDemandNutanixBackup,
            createOnDemandSapHanaBackup,
            createOnDemandVolumeGroupBackup,
            createOraclePdbRestore,
            createOrg,
            createOrgSwitchSession,
            createPolicy,
            createRcsReaderTarget,
            createRcsTarget,
            createRcvLocationsFromTemplate,
            createRcvPrivateEndpointApprovalRequest,
            createReplicationPair,
            createRole,
            createS3CompatibleReaderTarget,
            createS3CompatibleTarget,
            createSapHanaSystemRefresh,
            createScheduledReport,
            createServiceAccount,
            createTapeReaderTarget,
            createTapeTarget,
            createUser,
            createUserWithPassword,
            createVappsInstantRecovery,
            createVsphereAdvancedTag,
            createVsphereVcenter,
            createWebhook,
            deactivateCustomAnalyzer,
            deactivatePolicy,
            deleteAdGroupsFromHierarchy,
            deleteAllOracleDatabaseSnapshots,
            deleteAwsCluster,
            deleteAwsComputeSetting,
            deleteAwsExocomputeConfigs,
            deleteAzureAdDirectory,
            deleteAzureCloudAccount,
            deleteAzureCloudAccountExocomputeConfigurations,
            deleteAzureCloudAccountWithoutOauth,
            deleteAzureCluster,
            deleteCassandraSource,
            deleteCertificate,
            deleteCloudNativeLabelRule,
            deleteCloudNativeTagRule,
            deleteCloudWorkloadSnapshot,
            deleteCsr,
            deleteCustomReport,
            deleteDb2Database,
            deleteDb2Instance,
            deleteEventDigest,
            deleteExchangeSnapshotMount,
            deleteFailoverCluster,
            deleteFailoverClusterApp,
            deleteFilesetSnapshots,
            deleteGuestCredentialById,
            deleteHypervVirtualMachineSnapshot,
            deleteHypervVirtualMachineSnapshotMount,
            deleteIntegration,
            deleteIntegrations,
            deleteLdapPrincipals,
            deleteLogShipping,
            deleteManagedVolume,
            deleteManagedVolumeSnapshotExport,
            deleteMongodbSource,
            deleteMongoSource,
            deleteMosaicStore,
            deleteMssqlDbSnapshots,
            deleteMssqlLiveMount,
            deleteNasSystem,
            deleteNutanixCluster,
            deleteNutanixMountV1,
            deleteNutanixPrismCentral,
            deleteNutanixSnapshot,
            deleteNutanixSnapshots,
            deleteO365AzureApp,
            deleteO365Org,
            deleteO365ServiceAccount,
            deleteOracleMount,
            deleteOrg,
            deleteReplicationPair,
            deleteRole,
            deleteSapHanaDbSnapshot,
            deleteSapHanaSystem,
            deleteScheduledReport,
            deleteServiceAccountsFromAccount,
            deleteSmbDomain,
            deleteStorageArrays,
            deleteSyslogExportRule,
            deleteTarget,
            deleteTargetMapping,
            deleteTotpConfig,
            deleteTotpConfigs,
            deleteUsersFromAccount,
            deleteVolumeGroupMount,
            deleteVsphereAdvancedTag,
            deleteVsphereLiveMount,
            deleteWebhook,
            disableReplicationPause,
            disableSupportUserAccess,
            disableTarget,
            discoverDb2Instance,
            discoverMongoSource,
            downloadAuditLogCsvAsync,
            downloadDb2Snapshot,
            downloadDb2SnapshotsForPointInTimeRecovery,
            downloadExchangeSnapshot,
            downloadFilesetSnapshot,
            downloadFilesetSnapshotFromLocation,
            downloadFilesNutanixSnapshot,
            downloadHypervSnapshotFromLocation,
            downloadHypervVirtualMachineSnapshot,
            downloadHypervVirtualMachineSnapshotFiles,
            downloadManagedVolumeFiles,
            downloadManagedVolumeFromLocation,
            downloadMssqlDatabaseBackupFiles,
            downloadMssqlDatabaseFilesFromArchivalLocation,
            downloadNutanixSnapshot,
            downloadNutanixVmFromLocation,
            downloadObjectFilesCsv,
            downloadObjectsListCsv,
            downloadOracleDatabaseSnapshot,
            downloadReportCsvAsync,
            downloadReportPdfAsync,
            downloadResultsCsv,
            downloadSapHanaSnapshot,
            downloadSapHanaSnapshotFromLocation,
            downloadSapHanaSnapshotsForPointInTimeRecovery,
            downloadSnapshotResultsCsv,
            downloadThreatHuntCsv,
            downloadUserActivityCsv,
            downloadUserFileActivityCsv,
            downloadVolumeGroupSnapshotFiles,
            downloadVolumeGroupSnapshotFromLocation,
            downloadVsphereVirtualMachineFiles,
            enableAutomaticFmdUpload,
            enableDisableAppConsistency,
            enableO365SharePoint,
            enableO365Teams,
            enableReplicationPause,
            enableSupportUserAccess,
            enableTarget,
            enableThreatMonitoring,
            endManagedVolumeSnapshot,
            excludeAwsNativeEbsVolumesFromSnapshot,
            excludeAzureNativeManagedDisksFromSnapshot,
            excludeSharepointObjectsFromProtection,
            excludeVmDisks,
            expireDownloadedDb2Snapshots,
            expireDownloadedSapHanaSnapshots,
            exportHypervVirtualMachine,
            exportK8sNamespace,
            exportManagedVolumeSnapshot,
            exportMssqlDatabase,
            exportNutanixSnapshot,
            exportO365Mailbox,
            exportOracleDatabase,
            exportOracleTablespace,
            exportSlaManagedVolumeSnapshot,
            filesetDownloadSnapshotFiles,
            filesetExportSnapshotFiles,
            filesetRecoverFiles,
            finalizeAwsCloudAccountDeletion,
            finalizeAwsCloudAccountProtection,
            gcpCloudAccountAddManualAuthProject,
            gcpCloudAccountAddProjects,
            gcpCloudAccountDeleteProjects,
            gcpCloudAccountOauthComplete,
            gcpCloudAccountOauthInitiate,
            gcpCloudAccountUpgradeProjects,
            gcpNativeDisableProject,
            gcpNativeExcludeDisksFromInstanceSnapshot,
            gcpNativeExportDisk,
            gcpNativeExportGceInstance,
            gcpNativeRefreshProjects,
            gcpNativeRestoreGceInstance,
            gcpSetDefaultServiceAccountJwtConfig,
            generateClusterRegistrationToken,
            generateConfigProtectionRestoreForm,
            generateCsr,
            generateSupportBundle,
            generateTotpSecret,
            getDownloadUrl,
            getHealthMonitorPolicyStatus,
            getPendingSlaAssignments,
            hideRevealNasNamespaces,
            hideRevealNasShares,
            hypervDeleteAllSnapshots,
            hypervOnDemandSnapshot,
            hypervScvmmDelete,
            hypervScvmmUpdate,
            insertCustomerO365App,
            installIoFilter,
            instantRecoverHypervVirtualMachineSnapshot,
            instantRecoverOracleSnapshot,
            inviteSsoGroup,
            joinSmbDomain,
            listCidrsForComputeSetting,
            lockUsersByAdmin,
            logoutFromRubrikSupportPortal,
            mapAzureCloudAccountExocomputeSubscription,
            mapAzureCloudAccountToPersistentStorageLocation,
            mapCloudAccountExocomputeAccount,
            migrateNutanixMountV1,
            modifyIpmi,
            mountDisk,
            mountNutanixSnapshotV1,
            mountOracleDatabase,
            mutateRole,
            notificationForGetLicense,
            o365OauthConsentComplete,
            o365OauthConsentKickoff,
            o365PdlGroups,
            o365SaasSetupComplete,
            o365SaaSSetupKickoff,
            o365SetupKickoff,
            patchAwsAuthenticationServerBasedCloudAccount,
            patchAwsIamUserBasedCloudAccount,
            patchDb2Database,
            patchDb2Instance,
            patchMongoSource,
            patchNutanixMountV1,
            patchSapHanaSystem,
            pauseSla,
            pauseTarget,
            prepareAwsCloudAccountDeletion,
            prepareFeatureUpdateForAwsCloudAccount,
            promoteReaderTarget,
            putSmbConfiguration,
            recoverCassandraSource,
            recoverCloudCluster,
            recoverCloudDirectMultiPaths,
            recoverCloudDirectPath,
            recoverMongodbSource,
            recoverMongoSource,
            refreshDb2Database,
            refreshGlobalManagerConnectivityStatus,
            refreshHost,
            refreshHypervScvmm,
            refreshHypervServer,
            refreshK8sCluster,
            refreshNasSystems,
            refreshNutanixCluster,
            refreshNutanixPrismCentral,
            refreshO365Org,
            refreshOracleDatabase,
            refreshReaderTarget,
            refreshStorageArrays,
            refreshVsphereVcenter,
            registerAgentHypervVirtualMachine,
            registerAgentNutanixVm,
            registerAwsFeatureArtifacts,
            registerCloudCluster,
            registerHypervScvmm,
            registerNasSystem,
            removeCdmCluster,
            removeCloudClusterNodes,
            removeClusterNodes,
            removeDisk,
            removeInventoryWorkloads,
            removeLdapIntegration,
            removeNodeForReplacement,
            removePolicyObjects,
            removePrivateEndpointConnection,
            removeProxyConfig,
            removeVlans,
            replaceClusterNode,
            reseedLogShippingSecondary,
            resetAllOrgUsersPasswords,
            resetUsersPasswordsWithUserIds,
            resizeDisk,
            resizeManagedVolume,
            resolveVolumeGroupsConflict,
            restoreAzureAdObjectsWithPasswords,
            restoreFilesNutanixSnapshot,
            restoreHypervVirtualMachineSnapshotFiles,
            restoreK8sNamespace,
            restoreMssqlDatabase,
            restoreO365Mailbox,
            restoreO365Snappable,
            restoreO365TeamsConversations,
            restoreO365TeamsFiles,
            restoreOracleLogs,
            restoreVolumeGroupSnapshotFiles,
            resumeTarget,
            retryAddMongoSource,
            retryBackup,
            retryDownloadPackageJob,
            revokeAllOrgRoles,
            rotateServiceAccountSecret,
            runCustomAnalyzer,
            scheduleUpgradeBatchJob,
            seedEnabledPolicies,
            seedInitialPolicies,
            sendPdfReport,
            sendScheduledReportAsync,
            setAnalyzerRisks,
            setAzureCloudAccountCustomerAppCredentials,
            setCustomerTags,
            setDatastoreFreespaceThresholds,
            setIpWhitelistEnabled,
            setLdapMfaSetting,
            setMfaSetting,
            setO365ServiceAccount,
            setPasswordComplexityPolicy,
            setSsoCertificate,
            setTotpConfig,
            setupAzureO365Exocompute,
            setupCloudNativeSqlServerBackup,
            setupDisk,
            setUpgradeType,
            setUserLevelTotpEnforcement,
            setWebSignedCertificate,
            setWorkloadAlertSetting,
            startAwsExocomputeDisableJob,
            startAwsNativeAccountDisableJob,
            startAwsNativeEc2InstanceSnapshotsJob,
            startAwsNativeRdsInstanceSnapshotsJob,
            startAzureAdAppSetup,
            startAzureAdAppUpdate,
            startAzureCloudAccountOauth,
            startCloudNativeSnapshotsIndexJob,
            startClusterReportMigrationJob,
            startCrawl,
            startCreateAwsNativeEbsVolumeSnapshotsJob,
            startCreateAzureNativeManagedDiskSnapshotsJob,
            startCreateAzureNativeVirtualMachineSnapshotsJob,
            startDisableAzureCloudAccountJob,
            startDisableAzureNativeSubscriptionProtectionJob,
            startDownloadPackageBatchJob,
            startEc2InstanceSnapshotExportJob,
            startExportAwsNativeEbsVolumeSnapshotJob,
            startExportAzureNativeManagedDiskJob,
            startExportAzureNativeVirtualMachineJob,
            startExportAzureSqlDatabaseDbJob,
            startExportAzureSqlManagedInstanceDbJob,
            startExportRdsInstanceJob,
            startPeriodicUpgradePrechecksOnDemandJob,
            startRecoverS3SnapshotJob,
            startRefreshAwsNativeAccountsJob,
            startRefreshAzureNativeSubscriptionsJob,
            startRestoreAwsNativeEc2InstanceSnapshotJob,
            startRestoreAzureNativeVirtualMachineJob,
            startThreatHunt,
            startUpgradeBatchJob,
            startVolumeGroupMount,
            stopJobInstance,
            stopJobInstanceFromEventSeries,
            supportPortalLogin,
            takeManagedVolumeOnDemandSnapshot,
            takeMssqlLogBackup,
            takeOnDemandOracleDatabaseSnapshot,
            takeOnDemandOracleLogSnapshot,
            takeOnDemandSnapshot,
            testExistingWebhook,
            testSyslogExportRule,
            testWebhook,
            triggerCloudComputeConnectivityCheck,
            triggerExocomputeHealthCheck,
            triggerRansomwareDetection,
            unconfigureSapHanaRestore,
            uninstallIoFilter,
            unlockUsersByAdmin,
            unmapAzureCloudAccountExocomputeSubscription,
            unmapAzurePersistentStorageSubscription,
            unmapCloudAccountExocomputeAccount,
            unmountDisk,
            updateAccountOwner,
            updateAuthDomainUsersHiddenStatus,
            updateAutoEnablePolicyClusterConfig,
            updateAutomaticAwsTargetMapping,
            updateAutomaticAzureTargetMapping,
            updateAwsAccount,
            updateAwsCloudAccount,
            updateAwsCloudAccountFeature,
            updateAwsComputeSetting,
            updateAwsExocomputeConfigs,
            updateAwsTarget,
            updateAzureAccount,
            updateAzureCloudAccount,
            updateAzureTarget,
            updateBadDiskLedStatus,
            updateCassandraSource,
            updateCertificate,
            updateCertificateHost,
            updateCloudNativeAwsStorageSetting,
            updateCloudNativeAzureStorageSetting,
            updateCloudNativeIndexingStatus,
            updateCloudNativeLabelRule,
            updateCloudNativeRcvAzureStorageSetting,
            updateCloudNativeTagRule,
            updateClusterDefaultAddress,
            updateClusterLocation,
            updateClusterNtpServers,
            updateClusterSettings,
            updateConfiguredGroup,
            updateCustomAnalyzer,
            updateCustomerAppPermissionForAzureSql,
            updateCustomReport,
            updateDatabaseLogReportingPropertiesForCluster,
            updateDnsServersAndSearchDomains,
            updateEventDigest,
            updateFailoverCluster,
            updateFailoverClusterApp,
            updateFloatingIps,
            updateGcpTarget,
            updateGlacierTarget,
            updateGlobalSla,
            updateGuestCredential,
            updateHealthMonitorPolicyStatus,
            updateHypervVirtualMachine,
            updateHypervVirtualMachineSnapshotMount,
            updateInsightState,
            updateIntegration,
            updateIntegrations,
            updateIpWhitelist,
            updateLambdaSettings,
            updateLdapIntegration,
            updateLockoutConfig,
            updateManagedVolume,
            updateManualTargetMapping,
            updateMongodbSource,
            updateMosaicStore,
            updateMssqlDefaultProperties,
            updateMssqlLogShippingConfiguration,
            updateNasShares,
            updateNasSystem,
            updateNetworkThrottle,
            updateNfsTarget,
            updateNutanixCluster,
            updateNutanixPrismCentral,
            updateNutanixVm,
            updateO365AppAuthStatus,
            updateO365AppPermissions,
            updateO365OrgCustomName,
            updateOracleDataGuardGroup,
            updateOrg,
            updateOrgSecurityPolicy,
            updatePolicy,
            updatePreviewerClusterConfig,
            updateProxyConfig,
            updateRcsAutomaticTargetMapping,
            updateRcvTarget,
            updateReplicationTarget,
            updateRole,
            updateRoleAssignments,
            updateS3CompatibleTarget,
            updateScheduledReport,
            updateServiceAccount,
            updateSnmpConfig,
            updateStorageArrays,
            updateSupportUserAccess,
            updateSyslogExportRule,
            updateTapeTarget,
            updateTunnelStatus,
            updateVcenter,
            updateVcenterHotAddBandwidth,
            updateVcenterHotAddNetwork,
            updateVolumeGroup,
            updateVsphereAdvancedTag,
            updateVsphereVm,
            updateWebhook,
            updateWhitelistedAnalyzers,
            upgradeAwsCloudAccountFeaturesWithoutCft,
            upgradeAwsIamUserBasedCloudAccountPermissions,
            upgradeAzureCloudAccount,
            upgradeAzureCloudAccountPermissionsWithoutOauth,
            upgradeCdmManagedTarget,
            upgradeGcpCloudAccountPermissionsWithoutOauth,
            upgradeIoFilter,
            upgradeToRsc,
            uploadDatabaseSnapshotToBlobstore,
            validateAndCreateAwsCloudAccount,
            validateAndSaveCustomerKmsInfo,
            validateOracleAcoFile,
            validateOracleDatabaseBackups,
            vmwareDownloadSnapshotFromLocation,
            vsphereBulkOnDemandSnapshot,
            vsphereDeleteVcenter,
            vsphereExcludeVmDisks,
            vsphereExportSnapshotToStandaloneHostV2,
            vsphereOnDemandSnapshot,
            vsphereVmBatchExport,
            vsphereVmBatchExportV3,
            vsphereVmBatchInPlaceRecovery,
            vsphereVmDeleteSnapshot,
            vsphereVmDownloadSnapshot,
            vsphereVmDownloadSnapshotFiles,
            vsphereVmExportSnapshotV2,
            vsphereVmExportSnapshotV3,
            vsphereVmExportSnapshotWithDownloadFromCloud,
            vsphereVmInitiateBatchInstantRecovery,
            vsphereVmInitiateBatchLiveMountV2,
            vsphereVmInitiateDiskMount,
            vsphereVmInitiateInPlaceRecovery,
            vsphereVmInitiateInstantRecoveryV2,
            vsphereVmInitiateLiveMountV2,
            vsphereVmListEsxiDatastores,
            vsphereVmMountRelocate,
            vsphereVmMountRelocateV2,
            vsphereVmPowerOnOffLiveMount,
            vsphereVmRecoverFiles,
            vsphereVmRecoverFilesNew,
            vsphereVmRegisterAgent,
            warmSearchCache,
        }

        /// <summary>
        /// All GraphQL enum names.
        /// </summary>
        public enum GqlEnumName
        {
            Unknown,
            AccessType,
            AccountState,
            AccountType,
            AceFlags,
            AceQualifier,
            ActionType,
            ActivityAccessType,
            ActivityObjectTypeEnum,
            ActivitySeriesGroupByEnum,
            ActivitySeriesSortByEnum,
            ActivitySeriesSortField,
            ActivitySeverityEnum,
            ActivityStatusEnum,
            ActivityTableColumnEnum,
            ActivityTypeEnum,
            AdoptionStatus,
            AgentConnectionStatus,
            AmiType,
            AnalysisStatus,
            AnalyzerErrorCode,
            AnalyzerGroupTypeEnum,
            AnalyzerTypeEnum,
            AnomalyResultGroupBy,
            AnomalyResultSortBy,
            AnomalyTableColumnEnum,
            AnomalyType,
            AppAuthStatus,
            AppFilterField,
            AppSortByParamField,
            ArchivalGroupQuerySortByField,
            ArchivalGroupTieringStatus,
            ArchivalGroupType,
            ArchivalLocationQuerySortByField,
            ArchivalLocationStatus,
            ArmTemplateDeploymentLevel,
            AuditObjectType,
            AuditSeverity,
            AuditStatus,
            AuditType,
            AuthenticationType,
            AuthTypeEnum,
            AwsAccountStatus,
            AwsAuthServerBasedCloudAccountRegion,
            AwsCloudAccountRegion,
            AwsCloudComputeSettingFilterField,
            AwsCloudComputeSettingQuerySortByField,
            AwsCloudExternalArtifact,
            AwsCloudType,
            AwsFeatureForPermissionCheck,
            AwsInstanceType,
            AwsNativeAccountSortFields,
            AwsNativeEbsVolumeSortFields,
            AwsNativeEbsVolumeType,
            AwsNativeEc2InstanceSortFields,
            AwsNativeEc2InstanceType,
            AwsNativeFileRecoveryStatus,
            AwsNativeProtectionFeature,
            AwsNativeRdsDbEngine,
            AwsNativeRdsDbInstanceClass,
            AwsNativeRdsInstanceSortFields,
            AwsNativeRdsStorageType,
            AwsNativeRdsType,
            AwsNativeRegion,
            AwsNativeRegionForReplication,
            AwsRegion,
            AwsRetrievalTier,
            AwsStorageClass,
            AzureAdObjectSearchType,
            AzureAdObjectType,
            AzureAdRegion,
            AzureCloudAccountRegion,
            AzureCloudType,
            AzureFeatureForPermissionCheck,
            AzureHostType,
            AzureInstanceType,
            AzureNativeCommonResourceGroupSortFields,
            AzureNativeDiskSortFields,
            AzureNativeFileIndexingStatus,
            AzureNativeManagedDiskType,
            AzureNativeProtectionFeature,
            AzureNativeRegion,
            AzureNativeRegionForReplication,
            AzureNativeSubscriptionSortFields,
            AzureNativeVirtualMachineSortFields,
            AzureNativeVmOsType,
            AzureNetworkSecurityRulesStatus,
            AzureOauthResource,
            AzureRedundancy,
            AzureRegion,
            AzureRetrievalTier,
            AzureSnapshotType,
            AzureSqlBackupStorageRedundancyType,
            AzureSqlDatabaseServerSortFields,
            AzureSqlDatabaseSortFields,
            AzureSqlDbBackupSetupStatus,
            AzureSqlManagedInstanceDatabaseSortFields,
            AzureSqlManagedInstanceServerSortFields,
            AzureStorageTier,
            AzureSubscriptionStatus,
            BlueprintRecoveryType,
            CalendarEmailAddressFilterType,
            CalendarEventType,
            CalendarRecurrenceType,
            CalendarSearchKeywordType,
            CassandraSourceStatus,
            CcpJobStatus,
            CcpJobType,
            CcpVendorType,
            CdmClusterStatusTypeEnum,
            CdmDataGuardType,
            CdmFeatureFlagType,
            CdmFindBadDiskResultType,
            CdmJobStatus,
            CdmManagedVolumeType,
            CdmNutanixSnapshotConsistencyMandate,
            CdmReportMigrationStatus,
            CdpLocalStatus,
            CdpPerfDashboardFilterField,
            CdpPerfDashboardSortType,
            CdpReplicationStatus,
            CertMgmtSortBy,
            ChannelMembershipType,
            ClassificationPolicyColor,
            ClassificationPolicyMode,
            CloudAccountAction,
            CloudAccountFeature,
            CloudAccountFilterFieldEnum,
            CloudAccountOperation,
            CloudAccountSortByFieldEnum,
            CloudAccountState,
            CloudAccountStatus,
            CloudAccountType,
            CloudInstanceRbsConnectionStatus,
            CloudNativeLabelObjectType,
            CloudNativeLocTemplateType,
            CloudNativeObjectType,
            CloudNativeRbaStatusType,
            CloudNativeTagObjectType,
            CloudNativeTagRuleFilterFields,
            CloudNativeTagRuleSortByFields,
            CloudNativeVmAppConsistentObjectType,
            CloudProvider,
            CloudProviderType,
            CloudVendor,
            ClusterConnectionStatus,
            ClusterDiskStatus,
            ClusterDiskType,
            ClusterGroupByEnum,
            ClusterJobStatusTypeEnum,
            ClusterLicenseInfoType,
            ClusterNodePlatformType,
            ClusterNodePosition,
            ClusterNodeStatus,
            ClusterPauseStatus,
            ClusterProductEnum,
            ClusterRegistrationMode,
            ClusterRemovalState,
            ClusterReportMigrationStatus,
            ClusterSortByEnum,
            ClusterStatus,
            ClusterSubStatus,
            ClusterSystemStatus,
            ClusterTimezoneType,
            ClusterTypeEnum,
            ColdStorageClass,
            ColossusStorageContainerImmutabilityStatus,
            ComplianceDuration,
            ComplianceStatusEnum,
            ConfigProtectionStatus,
            ConfigurationTypes,
            ConfiguredSlaType,
            ConnectedThroughEnumType,
            ConnectionStatusType,
            ConsistencyLevelEnum,
            ContextFilterTypeEnum,
            CrawlStatusEnum,
            DatabaseType,
            DataGovFileMode,
            DataGovObjectType,
            DataGovOsType,
            DataGovShareType,
            DataGuardType,
            DataLocationName,
            DataTypeEnum,
            DataViewTypeEnum,
            DayOfMonth,
            DayOfQuarter,
            DayOfWeek,
            DayOfYear,
            Db2DatabaseStatus,
            Db2DatabaseType,
            Db2InstanceSummaryStatus,
            Db2LogSnapshotSortBy,
            Db2RecoverableRangeSortBy,
            Db2SnapshotType,
            Db2Status,
            DefaultActionType,
            DeleteVmwareSnapshotRequestLocation,
            DeltaType,
            DhrcCategory,
            DhrcMetric,
            DhrcRecommendationKey,
            DhrcScoreTimespan,
            DiagnosticTaskStatus,
            DiscoveryContentReportGroupBy,
            DiscoveryContentReportSortBy,
            DiscoveryReportGroupBy,
            DiscoveryReportSortBy,
            DiscoveryReportTablePolicyStatus,
            DiskEncryptionType,
            DlpConfigOsType,
            DlpConfigShareType,
            DlpConfigTargetType,
            DlpStatusCode,
            DownloadIdentifierEnum,
            DownloadStatusEnum,
            EmailAddressFilterType,
            EncryptionLevel,
            EventClusterType,
            EventObjectType,
            EventSeverity,
            EventStatus,
            EventType,
            ExchangeBackupPreference,
            ExchangeLiveMountFilterField,
            ExchangeLiveMountSortByField,
            ExistingSnapshotRetention,
            ExocomputeHealthCheckStatusValue,
            FailoverClusterAppConnectionStatus,
            FailoverClusterConnectionStatus,
            FailoverClusterConnectivityStatus,
            FailoverClusterNodeConnectionStatus,
            FailoverClusterOsType,
            FailoverClusterType,
            FailoverGroupByEnum,
            FailoverSortByEnum,
            FailoverStatusEnum,
            FailoverTableColumnEnum,
            FailoverTypeEnum,
            FileActivitiesSortBy,
            FileCountType,
            FileDownloadType,
            FileModeEnum,
            FileRecoveryFeasibility,
            FileResultSortBy,
            FilesetOsType,
            FilesetTemplateCreateOperatingSystemType,
            FilesetTemplateCreateShareType,
            FilesetTemplatePatchOperatingSystemType,
            FilesetTemplatePatchShareType,
            FileSystemType,
            FileVersionSourceEnum,
            GcpNativeDiskSortFields,
            GcpNativeGceInstanceSortFields,
            GcpNativeLabelFilterType,
            GcpNativeProjectSortFields,
            GcpNativeProjectStatus,
            GcpRegion,
            GcpStorageClass,
            GlobalExistingSnapshotRetention,
            GlobalSlaQueryFilterInputField,
            GroupByFieldEnum,
            GroupSortByField,
            GuestCredentialAuthorizationStatus,
            GuestOsCredentialFilterField,
            GuestOsCredentialSortByField,
            GuestOsType,
            HardwareHealthPolicyName,
            HashType,
            HelpContentSnippetsFilterInitiator,
            HelpContentSource,
            HiddenStateFilter,
            HideRevealAction,
            HierarchyFilterField,
            HierarchyObjectTypeEnum,
            HierarchySortByField,
            HostConnectivityStatusEnum,
            HostFailoverClusterRoot,
            HostFilterStatus,
            HostRoot,
            HostUiFilterStatus,
            HostVfdInstallConfig,
            HostVfdState,
            HotAddProxyVmStatusType,
            HypervHostStatusType,
            HypervLiveMountFilterField,
            HypervLiveMountSortByField,
            HypervMountedVmStatusType,
            HypervVirtualMachineDetailGuestOsType,
            HypervVirtualMachineDetailOperatingSystemType,
            HypervVirtualMachineMountSummaryPowerStatus,
            HypervVmAgentConnectionStatus,
            IbmDeploymentType,
            IndicatorOfCompromiseKind,
            InfrastructureTableColumnEnum,
            InodeType,
            InstanceTypeEnum,
            IntegrationType,
            InterfaceType,
            InternalDeleteHypervVirtualMachineSnapshotRequestLocation,
            InternalDeleteNutanixSnapshotRequestLocation,
            InternalQueryHypervHostRequestSlaAssignment,
            InternalQueryHypervHostRequestSortBy,
            InternalQueryHypervHostRequestSortOrder,
            InternalQueryNetworkThrottleRequestResourceId,
            InventoryCard,
            InventorySubHierarchyRootEnum,
            IoFilterStatus,
            IssueEventType,
            IssueStatus,
            K8sClusterProtoType,
            K8sClusterStatus,
            K8sClusterType,
            K8sContentType,
            KuprClusterPortsType,
            LdapAuthorizedPrincipalFieldEnum,
            LdapIntegrationFieldEnum,
            LdapPrincipalFieldEnum,
            LegalHoldQueryFilterField,
            LegalHoldSortType,
            ListAccessUsersSort,
            ListValidReplicationTargetsSortByField,
            LocationScope,
            LockMethod,
            LockoutStateFilter,
            LogLevel,
            M365Cloud,
            MalwareScanInSnapshotStatus,
            ManagedByRubrik,
            ManagedObjectType,
            ManagedVolumeApplicationTag,
            ManagedVolumeShareType,
            ManagedVolumeState,
            ManagedVolumeType,
            MissedSnapshotDayOfTimeUnit,
            MongodbSourceStatus,
            MongoDiscoveryStatus,
            MongoSourceStatus,
            MongoSourceType,
            MongoSslCertificateRequirement,
            MongoType,
            Month,
            MosaicAddStoreRequestStoreType,
            MosaicBulkRecoverableRangeRequestSourceType,
            MosaicRecoverableRangeRequestSourceType,
            MosaicRetrieveRequestSourceType,
            MosaicSnapshotType,
            MosaicStorageLocationFilterField,
            MosaicStorageLocationQuerySortByField,
            MosaicStoreConnectionStatus,
            MosaicStoreObjectStoreType,
            MosaicStoreType,
            MosaicVersionObjectVersionState,
            MountState,
            MssqlBackupType,
            MssqlCbtEffectiveStatusType,
            MssqlCbtStatusType,
            MssqlDatabaseFileType,
            MssqlDatabaseLiveMountFilterField,
            MssqlDatabaseLiveMountSortByField,
            MssqlDatabaseRecoveryModel,
            MssqlDbReplicaAvailabilityInfoRole,
            MssqlDbReplicaRecoveryModel,
            MssqlDbSummaryRecoveryModel,
            MssqlLogShippingOkState,
            MssqlLogShippingStatus,
            MssqlLogShippingTargetFilterField,
            MssqlLogShippingTargetSortByField,
            MssqlRootPropertiesRootType,
            MssqlUnprotectableType,
            NameValidity,
            NasSystemConnectivityStatus,
            NasVendorType,
            NcdTaskStatus,
            NetworkInterfaceType,
            NetworkThrottleResourceId,
            NfAnomalyResultGroupBy,
            NfAnomalyResultSortBy,
            NutanixBackupScriptFailureHandling,
            NutanixLiveMountFilterField,
            NutanixLiveMountSortByField,
            NutanixSnapshotConsistencyMandate,
            NutanixVirtualMachineScriptDetailFailureHandling,
            NutanixVmAgentConnectionStatus,
            O365AppType,
            O365AzureCloudType,
            O365CalendarSearchObjectType,
            O365ConfiguredGroupMemberType,
            O365ContactsSearchObjectType,
            O365GroupType,
            O365RestoreActionType,
            O365ServiceAccountStatus,
            O365ServiceStatusIndication,
            ObjectPolicyStatus,
            ObjectTypeEnum,
            OnedriveSearchKeywordType,
            OnedriveSearchObjectType,
            OpenAccessType,
            Operation,
            OracleLiveMountFilterField,
            OracleLiveMountSortByField,
            OracleLiveMountStatus,
            OraclePdbOpenMode,
            OrgField,
            OrgStatus,
            OsType,
            PastDurationEnum,
            PauseStatus,
            PendingActionGroupTypeEnum,
            PendingActionStatus,
            PendingActionSubGroupTypeEnum,
            PendingActionSyncType,
            PermissionsGroup,
            PolarisObjectAuthorizedOperationsEnum,
            PolarisSnappableAuthorizedOperationsEnum,
            PolicyAssignmentType,
            PolicyDetailsSortBy,
            PolicyObjectFilter,
            PrecheckIdentifier,
            PrechecksStatusTypeEnum,
            PrePostScriptFailureHandlingEnum,
            PrincipalTypeEnum,
            PrivateEndpointConnectionStatus,
            Product,
            ProductDocumentationType,
            ProductName,
            ProductState,
            ProductType,
            ProtectionStatusEnum,
            ProviderType,
            ProvisionStatus,
            ProxyProtocol,
            QuarantineFilter,
            RansomwareResultGroupBy,
            RansomwareResultSortBy,
            RcsConsumptionMetricNameType,
            RcsConsumptionMetricOutputNameType,
            RcsRegionEnumType,
            RcsTierEnumType,
            RcvRegionBundle,
            RcvTier,
            ReaderRetrievalMethod,
            RefreshableObjectConnectionStatusType,
            RegisteredMode,
            ReplicationInterfaceType,
            ReplicationPairConnectionStatus,
            ReplicationPairsQuerySortByField,
            ReplicationSetupType,
            ReplicationType,
            ReportAttachmentType,
            ReportFocusEnum,
            ReportTableColumnEnum,
            ReportTemplate,
            ResolutionType,
            RetentionLockMode,
            RetentionUnit,
            RiskLevelType,
            RiskReason,
            RoleFieldEnum,
            RubrikCloudVaultType,
            S3CompatibleSubType,
            SaasFeature,
            SapHanaDataPathType,
            SapHanaEncryptionProvider,
            SapHanaHostHostType,
            SapHanaLogSnapshotSortBy,
            SapHanaRecoverableRangeSortBy,
            SapHanaSslInfoEncryptionProvider,
            SapHanaSystemAuthType,
            SapHanaSystemAuthTypeSpecAuthType,
            SapHanaSystemStatus,
            SapHanaSystemSummaryContainerType,
            SapHanaSystemSummaryStatus,
            ScriptErrorAction,
            SearchKeywordType,
            SearchObjectType,
            ServiceAccountSortBy,
            ServiceTier,
            SharePointDescendantType,
            SharePointSearchKeywordType,
            SharePointSearchObjectType,
            ShareTypeEnum,
            SlaAssignment,
            SlaAssignmentTypeEnum,
            SlaAssignTypeEnum,
            SlaAuditDetailFilterFieldEnum,
            SlaComplianceTimeRange,
            SlaMigrationIneligibilityReason,
            SlaMigrationStatus,
            SlaObjectType,
            SlaQuerySortByField,
            SlaStatusFilterField,
            SlaSyncStatus,
            SlaTimeUnit,
            SmbAuthenticationStatus,
            SmbDomainFilterField,
            SmbDomainSortByField,
            SmbDomainStatus,
            SnappableAggregationsEnum,
            SnappableCrawlStatus,
            SnappableGroupByEnum,
            SnappableSlaAssignment,
            SnappableSortByEnum,
            SnappableTableColumnEnum,
            SnappableType,
            SnapshotCloudState,
            SnapshotCloudStorageTier,
            SnapshotConsistencyLevel,
            SnapshotCustomization,
            SnapshotFrequency,
            SnapshotQueryFilterField,
            SnapshotQuerySortByField,
            SnapshotSearchError,
            SnapshotServiceBackupStatus,
            SnapshotServiceConsistencyLevel,
            SnapshotType,
            SnapshotTypeEnum,
            SnapshotTypeForRestoreIfSourceExpired,
            SnapshotTypeToUseIfSourceExpired,
            SnmpSecurityLevel,
            SonarContentReportTableColumnEnum,
            SonarReportTableColumnEnum,
            SortByFieldEnum,
            SortOrder,
            SourceSourceType,
            SourceSslCertReqs,
            SqlAuthenticationMechanism,
            SsoCertificateType,
            StalenessType,
            StorageAccountSku,
            StorageAccountTier,
            StorageArrayType,
            SupportUserAccessFilterField,
            SupportUserAccessSortByField,
            SupportUserAccessStatus,
            SyslogFacility,
            SyslogSeverity,
            TagFilterType,
            TagRuleSlaAssignType,
            TargetEncryptionTypeEnum,
            TargetMappingQueryFilterField,
            TargetQueryFilterField,
            TargetSyncStatus,
            TargetType,
            TaskchainState,
            TaskDetailGroupByEnum,
            TaskDetailSortByEnum,
            TaskDetailTableColumnEnum,
            TaskReportTableColumnEnum,
            TaskSummaryGroupByEnum,
            TaskSummarySortByEnum,
            TenantAuthDomainConfig,
            TenantNetworkHealth,
            ThreatHuntMatchesFound,
            ThreatHuntQuarantinedMatchType,
            ThreatHuntStatus,
            ThreatMonitoringEnablementEntity,
            TimeDuration,
            TimeGranularity,
            TimeUnitEnum,
            TransportLayerProtocol,
            UnlockMethod,
            UnmanagedObjectAvailabilityFilter,
            UnmanagedObjectsSortType,
            UnmanagedSnapshotType,
            UnmappingValidationType,
            UpgradeInfoSortByEnum,
            UpgradeStatus,
            UpgradeType,
            UploadLocationType,
            UserAccessType,
            UserAuditGroupByEnum,
            UserAuditObjectTypeEnum,
            UserAuditSeverityEnum,
            UserAuditSortByEnum,
            UserAuditSortField,
            UserAuditStatusEnum,
            UserAuditTableColumnEnum,
            UserAuditTypeEnum,
            UserDomainEnum,
            UserFieldEnum,
            UserSortByField,
            UserStatus,
            V1GetCompatibleMssqlInstancesV1RequestRecoveryType,
            V1QueryCertificatesRequestSortBy,
            V1QueryCertificatesRequestSortOrder,
            V1QueryLogReportRequestSortBy,
            V1QueryLogReportRequestSortOrder,
            V1QueryUnmanagedObjectSnapshotsV1RequestSnapshotType,
            V1QueryUnmanagedObjectSnapshotsV1RequestSortBy,
            V1QueryUnmanagedObjectSnapshotsV1RequestSortOrder,
            V2BulkDeleteMosaicSourcesRequestSourceType,
            V2DeleteMosaicSourceRequestSourceType,
            V2QueryLogShippingConfigurationsV2RequestSortBy,
            V2QueryLogShippingConfigurationsV2RequestSortOrder,
            V2QueryLogShippingConfigurationsV2RequestStatus,
            VappVmIpAddressingMode,
            VcenterConfigConflictResolutionAuthz,
            VcenterConfigV2ConflictResolutionAuthz,
            VcenterSummaryConflictResolutionAuthz,
            VersionSourceType,
            VersionStatus,
            VirtualMachineFileType,
            VirtualMachineScriptDetailFailureHandling,
            VirtualMachineSummarySnapshotConsistencyMandate,
            VirtualMachineUpdateSnapshotConsistencyMandate,
            VmNetworkAddressingMode,
            VmPowerStatus,
            VmType,
            VmwareFolderType,
            VolumeGroupLiveMountFilterField,
            VolumeGroupLiveMountSortByField,
            VsphereLiveMountFilterField,
            VsphereLiveMountSortByField,
            VsphereLiveMountStatus,
            VsphereMountSortBy,
            VsphereMountStatus,
            WebhookStatus,
            WeekDay,
            WhitelistModeEnum,
            WorkloadAnomaliesSortBy,
            WorkloadLevelHierarchy,
        }

        /// <summary>
        /// All GraphQL scalar names.
        /// </summary>
        public enum GqlScalarName
        {
            Unknown,
            Boolean,
            DateTime,
            Float,
            Id,
            Int,
            LocalTime,
            Long,
            String,
            Url,
            Uuid,
            Void,
        }

        /// <summary>
        /// All GraphQL union names.
        /// </summary>
        public enum GqlUnionName
        {
            Unknown,
            AnomalyResultGroupByInfo,
            CdmSnapshotGroupByInfo,
            ClusterGroupByInfo,
            ClusterMetricGroupByInfo,
            ManagedVolumeQueuedSnapshotGroupByInfo,
            MissedSnapshotGroupByInfo,
            MongoSnapshotGroupByInfo,
            MosaicSnapshotGroupByInfo,
            NfAnomalyResultGroupByInfo,
            PolarisSnapshotGroupByInfo,
            RansomwareResultGroupByInfo,
            ReportChartType,
            ReportTableType,
            SnappableGroupByInfo,
            SnappableLocationType,
            TaskDetailGroupByInfo,
        }

        /// <summary>
        /// Given the name of an interface type, return the names of the types that implement it.
        /// </summary>
        public static HashSet<string> InterfaceImpls( string interfaceName )
        {
            var InterfaceImplsDict = new Dictionary<string, HashSet<string>> {
                {
                    "AwsNativeAccountDescendantType",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AwsNativeAccountLogicalChildType",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AwsNativeHierarchyObject",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeS3Bucket",
                    }
                },
                {
                    "AzureNativeHierarchyObjectType",
                    new HashSet<string> {
                    "AzureNativeHierarchyObjectType",
                    "AzureNativeManagedDisk",
                    "AzureNativeVirtualMachine",
                    "AzureStorageAccount",
                    }
                },
                {
                    "CassandraKeyspaceDescendantType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    }
                },
                {
                    "CassandraKeyspacePhysicalChildType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    }
                },
                {
                    "CassandraSourceDescendantType",
                    new HashSet<string> {
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    }
                },
                {
                    "CassandraSourcePhysicalChildType",
                    new HashSet<string> {
                    "CassandraKeyspace",
                    "CassandraSourcePhysicalChildType",
                    }
                },
                {
                    "CdmHierarchyObject",
                    new HashSet<string> {
                    "Db2Database",
                    "Db2Instance",
                    "ExchangeDag",
                    "ExchangeDatabase",
                    "ExchangeServer",
                    "FailoverClusterApp",
                    "FilesetTemplate",
                    "HostFailoverCluster",
                    "HostShare",
                    "HyperVcluster",
                    "HyperVscvmm",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    "LinuxFileset",
                    "ManagedVolume",
                    "ManagedVolumeMount",
                    "MongoCollection",
                    "MongoCollectionSet",
                    "MongoDatabase",
                    "MongoSource",
                    "MssqlAvailabilityGroup",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasSystem",
                    "NasVolume",
                    "NutanixCategory",
                    "NutanixCategoryValue",
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    "NutanixVm",
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "OracleHost",
                    "OracleRac",
                    "PhysicalHost",
                    "SapHanaDatabase",
                    "SapHanaSystem",
                    "ShareFileset",
                    "Vcd",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereTag",
                    "VsphereTagCategory",
                    "VsphereVcenter",
                    "VsphereVm",
                    "WindowsCluster",
                    "WindowsFileset",
                    }
                },
                {
                    "CdmHierarchySnappableNew",
                    new HashSet<string> {
                    "CdmHierarchySnappableNew",
                    "Db2Database",
                    "ExchangeDatabase",
                    "HyperVvirtualMachine",
                    "LinuxFileset",
                    "ManagedVolume",
                    "MongoCollectionSet",
                    "MssqlDatabase",
                    "NasFileset",
                    "NutanixVm",
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "SapHanaDatabase",
                    "ShareFileset",
                    "VcdVapp",
                    "VsphereVm",
                    "WindowsFileset",
                    }
                },
                {
                    "CloudAccount",
                    new HashSet<string> {
                    "AwsAccount",
                    "AwsRoleBasedAccount",
                    "AzureAccount",
                    "AzureRoleBasedAccount",
                    }
                },
                {
                    "CloudDirectHierarchyObject",
                    new HashSet<string> {
                    "CloudDirectNasExport",
                    }
                },
                {
                    "CloudDirectHierarchyWorkload",
                    new HashSet<string> {
                    "CloudDirectNasExport",
                    }
                },
                {
                    "Db2InstanceDescendantType",
                    new HashSet<string> {
                    "Db2Database",
                    "PhysicalHost",
                    }
                },
                {
                    "Db2InstancePhysicalChildType",
                    new HashSet<string> {
                    "Db2Database",
                    "PhysicalHost",
                    }
                },
                {
                    "DisplayableValue",
                    new HashSet<string> {
                    "DisplayableValueBoolean",
                    "DisplayableValueComplianceRange",
                    "DisplayableValueDateRange",
                    "DisplayableValueDateTime",
                    "DisplayableValueFloat",
                    "DisplayableValueInteger",
                    "DisplayableValueLong",
                    "DisplayableValueNull",
                    "DisplayableValueString",
                    }
                },
                {
                    "ExchangeDagDescendantType",
                    new HashSet<string> {
                    "ExchangeDagDescendantType",
                    "ExchangeDatabase",
                    }
                },
                {
                    "ExchangeServerDescendantType",
                    new HashSet<string> {
                    "ExchangeDatabase",
                    }
                },
                {
                    "FailoverClusterAppDescendantType",
                    new HashSet<string> {
                    "FailoverClusterAppDescendantType",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FailoverClusterAppPhysicalChildType",
                    new HashSet<string> {
                    "FailoverClusterAppPhysicalChildType",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FailoverClusterTopLevelDescendantType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "HostFailoverCluster",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FilesetTemplateDescendantType",
                    new HashSet<string> {
                    "FilesetTemplateDescendantType",
                    "LinuxFileset",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "FilesetTemplatePhysicalChildType",
                    new HashSet<string> {
                    "FilesetTemplatePhysicalChildType",
                    "LinuxFileset",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "GcpNativeProjectDescendantType",
                    new HashSet<string> {
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    }
                },
                {
                    "GcpNativeProjectLogicalChildType",
                    new HashSet<string> {
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    }
                },
                {
                    "GenericSnapshot",
                    new HashSet<string> {
                    "CdmSnapshot",
                    "PolarisSnapshot",
                    }
                },
                {
                    "HierarchyObject",
                    new HashSet<string> {
                    "AwsNativeAccount",
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureAdDirectory",
                    "AzureNativeManagedDisk",
                    "AzureNativeResourceGroup",
                    "AzureNativeSubscription",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlDatabaseServer",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureSqlManagedInstanceServer",
                    "AzureStorageAccount",
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    "CassandraSource",
                    "CloudDirectNasExport",
                    "Db2Database",
                    "Db2Instance",
                    "ExchangeDag",
                    "ExchangeDatabase",
                    "ExchangeServer",
                    "FailoverClusterApp",
                    "FilesetTemplate",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "GcpNativeProject",
                    "HostFailoverCluster",
                    "HostShare",
                    "HyperVcluster",
                    "HyperVscvmm",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    "K8sCluster",
                    "K8sNamespace",
                    "LinuxFileset",
                    "ManagedVolume",
                    "ManagedVolumeMount",
                    "MongoCollection",
                    "MongoCollectionSet",
                    "MongoDatabase",
                    "MongodbCollection",
                    "MongodbDatabase",
                    "MongodbSource",
                    "MongoSource",
                    "MssqlAvailabilityGroup",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasSystem",
                    "NasVolume",
                    "NutanixCategory",
                    "NutanixCategoryValue",
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    "NutanixVm",
                    "O365Calendar",
                    "O365Group",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365Org",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "O365User",
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "OracleHost",
                    "OracleRac",
                    "PhysicalHost",
                    "SapHanaDatabase",
                    "SapHanaSystem",
                    "ShareFileset",
                    "Vcd",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereTag",
                    "VsphereTagCategory",
                    "VsphereVcenter",
                    "VsphereVm",
                    "WindowsCluster",
                    "WindowsFileset",
                    }
                },
                {
                    "HierarchySnappable",
                    new HashSet<string> {
                    "AzureAdDirectory",
                    "K8sNamespace",
                    "LinuxFileset",
                    "NasFileset",
                    "NutanixVm",
                    "O365Calendar",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "ShareFileset",
                    "VcdVapp",
                    "VsphereVm",
                    "WindowsFileset",
                    }
                },
                {
                    "HostFailoverClusterDescendantType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "HostFailoverClusterPhysicalChildType",
                    new HashSet<string> {
                    "FailoverClusterApp",
                    "LinuxFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "HostShareDescendantType",
                    new HashSet<string> {
                    "HostShareDescendantType",
                    "ShareFileset",
                    }
                },
                {
                    "HostSharePhysicalChildType",
                    new HashSet<string> {
                    "HostSharePhysicalChildType",
                    "ShareFileset",
                    }
                },
                {
                    "HyperVclusterDescendantType",
                    new HashSet<string> {
                    "HyperVclusterDescendantType",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HyperVclusterLogicalChildType",
                    new HashSet<string> {
                    "HyperVclusterLogicalChildType",
                    "HypervServer",
                    }
                },
                {
                    "HyperVscvmmDescendantType",
                    new HashSet<string> {
                    "HyperVcluster",
                    "HyperVscvmmDescendantType",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HyperVscvmmLogicalChildType",
                    new HashSet<string> {
                    "HyperVcluster",
                    "HyperVscvmmLogicalChildType",
                    "HypervServer",
                    }
                },
                {
                    "HypervServerDescendantType",
                    new HashSet<string> {
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HypervServerLogicalChildType",
                    new HashSet<string> {
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "HypervTopLevelDescendantType",
                    new HashSet<string> {
                    "HyperVcluster",
                    "HyperVscvmm",
                    "HypervServer",
                    "HyperVvirtualMachine",
                    }
                },
                {
                    "K8sClusterDescendant",
                    new HashSet<string> {
                    "K8sClusterDescendant",
                    "K8sNamespace",
                    }
                },
                {
                    "ManagedVolumeDescendantType",
                    new HashSet<string> {
                    "ManagedVolumeMount",
                    "PhysicalHost",
                    }
                },
                {
                    "ManagedVolumeMountDescendantType",
                    new HashSet<string> {
                    "PhysicalHost",
                    }
                },
                {
                    "ManagedVolumeMountPhysicalChildType",
                    new HashSet<string> {
                    "PhysicalHost",
                    }
                },
                {
                    "ManagedVolumePhysicalChildType",
                    new HashSet<string> {
                    "ManagedVolumeMount",
                    "ManagedVolumePhysicalChildType",
                    }
                },
                {
                    "MongoCollectionSetDescendantType",
                    new HashSet<string> {
                    "MongoCollection",
                    }
                },
                {
                    "MongoCollectionSetPhysicalChildType",
                    new HashSet<string> {
                    "MongoCollection",
                    }
                },
                {
                    "MongoDatabaseDescendantType",
                    new HashSet<string> {
                    "MongoCollection",
                    "MongoCollectionSet",
                    }
                },
                {
                    "MongoDatabasePhysicalChildType",
                    new HashSet<string> {
                    "MongoCollectionSet",
                    "MongoDatabasePhysicalChildType",
                    }
                },
                {
                    "MongoSourceDescendantType",
                    new HashSet<string> {
                    "MongoCollection",
                    "MongoCollectionSet",
                    "MongoDatabase",
                    "PhysicalHost",
                    }
                },
                {
                    "MongoSourcePhysicalChildType",
                    new HashSet<string> {
                    "MongoDatabase",
                    "PhysicalHost",
                    }
                },
                {
                    "MongodbDatabaseDescendantType",
                    new HashSet<string> {
                    "MongodbCollection",
                    }
                },
                {
                    "MongodbDatabasePhysicalChildType",
                    new HashSet<string> {
                    "MongodbCollection",
                    }
                },
                {
                    "MongodbSourceDescendantType",
                    new HashSet<string> {
                    "MongodbCollection",
                    "MongodbDatabase",
                    }
                },
                {
                    "MongodbSourcePhysicalChildType",
                    new HashSet<string> {
                    "MongodbDatabase",
                    "MongodbSourcePhysicalChildType",
                    }
                },
                {
                    "MssqlAvailabilityGroupDescendantType",
                    new HashSet<string> {
                    "MssqlAvailabilityGroupDescendantType",
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlAvailabilityGroupLogicalChildType",
                    new HashSet<string> {
                    "MssqlAvailabilityGroupLogicalChildType",
                    "MssqlDatabase",
                    }
                },
                {
                    "MssqlInstanceDescendantType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    "MssqlInstanceDescendantType",
                    }
                },
                {
                    "MssqlInstanceLogicalChildType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    "MssqlInstanceLogicalChildType",
                    }
                },
                {
                    "MssqlTopLevelDescendantType",
                    new HashSet<string> {
                    "MssqlAvailabilityGroup",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "PhysicalHost",
                    "WindowsCluster",
                    }
                },
                {
                    "NasNamespaceDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasNamespaceDescendantType",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasNamespaceLogicalChildType",
                    new HashSet<string> {
                    "NasNamespaceLogicalChildType",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasShareDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasShareDescendantType",
                    }
                },
                {
                    "NasShareLogicalChildType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasShareLogicalChildType",
                    }
                },
                {
                    "NasSystemDescendantType",
                    new HashSet<string> {
                    "NasFileset",
                    "NasNamespace",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasSystemLogicalChildType",
                    new HashSet<string> {
                    "NasNamespace",
                    "NasShare",
                    "NasVolume",
                    }
                },
                {
                    "NasVolumeDescendantType",
                    new HashSet<string> {
                    "NasShare",
                    "NasVolumeDescendantType",
                    }
                },
                {
                    "NasVolumeLogicalChildType",
                    new HashSet<string> {
                    "NasShare",
                    "NasVolumeLogicalChildType",
                    }
                },
                {
                    "NutanixCategoryDescendantType",
                    new HashSet<string> {
                    "NutanixCategoryDescendantType",
                    "NutanixCategoryValue",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixCategoryLogicalChildType",
                    new HashSet<string> {
                    "NutanixCategoryLogicalChildType",
                    "NutanixCategoryValue",
                    }
                },
                {
                    "NutanixCategoryValueDescendantType",
                    new HashSet<string> {
                    "NutanixCategoryValueDescendantType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixCategoryValueLogicalChildType",
                    new HashSet<string> {
                    "NutanixCategoryValueLogicalChildType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixClusterDescendantType",
                    new HashSet<string> {
                    "NutanixClusterDescendantType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixClusterLogicalChildType",
                    new HashSet<string> {
                    "NutanixClusterLogicalChildType",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixPrismCentralDescendantType",
                    new HashSet<string> {
                    "NutanixCategory",
                    "NutanixCategoryValue",
                    "NutanixCluster",
                    "NutanixVm",
                    }
                },
                {
                    "NutanixPrismCentralLogicalChildType",
                    new HashSet<string> {
                    "NutanixCategory",
                    "NutanixCluster",
                    }
                },
                {
                    "NutanixTopLevelDescendantType",
                    new HashSet<string> {
                    "NutanixCluster",
                    "NutanixPrismCentral",
                    }
                },
                {
                    "O365AppObject",
                    new HashSet<string> {
                    "O365App",
                    }
                },
                {
                    "O365ExchangeObject",
                    new HashSet<string> {
                    "O365CalendarEvent",
                    "O365CalendarFolder",
                    "O365Contact",
                    "O365ContactFolder",
                    "O365Email",
                    "O365ExchangeObject",
                    "O365Folder",
                    }
                },
                {
                    "O365FullSpObject",
                    new HashSet<string> {
                    "O365FullSpDescendant",
                    "O365FullSpObject",
                    }
                },
                {
                    "O365OnedriveObject",
                    new HashSet<string> {
                    "O365OnedriveFile",
                    "O365OnedriveFolder",
                    "O365OnedriveObject",
                    }
                },
                {
                    "O365OrgDescendant",
                    new HashSet<string> {
                    "O365Calendar",
                    "O365Group",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "O365User",
                    }
                },
                {
                    "O365SharepointObject",
                    new HashSet<string> {
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    }
                },
                {
                    "O365TeamsChannelObject",
                    new HashSet<string> {
                    "O365TeamsChannel",
                    }
                },
                {
                    "O365UserDescendant",
                    new HashSet<string> {
                    "O365Calendar",
                    "O365Mailbox",
                    "O365Onedrive",
                    }
                },
                {
                    "O365UserDescendantMetadata",
                    new HashSet<string> {
                    "O365Mailbox",
                    "O365Onedrive",
                    }
                },
                {
                    "OracleDataGuardGroupDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    "OracleDataGuardGroupDescendantType",
                    }
                },
                {
                    "OracleDataGuardGroupLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
                    "OracleDataGuardGroupLogicalChildType",
                    }
                },
                {
                    "OracleHostDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleHostLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleRacDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleRacLogicalChildType",
                    new HashSet<string> {
                    "OracleDatabase",
                    }
                },
                {
                    "OracleTopLevelDescendantType",
                    new HashSet<string> {
                    "OracleDatabase",
                    "OracleDataGuardGroup",
                    "OracleHost",
                    "OracleRac",
                    }
                },
                {
                    "PhysicalHostDescendantType",
                    new HashSet<string> {
                    "ExchangeServer",
                    "HostShare",
                    "HyperVscvmm",
                    "HypervServer",
                    "LinuxFileset",
                    "MssqlDatabase",
                    "MssqlInstance",
                    "PhysicalHostDescendantType",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "PhysicalHostPhysicalChildType",
                    new HashSet<string> {
                    "ExchangeServer",
                    "HostShare",
                    "HyperVscvmm",
                    "HypervServer",
                    "LinuxFileset",
                    "MssqlInstance",
                    "PhysicalHostPhysicalChildType",
                    "ShareFileset",
                    "WindowsFileset",
                    }
                },
                {
                    "PolarisHierarchyObject",
                    new HashSet<string> {
                    "AwsNativeAccount",
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureAdDirectory",
                    "AzureNativeManagedDisk",
                    "AzureNativeResourceGroup",
                    "AzureNativeSubscription",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlDatabaseServer",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureSqlManagedInstanceServer",
                    "AzureStorageAccount",
                    "CassandraColumnFamily",
                    "CassandraKeyspace",
                    "CassandraSource",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "GcpNativeProject",
                    "K8sCluster",
                    "K8sNamespace",
                    "MongodbCollection",
                    "MongodbDatabase",
                    "MongodbSource",
                    "O365Calendar",
                    "O365Group",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365Org",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    "O365User",
                    }
                },
                {
                    "PolarisHierarchySnappable",
                    new HashSet<string> {
                    "AwsNativeEbsVolume",
                    "AwsNativeEc2Instance",
                    "AwsNativeRdsInstance",
                    "AwsNativeS3Bucket",
                    "AzureAdDirectory",
                    "AzureNativeManagedDisk",
                    "AzureNativeVirtualMachine",
                    "AzureSqlDatabaseDb",
                    "AzureSqlManagedInstanceDatabase",
                    "AzureStorageAccount",
                    "GcpNativeDisk",
                    "GcpNativeGceInstance",
                    "K8sNamespace",
                    "O365Calendar",
                    "O365Mailbox",
                    "O365Onedrive",
                    "O365SharepointDrive",
                    "O365SharepointList",
                    "O365Site",
                    "O365Teams",
                    }
                },
                {
                    "PolarisSpecificSnapshot",
                    new HashSet<string> {
                    "AwsNativeEc2InstanceSpecificSnapshot",
                    "AzureNativeVmSpecificSnapshot",
                    "M365Snapshot",
                    "O365SiteSpecificSnapshot",
                    }
                },
                {
                    "ProtectedObjectSummary",
                    new HashSet<string> {
                    "ProtectedObjects",
                    }
                },
                {
                    "SapHanaSystemDescendantType",
                    new HashSet<string> {
                    "SapHanaDatabase",
                    }
                },
                {
                    "SapHanaSystemPhysicalChildType",
                    new HashSet<string> {
                    "SapHanaDatabase",
                    }
                },
                {
                    "SlaDomain",
                    new HashSet<string> {
                    "ClusterSlaDomain",
                    "GlobalSlaReply",
                    }
                },
                {
                    "Target",
                    new HashSet<string> {
                    "CdmManagedAwsTarget",
                    "CdmManagedAzureTarget",
                    "CdmManagedGcpTarget",
                    "CdmManagedGlacierTarget",
                    "CdmManagedNfsTarget",
                    "CdmManagedS3CompatibleTarget",
                    "CdmManagedTapeTarget",
                    "CdmTarget",
                    "RubrikManagedAwsTarget",
                    "RubrikManagedAzureTarget",
                    "RubrikManagedGcpTarget",
                    "RubrikManagedGlacierTarget",
                    "RubrikManagedNfsTarget",
                    "RubrikManagedRcsTarget",
                    "RubrikManagedS3CompatibleTarget",
                    "RubrikManagedTapeTargetType",
                    "Target",
                    }
                },
                {
                    "TargetTemplate",
                    new HashSet<string> {
                    "AwsTargetTemplate",
                    "AzureTargetTemplate",
                    "RcsAzureTargetTemplate",
                    }
                },
                {
                    "Value",
                    new HashSet<string> {
                    "ValueBoolean",
                    "ValueDateTime",
                    "ValueFloat",
                    "ValueInteger",
                    "ValueLong",
                    "ValueNull",
                    "ValueString",
                    }
                },
                {
                    "VcdCatalogDescendantType",
                    new HashSet<string> {
                    "VcdVapp",
                    }
                },
                {
                    "VcdCatalogLogicalChildType",
                    new HashSet<string> {
                    "VcdVapp",
                    }
                },
                {
                    "VcdDescendantType",
                    new HashSet<string> {
                    "VcdDescendantType",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdLogicalChildType",
                    new HashSet<string> {
                    "VcdLogicalChildType",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgDescendantType",
                    new HashSet<string> {
                    "VcdOrgDescendantType",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgLogicalChildType",
                    new HashSet<string> {
                    "VcdOrgLogicalChildType",
                    "VcdOrgVdc",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgVdcDescendantType",
                    new HashSet<string> {
                    "VcdOrgVdcDescendantType",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdOrgVdcLogicalChildType",
                    new HashSet<string> {
                    "VcdOrgVdcLogicalChildType",
                    "VcdVapp",
                    "VsphereVm",
                    }
                },
                {
                    "VcdTopLevelDescendantType",
                    new HashSet<string> {
                    "Vcd",
                    "VcdOrg",
                    "VcdOrgVdc",
                    "VcdVapp",
                    "VcdVimServer",
                    "VsphereVm",
                    }
                },
                {
                    "VcdVappDescendantType",
                    new HashSet<string> {
                    "VsphereVm",
                    }
                },
                {
                    "VcdVappLogicalChildType",
                    new HashSet<string> {
                    "VcdVappLogicalChildType",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereComputeClusterDescendantType",
                    new HashSet<string> {
                    "VsphereComputeClusterDescendantType",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereComputeClusterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereComputeClusterPhysicalChildType",
                    "VsphereHost",
                    "VsphereResourcePool",
                    }
                },
                {
                    "VsphereDatacenterDescendantType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereDatacenterFolderDescendantType",
                    new HashSet<string> {
                    "VsphereDatacenter",
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereDatacenterFolderLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenter",
                    "VsphereFolder",
                    }
                },
                {
                    "VsphereDatacenterLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenterLogicalChildType",
                    "VsphereFolder",
                    }
                },
                {
                    "VsphereDatacenterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatastoreCluster",
                    "VsphereHost",
                    }
                },
                {
                    "VsphereDatastoreClusterDescendantType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreClusterDescendantType",
                    }
                },
                {
                    "VsphereDatastoreClusterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreClusterPhysicalChildType",
                    }
                },
                {
                    "VsphereFolderDescendantType",
                    new HashSet<string> {
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereFolderLogicalChildType",
                    new HashSet<string> {
                    "VsphereFolder",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereHostDescendantType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereHostPhysicalChildType",
                    new HashSet<string> {
                    "VsphereHostPhysicalChildType",
                    "VsphereResourcePool",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereResourcePoolDescendantType",
                    new HashSet<string> {
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    }
                },
                {
                    "VsphereResourcePoolPhysicalChildType",
                    new HashSet<string> {
                    "VsphereResourcePool",
                    "VsphereResourcePoolPhysicalChildType",
                    }
                },
                {
                    "VsphereTagCategoryDescendantType",
                    new HashSet<string> {
                    "VsphereTag",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereTagCategoryTagChildType",
                    new HashSet<string> {
                    "VsphereTag",
                    "VsphereTagCategoryTagChildType",
                    }
                },
                {
                    "VsphereTagDescendantType",
                    new HashSet<string> {
                    "VsphereVm",
                    }
                },
                {
                    "VsphereTagTagChildType",
                    new HashSet<string> {
                    "VsphereVm",
                    }
                },
                {
                    "VsphereVcenterDescendantType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastore",
                    "VsphereDatastoreCluster",
                    "VsphereFolder",
                    "VsphereHost",
                    "VsphereNetwork",
                    "VsphereResourcePool",
                    "VsphereTag",
                    "VsphereTagCategory",
                    "VsphereVm",
                    }
                },
                {
                    "VsphereVcenterLogicalChildType",
                    new HashSet<string> {
                    "VsphereDatacenter",
                    "VsphereFolder",
                    }
                },
                {
                    "VsphereVcenterPhysicalChildType",
                    new HashSet<string> {
                    "VsphereComputeCluster",
                    "VsphereDatacenter",
                    "VsphereDatastoreCluster",
                    "VsphereHost",
                    }
                },
                {
                    "VsphereVcenterTagChildType",
                    new HashSet<string> {
                    "VsphereTagCategory",
                    "VsphereVcenterTagChildType",
                    }
                },
                {
                    "WindowsClusterDescendantType",
                    new HashSet<string> {
                    "MssqlDatabase",
                    "MssqlInstance",
                    }
                },
                {
                    "WindowsClusterLogicalChildType",
                    new HashSet<string> {
                    "MssqlInstance",
                    }
                },
            };
            if (InterfaceImplsDict.TryGetValue(interfaceName, out var implNames))
            {
                return implNames;
            }
            return new HashSet<string>();
        }
        
        /// <summary>
        /// Given the name of a type, return the names of the unions that include it.
        /// </summary>
        public static HashSet<string> UnionMembership( string typeName )
        {
            var UnionMembershipDict = new Dictionary<string, HashSet<string>> {
                {
                    "ActivityChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "ActivitySeverityLevel",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    }
                },
                {
                    "ActivityTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "AnomalyChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "AnomalyStatus",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    }
                },
                {
                    "AnomalyTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "AzureSnappableLocation",
                    new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                {
                    "CdmSnappableLocation",
                    new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
                {
                    "Cluster",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "ClusterSlaDomain",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ClusterType",
                    new HashSet<string> {
                    "ClusterGroupByInfo",
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ComplianceStatus",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "FailoverChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "FailoverTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "InfrastructureChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "InfrastructureTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "ObjectType",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "ProtectionStatus",
                    new HashSet<string> {
                    "SnappableGroupByInfo",
                    }
                },
                {
                    "Snappable",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    }
                },
                {
                    "SnappableChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "SnappableTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "SonarContentReportChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "SonarContentReportTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "SonarReportChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "SonarReportTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "Status",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TaskDetailChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "TaskDetailClusterType",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TaskDetailObjectType",
                    new HashSet<string> {
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "TaskDetailTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "TaskSummaryChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "TaskSummaryTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "TimeRangeWithUnit",
                    new HashSet<string> {
                    "AnomalyResultGroupByInfo",
                    "CdmSnapshotGroupByInfo",
                    "ClusterGroupByInfo",
                    "ClusterMetricGroupByInfo",
                    "ManagedVolumeQueuedSnapshotGroupByInfo",
                    "MissedSnapshotGroupByInfo",
                    "MongoSnapshotGroupByInfo",
                    "MosaicSnapshotGroupByInfo",
                    "NfAnomalyResultGroupByInfo",
                    "PolarisSnapshotGroupByInfo",
                    "RansomwareResultGroupByInfo",
                    "SnappableGroupByInfo",
                    "TaskDetailGroupByInfo",
                    }
                },
                {
                    "UserAuditChart",
                    new HashSet<string> {
                    "ReportChartType",
                    }
                },
                {
                    "UserAuditTable",
                    new HashSet<string> {
                    "ReportTableType",
                    }
                },
                {
                    "WorkloadLocation",
                    new HashSet<string> {
                    "SnappableLocationType",
                    }
                },
            };
            if (UnionMembershipDict.TryGetValue(typeName, out var unionNames))
            {
                return unionNames;
            }
            return new HashSet<string>();
        }

        /// <summary>
        /// All GraphQL root field names (for both queries and mutations)
        /// that are accessible through master cmdlets.
        /// </summary>
        public enum GqlRootFieldName
        {
            Unknown,
            accountId,
            accountSettings,
            activitySeries,
            activitySeriesConnection,
            addAwsAuthenticationServerBasedCloudAccount,
            addAwsIamUserBasedCloudAccount,
            addAzureCloudAccount,
            addAzureCloudAccountExocomputeConfigurations,
            addAzureCloudAccountWithoutOauth,
            addDb2Instance,
            addManagedVolume,
            addMongoSource,
            addNodesToCloudCluster,
            addO365Org,
            allAccountOwners,
            allAccountProducts,
            allAccountsWithExocomputeMappings,
            allAvailabilityZonesByRegionFromAws,
            allAwsCdmVersions,
            allAwsCloudAccountConfigs,
            allAwsCloudAccountsWithFeatures,
            allAwsComputeSettings,
            allAwsExocomputeConfigs,
            allAwsInstanceProfileNames,
            allAwsPermissionPolicies,
            allAwsRegions,
            allAzureArmTemplatesByFeature,
            allAzureCdmVersions,
            allAzureCloudAccountMissingPermissions,
            allAzureCloudAccountSubnetsByRegion,
            allAzureCloudAccountSubscriptionsByFeature,
            allAzureCloudAccountTenants,
            allAzureDiskEncryptionSetsByRegion,
            allAzureEncryptionKeys,
            allAzureExocomputeConfigsInAccount,
            allAzureKeyVaultsByRegion,
            allAzureManagedIdentities,
            allAzureNativeAvailabilitySetsByRegionFromAzure,
            allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
            allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
            allAzureNativeResourceGroupsInfoIfExist,
            allAzureNativeSecurityGroupsByRegionFromAzure,
            allAzureNativeStorageAccountsFromAzure,
            allAzureNativeSubnetsByRegionFromAzure,
            allAzureNativeVirtualMachineSizes,
            allAzureNativeVirtualNetworks,
            allAzureNsgs,
            allAzureRegions,
            allAzureResourceGroups,
            allAzureSqlDatabaseServerElasticPools,
            allAzureStorageAccounts,
            allAzureSubnets,
            allAzureSubscriptionWithExocomputeMappings,
            allAzureVnets,
            allClusterGlobalSlas,
            allClusterReplicationTargets,
            allClusterWebCertsAndIpmis,
            allClustersTotpAckStatus,
            allConnectedClusters,
            allDbParameterGroupsByRegionFromAws,
            allDbSubnetGroupsByRegionFromAws,
            allEc2KeyPairsByRegionFromAws,
            allHostedAzureRegions,
            allKmsEncryptionKeysByRegionFromAws,
            allMssqlDatabaseRestoreFiles,
            allNcdSlaComplianceData,
            allO365AdGroups,
            allO365OrgStatuses,
            allO365SubscriptionsAppTypeCounts,
            allOptionGroupsByRegionFromAws,
            allResourceGroupsFromAzure,
            allS3BucketsDetailsFromAws,
            allS3BucketsFromAws,
            allSlaSummariesByIds,
            allSupportedAwsRdsDatabaseInstanceClasses,
            allVcenterHotAddProxyVms,
            allVpcsByRegionFromAws,
            allVpcsFromAws,
            amiTypeForAwsNativeArchivedSnapshotExport,
            archiveK8sCluster,
            assignMssqlSlaDomainProperties,
            assignMssqlSlaDomainPropertiesAsync,
            assignRetentionSLAToSnappables,
            assignRetentionSLAToSnapshots,
            assignSla,
            assignSlaToMongoDbCollection,
            assignSlasForSnappableHierarchies,
            awsArtifactsToDelete,
            awsCloudAccountListSecurityGroups,
            awsCloudAccountListSubnets,
            awsCloudAccountListVpcs,
            awsCloudAccountWithFeatures,
            awsComputeSettings,
            awsNativeAccount,
            awsNativeAccounts,
            awsNativeEbsVolume,
            awsNativeEbsVolumes,
            awsNativeEbsVolumesByName,
            awsNativeEc2Instance,
            awsNativeEc2Instances,
            awsNativeEc2InstancesByName,
            awsNativeRdsExportDefaults,
            awsNativeRdsInstance,
            awsNativeRdsInstances,
            awsNativeRdsPointInTimeRestoreWindow,
            awsNativeRoot,
            awsNativeS3Bucket,
            awsTrustPolicy,
            azureAdDirectories,
            azureAdDirectory,
            azureAdObjectsByType,
            azureCloudAccountPermissionConfig,
            azureCloudAccountSubscriptionWithFeatures,
            azureCloudAccountTenant,
            azureCloudAccountTenantWithExoConfigs,
            azureNativeManagedDisk,
            azureNativeManagedDisks,
            azureNativeResourceGroup,
            azureNativeResourceGroups,
            azureNativeRoot,
            azureNativeSubscription,
            azureNativeSubscriptions,
            azureNativeVirtualMachine,
            azureNativeVirtualMachines,
            azureO365CheckNSGOutboundRules,
            azureO365CheckNetworkSubnet,
            azureO365CheckResourceGroupName,
            azureO365CheckStorageAccountAccessibility,
            azureO365CheckStorageAccountName,
            azureO365CheckSubscriptionQuota,
            azureO365CheckVirtualNetworkName,
            azureO365Exocompute,
            azureO365GetAzureHostType,
            azureO365GetNetworkSubnetUnusedAddr,
            azureO365ValidateUserRoles,
            azureOauthConsentComplete,
            azureOauthConsentKickoff,
            azureRegions,
            azureResourceGroups,
            azureSqlDatabase,
            azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
            azureSqlDatabaseServer,
            azureSqlDatabaseServers,
            azureSqlDatabases,
            azureSqlManagedInstanceDatabase,
            azureSqlManagedInstanceDatabases,
            azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
            azureSqlManagedInstanceServer,
            azureSqlManagedInstanceServers,
            azureStorageAccounts,
            azureSubnets,
            azureSubscriptions,
            azureVNets,
            backupAzureAdDirectory,
            backupO365Mailbox,
            backupO365Onedrive,
            backupO365SharePointSite,
            backupO365SharepointDrive,
            backupO365SharepointList,
            backupO365Team,
            batchExportHypervVm,
            batchExportNutanixVm,
            batchInstantRecoverHypervVm,
            batchMountHypervVm,
            batchMountNutanixVm,
            batchOnDemandBackupHypervVm,
            beginManagedVolumeSnapshot,
            browseMssqlDatabaseSnapshot,
            browseO365TeamConvChannels,
            bulkCreateOnDemandMssqlBackup,
            bulkDeleteAwsCloudAccountWithoutCft,
            bulkDeleteCassandraSources,
            bulkDeleteFailoverCluster,
            bulkDeleteMongodbSources,
            bulkOnDemandSnapshotNutanixVm,
            bulkUpdateMssqlDbs,
            bulkUpdateOracleDatabases,
            bulkUpdateOracleHosts,
            bulkUpdateOracleRacs,
            cancelActivitySeries,
            cassandraColumnFamilies,
            cassandraColumnFamily,
            cassandraColumnFamilyRecoverableRange,
            cassandraColumnFamilySchema,
            cassandraKeyspace,
            cassandraKeyspaces,
            cassandraSource,
            cassandraSources,
            cdmMssqlLogShippingTarget,
            cdmMssqlLogShippingTargets,
            checkAzurePersistentStorageSubscriptionCanUnmap,
            cluster,
            clusterCertificates,
            clusterConnection,
            clusterCsr,
            clusterDefaultGateway,
            clusterDns,
            clusterFloatingIps,
            clusterGroupByConnection,
            clusterIpmi,
            clusterIpv6Mode,
            clusterNetworkInterfaces,
            clusterNodes,
            clusterNtpServers,
            clusterOperationJobProgress,
            clusterProxy,
            clusterRegistrationProductInfo,
            clusterReportMigrationCount,
            clusterReportMigrationJobStatus,
            clusterReportMigrationStatus,
            clusterSlaDomains,
            clusterTypeList,
            clusterVlans,
            clusterWebSignedCertificate,
            clusterWithUpgradesInfo,
            completeAzureAdAppSetup,
            completeAzureAdAppUpdate,
            completeAzureCloudAccountOauth,
            countOfObjectsProtectedBySlas,
            createAutomaticAwsTargetMapping,
            createAutomaticAzureTargetMapping,
            createAwsAccount,
            createAwsCluster,
            createAwsComputeSetting,
            createAwsExocomputeConfigs,
            createAwsReaderTarget,
            createAwsTarget,
            createAzureAccount,
            createAzureCluster,
            createAzureReaderTarget,
            createAzureSaasAppAad,
            createAzureTarget,
            createCassandraSource,
            createCloudNativeAwsStorageSetting,
            createCloudNativeAzureStorageSetting,
            createCloudNativeRcvAzureStorageSetting,
            createFailoverCluster,
            createGlobalSla,
            createHypervVirtualMachineSnapshotMount,
            createK8sCluster,
            createMongodbSource,
            createMssqlLiveMount,
            createMssqlLogShippingConfiguration,
            createNutanixCluster,
            createNutanixPrismCentral,
            createO365AppComplete,
            createO365AppKickoff,
            createOnDemandDb2Backup,
            createOnDemandMssqlBackup,
            createOnDemandNutanixBackup,
            createOraclePdbRestore,
            createVsphereAdvancedTag,
            createVsphereVcenter,
            databaseLogReportForCluster,
            databaseLogReportingPropertiesForCluster,
            db2Database,
            db2Databases,
            db2Instance,
            db2Instances,
            db2LogSnapshot,
            db2LogSnapshots,
            db2RecoverableRange,
            db2RecoverableRanges,
            deleteAllOracleDatabaseSnapshots,
            deleteAwsCluster,
            deleteAwsComputeSetting,
            deleteAwsExocomputeConfigs,
            deleteAzureAdDirectory,
            deleteAzureCloudAccount,
            deleteAzureCloudAccountExocomputeConfigurations,
            deleteAzureCloudAccountWithoutOauth,
            deleteAzureCluster,
            deleteCassandraSource,
            deleteDb2Database,
            deleteDb2Instance,
            deleteFailoverCluster,
            deleteHypervVirtualMachineSnapshot,
            deleteHypervVirtualMachineSnapshotMount,
            deleteLdapPrincipals,
            deleteManagedVolume,
            deleteManagedVolumeSnapshotExport,
            deleteMongoSource,
            deleteMongodbSource,
            deleteMssqlDbSnapshots,
            deleteMssqlLiveMount,
            deleteNutanixCluster,
            deleteNutanixMountV1,
            deleteNutanixPrismCentral,
            deleteNutanixSnapshot,
            deleteNutanixSnapshots,
            deleteO365AzureApp,
            deleteO365Org,
            deleteO365ServiceAccount,
            deleteOracleMount,
            deleteVsphereAdvancedTag,
            deleteVsphereLiveMount,
            discoverDb2Instance,
            discoverMongoSource,
            doesAzureNativeResourceGroupExist,
            downloadDb2Snapshot,
            downloadDb2SnapshotsForPointInTimeRecovery,
            downloadFilesNutanixSnapshot,
            downloadHypervSnapshotFromLocation,
            downloadHypervVirtualMachineSnapshot,
            downloadHypervVirtualMachineSnapshotFiles,
            downloadManagedVolumeFiles,
            downloadManagedVolumeFromLocation,
            downloadMssqlDatabaseBackupFiles,
            downloadMssqlDatabaseFilesFromArchivalLocation,
            downloadNutanixSnapshot,
            downloadNutanixVmFromLocation,
            downloadOracleDatabaseSnapshot,
            downloadVsphereVirtualMachineFiles,
            enableO365SharePoint,
            enableO365Teams,
            endManagedVolumeSnapshot,
            excludeAwsNativeEbsVolumesFromSnapshot,
            excludeAzureNativeManagedDisksFromSnapshot,
            expireDownloadedDb2Snapshots,
            exportHypervVirtualMachine,
            exportManagedVolumeSnapshot,
            exportMssqlDatabase,
            exportNutanixSnapshot,
            exportO365Mailbox,
            exportOracleDatabase,
            exportOracleTablespace,
            exportSlaManagedVolumeSnapshot,
            finalizeAwsCloudAccountDeletion,
            finalizeAwsCloudAccountProtection,
            getPendingSlaAssignments,
            globalSlaFilterConnection,
            globalSlaStatuses,
            hostFailoverCluster,
            hypervCluster,
            hypervDeleteAllSnapshots,
            hypervHostAsyncRequestStatus,
            hypervMounts,
            hypervOnDemandSnapshot,
            hypervScvmm,
            hypervScvmmAsyncRequestStatus,
            hypervScvmmDelete,
            hypervScvmmUpdate,
            hypervScvmms,
            hypervServer,
            hypervServers,
            hypervTopLevelDescendants,
            hypervVirtualMachine,
            hypervVirtualMachineAsyncRequestStatus,
            hypervVirtualMachines,
            hypervVmDetail,
            insertCustomerO365App,
            instantRecoverHypervVirtualMachineSnapshot,
            instantRecoverOracleSnapshot,
            isAwsNativeEbsVolumeSnapshotRestorable,
            isAwsNativeRdsInstanceLaunchConfigurationValid,
            isAwsS3BucketNameAvailable,
            isAzureNativeManagedDiskSnapshotRestorable,
            isAzureNativeSqlDatabaseSnapshotPersistent,
            isAzureStorageAccountNameAvailable,
            isTotpAckNecessaryForCluster,
            k8sClusters,
            ldapAuthorizedPrincipalConnection,
            ldapIntegrationConnection,
            ldapPrincipalConnection,
            listO365Apps,
            managedVolume,
            managedVolumeInventoryStats,
            managedVolumeLiveMounts,
            managedVolumes,
            mapAzureCloudAccountExocomputeSubscription,
            mapAzureCloudAccountToPersistentStorageLocation,
            migrateNutanixMountV1,
            mongoBulkRecoverableRanges,
            mongoCollection,
            mongoCollections,
            mongoDatabase,
            mongoDatabases,
            mongoRecoverableRanges,
            mongoSource,
            mongoSources,
            mongodbBulkRecoverableRange,
            mongodbCollection,
            mongodbCollectionRecoverableRange,
            mongodbCollections,
            mongodbDatabase,
            mongodbDatabases,
            mongodbSource,
            mongodbSources,
            mountNutanixSnapshotV1,
            mountOracleDatabase,
            mssqlAvailabilityGroup,
            mssqlCompatibleInstances,
            mssqlDatabase,
            mssqlDatabaseLiveMounts,
            mssqlDatabaseMissedRecoverableRanges,
            mssqlDatabaseMissedSnapshots,
            mssqlDatabaseRestoreEstimate,
            mssqlDatabases,
            mssqlDefaultProperties,
            mssqlInstance,
            mssqlLogShippingTargets,
            mssqlRecoverableRanges,
            mssqlTopLevelDescendants,
            nutanixBrowseSnapshot,
            nutanixCategory,
            nutanixCategoryValue,
            nutanixCluster,
            nutanixClusterAsyncRequestStatus,
            nutanixClusterContainers,
            nutanixClusterNetworks,
            nutanixClusters,
            nutanixMounts,
            nutanixPrismCentral,
            nutanixPrismCentrals,
            nutanixSnapshotDetail,
            nutanixTopLevelDescendants,
            nutanixVm,
            nutanixVmAsyncRequestStatus,
            nutanixVmMissedSnapshots,
            nutanixVms,
            o365Calendar,
            o365Groups,
            o365License,
            o365Mailbox,
            o365Mailboxes,
            o365OauthConsentComplete,
            o365OauthConsentKickoff,
            o365ObjectAncestors,
            o365Onedrive,
            o365Onedrives,
            o365Org,
            o365OrgAtSnappableLevel,
            o365OrgSummaries,
            o365Orgs,
            o365PdlGroups,
            o365SaaSSetupKickoff,
            o365SaasSetupComplete,
            o365ServiceAccount,
            o365ServiceStatus,
            o365SetupKickoff,
            o365SharepointDrive,
            o365SharepointDrives,
            o365SharepointList,
            o365SharepointLists,
            o365SharepointObjectList,
            o365SharepointObjects,
            o365SharepointSite,
            o365SharepointSites,
            o365Site,
            o365Sites,
            o365StorageStats,
            o365Team,
            o365TeamChannels,
            o365TeamConversationsFolderID,
            o365TeamPostedBy,
            o365Teams,
            o365User,
            o365UserObjects,
            oracleAcoExampleDownloadLink,
            oracleAcoParameters,
            oracleDataGuardGroup,
            oracleDatabase,
            oracleDatabaseLogBackupConfig,
            oracleDatabases,
            oracleHost,
            oracleHostLogBackupConfig,
            oracleLiveMounts,
            oracleMissedRecoverableRanges,
            oracleMissedSnapshots,
            oraclePdbDetails,
            oracleRac,
            oracleRacLogBackupConfig,
            oracleRecoverableRanges,
            oracleTopLevelDescendants,
            patchAwsAuthenticationServerBasedCloudAccount,
            patchAwsIamUserBasedCloudAccount,
            patchDb2Database,
            patchDb2Instance,
            patchMongoSource,
            patchNutanixMountV1,
            pauseSla,
            prepareAwsCloudAccountDeletion,
            prepareFeatureUpdateForAwsCloudAccount,
            rdsInstanceDetailsFromAws,
            recoverCassandraSource,
            recoverCloudCluster,
            recoverMongoSource,
            recoverMongodbSource,
            refreshDb2Database,
            refreshHypervScvmm,
            refreshHypervServer,
            refreshK8sCluster,
            refreshNutanixCluster,
            refreshNutanixPrismCentral,
            refreshO365Org,
            refreshOracleDatabase,
            refreshVsphereVcenter,
            registerAgentHypervVirtualMachine,
            registerAgentNutanixVm,
            registerAwsFeatureArtifacts,
            registerCloudCluster,
            registerHypervScvmm,
            removeCdmCluster,
            removeLdapIntegration,
            resizeManagedVolume,
            restoreAzureAdObjectsWithPasswords,
            restoreFilesNutanixSnapshot,
            restoreHypervVirtualMachineSnapshotFiles,
            restoreMssqlDatabase,
            restoreO365Mailbox,
            restoreO365Snappable,
            restoreO365TeamsConversations,
            restoreO365TeamsFiles,
            restoreOracleLogs,
            retryAddMongoSource,
            searchAzureAdSnapshot,
            searchNutanixVm,
            setAzureCloudAccountCustomerAppCredentials,
            setLdapMfaSetting,
            setO365ServiceAccount,
            setupAzureO365Exocompute,
            slaAuditDetail,
            slaConflictObjects,
            slaDomain,
            slaDomains,
            slaManagedVolume,
            slaManagedVolumes,
            startAwsExocomputeDisableJob,
            startAwsNativeAccountDisableJob,
            startAwsNativeEc2InstanceSnapshotsJob,
            startAwsNativeRdsInstanceSnapshotsJob,
            startAzureAdAppSetup,
            startAzureAdAppUpdate,
            startAzureCloudAccountOauth,
            startCreateAwsNativeEbsVolumeSnapshotsJob,
            startCreateAzureNativeManagedDiskSnapshotsJob,
            startCreateAzureNativeVirtualMachineSnapshotsJob,
            startDisableAzureCloudAccountJob,
            startDisableAzureNativeSubscriptionProtectionJob,
            startExportAwsNativeEbsVolumeSnapshotJob,
            startExportAzureNativeManagedDiskJob,
            startExportAzureNativeVirtualMachineJob,
            startExportAzureSqlDatabaseDbJob,
            startExportAzureSqlManagedInstanceDbJob,
            startRefreshAwsNativeAccountsJob,
            startRefreshAzureNativeSubscriptionsJob,
            startRestoreAwsNativeEc2InstanceSnapshotJob,
            startRestoreAzureNativeVirtualMachineJob,
            takeManagedVolumeOnDemandSnapshot,
            takeMssqlLogBackup,
            takeOnDemandOracleDatabaseSnapshot,
            takeOnDemandOracleLogSnapshot,
            uniqueHypervServersCount,
            unmapAzureCloudAccountExocomputeSubscription,
            unmapAzurePersistentStorageSubscription,
            updateAutomaticAwsTargetMapping,
            updateAutomaticAzureTargetMapping,
            updateAwsAccount,
            updateAwsCloudAccount,
            updateAwsCloudAccountFeature,
            updateAwsComputeSetting,
            updateAwsExocomputeConfigs,
            updateAwsTarget,
            updateAzureAccount,
            updateAzureCloudAccount,
            updateAzureTarget,
            updateCassandraSource,
            updateCloudNativeAwsStorageSetting,
            updateCloudNativeAzureStorageSetting,
            updateCloudNativeRcvAzureStorageSetting,
            updateCustomerAppPermissionForAzureSql,
            updateDatabaseLogReportingPropertiesForCluster,
            updateFailoverCluster,
            updateGlobalSla,
            updateHypervVirtualMachine,
            updateHypervVirtualMachineSnapshotMount,
            updateLdapIntegration,
            updateManagedVolume,
            updateMongodbSource,
            updateMssqlDefaultProperties,
            updateMssqlLogShippingConfiguration,
            updateNutanixCluster,
            updateNutanixPrismCentral,
            updateNutanixVm,
            updateO365AppAuthStatus,
            updateO365AppPermissions,
            updateO365OrgCustomName,
            updateOracleDataGuardGroup,
            updateVcenter,
            updateVcenterHotAddBandwidth,
            updateVcenterHotAddNetwork,
            updateVsphereAdvancedTag,
            updateVsphereVm,
            upgradeAwsCloudAccountFeaturesWithoutCft,
            upgradeAwsIamUserBasedCloudAccountPermissions,
            upgradeAzureCloudAccount,
            upgradeAzureCloudAccountPermissionsWithoutOauth,
            vCenterAdvancedTagPreview,
            vCenterHotAddBandwidth,
            vCenterHotAddNetwork,
            vCenterNetworks,
            vCenterNumProxiesNeeded,
            vCenterPreAddInfo,
            vSphereComputeCluster,
            vSphereComputeClusters,
            vSphereDatacenter,
            vSphereDatastore,
            vSphereDatastoreCluster,
            vSphereDatastoreClusters,
            vSphereDatastoreConnection,
            vSphereFolder,
            vSphereFolders,
            vSphereHost,
            vSphereHostConnection,
            vSphereHostDetails,
            vSphereHostsByFids,
            vSphereLiveMounts,
            vSphereMount,
            vSphereMountConnection,
            vSphereNetwork,
            vSphereResourcePool,
            vSphereRootRecoveryHierarchy,
            vSphereTag,
            vSphereTagCategory,
            vSphereTopLevelDescendantsConnection,
            vSphereVCenter,
            vSphereVCenterConnection,
            vSphereVMAsyncRequestStatus,
            vSphereVmNew,
            vSphereVmNewConnection,
            validateAndCreateAwsCloudAccount,
            validateAwsNativeRdsClusterNameForExport,
            validateAwsNativeRdsInstanceNameForExport,
            validateAzureCloudAccountExocomputeConfigurations,
            validateAzureNativeSqlDatabaseDbNameForExport,
            validateAzureNativeSqlManagedInstanceDbNameForExport,
            validateOracleAcoFile,
            validateOracleDatabaseBackups,
            verifySlaWithReplicationToCluster,
            vsphereBulkOnDemandSnapshot,
            vsphereDeleteVcenter,
            vsphereExcludeVmDisks,
            vsphereExportSnapshotToStandaloneHostV2,
            vsphereOnDemandSnapshot,
            vsphereVMMissedRecoverableRange,
            vsphereVMRecoverableRange,
            vsphereVMRecoverableRangeInBatch,
            vsphereVmBatchExport,
            vsphereVmBatchExportV3,
            vsphereVmBatchInPlaceRecovery,
            vsphereVmDeleteSnapshot,
            vsphereVmDownloadSnapshot,
            vsphereVmDownloadSnapshotFiles,
            vsphereVmExportSnapshotV2,
            vsphereVmExportSnapshotV3,
            vsphereVmExportSnapshotWithDownloadFromCloud,
            vsphereVmInitiateBatchInstantRecovery,
            vsphereVmInitiateBatchLiveMountV2,
            vsphereVmInitiateDiskMount,
            vsphereVmInitiateInPlaceRecovery,
            vsphereVmInitiateInstantRecoveryV2,
            vsphereVmInitiateLiveMountV2,
            vsphereVmListEsxiDatastores,
            vsphereVmMountRelocate,
            vsphereVmMountRelocateV2,
            vsphereVmPowerOnOffLiveMount,
            vsphereVmRecoverFiles,
            vsphereVmRecoverFilesNew,
            vsphereVmRegisterAgent,
            vsphereVmwareCdpLiveInfo,
            windowsCluster,
        }

        /// <summary>
        /// Given a GraphQL root field name, return the corresponding RSC operation.
        /// </summary>
        public static RscOp RscOpLookupByGqlRootField(
            GqlRootFieldName rootField)
        {
            var lookupDict = new Dictionary<GqlRootFieldName, RscOp> {
                {
                    GqlRootFieldName.accountId,
                    new RscOp(
                        cmdletName: "New-RscQueryAccount",
                        cmdletSwitchName: "Id",
                        gqlRootFieldName: "accountId"
                    )
                },
                {
                    GqlRootFieldName.accountSettings,
                    new RscOp(
                        cmdletName: "New-RscQueryAccount",
                        cmdletSwitchName: "Settings",
                        gqlRootFieldName: "accountSettings"
                    )
                },
                {
                    GqlRootFieldName.activitySeries,
                    new RscOp(
                        cmdletName: "New-RscQueryActivitySeries",
                        cmdletSwitchName: "ActivitySeries",
                        gqlRootFieldName: "activitySeries"
                    )
                },
                {
                    GqlRootFieldName.activitySeriesConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryActivitySeries",
                        cmdletSwitchName: "List",
                        gqlRootFieldName: "activitySeriesConnection"
                    )
                },
                {
                    GqlRootFieldName.addAwsAuthenticationServerBasedCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "AddAuthenticationServerBasedCloudAccount",
                        gqlRootFieldName: "addAwsAuthenticationServerBasedCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.addAwsIamUserBasedCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "AddIamUserBasedCloudAccount",
                        gqlRootFieldName: "addAwsIamUserBasedCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.addAzureCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "AddCloudAccount",
                        gqlRootFieldName: "addAzureCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.addAzureCloudAccountExocomputeConfigurations,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "AddCloudAccountExocomputeConfigurations",
                        gqlRootFieldName: "addAzureCloudAccountExocomputeConfigurations"
                    )
                },
                {
                    GqlRootFieldName.addAzureCloudAccountWithoutOauth,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "AddCloudAccountWithoutOauth",
                        gqlRootFieldName: "addAzureCloudAccountWithoutOauth"
                    )
                },
                {
                    GqlRootFieldName.addDb2Instance,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "AddInstance",
                        gqlRootFieldName: "addDb2Instance"
                    )
                },
                {
                    GqlRootFieldName.addManagedVolume,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "Add",
                        gqlRootFieldName: "addManagedVolume"
                    )
                },
                {
                    GqlRootFieldName.addMongoSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "AddSource",
                        gqlRootFieldName: "addMongoSource"
                    )
                },
                {
                    GqlRootFieldName.addNodesToCloudCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "AddNodesToCloud",
                        gqlRootFieldName: "addNodesToCloudCluster"
                    )
                },
                {
                    GqlRootFieldName.addO365Org,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "AddOrg",
                        gqlRootFieldName: "addO365Org"
                    )
                },
                {
                    GqlRootFieldName.allAccountOwners,
                    new RscOp(
                        cmdletName: "New-RscQueryAccount",
                        cmdletSwitchName: "Owners",
                        gqlRootFieldName: "allAccountOwners"
                    )
                },
                {
                    GqlRootFieldName.allAccountProducts,
                    new RscOp(
                        cmdletName: "New-RscQueryAccount",
                        cmdletSwitchName: "Products",
                        gqlRootFieldName: "allAccountProducts"
                    )
                },
                {
                    GqlRootFieldName.allAccountsWithExocomputeMappings,
                    new RscOp(
                        cmdletName: "New-RscQueryAccount",
                        cmdletSwitchName: "WithExocomputeMappings",
                        gqlRootFieldName: "allAccountsWithExocomputeMappings"
                    )
                },
                {
                    GqlRootFieldName.allAvailabilityZonesByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllAvailabilityZonesByRegion",
                        gqlRootFieldName: "allAvailabilityZonesByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allAwsCdmVersions,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllCdmVersions",
                        gqlRootFieldName: "allAwsCdmVersions"
                    )
                },
                {
                    GqlRootFieldName.allAwsCloudAccountConfigs,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllCloudAccountConfigs",
                        gqlRootFieldName: "allAwsCloudAccountConfigs"
                    )
                },
                {
                    GqlRootFieldName.allAwsCloudAccountsWithFeatures,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllCloudAccountsWithFeatures",
                        gqlRootFieldName: "allAwsCloudAccountsWithFeatures"
                    )
                },
                {
                    GqlRootFieldName.allAwsComputeSettings,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllComputeSettings",
                        gqlRootFieldName: "allAwsComputeSettings"
                    )
                },
                {
                    GqlRootFieldName.allAwsExocomputeConfigs,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllExocomputeConfigs",
                        gqlRootFieldName: "allAwsExocomputeConfigs"
                    )
                },
                {
                    GqlRootFieldName.allAwsInstanceProfileNames,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllInstanceProfileNames",
                        gqlRootFieldName: "allAwsInstanceProfileNames"
                    )
                },
                {
                    GqlRootFieldName.allAwsPermissionPolicies,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllPermissionPolicies",
                        gqlRootFieldName: "allAwsPermissionPolicies"
                    )
                },
                {
                    GqlRootFieldName.allAwsRegions,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllRegions",
                        gqlRootFieldName: "allAwsRegions"
                    )
                },
                {
                    GqlRootFieldName.allAzureArmTemplatesByFeature,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllArmTemplatesByFeature",
                        gqlRootFieldName: "allAzureArmTemplatesByFeature"
                    )
                },
                {
                    GqlRootFieldName.allAzureCdmVersions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllCdmVersions",
                        gqlRootFieldName: "allAzureCdmVersions"
                    )
                },
                {
                    GqlRootFieldName.allAzureCloudAccountMissingPermissions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllCloudAccountMissingPermissions",
                        gqlRootFieldName: "allAzureCloudAccountMissingPermissions"
                    )
                },
                {
                    GqlRootFieldName.allAzureCloudAccountSubnetsByRegion,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllCloudAccountSubnetsByRegion",
                        gqlRootFieldName: "allAzureCloudAccountSubnetsByRegion"
                    )
                },
                {
                    GqlRootFieldName.allAzureCloudAccountSubscriptionsByFeature,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllCloudAccountSubscriptionsByFeature",
                        gqlRootFieldName: "allAzureCloudAccountSubscriptionsByFeature"
                    )
                },
                {
                    GqlRootFieldName.allAzureCloudAccountTenants,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllCloudAccountTenants",
                        gqlRootFieldName: "allAzureCloudAccountTenants"
                    )
                },
                {
                    GqlRootFieldName.allAzureDiskEncryptionSetsByRegion,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllDiskEncryptionSetsByRegion",
                        gqlRootFieldName: "allAzureDiskEncryptionSetsByRegion"
                    )
                },
                {
                    GqlRootFieldName.allAzureEncryptionKeys,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllEncryptionKeys",
                        gqlRootFieldName: "allAzureEncryptionKeys"
                    )
                },
                {
                    GqlRootFieldName.allAzureExocomputeConfigsInAccount,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllExocomputeConfigsInAccount",
                        gqlRootFieldName: "allAzureExocomputeConfigsInAccount"
                    )
                },
                {
                    GqlRootFieldName.allAzureKeyVaultsByRegion,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllKeyVaultsByRegion",
                        gqlRootFieldName: "allAzureKeyVaultsByRegion"
                    )
                },
                {
                    GqlRootFieldName.allAzureManagedIdentities,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllManagedIdentities",
                        gqlRootFieldName: "allAzureManagedIdentities"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeAvailabilitySetsByRegionFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeAvailabilitySetsByRegionFromAzure",
                        gqlRootFieldName: "allAzureNativeAvailabilitySetsByRegionFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeExportCompatibleDiskTypesByRegionFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeExportCompatibleDiskTypesByRegionFromAzure",
                        gqlRootFieldName: "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeExportCompatibleVmSizesByRegionFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeExportCompatibleVmSizesByRegionFromAzure",
                        gqlRootFieldName: "allAzureNativeExportCompatibleVmSizesByRegionFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeResourceGroupsInfoIfExist,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeResourceGroupsInfoIfExist",
                        gqlRootFieldName: "allAzureNativeResourceGroupsInfoIfExist"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeSecurityGroupsByRegionFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeSecurityGroupsByRegionFromAzure",
                        gqlRootFieldName: "allAzureNativeSecurityGroupsByRegionFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeStorageAccountsFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeStorageAccountsFromAzure",
                        gqlRootFieldName: "allAzureNativeStorageAccountsFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeSubnetsByRegionFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeSubnetsByRegionFromAzure",
                        gqlRootFieldName: "allAzureNativeSubnetsByRegionFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeVirtualMachineSizes,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeVirtualMachineSizes",
                        gqlRootFieldName: "allAzureNativeVirtualMachineSizes"
                    )
                },
                {
                    GqlRootFieldName.allAzureNativeVirtualNetworks,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNativeVirtualNetworks",
                        gqlRootFieldName: "allAzureNativeVirtualNetworks"
                    )
                },
                {
                    GqlRootFieldName.allAzureNsgs,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllNsgs",
                        gqlRootFieldName: "allAzureNsgs"
                    )
                },
                {
                    GqlRootFieldName.allAzureRegions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllRegions",
                        gqlRootFieldName: "allAzureRegions"
                    )
                },
                {
                    GqlRootFieldName.allAzureResourceGroups,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllResourceGroups",
                        gqlRootFieldName: "allAzureResourceGroups"
                    )
                },
                {
                    GqlRootFieldName.allAzureSqlDatabaseServerElasticPools,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllSqlDatabaseServerElasticPools",
                        gqlRootFieldName: "allAzureSqlDatabaseServerElasticPools"
                    )
                },
                {
                    GqlRootFieldName.allAzureStorageAccounts,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllStorageAccounts",
                        gqlRootFieldName: "allAzureStorageAccounts"
                    )
                },
                {
                    GqlRootFieldName.allAzureSubnets,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllSubnets",
                        gqlRootFieldName: "allAzureSubnets"
                    )
                },
                {
                    GqlRootFieldName.allAzureSubscriptionWithExocomputeMappings,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllSubscriptionWithExocomputeMappings",
                        gqlRootFieldName: "allAzureSubscriptionWithExocomputeMappings"
                    )
                },
                {
                    GqlRootFieldName.allAzureVnets,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllVnets",
                        gqlRootFieldName: "allAzureVnets"
                    )
                },
                {
                    GqlRootFieldName.allClusterGlobalSlas,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "GlobalSlas",
                        gqlRootFieldName: "allClusterGlobalSlas"
                    )
                },
                {
                    GqlRootFieldName.allClusterReplicationTargets,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "ReplicationTargets",
                        gqlRootFieldName: "allClusterReplicationTargets"
                    )
                },
                {
                    GqlRootFieldName.allClusterWebCertsAndIpmis,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "WebCertsAndIpmis",
                        gqlRootFieldName: "allClusterWebCertsAndIpmis"
                    )
                },
                {
                    GqlRootFieldName.allClustersTotpAckStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "TotpAckStatus",
                        gqlRootFieldName: "allClustersTotpAckStatus"
                    )
                },
                {
                    GqlRootFieldName.allConnectedClusters,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Connected",
                        gqlRootFieldName: "allConnectedClusters"
                    )
                },
                {
                    GqlRootFieldName.allDbParameterGroupsByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllDbParameterGroupsByRegion",
                        gqlRootFieldName: "allDbParameterGroupsByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allDbSubnetGroupsByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllDbSubnetGroupsByRegion",
                        gqlRootFieldName: "allDbSubnetGroupsByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allEc2KeyPairsByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllEc2KeyPairsByRegion",
                        gqlRootFieldName: "allEc2KeyPairsByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allHostedAzureRegions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllHostedRegions",
                        gqlRootFieldName: "allHostedAzureRegions"
                    )
                },
                {
                    GqlRootFieldName.allKmsEncryptionKeysByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllKmsEncryptionKeysByRegion",
                        gqlRootFieldName: "allKmsEncryptionKeysByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allMssqlDatabaseRestoreFiles,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "AllDatabaseRestoreFiles",
                        gqlRootFieldName: "allMssqlDatabaseRestoreFiles"
                    )
                },
                {
                    GqlRootFieldName.allNcdSlaComplianceData,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "AllNcdComplianceData",
                        gqlRootFieldName: "allNcdSlaComplianceData"
                    )
                },
                {
                    GqlRootFieldName.allO365AdGroups,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "AllAdGroups",
                        gqlRootFieldName: "allO365AdGroups"
                    )
                },
                {
                    GqlRootFieldName.allO365OrgStatuses,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "AllOrgStatuses",
                        gqlRootFieldName: "allO365OrgStatuses"
                    )
                },
                {
                    GqlRootFieldName.allO365SubscriptionsAppTypeCounts,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "AllSubscriptionsAppTypeCounts",
                        gqlRootFieldName: "allO365SubscriptionsAppTypeCounts"
                    )
                },
                {
                    GqlRootFieldName.allOptionGroupsByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllOptionGroupsByRegion",
                        gqlRootFieldName: "allOptionGroupsByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allResourceGroupsFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AllResourceGroupsFrom",
                        gqlRootFieldName: "allResourceGroupsFromAzure"
                    )
                },
                {
                    GqlRootFieldName.allS3BucketsDetailsFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllS3BucketsDetails",
                        gqlRootFieldName: "allS3BucketsDetailsFromAws"
                    )
                },
                {
                    GqlRootFieldName.allS3BucketsFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllS3Buckets",
                        gqlRootFieldName: "allS3BucketsFromAws"
                    )
                },
                {
                    GqlRootFieldName.allSlaSummariesByIds,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "AllSummariesByIds",
                        gqlRootFieldName: "allSlaSummariesByIds"
                    )
                },
                {
                    GqlRootFieldName.allSupportedAwsRdsDatabaseInstanceClasses,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllSupportedRdsDatabaseInstanceClasses",
                        gqlRootFieldName: "allSupportedAwsRdsDatabaseInstanceClasses"
                    )
                },
                {
                    GqlRootFieldName.allVcenterHotAddProxyVms,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "HotAddProxy",
                        gqlRootFieldName: "allVcenterHotAddProxyVms"
                    )
                },
                {
                    GqlRootFieldName.allVpcsByRegionFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllVpcsByRegion",
                        gqlRootFieldName: "allVpcsByRegionFromAws"
                    )
                },
                {
                    GqlRootFieldName.allVpcsFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AllVpcs",
                        gqlRootFieldName: "allVpcsFromAws"
                    )
                },
                {
                    GqlRootFieldName.amiTypeForAwsNativeArchivedSnapshotExport,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "AmiTypeForNativeArchivedSnapshotExport",
                        gqlRootFieldName: "amiTypeForAwsNativeArchivedSnapshotExport"
                    )
                },
                {
                    GqlRootFieldName.archiveK8sCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "ArchiveK8s",
                        gqlRootFieldName: "archiveK8sCluster"
                    )
                },
                {
                    GqlRootFieldName.assignMssqlSlaDomainProperties,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "AssignSlaDomainProperties",
                        gqlRootFieldName: "assignMssqlSlaDomainProperties"
                    )
                },
                {
                    GqlRootFieldName.assignMssqlSlaDomainPropertiesAsync,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "AssignSlaDomainPropertiesAsync",
                        gqlRootFieldName: "assignMssqlSlaDomainPropertiesAsync"
                    )
                },
                {
                    GqlRootFieldName.assignRetentionSLAToSnappables,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "AssignRetentionToSnappables",
                        gqlRootFieldName: "assignRetentionSLAToSnappables"
                    )
                },
                {
                    GqlRootFieldName.assignRetentionSLAToSnapshots,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "AssignRetentionToSnapshots",
                        gqlRootFieldName: "assignRetentionSLAToSnapshots"
                    )
                },
                {
                    GqlRootFieldName.assignSla,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "Assign",
                        gqlRootFieldName: "assignSla"
                    )
                },
                {
                    GqlRootFieldName.assignSlaToMongoDbCollection,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "AssignSlaToDbCollection",
                        gqlRootFieldName: "assignSlaToMongoDbCollection"
                    )
                },
                {
                    GqlRootFieldName.assignSlasForSnappableHierarchies,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "AssignsForSnappableHierarchies",
                        gqlRootFieldName: "assignSlasForSnappableHierarchies"
                    )
                },
                {
                    GqlRootFieldName.awsArtifactsToDelete,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "ArtifactsToDelete",
                        gqlRootFieldName: "awsArtifactsToDelete"
                    )
                },
                {
                    GqlRootFieldName.awsCloudAccountListSecurityGroups,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "CloudAccountListSecurityGroups",
                        gqlRootFieldName: "awsCloudAccountListSecurityGroups"
                    )
                },
                {
                    GqlRootFieldName.awsCloudAccountListSubnets,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "CloudAccountListSubnets",
                        gqlRootFieldName: "awsCloudAccountListSubnets"
                    )
                },
                {
                    GqlRootFieldName.awsCloudAccountListVpcs,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "CloudAccountListVpcs",
                        gqlRootFieldName: "awsCloudAccountListVpcs"
                    )
                },
                {
                    GqlRootFieldName.awsCloudAccountWithFeatures,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "CloudAccountWithFeatures",
                        gqlRootFieldName: "awsCloudAccountWithFeatures"
                    )
                },
                {
                    GqlRootFieldName.awsComputeSettings,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "ComputeSettings",
                        gqlRootFieldName: "awsComputeSettings"
                    )
                },
                {
                    GqlRootFieldName.awsNativeAccount,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeAccount",
                        gqlRootFieldName: "awsNativeAccount"
                    )
                },
                {
                    GqlRootFieldName.awsNativeAccounts,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeAccounts",
                        gqlRootFieldName: "awsNativeAccounts"
                    )
                },
                {
                    GqlRootFieldName.awsNativeEbsVolume,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeEbsVolume",
                        gqlRootFieldName: "awsNativeEbsVolume"
                    )
                },
                {
                    GqlRootFieldName.awsNativeEbsVolumes,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeEbsVolumes",
                        gqlRootFieldName: "awsNativeEbsVolumes"
                    )
                },
                {
                    GqlRootFieldName.awsNativeEbsVolumesByName,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeEbsVolumesByName",
                        gqlRootFieldName: "awsNativeEbsVolumesByName"
                    )
                },
                {
                    GqlRootFieldName.awsNativeEc2Instance,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeEc2Instance",
                        gqlRootFieldName: "awsNativeEc2Instance"
                    )
                },
                {
                    GqlRootFieldName.awsNativeEc2Instances,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeEc2Instances",
                        gqlRootFieldName: "awsNativeEc2Instances"
                    )
                },
                {
                    GqlRootFieldName.awsNativeEc2InstancesByName,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeEc2InstancesByName",
                        gqlRootFieldName: "awsNativeEc2InstancesByName"
                    )
                },
                {
                    GqlRootFieldName.awsNativeRdsExportDefaults,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeRdsExportDefaults",
                        gqlRootFieldName: "awsNativeRdsExportDefaults"
                    )
                },
                {
                    GqlRootFieldName.awsNativeRdsInstance,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeRdsInstance",
                        gqlRootFieldName: "awsNativeRdsInstance"
                    )
                },
                {
                    GqlRootFieldName.awsNativeRdsInstances,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeRdsInstances",
                        gqlRootFieldName: "awsNativeRdsInstances"
                    )
                },
                {
                    GqlRootFieldName.awsNativeRdsPointInTimeRestoreWindow,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeRdsPointInTimeRestoreWindow",
                        gqlRootFieldName: "awsNativeRdsPointInTimeRestoreWindow"
                    )
                },
                {
                    GqlRootFieldName.awsNativeRoot,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeRoot",
                        gqlRootFieldName: "awsNativeRoot"
                    )
                },
                {
                    GqlRootFieldName.awsNativeS3Bucket,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "NativeS3Bucket",
                        gqlRootFieldName: "awsNativeS3Bucket"
                    )
                },
                {
                    GqlRootFieldName.awsTrustPolicy,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "TrustPolicy",
                        gqlRootFieldName: "awsTrustPolicy"
                    )
                },
                {
                    GqlRootFieldName.azureAdDirectories,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AdDirectories",
                        gqlRootFieldName: "azureAdDirectories"
                    )
                },
                {
                    GqlRootFieldName.azureAdDirectory,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AdDirectory",
                        gqlRootFieldName: "azureAdDirectory"
                    )
                },
                {
                    GqlRootFieldName.azureAdObjectsByType,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "AdObjectsByType",
                        gqlRootFieldName: "azureAdObjectsByType"
                    )
                },
                {
                    GqlRootFieldName.azureCloudAccountPermissionConfig,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "CloudAccountPermissionConfig",
                        gqlRootFieldName: "azureCloudAccountPermissionConfig"
                    )
                },
                {
                    GqlRootFieldName.azureCloudAccountSubscriptionWithFeatures,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "CloudAccountSubscriptionWithFeatures",
                        gqlRootFieldName: "azureCloudAccountSubscriptionWithFeatures"
                    )
                },
                {
                    GqlRootFieldName.azureCloudAccountTenant,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "CloudAccountTenant",
                        gqlRootFieldName: "azureCloudAccountTenant"
                    )
                },
                {
                    GqlRootFieldName.azureCloudAccountTenantWithExoConfigs,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "CloudAccountTenantWithExoConfigs",
                        gqlRootFieldName: "azureCloudAccountTenantWithExoConfigs"
                    )
                },
                {
                    GqlRootFieldName.azureNativeManagedDisk,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeManagedDisk",
                        gqlRootFieldName: "azureNativeManagedDisk"
                    )
                },
                {
                    GqlRootFieldName.azureNativeManagedDisks,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeManagedDisks",
                        gqlRootFieldName: "azureNativeManagedDisks"
                    )
                },
                {
                    GqlRootFieldName.azureNativeResourceGroup,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeResourceGroup",
                        gqlRootFieldName: "azureNativeResourceGroup"
                    )
                },
                {
                    GqlRootFieldName.azureNativeResourceGroups,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeResourceGroups",
                        gqlRootFieldName: "azureNativeResourceGroups"
                    )
                },
                {
                    GqlRootFieldName.azureNativeRoot,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeRoot",
                        gqlRootFieldName: "azureNativeRoot"
                    )
                },
                {
                    GqlRootFieldName.azureNativeSubscription,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeSubscription",
                        gqlRootFieldName: "azureNativeSubscription"
                    )
                },
                {
                    GqlRootFieldName.azureNativeSubscriptions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeSubscriptions",
                        gqlRootFieldName: "azureNativeSubscriptions"
                    )
                },
                {
                    GqlRootFieldName.azureNativeVirtualMachine,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeVirtualMachine",
                        gqlRootFieldName: "azureNativeVirtualMachine"
                    )
                },
                {
                    GqlRootFieldName.azureNativeVirtualMachines,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "NativeVirtualMachines",
                        gqlRootFieldName: "azureNativeVirtualMachines"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckNSGOutboundRules,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckNSGOutboundRules",
                        gqlRootFieldName: "azureO365CheckNSGOutboundRules"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckNetworkSubnet,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckNetworkSubnet",
                        gqlRootFieldName: "azureO365CheckNetworkSubnet"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckResourceGroupName,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckResourceGroupName",
                        gqlRootFieldName: "azureO365CheckResourceGroupName"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckStorageAccountAccessibility,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckStorageAccountAccessibility",
                        gqlRootFieldName: "azureO365CheckStorageAccountAccessibility"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckStorageAccountName,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckStorageAccountName",
                        gqlRootFieldName: "azureO365CheckStorageAccountName"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckSubscriptionQuota,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckSubscriptionQuota",
                        gqlRootFieldName: "azureO365CheckSubscriptionQuota"
                    )
                },
                {
                    GqlRootFieldName.azureO365CheckVirtualNetworkName,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "CheckVirtualNetworkName",
                        gqlRootFieldName: "azureO365CheckVirtualNetworkName"
                    )
                },
                {
                    GqlRootFieldName.azureO365Exocompute,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "Exocompute",
                        gqlRootFieldName: "azureO365Exocompute"
                    )
                },
                {
                    GqlRootFieldName.azureO365GetAzureHostType,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "GetAzureHostType",
                        gqlRootFieldName: "azureO365GetAzureHostType"
                    )
                },
                {
                    GqlRootFieldName.azureO365GetNetworkSubnetUnusedAddr,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "GetNetworkSubnetUnusedAddr",
                        gqlRootFieldName: "azureO365GetNetworkSubnetUnusedAddr"
                    )
                },
                {
                    GqlRootFieldName.azureO365ValidateUserRoles,
                    new RscOp(
                        cmdletName: "New-RscQueryAzureO365",
                        cmdletSwitchName: "ValidateUserRoles",
                        gqlRootFieldName: "azureO365ValidateUserRoles"
                    )
                },
                {
                    GqlRootFieldName.azureOauthConsentComplete,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "OauthConsentComplete",
                        gqlRootFieldName: "azureOauthConsentComplete"
                    )
                },
                {
                    GqlRootFieldName.azureOauthConsentKickoff,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "OauthConsentKickoff",
                        gqlRootFieldName: "azureOauthConsentKickoff"
                    )
                },
                {
                    GqlRootFieldName.azureRegions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "Regions",
                        gqlRootFieldName: "azureRegions"
                    )
                },
                {
                    GqlRootFieldName.azureResourceGroups,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "ResourceGroups",
                        gqlRootFieldName: "azureResourceGroups"
                    )
                },
                {
                    GqlRootFieldName.azureSqlDatabase,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlDatabase",
                        gqlRootFieldName: "azureSqlDatabase"
                    )
                },
                {
                    GqlRootFieldName.azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                        gqlRootFieldName: "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure"
                    )
                },
                {
                    GqlRootFieldName.azureSqlDatabaseServer,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlDatabaseServer",
                        gqlRootFieldName: "azureSqlDatabaseServer"
                    )
                },
                {
                    GqlRootFieldName.azureSqlDatabaseServers,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlDatabaseServers",
                        gqlRootFieldName: "azureSqlDatabaseServers"
                    )
                },
                {
                    GqlRootFieldName.azureSqlDatabases,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlDatabases",
                        gqlRootFieldName: "azureSqlDatabases"
                    )
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceDatabase,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlManagedInstanceDatabase",
                        gqlRootFieldName: "azureSqlManagedInstanceDatabase"
                    )
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceDatabases,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlManagedInstanceDatabases",
                        gqlRootFieldName: "azureSqlManagedInstanceDatabases"
                    )
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                        gqlRootFieldName: "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure"
                    )
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceServer,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlManagedInstanceServer",
                        gqlRootFieldName: "azureSqlManagedInstanceServer"
                    )
                },
                {
                    GqlRootFieldName.azureSqlManagedInstanceServers,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SqlManagedInstanceServers",
                        gqlRootFieldName: "azureSqlManagedInstanceServers"
                    )
                },
                {
                    GqlRootFieldName.azureStorageAccounts,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "StorageAccounts",
                        gqlRootFieldName: "azureStorageAccounts"
                    )
                },
                {
                    GqlRootFieldName.azureSubnets,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "Subnets",
                        gqlRootFieldName: "azureSubnets"
                    )
                },
                {
                    GqlRootFieldName.azureSubscriptions,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "Subscriptions",
                        gqlRootFieldName: "azureSubscriptions"
                    )
                },
                {
                    GqlRootFieldName.azureVNets,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "VNets",
                        gqlRootFieldName: "azureVNets"
                    )
                },
                {
                    GqlRootFieldName.backupAzureAdDirectory,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "BackupAdDirectory",
                        gqlRootFieldName: "backupAzureAdDirectory"
                    )
                },
                {
                    GqlRootFieldName.backupO365Mailbox,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "BackupMailbox",
                        gqlRootFieldName: "backupO365Mailbox"
                    )
                },
                {
                    GqlRootFieldName.backupO365Onedrive,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "BackupOnedrive",
                        gqlRootFieldName: "backupO365Onedrive"
                    )
                },
                {
                    GqlRootFieldName.backupO365SharePointSite,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "BackupSharePointSite",
                        gqlRootFieldName: "backupO365SharePointSite"
                    )
                },
                {
                    GqlRootFieldName.backupO365SharepointDrive,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "BackupSharepointDrive",
                        gqlRootFieldName: "backupO365SharepointDrive"
                    )
                },
                {
                    GqlRootFieldName.backupO365SharepointList,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "BackupSharepointList",
                        gqlRootFieldName: "backupO365SharepointList"
                    )
                },
                {
                    GqlRootFieldName.backupO365Team,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "BackupTeam",
                        gqlRootFieldName: "backupO365Team"
                    )
                },
                {
                    GqlRootFieldName.batchExportHypervVm,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "BatchExportVm",
                        gqlRootFieldName: "batchExportHypervVm"
                    )
                },
                {
                    GqlRootFieldName.batchExportNutanixVm,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "BatchExportVm",
                        gqlRootFieldName: "batchExportNutanixVm"
                    )
                },
                {
                    GqlRootFieldName.batchInstantRecoverHypervVm,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "BatchInstantRecoverVm",
                        gqlRootFieldName: "batchInstantRecoverHypervVm"
                    )
                },
                {
                    GqlRootFieldName.batchMountHypervVm,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "BatchMountVm",
                        gqlRootFieldName: "batchMountHypervVm"
                    )
                },
                {
                    GqlRootFieldName.batchMountNutanixVm,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "BatchMountVm",
                        gqlRootFieldName: "batchMountNutanixVm"
                    )
                },
                {
                    GqlRootFieldName.batchOnDemandBackupHypervVm,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "BatchOnDemandBackupVm",
                        gqlRootFieldName: "batchOnDemandBackupHypervVm"
                    )
                },
                {
                    GqlRootFieldName.beginManagedVolumeSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "BeginSnapshot",
                        gqlRootFieldName: "beginManagedVolumeSnapshot"
                    )
                },
                {
                    GqlRootFieldName.browseMssqlDatabaseSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "BrowseDatabaseSnapshot",
                        gqlRootFieldName: "browseMssqlDatabaseSnapshot"
                    )
                },
                {
                    GqlRootFieldName.browseO365TeamConvChannels,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "BrowseTeamConvChannels",
                        gqlRootFieldName: "browseO365TeamConvChannels"
                    )
                },
                {
                    GqlRootFieldName.bulkCreateOnDemandMssqlBackup,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "BulkCreateOnDemandBackup",
                        gqlRootFieldName: "bulkCreateOnDemandMssqlBackup"
                    )
                },
                {
                    GqlRootFieldName.bulkDeleteAwsCloudAccountWithoutCft,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "BulkDeleteCloudAccountWithoutCft",
                        gqlRootFieldName: "bulkDeleteAwsCloudAccountWithoutCft"
                    )
                },
                {
                    GqlRootFieldName.bulkDeleteCassandraSources,
                    new RscOp(
                        cmdletName: "New-RscMutationCassandra",
                        cmdletSwitchName: "BulkDeleteSources",
                        gqlRootFieldName: "bulkDeleteCassandraSources"
                    )
                },
                {
                    GqlRootFieldName.bulkDeleteFailoverCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "BulkDeleteFailover",
                        gqlRootFieldName: "bulkDeleteFailoverCluster"
                    )
                },
                {
                    GqlRootFieldName.bulkDeleteMongodbSources,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "BulkDeletedbSources",
                        gqlRootFieldName: "bulkDeleteMongodbSources"
                    )
                },
                {
                    GqlRootFieldName.bulkOnDemandSnapshotNutanixVm,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "BulkOnDemandSnapshotVm",
                        gqlRootFieldName: "bulkOnDemandSnapshotNutanixVm"
                    )
                },
                {
                    GqlRootFieldName.bulkUpdateMssqlDbs,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "BulkUpdateDbs",
                        gqlRootFieldName: "bulkUpdateMssqlDbs"
                    )
                },
                {
                    GqlRootFieldName.bulkUpdateOracleDatabases,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "BulkUpdateDatabases",
                        gqlRootFieldName: "bulkUpdateOracleDatabases"
                    )
                },
                {
                    GqlRootFieldName.bulkUpdateOracleHosts,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "BulkUpdateHosts",
                        gqlRootFieldName: "bulkUpdateOracleHosts"
                    )
                },
                {
                    GqlRootFieldName.bulkUpdateOracleRacs,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "BulkUpdateRacs",
                        gqlRootFieldName: "bulkUpdateOracleRacs"
                    )
                },
                {
                    GqlRootFieldName.cancelActivitySeries,
                    new RscOp(
                        cmdletName: "New-RscMutationActivitySeries",
                        cmdletSwitchName: "Cancel",
                        gqlRootFieldName: "cancelActivitySeries"
                    )
                },
                {
                    GqlRootFieldName.cassandraColumnFamilies,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "ColumnFamilies",
                        gqlRootFieldName: "cassandraColumnFamilies"
                    )
                },
                {
                    GqlRootFieldName.cassandraColumnFamily,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "ColumnFamily",
                        gqlRootFieldName: "cassandraColumnFamily"
                    )
                },
                {
                    GqlRootFieldName.cassandraColumnFamilyRecoverableRange,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "ColumnFamilyRecoverableRange",
                        gqlRootFieldName: "cassandraColumnFamilyRecoverableRange"
                    )
                },
                {
                    GqlRootFieldName.cassandraColumnFamilySchema,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "ColumnFamilySchema",
                        gqlRootFieldName: "cassandraColumnFamilySchema"
                    )
                },
                {
                    GqlRootFieldName.cassandraKeyspace,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "Keyspace",
                        gqlRootFieldName: "cassandraKeyspace"
                    )
                },
                {
                    GqlRootFieldName.cassandraKeyspaces,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "Keyspaces",
                        gqlRootFieldName: "cassandraKeyspaces"
                    )
                },
                {
                    GqlRootFieldName.cassandraSource,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "Source",
                        gqlRootFieldName: "cassandraSource"
                    )
                },
                {
                    GqlRootFieldName.cassandraSources,
                    new RscOp(
                        cmdletName: "New-RscQueryCassandra",
                        cmdletSwitchName: "Sources",
                        gqlRootFieldName: "cassandraSources"
                    )
                },
                {
                    GqlRootFieldName.cdmMssqlLogShippingTarget,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "CdmLogShippingTarget",
                        gqlRootFieldName: "cdmMssqlLogShippingTarget"
                    )
                },
                {
                    GqlRootFieldName.cdmMssqlLogShippingTargets,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "CdmLogShippingTargets",
                        gqlRootFieldName: "cdmMssqlLogShippingTargets"
                    )
                },
                {
                    GqlRootFieldName.checkAzurePersistentStorageSubscriptionCanUnmap,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "CheckPersistentStorageSubscriptionCanUnmap",
                        gqlRootFieldName: "checkAzurePersistentStorageSubscriptionCanUnmap"
                    )
                },
                {
                    GqlRootFieldName.cluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Cluster",
                        gqlRootFieldName: "cluster"
                    )
                },
                {
                    GqlRootFieldName.clusterCertificates,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Certificates",
                        gqlRootFieldName: "clusterCertificates"
                    )
                },
                {
                    GqlRootFieldName.clusterConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "List",
                        gqlRootFieldName: "clusterConnection"
                    )
                },
                {
                    GqlRootFieldName.clusterCsr,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Csr",
                        gqlRootFieldName: "clusterCsr"
                    )
                },
                {
                    GqlRootFieldName.clusterDefaultGateway,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "DefaultGateway",
                        gqlRootFieldName: "clusterDefaultGateway"
                    )
                },
                {
                    GqlRootFieldName.clusterDns,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Dns",
                        gqlRootFieldName: "clusterDns"
                    )
                },
                {
                    GqlRootFieldName.clusterFloatingIps,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "FloatingIps",
                        gqlRootFieldName: "clusterFloatingIps"
                    )
                },
                {
                    GqlRootFieldName.clusterGroupByConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "GroupByList",
                        gqlRootFieldName: "clusterGroupByConnection"
                    )
                },
                {
                    GqlRootFieldName.clusterIpmi,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Ipmi",
                        gqlRootFieldName: "clusterIpmi"
                    )
                },
                {
                    GqlRootFieldName.clusterIpv6Mode,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Ipv6Mode",
                        gqlRootFieldName: "clusterIpv6Mode"
                    )
                },
                {
                    GqlRootFieldName.clusterNetworkInterfaces,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "NetworkInterfaces",
                        gqlRootFieldName: "clusterNetworkInterfaces"
                    )
                },
                {
                    GqlRootFieldName.clusterNodes,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Nodes",
                        gqlRootFieldName: "clusterNodes"
                    )
                },
                {
                    GqlRootFieldName.clusterNtpServers,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "NtpServers",
                        gqlRootFieldName: "clusterNtpServers"
                    )
                },
                {
                    GqlRootFieldName.clusterOperationJobProgress,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "OperationJobProgress",
                        gqlRootFieldName: "clusterOperationJobProgress"
                    )
                },
                {
                    GqlRootFieldName.clusterProxy,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Proxy",
                        gqlRootFieldName: "clusterProxy"
                    )
                },
                {
                    GqlRootFieldName.clusterRegistrationProductInfo,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "RegistrationProductInfo",
                        gqlRootFieldName: "clusterRegistrationProductInfo"
                    )
                },
                {
                    GqlRootFieldName.clusterReportMigrationCount,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "ReportMigrationCount",
                        gqlRootFieldName: "clusterReportMigrationCount"
                    )
                },
                {
                    GqlRootFieldName.clusterReportMigrationJobStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "ReportMigrationJobStatus",
                        gqlRootFieldName: "clusterReportMigrationJobStatus"
                    )
                },
                {
                    GqlRootFieldName.clusterReportMigrationStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "ReportMigrationStatus",
                        gqlRootFieldName: "clusterReportMigrationStatus"
                    )
                },
                {
                    GqlRootFieldName.clusterSlaDomains,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "SlaDomains",
                        gqlRootFieldName: "clusterSlaDomains"
                    )
                },
                {
                    GqlRootFieldName.clusterTypeList,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "TypeList",
                        gqlRootFieldName: "clusterTypeList"
                    )
                },
                {
                    GqlRootFieldName.clusterVlans,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Vlans",
                        gqlRootFieldName: "clusterVlans"
                    )
                },
                {
                    GqlRootFieldName.clusterWebSignedCertificate,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "WebSignedCertificate",
                        gqlRootFieldName: "clusterWebSignedCertificate"
                    )
                },
                {
                    GqlRootFieldName.clusterWithUpgradesInfo,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "WithUpgradesInfo",
                        gqlRootFieldName: "clusterWithUpgradesInfo"
                    )
                },
                {
                    GqlRootFieldName.completeAzureAdAppSetup,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CompleteAdAppSetup",
                        gqlRootFieldName: "completeAzureAdAppSetup"
                    )
                },
                {
                    GqlRootFieldName.completeAzureAdAppUpdate,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CompleteAdAppUpdate",
                        gqlRootFieldName: "completeAzureAdAppUpdate"
                    )
                },
                {
                    GqlRootFieldName.completeAzureCloudAccountOauth,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CompleteCloudAccountOauth",
                        gqlRootFieldName: "completeAzureCloudAccountOauth"
                    )
                },
                {
                    GqlRootFieldName.countOfObjectsProtectedBySlas,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "CountOfObjectsProtected",
                        gqlRootFieldName: "countOfObjectsProtectedBySlas"
                    )
                },
                {
                    GqlRootFieldName.createAutomaticAwsTargetMapping,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateAutomaticTargetMapping",
                        gqlRootFieldName: "createAutomaticAwsTargetMapping"
                    )
                },
                {
                    GqlRootFieldName.createAutomaticAzureTargetMapping,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateAutomaticTargetMapping",
                        gqlRootFieldName: "createAutomaticAzureTargetMapping"
                    )
                },
                {
                    GqlRootFieldName.createAwsAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateAccount",
                        gqlRootFieldName: "createAwsAccount"
                    )
                },
                {
                    GqlRootFieldName.createAwsCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateCluster",
                        gqlRootFieldName: "createAwsCluster"
                    )
                },
                {
                    GqlRootFieldName.createAwsComputeSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateComputeSetting",
                        gqlRootFieldName: "createAwsComputeSetting"
                    )
                },
                {
                    GqlRootFieldName.createAwsExocomputeConfigs,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateExocomputeConfigs",
                        gqlRootFieldName: "createAwsExocomputeConfigs"
                    )
                },
                {
                    GqlRootFieldName.createAwsReaderTarget,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateReaderTarget",
                        gqlRootFieldName: "createAwsReaderTarget"
                    )
                },
                {
                    GqlRootFieldName.createAwsTarget,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateTarget",
                        gqlRootFieldName: "createAwsTarget"
                    )
                },
                {
                    GqlRootFieldName.createAzureAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateAccount",
                        gqlRootFieldName: "createAzureAccount"
                    )
                },
                {
                    GqlRootFieldName.createAzureCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateCluster",
                        gqlRootFieldName: "createAzureCluster"
                    )
                },
                {
                    GqlRootFieldName.createAzureReaderTarget,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateReaderTarget",
                        gqlRootFieldName: "createAzureReaderTarget"
                    )
                },
                {
                    GqlRootFieldName.createAzureSaasAppAad,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateSaasAppAad",
                        gqlRootFieldName: "createAzureSaasAppAad"
                    )
                },
                {
                    GqlRootFieldName.createAzureTarget,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateTarget",
                        gqlRootFieldName: "createAzureTarget"
                    )
                },
                {
                    GqlRootFieldName.createCassandraSource,
                    new RscOp(
                        cmdletName: "New-RscMutationCassandra",
                        cmdletSwitchName: "CreateSource",
                        gqlRootFieldName: "createCassandraSource"
                    )
                },
                {
                    GqlRootFieldName.createCloudNativeAwsStorageSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "CreateCloudNativeStorageSetting",
                        gqlRootFieldName: "createCloudNativeAwsStorageSetting"
                    )
                },
                {
                    GqlRootFieldName.createCloudNativeAzureStorageSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateCloudNativeStorageSetting",
                        gqlRootFieldName: "createCloudNativeAzureStorageSetting"
                    )
                },
                {
                    GqlRootFieldName.createCloudNativeRcvAzureStorageSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "CreateCloudNativeRcvStorageSetting",
                        gqlRootFieldName: "createCloudNativeRcvAzureStorageSetting"
                    )
                },
                {
                    GqlRootFieldName.createFailoverCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "CreateFailover",
                        gqlRootFieldName: "createFailoverCluster"
                    )
                },
                {
                    GqlRootFieldName.createGlobalSla,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "CreateGlobal",
                        gqlRootFieldName: "createGlobalSla"
                    )
                },
                {
                    GqlRootFieldName.createHypervVirtualMachineSnapshotMount,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "CreateVirtualMachineSnapshotMount",
                        gqlRootFieldName: "createHypervVirtualMachineSnapshotMount"
                    )
                },
                {
                    GqlRootFieldName.createK8sCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "CreateK8s",
                        gqlRootFieldName: "createK8sCluster"
                    )
                },
                {
                    GqlRootFieldName.createMongodbSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "CreatedbSource",
                        gqlRootFieldName: "createMongodbSource"
                    )
                },
                {
                    GqlRootFieldName.createMssqlLiveMount,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "CreateLiveMount",
                        gqlRootFieldName: "createMssqlLiveMount"
                    )
                },
                {
                    GqlRootFieldName.createMssqlLogShippingConfiguration,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "CreateLogShippingConfiguration",
                        gqlRootFieldName: "createMssqlLogShippingConfiguration"
                    )
                },
                {
                    GqlRootFieldName.createNutanixCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "CreateCluster",
                        gqlRootFieldName: "createNutanixCluster"
                    )
                },
                {
                    GqlRootFieldName.createNutanixPrismCentral,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "CreatePrismCentral",
                        gqlRootFieldName: "createNutanixPrismCentral"
                    )
                },
                {
                    GqlRootFieldName.createO365AppComplete,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "CreateAppComplete",
                        gqlRootFieldName: "createO365AppComplete"
                    )
                },
                {
                    GqlRootFieldName.createO365AppKickoff,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "CreateAppKickoff",
                        gqlRootFieldName: "createO365AppKickoff"
                    )
                },
                {
                    GqlRootFieldName.createOnDemandDb2Backup,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "CreateOnDemandBackup",
                        gqlRootFieldName: "createOnDemandDb2Backup"
                    )
                },
                {
                    GqlRootFieldName.createOnDemandMssqlBackup,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "CreateOnDemandBackup",
                        gqlRootFieldName: "createOnDemandMssqlBackup"
                    )
                },
                {
                    GqlRootFieldName.createOnDemandNutanixBackup,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "CreateOnDemandBackup",
                        gqlRootFieldName: "createOnDemandNutanixBackup"
                    )
                },
                {
                    GqlRootFieldName.createOraclePdbRestore,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "CreatePdbRestore",
                        gqlRootFieldName: "createOraclePdbRestore"
                    )
                },
                {
                    GqlRootFieldName.createVsphereAdvancedTag,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "CreateAdvancedTag",
                        gqlRootFieldName: "createVsphereAdvancedTag"
                    )
                },
                {
                    GqlRootFieldName.createVsphereVcenter,
                    new RscOp(
                        cmdletName: "New-RscMutationVcenter",
                        cmdletSwitchName: "Create",
                        gqlRootFieldName: "createVsphereVcenter"
                    )
                },
                {
                    GqlRootFieldName.databaseLogReportForCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "DatabaseLogReport",
                        gqlRootFieldName: "databaseLogReportForCluster"
                    )
                },
                {
                    GqlRootFieldName.databaseLogReportingPropertiesForCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "DatabaseLogReportingProperties",
                        gqlRootFieldName: "databaseLogReportingPropertiesForCluster"
                    )
                },
                {
                    GqlRootFieldName.db2Database,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "Database",
                        gqlRootFieldName: "db2Database"
                    )
                },
                {
                    GqlRootFieldName.db2Databases,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "Databases",
                        gqlRootFieldName: "db2Databases"
                    )
                },
                {
                    GqlRootFieldName.db2Instance,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "Instance",
                        gqlRootFieldName: "db2Instance"
                    )
                },
                {
                    GqlRootFieldName.db2Instances,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "Instances",
                        gqlRootFieldName: "db2Instances"
                    )
                },
                {
                    GqlRootFieldName.db2LogSnapshot,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "LogSnapshot",
                        gqlRootFieldName: "db2LogSnapshot"
                    )
                },
                {
                    GqlRootFieldName.db2LogSnapshots,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "LogSnapshots",
                        gqlRootFieldName: "db2LogSnapshots"
                    )
                },
                {
                    GqlRootFieldName.db2RecoverableRange,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "RecoverableRange",
                        gqlRootFieldName: "db2RecoverableRange"
                    )
                },
                {
                    GqlRootFieldName.db2RecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryDb2",
                        cmdletSwitchName: "RecoverableRanges",
                        gqlRootFieldName: "db2RecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.deleteAllOracleDatabaseSnapshots,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "DeleteAllDatabaseSnapshots",
                        gqlRootFieldName: "deleteAllOracleDatabaseSnapshots"
                    )
                },
                {
                    GqlRootFieldName.deleteAwsCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "DeleteCluster",
                        gqlRootFieldName: "deleteAwsCluster"
                    )
                },
                {
                    GqlRootFieldName.deleteAwsComputeSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "DeleteComputeSetting",
                        gqlRootFieldName: "deleteAwsComputeSetting"
                    )
                },
                {
                    GqlRootFieldName.deleteAwsExocomputeConfigs,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "DeleteExocomputeConfigs",
                        gqlRootFieldName: "deleteAwsExocomputeConfigs"
                    )
                },
                {
                    GqlRootFieldName.deleteAzureAdDirectory,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "DeleteAdDirectory",
                        gqlRootFieldName: "deleteAzureAdDirectory"
                    )
                },
                {
                    GqlRootFieldName.deleteAzureCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "DeleteCloudAccount",
                        gqlRootFieldName: "deleteAzureCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.deleteAzureCloudAccountExocomputeConfigurations,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "DeleteCloudAccountExocomputeConfigurations",
                        gqlRootFieldName: "deleteAzureCloudAccountExocomputeConfigurations"
                    )
                },
                {
                    GqlRootFieldName.deleteAzureCloudAccountWithoutOauth,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "DeleteCloudAccountWithoutOauth",
                        gqlRootFieldName: "deleteAzureCloudAccountWithoutOauth"
                    )
                },
                {
                    GqlRootFieldName.deleteAzureCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "DeleteCluster",
                        gqlRootFieldName: "deleteAzureCluster"
                    )
                },
                {
                    GqlRootFieldName.deleteCassandraSource,
                    new RscOp(
                        cmdletName: "New-RscMutationCassandra",
                        cmdletSwitchName: "DeleteSource",
                        gqlRootFieldName: "deleteCassandraSource"
                    )
                },
                {
                    GqlRootFieldName.deleteDb2Database,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "DeleteDatabase",
                        gqlRootFieldName: "deleteDb2Database"
                    )
                },
                {
                    GqlRootFieldName.deleteDb2Instance,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "DeleteInstance",
                        gqlRootFieldName: "deleteDb2Instance"
                    )
                },
                {
                    GqlRootFieldName.deleteFailoverCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "DeleteFailover",
                        gqlRootFieldName: "deleteFailoverCluster"
                    )
                },
                {
                    GqlRootFieldName.deleteHypervVirtualMachineSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "DeleteVirtualMachineSnapshot",
                        gqlRootFieldName: "deleteHypervVirtualMachineSnapshot"
                    )
                },
                {
                    GqlRootFieldName.deleteHypervVirtualMachineSnapshotMount,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "DeleteVirtualMachineSnapshotMount",
                        gqlRootFieldName: "deleteHypervVirtualMachineSnapshotMount"
                    )
                },
                {
                    GqlRootFieldName.deleteLdapPrincipals,
                    new RscOp(
                        cmdletName: "New-RscMutationLdap",
                        cmdletSwitchName: "DeletePrincipals",
                        gqlRootFieldName: "deleteLdapPrincipals"
                    )
                },
                {
                    GqlRootFieldName.deleteManagedVolume,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "Delete",
                        gqlRootFieldName: "deleteManagedVolume"
                    )
                },
                {
                    GqlRootFieldName.deleteManagedVolumeSnapshotExport,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "DeleteSnapshotExport",
                        gqlRootFieldName: "deleteManagedVolumeSnapshotExport"
                    )
                },
                {
                    GqlRootFieldName.deleteMongoSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "DeleteSource",
                        gqlRootFieldName: "deleteMongoSource"
                    )
                },
                {
                    GqlRootFieldName.deleteMongodbSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "DeletedbSource",
                        gqlRootFieldName: "deleteMongodbSource"
                    )
                },
                {
                    GqlRootFieldName.deleteMssqlDbSnapshots,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "DeleteDbSnapshots",
                        gqlRootFieldName: "deleteMssqlDbSnapshots"
                    )
                },
                {
                    GqlRootFieldName.deleteMssqlLiveMount,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "DeleteLiveMount",
                        gqlRootFieldName: "deleteMssqlLiveMount"
                    )
                },
                {
                    GqlRootFieldName.deleteNutanixCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DeleteCluster",
                        gqlRootFieldName: "deleteNutanixCluster"
                    )
                },
                {
                    GqlRootFieldName.deleteNutanixMountV1,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DeleteMountV1",
                        gqlRootFieldName: "deleteNutanixMountV1"
                    )
                },
                {
                    GqlRootFieldName.deleteNutanixPrismCentral,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DeletePrismCentral",
                        gqlRootFieldName: "deleteNutanixPrismCentral"
                    )
                },
                {
                    GqlRootFieldName.deleteNutanixSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DeleteSnapshot",
                        gqlRootFieldName: "deleteNutanixSnapshot"
                    )
                },
                {
                    GqlRootFieldName.deleteNutanixSnapshots,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DeleteSnapshots",
                        gqlRootFieldName: "deleteNutanixSnapshots"
                    )
                },
                {
                    GqlRootFieldName.deleteO365AzureApp,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "DeleteAzureApp",
                        gqlRootFieldName: "deleteO365AzureApp"
                    )
                },
                {
                    GqlRootFieldName.deleteO365Org,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "DeleteOrg",
                        gqlRootFieldName: "deleteO365Org"
                    )
                },
                {
                    GqlRootFieldName.deleteO365ServiceAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "DeleteServiceAccount",
                        gqlRootFieldName: "deleteO365ServiceAccount"
                    )
                },
                {
                    GqlRootFieldName.deleteOracleMount,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "DeleteMount",
                        gqlRootFieldName: "deleteOracleMount"
                    )
                },
                {
                    GqlRootFieldName.deleteVsphereAdvancedTag,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "DeleteAdvancedTag",
                        gqlRootFieldName: "deleteVsphereAdvancedTag"
                    )
                },
                {
                    GqlRootFieldName.deleteVsphereLiveMount,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "DeleteLiveMount",
                        gqlRootFieldName: "deleteVsphereLiveMount"
                    )
                },
                {
                    GqlRootFieldName.discoverDb2Instance,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "DiscoverInstance",
                        gqlRootFieldName: "discoverDb2Instance"
                    )
                },
                {
                    GqlRootFieldName.discoverMongoSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "DiscoverSource",
                        gqlRootFieldName: "discoverMongoSource"
                    )
                },
                {
                    GqlRootFieldName.doesAzureNativeResourceGroupExist,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "DoesNativeResourceGroupExist",
                        gqlRootFieldName: "doesAzureNativeResourceGroupExist"
                    )
                },
                {
                    GqlRootFieldName.downloadDb2Snapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "DownloadSnapshot",
                        gqlRootFieldName: "downloadDb2Snapshot"
                    )
                },
                {
                    GqlRootFieldName.downloadDb2SnapshotsForPointInTimeRecovery,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "DownloadSnapshotsForPointInTimeRecovery",
                        gqlRootFieldName: "downloadDb2SnapshotsForPointInTimeRecovery"
                    )
                },
                {
                    GqlRootFieldName.downloadFilesNutanixSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DownloadFilesSnapshot",
                        gqlRootFieldName: "downloadFilesNutanixSnapshot"
                    )
                },
                {
                    GqlRootFieldName.downloadHypervSnapshotFromLocation,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "DownloadSnapshotFromLocation",
                        gqlRootFieldName: "downloadHypervSnapshotFromLocation"
                    )
                },
                {
                    GqlRootFieldName.downloadHypervVirtualMachineSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "DownloadVirtualMachineSnapshot",
                        gqlRootFieldName: "downloadHypervVirtualMachineSnapshot"
                    )
                },
                {
                    GqlRootFieldName.downloadHypervVirtualMachineSnapshotFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "DownloadVirtualMachineSnapshotFiles",
                        gqlRootFieldName: "downloadHypervVirtualMachineSnapshotFiles"
                    )
                },
                {
                    GqlRootFieldName.downloadManagedVolumeFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "DownloadFiles",
                        gqlRootFieldName: "downloadManagedVolumeFiles"
                    )
                },
                {
                    GqlRootFieldName.downloadManagedVolumeFromLocation,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "DownloadFromLocation",
                        gqlRootFieldName: "downloadManagedVolumeFromLocation"
                    )
                },
                {
                    GqlRootFieldName.downloadMssqlDatabaseBackupFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "DownloadDatabaseBackupFiles",
                        gqlRootFieldName: "downloadMssqlDatabaseBackupFiles"
                    )
                },
                {
                    GqlRootFieldName.downloadMssqlDatabaseFilesFromArchivalLocation,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "DownloadDatabaseFilesFromArchivalLocation",
                        gqlRootFieldName: "downloadMssqlDatabaseFilesFromArchivalLocation"
                    )
                },
                {
                    GqlRootFieldName.downloadNutanixSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DownloadSnapshot",
                        gqlRootFieldName: "downloadNutanixSnapshot"
                    )
                },
                {
                    GqlRootFieldName.downloadNutanixVmFromLocation,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "DownloadVmFromLocation",
                        gqlRootFieldName: "downloadNutanixVmFromLocation"
                    )
                },
                {
                    GqlRootFieldName.downloadOracleDatabaseSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "DownloadDatabaseSnapshot",
                        gqlRootFieldName: "downloadOracleDatabaseSnapshot"
                    )
                },
                {
                    GqlRootFieldName.downloadVsphereVirtualMachineFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "DownloadVirtualMachineFiles",
                        gqlRootFieldName: "downloadVsphereVirtualMachineFiles"
                    )
                },
                {
                    GqlRootFieldName.enableO365SharePoint,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "EnableSharePoint",
                        gqlRootFieldName: "enableO365SharePoint"
                    )
                },
                {
                    GqlRootFieldName.enableO365Teams,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "EnableTeams",
                        gqlRootFieldName: "enableO365Teams"
                    )
                },
                {
                    GqlRootFieldName.endManagedVolumeSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "EndSnapshot",
                        gqlRootFieldName: "endManagedVolumeSnapshot"
                    )
                },
                {
                    GqlRootFieldName.excludeAwsNativeEbsVolumesFromSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "ExcludeNativeEbsVolumesFromSnapshot",
                        gqlRootFieldName: "excludeAwsNativeEbsVolumesFromSnapshot"
                    )
                },
                {
                    GqlRootFieldName.excludeAzureNativeManagedDisksFromSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "ExcludeNativeManagedDisksFromSnapshot",
                        gqlRootFieldName: "excludeAzureNativeManagedDisksFromSnapshot"
                    )
                },
                {
                    GqlRootFieldName.expireDownloadedDb2Snapshots,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "ExpireDownloadedSnapshots",
                        gqlRootFieldName: "expireDownloadedDb2Snapshots"
                    )
                },
                {
                    GqlRootFieldName.exportHypervVirtualMachine,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "ExportVirtualMachine",
                        gqlRootFieldName: "exportHypervVirtualMachine"
                    )
                },
                {
                    GqlRootFieldName.exportManagedVolumeSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "ExportSnapshot",
                        gqlRootFieldName: "exportManagedVolumeSnapshot"
                    )
                },
                {
                    GqlRootFieldName.exportMssqlDatabase,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "ExportDatabase",
                        gqlRootFieldName: "exportMssqlDatabase"
                    )
                },
                {
                    GqlRootFieldName.exportNutanixSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "ExportSnapshot",
                        gqlRootFieldName: "exportNutanixSnapshot"
                    )
                },
                {
                    GqlRootFieldName.exportO365Mailbox,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "ExportMailbox",
                        gqlRootFieldName: "exportO365Mailbox"
                    )
                },
                {
                    GqlRootFieldName.exportOracleDatabase,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "ExportDatabase",
                        gqlRootFieldName: "exportOracleDatabase"
                    )
                },
                {
                    GqlRootFieldName.exportOracleTablespace,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "ExportTablespace",
                        gqlRootFieldName: "exportOracleTablespace"
                    )
                },
                {
                    GqlRootFieldName.exportSlaManagedVolumeSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "ExportManagedVolumeSnapshot",
                        gqlRootFieldName: "exportSlaManagedVolumeSnapshot"
                    )
                },
                {
                    GqlRootFieldName.finalizeAwsCloudAccountDeletion,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "FinalizeCloudAccountDeletion",
                        gqlRootFieldName: "finalizeAwsCloudAccountDeletion"
                    )
                },
                {
                    GqlRootFieldName.finalizeAwsCloudAccountProtection,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "FinalizeCloudAccountProtection",
                        gqlRootFieldName: "finalizeAwsCloudAccountProtection"
                    )
                },
                {
                    GqlRootFieldName.getPendingSlaAssignments,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "GetPendingAssignments",
                        gqlRootFieldName: "getPendingSlaAssignments"
                    )
                },
                {
                    GqlRootFieldName.globalSlaFilterConnection,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "GlobalFilterList",
                        gqlRootFieldName: "globalSlaFilterConnection"
                    )
                },
                {
                    GqlRootFieldName.globalSlaStatuses,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "GlobalStatuses",
                        gqlRootFieldName: "globalSlaStatuses"
                    )
                },
                {
                    GqlRootFieldName.hostFailoverCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "HostFailover",
                        gqlRootFieldName: "hostFailoverCluster"
                    )
                },
                {
                    GqlRootFieldName.hypervCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "Cluster",
                        gqlRootFieldName: "hypervCluster"
                    )
                },
                {
                    GqlRootFieldName.hypervDeleteAllSnapshots,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "DeleteAllSnapshots",
                        gqlRootFieldName: "hypervDeleteAllSnapshots"
                    )
                },
                {
                    GqlRootFieldName.hypervHostAsyncRequestStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "HostAsyncRequestStatus",
                        gqlRootFieldName: "hypervHostAsyncRequestStatus"
                    )
                },
                {
                    GqlRootFieldName.hypervMounts,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "Mounts",
                        gqlRootFieldName: "hypervMounts"
                    )
                },
                {
                    GqlRootFieldName.hypervOnDemandSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "OnDemandSnapshot",
                        gqlRootFieldName: "hypervOnDemandSnapshot"
                    )
                },
                {
                    GqlRootFieldName.hypervScvmm,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "Scvmm",
                        gqlRootFieldName: "hypervScvmm"
                    )
                },
                {
                    GqlRootFieldName.hypervScvmmAsyncRequestStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "ScvmmAsyncRequestStatus",
                        gqlRootFieldName: "hypervScvmmAsyncRequestStatus"
                    )
                },
                {
                    GqlRootFieldName.hypervScvmmDelete,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "ScvmmDelete",
                        gqlRootFieldName: "hypervScvmmDelete"
                    )
                },
                {
                    GqlRootFieldName.hypervScvmmUpdate,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "ScvmmUpdate",
                        gqlRootFieldName: "hypervScvmmUpdate"
                    )
                },
                {
                    GqlRootFieldName.hypervScvmms,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "Scvmms",
                        gqlRootFieldName: "hypervScvmms"
                    )
                },
                {
                    GqlRootFieldName.hypervServer,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "Server",
                        gqlRootFieldName: "hypervServer"
                    )
                },
                {
                    GqlRootFieldName.hypervServers,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "Servers",
                        gqlRootFieldName: "hypervServers"
                    )
                },
                {
                    GqlRootFieldName.hypervTopLevelDescendants,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "TopLevelDescendants",
                        gqlRootFieldName: "hypervTopLevelDescendants"
                    )
                },
                {
                    GqlRootFieldName.hypervVirtualMachine,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "VirtualMachine",
                        gqlRootFieldName: "hypervVirtualMachine"
                    )
                },
                {
                    GqlRootFieldName.hypervVirtualMachineAsyncRequestStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "VirtualMachineAsyncRequestStatus",
                        gqlRootFieldName: "hypervVirtualMachineAsyncRequestStatus"
                    )
                },
                {
                    GqlRootFieldName.hypervVirtualMachines,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "VirtualMachines",
                        gqlRootFieldName: "hypervVirtualMachines"
                    )
                },
                {
                    GqlRootFieldName.hypervVmDetail,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "VmDetail",
                        gqlRootFieldName: "hypervVmDetail"
                    )
                },
                {
                    GqlRootFieldName.insertCustomerO365App,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "InsertCustomerApp",
                        gqlRootFieldName: "insertCustomerO365App"
                    )
                },
                {
                    GqlRootFieldName.instantRecoverHypervVirtualMachineSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "InstantRecoverVirtualMachineSnapshot",
                        gqlRootFieldName: "instantRecoverHypervVirtualMachineSnapshot"
                    )
                },
                {
                    GqlRootFieldName.instantRecoverOracleSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "InstantRecoverSnapshot",
                        gqlRootFieldName: "instantRecoverOracleSnapshot"
                    )
                },
                {
                    GqlRootFieldName.isAwsNativeEbsVolumeSnapshotRestorable,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "IsNativeEbsVolumeSnapshotRestorable",
                        gqlRootFieldName: "isAwsNativeEbsVolumeSnapshotRestorable"
                    )
                },
                {
                    GqlRootFieldName.isAwsNativeRdsInstanceLaunchConfigurationValid,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "IsNativeRdsInstanceLaunchConfigurationValid",
                        gqlRootFieldName: "isAwsNativeRdsInstanceLaunchConfigurationValid"
                    )
                },
                {
                    GqlRootFieldName.isAwsS3BucketNameAvailable,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "IsS3BucketNameAvailable",
                        gqlRootFieldName: "isAwsS3BucketNameAvailable"
                    )
                },
                {
                    GqlRootFieldName.isAzureNativeManagedDiskSnapshotRestorable,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "IsNativeManagedDiskSnapshotRestorable",
                        gqlRootFieldName: "isAzureNativeManagedDiskSnapshotRestorable"
                    )
                },
                {
                    GqlRootFieldName.isAzureNativeSqlDatabaseSnapshotPersistent,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "IsNativeSqlDatabaseSnapshotPersistent",
                        gqlRootFieldName: "isAzureNativeSqlDatabaseSnapshotPersistent"
                    )
                },
                {
                    GqlRootFieldName.isAzureStorageAccountNameAvailable,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "IsStorageAccountNameAvailable",
                        gqlRootFieldName: "isAzureStorageAccountNameAvailable"
                    )
                },
                {
                    GqlRootFieldName.isTotpAckNecessaryForCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "IsTotpAckNecessary",
                        gqlRootFieldName: "isTotpAckNecessaryForCluster"
                    )
                },
                {
                    GqlRootFieldName.k8sClusters,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "K8s",
                        gqlRootFieldName: "k8sClusters"
                    )
                },
                {
                    GqlRootFieldName.ldapAuthorizedPrincipalConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryLdap",
                        cmdletSwitchName: "AuthorizedPrincipalList",
                        gqlRootFieldName: "ldapAuthorizedPrincipalConnection"
                    )
                },
                {
                    GqlRootFieldName.ldapIntegrationConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryLdap",
                        cmdletSwitchName: "IntegrationList",
                        gqlRootFieldName: "ldapIntegrationConnection"
                    )
                },
                {
                    GqlRootFieldName.ldapPrincipalConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryLdap",
                        cmdletSwitchName: "PrincipalList",
                        gqlRootFieldName: "ldapPrincipalConnection"
                    )
                },
                {
                    GqlRootFieldName.listO365Apps,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "ListApps",
                        gqlRootFieldName: "listO365Apps"
                    )
                },
                {
                    GqlRootFieldName.managedVolume,
                    new RscOp(
                        cmdletName: "New-RscQueryManagedVolume",
                        cmdletSwitchName: "ManagedVolume",
                        gqlRootFieldName: "managedVolume"
                    )
                },
                {
                    GqlRootFieldName.managedVolumeInventoryStats,
                    new RscOp(
                        cmdletName: "New-RscQueryManagedVolume",
                        cmdletSwitchName: "InventoryStats",
                        gqlRootFieldName: "managedVolumeInventoryStats"
                    )
                },
                {
                    GqlRootFieldName.managedVolumeLiveMounts,
                    new RscOp(
                        cmdletName: "New-RscQueryManagedVolume",
                        cmdletSwitchName: "LiveMounts",
                        gqlRootFieldName: "managedVolumeLiveMounts"
                    )
                },
                {
                    GqlRootFieldName.managedVolumes,
                    new RscOp(
                        cmdletName: "New-RscQueryManagedVolume",
                        cmdletSwitchName: "ManagedVolumes",
                        gqlRootFieldName: "managedVolumes"
                    )
                },
                {
                    GqlRootFieldName.mapAzureCloudAccountExocomputeSubscription,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "MapCloudAccountExocomputeSubscription",
                        gqlRootFieldName: "mapAzureCloudAccountExocomputeSubscription"
                    )
                },
                {
                    GqlRootFieldName.mapAzureCloudAccountToPersistentStorageLocation,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "MapCloudAccountToPersistentStorageLocation",
                        gqlRootFieldName: "mapAzureCloudAccountToPersistentStorageLocation"
                    )
                },
                {
                    GqlRootFieldName.migrateNutanixMountV1,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "MigrateMountV1",
                        gqlRootFieldName: "migrateNutanixMountV1"
                    )
                },
                {
                    GqlRootFieldName.mongoBulkRecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "BulkRecoverableRanges",
                        gqlRootFieldName: "mongoBulkRecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.mongoCollection,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "Collection",
                        gqlRootFieldName: "mongoCollection"
                    )
                },
                {
                    GqlRootFieldName.mongoCollections,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "Collections",
                        gqlRootFieldName: "mongoCollections"
                    )
                },
                {
                    GqlRootFieldName.mongoDatabase,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "Database",
                        gqlRootFieldName: "mongoDatabase"
                    )
                },
                {
                    GqlRootFieldName.mongoDatabases,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "Databases",
                        gqlRootFieldName: "mongoDatabases"
                    )
                },
                {
                    GqlRootFieldName.mongoRecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "RecoverableRanges",
                        gqlRootFieldName: "mongoRecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.mongoSource,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "Source",
                        gqlRootFieldName: "mongoSource"
                    )
                },
                {
                    GqlRootFieldName.mongoSources,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "Sources",
                        gqlRootFieldName: "mongoSources"
                    )
                },
                {
                    GqlRootFieldName.mongodbBulkRecoverableRange,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbBulkRecoverableRange",
                        gqlRootFieldName: "mongodbBulkRecoverableRange"
                    )
                },
                {
                    GqlRootFieldName.mongodbCollection,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbCollection",
                        gqlRootFieldName: "mongodbCollection"
                    )
                },
                {
                    GqlRootFieldName.mongodbCollectionRecoverableRange,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbCollectionRecoverableRange",
                        gqlRootFieldName: "mongodbCollectionRecoverableRange"
                    )
                },
                {
                    GqlRootFieldName.mongodbCollections,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbCollections",
                        gqlRootFieldName: "mongodbCollections"
                    )
                },
                {
                    GqlRootFieldName.mongodbDatabase,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbDatabase",
                        gqlRootFieldName: "mongodbDatabase"
                    )
                },
                {
                    GqlRootFieldName.mongodbDatabases,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbDatabases",
                        gqlRootFieldName: "mongodbDatabases"
                    )
                },
                {
                    GqlRootFieldName.mongodbSource,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbSource",
                        gqlRootFieldName: "mongodbSource"
                    )
                },
                {
                    GqlRootFieldName.mongodbSources,
                    new RscOp(
                        cmdletName: "New-RscQueryMongo",
                        cmdletSwitchName: "DbSources",
                        gqlRootFieldName: "mongodbSources"
                    )
                },
                {
                    GqlRootFieldName.mountNutanixSnapshotV1,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "MountSnapshotV1",
                        gqlRootFieldName: "mountNutanixSnapshotV1"
                    )
                },
                {
                    GqlRootFieldName.mountOracleDatabase,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "MountDatabase",
                        gqlRootFieldName: "mountOracleDatabase"
                    )
                },
                {
                    GqlRootFieldName.mssqlAvailabilityGroup,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "AvailabilityGroup",
                        gqlRootFieldName: "mssqlAvailabilityGroup"
                    )
                },
                {
                    GqlRootFieldName.mssqlCompatibleInstances,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "CompatibleInstances",
                        gqlRootFieldName: "mssqlCompatibleInstances"
                    )
                },
                {
                    GqlRootFieldName.mssqlDatabase,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "Database",
                        gqlRootFieldName: "mssqlDatabase"
                    )
                },
                {
                    GqlRootFieldName.mssqlDatabaseLiveMounts,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "DatabaseLiveMounts",
                        gqlRootFieldName: "mssqlDatabaseLiveMounts"
                    )
                },
                {
                    GqlRootFieldName.mssqlDatabaseMissedRecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "DatabaseMissedRecoverableRanges",
                        gqlRootFieldName: "mssqlDatabaseMissedRecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.mssqlDatabaseMissedSnapshots,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "DatabaseMissedSnapshots",
                        gqlRootFieldName: "mssqlDatabaseMissedSnapshots"
                    )
                },
                {
                    GqlRootFieldName.mssqlDatabaseRestoreEstimate,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "DatabaseRestoreEstimate",
                        gqlRootFieldName: "mssqlDatabaseRestoreEstimate"
                    )
                },
                {
                    GqlRootFieldName.mssqlDatabases,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "Databases",
                        gqlRootFieldName: "mssqlDatabases"
                    )
                },
                {
                    GqlRootFieldName.mssqlDefaultProperties,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "DefaultProperties",
                        gqlRootFieldName: "mssqlDefaultProperties"
                    )
                },
                {
                    GqlRootFieldName.mssqlInstance,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "Instance",
                        gqlRootFieldName: "mssqlInstance"
                    )
                },
                {
                    GqlRootFieldName.mssqlLogShippingTargets,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "LogShippingTargets",
                        gqlRootFieldName: "mssqlLogShippingTargets"
                    )
                },
                {
                    GqlRootFieldName.mssqlRecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "RecoverableRanges",
                        gqlRootFieldName: "mssqlRecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.mssqlTopLevelDescendants,
                    new RscOp(
                        cmdletName: "New-RscQueryMssql",
                        cmdletSwitchName: "TopLevelDescendants",
                        gqlRootFieldName: "mssqlTopLevelDescendants"
                    )
                },
                {
                    GqlRootFieldName.nutanixBrowseSnapshot,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "BrowseSnapshot",
                        gqlRootFieldName: "nutanixBrowseSnapshot"
                    )
                },
                {
                    GqlRootFieldName.nutanixCategory,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "Category",
                        gqlRootFieldName: "nutanixCategory"
                    )
                },
                {
                    GqlRootFieldName.nutanixCategoryValue,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "CategoryValue",
                        gqlRootFieldName: "nutanixCategoryValue"
                    )
                },
                {
                    GqlRootFieldName.nutanixCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "Cluster",
                        gqlRootFieldName: "nutanixCluster"
                    )
                },
                {
                    GqlRootFieldName.nutanixClusterAsyncRequestStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "ClusterAsyncRequestStatus",
                        gqlRootFieldName: "nutanixClusterAsyncRequestStatus"
                    )
                },
                {
                    GqlRootFieldName.nutanixClusterContainers,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "ClusterContainers",
                        gqlRootFieldName: "nutanixClusterContainers"
                    )
                },
                {
                    GqlRootFieldName.nutanixClusterNetworks,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "ClusterNetworks",
                        gqlRootFieldName: "nutanixClusterNetworks"
                    )
                },
                {
                    GqlRootFieldName.nutanixClusters,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "Clusters",
                        gqlRootFieldName: "nutanixClusters"
                    )
                },
                {
                    GqlRootFieldName.nutanixMounts,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "Mounts",
                        gqlRootFieldName: "nutanixMounts"
                    )
                },
                {
                    GqlRootFieldName.nutanixPrismCentral,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "PrismCentral",
                        gqlRootFieldName: "nutanixPrismCentral"
                    )
                },
                {
                    GqlRootFieldName.nutanixPrismCentrals,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "PrismCentrals",
                        gqlRootFieldName: "nutanixPrismCentrals"
                    )
                },
                {
                    GqlRootFieldName.nutanixSnapshotDetail,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "SnapshotDetail",
                        gqlRootFieldName: "nutanixSnapshotDetail"
                    )
                },
                {
                    GqlRootFieldName.nutanixTopLevelDescendants,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "TopLevelDescendants",
                        gqlRootFieldName: "nutanixTopLevelDescendants"
                    )
                },
                {
                    GqlRootFieldName.nutanixVm,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "Vm",
                        gqlRootFieldName: "nutanixVm"
                    )
                },
                {
                    GqlRootFieldName.nutanixVmAsyncRequestStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "VmAsyncRequestStatus",
                        gqlRootFieldName: "nutanixVmAsyncRequestStatus"
                    )
                },
                {
                    GqlRootFieldName.nutanixVmMissedSnapshots,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "VmMissedSnapshots",
                        gqlRootFieldName: "nutanixVmMissedSnapshots"
                    )
                },
                {
                    GqlRootFieldName.nutanixVms,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "Vms",
                        gqlRootFieldName: "nutanixVms"
                    )
                },
                {
                    GqlRootFieldName.o365Calendar,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Calendar",
                        gqlRootFieldName: "o365Calendar"
                    )
                },
                {
                    GqlRootFieldName.o365Groups,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Groups",
                        gqlRootFieldName: "o365Groups"
                    )
                },
                {
                    GqlRootFieldName.o365License,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "License",
                        gqlRootFieldName: "o365License"
                    )
                },
                {
                    GqlRootFieldName.o365Mailbox,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Mailbox",
                        gqlRootFieldName: "o365Mailbox"
                    )
                },
                {
                    GqlRootFieldName.o365Mailboxes,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Mailboxes",
                        gqlRootFieldName: "o365Mailboxes"
                    )
                },
                {
                    GqlRootFieldName.o365OauthConsentComplete,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "OauthConsentComplete",
                        gqlRootFieldName: "o365OauthConsentComplete"
                    )
                },
                {
                    GqlRootFieldName.o365OauthConsentKickoff,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "OauthConsentKickoff",
                        gqlRootFieldName: "o365OauthConsentKickoff"
                    )
                },
                {
                    GqlRootFieldName.o365ObjectAncestors,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "ObjectAncestors",
                        gqlRootFieldName: "o365ObjectAncestors"
                    )
                },
                {
                    GqlRootFieldName.o365Onedrive,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Onedrive",
                        gqlRootFieldName: "o365Onedrive"
                    )
                },
                {
                    GqlRootFieldName.o365Onedrives,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Onedrives",
                        gqlRootFieldName: "o365Onedrives"
                    )
                },
                {
                    GqlRootFieldName.o365Org,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Org",
                        gqlRootFieldName: "o365Org"
                    )
                },
                {
                    GqlRootFieldName.o365OrgAtSnappableLevel,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "OrgAtSnappableLevel",
                        gqlRootFieldName: "o365OrgAtSnappableLevel"
                    )
                },
                {
                    GqlRootFieldName.o365OrgSummaries,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "OrgSummaries",
                        gqlRootFieldName: "o365OrgSummaries"
                    )
                },
                {
                    GqlRootFieldName.o365Orgs,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Orgs",
                        gqlRootFieldName: "o365Orgs"
                    )
                },
                {
                    GqlRootFieldName.o365PdlGroups,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "PdlGroups",
                        gqlRootFieldName: "o365PdlGroups"
                    )
                },
                {
                    GqlRootFieldName.o365SaaSSetupKickoff,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "SaaSSetupKickoff",
                        gqlRootFieldName: "o365SaaSSetupKickoff"
                    )
                },
                {
                    GqlRootFieldName.o365SaasSetupComplete,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "SaasSetupComplete",
                        gqlRootFieldName: "o365SaasSetupComplete"
                    )
                },
                {
                    GqlRootFieldName.o365ServiceAccount,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "ServiceAccount",
                        gqlRootFieldName: "o365ServiceAccount"
                    )
                },
                {
                    GqlRootFieldName.o365ServiceStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "ServiceStatus",
                        gqlRootFieldName: "o365ServiceStatus"
                    )
                },
                {
                    GqlRootFieldName.o365SetupKickoff,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "SetupKickoff",
                        gqlRootFieldName: "o365SetupKickoff"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointDrive,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointDrive",
                        gqlRootFieldName: "o365SharepointDrive"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointDrives,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointDrives",
                        gqlRootFieldName: "o365SharepointDrives"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointList,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointList",
                        gqlRootFieldName: "o365SharepointList"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointLists,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointLists",
                        gqlRootFieldName: "o365SharepointLists"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointObjectList,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointObjectList",
                        gqlRootFieldName: "o365SharepointObjectList"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointObjects,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointObjects",
                        gqlRootFieldName: "o365SharepointObjects"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointSite,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointSite",
                        gqlRootFieldName: "o365SharepointSite"
                    )
                },
                {
                    GqlRootFieldName.o365SharepointSites,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "SharepointSites",
                        gqlRootFieldName: "o365SharepointSites"
                    )
                },
                {
                    GqlRootFieldName.o365Site,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Site",
                        gqlRootFieldName: "o365Site"
                    )
                },
                {
                    GqlRootFieldName.o365Sites,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Sites",
                        gqlRootFieldName: "o365Sites"
                    )
                },
                {
                    GqlRootFieldName.o365StorageStats,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "StorageStats",
                        gqlRootFieldName: "o365StorageStats"
                    )
                },
                {
                    GqlRootFieldName.o365Team,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Team",
                        gqlRootFieldName: "o365Team"
                    )
                },
                {
                    GqlRootFieldName.o365TeamChannels,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "TeamChannels",
                        gqlRootFieldName: "o365TeamChannels"
                    )
                },
                {
                    GqlRootFieldName.o365TeamConversationsFolderID,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "TeamConversationsFolderID",
                        gqlRootFieldName: "o365TeamConversationsFolderID"
                    )
                },
                {
                    GqlRootFieldName.o365TeamPostedBy,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "TeamPostedBy",
                        gqlRootFieldName: "o365TeamPostedBy"
                    )
                },
                {
                    GqlRootFieldName.o365Teams,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "Teams",
                        gqlRootFieldName: "o365Teams"
                    )
                },
                {
                    GqlRootFieldName.o365User,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "User",
                        gqlRootFieldName: "o365User"
                    )
                },
                {
                    GqlRootFieldName.o365UserObjects,
                    new RscOp(
                        cmdletName: "New-RscQueryO365",
                        cmdletSwitchName: "UserObjects",
                        gqlRootFieldName: "o365UserObjects"
                    )
                },
                {
                    GqlRootFieldName.oracleAcoExampleDownloadLink,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "AcoExampleDownloadLink",
                        gqlRootFieldName: "oracleAcoExampleDownloadLink"
                    )
                },
                {
                    GqlRootFieldName.oracleAcoParameters,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "AcoParameters",
                        gqlRootFieldName: "oracleAcoParameters"
                    )
                },
                {
                    GqlRootFieldName.oracleDataGuardGroup,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "DataGuardGroup",
                        gqlRootFieldName: "oracleDataGuardGroup"
                    )
                },
                {
                    GqlRootFieldName.oracleDatabase,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "Database",
                        gqlRootFieldName: "oracleDatabase"
                    )
                },
                {
                    GqlRootFieldName.oracleDatabaseLogBackupConfig,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "DatabaseLogBackupConfig",
                        gqlRootFieldName: "oracleDatabaseLogBackupConfig"
                    )
                },
                {
                    GqlRootFieldName.oracleDatabases,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "Databases",
                        gqlRootFieldName: "oracleDatabases"
                    )
                },
                {
                    GqlRootFieldName.oracleHost,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "Host",
                        gqlRootFieldName: "oracleHost"
                    )
                },
                {
                    GqlRootFieldName.oracleHostLogBackupConfig,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "HostLogBackupConfig",
                        gqlRootFieldName: "oracleHostLogBackupConfig"
                    )
                },
                {
                    GqlRootFieldName.oracleLiveMounts,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "LiveMounts",
                        gqlRootFieldName: "oracleLiveMounts"
                    )
                },
                {
                    GqlRootFieldName.oracleMissedRecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "MissedRecoverableRanges",
                        gqlRootFieldName: "oracleMissedRecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.oracleMissedSnapshots,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "MissedSnapshots",
                        gqlRootFieldName: "oracleMissedSnapshots"
                    )
                },
                {
                    GqlRootFieldName.oraclePdbDetails,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "PdbDetails",
                        gqlRootFieldName: "oraclePdbDetails"
                    )
                },
                {
                    GqlRootFieldName.oracleRac,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "Rac",
                        gqlRootFieldName: "oracleRac"
                    )
                },
                {
                    GqlRootFieldName.oracleRacLogBackupConfig,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "RacLogBackupConfig",
                        gqlRootFieldName: "oracleRacLogBackupConfig"
                    )
                },
                {
                    GqlRootFieldName.oracleRecoverableRanges,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "RecoverableRanges",
                        gqlRootFieldName: "oracleRecoverableRanges"
                    )
                },
                {
                    GqlRootFieldName.oracleTopLevelDescendants,
                    new RscOp(
                        cmdletName: "New-RscQueryOracle",
                        cmdletSwitchName: "TopLevelDescendants",
                        gqlRootFieldName: "oracleTopLevelDescendants"
                    )
                },
                {
                    GqlRootFieldName.patchAwsAuthenticationServerBasedCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "PatchAuthenticationServerBasedCloudAccount",
                        gqlRootFieldName: "patchAwsAuthenticationServerBasedCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.patchAwsIamUserBasedCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "PatchIamUserBasedCloudAccount",
                        gqlRootFieldName: "patchAwsIamUserBasedCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.patchDb2Database,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "PatchDatabase",
                        gqlRootFieldName: "patchDb2Database"
                    )
                },
                {
                    GqlRootFieldName.patchDb2Instance,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "PatchInstance",
                        gqlRootFieldName: "patchDb2Instance"
                    )
                },
                {
                    GqlRootFieldName.patchMongoSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "PatchSource",
                        gqlRootFieldName: "patchMongoSource"
                    )
                },
                {
                    GqlRootFieldName.patchNutanixMountV1,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "PatchMountV1",
                        gqlRootFieldName: "patchNutanixMountV1"
                    )
                },
                {
                    GqlRootFieldName.pauseSla,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "Pause",
                        gqlRootFieldName: "pauseSla"
                    )
                },
                {
                    GqlRootFieldName.prepareAwsCloudAccountDeletion,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "PrepareCloudAccountDeletion",
                        gqlRootFieldName: "prepareAwsCloudAccountDeletion"
                    )
                },
                {
                    GqlRootFieldName.prepareFeatureUpdateForAwsCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "PrepareFeatureUpdateForCloudAccount",
                        gqlRootFieldName: "prepareFeatureUpdateForAwsCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.rdsInstanceDetailsFromAws,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "RdsInstanceDetails",
                        gqlRootFieldName: "rdsInstanceDetailsFromAws"
                    )
                },
                {
                    GqlRootFieldName.recoverCassandraSource,
                    new RscOp(
                        cmdletName: "New-RscMutationCassandra",
                        cmdletSwitchName: "RecoverSource",
                        gqlRootFieldName: "recoverCassandraSource"
                    )
                },
                {
                    GqlRootFieldName.recoverCloudCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "RecoverCloud",
                        gqlRootFieldName: "recoverCloudCluster"
                    )
                },
                {
                    GqlRootFieldName.recoverMongoSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "RecoverSource",
                        gqlRootFieldName: "recoverMongoSource"
                    )
                },
                {
                    GqlRootFieldName.recoverMongodbSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "RecoverdbSource",
                        gqlRootFieldName: "recoverMongodbSource"
                    )
                },
                {
                    GqlRootFieldName.refreshDb2Database,
                    new RscOp(
                        cmdletName: "New-RscMutationDb2",
                        cmdletSwitchName: "RefreshDatabase",
                        gqlRootFieldName: "refreshDb2Database"
                    )
                },
                {
                    GqlRootFieldName.refreshHypervScvmm,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "RefreshScvmm",
                        gqlRootFieldName: "refreshHypervScvmm"
                    )
                },
                {
                    GqlRootFieldName.refreshHypervServer,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "RefreshServer",
                        gqlRootFieldName: "refreshHypervServer"
                    )
                },
                {
                    GqlRootFieldName.refreshK8sCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "RefreshK8s",
                        gqlRootFieldName: "refreshK8sCluster"
                    )
                },
                {
                    GqlRootFieldName.refreshNutanixCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "RefreshCluster",
                        gqlRootFieldName: "refreshNutanixCluster"
                    )
                },
                {
                    GqlRootFieldName.refreshNutanixPrismCentral,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "RefreshPrismCentral",
                        gqlRootFieldName: "refreshNutanixPrismCentral"
                    )
                },
                {
                    GqlRootFieldName.refreshO365Org,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "RefreshOrg",
                        gqlRootFieldName: "refreshO365Org"
                    )
                },
                {
                    GqlRootFieldName.refreshOracleDatabase,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "RefreshDatabase",
                        gqlRootFieldName: "refreshOracleDatabase"
                    )
                },
                {
                    GqlRootFieldName.refreshVsphereVcenter,
                    new RscOp(
                        cmdletName: "New-RscMutationVcenter",
                        cmdletSwitchName: "Refresh",
                        gqlRootFieldName: "refreshVsphereVcenter"
                    )
                },
                {
                    GqlRootFieldName.registerAgentHypervVirtualMachine,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "RegisterAgentVirtualMachine",
                        gqlRootFieldName: "registerAgentHypervVirtualMachine"
                    )
                },
                {
                    GqlRootFieldName.registerAgentNutanixVm,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "RegisterAgentVm",
                        gqlRootFieldName: "registerAgentNutanixVm"
                    )
                },
                {
                    GqlRootFieldName.registerAwsFeatureArtifacts,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "RegisterFeatureArtifacts",
                        gqlRootFieldName: "registerAwsFeatureArtifacts"
                    )
                },
                {
                    GqlRootFieldName.registerCloudCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "RegisterCloud",
                        gqlRootFieldName: "registerCloudCluster"
                    )
                },
                {
                    GqlRootFieldName.registerHypervScvmm,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "RegisterScvmm",
                        gqlRootFieldName: "registerHypervScvmm"
                    )
                },
                {
                    GqlRootFieldName.removeCdmCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "RemoveCdm",
                        gqlRootFieldName: "removeCdmCluster"
                    )
                },
                {
                    GqlRootFieldName.removeLdapIntegration,
                    new RscOp(
                        cmdletName: "New-RscMutationLdap",
                        cmdletSwitchName: "RemoveIntegration",
                        gqlRootFieldName: "removeLdapIntegration"
                    )
                },
                {
                    GqlRootFieldName.resizeManagedVolume,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "Resize",
                        gqlRootFieldName: "resizeManagedVolume"
                    )
                },
                {
                    GqlRootFieldName.restoreAzureAdObjectsWithPasswords,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "RestoreAdObjectsWithPasswords",
                        gqlRootFieldName: "restoreAzureAdObjectsWithPasswords"
                    )
                },
                {
                    GqlRootFieldName.restoreFilesNutanixSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "RestoreFilesSnapshot",
                        gqlRootFieldName: "restoreFilesNutanixSnapshot"
                    )
                },
                {
                    GqlRootFieldName.restoreHypervVirtualMachineSnapshotFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "RestoreVirtualMachineSnapshotFiles",
                        gqlRootFieldName: "restoreHypervVirtualMachineSnapshotFiles"
                    )
                },
                {
                    GqlRootFieldName.restoreMssqlDatabase,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "RestoreDatabase",
                        gqlRootFieldName: "restoreMssqlDatabase"
                    )
                },
                {
                    GqlRootFieldName.restoreO365Mailbox,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "RestoreMailbox",
                        gqlRootFieldName: "restoreO365Mailbox"
                    )
                },
                {
                    GqlRootFieldName.restoreO365Snappable,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "RestoreSnappable",
                        gqlRootFieldName: "restoreO365Snappable"
                    )
                },
                {
                    GqlRootFieldName.restoreO365TeamsConversations,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "RestoreTeamsConversations",
                        gqlRootFieldName: "restoreO365TeamsConversations"
                    )
                },
                {
                    GqlRootFieldName.restoreO365TeamsFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "RestoreTeamsFiles",
                        gqlRootFieldName: "restoreO365TeamsFiles"
                    )
                },
                {
                    GqlRootFieldName.restoreOracleLogs,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "RestoreLogs",
                        gqlRootFieldName: "restoreOracleLogs"
                    )
                },
                {
                    GqlRootFieldName.retryAddMongoSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "RetryAddSource",
                        gqlRootFieldName: "retryAddMongoSource"
                    )
                },
                {
                    GqlRootFieldName.searchAzureAdSnapshot,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "SearchAdSnapshot",
                        gqlRootFieldName: "searchAzureAdSnapshot"
                    )
                },
                {
                    GqlRootFieldName.searchNutanixVm,
                    new RscOp(
                        cmdletName: "New-RscQueryNutanix",
                        cmdletSwitchName: "SearchVm",
                        gqlRootFieldName: "searchNutanixVm"
                    )
                },
                {
                    GqlRootFieldName.setAzureCloudAccountCustomerAppCredentials,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "SetCloudAccountCustomerAppCredentials",
                        gqlRootFieldName: "setAzureCloudAccountCustomerAppCredentials"
                    )
                },
                {
                    GqlRootFieldName.setLdapMfaSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationLdap",
                        cmdletSwitchName: "SetMfaSetting",
                        gqlRootFieldName: "setLdapMfaSetting"
                    )
                },
                {
                    GqlRootFieldName.setO365ServiceAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "SetServiceAccount",
                        gqlRootFieldName: "setO365ServiceAccount"
                    )
                },
                {
                    GqlRootFieldName.setupAzureO365Exocompute,
                    new RscOp(
                        cmdletName: "New-RscMutationAzureO365",
                        cmdletSwitchName: "SetupExocompute",
                        gqlRootFieldName: "setupAzureO365Exocompute"
                    )
                },
                {
                    GqlRootFieldName.slaAuditDetail,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "AuditDetail",
                        gqlRootFieldName: "slaAuditDetail"
                    )
                },
                {
                    GqlRootFieldName.slaConflictObjects,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "ConflictObjects",
                        gqlRootFieldName: "slaConflictObjects"
                    )
                },
                {
                    GqlRootFieldName.slaDomain,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "Domain",
                        gqlRootFieldName: "slaDomain"
                    )
                },
                {
                    GqlRootFieldName.slaDomains,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "Domains",
                        gqlRootFieldName: "slaDomains"
                    )
                },
                {
                    GqlRootFieldName.slaManagedVolume,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "ManagedVolume",
                        gqlRootFieldName: "slaManagedVolume"
                    )
                },
                {
                    GqlRootFieldName.slaManagedVolumes,
                    new RscOp(
                        cmdletName: "New-RscQuerySla",
                        cmdletSwitchName: "ManagedVolumes",
                        gqlRootFieldName: "slaManagedVolumes"
                    )
                },
                {
                    GqlRootFieldName.startAwsExocomputeDisableJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartExocomputeDisableJob",
                        gqlRootFieldName: "startAwsExocomputeDisableJob"
                    )
                },
                {
                    GqlRootFieldName.startAwsNativeAccountDisableJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartNativeAccountDisableJob",
                        gqlRootFieldName: "startAwsNativeAccountDisableJob"
                    )
                },
                {
                    GqlRootFieldName.startAwsNativeEc2InstanceSnapshotsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartNativeEc2InstanceSnapshotsJob",
                        gqlRootFieldName: "startAwsNativeEc2InstanceSnapshotsJob"
                    )
                },
                {
                    GqlRootFieldName.startAwsNativeRdsInstanceSnapshotsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartNativeRdsInstanceSnapshotsJob",
                        gqlRootFieldName: "startAwsNativeRdsInstanceSnapshotsJob"
                    )
                },
                {
                    GqlRootFieldName.startAzureAdAppSetup,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartAdAppSetup",
                        gqlRootFieldName: "startAzureAdAppSetup"
                    )
                },
                {
                    GqlRootFieldName.startAzureAdAppUpdate,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartAdAppUpdate",
                        gqlRootFieldName: "startAzureAdAppUpdate"
                    )
                },
                {
                    GqlRootFieldName.startAzureCloudAccountOauth,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartCloudAccountOauth",
                        gqlRootFieldName: "startAzureCloudAccountOauth"
                    )
                },
                {
                    GqlRootFieldName.startCreateAwsNativeEbsVolumeSnapshotsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartCreateNativeEbsVolumeSnapshotsJob",
                        gqlRootFieldName: "startCreateAwsNativeEbsVolumeSnapshotsJob"
                    )
                },
                {
                    GqlRootFieldName.startCreateAzureNativeManagedDiskSnapshotsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartCreateNativeManagedDiskSnapshotsJob",
                        gqlRootFieldName: "startCreateAzureNativeManagedDiskSnapshotsJob"
                    )
                },
                {
                    GqlRootFieldName.startCreateAzureNativeVirtualMachineSnapshotsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartCreateNativeVirtualMachineSnapshotsJob",
                        gqlRootFieldName: "startCreateAzureNativeVirtualMachineSnapshotsJob"
                    )
                },
                {
                    GqlRootFieldName.startDisableAzureCloudAccountJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartDisableCloudAccountJob",
                        gqlRootFieldName: "startDisableAzureCloudAccountJob"
                    )
                },
                {
                    GqlRootFieldName.startDisableAzureNativeSubscriptionProtectionJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartDisableNativeSubscriptionProtectionJob",
                        gqlRootFieldName: "startDisableAzureNativeSubscriptionProtectionJob"
                    )
                },
                {
                    GqlRootFieldName.startExportAwsNativeEbsVolumeSnapshotJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartExportNativeEbsVolumeSnapshotJob",
                        gqlRootFieldName: "startExportAwsNativeEbsVolumeSnapshotJob"
                    )
                },
                {
                    GqlRootFieldName.startExportAzureNativeManagedDiskJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartExportNativeManagedDiskJob",
                        gqlRootFieldName: "startExportAzureNativeManagedDiskJob"
                    )
                },
                {
                    GqlRootFieldName.startExportAzureNativeVirtualMachineJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartExportNativeVirtualMachineJob",
                        gqlRootFieldName: "startExportAzureNativeVirtualMachineJob"
                    )
                },
                {
                    GqlRootFieldName.startExportAzureSqlDatabaseDbJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartExportSqlDatabaseDbJob",
                        gqlRootFieldName: "startExportAzureSqlDatabaseDbJob"
                    )
                },
                {
                    GqlRootFieldName.startExportAzureSqlManagedInstanceDbJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartExportSqlManagedInstanceDbJob",
                        gqlRootFieldName: "startExportAzureSqlManagedInstanceDbJob"
                    )
                },
                {
                    GqlRootFieldName.startRefreshAwsNativeAccountsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartRefreshNativeAccountsJob",
                        gqlRootFieldName: "startRefreshAwsNativeAccountsJob"
                    )
                },
                {
                    GqlRootFieldName.startRefreshAzureNativeSubscriptionsJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartRefreshNativeSubscriptionsJob",
                        gqlRootFieldName: "startRefreshAzureNativeSubscriptionsJob"
                    )
                },
                {
                    GqlRootFieldName.startRestoreAwsNativeEc2InstanceSnapshotJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "StartRestoreNativeEc2InstanceSnapshotJob",
                        gqlRootFieldName: "startRestoreAwsNativeEc2InstanceSnapshotJob"
                    )
                },
                {
                    GqlRootFieldName.startRestoreAzureNativeVirtualMachineJob,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "StartRestoreNativeVirtualMachineJob",
                        gqlRootFieldName: "startRestoreAzureNativeVirtualMachineJob"
                    )
                },
                {
                    GqlRootFieldName.takeManagedVolumeOnDemandSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "TakeOnDemandSnapshot",
                        gqlRootFieldName: "takeManagedVolumeOnDemandSnapshot"
                    )
                },
                {
                    GqlRootFieldName.takeMssqlLogBackup,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "TakeLogBackup",
                        gqlRootFieldName: "takeMssqlLogBackup"
                    )
                },
                {
                    GqlRootFieldName.takeOnDemandOracleDatabaseSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "TakeOnDemandDatabaseSnapshot",
                        gqlRootFieldName: "takeOnDemandOracleDatabaseSnapshot"
                    )
                },
                {
                    GqlRootFieldName.takeOnDemandOracleLogSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "TakeOnDemandLogSnapshot",
                        gqlRootFieldName: "takeOnDemandOracleLogSnapshot"
                    )
                },
                {
                    GqlRootFieldName.uniqueHypervServersCount,
                    new RscOp(
                        cmdletName: "New-RscQueryHyperv",
                        cmdletSwitchName: "UniqueServersCount",
                        gqlRootFieldName: "uniqueHypervServersCount"
                    )
                },
                {
                    GqlRootFieldName.unmapAzureCloudAccountExocomputeSubscription,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UnmapCloudAccountExocomputeSubscription",
                        gqlRootFieldName: "unmapAzureCloudAccountExocomputeSubscription"
                    )
                },
                {
                    GqlRootFieldName.unmapAzurePersistentStorageSubscription,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UnmapPersistentStorageSubscription",
                        gqlRootFieldName: "unmapAzurePersistentStorageSubscription"
                    )
                },
                {
                    GqlRootFieldName.updateAutomaticAwsTargetMapping,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateAutomaticTargetMapping",
                        gqlRootFieldName: "updateAutomaticAwsTargetMapping"
                    )
                },
                {
                    GqlRootFieldName.updateAutomaticAzureTargetMapping,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateAutomaticTargetMapping",
                        gqlRootFieldName: "updateAutomaticAzureTargetMapping"
                    )
                },
                {
                    GqlRootFieldName.updateAwsAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateAccount",
                        gqlRootFieldName: "updateAwsAccount"
                    )
                },
                {
                    GqlRootFieldName.updateAwsCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateCloudAccount",
                        gqlRootFieldName: "updateAwsCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.updateAwsCloudAccountFeature,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateCloudAccountFeature",
                        gqlRootFieldName: "updateAwsCloudAccountFeature"
                    )
                },
                {
                    GqlRootFieldName.updateAwsComputeSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateComputeSetting",
                        gqlRootFieldName: "updateAwsComputeSetting"
                    )
                },
                {
                    GqlRootFieldName.updateAwsExocomputeConfigs,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateExocomputeConfigs",
                        gqlRootFieldName: "updateAwsExocomputeConfigs"
                    )
                },
                {
                    GqlRootFieldName.updateAwsTarget,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateTarget",
                        gqlRootFieldName: "updateAwsTarget"
                    )
                },
                {
                    GqlRootFieldName.updateAzureAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateAccount",
                        gqlRootFieldName: "updateAzureAccount"
                    )
                },
                {
                    GqlRootFieldName.updateAzureCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateCloudAccount",
                        gqlRootFieldName: "updateAzureCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.updateAzureTarget,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateTarget",
                        gqlRootFieldName: "updateAzureTarget"
                    )
                },
                {
                    GqlRootFieldName.updateCassandraSource,
                    new RscOp(
                        cmdletName: "New-RscMutationCassandra",
                        cmdletSwitchName: "UpdateSource",
                        gqlRootFieldName: "updateCassandraSource"
                    )
                },
                {
                    GqlRootFieldName.updateCloudNativeAwsStorageSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpdateCloudNativeStorageSetting",
                        gqlRootFieldName: "updateCloudNativeAwsStorageSetting"
                    )
                },
                {
                    GqlRootFieldName.updateCloudNativeAzureStorageSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateCloudNativeStorageSetting",
                        gqlRootFieldName: "updateCloudNativeAzureStorageSetting"
                    )
                },
                {
                    GqlRootFieldName.updateCloudNativeRcvAzureStorageSetting,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateCloudNativeRcvStorageSetting",
                        gqlRootFieldName: "updateCloudNativeRcvAzureStorageSetting"
                    )
                },
                {
                    GqlRootFieldName.updateCustomerAppPermissionForAzureSql,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpdateCustomerAppPermissionForSql",
                        gqlRootFieldName: "updateCustomerAppPermissionForAzureSql"
                    )
                },
                {
                    GqlRootFieldName.updateDatabaseLogReportingPropertiesForCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "UpdateDatabaseLogReportingProperties",
                        gqlRootFieldName: "updateDatabaseLogReportingPropertiesForCluster"
                    )
                },
                {
                    GqlRootFieldName.updateFailoverCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationCluster",
                        cmdletSwitchName: "UpdateFailover",
                        gqlRootFieldName: "updateFailoverCluster"
                    )
                },
                {
                    GqlRootFieldName.updateGlobalSla,
                    new RscOp(
                        cmdletName: "New-RscMutationSla",
                        cmdletSwitchName: "UpdateGlobal",
                        gqlRootFieldName: "updateGlobalSla"
                    )
                },
                {
                    GqlRootFieldName.updateHypervVirtualMachine,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "UpdateVirtualMachine",
                        gqlRootFieldName: "updateHypervVirtualMachine"
                    )
                },
                {
                    GqlRootFieldName.updateHypervVirtualMachineSnapshotMount,
                    new RscOp(
                        cmdletName: "New-RscMutationHyperv",
                        cmdletSwitchName: "UpdateVirtualMachineSnapshotMount",
                        gqlRootFieldName: "updateHypervVirtualMachineSnapshotMount"
                    )
                },
                {
                    GqlRootFieldName.updateLdapIntegration,
                    new RscOp(
                        cmdletName: "New-RscMutationLdap",
                        cmdletSwitchName: "UpdateIntegration",
                        gqlRootFieldName: "updateLdapIntegration"
                    )
                },
                {
                    GqlRootFieldName.updateManagedVolume,
                    new RscOp(
                        cmdletName: "New-RscMutationManagedVolume",
                        cmdletSwitchName: "Update",
                        gqlRootFieldName: "updateManagedVolume"
                    )
                },
                {
                    GqlRootFieldName.updateMongodbSource,
                    new RscOp(
                        cmdletName: "New-RscMutationMongo",
                        cmdletSwitchName: "UpdatedbSource",
                        gqlRootFieldName: "updateMongodbSource"
                    )
                },
                {
                    GqlRootFieldName.updateMssqlDefaultProperties,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "UpdateDefaultProperties",
                        gqlRootFieldName: "updateMssqlDefaultProperties"
                    )
                },
                {
                    GqlRootFieldName.updateMssqlLogShippingConfiguration,
                    new RscOp(
                        cmdletName: "New-RscMutationMssql",
                        cmdletSwitchName: "UpdateLogShippingConfiguration",
                        gqlRootFieldName: "updateMssqlLogShippingConfiguration"
                    )
                },
                {
                    GqlRootFieldName.updateNutanixCluster,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "UpdateCluster",
                        gqlRootFieldName: "updateNutanixCluster"
                    )
                },
                {
                    GqlRootFieldName.updateNutanixPrismCentral,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "UpdatePrismCentral",
                        gqlRootFieldName: "updateNutanixPrismCentral"
                    )
                },
                {
                    GqlRootFieldName.updateNutanixVm,
                    new RscOp(
                        cmdletName: "New-RscMutationNutanix",
                        cmdletSwitchName: "UpdateVm",
                        gqlRootFieldName: "updateNutanixVm"
                    )
                },
                {
                    GqlRootFieldName.updateO365AppAuthStatus,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "UpdateAppAuthStatus",
                        gqlRootFieldName: "updateO365AppAuthStatus"
                    )
                },
                {
                    GqlRootFieldName.updateO365AppPermissions,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "UpdateAppPermissions",
                        gqlRootFieldName: "updateO365AppPermissions"
                    )
                },
                {
                    GqlRootFieldName.updateO365OrgCustomName,
                    new RscOp(
                        cmdletName: "New-RscMutationO365",
                        cmdletSwitchName: "UpdateOrgCustomName",
                        gqlRootFieldName: "updateO365OrgCustomName"
                    )
                },
                {
                    GqlRootFieldName.updateOracleDataGuardGroup,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "UpdateDataGuardGroup",
                        gqlRootFieldName: "updateOracleDataGuardGroup"
                    )
                },
                {
                    GqlRootFieldName.updateVcenter,
                    new RscOp(
                        cmdletName: "New-RscMutationVcenter",
                        cmdletSwitchName: "Update",
                        gqlRootFieldName: "updateVcenter"
                    )
                },
                {
                    GqlRootFieldName.updateVcenterHotAddBandwidth,
                    new RscOp(
                        cmdletName: "New-RscMutationVcenter",
                        cmdletSwitchName: "UpdateHotAddBandwidth",
                        gqlRootFieldName: "updateVcenterHotAddBandwidth"
                    )
                },
                {
                    GqlRootFieldName.updateVcenterHotAddNetwork,
                    new RscOp(
                        cmdletName: "New-RscMutationVcenter",
                        cmdletSwitchName: "UpdateHotAddNetwork",
                        gqlRootFieldName: "updateVcenterHotAddNetwork"
                    )
                },
                {
                    GqlRootFieldName.updateVsphereAdvancedTag,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "UpdateAdvancedTag",
                        gqlRootFieldName: "updateVsphereAdvancedTag"
                    )
                },
                {
                    GqlRootFieldName.updateVsphereVm,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "Update",
                        gqlRootFieldName: "updateVsphereVm"
                    )
                },
                {
                    GqlRootFieldName.upgradeAwsCloudAccountFeaturesWithoutCft,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpgradeCloudAccountFeaturesWithoutCft",
                        gqlRootFieldName: "upgradeAwsCloudAccountFeaturesWithoutCft"
                    )
                },
                {
                    GqlRootFieldName.upgradeAwsIamUserBasedCloudAccountPermissions,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "UpgradeIamUserBasedCloudAccountPermissions",
                        gqlRootFieldName: "upgradeAwsIamUserBasedCloudAccountPermissions"
                    )
                },
                {
                    GqlRootFieldName.upgradeAzureCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpgradeCloudAccount",
                        gqlRootFieldName: "upgradeAzureCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.upgradeAzureCloudAccountPermissionsWithoutOauth,
                    new RscOp(
                        cmdletName: "New-RscMutationAzure",
                        cmdletSwitchName: "UpgradeCloudAccountPermissionsWithoutOauth",
                        gqlRootFieldName: "upgradeAzureCloudAccountPermissionsWithoutOauth"
                    )
                },
                {
                    GqlRootFieldName.vCenterAdvancedTagPreview,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "AdvancedTagPreview",
                        gqlRootFieldName: "vCenterAdvancedTagPreview"
                    )
                },
                {
                    GqlRootFieldName.vCenterHotAddBandwidth,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "HotAddBandwidth",
                        gqlRootFieldName: "vCenterHotAddBandwidth"
                    )
                },
                {
                    GqlRootFieldName.vCenterHotAddNetwork,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "HotAddNetwork",
                        gqlRootFieldName: "vCenterHotAddNetwork"
                    )
                },
                {
                    GqlRootFieldName.vCenterNetworks,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "Networks",
                        gqlRootFieldName: "vCenterNetworks"
                    )
                },
                {
                    GqlRootFieldName.vCenterNumProxiesNeeded,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "NumProxiesNeeded",
                        gqlRootFieldName: "vCenterNumProxiesNeeded"
                    )
                },
                {
                    GqlRootFieldName.vCenterPreAddInfo,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "PreAddInfo",
                        gqlRootFieldName: "vCenterPreAddInfo"
                    )
                },
                {
                    GqlRootFieldName.vSphereComputeCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "ComputeCluster",
                        gqlRootFieldName: "vSphereComputeCluster"
                    )
                },
                {
                    GqlRootFieldName.vSphereComputeClusters,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "ComputeClusters",
                        gqlRootFieldName: "vSphereComputeClusters"
                    )
                },
                {
                    GqlRootFieldName.vSphereDatacenter,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Datacenter",
                        gqlRootFieldName: "vSphereDatacenter"
                    )
                },
                {
                    GqlRootFieldName.vSphereDatastore,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Datastore",
                        gqlRootFieldName: "vSphereDatastore"
                    )
                },
                {
                    GqlRootFieldName.vSphereDatastoreCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "DatastoreCluster",
                        gqlRootFieldName: "vSphereDatastoreCluster"
                    )
                },
                {
                    GqlRootFieldName.vSphereDatastoreClusters,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "DatastoreClusters",
                        gqlRootFieldName: "vSphereDatastoreClusters"
                    )
                },
                {
                    GqlRootFieldName.vSphereDatastoreConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "DatastoreList",
                        gqlRootFieldName: "vSphereDatastoreConnection"
                    )
                },
                {
                    GqlRootFieldName.vSphereFolder,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Folder",
                        gqlRootFieldName: "vSphereFolder"
                    )
                },
                {
                    GqlRootFieldName.vSphereFolders,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Folders",
                        gqlRootFieldName: "vSphereFolders"
                    )
                },
                {
                    GqlRootFieldName.vSphereHost,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Host",
                        gqlRootFieldName: "vSphereHost"
                    )
                },
                {
                    GqlRootFieldName.vSphereHostConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "HostList",
                        gqlRootFieldName: "vSphereHostConnection"
                    )
                },
                {
                    GqlRootFieldName.vSphereHostDetails,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "HostDetails",
                        gqlRootFieldName: "vSphereHostDetails"
                    )
                },
                {
                    GqlRootFieldName.vSphereHostsByFids,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "HostsByFids",
                        gqlRootFieldName: "vSphereHostsByFids"
                    )
                },
                {
                    GqlRootFieldName.vSphereLiveMounts,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "LiveMounts",
                        gqlRootFieldName: "vSphereLiveMounts"
                    )
                },
                {
                    GqlRootFieldName.vSphereMount,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Mount",
                        gqlRootFieldName: "vSphereMount"
                    )
                },
                {
                    GqlRootFieldName.vSphereMountConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "MountList",
                        gqlRootFieldName: "vSphereMountConnection"
                    )
                },
                {
                    GqlRootFieldName.vSphereNetwork,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Network",
                        gqlRootFieldName: "vSphereNetwork"
                    )
                },
                {
                    GqlRootFieldName.vSphereResourcePool,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "ResourcePool",
                        gqlRootFieldName: "vSphereResourcePool"
                    )
                },
                {
                    GqlRootFieldName.vSphereRootRecoveryHierarchy,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "RootRecoveryHierarchy",
                        gqlRootFieldName: "vSphereRootRecoveryHierarchy"
                    )
                },
                {
                    GqlRootFieldName.vSphereTag,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "Tag",
                        gqlRootFieldName: "vSphereTag"
                    )
                },
                {
                    GqlRootFieldName.vSphereTagCategory,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "TagCategory",
                        gqlRootFieldName: "vSphereTagCategory"
                    )
                },
                {
                    GqlRootFieldName.vSphereTopLevelDescendantsConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "TopLevelDescendantsList",
                        gqlRootFieldName: "vSphereTopLevelDescendantsConnection"
                    )
                },
                {
                    GqlRootFieldName.vSphereVCenter,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "Vcenter",
                        gqlRootFieldName: "vSphereVCenter"
                    )
                },
                {
                    GqlRootFieldName.vSphereVCenterConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryVcenter",
                        cmdletSwitchName: "List",
                        gqlRootFieldName: "vSphereVCenterConnection"
                    )
                },
                {
                    GqlRootFieldName.vSphereVMAsyncRequestStatus,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphereVm",
                        cmdletSwitchName: "AsyncRequestStatus",
                        gqlRootFieldName: "vSphereVMAsyncRequestStatus"
                    )
                },
                {
                    GqlRootFieldName.vSphereVmNew,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphereVm",
                        cmdletSwitchName: "New",
                        gqlRootFieldName: "vSphereVmNew"
                    )
                },
                {
                    GqlRootFieldName.vSphereVmNewConnection,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphereVm",
                        cmdletSwitchName: "NewList",
                        gqlRootFieldName: "vSphereVmNewConnection"
                    )
                },
                {
                    GqlRootFieldName.validateAndCreateAwsCloudAccount,
                    new RscOp(
                        cmdletName: "New-RscMutationAws",
                        cmdletSwitchName: "ValidateAndCreateCloudAccount",
                        gqlRootFieldName: "validateAndCreateAwsCloudAccount"
                    )
                },
                {
                    GqlRootFieldName.validateAwsNativeRdsClusterNameForExport,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "ValidateNativeRdsClusterNameForExport",
                        gqlRootFieldName: "validateAwsNativeRdsClusterNameForExport"
                    )
                },
                {
                    GqlRootFieldName.validateAwsNativeRdsInstanceNameForExport,
                    new RscOp(
                        cmdletName: "New-RscQueryAws",
                        cmdletSwitchName: "ValidateNativeRdsInstanceNameForExport",
                        gqlRootFieldName: "validateAwsNativeRdsInstanceNameForExport"
                    )
                },
                {
                    GqlRootFieldName.validateAzureCloudAccountExocomputeConfigurations,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "ValidateCloudAccountExocomputeConfigurations",
                        gqlRootFieldName: "validateAzureCloudAccountExocomputeConfigurations"
                    )
                },
                {
                    GqlRootFieldName.validateAzureNativeSqlDatabaseDbNameForExport,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "ValidateNativeSqlDatabaseDbNameForExport",
                        gqlRootFieldName: "validateAzureNativeSqlDatabaseDbNameForExport"
                    )
                },
                {
                    GqlRootFieldName.validateAzureNativeSqlManagedInstanceDbNameForExport,
                    new RscOp(
                        cmdletName: "New-RscQueryAzure",
                        cmdletSwitchName: "ValidateNativeSqlManagedInstanceDbNameForExport",
                        gqlRootFieldName: "validateAzureNativeSqlManagedInstanceDbNameForExport"
                    )
                },
                {
                    GqlRootFieldName.validateOracleAcoFile,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "ValidateAcoFile",
                        gqlRootFieldName: "validateOracleAcoFile"
                    )
                },
                {
                    GqlRootFieldName.validateOracleDatabaseBackups,
                    new RscOp(
                        cmdletName: "New-RscMutationOracle",
                        cmdletSwitchName: "ValidateDatabaseBackups",
                        gqlRootFieldName: "validateOracleDatabaseBackups"
                    )
                },
                {
                    GqlRootFieldName.verifySlaWithReplicationToCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "VerifySlaWithReplicationTo",
                        gqlRootFieldName: "verifySlaWithReplicationToCluster"
                    )
                },
                {
                    GqlRootFieldName.vsphereBulkOnDemandSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "BulkOnDemandSnapshot",
                        gqlRootFieldName: "vsphereBulkOnDemandSnapshot"
                    )
                },
                {
                    GqlRootFieldName.vsphereDeleteVcenter,
                    new RscOp(
                        cmdletName: "New-RscMutationVcenter",
                        cmdletSwitchName: "Delete",
                        gqlRootFieldName: "vsphereDeleteVcenter"
                    )
                },
                {
                    GqlRootFieldName.vsphereExcludeVmDisks,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "ExcludeVmDisks",
                        gqlRootFieldName: "vsphereExcludeVmDisks"
                    )
                },
                {
                    GqlRootFieldName.vsphereExportSnapshotToStandaloneHostV2,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "ExportSnapshotToStandaloneHostV2",
                        gqlRootFieldName: "vsphereExportSnapshotToStandaloneHostV2"
                    )
                },
                {
                    GqlRootFieldName.vsphereOnDemandSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphere",
                        cmdletSwitchName: "OnDemandSnapshot",
                        gqlRootFieldName: "vsphereOnDemandSnapshot"
                    )
                },
                {
                    GqlRootFieldName.vsphereVMMissedRecoverableRange,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphereVm",
                        cmdletSwitchName: "MissedRecoverableRange",
                        gqlRootFieldName: "vsphereVMMissedRecoverableRange"
                    )
                },
                {
                    GqlRootFieldName.vsphereVMRecoverableRange,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphereVm",
                        cmdletSwitchName: "RecoverableRange",
                        gqlRootFieldName: "vsphereVMRecoverableRange"
                    )
                },
                {
                    GqlRootFieldName.vsphereVMRecoverableRangeInBatch,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphereVm",
                        cmdletSwitchName: "RecoverableRangeInBatch",
                        gqlRootFieldName: "vsphereVMRecoverableRangeInBatch"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmBatchExport,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "BatchExport",
                        gqlRootFieldName: "vsphereVmBatchExport"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmBatchExportV3,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "BatchExportV3",
                        gqlRootFieldName: "vsphereVmBatchExportV3"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmBatchInPlaceRecovery,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "BatchInPlaceRecovery",
                        gqlRootFieldName: "vsphereVmBatchInPlaceRecovery"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmDeleteSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "DeleteSnapshot",
                        gqlRootFieldName: "vsphereVmDeleteSnapshot"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmDownloadSnapshot,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "DownloadSnapshot",
                        gqlRootFieldName: "vsphereVmDownloadSnapshot"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmDownloadSnapshotFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "DownloadSnapshotFiles",
                        gqlRootFieldName: "vsphereVmDownloadSnapshotFiles"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmExportSnapshotV2,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "ExportSnapshotV2",
                        gqlRootFieldName: "vsphereVmExportSnapshotV2"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmExportSnapshotV3,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "ExportSnapshotV3",
                        gqlRootFieldName: "vsphereVmExportSnapshotV3"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmExportSnapshotWithDownloadFromCloud,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "ExportSnapshotWithDownloadFromCloud",
                        gqlRootFieldName: "vsphereVmExportSnapshotWithDownloadFromCloud"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmInitiateBatchInstantRecovery,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "InitiateBatchInstantRecovery",
                        gqlRootFieldName: "vsphereVmInitiateBatchInstantRecovery"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmInitiateBatchLiveMountV2,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "InitiateBatchLiveMountV2",
                        gqlRootFieldName: "vsphereVmInitiateBatchLiveMountV2"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmInitiateDiskMount,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "InitiateDiskMount",
                        gqlRootFieldName: "vsphereVmInitiateDiskMount"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmInitiateInPlaceRecovery,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "InitiateInPlaceRecovery",
                        gqlRootFieldName: "vsphereVmInitiateInPlaceRecovery"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmInitiateInstantRecoveryV2,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "InitiateInstantRecoveryV2",
                        gqlRootFieldName: "vsphereVmInitiateInstantRecoveryV2"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmInitiateLiveMountV2,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "InitiateLiveMountV2",
                        gqlRootFieldName: "vsphereVmInitiateLiveMountV2"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmListEsxiDatastores,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "ListEsxiDatastores",
                        gqlRootFieldName: "vsphereVmListEsxiDatastores"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmMountRelocate,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "MountRelocate",
                        gqlRootFieldName: "vsphereVmMountRelocate"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmMountRelocateV2,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "MountRelocateV2",
                        gqlRootFieldName: "vsphereVmMountRelocateV2"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmPowerOnOffLiveMount,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "PowerOnOffLiveMount",
                        gqlRootFieldName: "vsphereVmPowerOnOffLiveMount"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmRecoverFiles,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "RecoverFiles",
                        gqlRootFieldName: "vsphereVmRecoverFiles"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmRecoverFilesNew,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "RecoverFilesNew",
                        gqlRootFieldName: "vsphereVmRecoverFilesNew"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmRegisterAgent,
                    new RscOp(
                        cmdletName: "New-RscMutationVsphereVm",
                        cmdletSwitchName: "RegisterAgent",
                        gqlRootFieldName: "vsphereVmRegisterAgent"
                    )
                },
                {
                    GqlRootFieldName.vsphereVmwareCdpLiveInfo,
                    new RscOp(
                        cmdletName: "New-RscQueryVsphere",
                        cmdletSwitchName: "VmwareCdpLiveInfo",
                        gqlRootFieldName: "vsphereVmwareCdpLiveInfo"
                    )
                },
                {
                    GqlRootFieldName.windowsCluster,
                    new RscOp(
                        cmdletName: "New-RscQueryCluster",
                        cmdletSwitchName: "Windows",
                        gqlRootFieldName: "windowsCluster"
                    )
                },
            };
            if (lookupDict.TryGetValue(rootField, out var rscOp))
            {
                rscOp.GqlReturnTypeName = ReturnTypeLookupByGqlRootField(rootField.ToString());
                return rscOp;
            }
            return new RscOp(
                gqlRootFieldName: rootField.ToString()
            );
        }

        /// <summary>
        /// Given a RSC operation, return the corresponding GraphQL root field name.
        /// </summary>
        public static GqlRootFieldName GqlRootFieldNameLookupByRscOp(RscOp rscOp)
        {
            var lookupDict = new Dictionary<string, GqlRootFieldName> {
                {
                    "New-RscQueryAccount -Id",
                    GqlRootFieldName.accountId
                },
                {
                    "New-RscQueryAccount -Settings",
                    GqlRootFieldName.accountSettings
                },
                {
                    "New-RscQueryActivitySeries -ActivitySeries",
                    GqlRootFieldName.activitySeries
                },
                {
                    "New-RscQueryActivitySeries -List",
                    GqlRootFieldName.activitySeriesConnection
                },
                {
                    "New-RscMutationAws -AddAuthenticationServerBasedCloudAccount",
                    GqlRootFieldName.addAwsAuthenticationServerBasedCloudAccount
                },
                {
                    "New-RscMutationAws -AddIamUserBasedCloudAccount",
                    GqlRootFieldName.addAwsIamUserBasedCloudAccount
                },
                {
                    "New-RscMutationAzure -AddCloudAccount",
                    GqlRootFieldName.addAzureCloudAccount
                },
                {
                    "New-RscMutationAzure -AddCloudAccountExocomputeConfigurations",
                    GqlRootFieldName.addAzureCloudAccountExocomputeConfigurations
                },
                {
                    "New-RscMutationAzure -AddCloudAccountWithoutOauth",
                    GqlRootFieldName.addAzureCloudAccountWithoutOauth
                },
                {
                    "New-RscMutationDb2 -AddInstance",
                    GqlRootFieldName.addDb2Instance
                },
                {
                    "New-RscMutationManagedVolume -Add",
                    GqlRootFieldName.addManagedVolume
                },
                {
                    "New-RscMutationMongo -AddSource",
                    GqlRootFieldName.addMongoSource
                },
                {
                    "New-RscMutationCluster -AddNodesToCloud",
                    GqlRootFieldName.addNodesToCloudCluster
                },
                {
                    "New-RscMutationO365 -AddOrg",
                    GqlRootFieldName.addO365Org
                },
                {
                    "New-RscQueryAccount -Owners",
                    GqlRootFieldName.allAccountOwners
                },
                {
                    "New-RscQueryAccount -Products",
                    GqlRootFieldName.allAccountProducts
                },
                {
                    "New-RscQueryAccount -WithExocomputeMappings",
                    GqlRootFieldName.allAccountsWithExocomputeMappings
                },
                {
                    "New-RscQueryAws -AllAvailabilityZonesByRegion",
                    GqlRootFieldName.allAvailabilityZonesByRegionFromAws
                },
                {
                    "New-RscQueryAws -AllCdmVersions",
                    GqlRootFieldName.allAwsCdmVersions
                },
                {
                    "New-RscQueryAws -AllCloudAccountConfigs",
                    GqlRootFieldName.allAwsCloudAccountConfigs
                },
                {
                    "New-RscQueryAws -AllCloudAccountsWithFeatures",
                    GqlRootFieldName.allAwsCloudAccountsWithFeatures
                },
                {
                    "New-RscQueryAws -AllComputeSettings",
                    GqlRootFieldName.allAwsComputeSettings
                },
                {
                    "New-RscQueryAws -AllExocomputeConfigs",
                    GqlRootFieldName.allAwsExocomputeConfigs
                },
                {
                    "New-RscQueryAws -AllInstanceProfileNames",
                    GqlRootFieldName.allAwsInstanceProfileNames
                },
                {
                    "New-RscQueryAws -AllPermissionPolicies",
                    GqlRootFieldName.allAwsPermissionPolicies
                },
                {
                    "New-RscQueryAws -AllRegions",
                    GqlRootFieldName.allAwsRegions
                },
                {
                    "New-RscQueryAzure -AllArmTemplatesByFeature",
                    GqlRootFieldName.allAzureArmTemplatesByFeature
                },
                {
                    "New-RscQueryAzure -AllCdmVersions",
                    GqlRootFieldName.allAzureCdmVersions
                },
                {
                    "New-RscQueryAzure -AllCloudAccountMissingPermissions",
                    GqlRootFieldName.allAzureCloudAccountMissingPermissions
                },
                {
                    "New-RscQueryAzure -AllCloudAccountSubnetsByRegion",
                    GqlRootFieldName.allAzureCloudAccountSubnetsByRegion
                },
                {
                    "New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature",
                    GqlRootFieldName.allAzureCloudAccountSubscriptionsByFeature
                },
                {
                    "New-RscQueryAzure -AllCloudAccountTenants",
                    GqlRootFieldName.allAzureCloudAccountTenants
                },
                {
                    "New-RscQueryAzure -AllDiskEncryptionSetsByRegion",
                    GqlRootFieldName.allAzureDiskEncryptionSetsByRegion
                },
                {
                    "New-RscQueryAzure -AllEncryptionKeys",
                    GqlRootFieldName.allAzureEncryptionKeys
                },
                {
                    "New-RscQueryAzure -AllExocomputeConfigsInAccount",
                    GqlRootFieldName.allAzureExocomputeConfigsInAccount
                },
                {
                    "New-RscQueryAzure -AllKeyVaultsByRegion",
                    GqlRootFieldName.allAzureKeyVaultsByRegion
                },
                {
                    "New-RscQueryAzure -AllManagedIdentities",
                    GqlRootFieldName.allAzureManagedIdentities
                },
                {
                    "New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure",
                    GqlRootFieldName.allAzureNativeAvailabilitySetsByRegionFromAzure
                },
                {
                    "New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure",
                    GqlRootFieldName.allAzureNativeExportCompatibleDiskTypesByRegionFromAzure
                },
                {
                    "New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure",
                    GqlRootFieldName.allAzureNativeExportCompatibleVmSizesByRegionFromAzure
                },
                {
                    "New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist",
                    GqlRootFieldName.allAzureNativeResourceGroupsInfoIfExist
                },
                {
                    "New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure",
                    GqlRootFieldName.allAzureNativeSecurityGroupsByRegionFromAzure
                },
                {
                    "New-RscQueryAzure -AllNativeStorageAccountsFromAzure",
                    GqlRootFieldName.allAzureNativeStorageAccountsFromAzure
                },
                {
                    "New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure",
                    GqlRootFieldName.allAzureNativeSubnetsByRegionFromAzure
                },
                {
                    "New-RscQueryAzure -AllNativeVirtualMachineSizes",
                    GqlRootFieldName.allAzureNativeVirtualMachineSizes
                },
                {
                    "New-RscQueryAzure -AllNativeVirtualNetworks",
                    GqlRootFieldName.allAzureNativeVirtualNetworks
                },
                {
                    "New-RscQueryAzure -AllNsgs",
                    GqlRootFieldName.allAzureNsgs
                },
                {
                    "New-RscQueryAzure -AllRegions",
                    GqlRootFieldName.allAzureRegions
                },
                {
                    "New-RscQueryAzure -AllResourceGroups",
                    GqlRootFieldName.allAzureResourceGroups
                },
                {
                    "New-RscQueryAzure -AllSqlDatabaseServerElasticPools",
                    GqlRootFieldName.allAzureSqlDatabaseServerElasticPools
                },
                {
                    "New-RscQueryAzure -AllStorageAccounts",
                    GqlRootFieldName.allAzureStorageAccounts
                },
                {
                    "New-RscQueryAzure -AllSubnets",
                    GqlRootFieldName.allAzureSubnets
                },
                {
                    "New-RscQueryAzure -AllSubscriptionWithExocomputeMappings",
                    GqlRootFieldName.allAzureSubscriptionWithExocomputeMappings
                },
                {
                    "New-RscQueryAzure -AllVnets",
                    GqlRootFieldName.allAzureVnets
                },
                {
                    "New-RscQueryCluster -GlobalSlas",
                    GqlRootFieldName.allClusterGlobalSlas
                },
                {
                    "New-RscQueryCluster -ReplicationTargets",
                    GqlRootFieldName.allClusterReplicationTargets
                },
                {
                    "New-RscQueryCluster -WebCertsAndIpmis",
                    GqlRootFieldName.allClusterWebCertsAndIpmis
                },
                {
                    "New-RscQueryCluster -TotpAckStatus",
                    GqlRootFieldName.allClustersTotpAckStatus
                },
                {
                    "New-RscQueryCluster -Connected",
                    GqlRootFieldName.allConnectedClusters
                },
                {
                    "New-RscQueryAws -AllDbParameterGroupsByRegion",
                    GqlRootFieldName.allDbParameterGroupsByRegionFromAws
                },
                {
                    "New-RscQueryAws -AllDbSubnetGroupsByRegion",
                    GqlRootFieldName.allDbSubnetGroupsByRegionFromAws
                },
                {
                    "New-RscQueryAws -AllEc2KeyPairsByRegion",
                    GqlRootFieldName.allEc2KeyPairsByRegionFromAws
                },
                {
                    "New-RscQueryAzure -AllHostedRegions",
                    GqlRootFieldName.allHostedAzureRegions
                },
                {
                    "New-RscQueryAws -AllKmsEncryptionKeysByRegion",
                    GqlRootFieldName.allKmsEncryptionKeysByRegionFromAws
                },
                {
                    "New-RscQueryMssql -AllDatabaseRestoreFiles",
                    GqlRootFieldName.allMssqlDatabaseRestoreFiles
                },
                {
                    "New-RscQuerySla -AllNcdComplianceData",
                    GqlRootFieldName.allNcdSlaComplianceData
                },
                {
                    "New-RscQueryO365 -AllAdGroups",
                    GqlRootFieldName.allO365AdGroups
                },
                {
                    "New-RscQueryO365 -AllOrgStatuses",
                    GqlRootFieldName.allO365OrgStatuses
                },
                {
                    "New-RscQueryO365 -AllSubscriptionsAppTypeCounts",
                    GqlRootFieldName.allO365SubscriptionsAppTypeCounts
                },
                {
                    "New-RscQueryAws -AllOptionGroupsByRegion",
                    GqlRootFieldName.allOptionGroupsByRegionFromAws
                },
                {
                    "New-RscQueryAzure -AllResourceGroupsFrom",
                    GqlRootFieldName.allResourceGroupsFromAzure
                },
                {
                    "New-RscQueryAws -AllS3BucketsDetails",
                    GqlRootFieldName.allS3BucketsDetailsFromAws
                },
                {
                    "New-RscQueryAws -AllS3Buckets",
                    GqlRootFieldName.allS3BucketsFromAws
                },
                {
                    "New-RscQuerySla -AllSummariesByIds",
                    GqlRootFieldName.allSlaSummariesByIds
                },
                {
                    "New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses",
                    GqlRootFieldName.allSupportedAwsRdsDatabaseInstanceClasses
                },
                {
                    "New-RscQueryVcenter -HotAddProxy",
                    GqlRootFieldName.allVcenterHotAddProxyVms
                },
                {
                    "New-RscQueryAws -AllVpcsByRegion",
                    GqlRootFieldName.allVpcsByRegionFromAws
                },
                {
                    "New-RscQueryAws -AllVpcs",
                    GqlRootFieldName.allVpcsFromAws
                },
                {
                    "New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport",
                    GqlRootFieldName.amiTypeForAwsNativeArchivedSnapshotExport
                },
                {
                    "New-RscMutationCluster -ArchiveK8s",
                    GqlRootFieldName.archiveK8sCluster
                },
                {
                    "New-RscMutationMssql -AssignSlaDomainProperties",
                    GqlRootFieldName.assignMssqlSlaDomainProperties
                },
                {
                    "New-RscMutationMssql -AssignSlaDomainPropertiesAsync",
                    GqlRootFieldName.assignMssqlSlaDomainPropertiesAsync
                },
                {
                    "New-RscMutationSla -AssignRetentionToSnappables",
                    GqlRootFieldName.assignRetentionSLAToSnappables
                },
                {
                    "New-RscMutationSla -AssignRetentionToSnapshots",
                    GqlRootFieldName.assignRetentionSLAToSnapshots
                },
                {
                    "New-RscMutationSla -Assign",
                    GqlRootFieldName.assignSla
                },
                {
                    "New-RscMutationMongo -AssignSlaToDbCollection",
                    GqlRootFieldName.assignSlaToMongoDbCollection
                },
                {
                    "New-RscMutationSla -AssignsForSnappableHierarchies",
                    GqlRootFieldName.assignSlasForSnappableHierarchies
                },
                {
                    "New-RscQueryAws -ArtifactsToDelete",
                    GqlRootFieldName.awsArtifactsToDelete
                },
                {
                    "New-RscQueryAws -CloudAccountListSecurityGroups",
                    GqlRootFieldName.awsCloudAccountListSecurityGroups
                },
                {
                    "New-RscQueryAws -CloudAccountListSubnets",
                    GqlRootFieldName.awsCloudAccountListSubnets
                },
                {
                    "New-RscQueryAws -CloudAccountListVpcs",
                    GqlRootFieldName.awsCloudAccountListVpcs
                },
                {
                    "New-RscQueryAws -CloudAccountWithFeatures",
                    GqlRootFieldName.awsCloudAccountWithFeatures
                },
                {
                    "New-RscQueryAws -ComputeSettings",
                    GqlRootFieldName.awsComputeSettings
                },
                {
                    "New-RscQueryAws -NativeAccount",
                    GqlRootFieldName.awsNativeAccount
                },
                {
                    "New-RscQueryAws -NativeAccounts",
                    GqlRootFieldName.awsNativeAccounts
                },
                {
                    "New-RscQueryAws -NativeEbsVolume",
                    GqlRootFieldName.awsNativeEbsVolume
                },
                {
                    "New-RscQueryAws -NativeEbsVolumes",
                    GqlRootFieldName.awsNativeEbsVolumes
                },
                {
                    "New-RscQueryAws -NativeEbsVolumesByName",
                    GqlRootFieldName.awsNativeEbsVolumesByName
                },
                {
                    "New-RscQueryAws -NativeEc2Instance",
                    GqlRootFieldName.awsNativeEc2Instance
                },
                {
                    "New-RscQueryAws -NativeEc2Instances",
                    GqlRootFieldName.awsNativeEc2Instances
                },
                {
                    "New-RscQueryAws -NativeEc2InstancesByName",
                    GqlRootFieldName.awsNativeEc2InstancesByName
                },
                {
                    "New-RscQueryAws -NativeRdsExportDefaults",
                    GqlRootFieldName.awsNativeRdsExportDefaults
                },
                {
                    "New-RscQueryAws -NativeRdsInstance",
                    GqlRootFieldName.awsNativeRdsInstance
                },
                {
                    "New-RscQueryAws -NativeRdsInstances",
                    GqlRootFieldName.awsNativeRdsInstances
                },
                {
                    "New-RscQueryAws -NativeRdsPointInTimeRestoreWindow",
                    GqlRootFieldName.awsNativeRdsPointInTimeRestoreWindow
                },
                {
                    "New-RscQueryAws -NativeRoot",
                    GqlRootFieldName.awsNativeRoot
                },
                {
                    "New-RscQueryAws -NativeS3Bucket",
                    GqlRootFieldName.awsNativeS3Bucket
                },
                {
                    "New-RscQueryAws -TrustPolicy",
                    GqlRootFieldName.awsTrustPolicy
                },
                {
                    "New-RscQueryAzure -AdDirectories",
                    GqlRootFieldName.azureAdDirectories
                },
                {
                    "New-RscQueryAzure -AdDirectory",
                    GqlRootFieldName.azureAdDirectory
                },
                {
                    "New-RscQueryAzure -AdObjectsByType",
                    GqlRootFieldName.azureAdObjectsByType
                },
                {
                    "New-RscQueryAzure -CloudAccountPermissionConfig",
                    GqlRootFieldName.azureCloudAccountPermissionConfig
                },
                {
                    "New-RscQueryAzure -CloudAccountSubscriptionWithFeatures",
                    GqlRootFieldName.azureCloudAccountSubscriptionWithFeatures
                },
                {
                    "New-RscQueryAzure -CloudAccountTenant",
                    GqlRootFieldName.azureCloudAccountTenant
                },
                {
                    "New-RscQueryAzure -CloudAccountTenantWithExoConfigs",
                    GqlRootFieldName.azureCloudAccountTenantWithExoConfigs
                },
                {
                    "New-RscQueryAzure -NativeManagedDisk",
                    GqlRootFieldName.azureNativeManagedDisk
                },
                {
                    "New-RscQueryAzure -NativeManagedDisks",
                    GqlRootFieldName.azureNativeManagedDisks
                },
                {
                    "New-RscQueryAzure -NativeResourceGroup",
                    GqlRootFieldName.azureNativeResourceGroup
                },
                {
                    "New-RscQueryAzure -NativeResourceGroups",
                    GqlRootFieldName.azureNativeResourceGroups
                },
                {
                    "New-RscQueryAzure -NativeRoot",
                    GqlRootFieldName.azureNativeRoot
                },
                {
                    "New-RscQueryAzure -NativeSubscription",
                    GqlRootFieldName.azureNativeSubscription
                },
                {
                    "New-RscQueryAzure -NativeSubscriptions",
                    GqlRootFieldName.azureNativeSubscriptions
                },
                {
                    "New-RscQueryAzure -NativeVirtualMachine",
                    GqlRootFieldName.azureNativeVirtualMachine
                },
                {
                    "New-RscQueryAzure -NativeVirtualMachines",
                    GqlRootFieldName.azureNativeVirtualMachines
                },
                {
                    "New-RscQueryAzureO365 -CheckNSGOutboundRules",
                    GqlRootFieldName.azureO365CheckNSGOutboundRules
                },
                {
                    "New-RscQueryAzureO365 -CheckNetworkSubnet",
                    GqlRootFieldName.azureO365CheckNetworkSubnet
                },
                {
                    "New-RscQueryAzureO365 -CheckResourceGroupName",
                    GqlRootFieldName.azureO365CheckResourceGroupName
                },
                {
                    "New-RscQueryAzureO365 -CheckStorageAccountAccessibility",
                    GqlRootFieldName.azureO365CheckStorageAccountAccessibility
                },
                {
                    "New-RscQueryAzureO365 -CheckStorageAccountName",
                    GqlRootFieldName.azureO365CheckStorageAccountName
                },
                {
                    "New-RscQueryAzureO365 -CheckSubscriptionQuota",
                    GqlRootFieldName.azureO365CheckSubscriptionQuota
                },
                {
                    "New-RscQueryAzureO365 -CheckVirtualNetworkName",
                    GqlRootFieldName.azureO365CheckVirtualNetworkName
                },
                {
                    "New-RscQueryAzureO365 -Exocompute",
                    GqlRootFieldName.azureO365Exocompute
                },
                {
                    "New-RscQueryAzureO365 -GetAzureHostType",
                    GqlRootFieldName.azureO365GetAzureHostType
                },
                {
                    "New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr",
                    GqlRootFieldName.azureO365GetNetworkSubnetUnusedAddr
                },
                {
                    "New-RscQueryAzureO365 -ValidateUserRoles",
                    GqlRootFieldName.azureO365ValidateUserRoles
                },
                {
                    "New-RscMutationAzure -OauthConsentComplete",
                    GqlRootFieldName.azureOauthConsentComplete
                },
                {
                    "New-RscMutationAzure -OauthConsentKickoff",
                    GqlRootFieldName.azureOauthConsentKickoff
                },
                {
                    "New-RscQueryAzure -Regions",
                    GqlRootFieldName.azureRegions
                },
                {
                    "New-RscQueryAzure -ResourceGroups",
                    GqlRootFieldName.azureResourceGroups
                },
                {
                    "New-RscQueryAzure -SqlDatabase",
                    GqlRootFieldName.azureSqlDatabase
                },
                {
                    "New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                    GqlRootFieldName.azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
                },
                {
                    "New-RscQueryAzure -SqlDatabaseServer",
                    GqlRootFieldName.azureSqlDatabaseServer
                },
                {
                    "New-RscQueryAzure -SqlDatabaseServers",
                    GqlRootFieldName.azureSqlDatabaseServers
                },
                {
                    "New-RscQueryAzure -SqlDatabases",
                    GqlRootFieldName.azureSqlDatabases
                },
                {
                    "New-RscQueryAzure -SqlManagedInstanceDatabase",
                    GqlRootFieldName.azureSqlManagedInstanceDatabase
                },
                {
                    "New-RscQueryAzure -SqlManagedInstanceDatabases",
                    GqlRootFieldName.azureSqlManagedInstanceDatabases
                },
                {
                    "New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                    GqlRootFieldName.azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
                },
                {
                    "New-RscQueryAzure -SqlManagedInstanceServer",
                    GqlRootFieldName.azureSqlManagedInstanceServer
                },
                {
                    "New-RscQueryAzure -SqlManagedInstanceServers",
                    GqlRootFieldName.azureSqlManagedInstanceServers
                },
                {
                    "New-RscQueryAzure -StorageAccounts",
                    GqlRootFieldName.azureStorageAccounts
                },
                {
                    "New-RscQueryAzure -Subnets",
                    GqlRootFieldName.azureSubnets
                },
                {
                    "New-RscQueryAzure -Subscriptions",
                    GqlRootFieldName.azureSubscriptions
                },
                {
                    "New-RscQueryAzure -VNets",
                    GqlRootFieldName.azureVNets
                },
                {
                    "New-RscMutationAzure -BackupAdDirectory",
                    GqlRootFieldName.backupAzureAdDirectory
                },
                {
                    "New-RscMutationO365 -BackupMailbox",
                    GqlRootFieldName.backupO365Mailbox
                },
                {
                    "New-RscMutationO365 -BackupOnedrive",
                    GqlRootFieldName.backupO365Onedrive
                },
                {
                    "New-RscMutationO365 -BackupSharePointSite",
                    GqlRootFieldName.backupO365SharePointSite
                },
                {
                    "New-RscMutationO365 -BackupSharepointDrive",
                    GqlRootFieldName.backupO365SharepointDrive
                },
                {
                    "New-RscMutationO365 -BackupSharepointList",
                    GqlRootFieldName.backupO365SharepointList
                },
                {
                    "New-RscMutationO365 -BackupTeam",
                    GqlRootFieldName.backupO365Team
                },
                {
                    "New-RscMutationHyperv -BatchExportVm",
                    GqlRootFieldName.batchExportHypervVm
                },
                {
                    "New-RscMutationNutanix -BatchExportVm",
                    GqlRootFieldName.batchExportNutanixVm
                },
                {
                    "New-RscMutationHyperv -BatchInstantRecoverVm",
                    GqlRootFieldName.batchInstantRecoverHypervVm
                },
                {
                    "New-RscMutationHyperv -BatchMountVm",
                    GqlRootFieldName.batchMountHypervVm
                },
                {
                    "New-RscMutationNutanix -BatchMountVm",
                    GqlRootFieldName.batchMountNutanixVm
                },
                {
                    "New-RscMutationHyperv -BatchOnDemandBackupVm",
                    GqlRootFieldName.batchOnDemandBackupHypervVm
                },
                {
                    "New-RscMutationManagedVolume -BeginSnapshot",
                    GqlRootFieldName.beginManagedVolumeSnapshot
                },
                {
                    "New-RscMutationMssql -BrowseDatabaseSnapshot",
                    GqlRootFieldName.browseMssqlDatabaseSnapshot
                },
                {
                    "New-RscQueryO365 -BrowseTeamConvChannels",
                    GqlRootFieldName.browseO365TeamConvChannels
                },
                {
                    "New-RscMutationMssql -BulkCreateOnDemandBackup",
                    GqlRootFieldName.bulkCreateOnDemandMssqlBackup
                },
                {
                    "New-RscMutationAws -BulkDeleteCloudAccountWithoutCft",
                    GqlRootFieldName.bulkDeleteAwsCloudAccountWithoutCft
                },
                {
                    "New-RscMutationCassandra -BulkDeleteSources",
                    GqlRootFieldName.bulkDeleteCassandraSources
                },
                {
                    "New-RscMutationCluster -BulkDeleteFailover",
                    GqlRootFieldName.bulkDeleteFailoverCluster
                },
                {
                    "New-RscMutationMongo -BulkDeletedbSources",
                    GqlRootFieldName.bulkDeleteMongodbSources
                },
                {
                    "New-RscMutationNutanix -BulkOnDemandSnapshotVm",
                    GqlRootFieldName.bulkOnDemandSnapshotNutanixVm
                },
                {
                    "New-RscMutationMssql -BulkUpdateDbs",
                    GqlRootFieldName.bulkUpdateMssqlDbs
                },
                {
                    "New-RscMutationOracle -BulkUpdateDatabases",
                    GqlRootFieldName.bulkUpdateOracleDatabases
                },
                {
                    "New-RscMutationOracle -BulkUpdateHosts",
                    GqlRootFieldName.bulkUpdateOracleHosts
                },
                {
                    "New-RscMutationOracle -BulkUpdateRacs",
                    GqlRootFieldName.bulkUpdateOracleRacs
                },
                {
                    "New-RscMutationActivitySeries -Cancel",
                    GqlRootFieldName.cancelActivitySeries
                },
                {
                    "New-RscQueryCassandra -ColumnFamilies",
                    GqlRootFieldName.cassandraColumnFamilies
                },
                {
                    "New-RscQueryCassandra -ColumnFamily",
                    GqlRootFieldName.cassandraColumnFamily
                },
                {
                    "New-RscQueryCassandra -ColumnFamilyRecoverableRange",
                    GqlRootFieldName.cassandraColumnFamilyRecoverableRange
                },
                {
                    "New-RscQueryCassandra -ColumnFamilySchema",
                    GqlRootFieldName.cassandraColumnFamilySchema
                },
                {
                    "New-RscQueryCassandra -Keyspace",
                    GqlRootFieldName.cassandraKeyspace
                },
                {
                    "New-RscQueryCassandra -Keyspaces",
                    GqlRootFieldName.cassandraKeyspaces
                },
                {
                    "New-RscQueryCassandra -Source",
                    GqlRootFieldName.cassandraSource
                },
                {
                    "New-RscQueryCassandra -Sources",
                    GqlRootFieldName.cassandraSources
                },
                {
                    "New-RscQueryMssql -CdmLogShippingTarget",
                    GqlRootFieldName.cdmMssqlLogShippingTarget
                },
                {
                    "New-RscQueryMssql -CdmLogShippingTargets",
                    GqlRootFieldName.cdmMssqlLogShippingTargets
                },
                {
                    "New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap",
                    GqlRootFieldName.checkAzurePersistentStorageSubscriptionCanUnmap
                },
                {
                    "New-RscQueryCluster -Cluster",
                    GqlRootFieldName.cluster
                },
                {
                    "New-RscQueryCluster -Certificates",
                    GqlRootFieldName.clusterCertificates
                },
                {
                    "New-RscQueryCluster -List",
                    GqlRootFieldName.clusterConnection
                },
                {
                    "New-RscQueryCluster -Csr",
                    GqlRootFieldName.clusterCsr
                },
                {
                    "New-RscQueryCluster -DefaultGateway",
                    GqlRootFieldName.clusterDefaultGateway
                },
                {
                    "New-RscQueryCluster -Dns",
                    GqlRootFieldName.clusterDns
                },
                {
                    "New-RscQueryCluster -FloatingIps",
                    GqlRootFieldName.clusterFloatingIps
                },
                {
                    "New-RscQueryCluster -GroupByList",
                    GqlRootFieldName.clusterGroupByConnection
                },
                {
                    "New-RscQueryCluster -Ipmi",
                    GqlRootFieldName.clusterIpmi
                },
                {
                    "New-RscQueryCluster -Ipv6Mode",
                    GqlRootFieldName.clusterIpv6Mode
                },
                {
                    "New-RscQueryCluster -NetworkInterfaces",
                    GqlRootFieldName.clusterNetworkInterfaces
                },
                {
                    "New-RscQueryCluster -Nodes",
                    GqlRootFieldName.clusterNodes
                },
                {
                    "New-RscQueryCluster -NtpServers",
                    GqlRootFieldName.clusterNtpServers
                },
                {
                    "New-RscQueryCluster -OperationJobProgress",
                    GqlRootFieldName.clusterOperationJobProgress
                },
                {
                    "New-RscQueryCluster -Proxy",
                    GqlRootFieldName.clusterProxy
                },
                {
                    "New-RscQueryCluster -RegistrationProductInfo",
                    GqlRootFieldName.clusterRegistrationProductInfo
                },
                {
                    "New-RscQueryCluster -ReportMigrationCount",
                    GqlRootFieldName.clusterReportMigrationCount
                },
                {
                    "New-RscQueryCluster -ReportMigrationJobStatus",
                    GqlRootFieldName.clusterReportMigrationJobStatus
                },
                {
                    "New-RscQueryCluster -ReportMigrationStatus",
                    GqlRootFieldName.clusterReportMigrationStatus
                },
                {
                    "New-RscQueryCluster -SlaDomains",
                    GqlRootFieldName.clusterSlaDomains
                },
                {
                    "New-RscQueryCluster -TypeList",
                    GqlRootFieldName.clusterTypeList
                },
                {
                    "New-RscQueryCluster -Vlans",
                    GqlRootFieldName.clusterVlans
                },
                {
                    "New-RscQueryCluster -WebSignedCertificate",
                    GqlRootFieldName.clusterWebSignedCertificate
                },
                {
                    "New-RscQueryCluster -WithUpgradesInfo",
                    GqlRootFieldName.clusterWithUpgradesInfo
                },
                {
                    "New-RscMutationAzure -CompleteAdAppSetup",
                    GqlRootFieldName.completeAzureAdAppSetup
                },
                {
                    "New-RscMutationAzure -CompleteAdAppUpdate",
                    GqlRootFieldName.completeAzureAdAppUpdate
                },
                {
                    "New-RscMutationAzure -CompleteCloudAccountOauth",
                    GqlRootFieldName.completeAzureCloudAccountOauth
                },
                {
                    "New-RscQuerySla -CountOfObjectsProtected",
                    GqlRootFieldName.countOfObjectsProtectedBySlas
                },
                {
                    "New-RscMutationAws -CreateAutomaticTargetMapping",
                    GqlRootFieldName.createAutomaticAwsTargetMapping
                },
                {
                    "New-RscMutationAzure -CreateAutomaticTargetMapping",
                    GqlRootFieldName.createAutomaticAzureTargetMapping
                },
                {
                    "New-RscMutationAws -CreateAccount",
                    GqlRootFieldName.createAwsAccount
                },
                {
                    "New-RscMutationAws -CreateCluster",
                    GqlRootFieldName.createAwsCluster
                },
                {
                    "New-RscMutationAws -CreateComputeSetting",
                    GqlRootFieldName.createAwsComputeSetting
                },
                {
                    "New-RscMutationAws -CreateExocomputeConfigs",
                    GqlRootFieldName.createAwsExocomputeConfigs
                },
                {
                    "New-RscMutationAws -CreateReaderTarget",
                    GqlRootFieldName.createAwsReaderTarget
                },
                {
                    "New-RscMutationAws -CreateTarget",
                    GqlRootFieldName.createAwsTarget
                },
                {
                    "New-RscMutationAzure -CreateAccount",
                    GqlRootFieldName.createAzureAccount
                },
                {
                    "New-RscMutationAzure -CreateCluster",
                    GqlRootFieldName.createAzureCluster
                },
                {
                    "New-RscMutationAzure -CreateReaderTarget",
                    GqlRootFieldName.createAzureReaderTarget
                },
                {
                    "New-RscMutationAzure -CreateSaasAppAad",
                    GqlRootFieldName.createAzureSaasAppAad
                },
                {
                    "New-RscMutationAzure -CreateTarget",
                    GqlRootFieldName.createAzureTarget
                },
                {
                    "New-RscMutationCassandra -CreateSource",
                    GqlRootFieldName.createCassandraSource
                },
                {
                    "New-RscMutationAws -CreateCloudNativeStorageSetting",
                    GqlRootFieldName.createCloudNativeAwsStorageSetting
                },
                {
                    "New-RscMutationAzure -CreateCloudNativeStorageSetting",
                    GqlRootFieldName.createCloudNativeAzureStorageSetting
                },
                {
                    "New-RscMutationAzure -CreateCloudNativeRcvStorageSetting",
                    GqlRootFieldName.createCloudNativeRcvAzureStorageSetting
                },
                {
                    "New-RscMutationCluster -CreateFailover",
                    GqlRootFieldName.createFailoverCluster
                },
                {
                    "New-RscMutationSla -CreateGlobal",
                    GqlRootFieldName.createGlobalSla
                },
                {
                    "New-RscMutationHyperv -CreateVirtualMachineSnapshotMount",
                    GqlRootFieldName.createHypervVirtualMachineSnapshotMount
                },
                {
                    "New-RscMutationCluster -CreateK8s",
                    GqlRootFieldName.createK8sCluster
                },
                {
                    "New-RscMutationMongo -CreatedbSource",
                    GqlRootFieldName.createMongodbSource
                },
                {
                    "New-RscMutationMssql -CreateLiveMount",
                    GqlRootFieldName.createMssqlLiveMount
                },
                {
                    "New-RscMutationMssql -CreateLogShippingConfiguration",
                    GqlRootFieldName.createMssqlLogShippingConfiguration
                },
                {
                    "New-RscMutationNutanix -CreateCluster",
                    GqlRootFieldName.createNutanixCluster
                },
                {
                    "New-RscMutationNutanix -CreatePrismCentral",
                    GqlRootFieldName.createNutanixPrismCentral
                },
                {
                    "New-RscMutationO365 -CreateAppComplete",
                    GqlRootFieldName.createO365AppComplete
                },
                {
                    "New-RscMutationO365 -CreateAppKickoff",
                    GqlRootFieldName.createO365AppKickoff
                },
                {
                    "New-RscMutationDb2 -CreateOnDemandBackup",
                    GqlRootFieldName.createOnDemandDb2Backup
                },
                {
                    "New-RscMutationMssql -CreateOnDemandBackup",
                    GqlRootFieldName.createOnDemandMssqlBackup
                },
                {
                    "New-RscMutationNutanix -CreateOnDemandBackup",
                    GqlRootFieldName.createOnDemandNutanixBackup
                },
                {
                    "New-RscMutationOracle -CreatePdbRestore",
                    GqlRootFieldName.createOraclePdbRestore
                },
                {
                    "New-RscMutationVsphere -CreateAdvancedTag",
                    GqlRootFieldName.createVsphereAdvancedTag
                },
                {
                    "New-RscMutationVcenter -Create",
                    GqlRootFieldName.createVsphereVcenter
                },
                {
                    "New-RscQueryCluster -DatabaseLogReport",
                    GqlRootFieldName.databaseLogReportForCluster
                },
                {
                    "New-RscQueryCluster -DatabaseLogReportingProperties",
                    GqlRootFieldName.databaseLogReportingPropertiesForCluster
                },
                {
                    "New-RscQueryDb2 -Database",
                    GqlRootFieldName.db2Database
                },
                {
                    "New-RscQueryDb2 -Databases",
                    GqlRootFieldName.db2Databases
                },
                {
                    "New-RscQueryDb2 -Instance",
                    GqlRootFieldName.db2Instance
                },
                {
                    "New-RscQueryDb2 -Instances",
                    GqlRootFieldName.db2Instances
                },
                {
                    "New-RscQueryDb2 -LogSnapshot",
                    GqlRootFieldName.db2LogSnapshot
                },
                {
                    "New-RscQueryDb2 -LogSnapshots",
                    GqlRootFieldName.db2LogSnapshots
                },
                {
                    "New-RscQueryDb2 -RecoverableRange",
                    GqlRootFieldName.db2RecoverableRange
                },
                {
                    "New-RscQueryDb2 -RecoverableRanges",
                    GqlRootFieldName.db2RecoverableRanges
                },
                {
                    "New-RscMutationOracle -DeleteAllDatabaseSnapshots",
                    GqlRootFieldName.deleteAllOracleDatabaseSnapshots
                },
                {
                    "New-RscMutationAws -DeleteCluster",
                    GqlRootFieldName.deleteAwsCluster
                },
                {
                    "New-RscMutationAws -DeleteComputeSetting",
                    GqlRootFieldName.deleteAwsComputeSetting
                },
                {
                    "New-RscMutationAws -DeleteExocomputeConfigs",
                    GqlRootFieldName.deleteAwsExocomputeConfigs
                },
                {
                    "New-RscMutationAzure -DeleteAdDirectory",
                    GqlRootFieldName.deleteAzureAdDirectory
                },
                {
                    "New-RscMutationAzure -DeleteCloudAccount",
                    GqlRootFieldName.deleteAzureCloudAccount
                },
                {
                    "New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations",
                    GqlRootFieldName.deleteAzureCloudAccountExocomputeConfigurations
                },
                {
                    "New-RscMutationAzure -DeleteCloudAccountWithoutOauth",
                    GqlRootFieldName.deleteAzureCloudAccountWithoutOauth
                },
                {
                    "New-RscMutationAzure -DeleteCluster",
                    GqlRootFieldName.deleteAzureCluster
                },
                {
                    "New-RscMutationCassandra -DeleteSource",
                    GqlRootFieldName.deleteCassandraSource
                },
                {
                    "New-RscMutationDb2 -DeleteDatabase",
                    GqlRootFieldName.deleteDb2Database
                },
                {
                    "New-RscMutationDb2 -DeleteInstance",
                    GqlRootFieldName.deleteDb2Instance
                },
                {
                    "New-RscMutationCluster -DeleteFailover",
                    GqlRootFieldName.deleteFailoverCluster
                },
                {
                    "New-RscMutationHyperv -DeleteVirtualMachineSnapshot",
                    GqlRootFieldName.deleteHypervVirtualMachineSnapshot
                },
                {
                    "New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount",
                    GqlRootFieldName.deleteHypervVirtualMachineSnapshotMount
                },
                {
                    "New-RscMutationLdap -DeletePrincipals",
                    GqlRootFieldName.deleteLdapPrincipals
                },
                {
                    "New-RscMutationManagedVolume -Delete",
                    GqlRootFieldName.deleteManagedVolume
                },
                {
                    "New-RscMutationManagedVolume -DeleteSnapshotExport",
                    GqlRootFieldName.deleteManagedVolumeSnapshotExport
                },
                {
                    "New-RscMutationMongo -DeleteSource",
                    GqlRootFieldName.deleteMongoSource
                },
                {
                    "New-RscMutationMongo -DeletedbSource",
                    GqlRootFieldName.deleteMongodbSource
                },
                {
                    "New-RscMutationMssql -DeleteDbSnapshots",
                    GqlRootFieldName.deleteMssqlDbSnapshots
                },
                {
                    "New-RscMutationMssql -DeleteLiveMount",
                    GqlRootFieldName.deleteMssqlLiveMount
                },
                {
                    "New-RscMutationNutanix -DeleteCluster",
                    GqlRootFieldName.deleteNutanixCluster
                },
                {
                    "New-RscMutationNutanix -DeleteMountV1",
                    GqlRootFieldName.deleteNutanixMountV1
                },
                {
                    "New-RscMutationNutanix -DeletePrismCentral",
                    GqlRootFieldName.deleteNutanixPrismCentral
                },
                {
                    "New-RscMutationNutanix -DeleteSnapshot",
                    GqlRootFieldName.deleteNutanixSnapshot
                },
                {
                    "New-RscMutationNutanix -DeleteSnapshots",
                    GqlRootFieldName.deleteNutanixSnapshots
                },
                {
                    "New-RscMutationO365 -DeleteAzureApp",
                    GqlRootFieldName.deleteO365AzureApp
                },
                {
                    "New-RscMutationO365 -DeleteOrg",
                    GqlRootFieldName.deleteO365Org
                },
                {
                    "New-RscMutationO365 -DeleteServiceAccount",
                    GqlRootFieldName.deleteO365ServiceAccount
                },
                {
                    "New-RscMutationOracle -DeleteMount",
                    GqlRootFieldName.deleteOracleMount
                },
                {
                    "New-RscMutationVsphere -DeleteAdvancedTag",
                    GqlRootFieldName.deleteVsphereAdvancedTag
                },
                {
                    "New-RscMutationVsphere -DeleteLiveMount",
                    GqlRootFieldName.deleteVsphereLiveMount
                },
                {
                    "New-RscMutationDb2 -DiscoverInstance",
                    GqlRootFieldName.discoverDb2Instance
                },
                {
                    "New-RscMutationMongo -DiscoverSource",
                    GqlRootFieldName.discoverMongoSource
                },
                {
                    "New-RscQueryAzure -DoesNativeResourceGroupExist",
                    GqlRootFieldName.doesAzureNativeResourceGroupExist
                },
                {
                    "New-RscMutationDb2 -DownloadSnapshot",
                    GqlRootFieldName.downloadDb2Snapshot
                },
                {
                    "New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery",
                    GqlRootFieldName.downloadDb2SnapshotsForPointInTimeRecovery
                },
                {
                    "New-RscMutationNutanix -DownloadFilesSnapshot",
                    GqlRootFieldName.downloadFilesNutanixSnapshot
                },
                {
                    "New-RscMutationHyperv -DownloadSnapshotFromLocation",
                    GqlRootFieldName.downloadHypervSnapshotFromLocation
                },
                {
                    "New-RscMutationHyperv -DownloadVirtualMachineSnapshot",
                    GqlRootFieldName.downloadHypervVirtualMachineSnapshot
                },
                {
                    "New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles",
                    GqlRootFieldName.downloadHypervVirtualMachineSnapshotFiles
                },
                {
                    "New-RscMutationManagedVolume -DownloadFiles",
                    GqlRootFieldName.downloadManagedVolumeFiles
                },
                {
                    "New-RscMutationManagedVolume -DownloadFromLocation",
                    GqlRootFieldName.downloadManagedVolumeFromLocation
                },
                {
                    "New-RscMutationMssql -DownloadDatabaseBackupFiles",
                    GqlRootFieldName.downloadMssqlDatabaseBackupFiles
                },
                {
                    "New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation",
                    GqlRootFieldName.downloadMssqlDatabaseFilesFromArchivalLocation
                },
                {
                    "New-RscMutationNutanix -DownloadSnapshot",
                    GqlRootFieldName.downloadNutanixSnapshot
                },
                {
                    "New-RscMutationNutanix -DownloadVmFromLocation",
                    GqlRootFieldName.downloadNutanixVmFromLocation
                },
                {
                    "New-RscMutationOracle -DownloadDatabaseSnapshot",
                    GqlRootFieldName.downloadOracleDatabaseSnapshot
                },
                {
                    "New-RscMutationVsphere -DownloadVirtualMachineFiles",
                    GqlRootFieldName.downloadVsphereVirtualMachineFiles
                },
                {
                    "New-RscMutationO365 -EnableSharePoint",
                    GqlRootFieldName.enableO365SharePoint
                },
                {
                    "New-RscMutationO365 -EnableTeams",
                    GqlRootFieldName.enableO365Teams
                },
                {
                    "New-RscMutationManagedVolume -EndSnapshot",
                    GqlRootFieldName.endManagedVolumeSnapshot
                },
                {
                    "New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot",
                    GqlRootFieldName.excludeAwsNativeEbsVolumesFromSnapshot
                },
                {
                    "New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot",
                    GqlRootFieldName.excludeAzureNativeManagedDisksFromSnapshot
                },
                {
                    "New-RscMutationDb2 -ExpireDownloadedSnapshots",
                    GqlRootFieldName.expireDownloadedDb2Snapshots
                },
                {
                    "New-RscMutationHyperv -ExportVirtualMachine",
                    GqlRootFieldName.exportHypervVirtualMachine
                },
                {
                    "New-RscMutationManagedVolume -ExportSnapshot",
                    GqlRootFieldName.exportManagedVolumeSnapshot
                },
                {
                    "New-RscMutationMssql -ExportDatabase",
                    GqlRootFieldName.exportMssqlDatabase
                },
                {
                    "New-RscMutationNutanix -ExportSnapshot",
                    GqlRootFieldName.exportNutanixSnapshot
                },
                {
                    "New-RscMutationO365 -ExportMailbox",
                    GqlRootFieldName.exportO365Mailbox
                },
                {
                    "New-RscMutationOracle -ExportDatabase",
                    GqlRootFieldName.exportOracleDatabase
                },
                {
                    "New-RscMutationOracle -ExportTablespace",
                    GqlRootFieldName.exportOracleTablespace
                },
                {
                    "New-RscMutationSla -ExportManagedVolumeSnapshot",
                    GqlRootFieldName.exportSlaManagedVolumeSnapshot
                },
                {
                    "New-RscMutationAws -FinalizeCloudAccountDeletion",
                    GqlRootFieldName.finalizeAwsCloudAccountDeletion
                },
                {
                    "New-RscMutationAws -FinalizeCloudAccountProtection",
                    GqlRootFieldName.finalizeAwsCloudAccountProtection
                },
                {
                    "New-RscMutationSla -GetPendingAssignments",
                    GqlRootFieldName.getPendingSlaAssignments
                },
                {
                    "New-RscQuerySla -GlobalFilterList",
                    GqlRootFieldName.globalSlaFilterConnection
                },
                {
                    "New-RscQuerySla -GlobalStatuses",
                    GqlRootFieldName.globalSlaStatuses
                },
                {
                    "New-RscQueryCluster -HostFailover",
                    GqlRootFieldName.hostFailoverCluster
                },
                {
                    "New-RscQueryHyperv -Cluster",
                    GqlRootFieldName.hypervCluster
                },
                {
                    "New-RscMutationHyperv -DeleteAllSnapshots",
                    GqlRootFieldName.hypervDeleteAllSnapshots
                },
                {
                    "New-RscQueryHyperv -HostAsyncRequestStatus",
                    GqlRootFieldName.hypervHostAsyncRequestStatus
                },
                {
                    "New-RscQueryHyperv -Mounts",
                    GqlRootFieldName.hypervMounts
                },
                {
                    "New-RscMutationHyperv -OnDemandSnapshot",
                    GqlRootFieldName.hypervOnDemandSnapshot
                },
                {
                    "New-RscQueryHyperv -Scvmm",
                    GqlRootFieldName.hypervScvmm
                },
                {
                    "New-RscQueryHyperv -ScvmmAsyncRequestStatus",
                    GqlRootFieldName.hypervScvmmAsyncRequestStatus
                },
                {
                    "New-RscMutationHyperv -ScvmmDelete",
                    GqlRootFieldName.hypervScvmmDelete
                },
                {
                    "New-RscMutationHyperv -ScvmmUpdate",
                    GqlRootFieldName.hypervScvmmUpdate
                },
                {
                    "New-RscQueryHyperv -Scvmms",
                    GqlRootFieldName.hypervScvmms
                },
                {
                    "New-RscQueryHyperv -Server",
                    GqlRootFieldName.hypervServer
                },
                {
                    "New-RscQueryHyperv -Servers",
                    GqlRootFieldName.hypervServers
                },
                {
                    "New-RscQueryHyperv -TopLevelDescendants",
                    GqlRootFieldName.hypervTopLevelDescendants
                },
                {
                    "New-RscQueryHyperv -VirtualMachine",
                    GqlRootFieldName.hypervVirtualMachine
                },
                {
                    "New-RscQueryHyperv -VirtualMachineAsyncRequestStatus",
                    GqlRootFieldName.hypervVirtualMachineAsyncRequestStatus
                },
                {
                    "New-RscQueryHyperv -VirtualMachines",
                    GqlRootFieldName.hypervVirtualMachines
                },
                {
                    "New-RscQueryHyperv -VmDetail",
                    GqlRootFieldName.hypervVmDetail
                },
                {
                    "New-RscMutationO365 -InsertCustomerApp",
                    GqlRootFieldName.insertCustomerO365App
                },
                {
                    "New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot",
                    GqlRootFieldName.instantRecoverHypervVirtualMachineSnapshot
                },
                {
                    "New-RscMutationOracle -InstantRecoverSnapshot",
                    GqlRootFieldName.instantRecoverOracleSnapshot
                },
                {
                    "New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable",
                    GqlRootFieldName.isAwsNativeEbsVolumeSnapshotRestorable
                },
                {
                    "New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid",
                    GqlRootFieldName.isAwsNativeRdsInstanceLaunchConfigurationValid
                },
                {
                    "New-RscQueryAws -IsS3BucketNameAvailable",
                    GqlRootFieldName.isAwsS3BucketNameAvailable
                },
                {
                    "New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable",
                    GqlRootFieldName.isAzureNativeManagedDiskSnapshotRestorable
                },
                {
                    "New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent",
                    GqlRootFieldName.isAzureNativeSqlDatabaseSnapshotPersistent
                },
                {
                    "New-RscQueryAzure -IsStorageAccountNameAvailable",
                    GqlRootFieldName.isAzureStorageAccountNameAvailable
                },
                {
                    "New-RscQueryCluster -IsTotpAckNecessary",
                    GqlRootFieldName.isTotpAckNecessaryForCluster
                },
                {
                    "New-RscQueryCluster -K8s",
                    GqlRootFieldName.k8sClusters
                },
                {
                    "New-RscQueryLdap -AuthorizedPrincipalList",
                    GqlRootFieldName.ldapAuthorizedPrincipalConnection
                },
                {
                    "New-RscQueryLdap -IntegrationList",
                    GqlRootFieldName.ldapIntegrationConnection
                },
                {
                    "New-RscQueryLdap -PrincipalList",
                    GqlRootFieldName.ldapPrincipalConnection
                },
                {
                    "New-RscQueryO365 -ListApps",
                    GqlRootFieldName.listO365Apps
                },
                {
                    "New-RscQueryManagedVolume -ManagedVolume",
                    GqlRootFieldName.managedVolume
                },
                {
                    "New-RscQueryManagedVolume -InventoryStats",
                    GqlRootFieldName.managedVolumeInventoryStats
                },
                {
                    "New-RscQueryManagedVolume -LiveMounts",
                    GqlRootFieldName.managedVolumeLiveMounts
                },
                {
                    "New-RscQueryManagedVolume -ManagedVolumes",
                    GqlRootFieldName.managedVolumes
                },
                {
                    "New-RscMutationAzure -MapCloudAccountExocomputeSubscription",
                    GqlRootFieldName.mapAzureCloudAccountExocomputeSubscription
                },
                {
                    "New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation",
                    GqlRootFieldName.mapAzureCloudAccountToPersistentStorageLocation
                },
                {
                    "New-RscMutationNutanix -MigrateMountV1",
                    GqlRootFieldName.migrateNutanixMountV1
                },
                {
                    "New-RscQueryMongo -BulkRecoverableRanges",
                    GqlRootFieldName.mongoBulkRecoverableRanges
                },
                {
                    "New-RscQueryMongo -Collection",
                    GqlRootFieldName.mongoCollection
                },
                {
                    "New-RscQueryMongo -Collections",
                    GqlRootFieldName.mongoCollections
                },
                {
                    "New-RscQueryMongo -Database",
                    GqlRootFieldName.mongoDatabase
                },
                {
                    "New-RscQueryMongo -Databases",
                    GqlRootFieldName.mongoDatabases
                },
                {
                    "New-RscQueryMongo -RecoverableRanges",
                    GqlRootFieldName.mongoRecoverableRanges
                },
                {
                    "New-RscQueryMongo -Source",
                    GqlRootFieldName.mongoSource
                },
                {
                    "New-RscQueryMongo -Sources",
                    GqlRootFieldName.mongoSources
                },
                {
                    "New-RscQueryMongo -DbBulkRecoverableRange",
                    GqlRootFieldName.mongodbBulkRecoverableRange
                },
                {
                    "New-RscQueryMongo -DbCollection",
                    GqlRootFieldName.mongodbCollection
                },
                {
                    "New-RscQueryMongo -DbCollectionRecoverableRange",
                    GqlRootFieldName.mongodbCollectionRecoverableRange
                },
                {
                    "New-RscQueryMongo -DbCollections",
                    GqlRootFieldName.mongodbCollections
                },
                {
                    "New-RscQueryMongo -DbDatabase",
                    GqlRootFieldName.mongodbDatabase
                },
                {
                    "New-RscQueryMongo -DbDatabases",
                    GqlRootFieldName.mongodbDatabases
                },
                {
                    "New-RscQueryMongo -DbSource",
                    GqlRootFieldName.mongodbSource
                },
                {
                    "New-RscQueryMongo -DbSources",
                    GqlRootFieldName.mongodbSources
                },
                {
                    "New-RscMutationNutanix -MountSnapshotV1",
                    GqlRootFieldName.mountNutanixSnapshotV1
                },
                {
                    "New-RscMutationOracle -MountDatabase",
                    GqlRootFieldName.mountOracleDatabase
                },
                {
                    "New-RscQueryMssql -AvailabilityGroup",
                    GqlRootFieldName.mssqlAvailabilityGroup
                },
                {
                    "New-RscQueryMssql -CompatibleInstances",
                    GqlRootFieldName.mssqlCompatibleInstances
                },
                {
                    "New-RscQueryMssql -Database",
                    GqlRootFieldName.mssqlDatabase
                },
                {
                    "New-RscQueryMssql -DatabaseLiveMounts",
                    GqlRootFieldName.mssqlDatabaseLiveMounts
                },
                {
                    "New-RscQueryMssql -DatabaseMissedRecoverableRanges",
                    GqlRootFieldName.mssqlDatabaseMissedRecoverableRanges
                },
                {
                    "New-RscQueryMssql -DatabaseMissedSnapshots",
                    GqlRootFieldName.mssqlDatabaseMissedSnapshots
                },
                {
                    "New-RscQueryMssql -DatabaseRestoreEstimate",
                    GqlRootFieldName.mssqlDatabaseRestoreEstimate
                },
                {
                    "New-RscQueryMssql -Databases",
                    GqlRootFieldName.mssqlDatabases
                },
                {
                    "New-RscQueryMssql -DefaultProperties",
                    GqlRootFieldName.mssqlDefaultProperties
                },
                {
                    "New-RscQueryMssql -Instance",
                    GqlRootFieldName.mssqlInstance
                },
                {
                    "New-RscQueryMssql -LogShippingTargets",
                    GqlRootFieldName.mssqlLogShippingTargets
                },
                {
                    "New-RscQueryMssql -RecoverableRanges",
                    GqlRootFieldName.mssqlRecoverableRanges
                },
                {
                    "New-RscQueryMssql -TopLevelDescendants",
                    GqlRootFieldName.mssqlTopLevelDescendants
                },
                {
                    "New-RscQueryNutanix -BrowseSnapshot",
                    GqlRootFieldName.nutanixBrowseSnapshot
                },
                {
                    "New-RscQueryNutanix -Category",
                    GqlRootFieldName.nutanixCategory
                },
                {
                    "New-RscQueryNutanix -CategoryValue",
                    GqlRootFieldName.nutanixCategoryValue
                },
                {
                    "New-RscQueryNutanix -Cluster",
                    GqlRootFieldName.nutanixCluster
                },
                {
                    "New-RscQueryNutanix -ClusterAsyncRequestStatus",
                    GqlRootFieldName.nutanixClusterAsyncRequestStatus
                },
                {
                    "New-RscQueryNutanix -ClusterContainers",
                    GqlRootFieldName.nutanixClusterContainers
                },
                {
                    "New-RscQueryNutanix -ClusterNetworks",
                    GqlRootFieldName.nutanixClusterNetworks
                },
                {
                    "New-RscQueryNutanix -Clusters",
                    GqlRootFieldName.nutanixClusters
                },
                {
                    "New-RscQueryNutanix -Mounts",
                    GqlRootFieldName.nutanixMounts
                },
                {
                    "New-RscQueryNutanix -PrismCentral",
                    GqlRootFieldName.nutanixPrismCentral
                },
                {
                    "New-RscQueryNutanix -PrismCentrals",
                    GqlRootFieldName.nutanixPrismCentrals
                },
                {
                    "New-RscQueryNutanix -SnapshotDetail",
                    GqlRootFieldName.nutanixSnapshotDetail
                },
                {
                    "New-RscQueryNutanix -TopLevelDescendants",
                    GqlRootFieldName.nutanixTopLevelDescendants
                },
                {
                    "New-RscQueryNutanix -Vm",
                    GqlRootFieldName.nutanixVm
                },
                {
                    "New-RscQueryNutanix -VmAsyncRequestStatus",
                    GqlRootFieldName.nutanixVmAsyncRequestStatus
                },
                {
                    "New-RscQueryNutanix -VmMissedSnapshots",
                    GqlRootFieldName.nutanixVmMissedSnapshots
                },
                {
                    "New-RscQueryNutanix -Vms",
                    GqlRootFieldName.nutanixVms
                },
                {
                    "New-RscQueryO365 -Calendar",
                    GqlRootFieldName.o365Calendar
                },
                {
                    "New-RscQueryO365 -Groups",
                    GqlRootFieldName.o365Groups
                },
                {
                    "New-RscQueryO365 -License",
                    GqlRootFieldName.o365License
                },
                {
                    "New-RscQueryO365 -Mailbox",
                    GqlRootFieldName.o365Mailbox
                },
                {
                    "New-RscQueryO365 -Mailboxes",
                    GqlRootFieldName.o365Mailboxes
                },
                {
                    "New-RscMutationO365 -OauthConsentComplete",
                    GqlRootFieldName.o365OauthConsentComplete
                },
                {
                    "New-RscMutationO365 -OauthConsentKickoff",
                    GqlRootFieldName.o365OauthConsentKickoff
                },
                {
                    "New-RscQueryO365 -ObjectAncestors",
                    GqlRootFieldName.o365ObjectAncestors
                },
                {
                    "New-RscQueryO365 -Onedrive",
                    GqlRootFieldName.o365Onedrive
                },
                {
                    "New-RscQueryO365 -Onedrives",
                    GqlRootFieldName.o365Onedrives
                },
                {
                    "New-RscQueryO365 -Org",
                    GqlRootFieldName.o365Org
                },
                {
                    "New-RscQueryO365 -OrgAtSnappableLevel",
                    GqlRootFieldName.o365OrgAtSnappableLevel
                },
                {
                    "New-RscQueryO365 -OrgSummaries",
                    GqlRootFieldName.o365OrgSummaries
                },
                {
                    "New-RscQueryO365 -Orgs",
                    GqlRootFieldName.o365Orgs
                },
                {
                    "New-RscMutationO365 -PdlGroups",
                    GqlRootFieldName.o365PdlGroups
                },
                {
                    "New-RscMutationO365 -SaaSSetupKickoff",
                    GqlRootFieldName.o365SaaSSetupKickoff
                },
                {
                    "New-RscMutationO365 -SaasSetupComplete",
                    GqlRootFieldName.o365SaasSetupComplete
                },
                {
                    "New-RscQueryO365 -ServiceAccount",
                    GqlRootFieldName.o365ServiceAccount
                },
                {
                    "New-RscQueryO365 -ServiceStatus",
                    GqlRootFieldName.o365ServiceStatus
                },
                {
                    "New-RscMutationO365 -SetupKickoff",
                    GqlRootFieldName.o365SetupKickoff
                },
                {
                    "New-RscQueryO365 -SharepointDrive",
                    GqlRootFieldName.o365SharepointDrive
                },
                {
                    "New-RscQueryO365 -SharepointDrives",
                    GqlRootFieldName.o365SharepointDrives
                },
                {
                    "New-RscQueryO365 -SharepointList",
                    GqlRootFieldName.o365SharepointList
                },
                {
                    "New-RscQueryO365 -SharepointLists",
                    GqlRootFieldName.o365SharepointLists
                },
                {
                    "New-RscQueryO365 -SharepointObjectList",
                    GqlRootFieldName.o365SharepointObjectList
                },
                {
                    "New-RscQueryO365 -SharepointObjects",
                    GqlRootFieldName.o365SharepointObjects
                },
                {
                    "New-RscQueryO365 -SharepointSite",
                    GqlRootFieldName.o365SharepointSite
                },
                {
                    "New-RscQueryO365 -SharepointSites",
                    GqlRootFieldName.o365SharepointSites
                },
                {
                    "New-RscQueryO365 -Site",
                    GqlRootFieldName.o365Site
                },
                {
                    "New-RscQueryO365 -Sites",
                    GqlRootFieldName.o365Sites
                },
                {
                    "New-RscQueryO365 -StorageStats",
                    GqlRootFieldName.o365StorageStats
                },
                {
                    "New-RscQueryO365 -Team",
                    GqlRootFieldName.o365Team
                },
                {
                    "New-RscQueryO365 -TeamChannels",
                    GqlRootFieldName.o365TeamChannels
                },
                {
                    "New-RscQueryO365 -TeamConversationsFolderID",
                    GqlRootFieldName.o365TeamConversationsFolderID
                },
                {
                    "New-RscQueryO365 -TeamPostedBy",
                    GqlRootFieldName.o365TeamPostedBy
                },
                {
                    "New-RscQueryO365 -Teams",
                    GqlRootFieldName.o365Teams
                },
                {
                    "New-RscQueryO365 -User",
                    GqlRootFieldName.o365User
                },
                {
                    "New-RscQueryO365 -UserObjects",
                    GqlRootFieldName.o365UserObjects
                },
                {
                    "New-RscQueryOracle -AcoExampleDownloadLink",
                    GqlRootFieldName.oracleAcoExampleDownloadLink
                },
                {
                    "New-RscQueryOracle -AcoParameters",
                    GqlRootFieldName.oracleAcoParameters
                },
                {
                    "New-RscQueryOracle -DataGuardGroup",
                    GqlRootFieldName.oracleDataGuardGroup
                },
                {
                    "New-RscQueryOracle -Database",
                    GqlRootFieldName.oracleDatabase
                },
                {
                    "New-RscQueryOracle -DatabaseLogBackupConfig",
                    GqlRootFieldName.oracleDatabaseLogBackupConfig
                },
                {
                    "New-RscQueryOracle -Databases",
                    GqlRootFieldName.oracleDatabases
                },
                {
                    "New-RscQueryOracle -Host",
                    GqlRootFieldName.oracleHost
                },
                {
                    "New-RscQueryOracle -HostLogBackupConfig",
                    GqlRootFieldName.oracleHostLogBackupConfig
                },
                {
                    "New-RscQueryOracle -LiveMounts",
                    GqlRootFieldName.oracleLiveMounts
                },
                {
                    "New-RscQueryOracle -MissedRecoverableRanges",
                    GqlRootFieldName.oracleMissedRecoverableRanges
                },
                {
                    "New-RscQueryOracle -MissedSnapshots",
                    GqlRootFieldName.oracleMissedSnapshots
                },
                {
                    "New-RscQueryOracle -PdbDetails",
                    GqlRootFieldName.oraclePdbDetails
                },
                {
                    "New-RscQueryOracle -Rac",
                    GqlRootFieldName.oracleRac
                },
                {
                    "New-RscQueryOracle -RacLogBackupConfig",
                    GqlRootFieldName.oracleRacLogBackupConfig
                },
                {
                    "New-RscQueryOracle -RecoverableRanges",
                    GqlRootFieldName.oracleRecoverableRanges
                },
                {
                    "New-RscQueryOracle -TopLevelDescendants",
                    GqlRootFieldName.oracleTopLevelDescendants
                },
                {
                    "New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount",
                    GqlRootFieldName.patchAwsAuthenticationServerBasedCloudAccount
                },
                {
                    "New-RscMutationAws -PatchIamUserBasedCloudAccount",
                    GqlRootFieldName.patchAwsIamUserBasedCloudAccount
                },
                {
                    "New-RscMutationDb2 -PatchDatabase",
                    GqlRootFieldName.patchDb2Database
                },
                {
                    "New-RscMutationDb2 -PatchInstance",
                    GqlRootFieldName.patchDb2Instance
                },
                {
                    "New-RscMutationMongo -PatchSource",
                    GqlRootFieldName.patchMongoSource
                },
                {
                    "New-RscMutationNutanix -PatchMountV1",
                    GqlRootFieldName.patchNutanixMountV1
                },
                {
                    "New-RscMutationSla -Pause",
                    GqlRootFieldName.pauseSla
                },
                {
                    "New-RscMutationAws -PrepareCloudAccountDeletion",
                    GqlRootFieldName.prepareAwsCloudAccountDeletion
                },
                {
                    "New-RscMutationAws -PrepareFeatureUpdateForCloudAccount",
                    GqlRootFieldName.prepareFeatureUpdateForAwsCloudAccount
                },
                {
                    "New-RscQueryAws -RdsInstanceDetails",
                    GqlRootFieldName.rdsInstanceDetailsFromAws
                },
                {
                    "New-RscMutationCassandra -RecoverSource",
                    GqlRootFieldName.recoverCassandraSource
                },
                {
                    "New-RscMutationCluster -RecoverCloud",
                    GqlRootFieldName.recoverCloudCluster
                },
                {
                    "New-RscMutationMongo -RecoverSource",
                    GqlRootFieldName.recoverMongoSource
                },
                {
                    "New-RscMutationMongo -RecoverdbSource",
                    GqlRootFieldName.recoverMongodbSource
                },
                {
                    "New-RscMutationDb2 -RefreshDatabase",
                    GqlRootFieldName.refreshDb2Database
                },
                {
                    "New-RscMutationHyperv -RefreshScvmm",
                    GqlRootFieldName.refreshHypervScvmm
                },
                {
                    "New-RscMutationHyperv -RefreshServer",
                    GqlRootFieldName.refreshHypervServer
                },
                {
                    "New-RscMutationCluster -RefreshK8s",
                    GqlRootFieldName.refreshK8sCluster
                },
                {
                    "New-RscMutationNutanix -RefreshCluster",
                    GqlRootFieldName.refreshNutanixCluster
                },
                {
                    "New-RscMutationNutanix -RefreshPrismCentral",
                    GqlRootFieldName.refreshNutanixPrismCentral
                },
                {
                    "New-RscMutationO365 -RefreshOrg",
                    GqlRootFieldName.refreshO365Org
                },
                {
                    "New-RscMutationOracle -RefreshDatabase",
                    GqlRootFieldName.refreshOracleDatabase
                },
                {
                    "New-RscMutationVcenter -Refresh",
                    GqlRootFieldName.refreshVsphereVcenter
                },
                {
                    "New-RscMutationHyperv -RegisterAgentVirtualMachine",
                    GqlRootFieldName.registerAgentHypervVirtualMachine
                },
                {
                    "New-RscMutationNutanix -RegisterAgentVm",
                    GqlRootFieldName.registerAgentNutanixVm
                },
                {
                    "New-RscMutationAws -RegisterFeatureArtifacts",
                    GqlRootFieldName.registerAwsFeatureArtifacts
                },
                {
                    "New-RscMutationCluster -RegisterCloud",
                    GqlRootFieldName.registerCloudCluster
                },
                {
                    "New-RscMutationHyperv -RegisterScvmm",
                    GqlRootFieldName.registerHypervScvmm
                },
                {
                    "New-RscMutationCluster -RemoveCdm",
                    GqlRootFieldName.removeCdmCluster
                },
                {
                    "New-RscMutationLdap -RemoveIntegration",
                    GqlRootFieldName.removeLdapIntegration
                },
                {
                    "New-RscMutationManagedVolume -Resize",
                    GqlRootFieldName.resizeManagedVolume
                },
                {
                    "New-RscMutationAzure -RestoreAdObjectsWithPasswords",
                    GqlRootFieldName.restoreAzureAdObjectsWithPasswords
                },
                {
                    "New-RscMutationNutanix -RestoreFilesSnapshot",
                    GqlRootFieldName.restoreFilesNutanixSnapshot
                },
                {
                    "New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles",
                    GqlRootFieldName.restoreHypervVirtualMachineSnapshotFiles
                },
                {
                    "New-RscMutationMssql -RestoreDatabase",
                    GqlRootFieldName.restoreMssqlDatabase
                },
                {
                    "New-RscMutationO365 -RestoreMailbox",
                    GqlRootFieldName.restoreO365Mailbox
                },
                {
                    "New-RscMutationO365 -RestoreSnappable",
                    GqlRootFieldName.restoreO365Snappable
                },
                {
                    "New-RscMutationO365 -RestoreTeamsConversations",
                    GqlRootFieldName.restoreO365TeamsConversations
                },
                {
                    "New-RscMutationO365 -RestoreTeamsFiles",
                    GqlRootFieldName.restoreO365TeamsFiles
                },
                {
                    "New-RscMutationOracle -RestoreLogs",
                    GqlRootFieldName.restoreOracleLogs
                },
                {
                    "New-RscMutationMongo -RetryAddSource",
                    GqlRootFieldName.retryAddMongoSource
                },
                {
                    "New-RscQueryAzure -SearchAdSnapshot",
                    GqlRootFieldName.searchAzureAdSnapshot
                },
                {
                    "New-RscQueryNutanix -SearchVm",
                    GqlRootFieldName.searchNutanixVm
                },
                {
                    "New-RscMutationAzure -SetCloudAccountCustomerAppCredentials",
                    GqlRootFieldName.setAzureCloudAccountCustomerAppCredentials
                },
                {
                    "New-RscMutationLdap -SetMfaSetting",
                    GqlRootFieldName.setLdapMfaSetting
                },
                {
                    "New-RscMutationO365 -SetServiceAccount",
                    GqlRootFieldName.setO365ServiceAccount
                },
                {
                    "New-RscMutationAzureO365 -SetupExocompute",
                    GqlRootFieldName.setupAzureO365Exocompute
                },
                {
                    "New-RscQuerySla -AuditDetail",
                    GqlRootFieldName.slaAuditDetail
                },
                {
                    "New-RscQuerySla -ConflictObjects",
                    GqlRootFieldName.slaConflictObjects
                },
                {
                    "New-RscQuerySla -Domain",
                    GqlRootFieldName.slaDomain
                },
                {
                    "New-RscQuerySla -Domains",
                    GqlRootFieldName.slaDomains
                },
                {
                    "New-RscQuerySla -ManagedVolume",
                    GqlRootFieldName.slaManagedVolume
                },
                {
                    "New-RscQuerySla -ManagedVolumes",
                    GqlRootFieldName.slaManagedVolumes
                },
                {
                    "New-RscMutationAws -StartExocomputeDisableJob",
                    GqlRootFieldName.startAwsExocomputeDisableJob
                },
                {
                    "New-RscMutationAws -StartNativeAccountDisableJob",
                    GqlRootFieldName.startAwsNativeAccountDisableJob
                },
                {
                    "New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob",
                    GqlRootFieldName.startAwsNativeEc2InstanceSnapshotsJob
                },
                {
                    "New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob",
                    GqlRootFieldName.startAwsNativeRdsInstanceSnapshotsJob
                },
                {
                    "New-RscMutationAzure -StartAdAppSetup",
                    GqlRootFieldName.startAzureAdAppSetup
                },
                {
                    "New-RscMutationAzure -StartAdAppUpdate",
                    GqlRootFieldName.startAzureAdAppUpdate
                },
                {
                    "New-RscMutationAzure -StartCloudAccountOauth",
                    GqlRootFieldName.startAzureCloudAccountOauth
                },
                {
                    "New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob",
                    GqlRootFieldName.startCreateAwsNativeEbsVolumeSnapshotsJob
                },
                {
                    "New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob",
                    GqlRootFieldName.startCreateAzureNativeManagedDiskSnapshotsJob
                },
                {
                    "New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob",
                    GqlRootFieldName.startCreateAzureNativeVirtualMachineSnapshotsJob
                },
                {
                    "New-RscMutationAzure -StartDisableCloudAccountJob",
                    GqlRootFieldName.startDisableAzureCloudAccountJob
                },
                {
                    "New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob",
                    GqlRootFieldName.startDisableAzureNativeSubscriptionProtectionJob
                },
                {
                    "New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob",
                    GqlRootFieldName.startExportAwsNativeEbsVolumeSnapshotJob
                },
                {
                    "New-RscMutationAzure -StartExportNativeManagedDiskJob",
                    GqlRootFieldName.startExportAzureNativeManagedDiskJob
                },
                {
                    "New-RscMutationAzure -StartExportNativeVirtualMachineJob",
                    GqlRootFieldName.startExportAzureNativeVirtualMachineJob
                },
                {
                    "New-RscMutationAzure -StartExportSqlDatabaseDbJob",
                    GqlRootFieldName.startExportAzureSqlDatabaseDbJob
                },
                {
                    "New-RscMutationAzure -StartExportSqlManagedInstanceDbJob",
                    GqlRootFieldName.startExportAzureSqlManagedInstanceDbJob
                },
                {
                    "New-RscMutationAws -StartRefreshNativeAccountsJob",
                    GqlRootFieldName.startRefreshAwsNativeAccountsJob
                },
                {
                    "New-RscMutationAzure -StartRefreshNativeSubscriptionsJob",
                    GqlRootFieldName.startRefreshAzureNativeSubscriptionsJob
                },
                {
                    "New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob",
                    GqlRootFieldName.startRestoreAwsNativeEc2InstanceSnapshotJob
                },
                {
                    "New-RscMutationAzure -StartRestoreNativeVirtualMachineJob",
                    GqlRootFieldName.startRestoreAzureNativeVirtualMachineJob
                },
                {
                    "New-RscMutationManagedVolume -TakeOnDemandSnapshot",
                    GqlRootFieldName.takeManagedVolumeOnDemandSnapshot
                },
                {
                    "New-RscMutationMssql -TakeLogBackup",
                    GqlRootFieldName.takeMssqlLogBackup
                },
                {
                    "New-RscMutationOracle -TakeOnDemandDatabaseSnapshot",
                    GqlRootFieldName.takeOnDemandOracleDatabaseSnapshot
                },
                {
                    "New-RscMutationOracle -TakeOnDemandLogSnapshot",
                    GqlRootFieldName.takeOnDemandOracleLogSnapshot
                },
                {
                    "New-RscQueryHyperv -UniqueServersCount",
                    GqlRootFieldName.uniqueHypervServersCount
                },
                {
                    "New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription",
                    GqlRootFieldName.unmapAzureCloudAccountExocomputeSubscription
                },
                {
                    "New-RscMutationAzure -UnmapPersistentStorageSubscription",
                    GqlRootFieldName.unmapAzurePersistentStorageSubscription
                },
                {
                    "New-RscMutationAws -UpdateAutomaticTargetMapping",
                    GqlRootFieldName.updateAutomaticAwsTargetMapping
                },
                {
                    "New-RscMutationAzure -UpdateAutomaticTargetMapping",
                    GqlRootFieldName.updateAutomaticAzureTargetMapping
                },
                {
                    "New-RscMutationAws -UpdateAccount",
                    GqlRootFieldName.updateAwsAccount
                },
                {
                    "New-RscMutationAws -UpdateCloudAccount",
                    GqlRootFieldName.updateAwsCloudAccount
                },
                {
                    "New-RscMutationAws -UpdateCloudAccountFeature",
                    GqlRootFieldName.updateAwsCloudAccountFeature
                },
                {
                    "New-RscMutationAws -UpdateComputeSetting",
                    GqlRootFieldName.updateAwsComputeSetting
                },
                {
                    "New-RscMutationAws -UpdateExocomputeConfigs",
                    GqlRootFieldName.updateAwsExocomputeConfigs
                },
                {
                    "New-RscMutationAws -UpdateTarget",
                    GqlRootFieldName.updateAwsTarget
                },
                {
                    "New-RscMutationAzure -UpdateAccount",
                    GqlRootFieldName.updateAzureAccount
                },
                {
                    "New-RscMutationAzure -UpdateCloudAccount",
                    GqlRootFieldName.updateAzureCloudAccount
                },
                {
                    "New-RscMutationAzure -UpdateTarget",
                    GqlRootFieldName.updateAzureTarget
                },
                {
                    "New-RscMutationCassandra -UpdateSource",
                    GqlRootFieldName.updateCassandraSource
                },
                {
                    "New-RscMutationAws -UpdateCloudNativeStorageSetting",
                    GqlRootFieldName.updateCloudNativeAwsStorageSetting
                },
                {
                    "New-RscMutationAzure -UpdateCloudNativeStorageSetting",
                    GqlRootFieldName.updateCloudNativeAzureStorageSetting
                },
                {
                    "New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting",
                    GqlRootFieldName.updateCloudNativeRcvAzureStorageSetting
                },
                {
                    "New-RscMutationAzure -UpdateCustomerAppPermissionForSql",
                    GqlRootFieldName.updateCustomerAppPermissionForAzureSql
                },
                {
                    "New-RscMutationCluster -UpdateDatabaseLogReportingProperties",
                    GqlRootFieldName.updateDatabaseLogReportingPropertiesForCluster
                },
                {
                    "New-RscMutationCluster -UpdateFailover",
                    GqlRootFieldName.updateFailoverCluster
                },
                {
                    "New-RscMutationSla -UpdateGlobal",
                    GqlRootFieldName.updateGlobalSla
                },
                {
                    "New-RscMutationHyperv -UpdateVirtualMachine",
                    GqlRootFieldName.updateHypervVirtualMachine
                },
                {
                    "New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount",
                    GqlRootFieldName.updateHypervVirtualMachineSnapshotMount
                },
                {
                    "New-RscMutationLdap -UpdateIntegration",
                    GqlRootFieldName.updateLdapIntegration
                },
                {
                    "New-RscMutationManagedVolume -Update",
                    GqlRootFieldName.updateManagedVolume
                },
                {
                    "New-RscMutationMongo -UpdatedbSource",
                    GqlRootFieldName.updateMongodbSource
                },
                {
                    "New-RscMutationMssql -UpdateDefaultProperties",
                    GqlRootFieldName.updateMssqlDefaultProperties
                },
                {
                    "New-RscMutationMssql -UpdateLogShippingConfiguration",
                    GqlRootFieldName.updateMssqlLogShippingConfiguration
                },
                {
                    "New-RscMutationNutanix -UpdateCluster",
                    GqlRootFieldName.updateNutanixCluster
                },
                {
                    "New-RscMutationNutanix -UpdatePrismCentral",
                    GqlRootFieldName.updateNutanixPrismCentral
                },
                {
                    "New-RscMutationNutanix -UpdateVm",
                    GqlRootFieldName.updateNutanixVm
                },
                {
                    "New-RscMutationO365 -UpdateAppAuthStatus",
                    GqlRootFieldName.updateO365AppAuthStatus
                },
                {
                    "New-RscMutationO365 -UpdateAppPermissions",
                    GqlRootFieldName.updateO365AppPermissions
                },
                {
                    "New-RscMutationO365 -UpdateOrgCustomName",
                    GqlRootFieldName.updateO365OrgCustomName
                },
                {
                    "New-RscMutationOracle -UpdateDataGuardGroup",
                    GqlRootFieldName.updateOracleDataGuardGroup
                },
                {
                    "New-RscMutationVcenter -Update",
                    GqlRootFieldName.updateVcenter
                },
                {
                    "New-RscMutationVcenter -UpdateHotAddBandwidth",
                    GqlRootFieldName.updateVcenterHotAddBandwidth
                },
                {
                    "New-RscMutationVcenter -UpdateHotAddNetwork",
                    GqlRootFieldName.updateVcenterHotAddNetwork
                },
                {
                    "New-RscMutationVsphere -UpdateAdvancedTag",
                    GqlRootFieldName.updateVsphereAdvancedTag
                },
                {
                    "New-RscMutationVsphereVm -Update",
                    GqlRootFieldName.updateVsphereVm
                },
                {
                    "New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft",
                    GqlRootFieldName.upgradeAwsCloudAccountFeaturesWithoutCft
                },
                {
                    "New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions",
                    GqlRootFieldName.upgradeAwsIamUserBasedCloudAccountPermissions
                },
                {
                    "New-RscMutationAzure -UpgradeCloudAccount",
                    GqlRootFieldName.upgradeAzureCloudAccount
                },
                {
                    "New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth",
                    GqlRootFieldName.upgradeAzureCloudAccountPermissionsWithoutOauth
                },
                {
                    "New-RscQueryVcenter -AdvancedTagPreview",
                    GqlRootFieldName.vCenterAdvancedTagPreview
                },
                {
                    "New-RscQueryVcenter -HotAddBandwidth",
                    GqlRootFieldName.vCenterHotAddBandwidth
                },
                {
                    "New-RscQueryVcenter -HotAddNetwork",
                    GqlRootFieldName.vCenterHotAddNetwork
                },
                {
                    "New-RscQueryVcenter -Networks",
                    GqlRootFieldName.vCenterNetworks
                },
                {
                    "New-RscQueryVcenter -NumProxiesNeeded",
                    GqlRootFieldName.vCenterNumProxiesNeeded
                },
                {
                    "New-RscQueryVcenter -PreAddInfo",
                    GqlRootFieldName.vCenterPreAddInfo
                },
                {
                    "New-RscQueryVsphere -ComputeCluster",
                    GqlRootFieldName.vSphereComputeCluster
                },
                {
                    "New-RscQueryVsphere -ComputeClusters",
                    GqlRootFieldName.vSphereComputeClusters
                },
                {
                    "New-RscQueryVsphere -Datacenter",
                    GqlRootFieldName.vSphereDatacenter
                },
                {
                    "New-RscQueryVsphere -Datastore",
                    GqlRootFieldName.vSphereDatastore
                },
                {
                    "New-RscQueryVsphere -DatastoreCluster",
                    GqlRootFieldName.vSphereDatastoreCluster
                },
                {
                    "New-RscQueryVsphere -DatastoreClusters",
                    GqlRootFieldName.vSphereDatastoreClusters
                },
                {
                    "New-RscQueryVsphere -DatastoreList",
                    GqlRootFieldName.vSphereDatastoreConnection
                },
                {
                    "New-RscQueryVsphere -Folder",
                    GqlRootFieldName.vSphereFolder
                },
                {
                    "New-RscQueryVsphere -Folders",
                    GqlRootFieldName.vSphereFolders
                },
                {
                    "New-RscQueryVsphere -Host",
                    GqlRootFieldName.vSphereHost
                },
                {
                    "New-RscQueryVsphere -HostList",
                    GqlRootFieldName.vSphereHostConnection
                },
                {
                    "New-RscQueryVsphere -HostDetails",
                    GqlRootFieldName.vSphereHostDetails
                },
                {
                    "New-RscQueryVsphere -HostsByFids",
                    GqlRootFieldName.vSphereHostsByFids
                },
                {
                    "New-RscQueryVsphere -LiveMounts",
                    GqlRootFieldName.vSphereLiveMounts
                },
                {
                    "New-RscQueryVsphere -Mount",
                    GqlRootFieldName.vSphereMount
                },
                {
                    "New-RscQueryVsphere -MountList",
                    GqlRootFieldName.vSphereMountConnection
                },
                {
                    "New-RscQueryVsphere -Network",
                    GqlRootFieldName.vSphereNetwork
                },
                {
                    "New-RscQueryVsphere -ResourcePool",
                    GqlRootFieldName.vSphereResourcePool
                },
                {
                    "New-RscQueryVsphere -RootRecoveryHierarchy",
                    GqlRootFieldName.vSphereRootRecoveryHierarchy
                },
                {
                    "New-RscQueryVsphere -Tag",
                    GqlRootFieldName.vSphereTag
                },
                {
                    "New-RscQueryVsphere -TagCategory",
                    GqlRootFieldName.vSphereTagCategory
                },
                {
                    "New-RscQueryVsphere -TopLevelDescendantsList",
                    GqlRootFieldName.vSphereTopLevelDescendantsConnection
                },
                {
                    "New-RscQueryVcenter -Vcenter",
                    GqlRootFieldName.vSphereVCenter
                },
                {
                    "New-RscQueryVcenter -List",
                    GqlRootFieldName.vSphereVCenterConnection
                },
                {
                    "New-RscQueryVsphereVm -AsyncRequestStatus",
                    GqlRootFieldName.vSphereVMAsyncRequestStatus
                },
                {
                    "New-RscQueryVsphereVm -New",
                    GqlRootFieldName.vSphereVmNew
                },
                {
                    "New-RscQueryVsphereVm -NewList",
                    GqlRootFieldName.vSphereVmNewConnection
                },
                {
                    "New-RscMutationAws -ValidateAndCreateCloudAccount",
                    GqlRootFieldName.validateAndCreateAwsCloudAccount
                },
                {
                    "New-RscQueryAws -ValidateNativeRdsClusterNameForExport",
                    GqlRootFieldName.validateAwsNativeRdsClusterNameForExport
                },
                {
                    "New-RscQueryAws -ValidateNativeRdsInstanceNameForExport",
                    GqlRootFieldName.validateAwsNativeRdsInstanceNameForExport
                },
                {
                    "New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations",
                    GqlRootFieldName.validateAzureCloudAccountExocomputeConfigurations
                },
                {
                    "New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport",
                    GqlRootFieldName.validateAzureNativeSqlDatabaseDbNameForExport
                },
                {
                    "New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport",
                    GqlRootFieldName.validateAzureNativeSqlManagedInstanceDbNameForExport
                },
                {
                    "New-RscMutationOracle -ValidateAcoFile",
                    GqlRootFieldName.validateOracleAcoFile
                },
                {
                    "New-RscMutationOracle -ValidateDatabaseBackups",
                    GqlRootFieldName.validateOracleDatabaseBackups
                },
                {
                    "New-RscQueryCluster -VerifySlaWithReplicationTo",
                    GqlRootFieldName.verifySlaWithReplicationToCluster
                },
                {
                    "New-RscMutationVsphere -BulkOnDemandSnapshot",
                    GqlRootFieldName.vsphereBulkOnDemandSnapshot
                },
                {
                    "New-RscMutationVcenter -Delete",
                    GqlRootFieldName.vsphereDeleteVcenter
                },
                {
                    "New-RscMutationVsphereVm -ExcludeVmDisks",
                    GqlRootFieldName.vsphereExcludeVmDisks
                },
                {
                    "New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2",
                    GqlRootFieldName.vsphereExportSnapshotToStandaloneHostV2
                },
                {
                    "New-RscMutationVsphere -OnDemandSnapshot",
                    GqlRootFieldName.vsphereOnDemandSnapshot
                },
                {
                    "New-RscQueryVsphereVm -MissedRecoverableRange",
                    GqlRootFieldName.vsphereVMMissedRecoverableRange
                },
                {
                    "New-RscQueryVsphereVm -RecoverableRange",
                    GqlRootFieldName.vsphereVMRecoverableRange
                },
                {
                    "New-RscQueryVsphereVm -RecoverableRangeInBatch",
                    GqlRootFieldName.vsphereVMRecoverableRangeInBatch
                },
                {
                    "New-RscMutationVsphereVm -BatchExport",
                    GqlRootFieldName.vsphereVmBatchExport
                },
                {
                    "New-RscMutationVsphereVm -BatchExportV3",
                    GqlRootFieldName.vsphereVmBatchExportV3
                },
                {
                    "New-RscMutationVsphereVm -BatchInPlaceRecovery",
                    GqlRootFieldName.vsphereVmBatchInPlaceRecovery
                },
                {
                    "New-RscMutationVsphereVm -DeleteSnapshot",
                    GqlRootFieldName.vsphereVmDeleteSnapshot
                },
                {
                    "New-RscMutationVsphereVm -DownloadSnapshot",
                    GqlRootFieldName.vsphereVmDownloadSnapshot
                },
                {
                    "New-RscMutationVsphereVm -DownloadSnapshotFiles",
                    GqlRootFieldName.vsphereVmDownloadSnapshotFiles
                },
                {
                    "New-RscMutationVsphereVm -ExportSnapshotV2",
                    GqlRootFieldName.vsphereVmExportSnapshotV2
                },
                {
                    "New-RscMutationVsphereVm -ExportSnapshotV3",
                    GqlRootFieldName.vsphereVmExportSnapshotV3
                },
                {
                    "New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud",
                    GqlRootFieldName.vsphereVmExportSnapshotWithDownloadFromCloud
                },
                {
                    "New-RscMutationVsphereVm -InitiateBatchInstantRecovery",
                    GqlRootFieldName.vsphereVmInitiateBatchInstantRecovery
                },
                {
                    "New-RscMutationVsphereVm -InitiateBatchLiveMountV2",
                    GqlRootFieldName.vsphereVmInitiateBatchLiveMountV2
                },
                {
                    "New-RscMutationVsphereVm -InitiateDiskMount",
                    GqlRootFieldName.vsphereVmInitiateDiskMount
                },
                {
                    "New-RscMutationVsphereVm -InitiateInPlaceRecovery",
                    GqlRootFieldName.vsphereVmInitiateInPlaceRecovery
                },
                {
                    "New-RscMutationVsphereVm -InitiateInstantRecoveryV2",
                    GqlRootFieldName.vsphereVmInitiateInstantRecoveryV2
                },
                {
                    "New-RscMutationVsphereVm -InitiateLiveMountV2",
                    GqlRootFieldName.vsphereVmInitiateLiveMountV2
                },
                {
                    "New-RscMutationVsphereVm -ListEsxiDatastores",
                    GqlRootFieldName.vsphereVmListEsxiDatastores
                },
                {
                    "New-RscMutationVsphereVm -MountRelocate",
                    GqlRootFieldName.vsphereVmMountRelocate
                },
                {
                    "New-RscMutationVsphereVm -MountRelocateV2",
                    GqlRootFieldName.vsphereVmMountRelocateV2
                },
                {
                    "New-RscMutationVsphereVm -PowerOnOffLiveMount",
                    GqlRootFieldName.vsphereVmPowerOnOffLiveMount
                },
                {
                    "New-RscMutationVsphereVm -RecoverFiles",
                    GqlRootFieldName.vsphereVmRecoverFiles
                },
                {
                    "New-RscMutationVsphereVm -RecoverFilesNew",
                    GqlRootFieldName.vsphereVmRecoverFilesNew
                },
                {
                    "New-RscMutationVsphereVm -RegisterAgent",
                    GqlRootFieldName.vsphereVmRegisterAgent
                },
                {
                    "New-RscQueryVsphere -VmwareCdpLiveInfo",
                    GqlRootFieldName.vsphereVmwareCdpLiveInfo
                },
                {
                    "New-RscQueryCluster -Windows",
                    GqlRootFieldName.windowsCluster
                },
            };
            string key = rscOp.Syntax();
            if ( !string.IsNullOrEmpty(key) && lookupDict.TryGetValue(key, out var gqlRootFieldName)) {
                return gqlRootFieldName;
            }
            return GqlRootFieldName.Unknown;
        }

        /// <summary>
        /// Given a RSC operation, return the corresponding GraphQL root field name (as string).
        /// </summary>
        public static string StringGqlRootFieldNameLookupByRscOp(RscOp rscOp)
        {
            var rootField = GqlRootFieldNameLookupByRscOp(rscOp);
            return rootField.ToString();
        }

        /// <summary>
        /// Given a GraphQL root field name, return the corresponding RSC operation.
        /// </summary>
        public static RscOp RscOpLookupByGqlRootField(string rootField)
        {
            if (Enum.TryParse<GqlRootFieldName>(rootField, out GqlRootFieldName rootFieldEnumVal))
            {
                // The provided operation is a valid enum member.
                return RscOpLookupByGqlRootField(rootFieldEnumVal);
            }
            return new RscOp(
                gqlRootFieldName: rootField
            );
        }

        /// <summary>
        /// Given a GraphQL return type, return the list of root field names that return that type.
        /// </summary>
        public static List<string> GqlRootFieldLookupByReturnType(
            string returnTypeName
        )
        {
            var lookupDict = new Dictionary<string, List<string>> {
                {   "AccessGroupConnection", new List<string> {
                        "sonarUserGroups",
                    }
                },
                {   "AccessUserConnection", new List<string> {
                        "sonarUsers",
                    }
                },
                {   "AccountSetting", new List<string> {
                        "accountSettings",
                    }
                },
                {   "ActivitySeries", new List<string> {
                        "activitySeries",
                    }
                },
                {   "ActivitySeriesConnection", new List<string> {
                        "activitySeriesConnection",
                    }
                },
                {   "ActivityTimelineResultConnection", new List<string> {
                        "userActivityTimeline",
                        "userFileActivityTimeline",
                    }
                },
                {   "AddAndJoinSmbDomainReply", new List<string> {
                        "addAndJoinSmbDomain",
                    }
                },
                {   "AddAwsAuthenticationServerBasedCloudAccountReply", new List<string> {
                        "addAwsAuthenticationServerBasedCloudAccount",
                    }
                },
                {   "AddAwsIamUserBasedCloudAccountReply", new List<string> {
                        "addAwsIamUserBasedCloudAccount",
                    }
                },
                {   "AddAzureCloudAccountExocomputeConfigurationsReply", new List<string> {
                        "addAzureCloudAccountExocomputeConfigurations",
                    }
                },
                {   "AddAzureCloudAccountReply", new List<string> {
                        "addAzureCloudAccount",
                    }
                },
                {   "AddAzureCloudAccountWithoutOauthReply", new List<string> {
                        "addAzureCloudAccountWithoutOauth",
                    }
                },
                {   "AddCloudNativeSqlServerBackupCredentialsReply", new List<string> {
                        "addCloudNativeSqlServerBackupCredentials",
                    }
                },
                {   "AddClusterCertificateReply", new List<string> {
                        "addClusterCertificate",
                    }
                },
                {   "AddClusterNodesReply", new List<string> {
                        "addClusterNodes",
                    }
                },
                {   "AddConfiguredGroupToHierarchyReply", new List<string> {
                        "addConfiguredGroupToHierarchy",
                    }
                },
                {   "AddDb2InstanceReply", new List<string> {
                        "addDb2Instance",
                    }
                },
                {   "AddManagedVolumeReply", new List<string> {
                        "addManagedVolume",
                    }
                },
                {   "AddMongoSourceReply", new List<string> {
                        "addMongoSource",
                    }
                },
                {   "AddO365OrgResponse", new List<string> {
                        "addO365Org",
                        "o365SaasSetupComplete",
                    }
                },
                {   "AddSapHanaSystemReply", new List<string> {
                        "addSapHanaSystem",
                    }
                },
                {   "AddStorageArraysReply", new List<string> {
                        "addStorageArrays",
                    }
                },
                {   "AddSyslogExportRuleReply", new List<string> {
                        "addSyslogExportRule",
                    }
                },
                {   "AddVmAppConsistentSpecsReply", new List<string> {
                        "addVmAppConsistentSpecs",
                    }
                },
                {   "AllEnabledFeaturesForAccountReply", new List<string> {
                        "allEnabledFeaturesForAccount",
                    }
                },
                {   "AllStorageArraysReply", new List<string> {
                        "allStorageArrays",
                    }
                },
                {   "AmiTypeForAwsNativeArchivedSnapshotExportReply", new List<string> {
                        "amiTypeForAwsNativeArchivedSnapshotExport",
                    }
                },
                {   "Analyzer", new List<string> {
                        "createCustomAnalyzer",
                        "customAnalyzer",
                        "updateCustomAnalyzer",
                    }
                },
                {   "AnalyzerAccessUsageConnection", new List<string> {
                        "userAnalyzerAccess",
                    }
                },
                {   "AnalyzerConnection", new List<string> {
                        "activeCustomAnalyzers",
                    }
                },
                {   "AnalyzerGroupConnection", new List<string> {
                        "analyzerGroups",
                    }
                },
                {   "AnalyzerUsageConnection", new List<string> {
                        "analyzerUsages",
                    }
                },
                {   "AnomalyResultConnection", new List<string> {
                        "anomalyResults",
                    }
                },
                {   "AnomalyResultGroupedDataConnection", new List<string> {
                        "anomalyResultsGrouped",
                    }
                },
                {   "ArchiveK8sClusterReply", new List<string> {
                        "archiveK8sCluster",
                    }
                },
                {   "AssignMssqlSlaDomainPropertiesAsyncReply", new List<string> {
                        "assignMssqlSlaDomainPropertiesAsync",
                    }
                },
                {   "AsyncDownloadReply", new List<string> {
                        "downloadAuditLogCsvAsync",
                        "downloadReportCsvAsync",
                        "downloadReportPdfAsync",
                        "sendScheduledReportAsync",
                    }
                },
                {   "AsyncJobStatus", new List<string> {
                        "gcpNativeDisableProject",
                        "gcpNativeExportDisk",
                        "gcpNativeExportGceInstance",
                        "gcpNativeRestoreGceInstance",
                        "startAwsExocomputeDisableJob",
                        "startAwsNativeAccountDisableJob",
                        "startDisableAzureNativeSubscriptionProtectionJob",
                        "startEc2InstanceSnapshotExportJob",
                        "startExportAwsNativeEbsVolumeSnapshotJob",
                        "startExportAzureNativeManagedDiskJob",
                        "startExportAzureNativeVirtualMachineJob",
                        "startExportAzureSqlDatabaseDbJob",
                        "startExportAzureSqlManagedInstanceDbJob",
                        "startExportRdsInstanceJob",
                        "startRecoverS3SnapshotJob",
                        "startRestoreAwsNativeEc2InstanceSnapshotJob",
                        "startRestoreAzureNativeVirtualMachineJob",
                        "uploadDatabaseSnapshotToBlobstore",
                    }
                },
                {   "AsyncRequestStatus", new List<string> {
                        "assignSlaToMongoDbCollection",
                        "bulkCreateOnDemandMssqlBackup",
                        "bulkTierExistingSnapshots",
                        "checkCloudComputeConnectivityJobProgress",
                        "configureSapHanaRestore",
                        "createDownloadSnapshotForVolumeGroup",
                        "createExchangeMount",
                        "createFilesetSnapshot",
                        "createHypervVirtualMachineSnapshotMount",
                        "createMssqlLiveMount",
                        "createMssqlLogShippingConfiguration",
                        "createNutanixCluster",
                        "createOnDemandDb2Backup",
                        "createOnDemandExchangeBackup",
                        "createOnDemandMssqlBackup",
                        "createOnDemandNutanixBackup",
                        "createOnDemandSapHanaBackup",
                        "createOnDemandVolumeGroupBackup",
                        "createOraclePdbRestore",
                        "createSapHanaSystemRefresh",
                        "deleteDb2Database",
                        "deleteDb2Instance",
                        "deleteExchangeSnapshotMount",
                        "deleteHypervVirtualMachineSnapshotMount",
                        "deleteLogShipping",
                        "deleteManagedVolumeSnapshotExport",
                        "deleteMongoSource",
                        "deleteMssqlLiveMount",
                        "deleteNasSystem",
                        "deleteNutanixCluster",
                        "deleteNutanixMountV1",
                        "deleteOracleMount",
                        "deleteSapHanaSystem",
                        "deleteVolumeGroupMount",
                        "deleteVsphereLiveMount",
                        "discoverDb2Instance",
                        "discoverMongoSource",
                        "downloadDb2Snapshot",
                        "downloadDb2SnapshotsForPointInTimeRecovery",
                        "downloadExchangeSnapshot",
                        "downloadFilesetSnapshot",
                        "downloadFilesetSnapshotFromLocation",
                        "downloadFilesNutanixSnapshot",
                        "downloadHypervSnapshotFromLocation",
                        "downloadHypervVirtualMachineSnapshot",
                        "downloadHypervVirtualMachineSnapshotFiles",
                        "downloadManagedVolumeFiles",
                        "downloadManagedVolumeFromLocation",
                        "downloadMssqlDatabaseBackupFiles",
                        "downloadMssqlDatabaseFilesFromArchivalLocation",
                        "downloadNutanixSnapshot",
                        "downloadNutanixVmFromLocation",
                        "downloadOracleDatabaseSnapshot",
                        "downloadSapHanaSnapshot",
                        "downloadSapHanaSnapshotFromLocation",
                        "downloadSapHanaSnapshotsForPointInTimeRecovery",
                        "downloadVolumeGroupSnapshotFiles",
                        "downloadVolumeGroupSnapshotFromLocation",
                        "downloadVsphereVirtualMachineFiles",
                        "expireDownloadedDb2Snapshots",
                        "expireDownloadedSapHanaSnapshots",
                        "exportHypervVirtualMachine",
                        "exportManagedVolumeSnapshot",
                        "exportMssqlDatabase",
                        "exportNutanixSnapshot",
                        "exportOracleDatabase",
                        "exportOracleTablespace",
                        "exportSlaManagedVolumeSnapshot",
                        "filesetDownloadSnapshotFiles",
                        "filesetExportSnapshotFiles",
                        "filesetRecoverFiles",
                        "filesetRequestStatus",
                        "generateSupportBundle",
                        "hypervHostAsyncRequestStatus",
                        "hypervOnDemandSnapshot",
                        "hypervScvmmAsyncRequestStatus",
                        "hypervVirtualMachineAsyncRequestStatus",
                        "instantRecoverHypervVirtualMachineSnapshot",
                        "instantRecoverOracleSnapshot",
                        "migrateNutanixMountV1",
                        "mountNutanixSnapshotV1",
                        "mountOracleDatabase",
                        "nutanixClusterAsyncRequestStatus",
                        "nutanixVmAsyncRequestStatus",
                        "patchMongoSource",
                        "recoverCloudDirectMultiPaths",
                        "recoverCloudDirectPath",
                        "recoverMongoSource",
                        "refreshDb2Database",
                        "refreshHypervScvmm",
                        "refreshHypervServer",
                        "refreshNutanixCluster",
                        "refreshOracleDatabase",
                        "refreshVsphereVcenter",
                        "registerHypervScvmm",
                        "reseedLogShippingSecondary",
                        "resizeManagedVolume",
                        "restoreFilesNutanixSnapshot",
                        "restoreHypervVirtualMachineSnapshotFiles",
                        "restoreMssqlDatabase",
                        "restoreOracleLogs",
                        "restoreVolumeGroupSnapshotFiles",
                        "retryAddMongoSource",
                        "setWebSignedCertificate",
                        "startVolumeGroupMount",
                        "supportBundle",
                        "takeManagedVolumeOnDemandSnapshot",
                        "takeMssqlLogBackup",
                        "takeOnDemandOracleDatabaseSnapshot",
                        "takeOnDemandOracleLogSnapshot",
                        "triggerCloudComputeConnectivityCheck",
                        "unconfigureSapHanaRestore",
                        "validateOracleDatabaseBackups",
                        "vmwareDownloadSnapshotFromLocation",
                        "vsphereDeleteVcenter",
                        "vsphereExportSnapshotToStandaloneHostV2",
                        "vsphereOnDemandSnapshot",
                        "vSphereVMAsyncRequestStatus",
                        "vsphereVmDownloadSnapshot",
                        "vsphereVmDownloadSnapshotFiles",
                        "vsphereVmExportSnapshotV2",
                        "vsphereVmExportSnapshotV3",
                        "vsphereVmExportSnapshotWithDownloadFromCloud",
                        "vsphereVmInitiateDiskMount",
                        "vsphereVmInitiateInPlaceRecovery",
                        "vsphereVmInitiateInstantRecoveryV2",
                        "vsphereVmInitiateLiveMountV2",
                        "vsphereVmMountRelocate",
                        "vsphereVmMountRelocateV2",
                        "vsphereVmRecoverFilesNew",
                    }
                },
                {   "AuthorizedPrincipalConnection", new List<string> {
                        "ldapAuthorizedPrincipalConnection",
                    }
                },
                {   "AwsArtifactsToDelete", new List<string> {
                        "awsArtifactsToDelete",
                    }
                },
                {   "AwsCloudAccountListSecurityGroupsResponse", new List<string> {
                        "awsCloudAccountListSecurityGroups",
                    }
                },
                {   "AwsCloudAccountListSubnetsResponse", new List<string> {
                        "awsCloudAccountListSubnets",
                    }
                },
                {   "AwsCloudAccountListVpcResponse", new List<string> {
                        "awsCloudAccountListVpcs",
                    }
                },
                {   "AwsCloudAccountWithFeatures", new List<string> {
                        "awsCloudAccountWithFeatures",
                    }
                },
                {   "AwsComputeSettings", new List<string> {
                        "awsComputeSettings",
                        "createAwsComputeSetting",
                        "updateAwsComputeSetting",
                    }
                },
                {   "AwsNativeAccount", new List<string> {
                        "awsNativeAccount",
                    }
                },
                {   "AwsNativeAccountConnection", new List<string> {
                        "awsNativeAccounts",
                    }
                },
                {   "AwsNativeEbsVolume", new List<string> {
                        "awsNativeEbsVolume",
                    }
                },
                {   "AwsNativeEbsVolumeConnection", new List<string> {
                        "awsNativeEbsVolumes",
                        "awsNativeEbsVolumesByName",
                    }
                },
                {   "AwsNativeEc2Instance", new List<string> {
                        "awsNativeEc2Instance",
                    }
                },
                {   "AwsNativeEc2InstanceConnection", new List<string> {
                        "awsNativeEc2Instances",
                        "awsNativeEc2InstancesByName",
                    }
                },
                {   "AwsNativeRdsInstance", new List<string> {
                        "awsNativeRdsInstance",
                    }
                },
                {   "AwsNativeRdsInstanceConnection", new List<string> {
                        "awsNativeRdsInstances",
                    }
                },
                {   "AwsNativeRdsPointInTimeRestoreWindow", new List<string> {
                        "awsNativeRdsPointInTimeRestoreWindow",
                    }
                },
                {   "AwsNativeRoot", new List<string> {
                        "awsNativeRoot",
                    }
                },
                {   "AwsNativeS3Bucket", new List<string> {
                        "awsNativeS3Bucket",
                    }
                },
                {   "AwsTrustPolicy", new List<string> {
                        "awsTrustPolicy",
                    }
                },
                {   "AzureAdDirectory", new List<string> {
                        "azureAdDirectory",
                    }
                },
                {   "AzureAdDirectoryConnection", new List<string> {
                        "azureAdDirectories",
                    }
                },
                {   "AzureAdObjectConnection", new List<string> {
                        "azureAdObjectsByType",
                        "searchAzureAdSnapshot",
                    }
                },
                {   "AzureCloudAccountPermissionConfigResponse", new List<string> {
                        "azureCloudAccountPermissionConfig",
                    }
                },
                {   "AzureCloudAccountSubscriptionWithFeatures", new List<string> {
                        "azureCloudAccountSubscriptionWithFeatures",
                    }
                },
                {   "AzureCloudAccountTenant", new List<string> {
                        "azureCloudAccountTenant",
                    }
                },
                {   "AzureCloudAccountTenantWithExoConfigs", new List<string> {
                        "azureCloudAccountTenantWithExoConfigs",
                    }
                },
                {   "AzureNativeManagedDisk", new List<string> {
                        "azureNativeManagedDisk",
                    }
                },
                {   "AzureNativeManagedDiskConnection", new List<string> {
                        "azureNativeManagedDisks",
                    }
                },
                {   "AzureNativeResourceGroup", new List<string> {
                        "azureNativeResourceGroup",
                    }
                },
                {   "AzureNativeResourceGroupConnection", new List<string> {
                        "azureNativeResourceGroups",
                    }
                },
                {   "AzureNativeRoot", new List<string> {
                        "azureNativeRoot",
                    }
                },
                {   "AzureNativeSqlDatabasePointInTimeRestoreWindow", new List<string> {
                        "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                        "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                    }
                },
                {   "AzureNativeSubscription", new List<string> {
                        "azureNativeSubscription",
                    }
                },
                {   "AzureNativeSubscriptionConnection", new List<string> {
                        "azureNativeSubscriptions",
                    }
                },
                {   "AzureNativeVirtualMachine", new List<string> {
                        "azureNativeVirtualMachine",
                    }
                },
                {   "AzureNativeVirtualMachineConnection", new List<string> {
                        "azureNativeVirtualMachines",
                    }
                },
                {   "AzureNetworkSecurityGroupResp", new List<string> {
                        "azureO365CheckNSGOutboundRules",
                    }
                },
                {   "AzureNetworkSubnetResp", new List<string> {
                        "azureO365CheckNetworkSubnet",
                    }
                },
                {   "AzureNetworkSubnetUnusedAddrResp", new List<string> {
                        "azureO365GetNetworkSubnetUnusedAddr",
                    }
                },
                {   "AzureOauthConsentKickoffReply", new List<string> {
                        "azureOauthConsentKickoff",
                    }
                },
                {   "AzureRegionsResp", new List<string> {
                        "allHostedAzureRegions",
                    }
                },
                {   "AzureResourceAvailabilityResp", new List<string> {
                        "azureO365CheckResourceGroupName",
                        "azureO365CheckStorageAccountAccessibility",
                        "azureO365CheckStorageAccountName",
                        "azureO365CheckSubscriptionQuota",
                        "azureO365CheckVirtualNetworkName",
                    }
                },
                {   "AzureSqlDatabaseDb", new List<string> {
                        "azureSqlDatabase",
                    }
                },
                {   "AzureSqlDatabaseDbConnection", new List<string> {
                        "azureSqlDatabases",
                    }
                },
                {   "AzureSqlDatabaseServer", new List<string> {
                        "azureSqlDatabaseServer",
                    }
                },
                {   "AzureSqlDatabaseServerConnection", new List<string> {
                        "azureSqlDatabaseServers",
                    }
                },
                {   "AzureSqlManagedInstanceDatabase", new List<string> {
                        "azureSqlManagedInstanceDatabase",
                    }
                },
                {   "AzureSqlManagedInstanceDatabaseConnection", new List<string> {
                        "azureSqlManagedInstanceDatabases",
                    }
                },
                {   "AzureSqlManagedInstanceServer", new List<string> {
                        "azureSqlManagedInstanceServer",
                    }
                },
                {   "AzureSqlManagedInstanceServerConnection", new List<string> {
                        "azureSqlManagedInstanceServers",
                    }
                },
                {   "AzureSubscriptionConnection", new List<string> {
                        "azureSubscriptions",
                    }
                },
                {   "AzureUserRoleResp", new List<string> {
                        "azureO365ValidateUserRoles",
                    }
                },
                {   "BatchAsyncJobStatus", new List<string> {
                        "backupO365Mailbox",
                        "backupO365Onedrive",
                        "backupO365SharepointDrive",
                        "backupO365Team",
                        "gcpNativeRefreshProjects",
                        "setupCloudNativeSqlServerBackup",
                        "startAwsNativeEc2InstanceSnapshotsJob",
                        "startAwsNativeRdsInstanceSnapshotsJob",
                        "startCloudNativeSnapshotsIndexJob",
                        "startCreateAwsNativeEbsVolumeSnapshotsJob",
                        "startCreateAzureNativeManagedDiskSnapshotsJob",
                        "startCreateAzureNativeVirtualMachineSnapshotsJob",
                        "startDisableAzureCloudAccountJob",
                        "startRefreshAwsNativeAccountsJob",
                        "startRefreshAzureNativeSubscriptionsJob",
                    }
                },
                {   "BatchAsyncRequestStatus", new List<string> {
                        "bulkDeleteNasSystems",
                        "createNutanixPrismCentral",
                        "deleteNutanixPrismCentral",
                        "refreshNutanixPrismCentral",
                        "vsphereBulkOnDemandSnapshot",
                        "vsphereVmBatchExport",
                        "vsphereVmBatchExportV3",
                        "vsphereVmBatchInPlaceRecovery",
                        "vsphereVmInitiateBatchInstantRecovery",
                        "vsphereVmInitiateBatchLiveMountV2",
                    }
                },
                {   "BatchExportHypervVmReply", new List<string> {
                        "batchExportHypervVm",
                    }
                },
                {   "BatchExportNutanixVmReply", new List<string> {
                        "batchExportNutanixVm",
                    }
                },
                {   "BatchInstantRecoverHypervVmReply", new List<string> {
                        "batchInstantRecoverHypervVm",
                    }
                },
                {   "BatchMountHypervVmReply", new List<string> {
                        "batchMountHypervVm",
                    }
                },
                {   "BatchMountNutanixVmReply", new List<string> {
                        "batchMountNutanixVm",
                    }
                },
                {   "BatchOnDemandBackupHypervVmReply", new List<string> {
                        "batchOnDemandBackupHypervVm",
                    }
                },
                {   "BatchQuarantineSnapshotReply", new List<string> {
                        "batchQuarantineSnapshot",
                    }
                },
                {   "BatchReleaseFromQuarantineSnapshotReply", new List<string> {
                        "batchReleaseFromQuarantineSnapshot",
                    }
                },
                {   "BatchVmwareCdpLiveInfo", new List<string> {
                        "vsphereVmwareCdpLiveInfo",
                    }
                },
                {   "BatchVmwareVmRecoverableRanges", new List<string> {
                        "vsphereVMRecoverableRangeInBatch",
                    }
                },
                {   "BeginManagedVolumeSnapshotReply", new List<string> {
                        "beginManagedVolumeSnapshot",
                    }
                },
                {   "Boolean", new List<string> {
                        "addInventoryWorkloads",
                        "addRoleAssignments",
                        "areMultiGeoBackupsEnabled",
                        "batchDeassignRoleFromUserGroups",
                        "cancelActivitySeries",
                        "changePassword",
                        "cloudNativeCheckRequiredPermissionsForFeature",
                        "deleteCertificate",
                        "deleteCloudWorkloadSnapshot",
                        "deleteGuestCredentialById",
                        "deleteLdapPrincipals",
                        "deleteOrg",
                        "deleteRole",
                        "deleteServiceAccountsFromAccount",
                        "deleteTotpConfig",
                        "deleteTotpConfigs",
                        "deleteUsersFromAccount",
                        "doesAzureNativeResourceGroupExist",
                        "dummyFieldWithAdminOnlyTag",
                        "gcpCloudAccountAddManualAuthProject",
                        "gcpSetDefaultServiceAccountJwtConfig",
                        "hasIdpConfigured",
                        "inviteSsoGroup",
                        "isAwsNativeRdsInstanceLaunchConfigurationValid",
                        "isAwsS3BucketNameAvailable",
                        "isAzureNativeManagedDiskSnapshotRestorable",
                        "isAzureNativeSqlDatabaseSnapshotPersistent",
                        "isAzureStorageAccountNameAvailable",
                        "isSfdcReachable",
                        "isTotpAckNecessaryForCluster",
                        "isTotpMandatoryInTargetVersion",
                        "isVMwareManagementEnabled",
                        "patchAwsAuthenticationServerBasedCloudAccount",
                        "patchAwsIamUserBasedCloudAccount",
                        "removeCdmCluster",
                        "removeInventoryWorkloads",
                        "removeLdapIntegration",
                        "setAzureCloudAccountCustomerAppCredentials",
                        "setIpWhitelistEnabled",
                        "setLdapMfaSetting",
                        "setMfaSetting",
                        "setTotpConfig",
                        "setUserLevelTotpEnforcement",
                        "teamChannelNameAvailable",
                        "updateAccountOwner",
                        "updateCertificate",
                        "updateIpWhitelist",
                        "updateRole",
                        "updateRoleAssignments",
                        "upgradeAwsCloudAccountFeaturesWithoutCft",
                        "upgradeAwsIamUserBasedCloudAccountPermissions",
                        "warmSearchCache",
                    }
                },
                {   "BootstrappableNodeInfoListResponse", new List<string> {
                        "discoverNodes",
                    }
                },
                {   "BrowseMssqlDatabaseSnapshotReply", new List<string> {
                        "browseMssqlDatabaseSnapshot",
                    }
                },
                {   "BrowseResponseListResponse", new List<string> {
                        "filesetSnapshotFiles",
                        "nutanixBrowseSnapshot",
                    }
                },
                {   "BulkCreateFilesetTemplatesReply", new List<string> {
                        "bulkCreateFilesetTemplates",
                    }
                },
                {   "BulkCreateFilesetsReply", new List<string> {
                        "bulkCreateFilesets",
                    }
                },
                {   "BulkCreateNasFilesetsReply", new List<string> {
                        "bulkCreateNasFilesets",
                    }
                },
                {   "BulkDeleteAwsCloudAccountWithoutCftReply", new List<string> {
                        "bulkDeleteAwsCloudAccountWithoutCft",
                    }
                },
                {   "BulkOnDemandSnapshotNutanixVmReply", new List<string> {
                        "bulkOnDemandSnapshotNutanixVm",
                    }
                },
                {   "BulkRefreshHostsReply", new List<string> {
                        "bulkRefreshHosts",
                    }
                },
                {   "BulkRegisterHostReply", new List<string> {
                        "bulkRegisterHost",
                    }
                },
                {   "BulkUpdateFilesetTemplateReply", new List<string> {
                        "bulkUpdateFilesetTemplate",
                    }
                },
                {   "BulkUpdateHostReply", new List<string> {
                        "bulkUpdateHost",
                    }
                },
                {   "BulkUpdateMssqlDbsReply", new List<string> {
                        "bulkUpdateMssqlDbs",
                    }
                },
                {   "BulkUpdateOracleDatabasesReply", new List<string> {
                        "bulkUpdateOracleDatabases",
                    }
                },
                {   "BulkUpdateOracleHostsReply", new List<string> {
                        "bulkUpdateOracleHosts",
                    }
                },
                {   "BulkUpdateOracleRacsReply", new List<string> {
                        "bulkUpdateOracleRacs",
                    }
                },
                {   "CancelJobReply", new List<string> {
                        "cancelDownloadPackage",
                        "cancelScheduledUpgrade",
                    }
                },
                {   "CassandraColumnFamily", new List<string> {
                        "cassandraColumnFamily",
                    }
                },
                {   "CassandraColumnFamilyConnection", new List<string> {
                        "cassandraColumnFamilies",
                    }
                },
                {   "CassandraKeyspace", new List<string> {
                        "cassandraKeyspace",
                    }
                },
                {   "CassandraKeyspaceConnection", new List<string> {
                        "cassandraKeyspaces",
                    }
                },
                {   "CassandraSource", new List<string> {
                        "cassandraSource",
                    }
                },
                {   "CassandraSourceConnection", new List<string> {
                        "cassandraSources",
                    }
                },
                {   "CcProvisionJobReply", new List<string> {
                        "addNodesToCloudCluster",
                        "createAwsCluster",
                        "createAzureCluster",
                        "deleteAwsCluster",
                        "deleteAzureCluster",
                        "recoverCloudCluster",
                        "removeCloudClusterNodes",
                        "removeClusterNodes",
                    }
                },
                {   "CdmHierarchyObjectConnection", new List<string> {
                        "nasTopLevelDescendants",
                        "nutanixTopLevelDescendants",
                        "vSphereRootRecoveryHierarchy",
                        "vSphereTopLevelDescendantsConnection",
                    }
                },
                {   "CdmHierarchySnappableNew", new List<string> {
                        "cdmHierarchySnappableNew",
                    }
                },
                {   "CdmInventorySubHierarchyRoot", new List<string> {
                        "cdmInventorySubHierarchyRoot",
                    }
                },
                {   "CdmSnapshot", new List<string> {
                        "snapshot",
                    }
                },
                {   "CdmUpgradeAvailabilityReply", new List<string> {
                        "isUpgradeAvailable",
                    }
                },
                {   "CdmUpgradeRecommendationReply", new List<string> {
                        "isUpgradeRecommended",
                    }
                },
                {   "CdmUpgradeReleaseDetailsFromSupportPortalReply", new List<string> {
                        "getCdmReleaseDetailsForClusterFromSupportPortal",
                        "getCdmReleaseDetailsForVersionFromSupportPortal",
                        "getCdmReleaseDetailsFromSupportPortal",
                    }
                },
                {   "CdpVmInfoConnection", new List<string> {
                        "allCdpVmsInfos",
                    }
                },
                {   "CertificateConnection", new List<string> {
                        "certificates",
                        "certificatesWithKey",
                    }
                },
                {   "CertificateSummaryListResponse", new List<string> {
                        "clusterCertificates",
                    }
                },
                {   "ChangeVfdOnHostReply", new List<string> {
                        "changeVfdOnHost",
                    }
                },
                {   "CheckArchivedSnapshotsLockedReply", new List<string> {
                        "cloudNativeCheckArchivedSnapshotsLocked",
                    }
                },
                {   "CheckAzurePersistentStorageSubscriptionCanUnmapReply", new List<string> {
                        "checkAzurePersistentStorageSubscriptionCanUnmap",
                    }
                },
                {   "ClassificationPolicyDetail", new List<string> {
                        "createPolicy",
                        "policy",
                        "updatePolicy",
                    }
                },
                {   "ClassificationPolicyDetailConnection", new List<string> {
                        "policies",
                    }
                },
                {   "ClearCloudNativeSqlServerBackupCredentialsReply", new List<string> {
                        "clearCloudNativeSqlServerBackupCredentials",
                    }
                },
                {   "CloudAccount", new List<string> {
                        "cloudAccount",
                        "createAwsAccount",
                        "createAzureAccount",
                        "updateAwsAccount",
                        "updateAzureAccount",
                    }
                },
                {   "CloudDirectNasExport", new List<string> {
                        "cloudDirectNasExport",
                    }
                },
                {   "CloudDirectSystems", new List<string> {
                        "cloudDirectSystems",
                    }
                },
                {   "CloudNativeCheckRbaConnectivityReply", new List<string> {
                        "cloudNativeCheckRbaConnectivity",
                    }
                },
                {   "CloudNativeCustomerTagsReply", new List<string> {
                        "cloudNativeCustomerTags",
                    }
                },
                {   "CloudNativeSnapshotDetailsForRecoveryReply", new List<string> {
                        "cloudNativeSnapshotDetailsForRecovery",
                    }
                },
                {   "CloudNativeSnapshotTypeDetailsReply", new List<string> {
                        "cloudNativeSnapshotTypeDetails",
                    }
                },
                {   "CloudNativeSqlServerSetupScript", new List<string> {
                        "cloudNativeSqlServerSetupScript",
                    }
                },
                {   "CloudNativeVersionedFileConnection", new List<string> {
                        "cloudNativeWorkloadVersionedFiles",
                    }
                },
                {   "Cluster", new List<string> {
                        "cluster",
                        "updateClusterLocation",
                        "updatePreviewerClusterConfig",
                    }
                },
                {   "ClusterConnection", new List<string> {
                        "allClusterConnection",
                        "clusterConnection",
                        "clusterWithUpgradesInfo",
                        "radarClusterConnection",
                    }
                },
                {   "ClusterCsr", new List<string> {
                        "clusterCsr",
                    }
                },
                {   "ClusterDnsReply", new List<string> {
                        "clusterDns",
                    }
                },
                {   "ClusterGroupByConnection", new List<string> {
                        "clusterGroupByConnection",
                    }
                },
                {   "ClusterIpv6ModeReply", new List<string> {
                        "clusterIpv6Mode",
                    }
                },
                {   "ClusterLicenseCapacityValidations", new List<string> {
                        "validateClusterLicenseCapacity",
                    }
                },
                {   "ClusterOperationJobProgress", new List<string> {
                        "clusterOperationJobProgress",
                    }
                },
                {   "ClusterProxyReply", new List<string> {
                        "clusterProxy",
                    }
                },
                {   "ClusterRegistrationProductInfoType", new List<string> {
                        "clusterRegistrationProductInfo",
                    }
                },
                {   "ClusterRegistrationToken", new List<string> {
                        "generateClusterRegistrationToken",
                    }
                },
                {   "ClusterReportMigrationJobStatus", new List<string> {
                        "clusterReportMigrationJobStatus",
                    }
                },
                {   "ClusterSlaDomainConnection", new List<string> {
                        "clusterSlaDomains",
                    }
                },
                {   "ClusterWebSignedCertificateReply", new List<string> {
                        "clusterWebSignedCertificate",
                    }
                },
                {   "CompleteAzureAdAppSetupReply", new List<string> {
                        "completeAzureAdAppSetup",
                    }
                },
                {   "CompleteAzureCloudAccountOauthReply", new List<string> {
                        "completeAzureCloudAccountOauth",
                    }
                },
                {   "ComputeClusterDetail", new List<string> {
                        "computeClusterStatus",
                    }
                },
                {   "CountOfObjectsProtectedBySLAsResult", new List<string> {
                        "countOfObjectsProtectedBySlas",
                    }
                },
                {   "Crawl", new List<string> {
                        "crawl",
                    }
                },
                {   "CrawlConnection", new List<string> {
                        "crawls",
                    }
                },
                {   "CreateAwsExocomputeConfigsReply", new List<string> {
                        "createAwsExocomputeConfigs",
                    }
                },
                {   "CreateAzureSaasAppAadReply", new List<string> {
                        "createAzureSaasAppAad",
                    }
                },
                {   "CreateCloudNativeAwsStorageSettingReply", new List<string> {
                        "createCloudNativeAwsStorageSetting",
                    }
                },
                {   "CreateCloudNativeAzureStorageSettingReply", new List<string> {
                        "createCloudNativeAzureStorageSetting",
                    }
                },
                {   "CreateCloudNativeLabelRuleReply", new List<string> {
                        "createCloudNativeLabelRule",
                    }
                },
                {   "CreateCloudNativeRcvAzureStorageSettingReply", new List<string> {
                        "createCloudNativeRcvAzureStorageSetting",
                    }
                },
                {   "CreateCloudNativeTagRuleReply", new List<string> {
                        "createCloudNativeTagRule",
                    }
                },
                {   "CreateCustomReportReply", new List<string> {
                        "createCustomReport",
                    }
                },
                {   "CreateFailoverClusterAppReply", new List<string> {
                        "createFailoverClusterApp",
                    }
                },
                {   "CreateFailoverClusterReply", new List<string> {
                        "createFailoverCluster",
                    }
                },
                {   "CreateGuestCredentialReply", new List<string> {
                        "createGuestCredential",
                    }
                },
                {   "CreateIntegrationReply", new List<string> {
                        "createIntegration",
                    }
                },
                {   "CreateIntegrationsReply", new List<string> {
                        "createIntegrations",
                    }
                },
                {   "CreateK8sAgentManifestReply", new List<string> {
                        "createK8sAgentManifest",
                    }
                },
                {   "CreateK8sClusterReply", new List<string> {
                        "createK8sCluster",
                    }
                },
                {   "CreateO365AppKickoffResp", new List<string> {
                        "createO365AppKickoff",
                    }
                },
                {   "CreateOnDemandJobReply", new List<string> {
                        "backupO365SharepointList",
                        "backupO365SharePointSite",
                        "deleteAzureAdDirectory",
                        "deleteO365Org",
                        "exportK8sNamespace",
                        "exportO365Mailbox",
                        "refreshK8sCluster",
                        "refreshO365Org",
                        "restoreK8sNamespace",
                        "restoreO365Mailbox",
                        "restoreO365Snappable",
                        "restoreO365TeamsConversations",
                        "restoreO365TeamsFiles",
                    }
                },
                {   "CreateOrgReply", new List<string> {
                        "createOrg",
                    }
                },
                {   "CreateOrgSwitchSessionReply", new List<string> {
                        "createOrgSwitchSession",
                    }
                },
                {   "CreateRcvPrivateEndpointApprovalRequestReply", new List<string> {
                        "createRcvPrivateEndpointApprovalRequest",
                    }
                },
                {   "CreateScheduledReportReply", new List<string> {
                        "createScheduledReport",
                    }
                },
                {   "CreateServiceAccountReply", new List<string> {
                        "createServiceAccount",
                    }
                },
                {   "CreateVappsInstantRecoveryReply", new List<string> {
                        "createVappsInstantRecovery",
                    }
                },
                {   "CreateVsphereAdvancedTagReply", new List<string> {
                        "createVsphereAdvancedTag",
                    }
                },
                {   "CreateVsphereVcenterReply", new List<string> {
                        "createVsphereVcenter",
                    }
                },
                {   "CreateWebhookReply", new List<string> {
                        "createWebhook",
                    }
                },
                {   "Csr", new List<string> {
                        "certificateSigningRequest",
                        "generateCsr",
                    }
                },
                {   "CsrConnection", new List<string> {
                        "certificateSigningRequests",
                    }
                },
                {   "Db2Database", new List<string> {
                        "db2Database",
                    }
                },
                {   "Db2DatabaseConnection", new List<string> {
                        "db2Databases",
                    }
                },
                {   "Db2Instance", new List<string> {
                        "db2Instance",
                    }
                },
                {   "Db2InstanceConnection", new List<string> {
                        "db2Instances",
                    }
                },
                {   "Db2LogSnapshot", new List<string> {
                        "db2LogSnapshot",
                    }
                },
                {   "Db2LogSnapshotConnection", new List<string> {
                        "db2LogSnapshots",
                    }
                },
                {   "Db2RecoverableRange", new List<string> {
                        "db2RecoverableRange",
                    }
                },
                {   "Db2RecoverableRangeConnection", new List<string> {
                        "db2RecoverableRanges",
                    }
                },
                {   "DbLogReportProperties", new List<string> {
                        "databaseLogReportingPropertiesForCluster",
                        "updateDatabaseLogReportingPropertiesForCluster",
                    }
                },
                {   "DbLogReportSummaryListReply", new List<string> {
                        "databaseLogReportForCluster",
                    }
                },
                {   "DeleteAwsExocomputeConfigsReply", new List<string> {
                        "deleteAwsExocomputeConfigs",
                    }
                },
                {   "DeleteAzureCloudAccountExocomputeConfigurationsReply", new List<string> {
                        "deleteAzureCloudAccountExocomputeConfigurations",
                    }
                },
                {   "DeleteAzureCloudAccountReply", new List<string> {
                        "deleteAzureCloudAccount",
                    }
                },
                {   "DeleteAzureCloudAccountWithoutOauthReply", new List<string> {
                        "deleteAzureCloudAccountWithoutOauth",
                    }
                },
                {   "DeleteManagedVolumeReply", new List<string> {
                        "deleteManagedVolume",
                    }
                },
                {   "DeleteStorageArraysReply", new List<string> {
                        "deleteStorageArrays",
                    }
                },
                {   "DiffResult", new List<string> {
                        "diffFmd",
                        "searchFileByPrefix",
                    }
                },
                {   "DisableTargetReply", new List<string> {
                        "disableTarget",
                    }
                },
                {   "DiskInfo", new List<string> {
                        "setupDisk",
                    }
                },
                {   "DownloadCdmUpgradesPdfReply", new List<string> {
                        "downloadCdmUpgradesPdf",
                    }
                },
                {   "DownloadCsvReply", new List<string> {
                        "downloadObjectFilesCsv",
                        "downloadObjectsListCsv",
                        "downloadSnapshotResultsCsv",
                        "downloadUserActivityCsv",
                        "downloadUserFileActivityCsv",
                    }
                },
                {   "DownloadFilesReply", new List<string> {
                        "cloudNativeDownloadFiles",
                    }
                },
                {   "DownloadPackageReply", new List<string> {
                        "retryDownloadPackageJob",
                    }
                },
                {   "DownloadPackageStatusReply", new List<string> {
                        "downloadPackageStatus",
                    }
                },
                {   "DownloadResultsCsvReply", new List<string> {
                        "downloadResultsCsv",
                    }
                },
                {   "DownloadThreatHuntCsvReply", new List<string> {
                        "downloadThreatHuntCsv",
                    }
                },
                {   "EdgeWindowsToolLink", new List<string> {
                        "edgeWindowsToolLink",
                    }
                },
                {   "EnableAutomaticFmdUploadReply", new List<string> {
                        "enableAutomaticFmdUpload",
                    }
                },
                {   "EnableDisableAppConsistencyReply", new List<string> {
                        "enableDisableAppConsistency",
                    }
                },
                {   "EnableTargetReply", new List<string> {
                        "enableTarget",
                    }
                },
                {   "EndManagedVolumeSnapshotReply", new List<string> {
                        "endManagedVolumeSnapshot",
                    }
                },
                {   "ExchangeDag", new List<string> {
                        "exchangeDag",
                    }
                },
                {   "ExchangeDagConnection", new List<string> {
                        "exchangeDags",
                    }
                },
                {   "ExchangeDatabase", new List<string> {
                        "exchangeDatabase",
                    }
                },
                {   "ExchangeDatabaseConnection", new List<string> {
                        "exchangeDatabases",
                    }
                },
                {   "ExchangeLiveMountConnection", new List<string> {
                        "exchangeLiveMounts",
                    }
                },
                {   "ExchangeServer", new List<string> {
                        "exchangeServer",
                    }
                },
                {   "ExchangeServerConnection", new List<string> {
                        "exchangeServers",
                    }
                },
                {   "ExportUrlSpecs", new List<string> {
                        "decryptExportUrl",
                    }
                },
                {   "FailoverClusterApp", new List<string> {
                        "failoverClusterApp",
                    }
                },
                {   "FailoverClusterAppConnection", new List<string> {
                        "failoverClusterApps",
                    }
                },
                {   "FailoverClusterTopLevelDescendantTypeConnection", new List<string> {
                        "failoverClusterTopLevelDescendants",
                    }
                },
                {   "FeatureCdmVersionReply", new List<string> {
                        "cdmVersionCheck",
                    }
                },
                {   "FeatureListMinimumCdmVersionReply", new List<string> {
                        "minimumCdmVersionForFeatureSet",
                    }
                },
                {   "FederatedLoginStatus", new List<string> {
                        "federatedLoginStatus",
                    }
                },
                {   "FileResultConnection", new List<string> {
                        "objectFiles",
                        "userActivities",
                    }
                },
                {   "FilesetSnapshotDetail", new List<string> {
                        "filesetSnapshot",
                    }
                },
                {   "FilesetTemplate", new List<string> {
                        "filesetTemplate",
                    }
                },
                {   "FilesetTemplateConnection", new List<string> {
                        "filesetTemplates",
                    }
                },
                {   "FinalizeAwsCloudAccountDeletionReply", new List<string> {
                        "finalizeAwsCloudAccountDeletion",
                    }
                },
                {   "FinalizeAwsCloudAccountProtectionReply", new List<string> {
                        "finalizeAwsCloudAccountProtection",
                    }
                },
                {   "GcpCloudAccountAddProjectsReply", new List<string> {
                        "gcpCloudAccountAddProjects",
                    }
                },
                {   "GcpCloudAccountDeleteProjectsReply", new List<string> {
                        "gcpCloudAccountDeleteProjects",
                    }
                },
                {   "GcpCloudAccountOauthCompleteReply", new List<string> {
                        "gcpCloudAccountOauthComplete",
                    }
                },
                {   "GcpCloudAccountOauthInitiateReply", new List<string> {
                        "gcpCloudAccountOauthInitiate",
                    }
                },
                {   "GcpCloudAccountUpgradeProjectsReply", new List<string> {
                        "gcpCloudAccountUpgradeProjects",
                    }
                },
                {   "GcpNativeDisk", new List<string> {
                        "gcpNativeDisk",
                    }
                },
                {   "GcpNativeDiskConnection", new List<string> {
                        "gcpNativeDisks",
                    }
                },
                {   "GcpNativeGceInstance", new List<string> {
                        "gcpNativeGceInstance",
                    }
                },
                {   "GcpNativeGceInstanceConnection", new List<string> {
                        "gcpNativeGceInstances",
                    }
                },
                {   "GcpNativeProject", new List<string> {
                        "gcpNativeProject",
                    }
                },
                {   "GcpNativeProjectConnection", new List<string> {
                        "gcpNativeProjects",
                    }
                },
                {   "GenerateConfigProtectionRestoreFormReply", new List<string> {
                        "generateConfigProtectionRestoreForm",
                    }
                },
                {   "GenerateTotpSecretReply", new List<string> {
                        "generateTotpSecret",
                    }
                },
                {   "GenericSnapshotConnection", new List<string> {
                        "snapshotOfASnappableConnection",
                        "snapshotOfSnappablesConnection",
                    }
                },
                {   "GetAnomalyDetailsReply", new List<string> {
                        "anomalyResultOpt",
                    }
                },
                {   "GetAzureHostTypeResp", new List<string> {
                        "azureO365GetAzureHostType",
                    }
                },
                {   "GetAzureO365ExocomputeResp", new List<string> {
                        "azureO365Exocompute",
                    }
                },
                {   "GetCloudNativeLabelRulesReply", new List<string> {
                        "cloudNativeLabelRules",
                    }
                },
                {   "GetCloudNativeTagRulesReply", new List<string> {
                        "cloudNativeTagRules",
                    }
                },
                {   "GetDashboardSummaryReply", new List<string> {
                        "dashboardSummary",
                    }
                },
                {   "GetHealthMonitorPolicyStatusReply", new List<string> {
                        "getHealthMonitorPolicyStatus",
                    }
                },
                {   "GetImplicitlyAuthorizedAncestorSummariesResponse", new List<string> {
                        "o365ObjectAncestors",
                    }
                },
                {   "GetImplicitlyAuthorizedObjectSummariesResponse", new List<string> {
                        "o365OrgSummaries",
                    }
                },
                {   "GetLicensedProductsInfoReply", new List<string> {
                        "allLicensedProducts",
                    }
                },
                {   "GetMfaSettingReply", new List<string> {
                        "globalMfaSetting",
                        "mfaSetting",
                    }
                },
                {   "GetMosaicRecoverableRangeResponse", new List<string> {
                        "cassandraColumnFamilyRecoverableRange",
                        "mongodbCollectionRecoverableRange",
                    }
                },
                {   "GetO365ServiceStatusResp", new List<string> {
                        "o365ServiceStatus",
                    }
                },
                {   "GetO365StorageStatsResp", new List<string> {
                        "o365StorageStats",
                    }
                },
                {   "GetPendingSlaAssignmentsReply", new List<string> {
                        "getPendingSlaAssignments",
                    }
                },
                {   "GetPipelineHealthReply", new List<string> {
                        "pipelineHealthForTimeRange",
                    }
                },
                {   "GetPoliciesTimelineReply", new List<string> {
                        "discoveryTimeline",
                    }
                },
                {   "GetS3BucketStateForRecoveryReply", new List<string> {
                        "s3BucketStateForRecovery",
                    }
                },
                {   "GetSchemaResponse", new List<string> {
                        "cassandraColumnFamilySchema",
                    }
                },
                {   "GetSmbConfigurationReply", new List<string> {
                        "smbConfiguration",
                    }
                },
                {   "GetTaskchainStatusReply", new List<string> {
                        "getKorgTaskchainStatus",
                    }
                },
                {   "GetTotpStatusReply", new List<string> {
                        "totpConfigStatus",
                    }
                },
                {   "GetUserDetailReply", new List<string> {
                        "userDetail",
                    }
                },
                {   "GetUserSessionManagementConfigReply", new List<string> {
                        "userSessionManagementConfig",
                    }
                },
                {   "GetWhitelistReply", new List<string> {
                        "ipWhitelist",
                    }
                },
                {   "GetWorkloadAlertSettingReply", new List<string> {
                        "workloadAlertSetting",
                    }
                },
                {   "GlobalFileSearchReply", new List<string> {
                        "globalFileSearch",
                    }
                },
                {   "GlobalManagerConnectivity", new List<string> {
                        "refreshGlobalManagerConnectivityStatus",
                    }
                },
                {   "GlobalSlaForFilterConnection", new List<string> {
                        "globalSlaFilterConnection",
                    }
                },
                {   "GlobalSlaReply", new List<string> {
                        "createGlobalSla",
                        "updateGlobalSla",
                    }
                },
                {   "GlobalSlaStatusConnection", new List<string> {
                        "globalSlaStatuses",
                    }
                },
                {   "GroupConnection", new List<string> {
                        "groupsInCurrentAndDescendantOrganization",
                    }
                },
                {   "GroupCountListWithTotal", new List<string> {
                        "getGroupCountByCdmClusterStatus",
                    }
                },
                {   "GuestCredentialDetailListResponse", new List<string> {
                        "guestCredentials",
                    }
                },
                {   "GuestOsCredentialConnection", new List<string> {
                        "guestCredentialsV2",
                    }
                },
                {   "HelpContentSnippetConnection", new List<string> {
                        "helpContentSnippets",
                    }
                },
                {   "HierarchyObject", new List<string> {
                        "hierarchyObject",
                    }
                },
                {   "HierarchyObjectConnection", new List<string> {
                        "globalSearchResults",
                    }
                },
                {   "HierarchySnappableConnection", new List<string> {
                        "hierarchySnappables",
                    }
                },
                {   "HostDiagnosisSummary", new List<string> {
                        "hostDiagnosis",
                    }
                },
                {   "HostFailoverCluster", new List<string> {
                        "hostFailoverCluster",
                    }
                },
                {   "HostFailoverClusterConnection", new List<string> {
                        "hostFailoverClusters",
                    }
                },
                {   "HostShare", new List<string> {
                        "hostShare",
                    }
                },
                {   "HostShareConnection", new List<string> {
                        "hostShares",
                    }
                },
                {   "HotAddBandwidthInfo", new List<string> {
                        "vCenterHotAddBandwidth",
                    }
                },
                {   "HotAddNetworkConfigWithName", new List<string> {
                        "vCenterHotAddNetwork",
                    }
                },
                {   "HyperVCluster", new List<string> {
                        "hypervCluster",
                    }
                },
                {   "HyperVLiveMountConnection", new List<string> {
                        "hypervMounts",
                    }
                },
                {   "HyperVSCVMM", new List<string> {
                        "hypervScvmm",
                    }
                },
                {   "HyperVSCVMMConnection", new List<string> {
                        "hypervScvmms",
                    }
                },
                {   "HyperVVirtualMachine", new List<string> {
                        "hypervVirtualMachine",
                    }
                },
                {   "HyperVVirtualMachineConnection", new List<string> {
                        "hypervVirtualMachines",
                    }
                },
                {   "HypervHostSummaryListResponse", new List<string> {
                        "hypervServers",
                    }
                },
                {   "HypervScvmmUpdateReply", new List<string> {
                        "hypervScvmmUpdate",
                    }
                },
                {   "HypervServer", new List<string> {
                        "hypervServer",
                    }
                },
                {   "HypervTopLevelDescendantTypeConnection", new List<string> {
                        "hypervTopLevelDescendants",
                    }
                },
                {   "HypervVirtualMachineDetail", new List<string> {
                        "hypervVmDetail",
                    }
                },
                {   "Int", new List<string> {
                        "maxProtectedAppsCount",
                        "uniqueHypervServersCount",
                        "uniqueVcdCount",
                        "vCenterNumProxiesNeeded",
                    }
                },
                {   "InternalGetClusterIpsResponse", new List<string> {
                        "clusterFloatingIps",
                    }
                },
                {   "InternalGetDefaultGatewayResponse", new List<string> {
                        "clusterDefaultGateway",
                    }
                },
                {   "InternalReplicationBandwidthIncomingResponse", new List<string> {
                        "replicationIncomingStats",
                    }
                },
                {   "InternalReplicationBandwidthOutgoingResponse", new List<string> {
                        "replicationOutgoingStats",
                    }
                },
                {   "InventoryRoot", new List<string> {
                        "inventoryRoot",
                    }
                },
                {   "InventorySubHierarchyRoot", new List<string> {
                        "inventorySubHierarchyRoot",
                    }
                },
                {   "InvestigationCsvDownloadLinkReply", new List<string> {
                        "investigationCsvDownloadLink",
                    }
                },
                {   "IsCloudNativeTagRuleNameUniqueReply", new List<string> {
                        "checkCloudNativeLabelRuleNameUniqueness",
                        "checkCloudNativeTagRuleNameUniqueness",
                    }
                },
                {   "IsVolumeSnapshotRestorableReply", new List<string> {
                        "isAwsNativeEbsVolumeSnapshotRestorable",
                    }
                },
                {   "Issue", new List<string> {
                        "issue",
                    }
                },
                {   "IssueConnection", new List<string> {
                        "issues",
                    }
                },
                {   "K8sAppManifest", new List<string> {
                        "k8sAppManifest",
                    }
                },
                {   "K8sCluster", new List<string> {
                        "k8sCluster",
                    }
                },
                {   "K8sClusterConnection", new List<string> {
                        "k8sClusters",
                    }
                },
                {   "K8sNamespace", new List<string> {
                        "k8sNamespace",
                    }
                },
                {   "K8sNamespaceConnection", new List<string> {
                        "k8sNamespaces",
                    }
                },
                {   "K8sSnapshotInfo", new List<string> {
                        "k8sSnapshotInfo",
                    }
                },
                {   "KnowledgeBaseArticle", new List<string> {
                        "knowledgeBaseArticle",
                    }
                },
                {   "LambdaSettings", new List<string> {
                        "lambdaSettings",
                        "updateLambdaSettings",
                    }
                },
                {   "LdapIntegrationConnection", new List<string> {
                        "ldapIntegrationConnection",
                    }
                },
                {   "LegalHoldSnappableDetailConnection", new List<string> {
                        "snappablesWithLegalHoldSnapshotsSummary",
                    }
                },
                {   "LegalHoldSnapshotDetailConnection", new List<string> {
                        "legalHoldSnapshotsForSnappable",
                    }
                },
                {   "LicensesForClusterProductReply", new List<string> {
                        "licensesForClusterProductSummary",
                    }
                },
                {   "LinuxFileset", new List<string> {
                        "linuxFileset",
                    }
                },
                {   "ListCidrsForComputeSettingReply", new List<string> {
                        "listCidrsForComputeSetting",
                    }
                },
                {   "ListIntegrationsReply", new List<string> {
                        "allIntegrations",
                    }
                },
                {   "ListLocationsReply", new List<string> {
                        "ransomwareDetectionWorkloadLocations",
                    }
                },
                {   "ListStoreResponse", new List<string> {
                        "mosaicStores",
                    }
                },
                {   "ListStoredDiskLocationsReply", new List<string> {
                        "gcpNativeStoredDiskLocations",
                    }
                },
                {   "ListVersionResponse", new List<string> {
                        "mosaicSnapshots",
                        "mosaicVersions",
                    }
                },
                {   "LockoutConfig", new List<string> {
                        "globalLockoutConfig",
                        "lockoutConfig",
                    }
                },
                {   "LookupAccountReply", new List<string> {
                        "lookupAccount",
                    }
                },
                {   "M365RegionsResp", new List<string> {
                        "m365Regions",
                    }
                },
                {   "ManagedVolume", new List<string> {
                        "managedVolume",
                        "slaManagedVolume",
                    }
                },
                {   "ManagedVolumeConnection", new List<string> {
                        "managedVolumes",
                        "slaManagedVolumes",
                    }
                },
                {   "ManagedVolumeInventoryStats", new List<string> {
                        "managedVolumeInventoryStats",
                    }
                },
                {   "ManagedVolumeMountConnection", new List<string> {
                        "managedVolumeLiveMounts",
                    }
                },
                {   "MapAzureCloudAccountExocomputeSubscriptionReply", new List<string> {
                        "mapAzureCloudAccountExocomputeSubscription",
                    }
                },
                {   "MapAzureCloudAccountToPersistentStorageLocationReply", new List<string> {
                        "mapAzureCloudAccountToPersistentStorageLocation",
                    }
                },
                {   "MapCloudAccountExocomputeAccountReply", new List<string> {
                        "mapCloudAccountExocomputeAccount",
                    }
                },
                {   "MissedSnapshotListResponse", new List<string> {
                        "mssqlDatabaseMissedSnapshots",
                        "nutanixVmMissedSnapshots",
                        "oracleMissedSnapshots",
                    }
                },
                {   "ModifyIpmiReply", new List<string> {
                        "clusterIpmi",
                        "modifyIpmi",
                    }
                },
                {   "MongoCollection", new List<string> {
                        "mongoCollection",
                    }
                },
                {   "MongoCollectionConnection", new List<string> {
                        "mongoCollections",
                    }
                },
                {   "MongoDatabase", new List<string> {
                        "mongoDatabase",
                    }
                },
                {   "MongoDatabaseConnection", new List<string> {
                        "mongoDatabases",
                    }
                },
                {   "MongoRecoverableRanges", new List<string> {
                        "mongoBulkRecoverableRanges",
                        "mongoRecoverableRanges",
                    }
                },
                {   "MongoSource", new List<string> {
                        "mongoSource",
                    }
                },
                {   "MongoSourceConnection", new List<string> {
                        "mongoSources",
                    }
                },
                {   "MongodbCollection", new List<string> {
                        "mongodbCollection",
                    }
                },
                {   "MongodbCollectionConnection", new List<string> {
                        "mongodbCollections",
                    }
                },
                {   "MongodbDatabase", new List<string> {
                        "mongodbDatabase",
                    }
                },
                {   "MongodbDatabaseConnection", new List<string> {
                        "mongodbDatabases",
                    }
                },
                {   "MongodbSource", new List<string> {
                        "mongodbSource",
                    }
                },
                {   "MongodbSourceConnection", new List<string> {
                        "mongodbSources",
                    }
                },
                {   "MosaicAsyncResponse", new List<string> {
                        "addMosaicStore",
                        "bulkDeleteCassandraSources",
                        "bulkDeleteMongodbSources",
                        "createCassandraSource",
                        "createMongodbSource",
                        "deleteCassandraSource",
                        "deleteMongodbSource",
                        "deleteMosaicStore",
                        "recoverCassandraSource",
                        "recoverMongodbSource",
                        "updateCassandraSource",
                        "updateMongodbSource",
                        "updateMosaicStore",
                    }
                },
                {   "MosaicRecoveryRangeResponse", new List<string> {
                        "mongodbBulkRecoverableRange",
                        "mosaicBulkRecoveryRange",
                    }
                },
                {   "MountDiskReply", new List<string> {
                        "mountDisk",
                    }
                },
                {   "MssqlAvailabilityGroup", new List<string> {
                        "mssqlAvailabilityGroup",
                    }
                },
                {   "MssqlDatabase", new List<string> {
                        "mssqlDatabase",
                    }
                },
                {   "MssqlDatabaseConnection", new List<string> {
                        "mssqlDatabases",
                    }
                },
                {   "MssqlDatabaseLiveMountConnection", new List<string> {
                        "mssqlDatabaseLiveMounts",
                    }
                },
                {   "MssqlInstance", new List<string> {
                        "mssqlInstance",
                    }
                },
                {   "MssqlInstanceSummaryListResponse", new List<string> {
                        "mssqlCompatibleInstances",
                    }
                },
                {   "MssqlLogShippingSummaryV2ListResponse", new List<string> {
                        "mssqlLogShippingTargets",
                    }
                },
                {   "MssqlLogShippingTarget", new List<string> {
                        "cdmMssqlLogShippingTarget",
                    }
                },
                {   "MssqlLogShippingTargetConnection", new List<string> {
                        "cdmMssqlLogShippingTargets",
                    }
                },
                {   "MssqlMissedRecoverableRangeListResponse", new List<string> {
                        "mssqlDatabaseMissedRecoverableRanges",
                    }
                },
                {   "MssqlRecoverableRangeListResponse", new List<string> {
                        "mssqlRecoverableRanges",
                    }
                },
                {   "MssqlRestoreEstimateResult", new List<string> {
                        "mssqlDatabaseRestoreEstimate",
                    }
                },
                {   "MssqlTopLevelDescendantTypeConnection", new List<string> {
                        "mssqlTopLevelDescendants",
                    }
                },
                {   "NasFileset", new List<string> {
                        "nasFileset",
                    }
                },
                {   "NasNamespace", new List<string> {
                        "nasNamespace",
                    }
                },
                {   "NasNamespaceConnection", new List<string> {
                        "nasNamespaces",
                    }
                },
                {   "NasShare", new List<string> {
                        "nasShare",
                    }
                },
                {   "NasSystem", new List<string> {
                        "nasSystem",
                    }
                },
                {   "NasSystemConnection", new List<string> {
                        "nasSystems",
                    }
                },
                {   "NasVolume", new List<string> {
                        "nasVolume",
                    }
                },
                {   "NcdBackEndCapacity", new List<string> {
                        "ncdBackEndCapacity",
                    }
                },
                {   "NcdFrontEndCapacity", new List<string> {
                        "ncdFrontEndCapacity",
                    }
                },
                {   "NcdObjectProtectionStatus", new List<string> {
                        "ncdObjectProtectionStatus",
                    }
                },
                {   "NetworkInfoListResponse", new List<string> {
                        "vCenterNetworks",
                    }
                },
                {   "NetworkInterfaceListResponse", new List<string> {
                        "clusterNetworkInterfaces",
                    }
                },
                {   "NetworkThrottleSummaryListResponse", new List<string> {
                        "networkThrottle",
                    }
                },
                {   "NfAnomalyResultConnection", new List<string> {
                        "nfAnomalyResults",
                    }
                },
                {   "NfAnomalyResultGroupedDataConnection", new List<string> {
                        "nfAnomalyResultsGrouped",
                    }
                },
                {   "NodeRemovalCancelPermissionReply", new List<string> {
                        "nodeRemovalCancelPermission",
                    }
                },
                {   "NodeStatusListResponse", new List<string> {
                        "clusterNodes",
                    }
                },
                {   "NodeToReplaceReply", new List<string> {
                        "nodeToReplace",
                    }
                },
                {   "NotificationForGetLicenseReply", new List<string> {
                        "notificationForGetLicense",
                    }
                },
                {   "NtpServerConfigurationListResponse", new List<string> {
                        "clusterNtpServers",
                    }
                },
                {   "NutanixCategory", new List<string> {
                        "nutanixCategory",
                    }
                },
                {   "NutanixCategoryValue", new List<string> {
                        "nutanixCategoryValue",
                    }
                },
                {   "NutanixCluster", new List<string> {
                        "nutanixCluster",
                    }
                },
                {   "NutanixClusterConnection", new List<string> {
                        "nutanixClusters",
                    }
                },
                {   "NutanixContainerListResponse", new List<string> {
                        "nutanixClusterContainers",
                    }
                },
                {   "NutanixLiveMountConnection", new List<string> {
                        "nutanixMounts",
                    }
                },
                {   "NutanixNetworkListResponse", new List<string> {
                        "nutanixClusterNetworks",
                    }
                },
                {   "NutanixPrismCentral", new List<string> {
                        "nutanixPrismCentral",
                    }
                },
                {   "NutanixPrismCentralConnection", new List<string> {
                        "nutanixPrismCentrals",
                    }
                },
                {   "NutanixVm", new List<string> {
                        "nutanixVm",
                    }
                },
                {   "NutanixVmConnection", new List<string> {
                        "nutanixVms",
                    }
                },
                {   "NutanixVmSnapshotDetail", new List<string> {
                        "nutanixSnapshotDetail",
                    }
                },
                {   "O365AppConnection", new List<string> {
                        "listO365Apps",
                    }
                },
                {   "O365Calendar", new List<string> {
                        "o365Calendar",
                    }
                },
                {   "O365ConfiguredGroupMemberConnection", new List<string> {
                        "configuredGroupMembers",
                    }
                },
                {   "O365ExchangeObjectConnection", new List<string> {
                        "browseCalendar",
                        "browseContacts",
                        "browseFolder",
                        "snappableContactSearch",
                        "snappableEmailSearch",
                        "snappableEventSearch",
                        "snapshotEmailSearch",
                        "snapshotEventSearch",
                    }
                },
                {   "O365FullSpObjectConnection", new List<string> {
                        "sharepointSiteDescendants",
                        "sharepointSiteSearch",
                    }
                },
                {   "O365GroupConnection", new List<string> {
                        "o365Groups",
                    }
                },
                {   "O365License", new List<string> {
                        "o365License",
                    }
                },
                {   "O365Mailbox", new List<string> {
                        "o365Mailbox",
                    }
                },
                {   "O365MailboxConnection", new List<string> {
                        "o365Mailboxes",
                    }
                },
                {   "O365OauthConsentCompleteReply", new List<string> {
                        "o365OauthConsentComplete",
                    }
                },
                {   "O365OauthConsentKickoffReply", new List<string> {
                        "o365OauthConsentKickoff",
                    }
                },
                {   "O365Onedrive", new List<string> {
                        "o365Onedrive",
                    }
                },
                {   "O365OnedriveConnection", new List<string> {
                        "o365Onedrives",
                    }
                },
                {   "O365OnedriveObjectConnection", new List<string> {
                        "browseOnedrive",
                        "browseSharepointDrive",
                        "browseSharepointList",
                        "browseTeamsDrive",
                        "snappableOnedriveSearch",
                        "snappableSharepointDriveSearch",
                        "snappableSharepointListSearch",
                        "snappableTeamsDriveSearch",
                        "snapshotOnedriveSearch",
                        "snapshotSharepointDriveSearch",
                    }
                },
                {   "O365Org", new List<string> {
                        "o365Org",
                        "o365OrgAtSnappableLevel",
                    }
                },
                {   "O365OrgConnection", new List<string> {
                        "o365Orgs",
                    }
                },
                {   "O365PdlGroupsReply", new List<string> {
                        "o365PdlGroups",
                    }
                },
                {   "O365SaasSetupKickoffReply", new List<string> {
                        "o365SaaSSetupKickoff",
                    }
                },
                {   "O365ServiceAccountStatusResp", new List<string> {
                        "o365ServiceAccount",
                    }
                },
                {   "O365SetupKickoffResp", new List<string> {
                        "o365SetupKickoff",
                    }
                },
                {   "O365SharepointDrive", new List<string> {
                        "o365SharepointDrive",
                    }
                },
                {   "O365SharepointDriveConnection", new List<string> {
                        "o365SharepointDrives",
                    }
                },
                {   "O365SharepointList", new List<string> {
                        "o365SharepointList",
                    }
                },
                {   "O365SharepointListConnection", new List<string> {
                        "o365SharepointLists",
                    }
                },
                {   "O365SharepointObjectConnection", new List<string> {
                        "o365SharepointObjectList",
                        "o365SharepointObjects",
                    }
                },
                {   "O365Site", new List<string> {
                        "o365SharepointSite",
                        "o365Site",
                    }
                },
                {   "O365SiteConnection", new List<string> {
                        "o365SharepointSites",
                        "o365Sites",
                    }
                },
                {   "O365TeamConvChannelConnection", new List<string> {
                        "browseO365TeamConvChannels",
                    }
                },
                {   "O365TeamConversationsSenderConnection", new List<string> {
                        "o365TeamPostedBy",
                    }
                },
                {   "O365Teams", new List<string> {
                        "o365Team",
                    }
                },
                {   "O365TeamsChannelConnection", new List<string> {
                        "browseTeamsChannels",
                        "o365TeamChannels",
                    }
                },
                {   "O365TeamsConnection", new List<string> {
                        "o365Teams",
                    }
                },
                {   "O365TeamsConversationsConnection", new List<string> {
                        "snappableTeamsConversationsSearch",
                    }
                },
                {   "O365User", new List<string> {
                        "o365User",
                    }
                },
                {   "O365UserDescendantMetadataConnection", new List<string> {
                        "o365UserObjects",
                    }
                },
                {   "OauthCodesForEdgeRegReply", new List<string> {
                        "oauthCodesForEdgeReg",
                    }
                },
                {   "OracleAcoParameterList", new List<string> {
                        "oracleAcoParameters",
                    }
                },
                {   "OracleDataGuardGroup", new List<string> {
                        "oracleDataGuardGroup",
                    }
                },
                {   "OracleDatabase", new List<string> {
                        "oracleDatabase",
                    }
                },
                {   "OracleDatabaseConnection", new List<string> {
                        "oracleDatabases",
                    }
                },
                {   "OracleDbDetail", new List<string> {
                        "updateOracleDataGuardGroup",
                    }
                },
                {   "OracleFileDownloadLink", new List<string> {
                        "oracleAcoExampleDownloadLink",
                    }
                },
                {   "OracleHost", new List<string> {
                        "oracleHost",
                    }
                },
                {   "OracleLiveMountConnection", new List<string> {
                        "oracleLiveMounts",
                    }
                },
                {   "OracleLogBackupConfig", new List<string> {
                        "oracleDatabaseLogBackupConfig",
                        "oracleHostLogBackupConfig",
                        "oracleRacLogBackupConfig",
                    }
                },
                {   "OracleMissedRecoverableRangeListResponse", new List<string> {
                        "oracleMissedRecoverableRanges",
                    }
                },
                {   "OraclePdbDetails", new List<string> {
                        "oraclePdbDetails",
                    }
                },
                {   "OracleRac", new List<string> {
                        "oracleRac",
                    }
                },
                {   "OracleRecoverableRangeListResponse", new List<string> {
                        "oracleRecoverableRanges",
                    }
                },
                {   "OracleTopLevelDescendantTypeConnection", new List<string> {
                        "oracleTopLevelDescendants",
                    }
                },
                {   "Org", new List<string> {
                        "currentOrg",
                        "org",
                    }
                },
                {   "OrgConnection", new List<string> {
                        "orgs",
                    }
                },
                {   "OrgSecurityPolicy", new List<string> {
                        "orgSecurityPolicy",
                    }
                },
                {   "OrgsForPrincipalReply", new List<string> {
                        "orgsForPrincipal",
                    }
                },
                {   "OverallRansomwareInvestigationSummary", new List<string> {
                        "overallRansomwareInvestigationSummary",
                    }
                },
                {   "PasswordComplexityPolicy", new List<string> {
                        "passwordComplexityPolicy",
                    }
                },
                {   "PatchDb2DatabaseReply", new List<string> {
                        "patchDb2Database",
                    }
                },
                {   "PatchDb2InstanceReply", new List<string> {
                        "patchDb2Instance",
                    }
                },
                {   "PatchNutanixMountV1Reply", new List<string> {
                        "patchNutanixMountV1",
                    }
                },
                {   "PatchSapHanaSystemReply", new List<string> {
                        "patchSapHanaSystem",
                    }
                },
                {   "PauseSlaReply", new List<string> {
                        "pauseSla",
                    }
                },
                {   "PauseTargetReply", new List<string> {
                        "pauseTarget",
                    }
                },
                {   "PendingEvaluationResultsReply", new List<string> {
                        "pendingRansomwareInvestigationResultsCount",
                    }
                },
                {   "PhoenixRolloutProgress", new List<string> {
                        "phoenixRolloutProgress",
                    }
                },
                {   "PhysicalHost", new List<string> {
                        "physicalHost",
                    }
                },
                {   "PhysicalHostConnection", new List<string> {
                        "physicalHosts",
                    }
                },
                {   "PolarisInventorySubHierarchyRoot", new List<string> {
                        "polarisInventorySubHierarchyRoot",
                    }
                },
                {   "PolarisSnapshot", new List<string> {
                        "polarisSnapshot",
                    }
                },
                {   "PolicyDetailConnection", new List<string> {
                        "policyDetails",
                    }
                },
                {   "PolicyObj", new List<string> {
                        "policyObj",
                    }
                },
                {   "PolicyObjConnection", new List<string> {
                        "policyObjs",
                    }
                },
                {   "PolicyObjectUsageConnection", new List<string> {
                        "policyObjectUsages",
                    }
                },
                {   "PrechecksJobReply", new List<string> {
                        "startPeriodicUpgradePrechecksOnDemandJob",
                    }
                },
                {   "PrechecksStatusReply", new List<string> {
                        "prechecksStatus",
                        "prechecksStatusWithNextJobInfo",
                    }
                },
                {   "PrepareAwsCloudAccountDeletionReply", new List<string> {
                        "prepareAwsCloudAccountDeletion",
                    }
                },
                {   "PrepareFeatureUpdateForAwsCloudAccountReply", new List<string> {
                        "prepareFeatureUpdateForAwsCloudAccount",
                    }
                },
                {   "PrincipalConnection", new List<string> {
                        "ldapPrincipalConnection",
                    }
                },
                {   "ProcessedRansomwareInvestigationWorkloadCountReply", new List<string> {
                        "processedRansomwareInvestigationWorkloadCount",
                    }
                },
                {   "ProductDocumentation", new List<string> {
                        "productDocumentation",
                    }
                },
                {   "ProtectedObjectsConnection", new List<string> {
                        "protectedObjectsConnection",
                    }
                },
                {   "ProtectedRansomwareInvestigationWorkloadCountReply", new List<string> {
                        "protectedRansomwareInvestigationWorkloadCount",
                    }
                },
                {   "PutSmbConfigurationReply", new List<string> {
                        "putSmbConfiguration",
                    }
                },
                {   "QueryDatastoreFreespaceThresholdsReply", new List<string> {
                        "queryDatastoreFreespaceThresholds",
                    }
                },
                {   "QuerySDDLReply", new List<string> {
                        "datagovSecDesc",
                    }
                },
                {   "RansomwareInvestigationAnalysisSummaryReply", new List<string> {
                        "ransomwareInvestigationAnalysisSummary",
                    }
                },
                {   "RansomwareInvestigationEnablementReply", new List<string> {
                        "ransomwareInvestigationEnablement",
                    }
                },
                {   "RansomwareInvestigationWorkloadScannedCountReply", new List<string> {
                        "ransomwareInvestigationWorkloadScannedCount",
                    }
                },
                {   "RansomwareResult", new List<string> {
                        "ransomwareResult",
                        "ransomwareResultOpt",
                    }
                },
                {   "RansomwareResultConnection", new List<string> {
                        "ransomwareResults",
                    }
                },
                {   "RansomwareResultGroupedDataConnection", new List<string> {
                        "ransomwareResultsGrouped",
                    }
                },
                {   "RbaInstallerUrls", new List<string> {
                        "cloudNativeRbaInstallers",
                    }
                },
                {   "RcsAzureArchivalLocationsConsumptionStatsOutput", new List<string> {
                        "rcsArchivalLocationsConsumptionStats",
                    }
                },
                {   "RcvAccountEntitlement", new List<string> {
                        "rcvAccountEntitlement",
                    }
                },
                {   "RdsInstanceDetailsFromAws", new List<string> {
                        "rdsInstanceDetailsFromAws",
                    }
                },
                {   "RdsInstanceExportDefaults", new List<string> {
                        "awsNativeRdsExportDefaults",
                    }
                },
                {   "ReadIntegrationReply", new List<string> {
                        "integration",
                    }
                },
                {   "RecoverableRangeResponse", new List<string> {
                        "vsphereVMMissedRecoverableRange",
                        "vsphereVMRecoverableRange",
                    }
                },
                {   "RefreshHostReply", new List<string> {
                        "refreshHost",
                    }
                },
                {   "RefreshNasSystemsReply", new List<string> {
                        "refreshNasSystems",
                    }
                },
                {   "RefreshStorageArraysReply", new List<string> {
                        "refreshStorageArrays",
                    }
                },
                {   "RegionConnection", new List<string> {
                        "azureRegions",
                    }
                },
                {   "RegisterAwsFeatureArtifactsReply", new List<string> {
                        "registerAwsFeatureArtifacts",
                    }
                },
                {   "RegisterCloudClusterReply", new List<string> {
                        "registerCloudCluster",
                    }
                },
                {   "RegisterNasSystemReply", new List<string> {
                        "registerNasSystem",
                    }
                },
                {   "RemoveNodeForReplacementReply", new List<string> {
                        "removeNodeForReplacement",
                    }
                },
                {   "RemoveVlansReply", new List<string> {
                        "removeVlans",
                    }
                },
                {   "ReplaceClusterNodeReply", new List<string> {
                        "replaceClusterNode",
                    }
                },
                {   "ReplicationPairConnection", new List<string> {
                        "replicationPairs",
                    }
                },
                {   "ReportMigrationStatusConnection", new List<string> {
                        "clusterReportMigrationStatus",
                    }
                },
                {   "ReportsMigrationCount", new List<string> {
                        "clusterReportMigrationCount",
                    }
                },
                {   "RequestStatus", new List<string> {
                        "addAdGroupsToHierarchy",
                        "azureOauthConsentComplete",
                        "cancelTaskchain",
                        "createO365AppComplete",
                        "deleteAdGroupsFromHierarchy",
                        "deleteO365AzureApp",
                        "deleteO365ServiceAccount",
                        "enableO365SharePoint",
                        "enableO365Teams",
                        "insertCustomerO365App",
                        "setO365ServiceAccount",
                    }
                },
                {   "RequestSuccess", new List<string> {
                        "deleteHypervVirtualMachineSnapshot",
                        "deleteNutanixSnapshot",
                        "deleteNutanixSnapshots",
                        "deleteVsphereAdvancedTag",
                        "excludeVmDisks",
                        "hypervDeleteAllSnapshots",
                        "installIoFilter",
                        "registerAgentHypervVirtualMachine",
                        "registerAgentNutanixVm",
                        "resolveVolumeGroupsConflict",
                        "uninstallIoFilter",
                        "updateVcenterHotAddBandwidth",
                        "updateVcenterHotAddNetwork",
                        "updateVsphereVm",
                        "upgradeIoFilter",
                        "vsphereExcludeVmDisks",
                        "vsphereVmRegisterAgent",
                    }
                },
                {   "ResourceGroupConnection", new List<string> {
                        "azureResourceGroups",
                    }
                },
                {   "ResponseSuccess", new List<string> {
                        "addVlan",
                        "assignMssqlSlaDomainProperties",
                        "bulkDeleteFailoverCluster",
                        "bulkDeleteFailoverClusterApp",
                        "bulkDeleteFileset",
                        "bulkDeleteFilesetTemplate",
                        "bulkDeleteHost",
                        "deleteFailoverCluster",
                        "deleteFailoverClusterApp",
                        "deleteFilesetSnapshots",
                        "deleteMssqlDbSnapshots",
                        "deleteSapHanaDbSnapshot",
                        "disableReplicationPause",
                        "enableReplicationPause",
                        "hideRevealNasShares",
                        "hypervScvmmDelete",
                        "removeDisk",
                        "removeProxyConfig",
                        "resizeDisk",
                        "updateClusterNtpServers",
                        "updateDnsServersAndSearchDomains",
                    }
                },
                {   "RestoreAzureAdObjectsWithPasswordsReply", new List<string> {
                        "restoreAzureAdObjectsWithPasswords",
                    }
                },
                {   "ResumeTargetReply", new List<string> {
                        "resumeTarget",
                    }
                },
                {   "RetryBackupResp", new List<string> {
                        "retryBackup",
                    }
                },
                {   "RoleConnection", new List<string> {
                        "getAllRolesInOrgConnection",
                    }
                },
                {   "RoleTemplateConnection", new List<string> {
                        "roleTemplates",
                    }
                },
                {   "RotateServiceAccountSecretReply", new List<string> {
                        "rotateServiceAccountSecret",
                    }
                },
                {   "RowConnection", new List<string> {
                        "reportData",
                    }
                },
                {   "RunCustomAnalyzerReply", new List<string> {
                        "runCustomAnalyzer",
                    }
                },
                {   "SapHanaDatabase", new List<string> {
                        "sapHanaDatabase",
                    }
                },
                {   "SapHanaDatabaseConnection", new List<string> {
                        "sapHanaDatabases",
                    }
                },
                {   "SapHanaLogSnapshot", new List<string> {
                        "sapHanaLogSnapshot",
                    }
                },
                {   "SapHanaLogSnapshotConnection", new List<string> {
                        "sapHanaLogSnapshots",
                    }
                },
                {   "SapHanaRecoverableRange", new List<string> {
                        "sapHanaRecoverableRange",
                    }
                },
                {   "SapHanaRecoverableRangeConnection", new List<string> {
                        "sapHanaRecoverableRanges",
                    }
                },
                {   "SapHanaSystem", new List<string> {
                        "sapHanaSystem",
                    }
                },
                {   "SapHanaSystemConnection", new List<string> {
                        "sapHanaSystems",
                    }
                },
                {   "ScheduledReport", new List<string> {
                        "scheduledReport",
                    }
                },
                {   "ScheduledReportConnection", new List<string> {
                        "scheduledReports",
                    }
                },
                {   "SearchResponseListResponse", new List<string> {
                        "searchHost",
                        "searchNutanixVm",
                    }
                },
                {   "SeedEnabledPoliciesReply", new List<string> {
                        "seedEnabledPolicies",
                    }
                },
                {   "SeedInitialPoliciesReply", new List<string> {
                        "seedInitialPolicies",
                    }
                },
                {   "SendPdfReportReply", new List<string> {
                        "sendPdfReport",
                    }
                },
                {   "ServiceAccountConnection", new List<string> {
                        "serviceAccounts",
                    }
                },
                {   "SetAnalyzerRisksReply", new List<string> {
                        "setAnalyzerRisks",
                    }
                },
                {   "SetDatastoreFreespaceThresholdsReply", new List<string> {
                        "setDatastoreFreespaceThresholds",
                    }
                },
                {   "SetUpgradeTypeReply", new List<string> {
                        "setUpgradeType",
                    }
                },
                {   "SetWorkloadAlertSettingReply", new List<string> {
                        "setWorkloadAlertSetting",
                    }
                },
                {   "SetupAzureO365ExocomputeResp", new List<string> {
                        "setupAzureO365Exocompute",
                    }
                },
                {   "ShareFileset", new List<string> {
                        "shareFileset",
                    }
                },
                {   "SlaAssignResult", new List<string> {
                        "assignProtection",
                        "assignRetentionSLAToSnappables",
                        "assignRetentionSLAToSnapshots",
                        "assignSla",
                    }
                },
                {   "SlaDomain", new List<string> {
                        "slaDomain",
                    }
                },
                {   "SlaDomainConnection", new List<string> {
                        "slaDomains",
                    }
                },
                {   "SmbDomainConnection", new List<string> {
                        "smbDomains",
                    }
                },
                {   "SnappableConnection", new List<string> {
                        "searchSnappableConnection",
                        "snappableConnection",
                    }
                },
                {   "SnappableGroupByConnection", new List<string> {
                        "snappableGroupByConnection",
                    }
                },
                {   "SnapshotFileConnection", new List<string> {
                        "browseSnapshotFileConnection",
                        "cloudNativeSnapshots",
                    }
                },
                {   "SnapshotFileDeltaConnection", new List<string> {
                        "snapshotFilesDelta",
                    }
                },
                {   "SnapshotFileDeltaV2Connection", new List<string> {
                        "snapshotFilesDeltaV2",
                    }
                },
                {   "SnapshotResultConnection", new List<string> {
                        "snapshotResults",
                    }
                },
                {   "SnapshotSummaryConnection", new List<string> {
                        "snapshotsForUnmanagedObject",
                    }
                },
                {   "SnmpConfiguration", new List<string> {
                        "snmpConfigurations",
                    }
                },
                {   "SonarContentReportConnection", new List<string> {
                        "sonarContentReport",
                    }
                },
                {   "SonarReportConnection", new List<string> {
                        "sonarReport",
                    }
                },
                {   "SonarReportRowConnection", new List<string> {
                        "sonarReportRow",
                    }
                },
                {   "StartAzureAdAppSetupReply", new List<string> {
                        "startAzureAdAppSetup",
                    }
                },
                {   "StartAzureAdAppUpdateReply", new List<string> {
                        "startAzureAdAppUpdate",
                    }
                },
                {   "StartAzureCloudAccountOauthReply", new List<string> {
                        "startAzureCloudAccountOauth",
                    }
                },
                {   "StartClusterReportMigrationJobReply", new List<string> {
                        "startClusterReportMigrationJob",
                    }
                },
                {   "StartCrawlReply", new List<string> {
                        "startCrawl",
                    }
                },
                {   "StartThreatHuntReply", new List<string> {
                        "startThreatHunt",
                    }
                },
                {   "StopJobInstanceReply", new List<string> {
                        "stopJobInstance",
                    }
                },
                {   "StorageAccountConnection", new List<string> {
                        "azureStorageAccounts",
                    }
                },
                {   "String", new List<string> {
                        "accountId",
                        "addPolicyObjects",
                        "archiveCrawl",
                        "createUser",
                        "createUserWithPassword",
                        "currentIpAddress",
                        "deactivateCustomAnalyzer",
                        "deploymentVersion",
                        "externalDeploymentName",
                        "gcpGetDefaultCredentialsServiceAccount",
                        "o365TeamConversationsFolderID",
                        "updateLdapIntegration",
                        "updateWhitelistedAnalyzers",
                    }
                },
                {   "SubnetConnection", new List<string> {
                        "azureSubnets",
                    }
                },
                {   "SupportPortalLoginReply", new List<string> {
                        "supportPortalLogin",
                    }
                },
                {   "SupportPortalLogoutReply", new List<string> {
                        "logoutFromRubrikSupportPortal",
                    }
                },
                {   "SupportPortalStatusReply", new List<string> {
                        "isLoggedIntoRubrikSupportPortal",
                    }
                },
                {   "SupportTunnelInfo", new List<string> {
                        "tunnelStatus",
                    }
                },
                {   "SupportUserAccessConnection", new List<string> {
                        "supportUserAccesses",
                    }
                },
                {   "SyslogExportRuleSummaryListResponse", new List<string> {
                        "syslogExportRules",
                    }
                },
                {   "TableFilters", new List<string> {
                        "tableFilters",
                    }
                },
                {   "TakeOnDemandSnapshotReply", new List<string> {
                        "takeOnDemandSnapshot",
                    }
                },
                {   "Target", new List<string> {
                        "createAwsReaderTarget",
                        "createAwsTarget",
                        "createAzureReaderTarget",
                        "createAzureTarget",
                        "createGcpReaderTarget",
                        "createGcpTarget",
                        "createGlacierReaderTarget",
                        "createNfsReaderTarget",
                        "createNfsTarget",
                        "createRcsReaderTarget",
                        "createRcsTarget",
                        "createS3CompatibleReaderTarget",
                        "createS3CompatibleTarget",
                        "createTapeReaderTarget",
                        "createTapeTarget",
                        "target",
                        "updateAwsTarget",
                        "updateAzureTarget",
                        "updateGcpTarget",
                        "updateGlacierTarget",
                        "updateNfsTarget",
                        "updateRcvTarget",
                        "updateS3CompatibleTarget",
                        "updateTapeTarget",
                    }
                },
                {   "TargetConnection", new List<string> {
                        "targets",
                    }
                },
                {   "TargetMapping", new List<string> {
                        "createAutomaticAwsTargetMapping",
                        "createAutomaticAzureTargetMapping",
                        "createAutomaticRcsTargetMapping",
                        "createManualTargetMapping",
                        "targetMapping",
                        "updateAutomaticAwsTargetMapping",
                        "updateAutomaticAzureTargetMapping",
                        "updateManualTargetMapping",
                        "updateRcsAutomaticTargetMapping",
                    }
                },
                {   "TaskDetailConnection", new List<string> {
                        "taskDetailConnection",
                    }
                },
                {   "TaskDetailGroupByConnection", new List<string> {
                        "taskDetailGroupByConnection",
                    }
                },
                {   "TenantAuthDomainConfig", new List<string> {
                        "currentOrgAuthDomainConfig",
                    }
                },
                {   "TestExistingWebhookReply", new List<string> {
                        "testExistingWebhook",
                    }
                },
                {   "TestSyslogExportRuleReply", new List<string> {
                        "testSyslogExportRule",
                    }
                },
                {   "TestWebhookReply", new List<string> {
                        "testWebhook",
                    }
                },
                {   "ThreatHunt", new List<string> {
                        "threatHuntDetail",
                    }
                },
                {   "ThreatHuntConnection", new List<string> {
                        "threatHunts",
                    }
                },
                {   "ThreatHuntResult", new List<string> {
                        "threatHuntResult",
                    }
                },
                {   "ThreatHuntSummaryReply", new List<string> {
                        "threatHuntSummary",
                    }
                },
                {   "TriggerExocomputeHealthCheckReply", new List<string> {
                        "triggerExocomputeHealthCheck",
                    }
                },
                {   "TriggerRansomwareDetectionReply", new List<string> {
                        "triggerRansomwareDetection",
                    }
                },
                {   "UUID", new List<string> {
                        "createRole",
                        "mutateRole",
                    }
                },
                {   "UnmanagedObjectDetailConnection", new List<string> {
                        "unmanagedObjects",
                    }
                },
                {   "UnmapAzureCloudAccountExocomputeSubscriptionReply", new List<string> {
                        "unmapAzureCloudAccountExocomputeSubscription",
                    }
                },
                {   "UnmapCloudAccountExocomputeAccountReply", new List<string> {
                        "unmapCloudAccountExocomputeAccount",
                    }
                },
                {   "UpdateAutoEnablePolicyClusterConfigReply", new List<string> {
                        "updateAutoEnablePolicyClusterConfig",
                    }
                },
                {   "UpdateAwsCloudAccountFeatureReply", new List<string> {
                        "updateAwsCloudAccountFeature",
                    }
                },
                {   "UpdateAwsExocomputeConfigsReply", new List<string> {
                        "updateAwsExocomputeConfigs",
                    }
                },
                {   "UpdateAzureCloudAccountReply", new List<string> {
                        "updateAzureCloudAccount",
                    }
                },
                {   "UpdateBadDiskLedStatusReply", new List<string> {
                        "updateBadDiskLedStatus",
                    }
                },
                {   "UpdateCertificateHostReply", new List<string> {
                        "updateCertificateHost",
                    }
                },
                {   "UpdateCloudNativeAwsStorageSettingReply", new List<string> {
                        "updateCloudNativeAwsStorageSetting",
                    }
                },
                {   "UpdateCloudNativeAzureStorageSettingReply", new List<string> {
                        "updateCloudNativeAzureStorageSetting",
                    }
                },
                {   "UpdateCloudNativeIndexingStatusReply", new List<string> {
                        "updateCloudNativeIndexingStatus",
                    }
                },
                {   "UpdateCloudNativeRcvAzureStorageSettingReply", new List<string> {
                        "updateCloudNativeRcvAzureStorageSetting",
                    }
                },
                {   "UpdateClusterDefaultAddressReply", new List<string> {
                        "updateClusterDefaultAddress",
                    }
                },
                {   "UpdateClusterSettingsReply", new List<string> {
                        "updateClusterSettings",
                    }
                },
                {   "UpdateCustomReportReply", new List<string> {
                        "updateCustomReport",
                    }
                },
                {   "UpdateEventDigestReply", new List<string> {
                        "updateEventDigest",
                    }
                },
                {   "UpdateFailoverClusterAppReply", new List<string> {
                        "updateFailoverClusterApp",
                    }
                },
                {   "UpdateFailoverClusterReply", new List<string> {
                        "updateFailoverCluster",
                    }
                },
                {   "UpdateFloatingIpsReply", new List<string> {
                        "updateFloatingIps",
                    }
                },
                {   "UpdateGuestCredentialReply", new List<string> {
                        "updateGuestCredential",
                    }
                },
                {   "UpdateHealthMonitorPolicyStatusReply", new List<string> {
                        "updateHealthMonitorPolicyStatus",
                    }
                },
                {   "UpdateHypervVirtualMachineReply", new List<string> {
                        "updateHypervVirtualMachine",
                    }
                },
                {   "UpdateHypervVirtualMachineSnapshotMountReply", new List<string> {
                        "updateHypervVirtualMachineSnapshotMount",
                    }
                },
                {   "UpdateInsightStateReply", new List<string> {
                        "updateInsightState",
                    }
                },
                {   "UpdateLockoutConfigReply", new List<string> {
                        "updateLockoutConfig",
                    }
                },
                {   "UpdateManagedVolumeReply", new List<string> {
                        "updateManagedVolume",
                    }
                },
                {   "UpdateMssqlDefaultPropertiesReply", new List<string> {
                        "mssqlDefaultProperties",
                        "updateMssqlDefaultProperties",
                    }
                },
                {   "UpdateMssqlLogShippingConfigurationReply", new List<string> {
                        "updateMssqlLogShippingConfiguration",
                    }
                },
                {   "UpdateNasSystemReply", new List<string> {
                        "updateNasSystem",
                    }
                },
                {   "UpdateNetworkThrottleReply", new List<string> {
                        "updateNetworkThrottle",
                    }
                },
                {   "UpdateNutanixClusterReply", new List<string> {
                        "updateNutanixCluster",
                    }
                },
                {   "UpdateNutanixPrismCentralReply", new List<string> {
                        "updateNutanixPrismCentral",
                    }
                },
                {   "UpdateO365AppAuthStatusReply", new List<string> {
                        "updateO365AppAuthStatus",
                    }
                },
                {   "UpdateO365OrgCustomNameReply", new List<string> {
                        "updateO365OrgCustomName",
                    }
                },
                {   "UpdateOrgReply", new List<string> {
                        "updateOrg",
                    }
                },
                {   "UpdateProxyConfigReply", new List<string> {
                        "updateProxyConfig",
                    }
                },
                {   "UpdateScheduledReportReply", new List<string> {
                        "updateScheduledReport",
                    }
                },
                {   "UpdateServiceAccountReply", new List<string> {
                        "updateServiceAccount",
                    }
                },
                {   "UpdateSnmpConfigReply", new List<string> {
                        "updateSnmpConfig",
                    }
                },
                {   "UpdateStorageArraysReply", new List<string> {
                        "updateStorageArrays",
                    }
                },
                {   "UpdateSyslogExportRuleReply", new List<string> {
                        "updateSyslogExportRule",
                    }
                },
                {   "UpdateTunnelStatusReply", new List<string> {
                        "updateTunnelStatus",
                    }
                },
                {   "UpdateVcenterReply", new List<string> {
                        "updateVcenter",
                    }
                },
                {   "UpdateVolumeGroupReply", new List<string> {
                        "updateVolumeGroup",
                    }
                },
                {   "UpdateVsphereAdvancedTagReply", new List<string> {
                        "updateVsphereAdvancedTag",
                    }
                },
                {   "UpdateWebhookReply", new List<string> {
                        "updateWebhook",
                    }
                },
                {   "UpgradeAzureCloudAccountPermissionsWithoutOauthReply", new List<string> {
                        "upgradeAzureCloudAccountPermissionsWithoutOauth",
                    }
                },
                {   "UpgradeAzureCloudAccountReply", new List<string> {
                        "upgradeAzureCloudAccount",
                    }
                },
                {   "UpgradeGcpCloudAccountPermissionsWithoutOauthReply", new List<string> {
                        "upgradeGcpCloudAccountPermissionsWithoutOauth",
                    }
                },
                {   "UpgradeStatusReply", new List<string> {
                        "upgradeStatus",
                    }
                },
                {   "User", new List<string> {
                        "currentUser",
                    }
                },
                {   "UserActivityResultConnection", new List<string> {
                        "allFileActivities",
                    }
                },
                {   "UserAuditConnection", new List<string> {
                        "userAuditConnection",
                    }
                },
                {   "UserConnection", new List<string> {
                        "allUsersOnAccountConnection",
                        "usersInCurrentAndDescendantOrganization",
                    }
                },
                {   "UserDownloadUrl", new List<string> {
                        "getDownloadUrl",
                    }
                },
                {   "UserLoginContext", new List<string> {
                        "currentUserLoginContext",
                    }
                },
                {   "UserNotifications", new List<string> {
                        "userNotifications",
                    }
                },
                {   "UserSettings", new List<string> {
                        "userSettings",
                    }
                },
                {   "V1BulkUpdateExchangeDagResponse", new List<string> {
                        "bulkUpdateExchangeDag",
                    }
                },
                {   "V1MssqlGetRestoreFilesV1Response", new List<string> {
                        "allMssqlDatabaseRestoreFiles",
                    }
                },
                {   "ValidReplicationTargetConnection", new List<string> {
                        "allValidReplicationTargets",
                    }
                },
                {   "ValidateAndCreateAwsCloudAccountReply", new List<string> {
                        "validateAndCreateAwsCloudAccount",
                    }
                },
                {   "ValidateAndSaveCustomerKmsInfoReply", new List<string> {
                        "validateAndSaveCustomerKmsInfo",
                    }
                },
                {   "ValidateAwsNativeRdsClusterNameForExportReply", new List<string> {
                        "validateAwsNativeRdsClusterNameForExport",
                    }
                },
                {   "ValidateAwsNativeRdsInstanceNameForExportReply", new List<string> {
                        "validateAwsNativeRdsInstanceNameForExport",
                    }
                },
                {   "ValidateAzureNativeSqlDatabaseDbNameForExportReply", new List<string> {
                        "validateAzureNativeSqlDatabaseDbNameForExport",
                    }
                },
                {   "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply", new List<string> {
                        "validateAzureNativeSqlManagedInstanceDbNameForExport",
                    }
                },
                {   "ValidateAzureSubnetsForCloudAccountExocomputeReply", new List<string> {
                        "validateAzureCloudAccountExocomputeConfigurations",
                    }
                },
                {   "ValidateCloudNativeFileRecoveryFeasibilityReply", new List<string> {
                        "isCloudNativeFileRecoveryFeasible",
                    }
                },
                {   "ValidateOracleAcoFileReply", new List<string> {
                        "validateOracleAcoFile",
                    }
                },
                {   "ValidateOrgNameReply", new List<string> {
                        "validateOrgName",
                    }
                },
                {   "VappInstantRecoveryOptions", new List<string> {
                        "vappSnapshotInstantRecoveryOptions",
                    }
                },
                {   "VappTemplateExportOptionsUnion", new List<string> {
                        "vappTemplateSnapshotExportOptions",
                    }
                },
                {   "VcenterAdvancedTagPreviewReply", new List<string> {
                        "vCenterAdvancedTagPreview",
                    }
                },
                {   "VcenterPreAddInfo", new List<string> {
                        "vCenterPreAddInfo",
                    }
                },
                {   "VerifySlaWithReplicationToClusterResponse", new List<string> {
                        "verifySlaWithReplicationToCluster",
                    }
                },
                {   "VersionedFileConnection", new List<string> {
                        "searchSnappableVersionedFiles",
                    }
                },
                {   "VirtualMachineFilesReply", new List<string> {
                        "allVirtualMachineFiles",
                    }
                },
                {   "VlanConfigListResponse", new List<string> {
                        "clusterVlans",
                    }
                },
                {   "VmwareHostDetail", new List<string> {
                        "vSphereHostDetails",
                    }
                },
                {   "VnetConnection", new List<string> {
                        "azureVNets",
                    }
                },
                {   "Void", new List<string> {
                        "cancelThreatHunt",
                        "completeAzureAdAppUpdate",
                        "createReplicationPair",
                        "deleteAllOracleDatabaseSnapshots",
                        "deleteAwsComputeSetting",
                        "deleteCloudNativeLabelRule",
                        "deleteCloudNativeTagRule",
                        "deleteCsr",
                        "deleteCustomReport",
                        "deleteEventDigest",
                        "deleteIntegration",
                        "deleteIntegrations",
                        "deleteReplicationPair",
                        "deleteScheduledReport",
                        "deleteSmbDomain",
                        "deleteSyslogExportRule",
                        "deleteTarget",
                        "deleteTargetMapping",
                        "deleteWebhook",
                        "disableSupportUserAccess",
                        "enableSupportUserAccess",
                        "enableThreatMonitoring",
                        "excludeAwsNativeEbsVolumesFromSnapshot",
                        "excludeAzureNativeManagedDisksFromSnapshot",
                        "excludeSharepointObjectsFromProtection",
                        "gcpNativeExcludeDisksFromInstanceSnapshot",
                        "hideRevealNasNamespaces",
                        "joinSmbDomain",
                        "lockUsersByAdmin",
                        "promoteReaderTarget",
                        "refreshReaderTarget",
                        "removePrivateEndpointConnection",
                        "resetAllOrgUsersPasswords",
                        "resetUsersPasswordsWithUserIds",
                        "revokeAllOrgRoles",
                        "setCustomerTags",
                        "setPasswordComplexityPolicy",
                        "setSsoCertificate",
                        "stopJobInstanceFromEventSeries",
                        "unlockUsersByAdmin",
                        "unmapAzurePersistentStorageSubscription",
                        "unmountDisk",
                        "updateAuthDomainUsersHiddenStatus",
                        "updateAwsCloudAccount",
                        "updateCloudNativeLabelRule",
                        "updateCloudNativeTagRule",
                        "updateConfiguredGroup",
                        "updateCustomerAppPermissionForAzureSql",
                        "updateIntegration",
                        "updateIntegrations",
                        "updateNasShares",
                        "updateNutanixVm",
                        "updateO365AppPermissions",
                        "updateOrgSecurityPolicy",
                        "updateReplicationTarget",
                        "updateSupportUserAccess",
                        "upgradeCdmManagedTarget",
                        "upgradeToRsc",
                        "vsphereVmDeleteSnapshot",
                    }
                },
                {   "VolumeGroupLiveMountConnection", new List<string> {
                        "volumeGroupMounts",
                    }
                },
                {   "VsphereAsyncRequestStatus", new List<string> {
                        "vsphereVmRecoverFiles",
                    }
                },
                {   "VsphereComputeCluster", new List<string> {
                        "vSphereComputeCluster",
                    }
                },
                {   "VsphereComputeClusterConnection", new List<string> {
                        "vSphereComputeClusters",
                    }
                },
                {   "VsphereDatacenter", new List<string> {
                        "vSphereDatacenter",
                    }
                },
                {   "VsphereDatastore", new List<string> {
                        "vSphereDatastore",
                    }
                },
                {   "VsphereDatastoreCluster", new List<string> {
                        "vSphereDatastoreCluster",
                    }
                },
                {   "VsphereDatastoreClusterConnection", new List<string> {
                        "vSphereDatastoreClusters",
                    }
                },
                {   "VsphereDatastoreConnection", new List<string> {
                        "vSphereDatastoreConnection",
                    }
                },
                {   "VsphereFolder", new List<string> {
                        "vSphereFolder",
                    }
                },
                {   "VsphereFolderConnection", new List<string> {
                        "vSphereFolders",
                    }
                },
                {   "VsphereHost", new List<string> {
                        "vSphereHost",
                    }
                },
                {   "VsphereHostConnection", new List<string> {
                        "vSphereHostConnection",
                    }
                },
                {   "VsphereLiveMountConnection", new List<string> {
                        "vSphereLiveMounts",
                    }
                },
                {   "VsphereMount", new List<string> {
                        "vSphereMount",
                    }
                },
                {   "VsphereMountConnection", new List<string> {
                        "vSphereMountConnection",
                    }
                },
                {   "VsphereNetwork", new List<string> {
                        "vSphereNetwork",
                    }
                },
                {   "VsphereResourcePool", new List<string> {
                        "vSphereResourcePool",
                    }
                },
                {   "VsphereTag", new List<string> {
                        "vSphereTag",
                    }
                },
                {   "VsphereTagCategory", new List<string> {
                        "vSphereTagCategory",
                    }
                },
                {   "VsphereVcenter", new List<string> {
                        "vSphereVCenter",
                    }
                },
                {   "VsphereVcenterConnection", new List<string> {
                        "vSphereVCenterConnection",
                    }
                },
                {   "VsphereVm", new List<string> {
                        "vSphereVmNew",
                    }
                },
                {   "VsphereVmConnection", new List<string> {
                        "vcdVappVms",
                        "vSphereVmNewConnection",
                    }
                },
                {   "VsphereVmListEsxiDatastoresReply", new List<string> {
                        "vsphereVmListEsxiDatastores",
                    }
                },
                {   "VsphereVmPowerOnOffLiveMountReply", new List<string> {
                        "vsphereVmPowerOnOffLiveMount",
                    }
                },
                {   "WebhookConnection", new List<string> {
                        "allWebhooks",
                    }
                },
                {   "WindowsCluster", new List<string> {
                        "windowsCluster",
                    }
                },
                {   "WindowsFileset", new List<string> {
                        "windowsFileset",
                    }
                },
                {   "WorkloadAnomalyConnection", new List<string> {
                        "workloadAnomalies",
                    }
                },
                {   "ZrsAvailabilityReply", new List<string> {
                        "isZrsAvailableForLocation",
                    }
                },
                {   "[AccountProduct]", new List<string> {
                        "allAccountProducts",
                    }
                },
                {   "[AdGroup]", new List<string> {
                        "allO365AdGroups",
                    }
                },
                {   "[ArchivalStorageUsage]", new List<string> {
                        "archivalStorageUsage",
                    }
                },
                {   "[AuthorizedOperations]", new List<string> {
                        "allAuthorizationsForObjects",
                    }
                },
                {   "[AwsCdmVersion]", new List<string> {
                        "allAwsCdmVersions",
                    }
                },
                {   "[AwsCloudAccountRegion]", new List<string> {
                        "allAwsRegions",
                    }
                },
                {   "[AwsCloudAccountWithFeatures]", new List<string> {
                        "allAwsCloudAccountsWithFeatures",
                    }
                },
                {   "[AwsComputeSettings]", new List<string> {
                        "allAwsComputeSettings",
                    }
                },
                {   "[AwsExocomputeConfig]", new List<string> {
                        "allAwsExocomputeConfigs",
                    }
                },
                {   "[AwsFeatureConfig]", new List<string> {
                        "allAwsCloudAccountConfigs",
                    }
                },
                {   "[AwsVpc]", new List<string> {
                        "allVpcsByRegionFromAws",
                        "allVpcsFromAws",
                    }
                },
                {   "[AzureArmTemplateByFeature]", new List<string> {
                        "allAzureArmTemplatesByFeature",
                    }
                },
                {   "[AzureCdmVersion]", new List<string> {
                        "allAzureCdmVersions",
                    }
                },
                {   "[AzureCloudAccountRegion]", new List<string> {
                        "allAzureRegions",
                    }
                },
                {   "[AzureCloudAccountTenant]", new List<string> {
                        "allAzureCloudAccountTenants",
                    }
                },
                {   "[AzureEncryptionKey]", new List<string> {
                        "allAzureEncryptionKeys",
                    }
                },
                {   "[AzureExocomputeConfigsInAccount]", new List<string> {
                        "allAzureExocomputeConfigsInAccount",
                    }
                },
                {   "[AzureKeyVault]", new List<string> {
                        "allAzureKeyVaultsByRegion",
                    }
                },
                {   "[AzureManagedIdentity]", new List<string> {
                        "allAzureManagedIdentities",
                    }
                },
                {   "[AzureNativeAvailabilitySet]", new List<string> {
                        "allAzureNativeAvailabilitySetsByRegionFromAzure",
                    }
                },
                {   "[AzureNativeDiskEncryptionSet]", new List<string> {
                        "allAzureDiskEncryptionSetsByRegion",
                    }
                },
                {   "[AzureNativeExportCompatibleDiskTypes]", new List<string> {
                        "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure",
                    }
                },
                {   "[AzureNativeExportCompatibleVmSizes]", new List<string> {
                        "allAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                    }
                },
                {   "[AzureNativeSecurityGroup]", new List<string> {
                        "allAzureNativeSecurityGroupsByRegionFromAzure",
                    }
                },
                {   "[AzureNativeStorageAccount]", new List<string> {
                        "allAzureNativeStorageAccountsFromAzure",
                    }
                },
                {   "[AzureNativeSubnet]", new List<string> {
                        "allAzureCloudAccountSubnetsByRegion",
                        "allAzureNativeSubnetsByRegionFromAzure",
                    }
                },
                {   "[AzureNativeVirtualNetwork]", new List<string> {
                        "allAzureNativeVirtualNetworks",
                    }
                },
                {   "[AzureResourceGroupInfo]", new List<string> {
                        "allAzureNativeResourceGroupsInfoIfExist",
                    }
                },
                {   "[AzureResourceGroup]", new List<string> {
                        "allResourceGroupsFromAzure",
                    }
                },
                {   "[AzureSqlDatabaseServerElasticPool]", new List<string> {
                        "allAzureSqlDatabaseServerElasticPools",
                    }
                },
                {   "[AzureSubscriptionMissingPermissions]", new List<string> {
                        "allAzureCloudAccountMissingPermissions",
                    }
                },
                {   "[AzureSubscriptionWithExocomputeMapping]", new List<string> {
                        "allAzureSubscriptionWithExocomputeMappings",
                    }
                },
                {   "[AzureSubscriptionWithFeaturesType]", new List<string> {
                        "allAzureCloudAccountSubscriptionsByFeature",
                    }
                },
                {   "[Boolean]", new List<string> {
                        "allClustersTotpAckStatus",
                    }
                },
                {   "[CdmGuestCredential]", new List<string> {
                        "allCdmGuestCredentials",
                    }
                },
                {   "[CdmHierarchySnappableNew]", new List<string> {
                        "cdmHierarchySnappablesNew",
                    }
                },
                {   "[CdmOvaDetail]", new List<string> {
                        "allCdmOvaDetails",
                    }
                },
                {   "[ClosestSnapshotSearchResult]", new List<string> {
                        "allSnapshotsClosestToPointInTime",
                    }
                },
                {   "[CloudAccountFeaturePermission]", new List<string> {
                        "allCurrentFeaturePermissionsForCloudAccounts",
                        "allLatestFeaturePermissionsForCloudAccounts",
                    }
                },
                {   "[CloudAccountWithExocomputeMapping]", new List<string> {
                        "allAccountsWithExocomputeMappings",
                    }
                },
                {   "[CloudAccount]", new List<string> {
                        "allCloudAccounts",
                    }
                },
                {   "[CloudAccountsExocomputeAccountMapping]", new List<string> {
                        "allCloudAccountExocomputeMappings",
                    }
                },
                {   "[CloudDirectSite]", new List<string> {
                        "allCloudDirectSites",
                    }
                },
                {   "[ClusterReplicationTarget]", new List<string> {
                        "allClusterReplicationTargets",
                    }
                },
                {   "[ClusterWebCertAndIpmi]", new List<string> {
                        "allClusterWebCertsAndIpmis",
                    }
                },
                {   "[CreateOnDemandJobReply]", new List<string> {
                        "backupAzureAdDirectory",
                        "backupM365Mailbox",
                        "backupM365Onedrive",
                        "backupM365SharepointDrive",
                        "backupM365Team",
                        "createK8sNamespaceSnapshots",
                    }
                },
                {   "[DataLocationSupportedCluster]", new List<string> {
                        "allConnectedClusters",
                    }
                },
                {   "[DbParameterGroup]", new List<string> {
                        "allDbParameterGroupsByRegionFromAws",
                    }
                },
                {   "[DhrcActiveRecommendation]", new List<string> {
                        "allDhrcActiveRecommendations",
                    }
                },
                {   "[DhrcCollectedMetric]", new List<string> {
                        "allDhrcLatestMetrics",
                    }
                },
                {   "[DhrcScore]", new List<string> {
                        "allDhrcScores",
                    }
                },
                {   "[DownloadPackageReplyWithUuid]", new List<string> {
                        "startDownloadPackageBatchJob",
                    }
                },
                {   "[EventDigest]", new List<string> {
                        "allEventDigests",
                    }
                },
                {   "[FullSpSiteExclusions]", new List<string> {
                        "allSharepointSiteExclusions",
                    }
                },
                {   "[GcpCloudAccountMissingPermissionsForAddition]", new List<string> {
                        "allGcpCloudAccountMissingPermissionsForAddition",
                    }
                },
                {   "[GcpCloudAccountProjectDetail]", new List<string> {
                        "allGcpCloudAccountProjectsByFeature",
                    }
                },
                {   "[GcpCloudAccountProjectForOauth]", new List<string> {
                        "allGcpCloudAccountProjectsForOauth",
                    }
                },
                {   "[GcpNativeKmsCryptoKey]", new List<string> {
                        "allGcpNativeAvailableKmsCryptoKeys",
                    }
                },
                {   "[GcpNativeNetwork]", new List<string> {
                        "allGcpNativeNetworks",
                    }
                },
                {   "[GcpNativeRegion]", new List<string> {
                        "allGcpNativeRegions",
                    }
                },
                {   "[GcpPermission]", new List<string> {
                        "allFeaturePermissionsForGcpCloudAccount",
                    }
                },
                {   "[GroupCount]", new List<string> {
                        "clusterTypeList",
                        "downloadedVersionList",
                        "geoLocationList",
                        "getGroupCountByPrechecksStatus",
                        "getGroupCountByUpgradeJobStatus",
                        "getGroupCountByVersionStatus",
                    }
                },
                {   "[Group]", new List<string> {
                        "userGroups",
                    }
                },
                {   "[HierarchyObject]", new List<string> {
                        "hierarchyObjects",
                        "slaConflictObjects",
                    }
                },
                {   "[IdentityProvider]", new List<string> {
                        "allCurrentOrgIdentityProviders",
                    }
                },
                {   "[InstalledVersionGroupCount]", new List<string> {
                        "installedVersionList",
                    }
                },
                {   "[InventoryCard]", new List<string> {
                        "allInventoryWorkloads",
                    }
                },
                {   "[KmsEncryptionKey]", new List<string> {
                        "allKmsEncryptionKeysByRegionFromAws",
                    }
                },
                {   "[ManagedObjectType]", new List<string> {
                        "allUnmanagedObjectsSupportedTypes",
                    }
                },
                {   "[MosaicStorageLocation]", new List<string> {
                        "allNosqlStorageLocations",
                    }
                },
                {   "[NcdObjectsOverTimeData]", new List<string> {
                        "allNcdObjectsOverTimeData",
                    }
                },
                {   "[NcdSlaComplianceData]", new List<string> {
                        "allNcdSlaComplianceData",
                    }
                },
                {   "[NcdTaskData]", new List<string> {
                        "allNcdTaskData",
                    }
                },
                {   "[NcdUsageOverTimeData]", new List<string> {
                        "allNcdUsageOverTimeData",
                    }
                },
                {   "[NetworkHostProject]", new List<string> {
                        "allGcpNativeProjectsWithAccessibleNetworks",
                    }
                },
                {   "[O365OrgInfo]", new List<string> {
                        "allO365OrgStatuses",
                    }
                },
                {   "[O365SubscriptionAppTypeCounts]", new List<string> {
                        "allO365SubscriptionsAppTypeCounts",
                    }
                },
                {   "[ObjectIdsForHierarchyType]", new List<string> {
                        "allObjectsAlreadyAssignedToOrgs",
                    }
                },
                {   "[Operation]", new List<string> {
                        "allAllowedOrgAdminOperations",
                        "allAuthorizationsForGlobalResource",
                        "allAuthorizationsForObject",
                    }
                },
                {   "[OptionGroup]", new List<string> {
                        "allOptionGroupsByRegionFromAws",
                    }
                },
                {   "[Org]", new List<string> {
                        "allOrgsByIds",
                    }
                },
                {   "[PermissionPolicy]", new List<string> {
                        "allAwsPermissionPolicies",
                    }
                },
                {   "[Permission]", new List<string> {
                        "getPermissions",
                    }
                },
                {   "[PolicySummary]", new List<string> {
                        "allTopRiskPolicySummaries",
                    }
                },
                {   "[PvcInformation]", new List<string> {
                        "allSnapshotPvcs",
                    }
                },
                {   "[QuarantineSpec]", new List<string> {
                        "allQuarantinedDetailsForSnapshots",
                        "allQuarantinedDetailsForWorkload",
                    }
                },
                {   "[RbacPermission]", new List<string> {
                        "allEffectiveRbacPermissions",
                    }
                },
                {   "[ReplicatedSnapshotInfo]", new List<string> {
                        "allK8sReplicaSnapshotInfos",
                    }
                },
                {   "[Role]", new List<string> {
                        "getRolesByIds",
                    }
                },
                {   "[S3BucketDetails]", new List<string> {
                        "allS3BucketsDetailsFromAws",
                    }
                },
                {   "[ShareExportIdPair]", new List<string> {
                        "allCloudDirectShares",
                    }
                },
                {   "[SlaAssignResult]", new List<string> {
                        "assignSlasForSnappableHierarchies",
                    }
                },
                {   "[SlaAuditDetail]", new List<string> {
                        "slaAuditDetail",
                    }
                },
                {   "[SlaDomain]", new List<string> {
                        "allSlaSummariesByIds",
                    }
                },
                {   "[SlaInfo]", new List<string> {
                        "allClusterGlobalSlas",
                    }
                },
                {   "[String]", new List<string> {
                        "allAvailabilityZonesByRegionFromAws",
                        "allAwsInstanceProfileNames",
                        "allAzureNativeVirtualMachineSizes",
                        "allAzureNsgs",
                        "allAzureResourceGroups",
                        "allAzureStorageAccounts",
                        "allAzureSubnets",
                        "allAzureVnets",
                        "allCloudNativeFileRecoveryEligibleSnapshots",
                        "allCloudNativeLabelKeys",
                        "allCloudNativeLabelValues",
                        "allCloudNativeTagKeys",
                        "allCloudNativeTagValues",
                        "allDeploymentIpAddresses",
                        "allEc2KeyPairsByRegionFromAws",
                        "allGcpNativeCompatibleMachineTypes",
                        "allGcpNativeStoredMachineTypes",
                        "allGcpNativeStoredMachineTypesInProject",
                        "allGcpNativeStoredNetworkNames",
                        "allGcpNativeStoredNetworkNamesInProject",
                        "allGcpNativeStoredRegions",
                        "allGcpNativeStoredRegionsInProject",
                        "allIssuesJobIds",
                        "allS3BucketsFromAws",
                        "allSupportedAwsRdsDatabaseInstanceClasses",
                        "deactivatePolicy",
                        "removePolicyObjects",
                    }
                },
                {   "[SubnetGroup]", new List<string> {
                        "allDbSubnetGroupsByRegionFromAws",
                    }
                },
                {   "[TargetMapping]", new List<string> {
                        "allTargetMappings",
                    }
                },
                {   "[Target]", new List<string> {
                        "allTargets",
                        "createRcvLocationsFromTemplate",
                    }
                },
                {   "[UpgradeJobReplyWithUuid]", new List<string> {
                        "scheduleUpgradeBatchJob",
                        "startUpgradeBatchJob",
                    }
                },
                {   "[UserDownload]", new List<string> {
                        "getUserDownloads",
                    }
                },
                {   "[User]", new List<string> {
                        "allAccountOwners",
                        "allUsersOnAccount",
                    }
                },
                {   "[VcenterHotAddProxyVmInfo]", new List<string> {
                        "allVcenterHotAddProxyVms",
                    }
                },
                {   "[VmRecoveryJobInfo]", new List<string> {
                        "allVmRecoveryJobsInfo",
                    }
                },
                {   "[VmwareCdpStateInfo]", new List<string> {
                        "allVmwareCdpStateInfos",
                    }
                },
                {   "[VsphereHost]", new List<string> {
                        "vSphereHostsByFids",
                    }
                },
                {   "[pendingAction]", new List<string> {
                        "allPendingActions",
                    }
                },
                {   "pendingAction", new List<string> {
                        "pendingAction",
                    }
                },
            };
            if (lookupDict.TryGetValue(returnTypeName, out var rootFieldNames))
            {
                return rootFieldNames;
            }
            return new List<string>();
        }

        public static string ReturnTypeLookupByGqlRootField(
            string rootFieldName
        )
        {
            var lookupDict = new Dictionary<string, string> {
                { "sonarUserGroups", "AccessGroupConnection"},
                { "sonarUsers", "AccessUserConnection"},
                { "accountSettings", "AccountSetting"},
                { "activitySeries", "ActivitySeries"},
                { "activitySeriesConnection", "ActivitySeriesConnection"},
                { "userActivityTimeline", "ActivityTimelineResultConnection"},
                { "userFileActivityTimeline", "ActivityTimelineResultConnection"},
                { "addAndJoinSmbDomain", "AddAndJoinSmbDomainReply"},
                { "addAwsAuthenticationServerBasedCloudAccount", "AddAwsAuthenticationServerBasedCloudAccountReply"},
                { "addAwsIamUserBasedCloudAccount", "AddAwsIamUserBasedCloudAccountReply"},
                { "addAzureCloudAccountExocomputeConfigurations", "AddAzureCloudAccountExocomputeConfigurationsReply"},
                { "addAzureCloudAccount", "AddAzureCloudAccountReply"},
                { "addAzureCloudAccountWithoutOauth", "AddAzureCloudAccountWithoutOauthReply"},
                { "addCloudNativeSqlServerBackupCredentials", "AddCloudNativeSqlServerBackupCredentialsReply"},
                { "addClusterCertificate", "AddClusterCertificateReply"},
                { "addClusterNodes", "AddClusterNodesReply"},
                { "addConfiguredGroupToHierarchy", "AddConfiguredGroupToHierarchyReply"},
                { "addDb2Instance", "AddDb2InstanceReply"},
                { "addManagedVolume", "AddManagedVolumeReply"},
                { "addMongoSource", "AddMongoSourceReply"},
                { "addO365Org", "AddO365OrgResponse"},
                { "o365SaasSetupComplete", "AddO365OrgResponse"},
                { "addSapHanaSystem", "AddSapHanaSystemReply"},
                { "addStorageArrays", "AddStorageArraysReply"},
                { "addSyslogExportRule", "AddSyslogExportRuleReply"},
                { "addVmAppConsistentSpecs", "AddVmAppConsistentSpecsReply"},
                { "allEnabledFeaturesForAccount", "AllEnabledFeaturesForAccountReply"},
                { "allStorageArrays", "AllStorageArraysReply"},
                { "amiTypeForAwsNativeArchivedSnapshotExport", "AmiTypeForAwsNativeArchivedSnapshotExportReply"},
                { "createCustomAnalyzer", "Analyzer"},
                { "customAnalyzer", "Analyzer"},
                { "updateCustomAnalyzer", "Analyzer"},
                { "userAnalyzerAccess", "AnalyzerAccessUsageConnection"},
                { "activeCustomAnalyzers", "AnalyzerConnection"},
                { "analyzerGroups", "AnalyzerGroupConnection"},
                { "analyzerUsages", "AnalyzerUsageConnection"},
                { "anomalyResults", "AnomalyResultConnection"},
                { "anomalyResultsGrouped", "AnomalyResultGroupedDataConnection"},
                { "archiveK8sCluster", "ArchiveK8sClusterReply"},
                { "assignMssqlSlaDomainPropertiesAsync", "AssignMssqlSlaDomainPropertiesAsyncReply"},
                { "downloadAuditLogCsvAsync", "AsyncDownloadReply"},
                { "downloadReportCsvAsync", "AsyncDownloadReply"},
                { "downloadReportPdfAsync", "AsyncDownloadReply"},
                { "sendScheduledReportAsync", "AsyncDownloadReply"},
                { "gcpNativeDisableProject", "AsyncJobStatus"},
                { "gcpNativeExportDisk", "AsyncJobStatus"},
                { "gcpNativeExportGceInstance", "AsyncJobStatus"},
                { "gcpNativeRestoreGceInstance", "AsyncJobStatus"},
                { "startAwsExocomputeDisableJob", "AsyncJobStatus"},
                { "startAwsNativeAccountDisableJob", "AsyncJobStatus"},
                { "startDisableAzureNativeSubscriptionProtectionJob", "AsyncJobStatus"},
                { "startEc2InstanceSnapshotExportJob", "AsyncJobStatus"},
                { "startExportAwsNativeEbsVolumeSnapshotJob", "AsyncJobStatus"},
                { "startExportAzureNativeManagedDiskJob", "AsyncJobStatus"},
                { "startExportAzureNativeVirtualMachineJob", "AsyncJobStatus"},
                { "startExportAzureSqlDatabaseDbJob", "AsyncJobStatus"},
                { "startExportAzureSqlManagedInstanceDbJob", "AsyncJobStatus"},
                { "startExportRdsInstanceJob", "AsyncJobStatus"},
                { "startRecoverS3SnapshotJob", "AsyncJobStatus"},
                { "startRestoreAwsNativeEc2InstanceSnapshotJob", "AsyncJobStatus"},
                { "startRestoreAzureNativeVirtualMachineJob", "AsyncJobStatus"},
                { "uploadDatabaseSnapshotToBlobstore", "AsyncJobStatus"},
                { "assignSlaToMongoDbCollection", "AsyncRequestStatus"},
                { "bulkCreateOnDemandMssqlBackup", "AsyncRequestStatus"},
                { "bulkTierExistingSnapshots", "AsyncRequestStatus"},
                { "checkCloudComputeConnectivityJobProgress", "AsyncRequestStatus"},
                { "configureSapHanaRestore", "AsyncRequestStatus"},
                { "createDownloadSnapshotForVolumeGroup", "AsyncRequestStatus"},
                { "createExchangeMount", "AsyncRequestStatus"},
                { "createFilesetSnapshot", "AsyncRequestStatus"},
                { "createHypervVirtualMachineSnapshotMount", "AsyncRequestStatus"},
                { "createMssqlLiveMount", "AsyncRequestStatus"},
                { "createMssqlLogShippingConfiguration", "AsyncRequestStatus"},
                { "createNutanixCluster", "AsyncRequestStatus"},
                { "createOnDemandDb2Backup", "AsyncRequestStatus"},
                { "createOnDemandExchangeBackup", "AsyncRequestStatus"},
                { "createOnDemandMssqlBackup", "AsyncRequestStatus"},
                { "createOnDemandNutanixBackup", "AsyncRequestStatus"},
                { "createOnDemandSapHanaBackup", "AsyncRequestStatus"},
                { "createOnDemandVolumeGroupBackup", "AsyncRequestStatus"},
                { "createOraclePdbRestore", "AsyncRequestStatus"},
                { "createSapHanaSystemRefresh", "AsyncRequestStatus"},
                { "deleteDb2Database", "AsyncRequestStatus"},
                { "deleteDb2Instance", "AsyncRequestStatus"},
                { "deleteExchangeSnapshotMount", "AsyncRequestStatus"},
                { "deleteHypervVirtualMachineSnapshotMount", "AsyncRequestStatus"},
                { "deleteLogShipping", "AsyncRequestStatus"},
                { "deleteManagedVolumeSnapshotExport", "AsyncRequestStatus"},
                { "deleteMongoSource", "AsyncRequestStatus"},
                { "deleteMssqlLiveMount", "AsyncRequestStatus"},
                { "deleteNasSystem", "AsyncRequestStatus"},
                { "deleteNutanixCluster", "AsyncRequestStatus"},
                { "deleteNutanixMountV1", "AsyncRequestStatus"},
                { "deleteOracleMount", "AsyncRequestStatus"},
                { "deleteSapHanaSystem", "AsyncRequestStatus"},
                { "deleteVolumeGroupMount", "AsyncRequestStatus"},
                { "deleteVsphereLiveMount", "AsyncRequestStatus"},
                { "discoverDb2Instance", "AsyncRequestStatus"},
                { "discoverMongoSource", "AsyncRequestStatus"},
                { "downloadDb2Snapshot", "AsyncRequestStatus"},
                { "downloadDb2SnapshotsForPointInTimeRecovery", "AsyncRequestStatus"},
                { "downloadExchangeSnapshot", "AsyncRequestStatus"},
                { "downloadFilesetSnapshot", "AsyncRequestStatus"},
                { "downloadFilesetSnapshotFromLocation", "AsyncRequestStatus"},
                { "downloadFilesNutanixSnapshot", "AsyncRequestStatus"},
                { "downloadHypervSnapshotFromLocation", "AsyncRequestStatus"},
                { "downloadHypervVirtualMachineSnapshot", "AsyncRequestStatus"},
                { "downloadHypervVirtualMachineSnapshotFiles", "AsyncRequestStatus"},
                { "downloadManagedVolumeFiles", "AsyncRequestStatus"},
                { "downloadManagedVolumeFromLocation", "AsyncRequestStatus"},
                { "downloadMssqlDatabaseBackupFiles", "AsyncRequestStatus"},
                { "downloadMssqlDatabaseFilesFromArchivalLocation", "AsyncRequestStatus"},
                { "downloadNutanixSnapshot", "AsyncRequestStatus"},
                { "downloadNutanixVmFromLocation", "AsyncRequestStatus"},
                { "downloadOracleDatabaseSnapshot", "AsyncRequestStatus"},
                { "downloadSapHanaSnapshot", "AsyncRequestStatus"},
                { "downloadSapHanaSnapshotFromLocation", "AsyncRequestStatus"},
                { "downloadSapHanaSnapshotsForPointInTimeRecovery", "AsyncRequestStatus"},
                { "downloadVolumeGroupSnapshotFiles", "AsyncRequestStatus"},
                { "downloadVolumeGroupSnapshotFromLocation", "AsyncRequestStatus"},
                { "downloadVsphereVirtualMachineFiles", "AsyncRequestStatus"},
                { "expireDownloadedDb2Snapshots", "AsyncRequestStatus"},
                { "expireDownloadedSapHanaSnapshots", "AsyncRequestStatus"},
                { "exportHypervVirtualMachine", "AsyncRequestStatus"},
                { "exportManagedVolumeSnapshot", "AsyncRequestStatus"},
                { "exportMssqlDatabase", "AsyncRequestStatus"},
                { "exportNutanixSnapshot", "AsyncRequestStatus"},
                { "exportOracleDatabase", "AsyncRequestStatus"},
                { "exportOracleTablespace", "AsyncRequestStatus"},
                { "exportSlaManagedVolumeSnapshot", "AsyncRequestStatus"},
                { "filesetDownloadSnapshotFiles", "AsyncRequestStatus"},
                { "filesetExportSnapshotFiles", "AsyncRequestStatus"},
                { "filesetRecoverFiles", "AsyncRequestStatus"},
                { "filesetRequestStatus", "AsyncRequestStatus"},
                { "generateSupportBundle", "AsyncRequestStatus"},
                { "hypervHostAsyncRequestStatus", "AsyncRequestStatus"},
                { "hypervOnDemandSnapshot", "AsyncRequestStatus"},
                { "hypervScvmmAsyncRequestStatus", "AsyncRequestStatus"},
                { "hypervVirtualMachineAsyncRequestStatus", "AsyncRequestStatus"},
                { "instantRecoverHypervVirtualMachineSnapshot", "AsyncRequestStatus"},
                { "instantRecoverOracleSnapshot", "AsyncRequestStatus"},
                { "migrateNutanixMountV1", "AsyncRequestStatus"},
                { "mountNutanixSnapshotV1", "AsyncRequestStatus"},
                { "mountOracleDatabase", "AsyncRequestStatus"},
                { "nutanixClusterAsyncRequestStatus", "AsyncRequestStatus"},
                { "nutanixVmAsyncRequestStatus", "AsyncRequestStatus"},
                { "patchMongoSource", "AsyncRequestStatus"},
                { "recoverCloudDirectMultiPaths", "AsyncRequestStatus"},
                { "recoverCloudDirectPath", "AsyncRequestStatus"},
                { "recoverMongoSource", "AsyncRequestStatus"},
                { "refreshDb2Database", "AsyncRequestStatus"},
                { "refreshHypervScvmm", "AsyncRequestStatus"},
                { "refreshHypervServer", "AsyncRequestStatus"},
                { "refreshNutanixCluster", "AsyncRequestStatus"},
                { "refreshOracleDatabase", "AsyncRequestStatus"},
                { "refreshVsphereVcenter", "AsyncRequestStatus"},
                { "registerHypervScvmm", "AsyncRequestStatus"},
                { "reseedLogShippingSecondary", "AsyncRequestStatus"},
                { "resizeManagedVolume", "AsyncRequestStatus"},
                { "restoreFilesNutanixSnapshot", "AsyncRequestStatus"},
                { "restoreHypervVirtualMachineSnapshotFiles", "AsyncRequestStatus"},
                { "restoreMssqlDatabase", "AsyncRequestStatus"},
                { "restoreOracleLogs", "AsyncRequestStatus"},
                { "restoreVolumeGroupSnapshotFiles", "AsyncRequestStatus"},
                { "retryAddMongoSource", "AsyncRequestStatus"},
                { "setWebSignedCertificate", "AsyncRequestStatus"},
                { "startVolumeGroupMount", "AsyncRequestStatus"},
                { "supportBundle", "AsyncRequestStatus"},
                { "takeManagedVolumeOnDemandSnapshot", "AsyncRequestStatus"},
                { "takeMssqlLogBackup", "AsyncRequestStatus"},
                { "takeOnDemandOracleDatabaseSnapshot", "AsyncRequestStatus"},
                { "takeOnDemandOracleLogSnapshot", "AsyncRequestStatus"},
                { "triggerCloudComputeConnectivityCheck", "AsyncRequestStatus"},
                { "unconfigureSapHanaRestore", "AsyncRequestStatus"},
                { "validateOracleDatabaseBackups", "AsyncRequestStatus"},
                { "vmwareDownloadSnapshotFromLocation", "AsyncRequestStatus"},
                { "vsphereDeleteVcenter", "AsyncRequestStatus"},
                { "vsphereExportSnapshotToStandaloneHostV2", "AsyncRequestStatus"},
                { "vsphereOnDemandSnapshot", "AsyncRequestStatus"},
                { "vSphereVMAsyncRequestStatus", "AsyncRequestStatus"},
                { "vsphereVmDownloadSnapshot", "AsyncRequestStatus"},
                { "vsphereVmDownloadSnapshotFiles", "AsyncRequestStatus"},
                { "vsphereVmExportSnapshotV2", "AsyncRequestStatus"},
                { "vsphereVmExportSnapshotV3", "AsyncRequestStatus"},
                { "vsphereVmExportSnapshotWithDownloadFromCloud", "AsyncRequestStatus"},
                { "vsphereVmInitiateDiskMount", "AsyncRequestStatus"},
                { "vsphereVmInitiateInPlaceRecovery", "AsyncRequestStatus"},
                { "vsphereVmInitiateInstantRecoveryV2", "AsyncRequestStatus"},
                { "vsphereVmInitiateLiveMountV2", "AsyncRequestStatus"},
                { "vsphereVmMountRelocate", "AsyncRequestStatus"},
                { "vsphereVmMountRelocateV2", "AsyncRequestStatus"},
                { "vsphereVmRecoverFilesNew", "AsyncRequestStatus"},
                { "ldapAuthorizedPrincipalConnection", "AuthorizedPrincipalConnection"},
                { "awsArtifactsToDelete", "AwsArtifactsToDelete"},
                { "awsCloudAccountListSecurityGroups", "AwsCloudAccountListSecurityGroupsResponse"},
                { "awsCloudAccountListSubnets", "AwsCloudAccountListSubnetsResponse"},
                { "awsCloudAccountListVpcs", "AwsCloudAccountListVpcResponse"},
                { "awsCloudAccountWithFeatures", "AwsCloudAccountWithFeatures"},
                { "awsComputeSettings", "AwsComputeSettings"},
                { "createAwsComputeSetting", "AwsComputeSettings"},
                { "updateAwsComputeSetting", "AwsComputeSettings"},
                { "awsNativeAccount", "AwsNativeAccount"},
                { "awsNativeAccounts", "AwsNativeAccountConnection"},
                { "awsNativeEbsVolume", "AwsNativeEbsVolume"},
                { "awsNativeEbsVolumes", "AwsNativeEbsVolumeConnection"},
                { "awsNativeEbsVolumesByName", "AwsNativeEbsVolumeConnection"},
                { "awsNativeEc2Instance", "AwsNativeEc2Instance"},
                { "awsNativeEc2Instances", "AwsNativeEc2InstanceConnection"},
                { "awsNativeEc2InstancesByName", "AwsNativeEc2InstanceConnection"},
                { "awsNativeRdsInstance", "AwsNativeRdsInstance"},
                { "awsNativeRdsInstances", "AwsNativeRdsInstanceConnection"},
                { "awsNativeRdsPointInTimeRestoreWindow", "AwsNativeRdsPointInTimeRestoreWindow"},
                { "awsNativeRoot", "AwsNativeRoot"},
                { "awsNativeS3Bucket", "AwsNativeS3Bucket"},
                { "awsTrustPolicy", "AwsTrustPolicy"},
                { "azureAdDirectory", "AzureAdDirectory"},
                { "azureAdDirectories", "AzureAdDirectoryConnection"},
                { "azureAdObjectsByType", "AzureAdObjectConnection"},
                { "searchAzureAdSnapshot", "AzureAdObjectConnection"},
                { "azureCloudAccountPermissionConfig", "AzureCloudAccountPermissionConfigResponse"},
                { "azureCloudAccountSubscriptionWithFeatures", "AzureCloudAccountSubscriptionWithFeatures"},
                { "azureCloudAccountTenant", "AzureCloudAccountTenant"},
                { "azureCloudAccountTenantWithExoConfigs", "AzureCloudAccountTenantWithExoConfigs"},
                { "azureNativeManagedDisk", "AzureNativeManagedDisk"},
                { "azureNativeManagedDisks", "AzureNativeManagedDiskConnection"},
                { "azureNativeResourceGroup", "AzureNativeResourceGroup"},
                { "azureNativeResourceGroups", "AzureNativeResourceGroupConnection"},
                { "azureNativeRoot", "AzureNativeRoot"},
                { "azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure", "AzureNativeSqlDatabasePointInTimeRestoreWindow"},
                { "azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure", "AzureNativeSqlDatabasePointInTimeRestoreWindow"},
                { "azureNativeSubscription", "AzureNativeSubscription"},
                { "azureNativeSubscriptions", "AzureNativeSubscriptionConnection"},
                { "azureNativeVirtualMachine", "AzureNativeVirtualMachine"},
                { "azureNativeVirtualMachines", "AzureNativeVirtualMachineConnection"},
                { "azureO365CheckNSGOutboundRules", "AzureNetworkSecurityGroupResp"},
                { "azureO365CheckNetworkSubnet", "AzureNetworkSubnetResp"},
                { "azureO365GetNetworkSubnetUnusedAddr", "AzureNetworkSubnetUnusedAddrResp"},
                { "azureOauthConsentKickoff", "AzureOauthConsentKickoffReply"},
                { "allHostedAzureRegions", "AzureRegionsResp"},
                { "azureO365CheckResourceGroupName", "AzureResourceAvailabilityResp"},
                { "azureO365CheckStorageAccountAccessibility", "AzureResourceAvailabilityResp"},
                { "azureO365CheckStorageAccountName", "AzureResourceAvailabilityResp"},
                { "azureO365CheckSubscriptionQuota", "AzureResourceAvailabilityResp"},
                { "azureO365CheckVirtualNetworkName", "AzureResourceAvailabilityResp"},
                { "azureSqlDatabase", "AzureSqlDatabaseDb"},
                { "azureSqlDatabases", "AzureSqlDatabaseDbConnection"},
                { "azureSqlDatabaseServer", "AzureSqlDatabaseServer"},
                { "azureSqlDatabaseServers", "AzureSqlDatabaseServerConnection"},
                { "azureSqlManagedInstanceDatabase", "AzureSqlManagedInstanceDatabase"},
                { "azureSqlManagedInstanceDatabases", "AzureSqlManagedInstanceDatabaseConnection"},
                { "azureSqlManagedInstanceServer", "AzureSqlManagedInstanceServer"},
                { "azureSqlManagedInstanceServers", "AzureSqlManagedInstanceServerConnection"},
                { "azureSubscriptions", "AzureSubscriptionConnection"},
                { "azureO365ValidateUserRoles", "AzureUserRoleResp"},
                { "backupO365Mailbox", "BatchAsyncJobStatus"},
                { "backupO365Onedrive", "BatchAsyncJobStatus"},
                { "backupO365SharepointDrive", "BatchAsyncJobStatus"},
                { "backupO365Team", "BatchAsyncJobStatus"},
                { "gcpNativeRefreshProjects", "BatchAsyncJobStatus"},
                { "setupCloudNativeSqlServerBackup", "BatchAsyncJobStatus"},
                { "startAwsNativeEc2InstanceSnapshotsJob", "BatchAsyncJobStatus"},
                { "startAwsNativeRdsInstanceSnapshotsJob", "BatchAsyncJobStatus"},
                { "startCloudNativeSnapshotsIndexJob", "BatchAsyncJobStatus"},
                { "startCreateAwsNativeEbsVolumeSnapshotsJob", "BatchAsyncJobStatus"},
                { "startCreateAzureNativeManagedDiskSnapshotsJob", "BatchAsyncJobStatus"},
                { "startCreateAzureNativeVirtualMachineSnapshotsJob", "BatchAsyncJobStatus"},
                { "startDisableAzureCloudAccountJob", "BatchAsyncJobStatus"},
                { "startRefreshAwsNativeAccountsJob", "BatchAsyncJobStatus"},
                { "startRefreshAzureNativeSubscriptionsJob", "BatchAsyncJobStatus"},
                { "bulkDeleteNasSystems", "BatchAsyncRequestStatus"},
                { "createNutanixPrismCentral", "BatchAsyncRequestStatus"},
                { "deleteNutanixPrismCentral", "BatchAsyncRequestStatus"},
                { "refreshNutanixPrismCentral", "BatchAsyncRequestStatus"},
                { "vsphereBulkOnDemandSnapshot", "BatchAsyncRequestStatus"},
                { "vsphereVmBatchExport", "BatchAsyncRequestStatus"},
                { "vsphereVmBatchExportV3", "BatchAsyncRequestStatus"},
                { "vsphereVmBatchInPlaceRecovery", "BatchAsyncRequestStatus"},
                { "vsphereVmInitiateBatchInstantRecovery", "BatchAsyncRequestStatus"},
                { "vsphereVmInitiateBatchLiveMountV2", "BatchAsyncRequestStatus"},
                { "batchExportHypervVm", "BatchExportHypervVmReply"},
                { "batchExportNutanixVm", "BatchExportNutanixVmReply"},
                { "batchInstantRecoverHypervVm", "BatchInstantRecoverHypervVmReply"},
                { "batchMountHypervVm", "BatchMountHypervVmReply"},
                { "batchMountNutanixVm", "BatchMountNutanixVmReply"},
                { "batchOnDemandBackupHypervVm", "BatchOnDemandBackupHypervVmReply"},
                { "batchQuarantineSnapshot", "BatchQuarantineSnapshotReply"},
                { "batchReleaseFromQuarantineSnapshot", "BatchReleaseFromQuarantineSnapshotReply"},
                { "vsphereVmwareCdpLiveInfo", "BatchVmwareCdpLiveInfo"},
                { "vsphereVMRecoverableRangeInBatch", "BatchVmwareVmRecoverableRanges"},
                { "beginManagedVolumeSnapshot", "BeginManagedVolumeSnapshotReply"},
                { "addInventoryWorkloads", "Boolean"},
                { "addRoleAssignments", "Boolean"},
                { "areMultiGeoBackupsEnabled", "Boolean"},
                { "batchDeassignRoleFromUserGroups", "Boolean"},
                { "cancelActivitySeries", "Boolean"},
                { "changePassword", "Boolean"},
                { "cloudNativeCheckRequiredPermissionsForFeature", "Boolean"},
                { "deleteCertificate", "Boolean"},
                { "deleteCloudWorkloadSnapshot", "Boolean"},
                { "deleteGuestCredentialById", "Boolean"},
                { "deleteLdapPrincipals", "Boolean"},
                { "deleteOrg", "Boolean"},
                { "deleteRole", "Boolean"},
                { "deleteServiceAccountsFromAccount", "Boolean"},
                { "deleteTotpConfig", "Boolean"},
                { "deleteTotpConfigs", "Boolean"},
                { "deleteUsersFromAccount", "Boolean"},
                { "doesAzureNativeResourceGroupExist", "Boolean"},
                { "dummyFieldWithAdminOnlyTag", "Boolean"},
                { "gcpCloudAccountAddManualAuthProject", "Boolean"},
                { "gcpSetDefaultServiceAccountJwtConfig", "Boolean"},
                { "hasIdpConfigured", "Boolean"},
                { "inviteSsoGroup", "Boolean"},
                { "isAwsNativeRdsInstanceLaunchConfigurationValid", "Boolean"},
                { "isAwsS3BucketNameAvailable", "Boolean"},
                { "isAzureNativeManagedDiskSnapshotRestorable", "Boolean"},
                { "isAzureNativeSqlDatabaseSnapshotPersistent", "Boolean"},
                { "isAzureStorageAccountNameAvailable", "Boolean"},
                { "isSfdcReachable", "Boolean"},
                { "isTotpAckNecessaryForCluster", "Boolean"},
                { "isTotpMandatoryInTargetVersion", "Boolean"},
                { "isVMwareManagementEnabled", "Boolean"},
                { "patchAwsAuthenticationServerBasedCloudAccount", "Boolean"},
                { "patchAwsIamUserBasedCloudAccount", "Boolean"},
                { "removeCdmCluster", "Boolean"},
                { "removeInventoryWorkloads", "Boolean"},
                { "removeLdapIntegration", "Boolean"},
                { "setAzureCloudAccountCustomerAppCredentials", "Boolean"},
                { "setIpWhitelistEnabled", "Boolean"},
                { "setLdapMfaSetting", "Boolean"},
                { "setMfaSetting", "Boolean"},
                { "setTotpConfig", "Boolean"},
                { "setUserLevelTotpEnforcement", "Boolean"},
                { "teamChannelNameAvailable", "Boolean"},
                { "updateAccountOwner", "Boolean"},
                { "updateCertificate", "Boolean"},
                { "updateIpWhitelist", "Boolean"},
                { "updateRole", "Boolean"},
                { "updateRoleAssignments", "Boolean"},
                { "upgradeAwsCloudAccountFeaturesWithoutCft", "Boolean"},
                { "upgradeAwsIamUserBasedCloudAccountPermissions", "Boolean"},
                { "warmSearchCache", "Boolean"},
                { "discoverNodes", "BootstrappableNodeInfoListResponse"},
                { "browseMssqlDatabaseSnapshot", "BrowseMssqlDatabaseSnapshotReply"},
                { "filesetSnapshotFiles", "BrowseResponseListResponse"},
                { "nutanixBrowseSnapshot", "BrowseResponseListResponse"},
                { "bulkCreateFilesetTemplates", "BulkCreateFilesetTemplatesReply"},
                { "bulkCreateFilesets", "BulkCreateFilesetsReply"},
                { "bulkCreateNasFilesets", "BulkCreateNasFilesetsReply"},
                { "bulkDeleteAwsCloudAccountWithoutCft", "BulkDeleteAwsCloudAccountWithoutCftReply"},
                { "bulkOnDemandSnapshotNutanixVm", "BulkOnDemandSnapshotNutanixVmReply"},
                { "bulkRefreshHosts", "BulkRefreshHostsReply"},
                { "bulkRegisterHost", "BulkRegisterHostReply"},
                { "bulkUpdateFilesetTemplate", "BulkUpdateFilesetTemplateReply"},
                { "bulkUpdateHost", "BulkUpdateHostReply"},
                { "bulkUpdateMssqlDbs", "BulkUpdateMssqlDbsReply"},
                { "bulkUpdateOracleDatabases", "BulkUpdateOracleDatabasesReply"},
                { "bulkUpdateOracleHosts", "BulkUpdateOracleHostsReply"},
                { "bulkUpdateOracleRacs", "BulkUpdateOracleRacsReply"},
                { "cancelDownloadPackage", "CancelJobReply"},
                { "cancelScheduledUpgrade", "CancelJobReply"},
                { "cassandraColumnFamily", "CassandraColumnFamily"},
                { "cassandraColumnFamilies", "CassandraColumnFamilyConnection"},
                { "cassandraKeyspace", "CassandraKeyspace"},
                { "cassandraKeyspaces", "CassandraKeyspaceConnection"},
                { "cassandraSource", "CassandraSource"},
                { "cassandraSources", "CassandraSourceConnection"},
                { "addNodesToCloudCluster", "CcProvisionJobReply"},
                { "createAwsCluster", "CcProvisionJobReply"},
                { "createAzureCluster", "CcProvisionJobReply"},
                { "deleteAwsCluster", "CcProvisionJobReply"},
                { "deleteAzureCluster", "CcProvisionJobReply"},
                { "recoverCloudCluster", "CcProvisionJobReply"},
                { "removeCloudClusterNodes", "CcProvisionJobReply"},
                { "removeClusterNodes", "CcProvisionJobReply"},
                { "nasTopLevelDescendants", "CdmHierarchyObjectConnection"},
                { "nutanixTopLevelDescendants", "CdmHierarchyObjectConnection"},
                { "vSphereRootRecoveryHierarchy", "CdmHierarchyObjectConnection"},
                { "vSphereTopLevelDescendantsConnection", "CdmHierarchyObjectConnection"},
                { "cdmHierarchySnappableNew", "CdmHierarchySnappableNew"},
                { "cdmInventorySubHierarchyRoot", "CdmInventorySubHierarchyRoot"},
                { "snapshot", "CdmSnapshot"},
                { "isUpgradeAvailable", "CdmUpgradeAvailabilityReply"},
                { "isUpgradeRecommended", "CdmUpgradeRecommendationReply"},
                { "getCdmReleaseDetailsForClusterFromSupportPortal", "CdmUpgradeReleaseDetailsFromSupportPortalReply"},
                { "getCdmReleaseDetailsForVersionFromSupportPortal", "CdmUpgradeReleaseDetailsFromSupportPortalReply"},
                { "getCdmReleaseDetailsFromSupportPortal", "CdmUpgradeReleaseDetailsFromSupportPortalReply"},
                { "allCdpVmsInfos", "CdpVmInfoConnection"},
                { "certificates", "CertificateConnection"},
                { "certificatesWithKey", "CertificateConnection"},
                { "clusterCertificates", "CertificateSummaryListResponse"},
                { "changeVfdOnHost", "ChangeVfdOnHostReply"},
                { "cloudNativeCheckArchivedSnapshotsLocked", "CheckArchivedSnapshotsLockedReply"},
                { "checkAzurePersistentStorageSubscriptionCanUnmap", "CheckAzurePersistentStorageSubscriptionCanUnmapReply"},
                { "createPolicy", "ClassificationPolicyDetail"},
                { "policy", "ClassificationPolicyDetail"},
                { "updatePolicy", "ClassificationPolicyDetail"},
                { "policies", "ClassificationPolicyDetailConnection"},
                { "clearCloudNativeSqlServerBackupCredentials", "ClearCloudNativeSqlServerBackupCredentialsReply"},
                { "cloudAccount", "CloudAccount"},
                { "createAwsAccount", "CloudAccount"},
                { "createAzureAccount", "CloudAccount"},
                { "updateAwsAccount", "CloudAccount"},
                { "updateAzureAccount", "CloudAccount"},
                { "cloudDirectNasExport", "CloudDirectNasExport"},
                { "cloudDirectSystems", "CloudDirectSystems"},
                { "cloudNativeCheckRbaConnectivity", "CloudNativeCheckRbaConnectivityReply"},
                { "cloudNativeCustomerTags", "CloudNativeCustomerTagsReply"},
                { "cloudNativeSnapshotDetailsForRecovery", "CloudNativeSnapshotDetailsForRecoveryReply"},
                { "cloudNativeSnapshotTypeDetails", "CloudNativeSnapshotTypeDetailsReply"},
                { "cloudNativeSqlServerSetupScript", "CloudNativeSqlServerSetupScript"},
                { "cloudNativeWorkloadVersionedFiles", "CloudNativeVersionedFileConnection"},
                { "cluster", "Cluster"},
                { "updateClusterLocation", "Cluster"},
                { "updatePreviewerClusterConfig", "Cluster"},
                { "allClusterConnection", "ClusterConnection"},
                { "clusterConnection", "ClusterConnection"},
                { "clusterWithUpgradesInfo", "ClusterConnection"},
                { "radarClusterConnection", "ClusterConnection"},
                { "clusterCsr", "ClusterCsr"},
                { "clusterDns", "ClusterDnsReply"},
                { "clusterGroupByConnection", "ClusterGroupByConnection"},
                { "clusterIpv6Mode", "ClusterIpv6ModeReply"},
                { "validateClusterLicenseCapacity", "ClusterLicenseCapacityValidations"},
                { "clusterOperationJobProgress", "ClusterOperationJobProgress"},
                { "clusterProxy", "ClusterProxyReply"},
                { "clusterRegistrationProductInfo", "ClusterRegistrationProductInfoType"},
                { "generateClusterRegistrationToken", "ClusterRegistrationToken"},
                { "clusterReportMigrationJobStatus", "ClusterReportMigrationJobStatus"},
                { "clusterSlaDomains", "ClusterSlaDomainConnection"},
                { "clusterWebSignedCertificate", "ClusterWebSignedCertificateReply"},
                { "completeAzureAdAppSetup", "CompleteAzureAdAppSetupReply"},
                { "completeAzureCloudAccountOauth", "CompleteAzureCloudAccountOauthReply"},
                { "computeClusterStatus", "ComputeClusterDetail"},
                { "countOfObjectsProtectedBySlas", "CountOfObjectsProtectedBySLAsResult"},
                { "crawl", "Crawl"},
                { "crawls", "CrawlConnection"},
                { "createAwsExocomputeConfigs", "CreateAwsExocomputeConfigsReply"},
                { "createAzureSaasAppAad", "CreateAzureSaasAppAadReply"},
                { "createCloudNativeAwsStorageSetting", "CreateCloudNativeAwsStorageSettingReply"},
                { "createCloudNativeAzureStorageSetting", "CreateCloudNativeAzureStorageSettingReply"},
                { "createCloudNativeLabelRule", "CreateCloudNativeLabelRuleReply"},
                { "createCloudNativeRcvAzureStorageSetting", "CreateCloudNativeRcvAzureStorageSettingReply"},
                { "createCloudNativeTagRule", "CreateCloudNativeTagRuleReply"},
                { "createCustomReport", "CreateCustomReportReply"},
                { "createFailoverClusterApp", "CreateFailoverClusterAppReply"},
                { "createFailoverCluster", "CreateFailoverClusterReply"},
                { "createGuestCredential", "CreateGuestCredentialReply"},
                { "createIntegration", "CreateIntegrationReply"},
                { "createIntegrations", "CreateIntegrationsReply"},
                { "createK8sAgentManifest", "CreateK8sAgentManifestReply"},
                { "createK8sCluster", "CreateK8sClusterReply"},
                { "createO365AppKickoff", "CreateO365AppKickoffResp"},
                { "backupO365SharepointList", "CreateOnDemandJobReply"},
                { "backupO365SharePointSite", "CreateOnDemandJobReply"},
                { "deleteAzureAdDirectory", "CreateOnDemandJobReply"},
                { "deleteO365Org", "CreateOnDemandJobReply"},
                { "exportK8sNamespace", "CreateOnDemandJobReply"},
                { "exportO365Mailbox", "CreateOnDemandJobReply"},
                { "refreshK8sCluster", "CreateOnDemandJobReply"},
                { "refreshO365Org", "CreateOnDemandJobReply"},
                { "restoreK8sNamespace", "CreateOnDemandJobReply"},
                { "restoreO365Mailbox", "CreateOnDemandJobReply"},
                { "restoreO365Snappable", "CreateOnDemandJobReply"},
                { "restoreO365TeamsConversations", "CreateOnDemandJobReply"},
                { "restoreO365TeamsFiles", "CreateOnDemandJobReply"},
                { "createOrg", "CreateOrgReply"},
                { "createOrgSwitchSession", "CreateOrgSwitchSessionReply"},
                { "createRcvPrivateEndpointApprovalRequest", "CreateRcvPrivateEndpointApprovalRequestReply"},
                { "createScheduledReport", "CreateScheduledReportReply"},
                { "createServiceAccount", "CreateServiceAccountReply"},
                { "createVappsInstantRecovery", "CreateVappsInstantRecoveryReply"},
                { "createVsphereAdvancedTag", "CreateVsphereAdvancedTagReply"},
                { "createVsphereVcenter", "CreateVsphereVcenterReply"},
                { "createWebhook", "CreateWebhookReply"},
                { "certificateSigningRequest", "Csr"},
                { "generateCsr", "Csr"},
                { "certificateSigningRequests", "CsrConnection"},
                { "db2Database", "Db2Database"},
                { "db2Databases", "Db2DatabaseConnection"},
                { "db2Instance", "Db2Instance"},
                { "db2Instances", "Db2InstanceConnection"},
                { "db2LogSnapshot", "Db2LogSnapshot"},
                { "db2LogSnapshots", "Db2LogSnapshotConnection"},
                { "db2RecoverableRange", "Db2RecoverableRange"},
                { "db2RecoverableRanges", "Db2RecoverableRangeConnection"},
                { "databaseLogReportingPropertiesForCluster", "DbLogReportProperties"},
                { "updateDatabaseLogReportingPropertiesForCluster", "DbLogReportProperties"},
                { "databaseLogReportForCluster", "DbLogReportSummaryListReply"},
                { "deleteAwsExocomputeConfigs", "DeleteAwsExocomputeConfigsReply"},
                { "deleteAzureCloudAccountExocomputeConfigurations", "DeleteAzureCloudAccountExocomputeConfigurationsReply"},
                { "deleteAzureCloudAccount", "DeleteAzureCloudAccountReply"},
                { "deleteAzureCloudAccountWithoutOauth", "DeleteAzureCloudAccountWithoutOauthReply"},
                { "deleteManagedVolume", "DeleteManagedVolumeReply"},
                { "deleteStorageArrays", "DeleteStorageArraysReply"},
                { "diffFmd", "DiffResult"},
                { "searchFileByPrefix", "DiffResult"},
                { "disableTarget", "DisableTargetReply"},
                { "setupDisk", "DiskInfo"},
                { "downloadCdmUpgradesPdf", "DownloadCdmUpgradesPdfReply"},
                { "downloadObjectFilesCsv", "DownloadCsvReply"},
                { "downloadObjectsListCsv", "DownloadCsvReply"},
                { "downloadSnapshotResultsCsv", "DownloadCsvReply"},
                { "downloadUserActivityCsv", "DownloadCsvReply"},
                { "downloadUserFileActivityCsv", "DownloadCsvReply"},
                { "cloudNativeDownloadFiles", "DownloadFilesReply"},
                { "retryDownloadPackageJob", "DownloadPackageReply"},
                { "downloadPackageStatus", "DownloadPackageStatusReply"},
                { "downloadResultsCsv", "DownloadResultsCsvReply"},
                { "downloadThreatHuntCsv", "DownloadThreatHuntCsvReply"},
                { "edgeWindowsToolLink", "EdgeWindowsToolLink"},
                { "enableAutomaticFmdUpload", "EnableAutomaticFmdUploadReply"},
                { "enableDisableAppConsistency", "EnableDisableAppConsistencyReply"},
                { "enableTarget", "EnableTargetReply"},
                { "endManagedVolumeSnapshot", "EndManagedVolumeSnapshotReply"},
                { "exchangeDag", "ExchangeDag"},
                { "exchangeDags", "ExchangeDagConnection"},
                { "exchangeDatabase", "ExchangeDatabase"},
                { "exchangeDatabases", "ExchangeDatabaseConnection"},
                { "exchangeLiveMounts", "ExchangeLiveMountConnection"},
                { "exchangeServer", "ExchangeServer"},
                { "exchangeServers", "ExchangeServerConnection"},
                { "decryptExportUrl", "ExportUrlSpecs"},
                { "failoverClusterApp", "FailoverClusterApp"},
                { "failoverClusterApps", "FailoverClusterAppConnection"},
                { "failoverClusterTopLevelDescendants", "FailoverClusterTopLevelDescendantTypeConnection"},
                { "cdmVersionCheck", "FeatureCdmVersionReply"},
                { "minimumCdmVersionForFeatureSet", "FeatureListMinimumCdmVersionReply"},
                { "federatedLoginStatus", "FederatedLoginStatus"},
                { "objectFiles", "FileResultConnection"},
                { "userActivities", "FileResultConnection"},
                { "filesetSnapshot", "FilesetSnapshotDetail"},
                { "filesetTemplate", "FilesetTemplate"},
                { "filesetTemplates", "FilesetTemplateConnection"},
                { "finalizeAwsCloudAccountDeletion", "FinalizeAwsCloudAccountDeletionReply"},
                { "finalizeAwsCloudAccountProtection", "FinalizeAwsCloudAccountProtectionReply"},
                { "gcpCloudAccountAddProjects", "GcpCloudAccountAddProjectsReply"},
                { "gcpCloudAccountDeleteProjects", "GcpCloudAccountDeleteProjectsReply"},
                { "gcpCloudAccountOauthComplete", "GcpCloudAccountOauthCompleteReply"},
                { "gcpCloudAccountOauthInitiate", "GcpCloudAccountOauthInitiateReply"},
                { "gcpCloudAccountUpgradeProjects", "GcpCloudAccountUpgradeProjectsReply"},
                { "gcpNativeDisk", "GcpNativeDisk"},
                { "gcpNativeDisks", "GcpNativeDiskConnection"},
                { "gcpNativeGceInstance", "GcpNativeGceInstance"},
                { "gcpNativeGceInstances", "GcpNativeGceInstanceConnection"},
                { "gcpNativeProject", "GcpNativeProject"},
                { "gcpNativeProjects", "GcpNativeProjectConnection"},
                { "generateConfigProtectionRestoreForm", "GenerateConfigProtectionRestoreFormReply"},
                { "generateTotpSecret", "GenerateTotpSecretReply"},
                { "snapshotOfASnappableConnection", "GenericSnapshotConnection"},
                { "snapshotOfSnappablesConnection", "GenericSnapshotConnection"},
                { "anomalyResultOpt", "GetAnomalyDetailsReply"},
                { "azureO365GetAzureHostType", "GetAzureHostTypeResp"},
                { "azureO365Exocompute", "GetAzureO365ExocomputeResp"},
                { "cloudNativeLabelRules", "GetCloudNativeLabelRulesReply"},
                { "cloudNativeTagRules", "GetCloudNativeTagRulesReply"},
                { "dashboardSummary", "GetDashboardSummaryReply"},
                { "getHealthMonitorPolicyStatus", "GetHealthMonitorPolicyStatusReply"},
                { "o365ObjectAncestors", "GetImplicitlyAuthorizedAncestorSummariesResponse"},
                { "o365OrgSummaries", "GetImplicitlyAuthorizedObjectSummariesResponse"},
                { "allLicensedProducts", "GetLicensedProductsInfoReply"},
                { "globalMfaSetting", "GetMfaSettingReply"},
                { "mfaSetting", "GetMfaSettingReply"},
                { "cassandraColumnFamilyRecoverableRange", "GetMosaicRecoverableRangeResponse"},
                { "mongodbCollectionRecoverableRange", "GetMosaicRecoverableRangeResponse"},
                { "o365ServiceStatus", "GetO365ServiceStatusResp"},
                { "o365StorageStats", "GetO365StorageStatsResp"},
                { "getPendingSlaAssignments", "GetPendingSlaAssignmentsReply"},
                { "pipelineHealthForTimeRange", "GetPipelineHealthReply"},
                { "discoveryTimeline", "GetPoliciesTimelineReply"},
                { "s3BucketStateForRecovery", "GetS3BucketStateForRecoveryReply"},
                { "cassandraColumnFamilySchema", "GetSchemaResponse"},
                { "smbConfiguration", "GetSmbConfigurationReply"},
                { "getKorgTaskchainStatus", "GetTaskchainStatusReply"},
                { "totpConfigStatus", "GetTotpStatusReply"},
                { "userDetail", "GetUserDetailReply"},
                { "userSessionManagementConfig", "GetUserSessionManagementConfigReply"},
                { "ipWhitelist", "GetWhitelistReply"},
                { "workloadAlertSetting", "GetWorkloadAlertSettingReply"},
                { "globalFileSearch", "GlobalFileSearchReply"},
                { "refreshGlobalManagerConnectivityStatus", "GlobalManagerConnectivity"},
                { "globalSlaFilterConnection", "GlobalSlaForFilterConnection"},
                { "createGlobalSla", "GlobalSlaReply"},
                { "updateGlobalSla", "GlobalSlaReply"},
                { "globalSlaStatuses", "GlobalSlaStatusConnection"},
                { "groupsInCurrentAndDescendantOrganization", "GroupConnection"},
                { "getGroupCountByCdmClusterStatus", "GroupCountListWithTotal"},
                { "guestCredentials", "GuestCredentialDetailListResponse"},
                { "guestCredentialsV2", "GuestOsCredentialConnection"},
                { "helpContentSnippets", "HelpContentSnippetConnection"},
                { "hierarchyObject", "HierarchyObject"},
                { "globalSearchResults", "HierarchyObjectConnection"},
                { "hierarchySnappables", "HierarchySnappableConnection"},
                { "hostDiagnosis", "HostDiagnosisSummary"},
                { "hostFailoverCluster", "HostFailoverCluster"},
                { "hostFailoverClusters", "HostFailoverClusterConnection"},
                { "hostShare", "HostShare"},
                { "hostShares", "HostShareConnection"},
                { "vCenterHotAddBandwidth", "HotAddBandwidthInfo"},
                { "vCenterHotAddNetwork", "HotAddNetworkConfigWithName"},
                { "hypervCluster", "HyperVCluster"},
                { "hypervMounts", "HyperVLiveMountConnection"},
                { "hypervScvmm", "HyperVSCVMM"},
                { "hypervScvmms", "HyperVSCVMMConnection"},
                { "hypervVirtualMachine", "HyperVVirtualMachine"},
                { "hypervVirtualMachines", "HyperVVirtualMachineConnection"},
                { "hypervServers", "HypervHostSummaryListResponse"},
                { "hypervScvmmUpdate", "HypervScvmmUpdateReply"},
                { "hypervServer", "HypervServer"},
                { "hypervTopLevelDescendants", "HypervTopLevelDescendantTypeConnection"},
                { "hypervVmDetail", "HypervVirtualMachineDetail"},
                { "maxProtectedAppsCount", "Int"},
                { "uniqueHypervServersCount", "Int"},
                { "uniqueVcdCount", "Int"},
                { "vCenterNumProxiesNeeded", "Int"},
                { "clusterFloatingIps", "InternalGetClusterIpsResponse"},
                { "clusterDefaultGateway", "InternalGetDefaultGatewayResponse"},
                { "replicationIncomingStats", "InternalReplicationBandwidthIncomingResponse"},
                { "replicationOutgoingStats", "InternalReplicationBandwidthOutgoingResponse"},
                { "inventoryRoot", "InventoryRoot"},
                { "inventorySubHierarchyRoot", "InventorySubHierarchyRoot"},
                { "investigationCsvDownloadLink", "InvestigationCsvDownloadLinkReply"},
                { "checkCloudNativeLabelRuleNameUniqueness", "IsCloudNativeTagRuleNameUniqueReply"},
                { "checkCloudNativeTagRuleNameUniqueness", "IsCloudNativeTagRuleNameUniqueReply"},
                { "isAwsNativeEbsVolumeSnapshotRestorable", "IsVolumeSnapshotRestorableReply"},
                { "issue", "Issue"},
                { "issues", "IssueConnection"},
                { "k8sAppManifest", "K8sAppManifest"},
                { "k8sCluster", "K8sCluster"},
                { "k8sClusters", "K8sClusterConnection"},
                { "k8sNamespace", "K8sNamespace"},
                { "k8sNamespaces", "K8sNamespaceConnection"},
                { "k8sSnapshotInfo", "K8sSnapshotInfo"},
                { "knowledgeBaseArticle", "KnowledgeBaseArticle"},
                { "lambdaSettings", "LambdaSettings"},
                { "updateLambdaSettings", "LambdaSettings"},
                { "ldapIntegrationConnection", "LdapIntegrationConnection"},
                { "snappablesWithLegalHoldSnapshotsSummary", "LegalHoldSnappableDetailConnection"},
                { "legalHoldSnapshotsForSnappable", "LegalHoldSnapshotDetailConnection"},
                { "licensesForClusterProductSummary", "LicensesForClusterProductReply"},
                { "linuxFileset", "LinuxFileset"},
                { "listCidrsForComputeSetting", "ListCidrsForComputeSettingReply"},
                { "allIntegrations", "ListIntegrationsReply"},
                { "ransomwareDetectionWorkloadLocations", "ListLocationsReply"},
                { "mosaicStores", "ListStoreResponse"},
                { "gcpNativeStoredDiskLocations", "ListStoredDiskLocationsReply"},
                { "mosaicSnapshots", "ListVersionResponse"},
                { "mosaicVersions", "ListVersionResponse"},
                { "globalLockoutConfig", "LockoutConfig"},
                { "lockoutConfig", "LockoutConfig"},
                { "lookupAccount", "LookupAccountReply"},
                { "m365Regions", "M365RegionsResp"},
                { "managedVolume", "ManagedVolume"},
                { "slaManagedVolume", "ManagedVolume"},
                { "managedVolumes", "ManagedVolumeConnection"},
                { "slaManagedVolumes", "ManagedVolumeConnection"},
                { "managedVolumeInventoryStats", "ManagedVolumeInventoryStats"},
                { "managedVolumeLiveMounts", "ManagedVolumeMountConnection"},
                { "mapAzureCloudAccountExocomputeSubscription", "MapAzureCloudAccountExocomputeSubscriptionReply"},
                { "mapAzureCloudAccountToPersistentStorageLocation", "MapAzureCloudAccountToPersistentStorageLocationReply"},
                { "mapCloudAccountExocomputeAccount", "MapCloudAccountExocomputeAccountReply"},
                { "mssqlDatabaseMissedSnapshots", "MissedSnapshotListResponse"},
                { "nutanixVmMissedSnapshots", "MissedSnapshotListResponse"},
                { "oracleMissedSnapshots", "MissedSnapshotListResponse"},
                { "clusterIpmi", "ModifyIpmiReply"},
                { "modifyIpmi", "ModifyIpmiReply"},
                { "mongoCollection", "MongoCollection"},
                { "mongoCollections", "MongoCollectionConnection"},
                { "mongoDatabase", "MongoDatabase"},
                { "mongoDatabases", "MongoDatabaseConnection"},
                { "mongoBulkRecoverableRanges", "MongoRecoverableRanges"},
                { "mongoRecoverableRanges", "MongoRecoverableRanges"},
                { "mongoSource", "MongoSource"},
                { "mongoSources", "MongoSourceConnection"},
                { "mongodbCollection", "MongodbCollection"},
                { "mongodbCollections", "MongodbCollectionConnection"},
                { "mongodbDatabase", "MongodbDatabase"},
                { "mongodbDatabases", "MongodbDatabaseConnection"},
                { "mongodbSource", "MongodbSource"},
                { "mongodbSources", "MongodbSourceConnection"},
                { "addMosaicStore", "MosaicAsyncResponse"},
                { "bulkDeleteCassandraSources", "MosaicAsyncResponse"},
                { "bulkDeleteMongodbSources", "MosaicAsyncResponse"},
                { "createCassandraSource", "MosaicAsyncResponse"},
                { "createMongodbSource", "MosaicAsyncResponse"},
                { "deleteCassandraSource", "MosaicAsyncResponse"},
                { "deleteMongodbSource", "MosaicAsyncResponse"},
                { "deleteMosaicStore", "MosaicAsyncResponse"},
                { "recoverCassandraSource", "MosaicAsyncResponse"},
                { "recoverMongodbSource", "MosaicAsyncResponse"},
                { "updateCassandraSource", "MosaicAsyncResponse"},
                { "updateMongodbSource", "MosaicAsyncResponse"},
                { "updateMosaicStore", "MosaicAsyncResponse"},
                { "mongodbBulkRecoverableRange", "MosaicRecoveryRangeResponse"},
                { "mosaicBulkRecoveryRange", "MosaicRecoveryRangeResponse"},
                { "mountDisk", "MountDiskReply"},
                { "mssqlAvailabilityGroup", "MssqlAvailabilityGroup"},
                { "mssqlDatabase", "MssqlDatabase"},
                { "mssqlDatabases", "MssqlDatabaseConnection"},
                { "mssqlDatabaseLiveMounts", "MssqlDatabaseLiveMountConnection"},
                { "mssqlInstance", "MssqlInstance"},
                { "mssqlCompatibleInstances", "MssqlInstanceSummaryListResponse"},
                { "mssqlLogShippingTargets", "MssqlLogShippingSummaryV2ListResponse"},
                { "cdmMssqlLogShippingTarget", "MssqlLogShippingTarget"},
                { "cdmMssqlLogShippingTargets", "MssqlLogShippingTargetConnection"},
                { "mssqlDatabaseMissedRecoverableRanges", "MssqlMissedRecoverableRangeListResponse"},
                { "mssqlRecoverableRanges", "MssqlRecoverableRangeListResponse"},
                { "mssqlDatabaseRestoreEstimate", "MssqlRestoreEstimateResult"},
                { "mssqlTopLevelDescendants", "MssqlTopLevelDescendantTypeConnection"},
                { "nasFileset", "NasFileset"},
                { "nasNamespace", "NasNamespace"},
                { "nasNamespaces", "NasNamespaceConnection"},
                { "nasShare", "NasShare"},
                { "nasSystem", "NasSystem"},
                { "nasSystems", "NasSystemConnection"},
                { "nasVolume", "NasVolume"},
                { "ncdBackEndCapacity", "NcdBackEndCapacity"},
                { "ncdFrontEndCapacity", "NcdFrontEndCapacity"},
                { "ncdObjectProtectionStatus", "NcdObjectProtectionStatus"},
                { "vCenterNetworks", "NetworkInfoListResponse"},
                { "clusterNetworkInterfaces", "NetworkInterfaceListResponse"},
                { "networkThrottle", "NetworkThrottleSummaryListResponse"},
                { "nfAnomalyResults", "NfAnomalyResultConnection"},
                { "nfAnomalyResultsGrouped", "NfAnomalyResultGroupedDataConnection"},
                { "nodeRemovalCancelPermission", "NodeRemovalCancelPermissionReply"},
                { "clusterNodes", "NodeStatusListResponse"},
                { "nodeToReplace", "NodeToReplaceReply"},
                { "notificationForGetLicense", "NotificationForGetLicenseReply"},
                { "clusterNtpServers", "NtpServerConfigurationListResponse"},
                { "nutanixCategory", "NutanixCategory"},
                { "nutanixCategoryValue", "NutanixCategoryValue"},
                { "nutanixCluster", "NutanixCluster"},
                { "nutanixClusters", "NutanixClusterConnection"},
                { "nutanixClusterContainers", "NutanixContainerListResponse"},
                { "nutanixMounts", "NutanixLiveMountConnection"},
                { "nutanixClusterNetworks", "NutanixNetworkListResponse"},
                { "nutanixPrismCentral", "NutanixPrismCentral"},
                { "nutanixPrismCentrals", "NutanixPrismCentralConnection"},
                { "nutanixVm", "NutanixVm"},
                { "nutanixVms", "NutanixVmConnection"},
                { "nutanixSnapshotDetail", "NutanixVmSnapshotDetail"},
                { "listO365Apps", "O365AppConnection"},
                { "o365Calendar", "O365Calendar"},
                { "configuredGroupMembers", "O365ConfiguredGroupMemberConnection"},
                { "browseCalendar", "O365ExchangeObjectConnection"},
                { "browseContacts", "O365ExchangeObjectConnection"},
                { "browseFolder", "O365ExchangeObjectConnection"},
                { "snappableContactSearch", "O365ExchangeObjectConnection"},
                { "snappableEmailSearch", "O365ExchangeObjectConnection"},
                { "snappableEventSearch", "O365ExchangeObjectConnection"},
                { "snapshotEmailSearch", "O365ExchangeObjectConnection"},
                { "snapshotEventSearch", "O365ExchangeObjectConnection"},
                { "sharepointSiteDescendants", "O365FullSpObjectConnection"},
                { "sharepointSiteSearch", "O365FullSpObjectConnection"},
                { "o365Groups", "O365GroupConnection"},
                { "o365License", "O365License"},
                { "o365Mailbox", "O365Mailbox"},
                { "o365Mailboxes", "O365MailboxConnection"},
                { "o365OauthConsentComplete", "O365OauthConsentCompleteReply"},
                { "o365OauthConsentKickoff", "O365OauthConsentKickoffReply"},
                { "o365Onedrive", "O365Onedrive"},
                { "o365Onedrives", "O365OnedriveConnection"},
                { "browseOnedrive", "O365OnedriveObjectConnection"},
                { "browseSharepointDrive", "O365OnedriveObjectConnection"},
                { "browseSharepointList", "O365OnedriveObjectConnection"},
                { "browseTeamsDrive", "O365OnedriveObjectConnection"},
                { "snappableOnedriveSearch", "O365OnedriveObjectConnection"},
                { "snappableSharepointDriveSearch", "O365OnedriveObjectConnection"},
                { "snappableSharepointListSearch", "O365OnedriveObjectConnection"},
                { "snappableTeamsDriveSearch", "O365OnedriveObjectConnection"},
                { "snapshotOnedriveSearch", "O365OnedriveObjectConnection"},
                { "snapshotSharepointDriveSearch", "O365OnedriveObjectConnection"},
                { "o365Org", "O365Org"},
                { "o365OrgAtSnappableLevel", "O365Org"},
                { "o365Orgs", "O365OrgConnection"},
                { "o365PdlGroups", "O365PdlGroupsReply"},
                { "o365SaaSSetupKickoff", "O365SaasSetupKickoffReply"},
                { "o365ServiceAccount", "O365ServiceAccountStatusResp"},
                { "o365SetupKickoff", "O365SetupKickoffResp"},
                { "o365SharepointDrive", "O365SharepointDrive"},
                { "o365SharepointDrives", "O365SharepointDriveConnection"},
                { "o365SharepointList", "O365SharepointList"},
                { "o365SharepointLists", "O365SharepointListConnection"},
                { "o365SharepointObjectList", "O365SharepointObjectConnection"},
                { "o365SharepointObjects", "O365SharepointObjectConnection"},
                { "o365SharepointSite", "O365Site"},
                { "o365Site", "O365Site"},
                { "o365SharepointSites", "O365SiteConnection"},
                { "o365Sites", "O365SiteConnection"},
                { "browseO365TeamConvChannels", "O365TeamConvChannelConnection"},
                { "o365TeamPostedBy", "O365TeamConversationsSenderConnection"},
                { "o365Team", "O365Teams"},
                { "browseTeamsChannels", "O365TeamsChannelConnection"},
                { "o365TeamChannels", "O365TeamsChannelConnection"},
                { "o365Teams", "O365TeamsConnection"},
                { "snappableTeamsConversationsSearch", "O365TeamsConversationsConnection"},
                { "o365User", "O365User"},
                { "o365UserObjects", "O365UserDescendantMetadataConnection"},
                { "oauthCodesForEdgeReg", "OauthCodesForEdgeRegReply"},
                { "oracleAcoParameters", "OracleAcoParameterList"},
                { "oracleDataGuardGroup", "OracleDataGuardGroup"},
                { "oracleDatabase", "OracleDatabase"},
                { "oracleDatabases", "OracleDatabaseConnection"},
                { "updateOracleDataGuardGroup", "OracleDbDetail"},
                { "oracleAcoExampleDownloadLink", "OracleFileDownloadLink"},
                { "oracleHost", "OracleHost"},
                { "oracleLiveMounts", "OracleLiveMountConnection"},
                { "oracleDatabaseLogBackupConfig", "OracleLogBackupConfig"},
                { "oracleHostLogBackupConfig", "OracleLogBackupConfig"},
                { "oracleRacLogBackupConfig", "OracleLogBackupConfig"},
                { "oracleMissedRecoverableRanges", "OracleMissedRecoverableRangeListResponse"},
                { "oraclePdbDetails", "OraclePdbDetails"},
                { "oracleRac", "OracleRac"},
                { "oracleRecoverableRanges", "OracleRecoverableRangeListResponse"},
                { "oracleTopLevelDescendants", "OracleTopLevelDescendantTypeConnection"},
                { "currentOrg", "Org"},
                { "org", "Org"},
                { "orgs", "OrgConnection"},
                { "orgSecurityPolicy", "OrgSecurityPolicy"},
                { "orgsForPrincipal", "OrgsForPrincipalReply"},
                { "overallRansomwareInvestigationSummary", "OverallRansomwareInvestigationSummary"},
                { "passwordComplexityPolicy", "PasswordComplexityPolicy"},
                { "patchDb2Database", "PatchDb2DatabaseReply"},
                { "patchDb2Instance", "PatchDb2InstanceReply"},
                { "patchNutanixMountV1", "PatchNutanixMountV1Reply"},
                { "patchSapHanaSystem", "PatchSapHanaSystemReply"},
                { "pauseSla", "PauseSlaReply"},
                { "pauseTarget", "PauseTargetReply"},
                { "pendingRansomwareInvestigationResultsCount", "PendingEvaluationResultsReply"},
                { "phoenixRolloutProgress", "PhoenixRolloutProgress"},
                { "physicalHost", "PhysicalHost"},
                { "physicalHosts", "PhysicalHostConnection"},
                { "polarisInventorySubHierarchyRoot", "PolarisInventorySubHierarchyRoot"},
                { "polarisSnapshot", "PolarisSnapshot"},
                { "policyDetails", "PolicyDetailConnection"},
                { "policyObj", "PolicyObj"},
                { "policyObjs", "PolicyObjConnection"},
                { "policyObjectUsages", "PolicyObjectUsageConnection"},
                { "startPeriodicUpgradePrechecksOnDemandJob", "PrechecksJobReply"},
                { "prechecksStatus", "PrechecksStatusReply"},
                { "prechecksStatusWithNextJobInfo", "PrechecksStatusReply"},
                { "prepareAwsCloudAccountDeletion", "PrepareAwsCloudAccountDeletionReply"},
                { "prepareFeatureUpdateForAwsCloudAccount", "PrepareFeatureUpdateForAwsCloudAccountReply"},
                { "ldapPrincipalConnection", "PrincipalConnection"},
                { "processedRansomwareInvestigationWorkloadCount", "ProcessedRansomwareInvestigationWorkloadCountReply"},
                { "productDocumentation", "ProductDocumentation"},
                { "protectedObjectsConnection", "ProtectedObjectsConnection"},
                { "protectedRansomwareInvestigationWorkloadCount", "ProtectedRansomwareInvestigationWorkloadCountReply"},
                { "putSmbConfiguration", "PutSmbConfigurationReply"},
                { "queryDatastoreFreespaceThresholds", "QueryDatastoreFreespaceThresholdsReply"},
                { "datagovSecDesc", "QuerySDDLReply"},
                { "ransomwareInvestigationAnalysisSummary", "RansomwareInvestigationAnalysisSummaryReply"},
                { "ransomwareInvestigationEnablement", "RansomwareInvestigationEnablementReply"},
                { "ransomwareInvestigationWorkloadScannedCount", "RansomwareInvestigationWorkloadScannedCountReply"},
                { "ransomwareResult", "RansomwareResult"},
                { "ransomwareResultOpt", "RansomwareResult"},
                { "ransomwareResults", "RansomwareResultConnection"},
                { "ransomwareResultsGrouped", "RansomwareResultGroupedDataConnection"},
                { "cloudNativeRbaInstallers", "RbaInstallerUrls"},
                { "rcsArchivalLocationsConsumptionStats", "RcsAzureArchivalLocationsConsumptionStatsOutput"},
                { "rcvAccountEntitlement", "RcvAccountEntitlement"},
                { "rdsInstanceDetailsFromAws", "RdsInstanceDetailsFromAws"},
                { "awsNativeRdsExportDefaults", "RdsInstanceExportDefaults"},
                { "integration", "ReadIntegrationReply"},
                { "vsphereVMMissedRecoverableRange", "RecoverableRangeResponse"},
                { "vsphereVMRecoverableRange", "RecoverableRangeResponse"},
                { "refreshHost", "RefreshHostReply"},
                { "refreshNasSystems", "RefreshNasSystemsReply"},
                { "refreshStorageArrays", "RefreshStorageArraysReply"},
                { "azureRegions", "RegionConnection"},
                { "registerAwsFeatureArtifacts", "RegisterAwsFeatureArtifactsReply"},
                { "registerCloudCluster", "RegisterCloudClusterReply"},
                { "registerNasSystem", "RegisterNasSystemReply"},
                { "removeNodeForReplacement", "RemoveNodeForReplacementReply"},
                { "removeVlans", "RemoveVlansReply"},
                { "replaceClusterNode", "ReplaceClusterNodeReply"},
                { "replicationPairs", "ReplicationPairConnection"},
                { "clusterReportMigrationStatus", "ReportMigrationStatusConnection"},
                { "clusterReportMigrationCount", "ReportsMigrationCount"},
                { "addAdGroupsToHierarchy", "RequestStatus"},
                { "azureOauthConsentComplete", "RequestStatus"},
                { "cancelTaskchain", "RequestStatus"},
                { "createO365AppComplete", "RequestStatus"},
                { "deleteAdGroupsFromHierarchy", "RequestStatus"},
                { "deleteO365AzureApp", "RequestStatus"},
                { "deleteO365ServiceAccount", "RequestStatus"},
                { "enableO365SharePoint", "RequestStatus"},
                { "enableO365Teams", "RequestStatus"},
                { "insertCustomerO365App", "RequestStatus"},
                { "setO365ServiceAccount", "RequestStatus"},
                { "deleteHypervVirtualMachineSnapshot", "RequestSuccess"},
                { "deleteNutanixSnapshot", "RequestSuccess"},
                { "deleteNutanixSnapshots", "RequestSuccess"},
                { "deleteVsphereAdvancedTag", "RequestSuccess"},
                { "excludeVmDisks", "RequestSuccess"},
                { "hypervDeleteAllSnapshots", "RequestSuccess"},
                { "installIoFilter", "RequestSuccess"},
                { "registerAgentHypervVirtualMachine", "RequestSuccess"},
                { "registerAgentNutanixVm", "RequestSuccess"},
                { "resolveVolumeGroupsConflict", "RequestSuccess"},
                { "uninstallIoFilter", "RequestSuccess"},
                { "updateVcenterHotAddBandwidth", "RequestSuccess"},
                { "updateVcenterHotAddNetwork", "RequestSuccess"},
                { "updateVsphereVm", "RequestSuccess"},
                { "upgradeIoFilter", "RequestSuccess"},
                { "vsphereExcludeVmDisks", "RequestSuccess"},
                { "vsphereVmRegisterAgent", "RequestSuccess"},
                { "azureResourceGroups", "ResourceGroupConnection"},
                { "addVlan", "ResponseSuccess"},
                { "assignMssqlSlaDomainProperties", "ResponseSuccess"},
                { "bulkDeleteFailoverCluster", "ResponseSuccess"},
                { "bulkDeleteFailoverClusterApp", "ResponseSuccess"},
                { "bulkDeleteFileset", "ResponseSuccess"},
                { "bulkDeleteFilesetTemplate", "ResponseSuccess"},
                { "bulkDeleteHost", "ResponseSuccess"},
                { "deleteFailoverCluster", "ResponseSuccess"},
                { "deleteFailoverClusterApp", "ResponseSuccess"},
                { "deleteFilesetSnapshots", "ResponseSuccess"},
                { "deleteMssqlDbSnapshots", "ResponseSuccess"},
                { "deleteSapHanaDbSnapshot", "ResponseSuccess"},
                { "disableReplicationPause", "ResponseSuccess"},
                { "enableReplicationPause", "ResponseSuccess"},
                { "hideRevealNasShares", "ResponseSuccess"},
                { "hypervScvmmDelete", "ResponseSuccess"},
                { "removeDisk", "ResponseSuccess"},
                { "removeProxyConfig", "ResponseSuccess"},
                { "resizeDisk", "ResponseSuccess"},
                { "updateClusterNtpServers", "ResponseSuccess"},
                { "updateDnsServersAndSearchDomains", "ResponseSuccess"},
                { "restoreAzureAdObjectsWithPasswords", "RestoreAzureAdObjectsWithPasswordsReply"},
                { "resumeTarget", "ResumeTargetReply"},
                { "retryBackup", "RetryBackupResp"},
                { "getAllRolesInOrgConnection", "RoleConnection"},
                { "roleTemplates", "RoleTemplateConnection"},
                { "rotateServiceAccountSecret", "RotateServiceAccountSecretReply"},
                { "reportData", "RowConnection"},
                { "runCustomAnalyzer", "RunCustomAnalyzerReply"},
                { "sapHanaDatabase", "SapHanaDatabase"},
                { "sapHanaDatabases", "SapHanaDatabaseConnection"},
                { "sapHanaLogSnapshot", "SapHanaLogSnapshot"},
                { "sapHanaLogSnapshots", "SapHanaLogSnapshotConnection"},
                { "sapHanaRecoverableRange", "SapHanaRecoverableRange"},
                { "sapHanaRecoverableRanges", "SapHanaRecoverableRangeConnection"},
                { "sapHanaSystem", "SapHanaSystem"},
                { "sapHanaSystems", "SapHanaSystemConnection"},
                { "scheduledReport", "ScheduledReport"},
                { "scheduledReports", "ScheduledReportConnection"},
                { "searchHost", "SearchResponseListResponse"},
                { "searchNutanixVm", "SearchResponseListResponse"},
                { "seedEnabledPolicies", "SeedEnabledPoliciesReply"},
                { "seedInitialPolicies", "SeedInitialPoliciesReply"},
                { "sendPdfReport", "SendPdfReportReply"},
                { "serviceAccounts", "ServiceAccountConnection"},
                { "setAnalyzerRisks", "SetAnalyzerRisksReply"},
                { "setDatastoreFreespaceThresholds", "SetDatastoreFreespaceThresholdsReply"},
                { "setUpgradeType", "SetUpgradeTypeReply"},
                { "setWorkloadAlertSetting", "SetWorkloadAlertSettingReply"},
                { "setupAzureO365Exocompute", "SetupAzureO365ExocomputeResp"},
                { "shareFileset", "ShareFileset"},
                { "assignProtection", "SlaAssignResult"},
                { "assignRetentionSLAToSnappables", "SlaAssignResult"},
                { "assignRetentionSLAToSnapshots", "SlaAssignResult"},
                { "assignSla", "SlaAssignResult"},
                { "slaDomain", "SlaDomain"},
                { "slaDomains", "SlaDomainConnection"},
                { "smbDomains", "SmbDomainConnection"},
                { "searchSnappableConnection", "SnappableConnection"},
                { "snappableConnection", "SnappableConnection"},
                { "snappableGroupByConnection", "SnappableGroupByConnection"},
                { "browseSnapshotFileConnection", "SnapshotFileConnection"},
                { "cloudNativeSnapshots", "SnapshotFileConnection"},
                { "snapshotFilesDelta", "SnapshotFileDeltaConnection"},
                { "snapshotFilesDeltaV2", "SnapshotFileDeltaV2Connection"},
                { "snapshotResults", "SnapshotResultConnection"},
                { "snapshotsForUnmanagedObject", "SnapshotSummaryConnection"},
                { "snmpConfigurations", "SnmpConfiguration"},
                { "sonarContentReport", "SonarContentReportConnection"},
                { "sonarReport", "SonarReportConnection"},
                { "sonarReportRow", "SonarReportRowConnection"},
                { "startAzureAdAppSetup", "StartAzureAdAppSetupReply"},
                { "startAzureAdAppUpdate", "StartAzureAdAppUpdateReply"},
                { "startAzureCloudAccountOauth", "StartAzureCloudAccountOauthReply"},
                { "startClusterReportMigrationJob", "StartClusterReportMigrationJobReply"},
                { "startCrawl", "StartCrawlReply"},
                { "startThreatHunt", "StartThreatHuntReply"},
                { "stopJobInstance", "StopJobInstanceReply"},
                { "azureStorageAccounts", "StorageAccountConnection"},
                { "accountId", "String"},
                { "addPolicyObjects", "String"},
                { "archiveCrawl", "String"},
                { "createUser", "String"},
                { "createUserWithPassword", "String"},
                { "currentIpAddress", "String"},
                { "deactivateCustomAnalyzer", "String"},
                { "deploymentVersion", "String"},
                { "externalDeploymentName", "String"},
                { "gcpGetDefaultCredentialsServiceAccount", "String"},
                { "o365TeamConversationsFolderID", "String"},
                { "updateLdapIntegration", "String"},
                { "updateWhitelistedAnalyzers", "String"},
                { "azureSubnets", "SubnetConnection"},
                { "supportPortalLogin", "SupportPortalLoginReply"},
                { "logoutFromRubrikSupportPortal", "SupportPortalLogoutReply"},
                { "isLoggedIntoRubrikSupportPortal", "SupportPortalStatusReply"},
                { "tunnelStatus", "SupportTunnelInfo"},
                { "supportUserAccesses", "SupportUserAccessConnection"},
                { "syslogExportRules", "SyslogExportRuleSummaryListResponse"},
                { "tableFilters", "TableFilters"},
                { "takeOnDemandSnapshot", "TakeOnDemandSnapshotReply"},
                { "createAwsReaderTarget", "Target"},
                { "createAwsTarget", "Target"},
                { "createAzureReaderTarget", "Target"},
                { "createAzureTarget", "Target"},
                { "createGcpReaderTarget", "Target"},
                { "createGcpTarget", "Target"},
                { "createGlacierReaderTarget", "Target"},
                { "createNfsReaderTarget", "Target"},
                { "createNfsTarget", "Target"},
                { "createRcsReaderTarget", "Target"},
                { "createRcsTarget", "Target"},
                { "createS3CompatibleReaderTarget", "Target"},
                { "createS3CompatibleTarget", "Target"},
                { "createTapeReaderTarget", "Target"},
                { "createTapeTarget", "Target"},
                { "target", "Target"},
                { "updateAwsTarget", "Target"},
                { "updateAzureTarget", "Target"},
                { "updateGcpTarget", "Target"},
                { "updateGlacierTarget", "Target"},
                { "updateNfsTarget", "Target"},
                { "updateRcvTarget", "Target"},
                { "updateS3CompatibleTarget", "Target"},
                { "updateTapeTarget", "Target"},
                { "targets", "TargetConnection"},
                { "createAutomaticAwsTargetMapping", "TargetMapping"},
                { "createAutomaticAzureTargetMapping", "TargetMapping"},
                { "createAutomaticRcsTargetMapping", "TargetMapping"},
                { "createManualTargetMapping", "TargetMapping"},
                { "targetMapping", "TargetMapping"},
                { "updateAutomaticAwsTargetMapping", "TargetMapping"},
                { "updateAutomaticAzureTargetMapping", "TargetMapping"},
                { "updateManualTargetMapping", "TargetMapping"},
                { "updateRcsAutomaticTargetMapping", "TargetMapping"},
                { "taskDetailConnection", "TaskDetailConnection"},
                { "taskDetailGroupByConnection", "TaskDetailGroupByConnection"},
                { "currentOrgAuthDomainConfig", "TenantAuthDomainConfig"},
                { "testExistingWebhook", "TestExistingWebhookReply"},
                { "testSyslogExportRule", "TestSyslogExportRuleReply"},
                { "testWebhook", "TestWebhookReply"},
                { "threatHuntDetail", "ThreatHunt"},
                { "threatHunts", "ThreatHuntConnection"},
                { "threatHuntResult", "ThreatHuntResult"},
                { "threatHuntSummary", "ThreatHuntSummaryReply"},
                { "triggerExocomputeHealthCheck", "TriggerExocomputeHealthCheckReply"},
                { "triggerRansomwareDetection", "TriggerRansomwareDetectionReply"},
                { "createRole", "UUID"},
                { "mutateRole", "UUID"},
                { "unmanagedObjects", "UnmanagedObjectDetailConnection"},
                { "unmapAzureCloudAccountExocomputeSubscription", "UnmapAzureCloudAccountExocomputeSubscriptionReply"},
                { "unmapCloudAccountExocomputeAccount", "UnmapCloudAccountExocomputeAccountReply"},
                { "updateAutoEnablePolicyClusterConfig", "UpdateAutoEnablePolicyClusterConfigReply"},
                { "updateAwsCloudAccountFeature", "UpdateAwsCloudAccountFeatureReply"},
                { "updateAwsExocomputeConfigs", "UpdateAwsExocomputeConfigsReply"},
                { "updateAzureCloudAccount", "UpdateAzureCloudAccountReply"},
                { "updateBadDiskLedStatus", "UpdateBadDiskLedStatusReply"},
                { "updateCertificateHost", "UpdateCertificateHostReply"},
                { "updateCloudNativeAwsStorageSetting", "UpdateCloudNativeAwsStorageSettingReply"},
                { "updateCloudNativeAzureStorageSetting", "UpdateCloudNativeAzureStorageSettingReply"},
                { "updateCloudNativeIndexingStatus", "UpdateCloudNativeIndexingStatusReply"},
                { "updateCloudNativeRcvAzureStorageSetting", "UpdateCloudNativeRcvAzureStorageSettingReply"},
                { "updateClusterDefaultAddress", "UpdateClusterDefaultAddressReply"},
                { "updateClusterSettings", "UpdateClusterSettingsReply"},
                { "updateCustomReport", "UpdateCustomReportReply"},
                { "updateEventDigest", "UpdateEventDigestReply"},
                { "updateFailoverClusterApp", "UpdateFailoverClusterAppReply"},
                { "updateFailoverCluster", "UpdateFailoverClusterReply"},
                { "updateFloatingIps", "UpdateFloatingIpsReply"},
                { "updateGuestCredential", "UpdateGuestCredentialReply"},
                { "updateHealthMonitorPolicyStatus", "UpdateHealthMonitorPolicyStatusReply"},
                { "updateHypervVirtualMachine", "UpdateHypervVirtualMachineReply"},
                { "updateHypervVirtualMachineSnapshotMount", "UpdateHypervVirtualMachineSnapshotMountReply"},
                { "updateInsightState", "UpdateInsightStateReply"},
                { "updateLockoutConfig", "UpdateLockoutConfigReply"},
                { "updateManagedVolume", "UpdateManagedVolumeReply"},
                { "mssqlDefaultProperties", "UpdateMssqlDefaultPropertiesReply"},
                { "updateMssqlDefaultProperties", "UpdateMssqlDefaultPropertiesReply"},
                { "updateMssqlLogShippingConfiguration", "UpdateMssqlLogShippingConfigurationReply"},
                { "updateNasSystem", "UpdateNasSystemReply"},
                { "updateNetworkThrottle", "UpdateNetworkThrottleReply"},
                { "updateNutanixCluster", "UpdateNutanixClusterReply"},
                { "updateNutanixPrismCentral", "UpdateNutanixPrismCentralReply"},
                { "updateO365AppAuthStatus", "UpdateO365AppAuthStatusReply"},
                { "updateO365OrgCustomName", "UpdateO365OrgCustomNameReply"},
                { "updateOrg", "UpdateOrgReply"},
                { "updateProxyConfig", "UpdateProxyConfigReply"},
                { "updateScheduledReport", "UpdateScheduledReportReply"},
                { "updateServiceAccount", "UpdateServiceAccountReply"},
                { "updateSnmpConfig", "UpdateSnmpConfigReply"},
                { "updateStorageArrays", "UpdateStorageArraysReply"},
                { "updateSyslogExportRule", "UpdateSyslogExportRuleReply"},
                { "updateTunnelStatus", "UpdateTunnelStatusReply"},
                { "updateVcenter", "UpdateVcenterReply"},
                { "updateVolumeGroup", "UpdateVolumeGroupReply"},
                { "updateVsphereAdvancedTag", "UpdateVsphereAdvancedTagReply"},
                { "updateWebhook", "UpdateWebhookReply"},
                { "upgradeAzureCloudAccountPermissionsWithoutOauth", "UpgradeAzureCloudAccountPermissionsWithoutOauthReply"},
                { "upgradeAzureCloudAccount", "UpgradeAzureCloudAccountReply"},
                { "upgradeGcpCloudAccountPermissionsWithoutOauth", "UpgradeGcpCloudAccountPermissionsWithoutOauthReply"},
                { "upgradeStatus", "UpgradeStatusReply"},
                { "currentUser", "User"},
                { "allFileActivities", "UserActivityResultConnection"},
                { "userAuditConnection", "UserAuditConnection"},
                { "allUsersOnAccountConnection", "UserConnection"},
                { "usersInCurrentAndDescendantOrganization", "UserConnection"},
                { "getDownloadUrl", "UserDownloadUrl"},
                { "currentUserLoginContext", "UserLoginContext"},
                { "userNotifications", "UserNotifications"},
                { "userSettings", "UserSettings"},
                { "bulkUpdateExchangeDag", "V1BulkUpdateExchangeDagResponse"},
                { "allMssqlDatabaseRestoreFiles", "V1MssqlGetRestoreFilesV1Response"},
                { "allValidReplicationTargets", "ValidReplicationTargetConnection"},
                { "validateAndCreateAwsCloudAccount", "ValidateAndCreateAwsCloudAccountReply"},
                { "validateAndSaveCustomerKmsInfo", "ValidateAndSaveCustomerKmsInfoReply"},
                { "validateAwsNativeRdsClusterNameForExport", "ValidateAwsNativeRdsClusterNameForExportReply"},
                { "validateAwsNativeRdsInstanceNameForExport", "ValidateAwsNativeRdsInstanceNameForExportReply"},
                { "validateAzureNativeSqlDatabaseDbNameForExport", "ValidateAzureNativeSqlDatabaseDbNameForExportReply"},
                { "validateAzureNativeSqlManagedInstanceDbNameForExport", "ValidateAzureNativeSqlManagedInstanceDbNameForExportReply"},
                { "validateAzureCloudAccountExocomputeConfigurations", "ValidateAzureSubnetsForCloudAccountExocomputeReply"},
                { "isCloudNativeFileRecoveryFeasible", "ValidateCloudNativeFileRecoveryFeasibilityReply"},
                { "validateOracleAcoFile", "ValidateOracleAcoFileReply"},
                { "validateOrgName", "ValidateOrgNameReply"},
                { "vappSnapshotInstantRecoveryOptions", "VappInstantRecoveryOptions"},
                { "vappTemplateSnapshotExportOptions", "VappTemplateExportOptionsUnion"},
                { "vCenterAdvancedTagPreview", "VcenterAdvancedTagPreviewReply"},
                { "vCenterPreAddInfo", "VcenterPreAddInfo"},
                { "verifySlaWithReplicationToCluster", "VerifySlaWithReplicationToClusterResponse"},
                { "searchSnappableVersionedFiles", "VersionedFileConnection"},
                { "allVirtualMachineFiles", "VirtualMachineFilesReply"},
                { "clusterVlans", "VlanConfigListResponse"},
                { "vSphereHostDetails", "VmwareHostDetail"},
                { "azureVNets", "VnetConnection"},
                { "cancelThreatHunt", "Void"},
                { "completeAzureAdAppUpdate", "Void"},
                { "createReplicationPair", "Void"},
                { "deleteAllOracleDatabaseSnapshots", "Void"},
                { "deleteAwsComputeSetting", "Void"},
                { "deleteCloudNativeLabelRule", "Void"},
                { "deleteCloudNativeTagRule", "Void"},
                { "deleteCsr", "Void"},
                { "deleteCustomReport", "Void"},
                { "deleteEventDigest", "Void"},
                { "deleteIntegration", "Void"},
                { "deleteIntegrations", "Void"},
                { "deleteReplicationPair", "Void"},
                { "deleteScheduledReport", "Void"},
                { "deleteSmbDomain", "Void"},
                { "deleteSyslogExportRule", "Void"},
                { "deleteTarget", "Void"},
                { "deleteTargetMapping", "Void"},
                { "deleteWebhook", "Void"},
                { "disableSupportUserAccess", "Void"},
                { "enableSupportUserAccess", "Void"},
                { "enableThreatMonitoring", "Void"},
                { "excludeAwsNativeEbsVolumesFromSnapshot", "Void"},
                { "excludeAzureNativeManagedDisksFromSnapshot", "Void"},
                { "excludeSharepointObjectsFromProtection", "Void"},
                { "gcpNativeExcludeDisksFromInstanceSnapshot", "Void"},
                { "hideRevealNasNamespaces", "Void"},
                { "joinSmbDomain", "Void"},
                { "lockUsersByAdmin", "Void"},
                { "promoteReaderTarget", "Void"},
                { "refreshReaderTarget", "Void"},
                { "removePrivateEndpointConnection", "Void"},
                { "resetAllOrgUsersPasswords", "Void"},
                { "resetUsersPasswordsWithUserIds", "Void"},
                { "revokeAllOrgRoles", "Void"},
                { "setCustomerTags", "Void"},
                { "setPasswordComplexityPolicy", "Void"},
                { "setSsoCertificate", "Void"},
                { "stopJobInstanceFromEventSeries", "Void"},
                { "unlockUsersByAdmin", "Void"},
                { "unmapAzurePersistentStorageSubscription", "Void"},
                { "unmountDisk", "Void"},
                { "updateAuthDomainUsersHiddenStatus", "Void"},
                { "updateAwsCloudAccount", "Void"},
                { "updateCloudNativeLabelRule", "Void"},
                { "updateCloudNativeTagRule", "Void"},
                { "updateConfiguredGroup", "Void"},
                { "updateCustomerAppPermissionForAzureSql", "Void"},
                { "updateIntegration", "Void"},
                { "updateIntegrations", "Void"},
                { "updateNasShares", "Void"},
                { "updateNutanixVm", "Void"},
                { "updateO365AppPermissions", "Void"},
                { "updateOrgSecurityPolicy", "Void"},
                { "updateReplicationTarget", "Void"},
                { "updateSupportUserAccess", "Void"},
                { "upgradeCdmManagedTarget", "Void"},
                { "upgradeToRsc", "Void"},
                { "vsphereVmDeleteSnapshot", "Void"},
                { "volumeGroupMounts", "VolumeGroupLiveMountConnection"},
                { "vsphereVmRecoverFiles", "VsphereAsyncRequestStatus"},
                { "vSphereComputeCluster", "VsphereComputeCluster"},
                { "vSphereComputeClusters", "VsphereComputeClusterConnection"},
                { "vSphereDatacenter", "VsphereDatacenter"},
                { "vSphereDatastore", "VsphereDatastore"},
                { "vSphereDatastoreCluster", "VsphereDatastoreCluster"},
                { "vSphereDatastoreClusters", "VsphereDatastoreClusterConnection"},
                { "vSphereDatastoreConnection", "VsphereDatastoreConnection"},
                { "vSphereFolder", "VsphereFolder"},
                { "vSphereFolders", "VsphereFolderConnection"},
                { "vSphereHost", "VsphereHost"},
                { "vSphereHostConnection", "VsphereHostConnection"},
                { "vSphereLiveMounts", "VsphereLiveMountConnection"},
                { "vSphereMount", "VsphereMount"},
                { "vSphereMountConnection", "VsphereMountConnection"},
                { "vSphereNetwork", "VsphereNetwork"},
                { "vSphereResourcePool", "VsphereResourcePool"},
                { "vSphereTag", "VsphereTag"},
                { "vSphereTagCategory", "VsphereTagCategory"},
                { "vSphereVCenter", "VsphereVcenter"},
                { "vSphereVCenterConnection", "VsphereVcenterConnection"},
                { "vSphereVmNew", "VsphereVm"},
                { "vcdVappVms", "VsphereVmConnection"},
                { "vSphereVmNewConnection", "VsphereVmConnection"},
                { "vsphereVmListEsxiDatastores", "VsphereVmListEsxiDatastoresReply"},
                { "vsphereVmPowerOnOffLiveMount", "VsphereVmPowerOnOffLiveMountReply"},
                { "allWebhooks", "WebhookConnection"},
                { "windowsCluster", "WindowsCluster"},
                { "windowsFileset", "WindowsFileset"},
                { "workloadAnomalies", "WorkloadAnomalyConnection"},
                { "isZrsAvailableForLocation", "ZrsAvailabilityReply"},
                { "allAccountProducts", "[AccountProduct]"},
                { "allO365AdGroups", "[AdGroup]"},
                { "archivalStorageUsage", "[ArchivalStorageUsage]"},
                { "allAuthorizationsForObjects", "[AuthorizedOperations]"},
                { "allAwsCdmVersions", "[AwsCdmVersion]"},
                { "allAwsRegions", "[AwsCloudAccountRegion]"},
                { "allAwsCloudAccountsWithFeatures", "[AwsCloudAccountWithFeatures]"},
                { "allAwsComputeSettings", "[AwsComputeSettings]"},
                { "allAwsExocomputeConfigs", "[AwsExocomputeConfig]"},
                { "allAwsCloudAccountConfigs", "[AwsFeatureConfig]"},
                { "allVpcsByRegionFromAws", "[AwsVpc]"},
                { "allVpcsFromAws", "[AwsVpc]"},
                { "allAzureArmTemplatesByFeature", "[AzureArmTemplateByFeature]"},
                { "allAzureCdmVersions", "[AzureCdmVersion]"},
                { "allAzureRegions", "[AzureCloudAccountRegion]"},
                { "allAzureCloudAccountTenants", "[AzureCloudAccountTenant]"},
                { "allAzureEncryptionKeys", "[AzureEncryptionKey]"},
                { "allAzureExocomputeConfigsInAccount", "[AzureExocomputeConfigsInAccount]"},
                { "allAzureKeyVaultsByRegion", "[AzureKeyVault]"},
                { "allAzureManagedIdentities", "[AzureManagedIdentity]"},
                { "allAzureNativeAvailabilitySetsByRegionFromAzure", "[AzureNativeAvailabilitySet]"},
                { "allAzureDiskEncryptionSetsByRegion", "[AzureNativeDiskEncryptionSet]"},
                { "allAzureNativeExportCompatibleDiskTypesByRegionFromAzure", "[AzureNativeExportCompatibleDiskTypes]"},
                { "allAzureNativeExportCompatibleVmSizesByRegionFromAzure", "[AzureNativeExportCompatibleVmSizes]"},
                { "allAzureNativeSecurityGroupsByRegionFromAzure", "[AzureNativeSecurityGroup]"},
                { "allAzureNativeStorageAccountsFromAzure", "[AzureNativeStorageAccount]"},
                { "allAzureCloudAccountSubnetsByRegion", "[AzureNativeSubnet]"},
                { "allAzureNativeSubnetsByRegionFromAzure", "[AzureNativeSubnet]"},
                { "allAzureNativeVirtualNetworks", "[AzureNativeVirtualNetwork]"},
                { "allAzureNativeResourceGroupsInfoIfExist", "[AzureResourceGroupInfo]"},
                { "allResourceGroupsFromAzure", "[AzureResourceGroup]"},
                { "allAzureSqlDatabaseServerElasticPools", "[AzureSqlDatabaseServerElasticPool]"},
                { "allAzureCloudAccountMissingPermissions", "[AzureSubscriptionMissingPermissions]"},
                { "allAzureSubscriptionWithExocomputeMappings", "[AzureSubscriptionWithExocomputeMapping]"},
                { "allAzureCloudAccountSubscriptionsByFeature", "[AzureSubscriptionWithFeaturesType]"},
                { "allClustersTotpAckStatus", "[Boolean]"},
                { "allCdmGuestCredentials", "[CdmGuestCredential]"},
                { "cdmHierarchySnappablesNew", "[CdmHierarchySnappableNew]"},
                { "allCdmOvaDetails", "[CdmOvaDetail]"},
                { "allSnapshotsClosestToPointInTime", "[ClosestSnapshotSearchResult]"},
                { "allCurrentFeaturePermissionsForCloudAccounts", "[CloudAccountFeaturePermission]"},
                { "allLatestFeaturePermissionsForCloudAccounts", "[CloudAccountFeaturePermission]"},
                { "allAccountsWithExocomputeMappings", "[CloudAccountWithExocomputeMapping]"},
                { "allCloudAccounts", "[CloudAccount]"},
                { "allCloudAccountExocomputeMappings", "[CloudAccountsExocomputeAccountMapping]"},
                { "allCloudDirectSites", "[CloudDirectSite]"},
                { "allClusterReplicationTargets", "[ClusterReplicationTarget]"},
                { "allClusterWebCertsAndIpmis", "[ClusterWebCertAndIpmi]"},
                { "backupAzureAdDirectory", "[CreateOnDemandJobReply]"},
                { "backupM365Mailbox", "[CreateOnDemandJobReply]"},
                { "backupM365Onedrive", "[CreateOnDemandJobReply]"},
                { "backupM365SharepointDrive", "[CreateOnDemandJobReply]"},
                { "backupM365Team", "[CreateOnDemandJobReply]"},
                { "createK8sNamespaceSnapshots", "[CreateOnDemandJobReply]"},
                { "allConnectedClusters", "[DataLocationSupportedCluster]"},
                { "allDbParameterGroupsByRegionFromAws", "[DbParameterGroup]"},
                { "allDhrcActiveRecommendations", "[DhrcActiveRecommendation]"},
                { "allDhrcLatestMetrics", "[DhrcCollectedMetric]"},
                { "allDhrcScores", "[DhrcScore]"},
                { "startDownloadPackageBatchJob", "[DownloadPackageReplyWithUuid]"},
                { "allEventDigests", "[EventDigest]"},
                { "allSharepointSiteExclusions", "[FullSpSiteExclusions]"},
                { "allGcpCloudAccountMissingPermissionsForAddition", "[GcpCloudAccountMissingPermissionsForAddition]"},
                { "allGcpCloudAccountProjectsByFeature", "[GcpCloudAccountProjectDetail]"},
                { "allGcpCloudAccountProjectsForOauth", "[GcpCloudAccountProjectForOauth]"},
                { "allGcpNativeAvailableKmsCryptoKeys", "[GcpNativeKmsCryptoKey]"},
                { "allGcpNativeNetworks", "[GcpNativeNetwork]"},
                { "allGcpNativeRegions", "[GcpNativeRegion]"},
                { "allFeaturePermissionsForGcpCloudAccount", "[GcpPermission]"},
                { "clusterTypeList", "[GroupCount]"},
                { "downloadedVersionList", "[GroupCount]"},
                { "geoLocationList", "[GroupCount]"},
                { "getGroupCountByPrechecksStatus", "[GroupCount]"},
                { "getGroupCountByUpgradeJobStatus", "[GroupCount]"},
                { "getGroupCountByVersionStatus", "[GroupCount]"},
                { "userGroups", "[Group]"},
                { "hierarchyObjects", "[HierarchyObject]"},
                { "slaConflictObjects", "[HierarchyObject]"},
                { "allCurrentOrgIdentityProviders", "[IdentityProvider]"},
                { "installedVersionList", "[InstalledVersionGroupCount]"},
                { "allInventoryWorkloads", "[InventoryCard]"},
                { "allKmsEncryptionKeysByRegionFromAws", "[KmsEncryptionKey]"},
                { "allUnmanagedObjectsSupportedTypes", "[ManagedObjectType]"},
                { "allNosqlStorageLocations", "[MosaicStorageLocation]"},
                { "allNcdObjectsOverTimeData", "[NcdObjectsOverTimeData]"},
                { "allNcdSlaComplianceData", "[NcdSlaComplianceData]"},
                { "allNcdTaskData", "[NcdTaskData]"},
                { "allNcdUsageOverTimeData", "[NcdUsageOverTimeData]"},
                { "allGcpNativeProjectsWithAccessibleNetworks", "[NetworkHostProject]"},
                { "allO365OrgStatuses", "[O365OrgInfo]"},
                { "allO365SubscriptionsAppTypeCounts", "[O365SubscriptionAppTypeCounts]"},
                { "allObjectsAlreadyAssignedToOrgs", "[ObjectIdsForHierarchyType]"},
                { "allAllowedOrgAdminOperations", "[Operation]"},
                { "allAuthorizationsForGlobalResource", "[Operation]"},
                { "allAuthorizationsForObject", "[Operation]"},
                { "allOptionGroupsByRegionFromAws", "[OptionGroup]"},
                { "allOrgsByIds", "[Org]"},
                { "allAwsPermissionPolicies", "[PermissionPolicy]"},
                { "getPermissions", "[Permission]"},
                { "allTopRiskPolicySummaries", "[PolicySummary]"},
                { "allSnapshotPvcs", "[PvcInformation]"},
                { "allQuarantinedDetailsForSnapshots", "[QuarantineSpec]"},
                { "allQuarantinedDetailsForWorkload", "[QuarantineSpec]"},
                { "allEffectiveRbacPermissions", "[RbacPermission]"},
                { "allK8sReplicaSnapshotInfos", "[ReplicatedSnapshotInfo]"},
                { "getRolesByIds", "[Role]"},
                { "allS3BucketsDetailsFromAws", "[S3BucketDetails]"},
                { "allCloudDirectShares", "[ShareExportIdPair]"},
                { "assignSlasForSnappableHierarchies", "[SlaAssignResult]"},
                { "slaAuditDetail", "[SlaAuditDetail]"},
                { "allSlaSummariesByIds", "[SlaDomain]"},
                { "allClusterGlobalSlas", "[SlaInfo]"},
                { "allAvailabilityZonesByRegionFromAws", "[String]"},
                { "allAwsInstanceProfileNames", "[String]"},
                { "allAzureNativeVirtualMachineSizes", "[String]"},
                { "allAzureNsgs", "[String]"},
                { "allAzureResourceGroups", "[String]"},
                { "allAzureStorageAccounts", "[String]"},
                { "allAzureSubnets", "[String]"},
                { "allAzureVnets", "[String]"},
                { "allCloudNativeFileRecoveryEligibleSnapshots", "[String]"},
                { "allCloudNativeLabelKeys", "[String]"},
                { "allCloudNativeLabelValues", "[String]"},
                { "allCloudNativeTagKeys", "[String]"},
                { "allCloudNativeTagValues", "[String]"},
                { "allDeploymentIpAddresses", "[String]"},
                { "allEc2KeyPairsByRegionFromAws", "[String]"},
                { "allGcpNativeCompatibleMachineTypes", "[String]"},
                { "allGcpNativeStoredMachineTypes", "[String]"},
                { "allGcpNativeStoredMachineTypesInProject", "[String]"},
                { "allGcpNativeStoredNetworkNames", "[String]"},
                { "allGcpNativeStoredNetworkNamesInProject", "[String]"},
                { "allGcpNativeStoredRegions", "[String]"},
                { "allGcpNativeStoredRegionsInProject", "[String]"},
                { "allIssuesJobIds", "[String]"},
                { "allS3BucketsFromAws", "[String]"},
                { "allSupportedAwsRdsDatabaseInstanceClasses", "[String]"},
                { "deactivatePolicy", "[String]"},
                { "removePolicyObjects", "[String]"},
                { "allDbSubnetGroupsByRegionFromAws", "[SubnetGroup]"},
                { "allTargetMappings", "[TargetMapping]"},
                { "allTargets", "[Target]"},
                { "createRcvLocationsFromTemplate", "[Target]"},
                { "scheduleUpgradeBatchJob", "[UpgradeJobReplyWithUuid]"},
                { "startUpgradeBatchJob", "[UpgradeJobReplyWithUuid]"},
                { "getUserDownloads", "[UserDownload]"},
                { "allAccountOwners", "[User]"},
                { "allUsersOnAccount", "[User]"},
                { "allVcenterHotAddProxyVms", "[VcenterHotAddProxyVmInfo]"},
                { "allVmRecoveryJobsInfo", "[VmRecoveryJobInfo]"},
                { "allVmwareCdpStateInfos", "[VmwareCdpStateInfo]"},
                { "vSphereHostsByFids", "[VsphereHost]"},
                { "allPendingActions", "[pendingAction]"},
                { "pendingAction", "pendingAction"},
            };
            if (lookupDict.TryGetValue(rootFieldName, out var returnTypeName))
            {
                return returnTypeName;
            }
            return "";
        }

        /// <summary>
        /// Given a RSC operation, fill in the missing fields
        /// (if possible) and return whether the operation is fully determined.
        /// </summary>
        public static bool FillInRscOp(
            RscOp rscOp
        )
        {
            if (rscOp == null)
            {
                return false;
            }

            if ( !string.IsNullOrEmpty(rscOp.GqlRootFieldName)) {
                var _rscop = RscOpLookupByGqlRootField(rscOp.GqlRootFieldName);
                if(_rscop.IsDetermined()) {
                    rscOp.CmdletName = _rscop.CmdletName;
                    rscOp.CmdletSwitchName = _rscop.CmdletSwitchName;
                    rscOp.GqlReturnTypeName = _rscop.GqlReturnTypeName;
                    return true ;
                }
            }
            
            if ( !string.IsNullOrEmpty(rscOp.CmdletName) &&
                 !string.IsNullOrEmpty(rscOp.CmdletSwitchName) ) {
                GqlRootFieldName rf = GqlRootFieldNameLookupByRscOp(rscOp);
                if ( rf != GqlRootFieldName.Unknown ) {
                    rscOp.GqlRootFieldName = rf.ToString();
                    var rt = ReturnTypeLookupByGqlRootField(rscOp.GqlRootFieldName);
                    if ( !string.IsNullOrEmpty(rt) ) {
                        rscOp.GqlReturnTypeName = rt;
                    }
                }
                if (rscOp.IsDetermined()) 
                {
                    return true;
                }
            }

            if ( !string.IsNullOrEmpty(rscOp.CmdletName) &&
                 !string.IsNullOrEmpty(rscOp.GqlReturnTypeName) ) {
                List<string> rootFields = GqlRootFieldLookupByReturnType(rscOp.GqlReturnTypeName);
                foreach (string rootField in rootFields) {
                    var _rscop = RscOpLookupByGqlRootField(rootField);
                    if ( _rscop.IsDetermined() && _rscop.CmdletName == rscOp.CmdletName ) {
                        rscOp.CmdletSwitchName = _rscop.CmdletSwitchName;
                        rscOp.GqlRootFieldName = _rscop.GqlRootFieldName;
                        return true;
                    }
                }
            }

            if ( !string.IsNullOrEmpty(rscOp.CmdletSwitchName) &&
                 !string.IsNullOrEmpty(rscOp.GqlReturnTypeName) ) {
                List<string> rootFields = GqlRootFieldLookupByReturnType(rscOp.GqlReturnTypeName);
                foreach (string rootField in rootFields) {
                    var _rscop = RscOpLookupByGqlRootField(rootField);
                    if ( _rscop.IsDetermined() && _rscop.CmdletSwitchName == rscOp.CmdletSwitchName ) {
                        rscOp.CmdletName = _rscop.CmdletName;
                        rscOp.GqlRootFieldName = _rscop.GqlRootFieldName;
                        return true;
                    }
                }
            }

            return rscOp.IsDetermined();
        }

        /// <summary>
        /// All API domain names.
        /// </summary>
        public enum ApiDomainName
        {
            Unknown,
            Account,
            ActivitySeries,
            Aws,
            Azure,
            AzureO365,
            Cassandra,
            Cluster,
            Db2,
            Hyperv,
            Ldap,
            ManagedVolume,
            Mongo,
            Mssql,
            Nutanix,
            O365,
            Oracle,
            Sla,
            Vcenter,
            Vsphere,
            VsphereVm,
        }


    }
}