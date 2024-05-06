// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Audit.LoginAuditContainer
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Models.Crypto;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Audit
{
  /// <summary>Контейнер с результатами проверки ЭП</summary>
  public class LoginAuditContainer
  {
    internal static LoginAuditContainer v6D3t8wwbOj1OG8PjQ5f;

    /// <summary>Результат проверки</summary>
    public IVerifyResult Result
    {
      get => this.\u003CResult\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Пользователь</summary>
    public IUser User
    {
      get => this.\u003CUser\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUser\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public LoginAuditContainer()
    {
      LoginAuditContainer.I0Q4OkwwRflnuhuQZxXy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FTEm5CwwKLSeFyu7j8F2() => LoginAuditContainer.v6D3t8wwbOj1OG8PjQ5f == null;

    internal static LoginAuditContainer h24VekwwUt9OAPSmW9ZC() => LoginAuditContainer.v6D3t8wwbOj1OG8PjQ5f;

    internal static void I0Q4OkwwRflnuhuQZxXy() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
