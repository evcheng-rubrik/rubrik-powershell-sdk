// Invoke-RscGqlMutateO365OauthConsentKickoff.cs
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
    /// Invoke GraphQL Mutation o365OauthConsentKickoff
    /// o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateO365OauthConsentKickoff")
    ]
    public class Invoke_RscGqlMutateO365OauthConsentKickoff : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365OauthConsentKickoff");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation o365OauthConsentKickoff
        /// o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365OauthConsentKickoff();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365OauthConsentKickoff()
        {
            this._logger.name += " -o365OauthConsentKickoff";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentKickoff",
                "($input: O365OauthConsentKickoffInput!)",
                "O365OauthConsentKickoffReply",
                Mutation.O365OauthConsentKickoff_ObjectFieldSpec,
                Mutation.O365OauthConsentKickoffFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateO365OauthConsentKickoff
}