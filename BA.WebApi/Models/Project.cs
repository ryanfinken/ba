﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BA.WebApi.Converters;
using Newtonsoft.Json;

namespace BA.WebApi.Models {
    public class Project {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        //[JsonConverter(typeof(IsoFlatDateConverter))]
        public DateTime EstimatedStartDate { get; set; }

        public int EstimatedCompletionYear { get; set; }

        //[JsonConverter(typeof(IsoFlatDateConverter))]
        public DateTime? ActualStartDate { get; set; }

        //[JsonConverter(typeof(IsoFlatDateConverter))]
        public DateTime? ActualCompletionDate { get; set; }

        public DateTimeOffset? LastModifiedDateTime { get; set; }
    }
}