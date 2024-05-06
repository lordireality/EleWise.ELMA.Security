// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.ReplacementManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
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
  /// <summary>Менеджер объекта "Замещение"</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class ReplacementManager : EntityManager<IReplacement, long>
  {
    internal static ReplacementManager VQL2sdpndPGHlVRV24E;

    public IUnionComplexCacheService UnionComplexCacheService
    {
      get => this.\u003CUnionComplexCacheService\u003Ek__BackingField;
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
              this.\u003CUnionComplexCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 0 : 0;
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
    public static ReplacementManager Instance => Locator.GetServiceNotNull<ReplacementManager>();

    [PublicApiMember]
    [Transaction]
    [ActionMethod("42986da3-d210-414d-9225-f3cde17c18c9")]
    [Auditable]
    public override void Save(IReplacement obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ReplacementManager.ki8Dq6pznsTvhKgvVSw(ReplacementManager.FviCMkpHsDA7cXxdUQG(), (object) obj);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            ReplacementManager.NyAvWIOUNpBxulCcSXi((object) this.UnionComplexCacheService, ReplacementManager.YPnkCqOo2dISDkl1nmu((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818797382), (object) ((IEntity<long>) ReplacementManager.zPnnP5ORqBcxZjW0LBg((object) obj)).Id));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 2 : 2;
            continue;
          case 4:
            ReplacementManager.NyAvWIOUNpBxulCcSXi((object) this.UnionComplexCacheService, ReplacementManager.qbMENGOKSysVqY0O2PX(ReplacementManager.cm4I1yOuwVhsWFgoxtU(839394233 ^ 839447829), (object) (ReplacementManager.e5JY8VOwOjfAOtefR9s((object) obj) == null ? new long?() : new long?(((IEntity<long>) ReplacementManager.e5JY8VOwOjfAOtefR9s((object) obj)).Id)), (object) ReplacementManager.JMCvwBObcsRwUFYuPv7()));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 1 : 3;
            continue;
          default:
            base.Save(obj);
            num = 4;
            continue;
        }
      }
label_6:;
    }

    /// <inheritdoc />
    public override ActionCheckResult CanSave(IReplacement obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj.SourceUser == ReplacementManager.zPnnP5ORqBcxZjW0LBg((object) obj))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ActionCheckResult.False((string) ReplacementManager.XcLr3XOtYWXFn39m5Ry(ReplacementManager.cm4I1yOuwVhsWFgoxtU(-1277802350 ^ -1277780098)));
