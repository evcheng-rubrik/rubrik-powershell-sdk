### AwsCloudAccountsWithFeaturesInput
AWS cloud accounts with features.

- feature: CloudAccountFeature
  - Type of cloud native protection feature.
- statusFilters: list of CloudAccountStatuss
  - List of status filters for listing cloud accounts.
- awsAdminAccountFilter: System.String
  - Admin account ID to filter.
- columnSearchFilter: System.String
  - Search text to match in native ID, account name, and role ARN.
