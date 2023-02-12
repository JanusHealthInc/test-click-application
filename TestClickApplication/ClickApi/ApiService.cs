using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace TestClickApplication.ClickApi
{
    class ClickPost
    {
        public uint click_count
        {
            get; set;
        }
    }

    class ClickGet
    {
        public uint click_count
        {
            get; set;
        }
    }

    /// <summary>
    /// Simple Api Service for talking to our server that monitors user clicks.
    /// </summary>
    public class ApiService
    {
        private string host = "http://localhost:3000";
        public ApiService() { }

        public async Task SendClicksAsync()
        {
            // TODO: add your clicks here
            using (HttpClient client = new())
            {
                ClickPost payload = new ClickPost { click_count = 1 };
                await client.PostAsJsonAsync($"{host}/user/clicks", payload);
            }
        }

        public async Task<uint> GetClicksAsync()
        {
            // TODO: add your clicks here
            using (HttpClient client = new())
            {
                var payload = await client.GetFromJsonAsync<ClickGet>($"{host}/user/clicks");
                if (payload == null)
                {
                    throw new Exception("Could not get a payload from endpoint!");
                }
                return payload.click_count;
            }
        }
    }
}
