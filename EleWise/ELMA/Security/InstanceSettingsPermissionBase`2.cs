// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceSettingsPermissionBase`2
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.Security
{
  public abstract class InstanceSettingsPermissionBase<ET, PT> : IInstanceSettingsPermission
    where ET : class
    where PT : class, IInstanceSettingsPermissionHolder
  {
    private readonly Expression<Func<PT, ET>> targetExpression;
    private readonly string targetPropertyName;
    internal static object oKk5fgmqJylqZTOw3sc;

    protected InstanceSettingsPermissionBase(Expression<Func<PT, ET>> targetExpression)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.targetExpression = targetExpression;
      this.targetPropertyName = LinqUtils.NameOf<PT, ET>(targetExpression);
    }

    public virtual Type EntityType => InterfaceActivator.TypeOf<ET>();

    public virtual bool Filtering => true;

    public virtual string TargetPropetyName => this.targetPropertyName;

    public virtual Type PermissionHolderType => InterfaceActivator.TypeOf<PT>();

    public virtual Permission AdminPermission => (Permission) null;

    public virtual bool CanGrandPermissions(IUser user, object target)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!(this.AdminPermission == (Permission) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return true;
label_5:
      return this.SecurityService.HasPermission(user, this.AdminPermission);
    }

    public virtual ICollection<Permission> CanGrandLevel(
      IUser user,
      object target)
    {
      return (ICollection<Permission>) null;
    }

    /// <summary>Является системной ролью. Её нельзя удалять.</summary>
    /// <param name="permissionRoleTypeId"></param>
    /// <param name="permissionRole"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool IsSystemRole(Guid permissionRoleTypeId, IEntity permissionRole, object target)
    {
      int num = 3;
      InstanceSettingsPermissionBase<ET, PT> settingsPermissionBase;
      Guid permissionRoleTypeId1;
      IEntity permissionRole1;
      object target1;
      while (true)
      {
        switch (num)
        {
          case 1:
            permissionRoleTypeId1 = permissionRoleTypeId;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
            continue;
          case 2:
            settingsPermissionBase = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 1 : 1;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            target1 = target;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 4 : 5;
            continue;
          case 5:
            goto label_5;
          default:
            permissionRole1 = permissionRole;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 4 : 3;
            continue;
        }
      }
label_5:
      return ComponentManager.Current.GetExtensionPoints<ISystemRolePermissions>().Where<ISystemRolePermissions>((Func<ISystemRolePermissions, bool>) (r => r.EntityType == settingsPermissionBase.EntityType)).Any<ISystemRolePermissions>((Func<ISystemRolePermissions, bool>) (r => r.IsSystemRole(permissionRoleTypeId1, permissionRole1, target1, settingsPermissionBase.EntityType)));
    }

    /// <summary>
    /// Является системным правом, установленным по умолчанию, которое нельзя убирать.
    /// </summary>
    /// <returns></returns>
    public virtual bool IsSystemDefaultPermission(
      Permission permissionToCheck,
      Guid permissionRoleTypeId,
      IEntity permissionRole,
      object target)
    {
      int num = 2;
      InstanceSettingsPermissionBase<ET, PT> settingsPermissionBase;
      Guid permissionRoleTypeId1;
      IEntity permissionRole1;
      object target1;
      Permission permissionToCheck1;
      while (true)
      {
        switch (num)
        {
          case 1:
            settingsPermissionBase = this;
            num = 3;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 1 : 1;
            continue;
          case 3:
            permissionRoleTypeId1 = permissionRoleTypeId;
            num = 4;
            continue;
          case 4:
            permissionRole1 = permissionRole;
            num = 5;
            continue;
          case 5:
            target1 = target;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_3;
          default:
            permissionToCheck1 = permissionToCheck;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 6 : 6;
            continue;
        }
      }
label_3:
      return ComponentManager.Current.GetExtensionPoints<ISystemRolePermissions>().Where<ISystemRolePermissions>((Func<ISystemRolePermissions, bool>) (r => r.EntityType == settingsPermissionBase.EntityType)).Any<ISystemRolePermissions>((Func<ISystemRolePermissions, bool>) (r => r.IsSystem(permissionRoleTypeId1, permissionRole1, target1, settingsPermissionBase.EntityType, permissionToCheck1)));
    }

    public virtual bool CanGrandToElement(
      Permission[] elementPermission,
      Permission[] userPermission,
      Permission permissionToCheck,
      Guid permissionRoleTypeId,
      IEntity permissionRole,
      object target)
    {
      int num = 9;
      Permission permissionToCheck1;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            if (userPermission == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 2 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          case 3:
            if (target != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            goto label_3;
          case 6:
            if (permissionRole == null)
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 7:
            if (!(permissionRoleTypeId != Guid.Empty))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 1 : 1;
              continue;
            }
            goto case 6;
          case 8:
            permissionToCheck1 = permissionToCheck;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 7 : 0;
            continue;
          case 9:
            num = 8;
            continue;
          default:
            if (this.IsSystemDefaultPermission(permissionToCheck1, permissionRoleTypeId, permissionRole, target))
            {
              num = 4;
              continue;
            }
            goto case 1;
        }
      }
label_3:
      return false;
label_6:
      return true;
label_7:
      return ((IEnumerable<Permission>) userPermission).Any<Permission>((Func<Permission, bool>) (gp => gp.Id == permissionToCheck1.Id));
    }

    protected ISecurityService SecurityService => Locator.GetService<ISecurityService>();

    public virtual ICollection<IInstanceSettingsPermissionHolder> GetPermissionCollection(
      object target)
    {
      return target is ET target1 ? (ICollection<IInstanceSettingsPermissionHolder>) new InstanceSettingsPermissionBase<ET, PT>.PermissionsCollection<PT>(this.GetPermissionHolderCollection(target1)) : throw new InvalidOperationException();
    }

    protected abstract ICollection<PT> GetPermissionHolderCollection(ET target);

    internal static bool KdnR6xmgbINT8DmWsmI() => InstanceSettingsPermissionBase<ET, PT>.oKk5fgmqJylqZTOw3sc == null;

    internal static object lcOVEYmJPXjfnVTcJ1j() => InstanceSettingsPermissionBase<ET, PT>.oKk5fgmqJylqZTOw3sc;

    private class PermissionsCollection<PT> : 
      ICollection<IInstanceSettingsPermissionHolder>,
      IEnumerable<IInstanceSettingsPermissionHolder>,
      IEnumerable
      where PT : class, IInstanceSettingsPermissionHolder
    {
      private readonly ICollection<PT> target;
      private static object UKoIquwmzs5saCbrxDEg;

      public PermissionsCollection(ICollection<PT> target)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.target = target;
      }

      public IEnumerator<IInstanceSettingsPermissionHolder> GetEnumerator() => (IEnumerator<IInstanceSettingsPermissionHolder>) this.target.GetEnumerator();

      public void Add(IInstanceSettingsPermissionHolder item)
      {
        int num = 1;
        PT pt1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (item != null)
              {
                pt1 = item as PT;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 4 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_6;
            case 4:
              if ((object) pt1 != null)
              {
                this.target.Add(pt1);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 2 : 2;
                continue;
              }
              num = 5;
              continue;
            case 5:
              ICollection<PT> target = this.target;
              InstanceOf<PT> instanceOf = new InstanceOf<PT>();
              instanceOf.New.TypeRoleId = item.TypeRoleId;
              instanceOf.New.PermissionId = item.PermissionId;
              instanceOf.New.Target = item.Target;
              instanceOf.New.Assigned = item.Assigned;
              PT pt2 = instanceOf.New;
              target.Add(pt2);
              num = 3;
              continue;
            default:
              goto label_3;
          }
        }
label_2:
        return;
label_6:
        return;
label_3:
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1200636245 >> 6 ^ 18803021));
      }

      public void Clear()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.target.Clear();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool Contains(IInstanceSettingsPermissionHolder item) => this.target.Contains((PT) item);

      public void CopyTo(IInstanceSettingsPermissionHolder[] array, int arrayIndex)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.target.Cast<IInstanceSettingsPermissionHolder>().ToList<IInstanceSettingsPermissionHolder>().CopyTo(array, arrayIndex);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public bool Remove(IInstanceSettingsPermissionHolder item) => this.target.Remove((PT) item);

      public int Count => this.target.Count;

      public bool IsReadOnly => this.target.IsReadOnly;

      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.target.GetEnumerator();

      internal static bool Hbkwdsw6ukfJc9DcV05R() => InstanceSettingsPermissionBase<ET, PT>.PermissionsCollection<PT>.UKoIquwmzs5saCbrxDEg == null;

      internal static object BNTdgSw6wEl5VyTrt393() => InstanceSettingsPermissionBase<ET, PT>.PermissionsCollection<PT>.UKoIquwmzs5saCbrxDEg;
    }
  }
}
