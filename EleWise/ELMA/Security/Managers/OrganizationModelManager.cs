// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.OrganizationModelManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Diagrams.Elements;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Validation;
using EleWise.ELMA.Serialization;
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
using System.Text;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер оргструктуры</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class OrganizationModelManager : EntityManager<IOrganizationModel, int>
  {
    private List<OrganizationValidationMessage> messages;
    private List<Guid> ListTreeElement;
    private static Regex regexN;
    internal static OrganizationModelManager oVfYauBTsrQ9NcU6Tog;

    /// <summary>Сервис аутентификации</summary>
    public new IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 0 : 0;
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

    /// <summary>Сервис для кеширования</summary>
    public ICacheService CacheService
    {
      get => this.\u003CCacheService\u003Ek__BackingField;
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
              this.\u003CCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 0 : 0;
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

    /// <summary>Экземпляр менеджера</summary>
    public static OrganizationModelManager Instance => Locator.GetServiceNotNull<OrganizationModelManager>();

    /// <summary>
    /// Получить черновик.
    /// В качестве черновика берется сущность с минимальным Id. При ее отсутствии возвращает null
    /// </summary>
    /// <returns></returns>
    private IOrganizationModel GetDraft()
    {
      int num = 4;
      int? nullable;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (nullable.Value < 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            if (!nullable.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 4:
            nullable = ((ICriteria) OrganizationModelManager.Yfywf2BJi6I4a9MAXVm(OrganizationModelManager.himcA8BqgVRDugSDYte((object) this, (object) null), (object) new IProjection[1]
            {
              (IProjection) Projections.Min((IProjection) OrganizationModelManager.GmKIdBBgMjOlmRP6W9p())
            })).UniqueResult<int?>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 3 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (IOrganizationModel) null;
label_5:
      return this.LoadOrNull(nullable.Value);
    }

    /// <summary>Сохранить черновик оргструктуры</summary>
    /// <param name="obj">Черновик оргструктуры</param>
    [Transaction]
    [PublicApiMember]
    public override void Save(IOrganizationModel obj)
    {
      int num = 1;
      IOrganizationModel draft;
      while (true)
      {
        switch (num)
        {
          case 1:
            draft = this.GetDraft();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
            continue;
          case 2:
            IOrganizationModel organizationModel1 = draft;
            EleWise.ELMA.Security.Models.IUser currentUser1;
            OrganizationModelManager.heIb42BeWkDs5bwQ4cb((object) obj, (object) (currentUser1 = this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>()));
            EleWise.ELMA.Security.Models.IUser user1 = currentUser1;
            organizationModel1.CreationAuthor = user1;
            num = 10;
            continue;
          case 3:
            OrganizationModelManager.LvebmfpwP5gkqRs13Vq(OrganizationModelManager.NQpwpHpuaFsTerkE7XL((object) this), (object) draft);
            num = 5;
            continue;
          case 4:
            draft.Diagram = (OrganizationDiagram) OrganizationModelManager.ur2uDZB26OP9ATABUGl((object) obj);
            num = 8;
            continue;
          case 5:
            goto label_11;
          case 6:
            draft.ChangeDate = new DateTime?(obj.CreationDate = OrganizationModelManager.KKnyLCBnS71wfedsNu0());
            num = 12;
            continue;
          case 7:
            IOrganizationModel organizationModel2 = draft;
            DateTime now;
            OrganizationModelManager.hbXt9QBIC4g3rbWLEQi((object) obj, now = DateTime.Now);
            DateTime dateTime = now;
            OrganizationModelManager.hbXt9QBIC4g3rbWLEQi((object) organizationModel2, dateTime);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 2 : 2;
            continue;
          case 8:
            OrganizationModelManager.QrLDf3BzCkSppMfNcuF((object) draft, OrganizationModelManager.IkCChwBHl0FUX1A1QNh((object) obj));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 3 : 3;
            continue;
          case 9:
          case 10:
            draft.Description = (string) null;
            num = 4;
            continue;
          case 11:
            draft = this.Create();
            num = 7;
            continue;
          case 12:
            IOrganizationModel organizationModel3 = draft;
            EleWise.ELMA.Security.Models.IUser currentUser2;
            OrganizationModelManager.heIb42BeWkDs5bwQ4cb((object) obj, (object) (currentUser2 = this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>()));
            EleWise.ELMA.Security.Models.IUser user2 = currentUser2;
            OrganizationModelManager.xVWrhMBLonNgfpAs5Cf((object) organizationModel3, (object) user2);
            num = 9;
            continue;
          default:
            if (draft == null)
            {
              num = 11;
              continue;
            }
            goto case 6;
        }
      }
label_11:;
    }

    /// <summary>Загрузить черновик оргструктуры</summary>
    /// <returns>Черновик оргструктуры</returns>
    public virtual IOrganizationModel Load()
    {
      int num = 1;
      IOrganizationModel draft;
      IOrganizationModel organizationModel;
      while (true)
      {
        switch (num)
        {
          case 1:
            draft = this.GetDraft();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            organizationModel = draft;
            if (organizationModel == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 0 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return organizationModel;
label_6:
      InstanceOf<IOrganizationModel> instanceOf = new InstanceOf<IOrganizationModel>();
      OrganizationModelManager.GyxsQSpbqCgWtyYUsqp((object) instanceOf.New, (object) new OrganizationDiagram());
      return instanceOf.New;
    }

    /// <summary>Загрузить опубликованную версию оргструктуры</summary>
    /// <returns>Опубликованная версия оргструктуры или null</returns>
    public virtual IOrganizationModel LoadPublishedOrNull()
    {
      int num = 4;
      int? nullable;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (nullable.Value > 1)
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 3:
            if (!nullable.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            nullable = ((ICriteria) OrganizationModelManager.Yfywf2BJi6I4a9MAXVm(OrganizationModelManager.himcA8BqgVRDugSDYte((object) this, (object) null), (object) new IProjection[1]
            {
              (IProjection) OrganizationModelManager.PIiRnbpKSiI6xptK9hb(OrganizationModelManager.GmKIdBBgMjOlmRP6W9p())
            })).UniqueResult<int?>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 2 : 3;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (IOrganizationModel) null;
label_3:
      return this.LoadOrNull(nullable.Value);
    }

    /// <summary>Найти все версии оргструктуры</summary>
    /// <returns>Список версий оргструктуры</returns>
    public virtual ICollection<OrganizationVersionDTO> FindAllVersions() => (ICollection<OrganizationVersionDTO>) this.CreateCriteria().SetProjection((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617711132)), (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55886586)), (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-814831182 ^ -814815340)), (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1536327508 ^ -1536342326))).AddOrder(Order.Asc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1403802000 ^ 1403802692))).List<object[]>().Select<object[], OrganizationVersionDTO>((Func<object[], OrganizationVersionDTO>) (i =>
    {
      OrganizationVersionDTO allVersions = new OrganizationVersionDTO();
      allVersions.Id = (int) i[0];
      // ISSUE: reference to a compiler-generated method
      OrganizationModelManager.\u003C\u003Ec.i4KdTKwWqLRZJlPCg6lZ((object) allVersions, (DateTime) i[1]);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      OrganizationModelManager.\u003C\u003Ec.jWwWxMwWJOwS3OJewTHw((object) allVersions, !(i[2] is EleWise.ELMA.Security.Models.IUser) ? (object) string.Empty : OrganizationModelManager.\u003C\u003Ec.mbPb1ZwWgZB0bOUu5XTx((object) (EleWise.ELMA.Security.Models.IUser) i[2]));
      // ISSUE: reference to a compiler-generated method
      OrganizationModelManager.\u003C\u003Ec.HUEgP6wWIZ2QYoC728Mf((object) allVersions, (object) (string) i[3]);
      return allVersions;
    })).ToArray<OrganizationVersionDTO>();

    private void addSubElement(
      Element elementParent,
      OrganizationDiagram draftDiagram,
      OrganizationSubDiagram subDiagram)
    {
      int num1 = 2;
      List<OrganizationSubDiagrams>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_45;
          case 1:
            goto label_2;
          case 2:
            enumerator1 = subDiagram.OrganizationSubDiagrams.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 1 : 0;
            continue;
          default:
            goto label_41;
        }
      }
label_45:
      return;
label_41:
      return;
label_2:
      try
      {
label_6:
        if (enumerator1.MoveNext())
          goto label_4;
        else
          goto label_7;
label_3:
        OrganizationSubDiagrams current1;
        List<Element> list;
        IEnumerator<Element> enumerator2;
        Connector connector1;
        OrgConnectorElement connectorElement1;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_38;
            case 2:
              elementParent.OutputConnectors.Add(connector1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 4;
              continue;
            case 3:
              if (OrganizationModelManager.uZGJitpotg51k6YC4Nd((object) list) <= 0)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
            case 4:
              enumerator2 = current1.OrganizationSubDiagram.Elements.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 8 : 1;
              continue;
            case 5:
              goto label_4;
            case 6:
              if (OrganizationModelManager.Df8ynOpRutCfI9UyJwL(current1.Id, OrganizationModelManager.lZek4DpUko9IixyCMa2((object) elementParent)))
              {
                num2 = 12;
                continue;
              }
              goto label_6;
            case 7:
              ((ElementList) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) draftDiagram)).Add((Element) connectorElement1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 0;
              continue;
            case 8:
              goto label_10;
            case 9:
              OrgConnectorElement connectorElement2 = new OrgConnectorElement();
              OrganizationModelManager.MAgdFqpmD1W05dsbcaE((object) connectorElement2, OrganizationModelManager.aKGtW5pt8IQiGrbQSs4());
              connectorElement1 = connectorElement2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 7 : 7;
              continue;
            case 10:
            case 11:
              goto label_6;
            case 12:
              ElementList elements = current1.OrganizationSubDiagram.Elements;
              // ISSUE: reference to a compiler-generated field
              Func<Element, bool> func = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__15_0;
              Func<Element, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__15_0 = predicate = (Func<Element, bool>) (e =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        if (e is OrganizationElement)
                        {
                          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) == 0;
label_5:
                  return false;
                });
              }
              else
                goto label_48;
label_40:
              list = elements.Where<Element>(predicate).ToList<Element>();
              num2 = 3;
              continue;
label_48:
              predicate = func;
              goto label_40;
            default:
              Connector connector2 = new Connector();
              OrganizationModelManager.lWBDinpkFihZoEQRDCd((object) connector2, (object) list[0]);
              OrganizationModelManager.Qnk0L8pDTTQaT7kcJeG((object) connector2, (object) elementParent);
              connector1 = connector2;
              num2 = 2;
              continue;
          }
        }
label_38:
        return;
label_10:
        try
        {
label_22:
          if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator2))
            goto label_17;
          else
            goto label_23;
label_11:
          Element current2;
          NestedStructureElement elementParent1;
          int num4;
          while (true)
          {
            switch (num4)
            {
              case 1:
                this.addSubElement((Element) elementParent1, draftDiagram, subDiagram);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 0;
                continue;
              case 2:
                if (OrganizationModelManager.lZek4DpUko9IixyCMa2((object) current2) == list[0].Uid)
                {
                  num4 = 8;
                  continue;
                }
                goto case 5;
              case 3:
                goto label_6;
              case 4:
                if (elementParent1 != null)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 0 : 1;
                  continue;
                }
                goto label_22;
              case 5:
                OrganizationModelManager.YX4XRypaO2oWoj94EfO(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) draftDiagram), (object) current2);
                num4 = 6;
                continue;
              case 6:
                elementParent1 = current2 as NestedStructureElement;
                num4 = 4;
                continue;
              case 7:
                goto label_17;
              case 8:
                current2.InputConnectors.Add(connector1);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 5 : 4;
                continue;
              default:
                goto label_22;
            }
          }
label_17:
          current2 = enumerator2.Current;
          num4 = 2;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0)
          {
            num4 = 0;
            goto label_11;
          }
          else
            goto label_11;
label_23:
          num4 = 3;
          goto label_11;
        }
        finally
        {
          if (enumerator2 != null)
          {
            int num5 = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0)
              num5 = 0;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  goto label_29;
                default:
                  OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator2);
                  num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_29:;
        }
label_4:
        current1 = enumerator1.Current;
        num2 = 6;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
