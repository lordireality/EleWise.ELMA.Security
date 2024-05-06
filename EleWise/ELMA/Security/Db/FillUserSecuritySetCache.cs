// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Db.FillUserSecuritySetCache
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Db
{
  [Component(Type = ComponentType.Server)]
  internal class FillUserSecuritySetCache : IInitHandler
  {
    internal static FillUserSecuritySetCache UHuih0nkxIcj8bx7mfQ;

    public void Init()
    {
    }

    public void InitComplete()
    {
      int num1 = 2;
      ISession session;
      ITransaction transaction;
      while (true)
      {
        switch (num1)
        {
          case 1:
            session = (ISession) FillUserSecuritySetCache.rQw83rnCAmj36o7FRrb((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) "");
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
            continue;
          case 2:
            if (FillUserSecuritySetCache.ifoPXOnx0PxCtR76vlE((object) Locator.GetServiceNotNull<IRuntimeApplication>()))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 1 : 0;
              continue;
            }
            goto label_8;
          case 3:
            goto label_26;
          case 4:
            goto label_2;
          case 5:
            goto label_6;
          default:
            transaction = (ITransaction) null;
            num1 = 5;
            continue;
        }
      }
label_26:
      return;
label_2:
      return;
label_8:
      return;
label_6:
      try
      {
        transaction = (ITransaction) FillUserSecuritySetCache.SwHhVlniD8rKBjI8tWm((object) session);
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              FillUserSecuritySetCache.DVyi2cnj8KgSnMpHaE6(FillUserSecuritySetCache.QZnNO8nNhlpD5mbPg0P((object) session, FillUserSecuritySetCache.JmR4cin3uPR48aSKb5O(-757186336 ^ -757119230)), false);
              num2 = 4;
              continue;
            case 2:
              FillUserSecuritySetCache.IRZH2Nn0kT5OraZWCSn((object) transaction);
              num2 = 6;
              continue;
            case 3:
              FillUserSecuritySetCache.DVyi2cnj8KgSnMpHaE6((object) session.CreateSQLQuery((string) FillUserSecuritySetCache.JmR4cin3uPR48aSKb5O(-389167216 ^ -389234674)), false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 1 : 0;
              continue;
            case 4:
              FillUserSecuritySetCache.IRZH2Nn0kT5OraZWCSn((object) transaction);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 7 : 1;
              continue;
            case 5:
              FillUserSecuritySetCache.DVyi2cnj8KgSnMpHaE6(FillUserSecuritySetCache.a9s2ZqnAhmJYGoDJu4f((object) session.GetNamedQuery((string) FillUserSecuritySetCache.JmR4cin3uPR48aSKb5O(-817081027 ^ 243500131 ^ -1043408528)), 0), false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 2 : 2;
              continue;
            case 6:
              goto label_24;
            case 7:
              transaction = (ITransaction) FillUserSecuritySetCache.SwHhVlniD8rKBjI8tWm((object) session);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 0;
              continue;
            default:
              FillUserSecuritySetCache.DVyi2cnj8KgSnMpHaE6(FillUserSecuritySetCache.a9s2ZqnAhmJYGoDJu4f(FillUserSecuritySetCache.ktYZmtnZcKHVXgeS82Q((object) session, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928062074)), 0), false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 1 : 5;
              continue;
          }
        }
label_24:;
      }
      catch (Exception ex)
      {
        int num3 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              FillUserSecuritySetCache.BtQfjYnWxoVdIIKvxYt((object) transaction);
              num3 = 3;
              continue;
            case 2:
              FillUserSecuritySetCache.vZvPjNn7SyAQiTvOLoE(FillUserSecuritySetCache.x289O9nsv4xF1DhO5JQ(), FillUserSecuritySetCache.JmR4cin3uPR48aSKb5O(-296013529 ^ -295998295), (object) ex);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_20;
            case 4:
              goto label_16;
            default:
              if (transaction == null)
              {
                num3 = 4;
                continue;
              }
              goto case 1;
          }
        }
label_20:
        return;
label_16:;
      }
    }

    public FillUserSecuritySetCache()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ifoPXOnx0PxCtR76vlE([In] object obj0) => ((IRuntimeApplication) obj0).IsFirstServerInCluster;

    internal static object rQw83rnCAmj36o7FRrb([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object SwHhVlniD8rKBjI8tWm([In] object obj0) => (object) ((ISession) obj0).BeginTransaction();

    internal static object JmR4cin3uPR48aSKb5O(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int DVyi2cnj8KgSnMpHaE6([In] object obj0, [In] bool obj1) => ((IQuery) obj0).ExecuteUpdate(obj1);

    internal static object QZnNO8nNhlpD5mbPg0P([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static void IRZH2Nn0kT5OraZWCSn([In] object obj0) => ((ITransaction) obj0).Commit();

    internal static object ktYZmtnZcKHVXgeS82Q([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).GetNamedQuery((string) obj1);

    internal static object a9s2ZqnAhmJYGoDJu4f([In] object obj0, [In] int obj1) => (object) ((IQuery) obj0).SetTimeout(obj1);

    internal static object x289O9nsv4xF1DhO5JQ() => (object) Logger.Log;

    internal static void vZvPjNn7SyAQiTvOLoE([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void BtQfjYnWxoVdIIKvxYt([In] object obj0) => ((ITransaction) obj0).Rollback();

    internal static bool hL5brKnD1V8dWd4Lqov() => FillUserSecuritySetCache.UHuih0nkxIcj8bx7mfQ == null;

    internal static FillUserSecuritySetCache mvAtVWnayBIGOZvXFIg() => FillUserSecuritySetCache.UHuih0nkxIcj8bx7mfQ;
  }
}
