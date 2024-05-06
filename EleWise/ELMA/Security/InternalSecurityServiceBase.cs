// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InternalSecurityServiceBase
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.ActiveUserSession;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  internal abstract class InternalSecurityServiceBase : LicensedUnitBase
  {
    internal static InternalSecurityServiceBase Fj34vxKPFRdZhf7TBOm;

    protected virtual uint UsedLicenseCount
    {
      get
      {
        int num1 = 3;
        int? totalLoginCount;
        int? nullable1;
        while (true)
        {
          int num2 = num1;
          ActiveUsersSessionInfo usersSessionInfo;
          while (true)
          {
            int? nullable2;
            ActiveUserSessionService service;
            int? loginCount;
            byte licSubType;
            int? nullable3;
            switch (num2)
            {
              case 1:
                if (loginCount.HasValue)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 8 : 13;
                  continue;
                }
                goto case 14;
              case 2:
                if (licSubType == (byte) 1)
                {
                  num2 = 15;
                  continue;
                }
                goto label_10;
              case 3:
                this.Check(out licSubType, out ushort _, out ushort _);
                num2 = 2;
                continue;
              case 4:
                goto label_7;
              case 5:
                loginCount = usersSessionInfo.LoginCount;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 1 : 1;
                continue;
              case 6:
                goto label_17;
              case 7:
                goto label_6;
              case 8:
                if (totalLoginCount.HasValue)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 0 : 0;
                  continue;
                }
                goto case 5;
              case 9:
                usersSessionInfo = (ActiveUsersSessionInfo) InternalSecurityServiceBase.PE80HSK585IrrMK7p1n((object) service, (object) new AuthenticatedSessionInfo()
                {
                  UserId = (object) -1L
                });
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 6 : 2;
                continue;
              case 10:
                if (nullable1.HasValue)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 4 : 1;
                  continue;
                }
                goto label_6;
              case 11:
                nullable3 = nullable2;
                break;
              case 12:
                if (service != null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 9 : 8;
                  continue;
                }
                goto label_9;
              case 13:
                nullable3 = new int?(-loginCount.GetValueOrDefault());
                break;
              case 14:
                nullable2 = new int?();
                num2 = 11;
                continue;
              case 15:
                service = Locator.GetService<ActiveUserSessionService>();
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 12 : 7;
                continue;
              default:
                goto label_8;
            }
            nullable1 = nullable3;
            num2 = 10;
          }
label_17:
          totalLoginCount = usersSessionInfo.TotalLoginCount;
          num1 = 8;
        }
label_6:
        return 0;
label_7:
        return (uint) nullable1.GetValueOrDefault();
label_8:
        return (uint) totalLoginCount.GetValueOrDefault();
label_9:
        return 0;
label_10:
        object obj1 = InternalSecurityServiceBase.CBoA7dKdqD7miJerGa5((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) "");
        ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
        object obj2 = InternalSecurityServiceBase.kVyML9K9i4NkkUdLPA7(InternalSecurityServiceBase.qmBq20KE0j12YNfCq4D(1245871191 - 2145700088 ^ -899830507), InternalSecurityServiceBase.ylgx2lKXyLMwT80XLfo(InternalSecurityServiceBase.gXiw2tKGlbtTHjDw1FS((object) serviceNotNull), InternalSecurityServiceBase.qmBq20KE0j12YNfCq4D(552500104 ^ 552500800)), (object) 0, InternalSecurityServiceBase.ylgx2lKXyLMwT80XLfo((object) serviceNotNull.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(928696104 ^ 928695036)));
        return (uint) InternalSecurityServiceBase.KsmYJWKBFYtX3u70FXZ(InternalSecurityServiceBase.doUGJoKhakis9C1HfD2(InternalSecurityServiceBase.b0uOueKMy406R3TdnxG(InternalSecurityServiceBase.QST008K1PTSSmqARFPf(obj1, obj2), false)));
      }
    }

    protected virtual uint UsedPrivilegeCount
    {
      get
      {
        int num = 3;
        ActiveUserSessionService service;
        byte licSubType;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
              if (licSubType == (byte) 1)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 3:
              this.Check(out licSubType, out ushort _, out ushort _);
              num = 2;
              continue;
            case 4:
              if (service == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 1 : 1;
                continue;
              }
              goto label_9;
            default:
              service = Locator.GetService<ActiveUserSessionService>();
              num = 4;
              continue;
          }
        }
label_8:
        return 0;
label_9:
        return (uint) service.GetPrivilegeUserIds(false).Count<long>();
