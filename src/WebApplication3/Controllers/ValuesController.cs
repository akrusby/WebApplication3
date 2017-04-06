using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using WebApplication3.Models;
using System.Net.Http;

namespace WebApplication3.Controllers
{
	[Route("api/[controller]")]
	public class ValuesController : Controller
	{
		// GET api/values
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public IActionResult Post([FromBody] IncomingRequest value)
		{
			var client = new HttpClient();
			var response = client.PostAsync(@"https://api.vk.com/method/messages.send?message=" + 
				"Ты сказал " + 
				value.RequestObject.Body +
				"&user_id=" +
				value.RequestObject.UserId +
				"&access_token=39ce2d2a6c3a8881f2ee610404213b2f560582cd8add52fa3e8ba7dd7770a942f191ac45b7d24b5bf6d37" +
				"&v=5.0", null);

			var responseString = response.Result.Content.ReadAsStringAsync();

			return new OkObjectResult("ok");
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
