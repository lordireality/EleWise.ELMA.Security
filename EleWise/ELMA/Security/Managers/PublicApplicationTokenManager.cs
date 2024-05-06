// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.PublicApplicationTokenManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>
  /// Менеджер сущности <see cref="T:EleWise.ELMA.Security.Models.API.IPublicApplicationToken" />
  /// </summary>
  public class PublicApplicationTokenManager : EntityManager<IPublicApplicationToken, long>
  {
    private static readonly string TokenPropName;
    internal static PublicApplicationTokenManager q8tkGe1z3fUEhojiKg1;

    /// <summary>Статический экземпляр менеджера</summary>
    public static PublicApplicationTokenManager Instance => Locator.GetServiceNotNull<PublicApplicationTokenManager>();

    protected override void SetupAutoFilter(
      ICriteria criteria,
      IEntityFilter filter,
      EntityMetadata metadata,
      string alias = null)
    {
      int num = 4;
      while (true)
      {
        IPublicApplicationTokenFilter applicationTokenFilter;
        switch (num)
        {
          case 1:
            if (!PublicApplicationTokenManager.KIa1pxMKSCtaAcxk27s(PublicApplicationTokenManager.aBFmZ2MbgA2o67qBYA6((object) applicationTokenFilter)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 5 : 2;
              continue;
            }
            break;
          case 2:
            PublicApplicationTokenManager.qTJTYRMo8dEOJn6CO1N((object) (IPublicApplicationTokenFilter) filter, (object) null);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
            continue;
          case 3:
            if (applicationTokenFilter != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 1 : 0;
              continue;
            }
            break;
          case 4:
            applicationTokenFilter = filter as IPublicApplicationTokenFilter;
            num = 3;
            continue;
          case 5:
            PublicApplicationTokenManager.vVnOwVMRvM8SOPXOAl9((object) criteria, (object) Restrictions.Eq(string.IsNullOrEmpty(alias) ? PublicApplicationTokenManager.TokenPropName : string.Format((string) PublicApplicationTokenManager.YW0omqMU20gxRLLPYkR(-2143851882 - 923330995 ^ 1227766671), (object) alias, (object) PublicApplicationTokenManager.TokenPropName), PublicApplicationTokenManager.aBFmZ2MbgA2o67qBYA6((object) applicationTokenFilter)));
            num = 2;
            continue;
          case 6:
            goto label_2;
        }
        PublicApplicationTokenManager.MGBjV8MtYksT4Fb2uO1((object) this, (object) criteria, (object) filter, (object) metadata, (object) alias);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 6 : 6;
      }
label_2:;
    }

    public IPublicApplicationToken FindByToken(string applicationToken)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!PublicApplicationTokenManager.KIa1pxMKSCtaAcxk27s((object) applicationToken))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (IPublicApplicationToken) null;
label_3:
      object obj = PublicApplicationTokenManager.wy4iUWM6rKHX3MLPFUC((object) this, (object) new FetchOptions(0, 1), PublicApplicationTokenManager.gyclCbMmnmeAsw3cLLj((object) this, (object) null), (object) null, (object) null);
      ((ICriteria) obj).Add((ICriterion) PublicApplicationTokenManager.tG0R9kMk0bMvo1P1gHR((object) PublicApplicationTokenManager.TokenPropName, (object) applicationToken));
      PublicApplicationTokenManager.NnUNHtMawuE1fPsPcDH(PublicApplicationTokenManager.I6Ma64MDaJl3kCI2XyY(obj, true), PublicApplicationTokenManager.YW0omqMU20gxRLLPYkR(1458233619 ^ 1458185045));
      return ((ICriteria) obj).UniqueResult<IPublicApplicationToken>();
    }

    [PublicApiMember]
    public override void Delete(IPublicApplicationToken obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (!((ISecurityService) PublicApplicationTokenManager.wdScO0MxxHssv0XCZXg((object) this)).HasPermission(PermissionProvider.APIAdminPermission))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 0 : 0;
              continue;
            }
            base.Delete(obj);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 2 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_5:
      return;
label_7:;
    }

    public override void Delete(string query)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            base.Delete(query);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 0 : 0;
            continue;
          case 2:
            if (PublicApplicationTokenManager.lOe1eUMCN0KjiPh1Ve2(PublicApplicationTokenManager.wdScO0MxxHssv0XCZXg((object) this), (object) PermissionProvider.APIAdminPermission))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_5;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_5:
      return;
