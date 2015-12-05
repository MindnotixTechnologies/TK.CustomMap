﻿using Newtonsoft.Json;

namespace TK.CustomMap.Api.Google
{
    /// <summary>
    /// Prediction result of the Google Place API call
    /// </summary>
    public struct GmsPlacePrediction
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}