label_7:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 1 : 1;
        goto label_3;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    /// <summary>Сообщения после проверки</summary>
    public ICollection<OrganizationValidationMessage> Messages => (ICollection<OrganizationValidationMessage>) this.messages;

    /// <summary>True, если есть ошибки</summary>
    public bool HasErrors
    {
      get
      {
        List<OrganizationValidationMessage> messages = this.messages;
        Func<OrganizationValidationMessage, bool> func = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__20_0;
        Func<OrganizationValidationMessage, bool> predicate;
        if (func == null)
          OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__20_0 = predicate = (Func<OrganizationValidationMessage, bool>) (m => OrganizationModelManager.\u003C\u003Ec.Fx9OHCwWnpHeY4OXrR6L((object) m) == OrganizationValidationMessageType.Error);
        else
          goto label_1;
label_3:
        return messages.Count<OrganizationValidationMessage>(predicate) > 0;
label_1:
        predicate = func;
        goto label_3;
      }
    }

    /// <summary>True, если есть пердупреждения</summary>
    public bool HasWarning
    {
      get
      {
        List<OrganizationValidationMessage> messages = this.messages;
        Func<OrganizationValidationMessage, bool> func = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__22_0;
        Func<OrganizationValidationMessage, bool> predicate;
        if (func == null)
          OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__22_0 = predicate = (Func<OrganizationValidationMessage, bool>) (m => OrganizationModelManager.\u003C\u003Ec.Fx9OHCwWnpHeY4OXrR6L((object) m) == OrganizationValidationMessageType.Warning);
        else
          goto label_1;
label_3:
        return messages.Count<OrganizationValidationMessage>(predicate) > 0;
label_1:
        predicate = func;
        goto label_3;
      }
    }

    /// <summary>Проверить оргструктуру</summary>
    /// <param name="organizationModels"></param>
    /// <returns></returns>
    [Transaction]
    public virtual int Validate(IOrganizationModel organizationModels)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.ValidateOnly = true;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      int num2 = OrganizationModelManager.XsM6jEpi3UR03ZrNnqw((object) this, (object) organizationModels);
      this.ValidateOnly = false;
      return num2;
    }

    private bool ValidateOnly
    {
      get => this.\u003CValidateOnly\u003Ek__BackingField;
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
              this.\u003CValidateOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 0 : 0;
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

    /// <summary>Публиковать оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <returns>Версия опубликованной оргструктуры</returns>
    [Transaction]
    public virtual int Publish(IOrganizationModel organizationModel)
    {
      int num1 = 2;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            num2 = 0;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 1 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      try
      {
        num2 = this.PublishWarning(organizationModel);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (OrganizationModelPublishWarning ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
label_8:
      return num2;
    }

    /// <summary>Публиковать оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <param name="warning">Ошибка публикации</param>
    /// <returns>Версия опубликованной оргструктуры, в параметре warning вернем предупреждения если они были </returns>
    [Transaction]
    public virtual int Publish(
      IOrganizationModel organizationModel,
      out OrganizationModelPublishWarning warning)
    {
      int num1 = 3;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            warning = (OrganizationModelPublishWarning) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 1 : 1;
            continue;
          case 3:
            num2 = 0;
            num1 = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return num2;
label_5:
      try
      {
        num2 = this.PublishWarning(organizationModel);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_4;
        }
      }
      catch (OrganizationModelPublishWarning ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_4;
            default:
              warning = ex;
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 1 : 0;
              continue;
          }
        }
      }
    }

    /// <summary>Публиковать оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <param name="warning">Ошибка публикации</param>
    /// <returns>Версия опубликованной оргструктуры, в параметре warning вернем предупреждения если они были </returns>
    [Transaction]
    public virtual int Validate(
      IOrganizationModel organizationModel,
      out OrganizationModelPublishWarning warning)
    {
      int num1 = 1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = 0;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            warning = (OrganizationModelPublishWarning) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:
      return num2;
label_3:
      try
      {
        this.ValidateOnly = true;
        int num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_2;
            case 2:
              num2 = this.Publish(organizationModel, out warning);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 0 : 0;
              continue;
            default:
              this.ValidateOnly = false;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 1 : 1;
              continue;
          }
        }
      }
      catch (OrganizationModelPublishWarning ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_2;
            default:
              warning = ex;
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 1 : 1;
              continue;
          }
        }
      }
    }

    /// <summary>Публиковать оргструктуру</summary>
    /// <param name="organizationModels">Модель оргструктуры</param>
    /// <returns>Версия опубликованной оргструктуры</returns>
    private int PublishWarning(IOrganizationModel organizationModels)
    {
      int num1 = 66;
      IOrganizationModel organizationModel1;
      while (true)
      {
        int num2 = num1;
        OrganizationElement element1;
        OrganizationDiagram organizationDiagram;
        List<Element>.Enumerator enumerator1;
        IEnumerator<IGrouping<string, Element>> enumerator2;
        IEnumerator<Element> enumerator3;
        List<string> stringList;
        Dictionary<string, List<OrganizationModelManager.DuplicateElement>> dictionary;
        List<Element> elementList1;
        List<Guid> guidList1;
        string str1;
        string str2;
        List<Element> list1;
        string str3;
        List<Element> list2;
        while (true)
        {
          ICollection<IOrganizationItem> oldItems;
          IEnumerator<IOrganizationItem> enumerator4;
          OrganizationSubDiagram subDiagram;
          List<Element> list3;
          OrganizationElement element2;
          string str4;
          string str5;
          List<Connector>.Enumerator enumerator5;
          string str6;
          string str7;
          EleWise.ELMA.Model.Common.Filter filter;
          List<OrganizationSubDiagrams>.Enumerator enumerator6;
          List<OrganizationElement> list4;
          int num3;
          string str8;
          List<OrganizationModelManager.DuplicateElement>.Enumerator enumerator7;
          List<string>.Enumerator enumerator8;
          List<IGrouping<string, string>>.Enumerator enumerator9;
          List<OrganizationElement> elementsStack;
          List<IOrganizationItem> newItems;
          string str9;
          string str10;
          List<Element> list5;
          switch (num2)
          {
            case 1:
              if (!this.ValidateOnly)
              {
                num2 = 99;
                continue;
              }
              goto label_763;
            case 2:
              oldItems = ((AbstractNHEntityManager<IOrganizationItem, long>) OrganizationModelManager.ewGAMSp1jfNUB9Wkg3B()).Find((IEntityFilter) filter, (FetchOptions) null);
              num2 = 75;
              continue;
            case 3:
            case 16:
label_535:
              enumerator8 = stringList.GetEnumerator();
              num2 = 81;
              continue;
            case 4:
            case 35:
              IEnumerable<OrganizationElement> source1 = ((IEnumerable) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).OfType<OrganizationElement>();
              // ISSUE: reference to a compiler-generated field
              Func<OrganizationElement, bool> func1 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_5;
              Func<OrganizationElement, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_5 = predicate1 = (Func<OrganizationElement, bool>) (e =>
                {
                  int num4 = 2;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_3;
                      case 2:
                        if (e == null)
                        {
                          num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 1 : 1;
                          continue;
                        }
                        goto label_2;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  return string.IsNullOrWhiteSpace((string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e));
label_3:
                  return false;
                });
              }
              else
                goto label_721;
label_754:
              list4 = source1.Where<OrganizationElement>(predicate1).ToList<OrganizationElement>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 72 : 23;
              continue;
label_721:
              predicate1 = func1;
              goto label_754;
            case 5:
              goto label_503;
            case 6:
label_693:
              organizationModel1.Id = Convert.ToInt32(OrganizationModelManager.rsBsm1pqsA2b3c4fURi(OrganizationModelManager.NQpwpHpuaFsTerkE7XL((object) this), (object) organizationModel1));
              num2 = 45;
              continue;
            case 7:
              if (this.ValidateOnly)
              {
                num2 = 104;
                continue;
              }
              goto label_694;
            case 8:
              goto label_112;
            case 9:
              if (list3.Count == 0)
              {
                num2 = 41;
                continue;
              }
              goto case 83;
            case 10:
              goto label_21;
            case 11:
              if (!this.ValidateOnly)
              {
                num2 = 13;
                continue;
              }
              break;
            case 12:
              str5 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-201065280 ^ -201117538), (object) str4);
              num2 = 20;
              continue;
            case 13:
              OrganizationModelManager.nawPX0pr5GdkquXquWd((object) Logger.Log, OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--353012470 ^ 352993782), (object) new object[1]
              {
                (object) str3
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 0 : 0;
              continue;
            case 14:
              str8 = (string) OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(19590779 ^ 19538429));
              num2 = 67;
              continue;
            case 15:
              goto label_756;
            case 17:
              OrganizationModelManager.nawPX0pr5GdkquXquWd(OrganizationModelManager.GG6MGMpWDk1HSiQPvZo(), OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1859356887 ^ -1859339223), (object) new object[1]
              {
                (object) str10
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 49 : 1;
              continue;
            case 18:
              OrganizationModelManager.QrLDf3BzCkSppMfNcuF((object) organizationModel1, (object) organizationModels.SubDiagrams);
              num2 = 97;
              continue;
            case 19:
              OrganizationModelManager.heIb42BeWkDs5bwQ4cb((object) organizationModel1, OrganizationModelManager.b8tbgapNFhDvLnqZAuC((object) organizationModels) ?? OrganizationModelManager.iqd3Nep0TfmKLpDUfH8((object) organizationModels));
              num2 = 82;
              continue;
            case 20:
              if (this.ValidateOnly)
              {
                num2 = 111;
                continue;
              }
              goto case 96;
            case 21:
              goto label_18;
            case 22:
              goto label_691;
            case 23:
              str10 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(150349507 - 521039768 ^ -370706369), (object) new object[1]
              {
                (object) str9
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 61 : 30;
              continue;
            case 24:
              try
              {
label_10:
                if (enumerator1.MoveNext())
                  goto label_12;
                else
                  goto label_11;
label_8:
                Element current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_692;
                    case 2:
                      OrganizationModelManager.wVstBgpASNGKQaZ0CUm(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram), (object) current);
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_12;
                    default:
                      goto label_10;
                  }
                }
label_11:
                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 1 : 0;
                goto label_8;
label_12:
                current = enumerator1.Current;
                num5 = 2;
                goto label_8;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 25:
              goto label_59;
            case 26:
              if (list5.Count > 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 70 : 70;
                continue;
              }
              goto case 73;
            case 27:
              goto label_694;
            case 28:
              if (OrganizationModelManager.r4UB9GpddckqnaXp8a9((object) this.ListTreeElement) != ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).Where<Element>((Func<Element, bool>) (e => e is OrganizationElement)).Count<Element>())
              {
                num2 = 32;
                continue;
              }
              goto case 38;
            case 29:
            case 89:
              enumerator3 = organizationDiagram.Elements.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 98 : 18;
              continue;
            case 30:
              if (this.ValidateOnly)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 15 : 57;
                continue;
              }
              goto case 59;
            case 31:
              try
              {
label_712:
                if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator4))
                  goto label_703;
                else
                  goto label_713;
label_700:
                IOrganizationItem current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      OrganizationModelManager.XvjEPnppOEWj1VyFZxK((object) current, (object) null);
                      num7 = 4;
                      continue;
                    case 2:
                      OrganizationModelManager.uRETyDpvIgwiAoK47AY((object) current);
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 6 : 8;
                      continue;
                    case 3:
                      if (!OrganizationModelManager.r7pDU8pBVQPxtN8FCbS((object) current))
                      {
                        num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 1;
                        continue;
                      }
                      goto label_712;
                    case 4:
                      current.User = (EleWise.ELMA.Security.Models.IUser) null;
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 6 : 0;
                      continue;
                    case 5:
                      OrganizationModelManager.lnqRmwphwxIWvcgB6f9((object) this.CacheService, OrganizationModelManager.MSR9qVpMOjjAJv8Hryp(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--353012470 ^ 353001170), (object) current.GetType().FullName, (object) current.Id));
                      num7 = 11;
                      continue;
                    case 6:
                      OrganizationModelManager.mnsNqBpOgXPO5nuloPE((object) current.Users);
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 2 : 7;
                      continue;
                    case 7:
                      IOrganizationItem organizationItem = current;
                      OrganizationModelManager.lryBp6pFXr2Vv0lNvj8((object) organizationItem, OrganizationModelManager.xhXOQKpXZjyexx0lWVw(OrganizationModelManager.L9RKXtpTJqf1LuxqdiU((object) organizationItem), OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1185105284 ^ 1185139284), OrganizationModelManager.PFyBELpQPc8H8fWVcDQ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893109123)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(554338340 ^ 554305532)));
                      num7 = 2;
                      continue;
                    case 8:
                      goto label_712;
                    case 9:
                      goto label_693;
                    case 10:
                      if (current != null)
                      {
                        num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 5 : 5;
                        continue;
                      }
                      goto case 11;
                    case 11:
                      if (!newItems.Contains(current))
                      {
                        num7 = 3;
                        continue;
                      }
                      goto label_712;
                    default:
                      goto label_703;
                  }
                }
label_703:
                current = enumerator4.Current;
                num7 = 10;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0)
                {
                  num7 = 8;
                  goto label_700;
                }
                else
                  goto label_700;
label_713:
                num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 9;
                goto label_700;
              }
              finally
              {
                if (enumerator4 != null)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        enumerator4.Dispose();
                        num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_723;
                    }
                  }
                }
label_723:;
              }
            case 32:
              guidList1 = new List<Guid>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 62 : 25;
              continue;
            case 33:
              if (subDiagram == null)
                goto case 3;
              else
                goto label_730;
            case 34:
              this.FindDoubleTree(element1, organizationDiagram);
              num2 = 28;
              continue;
            case 36:
              enumerator3 = ((ElementList) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).GetEnumerator();
              num2 = 46;
              continue;
            case 37:
            case 78:
              ICollection<OrganizationValidationMessage> messages1 = this.Messages;
              OrganizationValidationMessage validationMessage1 = new OrganizationValidationMessage();
              OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage1, OrganizationValidationMessageType.Error);
              OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage1, (object) str8);
              validationMessage1.ItemUids = list4.Select<OrganizationElement, Guid>((Func<OrganizationElement, Guid>) (e => e.Uid)).ToArray<Guid>();
              messages1.Add(validationMessage1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 89 : 36;
              continue;
            case 38:
            case 42:
            case 92:
              list1 = ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).Where<Element>((Func<Element, bool>) (e => e is NestedStructureElement)).ToList<Element>();
              num2 = 102;
              continue;
            case 39:
              filter = new EleWise.ELMA.Model.Common.Filter();
              num2 = 95;
              continue;
            case 40:
              list5 = ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).Where<Element>((Func<Element, bool>) (e =>
              {
                int num9 = 1;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      if (e is OrganizationElement)
                      {
                        num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) > 1;
label_5:
                return false;
              })).ToList<Element>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 26 : 21;
              continue;
            case 41:
              str1 = (string) OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1702973981 - 773209001 ^ 1818803350));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 7 : 4;
              continue;
            case 43:
label_692:
              stringList = new List<string>();
              num2 = 51;
              continue;
            case 44:
              try
              {
label_605:
                if (enumerator6.MoveNext())
                  goto label_607;
                else
                  goto label_606;
label_537:
                OrganizationSubDiagrams current1;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                    case 4:
                    case 6:
                      goto label_605;
                    case 2:
                      enumerator8 = stringList.GetEnumerator();
                      num10 = 5;
                      continue;
                    case 3:
                      if (current1.OrganizationSubDiagram == null)
                      {
                        num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 2;
                    case 5:
                      goto label_538;
                    case 7:
                      goto label_607;
                    case 8:
                      if (current1 == null)
                      {
                        num10 = 4;
                        continue;
                      }
                      goto case 3;
                    default:
                      goto label_535;
                  }
                }
label_538:
                try
                {
label_592:
                  if (enumerator8.MoveNext())
                    goto label_595;
                  else
                    goto label_593;
label_539:
                  List<Guid> guidList2;
                  string str11;
                  List<string> source2;
                  int num11;
                  string str12;
                  Guid guid;
                  string current2;
                  int num12;
                  while (true)
                  {
                    switch (num12)
                    {
                      case 1:
                      case 2:
                        goto label_592;
                      case 3:
                        goto label_605;
                      case 4:
                      case 10:
                        if (OrganizationModelManager.r4UB9GpddckqnaXp8a9((object) guidList2) > 1)
                        {
                          num12 = 11;
                          continue;
                        }
                        goto label_592;
                      case 5:
                        str12 = "";
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 4 : 9;
                        continue;
                      case 6:
                        try
                        {
label_563:
                          if (enumerator7.MoveNext())
                            goto label_582;
                          else
                            goto label_564;
label_562:
                          int num13;
                          while (true)
                          {
                            List<OrganizationSubDiagrams> list6;
                            OrganizationModelManager.DuplicateElement duplicateElement;
                            switch (num13)
                            {
                              case 1:
                                if (!OrganizationModelManager.Df8ynOpRutCfI9UyJwL(duplicateElement.SubDiagram, Guid.Empty))
                                {
                                  num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 4;
                                  continue;
                                }
                                goto case 14;
                              case 2:
                                if (OrganizationModelManager.r4UB9GpddckqnaXp8a9((object) guidList2) != 0)
                                {
                                  num13 = 7;
                                  continue;
                                }
                                goto case 17;
                              case 3:
                              case 8:
                              case 11:
                              case 15:
                                goto label_563;
                              case 4:
                              case 5:
                                list6 = subDiagram.OrganizationSubDiagrams.Where<OrganizationSubDiagrams>((Func<OrganizationSubDiagrams, bool>) (e => e.Id == duplicateElement.SubDiagram)).ToList<OrganizationSubDiagrams>();
                                num13 = 9;
                                continue;
                              case 6:
                                str11 = (string) duplicateElement.Name;
                                num13 = 15;
                                continue;
                              case 7:
                                if (guid == duplicateElement.SubDiagram)
                                {
                                  num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 8 : 17;
                                  continue;
                                }
                                break;
                              case 9:
                                if (list6.Count<OrganizationSubDiagrams>() <= 0)
                                {
                                  num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 2 : 3;
                                  continue;
                                }
                                goto case 18;
                              case 10:
                                if (!OrganizationModelManager.Df8ynOpRutCfI9UyJwL(current1.Id, duplicateElement.SubDiagram))
                                {
                                  num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 16 : 16;
                                  continue;
                                }
                                goto case 2;
                              case 12:
                                duplicateElement = enumerator7.Current;
                                num13 = 10;
                                continue;
                              case 13:
                                goto label_582;
                              case 14:
                                source2.Add((string) OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--1587467489 ^ 1587414215)));
                                num13 = 11;
                                continue;
                              case 17:
                                guidList2.Add(duplicateElement.Uid);
                                num13 = 19;
                                continue;
                              case 18:
                                source2.Add(list6[0].Name);
                                num13 = 8;
                                continue;
                              case 19:
                                guid = duplicateElement.SubDiagram;
                                num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 6 : 0;
                                continue;
                              case 20:
                                goto label_540;
                            }
                            if (OrganizationModelManager.Fp0mFEpGEO1JKagZQyM(guid, duplicateElement.SubDiagram))
                              num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 1 : 1;
                            else
                              goto label_563;
                          }
label_564:
                          num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 20 : 10;
                          goto label_562;
label_582:
                          num13 = 12;
                          goto label_562;
                        }
                        finally
                        {
                          enumerator7.Dispose();
                          int num14 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0)
                            num14 = 0;
                          switch (num14)
                          {
                            default:
                          }
                        }
                      case 7:
                        try
                        {
label_549:
                          if (enumerator9.MoveNext())
                            goto label_551;
                          else
                            goto label_550;
label_548:
                          IGrouping<string, string> current3;
                          int num15;
                          while (true)
                          {
                            switch (num15)
                            {
                              case 1:
                                goto label_551;
                              case 2:
                                str12 += (string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1780597820 ^ 1780603184);
                                num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 4 : 1;
                                continue;
                              case 3:
                                if (num11 != 0)
                                {
                                  num15 = 2;
                                  continue;
                                }
                                goto case 4;
                              case 4:
                                str12 = (string) OrganizationModelManager.xhXOQKpXZjyexx0lWVw((object) str12, OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1751467293 ^ -1751487781), (object) current3.Key.ToString(), OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1534797734 ^ 1534850974));
                                num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 0 : 0;
                                continue;
                              case 5:
                                goto label_549;
                              case 6:
                                goto label_589;
                              default:
                                ++num11;
                                num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 3 : 5;
                                continue;
                            }
                          }
label_550:
                          num15 = 6;
                          goto label_548;
