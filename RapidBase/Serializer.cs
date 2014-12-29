﻿using Newtonsoft.Json;
using RapidBase.JsonConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBase
{
    public class Serializer
    {
        public static void RegisterFrontConverters(JsonSerializerSettings settings)
        {
            settings.Converters.Add(new BitcoinSerializableJsonConverter());
            settings.Converters.Add(new MoneyJsonConverter());
            settings.Converters.Add(new CoinJsonConverter());
            settings.Converters.Add(new ScriptJsonConverter());
        }
    }
}
