using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JJDirectLineClient.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace JJDirectLineClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<DLSModel> dlSecret;

        public HomeController(IOptions<DLSModel> dls)
        {
            dlSecret = dls;
        }
        public async Task<ActionResult> Index()
        {
            var secret = dlSecret.Value.DirectLineSecret;
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(
              HttpMethod.Post,
              $" https://directline.botframework.com/v3/directline/tokens/generate");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", secret);
            var userId = $"dl_{Guid.NewGuid()}";
            request.Content = new StringContent(
            JsonConvert.SerializeObject(
                new { User = new { Id = userId } }),
                Encoding.UTF8,
                "application/json");
            var response = await client.SendAsync(request);
            string token = String.Empty;
            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                token = JsonConvert.DeserializeObject<DirectLineToken>(body).token;
            }
            var config = new ChatConfig()
            {
                Token = token,
                UserId = userId
            };
            return View(config);
        }
    }
}
