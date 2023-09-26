// New-RscMutationMongo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 12
    /// operations in the 'Mongo' API domain:
    /// AddSource, AssignSlaToDbCollection, BulkDeletedbSources, CreatedbSource, DeleteSource, DeletedbSource, DiscoverSource, PatchSource, RecoverSource, RecoverdbSource, RetryAddSource, or UpdatedbSource.
    /// </summary>
    /// <description>
    /// New-RscMutationMongo creates a new
    /// mutation object for operations
    /// in the 'Mongo' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 12 operations
    /// in the 'Mongo' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AddSource, -AssignSlaToDbCollection, -BulkDeletedbSources, -CreatedbSource, -DeleteSource, -DeletedbSource, -DiscoverSource, -PatchSource, -RecoverSource, -RecoverdbSource, -RetryAddSource, -UpdatedbSource.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AddSource,
    /// which is equivalent to specifying -AddSource.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMongo -AddSource).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMongo -AddSource).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: AddSource
    /// 
    /// $query = New-RscMutationMongo -AddSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	mongoSourceAddRequestConfig = @{
    /// 		# OPTIONAL
    /// 		caCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertfilePath = $someString
    /// 		# REQUIRED
    /// 		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
    /// 		# REQUIRED
    /// 		mongoClientHosts = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				configurationPort = $someInt
    /// 				# REQUIRED
    /// 				hostId = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddMongoSourceReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AssignSlaToDbCollection operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: AssignSlaToDbCollection
    /// 
    /// $query = New-RscMutationMongo -AssignSlaToDbCollection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	input = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		slaId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkDeletedbSources operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: BulkDeletedbSources
    /// 
    /// $query = New-RscMutationMongo -BulkDeletedbSources
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sourceType = $someV2BulkDeleteMosaicSourcesRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceData = @{
    /// 		# OPTIONAL
    /// 		async = $someBoolean
    /// 		# REQUIRED
    /// 		sourceNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreatedbSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: CreatedbSource
    /// 
    /// $query = New-RscMutationMongo -CreatedbSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceData = @{
    /// 		# OPTIONAL
    /// 		async = $someBoolean
    /// 		# OPTIONAL
    /// 		cassandraYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dseYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		enableSsl = $someBoolean
    /// 		# OPTIONAL
    /// 		httpsCertificate = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		jmxPassword = $someString
    /// 		# OPTIONAL
    /// 		jmxUser = $someString
    /// 		# OPTIONAL
    /// 		parameterEncoded = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceAuthKey = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthKeyfile = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthPassphrase = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sourceHttpsPort = $someString
    /// 		# OPTIONAL
    /// 		sourcePassword = $someString
    /// 		# OPTIONAL
    /// 		sourcePort = $someString
    /// 		# OPTIONAL
    /// 		sourceRpcPort = $someString
    /// 		# OPTIONAL
    /// 		sourceSshPort = $someString
    /// 		# OPTIONAL
    /// 		sourceUser = $someString
    /// 		# OPTIONAL
    /// 		sslCaCerts = $someString
    /// 		# OPTIONAL
    /// 		sslCertfile = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfile = $someString
    /// 		# REQUIRED
    /// 		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
    /// 		# REQUIRED
    /// 		sourceIp = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: DeleteSource
    /// 
    /// $query = New-RscMutationMongo -DeleteSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeletedbSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: DeletedbSource
    /// 
    /// $query = New-RscMutationMongo -DeletedbSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sourceType = $someV2DeleteMosaicSourceRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DiscoverSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: DiscoverSource
    /// 
    /// $query = New-RscMutationMongo -DiscoverSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PatchSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: PatchSource
    /// 
    /// $query = New-RscMutationMongo -PatchSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	mongoSourcePatchRequestConfig = @{
    /// 		# OPTIONAL
    /// 		caCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: RecoverSource
    /// 
    /// $query = New-RscMutationMongo -RecoverSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	input = @{
    /// 		# OPTIONAL
    /// 		prefix = $someString
    /// 		# OPTIONAL
    /// 		restoreDbPassword = $someString
    /// 		# OPTIONAL
    /// 		restoreDbUsername = $someString
    /// 		# OPTIONAL
    /// 		shouldDropExistingCollection = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceCollectionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDatabaseIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		targetCollectionName = $someString
    /// 		# OPTIONAL
    /// 		targetDatabaseName = $someString
    /// 		# OPTIONAL
    /// 		versionTime = $someDateTime
    /// 		# OPTIONAL
    /// 		restoreThrottleInBytesPerSecond = $someInt64
    /// 		# OPTIONAL
    /// 		isRestoreWithIndex = $someBoolean
    /// 		# REQUIRED
    /// 		sourceMongoClusterId = $someString
    /// 		# REQUIRED
    /// 		targetMongoClusterId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverdbSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: RecoverdbSource
    /// 
    /// $query = New-RscMutationMongo -RecoverdbSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	recoveryData = @{
    /// 		# OPTIONAL
    /// 		destinationManagementObjects = @{
    /// 			# OPTIONAL
    /// 			databases = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					dbName = $someString
    /// 					# OPTIONAL
    /// 					tables = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		destinationSourceName = $someString
    /// 		# OPTIONAL
    /// 		keyspaceConfig = $someString
    /// 		# OPTIONAL
    /// 		maxDiskUsage = $someString
    /// 		# OPTIONAL
    /// 		restoreDbUserPwd = $someString
    /// 		# OPTIONAL
    /// 		restoreDbUsername = $someString
    /// 		# OPTIONAL
    /// 		startTimestamp = $someInt
    /// 		# OPTIONAL
    /// 		targetEncryptionKey = $someString
    /// 		# OPTIONAL
    /// 		targetQuery = $someString
    /// 		# OPTIONAL
    /// 		sourceType = $someMosaicRetrieveRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
    /// 		# REQUIRED
    /// 		destinationPath = $someString
    /// 		# REQUIRED
    /// 		managementObjects = @{
    /// 			# OPTIONAL
    /// 			databases = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					dbName = $someString
    /// 					# OPTIONAL
    /// 					tables = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		parameterEncoded = $someBoolean
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 		# REQUIRED
    /// 		versionTime = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RetryAddSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: RetryAddSource
    /// 
    /// $query = New-RscMutationMongo -RetryAddSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	mongoSourceRequestConfig = @{
    /// 		# OPTIONAL
    /// 		caCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertfilePath = $someString
    /// 		# REQUIRED
    /// 		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
    /// 		# REQUIRED
    /// 		mongoClientHosts = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				configurationPort = $someInt
    /// 				# REQUIRED
    /// 				hostId = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdatedbSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: UpdatedbSource
    /// 
    /// $query = New-RscMutationMongo -UpdatedbSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceData = @{
    /// 		# OPTIONAL
    /// 		async = $someBoolean
    /// 		# OPTIONAL
    /// 		cassandraYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dseYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		enableSsl = $someBoolean
    /// 		# OPTIONAL
    /// 		httpsCertificate = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		jmxPassword = $someString
    /// 		# OPTIONAL
    /// 		jmxUser = $someString
    /// 		# OPTIONAL
    /// 		parameterEncoded = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceAuthKey = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthKeyfile = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthPassphrase = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sourceHttpsPort = $someString
    /// 		# OPTIONAL
    /// 		sourcePassword = $someString
    /// 		# OPTIONAL
    /// 		sourcePort = $someString
    /// 		# OPTIONAL
    /// 		sourceRpcPort = $someString
    /// 		# OPTIONAL
    /// 		sourceSshPort = $someString
    /// 		# OPTIONAL
    /// 		sourceUser = $someString
    /// 		# OPTIONAL
    /// 		sslCaCerts = $someString
    /// 		# OPTIONAL
    /// 		sslCertfile = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfile = $someString
    /// 		# REQUIRED
    /// 		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
    /// 		# REQUIRED
    /// 		sourceIp = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationMongo",
        DefaultParameterSetName = "AddSource")
    ]
    public class New_RscMutationMongo : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AddSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddSource' operation
