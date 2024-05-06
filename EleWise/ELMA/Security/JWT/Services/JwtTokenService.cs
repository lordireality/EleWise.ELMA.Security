// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Services.JwtTokenService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace EleWise.ELMA.Security.JWT.Services
{
  /// <inheritdoc cref="T:EleWise.ELMA.Security.JWT.Services.IJwtTokenService" />
  [Service]
  internal sealed class JwtTokenService : IJwtTokenService
  {
    private static readonly TimeSpan DefaultClockSkew;
    private readonly JsonWebTokenHandler tokenHandler;
    private readonly ConcurrentDictionary<byte[], SigningCredentials> keysLocalCache;
    internal static JwtTokenService WZEPNVvZho7FvmJ75OQ;

    /// <summary>Ctor</summary>
    public JwtTokenService()
    {
      JwtTokenService.emje06v77tTyJ2A1xEp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.keysLocalCache = new ConcurrentDictionary<byte[], SigningCredentials>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
            continue;
          case 2:
            this.tokenHandler = new JsonWebTokenHandler();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public string CreateToken(
      IDictionary<string, string> payload,
      byte[] signatureSecret,
      TimeSpan duration)
    {
      Contract.NotNull((object) payload, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880091293 >> 4 ^ -55033170));
      Contract.CheckArgument(duration > TimeSpan.Zero, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224839642)));
      DateTime utcNow = DateTime.UtcNow;
      IEnumerable<Claim> claims = payload.Select<KeyValuePair<string, string>, Claim>((Func<KeyValuePair<string, string>, Claim>) (d => new Claim(d.Key, d.Value)));
      return this.tokenHandler.CreateToken(new SecurityTokenDescriptor()
      {
        Issuer = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1254421137 >> 4 ^ -78381662),
        Subject = new ClaimsIdentity(claims),
        Expires = new DateTime?(utcNow.Add(duration)),
        IssuedAt = new DateTime?(utcNow),
        NotBefore = new DateTime?(utcNow),
        SigningCredentials = this.GetSigningCredentials(signatureSecret)
      }).ToString();
    }

    /// <inheritdoc />
    public IDictionary<string, string> GetValidatedPayload(
      string token,
      byte[] signatureSecret)
    {
      Contract.ArgumentNotNullOrEmpty(token, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1115268484 ^ -1115232684));
      TokenValidationParameters validationParameters = this.GetTokenValidationParameters(signatureSecret);
      TokenValidationResult validationResult = this.tokenHandler.ValidateToken(token, validationParameters);
      if (!validationResult.IsValid)
        throw validationResult.Exception;
      // ISSUE: reference to a compiler-generated method
      return (IDictionary<string, string>) ((JsonWebToken) validationResult.SecurityToken).Claims.ToDictionary<Claim, string, string>((Func<Claim, string>) (c => (string) JwtTokenService.\u003C\u003Ec.FKtbKpwyRuJSDl7STovT((object) c)), (Func<Claim, string>) (c => c.Value));
    }

    private SigningCredentials GetSigningCredentials(byte[] signatureSecret)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (signatureSecret == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (SigningCredentials) null;
label_5:
      return this.keysLocalCache.GetOrAdd(signatureSecret, new SigningCredentials((SecurityKey) new SymmetricSecurityKey(signatureSecret), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1212037053 ^ -1727812018 ^ -784501169)));
    }

    private TokenValidationParameters GetTokenValidationParameters(
      byte[] signatureSecret)
    {
      int num = 2;
      SymmetricSecurityKey symmetricSecurityKey1;
      while (true)
      {
        SymmetricSecurityKey symmetricSecurityKey2;
        switch (num)
        {
          case 1:
            symmetricSecurityKey2 = (SymmetricSecurityKey) null;
            break;
          case 2:
            if (signatureSecret == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 1 : 1;
              continue;
            }
            symmetricSecurityKey2 = new SymmetricSecurityKey(signatureSecret);
            break;
          default:
            goto label_3;
        }
        symmetricSecurityKey1 = symmetricSecurityKey2;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
      }
label_3:
      TokenValidationParameters validationParameters = new TokenValidationParameters();
      JwtTokenService.zlIuU9vWRRWAQbUiah1((object) validationParameters, JwtTokenService.DefaultClockSkew);
      JwtTokenService.K4eiucvrKIM0kFfWAOO((object) validationParameters, (object) symmetricSecurityKey1);
      JwtTokenService.RLQ19gvSvMIVJZy4Byp((object) validationParameters, false);
      JwtTokenService.HExpluvY2LqloTpdR6j((object) validationParameters, false);
      JwtTokenService.N8Xy4LvykENDUml7ImO((object) validationParameters, symmetricSecurityKey1 != null);
      JwtTokenService.vdkuOGvVLuvew0daAVD((object) validationParameters, true);
      return validationParameters;
    }

    static JwtTokenService()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            JwtTokenService.DefaultClockSkew = JwtTokenService.xcAt8HvlIhuhMkQdoht(10.0);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void emje06v77tTyJ2A1xEp() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool NcZ6JBvAg64XpZc6JdI() => JwtTokenService.WZEPNVvZho7FvmJ75OQ == null;

    internal static JwtTokenService CLkiLPvs93eYInVAfiE() => JwtTokenService.WZEPNVvZho7FvmJ75OQ;

    internal static void zlIuU9vWRRWAQbUiah1([In] object obj0, [In] TimeSpan obj1) => ((TokenValidationParameters) obj0).ClockSkew = obj1;

    internal static void K4eiucvrKIM0kFfWAOO([In] object obj0, [In] object obj1) => ((TokenValidationParameters) obj0).IssuerSigningKey = (SecurityKey) obj1;

    internal static void RLQ19gvSvMIVJZy4Byp([In] object obj0, [In] bool obj1) => ((TokenValidationParameters) obj0).ValidateAudience = obj1;

    internal static void HExpluvY2LqloTpdR6j([In] object obj0, [In] bool obj1) => ((TokenValidationParameters) obj0).ValidateIssuer = obj1;

    internal static void N8Xy4LvykENDUml7ImO([In] object obj0, [In] bool obj1) => ((TokenValidationParameters) obj0).ValidateIssuerSigningKey = obj1;

    internal static void vdkuOGvVLuvew0daAVD([In] object obj0, [In] bool obj1) => ((TokenValidationParameters) obj0).ValidateLifetime = obj1;

    internal static TimeSpan xcAt8HvlIhuhMkQdoht([In] double obj0) => TimeSpan.FromSeconds(obj0);
  }
}