label_5:
      return base.CanSave(obj);
    }

    /// <summary>Возвращает замещения</summary>
    /// <param name="user">Замещаемый пользователь</param>
    /// <returns>Список замещений</returns>
    public IList<IReplacement> GetReplacements(EleWise.ELMA.Security.IUser user) => this.FindPlannedReplacement(user, (EleWise.ELMA.Security.IUser) null, new DateTime?(DateTime.Today), new DateTime?(DateTime.MaxValue));

    /// <summary>Возвращает замещения (из кэша)</summary>
    /// <param name="user">Замещаемый пользователь</param>
    /// <returns>Список замещений</returns>
    public IList<IReplacement> GetReplacementsReadOnly(EleWise.ELMA.Security.IUser user) => this.UnionComplexCacheService.GetOrAdd<IList<IReplacement>>(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--2002186503 ^ 2002135367), user != null ? user.GetId() : (object) null, (object) DateTime.Today), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868781623), user != null ? user.GetId() : (object) null, (object) DateTime.Today), (Func<IList<IReplacement>>) (() => this.GetReplacements(user)), TimeSpan.FromDays(1.0));

    /// <summary>
    /// Возращает список идентификаторов пользователей, кого замещает пользователь
    /// </summary>
    /// <param name="user">Замещающий пользователь</param>
    /// <returns>Список идентификаторов замещаемых пользователей</returns>
    public long[] GetReplacedUsers([NotNull] EleWise.ELMA.Security.IUser user)
    {
      int num = 1;
      ReplacementManager replacementManager;
      EleWise.ELMA.Security.IUser user1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 0;
            continue;
          case 2:
            user1 = user;
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            replacementManager = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 2;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.UnionComplexCacheService.GetOrAdd<long[]>((string) ReplacementManager.YPnkCqOo2dISDkl1nmu((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629935560 ^ -1103494022 ^ 1682517694), ReplacementManager.qLPwf8Omw2ITKk41KVs((object) user1)), (string) ReplacementManager.YPnkCqOo2dISDkl1nmu(ReplacementManager.cm4I1yOuwVhsWFgoxtU(1820204600 ^ 1820248388), ReplacementManager.qLPwf8Omw2ITKk41KVs((object) user1)), (Func<long[]>) (() => ((ICriteria) ReplacementManager.\u003C\u003Ec__DisplayClass14_0.qdFePhwrQVf6OVLJ51aN(ReplacementManager.\u003C\u003Ec__DisplayClass14_0.XBGikVwrc6io4UTk0p3l(ReplacementManager.\u003C\u003Ec__DisplayClass14_0.HTbqW5wrfPjF05Dt0dgg(ReplacementManager.\u003C\u003Ec__DisplayClass14_0.rxVFWvwrlxAxs5BgUOiE((object) replacementManager), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>()), ReplacementManager.\u003C\u003Ec__DisplayClass14_0.WR3HsMwr4vfDR1N4STkD((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124918957), (object) user1)), (object) new IProjection[1]
      {
        (IProjection) ReplacementManager.\u003C\u003Ec__DisplayClass14_0.mjJUqNwrPf44o1XmDEbZ()
      })).List<long>().ToArray<long>()));
    }

    /// <summary>
    /// Находит все замещения на заданный период для указанных пользователей<br />
    /// если указан только параметр fromUser, то ищутся все замещения, где этот пользователь замещается<br />
    /// если указан только параметр toUser, то ищутся все замещения, где этот пользователь замещает<br />
    /// если указаны оба параметра, то ищутся все замещения, где пользователь toUser замещает или пользователь fromUser замещается или замещает
    /// </summary>
    /// <param name="fromUser">Замещаемый пользователь</param>
    /// <param name="toUser">Замещающий пользователь</param>
    /// <param name="startDate">Дата начала замещения</param>
    /// <param name="endDate">Дата оканчания</param>
    /// <param name="ignoreReplacementId">Идентификатор замещения, которое нужно игнорировать</param>
    /// <returns></returns>
    public virtual IList<IReplacement> FindPlannedReplacement(
      EleWise.ELMA.Security.IUser fromUser,
      EleWise.ELMA.Security.IUser toUser,
      DateTime? startDate,
      DateTime? endDate,
      long? ignoreReplacementId = null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ICriteria criteria = this.CreateCriteria().If(endDate.HasValue, (Func<ICriteria, ICriteria>) (c => (ICriteria) ReplacementManager.\u003C\u003Ec__DisplayClass15_0.x7fD8VwrXwgOjRroyyOE((object) c, ReplacementManager.\u003C\u003Ec__DisplayClass15_0.PoLBh2wrGRRAKZgdWii5(ReplacementManager.\u003C\u003Ec__DisplayClass15_0.CZF226wrEmVfslunDxbv(1433051380 + 1051547170 ^ -1810419386), (object) endDate)))).If(startDate.HasValue, (Func<ICriteria, ICriteria>) (c => (ICriteria) ReplacementManager.\u003C\u003Ec__DisplayClass15_0.x7fD8VwrXwgOjRroyyOE((object) c, ReplacementManager.\u003C\u003Ec__DisplayClass15_0.fmBTy7wr9L8xSRd8XD42((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112555882), (object) startDate)))).Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-296013529 ^ -296012549), (object) ReplacementStatus.Delete))).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340837072)));
      if (fromUser != null && toUser != null)
        criteria.Add((ICriterion) Restrictions.Disjunction().Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--306199571 ^ 306242891), (object) fromUser)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(334323849 << 5 ^ 2108466604), (object) fromUser)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880091293 >> 4 ^ -55020370), (object) toUser)));
      else if (fromUser != null)
      {
        criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169331410), (object) fromUser));
      }
      else
      {
        if (toUser == null)
          throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499961492));
        criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110195605 ^ 2110239513), (object) toUser));
      }
      if (ignoreReplacementId.HasValue)
        criteria.Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1608979279), (object) ignoreReplacementId.Value)));
      return criteria.SetCacheable(true).List<IReplacement>();
    }

    /// <summary>Найти замещения</summary>
    /// <param name="id"> id пользователя</param>
    /// <param name="startDate">Дата начала замещения</param>
    /// <param name="endDate">Дата оканчания</param>
    /// <returns></returns>
    public IList<IReplacement> FindPlannedReplacement(
      long? id,
      DateTime startDate,
      DateTime endDate)
    {
      if (!id.HasValue)
        return (IList<IReplacement>) null;
      EleWise.ELMA.Security.Models.IUser fromUser = UserManager.Instance.LoadOrNull(id.Value);
      return fromUser == null ? (IList<IReplacement>) null : this.FindPlannedReplacement((EleWise.ELMA.Security.IUser) fromUser, (EleWise.ELMA.Security.IUser) null, new DateTime?(startDate), new DateTime?(endDate));
    }

    /// <summary>Проверить актуальность замещения</summary>
    /// <param name="replacement"></param>
    /// <returns></returns>
    public bool CheckReplacementnData(IReplacement replacement)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ReplacementManager.gRWq3OOk2vmI9opGmvf(ReplacementManager.JMCvwBObcsRwUFYuPv7(), ReplacementManager.uauWkrO6E3VCSwtMr9M((object) replacement)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_4;
          case 3:
            if (replacement == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 2 : 2;
              continue;
            }
            goto case 1;
          case 4:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return ReplacementManager.J3BT54ODLUMdfA0XO3g(DateTime.Today, replacement.StartDate);
label_3:
      return false;
label_4:
      return false;
    }

    /// <summary>Поставить замещение</summary>
    /// <param name="replacement">Замещение</param>
    public void PutReplacement(IReplacement replacement)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.IUser sourceUser;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ReplacementManager.gvsrjeOCC7a5ulJI1PJ((object) sourceUser);
              num2 = 3;
              continue;
            case 2:
              goto label_16;
            case 3:
              goto label_12;
            case 4:
              this.SetUserReplacement(sourceUser, replacement);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 1 : 1;
              continue;
            case 5:
              this.SetUserReplacement(sourceUser, (IReplacement) null);
              num2 = 12;
              continue;
            case 6:
              ReplacementManager.E3duIjOxlw4Mb2DEenZ((object) replacement, ReplacementStatus.Delete);
              num2 = 10;
              continue;
            case 7:
              if (ReplacementManager.OavZr8Oa7Pctuj7Mb07(replacement.EndDate, ReplacementManager.JMCvwBObcsRwUFYuPv7()))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 6 : 5;
                continue;
              }
              goto case 10;
            case 8:
              goto label_9;
            case 9:
              if (sourceUser != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 6 : 11;
                continue;
              }
              goto label_3;
            case 10:
              this.Save(replacement);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
              continue;
            case 11:
              if (this.CheckReplacementnData(replacement))
              {
                num2 = 4;
                continue;
              }
              goto label_14;
            case 12:
              ReplacementManager.gvsrjeOCC7a5ulJI1PJ((object) sourceUser);
              num2 = 8;
              continue;
            default:
              sourceUser = replacement.SourceUser;
              num2 = 9;
              continue;
          }
        }
