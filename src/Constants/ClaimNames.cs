namespace Delobytes.AspNetCore.Common.Constants
{
    public static class ClaimNames
    {
#pragma warning disable IDE1006 // JWT-стандарт использует нижний регистр
        // https://datatracker.ietf.org/doc/html/rfc7519
        public const string iss = nameof(iss);
        public const string sub = nameof(sub);
        public const string aud = nameof(aud);
        public const string exp = nameof(exp);
        public const string nbf = nameof(nbf);
        public const string iat = nameof(iat);
        public const string jti = nameof(jti);
        // https://openid.net/specs/openid-connect-core-1_0.html#StandardClaims
        public const string name = nameof(name);
        public const string given_name = nameof(given_name);
        public const string family_name = nameof(family_name);
        public const string nickname = nameof(nickname);
        public const string profile = nameof(profile);
        public const string picture = nameof(picture);

        public const string cid = nameof(cid);
        public const string uid = nameof(uid);
        public const string tid = nameof(tid);
        public const string email = nameof(email);
        public const string email_verified = nameof(email_verified);
        public const string username = nameof(username);
        public const string role = nameof(role);
        public const string externalId = nameof(externalId);
        public const string azp = nameof(azp);
        public const string tenantaccesstype = nameof(tenantaccesstype);
#pragma warning restore IDE1006 // Naming Styles
    }
}
