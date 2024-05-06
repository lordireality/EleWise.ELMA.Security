// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceSettingsPermissionsDelegate
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Делегат InstanceSettingsPermissions</summary>
  [Component(Order = 2147483647)]
  public class InstanceSettingsPermissionsDelegate : IPermissionsDelegate
  {
    private readonly Func<Type, bool> hasInstanceSettingsPermissionCacheFunc;
    private readonly Func<Type, Guid, bool> hasPermissionRoleTypeProviderCacheFunc;
    private static InstanceSettingsPermissionsDelegate q3f2JL6WI2s4xDOXHGU;

    /// <summary>Ctor</summary>
    /// <param name="memoryCacheService">Сервис для кэширования в памяти</param>
    /// <param name="instanceSettingsPermissions">Список привилегий для экземпляра объекта</param>
    /// <param name="permissionRoleTypeProviders">Список привилегий для типа объекта</param>
    public InstanceSettingsPermissionsDelegate(
      IMemoryCacheService memoryCacheService,
      Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissions,
      Func<IEnumerable<IPermissionRoleTypeProvider>> permissionRoleTypeProviders)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      InstanceSettingsPermissionsDelegate.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20 = new InstanceSettingsPermissionsDelegate.\u003C\u003Ec__DisplayClass2_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.instanceSettingsPermissions = instanceSettingsPermissions;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.permissionRoleTypeProviders = permissionRoleTypeProviders;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      ParameterExpression parameterExpression1 = Expression.Parameter(typeof (Type), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691374724));
      // ISSUE: method reference
      MethodInfo methodFromHandle1 = (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Enumerable.Any));
      // ISSUE: field reference
      Expression[] expressionArray1 = new Expression[2]
      {
        (Expression) Expression.Invoke((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (InstanceSettingsPermissionsDelegate.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (InstanceSettingsPermissionsDelegate.\u003C\u003Ec__DisplayClass2_0.instanceSettingsPermissions)))),
        null
      };
      ParameterExpression parameterExpression2;
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: method reference
      expressionArray1[1] = (Expression) Expression.Lambda<Func<IInstanceSettingsPermission, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ReflectionHelper.IsInheritOrSame)), new Expression[2]
      {
        (Expression) parameterExpression1,
        (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IInstanceSettingsPermission.get_EntityType)))
      }), (Expression) Expression.Call((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ReflectionHelper.IsInheritOrSame)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IInstanceSettingsPermission.get_PermissionHolderType))))), parameterExpression2);
      this.hasInstanceSettingsPermissionCacheFunc = MetadataLoader.UseCachingForFunc<Type, bool>(Expression.Lambda<Func<Type, bool>>((Expression) Expression.Call((Expression) null, methodFromHandle1, expressionArray1), parameterExpression1));
      ParameterExpression parameterExpression3 = Expression.Parameter(typeof (Type), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-201065280 ^ -201075718));
      ParameterExpression right = Expression.Parameter(typeof (Guid), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859364753));
      // ISSUE: method reference
      MethodInfo methodFromHandle2 = (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Enumerable.Any));
      // ISSUE: field reference
      Expression[] expressionArray2 = new Expression[2]
      {
        (Expression) Expression.Invoke((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (InstanceSettingsPermissionsDelegate.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (InstanceSettingsPermissionsDelegate.\u003C\u003Ec__DisplayClass2_0.permissionRoleTypeProviders)))),
        null
      };
      ParameterExpression instance = Expression.Parameter(typeof (IPermissionRoleTypeProvider), z2jc63fLkugS1X8Q9N.tE1kD1vbB(784628100 ^ 784619220));
      // ISSUE: method reference
      MethodInfo methodFromHandle3 = (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Enumerable.Any));
      // ISSUE: method reference
      Expression[] expressionArray3 = new Expression[2]
      {
        (Expression) Expression.Call((Expression) instance, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IPermissionRoleTypeProvider.GetTypePermissionRoleStereotypes)), Array.Empty<Expression>()),
        null
      };
      ParameterExpression parameterExpression4;
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: method reference
      expressionArray3[1] = (Expression) Expression.Lambda<Func<PermissionRoleTypeStereotype, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ReflectionHelper.IsInheritOrSame)), new Expression[2]
      {
        (Expression) parameterExpression3,
        (Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PermissionRoleTypeStereotype.get_Type)))
      }), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PermissionRoleTypeStereotype.get_Permission))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Permission.get_Id))), (Expression) right, false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression4);
      expressionArray2[1] = (Expression) Expression.Lambda<Func<IPermissionRoleTypeProvider, bool>>((Expression) Expression.Call((Expression) null, methodFromHandle3, expressionArray3), instance);
      this.hasPermissionRoleTypeProviderCacheFunc = MetadataLoader.UseCachingForFunc<Type, Guid, bool>(Expression.Lambda<Func<Type, Guid, bool>>((Expression) Expression.Call((Expression) null, methodFromHandle2, expressionArray2), parameterExpression3, right));
    }

    /// <summary>Поддерживает ли права доступа</summary>
    /// <param name="type">Тип</param>
    protected virtual bool HasInstanceSettingsPermission(Type type) => this.hasInstanceSettingsPermissionCacheFunc(type);

    /// <summary>
    /// Определены ли привилегии для объекта типа, роли для привилегий
    /// </summary>
    /// <param name="type">Тип</param>
    /// <param name="permission">Привилегия</param>
    protected virtual bool HasPermissionRoleTypeProvider(Type type, Permission permission) => this.hasPermissionRoleTypeProviderCacheFunc(type, permission.Id);

    /// <inheritdoc />
    public bool CanCheckPermissions(Type type, Permission permission)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (permission.PermissionType == PermissionType.Instance)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 5 : 6;
              continue;
            }
            goto label_14;
          case 3:
            if (!(permission != (Permission) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 2 : 1;
              continue;
            }
            goto case 1;
          case 4:
            if (!InstanceSettingsPermissionsDelegate.EuVYZM6Vyar0boomNgk((object) permission))
            {
              num = 5;
              continue;
            }
            goto label_13;
          case 5:
            goto label_12;
          case 6:
            if (!InstanceSettingsPermissionsDelegate.m9gLpt6YQpdalIcNn2a(type, (Type) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 7:
            if (InstanceSettingsPermissionsDelegate.BbTyUi6yQX0KshbdkMJ((object) this, type))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 4 : 0;
              continue;
            }
            goto label_14;
          default:
            goto label_14;
        }
      }
