﻿using Newtonsoft.Json;

namespace MercadoLibre.Backend.Domain.Models
{
    public class FreeMethodRule
    {
        [JsonProperty(PropertyName = "default")]
        public bool Default { get; set; }

        [JsonProperty(PropertyName = "free_mode")]
        public string FreeMode { get; set; }

        [JsonProperty(PropertyName = "free_shipping_flag")]
        public bool FreeShippingFlag { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}