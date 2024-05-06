// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.UserCertificateListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  /// <summary>Компонент для обновления серт-тов пользователя</summary>
  [Component]
  public class UserCertificateListener : PostFlushEventListener
  {
    private static UserCertificateListener MuNoJyZOpT8fLF3Loj8;

    public UserCertificateManager UserCertificateManager
    {
      get => this.\u003CUserCertificateManager\u003Ek__BackingField;
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
              this.\u003CUserCertificateManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
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

    /// <summary>При создании сертификата</summary>
    /// <param name="event"></param>
    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num = 2;
      IUserCertificate certificate;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.UpdateDefault(certificate);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 0;
            continue;
          case 2:
            certificate = UserCertificateListener.v43MWtZv1MX8PW01sIK((object) @event) as IUserCertificate;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>При обновлении сертификата</summary>
    /// <param name="event"></param>
    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num = 2;
      IUserCertificate certificate;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.UpdateDefault(certificate);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
            continue;
          case 2:
            certificate = UserCertificateListener.v43MWtZv1MX8PW01sIK((object) @event) as IUserCertificate;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void UpdateDefault(IUserCertificate certificate)
    {
      int num1 = 13;
      Guid? cryptoActionGuid;
      bool? isDefault1;
      IEnumerator<IUserCertificate> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            UserCertificateManager certificateManager = this.UserCertificateManager;
            object obj = UserCertificateListener.lFTHQLZqPBxHLurFEvC((object) certificate);
            cryptoActionGuid = certificate.CryptoActionGuid;
            Guid cryptoActionUid = cryptoActionGuid.Value;
            enumerator = certificateManager.GetCertificates((EleWise.ELMA.Security.IUser) obj, cryptoActionUid).Where<IUserCertificate>((Func<IUserCertificate, bool>) (c =>
            {
              int num2 = 3;
              bool? isDefault2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    if (!isDefault2.HasValue)
                    {
                      num2 = 4;
                      continue;
                    }
                    break;
                  case 3:
                    isDefault2 = c.IsDefault;
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 2 : 1;
                    continue;
                  case 4:
                    goto label_7;
                }
                isDefault2 = c.IsDefault;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 0 : 1;
              }
label_6:
              return isDefault2.Value;
label_7:
              return false;
            })).GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 3 : 6;
            continue;
          case 2:
            goto label_39;
          case 3:
            if (cryptoActionGuid.HasValue)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 1 : 1;
              continue;
            }
            goto label_14;
          case 4:
            cryptoActionGuid = certificate.CryptoActionGuid;
            num1 = 3;
            continue;
          case 5:
            goto label_7;
          case 6:
            goto label_12;
          case 7:
            if (isDefault1.Value)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 0 : 0;
              continue;
            }
            goto label_28;
          case 8:
            isDefault1 = certificate.IsDefault;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 7 : 1;
            continue;
          case 9:
            goto label_11;
          case 10:
            if (isDefault1.HasValue)
            {
              num1 = 8;
              continue;
            }
            goto label_32;
          case 11:
            goto label_5;
          case 12:
            isDefault1 = certificate.IsDefault;
            num1 = 10;
            continue;
          case 13:
            if (certificate != null)
            {
              num1 = 12;
              continue;
            }
            goto label_36;
          default:
            if (UserCertificateListener.lFTHQLZqPBxHLurFEvC((object) certificate) != null)
            {
              num1 = 4;
              continue;
            }
            goto label_2;
        }
      }
label_39:
      return;
label_7:
      return;
label_11:
      return;
label_5:
      return;
label_14:
      return;
label_2:
      return;
label_12:
      try
      {
label_16:
        if (UserCertificateListener.CGBMEMZgGCRH8fZDJpv((object) enumerator))
          goto label_15;
        else
          goto label_17;
label_13:
        IUserCertificate current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_25;
            case 1:
              current.IsDefault = new bool?(false);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 3 : 3;
              continue;
            case 2:
              goto label_15;
            case 3:
              goto label_16;
            case 4:
              if (current.Id != certificate.Id)
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 1 : 0;
                continue;
              }
              goto label_16;
            default:
              goto label_21;
          }
        }
label_25:
        return;
label_21:
        return;
label_15:
        current = enumerator.Current;
        num3 = 4;
        goto label_13;
label_17:
        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
        goto label_13;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 1 : 0;
        else
          goto label_26;
label_24:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_26:
        UserCertificateListener.RZpuMEZJV6V0NaGdgyO((object) enumerator);
        num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0)
        {
          num4 = 0;
          goto label_24;
        }
        else
          goto label_24;
      }
label_36:
      return;
label_32:
      return;
label_28:;
    }

    public UserCertificateListener()
    {
      UserCertificateListener.j8CNhsZIKCsJnrQiCE1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gMtQ5jZTcB5h9VYpDcD() => UserCertificateListener.MuNoJyZOpT8fLF3Loj8 == null;

    internal static UserCertificateListener Tm8YS1ZFFQBRtIH7a1J() => UserCertificateListener.MuNoJyZOpT8fLF3Loj8;

    internal static object v43MWtZv1MX8PW01sIK([In] object obj0) => ((AbstractPostDatabaseOperationEvent) obj0).Entity;

    internal static object lFTHQLZqPBxHLurFEvC([In] object obj0) => (object) ((IUserCertificate) obj0).User;

    internal static bool CGBMEMZgGCRH8fZDJpv([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void RZpuMEZJV6V0NaGdgyO([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void j8CNhsZIKCsJnrQiCE1() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
