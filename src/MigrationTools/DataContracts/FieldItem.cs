﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MigrationTools.DataContracts
{
    public class FieldItem
    {
        [JsonIgnore]
        public object internalObject { get; set; }

        public string ReferenceName { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
    }
}