in the 'Mongo' API domain.
Description of the operation:
Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addmongosource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddSource { get; set; }

        
        [Parameter(
            ParameterSetName = "AssignSlaToDbCollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AssignSlaToDbCollection' operation
in the 'Mongo' API domain.
Description of the operation:
Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/assignslatomongodbcollection.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AssignSlaToDbCollection { get; set; }

        
        [Parameter(
            ParameterSetName = "BulkDeletedbSources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BulkDeletedbSources' operation
in the 'Mongo' API domain.
Description of the operation:
Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/bulkdeletemongodbsources.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BulkDeletedbSources { get; set; }

        
        [Parameter(
            ParameterSetName = "CreatedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreatedbSource' operation
in the 'Mongo' API domain.
Description of the operation:
Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createmongodbsource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreatedbSource { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteSource' operation
in the 'Mongo' API domain.
Description of the operation:
Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemongosource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteSource { get; set; }

        
        [Parameter(
            ParameterSetName = "DeletedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeletedbSource' operation
in the 'Mongo' API domain.
Description of the operation:
Remove a registered MongoDB source from NoSQL cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deletemongodbsource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeletedbSource { get; set; }

        
        [Parameter(
            ParameterSetName = "DiscoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DiscoverSource' operation
in the 'Mongo' API domain.
Description of the operation:
Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/discovermongosource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DiscoverSource { get; set; }

        
        [Parameter(
            ParameterSetName = "PatchSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'PatchSource' operation
in the 'Mongo' API domain.
Description of the operation:
Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/patchmongosource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter PatchSource { get; set; }

        
        [Parameter(
            ParameterSetName = "RecoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RecoverSource' operation
in the 'Mongo' API domain.
Description of the operation:
Recover a MongoDB source from Rubrik CDM cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/recovermongosource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RecoverSource { get; set; }

        
        [Parameter(
            ParameterSetName = "RecoverdbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RecoverdbSource' operation
in the 'Mongo' API domain.
Description of the operation:
Recover a MongoDB source from NoSQL cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/recovermongodbsource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RecoverdbSource { get; set; }

        
        [Parameter(
            ParameterSetName = "RetryAddSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RetryAddSource' operation
in the 'Mongo' API domain.
Description of the operation:
Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/retryaddmongosource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RetryAddSource { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdatedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdatedbSource' operation
in the 'Mongo' API domain.
Description of the operation:
Modifies configuration for a registered MongoDB source in NoSQL cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatemongodbsource.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdatedbSource { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddSource":
                        this.ProcessRecord_AddSource();
                        break;
                    case "AssignSlaToDbCollection":
                        this.ProcessRecord_AssignSlaToDbCollection();
                        break;
                    case "BulkDeletedbSources":
                        this.ProcessRecord_BulkDeletedbSources();
                        break;
                    case "CreatedbSource":
                        this.ProcessRecord_CreatedbSource();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "DeletedbSource":
                        this.ProcessRecord_DeletedbSource();
                        break;
                    case "DiscoverSource":
                        this.ProcessRecord_DiscoverSource();
                        break;
                    case "PatchSource":
                        this.ProcessRecord_PatchSource();
                        break;
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "RecoverdbSource":
                        this.ProcessRecord_RecoverdbSource();
                        break;
                    case "RetryAddSource":
                        this.ProcessRecord_RetryAddSource();
                        break;
                    case "UpdatedbSource":
                        this.ProcessRecord_UpdatedbSource();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // addMongoSource.
        internal void ProcessRecord_AddSource()
        {
            this._logger.name += " -AddSource";
            // Create new graphql operation addMongoSource
            InitMutationAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlaToMongoDbCollection.
        internal void ProcessRecord_AssignSlaToDbCollection()
        {
            this._logger.name += " -AssignSlaToDbCollection";
            // Create new graphql operation assignSlaToMongoDbCollection
            InitMutationAssignSlaToMongoDbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        internal void ProcessRecord_BulkDeletedbSources()
        {
            this._logger.name += " -BulkDeletedbSources";
            // Create new graphql operation bulkDeleteMongodbSources
            InitMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // createMongodbSource.
        internal void ProcessRecord_CreatedbSource()
        {
            this._logger.name += " -CreatedbSource";
            // Create new graphql operation createMongodbSource
            InitMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongoSource.
        internal void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Create new graphql operation deleteMongoSource
            InitMutationDeleteMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        internal void ProcessRecord_DeletedbSource()
        {
            this._logger.name += " -DeletedbSource";
            // Create new graphql operation deleteMongodbSource
            InitMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // discoverMongoSource.
        internal void ProcessRecord_DiscoverSource()
        {
            this._logger.name += " -DiscoverSource";
            // Create new graphql operation discoverMongoSource
            InitMutationDiscoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchMongoSource.
        internal void ProcessRecord_PatchSource()
        {
            this._logger.name += " -PatchSource";
            // Create new graphql operation patchMongoSource
            InitMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongoSource.
        internal void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Create new graphql operation recoverMongoSource
            InitMutationRecoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        internal void ProcessRecord_RecoverdbSource()
        {
            this._logger.name += " -RecoverdbSource";
            // Create new graphql operation recoverMongodbSource
            InitMutationRecoverMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        internal void ProcessRecord_RetryAddSource()
        {
            this._logger.name += " -RetryAddSource";
            // Create new graphql operation retryAddMongoSource
            InitMutationRetryAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        internal void ProcessRecord_UpdatedbSource()
        {
            this._logger.name += " -UpdatedbSource";
            // Create new graphql operation updateMongodbSource
            InitMutationUpdateMongodbSource();
        }


        // Create new GraphQL Mutation:
        // addMongoSource(input: AddMongoSourceInput!): AddMongoSourceReply!
        internal void InitMutationAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddMongoSource",
                "($input: AddMongoSourceInput!)",
                "AddMongoSourceReply",
                Mutation.AddMongoSource_ObjectFieldSpec,
                Mutation.AddMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	mongoSourceAddRequestConfig = @{
		# OPTIONAL
		caCertfilePath = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sslKeyfilePath = $someString
		# OPTIONAL
		sslCertfilePath = $someString
		# REQUIRED
		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = $someInt
				# REQUIRED
				hostId = $someString
			}
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!): AsyncRequestStatus!
        internal void InitMutationAssignSlaToMongoDbCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaToMongoDbCollectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSlaToMongoDbCollection",
                "($input: AssignSlaToMongoDbCollectionInput!)",
                "AsyncRequestStatus",
                Mutation.AssignSlaToMongoDbCollection_ObjectFieldSpec,
                Mutation.AssignSlaToMongoDbCollectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	input = @{
		# REQUIRED
		ids = @(
			$someString
		)
		# REQUIRED
		slaId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        internal void InitMutationBulkDeleteMongodbSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteMongodbSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                "MosaicAsyncResponse",
                Mutation.BulkDeleteMongodbSources_ObjectFieldSpec,
                Mutation.BulkDeleteMongodbSourcesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sourceType = $someV2BulkDeleteMosaicSourcesRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = $someBoolean
		# REQUIRED
		sourceNames = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMongodbSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationCreateMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMongodbSource",
                "($input: AddMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.CreateMongodbSource_ObjectFieldSpec,
                Mutation.CreateMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = $someBoolean
		# OPTIONAL
		cassandraYaml = @(
			$someString
		)
		# OPTIONAL
		dseYaml = @(
			$someString
		)
		# OPTIONAL
		enableSsl = $someBoolean
		# OPTIONAL
		httpsCertificate = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		jmxPassword = $someString
		# OPTIONAL
		jmxUser = $someString
		# OPTIONAL
		parameterEncoded = $someBoolean
		# OPTIONAL
		sourceAuthKey = $someString
		# OPTIONAL
		sourceAuthKeyfile = $someString
		# OPTIONAL
		sourceAuthPassphrase = $someString
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sourceHttpsPort = $someString
		# OPTIONAL
		sourcePassword = $someString
		# OPTIONAL
		sourcePort = $someString
		# OPTIONAL
		sourceRpcPort = $someString
		# OPTIONAL
		sourceSshPort = $someString
		# OPTIONAL
		sourceUser = $someString
		# OPTIONAL
		sslCaCerts = $someString
		# OPTIONAL
		sslCertfile = $someString
		# OPTIONAL
		sslKeyfile = $someString
		# REQUIRED
		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			$someString
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMongoSource(input: DeleteMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationDeleteMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMongoSource",
                "($input: DeleteMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteMongoSource_ObjectFieldSpec,
                Mutation.DeleteMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMongodbSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationDeleteMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMongodbSource",
                "($input: DeleteMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.DeleteMongodbSource_ObjectFieldSpec,
                Mutation.DeleteMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sourceType = $someV2DeleteMosaicSourceRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // discoverMongoSource(input: DiscoverMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationDiscoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDiscoverMongoSource",
                "($input: DiscoverMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.DiscoverMongoSource_ObjectFieldSpec,
                Mutation.DiscoverMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchMongoSource(input: PatchMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationPatchMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchMongoSource",
                "($input: PatchMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.PatchMongoSource_ObjectFieldSpec,
                Mutation.PatchMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	mongoSourcePatchRequestConfig = @{
		# OPTIONAL
		caCertfilePath = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sslKeyfilePath = $someString
		# OPTIONAL
		sslCertfilePath = $someString
		# OPTIONAL
		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverMongoSource(input: RecoverMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationRecoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverMongoSource",
                "($input: RecoverMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverMongoSource_ObjectFieldSpec,
                Mutation.RecoverMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	input = @{
		# OPTIONAL
		prefix = $someString
		# OPTIONAL
		restoreDbPassword = $someString
		# OPTIONAL
		restoreDbUsername = $someString
		# OPTIONAL
		shouldDropExistingCollection = $someBoolean
		# OPTIONAL
		sourceCollectionIds = @(
			$someString
		)
		# OPTIONAL
		sourceDatabaseIds = @(
			$someString
		)
		# OPTIONAL
		targetCollectionName = $someString
		# OPTIONAL
		targetDatabaseName = $someString
		# OPTIONAL
		versionTime = $someDateTime
		# OPTIONAL
		restoreThrottleInBytesPerSecond = $someInt64
		# OPTIONAL
		isRestoreWithIndex = $someBoolean
		# REQUIRED
		sourceMongoClusterId = $someString
		# REQUIRED
		targetMongoClusterId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverMongodbSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        internal void InitMutationRecoverMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicRestoreDataInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverMongodbSource",
                "($input: MosaicRestoreDataInput!)",
                "MosaicAsyncResponse",
                Mutation.RecoverMongodbSource_ObjectFieldSpec,
                Mutation.RecoverMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	recoveryData = @{
		# OPTIONAL
		destinationManagementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = $someString
					# OPTIONAL
					tables = @(
						$someString
					)
				}
			)
		}
		# OPTIONAL
		destinationSourceName = $someString
		# OPTIONAL
		keyspaceConfig = $someString
		# OPTIONAL
		maxDiskUsage = $someString
		# OPTIONAL
		restoreDbUserPwd = $someString
		# OPTIONAL
		restoreDbUsername = $someString
		# OPTIONAL
		startTimestamp = $someInt
		# OPTIONAL
		targetEncryptionKey = $someString
		# OPTIONAL
		targetQuery = $someString
		# OPTIONAL
		sourceType = $someMosaicRetrieveRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
		# REQUIRED
		destinationPath = $someString
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = $someString
					# OPTIONAL
					tables = @(
						$someString
					)
				}
			)
		}
		# REQUIRED
		parameterEncoded = $someBoolean
		# REQUIRED
		sourceName = $someString
		# REQUIRED
		versionTime = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // retryAddMongoSource(input: RetryAddMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationRetryAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RetryAddMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRetryAddMongoSource",
                "($input: RetryAddMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.RetryAddMongoSource_ObjectFieldSpec,
                Mutation.RetryAddMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	mongoSourceRequestConfig = @{
		# OPTIONAL
		caCertfilePath = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sslKeyfilePath = $someString
		# OPTIONAL
		sslCertfilePath = $someString
		# REQUIRED
		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = $someInt
				# REQUIRED
				hostId = $someString
			}
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMongodbSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationUpdateMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMongodbSource",
                "($input: ModifyMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.UpdateMongodbSource_ObjectFieldSpec,
                Mutation.UpdateMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = $someBoolean
		# OPTIONAL
		cassandraYaml = @(
			$someString
		)
		# OPTIONAL
		dseYaml = @(
			$someString
		)
		# OPTIONAL
		enableSsl = $someBoolean
		# OPTIONAL
		httpsCertificate = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		jmxPassword = $someString
		# OPTIONAL
		jmxUser = $someString
		# OPTIONAL
		parameterEncoded = $someBoolean
		# OPTIONAL
		sourceAuthKey = $someString
		# OPTIONAL
		sourceAuthKeyfile = $someString
		# OPTIONAL
		sourceAuthPassphrase = $someString
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sourceHttpsPort = $someString
		# OPTIONAL
		sourcePassword = $someString
		# OPTIONAL
		sourcePort = $someString
		# OPTIONAL
		sourceRpcPort = $someString
		# OPTIONAL
		sourceSshPort = $someString
		# OPTIONAL
		sourceUser = $someString
		# OPTIONAL
		sslCaCerts = $someString
		# OPTIONAL
		sslCertfile = $someString
		# OPTIONAL
		sslKeyfile = $someString
		# REQUIRED
		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			$someString
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }


    } // class New_RscMutationMongo
}