label_551:
                          current3 = enumerator9.Current;
                          num15 = 3;
                          goto label_548;
                        }
                        finally
                        {
                          enumerator9.Dispose();
                          int num16 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0)
                            num16 = 0;
                          switch (num16)
                          {
                            default:
                          }
                        }
                      case 8:
                        if (source2.Count<string>() >= 1)
                        {
                          num12 = 5;
                          continue;
                        }
                        goto case 4;
                      case 9:
                        num11 = 0;
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 1 : 12;
                        continue;
                      case 11:
                        ICollection<OrganizationValidationMessage> messages2 = this.Messages;
                        OrganizationValidationMessage validationMessage2 = new OrganizationValidationMessage();
                        OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage2, OrganizationValidationMessageType.Warning);
                        validationMessage2.Message = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--1587467489 ^ 1587414411), (object) new object[2]
                        {
                          (object) current1.Name,
                          (object) str11
                        });
                        OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage2, (object) guidList2.ToArray());
                        OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage2, current1.Id);
                        OrganizationValidationMessage validationMessage3 = validationMessage2;
                        messages2.Add(validationMessage3);
                        num12 = 2;
                        continue;
                      case 12:
                        List<string> source3 = source2;
                        // ISSUE: reference to a compiler-generated field
                        Func<string, string> func2 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_39;
                        Func<string, string> keySelector;
                        if (func2 == null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_39 = keySelector = (Func<string, string>) (e => e.ToString());
                        }
                        else
                          goto label_766;
label_599:
                        enumerator9 = source3.GroupBy<string, string>(keySelector).ToList<IGrouping<string, string>>().GetEnumerator();
                        num12 = 7;
                        continue;
label_766:
                        keySelector = func2;
                        goto label_599;
                      case 13:
label_540:
                        if (OrganizationModelManager.r4UB9GpddckqnaXp8a9((object) guidList2) < 1)
                        {
                          num12 = 10;
                          continue;
                        }
                        goto case 8;
                      case 14:
                        List<OrganizationModelManager.DuplicateElement> duplicateElementList = dictionary[current2];
                        guidList2 = new List<Guid>();
                        source2 = new List<string>();
                        guid = new Guid();
                        str11 = "";
                        enumerator7 = duplicateElementList.GetEnumerator();
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 6 : 0;
                        continue;
                      case 15:
label_589:
                        ICollection<OrganizationValidationMessage> messages3 = this.Messages;
                        OrganizationValidationMessage validationMessage4 = new OrganizationValidationMessage();
                        OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage4, OrganizationValidationMessageType.Warning);
                        validationMessage4.Message = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(4869926 >> 3 ^ 629210), (object) new object[3]
                        {
                          (object) current1.Name,
                          (object) str11,
                          (object) str12
                        });
                        OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage4, OrganizationModelManager.kiXgeCp8jiD8rDAVZTI((object) guidList2));
                        OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage4, current1.Id);
                        OrganizationValidationMessage validationMessage5 = validationMessage4;
                        messages3.Add(validationMessage5);
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 1 : 0;
                        continue;
                      default:
                        goto label_595;
                    }
                  }
label_593:
                  num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 3 : 3;
                  goto label_539;
label_595:
                  current2 = enumerator8.Current;
                  num12 = 14;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0)
                  {
                    num12 = 9;
                    goto label_539;
                  }
                  else
                    goto label_539;
                }
                finally
                {
                  enumerator8.Dispose();
                  int num17 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0)
                    num17 = 0;
                  switch (num17)
                  {
                    default:
                  }
                }
label_606:
                num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
                goto label_537;
label_607:
                current1 = enumerator6.Current;
                num10 = 8;
                goto label_537;
              }
              finally
              {
                enumerator6.Dispose();
                int num18 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0)
                  num18 = 0;
                switch (num18)
                {
                  default:
                }
              }
            case 45:
            case 94:
              if (this.HasWarning)
              {
                num2 = 50;
                continue;
              }
              goto label_765;
            case 46:
              try
              {
label_418:
                if (enumerator3.MoveNext())
                  goto label_382;
                else
                  goto label_419;
label_377:
                Element current4;
                OrganizationElement organizationElement;
                List<Connector> connectorList;
                int num19;
                while (true)
                {
                  switch (num19)
                  {
                    case 1:
                    case 9:
                      if (current4 is OrgConnectorElementAnnotation)
                      {
                        num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 17;
                    case 2:
                      connectorList = new List<Connector>();
                      num19 = 11;
                      continue;
                    case 3:
                      goto label_418;
                    case 4:
label_405:
                      enumerator5 = connectorList.GetEnumerator();
                      num19 = 18;
                      continue;
                    case 5:
                      goto label_382;
                    case 6:
                      if (organizationElement == null)
                      {
                        num19 = 8;
                        continue;
                      }
                      goto case 2;
                    case 7:
                      elementList1.Add(current4);
                      num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 1 : 0;
                      continue;
                    case 8:
                    case 15:
label_385:
                      ++num3;
                      num19 = 3;
                      continue;
                    case 10:
                      if (!(current4 is OrganizationAnnotationElement))
                      {
                        num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 9 : 6;
                        continue;
                      }
                      goto case 7;
                    case 11:
                      enumerator5 = organizationElement.OutputConnectors.GetEnumerator();
                      num19 = 14;
                      continue;
                    case 12:
                      goto label_519;
                    case 13:
                      organizationElement = current4 as OrganizationElement;
                      num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 6 : 3;
                      continue;
                    case 14:
                      try
                      {
label_395:
                        if (enumerator5.MoveNext())
                          goto label_400;
                        else
                          goto label_396;
label_394:
                        Connector current5;
                        int num20;
                        while (true)
                        {
                          switch (num20)
                          {
                            case 1:
                              goto label_395;
                            case 2:
                              if (current5 is OrgConnectorElementAnnotation)
                              {
                                num20 = 3;
                                continue;
                              }
                              goto label_395;
                            case 3:
                              connectorList.Add(current5);
                              num20 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 1 : 1;
                              continue;
                            case 4:
                              goto label_400;
                            default:
                              goto label_405;
                          }
                        }
label_396:
                        num20 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 0 : 0;
                        goto label_394;
label_400:
                        current5 = enumerator5.Current;
                        num20 = 2;
                        goto label_394;
                      }
                      finally
                      {
                        enumerator5.Dispose();
                        int num21 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0)
                          num21 = 0;
                        switch (num21)
                        {
                          default:
                        }
                      }
                    case 16:
                      elementList1.Add(current4);
                      num19 = 13;
                      continue;
                    case 17:
                      if (current4 is OrgArtifactGroupElement)
                      {
                        num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 16 : 8;
                        continue;
                      }
                      goto case 13;
                    case 18:
                      try
                      {
label_408:
                        if (enumerator5.MoveNext())
                          goto label_411;
                        else
                          goto label_409;
label_407:
                        Connector current6;
                        int num22;
                        while (true)
                        {
                          switch (num22)
                          {
                            case 1:
                              goto label_385;
                            case 2:
                              goto label_411;
                            case 3:
                              goto label_408;
                            default:
                              organizationElement.OutputConnectors.Remove(current6);
                              num22 = 3;
                              continue;
                          }
                        }
label_409:
                        num22 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 1 : 0;
                        goto label_407;
label_411:
                        current6 = enumerator5.Current;
                        num22 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0)
                        {
                          num22 = 0;
                          goto label_407;
                        }
                        else
                          goto label_407;
                      }
                      finally
                      {
                        enumerator5.Dispose();
                        int num23 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0)
                          num23 = 0;
                        switch (num23)
                        {
                          default:
                        }
                      }
                    default:
                      elementList1.Add(current4);
                      num19 = 17;
                      continue;
                  }
                }
label_382:
                current4 = enumerator3.Current;
                num19 = 10;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0)
                {
                  num19 = 5;
                  goto label_377;
                }
                else
                  goto label_377;
label_419:
                num19 = 12;
                goto label_377;
              }
              finally
              {
                int num24;
                if (enumerator3 == null)
                  num24 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 0 : 2;
                else
                  goto label_425;
label_423:
                switch (num24)
                {
                  case 1:
                  case 2:
                }
label_425:
                OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator3);
                num24 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0)
                {
                  num24 = 1;
                  goto label_423;
                }
                else
                  goto label_423;
              }
            case 47:
              if (OrganizationModelManager.AEJhECpPDooQayPIw9U(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)) <= 0)
              {
                num2 = 42;
                continue;
              }
              goto label_756;
            case 48:
            case 107:
label_532:
              if (!this.HasErrors)
              {
                num2 = 93;
                continue;
              }
              goto case 86;
            case 49:
            case 108:
              ICollection<OrganizationValidationMessage> messages4 = this.Messages;
              OrganizationValidationMessage validationMessage6 = new OrganizationValidationMessage();
              OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage6, OrganizationValidationMessageType.Error);
              OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage6, (object) str10);
              List<Element> source4 = list3;
              // ISSUE: reference to a compiler-generated field
              Func<Element, Guid> func3 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_30;
              Func<Element, Guid> selector1;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_30 = selector1 = (Func<Element, Guid>) (e => e.Uid);
              }
              else
                goto label_767;
label_751:
              validationMessage6.ItemUids = source4.Select<Element, Guid>(selector1).ToArray<Guid>();
              messages4.Add(validationMessage6);
              num2 = 35;
              continue;
label_767:
              selector1 = func3;
              goto label_751;
            case 50:
              this.ValidateOnly = false;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 1 : 1;
              continue;
            case 51:
              dictionary = new Dictionary<string, List<OrganizationModelManager.DuplicateElement>>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 21 : 60;
              continue;
            case 52:
              elementsStack = new List<OrganizationElement>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 12 : 76;
              continue;
            case 53:
              num3 = 0;
              num2 = 36;
              continue;
            case 54:
              organizationModel1.Diagram = (OrganizationDiagram) OrganizationModelManager.ur2uDZB26OP9ATABUGl((object) organizationModels);
              num2 = 18;
              continue;
            case 55:
              if (subDiagram.OrganizationSubDiagrams != null)
              {
                num2 = 101;
                continue;
              }
              goto case 77;
            case 56:
              try
              {
label_304:
                if (enumerator6.MoveNext())
                  goto label_331;
                else
                  goto label_305;
label_126:
                OrganizationSubDiagrams current7;
                int num25;
                while (true)
                {
                  int num26;
                  List<Element> list7;
                  string str13;
                  string str14;
                  string str15;
                  List<Element> list8;
                  List<OrganizationElement> list9;
                  string str16;
                  List<Guid> guidList3;
                  List<Element> list10;
                  string str17;
                  string str18;
                  string str19;
                  string str20;
                  OrganizationElement element3;
                  switch (num25)
                  {
                    case 1:
                      if (this.ValidateOnly)
                      {
                        num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 14 : 9;
                        continue;
                      }
                      goto case 32;
                    case 2:
                      ICollection<OrganizationValidationMessage> messages5 = this.Messages;
                      OrganizationValidationMessage validationMessage7 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage7, OrganizationValidationMessageType.Error);
                      OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage7, (object) str13);
                      List<Element> source5 = list7;
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, Guid> func4 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_18;
                      Func<Element, Guid> selector2;
                      if (func4 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_18 = selector2 = (Func<Element, Guid>) (e => e.Uid);
                      }
                      else
                        goto label_770;
label_343:
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage7, (object) source5.Select<Element, Guid>(selector2).ToArray<Guid>());
                      OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage7, current7.Id);
                      messages5.Add(validationMessage7);
                      num25 = 6;
                      continue;
label_770:
                      selector2 = func4;
                      goto label_343;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      str19 = string.Join((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(781628008 - 11982093 ^ 769642871), list7.Select<Element, string>((Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e))));
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 24 : 35;
                      continue;
                    case 4:
                    case 47:
                      ICollection<OrganizationValidationMessage> messages6 = this.Messages;
                      OrganizationValidationMessage validationMessage8 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage8, OrganizationValidationMessageType.Error);
                      OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage8, (object) str18);
                      // ISSUE: reference to a compiler-generated method
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage8, (object) list10.Select<Element, Guid>((Func<Element, Guid>) (e => OrganizationModelManager.\u003C\u003Ec.x7pfcowW2S5V3YLLB1Bq((object) e))).ToArray<Guid>());
                      OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage8, current7.Id);
                      messages6.Add(validationMessage8);
                      num26 = 54;
                      break;
                    case 5:
                      if (!this.ValidateOnly)
                      {
                        num25 = 12;
                        continue;
                      }
                      goto case 2;
                    case 6:
                      object source6 = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram);
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, bool> func5 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_10;
                      Func<Element, bool> predicate2;
                      if (func5 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_10 = predicate2 = (Func<Element, bool>) (e => e is OrganizationElement);
                      }
                      else
                        goto label_769;
label_346:
                      List<Element> list11 = ((IEnumerable<Element>) source6).Where<Element>(predicate2).ToList<Element>();
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, string> func6 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_11;
                      Func<Element, string> keySelector;
                      if (func6 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_11 = keySelector = (Func<Element, string>) (e => e.Name.ToUpper());
                      }
                      else
                        goto label_768;
label_348:
                      enumerator2 = list11.GroupBy<Element, string>(keySelector).GetEnumerator();
                      num25 = 27;
                      continue;
label_768:
                      keySelector = func6;
                      goto label_348;
label_769:
                      predicate2 = func5;
                      goto label_346;
                    case 7:
                    case 9:
                    case 34:
                      goto label_304;
                    case 8:
                      str18 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(617710536 ^ 617697044), (object) new object[1]
                      {
                        (object) str17
                      });
                      num25 = 56;
                      continue;
                    case 10:
                      enumerator3 = current7.OrganizationSubDiagram.Elements.GetEnumerator();
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 33 : 33;
                      continue;
                    case 11:
                      this.FindDoubleTree(element3, current7.OrganizationSubDiagram);
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 19 : 49;
                      continue;
                    case 12:
                      ((ILogger) OrganizationModelManager.GG6MGMpWDk1HSiQPvZo()).Error(OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1115268484 ^ -1115254404), (object) new object[1]
                      {
                        (object) str13
                      }));
                      num25 = 2;
                      continue;
                    case 13:
                      // ISSUE: reference to a compiler-generated method
                      str14 = string.Join((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-909559362 ^ -398405015 ^ 562685947), list8.Select<Element, string>((Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e))));
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 16 : 5;
                      continue;
                    case 14:
                    case 57:
                      ICollection<OrganizationValidationMessage> messages7 = this.Messages;
                      OrganizationValidationMessage validationMessage9 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage9, OrganizationValidationMessageType.Error);
                      OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage9, (object) str16);
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage9, OrganizationModelManager.kiXgeCp8jiD8rDAVZTI((object) guidList3));
                      OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage9, current7.Id);
                      messages7.Add(validationMessage9);
                      num25 = 9;
                      continue;
                    case 15:
                      enumerator3 = ((ElementList) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram)).GetEnumerator();
                      num25 = 20;
                      continue;
                    case 16:
                      str15 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55858694), (object) new object[2]
                      {
                        (object) current7.Name,
                        (object) str14
                      });
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 19 : 1;
                      continue;
                    case 17:
                    case 53:
                      ICollection<OrganizationValidationMessage> messages8 = this.Messages;
                      OrganizationValidationMessage validationMessage10 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage10, OrganizationValidationMessageType.Error);
                      OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage10, (object) str20);
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage10, (object) list9.Select<OrganizationElement, Guid>((Func<OrganizationElement, Guid>) (e => e.Uid)).ToArray<Guid>());
                      OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage10, current7.Id);
                      messages8.Add(validationMessage10);
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 1 : 10;
                      continue;
                    case 18:
                    case 38:
                      list9 = ((IEnumerable) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram)).OfType<OrganizationElement>().Where<OrganizationElement>((Func<OrganizationElement, bool>) (e =>
                      {
                        int num27 = 2;
                        while (true)
                        {
                          switch (num27)
                          {
                            case 1:
                              goto label_3;
                            case 2:
                              if (e == null)
                              {
                                num27 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 1 : 0;
                                continue;
                              }
                              goto label_2;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return OrganizationModelManager.\u003C\u003Ec.YUZEpqwWHyMOMGwWD5nr(OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e));
label_3:
                        return false;
                      })).ToList<OrganizationElement>();
                      num25 = 41;
                      continue;
                    case 19:
                      if (this.ValidateOnly)
                      {
                        num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 44 : 46;
                        continue;
                      }
                      goto case 45;
                    case 20:
                      try
                      {
label_165:
                        if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
                          goto label_135;
                        else
                          goto label_166;
label_130:
                        Element current8;
                        List<Connector> connectorList;
                        OrganizationElement organizationElement;
                        int num28;
                        while (true)
                        {
                          switch (num28)
                          {
                            case 1:
                              goto label_165;
                            case 2:
                              if (!(current8 is OrganizationAnnotationElement))
                              {
                                num28 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 4 : 13;
                                continue;
                              }
                              goto case 6;
                            case 3:
label_134:
                              enumerator5 = connectorList.GetEnumerator();
                              num28 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 18 : 14;
                              continue;
                            case 4:
                              try
                              {
label_141:
                                if (enumerator5.MoveNext())
                                  goto label_144;
                                else
                                  goto label_142;
label_138:
                                Connector current9;
                                int num29;
                                while (true)
                                {
                                  switch (num29)
                                  {
                                    case 1:
                                      if (!(current9 is OrgConnectorElementAnnotation))
                                      {
                                        num29 = 4;
                                        continue;
                                      }
                                      goto case 2;
                                    case 2:
                                      connectorList.Add(current9);
                                      num29 = 5;
                                      continue;
                                    case 3:
                                      goto label_144;
                                    case 4:
                                    case 5:
                                      goto label_141;
                                    default:
                                      goto label_134;
                                  }
                                }
label_142:
                                num29 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 0 : 0;
                                goto label_138;
label_144:
                                current9 = enumerator5.Current;
                                num29 = 1;
                                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0)
                                {
                                  num29 = 0;
                                  goto label_138;
                                }
                                else
                                  goto label_138;
                              }
                              finally
                              {
                                enumerator5.Dispose();
                                int num30 = 0;
                                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0)
                                  num30 = 0;
                                switch (num30)
                                {
                                  default:
                                }
                              }
                            case 5:
                              goto label_135;
                            case 6:
                              elementList1.Add(current8);
                              num28 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 16 : 15;
                              continue;
                            case 7:
                              elementList1.Add(current8);
                              num28 = 8;
                              continue;
                            case 8:
                            case 9:
                              if (!(current8 is OrgConnectorElementAnnotation))
                              {
                                num28 = 17;
                                continue;
                              }
                              goto case 10;
                            case 10:
                              elementList1.Add(current8);
                              num28 = 12;
                              continue;
                            case 11:
                              goto label_319;
                            case 12:
                            case 17:
                              organizationElement = current8 as OrganizationElement;
                              num28 = 15;
                              continue;
                            case 13:
                            case 16:
                              if (!(current8 is OrgArtifactGroupElement))
                              {
                                num28 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 2 : 9;
                                continue;
                              }
                              goto case 7;
                            case 14:
                              connectorList = new List<Connector>();
                              num28 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 0 : 0;
                              continue;
                            case 15:
                              if (organizationElement != null)
                              {
                                num28 = 14;
                                continue;
                              }
                              goto label_165;
                            case 18:
                              goto label_153;
                            default:
                              enumerator5 = organizationElement.OutputConnectors.GetEnumerator();
                              num28 = 4;
                              continue;
                          }
                        }
