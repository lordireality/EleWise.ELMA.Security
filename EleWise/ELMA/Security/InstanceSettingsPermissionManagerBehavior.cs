// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceSettingsPermissionManagerBehavior
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Точка расширения для изменения поведения EntityManager
  /// </summary>
  [Component]
  public class InstanceSettingsPermissionManagerBehavior : EntityManagerBehavior
  {
    private readonly Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissions;
    private readonly ISecurityService securityService;
    /// <summary>Служба аутентификации системы</summary>
    protected readonly IAuthenticationService AuthenticationService;
    /// <summary>
    /// Сервис управления привилегиями, манипуляции со списком
    /// </summary>
    protected readonly IPermissionManagmentService PermissionManagmentService;
    internal static InstanceSettingsPermissionManagerBehavior sIYl1hmL4X0nBAuNdsv;

    /// <summary>
    /// Сервис, влияющий на результат проверки прав в текущем контексте
    /// </summary>
    public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService
    {
      get => this.\u003CRunWithElevatedPrivilegiesService\u003Ek__BackingField;
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
              this.\u003CRunWithElevatedPrivilegiesService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
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

    /// <summary>Провайдер преобразования базы данных</summary>
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
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

    /// <summary>Конструктор</summary>
    /// <param name="instanceSettingsPermissions">Интерфейсы прав доступа к экземпляру объекта на основе настроек</param>
    /// <param name="authenticationService">Служба аутентификации системы</param>
    /// <param name="permissionManagmentService">Управление привилегиями: манипуляции со списком</param>
    /// <param name="securityService">Интерфейс проверки привилегий пользователя</param>
    public InstanceSettingsPermissionManagerBehavior(
      Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissions,
      IAuthenticationService authenticationService,
      IPermissionManagmentService permissionManagmentService,
      ISecurityService securityService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.instanceSettingsPermissions = instanceSettingsPermissions;
      this.AuthenticationService = authenticationService;
      this.PermissionManagmentService = permissionManagmentService;
      this.securityService = securityService;
    }

    /// <summary>Проверка, есть ли права</summary>
    /// <param name="instanceSettingsPermission">Интерфейс прав доступа к экземпляру объекта на основе настроек</param>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    private bool HasAdminPermission(
      IInstanceSettingsPermission instanceSettingsPermission,
      IUser user)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_7;
          case 2:
            if (!((Permission) InstanceSettingsPermissionManagerBehavior.BOQsjtmzIHsovYm7aox((object) instanceSettingsPermission) != (Permission) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 1 : 4;
              continue;
            }
            goto label_6;
          default:
            goto label_6;
        }
      }
label_6:
      return InstanceSettingsPermissionManagerBehavior.hJnLDl6uTW3kDnNZoEo((object) this.securityService, (object) user, InstanceSettingsPermissionManagerBehavior.BOQsjtmzIHsovYm7aox((object) instanceSettingsPermission));
label_7:
      return false;
    }

    /// <summary>Вычисляет права на основе критерии</summary>
    /// <param name="criteria">Критерия</param>
    private IInstanceSettingsPermission GetInstanceSettingsPermission(
      ICriteria criteria)
    {
      int num1 = 3;
      System.Type criteriaRootType;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              criteriaRootType = (System.Type) null;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_12;
          }
        }
label_4:
        num1 = 2;
      }
label_5:
      IInstanceSettingsPermission settingsPermission;
      try
      {
        criteriaRootType = InstanceSettingsPermissionManagerBehavior.RBCy0Q6wvWYCwh7OoKQ((object) criteria);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_12;
        }
      }
      catch (HibernateException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              settingsPermission = (IInstanceSettingsPermission) null;
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
              continue;
            default:
              goto label_13;
          }
        }
      }
label_13:
      return settingsPermission;
