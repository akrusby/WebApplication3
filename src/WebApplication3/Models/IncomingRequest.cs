using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WebApplication3.Models
{
	[JsonObject]
	public class IncomingRequest
	{
		public string type { get; set; }

		[JsonProperty("object")]
		public NewMessage RequestObject { get; set; }

		public int group_id { get; set; }
	}
}
