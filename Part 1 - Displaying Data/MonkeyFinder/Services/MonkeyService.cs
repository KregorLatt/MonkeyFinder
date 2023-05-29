using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{

HttpClient httpClient;
public MonkeyService()
{
    this.httpClient = new HttpClient();
}
}