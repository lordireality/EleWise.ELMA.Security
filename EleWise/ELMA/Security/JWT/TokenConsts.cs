// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.TokenConsts
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

namespace EleWise.ELMA.Security.JWT
{
  /// <summary>Константы свзяанные с JWT токенами</summary>
  internal static class TokenConsts
  {
    /// <summary>Имя региона в кеше для токенов обновления авторизации</summary>
    public const string RefreshTokensCacheRegion = "RefreshTokens";
    /// <summary>
    /// Имя ключа настройки для времени жизни токена обновления авторизации
    /// </summary>
    public const string RefreshTokenLifetimeKey = "RefreshToken.Lifetime";
    /// <summary>
    /// Имя ключа payload токена с идентификатором токена обновления авторизации
    /// </summary>
    public const string RefreshTokenUidClaim = "rtUid";
    /// <summary>
    /// Имя ключа настройки для времени жизни токена авторизации
    /// </summary>
    public const string JwtAuthTokenLifetimeKey = "JwtAuthToken.Lifetime";
    /// <summary>
    /// Имя ключа payload токена с идентификатором пользователя
    /// </summary>
    public const string JwtTokenUserIdClaim = "userId";
    /// <summary>Имя ключа payload токена с токеном приложения</summary>
    public const string JwtApplicationTokenClaim = "appToken";
  }
}