label_14:
        if (!this.CheckReplacementnData((IReplacement) ReplacementManager.YDd0IqOiFw1wMImu4jw((object) sourceUser)))
          num1 = 5;
        else
          goto label_22;
      }
label_16:
      return;
label_12:
      return;
label_9:
      return;
label_22:
      return;
label_3:;
    }

    /// <summary>Удалить замещение</summary>
    [Auditable]
    [Transaction]
    [PublicApiMember]
    public override void Delete(IReplacement replacement)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ReplacementManager.gvsrjeOCC7a5ulJI1PJ((object) replacement);
            num = 2;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (ReplacementManager.mhmdxmO3xqg35jaiWQU((object) replacement))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 0 : 0;
              continue;
            }
            if (ReplacementManager.YDd0IqOiFw1wMImu4jw(ReplacementManager.e5JY8VOwOjfAOtefR9s((object) replacement)) != replacement)
            {
              replacement.Status = ReplacementStatus.Delete;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 1 : 1;
              continue;
            }
            num = 5;
            continue;
          case 4:
            if (replacement != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 3 : 2;
              continue;
            }
            goto label_13;
          case 5:
            goto label_2;
          default:
            goto label_14;
        }
      }
label_3:
      return;
label_10:
      return;
label_2:
      return;
label_14:
      return;
