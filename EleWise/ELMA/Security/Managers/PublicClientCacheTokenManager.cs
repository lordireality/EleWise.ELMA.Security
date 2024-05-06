// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.PublicClientCacheTokenManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер локальных кэшей публичных приложений</summary>
  public class PublicClientCacheTokenManager : EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>
  {
    private static readonly string SessionPropName;
    private static readonly string TokenKeyPropName;
    private readonly ITransformationProvider transformationProvider;
    private static PublicClientCacheTokenManager CAjIghMZ8GugyXey7XG;

    /// <summary>Конструктор</summary>
    public PublicClientCacheTokenManager(ITransformationProvider transformationProvider)
    {
      PublicClientCacheTokenManager.HZGhSGM7mTNnVd8fUrJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Статический экземпляр менеджера</summary>
    public static PublicClientCacheTokenManager Instance => Locator.GetServiceNotNull<PublicClientCacheTokenManager>();

    public bool SetData(long cacheTokenId, long[] data)
    {
      int num1 = 1;
      IStatelessSession statelessSession;
      string str1;
      string str2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            object obj = PublicClientCacheTokenManager.ufvFmFMWKdvVjAEoahO((object) Locator.GetServiceNotNull<SessionFactoryHolder>());
            str1 = (string) PublicClientCacheTokenManager.L2GEIQMyu2ZA7eB2yhA(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-845204010 ^ 2052495102 ^ -1211539036), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-880091293 >> 4 ^ -55021778)), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0((object) this.transformationProvider.Dialect, PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(784628100 ^ 784644990)));
            str2 = string.Format((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(631805505 ^ 631788877), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(~-272519830 ^ 272535629)), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(1290337431 ^ 1290288749)), (object) ((Dialect) PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1530848604 ^ 1530799650)));
            statelessSession = (IStatelessSession) PublicClientCacheTokenManager.YuJ5rjMVOG3vTOIZBWw(obj);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_36;
          default:
            goto label_2;
        }
      }
label_2:
      bool flag;
      try
      {
        ITransaction transaction = (ITransaction) PublicClientCacheTokenManager.GRjOffMllikU76pWRMM((object) statelessSession);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              PublicClientCacheTokenManager.oM1SbgM42Ny2erP4d4n((object) ((IQuery) PublicClientCacheTokenManager.JpXbjfMf1AxnbOZ9kFD((object) statelessSession, (object) str1)).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(--1587467489 ^ 1587418995), cacheTokenId), false);
              int num3 = 9;
              int index;
              long[] numArray;
              long val;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    val = numArray[index];
                    num3 = 6;
                    continue;
                  case 2:
                  case 4:
                    if (index >= numArray.Length)
                    {
                      num3 = 3;
                      continue;
                    }
                    goto case 1;
                  case 3:
                    PublicClientCacheTokenManager.aAeukQMcN4bVAUQdLl1((object) transaction);
                    num3 = 7;
                    continue;
                  case 5:
                    index = 0;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 1 : 2;
                    continue;
                  case 6:
                    PublicClientCacheTokenManager.oM1SbgM42Ny2erP4d4n((object) ((IQuery) PublicClientCacheTokenManager.JpXbjfMf1AxnbOZ9kFD((object) statelessSession, (object) str2)).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-517128429 ^ -517079935), cacheTokenId).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(~-272519830 ^ 272535857), val), false);
                    num3 = 8;
                    continue;
                  case 7:
                    flag = true;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 0 : 0;
                    continue;
                  case 8:
                    ++index;
                    num3 = 4;
                    continue;
                  case 9:
                    numArray = data;
                    num3 = 5;
                    continue;
                  default:
                    goto label_36;
                }
              }
            }
            catch (Exception ex)
            {
              int num4 = 3;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    PublicClientCacheTokenManager.Y6FkW7M8sgAsAgir1kQ(PublicClientCacheTokenManager.YFNTxYMPRIcmgrQpLUh((object) this), PublicClientCacheTokenManager.EwtycDMQTpkssNq2n5O(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(1658561670 << 4 ^ 767200216)), (object) ex);
                    num4 = 2;
                    continue;
                  case 2:
                    PublicClientCacheTokenManager.rKn1F9M5DFsGK1VQSXi((object) transaction);
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    flag = false;
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_36;
                }
              }
            }
            finally
            {
              int num5;
              if (transaction == null)
                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 1 : 1;
              else
                goto label_26;
label_25:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_26:
              PublicClientCacheTokenManager.CoEAb7Mdk2Lq1SMQrt9((object) transaction);
              num5 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0)
              {
                num5 = 0;
                goto label_25;
              }
              else
                goto label_25;
            }
        }
      }
      finally
      {
        int num6;
        if (statelessSession == null)
          num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 1;
        else
          goto label_32;
label_31:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_32:
        PublicClientCacheTokenManager.CoEAb7Mdk2Lq1SMQrt9((object) statelessSession);
        num6 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0)
        {
          num6 = 2;
          goto label_31;
        }
        else
          goto label_31;
      }
