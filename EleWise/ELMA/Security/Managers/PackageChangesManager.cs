// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.PackageChangesManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service.v1;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>
  /// Менеджер для реализации подсчета кэша изменений пакетов
  /// </summary>
  public class PackageChangesManager : EntityManager<IPackageChanges, long>
  {
    private static PackageChangesManager YCeB9wEdlxL9nn3D6J3;

    /// <summary>Экземпляр PackageChangesManager</summary>
    [NotNull]
    public static PackageChangesManager Instance => Locator.GetServiceNotNull<PackageChangesManager>();

    /// <summary>Сервисы обновления</summary>
    public IEnumerable<IUpdatePackageService> UpdatePackageServices { get; set; }

    /// <summary>Сервис работы с сессиями внешних приложений</summary>
    public IPublicClientService PublicClientService
    {
      get => this.\u003CPublicClientService\u003Ek__BackingField;
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
              this.\u003CPublicClientService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 0;
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

    /// <summary>
    /// Сервис, позволяющий создавать токены для авторизованных пользователей
    /// </summary>
    public IAuthenticationTokenService AuthenticationTokenService
    {
      get => this.\u003CAuthenticationTokenService\u003Ek__BackingField;
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
              this.\u003CAuthenticationTokenService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 0;
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

    /// <summary>Сервис для обеспечения работы внешних приложений</summary>
    public IPublicApplicationService PublicApplicationService
    {
      get => this.\u003CPublicApplicationService\u003Ek__BackingField;
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
              this.\u003CPublicApplicationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 0 : 0;
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

    /// <summary>Провайдер трасформации</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 0;
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

    /// <summary>Создать элемент кэша для пользователя</summary>
    /// <param name="count"></param>
    [Transaction]
    public virtual void CreatePackageChangesForUser(int count)
    {
      int num1 = 1;
      DetachedCriteria dc;
      IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            dc = (DetachedCriteria) PackageChangesManager.uK49QEE1J9o6SDpacUM(PackageChangesManager.xJpX1KEXWaYoik3XuTI(InterfaceActivator.TypeOf<IPackageChanges>()), PackageChangesManager.DRRO3ME9n1C4lhoVZba((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1212789817 - 1827404527 ^ 1254773364)));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_13;
          default:
            enumerator = ((ICriteria) PackageChangesManager.bYqBtPETZ1ixru5x6W9(PackageChangesManager.biTnp8EOUYpHHGOQeZl(PackageChangesManager.biTnp8EOUYpHHGOQeZl(PackageChangesManager.bflWjnEhEeGoOIknmWa((object) this, PackageChangesManager.TlyMgHEMbGgVOPjb47O(), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), (object) null, (object) null), PackageChangesManager.wltA1wEpl1jwDRjHCfM(PackageChangesManager.oWt3LeEBjftcMY7S79c(-17837901 ^ -17836689), (object) UserStatus.Active)), (object) Subqueries.PropertyNotIn((string) PackageChangesManager.oWt3LeEBjftcMY7S79c(-1527733619 - 442652394 ^ -1970385289), dc)), (object) Order.Asc((string) PackageChangesManager.oWt3LeEBjftcMY7S79c(911364681 ^ 911366045)))).SetMaxResults(count).List<EleWise.ELMA.Security.Models.IUser>().GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 2;
            continue;
        }
      }
label_13:
      return;
label_3:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_6;
label_4:
        EleWise.ELMA.Security.Models.IUser current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_12;
            case 3:
              InstanceOf<IPackageChanges> instanceOf = new InstanceOf<IPackageChanges>();
              instanceOf.New.Status = PackageChangesStatus.New;
              PackageChangesManager.NjtE5kEFko4EqKICIj4((object) instanceOf.New, current.Id);
              PackageChangesManager.P1dFxFEvBsYatlWj6rn((object) instanceOf.New);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_12:
        return;
label_6:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 2 : 2;
        goto label_4;
label_8:
        current = enumerator.Current;
        num2 = 3;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 0 : 2;
        else
          goto label_14;
label_11:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        enumerator.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    /// <summary>
    /// Получить пользователей, для которых нужно построить кэш
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    [Transaction]
    public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetTopUsersForPrepare(
      int count)
    {
      int num = EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331046654), 24);
      if (num < 0)
        num = 24;
      DetachedCriteria detachedCriteria = DetachedCriteria.For(InterfaceActivator.TypeOf<IPackageChanges>(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751467293 ^ -1751512365)).SetProjection((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110195605 ^ 2110240685)));
      AbstractCriterion lhs = Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1076316568 ^ 1076361686));
      string propertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440410901);
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.AddHours((double) -num);
      // ISSUE: variable of a boxed type
      __Boxed<long> ticks = (ValueType) dateTime.Ticks;
      SimpleExpression rhs = Restrictions.Le(propertyName, (object) ticks);
      AbstractCriterion abstractCriterion = Restrictions.Or((ICriterion) lhs, (ICriterion) rhs);
      DetachedCriteria dc = detachedCriteria.Add((ICriterion) abstractCriterion);
      IList<EleWise.ELMA.Security.Models.IUser> source = this.CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224809858)).Add((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-517128429 ^ -517107829), (ICollection) new int[2]
      {
        0,
        100
      })).Add((ICriterion) Subqueries.PropertyIn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1609016887), dc)).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776354366))).SetMaxResults(count).List<EleWise.ELMA.Security.Models.IUser>();
      if (source.Count > 0)
      {
        this.Session.CreateSQLQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169321266), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--180540780 ^ 180511842)), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928051752)), (object) 0, (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499934364)), (object) string.Join<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880091293 >> 4 ^ -55004934), source.Select<EleWise.ELMA.Security.Models.IUser, long>((Func<EleWise.ELMA.Security.Models.IUser, long>) (u => u.Id))))).ExecuteUpdate(false);
        this.Session.CleanUpCache(InterfaceActivator.TypeOf<IPackageChanges>());
      }
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) source;
    }

    /// <summary>Создать кэш для пользователя</summary>
    /// <param name="user"></param>
    [Transaction]
    public virtual void CreateCacheForUser(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 18;
      while (true)
      {
        IPublicClientSession publicClientSession;
        EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultSystemApplication systemApplication;
        Guid authToken;
        IPackageChanges packageChanges;
        PackageBase[] packages;
        PackageChangesManager packageChangesManager;
        switch (num1)
        {
          case 1:
            PackageChangesManager.tMXNkxEqOWNYBjuclX6();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 14 : 8;
            continue;
          case 2:
            PackageChangesManager.pYpJLEEngTTGtdf52hi((object) this.PublicClientService, PackageChangesManager.JeFegXEegZxGlLlXP99((object) publicClientSession));
            num1 = 16;
            continue;
          case 3:
            if (packages != null)
            {
              num1 = 11;
              continue;
            }
            break;
          case 4:
            goto label_8;
          case 5:
            PackageChangesService.InitEmptyDataSets();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 1 : 1;
            continue;
          case 6:
            packages = (PackageBase[]) null;
            num1 = 5;
            continue;
          case 7:
            if (packageChanges != null)
            {
              num1 = 6;
              continue;
            }
            goto label_6;
          case 8:
            ((ISecurityService) PackageChangesManager.FToHSMEIgmK1BappVVs((object) this)).RunByUser((EleWise.ELMA.Security.IUser) user, (Action) (() =>
            {
              int num2 = 3;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    packageChanges.ChangeDateTicks = new long?(PackageChangesManager.\u003C\u003Ec__DisplayClass24_0.EdMU0xwAtfJU4oApZScB().Ticks);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 0 : 0;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    ContextVars.Set<string>((string) PackageChangesManager.\u003C\u003Ec__DisplayClass24_0.inxBnvwAox5kLrFUCtfJ(784628100 ^ 784682646), authToken.ToString());
                    num2 = 2;
                    continue;
                  default:
                    IEnumerable<IUpdatePackageService> updatePackageServices = packageChangesManager.UpdatePackageServices;
                    // ISSUE: reference to a compiler-generated field
                    Func<IUpdatePackageService, IEnumerable<PackageBase>> func = PackageChangesManager.\u003C\u003Ec.\u003C\u003E9__24_2;
                    Func<IUpdatePackageService, IEnumerable<PackageBase>> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      PackageChangesManager.\u003C\u003Ec.\u003C\u003E9__24_2 = selector = (Func<IUpdatePackageService, IEnumerable<PackageBase>>) (p => p.CreatePackages(DateTime.MinValue));
                    }
                    else
                      goto label_8;
label_7:
                    packages = updatePackageServices.SelectMany<IUpdatePackageService, PackageBase>(selector).ToArray<PackageBase>();
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 1 : 0;
                    continue;
label_8:
                    selector = func;
                    goto label_7;
                }
              }
label_5:;
            }));
            num1 = 2;
            continue;
          case 9:
            goto label_23;
          case 10:
            publicClientSession = (IPublicClientSession) PackageChangesManager.rkWtbrEJEmMFUCo4wjl((object) this.PublicClientService, authToken, (object) systemApplication.DefaultToken);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 2 : 8;
            continue;
          case 11:
            PackageChangesManager.jcMHVPEHRM2FIT2pufs((object) packageChanges, PackageChangesManager.W2TrPvE2aBIPjobrU7u((object) packages));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
            continue;
          case 12:
            IEnumerable<EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultSystemApplication> defaultApplications = EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultApplications;
            // ISSUE: reference to a compiler-generated field
            Func<EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultSystemApplication, bool> func1 = PackageChangesManager.\u003C\u003Ec.\u003C\u003E9__24_0;
            Func<EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultSystemApplication, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              PackageChangesManager.\u003C\u003Ec.\u003C\u003E9__24_0 = predicate = (Func<EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultSystemApplication, bool>) (a => PackageChangesManager.\u003C\u003Ec.rJLQ8hwAwwGfr08ubN38(a.Uid, EleWise.ELMA.Security.Services.API.PublicApplicationService.AppUid_Agent));
            }
            else
              goto label_26;