label_8:
      return;
label_2:;
    }

    public override void DeleteAll()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_7;
          case 2:
            PublicApplicationTokenManager.Pt1RuWMiZUVNG2r2Bi3((object) this);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 1 : 0;
            continue;
          case 3:
            if (PublicApplicationTokenManager.lOe1eUMCN0KjiPh1Ve2(PublicApplicationTokenManager.wdScO0MxxHssv0XCZXg((object) this), (object) PermissionProvider.APIAdminPermission))
            {
              num = 2;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_7:
      return;
label_8:
      return;
label_2:;
    }

    public PublicApplicationTokenManager()
    {
      PublicApplicationTokenManager.u0MPBwM3RxG6cTaO3CL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PublicApplicationTokenManager()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        while (true)
        {
          switch (num2)
          {
            case 1:
              parameterExpression = (ParameterExpression) PublicApplicationTokenManager.mV57d2Mjxm4xRMv51P9(typeof (IPublicApplicationToken), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1200636245 >> 6 ^ 18771519));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
              continue;
            case 2:
              TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        // ISSUE: method reference
        PublicApplicationTokenManager.TokenPropName = LinqUtils.NameOf<IPublicApplicationToken>(System.Linq.Expressions.Expression.Lambda<Func<IPublicApplicationToken, object>>((System.Linq.Expressions.Expression) PublicApplicationTokenManager.lfYuwgM0aXcPMkmR1ud((object) parameterExpression, (object) (MethodInfo) PublicApplicationTokenManager.q4CGBQMNC3Z4YudHAjS(__methodref (IPublicApplicationToken.get_Token))), parameterExpression));
        num1 = 3;
      }
label_3:;
    }

    internal static object aBFmZ2MbgA2o67qBYA6([In] object obj0) => (object) ((IPublicApplicationTokenFilter) obj0).Token;

    internal static bool KIa1pxMKSCtaAcxk27s([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object YW0omqMU20gxRLLPYkR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object vVnOwVMRvM8SOPXOAl9([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void qTJTYRMo8dEOJn6CO1N([In] object obj0, [In] object obj1) => ((IPublicApplicationTokenFilter) obj0).Token = (string) obj1;

    internal static void MGBjV8MtYksT4Fb2uO1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((EntityManager<IPublicApplicationToken, long>) obj0).SetupAutoFilter((ICriteria) obj1, (IEntityFilter) obj2, (EntityMetadata) obj3, (string) obj4));
    }

    internal static bool kRfYCyMujWrBQ6ob1eJ() => PublicApplicationTokenManager.q8tkGe1z3fUEhojiKg1 == null;

    internal static PublicApplicationTokenManager kRMljRMwRydHKuT7P5x() => PublicApplicationTokenManager.q8tkGe1z3fUEhojiKg1;

    internal static Type gyclCbMmnmeAsw3cLLj([In] object obj0, [In] object obj1) => ((EntityManager<IPublicApplicationToken, long>) obj0).GetFetchType((IEntityFilter) obj1);

    internal static object wy4iUWM6rKHX3MLPFUC(
      [In] object obj0,
      [In] object obj1,
      [In] Type obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((EntityManager<IPublicApplicationToken, long>) obj0).CreateCriteria((FetchOptions) obj1, obj2, (string) obj3, (IEntityFilter) obj4);
    }

    internal static object tG0R9kMk0bMvo1P1gHR([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object I6Ma64MDaJl3kCI2XyY([In] object obj0, [In] bool obj1) => (object) ((ICriteria) obj0).SetCacheable(obj1);

    internal static object NnUNHtMawuE1fPsPcDH([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetCacheRegion((string) obj1);

    internal static object wdScO0MxxHssv0XCZXg([In] object obj0) => (object) ((EntityManager<IPublicApplicationToken, long>) obj0).SecurityService;

    internal static bool lOe1eUMCN0KjiPh1Ve2([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).HasPermission((Permission) obj1);

    internal static void Pt1RuWMiZUVNG2r2Bi3([In] object obj0) => __nonvirtual (((EntityManager<IPublicApplicationToken, long>) obj0).DeleteAll());

    internal static void u0MPBwM3RxG6cTaO3CL() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object mV57d2Mjxm4xRMv51P9([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object q4CGBQMNC3Z4YudHAjS([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object lfYuwgM0aXcPMkmR1ud([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);
  }
}