label_153:
                        try
                        {
label_158:
                          if (enumerator5.MoveNext())
                            goto label_156;
                          else
                            goto label_159;
label_154:
                          Connector current10;
                          int num31;
                          while (true)
                          {
                            switch (num31)
                            {
                              case 1:
                                goto label_158;
                              case 2:
                                goto label_156;
                              case 3:
                                goto label_165;
                              default:
                                organizationElement.OutputConnectors.Remove(current10);
                                num31 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 1 : 1;
                                continue;
                            }
                          }
label_156:
                          current10 = enumerator5.Current;
                          num31 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0)
                          {
                            num31 = 0;
                            goto label_154;
                          }
                          else
                            goto label_154;
label_159:
                          num31 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 3 : 0;
                          goto label_154;
                        }
                        finally
                        {
                          enumerator5.Dispose();
                          int num32 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0)
                            num32 = 0;
                          switch (num32)
                          {
                            default:
                          }
                        }
label_135:
                        current8 = enumerator3.Current;
                        num28 = 2;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0)
                        {
                          num28 = 2;
                          goto label_130;
                        }
                        else
                          goto label_130;
label_166:
                        num28 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 9 : 11;
                        goto label_130;
                      }
                      finally
                      {
                        int num33;
                        if (enumerator3 == null)
                          num33 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
                        else
                          goto label_177;
label_176:
                        switch (num33)
                        {
                          case 2:
                            break;
                          default:
                        }
label_177:
                        OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator3);
                        num33 = 1;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0)
                        {
                          num33 = 0;
                          goto label_176;
                        }
                        else
                          goto label_176;
                      }
                    case 21:
label_190:
                      str16 = (string) OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(384582979 ^ 384600317));
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 1 : 1;
                      continue;
                    case 22:
                      if (OrganizationModelManager.uZGJitpotg51k6YC4Nd((object) list10) <= 0)
                      {
                        num25 = 52;
                        continue;
                      }
                      goto case 31;
                    case 23:
                      object source7 = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram);
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, bool> func7 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_21;
                      Func<Element, bool> predicate3;
                      if (func7 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_21 = predicate3 = (Func<Element, bool>) (e =>
                        {
                          int num34 = 1;
                          while (true)
                          {
                            switch (num34)
                            {
                              case 1:
                                if (e is OrganizationElement)
                                {
                                  num34 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_3;
                              default:
                                goto label_2;
                            }
                          }
label_2:
                          // ISSUE: reference to a compiler-generated method
                          return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) == 0;
label_3:
                          return false;
                        });
                      }
                      else
                        goto label_772;
label_356:
                      element3 = (OrganizationElement) ((IEnumerable<Element>) source7).First<Element>(predicate3);
                      num25 = 61;
                      continue;
label_772:
                      predicate3 = func7;
                      goto label_356;
                    case 24:
                      try
                      {
label_312:
                        if (enumerator1.MoveNext())
                          goto label_310;
                        else
                          goto label_313;
label_309:
                        Element current11;
                        int num35;
                        while (true)
                        {
                          switch (num35)
                          {
                            case 1:
                              goto label_332;
                            case 2:
                              goto label_310;
                            case 3:
                              OrganizationModelManager.wVstBgpASNGKQaZ0CUm(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram), (object) current11);
                              num35 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_312;
                          }
                        }
label_310:
                        current11 = enumerator1.Current;
                        num35 = 3;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0)
                        {
                          num35 = 2;
                          goto label_309;
                        }
                        else
                          goto label_309;
label_313:
                        num35 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 1 : 1;
                        goto label_309;
                      }
                      finally
                      {
                        enumerator1.Dispose();
                        int num36 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0)
                          num36 = 0;
                        switch (num36)
                        {
                          default:
                        }
                      }
                    case 25:
                      OrganizationModelManager.Yql8SqpZPEJ2R5Yk1am((object) current7.OrganizationSubDiagram);
                      num25 = 62;
                      continue;
                    case 26:
label_337:
                      object source8 = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram);
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, bool> func8 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_9;
                      Func<Element, bool> predicate4;
                      if (func8 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_9 = predicate4 = (Func<Element, bool>) (e =>
                        {
                          int num37 = 1;
                          while (true)
                          {
                            switch (num37)
                            {
                              case 1:
                                if (e is OrganizationElement)
                                {
                                  num37 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_3;
                              default:
                                goto label_2;
                            }
                          }
label_2:
                          // ISSUE: reference to a compiler-generated method
                          return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) > 1;
label_3:
                          return false;
                        });
                      }
                      else
                        goto label_773;
label_339:
                      list7 = ((IEnumerable<Element>) source8).Where<Element>(predicate4).ToList<Element>();
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 0 : 0;
                      continue;
label_773:
                      predicate4 = func8;
                      goto label_339;
                    case 27:
                      try
                      {
label_276:
                        if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator2))
                          goto label_278;
                        else
                          goto label_277;
label_251:
                        int num38;
                        switch (num38)
                        {
                          case 1:
                            goto label_278;
                          case 2:
                            try
                            {
label_259:
                              if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
                                goto label_261;
                              else
                                goto label_260;
label_254:
                              Element current12;
                              int num39;
                              while (true)
                              {
                                int num40;
                                List<OrganizationModelManager.DuplicateElement> duplicateElementList1;
                                List<OrganizationModelManager.DuplicateElement> duplicateElementList2;
                                switch (num39)
                                {
                                  case 1:
                                    if (dictionary.ContainsKey(((string) OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current12)).ToUpper()))
                                    {
                                      num39 = 8;
                                      continue;
                                    }
                                    goto case 5;
                                  case 2:
                                    goto label_276;
                                  case 3:
                                    if (duplicateElementList2.Count == 1)
                                    {
                                      num39 = 7;
                                      continue;
                                    }
                                    goto case 11;
                                  case 4:
                                    dictionary[(string) OrganizationModelManager.WoMyaLpcXaK48vyN5HX(OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current12))] = duplicateElementList2;
                                    num39 = 10;
                                    continue;
                                  case 5:
                                    duplicateElementList1 = new List<OrganizationModelManager.DuplicateElement>();
                                    num39 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 0;
                                    continue;
                                  case 6:
                                    dictionary.Add(((string) OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current12)).ToUpper(), duplicateElementList1);
                                    num40 = 9;
                                    break;
                                  case 7:
                                    stringList.Add(((string) OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current12)).ToUpper());
                                    num39 = 11;
                                    continue;
                                  case 8:
                                    duplicateElementList2 = dictionary[(string) OrganizationModelManager.WoMyaLpcXaK48vyN5HX(OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current12))];
                                    num40 = 3;
                                    break;
                                  case 9:
                                  case 10:
                                    goto label_259;
                                  case 11:
                                    duplicateElementList2.Add(new OrganizationModelManager.DuplicateElement()
                                    {
                                      Uid = OrganizationModelManager.lZek4DpUko9IixyCMa2((object) current12),
                                      Name = (object) current12.Name,
                                      SubDiagram = current7.Id
                                    });
                                    num39 = 4;
                                    continue;
                                  case 12:
                                    goto label_261;
                                  default:
                                    duplicateElementList1.Add(new OrganizationModelManager.DuplicateElement()
                                    {
                                      Uid = OrganizationModelManager.lZek4DpUko9IixyCMa2((object) current12),
                                      Name = (object) current12.Name,
                                      SubDiagram = current7.Id
                                    });
                                    num39 = 6;
                                    continue;
                                }
                                num39 = num40;
                              }
label_260:
                              num39 = 2;
                              goto label_254;
label_261:
                              current12 = enumerator3.Current;
                              num39 = 0;
                              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
                              {
                                num39 = 1;
                                goto label_254;
                              }
                              else
                                goto label_254;
                            }
                            finally
                            {
                              int num41;
                              if (enumerator3 == null)
                                num41 = 2;
                              else
                                goto label_273;
label_272:
                              switch (num41)
                              {
                                case 1:
                                  break;
                                default:
                              }
label_273:
                              OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator3);
                              num41 = 0;
                              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0)
                              {
                                num41 = 0;
                                goto label_272;
                              }
                              else
                                goto label_272;
                            }
                          case 3:
                            goto label_276;
                          default:
                            goto label_349;
                        }
label_277:
                        num38 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
                        goto label_251;
label_278:
                        enumerator3 = enumerator2.Current.GetEnumerator();
                        num38 = 2;
                        goto label_251;
                      }
                      finally
                      {
                        int num42;
                        if (enumerator2 == null)
                          num42 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
                        else
                          goto label_282;
label_281:
                        switch (num42)
                        {
                          case 1:
                            break;
                          default:
                        }
label_282:
                        OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator2);
                        num42 = 2;
                        goto label_281;
                      }
                    case 28:
                      goto label_736;
                    case 29:
                      guidList3 = new List<Guid>();
                      num25 = 50;
                      continue;
                    case 30:
                      goto label_331;
                    case 31:
                      object separator = OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1744916777 - 891549337 ^ 853366460);
                      List<Element> source9 = list10;
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, string> func9 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_19;
                      Func<Element, string> selector3;
                      if (func9 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_19 = selector3 = (Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e));
                      }
                      else
                        goto label_771;
label_352:
                      IEnumerable<string> values = source9.Select<Element, string>(selector3);
                      str17 = string.Join((string) separator, values);
                      num25 = 8;
                      continue;
label_771:
                      selector3 = func9;
                      goto label_352;
                    case 32:
                      ((ILogger) OrganizationModelManager.GG6MGMpWDk1HSiQPvZo()).Error(OrganizationModelManager.jeTVtup7J9vVHho5qUa((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841276427), (object) new object[1]
                      {
                        (object) str16
                      }));
                      num25 = 57;
                      continue;
                    case 33:
                      try
                      {
label_195:
                        if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
                          goto label_197;
                        else
                          goto label_196;
label_192:
                        DepartmentElement current13;
                        int num43;
                        while (true)
                        {
                          List<OrganizationElement> source10;
                          Guid[] guidArray;
                          string str21;
                          List<OrganizationElement> organizationElementList;
                          switch (num43)
                          {
                            case 1:
                              if (current13 == null)
                              {
                                num43 = 18;
                                continue;
                              }
                              goto case 6;
                            case 2:
                              goto label_337;
                            case 3:
                              organizationElementList = source10.Where<OrganizationElement>((Func<OrganizationElement, bool>) (e =>
                              {
                                int num44 = 1;
                                while (true)
                                {
                                  switch (num44)
                                  {
                                    case 1:
                                      if (e is PositionElement)
                                      {
                                        num44 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
                                        continue;
                                      }
                                      goto label_5;
                                    default:
                                      goto label_4;
                                  }
                                }
label_4:
                                // ISSUE: reference to a compiler-generated method
                                return OrganizationModelManager.\u003C\u003Ec.novyimwWzDHe55PjLDXT((object) (PositionElement) e);
label_5:
                                return false;
                              })).ToList<OrganizationElement>();
                              break;
                            case 4:
                              OrganizationModelManager.nawPX0pr5GdkquXquWd(OrganizationModelManager.GG6MGMpWDk1HSiQPvZo(), OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-816108091 ^ -816060731), (object) new object[1]
                              {
                                (object) str21
                              }));
                              num43 = 9;
                              continue;
                            case 5:
                              organizationElementList = new List<OrganizationElement>();
                              break;
                            case 6:
                              source10 = new List<OrganizationElement>();
                              num43 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 12 : 12;
                              continue;
                            case 8:
                            case 11:
                            case 14:
                              enumerator5 = current13.OutputConnectors.GetEnumerator();
                              num43 = 13;
                              continue;
                            case 9:
                              ICollection<OrganizationValidationMessage> messages9 = this.Messages;
                              OrganizationValidationMessage validationMessage11 = new OrganizationValidationMessage();
                              validationMessage11.Type = OrganizationValidationMessageType.Error;
                              OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage11, (object) str21);
                              OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage11, (object) guidArray);
                              OrganizationModelManager.qhLyrKplLi56pdQtIWt((object) validationMessage11, current7.Id);
                              messages9.Add(validationMessage11);
                              num43 = 7;
                              continue;
                            case 10:
                              goto label_197;
                            case 12:
                              if (current13.Composition == null)
                              {
                                num43 = 11;
                                continue;
                              }
                              goto case 21;
                            case 13:
                              try
                              {
label_215:
                                if (enumerator5.MoveNext())
                                  goto label_217;
                                else
                                  goto label_216;
label_213:
                                OrganizationElement organizationElement;
                                int num45;
                                while (true)
                                {
                                  switch (num45)
                                  {
                                    case 1:
                                      if (organizationElement != null)
                                      {
                                        num45 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 1 : 3;
                                        continue;
                                      }
                                      goto label_215;
                                    case 2:
                                      goto label_215;
                                    case 3:
                                      source10.Add(organizationElement);
                                      num45 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 2;
                                      continue;
                                    case 4:
                                      goto label_217;
                                    default:
                                      goto label_193;
                                  }
                                }
label_216:
                                num45 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 0 : 0;
                                goto label_213;
label_217:
                                organizationElement = OrganizationModelManager.zNFoYbpfq8hqgCgVwhu((object) enumerator5.Current) as OrganizationElement;
                                num45 = 1;
                                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0)
                                {
                                  num45 = 0;
                                  goto label_213;
                                }
                                else
                                  goto label_213;
                              }
                              finally
                              {
                                enumerator5.Dispose();
                                int num46 = 0;
                                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0)
                                  num46 = 0;
                                switch (num46)
                                {
                                  default:
                                }
                              }
                            case 15:
label_193:
                              if (current13 != null)
                              {
                                num43 = 3;
                                continue;
                              }
                              goto case 5;
                            case 16:
