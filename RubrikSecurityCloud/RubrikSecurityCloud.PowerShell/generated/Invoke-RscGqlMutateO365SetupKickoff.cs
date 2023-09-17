// Invoke-RscGqlMutateO365SetupKickoff.cs
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
    /// Invoke GraphQL Mutation o365SetupKickoff
    /// o365SetupKickoff: O365SetupKickoffResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateO365SetupKickoff")
    ]
    public class Invoke_RscGqlMutateO365SetupKickoff : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365SetupKickoff");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation o365SetupKickoff
        /// o365SetupKickoff: O365SetupKickoffResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365SetupKickoff();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365SetupKickoff()
        {
            this._logger.name += " -o365SetupKickoff";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SetupKickoff",
                "",
                "O365SetupKickoffResp",
                Mutation.O365SetupKickoff_ObjectFieldSpec,
                Mutation.O365SetupKickoffFieldSpec,
                @""
            );
        }

    } // class Invoke-RscGqlMutateO365SetupKickoff
}