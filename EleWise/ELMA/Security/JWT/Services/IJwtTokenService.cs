// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Services.IJwtTokenService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.JWT.Services
{
  /// <summary>Сервис для работы с произвольными JSON Web Token</summary>
  internal interface IJwtTokenService
  {
    /// <summary>Сгенерировть токен</summary>
    /// <param name="payload">Содержимое токена</param>
    /// <param name="signatureSecret">Секрет для подписания. Если <c>null</c>, то токен не будет подписан</param>
    /// <param name="duration">Срок действия токена</param>
    /// <returns>Токен</returns>
    string CreateToken(
      IDictionary<string, string> payload,
      byte[] signatureSecret,
      TimeSpan duration);

    /// <summary>Получить валидированное содержимое токена</summary>
    /// <param name="token">Токен</param>
    /// <param name="signatureSecret">Секрет для проверки подписи. Если <c>null</c>, то подпись не будет проверена</param>
    /// <exception cref="!:EleWise.ELMA.Security.JWT.Exceptions.InvalidTokenException">Если токен не прошел валидацию</exception>
    /// <returns>Содержимое токена, если он прошел валидацию</returns>
    IDictionary<string, string> GetValidatedPayload(string token, byte[] signatureSecret);
  }
}
