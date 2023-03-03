using System.Net.Http;

namespace Jobs2WinWebApp.Proxy
{
    public interface IRestClient
    {
        public bool UploadFiles(FormFile file);
    }
    public class RestClient : IRestClient
    {
        public readonly HttpClient _httpClient;
        public RestClient()
        {
            _httpClient=new HttpClient();
        }
        public bool UploadFiles(FormFile file)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage() { };
            _httpClient.SendAsync(requestMessage);
        }
        //https://social.msdn.microsoft.com/Forums/en-US/1f142b01-b591-4243-a034-a5e93170b8f4/post-iformfile-from-net-core-mvc-to-web-api-core?forum=aspdotnetcore
    }
}
