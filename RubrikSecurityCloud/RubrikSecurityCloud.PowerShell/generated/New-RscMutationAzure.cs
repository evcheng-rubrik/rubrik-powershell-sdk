// New-RscMutationAzure.cs
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
    /// Create a new RscQuery object for any of the 51
    /// operations in the 'Azure' API domain:
    /// AddCloudAccount, AddCloudAccountExocomputeConfigurations, AddCloudAccountWithoutOauth, BackupAdDirectory, CompleteAdAppSetup, CompleteAdAppUpdate, CompleteCloudAccountOauth, CreateAccount, CreateAutomaticTargetMapping, CreateCloudNativeRcvStorageSetting, CreateCloudNativeStorageSetting, CreateCluster, CreateReaderTarget, CreateSaasAppAad, CreateTarget, DeleteAdDirectory, DeleteCloudAccount, DeleteCloudAccountExocomputeConfigurations, DeleteCloudAccountWithoutOauth, DeleteCluster, ExcludeNativeManagedDisksFromSnapshot, MapCloudAccountExocomputeSubscription, MapCloudAccountToPersistentStorageLocation, OauthConsentComplete, OauthConsentKickoff, RestoreAdObjectsWithPasswords, SetCloudAccountCustomerAppCredentials, StartAdAppSetup, StartAdAppUpdate, StartCloudAccountOauth, StartCreateNativeManagedDiskSnapshotsJob, StartCreateNativeVirtualMachineSnapshotsJob, StartDisableCloudAccountJob, StartDisableNativeSubscriptionProtectionJob, StartExportNativeManagedDiskJob, StartExportNativeVirtualMachineJob, StartExportSqlDatabaseDbJob, StartExportSqlManagedInstanceDbJob, StartRefreshNativeSubscriptionsJob, StartRestoreNativeVirtualMachineJob, UnmapCloudAccountExocomputeSubscription, UnmapPersistentStorageSubscription, UpdateAccount, UpdateAutomaticTargetMapping, UpdateCloudAccount, UpdateCloudNativeRcvStorageSetting, UpdateCloudNativeStorageSetting, UpdateCustomerAppPermissionForSql, UpdateTarget, UpgradeCloudAccount, or UpgradeCloudAccountPermissionsWithoutOauth.
    /// </summary>
    /// <description>
    /// New-RscMutationAzure creates a new
    /// mutation object for operations
    /// in the 'Azure' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 51 operations
    /// in the 'Azure' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -AddCloudAccount, -AddCloudAccountExocomputeConfigurations, -AddCloudAccountWithoutOauth, -BackupAdDirectory, -CompleteAdAppSetup, -CompleteAdAppUpdate, -CompleteCloudAccountOauth, -CreateAccount, -CreateAutomaticTargetMapping, -CreateCloudNativeRcvStorageSetting, -CreateCloudNativeStorageSetting, -CreateCluster, -CreateReaderTarget, -CreateSaasAppAad, -CreateTarget, -DeleteAdDirectory, -DeleteCloudAccount, -DeleteCloudAccountExocomputeConfigurations, -DeleteCloudAccountWithoutOauth, -DeleteCluster, -ExcludeNativeManagedDisksFromSnapshot, -MapCloudAccountExocomputeSubscription, -MapCloudAccountToPersistentStorageLocation, -OauthConsentComplete, -OauthConsentKickoff, -RestoreAdObjectsWithPasswords, -SetCloudAccountCustomerAppCredentials, -StartAdAppSetup, -StartAdAppUpdate, -StartCloudAccountOauth, -StartCreateNativeManagedDiskSnapshotsJob, -StartCreateNativeVirtualMachineSnapshotsJob, -StartDisableCloudAccountJob, -StartDisableNativeSubscriptionProtectionJob, -StartExportNativeManagedDiskJob, -StartExportNativeVirtualMachineJob, -StartExportSqlDatabaseDbJob, -StartExportSqlManagedInstanceDbJob, -StartRefreshNativeSubscriptionsJob, -StartRestoreNativeVirtualMachineJob, -UnmapCloudAccountExocomputeSubscription, -UnmapPersistentStorageSubscription, -UpdateAccount, -UpdateAutomaticTargetMapping, -UpdateCloudAccount, -UpdateCloudNativeRcvStorageSetting, -UpdateCloudNativeStorageSetting, -UpdateCustomerAppPermissionForSql, -UpdateTarget, -UpgradeCloudAccount, -UpgradeCloudAccountPermissionsWithoutOauth.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op AddCloudAccount,
    /// which is equivalent to specifying -AddCloudAccount.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAzure -AddCloudAccount).Info().
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
    /// (New-RscMutationAzure -AddCloudAccount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AddCloudAccount
    /// 
    /// $query = New-RscMutationAzure -AddCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	subscriptions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			features = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					resourceGroup = @{
    /// 						# REQUIRED
    /// 						name = $someString
    /// 						# OPTIONAL
    /// 						tags = @{
    /// 							# REQUIRED
    /// 							tagList = @(
    /// 								@{
    /// 									# REQUIRED
    /// 									key = $someString
    /// 									# REQUIRED
    /// 									value = $someString
    /// 								}
    /// 							)
    /// 						}
    /// 						# REQUIRED
    /// 						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 					}
    /// 					# REQUIRED
    /// 					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 					# OPTIONAL
    /// 					permissionsGroups = @(
    /// 						$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 					)
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			subscription = @{
    /// 				# REQUIRED
    /// 				nativeId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	regions = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddCloudAccountExocomputeConfigurations operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AddCloudAccountExocomputeConfigurations
    /// 
    /// $query = New-RscMutationAzure -AddCloudAccountExocomputeConfigurations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	azureExocomputeRegionConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 			# REQUIRED
    /// 			subnetNativeId = $someString
    /// 			# REQUIRED
    /// 			isRscManaged = $someBoolean
    /// 			# OPTIONAL
    /// 			podSubnetNativeId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	triggerHealthCheck = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAzureCloudAccountExocomputeConfigurationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddCloudAccountWithoutOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: AddCloudAccountWithoutOauth
    /// 
    /// $query = New-RscMutationAzure -AddCloudAccountWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	subscriptions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			features = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					policyVersion = $someInt
    /// 					# OPTIONAL
    /// 					resourceGroup = @{
    /// 						# REQUIRED
    /// 						name = $someString
    /// 						# OPTIONAL
    /// 						tags = @{
    /// 							# REQUIRED
    /// 							tagList = @(
    /// 								@{
    /// 									# REQUIRED
    /// 									key = $someString
    /// 									# REQUIRED
    /// 									value = $someString
    /// 								}
    /// 							)
    /// 						}
    /// 						# REQUIRED
    /// 						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 					}
    /// 					# OPTIONAL
    /// 					specificFeatureInput = @{
    /// 						# REQUIRED
    /// 						userAssignedManagedIdentityInput = @{
    /// 							# REQUIRED
    /// 							name = $someString
    /// 							# REQUIRED
    /// 							resourceGroupName = $someString
    /// 							# REQUIRED
    /// 							principalId = $someString
    /// 							# REQUIRED
    /// 							region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 						}
    /// 					}
    /// 					# REQUIRED
    /// 					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 					# OPTIONAL
    /// 					permissionsGroups = @(
    /// 						$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 					)
    /// 				}
    /// 			)
    /// 			# REQUIRED
    /// 			subscription = @{
    /// 				# REQUIRED
    /// 				nativeId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	regions = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddAzureCloudAccountWithoutOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupAdDirectory operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: BackupAdDirectory
    /// 
    /// $query = New-RscMutationAzure -BackupAdDirectory
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteAdAppSetup operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CompleteAdAppSetup
    /// 
    /// $query = New-RscMutationAzure -CompleteAdAppSetup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# OPTIONAL
    /// 	kmsSpec = @{
    /// 		# OPTIONAL
    /// 		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
    /// 		# OPTIONAL
    /// 		tenantId = $someString
    /// 		# OPTIONAL
    /// 		kmsId = $someString
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecret = $someString
    /// 		# OPTIONAL
    /// 		keyName = $someString
    /// 		# OPTIONAL
    /// 		kekNameColossus = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CompleteAzureAdAppSetupReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteAdAppUpdate operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CompleteAdAppUpdate
    /// 
    /// $query = New-RscMutationAzure -CompleteAdAppUpdate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteCloudAccountOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CompleteCloudAccountOauth
    /// 
    /// $query = New-RscMutationAzure -CompleteCloudAccountOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	authorizationCode = $someString
    /// 	# REQUIRED
    /// 	redirectUrl = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	appId = $someString
    /// 	# OPTIONAL
    /// 	appSecretKey = $someString
    /// 	# REQUIRED
    /// 	shouldSkipPermissionChecks = $someBoolean
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// 	# OPTIONAL
    /// 	resource = $someAzureOauthResource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureOauthResource]) for enum values.
    /// 	# OPTIONAL
    /// 	performBasicOauth = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldKeepRefreshToken = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CompleteAzureCloudAccountOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateAccount
    /// 
    /// $query = New-RscMutationAzure -CreateAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	subscriptionId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateAutomaticTargetMapping operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationAzure -CreateAutomaticTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	containerNamePrefix = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	clusterUuidList = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCloudNativeRcvStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateCloudNativeRcvStorageSetting
    /// 
    /// $query = New-RscMutationAzure -CreateCloudNativeRcvStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 	# REQUIRED
    /// 	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeRcvAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCloudNativeStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateCloudNativeStorageSetting
    /// 
    /// $query = New-RscMutationAzure -CreateCloudNativeStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	containerName = $someString
    /// 	# OPTIONAL
    /// 	storageAccountTags = @{
    /// 		# REQUIRED
    /// 		tagList = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				value = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	storageAccountRegion = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 	# REQUIRED
    /// 	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
    /// 	# REQUIRED
    /// 	redundancy = $someAzureRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
    /// 	# REQUIRED
    /// 	subscriptionNativeId = $someString
    /// 	# REQUIRED
    /// 	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
    /// 	# OPTIONAL
    /// 	cmkInfo = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			keyVaultName = $someString
    /// 			# OPTIONAL
    /// 			keyName = $someString
    /// 			# OPTIONAL
    /// 			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateCloudNativeAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCluster operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateCluster
    /// 
    /// $query = New-RscMutationAzure -CreateCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	isEsType = $someBoolean
    /// 	# OPTIONAL
    /// 	keepClusterOnFailure = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterConfig = @{
    /// 		# OPTIONAL
    /// 		userEmail = $someString
    /// 		# OPTIONAL
    /// 		adminPassword = $someString
    /// 		# OPTIONAL
    /// 		clusterName = $someString
    /// 		# OPTIONAL
    /// 		numNodes = $someInt
    /// 		# OPTIONAL
    /// 		dnsSearchDomains = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dnsNameServers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		ntpServers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		azureEsConfig = @{
    /// 			# OPTIONAL
    /// 			storageAccount = $someString
    /// 			# OPTIONAL
    /// 			resourceGroup = $someString
    /// 			# OPTIONAL
    /// 			storageSecret = $someString
    /// 			# OPTIONAL
    /// 			containerName = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateContainer = $someBoolean
    /// 			# OPTIONAL
    /// 			enableImmutability = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		awsEsConfig = @{
    /// 			# OPTIONAL
    /// 			bucketName = $someString
    /// 			# OPTIONAL
    /// 			shouldCreateBucket = $someBoolean
    /// 			# OPTIONAL
    /// 			enableObjectLock = $someBoolean
    /// 			# OPTIONAL
    /// 			enableImmutability = $someBoolean
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	vmConfig = @{
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		cdmVersion = $someString
    /// 		# OPTIONAL
    /// 		location = $someString
    /// 		# OPTIONAL
    /// 		nodeSizeGb = $someInt
    /// 		# OPTIONAL
    /// 		networkResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnetResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnet = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		vmImage = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateReaderTarget operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateReaderTarget
    /// 
    /// $query = New-RscMutationAzure -CreateReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	containerName = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSaasAppAad operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateSaasAppAad
    /// 
    /// $query = New-RscMutationAzure -CreateSaasAppAad
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateAzureSaasAppAadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateTarget operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: CreateTarget
    /// 
    /// $query = New-RscMutationAzure -CreateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	storageAccountName = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	containerName = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	rsaKey = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteAdDirectory operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteAdDirectory
    /// 
    /// $query = New-RscMutationAzure -DeleteAdDirectory
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCloudAccount
    /// 
    /// $query = New-RscMutationAzure -DeleteCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudAccountExocomputeConfigurations operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCloudAccountExocomputeConfigurations
    /// 
    /// $query = New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAzureCloudAccountExocomputeConfigurationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudAccountWithoutOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCloudAccountWithoutOauth
    /// 
    /// $query = New-RscMutationAzure -DeleteCloudAccountWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteAzureCloudAccountWithoutOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCluster operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: DeleteCluster
    /// 
    /// $query = New-RscMutationAzure -DeleteCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# OPTIONAL
    /// 	numNodes = $someInt
    /// 	# OPTIONAL
    /// 	resourceGroupName = $someString
    /// 	# OPTIONAL
    /// 	networkResourceGroup = $someString
    /// 	# OPTIONAL
    /// 	isEsType = $someBoolean
    /// 	# OPTIONAL
    /// 	storageAccount = $someString
    /// 	# OPTIONAL
    /// 	containerName = $someString
    /// 	# OPTIONAL
    /// 	storageResourceGroup = $someString
    /// 	# OPTIONAL
    /// 	isNewContainer = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExcludeNativeManagedDisksFromSnapshot operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: ExcludeNativeManagedDisksFromSnapshot
    /// 
    /// $query = New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	virtualMachineRubrikId = $someString
    /// 	# REQUIRED
    /// 	managedDiskExclusions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			managedDiskRubrikId = $someString
    /// 			# REQUIRED
    /// 			isExcludedFromSnapshot = $someBoolean
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MapCloudAccountExocomputeSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: MapCloudAccountExocomputeSubscription
    /// 
    /// $query = New-RscMutationAzure -MapCloudAccountExocomputeSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	exocomputeCloudAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MapAzureCloudAccountExocomputeSubscriptionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MapCloudAccountToPersistentStorageLocation operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: MapCloudAccountToPersistentStorageLocation
    /// 
    /// $query = New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	persistentStorageId = $someString
    /// 	# REQUIRED
    /// 	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MapAzureCloudAccountToPersistentStorageLocationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthConsentComplete operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: OauthConsentComplete
    /// 
    /// $query = New-RscMutationAzure -OauthConsentComplete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	tenantId = $someString
    /// 	# REQUIRED
    /// 	code = $someString
    /// 	# REQUIRED
    /// 	stateToken = $someString
    /// 	# REQUIRED
    /// 	redirectUrl = $someString
    /// 	# OPTIONAL
    /// 	azureAppId = $someString
    /// 	# OPTIONAL
    /// 	azureAppSecret = $someString
    /// 	# REQUIRED
    /// 	azureCloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthConsentKickoff operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: OauthConsentKickoff
    /// 
    /// $query = New-RscMutationAzure -OauthConsentKickoff
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AzureOauthConsentKickoffReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreAdObjectsWithPasswords operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: RestoreAdObjectsWithPasswords
    /// 
    /// $query = New-RscMutationAzure -RestoreAdObjectsWithPasswords
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# REQUIRED
    /// 	passwordByUserIdMap = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			userId = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypeToIdMap = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			objectId = $someString
    /// 			# REQUIRED
    /// 			azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	forceChangePasswordWithMfa = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RestoreAzureAdObjectsWithPasswordsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetCloudAccountCustomerAppCredentials operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: SetCloudAccountCustomerAppCredentials
    /// 
    /// $query = New-RscMutationAzure -SetCloudAccountCustomerAppCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	appId = $someString
    /// 	# REQUIRED
    /// 	appSecretKey = $someString
    /// 	# OPTIONAL
    /// 	appTenantId = $someString
    /// 	# OPTIONAL
    /// 	appName = $someString
    /// 	# OPTIONAL
    /// 	tenantDomainName = $someString
    /// 	# REQUIRED
    /// 	shouldReplace = $someBoolean
    /// 	# REQUIRED
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartAdAppSetup operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartAdAppSetup
    /// 
    /// $query = New-RscMutationAzure -StartAdAppSetup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	domainName = $someString
    /// 	# REQUIRED
    /// 	region = $someAzureAdRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	azureAdApp = @{
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartAzureAdAppSetupReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartAdAppUpdate operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartAdAppUpdate
    /// 
    /// $query = New-RscMutationAzure -StartAdAppUpdate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// 	# OPTIONAL
    /// 	azureAdApp = @{
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# OPTIONAL
    /// 		clientSecret = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartAzureAdAppUpdateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCloudAccountOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartCloudAccountOauth
    /// 
    /// $query = New-RscMutationAzure -StartCloudAccountOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	tenantDomainName = $someString
    /// 	# OPTIONAL
    /// 	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartAzureCloudAccountOauthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCreateNativeManagedDiskSnapshotsJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartCreateNativeManagedDiskSnapshotsJob
    /// 
    /// $query = New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	managedDiskRubrikIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCreateNativeVirtualMachineSnapshotsJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartCreateNativeVirtualMachineSnapshotsJob
    /// 
    /// $query = New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	virtualMachineRubrikIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartDisableCloudAccountJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartDisableCloudAccountJob
    /// 
    /// $query = New-RscMutationAzure -StartDisableCloudAccountJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartDisableNativeSubscriptionProtectionJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartDisableNativeSubscriptionProtectionJob
    /// 
    /// $query = New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	shouldDeleteNativeSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportNativeManagedDiskJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartExportNativeManagedDiskJob
    /// 
    /// $query = New-RscMutationAzure -StartExportNativeManagedDiskJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	diskName = $someString
    /// 	# OPTIONAL
    /// 	diskEncryptionSetNativeId = $someString
    /// 	# REQUIRED
    /// 	diskStorageTier = $someAzureNativeManagedDiskType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeManagedDiskType]) for enum values.
    /// 	# REQUIRED
    /// 	diskSize = $someInt
    /// 	# REQUIRED
    /// 	resourceGroup = $someString
    /// 	# REQUIRED
    /// 	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	destinationAvailabilityZone = $someString
    /// 	# OPTIONAL
    /// 	destinationSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# REQUIRED
    /// 	shouldReplaceAttachedManagedDisk = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldUseReplica = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportNativeVirtualMachineJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartExportNativeVirtualMachineJob
    /// 
    /// $query = New-RscMutationAzure -StartExportNativeVirtualMachineJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	virtualMachineName = $someString
    /// 	# OPTIONAL
    /// 	diskEncryptionSetNativeId = $someString
    /// 	# REQUIRED
    /// 	resourceGroupName = $someString
    /// 	# REQUIRED
    /// 	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	destinationAvailabilityZone = $someString
    /// 	# OPTIONAL
    /// 	destinationSubscriptionRubrikId = $someString
    /// 	# REQUIRED
    /// 	virtualMachineSize = $someString
    /// 	# REQUIRED
    /// 	subnetNativeId = $someString
    /// 	# OPTIONAL
    /// 	networkSecurityGroupNativeId = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# REQUIRED
    /// 	shouldPowerOff = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldUseReplica = $someBoolean
    /// 	# OPTIONAL
    /// 	availabilitySetNativeId = $someString
    /// 	# OPTIONAL
    /// 	shouldEnableAcceleratedNetworking = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
    /// 	# OPTIONAL
    /// 	recoveryDiskIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportSqlDatabaseDbJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartExportSqlDatabaseDbJob
    /// 
    /// $query = New-RscMutationAzure -StartExportSqlDatabaseDbJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sourceDatabaseRubrikId = $someString
    /// 	# REQUIRED
    /// 	destinationDatabaseName = $someString
    /// 	# OPTIONAL
    /// 	destinationServerRubrikId = $someString
    /// 	# OPTIONAL
    /// 	elasticPoolName = $someString
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# OPTIONAL
    /// 	azureSqlDatabaseDbPitExportInput = @{
    /// 		# REQUIRED
    /// 		restorePointInTime = $someDateTime
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	azureSqlDatabaseDbLtrExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# REQUIRED
    /// 		destinationResourceGroupName = $someString
    /// 		# REQUIRED
    /// 		destinationServerName = $someString
    /// 		# REQUIRED
    /// 		destinationRegionName = $someString
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	persistentBackupExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# OPTIONAL
    /// 		destinationServerCredentials = @{
    /// 			# REQUIRED
    /// 			login = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
    /// 		# OPTIONAL
    /// 		sessionId = $someString
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	serviceTier = $someString
    /// 	# OPTIONAL
    /// 	serviceObjectiveName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportSqlManagedInstanceDbJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartExportSqlManagedInstanceDbJob
    /// 
    /// $query = New-RscMutationAzure -StartExportSqlManagedInstanceDbJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sourceManagedInstanceDatabaseRubrikId = $someString
    /// 	# OPTIONAL
    /// 	destinationManagedInstanceRubrikId = $someString
    /// 	# REQUIRED
    /// 	destinationDatabaseName = $someString
    /// 	# REQUIRED
    /// 	destinationManagedInstanceName = $someString
    /// 	# REQUIRED
    /// 	destinationResourceGroupName = $someString
    /// 	# OPTIONAL
    /// 	azureSqlManagedInstanceDbPitExportInput = @{
    /// 		# REQUIRED
    /// 		restorePointInTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	azureSqlManagedInstanceDbLtrExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# REQUIRED
    /// 		destinationRegionName = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	persistentBackupExportInput = @{
    /// 		# REQUIRED
    /// 		sourceSnapshotRubrikId = $someString
    /// 		# OPTIONAL
    /// 		destinationServerCredentials = @{
    /// 			# REQUIRED
    /// 			login = $someString
    /// 			# REQUIRED
    /// 			password = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
    /// 		# OPTIONAL
    /// 		sessionId = $someString
    /// 		# OPTIONAL
    /// 		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	serviceTier = $someString
    /// 	# OPTIONAL
    /// 	serviceObjectiveName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRefreshNativeSubscriptionsJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartRefreshNativeSubscriptionsJob
    /// 
    /// $query = New-RscMutationAzure -StartRefreshNativeSubscriptionsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRestoreNativeVirtualMachineJob operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: StartRestoreNativeVirtualMachineJob
    /// 
    /// $query = New-RscMutationAzure -StartRestoreNativeVirtualMachineJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	shouldPowerOn = $someBoolean
    /// 	# REQUIRED
    /// 	shouldRestoreTags = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotTypeToUseIfSourceExpired = $someSnapshotTypeForRestoreIfSourceExpired # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeForRestoreIfSourceExpired]) for enum values.
    /// 	# OPTIONAL
    /// 	recoveryDiskIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmapCloudAccountExocomputeSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UnmapCloudAccountExocomputeSubscription
    /// 
    /// $query = New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UnmapAzureCloudAccountExocomputeSubscriptionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmapPersistentStorageSubscription operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UnmapPersistentStorageSubscription
    /// 
    /// $query = New-RscMutationAzure -UnmapPersistentStorageSubscription
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	applicationCloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# REQUIRED
    /// 	unmappingValidationType = $someUnmappingValidationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateAccount
    /// 
    /// $query = New-RscMutationAzure -UpdateAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	subscriptionId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAutomaticTargetMapping operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateAutomaticTargetMapping
    /// 
    /// $query = New-RscMutationAzure -UpdateAutomaticTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	storageAccountName = $someString
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	clusterUuidList = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCloudAccount
    /// 
    /// $query = New-RscMutationAzure -UpdateCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	subscriptions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			name = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	regionsToAdd = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	regionsToRemove = @(
    /// 		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudNativeRcvStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCloudNativeRcvStorageSetting
    /// 
    /// $query = New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeRcvAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCloudNativeStorageSetting operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCloudNativeStorageSetting
    /// 
    /// $query = New-RscMutationAzure -UpdateCloudNativeStorageSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	storageAccountTags = @{
    /// 		# REQUIRED
    /// 		tagList = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				value = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
    /// 	# OPTIONAL
    /// 	cmkInfo = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			keyVaultName = $someString
    /// 			# OPTIONAL
    /// 			keyName = $someString
    /// 			# OPTIONAL
    /// 			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCloudNativeAzureStorageSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustomerAppPermissionForSql operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateCustomerAppPermissionForSql
    /// 
    /// $query = New-RscMutationAzure -UpdateCustomerAppPermissionForSql
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateTarget operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpdateTarget
    /// 
    /// $query = New-RscMutationAzure -UpdateTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	storageAccountName = $someString
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	computeSettings = @{
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecretKey = $someString
    /// 		# OPTIONAL
    /// 		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
    /// 		# OPTIONAL
    /// 		generalPurposeStorageName = $someString
    /// 		# OPTIONAL
    /// 		generalPurposeStorageContainer = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		virtualNetworkId = $someString
    /// 		# OPTIONAL
    /// 		subnetId = $someString
    /// 		# OPTIONAL
    /// 		securityGroupId = $someString
    /// 		# OPTIONAL
    /// 		computeProxySettings = @{
    /// 			# OPTIONAL
    /// 			proxyServer = $someString
    /// 			# OPTIONAL
    /// 			portNumber = $someInt
    /// 			# OPTIONAL
    /// 			username = $someString
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			protocol = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		cloudAccountId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	proxySettings = @{
    /// 		# OPTIONAL
    /// 		proxyServer = $someString
    /// 		# OPTIONAL
    /// 		portNumber = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		protocol = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		lockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
    /// 	# REQUIRED
    /// 	bypassProxy = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeCloudAccount operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpgradeCloudAccount
    /// 
    /// $query = New-RscMutationAzure -UpgradeCloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	features = @(
    /// 		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	featuresToUpgrade = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 			# REQUIRED
    /// 			permissionsGroups = @(
    /// 				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	azureSubscriptionRubrikIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpgradeAzureCloudAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeCloudAccountPermissionsWithoutOauth operation
    /// of the 'Azure' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Azure
    /// # API Operation: UpgradeCloudAccountPermissionsWithoutOauth
    /// 
    /// $query = New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 	# OPTIONAL
    /// 	featureToUpgrade = @{
    /// 		# REQUIRED
    /// 		featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 		# REQUIRED
    /// 		permissionsGroups = @(
    /// 			$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpgradeAzureCloudAccountPermissionsWithoutOauthReply
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
        "RscMutationAzure",
        DefaultParameterSetName = "CreateTarget")
    ]
    public class New_RscMutationAzure : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "AddCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddCloudAccount' operation
in the 'Azure' API domain.
Description of the operation:
Add the Azure Subscriptions cloud account for the given feature.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addazurecloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "AddCloudAccountExocomputeConfigurations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddCloudAccountExocomputeConfigurations' operation
in the 'Azure' API domain.
Description of the operation:
Add Exocompute configurations for an Azure Cloud Account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addazurecloudaccountexocomputeconfigurations.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddCloudAccountExocomputeConfigurations { get; set; }

        
        [Parameter(
            ParameterSetName = "AddCloudAccountWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'AddCloudAccountWithoutOauth' operation
in the 'Azure' API domain.
Description of the operation:
Add the Azure Subscription cloud account for the given feature without OAuth.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/addazurecloudaccountwithoutoauth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter AddCloudAccountWithoutOauth { get; set; }

        
        [Parameter(
            ParameterSetName = "BackupAdDirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'BackupAdDirectory' operation
in the 'Azure' API domain.
Description of the operation:
Backs up the Azure AD directory.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/backupazureaddirectory.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter BackupAdDirectory { get; set; }

        
        [Parameter(
            ParameterSetName = "CompleteAdAppSetup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CompleteAdAppSetup' operation
in the 'Azure' API domain.
Description of the operation:
Completes the creation flow for an Azure AD app.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/completeazureadappsetup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CompleteAdAppSetup { get; set; }

        
        [Parameter(
            ParameterSetName = "CompleteAdAppUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CompleteAdAppUpdate' operation
in the 'Azure' API domain.
Description of the operation:
Completes an update to the Azure AD directory app.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/completeazureadappupdate.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CompleteAdAppUpdate { get; set; }

        
        [Parameter(
            ParameterSetName = "CompleteCloudAccountOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CompleteCloudAccountOauth' operation
in the 'Azure' API domain.
Description of the operation:
Complete the Azure OAuth flow and pass the authorization code.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/completeazurecloudaccountoauth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CompleteCloudAccountOauth { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateAccount' operation
in the 'Azure' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createazureaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateAutomaticTargetMapping' operation
in the 'Azure' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createautomaticazuretargetmapping.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateAutomaticTargetMapping { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCloudNativeRcvStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCloudNativeRcvStorageSetting' operation
in the 'Azure' API domain.
Description of the operation:
Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createcloudnativercvazurestoragesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCloudNativeRcvStorageSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCloudNativeStorageSetting' operation
in the 'Azure' API domain.
Description of the operation:
Creates Storage Settings for the archival of azure cloud native protected objects
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createcloudnativeazurestoragesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCloudNativeStorageSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateCluster' operation
in the 'Azure' API domain.
Description of the operation:
Create a Rubrik Cloud Cluster on Azure.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createazurecluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateReaderTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateReaderTarget' operation
in the 'Azure' API domain.
Description of the operation:
Creates reader type for Azure archival location on a CDM cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createazurereadertarget.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateReaderTarget { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateSaasAppAad",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateSaasAppAad' operation
in the 'Azure' API domain.
Description of the operation:
Create or get an Azure AAD application.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createazuresaasappaad.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateSaasAppAad { get; set; }

        
        [Parameter(
            ParameterSetName = "CreateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'CreateTarget' operation
in the 'Azure' API domain.
Description of the operation:
Creates an Azure archival target on the Rubrik cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createazuretarget.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter CreateTarget { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteAdDirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteAdDirectory' operation
in the 'Azure' API domain.
Description of the operation:
Deletes an Azure AD directory.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteazureaddirectory.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteAdDirectory { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteCloudAccount' operation
in the 'Azure' API domain.
Description of the operation:
Delete the Azure Subscriptions cloud account for the given feature.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteazurecloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteCloudAccountExocomputeConfigurations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteCloudAccountExocomputeConfigurations' operation
in the 'Azure' API domain.
Description of the operation:
Delete Exocompute configurations for an Azure Cloud Account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteazurecloudaccountexocomputeconfigurations.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteCloudAccountExocomputeConfigurations { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteCloudAccountWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteCloudAccountWithoutOauth' operation
in the 'Azure' API domain.
Description of the operation:
Delete the Azure Subscriptions cloud account for the given feature without OAuth.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteazurecloudaccountwithoutoauth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteCloudAccountWithoutOauth { get; set; }

        
        [Parameter(
            ParameterSetName = "DeleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'DeleteCluster' operation
in the 'Azure' API domain.
Description of the operation:
Delete a Rubrik Cloud Cluster on Azure.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/deleteazurecluster.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter DeleteCluster { get; set; }

        
        [Parameter(
            ParameterSetName = "ExcludeNativeManagedDisksFromSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExcludeNativeManagedDisksFromSnapshot' operation
in the 'Azure' API domain.
Description of the operation:
Exclude the Managed Disks from snapshots, for the specified virtual machines.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/excludeazurenativemanageddisksfromsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExcludeNativeManagedDisksFromSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "MapCloudAccountExocomputeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'MapCloudAccountExocomputeSubscription' operation
in the 'Azure' API domain.
Description of the operation:
Map Azure cloud accounts to an Exocompute subscription.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/mapazurecloudaccountexocomputesubscription.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter MapCloudAccountExocomputeSubscription { get; set; }

        
        [Parameter(
            ParameterSetName = "MapCloudAccountToPersistentStorageLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'MapCloudAccountToPersistentStorageLocation' operation
in the 'Azure' API domain.
Description of the operation:
Map Azure cloud accounts to a persistent storage location.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/mapazurecloudaccounttopersistentstoragelocation.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter MapCloudAccountToPersistentStorageLocation { get; set; }

        
        [Parameter(
            ParameterSetName = "OauthConsentComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'OauthConsentComplete' operation
in the 'Azure' API domain.
Description of the operation:
Completes an OAuth consent flow for Azure resource access.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/azureoauthconsentcomplete.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter OauthConsentComplete { get; set; }

        
        [Parameter(
            ParameterSetName = "OauthConsentKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'OauthConsentKickoff' operation
in the 'Azure' API domain.
Description of the operation:
Kicks off an OAuth consent flow for Azure resource access.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/azureoauthconsentkickoff.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter OauthConsentKickoff { get; set; }

        
        [Parameter(
            ParameterSetName = "RestoreAdObjectsWithPasswords",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'RestoreAdObjectsWithPasswords' operation
in the 'Azure' API domain.
Description of the operation:
Restores the Azure AD directory with multiple passwords.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/restoreazureadobjectswithpasswords.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter RestoreAdObjectsWithPasswords { get; set; }

        
        [Parameter(
            ParameterSetName = "SetCloudAccountCustomerAppCredentials",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'SetCloudAccountCustomerAppCredentials' operation
in the 'Azure' API domain.
Description of the operation:
Set credentials for the customer application, for the tenant domain name.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/setazurecloudaccountcustomerappcredentials.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter SetCloudAccountCustomerAppCredentials { get; set; }

        
        [Parameter(
            ParameterSetName = "StartAdAppSetup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartAdAppSetup' operation
in the 'Azure' API domain.
Description of the operation:
Initiates the Azure AD app creation workflow.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startazureadappsetup.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartAdAppSetup { get; set; }

        
        [Parameter(
            ParameterSetName = "StartAdAppUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartAdAppUpdate' operation
in the 'Azure' API domain.
Description of the operation:
Initiates an update to the Azure AD directory app.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startazureadappupdate.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartAdAppUpdate { get; set; }

        
        [Parameter(
            ParameterSetName = "StartCloudAccountOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartCloudAccountOauth' operation
in the 'Azure' API domain.
Description of the operation:
Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startazurecloudaccountoauth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartCloudAccountOauth { get; set; }

        
        [Parameter(
            ParameterSetName = "StartCreateNativeManagedDiskSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartCreateNativeManagedDiskSnapshotsJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startcreateazurenativemanageddisksnapshotsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartCreateNativeManagedDiskSnapshotsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartCreateNativeVirtualMachineSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartCreateNativeVirtualMachineSnapshotsJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startcreateazurenativevirtualmachinesnapshotsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartCreateNativeVirtualMachineSnapshotsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartDisableCloudAccountJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartDisableCloudAccountJob' operation
in the 'Azure' API domain.
Description of the operation:
Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startdisableazurecloudaccountjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartDisableCloudAccountJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartDisableNativeSubscriptionProtectionJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartDisableNativeSubscriptionProtectionJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to disable protection for a specified Azure subscription.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startdisableazurenativesubscriptionprotectionjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartDisableNativeSubscriptionProtectionJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartExportNativeManagedDiskJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartExportNativeManagedDiskJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to export the specified Azure Native Managed Disks to the desired destination.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startexportazurenativemanageddiskjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartExportNativeManagedDiskJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartExportNativeVirtualMachineJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartExportNativeVirtualMachineJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startexportazurenativevirtualmachinejob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartExportNativeVirtualMachineJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartExportSqlDatabaseDbJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartExportSqlDatabaseDbJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startexportazuresqldatabasedbjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartExportSqlDatabaseDbJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartExportSqlManagedInstanceDbJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartExportSqlManagedInstanceDbJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startexportazuresqlmanagedinstancedbjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartExportSqlManagedInstanceDbJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartRefreshNativeSubscriptionsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartRefreshNativeSubscriptionsJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startrefreshazurenativesubscriptionsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartRefreshNativeSubscriptionsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartRestoreNativeVirtualMachineJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartRestoreNativeVirtualMachineJob' operation
in the 'Azure' API domain.
Description of the operation:
Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startrestoreazurenativevirtualmachinejob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartRestoreNativeVirtualMachineJob { get; set; }

        
        [Parameter(
            ParameterSetName = "UnmapCloudAccountExocomputeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UnmapCloudAccountExocomputeSubscription' operation
in the 'Azure' API domain.
Description of the operation:
Unmap Azure cloud accounts from the mapped Exocompute subscription.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/unmapazurecloudaccountexocomputesubscription.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UnmapCloudAccountExocomputeSubscription { get; set; }

        
        [Parameter(
            ParameterSetName = "UnmapPersistentStorageSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UnmapPersistentStorageSubscription' operation
in the 'Azure' API domain.
Description of the operation:
Unmaps the archival location from the subscription.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/unmapazurepersistentstoragesubscription.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UnmapPersistentStorageSubscription { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateAccount' operation
in the 'Azure' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateazureaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateAutomaticTargetMapping' operation
in the 'Azure' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateautomaticazuretargetmapping.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateAutomaticTargetMapping { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCloudAccount' operation
in the 'Azure' API domain.
Description of the operation:
Update names of the Azure Subscriptions cloud account and regions for the given feature.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateazurecloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCloudNativeRcvStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCloudNativeRcvStorageSetting' operation
in the 'Azure' API domain.
Description of the operation:
Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatecloudnativercvazurestoragesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCloudNativeRcvStorageSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCloudNativeStorageSetting' operation
in the 'Azure' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatecloudnativeazurestoragesetting.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCloudNativeStorageSetting { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateCustomerAppPermissionForSql",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateCustomerAppPermissionForSql' operation
in the 'Azure' API domain.
Description of the operation:
Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatecustomerapppermissionforazuresql.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateCustomerAppPermissionForSql { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateTarget' operation
in the 'Azure' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updateazuretarget.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateTarget { get; set; }

        
        [Parameter(
            ParameterSetName = "UpgradeCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpgradeCloudAccount' operation
in the 'Azure' API domain.
Description of the operation:
Update permissions of the Azure Subscriptions cloud account for given feature.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/upgradeazurecloudaccount.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpgradeCloudAccount { get; set; }

        
        [Parameter(
            ParameterSetName = "UpgradeCloudAccountPermissionsWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpgradeCloudAccountPermissionsWithoutOauth' operation
in the 'Azure' API domain.
Description of the operation:
Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/upgradeazurecloudaccountpermissionswithoutoauth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpgradeCloudAccountPermissionsWithoutOauth { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddCloudAccount":
                        this.ProcessRecord_AddCloudAccount();
                        break;
                    case "AddCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_AddCloudAccountExocomputeConfigurations();
                        break;
                    case "AddCloudAccountWithoutOauth":
                        this.ProcessRecord_AddCloudAccountWithoutOauth();
                        break;
                    case "BackupAdDirectory":
                        this.ProcessRecord_BackupAdDirectory();
                        break;
                    case "CompleteAdAppSetup":
                        this.ProcessRecord_CompleteAdAppSetup();
                        break;
                    case "CompleteAdAppUpdate":
                        this.ProcessRecord_CompleteAdAppUpdate();
                        break;
                    case "CompleteCloudAccountOauth":
                        this.ProcessRecord_CompleteCloudAccountOauth();
                        break;
                    case "CreateAccount":
                        this.ProcessRecord_CreateAccount();
                        break;
                    case "CreateAutomaticTargetMapping":
                        this.ProcessRecord_CreateAutomaticTargetMapping();
                        break;
                    case "CreateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_CreateCloudNativeRcvStorageSetting();
                        break;
                    case "CreateCloudNativeStorageSetting":
                        this.ProcessRecord_CreateCloudNativeStorageSetting();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "CreateSaasAppAad":
                        this.ProcessRecord_CreateSaasAppAad();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "DeleteAdDirectory":
                        this.ProcessRecord_DeleteAdDirectory();
                        break;
                    case "DeleteCloudAccount":
                        this.ProcessRecord_DeleteCloudAccount();
                        break;
                    case "DeleteCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_DeleteCloudAccountExocomputeConfigurations();
                        break;
                    case "DeleteCloudAccountWithoutOauth":
                        this.ProcessRecord_DeleteCloudAccountWithoutOauth();
                        break;
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
                        break;
                    case "ExcludeNativeManagedDisksFromSnapshot":
                        this.ProcessRecord_ExcludeNativeManagedDisksFromSnapshot();
                        break;
                    case "MapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_MapCloudAccountExocomputeSubscription();
                        break;
                    case "MapCloudAccountToPersistentStorageLocation":
                        this.ProcessRecord_MapCloudAccountToPersistentStorageLocation();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "RestoreAdObjectsWithPasswords":
                        this.ProcessRecord_RestoreAdObjectsWithPasswords();
                        break;
                    case "SetCloudAccountCustomerAppCredentials":
                        this.ProcessRecord_SetCloudAccountCustomerAppCredentials();
                        break;
                    case "StartAdAppSetup":
                        this.ProcessRecord_StartAdAppSetup();
                        break;
                    case "StartAdAppUpdate":
                        this.ProcessRecord_StartAdAppUpdate();
                        break;
                    case "StartCloudAccountOauth":
                        this.ProcessRecord_StartCloudAccountOauth();
                        break;
                    case "StartCreateNativeManagedDiskSnapshotsJob":
                        this.ProcessRecord_StartCreateNativeManagedDiskSnapshotsJob();
                        break;
                    case "StartCreateNativeVirtualMachineSnapshotsJob":
                        this.ProcessRecord_StartCreateNativeVirtualMachineSnapshotsJob();
                        break;
                    case "StartDisableCloudAccountJob":
                        this.ProcessRecord_StartDisableCloudAccountJob();
                        break;
                    case "StartDisableNativeSubscriptionProtectionJob":
                        this.ProcessRecord_StartDisableNativeSubscriptionProtectionJob();
                        break;
                    case "StartExportNativeManagedDiskJob":
                        this.ProcessRecord_StartExportNativeManagedDiskJob();
                        break;
                    case "StartExportNativeVirtualMachineJob":
                        this.ProcessRecord_StartExportNativeVirtualMachineJob();
                        break;
                    case "StartExportSqlDatabaseDbJob":
                        this.ProcessRecord_StartExportSqlDatabaseDbJob();
                        break;
                    case "StartExportSqlManagedInstanceDbJob":
                        this.ProcessRecord_StartExportSqlManagedInstanceDbJob();
                        break;
                    case "StartRefreshNativeSubscriptionsJob":
                        this.ProcessRecord_StartRefreshNativeSubscriptionsJob();
                        break;
                    case "StartRestoreNativeVirtualMachineJob":
                        this.ProcessRecord_StartRestoreNativeVirtualMachineJob();
                        break;
                    case "UnmapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_UnmapCloudAccountExocomputeSubscription();
                        break;
                    case "UnmapPersistentStorageSubscription":
                        this.ProcessRecord_UnmapPersistentStorageSubscription();
                        break;
                    case "UpdateAccount":
                        this.ProcessRecord_UpdateAccount();
                        break;
                    case "UpdateAutomaticTargetMapping":
                        this.ProcessRecord_UpdateAutomaticTargetMapping();
                        break;
                    case "UpdateCloudAccount":
                        this.ProcessRecord_UpdateCloudAccount();
                        break;
                    case "UpdateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeRcvStorageSetting();
                        break;
                    case "UpdateCloudNativeStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeStorageSetting();
                        break;
                    case "UpdateCustomerAppPermissionForSql":
                        this.ProcessRecord_UpdateCustomerAppPermissionForSql();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
                        break;
                    case "UpgradeCloudAccount":
                        this.ProcessRecord_UpgradeCloudAccount();
                        break;
                    case "UpgradeCloudAccountPermissionsWithoutOauth":
                        this.ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth();
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
        // addAzureCloudAccount.
        internal void ProcessRecord_AddCloudAccount()
        {
            this._logger.name += " -AddCloudAccount";
            // Create new graphql operation addAzureCloudAccount
            InitMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_AddCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -AddCloudAccountExocomputeConfigurations";
            // Create new graphql operation addAzureCloudAccountExocomputeConfigurations
            InitMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_AddCloudAccountWithoutOauth()
        {
            this._logger.name += " -AddCloudAccountWithoutOauth";
            // Create new graphql operation addAzureCloudAccountWithoutOauth
            InitMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // backupAzureAdDirectory.
        internal void ProcessRecord_BackupAdDirectory()
        {
            this._logger.name += " -BackupAdDirectory";
            // Create new graphql operation backupAzureAdDirectory
            InitMutationBackupAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppSetup.
        internal void ProcessRecord_CompleteAdAppSetup()
        {
            this._logger.name += " -CompleteAdAppSetup";
            // Create new graphql operation completeAzureAdAppSetup
            InitMutationCompleteAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppUpdate.
        internal void ProcessRecord_CompleteAdAppUpdate()
        {
            this._logger.name += " -CompleteAdAppUpdate";
            // Create new graphql operation completeAzureAdAppUpdate
            InitMutationCompleteAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        internal void ProcessRecord_CompleteCloudAccountOauth()
        {
            this._logger.name += " -CompleteCloudAccountOauth";
            // Create new graphql operation completeAzureCloudAccountOauth
            InitMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        internal void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Create new graphql operation createAzureAccount
            InitMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        internal void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Create new graphql operation createAutomaticAzureTargetMapping
            InitMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeRcvStorageSetting";
            // Create new graphql operation createCloudNativeRcvAzureStorageSetting
            InitMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Create new graphql operation createCloudNativeAzureStorageSetting
            InitMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createAzureCluster
            InitMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createAzureReaderTarget
            InitMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        internal void ProcessRecord_CreateSaasAppAad()
        {
            this._logger.name += " -CreateSaasAppAad";
            // Create new graphql operation createAzureSaasAppAad
            InitMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createAzureTarget
            InitMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureAdDirectory.
        internal void ProcessRecord_DeleteAdDirectory()
        {
            this._logger.name += " -DeleteAdDirectory";
            // Create new graphql operation deleteAzureAdDirectory
            InitMutationDeleteAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        internal void ProcessRecord_DeleteCloudAccount()
        {
            this._logger.name += " -DeleteCloudAccount";
            // Create new graphql operation deleteAzureCloudAccount
            InitMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_DeleteCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -DeleteCloudAccountExocomputeConfigurations";
            // Create new graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InitMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_DeleteCloudAccountWithoutOauth()
        {
            this._logger.name += " -DeleteCloudAccountWithoutOauth";
            // Create new graphql operation deleteAzureCloudAccountWithoutOauth
            InitMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Create new graphql operation deleteAzureCluster
            InitMutationDeleteAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureNativeManagedDisksFromSnapshot.
        internal void ProcessRecord_ExcludeNativeManagedDisksFromSnapshot()
        {
            this._logger.name += " -ExcludeNativeManagedDisksFromSnapshot";
            // Create new graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InitMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_MapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -MapCloudAccountExocomputeSubscription";
            // Create new graphql operation mapAzureCloudAccountExocomputeSubscription
            InitMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        internal void ProcessRecord_MapCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -MapCloudAccountToPersistentStorageLocation";
            // Create new graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InitMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Create new graphql operation azureOauthConsentComplete
            InitMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Create new graphql operation azureOauthConsentKickoff
            InitMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // restoreAzureAdObjectsWithPasswords.
        internal void ProcessRecord_RestoreAdObjectsWithPasswords()
        {
            this._logger.name += " -RestoreAdObjectsWithPasswords";
            // Create new graphql operation restoreAzureAdObjectsWithPasswords
            InitMutationRestoreAzureAdObjectsWithPasswords();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        internal void ProcessRecord_SetCloudAccountCustomerAppCredentials()
        {
            this._logger.name += " -SetCloudAccountCustomerAppCredentials";
            // Create new graphql operation setAzureCloudAccountCustomerAppCredentials
            InitMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureAdAppSetup.
        internal void ProcessRecord_StartAdAppSetup()
        {
            this._logger.name += " -StartAdAppSetup";
            // Create new graphql operation startAzureAdAppSetup
            InitMutationStartAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureAdAppUpdate.
        internal void ProcessRecord_StartAdAppUpdate()
        {
            this._logger.name += " -StartAdAppUpdate";
            // Create new graphql operation startAzureAdAppUpdate
            InitMutationStartAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        internal void ProcessRecord_StartCloudAccountOauth()
        {
            this._logger.name += " -StartCloudAccountOauth";
            // Create new graphql operation startAzureCloudAccountOauth
            InitMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeManagedDiskSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeManagedDiskSnapshotsJob";
            // Create new graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InitMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeVirtualMachineSnapshotsJob";
            // Create new graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InitMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        internal void ProcessRecord_StartDisableCloudAccountJob()
        {
            this._logger.name += " -StartDisableCloudAccountJob";
            // Create new graphql operation startDisableAzureCloudAccountJob
            InitMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        internal void ProcessRecord_StartDisableNativeSubscriptionProtectionJob()
        {
            this._logger.name += " -StartDisableNativeSubscriptionProtectionJob";
            // Create new graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InitMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        internal void ProcessRecord_StartExportNativeManagedDiskJob()
        {
            this._logger.name += " -StartExportNativeManagedDiskJob";
            // Create new graphql operation startExportAzureNativeManagedDiskJob
            InitMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartExportNativeVirtualMachineJob()
        {
            this._logger.name += " -StartExportNativeVirtualMachineJob";
            // Create new graphql operation startExportAzureNativeVirtualMachineJob
            InitMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        internal void ProcessRecord_StartExportSqlDatabaseDbJob()
        {
            this._logger.name += " -StartExportSqlDatabaseDbJob";
            // Create new graphql operation startExportAzureSqlDatabaseDbJob
            InitMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        internal void ProcessRecord_StartExportSqlManagedInstanceDbJob()
        {
            this._logger.name += " -StartExportSqlManagedInstanceDbJob";
            // Create new graphql operation startExportAzureSqlManagedInstanceDbJob
            InitMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAzureNativeSubscriptionsJob.
        internal void ProcessRecord_StartRefreshNativeSubscriptionsJob()
        {
            this._logger.name += " -StartRefreshNativeSubscriptionsJob";
            // Create new graphql operation startRefreshAzureNativeSubscriptionsJob
            InitMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartRestoreNativeVirtualMachineJob()
        {
            this._logger.name += " -StartRestoreNativeVirtualMachineJob";
            // Create new graphql operation startRestoreAzureNativeVirtualMachineJob
            InitMutationStartRestoreAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_UnmapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -UnmapCloudAccountExocomputeSubscription";
            // Create new graphql operation unmapAzureCloudAccountExocomputeSubscription
            InitMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzurePersistentStorageSubscription.
        internal void ProcessRecord_UnmapPersistentStorageSubscription()
        {
            this._logger.name += " -UnmapPersistentStorageSubscription";
            // Create new graphql operation unmapAzurePersistentStorageSubscription
            InitMutationUnmapAzurePersistentStorageSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        internal void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Create new graphql operation updateAzureAccount
            InitMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        internal void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Create new graphql operation updateAutomaticAzureTargetMapping
            InitMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        internal void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Create new graphql operation updateAzureCloudAccount
            InitMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeRcvStorageSetting";
            // Create new graphql operation updateCloudNativeRcvAzureStorageSetting
            InitMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Create new graphql operation updateCloudNativeAzureStorageSetting
            InitMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        internal void ProcessRecord_UpdateCustomerAppPermissionForSql()
        {
            this._logger.name += " -UpdateCustomerAppPermissionForSql";
            // Create new graphql operation updateCustomerAppPermissionForAzureSql
            InitMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateAzureTarget
            InitMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        internal void ProcessRecord_UpgradeCloudAccount()
        {
            this._logger.name += " -UpgradeCloudAccount";
            // Create new graphql operation upgradeAzureCloudAccount
            InitMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        internal void ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -UpgradeCloudAccountPermissionsWithoutOauth";
            // Create new graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InitMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }


        // Create new GraphQL Mutation:
        // addAzureCloudAccount(input: AddAzureCloudAccountInput!): AddAzureCloudAccountReply!
        internal void InitMutationAddAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccount",
                "($input: AddAzureCloudAccountInput!)",
                "AddAzureCloudAccountReply",
                Mutation.AddAzureCloudAccount_ObjectFieldSpec,
                Mutation.AddAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = $someString
						# OPTIONAL
						tags = @{
							# REQUIRED
							tagList = @(
								@{
									# REQUIRED
									key = $someString
									# REQUIRED
									value = $someString
								}
							)
						}
						# REQUIRED
						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# REQUIRED
					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = $someString
				# REQUIRED
				name = $someString
			}
		}
	)
	# REQUIRED
	regions = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!): AddAzureCloudAccountExocomputeConfigurationsReply!
        internal void InitMutationAddAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccountExocomputeConfigurations",
                "($input: AddAzureCloudAccountExocomputeConfigurationsInput!)",
                "AddAzureCloudAccountExocomputeConfigurationsReply",
                Mutation.AddAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Mutation.AddAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = $someString
			# REQUIRED
			isRscManaged = $someBoolean
			# OPTIONAL
			podSubnetNativeId = $someString
		}
	)
	# OPTIONAL
	triggerHealthCheck = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!): AddAzureCloudAccountWithoutOauthReply!
        internal void InitMutationAddAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccountWithoutOauth",
                "($input: AddAzureCloudAccountWithoutOauthInput!)",
                "AddAzureCloudAccountWithoutOauthReply",
                Mutation.AddAzureCloudAccountWithoutOauth_ObjectFieldSpec,
                Mutation.AddAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# REQUIRED
					policyVersion = $someInt
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = $someString
						# OPTIONAL
						tags = @{
							# REQUIRED
							tagList = @(
								@{
									# REQUIRED
									key = $someString
									# REQUIRED
									value = $someString
								}
							)
						}
						# REQUIRED
						region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# OPTIONAL
					specificFeatureInput = @{
						# REQUIRED
						userAssignedManagedIdentityInput = @{
							# REQUIRED
							name = $someString
							# REQUIRED
							resourceGroupName = $someString
							# REQUIRED
							principalId = $someString
							# REQUIRED
							region = $someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
						}
					}
					# REQUIRED
					featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = $someString
				# REQUIRED
				name = $someString
			}
		}
	)
	# REQUIRED
	regions = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupAzureAdDirectory(input: BackupAzureAdDirectoryInput!): [CreateOnDemandJobReply!]!
        internal void InitMutationBackupAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupAzureAdDirectoryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupAzureAdDirectory",
                "($input: BackupAzureAdDirectoryInput!)",
                "List<CreateOnDemandJobReply>",
                Mutation.BackupAzureAdDirectory_ObjectFieldSpec,
                Mutation.BackupAzureAdDirectoryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureAdAppSetup(input: CompleteAzureAdAppSetupInput!): CompleteAzureAdAppSetupReply!
        internal void InitMutationCompleteAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureAdAppSetup",
                "($input: CompleteAzureAdAppSetupInput!)",
                "CompleteAzureAdAppSetupReply",
                Mutation.CompleteAzureAdAppSetup_ObjectFieldSpec,
                Mutation.CompleteAzureAdAppSetupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	domainName = $someString
	# REQUIRED
	stateToken = $someString
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = $someString
		# OPTIONAL
		kmsId = $someString
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecret = $someString
		# OPTIONAL
		keyName = $someString
		# OPTIONAL
		kekNameColossus = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureAdAppUpdate(input: CompleteAzureAdAppUpdateInput!): Void
        internal void InitMutationCompleteAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureAdAppUpdate",
                "($input: CompleteAzureAdAppUpdateInput!)",
                "System.String",
                Mutation.CompleteAzureAdAppUpdate_ObjectFieldSpec,
                Mutation.CompleteAzureAdAppUpdateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
	# REQUIRED
	stateToken = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!): CompleteAzureCloudAccountOauthReply!
        internal void InitMutationCompleteAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureCloudAccountOauth",
                "($input: CompleteAzureCloudAccountOauthInput!)",
                "CompleteAzureCloudAccountOauthReply",
                Mutation.CompleteAzureCloudAccountOauth_ObjectFieldSpec,
                Mutation.CompleteAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	tenantDomainName = $someString
	# REQUIRED
	authorizationCode = $someString
	# REQUIRED
	redirectUrl = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	appId = $someString
	# OPTIONAL
	appSecretKey = $someString
	# REQUIRED
	shouldSkipPermissionChecks = $someBoolean
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	resource = $someAzureOauthResource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureOauthResource]) for enum values.
	# OPTIONAL
	performBasicOauth = $someBoolean
	# OPTIONAL
	shouldKeepRefreshToken = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureAccount(input: CreateAzureAccountInput!): CloudAccount!
        internal void InitMutationCreateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureAccount",
                "($input: CreateAzureAccountInput!)",
                "CloudAccount",
                Mutation.CreateAzureAccount_ObjectFieldSpec,
                Mutation.CreateAzureAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# OPTIONAL
	description = $someString
	# REQUIRED
	subscriptionId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAutomaticAzureTargetMapping",
                "($input: CreateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateAutomaticAzureTargetMapping_ObjectFieldSpec,
                Mutation.CreateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	containerNamePrefix = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
		# OPTIONAL
		cloudAccountId = $someString
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	clusterUuidList = @(
		$someString
	)
	# REQUIRED
	isConsolidationEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        internal void InitMutationCreateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeRcvAzureStorageSetting",
                "($input: CreateCloudNativeRcvAzureStorageSettingInput!)",
                "CreateCloudNativeRcvAzureStorageSettingReply",
                Mutation.CreateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec,
                Mutation.CreateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        internal void InitMutationCreateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeAzureStorageSetting",
                "($input: CreateCloudNativeAzureStorageSettingInput!)",
                "CreateCloudNativeAzureStorageSettingReply",
                Mutation.CreateCloudNativeAzureStorageSetting_ObjectFieldSpec,
                Mutation.CreateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	containerName = $someString
	# OPTIONAL
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				value = $someString
			}
		)
	}
	# OPTIONAL
	storageAccountRegion = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	redundancy = $someAzureRedundancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
	# REQUIRED
	subscriptionNativeId = $someString
	# REQUIRED
	cloudNativeLocTemplateType = $someCloudNativeLocTemplateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = $someString
			# OPTIONAL
			keyName = $someString
			# OPTIONAL
			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        internal void InitMutationCreateAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureCluster",
                "($input: CreateAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.CreateAzureCluster_ObjectFieldSpec,
                Mutation.CreateAzureClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	isEsType = $someBoolean
	# OPTIONAL
	keepClusterOnFailure = $someBoolean
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = $someString
		# OPTIONAL
		adminPassword = $someString
		# OPTIONAL
		clusterName = $someString
		# OPTIONAL
		numNodes = $someInt
		# OPTIONAL
		dnsSearchDomains = @(
			$someString
		)
		# OPTIONAL
		dnsNameServers = @(
			$someString
		)
		# OPTIONAL
		ntpServers = @(
			$someString
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = $someString
			# OPTIONAL
			resourceGroup = $someString
			# OPTIONAL
			storageSecret = $someString
			# OPTIONAL
			containerName = $someString
			# OPTIONAL
			shouldCreateContainer = $someBoolean
			# OPTIONAL
			enableImmutability = $someBoolean
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = $someString
			# OPTIONAL
			shouldCreateBucket = $someBoolean
			# OPTIONAL
			enableObjectLock = $someBoolean
			# OPTIONAL
			enableImmutability = $someBoolean
		}
	}
	# OPTIONAL
	vmConfig = @{
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		cdmVersion = $someString
		# OPTIONAL
		location = $someString
		# OPTIONAL
		nodeSizeGb = $someInt
		# OPTIONAL
		networkResourceGroup = $someString
		# OPTIONAL
		vnetResourceGroup = $someString
		# OPTIONAL
		networkSecurityGroup = $someString
		# OPTIONAL
		networkSecurityResourceGroup = $someString
		# OPTIONAL
		vnet = $someString
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		tags = $someString
		# OPTIONAL
		vmImage = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureReaderTarget(input: CreateAzureReaderTargetInput!): Target!
        internal void InitMutationCreateAzureReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureReaderTarget",
                "($input: CreateAzureReaderTargetInput!)",
                "Target",
                Mutation.CreateAzureReaderTarget_ObjectFieldSpec,
                Mutation.CreateAzureReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	containerName = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
		# OPTIONAL
		cloudAccountId = $someString
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        internal void InitMutationCreateAzureSaasAppAad()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureSaasAppAad",
                "",
                "CreateAzureSaasAppAadReply",
                Mutation.CreateAzureSaasAppAad_ObjectFieldSpec,
                Mutation.CreateAzureSaasAppAadFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // createAzureTarget(input: CreateAzureTargetInput!): Target!
        internal void InitMutationCreateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureTarget",
                "($input: CreateAzureTargetInput!)",
                "Target",
                Mutation.CreateAzureTarget_ObjectFieldSpec,
                Mutation.CreateAzureTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	storageAccountName = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	containerName = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	instanceType = $someInstanceTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
		# OPTIONAL
		cloudAccountId = $someString
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# OPTIONAL
	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureAdDirectory(input: DeleteAzureAdDirectoryInput!): CreateOnDemandJobReply!
        internal void InitMutationDeleteAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureAdDirectoryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureAdDirectory",
                "($input: DeleteAzureAdDirectoryInput!)",
                "CreateOnDemandJobReply",
                Mutation.DeleteAzureAdDirectory_ObjectFieldSpec,
                Mutation.DeleteAzureAdDirectoryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!): DeleteAzureCloudAccountReply!
        internal void InitMutationDeleteAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccount",
                "($input: DeleteAzureCloudAccountInput!)",
                "DeleteAzureCloudAccountReply",
                Mutation.DeleteAzureCloudAccount_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!): DeleteAzureCloudAccountExocomputeConfigurationsReply!
        internal void InitMutationDeleteAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountExocomputeConfigurations",
                "($input: DeleteAzureCloudAccountExocomputeConfigurationsInput!)",
                "DeleteAzureCloudAccountExocomputeConfigurationsReply",
                Mutation.DeleteAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        internal void InitMutationDeleteAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountWithoutOauth",
                "($input: DeleteAzureCloudAccountWithoutOauthInput!)",
                "DeleteAzureCloudAccountWithoutOauthReply",
                Mutation.DeleteAzureCloudAccountWithoutOauth_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
        internal void InitMutationDeleteAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCluster",
                "($input: DeleteAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.DeleteAzureCluster_ObjectFieldSpec,
                Mutation.DeleteAzureClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	clusterName = $someString
	# OPTIONAL
	numNodes = $someInt
	# OPTIONAL
	resourceGroupName = $someString
	# OPTIONAL
	networkResourceGroup = $someString
	# OPTIONAL
	isEsType = $someBoolean
	# OPTIONAL
	storageAccount = $someString
	# OPTIONAL
	containerName = $someString
	# OPTIONAL
	storageResourceGroup = $someString
	# OPTIONAL
	isNewContainer = $someBoolean
	# OPTIONAL
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        internal void InitMutationExcludeAzureNativeManagedDisksFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAzureNativeManagedDisksFromSnapshot",
                "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)",
                "System.String",
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshot_ObjectFieldSpec,
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	virtualMachineRubrikId = $someString
	# REQUIRED
	managedDiskExclusions = @(
		@{
			# REQUIRED
			managedDiskRubrikId = $someString
			# REQUIRED
			isExcludedFromSnapshot = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InitMutationMapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountExocomputeSubscription",
                "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)",
                "MapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.MapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec,
                Mutation.MapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# REQUIRED
	exocomputeCloudAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        internal void InitMutationMapAzureCloudAccountToPersistentStorageLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountToPersistentStorageLocation",
                "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)",
                "MapAzureCloudAccountToPersistentStorageLocationReply",
                Mutation.MapAzureCloudAccountToPersistentStorageLocation_ObjectFieldSpec,
                Mutation.MapAzureCloudAccountToPersistentStorageLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
	# REQUIRED
	persistentStorageId = $someString
	# REQUIRED
	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        internal void InitMutationAzureOauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentComplete",
                "($input: AzureOauthConsentCompleteInput!)",
                "RequestStatus",
                Mutation.AzureOauthConsentComplete_ObjectFieldSpec,
                Mutation.AzureOauthConsentCompleteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	tenantId = $someString
	# REQUIRED
	code = $someString
	# REQUIRED
	stateToken = $someString
	# REQUIRED
	redirectUrl = $someString
	# OPTIONAL
	azureAppId = $someString
	# OPTIONAL
	azureAppSecret = $someString
	# REQUIRED
	azureCloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        internal void InitMutationAzureOauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentKickoff",
                "",
                "AzureOauthConsentKickoffReply",
                Mutation.AzureOauthConsentKickoff_ObjectFieldSpec,
                Mutation.AzureOauthConsentKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // restoreAzureAdObjectsWithPasswords(input: RestoreAzureAdObjectsWithPasswordsInput!): RestoreAzureAdObjectsWithPasswordsReply!
        internal void InitMutationRestoreAzureAdObjectsWithPasswords()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreAzureAdObjectsWithPasswordsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreAzureAdObjectsWithPasswords",
                "($input: RestoreAzureAdObjectsWithPasswordsInput!)",
                "RestoreAzureAdObjectsWithPasswordsReply",
                Mutation.RestoreAzureAdObjectsWithPasswords_ObjectFieldSpec,
                Mutation.RestoreAzureAdObjectsWithPasswordsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
	# REQUIRED
	snapshotFid = $someString
	# REQUIRED
	passwordByUserIdMap = @(
		@{
			# REQUIRED
			userId = $someString
			# REQUIRED
			password = $someString
		}
	)
	# REQUIRED
	objectTypeToIdMap = @(
		@{
			# REQUIRED
			objectId = $someString
			# REQUIRED
			azureAdObjectType = $someAzureAdObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
		}
	)
	# REQUIRED
	forceChangePasswordWithMfa = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        internal void InitMutationSetAzureCloudAccountCustomerAppCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetAzureCloudAccountCustomerAppCredentials",
                "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)",
                "System.Boolean",
                Mutation.SetAzureCloudAccountCustomerAppCredentials_ObjectFieldSpec,
                Mutation.SetAzureCloudAccountCustomerAppCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	appId = $someString
	# REQUIRED
	appSecretKey = $someString
	# OPTIONAL
	appTenantId = $someString
	# OPTIONAL
	appName = $someString
	# OPTIONAL
	tenantDomainName = $someString
	# REQUIRED
	shouldReplace = $someBoolean
	# REQUIRED
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureAdAppSetup(input: StartAzureAdAppSetupInput!): StartAzureAdAppSetupReply!
        internal void InitMutationStartAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureAdAppSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureAdAppSetup",
                "($input: StartAzureAdAppSetupInput!)",
                "StartAzureAdAppSetupReply",
                Mutation.StartAzureAdAppSetup_ObjectFieldSpec,
                Mutation.StartAzureAdAppSetupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	domainName = $someString
	# REQUIRED
	region = $someAzureAdRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdRegion]) for enum values.
	# OPTIONAL
	azureAdApp = @{
		# OPTIONAL
		clientId = $someString
		# OPTIONAL
		clientSecret = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureAdAppUpdate(input: StartAzureAdAppUpdateInput!): StartAzureAdAppUpdateReply!
        internal void InitMutationStartAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureAdAppUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureAdAppUpdate",
                "($input: StartAzureAdAppUpdateInput!)",
                "StartAzureAdAppUpdateReply",
                Mutation.StartAzureAdAppUpdate_ObjectFieldSpec,
                Mutation.StartAzureAdAppUpdateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
	# OPTIONAL
	azureAdApp = @{
		# OPTIONAL
		clientId = $someString
		# OPTIONAL
		clientSecret = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        internal void InitMutationStartAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureCloudAccountOauth",
                "($input: StartAzureCloudAccountOauthInput!)",
                "StartAzureCloudAccountOauthReply",
                Mutation.StartAzureCloudAccountOauth_ObjectFieldSpec,
                Mutation.StartAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	tenantDomainName = $someString
	# OPTIONAL
	azureCloudType = $someAzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeManagedDiskSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeManagedDiskSnapshotsJob",
                "($input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAzureNativeManagedDiskSnapshotsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	managedDiskRubrikIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
                "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	virtualMachineRubrikIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartDisableAzureCloudAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureCloudAccountJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureCloudAccountJob",
                "($input: StartDisableAzureCloudAccountJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartDisableAzureCloudAccountJob_ObjectFieldSpec,
                Mutation.StartDisableAzureCloudAccountJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        internal void InitMutationStartDisableAzureNativeSubscriptionProtectionJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureNativeSubscriptionProtectionJob",
                "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)",
                "AsyncJobStatus",
                Mutation.StartDisableAzureNativeSubscriptionProtectionJob_ObjectFieldSpec,
                Mutation.StartDisableAzureNativeSubscriptionProtectionJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikId = $someString
	# REQUIRED
	shouldDeleteNativeSnapshots = $someBoolean
	# REQUIRED
	azureNativeProtectionFeature = $someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureNativeManagedDiskJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeManagedDiskJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeManagedDiskJob",
                "($input: StartExportAzureNativeManagedDiskJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeManagedDiskJob_ObjectFieldSpec,
                Mutation.StartExportAzureNativeManagedDiskJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	diskName = $someString
	# OPTIONAL
	diskEncryptionSetNativeId = $someString
	# REQUIRED
	diskStorageTier = $someAzureNativeManagedDiskType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeManagedDiskType]) for enum values.
	# REQUIRED
	diskSize = $someInt
	# REQUIRED
	resourceGroup = $someString
	# REQUIRED
	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = $someString
	# OPTIONAL
	destinationSubscriptionRubrikId = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# REQUIRED
	shouldReplaceAttachedManagedDisk = $someBoolean
	# OPTIONAL
	shouldUseReplica = $someBoolean
	# OPTIONAL
	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeVirtualMachineJob",
                "($input: StartExportAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeVirtualMachineJob_ObjectFieldSpec,
                Mutation.StartExportAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	virtualMachineName = $someString
	# OPTIONAL
	diskEncryptionSetNativeId = $someString
	# REQUIRED
	resourceGroupName = $someString
	# REQUIRED
	destinationRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = $someString
	# OPTIONAL
	destinationSubscriptionRubrikId = $someString
	# REQUIRED
	virtualMachineSize = $someString
	# REQUIRED
	subnetNativeId = $someString
	# OPTIONAL
	networkSecurityGroupNativeId = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# REQUIRED
	shouldPowerOff = $someBoolean
	# OPTIONAL
	shouldUseReplica = $someBoolean
	# OPTIONAL
	availabilitySetNativeId = $someString
	# OPTIONAL
	shouldEnableAcceleratedNetworking = $someBoolean
	# OPTIONAL
	snapshotType = $someAzureSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureSqlDatabaseDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlDatabaseDbJob",
                "($input: StartExportAzureSqlDatabaseDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlDatabaseDbJob_ObjectFieldSpec,
                Mutation.StartExportAzureSqlDatabaseDbJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sourceDatabaseRubrikId = $someString
	# REQUIRED
	destinationDatabaseName = $someString
	# OPTIONAL
	destinationServerRubrikId = $someString
	# OPTIONAL
	elasticPoolName = $someString
	# REQUIRED
	shouldExportTags = $someBoolean
	# OPTIONAL
	azureSqlDatabaseDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = $someDateTime
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	azureSqlDatabaseDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# REQUIRED
		destinationResourceGroupName = $someString
		# REQUIRED
		destinationServerName = $someString
		# REQUIRED
		destinationRegionName = $someString
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = $someString
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = $someString
	# OPTIONAL
	serviceObjectiveName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureSqlManagedInstanceDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlManagedInstanceDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlManagedInstanceDbJob",
                "($input: StartExportAzureSqlManagedInstanceDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlManagedInstanceDbJob_ObjectFieldSpec,
                Mutation.StartExportAzureSqlManagedInstanceDbJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sourceManagedInstanceDatabaseRubrikId = $someString
	# OPTIONAL
	destinationManagedInstanceRubrikId = $someString
	# REQUIRED
	destinationDatabaseName = $someString
	# REQUIRED
	destinationManagedInstanceName = $someString
	# REQUIRED
	destinationResourceGroupName = $someString
	# OPTIONAL
	azureSqlManagedInstanceDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = $someDateTime
	}
	# OPTIONAL
	azureSqlManagedInstanceDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# REQUIRED
		destinationRegionName = $someString
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = $someString
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = $someString
			# REQUIRED
			password = $someString
		}
		# OPTIONAL
		authMechanism = $someSqlAuthenticationMechanism # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = $someString
		# OPTIONAL
		dbBackupRedundancy = $someAzureSqlBackupStorageRedundancyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = $someString
	# OPTIONAL
	serviceObjectiveName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartRefreshAzureNativeSubscriptionsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAzureNativeSubscriptionsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRefreshAzureNativeSubscriptionsJob",
                "($input: StartRefreshAzureNativeSubscriptionsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartRefreshAzureNativeSubscriptionsJob_ObjectFieldSpec,
                Mutation.StartRefreshAzureNativeSubscriptionsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InitMutationStartRestoreAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRestoreAzureNativeVirtualMachineJob",
                "($input: StartRestoreAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRestoreAzureNativeVirtualMachineJob_ObjectFieldSpec,
                Mutation.StartRestoreAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	shouldPowerOn = $someBoolean
	# REQUIRED
	shouldRestoreTags = $someBoolean
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = $someSnapshotTypeForRestoreIfSourceExpired # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeForRestoreIfSourceExpired]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!): UnmapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InitMutationUnmapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapAzureCloudAccountExocomputeSubscription",
                "($input: UnmapAzureCloudAccountExocomputeSubscriptionInput!)",
                "UnmapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.UnmapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec,
                Mutation.UnmapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapAzurePersistentStorageSubscription(input: UnmapAzurePersistentStorageSubscriptionInput!): Void
        internal void InitMutationUnmapAzurePersistentStorageSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzurePersistentStorageSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapAzurePersistentStorageSubscription",
                "($input: UnmapAzurePersistentStorageSubscriptionInput!)",
                "System.String",
                Mutation.UnmapAzurePersistentStorageSubscription_ObjectFieldSpec,
                Mutation.UnmapAzurePersistentStorageSubscriptionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	applicationCloudAccountIds = @(
		$someString
	)
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	unmappingValidationType = $someUnmappingValidationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        internal void InitMutationUpdateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureAccount",
                "($input: UpdateAzureAccountInput!)",
                "CloudAccount",
                Mutation.UpdateAzureAccount_ObjectFieldSpec,
                Mutation.UpdateAzureAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	subscriptionId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutomaticAzureTargetMapping",
                "($input: UpdateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateAutomaticAzureTargetMapping_ObjectFieldSpec,
                Mutation.UpdateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	storageAccountName = $someString
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
		# OPTIONAL
		cloudAccountId = $someString
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	clusterUuidList = @(
		$someString
	)
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!): UpdateAzureCloudAccountReply!
        internal void InitMutationUpdateAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureCloudAccount",
                "($input: UpdateAzureCloudAccountInput!)",
                "UpdateAzureCloudAccountReply",
                Mutation.UpdateAzureCloudAccount_ObjectFieldSpec,
                Mutation.UpdateAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	subscriptions = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			name = $someString
		}
	)
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	regionsToAdd = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	regionsToRemove = @(
		$someAzureCloudAccountRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!): UpdateCloudNativeRcvAzureStorageSettingReply!
        internal void InitMutationUpdateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeRcvAzureStorageSetting",
                "($input: UpdateCloudNativeRcvAzureStorageSettingInput!)",
                "UpdateCloudNativeRcvAzureStorageSettingReply",
                Mutation.UpdateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec,
                Mutation.UpdateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	name = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!): UpdateCloudNativeAzureStorageSettingReply!
        internal void InitMutationUpdateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeAzureStorageSetting",
                "($input: UpdateCloudNativeAzureStorageSettingInput!)",
                "UpdateCloudNativeAzureStorageSettingReply",
                Mutation.UpdateCloudNativeAzureStorageSetting_ObjectFieldSpec,
                Mutation.UpdateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				value = $someString
			}
		)
	}
	# REQUIRED
	storageTier = $someAzureStorageTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = $someString
			# OPTIONAL
			keyName = $someString
			# OPTIONAL
			region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomerAppPermissionForAzureSql: Void
        internal void InitMutationUpdateCustomerAppPermissionForAzureSql()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomerAppPermissionForAzureSql",
                "",
                "System.String",
                Mutation.UpdateCustomerAppPermissionForAzureSql_ObjectFieldSpec,
                Mutation.UpdateCustomerAppPermissionForAzureSqlFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        internal void InitMutationUpdateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureTarget",
                "($input: UpdateAzureTargetInput!)",
                "Target",
                Mutation.UpdateAzureTarget_ObjectFieldSpec,
                Mutation.UpdateAzureTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	storageAccountName = $someString
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecretKey = $someString
		# OPTIONAL
		region = $someAzureRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = $someString
		# OPTIONAL
		generalPurposeStorageContainer = $someString
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		virtualNetworkId = $someString
		# OPTIONAL
		subnetId = $someString
		# OPTIONAL
		securityGroupId = $someString
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = $someString
			# OPTIONAL
			portNumber = $someInt
			# OPTIONAL
			username = $someString
			# OPTIONAL
			password = $someString
			# OPTIONAL
			protocol = $someString
		}
		# OPTIONAL
		cloudAccountId = $someString
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = $someString
		# OPTIONAL
		portNumber = $someInt
		# OPTIONAL
		username = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		protocol = $someString
	}
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = $someInt
	}
	# OPTIONAL
	retrievalTier = $someAzureRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!): UpgradeAzureCloudAccountReply!
        internal void InitMutationUpgradeAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAzureCloudAccount",
                "($input: UpgradeAzureCloudAccountInput!)",
                "UpgradeAzureCloudAccountReply",
                Mutation.UpgradeAzureCloudAccount_ObjectFieldSpec,
                Mutation.UpgradeAzureCloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	features = @(
		$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featuresToUpgrade = @(
		@{
			# REQUIRED
			featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			permissionsGroups = @(
				$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
		}
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!): UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        internal void InitMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountPermissionsWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAzureCloudAccountPermissionsWithoutOauth",
                "($input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!)",
                "UpgradeAzureCloudAccountPermissionsWithoutOauthReply",
                Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth_ObjectFieldSpec,
                Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	feature = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	featureToUpgrade = @{
		# REQUIRED
		featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		# REQUIRED
		permissionsGroups = @(
			$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
		)
	}
}"
            );
        }


    } // class New_RscMutationAzure
}