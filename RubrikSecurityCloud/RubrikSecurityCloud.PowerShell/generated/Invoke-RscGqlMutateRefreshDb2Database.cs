// Invoke-RscGqlMutateRefreshDb2Database.cs
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
    /// Invoke GraphQL Mutation refreshDb2Database
    /// refreshDb2Database(input: RefreshDb2DatabaseInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRefreshDb2Database")
    ]
    public class Invoke_RscGqlMutateRefreshDb2Database : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("refreshDb2Database");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation refreshDb2Database
        /// refreshDb2Database(input: RefreshDb2DatabaseInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_refreshDb2Database();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_refreshDb2Database()
        {
            this._logger.name += " -refreshDb2Database";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshDb2Database",
                "($input: RefreshDb2DatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshDb2Database_ObjectFieldSpec,
                Mutation.RefreshDb2DatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateRefreshDb2Database
}