label_12:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.instanceSettingsPermissions().FirstOrDefault<IInstanceSettingsPermission>((Func<IInstanceSettingsPermission, bool>) (i => InstanceSettingsPermissionManagerBehavior.\u003C\u003Ec__DisplayClass14_0.kHASi2w6iedUTcQwuQD7(criteriaRootType, InstanceSettingsPermissionManagerBehavior.\u003C\u003Ec__DisplayClass14_0.zkPF6Gw6Cy5TBCspGrrH((object) i))));
    }

    /// <inheritdoc />
    public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 34;
      IInstanceSettingsPermission instanceSettingsPermission;
      IInstanceSettingsPermissionChild childPS;
      while (true)
      {
        int num2 = num1;
        Guid? permissionId;
        PropertyMetadata propertyMetadata1;
        while (true)
        {
          string str1;
          string name;
          string str2;
          EleWise.ELMA.Security.Models.IUser user1;
          Guid guid;
          PropertyMetadata propertyMetadata2;
          Permission permission;
          EntityMetadata entityMetadata;
          IUser user2;
          bool flag;
          System.Type entityType;
          int num3;
          object obj;
          switch (num2)
          {
            case 1:
              InstanceSettingsPermissionManagerBehavior.V9b6yj673vCEMBamgZd((object) criteria, (object) Expression.Sql((string) InstanceSettingsPermissionManagerBehavior.Du4d5f6sDhUHRUfZ8Sn(InstanceSettingsPermissionManagerBehavior.Tqxhaf6KTuQFV3Xkp84(-404268492 ^ -404260888), InstanceSettingsPermissionManagerBehavior.wD61nl60O295cRoRauq((object) this.TransformationProvider, (object) str1, InstanceSettingsPermissionManagerBehavior.Tqxhaf6KTuQFV3Xkp84(266768307 ^ 266772615)), (object) ((Dialect) InstanceSettingsPermissionManagerBehavior.m02WJd6ZBF2JS4MitTm((object) this.TransformationProvider)).QuoteIfNeeded(name), InstanceSettingsPermissionManagerBehavior.wAY4mV6Ap5806Uk6QoR(InstanceSettingsPermissionManagerBehavior.m02WJd6ZBF2JS4MitTm((object) this.TransformationProvider), (object) str2)), new object[2]
              {
                (object) user1.Id,
                (object) guid
              }, new IType[2]
              {
                (IType) NHibernateUtil.Int64,
                (IType) NHibernateUtil.Guid
              }));
              num2 = 36;
              continue;
            case 2:
              entityMetadata = (EntityMetadata) InstanceSettingsPermissionManagerBehavior.r5Z2LT6DTXl96GnIFOX(InstanceSettingsPermissionManagerBehavior.DxXrHG6Rg29iiUbJQkF((object) instanceSettingsPermission), true, true);
              num2 = 31;
              continue;
            case 3:
label_38:
              permissionId = filter.PermissionId;
              num2 = 47;
              continue;
            case 4:
              instanceSettingsPermission = this.GetInstanceSettingsPermission(criteria);
              num2 = 37;
              continue;
            case 5:
              goto label_52;
            case 6:
              str2 = (string) InstanceSettingsPermissionManagerBehavior.x4XKwL6i258NxdwFf5e((object) (SimpleTypeSettings) InstanceSettingsPermissionManagerBehavior.N7rVpH6CxPYLR5oMDXD((object) propertyMetadata2));
              num2 = 39;
              continue;
            case 7:
            case 48:
              if (InstanceSettingsPermissionManagerBehavior.nrfgBu6m8XeUBeFUlWv((object) instanceSettingsPermission))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 7 : 29;
                continue;
              }
              goto label_63;
            case 8:
              goto label_21;
            case 9:
              goto label_35;
            case 10:
              permission = this.PermissionManagmentService.GetPermissionForBase(CommonPermissions.View, entityType);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 35 : 24;
              continue;
            case 11:
              name = (string) InstanceSettingsPermissionManagerBehavior.Tqxhaf6KTuQFV3Xkp84(-880091293 >> 4 ^ -55007198);
              num2 = 24;
              continue;
            case 12:
              goto label_27;
            case 13:
              goto label_17;
            case 14:
              if (filter == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 36 : 49;
                continue;
              }
              obj = InstanceSettingsPermissionManagerBehavior.XYUA766oINc5VUva7Mb((object) filter);
              break;
            case 15:
              if (filter == null & flag)
              {
                num2 = 32;
                continue;
              }
              goto case 25;
            case 16:
            case 50:
              if (!EleWise.ELMA.SR.GetSetting<bool>((string) InstanceSettingsPermissionManagerBehavior.Tqxhaf6KTuQFV3Xkp84(-1536327508 ^ -1536321530)))
              {
                if (!InstanceSettingsPermissionManagerBehavior.JfIZl96UVRkBWub9svj((object) this.RunWithElevatedPrivilegiesService))
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 4 : 0;
                  continue;
                }
                goto label_45;
              }
              else
                goto label_56;
            case 17:
              guid = permissionId.Value;
              num2 = 42;
              continue;
            case 18:
              goto label_58;
            case 19:
              goto label_12;
            case 20:
              goto label_20;
            case 21:
              permission = CommonPermissions.View;
              num2 = 45;
              continue;
            case 22:
              if (propertyMetadata1 != null)
              {
                name = ((SimpleTypeSettings) InstanceSettingsPermissionManagerBehavior.N7rVpH6CxPYLR5oMDXD((object) propertyMetadata1)).FieldName;
                num2 = 41;
                continue;
              }
              num2 = 18;
              continue;
            case 23:
              if (propertyMetadata2 != null)
              {
                num2 = 6;
                continue;
              }
              goto label_12;
            case 24:
              childPS = instanceSettingsPermission as IInstanceSettingsPermissionChild;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 28 : 1;
              continue;
            case 25:
              if (filter == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 0;
                continue;
              }
              goto case 51;
            case 26:
              obj = (object) this.AuthenticationService.GetCurrentUser();
              goto label_80;
            case 27:
              goto label_48;
            case 28:
              if (childPS != null)
              {
                num2 = 44;
                continue;
              }
              goto case 1;
            case 29:
              entityType = instanceSettingsPermission.EntityType;
              num2 = 10;
              continue;
            case 30:
              flag = this.HasAdminPermission(instanceSettingsPermission, user2);
              num2 = 15;
              continue;
            case 31:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => (string) InstanceSettingsPermissionManagerBehavior.\u003C\u003Ec__DisplayClass15_0.D52FlDw6ZkBwLm4ZJwpN((object) p) == (string) InstanceSettingsPermissionManagerBehavior.\u003C\u003Ec__DisplayClass15_0.NL6yQSw6AdTMqmWSWec9((object) instanceSettingsPermission)));
              num2 = 23;
              continue;
            case 32:
              goto label_6;
            case 33:
              if (filter == null)
              {
                num2 = 16;
                continue;
              }
              goto case 43;
            case 34:
              num2 = 33;
              continue;
            case 35:
              if (InstanceSettingsPermissionManagerBehavior.OIJsQ666fQLkvFOqDvt((object) permission, (object) null))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 21 : 17;
                continue;
              }
              goto case 45;
            case 36:
              goto label_65;
            case 37:
              if (instanceSettingsPermission == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 19 : 27;
                continue;
              }
              goto case 46;
            case 38:
              goto label_37;
            case 39:
              str1 = (string) InstanceSettingsPermissionManagerBehavior.ghF3gy63t149hRa58S4((object) entityMetadata);
              num2 = 11;
              continue;
            case 40:
              goto label_64;
            case 41:
              guid = InstanceSettingsPermissionManagerBehavior.yUf4AZ6N1xy2FbVPJHZ((object) childPS, guid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 1;
              continue;
            case 42:
            case 52:
              if (user2 != null)
              {
                user1 = (EleWise.ELMA.Security.Models.IUser) user2;
                num2 = 2;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 10 : 12;
              continue;
            case 43:
              if (!InstanceSettingsPermissionManagerBehavior.rDdadU6b3qg2QU9J85e((object) filter))
              {
                num2 = 50;
                continue;
              }
              goto label_29;
            case 44:
              goto label_30;
            case 45:
              guid = InstanceSettingsPermissionManagerBehavior.uD0UaV6kuBuTvqXKRLT((object) permission);
              num2 = 52;
              continue;
            case 46:
              if (InstanceSettingsPermissionManagerBehavior.DxXrHG6Rg29iiUbJQkF((object) instanceSettingsPermission).IsInheritOrSame<ISecuritySetIdHolder>())
              {
                num2 = 14;
                continue;
              }
              goto label_39;
            case 47:
              if (permissionId.HasValue)
              {
                num2 = 20;
                continue;
              }
              goto case 7;
            case 49:
              obj = (object) null;
              break;
            case 51:
              num3 = !InstanceSettingsPermissionManagerBehavior.NTSyiL6tRhLkUc94LRk((object) filter) ? 1 : 0;
              goto label_82;
            default:
              num3 = 0;
              goto label_82;
          }
          if (obj == null)
          {
            num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 26 : 16;
            continue;
          }
label_80:
          user2 = (IUser) obj;
          num2 = 30;
          continue;
label_82:
          int num4 = flag ? 1 : 0;
          if ((num3 & num4) == 0)
          {
            if (filter == null)
              num2 = 48;
            else
              goto label_38;
          }
          else
            num2 = 40;
        }
