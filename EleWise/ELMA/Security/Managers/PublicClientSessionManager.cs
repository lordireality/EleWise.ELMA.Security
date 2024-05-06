// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.PublicClientSessionManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>
  /// Менеджер сущности <see cref="T:EleWise.ELMA.Security.Models.API.IPublicClientSession" />
  /// </summary>
  public class PublicClientSessionManager : EntityManager<IPublicClientSession, long>
  {
    private static readonly string SessionTokenPropName;
    private static readonly string AuthTokenPropName;
    private static readonly string AuthUserPropName;
    private static PublicClientSessionManager LOxrE2hi7bauIr14tFg;

    /// <summary>Статический экземпляр менеджера</summary>
    public static PublicClientSessionManager Instance => Locator.GetServiceNotNull<PublicClientSessionManager>();

    protected override void SetupAutoFilter(
      ICriteria criteria,
      IEntityFilter filter,
      EntityMetadata metadata,
      string alias = null)
    {
      int num = 3;
      IPublicClientSessionFilter clientSessionFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            PublicClientSessionManager.Cwy0r1h7KoNYZKKlbv1((object) criteria, (object) Restrictions.Eq(PublicClientSessionManager.Af2yV3hZrnUys7Y7klQ((object) alias) ? PublicClientSessionManager.SessionTokenPropName : (string) PublicClientSessionManager.Xgf6D3hsvxTfLrguL42(PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(1677147940 ^ 1677165640), (object) alias, (object) PublicClientSessionManager.SessionTokenPropName), (object) clientSessionFilter.SessionToken));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
            continue;
          case 2:
            if (clientSessionFilter != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 1 : 4;
              continue;
            }
            goto case 5;
          case 3:
            clientSessionFilter = filter as IPublicClientSessionFilter;
            num = 2;
            continue;
          case 4:
            if (PublicClientSessionManager.bKqu11h0MheuOZgmdw0(PublicClientSessionManager.uRENMEhN26BvkohgOUR((object) clientSessionFilter)))
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 5:
          case 7:
            PublicClientSessionManager.OZrXk5hrAhuWUmBGbAF((object) this, (object) criteria, (object) filter, (object) metadata, (object) alias);
            num = 6;
            continue;
          case 6:
            goto label_2;
          default:
            PublicClientSessionManager.r7mCp1hWIk7ure9mBaU((object) (IPublicClientSessionFilter) filter, (object) null);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 5;
            continue;
        }
      }
label_2:;
    }

    public IPublicClientSession FindByToken(string sessionToken)
    {
      int num1 = 3;
      string str;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider serviceNotNull;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = (string) PublicClientSessionManager.Xgf6D3hsvxTfLrguL42((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958977588 ^ -1958943566), PublicClientSessionManager.eySlXvhSKa0pBjShWCF((object) serviceNotNull, PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(334323849 << 5 ^ 2108478552), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(-404268492 ^ -404232672)), PublicClientSessionManager.dHX496hYPGBAqNCSWQB((object) serviceNotNull.Dialect, (object) PublicClientSessionManager.SessionTokenPropName));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              if (!string.IsNullOrWhiteSpace(sessionToken))
              {
                serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_8;
          }
        }
label_5:
        num1 = 2;
      }
label_6:
      return (IPublicClientSession) null;
