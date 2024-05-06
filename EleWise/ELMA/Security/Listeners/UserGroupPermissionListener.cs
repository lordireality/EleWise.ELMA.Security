// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.UserGroupPermissionListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  /// <summary>Листенер группы пользователей</summary>
  [Component]
  internal class UserGroupPermissionListener : EntityEventsListener
  {
    internal static UserGroupPermissionListener HYrkYU7KSRqxUBTlt5Y;

    /// <summary>Сервис проверки привилегий пользователя</summary>
    public SecurityService SecurityService
    {
      get => this.\u003CSecurityService\u003Ek__BackingField;
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
              this.\u003CSecurityService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
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

    /// <summary>Менеджер работы с глобальными привилегиями</summary>
    public GroupPermissionManager GroupPermissionManager
    {
      get => this.\u003CGroupPermissionManager\u003Ek__BackingField;
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
              this.\u003CGroupPermissionManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
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

    /// <summary>Перед удалением</summary>
    /// <param name="event">Параметры события</param>
    /// <returns><c>true</c>, если нужно первать операцию</returns>
    public override bool OnPreDelete(PreDeleteEvent @event)
    {
      int num1 = 3;
      GroupPermission groupPermission;
      IUserGroup entity;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!entity.IsSystem)
              {
                UserGroupPermissionListener.kIKs2676IgpTxFHokkE((object) this.GroupPermissionManager, (object) entity);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 0 : 0;
                continue;
              }
              goto label_25;
            case 2:
              entity = @event.Entity as IUserGroup;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 9 : 10;
              continue;
            case 3:
              if (@event != null)
              {
                num2 = 2;
                continue;
              }
              goto label_16;
            case 4:
              if (!(UserGroupPermissionListener.mQ9JV77C0bIqiGKLaKo((object) groupPermission) == UserGroupPermissionListener.tdMBGv7inRKEdVVdb3B((object) CommonPermissions.AdminPermission)))
              {
                if (!UserGroupPermissionListener.y42dyG7x4BcvZP9nwGp(groupPermission.PermissionId, UserGroupPermissionListener.tdMBGv7inRKEdVVdb3B((object) PermissionProvider.AccessManagmentPermission)))
                  goto case 9;
                else
                  goto label_5;
              }
              else
                goto label_12;
            case 5:
              goto label_16;
            case 6:
              if (groupPermission == null)
              {
                num2 = 9;
                continue;
              }
              goto case 11;
            case 7:
              goto label_3;
            case 8:
              goto label_10;
            case 9:
              this.ResetPermissionsCacheIfNeeded(UserGroupPermissionListener.gEtO3t7kXAn1MOr11hL((object) @event));
              num2 = 8;
              continue;
            case 10:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 1;
                continue;
              }
              break;
            case 11:
              if (UserGroupPermissionListener.y42dyG7x4BcvZP9nwGp(UserGroupPermissionListener.VgwZLS7aNdJpe7KrFc6(UserGroupPermissionListener.MhFNxy7D7IBx4AgBw4C((object) groupPermission)), SecurityConstants.AdminGroupUid))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 3 : 4;
                continue;
              }
              goto case 9;
            case 12:
              goto label_14;
            case 13:
              goto label_6;
          }
          groupPermission = UserGroupPermissionListener.gEtO3t7kXAn1MOr11hL((object) @event) as GroupPermission;
          num2 = 6;
        }
label_5:
        num1 = 13;
        continue;
label_12:
        num1 = 7;
        continue;
label_25:
        num1 = 12;
      }
label_3:
      throw new InvalidOperationException((string) UserGroupPermissionListener.NNXmRs7mP1Ofo1GVE5X(UserGroupPermissionListener.ePcBy87oKp8r8MkHCuF(1801131332 >> 4 ^ 112584472), (object) new object[2]
      {
        UserGroupPermissionListener.BOtIWJ7tMLlEXAyA1Pm((object) groupPermission.Group),
        UserGroupPermissionListener.yj8ru473aZMRgpSt0ii((object) CommonPermissions.AdminPermission)
      }));