label_36:
      return flag;
    }

    public bool UpdateData(long cacheTokenId, long[] updated, long[] deleted)
    {
      int num1 = 2;
      IStatelessSession statelessSession;
      string str1;
      string str2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            ISessionFactory sessionFactory = Locator.GetServiceNotNull<SessionFactoryHolder>().SessionFactory;
            str2 = (string) PublicClientCacheTokenManager.dbvp03MEg1t8tC819eM(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(--534238571 ^ 534189699), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0((object) this.transformationProvider.Dialect, PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(2110885667 - -1624984630 ^ -559146623)), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-909559362 ^ -398405015 ^ 562637101)), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(1690209562 ^ 116876444 ^ 1648962296)));
            str1 = (string) PublicClientCacheTokenManager.dbvp03MEg1t8tC819eM(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-1277802350 ^ -1277785186), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-1807813747 ^ -1807863467)), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-1691384762 ^ -1691400516)), (object) ((Dialect) PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1433051380 + 1051547170 ^ -1810418584)));
            statelessSession = sessionFactory.OpenStatelessSession();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 1 : 0;
            continue;
          default:
            goto label_41;
        }
      }
label_2:
      bool flag;
      try
      {
        ITransaction transaction = (ITransaction) PublicClientCacheTokenManager.GRjOffMllikU76pWRMM((object) statelessSession);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              long[] numArray = ((IEnumerable<long>) updated).Union<long>((IEnumerable<long>) deleted).ToArray<long>();
              int num3 = 16;
              int index;
              long val1;
              long val2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    PublicClientCacheTokenManager.aAeukQMcN4bVAUQdLl1((object) transaction);
                    num3 = 12;
                    continue;
                  case 2:
                    index = 0;
                    num3 = 13;
                    continue;
                  case 3:
                  case 4:
                    if (index < numArray.Length)
                    {
                      num3 = 14;
                      continue;
                    }
                    goto case 7;
                  case 5:
                    ++index;
                    num3 = 9;
                    continue;
                  case 6:
                    goto label_41;
                  case 7:
                    numArray = updated;
                    num3 = 2;
                    continue;
                  case 8:
                    PublicClientCacheTokenManager.oM1SbgM42Ny2erP4d4n((object) ((IQuery) PublicClientCacheTokenManager.JpXbjfMf1AxnbOZ9kFD((object) statelessSession, (object) str2)).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-901653144 ^ -901701894), cacheTokenId).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-1212789817 - 1827404527 ^ 1254790012), val2), false);
                    num3 = 10;
                    continue;
                  case 9:
                  case 13:
                    if (index >= numArray.Length)
                    {
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 1 : 1;
                      continue;
                    }
                    goto case 11;
                  case 10:
                    ++index;
                    num3 = 4;
                    continue;
                  case 11:
                    val1 = numArray[index];
                    num3 = 15;
                    continue;
                  case 12:
                    flag = true;
                    num3 = 6;
                    continue;
                  case 15:
                    PublicClientCacheTokenManager.oM1SbgM42Ny2erP4d4n((object) ((IQuery) PublicClientCacheTokenManager.JpXbjfMf1AxnbOZ9kFD((object) statelessSession, (object) str1)).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-757186336 ^ -757169294), cacheTokenId).SetParameter<long>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(784628100 ^ 784644640), val1), false);
                    num3 = 5;
                    continue;
                  case 16:
                    index = 0;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 3 : 2;
                    continue;
                  default:
                    val2 = numArray[index];
                    num3 = 8;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    transaction.Rollback();
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    flag = false;
                    num4 = 3;
                    continue;
                  case 3:
                    PublicClientCacheTokenManager.Y6FkW7M8sgAsAgir1kQ(PublicClientCacheTokenManager.YFNTxYMPRIcmgrQpLUh((object) this), PublicClientCacheTokenManager.EwtycDMQTpkssNq2n5O(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(868767899 ^ 868784931)), (object) ex);
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_41;
                }
              }
            }
            finally
            {
              int num5;
              if (transaction == null)
                num5 = 2;
              else
                goto label_31;
label_30:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_31:
              PublicClientCacheTokenManager.CoEAb7Mdk2Lq1SMQrt9((object) transaction);
              num5 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0)
              {
                num5 = 0;
                goto label_30;
              }
              else
                goto label_30;
            }
        }
      }
      finally
      {
        if (statelessSession != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                PublicClientCacheTokenManager.CoEAb7Mdk2Lq1SMQrt9((object) statelessSession);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
                continue;
              default:
                goto label_39;
            }
          }
        }
