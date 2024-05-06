// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.EntityPermissionService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис проверки/выдачи привилегий для объекта</summary>
  [Service(EnableInterceptors = true, Scope = ServiceScope.Shell, Type = ComponentType.Server)]
  internal class EntityPermissionService : IEntityPermissionService
  {
    private readonly ISecurityService securityService;
    private readonly IEnumerable<IInstanceSettingsPermission> instanceSettingsPermissions;
    private readonly IPermissionManagmentService permissionManagmentService;
    private readonly IEnumerable<IRoleTypeSelectorGroupsCategory> roleTypeSelectorGroupsCategories;
    private readonly IPermissionTypeRoleService permissionTypeRoleService;
    private readonly UserManager userManager;
    internal static EntityPermissionService MTvppH7NLZDLerXbwIt;

    /// <summary>ctor</summary>
    /// <param name="securityService">Интерфейс проверки привилегий пользователя</param>
    /// <param name="instanceSettingsPermissions">Интерфейс прав доступа к экземпляру объекта на основе настроек</param>
    /// <param name="permissionManagmentService">Управление привилегиями: манипуляции со списком</param>
    /// <param name="roleTypeSelectorGroupsCategories">Сервис для получения реализаций IRoleTypeSelectorGroupsModelItems на серверной стороне</param>
    /// <param name="permissionTypeRoleService">Сервис получения ролей</param>
    /// <param name="userManager">Менеджер пользователей</param>
    public EntityPermissionService(
      ISecurityService securityService,
      IEnumerable<IInstanceSettingsPermission> instanceSettingsPermissions,
      IPermissionManagmentService permissionManagmentService,
      IEnumerable<IRoleTypeSelectorGroupsCategory> roleTypeSelectorGroupsCategories,
      IPermissionTypeRoleService permissionTypeRoleService,
      UserManager userManager)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.securityService = securityService;
      this.instanceSettingsPermissions = instanceSettingsPermissions;
      this.permissionManagmentService = permissionManagmentService;
      this.roleTypeSelectorGroupsCategories = roleTypeSelectorGroupsCategories;
      this.permissionTypeRoleService = permissionTypeRoleService;
      this.userManager = userManager;
    }

    /// <inheritdoc />
    public bool CheckIfPermissionNeededForEntity(
      long[] objectsIds,
      Type type,
      long[] usersIds,
      string[] prefixedUsersIds,
      Guid permission,
      bool needReplacement = false)
    {
      int num1 = 2;
      // ISSUE: variable of a compiler-generated type
      EntityPermissionService.\u003C\u003Ec__DisplayClass7_0 cDisplayClass70;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass70.objectsIds = objectsIds;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass70 = new EntityPermissionService.\u003C\u003Ec__DisplayClass7_0();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass70.permission = permission;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 5;
            continue;
          case 4:
            goto label_17;
          case 5:
            goto label_3;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass70.\u003C\u003E4__this = this;
            num1 = 3;
            continue;
        }
      }
label_3:
      bool flag;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        EntityPermissionService.\u003C\u003Ec__DisplayClass7_1 cDisplayClass71 = new EntityPermissionService.\u003C\u003Ec__DisplayClass7_1();
        int num2 = 7;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass71.usersToCheck = this.FormUsersList(usersIds, prefixedUsersIds, needReplacement);
              num2 = 2;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              EntityPermissionService.crH6517sJkHVvJyDwCL((object) this.securityService, (object) new Action(cDisplayClass71.\u003CCheckIfPermissionNeededForEntity\u003Eb__0));
              num2 = 5;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass71.objects = (List<object>) null;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_17;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              cDisplayClass71.objects = cDisplayClass71.objects.Where<object>(new Func<object, bool>(cDisplayClass71.\u003CCheckIfPermissionNeededForEntity\u003Eb__1)).ToList<object>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 5 : 6;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              flag = cDisplayClass71.objects.Count > 0;
              num2 = 4;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass71.CS\u0024\u003C\u003E8__locals1 = cDisplayClass70;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass71.entityManager = (IEntityManager) EntityPermissionService.gYx4pg7AAo3924TjitE(type);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 3 : 2;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_17;
            default:
              flag = false;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 1 : 1;
              continue;
          }
        }
      }