label_13:;
    }

    /// <summary>Установить/снять пользователю замещение</summary>
    private void SetUserReplacement(EleWise.ELMA.Security.Models.IUser user, IReplacement replacement)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              goto label_8;
            case 2:
              if (ReplacementManager.MxRqTcOjIQ0ay6AbQjg((object) user) == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 1 : 1;
                continue;
              }
              goto case 10;
            case 3:
              user.DuplicateMessage = replacement != null ? replacement.DuplicateMessage : new bool?(false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 4 : 1;
              continue;
            case 4:
              user.EndReplacement = replacement == null ? new DateTime?() : new DateTime?(ReplacementManager.uauWkrO6E3VCSwtMr9M((object) replacement));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 3 : 5;
              continue;
            case 5:
              ReplacementManager.tQFfE0ONvJqIie4HCTJ((object) user, replacement != null ? ReplacementMode.AutoReplacement : ReplacementMode.None);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 6 : 1;
              continue;
            case 6:
              user.Replacement = replacement;
              num2 = 2;
              continue;
            case 7:
              this.UnionComplexCacheService.RefreshTimestamp((string) ReplacementManager.YPnkCqOo2dISDkl1nmu(ReplacementManager.cm4I1yOuwVhsWFgoxtU(1658561670 << 4 ^ 767205148), (object) user.ReplacementUser.Id));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 4 : 9;
              continue;
            case 8:
              if (ReplacementManager.MxRqTcOjIQ0ay6AbQjg((object) user) == null)
                goto case 9;
              else
                goto label_10;
            case 9:
              user.ReplacementUser = replacement?.TargetUser;
              num2 = 3;
              continue;
            case 10:
              ReplacementManager.NyAvWIOUNpBxulCcSXi((object) this.UnionComplexCacheService, ReplacementManager.YPnkCqOo2dISDkl1nmu(ReplacementManager.cm4I1yOuwVhsWFgoxtU(-1640694811 << 2 ^ 2027108584), (object) ((IEntity<long>) ReplacementManager.MxRqTcOjIQ0ay6AbQjg((object) user)).Id));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_10:
        num1 = 7;
      }
label_15:
      return;
label_8:
      return;
label_3:;
    }

    /// <summary>Завершить замещение</summary>
    public void Complete(IReplacement replacement)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              goto label_3;
            case 2:
              this.Delete(replacement);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 1 : 1;
              continue;
            case 3:
              if (ReplacementManager.e5JY8VOwOjfAOtefR9s((object) replacement) != null)
              {
                this.SetUserReplacement((EleWise.ELMA.Security.Models.IUser) ReplacementManager.e5JY8VOwOjfAOtefR9s((object) replacement), (IReplacement) null);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 3 : 5;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_10;
            case 5:
              ReplacementManager.gvsrjeOCC7a5ulJI1PJ((object) replacement.SourceUser);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 1 : 2;
              continue;
            default:
              goto label_13;
          }
        }
label_10:
        if (replacement != null)
          num1 = 3;
        else
          goto label_12;
      }
label_4:
      return;
label_3:
      return;
label_13:
      return;
label_12:;
    }

    /// <summary>Пересчет замещений</summary>
    [Transaction]
    public virtual void ConversionPlanReplacement()
    {
      int num1 = 3;
      IEnumerator<IReplacement> enumerator1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<EleWise.ELMA.Security.Models.IUser> enumerator2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
label_34:
                if (enumerator1.MoveNext())
                  goto label_36;
                else
                  goto label_35;
label_32:
                IReplacement current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.Delete(current);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_16;
                    case 3:
                      goto label_36;
                    default:
                      goto label_34;
                  }
                }
label_35:
                num3 = 2;
                goto label_32;
label_36:
                current = enumerator1.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0)
                {
                  num3 = 1;
                  goto label_32;
                }
                else
                  goto label_32;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_44;
                      default:
                        enumerator1.Dispose();
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_44:;
              }
            case 2:
              try
              {
label_5:
                if (ReplacementManager.Xe5EkmOssuCVnlMH33l((object) enumerator2))
                  goto label_8;
                else
                  goto label_6;
label_4:
                EleWise.ELMA.Security.Models.IUser current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      goto label_8;
                    case 3:
                      goto label_30;
                    default:
                      this.Complete((IReplacement) ReplacementManager.YDd0IqOiFw1wMImu4jw((object) current));
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 1 : 1;
                      continue;
                  }
                }
