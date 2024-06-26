### CassandraKeyspace
Cassandra Keyspace information.

- clusterUuid: System.String
  - UUID of the Mosaic cluster.
- backupCount: System.Int32
  - The backup count.
- watcherEnabled: System.Boolean
  - Watcher status of the keyspace.
- backupParams: CassandraBackupParams
  - Backup Params of the source.
- isRelic: System.Boolean
  - Is the keyspace a relic.
- descendantConnection: CassandraKeyspaceDescendantTypeConnection
  - List of descendants.
- physicalChildConnection: CassandraKeyspacePhysicalChildTypeConnection
  - List of physical children.
- source: CassandraSource
  - Parent source connection.
- cluster: Cluster
  - Mosaic cluster information.
- id: System.String
  - The FID of the hierarchy object.
- name: System.String
  - The name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - A sequential list of this object's logical ancestors.
- physicalPath: list of PathNodes
  - A sequential list of this object's physical ancestors.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- allOrgs: list of Orgs
  - The organizations to which this hierarchy object belongs.
