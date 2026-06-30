namespace MonoCloud.Backend.Tests.Mocks;

public class HttpClientFactoryMock : IHttpClientFactory
{
  public HttpClient CreateClient(string name)
  {
    return new HttpClient();
  }
}