label_6:
                num5 = 3;
                goto label_4;
label_8:
                current = enumerator2.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0)
                {
                  num5 = 0;
                  goto label_4;
                }
                else
                  goto label_4;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num6 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0)
                    num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        enumerator2.Dispose();
                        num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_15;
                    }
                  }
                }
label_15:;
              }
            case 3:
              goto label_45;
            case 4:
              goto label_17;
            case 5:
label_16:
              enumerator1 = ((ICriteria) ReplacementManager.qvDqdyOSYyfEeeosp9q(ReplacementManager.qvDqdyOSYyfEeeosp9q(ReplacementManager.qvDqdyOSYyfEeeosp9q(ReplacementManager.muISPPO7njy9JSOeC9c((object) this, (object) null), ReplacementManager.NyRWb2OrdJjFTfNH2S6((object) Restrictions.Eq((string) ReplacementManager.cm4I1yOuwVhsWFgoxtU(-1640694811 << 2 ^ 2027153992), (object) ReplacementStatus.Delete))), ReplacementManager.K1jt4pOyOMbxnB9dVeZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901702826), (object) DateTime.Today)), ReplacementManager.B8MGijOVEgC6f89i5OW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-517128429 ^ -517080765), (object) ReplacementManager.JMCvwBObcsRwUFYuPv7()))).List<IReplacement>().GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 4 : 3;
              continue;
            case 6:
              goto label_46;
          }
label_30:
          enumerator1 = ((ICriteria) ReplacementManager.qvDqdyOSYyfEeeosp9q(ReplacementManager.qvDqdyOSYyfEeeosp9q(ReplacementManager.muISPPO7njy9JSOeC9c((object) this, (object) null), ReplacementManager.NyRWb2OrdJjFTfNH2S6(ReplacementManager.Y1PVEaOWZhj2Ytx7h9S((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587466557), (object) ReplacementStatus.Delete))), ReplacementManager.xTEWjMOYMowR7iwWBDP(ReplacementManager.cm4I1yOuwVhsWFgoxtU(1100789287 - 1555711667 ^ -454907574), (object) ReplacementManager.JMCvwBObcsRwUFYuPv7()))).List<IReplacement>().GetEnumerator();
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 0 : 1;
        }
label_45:
        object obj1 = ReplacementManager.fub6s3O04eaRjPuySJI();
        InstanceOf<IUserFilter> instanceOf = new InstanceOf<IUserFilter>();
        ReplacementManager.c0lEc2OZb7WPNIIhHZc((object) instanceOf.New, true);
        IUserFilter filter = instanceOf.New;
        object obj2 = ReplacementManager.UOFLDlOA4nA7PvA6spC();
        ICollection<EleWise.ELMA.Security.Models.IUser> source = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) obj1).Find((IEntityFilter) filter, (FetchOptions) obj2);
        // ISSUE: reference to a compiler-generated field
        Func<EleWise.ELMA.Security.Models.IUser, bool> func = ReplacementManager.\u003C\u003Ec.\u003C\u003E9__22_0;
        Func<EleWise.ELMA.Security.Models.IUser, bool> predicate;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          ReplacementManager.\u003C\u003Ec.\u003C\u003E9__22_0 = predicate = (Func<EleWise.ELMA.Security.Models.IUser, bool>) (user =>
          {
            int num7 = 1;
            DateTime today;
            DateTime? endReplacement;
            while (true)
            {
              switch (num7)
              {
                case 1:
                  endReplacement = user.EndReplacement;
                  num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 0 : 0;
                  continue;
                case 2:
                  if (!endReplacement.HasValue)
                  {
                    num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 3 : 2;
                    continue;
                  }
                  goto label_7;
                case 3:
                  goto label_6;
                default:
                  today = DateTime.Today;
                  num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 2;
                  continue;
              }
            }
label_6:
            return false;
label_7:
            // ISSUE: reference to a compiler-generated method
            return ReplacementManager.\u003C\u003Ec.hYaGjRwrpFyCCHm2QaeK(endReplacement.GetValueOrDefault(), today);
          });
        }
        else
          goto label_49;
