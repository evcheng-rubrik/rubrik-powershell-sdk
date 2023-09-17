// ValueLong.cs
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
    #region ValueLong
 
    public class ValueLong: BaseType, Value
    {
        #region members

        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        [JsonProperty("serializedValue")]
        public System.String? SerializedValue { get; set; }

        //      C# -> System.Int64? Value
        // GraphQL -> value: Long (scalar)
        [JsonProperty("value")]
        public System.Int64? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValueLong";
    }

    public ValueLong Set(
        System.String? SerializedValue = null,
        System.Int64? Value = null
    ) 
    {
        if ( SerializedValue != null ) {
            this.SerializedValue = SerializedValue;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue != null) {
            s += ind + "serializedValue\n" ;
        }
        //      C# -> System.Int64? Value
        // GraphQL -> value: Long (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue == null && ec.Includes("serializedValue",true))
        {
            this.SerializedValue = "FETCH";
        }
        //      C# -> System.Int64? Value
        // GraphQL -> value: Long (scalar)
        if (this.Value == null && ec.Includes("value",true))
        {
            this.Value = new System.Int64();
        }
    }


    #endregion

    } // class ValueLong
    
    #endregion

    public static class ListValueLongExtensions
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
            this List<ValueLong> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValueLong> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValueLong());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValueLong> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types