label_10:
        return 0;
      }
    }

    protected abstract void Check(
      out byte licSubType,
      out ushort licCount,
      out ushort privilegeCount);

    protected virtual void CheckUserToAuthenticate(
      [NotNull] EleWise.ELMA.Security.Models.IUser user,
      Func<bool> isAlreadyLoggedFunc,
      Func<int, bool> isCurrentPrivilegeFunc,
      Func<int> otherUsersCountFunc)
    {
      if (user == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123924003));
      byte licSubType;
      ushort licCount;
      ushort privilegeCount;
      this.Check(out licSubType, out licCount, out privilegeCount);
      if (licSubType == (byte) 1)
      {
        if (isAlreadyLoggedFunc == null || isCurrentPrivilegeFunc == null || otherUsersCountFunc == null || isCurrentPrivilegeFunc((int) privilegeCount) || user.Uid == SecurityConstants.SystemUserUid)
          return;
        int num1 = isAlreadyLoggedFunc() ? 1 : 0;
        int num2 = otherUsersCountFunc();
        if ((num1 == 0 || num2 > (int) licCount) && num2 >= (int) licCount)
        {
          Locator.GetServiceNotNull<ILicenseWorkplaceExceededExceptionEventHandler>().UserLicenseWorkplaceExceededException(user);
          throw new ConcurrentLicenseExceededException((IUser) user);
        }
      }
      else
      {
        ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
        ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
        string queryString = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807815375), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362654593)), (object) 0, (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1424960806 ^ -1424959730)), (object) user.Id);
        if (Convert.ToInt32(session.CreateSQLQuery(queryString).CleanUpCache(false).UniqueResult()) >= (int) licCount)
        {
          Locator.GetServiceNotNull<ILicenseWorkplaceExceededExceptionEventHandler>().UserLicenseWorkplaceExceededException(user);
          throw new LicenseWorkplaceExceededException(__ModuleInfo.UID);
        }
      }
    }

    protected virtual bool CanCreateNewUser()
    {
      int num = 2;
      ushort licCount;
      byte licSubType;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (licSubType == (byte) 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            this.Check(out licSubType, out licCount, out ushort _);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return true;
label_3:
      object obj1 = InternalSecurityServiceBase.CBoA7dKdqD7miJerGa5((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) "");
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      object obj2 = InternalSecurityServiceBase.kVyML9K9i4NkkUdLPA7(InternalSecurityServiceBase.qmBq20KE0j12YNfCq4D(631805505 ^ 631802123), InternalSecurityServiceBase.ylgx2lKXyLMwT80XLfo(InternalSecurityServiceBase.gXiw2tKGlbtTHjDw1FS((object) serviceNotNull), InternalSecurityServiceBase.qmBq20KE0j12YNfCq4D(1687460816 ^ 1687461400)), (object) 0, InternalSecurityServiceBase.ylgx2lKXyLMwT80XLfo(InternalSecurityServiceBase.gXiw2tKGlbtTHjDw1FS((object) serviceNotNull), InternalSecurityServiceBase.qmBq20KE0j12YNfCq4D(-1341618464 ^ -1341619404)));
      return InternalSecurityServiceBase.KsmYJWKBFYtX3u70FXZ(InternalSecurityServiceBase.doUGJoKhakis9C1HfD2(InternalSecurityServiceBase.b0uOueKMy406R3TdnxG(InternalSecurityServiceBase.QST008K1PTSSmqARFPf(obj1, obj2), false))) < (int) licCount;
    }

    protected override string GetComponentId() => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454922036);

    protected override string GetComponentVersion() => VersionInfo.GetVersion<EleWise.ELMA.SR>().ToString();

    protected InternalSecurityServiceBase()
    {
      InternalSecurityServiceBase.oKHrb7Kpd6vvLhgCrn2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object PE80HSK585IrrMK7p1n([In] object obj0, [In] object obj1) => (object) ((ActiveUserSessionService) obj0).GetOtherUsersCount((AuthenticatedSessionInfo) obj1);

    internal static object CBoA7dKdqD7miJerGa5([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object qmBq20KE0j12YNfCq4D(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object gXiw2tKGlbtTHjDw1FS([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object ylgx2lKXyLMwT80XLfo([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object kVyML9K9i4NkkUdLPA7([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object QST008K1PTSSmqARFPf([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object b0uOueKMy406R3TdnxG([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static object doUGJoKhakis9C1HfD2([In] object obj0) => ((IQuery) obj0).UniqueResult();

    internal static int KsmYJWKBFYtX3u70FXZ([In] object obj0) => Convert.ToInt32(obj0);

    internal static bool T3lON8KQ3yDju99eXfX() => InternalSecurityServiceBase.Fj34vxKPFRdZhf7TBOm == null;

    internal static InternalSecurityServiceBase CMH6srK84GntRyAkgJL() => InternalSecurityServiceBase.Fj34vxKPFRdZhf7TBOm;

    internal static void oKHrb7Kpd6vvLhgCrn2() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