label_39:;
      }
label_41:
      return flag;
    }

    public long CountDeleted(
      Guid objectTypeUid,
      DateTime? from,
      string eqlQuery,
      DetachedCriteria subCriteria)
    {
      if (string.IsNullOrWhiteSpace(eqlQuery) || subCriteria == null)
        return 0;
      long contextCacheId = PublicClientCacheTokenManager.GetContextCacheId(objectTypeUid, (object) eqlQuery);
      return contextCacheId == 0L ? 0L : Convert.ToInt64(this.GetDeletedSqlQuery(objectTypeUid, subCriteria, contextCacheId, false).UniqueResult());
    }

    public IEnumerable<IEntityModelHistoryItem> FindDeleted(
      Guid objectTypeUid,
      DateTime? from,
      string eqlQuery,
      DetachedCriteria subCriteria)
    {
      if (string.IsNullOrWhiteSpace(eqlQuery) || subCriteria == null)
        return (IEnumerable<IEntityModelHistoryItem>) new IEntityModelHistoryItem[0];
      long contextCacheId = PublicClientCacheTokenManager.GetContextCacheId(objectTypeUid, (object) eqlQuery);
      if (contextCacheId == 0L)
        return (IEnumerable<IEntityModelHistoryItem>) new IEntityModelHistoryItem[0];
      IList list = this.GetDeletedSqlQuery(objectTypeUid, subCriteria, contextCacheId, false).List();
      List<IEntityModelHistoryItem> deleted = new List<IEntityModelHistoryItem>();
      foreach (object obj in (IEnumerable) list)
        deleted.Add((IEntityModelHistoryItem) new EntityModelHistoryItem()
        {
          ObjectId = Convert.ToInt64(obj),
          ActionTypeUid = DefaultEntityActions.DeleteGuid,
          ObjectTypeUid = objectTypeUid,
          CreationDate = DateTime.Now
        });
      return (IEnumerable<IEntityModelHistoryItem>) deleted;
    }

    [Transaction]
    public virtual long DeleteExpired(DateTime expireDateTime)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (PublicClientCacheTokenManager.HRt6txMXjWhIvkSn92t(PublicClientCacheTokenManager.CM1BaoMGfRVEx1tWKwa((object) this), (object) PermissionProvider.APIAdminPermission))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return 0;
