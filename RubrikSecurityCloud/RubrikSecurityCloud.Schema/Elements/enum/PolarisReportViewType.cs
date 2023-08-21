// PolarisReportViewType.cs
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
    public enum PolarisReportViewType
    {
        [EnumMember(Value = "COMPLIANCE_REPORT")]
        COMPLIANCE_REPORT,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_REPORT")]
        OBJECT_CAPACITY_OVERTIME_REPORT,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_REPORT")]
        PROTECTION_TASKS_DETAIL_REPORT,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_REPORT")]
        RECOVERY_TASKS_DETAIL_REPORT,

        [EnumMember(Value = "REPORT_UNSPECIFIED")]
        REPORT_UNSPECIFIED,

        [EnumMember(Value = "THREAT_MONITORING_REPORT")]
        THREAT_MONITORING_REPORT


    } // enum PolarisReportViewType

} // namespace RubrikSecurityCloud.Types