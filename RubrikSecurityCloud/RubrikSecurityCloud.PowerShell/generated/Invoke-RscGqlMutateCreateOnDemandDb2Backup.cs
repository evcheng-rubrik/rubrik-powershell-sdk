// Invoke-RscGqlMutateCreateOnDemandDb2Backup.cs
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
    /// Invoke GraphQL Mutation createOnDemandDb2Backup
    /// createOnDemandDb2Backup(input: CreateOnDemandDb2BackupInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateCreateOnDemandDb2Backup")
    ]
    public class Invoke_RscGqlMutateCreateOnDemandDb2Backup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createOnDemandDb2Backup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation createOnDemandDb2Backup
        /// createOnDemandDb2Backup(input: CreateOnDemandDb2BackupInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createOnDemandDb2Backup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createOnDemandDb2Backup()
        {
            this._logger.name += " -createOnDemandDb2Backup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandDb2BackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandDb2Backup",
                "($input: CreateOnDemandDb2BackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandDb2Backup_ObjectFieldSpec,
                Mutation.CreateOnDemandDb2BackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateCreateOnDemandDb2Backup
}