label_5:
      return (long) ((ISession) PublicClientCacheTokenManager.TiQpaGM9Yllu5ZavCxt((object) this)).Delete((string) PublicClientCacheTokenManager.pQnpWJMMqJpFdebgfpj(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(781628008 - 11982093 ^ 769595655), (object) PublicClientCacheTokenManager.aESoSeM1XQepB808R4H((object) this, (object) null).FullName), (object) expireDateTime, (IType) NHibernateUtil.DateTime);
    }

    public bool Promote(Guid tokenKey, EleWise.ELMA.Security.Models.API.IPublicClientSession storedSession)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.API.IPublicClientCacheToken byTokenSession;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (byTokenSession == null)
            {
              num = 4;
              continue;
            }
            PublicClientCacheTokenManager.Y675QKMBMayMmCDYdcI((object) byTokenSession, PublicClientCacheTokenManager.RCSJAjMhZoOVtQHQahR());
            num = 3;
            continue;
          case 2:
            byTokenSession = this.FindByTokenSession(tokenKey, storedSession);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 1 : 1;
            continue;
          case 3:
            this.Save(byTokenSession);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_5:
      return false;
label_7:
      return true;
    }

    private static long GetContextCacheId(Guid objectTypeUid, object eqlQuery)
    {
      switch (1)
      {
        case 1:
          long contextCacheId;
          try
          {
            EleWise.ELMA.API.Models.IPublicClientSession orDefault = ContextVars.GetOrDefault<EleWise.ELMA.API.Models.IPublicClientSession>((string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-1115268484 ^ -1115250970));
            int num = 5;
            IPublicCacheService serviceNotNull;
            EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (!serviceNotNull.IsCacheValid(PublicClientCacheTokenManager.E9tNGrMpS4ypB9eggXQ((object) orDefault), serviceNotNull.GetTokenValue(objectTypeUid, (string) eqlQuery), out cacheToken))
                  {
                    num = 10;
                    continue;
                  }
                  goto case 4;
                case 2:
                case 9:
                  serviceNotNull = Locator.GetServiceNotNull<IPublicCacheService>();
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 1 : 1;
                  continue;
                case 4:
                  contextCacheId = PublicClientCacheTokenManager.TC9Wl2MORoQ8lOyYxla((object) cacheToken);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 6 : 1;
                  continue;
                case 5:
                  if (orDefault != null)
                  {
                    num = 9;
                    continue;
                  }
                  goto case 7;
                case 7:
                  contextCacheId = 0L;
                  num = 3;
                  continue;
                case 8:
                case 10:
                  contextCacheId = 0L;
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_15;
              }
            }
          }
          catch (VariableNotFoundException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0)
              num = 0;
            switch (num)
            {
              default:
                goto label_14;
            }
          }
label_15:
          return contextCacheId;
      }
