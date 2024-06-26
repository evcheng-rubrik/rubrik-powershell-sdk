// ClusterDiskStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum ClusterDiskStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "LOCKED")]
        LOCKED,

        [EnumMember(Value = "MISSING")]
        MISSING,

        [EnumMember(Value = "PRE_REMOVAL")]
        PRE_REMOVAL,

        [EnumMember(Value = "PRE_REPAIR")]
        PRE_REPAIR,

        [EnumMember(Value = "READY_TO_REMOVE")]
        READY_TO_REMOVE,

        [EnumMember(Value = "REMOVED")]
        REMOVED,

        [EnumMember(Value = "REPAIR")]
        REPAIR,

        [EnumMember(Value = "UNFORMATTED")]
        UNFORMATTED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterDiskStatus

} // namespace RubrikSecurityCloud.Types