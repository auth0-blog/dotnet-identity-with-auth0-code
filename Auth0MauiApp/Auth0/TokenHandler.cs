using System.Net.Http.Headers;

namespace Auth0MauiApp.Auth0;

public class TokenHandler : DelegatingHandler
{
  protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
  {
    request.Headers.Authorization =
        new AuthenticationHeaderValue("Bearer", TokenHolder.AccessToken);
    return await base.SendAsync(request, cancellationToken);
  }
}