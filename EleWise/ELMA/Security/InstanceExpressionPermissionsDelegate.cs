// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceExpressionPermissionsDelegate
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Делегат InstanceExpressionPermissions</summary>
  [Component(Order = 100)]
  public class InstanceExpressionPermissionsDelegate : IPermissionsDelegate
  {
    private readonly IMemoryCacheService memoryCacheService;
    private readonly IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions;
    internal static InstanceExpressionPermissionsDelegate U0011GU8UTcLkQ9FsLE;

    /// <summary>Делегат InstanceExpressionPermissions</summary>
    /// <param name="memoryCacheService">Сервис для кэширования в памяти</param>
    /// <param name="instanceExpressionPermissions">Интерфейсы определения способа доступа к сущности на основе выражений, содержащих значения свойств экземпляра</param>
    /// <exception cref="T:System.ArgumentNullException"></exception>
    public InstanceExpressionPermissionsDelegate(
      IMemoryCacheService memoryCacheService,
      IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (memoryCacheService == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1530848604 ^ 1530840096));
      if (instanceExpressionPermissions == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(911364681 ^ 911373293));
      this.memoryCacheService = memoryCacheService;
      this.instanceExpressionPermissions = instanceExpressionPermissions;
    }

    [ContextCache]
    protected virtual bool HasInstanceExpressionPermission(Type type)
    {
      int num = 2;
      InstanceExpressionPermissionsDelegate permissionsDelegate;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            permissionsDelegate = this;
            num = 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 1;
            continue;
          case 3:
            type1 = type;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.memoryCacheService.GetOrAdd<bool>((string) InstanceExpressionPermissionsDelegate.Nli0CyUGdKreYuIcLnl(InstanceExpressionPermissionsDelegate.ibdvPxUE3RDIoca7LF2(-1324692970 << 3 ^ -2007600814), (object) type1.FullName), (Func<bool>) (() => permissionsDelegate.instanceExpressionPermissions.Any<IInstanceExpressionPermission>((Func<IInstanceExpressionPermission, bool>) (i => InstanceExpressionPermissionsDelegate.\u003C\u003Ec__DisplayClass3_0.KK3j4IwtklGMTH7EiPMV(type1, InstanceExpressionPermissionsDelegate.\u003C\u003Ec__DisplayClass3_0.OI52Qywt6vvctTfEL7VM((object) i))))));
    }

    public bool CanCheckPermissions(Type type, Permission permission)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            if ((Permission) InstanceExpressionPermissionsDelegate.jKDNhaU1Fa3HgWkRu4x((object) permission) == CommonPermissions.View)
            {
              num = 7;
              continue;
            }
            goto label_5;
          case 2:
          case 7:
            if (!InstanceExpressionPermissionsDelegate.jwUDxRUMTCLQEUSLYTr(type, (Type) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            if (InstanceExpressionPermissionsDelegate.RpYfo7U9mchbLRoJClL((object) permission, (object) CommonPermissions.View))
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 5:
            if (!InstanceExpressionPermissionsDelegate.I5xVl2UXVcHSo7lBkpF((object) permission, (object) null))
            {
              num = 4;
              continue;
            }
            goto case 8;
          case 6:
            goto label_4;
          case 8:
            if (permission.PermissionType == PermissionType.Instance)
            {
              num = 3;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_4:
      return InstanceExpressionPermissionsDelegate.Lddg9EUhpkSYgXLl2sd((object) this, type);
label_5:
      return false;
    }

    public virtual bool HasPermission(
      [NotNull] IUser user,
      [NotNull] Permission permission,
      object target,
      bool skipAdmin = false)
    {
      int num = 6;
      IEntityManager entityManager;
      Type type;
      IEntity entity;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityManager == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 2 : 2;
              continue;
            }
            goto label_12;
          case 2:
            goto label_13;
          case 3:
            goto label_4;
          case 4:
            goto label_12;
          case 5:
            if (!InstanceExpressionPermissionsDelegate.RpYfo7U9mchbLRoJClL((object) permission, (object) null))
            {
              num = 7;
              continue;
            }
            goto label_8;
          case 6:
            if (user != null)
            {
              num = 5;
              continue;
            }
            goto label_18;
          case 7:
            entity = target as IEntity;
            num = 11;
            continue;
          case 8:
            goto label_14;
          case 9:
            goto label_18;
          case 10:
            if (InstanceExpressionPermissionsDelegate.Lddg9EUhpkSYgXLl2sd((object) this, type))
            {
              entityManager = (IEntityManager) InstanceExpressionPermissionsDelegate.Y4E9YYUOoibcTmEq0Ky(type);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 1;
              continue;
            }
            num = 8;
            continue;
          case 11:
            if (entity != null)
            {
              type = InstanceExpressionPermissionsDelegate.fE2gjRUBpEdp9sxjYjQ(target);
              num = 10;
              continue;
            }
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) InstanceExpressionPermissionsDelegate.ibdvPxUE3RDIoca7LF2(--180540780 ^ 180549406), target));
label_8:
      throw new ArgumentNullException((string) InstanceExpressionPermissionsDelegate.ibdvPxUE3RDIoca7LF2(-901653144 ^ -901659228));