label_20:
        permissionId = filter.PermissionId;
        num1 = 17;
        continue;
label_30:
        // ISSUE: reference to a compiler-generated method
        propertyMetadata1 = ((ClassMetadata) InstanceSettingsPermissionManagerBehavior.r5Z2LT6DTXl96GnIFOX(InstanceSettingsPermissionManagerBehavior.sap6kZ6jxRuHcpRo6Pt((object) childPS), true, true)).Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == (string) InstanceSettingsPermissionManagerBehavior.\u003C\u003Ec__DisplayClass15_0.QkfigHw6sCFr0BjjDlS1((object) childPS)));
        num1 = 22;
        continue;
label_56:
        num1 = 13;
      }
label_52:
      return;
label_21:
      return;
label_35:
      return;
label_27:
      return;
label_17:
      return;
label_48:
      return;
label_6:
      return;
label_65:
      return;
label_37:
      return;
label_64:
      return;
label_63:
      return;
label_12:
      throw new InvalidOperationException((string) InstanceSettingsPermissionManagerBehavior.gMr1lZ6xKMmXveYKEZG((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458228329), (object) new object[1]
      {
        InstanceSettingsPermissionManagerBehavior.STDL1s6ay9HdYCCyCjt((object) instanceSettingsPermission)
      }));
