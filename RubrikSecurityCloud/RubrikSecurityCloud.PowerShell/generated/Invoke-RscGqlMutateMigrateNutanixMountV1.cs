// Invoke-RscGqlMutateMigrateNutanixMountV1.cs
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
    /// Invoke GraphQL Mutation migrateNutanixMountV1
    /// migrateNutanixMountV1(input: MigrateNutanixMountV1Input!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateMigrateNutanixMountV1")
    ]
    public class Invoke_RscGqlMutateMigrateNutanixMountV1 : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("migrateNutanixMountV1");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation migrateNutanixMountV1
        /// migrateNutanixMountV1(input: MigrateNutanixMountV1Input!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_migrateNutanixMountV1();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_migrateNutanixMountV1()
        {
            this._logger.name += " -migrateNutanixMountV1";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MigrateNutanixMountV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMigrateNutanixMountV1",
                "($input: MigrateNutanixMountV1Input!)",
                "AsyncRequestStatus",
                Mutation.MigrateNutanixMountV1_ObjectFieldSpec,
                Mutation.MigrateNutanixMountV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateMigrateNutanixMountV1
}