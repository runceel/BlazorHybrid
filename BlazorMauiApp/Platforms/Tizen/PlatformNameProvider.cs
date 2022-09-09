using BlazorShared;

namespace BlazorMauiApp;

public class PlatformNameProvider : IPlatformNameProvider
{
    public string GetPlatformName() => "Tizen";
}
