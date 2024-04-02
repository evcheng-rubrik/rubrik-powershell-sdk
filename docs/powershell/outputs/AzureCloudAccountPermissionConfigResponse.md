### AzureCloudAccountPermissionConfigResponse
Configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Rubrik features that the customer wants to be enabled on the cloud account.

- permissionVersion: System.Int32
  - Policy permission version to be used on Rubrik for adding a subscription.
- rolePermissions: list of AzureCloudAccountRolePermissions
  - List of permissions to be applied on the subscription level role created in Azure for a subscription.
- resourceGroupRolePermissions: list of AzureCloudAccountRolePermissions
  - List of permissions to be applied on the resource group level role created in Azure for a subscription.
- permissionsGroupVersions: list of PermissionsGroupWithVersions
  - Policy permissions group versions to be used on Rubrik for adding a subscription.