label_17:
      return flag;
    }

    /// <inheritdoc />
    public IEnumerable<string> CheckGrantablePermissions(
      Type type,
      string guids,
      string data)
    {
      Contract.ArgumentNotNull((object) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897151609));
      Contract.ArgumentNotNullOrEmpty(guids, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751467293 ^ -1751454643));
      Contract.ArgumentNotNullOrEmpty(data, z2jc63fLkugS1X8Q9N.tE1kD1vbB(554338340 ^ 554360564));
      List<Guid> list = ((IEnumerable<Guid>) guids.FromJson<Guid[]>()).ToList<Guid>();
      IdAndTypeRole idAndTypeRole = data.FromJson<IdAndTypeRole>();
      object obj = EntityHelper.GetEntityManager(type).Load((object) idAndTypeRole.EntityId).CastAs<object>();
      ICollection<Permission> grantablePermissions = this.GetSettingsPermission(obj).CanGrandLevel(AuthenticationService.GetCurrentUser(), obj);
      if (grantablePermissions == null)
        return (IEnumerable<string>) new List<string>();
      list.RemoveAll((Predicate<Guid>) (i => grantablePermissions.Select<Permission, Guid>((Func<Permission, Guid>) (x => x.Id)).Contains<Guid>(i)));
      // ISSUE: reference to a compiler-generated method
      return list.Select<Guid, string>((Func<Guid, string>) (x => ((Permission) EntityPermissionService.\u003C\u003Ec__DisplayClass8_0.TkdJr3wxMHIk6555ciq2((object) this.permissionManagmentService, x)).Name));
    }

    /// <inheritdoc />
    public AddPermissionModel EntityAddPermission(
      long[] id,
      Type type,
      long[] usersIds,
      string[] prefixedUsersIds,
      Guid permission,
      Guid[] defaultPermissions = null,
      bool needReplacement = false)
    {
      int num1 = 19;
      AddPermissionModel addPermissionModel1;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata;
        List<object> objects;
        IEntityManager entityManager;
        long[] id1;
        List<EleWise.ELMA.Security.Models.IUser> users;
        EntityPermissionService permissionService;
        Guid permission1;
        Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>> dict;
        bool hasGrantPermission;
        Dictionary<long, IEnumerable<Permission>> grandPermissions;
        while (true)
        {
          switch (num2)
          {
            case 1:
              EntityPermissionService.fMkfZU7r4nxAVvPWHyb((object) addPermissionModel1, type);
              num2 = 4;
              continue;
            case 2:
              objects = (List<object>) null;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 3 : 5;
              continue;
            case 3:
              permissionService = this;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 3 : 22;
              continue;
            case 4:
              AddPermissionModel addPermissionModel2 = addPermissionModel1;
              Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>> objects1 = dict;
              Type type1 = type;
              Guid[] guidArray1 = defaultPermissions;
              Guid[] defaultPermissionUids;
              if (guidArray1 == null)
                defaultPermissionUids = new Guid[1]
                {
                  permission1
                };
              else
                goto label_30;
label_26:
              List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> roleTypeModels = this.GetRoleTypeModels(objects1, type1, defaultPermissionUids);
              addPermissionModel2.PermissionTypeRolesModels = (IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>) roleTypeModels;
              num2 = 16;
              continue;
label_30:
              defaultPermissionUids = guidArray1;
              goto label_26;
            case 5:
              EntityPermissionService.crH6517sJkHVvJyDwCL((object) this.securityService, (object) (Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      objects = ((IEnumerable) EntityPermissionService.\u003C\u003Ec__DisplayClass9_0.hht6PRwxg3EBDF6XKiQ7((object) entityManager, (object) ((IEnumerable<long>) id1).Distinct<long>().Cast<object>().ToArray<object>())).Cast<object>().ToList<object>();
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 14;
              continue;
            case 6:
              EntityPermissionService.myP9a37WxdZsak95u17((object) addPermissionModel1, (object) entityMetadata);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 1 : 1;
              continue;
            case 7:
              EntityPermissionService.EalfpZ7SHPuDl5gGIUh((object) addPermissionModel1, hasGrantPermission);
              num2 = 15;
              continue;
            case 8:
              grandPermissions = new Dictionary<long, IEnumerable<Permission>>();
              num2 = 9;
              continue;
            case 9:
              objects.ForEach((Action<object>) (o =>
              {
                int num4 = 6;
                ICollection<Permission> permissions;
                object o1;
                // ISSUE: variable of a compiler-generated type
                EntityPermissionService.\u003C\u003Ec__DisplayClass9_0 cDisplayClass90;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      grandPermissions.Add(((IEntity<long>) o1).Id, (IEnumerable<Permission>) permissions);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 1 : 2;
                      continue;
                    case 2:
                      goto label_2;
                    case 3:
                      o1 = o;
                      num4 = 4;
                      continue;
                    case 4:
                      IInstanceSettingsPermission settingsPermission = permissionService.GetSettingsPermission(o1);
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      dict.Add(o1, users.Where<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => !EntityPermissionService.\u003C\u003Ec__DisplayClass9_2.OfL9WKwCURkgj8mb0ByT((object) cDisplayClass90.\u003C\u003E4__this.securityService, (object) u, EntityPermissionService.\u003C\u003Ec__DisplayClass9_2.O2eGeSwCKf9XkAGGsZP6((object) cDisplayClass90.\u003C\u003E4__this.permissionManagmentService, cDisplayClass90.permission), o1, false))).ToList<EleWise.ELMA.Security.Models.IUser>());
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!EntityPermissionService.\u003C\u003Ec__DisplayClass9_0.jmKcGdwxIl9LXkgHHuPw((object) settingsPermission, EntityPermissionService.\u003C\u003Ec__DisplayClass9_0.iJvZ8vwxJvEtayuQOhWP(), o1))
                        hasGrantPermission = false;
                      permissions = settingsPermission.CanGrandLevel(AuthenticationService.GetCurrentUser(), o1);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
                      continue;
                    case 5:
                      cDisplayClass90 = this;
                      num4 = 3;
                      continue;
                    case 6:
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 4 : 5;
                      continue;
                    default:
                      if (!grandPermissions.ContainsKey(((IEntity<long>) o1).Id))
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_12;
                  }
                }
label_2:
                return;
label_12:;
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
              continue;
            case 10:
              goto label_11;
            case 11:
              goto label_10;
            case 12:
              dict = new Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>>();
              num2 = 10;
              continue;
            case 13:
              addPermissionModel1 = new AddPermissionModel();
              num2 = 20;
              continue;
            case 14:
              objects = objects.Where<object>((Func<object, bool>) (o =>
              {
                int num5 = 2;
                object o2;
                // ISSUE: variable of a compiler-generated type
                EntityPermissionService.\u003C\u003Ec__DisplayClass9_0 cDisplayClass90;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      cDisplayClass90 = this;
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
                      continue;
                    case 2:
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_4;
                    default:
                      o2 = o;
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 1 : 3;
                      continue;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return users.Any<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => !EntityPermissionService.\u003C\u003Ec__DisplayClass9_1.gQKyW3wxHySLIKfQSra6((object) cDisplayClass90.\u003C\u003E4__this.securityService, (object) u, EntityPermissionService.\u003C\u003Ec__DisplayClass9_1.XDUfaywx2m8YmPklbYmX((object) cDisplayClass90.\u003C\u003E4__this.permissionManagmentService, cDisplayClass90.permission), o2, false)));
              })).ToList<object>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 21 : 21;
              continue;
            case 15:
              addPermissionModel1.GrandPermissions = grandPermissions;
              num2 = 11;
              continue;
            case 16:
              AddPermissionModel addPermissionModel3 = addPermissionModel1;
              Guid[] guidArray2 = defaultPermissions;
              Guid[] guidArray3;
              if (guidArray2 == null)
                guidArray3 = new Guid[1]{ permission1 };
              else
                goto label_31;
label_29:
              addPermissionModel3.DefaultPermissions = guidArray3;
              num2 = 7;
              continue;
label_31:
              guidArray3 = guidArray2;
              goto label_29;
            case 17:
              entityManager = (IEntityManager) EntityPermissionService.gYx4pg7AAo3924TjitE(type);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 12 : 11;
              continue;
            case 18:
              id1 = id;
              num2 = 3;
              continue;
            case 19:
              num2 = 18;
              continue;
            case 20:
              addPermissionModel1.Dictionary = dict;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 6 : 6;
              continue;
            case 21:
              hasGrantPermission = true;
              num2 = 8;
              continue;
            case 22:
              permission1 = permission;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 9 : 17;
              continue;
            default:
              entityMetadata = (EntityMetadata) EntityPermissionService.Upk01j77Jrf6TWijvyY(type, true, true);
              num2 = 13;
              continue;
          }
        }