label_202:
                              guidArray = new Guid[1]
                              {
                                OrganizationModelManager.lZek4DpUko9IixyCMa2((object) current13)
                              };
                              num43 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 6 : 20;
                              continue;
                            case 17:
                              source10.AddRange((IEnumerable<OrganizationElement>) current13.Composition);
                              num43 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 14 : 0;
                              continue;
                            case 19:
                              if (!this.ValidateOnly)
                              {
                                num43 = 4;
                                continue;
                              }
                              goto case 9;
                            case 20:
                              str21 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--2002186503 ^ 2002139849), (object) new object[2]
                              {
                                OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current13),
                                (object) current7.Name
                              });
                              num43 = 19;
                              continue;
                            case 21:
                              if (OrganizationModelManager.zOVBfPpVc0drRvIFyNe((object) current13.Composition) <= 0)
                              {
                                num43 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 1 : 8;
                                continue;
                              }
                              goto case 17;
                            default:
                              goto label_195;
                          }
                          if (organizationElementList.Count <= 1)
                            num43 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 0 : 0;
                          else
                            goto label_202;
                        }
label_196:
                        num43 = 2;
                        goto label_192;
label_197:
                        current13 = enumerator3.Current as DepartmentElement;
                        num43 = 1;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0)
                        {
                          num43 = 1;
                          goto label_192;
                        }
                        else
                          goto label_192;
                      }
                      finally
                      {
                        if (enumerator3 != null)
                        {
                          int num47 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0)
                            num47 = 0;
                          while (true)
                          {
                            switch (num47)
                            {
                              case 1:
                                goto label_236;
                              default:
                                enumerator3.Dispose();
                                num47 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 1 : 1;
                                continue;
                            }
                          }
                        }
label_236:;
                      }
                    case 35:
                      str13 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1489118656 ^ 643054122 ^ -2123813836), (object) new object[1]
                      {
                        (object) str19
                      });
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 5 : 5;
                      continue;
                    case 36:
                      OrganizationModelManager.nawPX0pr5GdkquXquWd(OrganizationModelManager.GG6MGMpWDk1HSiQPvZo(), (object) EleWise.ELMA.SR.T((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(~123928154 ^ -123876699), (object) str18));
                      num25 = 47;
                      continue;
                    case 37:
                      if (current7.OrganizationSubDiagram == null)
                      {
                        num25 = 34;
                        continue;
                      }
                      goto case 25;
                    case 39:
                      if (current7 != null)
                      {
                        num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 33 : 37;
                        continue;
                      }
                      goto label_304;
                    case 40:
                      if (OrganizationModelManager.AEJhECpPDooQayPIw9U(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram)) > 0)
                      {
                        num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 16 : 23;
                        continue;
                      }
                      goto label_304;
                    case 41:
                      if (OrganizationModelManager.zOVBfPpVc0drRvIFyNe((object) list9) > 0)
                      {
                        num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 58 : 57;
                        continue;
                      }
                      goto case 10;
                    case 42:
                      if (this.ValidateOnly)
                      {
                        num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 17 : 6;
                        continue;
                      }
                      goto case 43;
                    case 43:
                      OrganizationModelManager.nawPX0pr5GdkquXquWd((object) Logger.Log, OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1677147940 ^ 1677194276), (object) new object[1]
                      {
                        (object) str20
                      }));
                      num25 = 53;
                      continue;
                    case 44:
label_332:
                      list8 = ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram)).Where<Element>((Func<Element, bool>) (e =>
                      {
                        int num48 = 1;
                        while (true)
                        {
                          switch (num48)
                          {
                            case 1:
                              if (e is OrganizationElement)
                              {
                                num48 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 0;
                                continue;
                              }
                              goto label_5;
                            default:
                              goto label_4;
                          }
                        }
label_4:
                        // ISSUE: reference to a compiler-generated method
                        return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) == 0;
label_5:
                        return false;
                      })).ToList<Element>();
                      num25 = 60;
                      continue;
                    case 45:
                      OrganizationModelManager.nawPX0pr5GdkquXquWd(OrganizationModelManager.GG6MGMpWDk1HSiQPvZo(), (object) EleWise.ELMA.SR.T((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1341618464 ^ -1341633056), (object) str15));
                      num25 = 55;
                      continue;
                    case 46:
                    case 55:
                      ICollection<OrganizationValidationMessage> messages10 = this.Messages;
                      OrganizationValidationMessage validationMessage12 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage12, OrganizationValidationMessageType.Error);
                      OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage12, (object) str15);
                      // ISSUE: reference to a compiler-generated method
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage12, (object) list8.Select<Element, Guid>((Func<Element, Guid>) (e => OrganizationModelManager.\u003C\u003Ec.x7pfcowW2S5V3YLLB1Bq((object) e))).ToArray<Guid>());
                      validationMessage12.SubDiagram = current7.Id;
                      messages10.Add(validationMessage12);
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 18 : 2;
                      continue;
                    case 48:
                      try
                      {
label_292:
                        if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
                          goto label_288;
                        else
                          goto label_293;
label_287:
                        int num49;
                        Element subElement;
                        while (true)
                        {
                          switch (num49)
                          {
                            case 1:
                              goto label_292;
                            case 2:
                              goto label_288;
                            case 3:
                              subElement = enumerator3.Current;
                              num49 = 4;
                              continue;
                            case 4:
                              // ISSUE: reference to a compiler-generated method
                              if (!this.ListTreeElement.Any<Guid>((Func<Guid, bool>) (r => OrganizationModelManager.\u003C\u003Ec__DisplayClass31_0.K9fT2KwrRcHe2m319NWI(r, subElement.Uid))))
                              {
                                num49 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 3 : 5;
                                continue;
                              }
                              goto label_292;
                            case 5:
                              guidList3.Add(OrganizationModelManager.lZek4DpUko9IixyCMa2((object) subElement));
                              num49 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 1;
                              continue;
                            default:
                              goto label_190;
                          }
                        }
label_288:
                        num49 = 3;
                        goto label_287;
label_293:
                        num49 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
                        goto label_287;
                      }
                      finally
                      {
                        if (enumerator3 != null)
                        {
                          int num50 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0)
                            num50 = 0;
                          while (true)
                          {
                            switch (num50)
                            {
                              case 1:
                                goto label_300;
                              default:
                                OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator3);
                                num50 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 1;
                                continue;
                            }
                          }
                        }
label_300:;
                      }
                    case 49:
                      int count = this.ListTreeElement.Count;
                      object source11 = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current7.OrganizationSubDiagram);
                      // ISSUE: reference to a compiler-generated field
                      Func<Element, bool> func10 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_22;
                      Func<Element, bool> predicate5;
                      if (func10 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_22 = predicate5 = (Func<Element, bool>) (e => e is OrganizationElement);
                      }
                      else
                        goto label_775;
label_359:
                      int num51 = ((IEnumerable<Element>) source11).Where<Element>(predicate5).Count<Element>();
                      if (count != num51)
                      {
                        num26 = 29;
                        break;
                      }
                      goto label_304;
label_775:
                      predicate5 = func10;
                      goto label_359;
                    case 50:
                      enumerator3 = current7.OrganizationSubDiagram.Elements.Where<Element>((Func<Element, bool>) (e => e is OrganizationElement)).GetEnumerator();
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 48 : 39;
                      continue;
                    case 51:
label_349:
                      list10 = current7.OrganizationSubDiagram.Elements.Where<Element>((Func<Element, bool>) (e =>
                      {
                        int num52 = 2;
                        while (true)
                        {
                          switch (num52)
                          {
                            case 1:
                              goto label_3;
                            case 2:
                              if (!(e is NestedStructureElement))
                              {
                                num52 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 1 : 1;
                                continue;
                              }
                              goto label_2;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        return e.OutputConnectors.Count != 0;
label_3:
                        return false;
                      })).ToList<Element>();
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 22 : 19;
                      continue;
                    case 52:
                    case 54:
                      if (this.HasErrors)
                      {
                        num25 = 7;
                        continue;
                      }
                      goto case 40;
                    case 56:
                      if (this.ValidateOnly)
                      {
                        num25 = 4;
                        continue;
                      }
                      goto case 36;
                    case 58:
                      str20 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1424960806 ^ -1425008240), (object) new object[1]
                      {
                        (object) current7.Name
                      });
                      num25 = 42;
                      continue;
                    case 59:
label_319:
                      enumerator1 = elementList1.GetEnumerator();
                      num25 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 1 : 24;
                      continue;
                    case 60:
                      if (OrganizationModelManager.uZGJitpotg51k6YC4Nd((object) list8) <= 1)
                      {
                        num25 = 38;
                        continue;
                      }
                      goto case 13;
                    case 61:
                      this.ListTreeElement = new List<Guid>();
                      num26 = 11;
                      break;
                    case 62:
                      List<Element> elementList2 = new List<Element>();
                      num25 = 15;
                      continue;
                    default:
                      if (OrganizationModelManager.uZGJitpotg51k6YC4Nd((object) list7) > 0)
                      {
                        num25 = 3;
                        continue;
                      }
                      goto case 6;
                  }
                  num25 = num26;
                }
label_305:
                num25 = 28;
                goto label_126;
label_331:
                current7 = enumerator6.Current;
                num25 = 39;
                goto label_126;
              }
              finally
              {
                enumerator6.Dispose();
                int num53 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0)
                  num53 = 0;
                switch (num53)
                {
                  default:
                }
              }
            case 57:
            case 71:
              ICollection<OrganizationValidationMessage> messages11 = this.Messages;
              OrganizationValidationMessage validationMessage13 = new OrganizationValidationMessage();
              validationMessage13.Type = OrganizationValidationMessageType.Error;
              OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage13, (object) str6);
              OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage13, (object) list2.Select<Element, Guid>((Func<Element, Guid>) (e => e.Uid)).ToArray<Guid>());
              messages11.Add(validationMessage13);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 18 : 40;
              continue;
            case 58:
              subDiagram = ClassSerializationHelper.CloneObjectByXml<OrganizationSubDiagram>((OrganizationSubDiagram) OrganizationModelManager.IkCChwBHl0FUX1A1QNh((object) organizationModels));
              num2 = 103;
              continue;
            case 59:
              OrganizationModelManager.nawPX0pr5GdkquXquWd(OrganizationModelManager.GG6MGMpWDk1HSiQPvZo(), OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1527733619 - 442652394 ^ -1970372445), (object) new object[1]
              {
                (object) str6
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 71 : 32;
              continue;
            case 60:
              if (subDiagram != null)
              {
                num2 = 109;
                continue;
              }
              goto case 110;
            case 61:
              if (!this.ValidateOnly)
                goto case 17;
              else
                goto label_523;
            case 62:
              enumerator3 = ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).Where<Element>((Func<Element, bool>) (e => e is OrganizationElement)).GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 5 : 3;
              continue;
            case 63:
              IOrganizationModel organizationModel2 = organizationModel1;
              DateTime? changeDate = organizationModels.ChangeDate;
              DateTime creationDate;
              if (!changeDate.HasValue)
              {
                creationDate = organizationModels.CreationDate;
              }
              else
              {
                changeDate = organizationModels.ChangeDate;
                creationDate = changeDate.Value;
              }
              OrganizationModelManager.hbXt9QBIC4g3rbWLEQi((object) organizationModel2, creationDate);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 19 : 5;
              continue;
            case 64:
              if (list2.Count > 0)
              {
                num2 = 68;
                continue;
              }
              goto case 40;
            case 65:
              organizationModel1 = this.Create();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 32 : 54;
              continue;
            case 66:
              str7 = (string) OrganizationModelManager.eCmbZnp3QT7VDL9t6UF((object) organizationModels);
              num2 = 65;
              continue;
            case 67:
              if (this.ValidateOnly)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 37 : 37;
                continue;
              }
              goto case 79;
            case 68:
              goto label_740;
            case 69:
              enumerator4 = oldItems.GetEnumerator();
              num2 = 31;
              continue;
            case 70:
              string separator1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1534797734 ^ 1534798730);
              List<Element> source12 = list5;
              // ISSUE: reference to a compiler-generated field
              Func<Element, string> func11 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_27;
              Func<Element, string> selector4;
              if (func11 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_27 = selector4 = (Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e));
              }
              else
                goto label_776;
label_745:
              IEnumerable<string> values1 = source12.Select<Element, string>(selector4);
              str4 = string.Join(separator1, values1);
              num2 = 12;
              continue;
