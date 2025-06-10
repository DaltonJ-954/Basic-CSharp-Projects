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
            List<LocationDto> response = [];

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


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {

            var client = httpClientFactory.CreateClient();

            var response = await client.GetFromJsonAsync<LocationDto>($"https://localhost:7189/api/locations/{id}");
            
            if (response is not null)
            {
                return View(response);
            }

            return View(null);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(LocationDto request)
        {
            var client = httpClientFactory.CreateClient();

            var httpRequestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"https://localhost:7189/api/locations/{request.Id}"),
                Content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json")
            };

            var httpResponseMessage = await client.SendAsync(httpRequestMessage);
            httpResponseMessage.EnsureSuccessStatusCode();

            var response = await httpResponseMessage.Content.ReadFromJsonAsync<LocationDto>();

            if (response is not null)
            {
                return RedirectToAction("Edit", "Locations");
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Delete(LocationDto request)
        {
            try
            {
                var client = httpClientFactory.CreateClient();

                var httpResponseMessage = await client.DeleteAsync($"https://localhost:7189/api/locations/{request.Id}");

                httpResponseMessage.EnsureSuccessStatusCode();

                return RedirectToAction("Index", "Locations");
            }
            catch (Exception ex)
            {
                // Console
            }

            return View("Edit");
        }
    }
}