label_48:
        enumerator2 = source.Where<EleWise.ELMA.Security.Models.IUser>(predicate).GetEnumerator();
        num1 = 2;
        continue;
label_49:
        predicate = func;
        goto label_48;
      }
label_46:
      return;
label_17:
      try
      {
label_19:
        if (ReplacementManager.Xe5EkmOssuCVnlMH33l((object) enumerator1))
          goto label_22;
        else
          goto label_20;
label_18:
        IReplacement current;
        int num8;
        while (true)
        {
          switch (num8)
          {
            case 1:
              this.PutReplacement(current);
              num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 2 : 3;
              continue;
            case 2:
              goto label_42;
            case 3:
              goto label_19;
            default:
              goto label_22;
          }
        }
label_42:
        return;
label_20:
        num8 = 2;
        goto label_18;
label_22:
        current = enumerator1.Current;
        num8 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0)
        {
          num8 = 1;
          goto label_18;
        }
        else
          goto label_18;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num9 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                ReplacementManager.dQBtnlOlWsXgVFlNnfc((object) enumerator1);
                num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 0 : 0;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
    }

    /// <summary>
    /// Добавление пользователя <see cref="!:user" /> в список исполнителей <see cref="!:users" /> с указанием замещения с учётом правил замещения
    /// </summary>
    /// <param name="entity">Объект для которого производится замещение пользователя</param>
    /// <param name="expr">Свойство объекта по которому делается замещение</param>
    /// <param name="users">Список исполнителей и их замещаемых</param>
    /// <param name="user">Добавляемый в список пользователь</param>
    /// <param name="denyReplacement">Запретить замещение</param>
    public static void AddUserToList<T>(
      T entity,
      System.Linq.Expressions.Expression<Func<T, object>> expr,
      List<EleWise.ELMA.Security.Models.IUser> users,
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement = false)
      where T : IEntity
    {
      if (users == null || user == null)
        return;
      EleWise.ELMA.Security.Models.IUser addUser = ReplacementManager.GetExecutor<T>(entity, expr, user, denyReplacement);
      if (users.Find((Predicate<EleWise.ELMA.Security.Models.IUser>) (u => u.Id == addUser.Id)) != null)
        return;
      users.Add(addUser);
    }

    /// <summary>
    /// Добавление не заблокированного пользователя <see cref="!:user" /> в список исполнителей <see cref="!:users" /> с указанием замещения с учётом правил замещения
    /// </summary>
    /// <param name="entity">Объект для которого производится замещение пользователя</param>
    /// <param name="expr">Свойство объекта по которому делается замещение</param>
    /// <param name="users">Список исполнителей и их замещаемых</param>
    /// <param name="user">Добавляемый в список пользователь</param>
    /// <param name="denyReplacement">Запретить замещение</param>
    public static void AddUserNotBlockToList<T>(
      T entity,
      System.Linq.Expressions.Expression<Func<T, object>> expr,
      List<EleWise.ELMA.Security.Models.IUser> users,
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement = false)
      where T : IEntity
    {
      if (users == null || user == null)
        return;
      EleWise.ELMA.Security.Models.IUser addUser = ReplacementManager.GetExecutor<T>(entity, expr, user, denyReplacement);
      if (users.Find((Predicate<EleWise.ELMA.Security.Models.IUser>) (u => u.Id == addUser.Id)) != null || addUser.Status == UserStatus.Blocked)
        return;
      users.Add(addUser);
    }

    /// <summary>
    /// Добавление пользователя <see cref="!:user" /> в список исполнителей <see cref="!:users" /> с указанием замещения
    /// </summary>
    /// <param name="users">Список исполнителей и их замещаемых</param>
    /// <param name="user">Добавляемый в список пользователь</param>
    /// <param name="denyReplacement">Запретить замещение</param>
    [Obsolete("Метод устарел, вместо него необходимо использовать одноимённый с другими параметрами")]
    public static void AddUserToList(
      List<Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>> users,
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement = false)
    {
      if (users == null || user == null)
        return;
      Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser> addUser = new Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>(ReplacementManager.GetExecutor(user, denyReplacement), ReplacementManager.GetExecutorReplaced(user, denyReplacement));
      Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser> pair = users.Find((Predicate<Pair<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>>) (u => u.First != null && u.First.Id == addUser.First.Id));
      if (pair == null)
      {
        users.Add(addUser);
      }
      else
      {
        if (addUser.Second != null)
          return;
        pair.Second = (EleWise.ELMA.Security.Models.IUser) null;
      }
    }

    /// <summary>Получить исполнителя (замещающий)</summary>
    /// <param name="entity">Объект для которого производится замещение пользователя</param>
    /// <param name="expr">Свойство объекта по которому делается замещение</param>
    /// <param name="user">Пользователь</param>
    /// <param name="denyReplacement"></param>
    /// <returns></returns>
    public static EleWise.ELMA.Security.Models.IUser GetExecutor<T>(
      T entity,
      System.Linq.Expressions.Expression<Func<T, object>> expr,
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement)
      where T : IEntity
    {
      return denyReplacement || user.ReplacementMode != ReplacementMode.AutoReplacement || user.ReplacementUser == null ? user : ReplacementRuleManager.Instance.AssignmentReplacementRule<T>(entity, expr, user.Replacement) ?? user.ReplacementUser;
    }

    /// <summary>Получить исполнителя (замещающий)</summary>
    /// <param name="user"></param>
    /// <param name="denyReplacement"></param>
    /// <returns></returns>
    [Obsolete("Метод устарел, вместо него необходимо использовать одноимённый с другими параметрами")]
    public static EleWise.ELMA.Security.Models.IUser GetExecutor(
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_4;
          case 2:
            if (ReplacementManager.MxRqTcOjIQ0ay6AbQjg((object) user) != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 3 : 0;
              continue;
            }
            goto label_4;
          case 3:
            goto label_5;
          case 5:
            if (denyReplacement)
            {
              num = 4;
              continue;
            }
            break;
        }
        if (ReplacementManager.uSpGjhOfyPcAFKkyGOG((object) user) == ReplacementMode.AutoReplacement)
          num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 2 : 2;
        else
          break;
      }
