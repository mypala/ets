using Newtonsoft.Json;
using ResponseStates.Enums;
using ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebUI.Models;
using WebUI.MWAccess.Abstract;

namespace WebUI.MWAccess.Concrete
{
    public class MWClient : IMWClient
    {
        public HttpClient _client { get; private set; }

        public MWClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:44303");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _client = httpClient;
        }

        public ResponseState<TResponse> GetJSON<TResponse>(Connection connection)
        {
            var url = !string.IsNullOrWhiteSpace(connection.Controller) ? $"/{connection.Controller}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.Action) ? $"/{connection.Action}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.Query) ? $"/{connection.Query}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.QueryString) ? $"?{connection.QueryString}" : string.Empty;

            return JsonConvert.DeserializeObject<ResponseState<TResponse>>(_client.GetStringAsync($"{url}").Result);
        }

        public ResponseState PostJSON<TRequest>(Connection<TRequest> connection)
        {
            var url = !string.IsNullOrWhiteSpace(connection.Controller) ? $"/{connection.Controller}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.Action) ? $"/{connection.Action}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.Query) ? $"/{connection.Query}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.QueryString) ? $"?{connection.QueryString}" : string.Empty;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(connection.Model), Encoding.UTF8, "application/json");

            HttpResponseMessage response = _client.PostAsync($"{url}", httpContent).Result;

            if (!response.IsSuccessStatusCode)
            {
                return new ResponseState(StateCode.Error);
            }

            return JsonConvert.DeserializeObject<ResponseState>(response.Content.ReadAsStringAsync().Result);
        }

        public ResponseState<TResponse> PostJSON<TResponse, TRequest>(Connection<TRequest> connection)
        {
            var url = !string.IsNullOrWhiteSpace(connection.Controller) ? $"/{connection.Controller}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.Action) ? $"/{connection.Action}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.Query) ? $"/{connection.Query}" : string.Empty;
            url += !string.IsNullOrWhiteSpace(connection.QueryString) ? $"?{connection.QueryString}" : string.Empty;

            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(connection.Model), Encoding.UTF8, "application/json");

            HttpResponseMessage response = _client.PostAsync($"{url}", httpContent).Result;

            if (!response.IsSuccessStatusCode)
            {
                return new ResponseState<TResponse>(StateCode.Error);
            }

            return JsonConvert.DeserializeObject<ResponseState<TResponse>>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