label_25:
            systemApplication = defaultApplications.First<EleWise.ELMA.Security.Services.API.PublicApplicationService.DefaultSystemApplication>(predicate);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 10 : 10;
            continue;
label_26:
            predicate = func1;
            goto label_25;
          case 13:
            PackageChangesManager.P1dFxFEvBsYatlWj6rn((object) packageChanges);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 4 : 2;
            continue;
          case 14:
            authToken = PackageChangesManager.DR1PnIEgtrpFQDSEoND((object) this.AuthenticationTokenService, (object) user);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 9 : 12;
            continue;
          case 15:
            packageChanges = ((ICriteria) PackageChangesManager.biTnp8EOUYpHHGOQeZl(PackageChangesManager.biTnp8EOUYpHHGOQeZl(PackageChangesManager.bflWjnEhEeGoOIknmWa((object) this, (object) FetchOptions.First, InterfaceActivator.TypeOf<IPackageChanges>(), (object) null, (object) null), PackageChangesManager.wltA1wEpl1jwDRjHCfM(PackageChangesManager.oWt3LeEBjftcMY7S79c(-1212789817 - 1827404527 ^ 1254773364), (object) user.Id)), PackageChangesManager.wltA1wEpl1jwDRjHCfM(PackageChangesManager.oWt3LeEBjftcMY7S79c(--1403802000 ^ 1403802700), (object) PackageChangesStatus.New))).List<IPackageChanges>().FirstOrDefault<IPackageChanges>();
            num1 = 7;
            continue;
          case 16:
            PackageChangesManager.J4UFx3ELh5wEYfx6G2j((object) this.AuthenticationTokenService, authToken);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 3 : 3;
            continue;
          case 17:
            packageChangesManager = this;
            num1 = 15;
            continue;
          case 18:
            num1 = 17;
            continue;
        }
        PackageChangesManager.CATnw9EzGnihPif093Z((object) packageChanges, PackageChangesStatus.Completed);
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 13 : 10;
      }
