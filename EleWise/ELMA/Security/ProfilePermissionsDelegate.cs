// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ProfilePermissionsDelegate
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Делегат проверки привилегий через профайлер типа</summary>
  [Component]
  internal class ProfilePermissionsDelegate : IPermissionsDelegate
  {
    private readonly IEnumerable<IProfileResolver> profileResolvers;
    private readonly IEnumerable<IProfilePermission> profilePermissions;
    private readonly ISecurityService securityService;
    private Func<Type, Type> resolveProfileType;
    private Func<Permission, Type, Permission> resolvePermission;
    internal static ProfilePermissionsDelegate IAPEovD0uA2p2o5aAeK;

    /// <summary>Ctor</summary>
    /// <param name="profileResolvers">Список точек расширения для получения профайлеров типа</param>
    /// <param name="profilePermissions">Список точек расширения для указания соответсвия прав доступа типа к правам доступа профайлера типа</param>
    /// <param name="securityService">Сервис проверки привилегий пользователя</param>
    /// <param name="permissionManagmentService">Сервис для работы с привилегиями</param>
    public ProfilePermissionsDelegate(
      IEnumerable<IProfileResolver> profileResolvers,
      IEnumerable<IProfilePermission> profilePermissions,
      ISecurityService securityService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.profileResolvers = profileResolvers;
      this.profilePermissions = profilePermissions;
      this.securityService = securityService;
      this.resolveProfileType = MetadataLoader.UseCachingForFunc<Type, Type>((Expression<Func<Type, Type>>) (type => this.GetTypeByResolver(type)));
      this.resolvePermission = MetadataLoader.UseCachingForFunc<Permission, Type, Permission>((Expression<Func<Permission, Type, Permission>>) ((permission, type) => this.GetPermissionByProfile(permission, type)));
    }

    /// <summary>Получить тип профайлера типа</summary>
    /// <param name="type">Тип сущности</param>
    /// <returns>Тип профайлера</returns>
    [ContextCache]
    protected virtual Type ResolveProfileType(Type type) => this.resolveProfileType(type);

    /// <summary>Получить профайлер типа</summary>
    /// <param name="type">Тип сущности</param>
    /// <returns>Профайлер</returns>
    [ContextCache]
    protected virtual object ResolveProfile(Type type)
    {
      int num = 2;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            type1 = type;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return this.profileResolvers.Select<IProfileResolver, object>((Func<IProfileResolver, object>) (r => ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass7_0.q5FZVawkfBFirwb3m6Ow((object) r, type1))).FirstOrDefault<object>((Func<object, bool>) (t => t != null));
    }

    /// <summary>Получить привилегию из типа профайлера</summary>
    /// <param name="permission">Привилегия</param>
    /// <param name="profileType">Тип профайлера</param>
    /// <returns>Привилегия</returns>
    [ContextCache]
    protected virtual Permission ResolveTypeProfilePermission(
      Permission permission,
      Type profileType)
    {
      return this.resolvePermission(permission, profileType);
    }

    /// <inheritdoc />
    public bool CanCheckPermissions(Type type, Permission permission)
    {
      int num = 1;
      Type profileType;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ProfilePermissionsDelegate.buHRqADs5It7IDaa34f(type, (Type) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (!ProfilePermissionsDelegate.ltx9klD7A0o7YgPQNtV((object) permission, (object) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 5 : 0;
              continue;
            }
            goto case 4;
          case 4:
            if (!ProfilePermissionsDelegate.buHRqADs5It7IDaa34f(profileType = this.ResolveProfileType(type), (Type) null))
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 6:
            goto label_8;
          default:
            goto label_9;
        }
      }
label_8:
      return ProfilePermissionsDelegate.ltx9klD7A0o7YgPQNtV((object) this.ResolveTypeProfilePermission(permission, profileType), (object) null);
label_9:
      return false;
    }

    /// <inheritdoc />
    public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
    {
      int num = 6;
      object obj;
      while (true)
      {
        Type type;
        EntityMetadata entityMetadata;
        switch (num)
        {
          case 1:
            if (!type.IsInheritOrSame<IEntity>())
            {
              num = 17;
              continue;
            }
            goto case 4;
          case 2:
            if (!(type != (Type) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 18 : 5;
              continue;
            }
            goto case 1;
          case 3:
            goto label_4;
          case 4:
            if (ProfilePermissionsDelegate.FscydbDrJIsZ0pTBCho((object) permission) == PermissionType.Instance)
            {
              num = 21;
              continue;
            }
            break;
          case 5:
          case 16:
            goto label_10;
          case 6:
            if (target == null)
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 7:
            if (permission == (Permission) null)
            {
              num = 16;
              continue;
            }
            type = target as Type;
            num = 15;
            continue;
          case 8:
            type = ProfilePermissionsDelegate.STo2plDWd1mXqmX92x3(target);
            num = 2;
            continue;
          case 10:
            if (!ProfilePermissionsDelegate.b8vxtkDYIU0VD9QpYxj((object) entityMetadata))
            {
              num = 9;
              continue;
            }
            goto label_8;
          case 11:
            if (ProfilePermissionsDelegate.eRen8LDlhhEJeGWfyOs((object) permission, (object) null))
            {
              num = 14;
              continue;
            }
            goto label_17;
          case 12:
            if (entityMetadata == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
              continue;
            }
            goto case 10;
          case 13:
            goto label_8;
          case 14:
            goto label_16;
          case 15:
            if (!(type == (Type) null))
            {
              num = 19;
              continue;
            }
            goto case 8;
          case 20:
            if (obj != null)
            {
              permission = (Permission) ProfilePermissionsDelegate.r9J9KQDVQIxqDvnc32B((object) this, (object) permission, ProfilePermissionsDelegate.STo2plDWd1mXqmX92x3(obj));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 11 : 7;
              continue;
            }
            num = 3;
            continue;
          case 21:
            entityMetadata = ProfilePermissionsDelegate.ys80DlDSoy5yCXrn1XY(type, true, true) as EntityMetadata;
            num = 12;
            continue;
        }
        obj = ProfilePermissionsDelegate.NBYKXdDyuthtKdB02Ox((object) this, type);
        num = 20;
      }
label_4:
      return false;
label_8:
      return false;
label_10:
      return false;
label_16:
      return false;
label_17:
      return ProfilePermissionsDelegate.muDXByDfoJltP6YrhXw((object) this.securityService, (object) user, (object) permission, obj, false);
    }

    private bool PermissionsEquals(Permission permission1, Permission permission2)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ProfilePermissionsDelegate.eRen8LDlhhEJeGWfyOs((object) permission1, (object) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_4;
          case 3:
            if (!ProfilePermissionsDelegate.eRen8LDlhhEJeGWfyOs((object) permission2, (object) null))
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 4:
            if (!ProfilePermissionsDelegate.eCfTQuDcnFuQ3PcBhd3(ProfilePermissionsDelegate.W2edAaD43oZg74wfQtt((object) permission1), ProfilePermissionsDelegate.W2edAaD43oZg74wfQtt((object) permission2)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          default:
            goto label_8;
        }
      }
label_4:
      return this.PermissionsEquals(permission1, permission2.Base);
label_5:
      return true;
label_8:
      return false;
    }

    private Type GetTypeByResolver(Type type)
    {
      int num = 2;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            type1 = type;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      IEnumerable<Type> source = this.profileResolvers.Select<IProfileResolver, Type>((Func<IProfileResolver, Type>) (r => ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass12_0.M0IHVbwkXL3q6rvry9vA((object) r, type1)));
      // ISSUE: reference to a compiler-generated field
      Func<Type, bool> func = ProfilePermissionsDelegate.\u003C\u003Ec.\u003C\u003E9__12_1;
      Func<Type, bool> predicate;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        ProfilePermissionsDelegate.\u003C\u003Ec.\u003C\u003E9__12_1 = predicate = (Func<Type, bool>) (t => ProfilePermissionsDelegate.\u003C\u003Ec.AjaVPtwk8Xguy0RqGkGf(t, (Type) null));
      }
      else
        goto label_5;
label_7:
      return source.FirstOrDefault<Type>(predicate);
label_5:
      predicate = func;
      goto label_7;
    }

    private Permission GetPermissionByProfile(Permission permission, Type profileType)
    {
      int num1 = 3;
      ProfilePermissionsDelegate permissionsDelegate;
      Permission permission1;
      Type profileType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            profileType1 = profileType;
            num1 = 4;
            continue;
          case 2:
            permissionsDelegate = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_6;
          default:
            permission1 = permission;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 1 : 1;
            continue;
        }
      }
