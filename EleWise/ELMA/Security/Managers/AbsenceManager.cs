// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.AbsenceManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
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
  /// <summary>Менеджер отсутствий пользователей</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class AbsenceManager : EntityManager<IAbsence, long>
  {
    internal const string Key = "EleWise_ELMA_ActiveAbsences";
    internal const string TimestampKey = "EleWise_ELMA_ActiveAbsences_TimeStamp";
    internal static AbsenceManager aYXPefhqFbE43xdmGIK;

    public IComplexCacheService ComplexCacheService
    {
      get => this.\u003CComplexCacheService\u003Ek__BackingField;
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
              this.\u003CComplexCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 0 : 0;
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

    [NotNull]
    public static AbsenceManager Instance => Locator.GetServiceNotNull<AbsenceManager>();

    [PublicApiMember]
    public override void Save(IAbsence obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            base.Save(obj);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Назначить отсутствие</summary>
    /// <param name="absence">Объект отсутствия</param>
    public void Assign(IAbsence absence)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            absence.Status = AbsenceStatus.Active;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Save(absence);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Отменить отсутствие</summary>
    /// <param name="absence">Объект отсутствия</param>
    public void Cancel(IAbsence absence)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Save(absence);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 0 : 0;
            continue;
          case 2:
            AbsenceManager.FWUWhchId8PCRDvmlER((object) absence, AbsenceStatus.Closed);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// Возращает актуальные отсутствия пользователя (отсутсвия отвязаны от сессии NHibernate)
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Список запланированных отсутствий</returns>
    public virtual IList<IAbsence> GetAbsences(EleWise.ELMA.Security.IUser user) => this.ComplexCacheService.GetOrAdd<IList<IAbsence>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1609027743) + user.GetId(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272499675) + user.GetId(), (Func<IList<IAbsence>>) (() => this.LoadAbsences(user)));

    private IList<IAbsence> LoadAbsences(EleWise.ELMA.Security.IUser user) => this.CreateCriteria().Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868769107), (object) user)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347044430), (object) AbsenceStatus.Active)).Add((ICriterion) Restrictions.Ge(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617026523 ^ 617076197), (object) DateTime.Today)).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1820204600 ^ 1820252166))).List<IAbsence>();

    /// <summary>Получить ближайшее отсутствие пользователя</summary>
    /// <param name="user">Пользователь</param>
    public IAbsence GetNearAbsence(EleWise.ELMA.Security.Models.IUser user) => ((ICriteria) AbsenceManager.OA4V8MBuHF0eA6rusA9((object) ((ICriteria) AbsenceManager.Xj8ZGVhLcMvvndeh8L0((object) ((ICriteria) AbsenceManager.Xj8ZGVhLcMvvndeh8L0(AbsenceManager.M2HH3OheH0v7gCw2lFk((object) this, (object) null), (object) Restrictions.Eq((string) AbsenceManager.lQcO0lhnNrPfWlyXNtb(1053060681 ^ 1053089639), (object) user.Id))).Add((ICriterion) AbsenceManager.NOB0YEh2x7TJvaop0LS(AbsenceManager.lQcO0lhnNrPfWlyXNtb(-1958977588 ^ -1958962702), (object) DateTime.Now)), AbsenceManager.qwFq30hHAaFefDkfo0q((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1820204600 ^ 1820204004), (object) AbsenceStatus.Active))).AddOrder((Order) AbsenceManager.DgXBU3hzTwkjdxx11ca(AbsenceManager.lQcO0lhnNrPfWlyXNtb(1780597820 ^ 1780548098))), 1)).UniqueResult<IAbsence>();

    /// <summary>Получить текущее отсутствие пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Отсутствие пользователя на текущую дату или Null</returns>
    public IAbsence GetTodayAbsence(EleWise.ELMA.Security.IUser user)
    {
      int num = 1;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            dateTime = AbsenceManager.xcZ5OoBwfGgETc1aL2Y();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ((ICriteria) AbsenceManager.OA4V8MBuHF0eA6rusA9(AbsenceManager.FiC5rWBUd76WJkD5ZDT(AbsenceManager.Xj8ZGVhLcMvvndeh8L0(AbsenceManager.Xj8ZGVhLcMvvndeh8L0((object) ((ICriteria) AbsenceManager.Xj8ZGVhLcMvvndeh8L0(AbsenceManager.M2HH3OheH0v7gCw2lFk((object) this, (object) null), AbsenceManager.qwFq30hHAaFefDkfo0q(AbsenceManager.lQcO0lhnNrPfWlyXNtb(-1751467293 ^ -1751466197), (object) user))).Add((ICriterion) AbsenceManager.bD2T9GBbN93sAy73cYq(AbsenceManager.lQcO0lhnNrPfWlyXNtb(-1751467293 ^ -1751483213), (object) dateTime)), AbsenceManager.Bh0X4NBK5XcVMs9R1CN(AbsenceManager.lQcO0lhnNrPfWlyXNtb(-1958977588 ^ -1958962702), (object) dateTime)), AbsenceManager.qwFq30hHAaFefDkfo0q((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458234575), (object) AbsenceStatus.Active)), AbsenceManager.DgXBU3hzTwkjdxx11ca(AbsenceManager.lQcO0lhnNrPfWlyXNtb(1055964645 ^ 1055947739))), 1)).UniqueResult<IAbsence>();
    }

    /// <summary>
    /// Найти активные отсутствия для пользователя, которые полностью или частично входят в указанный интервал дат
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="startDate">Начало интервала</param>
    /// <param name="endDate">Конец интервала</param>
    /// <returns>Список отсутствий</returns>
    public IList<IAbsence> FindIntersection(
      EleWise.ELMA.Security.IUser user,
      DateTime startDate,
      DateTime endDate)
    {
      if (user == null)
        return (IList<IAbsence>) null;
      return this.FindIntersection((IEnumerable<EleWise.ELMA.Security.IUser>) new EleWise.ELMA.Security.IUser[1]
      {
        user
      }, startDate, endDate);
    }

    /// <summary>
    /// Найти активные отсутствия для пользователей, которые полностью или частично входят в указанный интервал дат
    /// </summary>
    /// <param name="users">Список пользователей</param>
    /// <param name="startDate">Начало интервала</param>
    /// <param name="endDate">Конец интервала</param>
    /// <returns>Список отсутствий</returns>
    public IList<IAbsence> FindIntersection(
      IEnumerable<EleWise.ELMA.Security.IUser> users,
      DateTime startDate,
      DateTime endDate)
    {
      // ISSUE: reference to a compiler-generated method
      return users != null && users.Any<EleWise.ELMA.Security.IUser>() ? this.CreateCriteria().Add((ICriterion) Restrictions.And((ICriterion) Restrictions.Le(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691401706), (object) endDate), (ICriterion) Restrictions.Ge(z2jc63fLkugS1X8Q9N.tE1kD1vbB(552500104 ^ 552517046), (object) startDate))).Add((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1457346863 ^ -1457383425), users.Select<EleWise.ELMA.Security.IUser, object>((Func<EleWise.ELMA.Security.IUser, object>) (user => AbsenceManager.\u003C\u003Ec.VJW57hwWCd2sjtA1srqA((object) user))).ToArray<object>())).Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(781628008 - 11982093 ^ 769644679), (object) AbsenceStatus.Closed))).List<IAbsence>() : (IList<IAbsence>) null;
    }

    /// <summary>
    /// Найти активные отсутствия для пользователя, полностью входящие в указанный интервал дат
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="startDate">Начало интервала</param>
    /// <param name="endDate">Конец интервала</param>
    /// <returns>Список отсутствий</returns>
    public IList<IAbsence> GetPlannedAbsences(
      EleWise.ELMA.Security.IUser user,
      DateTime startDate,
      DateTime endDate)
    {
      return user != null ? this.CreateCriteria().Add((ICriterion) Restrictions.And((ICriterion) Restrictions.Ge(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687444864), (object) startDate), (ICriterion) Restrictions.Le(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55859818), (object) endDate))).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617711104), (object) user)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908196378), (object) AbsenceStatus.Active)).List<IAbsence>() : (IList<IAbsence>) null;
    }

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<IAbsence>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      AbsenceManager.lDhFnbBR2TBO3xRtAX1((object) exportRule1, type);
      AbsenceManager.eo3mKmBolpuVpNYP5K4((object) exportRule1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1711335411 ^ -1711284629));
      AbsenceManager.U25PKsBtpTxf2vkeot9((object) exportRule1, ExportRuleType.Export);
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      AbsenceManager.lDhFnbBR2TBO3xRtAX1((object) exportRule2, type);
      AbsenceManager.eo3mKmBolpuVpNYP5K4((object) exportRule2, AbsenceManager.lQcO0lhnNrPfWlyXNtb(711486506 ^ 711502356));
      exportRule2.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      AbsenceManager.lDhFnbBR2TBO3xRtAX1((object) exportRule3, type);
      AbsenceManager.eo3mKmBolpuVpNYP5K4((object) exportRule3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776382658));
      AbsenceManager.U25PKsBtpTxf2vkeot9((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      AbsenceManager.lDhFnbBR2TBO3xRtAX1((object) exportRule4, type);
      AbsenceManager.eo3mKmBolpuVpNYP5K4((object) exportRule4, AbsenceManager.lQcO0lhnNrPfWlyXNtb(658384612 ^ 658383672));
      AbsenceManager.U25PKsBtpTxf2vkeot9((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      AbsenceManager.lDhFnbBR2TBO3xRtAX1((object) exportRule5, type);
      AbsenceManager.eo3mKmBolpuVpNYP5K4((object) exportRule5, AbsenceManager.lQcO0lhnNrPfWlyXNtb(~248518394 ^ -248517721));
      AbsenceManager.U25PKsBtpTxf2vkeot9((object) exportRule5, ExportRuleType.Export);
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      AbsenceManager.lDhFnbBR2TBO3xRtAX1((object) exportRule6, type);
      AbsenceManager.eo3mKmBolpuVpNYP5K4((object) exportRule6, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1527733619 - 442652394 ^ -1970385301));
      AbsenceManager.U25PKsBtpTxf2vkeot9((object) exportRule6, ExportRuleType.Export);
      exportRuleList.Add(exportRule6);
      return exportRuleList;
    }

    /// <summary>Обновить кэш отсутствий</summary>
    internal void UpdateAbsencesCache()
    {
      int num1 = 4;
      IUserFilter filter;
      IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) AbsenceManager.CE3xOYB6PKkj92E67hO()).Find((IEntityFilter) filter, (FetchOptions) null).GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_22;
          case 3:
            AbsenceManager.CKwj58BmV1nVefivdRO((object) filter, false);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 1;
            continue;
          case 4:
            filter = InterfaceActivator.Create<IUserFilter>();
            num1 = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_22:
      return;
label_4:
      try
      {
label_11:
        if (AbsenceManager.WmxvcDBxDISe55dvolE((object) enumerator))
          goto label_13;
        else
          goto label_12;
label_6:
        EleWise.ELMA.Security.Models.IUser current;
        int num2;
        List<IAbsence> absenceList;
        while (true)
        {
          switch (num2)
          {
            case 1:
              absenceList = this.GetAbsences((EleWise.ELMA.Security.IUser) current).ToList<IAbsence>();
              num2 = 4;
              continue;
            case 2:
              AbsenceManager.xINh2ABkjPaJObv4fYb((object) this.ComplexCacheService, AbsenceManager.lQcO0lhnNrPfWlyXNtb(1200636245 >> 6 ^ 18747467));
              num2 = 3;
              continue;
            case 3:
              this.ComplexCacheService.GetOrAdd<IList<IAbsence>>(AbsenceManager.lQcO0lhnNrPfWlyXNtb(-1859356887 ^ -1859342035).ToString() + AbsenceManager.tSRlcxBDaS6AVUfXWRc((object) current), (string) AbsenceManager.GeQxCHBaU0pTVAoRbJs(AbsenceManager.lQcO0lhnNrPfWlyXNtb(-1958138283 - -279956781 ^ -1678202164), AbsenceManager.tSRlcxBDaS6AVUfXWRc((object) current)), (Func<IList<IAbsence>>) (() => (IList<IAbsence>) absenceList));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 5 : 4;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated method
              if (absenceList.RemoveAll((Predicate<IAbsence>) (k => k.EndDate <= AbsenceManager.\u003C\u003Ec.VR8NJLwWiQtCF6UiE3kX())) > 0)
              {
                num2 = 2;
                continue;
              }
              goto label_11;
            case 5:
              goto label_11;
            case 6:
              goto label_13;
            case 7:
              goto label_17;
            default:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 0 : 1;
              continue;
          }
        }
label_17:
        return;
label_12:
        num2 = 7;
        goto label_6;
label_13:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0)
        {
          num2 = 0;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_24;
              default:
                AbsenceManager.ImxMhlBCKk0DDF4ohK7((object) enumerator);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_24:;
      }
    }

    /// <summary>Заполнение кэша отсутствий для всех пользователей</summary>
    internal void InitAbsenceCache()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        IAbsenceFilter filter1;
        ICollection<IAbsence> absences1;
        IUserFilter filter2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              filter1 = InterfaceActivator.Create<IAbsenceFilter>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              filter2 = InterfaceActivator.Create<IUserFilter>();
              num2 = 4;
              continue;
            case 4:
              AbsenceManager.CKwj58BmV1nVefivdRO((object) filter2, false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 1 : 2;
              continue;
            case 5:
              goto label_12;
            case 6:
              absences1 = ((AbstractNHEntityManager<IAbsence, long>) AbsenceManager.crlM7fBj7ASLaXf2tlK()).Find((IEntityFilter) filter1, (FetchOptions) null);
              num2 = 3;
              continue;
            case 7:
              AbsenceManager.bSqhGpB3MLvJkaCR12B((object) filter1, new DateTimeRange(new DateTime?(AbsenceManager.k3qrDtBiwJvtREOwUov()), new DateTime?()));
              num2 = 6;
              continue;
            default:
              filter1.Status = new AbsenceStatus?(AbsenceStatus.Active);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 7 : 6;
              continue;
          }
        }
