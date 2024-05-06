// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Services.JwtAuthTokenService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.JWT.Services
{
  /// <inheritdoc cref="T:EleWise.ELMA.Security.Services.IJwtAuthTokenService" />
  [Service]
  internal sealed class JwtAuthTokenService : IJwtAuthTokenService
  {
    private readonly byte[] secret;
    private readonly ILogger authLog;
    private readonly IJwtTokenService jwtTokenService;
    private readonly IRefreshTokenService refreshTokenService;
    private static JwtAuthTokenService L35VMlvPwSf52ShaQ1j;

    /// <summary>Ctor</summary>
    /// <param name="jwtTokenService">Сервис для работы с JSON Web Token</param>
    /// <param name="refreshTokenService">Сервис для работы с токеном обновления авторизации</param>
    public JwtAuthTokenService(
      IJwtTokenService jwtTokenService,
      IRefreshTokenService refreshTokenService)
    {
      JwtAuthTokenService.qCHpt6v55a59KrwIEAL();
      this.secret = new byte[32]
      {
        (byte) 109,
        (byte) 89,
        (byte) 112,
        (byte) 51,
        (byte) 115,
        (byte) 54,
        (byte) 118,
        (byte) 57,
        (byte) 121,
        (byte) 36,
        (byte) 66,
        (byte) 38,
        (byte) 69,
        (byte) 41,
        (byte) 72,
        (byte) 64,
        (byte) 77,
        (byte) 99,
        (byte) 81,
        (byte) 102,
        (byte) 84,
        (byte) 106,
        (byte) 87,
        (byte) 110,
        (byte) 90,
        (byte) 114,
        (byte) 52,
        (byte) 116,
        (byte) 55,
        (byte) 119,
        (byte) 33,
        (byte) 122
      };
      this.authLog = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816108091 ^ -816070129));
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
            this.refreshTokenService = refreshTokenService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 0 : 0;
            continue;
          case 2:
            this.jwtTokenService = jwtTokenService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 1 : 1;
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
    public JwtTokenContainer CreateToken(AuthInfoContainer authInfo)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            JwtAuthTokenService.khUsWIvEmwGeV62fOdI((object) authInfo, JwtAuthTokenService.C26Fa4vdA0UbjhGouti(-1958977588 ^ -1958957040));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.CreateTokenPrivate(authInfo);
    }

    /// <inheritdoc />
    public AuthInfoContainer GetAuthInfo(string jwtToken)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            JwtAuthTokenService.vut2eBvGFdqu7mFwue4((object) jwtToken, JwtAuthTokenService.C26Fa4vdA0UbjhGouti(-1115268484 ^ -1115245172));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      IDictionary<string, string> validatedPayload;
      return validatedPayload.ToAuthInfo();
label_4:
      AuthInfoContainer authInfo;
      try
      {
        validatedPayload = this.jwtTokenService.GetValidatedPayload(jwtToken, this.secret);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_3;
            case 2:
              authInfo = (AuthInfoContainer) null;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 0;
              continue;
            default:
              this.authLog.Debug((object) EleWise.ELMA.SR.T((string) JwtAuthTokenService.C26Fa4vdA0UbjhGouti(1100789287 - 1555711667 ^ -454910096), (object) jwtToken), ex);
              num3 = 2;
              continue;
          }
        }
      }
label_3:
      return authInfo;
    }

    /// <inheritdoc />
    public JwtTokenContainer RefreshToken(string refreshToken)
    {
      int num = 1;
      AuthInfoContainer authInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            JwtAuthTokenService.vut2eBvGFdqu7mFwue4((object) refreshToken, JwtAuthTokenService.C26Fa4vdA0UbjhGouti(1744916777 - 891549337 ^ 853387980));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 0;
            continue;
          case 2:
            if (authInfo != null)
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 3:
            goto label_6;
          case 4:
            goto label_7;
          default:
            authInfo = (AuthInfoContainer) JwtAuthTokenService.MPmKNEvXVwquAKinWPv((object) this.refreshTokenService, (object) refreshToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 2 : 1;
            continue;
        }
      }
label_6:
      return (JwtTokenContainer) null;
label_7:
      return this.CreateTokenPrivate(authInfo);
    }

    /// <inheritdoc />
    public void Revoke(AuthInfoContainer authInfo)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            JwtAuthTokenService.khUsWIvEmwGeV62fOdI((object) authInfo, JwtAuthTokenService.C26Fa4vdA0UbjhGouti(-1341618464 ^ -1341626052));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            JwtAuthTokenService.mIJaiUv9aJDAshpwB0f((object) this.refreshTokenService, (object) authInfo);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    private JwtTokenContainer CreateTokenPrivate(AuthInfoContainer authInfo) => new JwtTokenContainer(this.jwtTokenService.CreateToken(authInfo.ToDictionary(), this.secret, this.TokenDuration), (string) JwtAuthTokenService.oDFP15v1YOYiQDxqMHn((object) this.refreshTokenService, (object) authInfo));

    private TimeSpan TokenDuration => JwtAuthTokenService.pHh5SbvMZ1jZOXw6BGv(EleWise.ELMA.SR.GetSetting<double>((string) JwtAuthTokenService.C26Fa4vdA0UbjhGouti(554338340 ^ 554334300), 15.0));

    internal static void qCHpt6v55a59KrwIEAL() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool KoNG4LvQTuwyDdgbATs() => JwtAuthTokenService.L35VMlvPwSf52ShaQ1j == null;

    internal static JwtAuthTokenService bT7xbCv88uPhTfP1DM1() => JwtAuthTokenService.L35VMlvPwSf52ShaQ1j;

    internal static object C26Fa4vdA0UbjhGouti(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void khUsWIvEmwGeV62fOdI([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void vut2eBvGFdqu7mFwue4([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object MPmKNEvXVwquAKinWPv([In] object obj0, [In] object obj1) => (object) ((IRefreshTokenService) obj0).GetAuthInfo((string) obj1);

    internal static void mIJaiUv9aJDAshpwB0f([In] object obj0, [In] object obj1) => ((IRefreshTokenService) obj0).Revoke((AuthInfoContainer) obj1);

    internal static object oDFP15v1YOYiQDxqMHn([In] object obj0, [In] object obj1) => (object) ((IRefreshTokenService) obj0).CreateToken((AuthInfoContainer) obj1);

    internal static TimeSpan pHh5SbvMZ1jZOXw6BGv([In] double obj0) => TimeSpan.FromMinutes(obj0);
  }
}
