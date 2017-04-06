using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WebApplication3.Models
{
	[JsonObject]
	public class NewMessage
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("user_id")]
		public int UserId { get; set; }

		[JsonProperty("from_id")]
		public int FromId { get; set; }

		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("read_state")]
		public int ReadState { get; set; }

		[JsonProperty("out")]
		public int Out { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("body")]
		public string Body { get; set; }
	}
}
