// ErrorInfo.cs
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
    #region ErrorInfo
    public class ErrorInfo: BaseType
    {
        #region members

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        [JsonProperty("statusCode")]
        public System.Int32? StatusCode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ErrorInfo";
    }

    public ErrorInfo Set(
        System.String? ErrorMessage = null,
        System.Int32? StatusCode = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( StatusCode != null ) {
            this.StatusCode = StatusCode;
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
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        if (this.StatusCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusCode\n" ;
            } else {
                s += ind + "statusCode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        if (ec.Includes("statusCode",true))
        {
            if(this.StatusCode == null) {

                this.StatusCode = Int32.MinValue;

            } else {


            }
        }
        else if (this.StatusCode != null && ec.Excludes("statusCode",true))
        {
            this.StatusCode = null;
        }
    }


    #endregion

    } // class ErrorInfo
    
    #endregion

    public static class ListErrorInfoExtensions
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
            this List<ErrorInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ErrorInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ErrorInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ErrorInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types