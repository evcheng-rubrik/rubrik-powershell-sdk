// Invoke-RscGqlMutateRefreshNutanixPrismCentral.cs
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
    /// Invoke GraphQL Mutation refreshNutanixPrismCentral
    /// refreshNutanixPrismCentral(input: RefreshNutanixPrismCentralInput!): BatchAsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRefreshNutanixPrismCentral")
    ]
    public class Invoke_RscGqlMutateRefreshNutanixPrismCentral : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("refreshNutanixPrismCentral");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation refreshNutanixPrismCentral
        /// refreshNutanixPrismCentral(input: RefreshNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_refreshNutanixPrismCentral();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_refreshNutanixPrismCentral()
        {
            this._logger.name += " -refreshNutanixPrismCentral";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshNutanixPrismCentral",
                "($input: RefreshNutanixPrismCentralInput!)",
                "BatchAsyncRequestStatus",
                Mutation.RefreshNutanixPrismCentral_ObjectFieldSpec,
                Mutation.RefreshNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateRefreshNutanixPrismCentral
}