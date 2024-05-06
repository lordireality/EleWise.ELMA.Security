// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.EntityInstancePermissionsListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  [Component]
  internal class EntityInstancePermissionsListener : IUnitOfWorkEventListener
  {
    private readonly MethodInfo syncPermissions;
    private static EntityInstancePermissionsListener vTOXKdAcrMvrwKtAucO;

    public IEnumerable<IInstanceExpressionPermission> Providers { get; set; }

    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 0 : 0;
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

    public EntityInstancePermissionsListener()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.syncPermissions = EntityInstancePermissionsListener.oHJ5VDA8LNHUH7MayoY((object) this).GetMethod((string) EntityInstancePermissionsListener.fXYNvtA59OCsgIyUeK1(1762575989 ^ 1762564073), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    private void ProcessInstancePermissions(Type eventEntityType, object target)
    {
      int num1 = 2;
      IEnumerator<IInstanceExpressionPermission> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_25;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.Providers.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 1 : 0;
            continue;
          default:
            goto label_24;
        }
      }
label_25:
      return;
label_24:
      return;
label_3:
      try
      {
label_6:
        if (EntityInstancePermissionsListener.NpNWFoAMcrlTlHitkBC((object) enumerator))
          goto label_12;
        else
          goto label_7;
label_4:
        IInstanceExpressionPermission current;
        int num2;
        while (true)
        {
          MethodInfo methodInfo;
          IDynamicExpressionPermission expressionPermission;
          IEnumerable enumerable;
          switch (num2)
          {
            case 1:
              goto label_20;
            case 2:
              expressionPermission = current as IDynamicExpressionPermission;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 5;
              continue;
            case 3:
              if (!EntityInstancePermissionsListener.IJmjT6AEwSWIe0goumB(eventEntityType, EntityInstancePermissionsListener.bULQDyAd4NQnh7LKnOd((object) current)))
              {
                num2 = 8;
                continue;
              }
              goto case 10;
            case 4:
              if (!(eventEntityType == current.EntityType))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 2 : 3;
                continue;
              }
              goto case 10;
            case 5:
              if (expressionPermission == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 3 : 7;
                continue;
              }
              break;
            case 6:
              goto label_12;
            case 7:
            case 8:
            case 9:
              goto label_6;
            case 10:
              methodInfo = (MethodInfo) EntityInstancePermissionsListener.iI9qZHAXNyNNhBsHcod((object) this.syncPermissions, (object) new Type[2]
              {
                EntityInstancePermissionsListener.bULQDyAd4NQnh7LKnOd((object) current),
                EntityInstancePermissionsListener.qw9djVAGYIwD6DwwxEh((object) current)
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 12 : 2;
              continue;
            case 11:
              EntityInstancePermissionsListener.adcU8xA1iv9ge485yY1((object) methodInfo, (object) this, (object) new object[3]
              {
                target,
                (object) current.AccessExpressions,
                (object) enumerable
              });
              num2 = 2;
              continue;
            case 12:
              enumerable = (IEnumerable) EntityInstancePermissionsListener.TK1fixA9a1NHe1QQku0((object) current, target);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 11 : 4;
              continue;
          }
          EntityInstancePermissionsListener.adcU8xA1iv9ge485yY1((object) methodInfo, (object) this, (object) new object[3]
          {
            target,
            (object) expressionPermission.GetPropertyDescriptors(target),
            (object) enumerable
          });
          num2 = 9;
        }
label_20:
        return;
label_7:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 1 : 1;
        goto label_4;
label_12:
        current = enumerator.Current;
        num2 = 4;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0)
        {
          num2 = 4;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 0 : 0;
        else
          goto label_26;
label_23:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_26:
        EntityInstancePermissionsListener.iqCYb2Ah45uI1qw0UCA((object) enumerator);
        num3 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0)
        {
          num3 = 1;
          goto label_23;
        }
        else
          goto label_23;
      }
    }

    private void SyncPermissions<ET, PT>(
      ET target,
      IPropertyExpressionDescriptor[] expressions,
      ICollection<PT> permissions)
      where ET : IEntity<long>
      where PT : IInstanceExpressionPermissionHolder
    {
      if (this.Logger.IsDebugEnabled())
        this.Logger.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801329869) + typeof (ET).Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-468111058 ^ -468098868) + target.GetId() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1200636245 >> 6 ^ 18747631) + typeof (PT).Name));
      foreach (IPropertyExpressionDescriptor expression in expressions)
      {
        Func<object, object> accessor = expression.Accessor;
        string expressionName = expression is IPropertyExpressionDescriptorWithInstanceUid ? ((IPropertyExpressionDescriptorWithInstanceUid) expression).GetExpressionName((object) target) : expression.Name;
        // ISSUE: variable of a boxed type
        __Boxed<ET> local = (object) target;
        object obj = accessor((object) local);
        switch (obj)
        {
          case null:
            permissions.Where<PT>((Func<PT, bool>) (p => p.TypeRole == expressionName)).ToList<PT>().ForEach((Action<PT>) (a => permissions.Remove(a)));
            break;
          case EleWise.ELMA.Security.Models.IUser _:
            this.UpdatePermissions<PT>((IEnumerable<IEntity<long>>) new EleWise.ELMA.Security.Models.IUser[1]
            {
              (EleWise.ELMA.Security.Models.IUser) obj
            }, (IEntity<long>) target, expressionName, permissions, expression);
            break;
          case IUserGroup _:
            this.UpdatePermissions<PT>((IEnumerable<IEntity<long>>) new IUserGroup[1]
            {
              (IUserGroup) obj
            }, (IEntity<long>) target, expressionName, permissions, expression);
            break;
          case IOrganizationItem _:
            this.UpdatePermissions<PT>((IEnumerable<IEntity<long>>) new IOrganizationItem[1]
            {
              (IOrganizationItem) obj
            }, (IEntity<long>) target, expressionName, permissions, expression);
            break;
          case IEnumerable<EleWise.ELMA.Security.Models.IUser> _:
            this.UpdatePermissions<PT>((IEnumerable<IEntity<long>>) obj, (IEntity<long>) target, expressionName, permissions, expression);
            break;
          case IEnumerable<IUserGroup> _:
            this.UpdatePermissions<PT>((IEnumerable<IEntity<long>>) obj, (IEntity<long>) target, expressionName, permissions, expression);
            break;
          case IEnumerable<IOrganizationItem> _:
            this.UpdatePermissions<PT>((IEnumerable<IEntity<long>>) obj, (IEntity<long>) target, expressionName, permissions, expression);
            break;
          default:
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893075125), (object) obj.GetType()));
        }
      }
    }

    private void UpdatePermissions<PT>(
      IEnumerable<IEntity<long>> value,
      IEntity<long> target,
      string expressionName,
      ICollection<PT> permissions,
      IPropertyExpressionDescriptor expression)
      where PT : IInstanceExpressionPermissionHolder
    {
      PT[] array = permissions.Where<PT>((Func<PT, bool>) (p => p.TypeRole == expressionName)).ToArray<PT>();
      foreach (PT pt in array)
      {
        PT pc = pt;
        ISecurityExpressionSetIdHolder secExpSetIdHolder = (object) (PT) pc as ISecurityExpressionSetIdHolder;
        if (secExpSetIdHolder != null && !value.Any<IEntity<long>>((Func<IEntity<long>, bool>) (s =>
        {
          long? itemMask = this.GetItemMask(s);
          long? securitySetCacheId = secExpSetIdHolder.UserSecuritySetCacheId;
          return itemMask.GetValueOrDefault() == securitySetCacheId.GetValueOrDefault() & itemMask.HasValue == securitySetCacheId.HasValue;
        })))
          permissions.Remove(pc);
        else if (secExpSetIdHolder == null && !value.Any<IEntity<long>>((Func<IEntity<long>, bool>) (s => object.Equals((object) s, (object) pc.User))))
          permissions.Remove(pc);
      }
      foreach (IEntity<long> entity in value)
      {
        IEntity<long> item = entity;
        if (!((IEnumerable<PT>) array).Any<PT>((Func<PT, bool>) (pc =>
        {
          if (!((object) pc is ISecurityExpressionSetIdHolder))
            return object.Equals((object) pc.User, (object) item);
          long? securitySetCacheId = ((ISecurityExpressionSetIdHolder) (object) pc).UserSecuritySetCacheId;
          long? itemMask = this.GetItemMask(item);
          return securitySetCacheId.GetValueOrDefault() == itemMask.GetValueOrDefault() & securitySetCacheId.HasValue == itemMask.HasValue;
        })))
        {
          this.AddPermission<PT>(item, target, expressionName, expression.AllowChief, permissions);
          if (expression.AllowChief && !(expression is IPropertyExpressionDescriptorWithInstanceUid))
            this.AddPermission<PT>(item, target, expressionName, false, permissions);
        }
      }
    }

    private void AddPermission<PT>(
      IEntity<long> item,
      IEntity<long> target,
      string expressionName,
      bool allowChief,
      ICollection<PT> permissions)
      where PT : IInstanceExpressionPermissionHolder
    {
      PT pt = InterfaceActivator.Create<PT>();
      pt.Target = (object) target;
      if (item is EleWise.ELMA.Security.Models.IUser user)
        pt.User = (EleWise.ELMA.Security.IUser) user;
      pt.TypeRole = expressionName;
      pt.AllowChief = allowChief;
      if (pt is ISecurityExpressionSetIdHolder expressionSetIdHolder)
        expressionSetIdHolder.UserSecuritySetCacheId = this.GetItemMask(item);
      permissions.Add(pt);
    }

    private long? GetItemMask(IEntity<long> entity)
    {
      switch (entity)
      {
        case IUserGroup _:
          return new long?(UserSecuritySetHelper.GetGroupMask(entity.Id));
        case IOrganizationItem _:
          return new long?(UserSecuritySetHelper.GetOrganizationItemMask(entity.Id));
        case EleWise.ELMA.Security.Models.IUser _:
          return new long?(UserSecuritySetHelper.GetUserMask(entity.Id));
        default:
          return new long?();
      }
    }

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
      foreach (object entity in entities)
        this.ProcessInstancePermissions(entity.GetType(), entity);
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    internal static bool xRIIKgAPEFQTKMXNCmd() => EntityInstancePermissionsListener.vTOXKdAcrMvrwKtAucO == null;

    internal static EntityInstancePermissionsListener rr9QRsAQoCG7fbiX0xW() => EntityInstancePermissionsListener.vTOXKdAcrMvrwKtAucO;

    internal static Type oHJ5VDA8LNHUH7MayoY([In] object obj0) => obj0.GetType();

    internal static object fXYNvtA59OCsgIyUeK1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type bULQDyAd4NQnh7LKnOd([In] object obj0) => ((IInstanceExpressionPermission) obj0).EntityType;

    internal static bool IJmjT6AEwSWIe0goumB([In] Type obj0, [In] Type obj1) => obj0.IsInheritOrSame(obj1);

    internal static Type qw9djVAGYIwD6DwwxEh([In] object obj0) => ((IInstanceExpressionPermission) obj0).PermissionType;

    internal static object iI9qZHAXNyNNhBsHcod([In] object obj0, [In] object obj1) => (object) ((MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    internal static object TK1fixA9a1NHe1QQku0([In] object obj0, [In] object obj1) => (object) ((IInstanceExpressionPermission) obj0).GetPermissionCollection(obj1);

    internal static object adcU8xA1iv9ge485yY1([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool NpNWFoAMcrlTlHitkBC([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void iqCYb2Ah45uI1qw0UCA([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