label_11:
        users = this.FormUsersList(usersIds, prefixedUsersIds, needReplacement);
        num1 = 2;
      }
label_10:
      return addPermissionModel1;
    }

    /// <inheritdoc />
    public bool EntityAddPermissionSave(long[] id, Type type, EditableListModel accessBindList)
    {
      int num1 = 9;
      EntityPermissionService permissionService;
      EditableListModel accessBindList1;
      Type type1;
      IEntityManager entityManager;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!EntityPermissionService.NIonZl7YV3BtbqWDnFw(type1, (Type) null))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 2:
            if (id == null)
            {
              num1 = 5;
              continue;
            }
            goto case 1;
          case 3:
            accessBindList1 = accessBindList;
            num1 = 4;
            continue;
          case 4:
            type1 = type;
            num1 = 2;
            continue;
          case 5:
          case 6:
            goto label_14;
          case 7:
            entityManager.FindByIdArray(((IEnumerable<long>) id).Distinct<long>().Cast<object>().ToArray<object>()).Cast<object>().ToList<object>().ForEach((Action<object>) (instance =>
            {
              int num4 = 4;
              object instance1;
              ICollection<IInstanceSettingsPermissionHolder> holders;
              // ISSUE: variable of a compiler-generated type
              EntityPermissionService.\u003C\u003Ec__DisplayClass10_0 cDisplayClass100;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    EntityPermissionService.\u003C\u003Ec__DisplayClass10_0.fNmgS1wC6bks6Ro0DVhu((object) entityManager, instance1);
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 2 : 2;
                    continue;
                  case 2:
                    goto label_2;
                  case 3:
                    cDisplayClass100 = this;
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 6 : 6;
                    continue;
                  case 4:
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 2 : 3;
                    continue;
                  case 5:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: object of a compiler-generated type is created
                    accessBindList1.Items.Where<EditableListItem>((Func<EditableListItem, bool>) (i =>
                    {
                      int num5 = 1;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            if (EntityPermissionService.\u003C\u003Ec__DisplayClass10_1.YOdP4lwCCqWgBTRLTQH6((object) i) != null)
                            {
                              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_5;
                          default:
                            goto label_4;
                        }
                      }
label_4:
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated field
                      return cDisplayClass100.\u003C\u003E4__this.GetEntity(i, cDisplayClass100.type) == instance1;
label_5:
                      return false;
                    })).Select(i => new \u003C\u003Ef__AnonymousType0<Tuple<IEntity, PermissionRoleType>, EditableListItem>(cDisplayClass100.\u003C\u003E4__this.GetAssignedEntity(i, instance1), i)).SelectMany(v => (string.IsNullOrWhiteSpace(v.i.Data) ? (IEnumerable<Guid>) new Guid[0] : (IEnumerable<Guid>) v.i.Data.FromJson<Guid[]>()).Select<Guid, InstanceSettingsPermissionHolder>((Func<Guid, InstanceSettingsPermissionHolder>) (pid =>
                    {
                      InstanceSettingsPermissionHolder permissionHolder = new InstanceSettingsPermissionHolder();
                      // ISSUE: reference to a compiler-generated method
                      EntityPermissionService.\u003C\u003Ec__DisplayClass10_2.ub1P4mwCNnSAP6XSDPWr((object) permissionHolder, (object) v.a.Item1);
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      EntityPermissionService.\u003C\u003Ec__DisplayClass10_2.uuk17ZwCZKqfGuwcPyOg((object) permissionHolder, EntityPermissionService.\u003C\u003Ec__DisplayClass10_2.b9B24nwC0Py7Y9J4IumV((object) v.a.Item2));
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      EntityPermissionService.\u003C\u003Ec__DisplayClass10_2.oHTL3YwCs7XS4Q8gLUCW((object) permissionHolder, EntityPermissionService.\u003C\u003Ec__DisplayClass10_2.BH8B7rwCAP24BTdMtvkU((object) cDisplayClass100.\u003C\u003E4__this.permissionManagmentService.GetPermission(pid)));
                      // ISSUE: reference to a compiler-generated method
                      EntityPermissionService.\u003C\u003Ec__DisplayClass10_2.jM0ZHmwC7poTNIMrBRsT((object) permissionHolder, instance1);
                      return permissionHolder;
                    }))).ToList<InstanceSettingsPermissionHolder>().ForEach((Action<InstanceSettingsPermissionHolder>) (h =>
                    {
                      int num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            holders.Add((IInstanceSettingsPermissionHolder) h);
                            num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 1 : 0;
                    continue;
                  case 6:
                    instance1 = instance;
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
                    continue;
                  default:
                    holders = permissionService.GetSettingsPermission(instance1).GetPermissionCollection(instance1);
                    num4 = 5;
                    continue;
                }
              }
label_2:;
            }));
            num1 = 10;
            continue;
          case 8:
            permissionService = this;
            num1 = 3;
            continue;
          case 9:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 8 : 8;
            continue;
          case 10:
            goto label_2;
          default:
            if (accessBindList1 == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 4 : 6;
              continue;
            }
            entityManager = (IEntityManager) EntityPermissionService.gYx4pg7AAo3924TjitE(type1);
            num1 = 7;
            continue;
        }
      }