label_45:
      return;
label_58:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) InstanceSettingsPermissionManagerBehavior.Tqxhaf6KTuQFV3Xkp84(-1807813747 ^ -1807819017), (object) childPS.ParentPropertyName));
label_39:
      return;
label_29:;
    }

    internal static bool IODIuPm2Arr0VlU3PCc() => InstanceSettingsPermissionManagerBehavior.sIYl1hmL4X0nBAuNdsv == null;

    internal static InstanceSettingsPermissionManagerBehavior vjwJICmH0I1U1jtprvF() => InstanceSettingsPermissionManagerBehavior.sIYl1hmL4X0nBAuNdsv;

    internal static object BOQsjtmzIHsovYm7aox([In] object obj0) => (object) ((IInstanceSettingsPermission) obj0).AdminPermission;

    internal static bool hJnLDl6uTW3kDnNZoEo([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).HasPermission((IUser) obj1, (Permission) obj2);

    internal static System.Type RBCy0Q6wvWYCwh7OoKQ([In] object obj0) => ((ICriteria) obj0).GetRootEntityTypeIfAvailable();

    internal static bool rDdadU6b3qg2QU9J85e([In] object obj0) => ((IEntityFilter) obj0).DisableSecurity;

    internal static object Tqxhaf6KTuQFV3Xkp84(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool JfIZl96UVRkBWub9svj([In] object obj0) => ((RunWithElevatedPrivilegiesService) obj0).Turned;

    internal static System.Type DxXrHG6Rg29iiUbJQkF([In] object obj0) => ((IInstanceSettingsPermission) obj0).PermissionHolderType;

    internal static object XYUA766oINc5VUva7Mb([In] object obj0) => (object) ((IEntityFilter) obj0).PermissionUser;

    internal static bool NTSyiL6tRhLkUc94LRk([In] object obj0) => ((IEntityFilter) obj0).SkipAdminPermission;

    internal static bool nrfgBu6m8XeUBeFUlWv([In] object obj0) => ((IInstanceSettingsPermission) obj0).Filtering;

    internal static bool OIJsQ666fQLkvFOqDvt([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static Guid uD0UaV6kuBuTvqXKRLT([In] object obj0) => ((Permission) obj0).Id;

    internal static object r5Z2LT6DTXl96GnIFOX([In] System.Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static object STDL1s6ay9HdYCCyCjt([In] object obj0) => (object) ((IInstanceSettingsPermission) obj0).TargetPropetyName;

    internal static object gMr1lZ6xKMmXveYKEZG([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object N7rVpH6CxPYLR5oMDXD([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object x4XKwL6i258NxdwFf5e([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static object ghF3gy63t149hRa58S4([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static System.Type sap6kZ6jxRuHcpRo6Pt([In] object obj0) => ((IInstanceSettingsPermission) obj0).EntityType;

    internal static Guid yUf4AZ6N1xy2FbVPJHZ([In] object obj0, [In] Guid obj1) => ((IInstanceSettingsPermissionChild) obj0).GetParentPermissionId(obj1);

    internal static object wD61nl60O295cRoRauq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).NoLockTableExpression((string) obj1, (string) obj2);

    internal static object m02WJd6ZBF2JS4MitTm([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object wAY4mV6Ap5806Uk6QoR([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object Du4d5f6sDhUHRUfZ8Sn([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object V9b6yj673vCEMBamgZd([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);
  }
}
