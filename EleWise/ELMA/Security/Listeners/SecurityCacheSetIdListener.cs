// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.SecurityCacheSetIdListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  [Component]
  internal class SecurityCacheSetIdListener : EntityEventsListener
  {
    internal static SecurityCacheSetIdListener ALHaCYAv26gdW5eKEvo;

    /// <summary>Сервис для работы с мягко-удаленными сущностями</summary>
    public RunWithSoftDeletableService RunWithSoftDeletableService
    {
      get => this.\u003CRunWithSoftDeletableService\u003Ek__BackingField;
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
              this.\u003CRunWithSoftDeletableService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
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

    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num = 4;
      ISecuritySetIdHolder securitySetIdHolder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            this.SetId(securitySetIdHolder, (IEntityPersister) SecurityCacheSetIdListener.Ogogn0AIphYs0eEaVu7((object) @event), (object[]) SecurityCacheSetIdListener.NyXS2DAe4IemldOHAXU((object) @event));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
            continue;
          case 3:
            if (securitySetIdHolder != null)
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 4:
            securitySetIdHolder = SecurityCacheSetIdListener.VIO6plAJwceZglCV4iF((object) @event) as ISecuritySetIdHolder;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 3;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return false;
label_6:
      return false;
    }

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    private void SetId(
      ISecuritySetIdHolder securitySetIdHolder,
      IEntityPersister persister,
      object[] state)
    {
      int num1 = 1;
      long? nullable;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nullable = new long?();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 0 : 0;
            continue;
          case 2:
            this.RunWithSoftDeletableService.Turned = true;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 1 : 3;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_48;
          default:
            flag = SecurityCacheSetIdListener.se6DMbAnyAyIIMPXVMH((object) this.RunWithSoftDeletableService);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 2 : 1;
            continue;
        }
      }
label_48:
      return;
label_3:
      try
      {
        int num2;
        if (SecurityCacheSetIdListener.KOFrjBALvBfCe8nko0j((object) securitySetIdHolder) != null)
          num2 = 28;
        else
          goto label_37;
label_5:
        IUserGroup userGroup;
        IOrganizationItem organizationItem;
        EleWise.ELMA.Security.Models.IUser user;
        IEntity assigned;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_41;
            case 2:
              goto label_44;
            case 3:
              goto label_34;
            case 4:
              goto label_37;
            case 6:
              userGroup = assigned as IUserGroup;
              num2 = 15;
              continue;
            case 7:
            case 18:
              user = assigned as EleWise.ELMA.Security.Models.IUser;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 2 : 11;
              continue;
            case 8:
              goto label_15;
            case 9:
              organizationItem = assigned as IOrganizationItem;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 4 : 14;
              continue;
            case 10:
              nullable = new long?(SecurityCacheSetIdListener.B3PeomsbSSXiVP8LmJm(userGroup.Id));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 9 : 3;
              continue;
            case 11:
              if (user == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 30 : 19;
                continue;
              }
              goto case 13;
            case 12:
            case 16:
              SecurityCacheSetIdListener.vOq48PsoDcbWJOjcOy4((object) persister, (object) state, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-201065280 ^ -201085400), (object) nullable);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 4 : 22;
              continue;
            case 13:
              nullable = new long?(SecurityCacheSetIdListener.S1l215sUqDh8Bmkfw6u(user.Id));
              num2 = 17;
              continue;
            case 14:
              if (organizationItem == null)
              {
                num2 = 18;
                continue;
              }
              goto case 25;
            case 15:
              if (userGroup != null)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
            case 17:
            case 30:
              if (!(assigned is PropertyMetadataReference))
              {
                num2 = 26;
                continue;
              }
              goto label_31;
            case 19:
            case 26:
              if (nullable.HasValue)
              {
                num2 = 12;
                continue;
              }
              goto label_41;
            case 20:
              goto label_28;
            case 21:
              nullable = new long?(-1L);
              num2 = 16;
              continue;
            case 22:
              securitySetIdHolder.UserSecuritySetCacheId = nullable;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 2 : 0;
              continue;
            case 23:
              if (UserSecuritySetHelper.IsGroup(securitySetIdHolder.UserSecuritySetCacheId))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 2 : 3;
                continue;
              }
              goto label_6;
            case 24:
              goto label_6;
            case 25:
              nullable = new long?(SecurityCacheSetIdListener.g0Hm6IsKJEbJ6EwiCNe(organizationItem.Id));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 7 : 7;
              continue;
            case 27:
              if (SecurityCacheSetIdListener.TH6Pp2sug7jsi8sSE0D(SecurityCacheSetIdListener.dwfUgAA2fQymn9oMW9H((object) securitySetIdHolder), SecurityCacheSetIdListener.ilLKKwAHNV7wt6TV1H0((object) CommonRoleTypes.User)))
              {
                num2 = 21;
                continue;
              }
              goto label_15;
            case 28:
              assigned = securitySetIdHolder.Assigned;
              num2 = 6;
              continue;
            case 29:
              goto label_24;
            default:
              if (SecurityCacheSetIdListener.dwfUgAA2fQymn9oMW9H((object) securitySetIdHolder) != SecurityCacheSetIdListener.ilLKKwAHNV7wt6TV1H0((object) CommonRoleTypes.Group))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 27 : 2;
                continue;
              }
              goto label_15;
          }
        }