label_9:
        ICollection<EleWise.ELMA.Security.Models.IUser> outer = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) AbsenceManager.CE3xOYB6PKkj92E67hO()).Find((IEntityFilter) filter2, (FetchOptions) null);
        ICollection<IAbsence> inner = absences1;
        // ISSUE: reference to a compiler-generated field
        Func<IAbsence, EleWise.ELMA.Security.Models.IUser> func1 = AbsenceManager.\u003C\u003Ec.\u003C\u003E9__20_1;
        Func<IAbsence, EleWise.ELMA.Security.Models.IUser> innerKeySelector;
        if (func1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          AbsenceManager.\u003C\u003Ec.\u003C\u003E9__20_1 = innerKeySelector = (Func<IAbsence, EleWise.ELMA.Security.Models.IUser>) (absence => absence.User);
        }
        else
          goto label_16;
label_11:
        // ISSUE: reference to a compiler-generated field
        Func<EleWise.ELMA.Security.Models.IUser, IEnumerable<IAbsence>, \u003C\u003Ef__AnonymousType1<EleWise.ELMA.Security.Models.IUser, IList<IAbsence>>> func2 = AbsenceManager.\u003C\u003Ec.\u003C\u003E9__20_2;
        Func<EleWise.ELMA.Security.Models.IUser, IEnumerable<IAbsence>, \u003C\u003Ef__AnonymousType1<EleWise.ELMA.Security.Models.IUser, IList<IAbsence>>> resultSelector;
        if (func2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: object of a compiler-generated type is created
          AbsenceManager.\u003C\u003Ec.\u003C\u003E9__20_2 = resultSelector = (user, absences) => new \u003C\u003Ef__AnonymousType1<EleWise.ELMA.Security.Models.IUser, IList<IAbsence>>(user, absences as IList<IAbsence>);
        }
        else
          goto label_15;