label_776:
              selector4 = func11;
              goto label_745;
            case 72:
              if (OrganizationModelManager.zOVBfPpVc0drRvIFyNe((object) list4) <= 0)
              {
                num2 = 29;
                continue;
              }
              goto case 14;
            case 73:
              list3 = ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).Where<Element>((Func<Element, bool>) (e =>
              {
                int num54 = 1;
                while (true)
                {
                  switch (num54)
                  {
                    case 1:
                      if (!(e is OrganizationElement))
                      {
                        num54 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 0;
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
                // ISSUE: reference to a compiler-generated method
                return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) == 0;
label_3:
                return false;
              })).ToList<Element>();
              num2 = 9;
              continue;
            case 74:
              // ISSUE: reference to a compiler-generated method
              str9 = string.Join((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1433051380 + 1051547170 ^ -1810367686), list3.Select<Element, string>((Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e))));
              num2 = 23;
              continue;
            case 75:
              newItems = new List<IOrganizationItem>();
              num2 = 100;
              continue;
            case 76:
              this.SaveElement(element2, (IOrganizationItem) null, (DepartmentElement) null, (IEnumerable<IOrganizationItem>) oldItems, newItems, elementsStack);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 69 : 2;
              continue;
            case 77:
label_683:
              if (OrganizationModelManager.EuQ5LPpE9vxZwRmuIJy((object) stringList) <= 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 107 : 74;
                continue;
              }
              goto case 33;
            case 79:
              OrganizationModelManager.nawPX0pr5GdkquXquWd(OrganizationModelManager.GG6MGMpWDk1HSiQPvZo(), OrganizationModelManager.jeTVtup7J9vVHho5qUa((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(711486506 ^ 711501610), (object) new object[1]
              {
                (object) str8
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 38 : 78;
              continue;
            case 80:
            case 104:
              ICollection<OrganizationValidationMessage> messages12 = this.Messages;
              OrganizationValidationMessage validationMessage14 = new OrganizationValidationMessage();
              validationMessage14.Type = OrganizationValidationMessageType.Error;
              OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage14, (object) str1);
              messages12.Add(validationMessage14);
              num2 = 83;
              continue;
            case 81:
              try
              {
label_463:
                if (enumerator8.MoveNext())
                  goto label_466;
                else
                  goto label_464;
label_430:
                List<Guid> guidList4;
                Guid guid;
                List<string> source13;
                string str22;
                string current14;
                string str23;
                int num55;
                int num56;
                while (true)
                {
                  switch (num56)
                  {
                    case 1:
                      num55 = 0;
                      num56 = 5;
                      continue;
                    case 2:
                      if (source13.Count<string>() >= 1)
                      {
                        num56 = 12;
                        continue;
                      }
                      goto case 6;
                    case 5:
                      List<string> source14 = source13;
                      // ISSUE: reference to a compiler-generated field
                      Func<string, string> func12 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_41;
                      Func<string, string> keySelector;
                      if (func12 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_41 = keySelector = (Func<string, string>) (e => e.ToString());
                      }
                      else
                        goto label_777;
label_494:
                      enumerator9 = source14.GroupBy<string, string>(keySelector).ToList<IGrouping<string, string>>().GetEnumerator();
                      num56 = 14;
                      continue;
label_777:
                      keySelector = func12;
                      goto label_494;
                    case 6:
                    case 11:
                      if (OrganizationModelManager.r4UB9GpddckqnaXp8a9((object) guidList4) <= 1)
                      {
                        num56 = 4;
                        continue;
                      }
                      goto case 9;
                    case 7:
                      try
                      {
label_445:
                        if (enumerator7.MoveNext())
                          goto label_444;
                        else
                          goto label_446;
label_432:
                        List<OrganizationSubDiagrams> list12;
                        int num57;
                        OrganizationModelManager.DuplicateElement duplicateElement;
                        while (true)
                        {
                          switch (num57)
                          {
                            case 1:
                            case 9:
                              if (!OrganizationModelManager.Fp0mFEpGEO1JKagZQyM(guid, duplicateElement.SubDiagram))
                              {
                                num57 = 22;
                                continue;
                              }
                              goto case 15;
                            case 2:
                              if (list12.Count<OrganizationSubDiagrams>() > 0)
                              {
                                num57 = 16;
                                continue;
                              }
                              goto label_445;
                            case 5:
                            case 17:
                              guidList4.Add(duplicateElement.Uid);
                              num57 = 21;
                              continue;
                            case 6:
                              if (subDiagram.OrganizationSubDiagrams == null)
                              {
                                num57 = 7;
                                continue;
                              }
                              goto case 23;
                            case 8:
                              goto label_468;
                            case 10:
                              if (OrganizationModelManager.Df8ynOpRutCfI9UyJwL(Guid.Empty, duplicateElement.SubDiagram))
                              {
                                num57 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 14 : 7;
                                continue;
                              }
                              goto case 1;
                            case 11:
                              goto label_444;
                            case 12:
                            case 18:
                              if (subDiagram == null)
                              {
                                num57 = 19;
                                continue;
                              }
                              goto case 6;
                            case 13:
                              source13.Add((string) OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(4869926 >> 3 ^ 629186)));
                              num57 = 3;
                              continue;
                            case 14:
                              if (OrganizationModelManager.r4UB9GpddckqnaXp8a9((object) guidList4) == 0)
                              {
                                num57 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 5 : 5;
                                continue;
                              }
                              goto case 20;
                            case 15:
                              if (!(duplicateElement.SubDiagram == Guid.Empty))
                              {
                                num57 = 12;
                                continue;
                              }
                              goto case 13;
                            case 16:
                              source13.Add(list12[0].Name);
                              num57 = 4;
                              continue;
                            case 20:
                              if (!OrganizationModelManager.Df8ynOpRutCfI9UyJwL(guid, duplicateElement.SubDiagram))
                              {
                                num57 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 1 : 1;
                                continue;
                              }
                              goto case 5;
                            case 21:
                              guid = duplicateElement.SubDiagram;
                              num57 = 25;
                              continue;
                            case 23:
                              list12 = subDiagram.OrganizationSubDiagrams.Where<OrganizationSubDiagrams>((Func<OrganizationSubDiagrams, bool>) (e => e.Id == duplicateElement.SubDiagram)).ToList<OrganizationSubDiagrams>();
                              num57 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 0 : 2;
                              continue;
                            case 24:
                              duplicateElement = enumerator7.Current;
                              num57 = 10;
                              continue;
                            case 25:
                              str22 = (string) duplicateElement.Name;
                              num57 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_445;
                          }
                        }
label_444:
                        num57 = 24;
                        goto label_432;
label_446:
                        num57 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 6 : 8;
                        goto label_432;
                      }
                      finally
                      {
                        enumerator7.Dispose();
                        int num58 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0)
                          num58 = 0;
                        switch (num58)
                        {
                          default:
                        }
                      }
                    case 8:
label_477:
                      ICollection<OrganizationValidationMessage> messages13 = this.Messages;
                      OrganizationValidationMessage validationMessage15 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage15, OrganizationValidationMessageType.Warning);
                      validationMessage15.Message = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-817081027 ^ 243500131 ^ -1043397764), (object) new object[2]
                      {
                        (object) str22,
                        (object) str23
                      });
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage15, OrganizationModelManager.kiXgeCp8jiD8rDAVZTI((object) guidList4));
                      OrganizationValidationMessage validationMessage16 = validationMessage15;
                      messages13.Add(validationMessage16);
                      num56 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 0;
                      continue;
                    case 9:
                      ICollection<OrganizationValidationMessage> messages14 = this.Messages;
                      OrganizationValidationMessage validationMessage17 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage17, OrganizationValidationMessageType.Warning);
                      validationMessage17.Message = EleWise.ELMA.SR.T((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--353012470 ^ 352999876), (object) str22);
                      validationMessage17.ItemUids = (Guid[]) OrganizationModelManager.kiXgeCp8jiD8rDAVZTI((object) guidList4);
                      OrganizationValidationMessage validationMessage18 = validationMessage17;
                      messages14.Add(validationMessage18);
                      num56 = 3;
                      continue;
                    case 10:
                      goto label_532;
                    case 12:
                      str23 = "";
                      num56 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 1;
                      continue;
                    case 13:
                      goto label_466;
                    case 14:
                      try
                      {
label_480:
                        if (enumerator9.MoveNext())
                          goto label_482;
                        else
                          goto label_481;
label_479:
                        IGrouping<string, string> current15;
                        int num59;
                        while (true)
                        {
                          switch (num59)
                          {
                            case 1:
                            case 2:
                              str23 = str23 + (string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1807813747 ^ -1807866955) + current15.Key.ToString() + (string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(334323849 << 5 ^ 2108473624);
                              num59 = 3;
                              continue;
                            case 3:
                              ++num55;
                              num59 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 4 : 6;
                              continue;
                            case 4:
                              if (num55 == 0)
                              {
                                num59 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 1 : 1;
                                continue;
                              }
                              goto case 7;
                            case 5:
                              goto label_477;
                            case 6:
                              goto label_480;
                            case 7:
                              str23 += (string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1788054269 >> 5 ^ -55869788);
                              num59 = 2;
                              continue;
                            default:
                              goto label_482;
                          }
                        }
label_481:
                        num59 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 3 : 5;
                        goto label_479;
label_482:
                        current15 = enumerator9.Current;
                        num59 = 4;
                        goto label_479;
                      }
                      finally
                      {
                        enumerator9.Dispose();
                        int num60 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0)
                          num60 = 0;
                        switch (num60)
                        {
                          default:
                        }
                      }
                    case 15:
label_468:
                      if (guidList4.Count < 1)
                      {
                        num56 = 11;
                        continue;
                      }
                      goto case 2;
                    case 16:
                      List<OrganizationModelManager.DuplicateElement> duplicateElementList = dictionary[current14];
                      guidList4 = new List<Guid>();
                      source13 = new List<string>();
                      guid = new Guid();
                      str22 = "";
                      enumerator7 = duplicateElementList.GetEnumerator();
                      num56 = 7;
                      continue;
                    default:
                      goto label_463;
                  }
                }
label_464:
                num56 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 4 : 10;
                goto label_430;
label_466:
                current14 = enumerator8.Current;
                num56 = 14;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0)
                {
                  num56 = 16;
                  goto label_430;
                }
                else
                  goto label_430;
              }
              finally
              {
                enumerator8.Dispose();
                int num61 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0)
                  num61 = 0;
                switch (num61)
                {
                  default:
                }
              }
            case 82:
              organizationDiagram = ClassSerializationHelper.CloneObjectByXml<OrganizationDiagram>((OrganizationDiagram) OrganizationModelManager.ur2uDZB26OP9ATABUGl((object) organizationModels));
              num2 = 113;
              continue;
            case 83:
              if (OrganizationModelManager.uZGJitpotg51k6YC4Nd((object) list3) <= 1)
              {
                num2 = 4;
                continue;
              }
              goto case 74;
            case 84:
            case 111:
              ICollection<OrganizationValidationMessage> messages15 = this.Messages;
              OrganizationValidationMessage validationMessage19 = new OrganizationValidationMessage();
              OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage19, OrganizationValidationMessageType.Error);
              OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage19, (object) str5);
              // ISSUE: reference to a compiler-generated method
              OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage19, (object) list5.Select<Element, Guid>((Func<Element, Guid>) (e => OrganizationModelManager.\u003C\u003Ec.x7pfcowW2S5V3YLLB1Bq((object) e))).ToArray<Guid>());
              messages15.Add(validationMessage19);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 73 : 50;
              continue;
            case 85:
              try
              {
label_632:
                if (enumerator1.MoveNext())
                  goto label_630;
                else
                  goto label_633;
label_629:
                int num62;
                while (true)
                {
                  switch (num62)
                  {
                    case 1:
                      goto label_630;
                    case 2:
                      goto label_632;
                    case 3:
                      goto label_634;
                    case 4:
                      enumerator6 = subDiagram.OrganizationSubDiagrams.GetEnumerator();
                      num62 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 3 : 1;
                      continue;
                    default:
                      goto label_683;
                  }
                }
label_634:
                Element current16;
                try
                {
label_641:
                  if (enumerator6.MoveNext())
                    goto label_637;
                  else
                    goto label_642;
label_636:
                  OrganizationSubDiagrams current17;
                  List<Element> list13;
                  Connector connector1;
                  int num63;
                  while (true)
                  {
                    int num64;
                    OrgConnectorElement connectorElement1;
                    switch (num63)
                    {
                      case 1:
                        goto label_632;
                      case 2:
                        if (current17 == null)
                        {
                          num63 = 15;
                          continue;
                        }
                        goto case 11;
                      case 3:
                        if (!OrganizationModelManager.Df8ynOpRutCfI9UyJwL(current17.Id, OrganizationModelManager.lZek4DpUko9IixyCMa2((object) current16)))
                        {
                          num63 = 6;
                          continue;
                        }
                        goto case 14;
                      case 4:
                        OrganizationModelManager.YX4XRypaO2oWoj94EfO(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram), (object) connectorElement1);
                        num63 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 1 : 10;
                        continue;
                      case 5:
                        goto label_637;
                      case 6:
                      case 12:
                      case 15:
                        goto label_641;
                      case 7:
                        if (OrganizationModelManager.uZGJitpotg51k6YC4Nd((object) list13) > 0)
                        {
                          num63 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_641;
                      case 8:
                        goto label_646;
                      case 9:
                        current16.OutputConnectors.Add(connector1);
                        num64 = 13;
                        break;
                      case 10:
                        Connector connector2 = new Connector();
                        OrganizationModelManager.lWBDinpkFihZoEQRDCd((object) connector2, (object) list13[0]);
                        OrganizationModelManager.Qnk0L8pDTTQaT7kcJeG((object) connector2, (object) current16);
                        connector1 = connector2;
                        num63 = 9;
                        continue;
                      case 11:
                        if (current17.OrganizationSubDiagram != null)
                        {
                          num63 = 3;
                          continue;
                        }
                        goto label_641;
                      case 13:
                        enumerator3 = current17.OrganizationSubDiagram.Elements.GetEnumerator();
                        num63 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 2 : 8;
                        continue;
                      case 14:
                        object source15 = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) current17.OrganizationSubDiagram);
                        // ISSUE: reference to a compiler-generated field
                        Func<Element, bool> func13 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_37;
                        Func<Element, bool> predicate6;
                        if (func13 == null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_37 = predicate6 = (Func<Element, bool>) (e =>
                          {
                            int num65 = 1;
                            while (true)
                            {
                              switch (num65)
                              {
                                case 1:
                                  if (e is OrganizationElement)
                                  {
                                    num65 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
                                    continue;
                                  }
                                  goto label_5;
                                default:
                                  goto label_4;
                              }
                            }
label_4:
                            // ISSUE: reference to a compiler-generated method
                            return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.InputConnectors) == 0;
label_5:
                            return false;
                          });
                        }
                        else
                          goto label_778;
label_674:
                        list13 = ((IEnumerable<Element>) source15).Where<Element>(predicate6).ToList<Element>();
                        num64 = 7;
                        break;
label_778:
                        predicate6 = func13;
                        goto label_674;
                      default:
                        OrgConnectorElement connectorElement2 = new OrgConnectorElement();
                        OrganizationModelManager.MAgdFqpmD1W05dsbcaE((object) connectorElement2, Guid.NewGuid());
                        connectorElement1 = connectorElement2;
                        num63 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 4;
                        continue;
                    }
                    num63 = num64;
                  }
label_646:
                  try
                  {
label_656:
                    if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
                      goto label_650;
                    else
                      goto label_657;
label_647:
                    Element current18;
                    int num66;
                    while (true)
                    {
                      NestedStructureElement elementParent;
                      switch (num66)
                      {
                        case 1:
                          if (elementParent == null)
                          {
                            num66 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 6 : 6;
                            continue;
                          }
                          break;
                        case 2:
                          current18.InputConnectors.Add(connector1);
                          num66 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 4 : 3;
                          continue;
                        case 3:
                          if (current18.Uid == list13[0].Uid)
                          {
                            num66 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 1 : 2;
                            continue;
                          }
                          goto case 4;
                        case 4:
                          OrganizationModelManager.YX4XRypaO2oWoj94EfO(OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram), (object) current18);
                          num66 = 7;
                          continue;
                        case 5:
                          goto label_650;
                        case 6:
                        case 8:
                          goto label_656;
                        case 7:
                          elementParent = current18 as NestedStructureElement;
                          num66 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 1 : 1;
                          continue;
                        case 9:
                          goto label_641;
                      }
                      this.addSubElement((Element) elementParent, organizationDiagram, subDiagram);
                      num66 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 5 : 8;
                    }
label_650:
                    current18 = enumerator3.Current;
                    num66 = 3;
                    goto label_647;
label_657:
                    num66 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 9 : 6;
                    goto label_647;
                  }
                  finally
                  {
                    int num67;
                    if (enumerator3 == null)
                      num67 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 1 : 0;
                    else
                      goto label_662;
label_661:
                    switch (num67)
                    {
                      case 1:
                      case 2:
                    }
label_662:
                    enumerator3.Dispose();
                    num67 = 2;
                    goto label_661;
                  }
label_637:
                  current17 = enumerator6.Current;
                  num63 = 2;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0)
                  {
                    num63 = 0;
                    goto label_636;
                  }
                  else
                    goto label_636;
label_642:
                  num63 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 1;
                  goto label_636;
                }
                finally
                {
                  enumerator6.Dispose();
                  int num68 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0)
                    num68 = 0;
                  switch (num68)
                  {
                    default:
                  }
                }
label_630:
                current16 = enumerator1.Current;
                num62 = 4;
                goto label_629;
label_633:
                num62 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 0 : 0;
                goto label_629;
              }
              finally
              {
                enumerator1.Dispose();
                int num69 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0)
                  num69 = 0;
                switch (num69)
                {
                  default:
                }
              }
            case 86:
              this.ValidateOnly = false;
              num2 = 8;
              continue;
            case 87:
              if (subDiagram.OrganizationSubDiagrams == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 3 : 3;
                continue;
              }
              goto case 91;
            case 88:
              str6 = EleWise.ELMA.SR.T((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1007654939 ^ 1007637703), (object) str2);
              num2 = 30;
              continue;
            case 90:
              goto label_739;
            case 91:
              enumerator6 = subDiagram.OrganizationSubDiagrams.GetEnumerator();
              num2 = 44;
              continue;
            case 93:
              if (this.ValidateOnly)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 94 : 89;
                continue;
              }
              goto case 39;
            case 95:
              OrganizationModelManager.AVCwqXp9n39UxEp8KmQ((object) filter, true);
              num2 = 2;
              continue;
            case 96:
              Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1257514304 ^ -1257565760), (object) str5));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 4 : 84;
              continue;
            case 97:
              OrganizationModelManager.aCNK3lpjSH8X69yeALn((object) organizationModel1, (object) str7);
              num2 = 63;
              continue;
            case 98:
              try
              {
label_87:
                if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
                  goto label_66;
                else
                  goto label_88;
label_61:
                DepartmentElement current;
                int num70;
                while (true)
                {
                  List<OrganizationElement> organizationElementList1;
                  Guid[] guidArray;
                  string str24;
                  List<OrganizationElement> organizationElementList2;
                  switch (num70)
                  {
                    case 1:
                      goto label_115;
                    case 2:
                    case 5:
                      enumerator5 = current.OutputConnectors.GetEnumerator();
                      num70 = 8;
                      continue;
                    case 3:
                      str24 = (string) OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--2002186503 ^ 2002140887), (object) new object[1]
                      {
                        (object) current.Name
                      });
                      num70 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_87;
                    case 6:
                      organizationElementList1 = new List<OrganizationElement>();
                      num70 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 4 : 9;
                      continue;
                    case 7:
                      organizationElementList1.AddRange((IEnumerable<OrganizationElement>) current.Composition);
                      num70 = 2;
                      continue;
                    case 8:
                      try
                      {
label_74:
                        if (enumerator5.MoveNext())
                          goto label_78;
                        else
                          goto label_75;
label_73:
                        OrganizationElement organizationElement;
                        int num71;
                        while (true)
                        {
                          switch (num71)
                          {
                            case 1:
                              goto label_78;
                            case 2:
                              if (organizationElement != null)
                              {
                                num71 = 3;
                                continue;
                              }
                              goto label_74;
                            case 3:
                              organizationElementList1.Add(organizationElement);
                              num71 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
                              continue;
                            case 4:
                              goto label_92;
                            default:
                              goto label_74;
                          }
                        }
label_75:
                        num71 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 4 : 1;
                        goto label_73;
label_78:
                        organizationElement = OrganizationModelManager.zNFoYbpfq8hqgCgVwhu((object) enumerator5.Current) as OrganizationElement;
                        num71 = 2;
                        goto label_73;
                      }
                      finally
                      {
                        enumerator5.Dispose();
                        int num72 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0)
                          num72 = 0;
                        switch (num72)
                        {
                          default:
                        }
                      }
                    case 9:
                      if (current.Composition == null)
                      {
                        num70 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 5 : 5;
                        continue;
                      }
                      goto case 14;
                    case 10:
                      ICollection<OrganizationValidationMessage> messages16 = this.Messages;
                      OrganizationValidationMessage validationMessage20 = new OrganizationValidationMessage();
                      OrganizationModelManager.FXYv76pS3leOVpggFiV((object) validationMessage20, OrganizationValidationMessageType.Error);
                      OrganizationModelManager.iafLkgpYh9V5TjnQ5mJ((object) validationMessage20, (object) str24);
                      OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage20, (object) guidArray);
                      messages16.Add(validationMessage20);
                      num70 = 4;
                      continue;
                    case 11:
                      guidArray = new Guid[1]{ current.Uid };
                      num70 = 3;
                      continue;
                    case 12:
                      goto label_66;
                    case 13:
label_92:
                      if (current == null)
                      {
                        num70 = 16;
                        continue;
                      }
                      List<OrganizationElement> source16 = organizationElementList1;
                      // ISSUE: reference to a compiler-generated field
                      Func<OrganizationElement, bool> func14 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_32;
                      Func<OrganizationElement, bool> predicate7;
                      if (func14 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_32 = predicate7 = (Func<OrganizationElement, bool>) (e =>
                        {
                          int num73 = 1;
                          while (true)
                          {
                            switch (num73)
                            {
                              case 1:
                                if (e is PositionElement)
                                {
                                  num73 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_3;
                              default:
                                goto label_2;
                            }
                          }
label_2:
                          // ISSUE: reference to a compiler-generated method
                          return OrganizationModelManager.\u003C\u003Ec.novyimwWzDHe55PjLDXT((object) (PositionElement) e);
label_3:
                          return false;
                        });
                      }
                      else
                        goto label_779;
label_98:
                      organizationElementList2 = source16.Where<OrganizationElement>(predicate7).ToList<OrganizationElement>();
                      break;
label_779:
                      predicate7 = func14;
                      goto label_98;
                    case 14:
                      if (current.Composition.Count > 0)
                      {
                        num70 = 7;
                        continue;
                      }
                      goto case 2;
                    case 15:
                      Logger.Log.Error(OrganizationModelManager.jeTVtup7J9vVHho5qUa(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(--1403802000 ^ 1403820688), (object) new object[1]
                      {
                        (object) str24
                      }));
                      num70 = 10;
                      continue;
                    case 16:
                      organizationElementList2 = new List<OrganizationElement>();
                      break;
                    case 17:
                      if (current != null)
                      {
                        num70 = 6;
                        continue;
                      }
                      goto label_87;
                    default:
                      if (!this.ValidateOnly)
                      {
                        num70 = 15;
                        continue;
                      }
                      goto case 10;
                  }
                  if (organizationElementList2.Count > 1)
                    num70 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 5 : 11;
                  else
                    goto label_87;
                }
label_66:
                current = enumerator3.Current as DepartmentElement;
                num70 = 8;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
                {
                  num70 = 17;
                  goto label_61;
                }
                else
                  goto label_61;
label_88:
                num70 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 1 : 1;
                goto label_61;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num74 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0)
                    num74 = 0;
                  while (true)
                  {
                    switch (num74)
                    {
                      case 1:
                        goto label_106;
                      default:
                        enumerator3.Dispose();
                        num74 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_106:;
              }
            case 99:
              goto label_119;
            case 100:
              element2 = (OrganizationElement) list3[0];
              num2 = 52;
              continue;
            case 101:
              goto label_366;
            case 102:
              if (subDiagram != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 1 : 55;
                continue;
              }
              goto case 77;
            case 103:
              goto label_616;
            case 105:
label_519:
              enumerator1 = elementList1.GetEnumerator();
              num2 = 24;
              continue;
            case 106:
label_115:
              if (this.HasErrors)
              {
                num2 = 38;
                continue;
              }
              goto case 47;
            case 109:
              if (subDiagram.OrganizationSubDiagrams != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 112 : 46;
                continue;
              }
              goto case 110;
            case 110:
label_736:
              object source17 = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram);
              // ISSUE: reference to a compiler-generated field
              Func<Element, bool> func15 = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_0;
              Func<Element, bool> predicate8;
              if (func15 == null)
              {
                // ISSUE: reference to a compiler-generated field
                OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_0 = predicate8 = (Func<Element, bool>) (e => e is OrganizationElement);
              }
              else
                goto label_774;
label_738:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator2 = ((IEnumerable<Element>) source17).Where<Element>(predicate8).ToList<Element>().GroupBy<Element, string>((Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.DhJB9LwruVEZ790SiD8w(OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e)))).GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 10 : 3;
              continue;
label_774:
              predicate8 = func15;
              goto label_738;
            case 112:
              enumerator6 = subDiagram.OrganizationSubDiagrams.GetEnumerator();
              num2 = 56;
              continue;
            case 113:
              OrganizationModelManager.Yql8SqpZPEJ2R5Yk1am((object) organizationDiagram);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 58 : 41;
              continue;
          }
          ICollection<OrganizationValidationMessage> messages17 = this.Messages;
          OrganizationValidationMessage validationMessage21 = new OrganizationValidationMessage();
          validationMessage21.Type = OrganizationValidationMessageType.Error;
          validationMessage21.Message = str3;
          OrganizationModelManager.w0478SpyOf1RnIvBNlE((object) validationMessage21, (object) guidList1.ToArray());
          messages17.Add(validationMessage21);
          num2 = 92;
        }
label_18:
        this.ListTreeElement = new List<Guid>();
        num1 = 34;
        continue;
label_21:
        try
        {
label_23:
          if (enumerator2.MoveNext())
            goto label_46;
          else
            goto label_24;
label_22:
          int num75;
          switch (num75)
          {
            case 1:
              try
              {
label_34:
                if (enumerator3.MoveNext())
                  goto label_30;
                else
                  goto label_35;
label_26:
                Element current;
                int num76;
                while (true)
                {
                  List<OrganizationModelManager.DuplicateElement> duplicateElementList3;
                  List<OrganizationModelManager.DuplicateElement> duplicateElementList4;
                  switch (num76)
                  {
                    case 1:
                      stringList.Add(current.Name.ToUpper());
                      num76 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      dictionary[((string) OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current)).ToUpper()] = duplicateElementList3;
                      num76 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 1 : 5;
                      continue;
                    case 3:
                      dictionary.Add((string) OrganizationModelManager.WoMyaLpcXaK48vyN5HX(OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current)), duplicateElementList4);
                      num76 = 11;
                      continue;
                    case 4:
                    case 9:
                      duplicateElementList4 = new List<OrganizationModelManager.DuplicateElement>();
                      num76 = 10;
                      continue;
                    case 5:
                    case 11:
                      goto label_34;
                    case 6:
                      goto label_30;
                    case 7:
                      goto label_23;
                    case 8:
                      if (OrganizationModelManager.uqiMX6p5b9yYJQ86cE4((object) duplicateElementList3) == 1)
                      {
                        num76 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 1 : 1;
                        continue;
                      }
                      break;
                    case 10:
                      duplicateElementList4.Add(new OrganizationModelManager.DuplicateElement()
                      {
                        Uid = OrganizationModelManager.lZek4DpUko9IixyCMa2((object) current),
                        Name = OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current),
                        SubDiagram = Guid.Empty
                      });
                      num76 = 3;
                      continue;
                    case 12:
                      if (!dictionary.ContainsKey(((string) OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current)).ToUpper()))
                      {
                        num76 = 4;
                        continue;
                      }
                      goto case 13;
                    case 13:
                      duplicateElementList3 = dictionary[current.Name.ToUpper()];
                      num76 = 8;
                      continue;
                  }
                  duplicateElementList3.Add(new OrganizationModelManager.DuplicateElement()
                  {
                    Uid = current.Uid,
                    Name = OrganizationModelManager.U4eStOp4VpSK4E1ETmX((object) current),
                    SubDiagram = Guid.Empty
                  });
                  num76 = 2;
                }
label_30:
                current = enumerator3.Current;
                num76 = 12;
                goto label_26;
label_35:
                num76 = 7;
                goto label_26;
              }
              finally
              {
                int num77;
                if (enumerator3 == null)
                  num77 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 1 : 1;
                else
                  goto label_44;
label_43:
                switch (num77)
                {
                  case 1:
                  case 2:
                }
label_44:
                OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator3);
                num77 = 2;
                goto label_43;
              }
            case 2:
              goto label_46;
            case 3:
              goto label_23;
            default:
              goto label_739;
          }
label_24:
          num75 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 0 : 0;
          goto label_22;
label_46:
          enumerator3 = enumerator2.Current.GetEnumerator();
          num75 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0)
          {
            num75 = 0;
            goto label_22;
          }
          else
            goto label_22;
        }
        finally
        {
          int num78;
          if (enumerator2 == null)
            num78 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 1 : 1;
          else
            goto label_51;
label_50:
          switch (num78)
          {
            case 2:
              break;
            default:
          }
label_51:
          OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator2);
          num78 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0)
          {
            num78 = 0;
            goto label_50;
          }
          else
            goto label_50;
        }
label_59:
        elementList1 = new List<Element>();
        num1 = 53;
        continue;
label_366:
        enumerator1 = list1.GetEnumerator();
        num1 = 85;
        continue;
label_503:
        try
        {
label_505:
          if (OrganizationModelManager.LAegtJpx2ke2s5K1l6s((object) enumerator3))
            goto label_507;
          else
            goto label_506;
label_504:
          int num79;
          while (true)
          {
            Element subElement;
            switch (num79)
            {
              case 1:
              case 6:
                goto label_505;
              case 2:
                goto label_507;
              case 3:
                goto label_691;
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (this.ListTreeElement.Any<Guid>((Func<Guid, bool>) (r => OrganizationModelManager.\u003C\u003Ec__DisplayClass31_1.EC0oEVwrkdZ8is9nvOfi(r, OrganizationModelManager.\u003C\u003Ec__DisplayClass31_1.X7jGNTwr6DSuUR9nkdIM((object) subElement)))))
                {
                  num79 = 6;
                  continue;
                }
                break;
              case 5:
                subElement = enumerator3.Current;
                num79 = 4;
                continue;
            }
            guidList1.Add(subElement.Uid);
            num79 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 1 : 1;
          }
label_506:
          num79 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 3;
          goto label_504;
label_507:
          num79 = 3;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0)
          {
            num79 = 5;
            goto label_504;
          }
          else
            goto label_504;
        }
        finally
        {
          if (enumerator3 != null)
          {
            int num80 = 1;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0)
              num80 = 0;
            while (true)
            {
              switch (num80)
              {
                case 1:
                  OrganizationModelManager.MlGD35pCaHVRrpa7JRm((object) enumerator3);
                  num80 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_518;
              }
            }
          }
label_518:;
        }
label_523:
        num1 = 108;
        continue;
label_616:
        this.messages.Clear();
        num1 = 25;
        continue;
label_691:
        str3 = (string) OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-816108091 ^ -816062341));
        num1 = 11;
        continue;
label_694:
        ((ILogger) OrganizationModelManager.GG6MGMpWDk1HSiQPvZo()).Error(OrganizationModelManager.jeTVtup7J9vVHho5qUa((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(928696104 ^ 928648232), (object) new object[1]
        {
          (object) str1
        }));
        num1 = 80;
        continue;
label_730:
        num1 = 87;
        continue;
label_739:
        list2 = ((IEnumerable<Element>) OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram)).Where<Element>((Func<Element, bool>) (e =>
        {
          int num81 = 2;
          while (true)
          {
            switch (num81)
            {
              case 1:
                goto label_5;
              case 2:
                if (!(e is NestedStructureElement))
                {
                  num81 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 0;
                  continue;
                }
                goto label_4;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return OrganizationModelManager.\u003C\u003Ec.ubp5jvwWevFqfZxKMZlM((object) e.OutputConnectors) != 0;
label_5:
          return false;
        })).ToList<Element>();
        num1 = 64;
        continue;
label_740:
        // ISSUE: reference to a compiler-generated method
        str2 = string.Join((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-315619370 - -1325004768 ^ 1009382298), list2.Select<Element, string>((Func<Element, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e))));
        num1 = 88;
        continue;
label_756:
        object source = OrganizationModelManager.Rdvnlsp61r1kdodNRn4((object) organizationDiagram);
        // ISSUE: reference to a compiler-generated field
        Func<Element, bool> func = OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_33;
        Func<Element, bool> predicate;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          OrganizationModelManager.\u003C\u003Ec.\u003C\u003E9__31_33 = predicate = (Func<Element, bool>) (e =>
          {
            int num82 = 1;
            while (true)
            {
              switch (num82)
              {
                case 1:
                  if (!(e is OrganizationElement))
                  {
                    num82 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 0 : 0;
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
            return e.InputConnectors.Count == 0;
label_3:
            return false;
          });
        }
        else
          goto label_424;
label_758:
        element1 = (OrganizationElement) ((IEnumerable<Element>) source).First<Element>(predicate);
        num1 = 21;
        continue;
label_424:
        predicate = func;
        goto label_758;
      }
label_112:
      throw new OrganizationModelPublishException(EleWise.ELMA.SR.T((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(1530848604 ^ 1530803858)))
      {
        mess = this.messages
      };
label_119:
      object message = (object) EleWise.ELMA.SR.T((string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(789532496 ^ 1575286436 ^ 1928031530));
      goto label_764;
label_763:
      message = OrganizationModelManager.PFyBELpQPc8H8fWVcDQ(OrganizationModelManager.MhCAPbps7yBmjXe5aQB(~248518394 ^ -248562617));
label_764:
      throw new OrganizationModelPublishWarning((string) message)
      {
        mess = this.messages
      };
label_765:
      return organizationModel1.Id;
    }

    public void FindDoubleTree(OrganizationElement element, OrganizationDiagram TreeDraftDiagram)
    {
      int num1 = 4;
      List<OrganizationElement> organizationElementList;
      List<OrganizationElement>.Enumerator enumerator1;
      List<Connector>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
label_2:
            enumerator1 = organizationElementList.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 1 : 0;
            continue;
          case 3:
            organizationElementList = new List<OrganizationElement>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 0 : 0;
            continue;
          case 4:
            this.ListTreeElement.Add(OrganizationModelManager.lZek4DpUko9IixyCMa2((object) element));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 3 : 3;
            continue;
          case 5:
            try
            {
label_25:
              if (enumerator2.MoveNext())
                goto label_23;
              else
                goto label_26;
label_18:
              OrganizationElement organizationElement;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_25;
                  case 2:
                    goto label_2;
                  case 3:
                    if (organizationElement != null)
                    {
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_25;
                  case 4:
                    goto label_23;
                  default:
                    organizationElementList.Add(organizationElement);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 0 : 1;
                    continue;
                }
              }
label_23:
              organizationElement = OrganizationModelManager.zNFoYbpfq8hqgCgVwhu((object) enumerator2.Current) as OrganizationElement;
              num2 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0)
              {
                num2 = 3;
                goto label_18;
              }
              else
                goto label_18;
label_26:
              num2 = 2;
              goto label_18;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 6:
            goto label_31;
          default:
            enumerator2 = element.OutputConnectors.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 5;
            continue;
        }
      }
label_31:
      return;
label_4:
      try
      {
label_9:
        if (enumerator1.MoveNext())
          goto label_7;
        else
          goto label_10;
label_5:
        OrganizationElement current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_27;
            case 1:
              goto label_9;
            case 2:
              this.FindDoubleTree(current, TreeDraftDiagram);
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_7;
            case 4:
              string employeeCount = current.EmployeeCount;
              num4 = 2;
              continue;
            default:
              goto label_19;
          }
        }
label_27:
        return;
label_19:
        return;
label_7:
        current = enumerator1.Current;
        num4 = 4;
        goto label_5;