label_8:
      return ((IQuery) PublicClientSessionManager.u6kGa4hcoQ4NvYWCVHQ(PublicClientSessionManager.a97tmUh48IlLVJaEsTL(PublicClientSessionManager.KrNF4Ghf70FXoO8YZaF(PublicClientSessionManager.FoPIaThVKcU9NhKXsMJ(PublicClientSessionManager.IfTryBhyqSHxR97ncsJ((object) this), (object) str), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(-2143851882 - 923330995 ^ 1227766979), PublicClientSessionManager.YYRWkGhlaDnPr5yaJjH((object) this, (object) null)), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(-816108091 ^ -816082451), (object) sessionToken), false)).UniqueResult<IPublicClientSession>();
    }

    public IPublicClientSession FindByAuthToken(Guid authToken)
    {
      int num = 3;
      string str;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) PublicClientSessionManager.Xgf6D3hsvxTfLrguL42((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-757186336 ^ -757138530), PublicClientSessionManager.eySlXvhSKa0pBjShWCF((object) serviceNotNull, PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(4869926 >> 3 ^ 625820), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(1820204600 ^ 1820238380)), PublicClientSessionManager.dHX496hYPGBAqNCSWQB(PublicClientSessionManager.Byku8shQn7l4SLoF8PD((object) serviceNotNull), (object) PublicClientSessionManager.AuthTokenPropName));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 0 : 0;
            continue;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 1 : 1;
            continue;
          case 3:
            if (!PublicClientSessionManager.bFcTpEhPgeYJJc0n0aK(authToken, Guid.Empty))
            {
              num = 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ((IQuery) PublicClientSessionManager.u6kGa4hcoQ4NvYWCVHQ((object) ((ISQLQuery) PublicClientSessionManager.FoPIaThVKcU9NhKXsMJ(PublicClientSessionManager.IfTryBhyqSHxR97ncsJ((object) this), (object) str)).AddEntity(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-517128429 ^ -517110989), PublicClientSessionManager.YYRWkGhlaDnPr5yaJjH((object) this, (object) null)).SetGuid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807855707), authToken), false)).UniqueResult<IPublicClientSession>();
label_5:
      return (IPublicClientSession) null;
    }

    public IPublicClientSession FindByTokenUser(
      string sessionToken,
      EleWise.ELMA.Security.Models.IUser currentUser)
    {
      int num = 9;
      string str;
      IQuery query;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            PublicClientSessionManager.Rl8ieJhd9mqgbtEoNfl((object) query, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-206147790 ^ -206143670), (object) currentUser);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
            continue;
          case 3:
            query = ((ISQLQuery) PublicClientSessionManager.FoPIaThVKcU9NhKXsMJ(PublicClientSessionManager.IfTryBhyqSHxR97ncsJ((object) this), (object) str)).AddEntity((string) PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(1013954274 ^ 1013910210), PublicClientSessionManager.YYRWkGhlaDnPr5yaJjH((object) this, (object) null)).SetString((string) PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(978908330 << 6 ^ -1774348632), sessionToken);
            num = 7;
            continue;
          case 4:
            str = (string) PublicClientSessionManager.Xgf6D3hsvxTfLrguL42(PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(--2002186503 ^ 2002143865), PublicClientSessionManager.eySlXvhSKa0pBjShWCF((object) serviceNotNull, PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(781628008 - 11982093 ^ 769595427), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(-315619370 - -1325004768 ^ 1009337250)), PublicClientSessionManager.dHX496hYPGBAqNCSWQB((object) serviceNotNull.Dialect, (object) PublicClientSessionManager.SessionTokenPropName));
            num = 5;
            continue;
          case 5:
            if (currentUser != null)
            {
              num = 6;
              continue;
            }
            goto case 3;
          case 6:
            str += (string) PublicClientSessionManager.p9EA53h57ckMdrQO19K(PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(84189367 + 1997579375 ^ 2081783940), PublicClientSessionManager.dHX496hYPGBAqNCSWQB(PublicClientSessionManager.Byku8shQn7l4SLoF8PD((object) serviceNotNull), (object) PublicClientSessionManager.AuthUserPropName));
            num = 3;
            continue;
          case 7:
            if (currentUser == null)
            {
              num = 10;
              continue;
            }
            goto case 2;
          case 8:
            if (currentUser == null)
            {
              num = 11;
              continue;
            }
            goto case 12;
          case 9:
            if (!string.IsNullOrWhiteSpace(sessionToken))
            {
              num = 8;
              continue;
            }
            goto label_3;
          case 11:
            currentUser = ((IAuthenticationService) PublicClientSessionManager.KerViYh8mjwRuGJT1tj((object) this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 0 : 12;
            continue;
          case 12:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = 4;
            continue;
          default:
            goto label_14;
        }
      }
label_3:
      return (IPublicClientSession) null;
