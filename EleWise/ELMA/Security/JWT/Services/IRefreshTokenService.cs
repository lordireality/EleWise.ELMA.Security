// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Services.IRefreshTokenService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

namespace EleWise.ELMA.Security.JWT.Services
{
  /// <summary>Сервис для работы с RefreshToken</summary>
  internal interface IRefreshTokenService
  {
    /// <summary>
    /// Создать одноразовый токен обновления авторизации для указанного пользователя
    /// </summary>
    /// <param name="authInfo">Информация об авторизации</param>
    /// <returns>Токен</returns>
    string CreateToken(AuthInfoContainer authInfo);

    /// <summary>
    /// Вернуть идентификатор пользователя. Токен обновления авторизации будет удален.
    /// </summary>
    /// <param name="refreshToken">Токен обновления</param>
    /// <exception cref="T:System.ArgumentException">Если токен в неподдерживаемом формате</exception>
    /// <returns>Информация для авторизации, <c>null</c> если не найден</returns>
    AuthInfoContainer GetAuthInfo(string refreshToken);

    /// <summary>
    /// Отозвать токены обновления авторизации для указанного пользователя
    /// </summary>
    /// <param name="authInfo">Информация об авторизации</param>
    void Revoke(AuthInfoContainer authInfo);

    /// <summary>Удалить все просроченные токены</summary>
    void RemoveExpired();
  }
}
