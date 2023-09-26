// ValidateAndCreateAwsCloudAccountReply.cs
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
    #region ValidateAndCreateAwsCloudAccountReply
    public class ValidateAndCreateAwsCloudAccountReply: BaseType
    {
        #region members

        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        [JsonProperty("initiateResponse")]
        public AwsCloudAccountCreateResponse? InitiateResponse { get; set; }

        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        [JsonProperty("validateResponse")]
        public AwsCloudAccountValidateResponse? ValidateResponse { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateAndCreateAwsCloudAccountReply";
    }

    public ValidateAndCreateAwsCloudAccountReply Set(
        AwsCloudAccountCreateResponse? InitiateResponse = null,
        AwsCloudAccountValidateResponse? ValidateResponse = null
    ) 
    {
        if ( InitiateResponse != null ) {
            this.InitiateResponse = InitiateResponse;
        }
        if ( ValidateResponse != null ) {
            this.ValidateResponse = ValidateResponse;
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
        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        if (this.InitiateResponse != null) {
            var fspec = this.InitiateResponse.AsFieldSpec(conf.Child("initiateResponse"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "initiateResponse {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        if (this.ValidateResponse != null) {
            var fspec = this.ValidateResponse.AsFieldSpec(conf.Child("validateResponse"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "validateResponse {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudAccountCreateResponse? InitiateResponse
        // GraphQL -> initiateResponse: AwsCloudAccountCreateResponse (type)
        if (ec.Includes("initiateResponse",false))
        {
            if(this.InitiateResponse == null) {

                this.InitiateResponse = new AwsCloudAccountCreateResponse();
                this.InitiateResponse.ApplyExploratoryFieldSpec(ec.NewChild("initiateResponse"));

            } else {

                this.InitiateResponse.ApplyExploratoryFieldSpec(ec.NewChild("initiateResponse"));

            }
        }
        else if (this.InitiateResponse != null && ec.Excludes("initiateResponse",false))
        {
            this.InitiateResponse = null;
        }
        //      C# -> AwsCloudAccountValidateResponse? ValidateResponse
        // GraphQL -> validateResponse: AwsCloudAccountValidateResponse (type)
        if (ec.Includes("validateResponse",false))
        {
            if(this.ValidateResponse == null) {

                this.ValidateResponse = new AwsCloudAccountValidateResponse();
                this.ValidateResponse.ApplyExploratoryFieldSpec(ec.NewChild("validateResponse"));

            } else {

                this.ValidateResponse.ApplyExploratoryFieldSpec(ec.NewChild("validateResponse"));

            }
        }
        else if (this.ValidateResponse != null && ec.Excludes("validateResponse",false))
        {
            this.ValidateResponse = null;
        }
    }


    #endregion

    } // class ValidateAndCreateAwsCloudAccountReply
    
    #endregion

    public static class ListValidateAndCreateAwsCloudAccountReplyExtensions
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
            this List<ValidateAndCreateAwsCloudAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateAndCreateAwsCloudAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateAndCreateAwsCloudAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateAndCreateAwsCloudAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types