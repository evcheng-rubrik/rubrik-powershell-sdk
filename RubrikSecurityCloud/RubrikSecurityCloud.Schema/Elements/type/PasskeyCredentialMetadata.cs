// PasskeyCredentialMetadata.cs
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
    #region PasskeyCredentialMetadata
    public class PasskeyCredentialMetadata: BaseType
    {
        #region members

        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        [JsonProperty("credentialId")]
        public System.String? CredentialId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PasskeyCredentialMetadata";
    }

    public PasskeyCredentialMetadata Set(
        System.String? CredentialId = null
    ) 
    {
        if ( CredentialId != null ) {
            this.CredentialId = CredentialId;
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
        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        if (this.CredentialId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "credentialId\n" ;
            } else {
                s += ind + "credentialId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CredentialId
        // GraphQL -> credentialId: String! (scalar)
        if (ec.Includes("credentialId",true))
        {
            if(this.CredentialId == null) {

                this.CredentialId = "FETCH";

            } else {


            }
        }
        else if (this.CredentialId != null && ec.Excludes("credentialId",true))
        {
            this.CredentialId = null;
        }
    }


    #endregion

    } // class PasskeyCredentialMetadata
    
    #endregion

    public static class ListPasskeyCredentialMetadataExtensions
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
            this List<PasskeyCredentialMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PasskeyCredentialMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PasskeyCredentialMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PasskeyCredentialMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PasskeyCredentialMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types