label_6:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) UserGroupPermissionListener.ePcBy87oKp8r8MkHCuF(-629935560 ^ -1103494022 ^ 1682546702), UserGroupPermissionListener.BOtIWJ7tMLlEXAyA1Pm(UserGroupPermissionListener.MhFNxy7D7IBx4AgBw4C((object) groupPermission)), UserGroupPermissionListener.yj8ru473aZMRgpSt0ii((object) PermissionProvider.AccessManagmentPermission)));
label_10:
      return UserGroupPermissionListener.ksSCSm7jusMPOqnCUgy((object) this, (object) @event);
label_14:
      throw new InvalidOperationException((string) UserGroupPermissionListener.NNXmRs7mP1Ofo1GVE5X(UserGroupPermissionListener.ePcBy87oKp8r8MkHCuF(617710536 ^ 617731638), (object) new object[1]
      {
        UserGroupPermissionListener.BOtIWJ7tMLlEXAyA1Pm((object) entity)
      }));
label_16:
      return false;
    }

    /// <inheritdoc />
    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (@event != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          case 3:
            goto label_4;
          default:
            this.ResetPermissionsCacheIfNeeded(@event.Entity);
            num = 3;
            continue;
        }
      }
label_4:
      return false;
label_5:
      return false;
    }

    /// <inheritdoc />
    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (@event != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            goto label_2;
          default:
            this.ResetPermissionsCacheIfNeeded(UserGroupPermissionListener.gEtO3t7kXAn1MOr11hL((object) @event));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return false;
label_6:
      return false;
    }

    private void ResetPermissionsCacheIfNeeded(object entity)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.SecurityService != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 2:
            goto label_6;
          case 3:
            goto label_3;
          case 4:
            this.SecurityService.ResetPermissionsCache();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 2;
            continue;
          default:
            if (entity is GroupPermission)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 4 : 4;
              continue;
            }
            goto label_2;
        }
      }
label_6:
      return;
label_3:
      return;
label_2:
      return;
label_10:;
    }

    public UserGroupPermissionListener()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JaYSqb7UdKDr3dP5g1g() => UserGroupPermissionListener.HYrkYU7KSRqxUBTlt5Y == null;

    internal static UserGroupPermissionListener iDQTcM7RbMGpd7boo1g() => UserGroupPermissionListener.HYrkYU7KSRqxUBTlt5Y;

    internal static object ePcBy87oKp8r8MkHCuF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BOtIWJ7tMLlEXAyA1Pm([In] object obj0) => (object) ((IUserGroup) obj0).Name;

    internal static object NNXmRs7mP1Ofo1GVE5X([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static void kIKs2676IgpTxFHokkE([In] object obj0, [In] object obj1) => ((GroupPermissionManager) obj0).RemovePermission((IUserGroup) obj1);

    internal static object gEtO3t7kXAn1MOr11hL([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static object MhFNxy7D7IBx4AgBw4C([In] object obj0) => (object) ((GroupPermission) obj0).Group;

    internal static Guid VgwZLS7aNdJpe7KrFc6([In] object obj0) => ((IUserGroup) obj0).Uid;

    internal static bool y42dyG7x4BcvZP9nwGp([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid mQ9JV77C0bIqiGKLaKo([In] object obj0) => ((GroupPermission) obj0).PermissionId;

    internal static Guid tdMBGv7inRKEdVVdb3B([In] object obj0) => ((Permission) obj0).Id;

    internal static object yj8ru473aZMRgpSt0ii([In] object obj0) => (object) ((Permission) obj0).Name;

    internal static bool ksSCSm7jusMPOqnCUgy([In] object obj0, [In] object obj1) => __nonvirtual (((EntityEventsListener) obj0).OnPreDelete((PreDeleteEvent) obj1));
  }
}
