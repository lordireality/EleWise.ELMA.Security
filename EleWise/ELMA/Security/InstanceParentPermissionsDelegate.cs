// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceParentPermissionsDelegate
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Component]
  internal class InstanceParentPermissionsDelegate : IPermissionsDelegate
  {
    private readonly IMemoryCacheService memoryCacheService;
    private readonly Dictionary<Type, Permission[]> permissonsCache;
    internal static InstanceParentPermissionsDelegate OYYWeHbpl5Nhgaeywpm;

    public ISecurityService SecurityService
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 0;
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

    public InstanceParentPermissionsDelegate(
      IMemoryCacheService memoryCacheService,
      IEnumerable<IPermissionProvider> permissionProviders)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.memoryCacheService = memoryCacheService;
      this.permissonsCache = permissionProviders.SelectMany<IPermissionProvider, Permission>((Func<IPermissionProvider, IEnumerable<Permission>>) (p => p.GetPermissions())).Where<Permission>((Func<Permission, bool>) (p => p.ParentResolve != null)).GroupBy<Permission, Type>((Func<Permission, Type>) (p => p.EntityType)).ToDictionary<IGrouping<Type, Permission>, Type, Permission[]>((Func<IGrouping<Type, Permission>, Type>) (g => g.Key), (Func<IGrouping<Type, Permission>, Permission[]>) (g => g.ToArray<Permission>()));
    }

    [ContextCache]
    protected virtual Permission GetPermissions(Type type, Guid permissionId)
    {
      int num1 = 1;
      Type type1;
      InstanceParentPermissionsDelegate permissionsDelegate;
      Guid permissionId1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            permissionsDelegate = this;
            num1 = 4;
            continue;
          case 4:
            permissionId1 = permissionId;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 1 : 2;
            continue;
          default:
            type1 = type;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 3 : 3;
            continue;
        }
      }
