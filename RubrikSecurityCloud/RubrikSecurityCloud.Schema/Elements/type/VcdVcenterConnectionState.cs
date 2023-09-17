// VcdVcenterConnectionState.cs
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
    #region VcdVcenterConnectionState
    public class VcdVcenterConnectionState: BaseType
    {
        #region members

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? Status
        // GraphQL -> status: RefreshableObjectConnectionStatus! (type)
        [JsonProperty("status")]
        public RefreshableObjectConnectionStatus? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcdVcenterConnectionState";
    }

    public VcdVcenterConnectionState Set(
        System.String? VcenterId = null,
        RefreshableObjectConnectionStatus? Status = null
    ) 
    {
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        if (this.VcenterId != null) {
            s += ind + "vcenterId\n" ;
        }
        //      C# -> RefreshableObjectConnectionStatus? Status
        // GraphQL -> status: RefreshableObjectConnectionStatus! (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "status {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: UUID! (scalar)
        if (this.VcenterId == null && ec.Includes("vcenterId",true))
        {
            this.VcenterId = "FETCH";
        }
        //      C# -> RefreshableObjectConnectionStatus? Status
        // GraphQL -> status: RefreshableObjectConnectionStatus! (type)
        if (this.Status == null && ec.Includes("status",false))
        {
            this.Status = new RefreshableObjectConnectionStatus();
            this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));
        }
    }


    #endregion

    } // class VcdVcenterConnectionState
    
    #endregion

    public static class ListVcdVcenterConnectionStateExtensions
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
            this List<VcdVcenterConnectionState> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcdVcenterConnectionState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdVcenterConnectionState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcdVcenterConnectionState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types