label_14:
        outer.GroupJoin((IEnumerable<IAbsence>) inner, (Func<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>) (user => user), innerKeySelector, resultSelector).Each(k => this.ComplexCacheService.GetOrAdd<IList<IAbsence>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562638291) + k.User.GetId(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-817081027 ^ 243500131 ^ -1043365872) + k.User.GetId(), (Func<IList<IAbsence>>) (() => k.Absences)));
        num1 = 5;
        continue;
label_15:
        resultSelector = func2;
        goto label_14;
label_16:
        innerKeySelector = func1;
        goto label_11;
      }
label_12:;
    }

    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num = 5;
      IAbsenceFilter absenceFilter;
      EleWise.ELMA.Security.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = (EleWise.ELMA.Security.IUser) AbsenceManager.oTdwX8B0fbAcj6HucbE((object) absenceFilter, AbsenceManager.lQcO0lhnNrPfWlyXNtb(1801131332 >> 4 ^ 112571548), (object) null);
            num = 7;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (absenceFilter != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 1 : 0;
              continue;
            }
            goto label_8;
          case 4:
            absenceFilter = filter as IAbsenceFilter;
            num = 3;
            continue;
          case 5:
            AbsenceManager.htU82uBNrPwbGYh7wFS((object) this, (object) criteria, (object) filter);
            num = 4;
            continue;
          case 6:
            goto label_14;
          case 7:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 8 : 5;
              continue;
            }
            goto case 10;
          case 9:
            if (absenceFilter.Users.Any<EleWise.ELMA.Security.Models.IUser>())
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 10 : 11;
              continue;
            }
            goto label_19;
          case 10:
            criteria.Add((ICriterion) AbsenceManager.qwFq30hHAaFefDkfo0q(AbsenceManager.lQcO0lhnNrPfWlyXNtb(1690569372 >> 6 ^ 26416610), (object) user));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 0;
            continue;
          case 11:
            criteria.Add((ICriterion) Restrictions.In((string) AbsenceManager.lQcO0lhnNrPfWlyXNtb(-315619370 - -1325004768 ^ 1009384062), (ICollection) absenceFilter.Users.ToList<EleWise.ELMA.Security.Models.IUser>()));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 2 : 2;
            continue;
          default:
            if (absenceFilter.Users != null)
            {
              num = 9;
              continue;
            }
            goto label_2;
        }
      }
