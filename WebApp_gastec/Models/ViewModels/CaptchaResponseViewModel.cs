using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_gastec.Models
{
    public class CaptchaResponseViewModel
    {
        public bool Success { get; set; }
        [JsonProperty(propertyName: "error-codes")]
        public IEnumerable<string> ErrorCodes { get; set; }
        [JsonProperty(propertyName: "challenge-ts")]
        public DateTime ChallengeTime { get; set; }
        public string HostName { get; set; }
        public double Score { get; set; }
        public string Action { get; set; }

    }
}