label_2:
      return true;
label_14:
      return true;
    }

    private List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> GetRoleTypeModels(
      Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>> objects,
      Type type,
      Guid[] defaultPermissionUids)
    {
      IEnumerable<Tuple<Permission, PermissionRoleType[]>> permissionRolesStereotype = this.permissionTypeRoleService.GetPermissionRoles(type);
      List<Permission> defaultPermissions = ((IEnumerable<Guid>) defaultPermissionUids).Select<Guid, Permission>((Func<Guid, Permission>) (defaultPermissionUid =>
      {
        int num = 1;
        Guid defaultPermissionUid1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              defaultPermissionUid1 = defaultPermissionUid;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 0 : 2;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return permissionRolesStereotype.Select<Tuple<Permission, PermissionRoleType[]>, Permission>((Func<Tuple<Permission, PermissionRoleType[]>, Permission>) (t => t.Item1)).FirstOrDefault<Permission>((Func<Permission, bool>) (p => EntityPermissionService.\u003C\u003Ec__DisplayClass11_1.CAlamSwCfdqSljTI73TF((object) p) == defaultPermissionUid1));
      })).ToList<Permission>();
      List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> items = new List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>();
      objects.ToList<KeyValuePair<object, List<EleWise.ELMA.Security.Models.IUser>>>().ForEach((Action<KeyValuePair<object, List<EleWise.ELMA.Security.Models.IUser>>>) (d => items.AddRange((IEnumerable<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>) permissionRolesStereotype.Select<Tuple<Permission, PermissionRoleType[]>, Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>((Func<Tuple<Permission, PermissionRoleType[]>, Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>) (t =>
      {
        Permission permission = t.Item1;
        List<EleWise.ELMA.Security.Models.IUser> source = d.Value;
        List<AssignedRoleTypeModel> assignedRoleTypeModelList = defaultPermissions.Any<Permission>((Func<Permission, bool>) (p => p == permission)) || defaultPermissions != null && defaultPermissions.Any<Permission>((Func<Permission, bool>) (defaultPermission =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (EntityPermissionService.\u003C\u003Ec__DisplayClass11_3.jFHqjpwCGwscF0qTTu2H((object) defaultPermission) == null)
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 0 : 0;
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
          return ((IEnumerable<Permission>) EntityPermissionService.\u003C\u003Ec__DisplayClass11_3.jFHqjpwCGwscF0qTTu2H((object) defaultPermission)).Contains<Permission>(permission);
label_3:
          return false;
        })) ? source.Select<EleWise.ELMA.Security.Models.IUser, AssignedRoleTypeModel>((Func<EleWise.ELMA.Security.Models.IUser, AssignedRoleTypeModel>) (u => new AssignedRoleTypeModel(CommonRoleTypes.User, (IEntity) u))).ToList<AssignedRoleTypeModel>() : new List<AssignedRoleTypeModel>();
        return new Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>(permission, d.Key, (IEnumerable<AssignedRoleTypeModel>) assignedRoleTypeModelList);
      })).ToList<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>())));
      return items;
    }

    private IInstanceSettingsPermission GetSettingsPermission(
      object instance)
    {
      int num = 1;
      IInstanceSettingsPermission settingsPermission;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 0 : 0;
            continue;
          case 2:
            if (settingsPermission != null)
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 3:
            goto label_6;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            settingsPermission = this.instanceSettingsPermissions.FirstOrDefault<IInstanceSettingsPermission>((Func<IInstanceSettingsPermission, bool>) (p => EntityPermissionService.\u003C\u003Ec__DisplayClass12_0.L5DyLtwCBtQitKFuLSET(type, EntityPermissionService.\u003C\u003Ec__DisplayClass12_0.wCB82fwChZY4hhp638gX((object) p))));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 1 : 2;
            continue;
          case 5:
            goto label_5;
          default:
            type = EntityHelper.GetType(instance);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 4 : 4;
            continue;
        }
      }
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) EntityPermissionService.DKUCfW7yoPGBx4iFS5Q(784628100 ^ 784622362), EntityPermissionService.zL1qVr7VZLUO4KRIr0N((object) type)));
label_6:
      return settingsPermission;
    }

    private List<EleWise.ELMA.Security.Models.IUser> FormUsersList(
      long[] usersIds,
      string[] prefixedUsersIds,
      bool needReplacement = false)
    {
      List<EleWise.ELMA.Security.Models.IUser> users = new List<EleWise.ELMA.Security.Models.IUser>();
      if (usersIds != null)
        users.AddRange((IEnumerable<EleWise.ELMA.Security.Models.IUser>) this.userManager.FindByIdArray(usersIds));
      if (prefixedUsersIds != null)
        this.FillUsersByPrefixed(users, prefixedUsersIds);
      if (needReplacement)
      {
        List<EleWise.ELMA.Security.Models.IUser> collection = new List<EleWise.ELMA.Security.Models.IUser>();
        foreach (EleWise.ELMA.Security.Models.IUser user in users)
        {
          if (user.ReplacementUser != null)
            collection.AddIfNotContains<EleWise.ELMA.Security.Models.IUser>(user.ReplacementUser);
        }
      }
      return users;
    }

    private void FillUsersByPrefixed(List<EleWise.ELMA.Security.Models.IUser> users, string[] prefixedUserIds)
    {
      foreach (string prefixedUserId in prefixedUserIds)
      {
        foreach (EleWise.ELMA.Security.Models.IUser user in BaseEntityUserTypeSelector.GetUsers(prefixedUserId))
        {
          EleWise.ELMA.Security.Models.IUser prefixedUser = user;
          if (users.All<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => !u.Equals((object) prefixedUser))) && prefixedUser.Status == UserStatus.Active)
            users.Add(prefixedUser);
        }
      }
    }

    private object GetEntity(EditableListItem i, Type type)
    {
      int num = 1;
      IEntityManager entityManager;
      long entityId;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityManager = (IEntityManager) EntityPermissionService.gYx4pg7AAo3924TjitE(type);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 0 : 0;
            continue;
          case 2:
            if (entityId <= 0L)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 1 : 3;
              continue;
            }
            goto label_3;
          case 3:
            goto label_2;
          default:
            entityId = ((string) EntityPermissionService.FyhVcL7l1j0hlN2dmDe((object) i)).FromJson<IdAndTypeRole>().EntityId;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return (object) null;
