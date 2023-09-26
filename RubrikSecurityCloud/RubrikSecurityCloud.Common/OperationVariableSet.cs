﻿using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using RubrikSecurityCloud.Types;
using System.Linq;

namespace RubrikSecurityCloud
{
    public class SortedCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            return base.CreateProperties(type, memberSerialization).OrderBy(p => p.PropertyName).ToList();
        }
    }

    public class OperationVariableSet
    {
        public IDictionary<string, object>? Variables { get; set; }

        private IRscLogger? _logger = null;
        private readonly JsonSerializerSettings _serializerSettings =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                    new Newtonsoft.Json.Converters.StringEnumConverter(),
                    new GraphQLDateTimeConverter()
                    },
                ContractResolver = new SortedCamelCasePropertyNamesContractResolver()
            };


        public string AsJson(IRscLogger? logger = null)
        {
            JObject variables = processVariables(logger);
            return JsonConvert.SerializeObject(variables, _serializerSettings);

        }

        private JObject processVariables(IRscLogger? logger = null)
        {
            _logger = logger;
            JObject variables = new JObject();
            if (this.Variables == null)
            {
                return variables;
            }

            // Sort the keys of the Variables dictionary
            // so that the output is deterministic
            // (and easier to test)
            var sortedKeys = Variables.Keys.OrderBy(k => k).ToList();

            foreach (var key in sortedKeys)
            {
                logger?.Debug($"Var {key} = " +
                    StringUtils.FormatObjectForLogging(Variables[key]));
                var processedValue = processVariable(Variables[key]);
                variables.Add(key, processedValue);
            }

            return variables;
        }

        private JToken? processVariable(object obj)
        {
            if (obj is null)
            {
                return null;
            }
            if (obj is DateTime dtVal)
            {
                return dtVal.ToString(
                        "yyyy-MM-ddTHH:mm:sszzz",
                        System.Globalization.CultureInfo
                            .InvariantCulture);
            }

            // IConvertible is an interface that many of the
            // built-in simple types (like int, double, bool,
            // string, etc.) implement, and we're using it to
            // identify such scalar types
            if (obj is IConvertible || obj.GetType().IsEnum)
            {
                return JToken.FromObject(
                        obj,
                        JsonSerializer.Create(_serializerSettings)
                );
            }
            if (obj is string[] sarrVal)
            {
                return new JArray(sarrVal);
            }


            if (obj is object[] objArrVal)
            {
                var arr = new JArray();
                foreach (var arrItem in objArrVal)
                {
                    arr.Add(processVariable(arrItem));
                }
                return arr;
            }
            if (obj is VarDict vdObj)
            {
                JObject vdJObject = new JObject();
                foreach (var vdItem in vdObj)
                {
                    vdJObject[vdItem.Key] = processVariable(vdItem.Value);
                }
                return vdJObject;
            }
            // If value is a List<>
            if (obj is ICollection objListVal)
            {
                var arr = new JArray();
                foreach (var listItem in objListVal)
                {
                    arr.Add(processVariable(listItem));
                }
                return arr;
            }

            // default:
            return JObject.FromObject(
                    obj,
                    JsonSerializer.Create(_serializerSettings)
            );
        }
    }
}