label_10:
      return;
label_14:
      return;
label_2:
      return;
label_19:
      return;
label_8:;
    }

    public AbsenceManager()
    {
      AbsenceManager.SHGuesBZa2M8ajsJ8IF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool A2ygOChgIBXffx084Ti() => AbsenceManager.aYXPefhqFbE43xdmGIK == null;

    internal static AbsenceManager dn8bGnhJmVGAnXWmoFa() => AbsenceManager.aYXPefhqFbE43xdmGIK;

    internal static void FWUWhchId8PCRDvmlER([In] object obj0, AbsenceStatus value) => ((IAbsence) obj0).Status = value;

    internal static object M2HH3OheH0v7gCw2lFk([In] object obj0, [In] object obj1) => (object) ((EntityManager<IAbsence, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object lQcO0lhnNrPfWlyXNtb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Xj8ZGVhLcMvvndeh8L0([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object NOB0YEh2x7TJvaop0LS([In] object obj0, [In] object obj1) => (object) Restrictions.Gt((string) obj0, obj1);

    internal static object qwFq30hHAaFefDkfo0q([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object DgXBU3hzTwkjdxx11ca([In] object obj0) => (object) Order.Asc((string) obj0);

    internal static object OA4V8MBuHF0eA6rusA9([In] object obj0, [In] int obj1) => (object) ((ICriteria) obj0).SetMaxResults(obj1);

    internal static DateTime xcZ5OoBwfGgETc1aL2Y() => DateTime.Now;

    internal static object bD2T9GBbN93sAy73cYq([In] object obj0, [In] object obj1) => (object) Restrictions.Le((string) obj0, obj1);

    internal static object Bh0X4NBK5XcVMs9R1CN([In] object obj0, [In] object obj1) => (object) Restrictions.Ge((string) obj0, obj1);

    internal static object FiC5rWBUd76WJkD5ZDT([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).AddOrder((Order) obj1);

    internal static void lDhFnbBR2TBO3xRtAX1([In] object obj0, [In] Type obj1) => ((ExportRule) obj0).ParentType = obj1;

    internal static void eo3mKmBolpuVpNYP5K4([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void U25PKsBtpTxf2vkeot9([In] object obj0, [In] ExportRuleType obj1) => ((ExportRule) obj0).ExportRuleType = obj1;

    internal static void CKwj58BmV1nVefivdRO([In] object obj0, bool value) => ((IUserFilter) obj0).ShowBlock = value;

    internal static object CE3xOYB6PKkj92E67hO() => (object) UserManager.Instance;

    internal static void xINh2ABkjPaJObv4fYb([In] object obj0, [In] object obj1) => ((IComplexCacheService) obj0).RefreshTimestamp((string) obj1);

    internal static object tSRlcxBDaS6AVUfXWRc([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object GeQxCHBaU0pTVAoRbJs([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static bool WmxvcDBxDISe55dvolE([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ImxMhlBCKk0DDF4ohK7([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static DateTime k3qrDtBiwJvtREOwUov() => DateTime.Today;

    internal static void bSqhGpB3MLvJkaCR12B([In] object obj0, DateTimeRange value) => ((IAbsenceFilter) obj0).EndDate = value;

    internal static object crlM7fBj7ASLaXf2tlK() => (object) AbsenceManager.Instance;

    internal static void htU82uBNrPwbGYh7wFS([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((EntityManager<IAbsence, long>) obj0).SetupFilter((ICriteria) obj1, (IEntityFilter) obj2));

    internal static object oTdwX8B0fbAcj6HucbE([In] object obj0, [In] object obj1, [In] object obj2) => obj0.GetPropertyValue((string) obj1, obj2);

    internal static void SHGuesBZa2M8ajsJ8IF() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