label_8:
      return;
label_23:
      return;
label_6:;
    }

    public PackageChangesManager()
    {
      PackageChangesManager.pZKe5gGuMjPDL2XfY5x();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool MY92btEENOKGP498l7c() => PackageChangesManager.YCeB9wEdlxL9nn3D6J3 == null;

    internal static PackageChangesManager JDX6BWEGYFE4VaZ5Yau() => PackageChangesManager.YCeB9wEdlxL9nn3D6J3;

    internal static object xJpX1KEXWaYoik3XuTI([In] Type obj0) => (object) DetachedCriteria.For(obj0);

    internal static object DRRO3ME9n1C4lhoVZba([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object uK49QEE1J9o6SDpacUM([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).SetProjection((IProjection) obj1);

    internal static object TlyMgHEMbGgVOPjb47O() => (object) FetchOptions.All;

    internal static object bflWjnEhEeGoOIknmWa(
      [In] object obj0,
      [In] object obj1,
      [In] Type obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((EntityManager<IPackageChanges, long>) obj0).CreateCriteria((FetchOptions) obj1, obj2, (string) obj3, (IEntityFilter) obj4);
    }

    internal static object oWt3LeEBjftcMY7S79c(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wltA1wEpl1jwDRjHCfM([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object biTnp8EOUYpHHGOQeZl([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object bYqBtPETZ1ixru5x6W9([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).AddOrder((Order) obj1);

    internal static void NjtE5kEFko4EqKICIj4([In] object obj0, [In] long obj1) => ((IPackageChanges) obj0).UserId = obj1;

    internal static void P1dFxFEvBsYatlWj6rn([In] object obj0) => ((IEntity) obj0).Save();

    internal static Guid tMXNkxEqOWNYBjuclX6() => Guid.NewGuid();

    internal static Guid DR1PnIEgtrpFQDSEoND([In] object obj0, [In] object obj1) => ((IAuthenticationTokenService) obj0).CreateToken((EleWise.ELMA.Security.IUser) obj1);

    internal static object rkWtbrEJEmMFUCo4wjl([In] object obj0, [In] Guid obj1, [In] object obj2) => (object) ((IPublicClientService) obj0).CreateSession(obj1, (string) obj2);

    internal static object FToHSMEIgmK1BappVVs([In] object obj0) => (object) ((EntityManager<IPackageChanges, long>) obj0).SecurityService;

    internal static object JeFegXEegZxGlLlXP99([In] object obj0) => (object) ((IPublicClientSession) obj0).SessionToken;

    internal static bool pYpJLEEngTTGtdf52hi([In] object obj0, [In] object obj1) => ((IPublicClientService) obj0).RemoveSession((string) obj1);

    internal static void J4UFx3ELh5wEYfx6G2j([In] object obj0, [In] Guid obj1) => ((IAuthenticationTokenService) obj0).RemoveToken(obj1);

    internal static object W2TrPvE2aBIPjobrU7u([In] object obj0) => (object) ClassSerializationHelper.SerializeObjectByJson(obj0);

    internal static void jcMHVPEHRM2FIT2pufs([In] object obj0, [In] object obj1) => ((IPackageChanges) obj0).PackagesInfo = (string) obj1;

    internal static void CATnw9EzGnihPif093Z([In] object obj0, [In] PackageChangesStatus obj1) => ((IPackageChanges) obj0).Status = obj1;

    internal static void pZKe5gGuMjPDL2XfY5x() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