label_12:
      return InstanceSettingsPermissionsDelegate.X0m18h6lwZJ8SiGc98N((object) this, type, (object) permission);
label_13:
      return true;
label_14:
      return false;
    }

    /// <inheritdoc />
    public virtual bool HasPermission(
      [NotNull] IUser user,
      [NotNull] Permission permission,
      object target,
      bool skipAdmin = false)
    {
      int num = 2;
      Type type;
      IEntity entity;
      IEntityManager entityManager;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!InstanceSettingsPermissionsDelegate.OVhf4964Abc7DmB0p0I((object) permission, (object) null))
            {
              entity = target as IEntity;
              num = 10;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 6 : 1;
            continue;
          case 2:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 1 : 0;
              continue;
            }
            goto label_10;
          case 3:
            goto label_13;
          case 4:
            if (entityManager == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 9 : 4;
              continue;
            }
            goto label_15;
          case 5:
            goto label_10;
          case 6:
            goto label_8;
          case 7:
            if (this.HasInstanceSettingsPermission(type))
            {
              num = 11;
              continue;
            }
            goto label_13;
          case 8:
            goto label_15;
          case 9:
            goto label_16;
          case 10:
            if (entity != null)
            {
              type = InstanceSettingsPermissionsDelegate.El4lTo6P4XaDCSLfdpL(target);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 7;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 0;
            continue;
          case 11:
            entityManager = (IEntityManager) InstanceSettingsPermissionsDelegate.xWIPx76QWN2mb9ONajx(type);
            num = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      throw new InvalidOperationException((string) InstanceSettingsPermissionsDelegate.rIUBeF6cmeVxppTZqyY(InstanceSettingsPermissionsDelegate.WogRd86fwrGPBtCq8pA(-1751467293 ^ -1751476079), (object) new object[1]
      {
        target
      }));
label_8:
      throw new ArgumentNullException((string) InstanceSettingsPermissionsDelegate.WogRd86fwrGPBtCq8pA(781628008 - 11982093 ^ 769639831));
label_10:
      throw new ArgumentNullException((string) InstanceSettingsPermissionsDelegate.WogRd86fwrGPBtCq8pA(784628100 ^ 784624124));
label_13:
      throw new InvalidOperationException((string) InstanceSettingsPermissionsDelegate.rIUBeF6cmeVxppTZqyY(InstanceSettingsPermissionsDelegate.WogRd86fwrGPBtCq8pA(1848373724 >> 1 ^ 924181104), (object) new object[1]
      {
        (object) type
      }));
label_15:
      IEntityManager manager = entityManager;
      EleWise.ELMA.Model.Common.Filter filter = new EleWise.ELMA.Model.Common.Filter();
      filter.PermissionId = new Guid?(InstanceSettingsPermissionsDelegate.IKf5lW68nbS6nJE50tr((object) permission));
      InstanceSettingsPermissionsDelegate.Ay9mcV65T0mPXGKIYkD((object) filter, (object) user);
      InstanceSettingsPermissionsDelegate.FJN8u36darE712Rbgae((object) filter, entity.GetId());
      filter.SkipAdminPermission = skipAdmin;
      InstanceSettingsPermissionsDelegate.Wl3dcC6EdddTmv0rFDn((object) filter, true);
      return manager.Exists((IEntityFilter) filter);
label_16:
      return false;
    }

    internal static bool P95Mts6rTe8YhR1JbUV() => InstanceSettingsPermissionsDelegate.q3f2JL6WI2s4xDOXHGU == null;

    internal static InstanceSettingsPermissionsDelegate x6qE5L6SRYwvkQrJdaR() => InstanceSettingsPermissionsDelegate.q3f2JL6WI2s4xDOXHGU;

    internal static bool m9gLpt6YQpdalIcNn2a([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool BbTyUi6yQX0KshbdkMJ([In] object obj0, Type type) => ((InstanceSettingsPermissionsDelegate) obj0).HasInstanceSettingsPermission(type);

    internal static bool EuVYZM6Vyar0boomNgk([In] object obj0) => ((Permission) obj0).IsInstanceSettingsPermission;

    internal static bool X0m18h6lwZJ8SiGc98N([In] object obj0, Type type, [In] object obj2) => ((InstanceSettingsPermissionsDelegate) obj0).HasPermissionRoleTypeProvider(type, (Permission) obj2);

    internal static object WogRd86fwrGPBtCq8pA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool OVhf4964Abc7DmB0p0I([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static object rIUBeF6cmeVxppTZqyY([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static Type El4lTo6P4XaDCSLfdpL([In] object obj0) => EntityHelper.GetType(obj0);

    internal static object xWIPx76QWN2mb9ONajx([In] Type obj0) => (object) EntityHelper.GetEntityManager(obj0);

    internal static Guid IKf5lW68nbS6nJE50tr([In] object obj0) => ((Permission) obj0).Id;

    internal static void Ay9mcV65T0mPXGKIYkD([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).PermissionUser = (IUser) obj1;

    internal static void FJN8u36darE712Rbgae([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).Id = obj1;

    internal static void Wl3dcC6EdddTmv0rFDn([In] object obj0, [In] bool obj1) => ((EleWise.ELMA.Model.Common.Filter) obj0).DisableSoftDeletable = obj1;
  }
}