label_5:
      Func<Permission, bool> func;
      return this.memoryCacheService.GetOrAdd<Permission>((string) InstanceParentPermissionsDelegate.QuTdCpbvdsYCa1J8QYK(InstanceParentPermissionsDelegate.BSMKD0bFFDyUqr17TOw(1677147940 ^ 1677142360), (object) type1.FullName), (Func<Permission>) (() =>
      {
        int num2 = 1;
        Permission[] permissionArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              type1 = InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass7_0.Sv9QrowRpcAidJWgHV2v(type1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
              continue;
            case 3:
            case 6:
              if (!permissionsDelegate.permissonsCache.TryGetValue(type1, out permissionArray))
              {
                num2 = 7;
                continue;
              }
              goto label_8;
            case 4:
              goto label_2;
            case 5:
              goto label_8;
            case 7:
              type1 = type1.BaseType;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 1 : 2;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              if (InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass7_0.y18aIOwRO5wrjwy8SYRD(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 6 : 6;
                continue;
              }
              goto label_2;
          }
        }
label_2:
        return (Permission) null;
label_8:
        Permission[] source = permissionArray;
        Func<Permission, bool> func1 = func;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        Func<Permission, bool> predicate = func1 == null ? (func = (Func<Permission, bool>) (p => InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass7_0.sjDssCwRFEHRtIeGU5pG(InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass7_0.DEfOaIwRT741yPHFTPLe((object) p), permissionId1))) : func1;
        return ((IEnumerable<Permission>) source).FirstOrDefault<Permission>(predicate);
      }));
    }

    [ContextCache]
    public virtual bool CanCheckPermissions(Type type, Permission permission)
    {
      int num = 8;
      InstanceParentPermissionsDelegate permissionsDelegate;
      Type type1;
      Permission permission1;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 6:
            goto label_5;
          case 2:
            type1 = type;
            num = 3;
            continue;
          case 3:
            permission1 = permission;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 0 : 0;
            continue;
          case 4:
            if (!InstanceParentPermissionsDelegate.LQaDbTbqTkg7INWbBvx((object) permission1, (object) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 5:
            goto label_4;
          case 7:
            permissionsDelegate = this;
            num = 2;
            continue;
          case 8:
            num = 7;
            continue;
          default:
            if (!(type1 != (Type) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 6 : 6;
              continue;
            }
            goto case 4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.memoryCacheService.GetOrAdd<bool>((string) InstanceParentPermissionsDelegate.jalYFYbJ1GIuSy7Wb3o((object) new object[4]
      {
        (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678184962),
        (object) InstanceParentPermissionsDelegate.DlE8SZbgPcxKCTcafxx((object) permission1),
        InstanceParentPermissionsDelegate.BSMKD0bFFDyUqr17TOw(-1702973981 - 773209001 ^ 1818780748),
        (object) type1.FullName
      }), (Func<bool>) (() => InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass8_0.KCWN6MwRnPbeZwWAiJFv(InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass8_0.zeNdGNwReeteklKNyVWp((object) permissionsDelegate, type1, InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass8_0.chECaqwRIqZb0YHIeXmB((object) permission1)), (object) null)));
label_5:
      return false;
    }

    public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
    {
      int num = 3;
      object source;
      InstanceParentPermissionsDelegate permissionsDelegate;
      IUser user1;
      Permission checkPermission;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((source = checkPermission.ParentResolve(target)) != null)
            {
              num = 9;
              continue;
            }
            goto label_13;
          case 2:
            permissionsDelegate = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 10 : 4;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            Type type = target as Type;
            if ((object) type == null)
              type = InstanceParentPermissionsDelegate.dvyj4ZbIrFsIO4kDNLi(target);
            checkPermission = (Permission) InstanceParentPermissionsDelegate.xOcY0Xbe2MuqJ7BgdAt((object) this, type, InstanceParentPermissionsDelegate.DlE8SZbgPcxKCTcafxx((object) permission));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 8 : 8;
            continue;
          case 5:
            if ((Permission) InstanceParentPermissionsDelegate.qiskjVbnovIadkHLfVM((object) checkPermission) != (Permission) null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 1 : 1;
              continue;
            }
            goto label_13;
          case 6:
            if (InstanceParentPermissionsDelegate.A5kDwVb2pRaorPUO60U((object) checkPermission))
            {
              num = 7;
              continue;
            }
            goto label_11;
          case 7:
            goto label_12;
          case 8:
            if (InstanceParentPermissionsDelegate.LQaDbTbqTkg7INWbBvx((object) checkPermission, (object) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 5 : 5;
              continue;
            }
            goto label_13;
          case 9:
            if (source is IEnumerable)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 6 : 0;
              continue;
            }
            goto label_2;
          case 10:
            user1 = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 3 : 4;
            continue;
          case 11:
            goto label_11;
          default:
            goto label_2;
        }
      }
label_2:
      return InstanceParentPermissionsDelegate.KV2NNNbL8EjwGIrG84P((object) this.SecurityService, (object) user1, InstanceParentPermissionsDelegate.qiskjVbnovIadkHLfVM((object) checkPermission), source, false);
label_11:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable) source).Cast<object>().Any<object>((Func<object, bool>) (p => InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass9_0.EXYDPxwouhajptq53kab((object) permissionsDelegate.SecurityService, (object) user1, InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass9_0.JgwCg4wRza1WyXLKHEhu((object) checkPermission), p, false)));
label_12:
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable) source).Cast<object>().All<object>((Func<object, bool>) (p => permissionsDelegate.SecurityService.HasPermission(user1, (Permission) InstanceParentPermissionsDelegate.\u003C\u003Ec__DisplayClass9_0.JgwCg4wRza1WyXLKHEhu((object) checkPermission), p)));
label_13:
      return false;
    }

    internal static bool iqKGsgbO6hUyiTinKpA() => InstanceParentPermissionsDelegate.OYYWeHbpl5Nhgaeywpm == null;

    internal static InstanceParentPermissionsDelegate oc93NSbTlQXcDcYgWMD() => InstanceParentPermissionsDelegate.OYYWeHbpl5Nhgaeywpm;

    internal static object BSMKD0bFFDyUqr17TOw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object QuTdCpbvdsYCa1J8QYK([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool LQaDbTbqTkg7INWbBvx([In] object obj0, [In] object obj1) => (Permission) obj0 != (Permission) obj1;

    internal static Guid DlE8SZbgPcxKCTcafxx([In] object obj0) => ((Permission) obj0).Id;

    internal static object jalYFYbJ1GIuSy7Wb3o([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static Type dvyj4ZbIrFsIO4kDNLi([In] object obj0) => EntityHelper.GetType(obj0);

    internal static object xOcY0Xbe2MuqJ7BgdAt([In] object obj0, Type type, Guid permissionId) => (object) ((InstanceParentPermissionsDelegate) obj0).GetPermissions(type, permissionId);

    internal static object qiskjVbnovIadkHLfVM([In] object obj0) => (object) ((Permission) obj0).ParentPermission;

    internal static bool KV2NNNbL8EjwGIrG84P(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] bool obj4)
    {
      return ((ISecurityService) obj0).HasPermission((IUser) obj1, (Permission) obj2, obj3, obj4);
    }

    internal static bool A5kDwVb2pRaorPUO60U([In] object obj0) => ((Permission) obj0).ParentAllTargets;
  }
}