label_14:
      return 0;
    }

    private IQuery GetDeletedSqlQuery(
      Guid objectTypeUid,
      DetachedCriteria subCriteria,
      long tokenId,
      bool isCount)
    {
      int num1 = 19;
      ISQLQuery sqlQuery;
      while (true)
      {
        int num2 = num1;
        int num3;
        NHibernate.Engine.QueryParameters queryParameters;
        TypedValue namedParameter;
        CriteriaImpl criteriaImpl;
        IEnumerator<KeyValuePair<string, TypedValue>> enumerator;
        int index;
        CriteriaQueryTranslator translator;
        ISessionFactoryImplementor factory;
        object obj;
        string str;
        SqlString sqlString;
        while (true)
        {
          switch (num2)
          {
            case 1:
              translator = new CriteriaQueryTranslator(factory, criteriaImpl, (string) PublicClientCacheTokenManager.rLOvDLMvrlbsIj9vlSF((object) subCriteria), subCriteria.Alias);
              num2 = 27;
              continue;
            case 2:
            case 6:
            case 25:
label_16:
              if (PublicClientCacheTokenManager.UUq0Uvhb8PHlphPKU62((object) queryParameters) == null)
              {
                num2 = 3;
                continue;
              }
              goto case 13;
            case 3:
            case 14:
              goto label_8;
            case 4:
            case 9:
              if (num3 >= PublicClientCacheTokenManager.mpSdjUhuNJPePZhKx0m((object) queryParameters.NamedParameters))
              {
                num2 = 6;
                continue;
              }
              goto case 8;
            case 5:
            case 21:
              if (index >= PublicClientCacheTokenManager.UUq0Uvhb8PHlphPKU62((object) queryParameters).Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 11 : 14;
                continue;
              }
              goto case 7;
            case 7:
              PublicClientCacheTokenManager.UTfgoAMzQRGUHIZXIwu((object) sqlQuery, index, queryParameters.PositionalParameterValues[index], PublicClientCacheTokenManager.hOrHDRhKgmJfleBv7oq((object) queryParameters)[index]);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 17 : 20;
              continue;
            case 8:
              namedParameter = queryParameters.NamedParameters[string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801359385), (object) num3)];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 16 : 0;
              continue;
            case 10:
              enumerator = queryParameters.NamedParameters.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 0 : 0;
              continue;
            case 11:
              criteriaImpl = this.GetCriteriaImpl(subCriteria);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 1 : 1;
              continue;
            case 12:
              goto label_37;
            case 13:
              index = 0;
              num2 = 5;
              continue;
            case 15:
              if (queryParameters.NamedParameters == null)
              {
                num2 = 25;
                continue;
              }
              goto case 22;
            case 16:
              PublicClientCacheTokenManager.UTfgoAMzQRGUHIZXIwu((object) sqlQuery, num3, PublicClientCacheTokenManager.GqAecFM20sunj1CMQZO((object) namedParameter), PublicClientCacheTokenManager.RExLc6MHmbVD8i9OaUm((object) namedParameter));
              num2 = 23;
              continue;
            case 17:
              num3 = 0;
              num2 = 9;
              continue;
            case 18:
              factory = (ISessionFactoryImplementor) PublicClientCacheTokenManager.ufvFmFMWKdvVjAEoahO((object) Locator.GetServiceNotNull<SessionFactoryHolder>());
              num2 = 11;
              continue;
            case 19:
              goto label_36;
            case 20:
              ++index;
              num2 = 21;
              continue;
            case 22:
              if (PublicClientCacheTokenManager.fIqSFjMLal5L5gm7Zjn((object) sqlQuery).Length == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 17 : 17;
                continue;
              }
              goto case 10;
            case 23:
              ++num3;
              num2 = 4;
              continue;
            case 24:
              str = (string) PublicClientCacheTokenManager.PhGTo1MeECL2PJHrI1d(PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(1530848604 ^ 1530798522), (object) new object[5]
              {
                PublicClientCacheTokenManager.kJhEi8MIB09SD1DuH99(!isCount ? (object) "" : PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-814831182 ^ -814846744), PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(1100789287 - 1555711667 ^ -454906870)), !isCount ? (object) "" : PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(1095474805 ^ 155418997 ^ 1208520920)),
                PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-389167216 ^ -389216952)),
                PublicClientCacheTokenManager.CaPTM2MYkaQ0IUeC9D0(PublicClientCacheTokenManager.NtphvjMSlXxgVC3Jd9M((object) this.transformationProvider), PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(213026252 ^ 213010230)),
                (object) tokenId,
                (object) sqlString
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 10 : 12;
              continue;
            case 26:
              queryParameters = translator.GetQueryParameters();
              num2 = 15;
              continue;
            case 27:
              sqlString = (SqlString) PublicClientCacheTokenManager.SmtuI9MJ258RNbTAa27((object) new CriteriaJoinWalker((IOuterJoinLoadable) PublicClientCacheTokenManager.eby6mwMqaYJuyM2g39P((object) ((ISession) PublicClientCacheTokenManager.TiQpaGM9Yllu5ZavCxt((object) this)).GetSessionImplementation(), (object) subCriteria.EntityOrClassName, obj), translator, factory, (ICriteria) translator.RootCriteria, (string) PublicClientCacheTokenManager.rLOvDLMvrlbsIj9vlSF((object) subCriteria), ((ISessionImplementor) PublicClientCacheTokenManager.yh3CYfMgxmrwM18AvZP((object) this.Session)).EnabledFilters));
              num2 = 24;
              continue;
            default:
              try
              {
label_25:
                if (enumerator.MoveNext())
                  goto label_23;
                else
                  goto label_26;
label_22:
                KeyValuePair<string, TypedValue> current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_16;
                    case 2:
                      PublicClientCacheTokenManager.dNtZR0hwnJKtif3TeFU((object) sqlQuery, (object) current.Key, current.Value.Value, PublicClientCacheTokenManager.RExLc6MHmbVD8i9OaUm((object) current.Value));
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_23;
                    default:
                      goto label_25;
                  }
                }
