using DE.Rheinfabrik.Heimdall;

namespace Sample.Models.OAuth
{
    public class SampleOAuthAccessTokenManager : OAuth2AccessTokenManager
    {
        public SampleOAuthAccessTokenManager(IOAuth2AccessTokenStorage p0) : base(p0)
        {
        }
    }
}