// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.ClientSessionDataSetsManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
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
  /// Менеджер сущности <see cref="T:EleWise.ELMA.Security.Models.API.IClientSessionDataSets" />
  /// </summary>
  public class ClientSessionDataSetsManager : EntityManager<IClientSessionDataSets, long>
  {
    private static readonly string SessionTokenPropName;
    internal static ClientSessionDataSetsManager hAn71ZXHxhZUIN4w49m;

    /// <summary>Статический экземпляр менеджера</summary>
    public ClientSessionDataSetsManager Instance => Locator.GetServiceNotNull<ClientSessionDataSetsManager>();

    protected override void SetupAutoFilter(
      ICriteria criteria,
      IEntityFilter filter,
      EntityMetadata metadata,
      string alias = null)
    {
      int num = 5;
      IPublicClientSessionFilter clientSessionFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            ClientSessionDataSetsManager.XaVbwW9tYRGswTroNiE((object) (IPublicClientSessionFilter) filter, (object) null);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
            continue;
          case 3:
            if (ClientSessionDataSetsManager.GxHJWS9bOlwYumb12rO(ClientSessionDataSetsManager.dfk95l9waVsT6gIbFPf((object) clientSessionFilter)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 2 : 2;
              continue;
            }
            goto case 7;
          case 4:
            if (clientSessionFilter == null)
            {
              num = 8;
              continue;
            }
            goto case 3;
          case 5:
            clientSessionFilter = filter as IPublicClientSessionFilter;
            num = 4;
            continue;
          case 6:
            goto label_10;
          case 7:
            ClientSessionDataSetsManager.LaOMSE9ol1w4O38xncO((object) criteria, ClientSessionDataSetsManager.VA8SGv9RFRIYmS6yXeb(!string.IsNullOrEmpty(alias) ? ClientSessionDataSetsManager.L5HeNl9U4g3Spu1AOEG(ClientSessionDataSetsManager.hOnX1t9KFgE4xYUmlNi(-909559362 ^ -398405015 ^ 562647227), (object) alias, (object) ClientSessionDataSetsManager.SessionTokenPropName) : (object) ClientSessionDataSetsManager.SessionTokenPropName, ClientSessionDataSetsManager.dfk95l9waVsT6gIbFPf((object) clientSessionFilter)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 1;
            continue;
          default:
            ClientSessionDataSetsManager.CNx63q9miFHLtZtuGde((object) this, (object) criteria, (object) filter, (object) metadata, (object) alias);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 6 : 6;
            continue;
        }
      }
label_10:;
    }

    public IClientSessionDataSets FindByToken(string sessionToken)
    {
      int num = 3;
      ITransformationProvider serviceNotNull;
      string queryString;
      while (true)
      {
        switch (num)
        {
          case 1:
            queryString = (string) ClientSessionDataSetsManager.L5HeNl9U4g3Spu1AOEG(ClientSessionDataSetsManager.hOnX1t9KFgE4xYUmlNi(1124861159 ^ 1124908953), ClientSessionDataSetsManager.xS8hrs96iV1P7x7aHhW((object) serviceNotNull, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(213026252 ^ 213007914), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1007654939 ^ 1007625231)), (object) ((Dialect) ClientSessionDataSetsManager.urhBR89ku8aRITvlshC((object) serviceNotNull)).QuoteIfNeeded(ClientSessionDataSetsManager.SessionTokenPropName));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!ClientSessionDataSetsManager.GxHJWS9bOlwYumb12rO((object) sessionToken))
            {
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 1 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 2 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return (IClientSessionDataSets) null;
label_7:
      return ((IQuery) ClientSessionDataSetsManager.wrYQ8O9C5mlBYEsMP5w(ClientSessionDataSetsManager.Nh8H8I9xTe41PjKQ29i(ClientSessionDataSetsManager.Kcdl8T9amQdbhNdx16B((object) this.Session.CreateSQLQuery(queryString), ClientSessionDataSetsManager.hOnX1t9KFgE4xYUmlNi(1100789287 - 1555711667 ^ -454896812), ClientSessionDataSetsManager.fDVFqc9D9jDIlxCObiJ((object) this, (object) null)), ClientSessionDataSetsManager.hOnX1t9KFgE4xYUmlNi(1124861159 ^ 1124907215), (object) sessionToken), false)).UniqueResult<IClientSessionDataSets>();
    }

    public ClientSessionDataSetsManager()
    {
      ClientSessionDataSetsManager.OG3b8c9idBR3fNH3TcU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ClientSessionDataSetsManager()
    {
      int num = 3;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) ClientSessionDataSetsManager.meai3b9jwuiHh8QPQ4f(ClientSessionDataSetsManager.cSe1WK93e0F9UQiB3Ai(__typeref (IClientSessionDataSets)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1433051380 + 1051547170 ^ -1810376660));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 0 : 0;
            continue;
          case 3:
            ClientSessionDataSetsManager.OG3b8c9idBR3fNH3TcU();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 2 : 1;
            continue;
          default:
            // ISSUE: method reference
            ClientSessionDataSetsManager.SessionTokenPropName = LinqUtils.NameOf<IClientSessionDataSets>(System.Linq.Expressions.Expression.Lambda<Func<IClientSessionDataSets, object>>((System.Linq.Expressions.Expression) ClientSessionDataSetsManager.MjXdvj90H1aNHyVCewd((object) parameterExpression, (object) (MethodInfo) ClientSessionDataSetsManager.cMi9Gn9NcBm9XYcbqat(__methodref (IClientSessionDataSets.get_SessionToken))), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object dfk95l9waVsT6gIbFPf([In] object obj0) => (object) ((IPublicClientSessionFilter) obj0).SessionToken;

    internal static bool GxHJWS9bOlwYumb12rO([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object hOnX1t9KFgE4xYUmlNi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L5HeNl9U4g3Spu1AOEG([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object VA8SGv9RFRIYmS6yXeb([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object LaOMSE9ol1w4O38xncO([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void XaVbwW9tYRGswTroNiE([In] object obj0, [In] object obj1) => ((IPublicClientSessionFilter) obj0).SessionToken = (string) obj1;

    internal static void CNx63q9miFHLtZtuGde(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((EntityManager<IClientSessionDataSets, long>) obj0).SetupAutoFilter((ICriteria) obj1, (IEntityFilter) obj2, (EntityMetadata) obj3, (string) obj4));
    }

    internal static bool lSVeNqXzCC2EZyIZ9vU() => ClientSessionDataSetsManager.hAn71ZXHxhZUIN4w49m == null;

    internal static ClientSessionDataSetsManager R2rM1j9u0fihkDyoUpU() => ClientSessionDataSetsManager.hAn71ZXHxhZUIN4w49m;

    internal static object xS8hrs96iV1P7x7aHhW([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).NoLockTableExpression((string) obj1, (string) obj2);

    internal static object urhBR89ku8aRITvlshC([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static Type fDVFqc9D9jDIlxCObiJ([In] object obj0, [In] object obj1) => ((EntityManager<IClientSessionDataSets, long>) obj0).GetFetchType((IEntityFilter) obj1);

    internal static object Kcdl8T9amQdbhNdx16B([In] object obj0, [In] object obj1, [In] Type obj2) => (object) ((ISQLQuery) obj0).AddEntity((string) obj1, obj2);

    internal static object Nh8H8I9xTe41PjKQ29i([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetString((string) obj1, (string) obj2);

    internal static object wrYQ8O9C5mlBYEsMP5w([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static void OG3b8c9idBR3fNH3TcU() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static Type cSe1WK93e0F9UQiB3Ai([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object meai3b9jwuiHh8QPQ4f([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object cMi9Gn9NcBm9XYcbqat([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object MjXdvj90H1aNHyVCewd([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);
  }
}
