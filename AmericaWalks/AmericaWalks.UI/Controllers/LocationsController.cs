using AmericaWalks.UI.Models;
using AmericaWalks.UI.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace AmericaWalks.UI.Controllers
{
    public class LocationsController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public LocationsController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<LocationDto> response = new List<LocationDto>();

            try
            {
                // Get All Locations from Web API
                var client = httpClientFactory.CreateClient();

                var httpResponseMessage = await client.GetAsync("https://localhost:7189/api/locations");

                httpResponseMessage.EnsureSuccessStatusCode();

                response.AddRange(await httpResponseMessage.Content.ReadFromJsonAsync<IEnumerable<LocationDto>>());
            }
            catch (Exception ex)
            {
                // Log the exception
            }

            return View(response);
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddLocationViewModel model)
        {
            var client = httpClientFactory.CreateClient();

            var httpRequestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:7189/api/locations"),
                Content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json")
            };

            var httpResponseMessage =  await client.SendAsync(httpRequestMessage);
            httpResponseMessage.EnsureSuccessStatusCode();

            var response = await httpResponseMessage.Content.ReadFromJsonAsync<LocationDto>();

            if (response is not null)
            {
                return RedirectToAction("Index", "Locations");
            }

            return View();
        }
    }
}
