// VsphereVmPowerOnOffLiveMountReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region VsphereVmPowerOnOffLiveMountReply
    public class VsphereVmPowerOnOffLiveMountReply: BaseType
    {
        #region members

        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        [JsonProperty("nasIp")]
        public System.String? NasIp { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        [JsonProperty("vmwareVmMountSummaryV1")]
        public VmwareVmMountSummaryV1? VmwareVmMountSummaryV1 { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereVmPowerOnOffLiveMountReply";
    }

    public VsphereVmPowerOnOffLiveMountReply Set(
        System.String? NasIp = null,
        System.String? PowerStatus = null,
        VmwareVmMountSummaryV1? VmwareVmMountSummaryV1 = null
    ) 
    {
        if ( NasIp != null ) {
            this.NasIp = NasIp;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( VmwareVmMountSummaryV1 != null ) {
            this.VmwareVmMountSummaryV1 = VmwareVmMountSummaryV1;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        if (this.NasIp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasIp\n" ;
            } else {
                s += ind + "nasIp\n" ;
            }
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "powerStatus\n" ;
            } else {
                s += ind + "powerStatus\n" ;
            }
        }
        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        if (this.VmwareVmMountSummaryV1 != null) {
            var fspec = this.VmwareVmMountSummaryV1.AsFieldSpec(conf.Child("vmwareVmMountSummaryV1"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareVmMountSummaryV1 {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NasIp
        // GraphQL -> nasIp: String (scalar)
        if (ec.Includes("nasIp",true))
        {
            if(this.NasIp == null) {

                this.NasIp = "FETCH";

            } else {


            }
        }
        else if (this.NasIp != null && ec.Excludes("nasIp",true))
        {
            this.NasIp = null;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (ec.Includes("powerStatus",true))
        {
            if(this.PowerStatus == null) {

                this.PowerStatus = "FETCH";

            } else {


            }
        }
        else if (this.PowerStatus != null && ec.Excludes("powerStatus",true))
        {
            this.PowerStatus = null;
        }
        //      C# -> VmwareVmMountSummaryV1? VmwareVmMountSummaryV1
        // GraphQL -> vmwareVmMountSummaryV1: VmwareVmMountSummaryV1 (type)
        if (ec.Includes("vmwareVmMountSummaryV1",false))
        {
            if(this.VmwareVmMountSummaryV1 == null) {

                this.VmwareVmMountSummaryV1 = new VmwareVmMountSummaryV1();
                this.VmwareVmMountSummaryV1.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmMountSummaryV1"));

            } else {

                this.VmwareVmMountSummaryV1.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmMountSummaryV1"));

            }
        }
        else if (this.VmwareVmMountSummaryV1 != null && ec.Excludes("vmwareVmMountSummaryV1",false))
        {
            this.VmwareVmMountSummaryV1 = null;
        }
    }


    #endregion

    } // class VsphereVmPowerOnOffLiveMountReply
    
    #endregion

    public static class ListVsphereVmPowerOnOffLiveMountReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<VsphereVmPowerOnOffLiveMountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VsphereVmPowerOnOffLiveMountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmPowerOnOffLiveMountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmPowerOnOffLiveMountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereVmPowerOnOffLiveMountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types