// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.UserListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  /// <summary>Обработка событий на изменение пользователя</summary>
  [Component]
  public class UserListener : EntityEventsListener
  {
    private static UserListener FE55owAKDEH1BfLRckK;

    /// <inheritdoc />
    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.FixUserLocal((EleWise.ELMA.Security.IUser) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 0 : 0;
            continue;
          case 3:
            if (user == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            user = UserListener.jt4RtcAof9rsYsgTBsX((object) @event) as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 3 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return false;
    }

    /// <inheritdoc />
    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.IUser user1;
        DateTime? nullable1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              EleWise.ELMA.Security.Models.IUser user2 = user1;
              nullable1 = new DateTime?();
              DateTime? nullable2 = nullable1;
              user2.BlockDate = nullable2;
              num2 = 5;
              continue;
            case 2:
              user1.BlockDate = new DateTime?(UserListener.MnTZyWAmKRmfGSIKdo5());
              num2 = 6;
              continue;
            case 3:
              if (nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 1 : 1;
                continue;
              }
              goto label_9;
            case 4:
              if (UserListener.e1fgMuAtN6atpgoaFnM((object) user1) == UserStatus.Blocked)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
                continue;
              }
              goto case 9;
            case 5:
            case 6:
              goto label_9;
            case 7:
              goto label_13;
            case 8:
              this.FixUserLocal((EleWise.ELMA.Security.IUser) user1);
              num2 = 4;
              continue;
            case 9:
              if (UserListener.e1fgMuAtN6atpgoaFnM((object) user1) != UserStatus.Blocked)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 7 : 7;
                continue;
              }
              goto label_9;
            case 10:
              if (!nullable1.HasValue)
              {
                num2 = 2;
                continue;
              }
              goto case 9;
            case 11:
              if (user1 != null)
              {
                num2 = 8;
                continue;
              }
              goto label_9;
            case 12:
              user1 = UserListener.jt4RtcAof9rsYsgTBsX((object) @event) as EleWise.ELMA.Security.Models.IUser;
              num2 = 11;
              continue;
            default:
              nullable1 = user1.BlockDate;
              num2 = 10;
              continue;
          }
        }
label_13:
        nullable1 = user1.BlockDate;
        num1 = 3;
      }
label_9:
      return false;
    }

    private void FixUserLocal(EleWise.ELMA.Security.IUser user)
    {
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            if (!UserListener.OXAyptADJXNEhhPGUcZ((object) user.Lang, UserListener.tHJ4PTAkNRxIs5Efkgd(84189367 + 1997579375 ^ 2081769728)))
            {
              num1 = 2;
              continue;
            }
            goto label_22;
          case 2:
            goto label_5;
          case 3:
            goto label_18;
          case 4:
            if (UserListener.h7ErwkA6YqExADGPnYD((object) user.Lang))
            {
              num1 = 3;
              continue;
            }
            goto case 1;
          default:
            goto label_26;
        }
      }
label_25:
      return;
label_18:
      return;
label_26:
      return;
label_5:
      try
      {
        CultureInfo cultureInfo = (CultureInfo) UserListener.hakth3Axw2ajOuowjR9(UserListener.IqsVrxAaZPTRsXDQYD0((object) user));
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_14;
            case 1:
              UserListener.VP9OlgAiTRGu7OecLS3((object) user, UserListener.PXIGVjACHna34lNowEC((object) cultureInfo));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_14:
        return;
label_10:
        return;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0)
          num3 = 1;
        while (true)
        {
          CultureInfo cultureInfo;
          object obj;
          switch (num3)
          {
            case 0:
              goto label_8;
            case 1:
              UserListener.JSKDFUANvonBmENwRNK(UserListener.HX0g4OA3YeRNiMVQ2pN(), UserListener.mRUGH2AjGaw1yCSdJ9I((object) ex), (object) ex);
              num3 = 2;
              continue;
            case 2:
              obj = UserListener.UE02K6A0GlA3bdegyQI();
              if (obj == null)
              {
                num3 = 4;
                continue;
              }
              break;
            case 3:
              user.Lang = (string) UserListener.PXIGVjACHna34lNowEC((object) cultureInfo);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 0 : 0;
              continue;
            case 4:
              obj = (object) EleWise.ELMA.SR.KeyCultureInfo;
              break;
            default:
              goto label_2;
          }
          cultureInfo = (CultureInfo) obj;
          num3 = 3;
        }
label_8:
        return;
label_2:
        return;
      }
label_22:;
    }

    public UserListener()
    {
      UserListener.y3ih8QAZIMk7JHPmgTs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jt4RtcAof9rsYsgTBsX([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static bool xx9c1yAUSFxW1W9Hd0E() => UserListener.FE55owAKDEH1BfLRckK == null;

    internal static UserListener itLe8UARma9FQM9F6YO() => UserListener.FE55owAKDEH1BfLRckK;

    internal static UserStatus e1fgMuAtN6atpgoaFnM([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status;

    internal static DateTime MnTZyWAmKRmfGSIKdo5() => DateTime.Now;

    internal static bool h7ErwkA6YqExADGPnYD([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object tHJ4PTAkNRxIs5Efkgd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool OXAyptADJXNEhhPGUcZ([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object IqsVrxAaZPTRsXDQYD0([In] object obj0) => (object) ((EleWise.ELMA.Security.IUser) obj0).Lang;

    internal static object hakth3Axw2ajOuowjR9([In] object obj0) => (object) CultureInfo.CreateSpecificCulture((string) obj0);

    internal static object PXIGVjACHna34lNowEC([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static void VP9OlgAiTRGu7OecLS3([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.IUser) obj0).Lang = (string) obj1;

    internal static object HX0g4OA3YeRNiMVQ2pN() => (object) Logger.Log;

    internal static object mRUGH2AjGaw1yCSdJ9I([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void JSKDFUANvonBmENwRNK([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object UE02K6A0GlA3bdegyQI() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static void y3ih8QAZIMk7JHPmgTs() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