label_10:
        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Номер текущей версии оргструктуры</summary>
    public virtual int CurrentVersion => (int) OrganizationModelManager.mnr1vIpglmuworNKNuE((object) this) - 1;

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<IOrganizationModel>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      OrganizationModelManager.TZ6tkupJyNyD2Hafu9v((object) exportRule1, type);
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule1, OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-201065280 ^ -201084550));
      exportRule1.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      OrganizationModelManager.TZ6tkupJyNyD2Hafu9v((object) exportRule2, type);
      exportRule2.PropertyName = (string) OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-880091293 >> 4 ^ -55019450);
      OrganizationModelManager.L8wBs9peJlAxMWwjj90((object) exportRule2, ExportRuleType.Export);
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      OrganizationModelManager.TZ6tkupJyNyD2Hafu9v((object) exportRule3, type);
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272506035));
      OrganizationModelManager.L8wBs9peJlAxMWwjj90((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      exportRule4.ParentType = type;
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule4, OrganizationModelManager.MhCAPbps7yBmjXe5aQB(781628008 - 11982093 ^ 769623029));
      OrganizationModelManager.L8wBs9peJlAxMWwjj90((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      OrganizationModelManager.TZ6tkupJyNyD2Hafu9v((object) exportRule5, type);
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule5, OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-1324692970 << 3 ^ -2007591210));
      exportRule5.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      exportRule6.ParentType = type;
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule6, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690569372 >> 6 ^ 26461666));
      OrganizationModelManager.L8wBs9peJlAxMWwjj90((object) exportRule6, ExportRuleType.Export);
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      exportRule7.ParentType = type;
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule7, OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-169284490 ^ -169330260));
      OrganizationModelManager.L8wBs9peJlAxMWwjj90((object) exportRule7, ExportRuleType.Export);
      exportRuleList.Add(exportRule7);
      ExportRule exportRule8 = new ExportRule();
      exportRule8.ParentType = type;
      OrganizationModelManager.VlcrfBpIwCQgNdEsuAC((object) exportRule8, OrganizationModelManager.MhCAPbps7yBmjXe5aQB(-296013529 ^ -296012923));
      exportRule8.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule8);
      return exportRuleList;
    }

    /// <summary>Сохранить элемент оргструктуры</summary>
    /// <param name="element">Элемент диаграммы</param>
    /// <param name="parentItem">Родительский элемент оргструктуры</param>
    /// <param name="departmentElement">Отдел</param>
    /// <param name="oldItems">Список элементов оргструктуры предыдущей версии</param>
    /// <param name="newItems">Список, в который нужно добавлять элементы текущей версии</param>
    /// <param name="elementsStack">Стэк обработанных элементов</param>
    private IOrganizationItem SaveElement(
      OrganizationElement element,
      IOrganizationItem parentItem,
      DepartmentElement departmentElement,
      IEnumerable<IOrganizationItem> oldItems,
      List<IOrganizationItem> newItems,
      List<OrganizationElement> elementsStack)
    {
      int num1 = elementsStack.IndexOf(element);
      if (num1 >= 0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        List<Guid> guidList = new List<Guid>();
        for (int index = num1; index < elementsStack.Count; ++index)
        {
          stringBuilder.Append(elementsStack[index].Name);
          stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55855538));
          guidList.Add(elementsStack[index].Uid);
        }
        stringBuilder.Append(element.Name);
        string str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897185065), (object) stringBuilder);
        if (!this.ValidateOnly)
          Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44114157), (object) str));
        this.Messages.Add(new OrganizationValidationMessage()
        {
          Type = OrganizationValidationMessageType.Error,
          Message = str,
          ItemUids = guidList.ToArray()
        });
        if (this.HasErrors)
          throw new OrganizationModelPublishException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340842304)))
          {
            mess = this.messages
          };
      }
      elementsStack = new List<OrganizationElement>((IEnumerable<OrganizationElement>) elementsStack);
      elementsStack.Add(element);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IOrganizationItem parentItem1 = oldItems.FirstOrDefault<IOrganizationItem>((Func<IOrganizationItem, bool>) (i => OrganizationModelManager.\u003C\u003Ec__DisplayClass38_0.jSpwGJwrA8JGTaFtNZ9d((object) i) == OrganizationModelManager.\u003C\u003Ec__DisplayClass38_0.eXjrYHwrskT6H6IGI1vl((object) element)));
      if (parentItem1 == null)
        parentItem1 = new InstanceOf<IOrganizationItem>()
        {
          New = {
            Uid = element.Uid
          }
        }.New;
      string format = element.Name;
      if (!string.IsNullOrEmpty(format) && format.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277458457)))
        format = string.Format(format, departmentElement != null ? (object) departmentElement.Name : (object) string.Empty);
      parentItem1.Name = !string.IsNullOrEmpty(format) ? Regex.Replace(format.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617026523 ^ 617071943), ""), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841281961), z2jc63fLkugS1X8Q9N.tE1kD1vbB(2047763786 ^ 1536686658 ^ 563728098)).Trim() : format;
      if (element is DepartmentElement)
        parentItem1.ItemType = OrganizationItemType.Department;
      else if (element is PositionElement)
        parentItem1.ItemType = OrganizationItemType.Position;
      else if (element is EmployeeGroupElement)
        parentItem1.ItemType = OrganizationItemType.EmployeeGroup;
      else if (element is NestedStructureElement)
        parentItem1.ItemType = OrganizationItemType.NestedStructure;
      parentItem1.ParentItem = parentItem;
      parentItem1.IsDeleted = false;
      parentItem1.HardDelete = false;
      parentItem1.Save();
      newItems.Add(parentItem1);
      DepartmentElement departmentElement1 = element is DepartmentElement ? (DepartmentElement) element : departmentElement;
      List<OrganizationElement> source1 = new List<OrganizationElement>();
      if (element.Composition != null && element.Composition.Count > 0)
        source1.AddRange((IEnumerable<OrganizationElement>) element.Composition);
      foreach (Connector outputConnector in element.OutputConnectors)
      {
        if (outputConnector.EndElement is OrganizationElement endElement)
          source1.Add(endElement);
      }
      List<OrganizationElement> source2 = element is DepartmentElement ? source1.Where<OrganizationElement>((Func<OrganizationElement, bool>) (e =>
      {
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              if (!(e is PositionElement))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return OrganizationModelManager.\u003C\u003Ec.novyimwWzDHe55PjLDXT((object) (PositionElement) e);
label_5:
        return false;
      })).ToList<OrganizationElement>() : new List<OrganizationElement>();
      if (source2.Count > 1)
      {
        // ISSUE: reference to a compiler-generated method
        string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690569372 >> 6 ^ 26418182), source2.Select<OrganizationElement, string>((Func<OrganizationElement, string>) (e => (string) OrganizationModelManager.\u003C\u003Ec.LmnQlmwWLTORnxlYRpW6((object) e))));
        Guid[] guidArray = new Guid[1]{ element.Uid };
        string str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550685568), (object) element.Name);
        if (!this.ValidateOnly)
          Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447333889), (object) str));
        this.messages.Add(new OrganizationValidationMessage()
        {
          Type = OrganizationValidationMessageType.Error,
          Message = str,
          ItemUids = guidArray
        });
        throw new OrganizationModelPublishException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55857050)))
        {
          mess = this.messages
        };
      }
      OrganizationElement element1 = source2.FirstOrDefault<OrganizationElement>();
      IOrganizationItem parentItem2 = parentItem1;
      if (element1 != null)
      {
        parentItem2 = this.SaveElement(element1, parentItem1, departmentElement1, oldItems, newItems, elementsStack);
        source1.Remove(element1);
        elementsStack.Add(element1);
      }
      foreach (OrganizationElement element2 in source1)
        this.SaveElement(element2, parentItem2, departmentElement1, oldItems, newItems, elementsStack);
      return parentItem1;
    }

    public OrganizationModelManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.messages = new List<OrganizationValidationMessage>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static OrganizationModelManager() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool bv1P7LBF3ynwuF3qViZ() => OrganizationModelManager.oVfYauBTsrQ9NcU6Tog == null;

    internal static OrganizationModelManager D7aetgBvy8L1ZtDMWND() => OrganizationModelManager.oVfYauBTsrQ9NcU6Tog;

    internal static object himcA8BqgVRDugSDYte([In] object obj0, [In] object obj1) => (object) ((EntityManager<IOrganizationModel, int>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object GmKIdBBgMjOlmRP6W9p() => (object) Projections.Id();

    internal static object Yfywf2BJi6I4a9MAXVm([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static void hbXt9QBIC4g3rbWLEQi([In] object obj0, DateTime value) => ((IOrganizationModel) obj0).CreationDate = value;

    internal static void heIb42BeWkDs5bwQ4cb([In] object obj0, [In] object obj1) => ((IOrganizationModel) obj0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static DateTime KKnyLCBnS71wfedsNu0() => DateTime.Now;

    internal static void xVWrhMBLonNgfpAs5Cf([In] object obj0, [In] object obj1) => ((IOrganizationModel) obj0).ChangeAuthor = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static object ur2uDZB26OP9ATABUGl([In] object obj0) => (object) ((IOrganizationModel) obj0).Diagram;

    internal static object IkCChwBHl0FUX1A1QNh([In] object obj0) => (object) ((IOrganizationModel) obj0).SubDiagrams;

    internal static void QrLDf3BzCkSppMfNcuF([In] object obj0, [In] object obj1) => ((IOrganizationModel) obj0).SubDiagrams = (OrganizationSubDiagram) obj1;

    internal static object NQpwpHpuaFsTerkE7XL([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static void LvebmfpwP5gkqRs13Vq([In] object obj0, [In] object obj1) => ((ISession) obj0).SaveOrUpdate(obj1);

    internal static void GyxsQSpbqCgWtyYUsqp([In] object obj0, [In] object obj1) => ((IOrganizationModel) obj0).Diagram = (OrganizationDiagram) obj1;

    internal static object PIiRnbpKSiI6xptK9hb([In] object obj0) => (object) Projections.Max((IProjection) obj0);

    internal static Guid lZek4DpUko9IixyCMa2([In] object obj0) => ((Element) obj0).Uid;

    internal static bool Df8ynOpRutCfI9UyJwL([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static int uZGJitpotg51k6YC4Nd([In] object obj0) => ((List<Element>) obj0).Count;

    internal static Guid aKGtW5pt8IQiGrbQSs4() => Guid.NewGuid();

    internal static void MAgdFqpmD1W05dsbcaE([In] object obj0, [In] Guid obj1) => ((Element) obj0).Uid = obj1;

    internal static object Rdvnlsp61r1kdodNRn4([In] object obj0) => (object) ((Diagram) obj0).Elements;

    internal static void lWBDinpkFihZoEQRDCd([In] object obj0, [In] object obj1) => ((Connector) obj0).EndElement = (Element) obj1;

    internal static void Qnk0L8pDTTQaT7kcJeG([In] object obj0, [In] object obj1) => ((Connector) obj0).StartElement = (Element) obj1;

    internal static void YX4XRypaO2oWoj94EfO([In] object obj0, [In] object obj1) => ((ElementList) obj0).Add((Element) obj1);

    internal static bool LAegtJpx2ke2s5K1l6s([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void MlGD35pCaHVRrpa7JRm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int XsM6jEpi3UR03ZrNnqw([In] object obj0, [In] object obj1) => ((OrganizationModelManager) obj0).Publish((IOrganizationModel) obj1);

    internal static object eCmbZnp3QT7VDL9t6UF([In] object obj0) => (object) ((IOrganizationModel) obj0).Description;

    internal static void aCNK3lpjSH8X69yeALn([In] object obj0, [In] object obj1) => ((IOrganizationModel) obj0).Description = (string) obj1;

    internal static object b8tbgapNFhDvLnqZAuC([In] object obj0) => (object) ((IOrganizationModel) obj0).ChangeAuthor;

    internal static object iqd3Nep0TfmKLpDUfH8([In] object obj0) => (object) ((IOrganizationModel) obj0).CreationAuthor;

    internal static void Yql8SqpZPEJ2R5Yk1am([In] object obj0) => ((Diagram) obj0).LoadDiagram();

    internal static bool wVstBgpASNGKQaZ0CUm([In] object obj0, [In] object obj1) => ((ElementList) obj0).Remove((Element) obj1);

    internal static object MhCAPbps7yBmjXe5aQB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jeTVtup7J9vVHho5qUa([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object GG6MGMpWDk1HSiQPvZo() => (object) Logger.Log;

    internal static void nawPX0pr5GdkquXquWd([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static void FXYv76pS3leOVpggFiV([In] object obj0, OrganizationValidationMessageType value) => ((OrganizationValidationMessage) obj0).Type = value;

    internal static void iafLkgpYh9V5TjnQ5mJ([In] object obj0, [In] object obj1) => ((OrganizationValidationMessage) obj0).Message = (string) obj1;

    internal static void w0478SpyOf1RnIvBNlE([In] object obj0, [In] object obj1) => ((OrganizationValidationMessage) obj0).ItemUids = (Guid[]) obj1;

    internal static int zOVBfPpVc0drRvIFyNe([In] object obj0) => ((List<OrganizationElement>) obj0).Count;

    internal static void qhLyrKplLi56pdQtIWt([In] object obj0, Guid value) => ((OrganizationValidationMessage) obj0).SubDiagram = value;

    internal static object zNFoYbpfq8hqgCgVwhu([In] object obj0) => (object) ((Connector) obj0).EndElement;

    internal static object U4eStOp4VpSK4E1ETmX([In] object obj0) => (object) ((Element) obj0).Name;

    internal static object WoMyaLpcXaK48vyN5HX([In] object obj0) => (object) ((string) obj0).ToUpper();

    internal static int AEJhECpPDooQayPIw9U([In] object obj0) => ((ElementList) obj0).Count;

    internal static object PFyBELpQPc8H8fWVcDQ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object kiXgeCp8jiD8rDAVZTI([In] object obj0) => (object) ((List<Guid>) obj0).ToArray();

    internal static int uqiMX6p5b9yYJQ86cE4([In] object obj0) => ((List<OrganizationModelManager.DuplicateElement>) obj0).Count;

    internal static int r4UB9GpddckqnaXp8a9([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static int EuQ5LPpE9vxZwRmuIJy([In] object obj0) => ((List<string>) obj0).Count;

    internal static bool Fp0mFEpGEO1JKagZQyM([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object xhXOQKpXZjyexx0lWVw([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);

    internal static void AVCwqXp9n39UxEp8KmQ([In] object obj0, [In] bool obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).DisableSoftDeletable = obj1;

    internal static object ewGAMSp1jfNUB9Wkg3B() => (object) OrganizationItemManager.Instance;

    internal static object MSR9qVpMOjjAJv8Hryp([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void lnqRmwphwxIWvcgB6f9([In] object obj0, [In] object obj1) => ((ICacheService) obj0).Remove((string) obj1);

    internal static bool r7pDU8pBVQPxtN8FCbS([In] object obj0) => ((IOrganizationItem) obj0).IsDeleted;

    internal static void XvjEPnppOEWj1VyFZxK([In] object obj0, [In] object obj1) => ((IOrganizationItem) obj0).ParentItem = (IOrganizationItem) obj1;

    internal static void mnsNqBpOgXPO5nuloPE([In] object obj0) => ((ICollection<EleWise.ELMA.Security.Models.IUser>) obj0).Clear();

    internal static object L9RKXtpTJqf1LuxqdiU([In] object obj0) => (object) ((IOrganizationItem) obj0).Name;

    internal static void lryBp6pFXr2Vv0lNvj8([In] object obj0, [In] object obj1) => ((IOrganizationItem) obj0).Name = (string) obj1;

    internal static void uRETyDpvIgwiAoK47AY([In] object obj0) => ((IEntity) obj0).Delete();

    internal static object rsBsm1pqsA2b3c4fURi([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static long mnr1vIpglmuworNKNuE([In] object obj0) => ((AbstractNHEntityManager<IOrganizationModel, int>) obj0).Count();

    internal static void TZ6tkupJyNyD2Hafu9v([In] object obj0, [In] Type obj1) => ((ExportRule) obj0).ParentType = obj1;

    internal static void VlcrfBpIwCQgNdEsuAC([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void L8wBs9peJlAxMWwjj90([In] object obj0, [In] ExportRuleType obj1) => ((ExportRule) obj0).ExportRuleType = obj1;

    private class DuplicateElement
    {
      public Guid Uid;
      public object Name;
      public Guid SubDiagram;
      internal static object ndCCEewWMRu7DIQ7laMq;

      public DuplicateElement()
      {
        OrganizationModelManager.DuplicateElement.tSCppJwWpnWAe8wc5uIl();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void tSCppJwWpnWAe8wc5uIl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static bool n8BOIcwWhnOPprjBEATW() => OrganizationModelManager.DuplicateElement.ndCCEewWMRu7DIQ7laMq == null;

      internal static OrganizationModelManager.DuplicateElement WN13iGwWBKJPg2rU7pAJ() => (OrganizationModelManager.DuplicateElement) OrganizationModelManager.DuplicateElement.ndCCEewWMRu7DIQ7laMq;
    }
  }
}