label_12:
      IEntityManager manager = entityManager;
      EleWise.ELMA.Model.Common.Filter filter = new EleWise.ELMA.Model.Common.Filter();
      filter.PermissionId = new Guid?(permission.Id);
      filter.PermissionUser = user;
      InstanceExpressionPermissionsDelegate.xLBGsqUTO0mRthFb9Ht((object) filter, entity.GetId());
      InstanceExpressionPermissionsDelegate.oAYw9PUFV5cAN7YYpgM((object) filter, skipAdmin);
      InstanceExpressionPermissionsDelegate.epcqSKUvwVCfcHruc63((object) filter, true);
      return manager.Exists((IEntityFilter) filter);
label_13:
      return false;
label_14:
      throw new InvalidOperationException((string) InstanceExpressionPermissionsDelegate.w65U3TUpaoN8aX4h1IP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880048079), (object) new object[1]
      {
        (object) type
      }));
label_18:
      throw new ArgumentNullException((string) InstanceExpressionPermissionsDelegate.ibdvPxUE3RDIoca7LF2(1053060681 ^ 1053064753));
    }

    internal static object ibdvPxUE3RDIoca7LF2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Nli0CyUGdKreYuIcLnl([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool anHSxhU52kIiiAS7Xcl() => InstanceExpressionPermissionsDelegate.U0011GU8UTcLkQ9FsLE == null;

    internal static InstanceExpressionPermissionsDelegate h4pCTjUdC4nuVQuIpEN() => InstanceExpressionPermissionsDelegate.U0011GU8UTcLkQ9FsLE;

    internal static bool I5xVl2UXVcHSo7lBkpF([In] object obj0, [In] object obj1) => (Permission) obj0 != (Permission) obj1;

    internal static bool RpYfo7U9mchbLRoJClL([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static object jKDNhaU1Fa3HgWkRu4x([In] object obj0) => (object) ((Permission) obj0).Base;

    internal static bool jwUDxRUMTCLQEUSLYTr([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool Lddg9EUhpkSYgXLl2sd([In] object obj0, Type type) => ((InstanceExpressionPermissionsDelegate) obj0).HasInstanceExpressionPermission(type);

    internal static Type fE2gjRUBpEdp9sxjYjQ([In] object obj0) => EntityHelper.GetType(obj0);

    internal static object w65U3TUpaoN8aX4h1IP([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object Y4E9YYUOoibcTmEq0Ky([In] Type obj0) => (object) EntityHelper.GetEntityManager(obj0);

    internal static void xLBGsqUTO0mRthFb9Ht([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).Id = obj1;

    internal static void oAYw9PUFV5cAN7YYpgM([In] object obj0, [In] bool obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).SkipAdminPermission = obj1;

    internal static void epcqSKUvwVCfcHruc63([In] object obj0, [In] bool obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).DisableSoftDeletable = obj1;
  }
}
