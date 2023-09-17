// Invoke-RscGqlMutateRefreshNutanixCluster.cs
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
    /// Invoke GraphQL Mutation refreshNutanixCluster
    /// refreshNutanixCluster(input: RefreshNutanixClusterInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRefreshNutanixCluster")
    ]
    public class Invoke_RscGqlMutateRefreshNutanixCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("refreshNutanixCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation refreshNutanixCluster
        /// refreshNutanixCluster(input: RefreshNutanixClusterInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_refreshNutanixCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_refreshNutanixCluster()
        {
            this._logger.name += " -refreshNutanixCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshNutanixCluster",
                "($input: RefreshNutanixClusterInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshNutanixCluster_ObjectFieldSpec,
                Mutation.RefreshNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateRefreshNutanixCluster
}