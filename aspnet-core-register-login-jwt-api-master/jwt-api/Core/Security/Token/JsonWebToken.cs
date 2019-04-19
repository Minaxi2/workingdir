using System;

namespace jwt_api.Core.Security.Token
{
    public abstract class JsonWebToken
    {
        public string Token { get; set; }
        public long Expiration { get; set; }

        public JsonWebToken(string token, long expiration)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException("Invalid Token");

            if (expiration <= 0) throw new ArgumentException("Invalid expiration");

            Token = token;
            Expiration = expiration;
        }

        public bool IsExpired() => DateTime.UtcNow.Ticks > Expiration;
    }
}