label_14:
      return ((IQuery) PublicClientSessionManager.u6kGa4hcoQ4NvYWCVHQ((object) query, false)).UniqueResult<IPublicClientSession>();
    }

    /// <summary>Удалить истекшие по времени сессии</summary>
    /// <param name="expireDateTime">Дата срока истечения</param>
    /// <returns>Количество удаленных сессий</returns>
    [Transaction]
    public virtual long DeleteExpired(DateTime expireDateTime)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!PublicClientSessionManager.zkYHi8hGy1EILAVHNux(PublicClientSessionManager.rccP5EhEHAYK3ToFbF1((object) this), (object) PermissionProvider.APIAdminPermission))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return 0;
label_5:
      return (long) PublicClientSessionManager.ASDKNJhXjsdRAAgEhAZ(PublicClientSessionManager.IfTryBhyqSHxR97ncsJ((object) this), PublicClientSessionManager.p9EA53h57ckMdrQO19K(PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(-1691384762 ^ -1691402214), (object) PublicClientSessionManager.YYRWkGhlaDnPr5yaJjH((object) this, (object) null).FullName), (object) expireDateTime, (object) NHibernateUtil.DateTime);
    }

    /// <summary>Удалить все сессии пользователя</summary>
    /// <param name="authUser">Идентификатор пользователя</param>
    [Transaction]
    internal virtual void DeleteByAuthUser(long authUser)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PublicClientSessionManager.ASDKNJhXjsdRAAgEhAZ(PublicClientSessionManager.IfTryBhyqSHxR97ncsJ((object) this), (object) str, (object) authUser, (object) NHibernateUtil.Int64);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 0 : 0;
            continue;
          case 2:
            str = (string) PublicClientSessionManager.Xgf6D3hsvxTfLrguL42(PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(617710536 ^ 617694748), PublicClientSessionManager.dHX496hYPGBAqNCSWQB(PublicClientSessionManager.Byku8shQn7l4SLoF8PD((object) this.Transformation), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447334521)), PublicClientSessionManager.dHX496hYPGBAqNCSWQB(PublicClientSessionManager.Byku8shQn7l4SLoF8PD(PublicClientSessionManager.AkW6Ohh9PZODhNwe7yy((object) this)), (object) PublicClientSessionManager.AuthUserPropName));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public PublicClientSessionManager()
    {
      PublicClientSessionManager.rjNXRDh15oUxgc6tZYW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PublicClientSessionManager()
    {
      int num = 7;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) PublicClientSessionManager.QK4IOxhh6uJLXtdNUdS(PublicClientSessionManager.MWfCPOhMUwTRB4fVtmM(__typeref (IPublicClientSession)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227796441));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 3 : 2;
            continue;
          case 2:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) PublicClientSessionManager.QK4IOxhh6uJLXtdNUdS(PublicClientSessionManager.MWfCPOhMUwTRB4fVtmM(__typeref (IPublicClientSession)), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(-1489118656 ^ 643054122 ^ -2123772080));
            num = 5;
            continue;
          case 3:
            // ISSUE: method reference
            PublicClientSessionManager.AuthUserPropName = LinqUtils.NameOf<IPublicClientSession>(System.Linq.Expressions.Expression.Lambda<Func<IPublicClientSession, object>>((System.Linq.Expressions.Expression) PublicClientSessionManager.N3CTDuhpgBRGQVte81q((object) parameterExpression, (object) (MethodInfo) PublicClientSessionManager.TAOTSWhBHSRa3oHtxND(__methodref (IPublicClientSession.get_AuthUser))), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: method reference
            PublicClientSessionManager.SessionTokenPropName = LinqUtils.NameOf<IPublicClientSession>(System.Linq.Expressions.Expression.Lambda<Func<IPublicClientSession, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression, (MethodInfo) PublicClientSessionManager.TAOTSWhBHSRa3oHtxND(__methodref (IPublicClientSession.get_SessionToken))), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 0 : 2;
            continue;
          case 5:
            // ISSUE: method reference
            // ISSUE: type reference
            PublicClientSessionManager.AuthTokenPropName = LinqUtils.NameOf<IPublicClientSession>(System.Linq.Expressions.Expression.Lambda<Func<IPublicClientSession, object>>((System.Linq.Expressions.Expression) PublicClientSessionManager.ywM5UhhO2SlXS4qrTip(PublicClientSessionManager.N3CTDuhpgBRGQVte81q((object) parameterExpression, (object) (MethodInfo) PublicClientSessionManager.TAOTSWhBHSRa3oHtxND(__methodref (IPublicClientSession.get_AuthToken))), PublicClientSessionManager.MWfCPOhMUwTRB4fVtmM(__typeref (object))), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 1 : 1;
            continue;
          case 6:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) PublicClientSessionManager.QK4IOxhh6uJLXtdNUdS(PublicClientSessionManager.MWfCPOhMUwTRB4fVtmM(__typeref (IPublicClientSession)), PublicClientSessionManager.WisVFWhAU5O2iCs5lMp(554338340 ^ 554346270));
            num = 4;
            continue;
          case 7:
            PublicClientSessionManager.rjNXRDh15oUxgc6tZYW();
            num = 6;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:;
    }

    internal static object uRENMEhN26BvkohgOUR([In] object obj0) => (object) ((IPublicClientSessionFilter) obj0).SessionToken;

    internal static bool bKqu11h0MheuOZgmdw0([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool Af2yV3hZrnUys7Y7klQ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object WisVFWhAU5O2iCs5lMp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Xgf6D3hsvxTfLrguL42([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object Cwy0r1h7KoNYZKKlbv1([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void r7mCp1hWIk7ure9mBaU([In] object obj0, [In] object obj1) => ((IPublicClientSessionFilter) obj0).SessionToken = (string) obj1;

    internal static void OZrXk5hrAhuWUmBGbAF(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((EntityManager<IPublicClientSession, long>) obj0).SetupAutoFilter((ICriteria) obj1, (IEntityFilter) obj2, (EntityMetadata) obj3, (string) obj4));
    }

    internal static bool h4AwU5h3A0XqIcdLdL0() => PublicClientSessionManager.LOxrE2hi7bauIr14tFg == null;

    internal static PublicClientSessionManager jgRdoyhjDeKIeehBKoo() => PublicClientSessionManager.LOxrE2hi7bauIr14tFg;

    internal static object eySlXvhSKa0pBjShWCF([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).NoLockTableExpression((string) obj1, (string) obj2);

    internal static object dHX496hYPGBAqNCSWQB([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object IfTryBhyqSHxR97ncsJ([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static object FoPIaThVKcU9NhKXsMJ([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static System.Type YYRWkGhlaDnPr5yaJjH([In] object obj0, [In] object obj1) => ((EntityManager<IPublicClientSession, long>) obj0).GetFetchType((IEntityFilter) obj1);

    internal static object KrNF4Ghf70FXoO8YZaF([In] object obj0, [In] object obj1, [In] System.Type obj2) => (object) ((ISQLQuery) obj0).AddEntity((string) obj1, obj2);

    internal static object a97tmUh48IlLVJaEsTL([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetString((string) obj1, (string) obj2);

    internal static object u6kGa4hcoQ4NvYWCVHQ([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static bool bFcTpEhPgeYJJc0n0aK([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object Byku8shQn7l4SLoF8PD([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object KerViYh8mjwRuGJT1tj([In] object obj0) => (object) ((EntityManager<IPublicClientSession, long>) obj0).AuthenticationService;

    internal static object p9EA53h57ckMdrQO19K([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object Rl8ieJhd9mqgbtEoNfl([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetEntity((string) obj1, obj2);

    internal static object rccP5EhEHAYK3ToFbF1([In] object obj0) => (object) ((EntityManager<IPublicClientSession, long>) obj0).SecurityService;

    internal static bool zkYHi8hGy1EILAVHNux([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).HasPermission((Permission) obj1);

    internal static int ASDKNJhXjsdRAAgEhAZ([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ISession) obj0).Delete((string) obj1, obj2, (IType) obj3);

    internal static object AkW6Ohh9PZODhNwe7yy([In] object obj0) => (object) ((EntityManager<IPublicClientSession, long>) obj0).Transformation;

    internal static void rjNXRDh15oUxgc6tZYW() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static System.Type MWfCPOhMUwTRB4fVtmM([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object QK4IOxhh6uJLXtdNUdS([In] System.Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object TAOTSWhBHSRa3oHtxND([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object N3CTDuhpgBRGQVte81q([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object ywM5UhhO2SlXS4qrTip([In] object obj0, [In] System.Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);
  }
}