label_23:
                current = enumerator.Current;
                num4 = 2;
                goto label_22;
label_26:
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 1 : 0;
                goto label_22;
              }
              finally
              {
                int num5;
                if (enumerator == null)
                  num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 1;
                else
                  goto label_30;
label_29:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_30:
                PublicClientCacheTokenManager.CoEAb7Mdk2Lq1SMQrt9((object) enumerator);
                num5 = 2;
                goto label_29;
              }
          }
        }
label_36:
        obj = PublicClientCacheTokenManager.FP8n9xMFQYda3t5DSOL(PublicClientCacheTokenManager.EaAEE3MTuwIGgMc99vJ(objectTypeUid, true));
        num1 = 18;
        continue;
label_37:
        sqlQuery = (ISQLQuery) PublicClientCacheTokenManager.oacHV3MnpKXpwwfKklM((object) this.Session, (object) str);
        num1 = 26;
      }
label_8:
      return (IQuery) PublicClientCacheTokenManager.YMJHgyhUyWGqcZB5KkJ((object) sqlQuery, false);
    }

    private CriteriaImpl GetCriteriaImpl(DetachedCriteria subCriteria) => (CriteriaImpl) PublicClientCacheTokenManager.ARYfV9hRu5C1lWDjVjF((object) subCriteria, PublicClientCacheTokenManager.TiQpaGM9Yllu5ZavCxt((object) this));

    public EleWise.ELMA.Security.Models.API.IPublicClientCacheToken FindByTokenSession(
      Guid tokenKey,
      EleWise.ELMA.Security.Models.API.IPublicClientSession session)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_4;
          case 2:
            goto label_5;
          case 4:
            if (PublicClientCacheTokenManager.NIW0aghomu1kKEwtaA5(tokenKey, Guid.Empty))
            {
              num = 3;
              continue;
            }
            break;
        }
        if (session != null)
          num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 2 : 2;
        else
          break;
      }
label_4:
      return (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken) null;
