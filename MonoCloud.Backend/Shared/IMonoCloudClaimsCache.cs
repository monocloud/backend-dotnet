namespace MonoCloud.Backend.Shared;

/// <summary>
/// Defines an abstract interface for a claims cache mechanism.
/// This interface is intended to be used to temporarily store and retrieve user
/// claims.
/// </summary>
/// <remarks>
/// Implementations must be registered in the service collection with a <b>singleton</b> lifetime.
/// </remarks>
public interface IMonoCloudClaimsCache
{
  /// <summary>
  /// Asynchronously retrieves a cached value based on the provided key.
  /// </summary>
  /// <param name="key">The unique key used to identify the cached item.</param>
  /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
  /// <returns>A task that represents the asynchronous get operation. The task result is the cached string value, or <c>null</c> if the key is not found.</returns>
  Task<string?> GetAsync(string key, CancellationToken cancellationToken);

  /// <summary>
  /// Asynchronously stores a key-value pair in the cache with a specified expiration time.
  /// </summary>
  /// <param name="key">The unique key for the item to be cached.</param>
  /// <param name="value">The string value to cache.</param>
  /// <param name="expiresIn">The duration after which the cached item should expire.</param>
  /// <param name="cancellationToken">A <see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
  /// <returns>A task that represents the asynchronous set operation.</returns>
  Task SetAsync(string key, string value, TimeSpan expiresIn, CancellationToken cancellationToken);
}
