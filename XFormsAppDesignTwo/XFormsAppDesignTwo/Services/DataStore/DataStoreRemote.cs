using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using XFormsAppDesignTwo.Config;

namespace XFormsAppDesignTwo.Services
{
    class DataStoreRemote
    {
        private CancellationTokenSource cts;
        public CancellationTokenSource CancellationTokenSource
        {
            get => cts;
        }

        private HttpClient client = null;
        public HttpClient Client
        {
            get => client;
        }

        protected DataStoreRemote()
        {
            client = new HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(Settings.Current.RequestTimeout);
            client.BaseAddress = new Uri(Settings.Current.URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            cts = new CancellationTokenSource(Settings.Current.RequestTimeout);
        }
    }
}
