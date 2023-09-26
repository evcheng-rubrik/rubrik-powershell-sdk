// OracleLogBackupConfig.cs
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
    #region OracleLogBackupConfig
    public class OracleLogBackupConfig: BaseType
    {
        #region members

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        [JsonProperty("logBackupFrequencyMin")]
        public System.Int32? LogBackupFrequencyMin { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleLogBackupConfig";
    }

    public OracleLogBackupConfig Set(
        System.Int32? HostLogRetentionHours = null,
        System.Int32? LogBackupFrequencyMin = null,
        System.Int32? LogRetentionHours = null
    ) 
    {
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( LogBackupFrequencyMin != null ) {
            this.LogBackupFrequencyMin = LogBackupFrequencyMin;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
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
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        if (this.HostLogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetentionHours\n" ;
            } else {
                s += ind + "hostLogRetentionHours\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        if (this.LogBackupFrequencyMin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyMin\n" ;
            } else {
                s += ind + "logBackupFrequencyMin\n" ;
            }
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logRetentionHours\n" ;
            } else {
                s += ind + "logRetentionHours\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        if (ec.Includes("hostLogRetentionHours",true))
        {
            if(this.HostLogRetentionHours == null) {

                this.HostLogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostLogRetentionHours != null && ec.Excludes("hostLogRetentionHours",true))
        {
            this.HostLogRetentionHours = null;
        }
        //      C# -> System.Int32? LogBackupFrequencyMin
        // GraphQL -> logBackupFrequencyMin: Int! (scalar)
        if (ec.Includes("logBackupFrequencyMin",true))
        {
            if(this.LogBackupFrequencyMin == null) {

                this.LogBackupFrequencyMin = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequencyMin != null && ec.Excludes("logBackupFrequencyMin",true))
        {
            this.LogBackupFrequencyMin = null;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (ec.Includes("logRetentionHours",true))
        {
            if(this.LogRetentionHours == null) {

                this.LogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogRetentionHours != null && ec.Excludes("logRetentionHours",true))
        {
            this.LogRetentionHours = null;
        }
    }


    #endregion

    } // class OracleLogBackupConfig
    
    #endregion

    public static class ListOracleLogBackupConfigExtensions
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
            this List<OracleLogBackupConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleLogBackupConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleLogBackupConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleLogBackupConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types