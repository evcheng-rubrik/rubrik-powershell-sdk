// AwsImmutabilitySettingsType.cs
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
    #region AwsImmutabilitySettingsType
    public class AwsImmutabilitySettingsType: BaseType
    {
        #region members

        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        [JsonProperty("lockDurationDays")]
        public System.Int32? LockDurationDays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsImmutabilitySettingsType";
    }

    public AwsImmutabilitySettingsType Set(
        System.Int32? LockDurationDays = null
    ) 
    {
        if ( LockDurationDays != null ) {
            this.LockDurationDays = LockDurationDays;
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
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays != null) {
            s += ind + "lockDurationDays\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? LockDurationDays
        // GraphQL -> lockDurationDays: Int! (scalar)
        if (this.LockDurationDays == null && ec.Includes("lockDurationDays",true))
        {
            this.LockDurationDays = Int32.MinValue;
        }
    }


    #endregion

    } // class AwsImmutabilitySettingsType
    
    #endregion

    public static class ListAwsImmutabilitySettingsTypeExtensions
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
            this List<AwsImmutabilitySettingsType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsImmutabilitySettingsType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsImmutabilitySettingsType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsImmutabilitySettingsType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types