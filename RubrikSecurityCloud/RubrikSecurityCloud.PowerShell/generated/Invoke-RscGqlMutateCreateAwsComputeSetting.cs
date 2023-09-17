// Invoke-RscGqlMutateCreateAwsComputeSetting.cs
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

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Invoke GraphQL Mutation createAwsComputeSetting
    /// createAwsComputeSetting(input: CreateAwsComputeSettingInput!): AwsComputeSettings!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateCreateAwsComputeSetting")
    ]
    public class Invoke_RscGqlMutateCreateAwsComputeSetting : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAwsComputeSetting");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation createAwsComputeSetting
        /// createAwsComputeSetting(input: CreateAwsComputeSettingInput!): AwsComputeSettings!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAwsComputeSetting();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAwsComputeSetting()
        {
            this._logger.name += " -createAwsComputeSetting";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsComputeSetting",
                "($input: CreateAwsComputeSettingInput!)",
                "AwsComputeSettings",
                Mutation.CreateAwsComputeSetting_ObjectFieldSpec,
                Mutation.CreateAwsComputeSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	subnetId = <System.String>
	# OPTIONAL
	vpcId = <System.String>
	# OPTIONAL
	securityGroupId = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	isSecurityGroupPolarisManaged = <System.Boolean>
	# OPTIONAL
	clusterInterfaceCidrs = @(
		@{
			# OPTIONAL
			clusterName = <System.String>
			# OPTIONAL
			clusterId = <System.String>
			# OPTIONAL
			interfaceCidr = @(
				@{
					# OPTIONAL
					interfaceType = <InterfaceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InterfaceType]) for enum values.
					# OPTIONAL
					cidr = <System.String>
					# OPTIONAL
					selected = <System.Boolean>
				}
			)
		}
	)
}"
            );
        }

    } // class Invoke-RscGqlMutateCreateAwsComputeSetting
}