label_44:
        return;
label_34:
        return;
label_28:
        return;
label_24:
        return;
label_15:
        throw new ArgumentException((string) SecurityCacheSetIdListener.IXnhSHsw01Xuuk9cNUl(1567399832 << 6 ^ 1529328694));
label_31:
        return;
label_41:
        throw new InvalidOperationException((string) SecurityCacheSetIdListener.sImhDwsRLiooyIrOQxA(SecurityCacheSetIdListener.IXnhSHsw01Xuuk9cNUl(-1976147292 - 421656521 ^ 1897150553), (object) new object[2]
        {
          assigned == null ? SecurityCacheSetIdListener.IXnhSHsw01Xuuk9cNUl(781628008 - 11982093 ^ 769641265) : (object) assigned.ToString(),
          (object) securitySetIdHolder
        }));
label_6:
        if (SecurityCacheSetIdListener.XEqs03Azb54Uw3HN8ZV(SecurityCacheSetIdListener.dwfUgAA2fQymn9oMW9H((object) securitySetIdHolder), CommonRoleTypes.OrganizationItem.Id))
          return;
        num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_37:
        if (SecurityCacheSetIdListener.XEqs03Azb54Uw3HN8ZV(SecurityCacheSetIdListener.dwfUgAA2fQymn9oMW9H((object) securitySetIdHolder), SecurityCacheSetIdListener.ilLKKwAHNV7wt6TV1H0((object) CommonRoleTypes.Group)))
        {
          num2 = 23;
          goto label_5;
        }
        else
          goto label_6;
      }
      finally
      {
        SecurityCacheSetIdListener.MOw3MvstruHXtqXIVt8((object) this.RunWithSoftDeletableService, flag);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num = 1;
      ISecuritySetIdHolder securitySetIdHolder;
      while (true)
      {
        switch (num)
        {
          case 1:
            securitySetIdHolder = SecurityCacheSetIdListener.VIO6plAJwceZglCV4iF((object) @event) as ISecuritySetIdHolder;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          case 4:
            this.SetId(securitySetIdHolder, (IEntityPersister) SecurityCacheSetIdListener.Ogogn0AIphYs0eEaVu7((object) @event), (object[]) SecurityCacheSetIdListener.FK5KfrsmI7vJ0LIQopo((object) @event));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 2 : 1;
            continue;
          default:
            if (securitySetIdHolder != null)
            {
              num = 4;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return false;
label_4:
      return false;
    }

    public SecurityCacheSetIdListener()
    {
      SecurityCacheSetIdListener.fhdg8xs6BNc259r7w1C();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UR7JpOAqQyyk38J68rE() => SecurityCacheSetIdListener.ALHaCYAv26gdW5eKEvo == null;

    internal static SecurityCacheSetIdListener bDMXdSAgvQMheoCaso2() => SecurityCacheSetIdListener.ALHaCYAv26gdW5eKEvo;

    internal static object VIO6plAJwceZglCV4iF([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static object Ogogn0AIphYs0eEaVu7([In] object obj0) => (object) ((AbstractPreDatabaseOperationEvent) obj0).Persister;

    internal static object NyXS2DAe4IemldOHAXU([In] object obj0) => (object) ((PreInsertEvent) obj0).State;

    internal static bool se6DMbAnyAyIIMPXVMH([In] object obj0) => ((RunWithSoftDeletableService) obj0).Turned;

    internal static object KOFrjBALvBfCe8nko0j([In] object obj0) => (object) ((IInstanceSettingsPermissionHolder) obj0).Assigned;

    internal static Guid dwfUgAA2fQymn9oMW9H([In] object obj0) => ((IInstanceSettingsPermissionHolder) obj0).TypeRoleId;

    internal static Guid ilLKKwAHNV7wt6TV1H0([In] object obj0) => ((PermissionRoleType) obj0).Id;

    internal static bool XEqs03Azb54Uw3HN8ZV([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool TH6Pp2sug7jsi8sSE0D([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object IXnhSHsw01Xuuk9cNUl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static long B3PeomsbSSXiVP8LmJm(long id) => UserSecuritySetHelper.GetGroupMask(id);

    internal static long g0Hm6IsKJEbJ6EwiCNe(long id) => UserSecuritySetHelper.GetOrganizationItemMask(id);

    internal static long S1l215sUqDh8Bmkfw6u(long id) => UserSecuritySetHelper.GetUserMask(id);

    internal static object sImhDwsRLiooyIrOQxA([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static void vOq48PsoDcbWJOjcOy4([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IEntityPersister) obj0).Set((object[]) obj1, (string) obj2, obj3);

    internal static void MOw3MvstruHXtqXIVt8([In] object obj0, [In] bool obj1) => ((RunWithSoftDeletableService) obj0).Turned = obj1;

    internal static object FK5KfrsmI7vJ0LIQopo([In] object obj0) => (object) ((PreUpdateEvent) obj0).State;

    internal static void fhdg8xs6BNc259r7w1C() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