label_6:
      IEnumerable<IProfilePermission> profilePermissions = this.profilePermissions;
      // ISSUE: reference to a compiler-generated field
      Func<IProfilePermission, IEnumerable<ProfilePermissionDescriptor>> func = ProfilePermissionsDelegate.\u003C\u003Ec.\u003C\u003E9__13_0;
      Func<IProfilePermission, IEnumerable<ProfilePermissionDescriptor>> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ProfilePermissionsDelegate.\u003C\u003Ec.\u003C\u003E9__13_0 = selector = (Func<IProfilePermission, IEnumerable<ProfilePermissionDescriptor>>) (p => p.ProfilePermissionDescriptors);
      }
      else
        goto label_9;
label_8:
      return profilePermissions.SelectMany<IProfilePermission, ProfilePermissionDescriptor>(selector).Where<ProfilePermissionDescriptor>((Func<ProfilePermissionDescriptor, bool>) (d =>
      {
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.wtqWVxwkvy45JXKhi686(ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.uCV0NhwkF2eLWAyNdASu((object) d), (Type) null))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.c2fXuewkTto1H96TfPTb(profileType1, ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.JbAsekwkOLA0DnMEbudE(ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.DnRMfmwkp6lQBaxE5AEO((object) d))))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (permissionsDelegate.PermissionsEquals((Permission) ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.i69SQIwkBrYK1A2MSWBM((object) d), permission1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 2 : 0;
                continue;
              }
              goto label_5;
            case 4:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.c2fXuewkTto1H96TfPTb(ProfilePermissionsDelegate.\u003C\u003Ec__DisplayClass13_0.uCV0NhwkF2eLWAyNdASu((object) d), profileType1);
label_3:
        return false;
label_4:
        return true;
label_5:
        return false;
      })).Select<ProfilePermissionDescriptor, Permission>((Func<ProfilePermissionDescriptor, Permission>) (d => d.ProfilePermission)).FirstOrDefault<Permission>();
