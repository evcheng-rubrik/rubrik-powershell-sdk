// GetS3BucketStateForRecoveryReply.cs
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
    #region GetS3BucketStateForRecoveryReply
    public class GetS3BucketStateForRecoveryReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsObjectAclEnabled
        // GraphQL -> isObjectAclEnabled: Boolean! (scalar)
        [JsonProperty("isObjectAclEnabled")]
        public System.Boolean? IsObjectAclEnabled { get; set; }

        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        [JsonProperty("isVersioningEnabled")]
        public System.Boolean? IsVersioningEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetS3BucketStateForRecoveryReply";
    }

    public GetS3BucketStateForRecoveryReply Set(
        System.Boolean? IsObjectAclEnabled = null,
        System.Boolean? IsVersioningEnabled = null
    ) 
    {
        if ( IsObjectAclEnabled != null ) {
            this.IsObjectAclEnabled = IsObjectAclEnabled;
        }
        if ( IsVersioningEnabled != null ) {
            this.IsVersioningEnabled = IsVersioningEnabled;
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
        //      C# -> System.Boolean? IsObjectAclEnabled
        // GraphQL -> isObjectAclEnabled: Boolean! (scalar)
        if (this.IsObjectAclEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isObjectAclEnabled\n" ;
            } else {
                s += ind + "isObjectAclEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (this.IsVersioningEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVersioningEnabled\n" ;
            } else {
                s += ind + "isVersioningEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsObjectAclEnabled
        // GraphQL -> isObjectAclEnabled: Boolean! (scalar)
        if (ec.Includes("isObjectAclEnabled",true))
        {
            if(this.IsObjectAclEnabled == null) {

                this.IsObjectAclEnabled = true;

            } else {


            }
        }
        else if (this.IsObjectAclEnabled != null && ec.Excludes("isObjectAclEnabled",true))
        {
            this.IsObjectAclEnabled = null;
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (ec.Includes("isVersioningEnabled",true))
        {
            if(this.IsVersioningEnabled == null) {

                this.IsVersioningEnabled = true;

            } else {


            }
        }
        else if (this.IsVersioningEnabled != null && ec.Excludes("isVersioningEnabled",true))
        {
            this.IsVersioningEnabled = null;
        }
    }


    #endregion

    } // class GetS3BucketStateForRecoveryReply
    
    #endregion

    public static class ListGetS3BucketStateForRecoveryReplyExtensions
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
            this List<GetS3BucketStateForRecoveryReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetS3BucketStateForRecoveryReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetS3BucketStateForRecoveryReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetS3BucketStateForRecoveryReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types