label_3:
      return EntityPermissionService.pGDX827fT70DrpkfQLV((object) entityManager, (object) entityId);
    }

    private Tuple<IEntity, PermissionRoleType> GetAssignedEntity(
      EditableListItem i,
      object instance)
    {
      IdAndTypeRole idObjectType = i.Value.FromJson<IdAndTypeRole>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      PermissionRoleType permissionRoleType = this.roleTypeSelectorGroupsCategories.Any<IRoleTypeSelectorGroupsCategory>((Func<IRoleTypeSelectorGroupsCategory, bool>) (r => EntityPermissionService.\u003C\u003Ec__DisplayClass16_0.CxGOVLwCeTRX9pVhylME(EntityPermissionService.\u003C\u003Ec__DisplayClass16_0.llJNZewCJLcB8KZHbPBr((object) r), EntityPermissionService.\u003C\u003Ec__DisplayClass16_0.GnxHEhwCI3CihUiKdxue((object) idObjectType)))) ? CommonRoleTypes.Group : this.permissionTypeRoleService.Load(idObjectType.ObjectType);
      IEntity entity = (IEntity) null;
      if (permissionRoleType == CommonRoleTypes.Property)
      {
        Guid pUid;
        if (Guid.TryParse(idObjectType.Id, out pUid))
        {
          // ISSUE: reference to a compiler-generated method
          PropertyMetadata propertyMetadata = !(permissionRoleType.AssignedEntityEvalutor(instance) is EntityMetadata metadata) ? (PropertyMetadata) null : metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EntityPermissionService.\u003C\u003Ec__DisplayClass16_1.W1QmHpwCzLRVNP13atyP((object) p) == pUid));
          entity = (IEntity) new PropertyMetadataReference((IEntityMetadata) metadata, (IPropertyMetadata) propertyMetadata);
        }
      }
      else if (permissionRoleType.AssignedEntityEvalutor != null)
        entity = permissionRoleType.AssignedEntityEvalutor(instance);
      else if (!string.IsNullOrEmpty(idObjectType.Id))
      {
        Type linkedEntityType = permissionRoleType.LinkedEntityType;
        if (linkedEntityType == (Type) null)
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691364682), (object) permissionRoleType.Name, (object) idObjectType.Id));
        entity = (IEntity) EntityHelper.GetEntityManager(linkedEntityType).Load((object) idObjectType.Id);
      }
      return new Tuple<IEntity, PermissionRoleType>(entity, permissionRoleType);
    }

    internal static object gYx4pg7AAo3924TjitE([In] Type obj0) => (object) EntityHelper.GetEntityManager(obj0);

    internal static void crH6517sJkHVvJyDwCL([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((Action) obj1);

    internal static bool B6upav700XodwMrfLMU() => EntityPermissionService.MTvppH7NLZDLerXbwIt == null;

    internal static EntityPermissionService HHEIr77ZjwUHeWKBaYi() => EntityPermissionService.MTvppH7NLZDLerXbwIt;

    internal static object Upk01j77Jrf6TWijvyY([In] Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static void myP9a37WxdZsak95u17([In] object obj0, [In] object obj1) => ((AddPermissionModel) obj0).EntityMetadata = (EntityMetadata) obj1;

    internal static void fMkfZU7r4nxAVvPWHyb([In] object obj0, Type value) => ((AddPermissionModel) obj0).EntityType = value;

    internal static void EalfpZ7SHPuDl5gGIUh([In] object obj0, bool value) => ((AddPermissionModel) obj0).HasGrantPermission = value;

    internal static bool NIonZl7YV3BtbqWDnFw([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object DKUCfW7yoPGBx4iFS5Q(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zL1qVr7VZLUO4KRIr0N([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object FyhVcL7l1j0hlN2dmDe([In] object obj0) => (object) ((ListItem) obj0).Value;

    internal static object pGDX827fT70DrpkfQLV([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).Load(obj1);
  }
}