label_4:
      return user;
label_5:
      return (EleWise.ELMA.Security.Models.IUser) ReplacementManager.MxRqTcOjIQ0ay6AbQjg((object) user);
    }

    /// <summary>Получитель исполнителя (замещаемый)</summary>
    /// <param name="user"></param>
    /// <param name="denyReplacement"></param>
    /// <returns></returns>
    public static EleWise.ELMA.Security.Models.IUser GetExecutorReplaced(
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ReplacementManager.MxRqTcOjIQ0ay6AbQjg((object) user) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              goto label_9;
            case 3:
              if (ReplacementManager.uSpGjhOfyPcAFKkyGOG((object) user) == ReplacementMode.AutoReplacement)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 1 : 1;
                continue;
              }
              goto label_9;
            case 4:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_3:
        if (!denyReplacement)
          num1 = 3;
        else
          break;
      }
label_9:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_10:
      return user;
    }

    /// <summary>Получить замещающего</summary>
    /// <param name="entity">Объект для которого производится замещение пользователя</param>
    /// <param name="expr">Свойство объекта по которому делается замещение</param>
    /// <param name="user"></param>
    /// <param name="denyReplacement"></param>
    /// <returns></returns>
    public static EleWise.ELMA.Security.Models.IUser GetReplacementUser<T>(
      T entity,
      System.Linq.Expressions.Expression<Func<T, object>> expr,
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement)
      where T : IEntity
    {
      return ReplacementManager.GetReplacementUser<T>(entity, expr, user, denyReplacement, false);
    }

    /// <summary>Получать замещающего с учётом натройки в задаче</summary>
    /// <param name="entity"></param>
    /// <param name="expr"></param>
    /// <param name="user"></param>
    /// <param name="denyReplacement"></param>
    /// <param name="denyReplacementInTask"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static EleWise.ELMA.Security.Models.IUser GetReplacementUser<T>(
      T entity,
      System.Linq.Expressions.Expression<Func<T, object>> expr,
      EleWise.ELMA.Security.Models.IUser user,
      bool denyReplacement,
      bool denyReplacementInTask)
      where T : IEntity
    {
      return (user == null || denyReplacement || denyReplacementInTask || user.ReplacementMode != ReplacementMode.AutoReplacement ? (EleWise.ELMA.Security.Models.IUser) null : ReplacementRuleManager.Instance.AssignmentReplacementRule<T>(entity, expr, user.Replacement) ?? user.ReplacementUser) ?? user;
    }

    public ReplacementManager()
    {
      ReplacementManager.r4BHbXO4fqx2Zgoh66d();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Rn5GGBpLVRfNsuZRQk2() => ReplacementManager.VQL2sdpndPGHlVRV24E == null;

    internal static ReplacementManager x4Hl5Xp2hNIlSHYXZpJ() => ReplacementManager.VQL2sdpndPGHlVRV24E;

    internal static object FviCMkpHsDA7cXxdUQG() => (object) ReplacementRuleManager.Instance;

    internal static void ki8Dq6pznsTvhKgvVSw([In] object obj0, [In] object obj1) => ((ReplacementRuleManager) obj0).CreateDefaultRules((IReplacement) obj1);

    internal static object cm4I1yOuwVhsWFgoxtU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object e5JY8VOwOjfAOtefR9s([In] object obj0) => (object) ((IReplacement) obj0).SourceUser;

    internal static DateTime JMCvwBObcsRwUFYuPv7() => DateTime.Today;

    internal static object qbMENGOKSysVqY0O2PX([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void NyAvWIOUNpBxulCcSXi([In] object obj0, [In] object obj1) => ((IUnionComplexCacheService) obj0).RefreshTimestamp((string) obj1);

    internal static object zPnnP5ORqBcxZjW0LBg([In] object obj0) => (object) ((IReplacement) obj0).TargetUser;

    internal static object YPnkCqOo2dISDkl1nmu([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object XcLr3XOtYWXFn39m5Ry([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object qLPwf8Omw2ITKk41KVs([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static DateTime uauWkrO6E3VCSwtMr9M([In] object obj0) => ((IReplacement) obj0).EndDate;

    internal static bool gRWq3OOk2vmI9opGmvf([In] DateTime obj0, [In] DateTime obj1) => obj0 <= obj1;

    internal static bool J3BT54ODLUMdfA0XO3g([In] DateTime obj0, [In] DateTime obj1) => obj0 >= obj1;

    internal static bool OavZr8Oa7Pctuj7Mb07([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static void E3duIjOxlw4Mb2DEenZ([In] object obj0, ReplacementStatus value) => ((IReplacement) obj0).Status = value;

    internal static void gvsrjeOCC7a5ulJI1PJ([In] object obj0) => ((IEntity) obj0).Save();

    internal static object YDd0IqOiFw1wMImu4jw([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).Replacement;

    internal static bool mhmdxmO3xqg35jaiWQU([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static object MxRqTcOjIQ0ay6AbQjg([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).ReplacementUser;

    internal static void tQFfE0ONvJqIie4HCTJ([In] object obj0, ReplacementMode value) => ((EleWise.ELMA.Security.Models.IUser) obj0).ReplacementMode = value;

    internal static object fub6s3O04eaRjPuySJI() => (object) UserManager.Instance;

    internal static void c0lEc2OZb7WPNIIhHZc([In] object obj0, bool value) => ((IUserFilter) obj0).ShowOnlyReplacement = value;

    internal static object UOFLDlOA4nA7PvA6spC() => (object) FetchOptions.All;

    internal static bool Xe5EkmOssuCVnlMH33l([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object muISPPO7njy9JSOeC9c([In] object obj0, [In] object obj1) => (object) ((EntityManager<IReplacement, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object Y1PVEaOWZhj2Ytx7h9S([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object NyRWb2OrdJjFTfNH2S6([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object qvDqdyOSYyfEeeosp9q([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object xTEWjMOYMowR7iwWBDP([In] object obj0, [In] object obj1) => (object) Restrictions.Lt((string) obj0, obj1);

    internal static object K1jt4pOyOMbxnB9dVeZ([In] object obj0, [In] object obj1) => (object) Restrictions.Ge((string) obj0, obj1);

    internal static object B8MGijOVEgC6f89i5OW([In] object obj0, [In] object obj1) => (object) Restrictions.Le((string) obj0, obj1);

    internal static void dQBtnlOlWsXgVFlNnfc([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static ReplacementMode uSpGjhOfyPcAFKkyGOG([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).ReplacementMode;

    internal static void r4BHbXO4fqx2Zgoh66d() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
