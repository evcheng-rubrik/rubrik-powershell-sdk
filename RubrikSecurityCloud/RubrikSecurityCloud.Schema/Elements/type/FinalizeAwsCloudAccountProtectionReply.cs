// FinalizeAwsCloudAccountProtectionReply.cs
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
    #region FinalizeAwsCloudAccountProtectionReply
    public class FinalizeAwsCloudAccountProtectionReply: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> List<AwsCloudAccount>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccount!]! (type)
        [JsonProperty("awsChildAccounts")]
        public List<AwsCloudAccount>? AwsChildAccounts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FinalizeAwsCloudAccountProtectionReply";
    }

    public FinalizeAwsCloudAccountProtectionReply Set(
        System.String? Message = null,
        List<AwsCloudAccount>? AwsChildAccounts = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( AwsChildAccounts != null ) {
            this.AwsChildAccounts = AwsChildAccounts;
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
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> List<AwsCloudAccount>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccount!]! (type)
        if (this.AwsChildAccounts != null) {
            var fspec = this.AwsChildAccounts.AsFieldSpec(conf.Child("awsChildAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsChildAccounts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> List<AwsCloudAccount>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccount!]! (type)
        if (ec.Includes("awsChildAccounts",false))
        {
            if(this.AwsChildAccounts == null) {

                this.AwsChildAccounts = new List<AwsCloudAccount>();
                this.AwsChildAccounts.ApplyExploratoryFieldSpec(ec.NewChild("awsChildAccounts"));

            } else {

                this.AwsChildAccounts.ApplyExploratoryFieldSpec(ec.NewChild("awsChildAccounts"));

            }
        }
        else if (this.AwsChildAccounts != null && ec.Excludes("awsChildAccounts",false))
        {
            this.AwsChildAccounts = null;
        }
    }


    #endregion

    } // class FinalizeAwsCloudAccountProtectionReply
    
    #endregion

    public static class ListFinalizeAwsCloudAccountProtectionReplyExtensions
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
            this List<FinalizeAwsCloudAccountProtectionReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FinalizeAwsCloudAccountProtectionReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FinalizeAwsCloudAccountProtectionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FinalizeAwsCloudAccountProtectionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types