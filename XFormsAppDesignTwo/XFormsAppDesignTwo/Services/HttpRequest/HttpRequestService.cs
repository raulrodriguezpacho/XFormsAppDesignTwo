using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XFormsAppDesignTwo.Services
{
    class HttpRequestService<T, D> : IHttpRequestService<T, D> where T : class where D : class
    {
        private Type typeT;
        private Type typeD;
        private HttpClient client = null;
        private CancellationTokenSource cts;

        public T Item { get; private set; }
        public D Response { get; private set; }

        public void Dispose() { cts = null; }

        public HttpRequestService()
        {
            try
            {
                typeT = typeof(T);
                typeD = typeof(D);
            }
            catch { }
            Initialize();
        }

        private void Initialize()
        {
            client = new HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(Config.Settings.Current.RequestTimeout);
            client.BaseAddress = new Uri(Config.Settings.Current.URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<D> MakeRequest(T item)
        {
            if (client == null)
                return default(D);

            D result = default(D);
            string stringResponse = string.Empty;
            HttpResponseMessage response = null;
            string urlItemSegment = string.Empty;

            try
            {
                if (cts == null)
                    cts = new CancellationTokenSource();
                //cts = new CancellationTokenSource(Config.Settings.Current.RequestTimeout);
                cts.CancelAfter(Config.Settings.Current.RequestTimeout);

                response = await client.GetAsync(item.ToString(), cts.Token);
                if (response.IsSuccessStatusCode)
                {
                    stringResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<D>(stringResponse);
                }
                else
                {
                    stringResponse = await response.Content.ReadAsStringAsync();
                }
            }
            catch (OperationCanceledException ex)
            {

            }
            catch (Exception ex)
            {
                //throw;
            }
            finally
            {
                cts = null;
            }
            return result;
        }
    }
}
