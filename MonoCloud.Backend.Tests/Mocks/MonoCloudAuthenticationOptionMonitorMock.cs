namespace MonoCloud.Backend.Tests.Mocks;

/// <summary>
/// Minimal <see cref="IOptionsMonitor{TOptions}"/> that always returns the supplied options instance,
/// regardless of the requested scheme name. Used to drive <see cref="MonoCloudAuthenticationHandler"/> in tests.
/// </summary>
public class MonoCloudAuthenticationOptionMonitorMock(MonoCloudAuthenticationOptions options)
    : IOptionsMonitor<MonoCloudAuthenticationOptions>
{
  public MonoCloudAuthenticationOptions Get(string? name) => options;

  public IDisposable? OnChange(Action<MonoCloudAuthenticationOptions, string?> listener) => null;

  public MonoCloudAuthenticationOptions CurrentValue => options;
}
