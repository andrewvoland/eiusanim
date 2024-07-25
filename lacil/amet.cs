public class ApiRequestBuilder : IApiRequestBuilder<ApiRequestBuilder, ApiRequestBuilder>
{
    private string url;
    private Dictionary<string, string> queryParameters = new Dictionary<string, string>();
    private Dictionary<string, string> bodyParameters = new Dictionary<string, string>();

    public IHasUrlBuilder2 WithUrl(string url)
    {
        this.url = url;
        return this;
    }

    public ApiRequestBuilder AddQueryParameter(string name, string value)
    {
        queryParameters[name] = value;
        return this;
    }

    public ApiRequestBuilder AddBodyParameter(string name, string value)
    {
        bodyParameters[name] = value;
        return this;
    }

    public void Build()
    {
        // Here you would build the request with the collected data
        Console.WriteLine($"URL: {url}");
        Console.WriteLine("Query Parameters:");
        foreach (var param in queryParameters)
        {
            Console.WriteLine($"{param.Key}: {param.Value}");
        }
        Console.WriteLine("Body Parameters:");
        foreach (var param in bodyParameters)
        {
            Console.WriteLine($"{param.Key}: {param.Value}");
        }
    }
}
