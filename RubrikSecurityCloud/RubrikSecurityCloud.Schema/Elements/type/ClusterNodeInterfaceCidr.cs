// ClusterNodeInterfaceCidr.cs
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
    #region ClusterNodeInterfaceCidr
    public class ClusterNodeInterfaceCidr: BaseType
    {
        #region members

        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        [JsonProperty("cidr")]
        public System.String? Cidr { get; set; }

        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        [JsonProperty("interfaceName")]
        public System.String? InterfaceName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterNodeInterfaceCidr";
    }

    public ClusterNodeInterfaceCidr Set(
        System.String? Cidr = null,
        System.String? InterfaceName = null
    ) 
    {
        if ( Cidr != null ) {
            this.Cidr = Cidr;
        }
        if ( InterfaceName != null ) {
            this.InterfaceName = InterfaceName;
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
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (this.Cidr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cidr\n" ;
            } else {
                s += ind + "cidr\n" ;
            }
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (this.InterfaceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interfaceName\n" ;
            } else {
                s += ind + "interfaceName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Cidr
        // GraphQL -> cidr: String! (scalar)
        if (ec.Includes("cidr",true))
        {
            if(this.Cidr == null) {

                this.Cidr = "FETCH";

            } else {


            }
        }
        else if (this.Cidr != null && ec.Excludes("cidr",true))
        {
            this.Cidr = null;
        }
        //      C# -> System.String? InterfaceName
        // GraphQL -> interfaceName: String! (scalar)
        if (ec.Includes("interfaceName",true))
        {
            if(this.InterfaceName == null) {

                this.InterfaceName = "FETCH";

            } else {


            }
        }
        else if (this.InterfaceName != null && ec.Excludes("interfaceName",true))
        {
            this.InterfaceName = null;
        }
    }


    #endregion

    } // class ClusterNodeInterfaceCidr
    
    #endregion

    public static class ListClusterNodeInterfaceCidrExtensions
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
            this List<ClusterNodeInterfaceCidr> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNodeInterfaceCidr> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNodeInterfaceCidr());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterNodeInterfaceCidr> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types