using System;
using Newtonsoft.Json;

namespace reCAPTCHA.AspNetCore
{
    public class RecaptchaResponse
    {
        public bool Success { get; set; }
        public decimal Score { get; set; }
        public string Action { get; set; }
        [JsonProperty("challenge_ts")]
        public DateTime ChallengeTs { get; set; }
        public string Hostname { get; set; }
    }
}
