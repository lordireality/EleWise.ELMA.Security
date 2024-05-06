// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.TokenExtensions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.JWT
{
  /// <summary>Методы-расширения для работы с токенами</summary>
  internal static class TokenExtensions
  {
    private static readonly ISet<string> ClaimsToFilter;
    internal static TokenExtensions wuW172vi07I2fLjYTgB;

    /// <summary>Получить словарь из контейнера параметров авторизации</summary>
    /// <param name="authInfo">Параметры авторизации</param>
    /// <returns>Словарь параметров</returns>
    public static IDictionary<string, string> ToDictionary(
      this AuthInfoContainer authInfo)
    {
      return (IDictionary<string, string>) new Dictionary<string, string>(2)
      {
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(266768307 ^ 266792051),
          authInfo.UserId.ToString()
        },
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-389167216 ^ -389207794),
          authInfo.ApplicationToken
        }
      }.Concat<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) authInfo.AdditionalClaims).ToDictionary<KeyValuePair<string, string>, string, string>((Func<KeyValuePair<string, string>, string>) (kv => kv.Key), (Func<KeyValuePair<string, string>, string>) (kv => kv.Value));
    }

    /// <summary>Получить параметры авторизации из словаря</summary>
    /// <param name="claims">Словарь</param>
    /// <exception cref="T:System.ArgumentException">Если словарь не содержит обязательных значений</exception>
    /// <returns>Контейнер параметров</returns>
    public static AuthInfoContainer ToAuthInfo(
      this IDictionary<string, string> claims)
    {
      Contract.CheckArgument(claims.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1212789817 - 1827404527 ^ 1254765336)) && claims.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362665175)), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550693406)));
      long userId = long.Parse(claims[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440366245)]);
      string claim = claims[z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447341471)];
      Dictionary<string, string> dictionary = claims.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (kv => !TokenExtensions.ClaimsToFilter.Contains(kv.Key))).ToDictionary<KeyValuePair<string, string>, string, string>((Func<KeyValuePair<string, string>, string>) (kv => kv.Key), (Func<KeyValuePair<string, string>, string>) (kv => kv.Value));
      string applicationToken = claim;
      Dictionary<string, string> additionalClaims = dictionary;
      return new AuthInfoContainer(userId, applicationToken, (IDictionary<string, string>) additionalClaims);
    }

    static TokenExtensions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TokenExtensions.ClaimsToFilter = (ISet<string>) new HashSet<string>()
            {
              (string) TokenExtensions.lS4cghv0Zdjwvq8eNVF(--353012470 ^ 353002980),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331062794),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-296013529 ^ -295969279),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1743015995 ^ -1743044363),
              (string) TokenExtensions.lS4cghv0Zdjwvq8eNVF(-1540570615 - 1746246777 ^ 1008192170),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899851237),
              (string) TokenExtensions.lS4cghv0Zdjwvq8eNVF(-94240706 ^ -94179472),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1780597820 ^ 1780590588),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562627913)
            };
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 0 : 0;
            continue;
          case 2:
            TokenExtensions.G5VMytvN8HakcrTHXN8();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void G5VMytvN8HakcrTHXN8() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object lS4cghv0Zdjwvq8eNVF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool F2Kul5v3mfsBWr4QcpZ() => TokenExtensions.wuW172vi07I2fLjYTgB == null;

    internal static TokenExtensions bHH7EHvji0Zqit6srDg() => TokenExtensions.wuW172vi07I2fLjYTgB;
  }
}