label_9:
      selector = func;
      goto label_8;
    }

    internal static bool TZJjFRDZw4mXexgNEfu() => ProfilePermissionsDelegate.IAPEovD0uA2p2o5aAeK == null;

    internal static ProfilePermissionsDelegate nDM9FYDARUEJSVcoBIn() => ProfilePermissionsDelegate.IAPEovD0uA2p2o5aAeK;

    internal static bool buHRqADs5It7IDaa34f([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool ltx9klD7A0o7YgPQNtV([In] object obj0, [In] object obj1) => (Permission) obj0 != (Permission) obj1;

    internal static Type STo2plDWd1mXqmX92x3([In] object obj0) => EntityHelper.GetType(obj0);

    internal static PermissionType FscydbDrJIsZ0pTBCho([In] object obj0) => ((Permission) obj0).PermissionType;

    internal static object ys80DlDSoy5yCXrn1XY([In] Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static bool b8vxtkDYIU0VD9QpYxj([In] object obj0) => ((EntityMetadata) obj0).CanUsePermissions();

    internal static object NBYKXdDyuthtKdB02Ox([In] object obj0, Type type) => ((ProfilePermissionsDelegate) obj0).ResolveProfile(type);

    internal static object r9J9KQDVQIxqDvnc32B([In] object obj0, [In] object obj1, Type profileType) => (object) ((ProfilePermissionsDelegate) obj0).ResolveTypeProfilePermission((Permission) obj1, profileType);

    internal static bool eRen8LDlhhEJeGWfyOs([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static bool muDXByDfoJltP6YrhXw(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] bool obj4)
    {
      return ((ISecurityService) obj0).HasPermission((IUser) obj1, (Permission) obj2, obj3, obj4);
    }

    internal static Guid W2edAaD43oZg74wfQtt([In] object obj0) => ((Permission) obj0).Id;

    internal static bool eCfTQuDcnFuQ3PcBhd3([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