label_5:
      object obj = PublicClientCacheTokenManager.AbEX83htWvLjCkBEfH4((object) this, (object) new FetchOptions(0, 1), PublicClientCacheTokenManager.aESoSeM1XQepB808R4H((object) this, (object) null), (object) null, (object) null);
      PublicClientCacheTokenManager.kX4v0Nh64uaA4GhETMu(obj, PublicClientCacheTokenManager.dQt26shmp5mR2Rjs6ru((object) PublicClientCacheTokenManager.TokenKeyPropName, (object) tokenKey));
      PublicClientCacheTokenManager.kX4v0Nh64uaA4GhETMu(obj, (object) Restrictions.Eq(PublicClientCacheTokenManager.SessionPropName, (object) session));
      return ((ICriteria) obj).UniqueResult<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken>();
    }

    static PublicClientCacheTokenManager()
    {
      int num = 3;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            parameterExpression = System.Linq.Expressions.Expression.Parameter(typeof (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken), (string) PublicClientCacheTokenManager.QMAlxqMr93RNps2OgPM(-617657301 ^ -617651439));
            num = 4;
            continue;
          case 2:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) PublicClientCacheTokenManager.b89AgChDZrGAWLSog9L(PublicClientCacheTokenManager.qu83hjhk5Q0V9lopbQT(__typeref (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-201065280 ^ -201075718));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 5 : 4;
            continue;
          case 3:
            PublicClientCacheTokenManager.HZGhSGM7mTNnVd8fUrJ();
            num = 2;
            continue;
          case 4:
            // ISSUE: method reference
            PublicClientCacheTokenManager.TokenKeyPropName = LinqUtils.NameOf<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken>(System.Linq.Expressions.Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, object>>((System.Linq.Expressions.Expression) PublicClientCacheTokenManager.rRwyg2hC6EGfr6voux3(PublicClientCacheTokenManager.BNr7cDhx3i7N9pgslVI((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken.get_TokenKey))), typeof (object)), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
            continue;
          case 5:
            // ISSUE: method reference
            PublicClientCacheTokenManager.SessionPropName = LinqUtils.NameOf<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken>(System.Linq.Expressions.Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, object>>((System.Linq.Expressions.Expression) PublicClientCacheTokenManager.BNr7cDhx3i7N9pgslVI((object) parameterExpression, (object) (MethodInfo) PublicClientCacheTokenManager.gKVPqohaZbLdIESUbDq(__methodref (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken.get_Session))), parameterExpression));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    internal static void HZGhSGM7mTNnVd8fUrJ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool AMNF3tMA1NZLjO2I2EP() => PublicClientCacheTokenManager.CAjIghMZ8GugyXey7XG == null;

    internal static PublicClientCacheTokenManager GusdCHMsPdlN7iW28Rh() => PublicClientCacheTokenManager.CAjIghMZ8GugyXey7XG;

    internal static object ufvFmFMWKdvVjAEoahO([In] object obj0) => (object) ((SessionFactoryHolder) obj0).SessionFactory;

    internal static object QMAlxqMr93RNps2OgPM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NtphvjMSlXxgVC3Jd9M([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object CaPTM2MYkaQ0IUeC9D0([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object L2GEIQMyu2ZA7eB2yhA([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object YuJ5rjMVOG3vTOIZBWw([In] object obj0) => (object) ((ISessionFactory) obj0).OpenStatelessSession();

    internal static object GRjOffMllikU76pWRMM([In] object obj0) => (object) ((IStatelessSession) obj0).BeginTransaction();

    internal static object JpXbjfMf1AxnbOZ9kFD([In] object obj0, [In] object obj1) => (object) ((IStatelessSession) obj0).CreateSQLQuery((string) obj1);

    internal static int oM1SbgM42Ny2erP4d4n([In] object obj0, [In] bool obj1) => ((IQuery) obj0).ExecuteUpdate(obj1);

    internal static void aAeukQMcN4bVAUQdLl1([In] object obj0) => ((ITransaction) obj0).Commit();

    internal static object YFNTxYMPRIcmgrQpLUh([In] object obj0) => (object) ((EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>) obj0).Logger;

    internal static object EwtycDMQTpkssNq2n5O([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void Y6FkW7M8sgAsAgir1kQ([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void rKn1F9M5DFsGK1VQSXi([In] object obj0) => ((ITransaction) obj0).Rollback();

    internal static void CoEAb7Mdk2Lq1SMQrt9([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object dbvp03MEg1t8tC819eM([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object CM1BaoMGfRVEx1tWKwa([In] object obj0) => (object) ((EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>) obj0).SecurityService;

    internal static bool HRt6txMXjWhIvkSn92t([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).HasPermission((Permission) obj1);

    internal static object TiQpaGM9Yllu5ZavCxt([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static System.Type aESoSeM1XQepB808R4H([In] object obj0, [In] object obj1) => ((EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>) obj0).GetFetchType((IEntityFilter) obj1);

    internal static object pQnpWJMMqJpFdebgfpj([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static DateTime RCSJAjMhZoOVtQHQahR() => DateTime.Now;

    internal static void Y675QKMBMayMmCDYdcI([In] object obj0, DateTime value) => ((EleWise.ELMA.Security.Models.API.IPublicClientCacheToken) obj0).LastAccess = value;

    internal static Guid E9tNGrMpS4ypB9eggXQ([In] object obj0) => ((EleWise.ELMA.API.Models.IPublicClientSession) obj0).AuthToken;

    internal static long TC9Wl2MORoQ8lOyYxla([In] object obj0) => ((EleWise.ELMA.API.Models.IPublicClientCacheToken) obj0).Id;

    internal static System.Type EaAEE3MTuwIGgMc99vJ([In] Guid obj0, [In] bool obj1) => ModelHelper.GetEntityType(obj0, obj1);

    internal static object FP8n9xMFQYda3t5DSOL([In] System.Type obj0) => InterfaceActivator.Create(obj0);

    internal static object rLOvDLMvrlbsIj9vlSF([In] object obj0) => (object) ((DetachedCriteria) obj0).EntityOrClassName;

    internal static object eby6mwMqaYJuyM2g39P([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ISessionImplementor) obj0).GetEntityPersister((string) obj1, obj2);

    internal static object yh3CYfMgxmrwM18AvZP([In] object obj0) => (object) ((ISession) obj0).GetSessionImplementation();

    internal static object SmtuI9MJ258RNbTAa27([In] object obj0) => (object) ((JoinWalker) obj0).SqlString;

    internal static object kJhEi8MIB09SD1DuH99([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object PhGTo1MeECL2PJHrI1d([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object oacHV3MnpKXpwwfKklM([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object fIqSFjMLal5L5gm7Zjn([In] object obj0) => (object) ((IQuery) obj0).NamedParameters;

    internal static object GqAecFM20sunj1CMQZO([In] object obj0) => ((TypedValue) obj0).Value;

    internal static object RExLc6MHmbVD8i9OaUm([In] object obj0) => (object) ((TypedValue) obj0).Type;

    internal static object UTfgoAMzQRGUHIZXIwu([In] object obj0, [In] int obj1, [In] object obj2, [In] object obj3) => (object) ((IQuery) obj0).SetParameter(obj1, obj2, (IType) obj3);

    internal static int mpSdjUhuNJPePZhKx0m([In] object obj0) => ((ICollection<KeyValuePair<string, TypedValue>>) obj0).Count;

    internal static object dNtZR0hwnJKtif3TeFU([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((IQuery) obj0).SetParameter((string) obj1, obj2, (IType) obj3);

    internal static object UUq0Uvhb8PHlphPKU62([In] object obj0) => (object) ((NHibernate.Engine.QueryParameters) obj0).PositionalParameterValues;

    internal static object hOrHDRhKgmJfleBv7oq([In] object obj0) => (object) ((NHibernate.Engine.QueryParameters) obj0).PositionalParameterTypes;

    internal static object YMJHgyhUyWGqcZB5KkJ([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static object ARYfV9hRu5C1lWDjVjF([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).GetExecutableCriteria((ISession) obj1);

    internal static bool NIW0aghomu1kKEwtaA5([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object AbEX83htWvLjCkBEfH4(
      [In] object obj0,
      [In] object obj1,
      [In] System.Type obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((EntityManager<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, long>) obj0).CreateCriteria((FetchOptions) obj1, obj2, (string) obj3, (IEntityFilter) obj4);
    }

    internal static object dQt26shmp5mR2Rjs6ru([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object kX4v0Nh64uaA4GhETMu([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static System.Type qu83hjhk5Q0V9lopbQT([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object b89AgChDZrGAWLSog9L([In] System.Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object gKVPqohaZbLdIESUbDq([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object BNr7cDhx3i7N9pgslVI([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object rRwyg2hC6EGfr6voux3([In] object obj0, [In] System.Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);
  }
}
