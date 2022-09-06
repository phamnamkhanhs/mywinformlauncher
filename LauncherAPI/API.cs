using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;

namespace VietLacSo2022
{
    public enum RequestDataType
    {
        None,
        FormUrlEncodedContent,
        StringContent,
        MultiPartFormDataContent
    }

    public sealed class API
    {
        private static readonly object mutex = new object();  
        private static API instance = null;
        public static API Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (mutex)
                        {
                            if (instance == null)
                            {
                                instance = new API();
                            }
                        }
                }
                return instance;
            }
        }
        private static CookieContainer cookieContainer;
        private static HttpClientHandler clienthandler;
        private readonly HttpClient client;

        API() {
            cookieContainer = new CookieContainer();
            clienthandler = new HttpClientHandler {
                AllowAutoRedirect = true,
                UseCookies = true,
                CookieContainer = cookieContainer
            };
            client = new HttpClient(clienthandler);
        }

        public async Task<HttpResponseMessage> MakeRequest(HttpMethod method, string url, IEnumerable<KeyValuePair<string, string>> reqParams, RequestDataType dataType, IEnumerable<KeyValuePair<string, string>> headers, CancellationToken cancellationToken, string attachFilePath)
        {
            var request = new HttpRequestMessage(method, url);
            if (method == HttpMethod.Get)
            {

            } else
            {
                if (dataType == RequestDataType.FormUrlEncodedContent)
                {
                    var content = new FormUrlEncodedContent(reqParams);
                    request.Content = content;
                } else if (dataType == RequestDataType.StringContent)
                {
                    var content = new StringContent(JsonConvert.SerializeObject(reqParams), Encoding.UTF8, "application/json");
                    request.Content = content;
                } else if (dataType == RequestDataType.MultiPartFormDataContent)
                {
                    var content = new MultipartFormDataContent();
                    if (!string.IsNullOrEmpty(attachFilePath) && File.Exists(attachFilePath))
                    {
                        Stream stream = File.OpenRead(attachFilePath);
                        content.Add(new StreamContent(stream), "file", Path.GetFileName(attachFilePath));
                    }
                    if (reqParams != null && reqParams.)
                } else
                {

                }
            }
            var response = await client.SendAsync(request, cancellationToken);
            return response;
        }
    }
}
