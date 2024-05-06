// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.GroupPermissionManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Events;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Менеджер работы с глобальными привилегиями</summary>
  [Service(EnableInterceptors = true, InjectProperties = true, Type = ComponentType.Server)]
  public class GroupPermissionManager : NHManager
  {
    private IGroupPermissionEventHandler _groupPermissionEventHandler;
    private static GroupPermissionManager vbv7R8m3OTuPQ0pn7we;

    /// <summary>Logger</summary>
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 0 : 0;
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

    private IGroupPermissionEventHandler GroupPermissionEventHandler
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._groupPermissionEventHandler == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              this._groupPermissionEventHandler = Locator.GetService<IGroupPermissionEventHandler>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return this._groupPermissionEventHandler;
      }
    }

    /// <summary>Дать привилегию группе</summary>
    /// <param name="group"></param>
    /// <param name="permission"></param>
    [Transaction]
    public virtual void GrantPermission(IUserGroup group, Permission permission)
    {
      int num1 = 2;
      GroupPermission permission1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_4;
          case 2:
            if (group != null)
            {
              if (!GroupPermissionManager.Gyv8wfm0tckOaoELdyQ((object) permission, (object) null))
              {
                num1 = 9;
                continue;
              }
              goto label_9;
            }
            else
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 0;
              continue;
            }
          case 3:
            goto label_28;
          case 4:
            GroupPermission groupPermission = new GroupPermission();
            GroupPermissionManager.ULGmBams1JU0IwAFbRw((object) groupPermission, (object) group);
            GroupPermissionManager.iNaLtTmWjjMMRb30bVi((object) groupPermission, GroupPermissionManager.XkZ2jvm7OagW0npYMII((object) permission));
            permission1 = groupPermission;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 1 : 10;
            continue;
          case 5:
label_7:
            if (this.GroupPermissionEventHandler == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 8 : 4;
              continue;
            }
            goto case 7;
          case 6:
            goto label_9;
          case 7:
            GroupPermissionManager.M6EE2rmyD3MvT6whvRr((object) this.GroupPermissionEventHandler, (object) new GroupPermissionEventArgs(permission1, GroupPermissionOperation.Add, permission));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 0 : 0;
            continue;
          case 8:
            goto label_22;
          case 9:
            if (GroupPermissionManager.s2o8YRmAe1J9Pe5CTJ2((object) this.GetGroupPermission(group, permission)) <= 0)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 1 : 4;
              continue;
            }
            goto label_27;
          case 10:
            try
            {
              GroupPermissionManager.EoC19TmSp53DiZEjuwA(GroupPermissionManager.YQjF41mrXm9GqdxiUtl((object) this), (object) permission1);
              int num2 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_7;
              }
            }
            catch (NonUniqueObjectException ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    if (this.Logger.IsWarnEnabled())
                    {
                      num3 = 2;
                      continue;
                    }
                    break;
                  case 2:
                    this.Logger.Warn((object) ex);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_7;
                }
                GroupPermissionManager.myRMnRmY2xsvVM2Q6U7((object) this.Session);
                num3 = 3;
              }
            }
          default:
            goto label_18;
        }
      }
label_2:
      return;
label_28:
      return;
label_22:
      return;
label_18:
      return;
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629935560 ^ -1103494022 ^ 1682561662));
label_9:
      throw new ArgumentNullException((string) GroupPermissionManager.kvEmmlmZXroY3JkH4ds(1940240517 ^ 974551502 ^ 1236523399));
label_27:;
    }

    /// <summary>Получить группы, которым дана привилегия</summary>
    /// <param name="permission"></param>
    /// <returns></returns>
    public virtual IEnumerable<IUserGroup> GetGroupsByPermission(
      Permission permission)
    {
      return !(permission == (Permission) null) ? this.GetGroupsByPermissionUid(permission.Id) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1185105284 ^ 1185111368));
    }

    /// <summary>Получить группы, которым дана привилегия</summary>
    /// <param name="permissionUid"> </param>
    /// <returns></returns>
    public IEnumerable<IUserGroup> GetGroupsByPermissionUid(Guid permissionUid)
    {
      if (permissionUid == Guid.Empty)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1212789817 - 1827404527 ^ 1254784146));
      // ISSUE: reference to a compiler-generated method
      return (IEnumerable<IUserGroup>) this.ClearGroups((IEnumerable<GroupPermission>) this.Session.Query<GroupPermission>().Where<GroupPermission>((Expression<Func<GroupPermission, bool>>) (groupPermission => groupPermission.PermissionId == permissionUid)).ToList<GroupPermission>()).Select<GroupPermission, IUserGroup>((Func<GroupPermission, IUserGroup>) (v => (IUserGroup) GroupPermissionManager.\u003C\u003Ec.fWp9TLwmymitnTsx53Jr((object) v))).ToList<IUserGroup>();
    }

    private List<GroupPermission> ClearGroups(
      IEnumerable<GroupPermission> groupPermissions)
    {
      if (groupPermissions == null)
        return (List<GroupPermission>) null;
      List<GroupPermission> groupPermissionList = new List<GroupPermission>();
      foreach (GroupPermission groupPermission in groupPermissions)
      {
        try
        {
          if (groupPermission.Group == null || groupPermission.Group.IsNew())
          {
            this.RemovePermissionInternal(groupPermission);
          }
          else
          {
            string name = groupPermission.Group.Name;
            groupPermissionList.Add(groupPermission);
          }
        }
        catch (ObjectNotFoundException ex1)
        {
          this.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340797570)), (Exception) ex1);
          try
          {
            this.RemovePermissionInternal(groupPermission);
          }
          catch (Exception ex2)
          {
            this.Logger.Error(ex2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1341618464 ^ -1341609432), (object) groupPermission.PermissionId);
          }
        }
      }
      return groupPermissionList;
    }

    /// <summary>Получить привилегии группы</summary>
    /// <param name="userGroup"></param>
    /// <returns></returns>
    public virtual IEnumerable<Guid> GetGroupPermissions(IUserGroup userGroup)
    {
      if (userGroup == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-315619370 - -1325004768 ^ 1009373880));
      // ISSUE: reference to a compiler-generated method
      return (IEnumerable<Guid>) this.Session.Query<GroupPermission>().Where<GroupPermission>((Expression<Func<GroupPermission, bool>>) (groupPermission => groupPermission.Group == userGroup)).ToList<GroupPermission>().Select<GroupPermission, Guid>((Func<GroupPermission, Guid>) (v => GroupPermissionManager.\u003C\u003Ec.RrxB0GwmV22YBQiDACZa((object) v))).ToList<Guid>();
    }

    /// <summary>Убрать привилегию у группы</summary>
    /// <param name="userGroup"></param>
    /// <param name="permission"></param>
    /// <returns></returns>
    [Transaction]
    public virtual void RemovePermission(IUserGroup userGroup, Permission permission)
    {
      int num1 = 3;
      List<GroupPermission>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_18;
          case 2:
            if (!(permission == (Permission) null))
            {
              enumerator = this.GetGroupPermission(userGroup, permission).GetEnumerator();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 5 : 5;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 0;
            continue;
          case 3:
            if (userGroup != null)
            {
              num1 = 2;
              continue;
            }
            goto label_18;
          case 4:
            goto label_17;
          case 5:
            goto label_6;
          default:
            goto label_4;
        }
      }
label_17:
      return;
label_4:
      throw new ArgumentNullException((string) GroupPermissionManager.kvEmmlmZXroY3JkH4ds(-1277472395 ^ -1277474375));
label_6:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_11;
label_7:
        GroupPermission current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_15;
            case 3:
              this.RemovePermissionInternal(current, permission);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 1;
              continue;
            default:
              goto label_9;
          }
        }
label_15:
        return;
label_9:
        current = enumerator.Current;
        num2 = 3;
        goto label_7;
label_11:
        num2 = 2;
        goto label_7;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_18:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-110921701 >> 6 ^ -1728274));
    }

    /// <summary>Убрать привилегии у группы</summary>
    /// <param name="userGroup"></param>
    /// <returns></returns>
    [Transaction]
    public virtual void RemovePermission(IUserGroup userGroup)
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      GroupPermissionManager.\u003C\u003Ec__DisplayClass13_0 cDisplayClass130;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass130 = new GroupPermissionManager.\u003C\u003Ec__DisplayClass13_0();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass130.userGroup == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 1 : 4;
              continue;
            }
            IQueryable<GroupPermission> source = this.Session.Query<GroupPermission>();
            ParameterExpression parameterExpression = (ParameterExpression) GroupPermissionManager.DcKRntmVDmwil1rEuNf(typeof (GroupPermission), GroupPermissionManager.kvEmmlmZXroY3JkH4ds(44166125 ^ 44156805));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            Expression<Func<GroupPermission, bool>> predicate = Expression.Lambda<Func<GroupPermission, bool>>((Expression) GroupPermissionManager.UcoyYMmQ8qsqYN7MIt6(GroupPermissionManager.H9JUyqmlElk8ABs9f5j((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (GroupPermission.get_Group))), GroupPermissionManager.idiV0QmP2XHnYqOCrFu(GroupPermissionManager.SSl4fBm4Jjqr0Mi1chg((object) cDisplayClass130, GroupPermissionManager.CSxubwmfXFZnTNKQ9D5(__typeref (GroupPermissionManager.\u003C\u003Ec__DisplayClass13_0))), GroupPermissionManager.i9E8G3mc3EyM4RRrMs4(__fieldref (GroupPermissionManager.\u003C\u003Ec__DisplayClass13_0.userGroup)))), parameterExpression);
            source.Where<GroupPermission>(predicate).ToList<GroupPermission>().ForEach(new Action<GroupPermission>(this.RemovePermissionInternal));
            num = 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_7;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass130.userGroup = userGroup;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return;
label_7:
      throw new ArgumentNullException((string) GroupPermissionManager.kvEmmlmZXroY3JkH4ds(554338340 ^ 554345770));
    }

    private void RemovePermissionInternal(GroupPermission groupPermission)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RemovePermissionInternal(groupPermission, (Permission) null);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void RemovePermissionInternal(GroupPermission groupPermission, Permission permission)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (this.GroupPermissionEventHandler != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            ((ISession) GroupPermissionManager.YQjF41mrXm9GqdxiUtl((object) this)).Delete((object) groupPermission);
            num = 2;
            continue;
          default:
            GroupPermissionManager.M6EE2rmyD3MvT6whvRr((object) this.GroupPermissionEventHandler, (object) new GroupPermissionEventArgs(groupPermission, GroupPermissionOperation.Remove, permission));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    private List<GroupPermission> GetGroupPermission(
      IUserGroup userGroup,
      Permission permission)
    {
      return this.Session.Query<GroupPermission>().Where<GroupPermission>((Expression<Func<GroupPermission, bool>>) (groupPermission => groupPermission.PermissionId == permission.Id && groupPermission.Group == userGroup)).ToList<GroupPermission>();
    }

    /// <summary>Удалить все назначения привилегий на группы</summary>
    [Transaction]
    public virtual void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((ISession) GroupPermissionManager.YQjF41mrXm9GqdxiUtl((object) this)).Query<GroupPermission>().ToList<GroupPermission>().ForEach(new Action<GroupPermission>(((ISession) GroupPermissionManager.YQjF41mrXm9GqdxiUtl((object) this)).Delete));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public GroupPermissionManager()
    {
      GroupPermissionManager.csM7LTm8CdNYeGQONGP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QPak2smjfQYAROT4DVS() => GroupPermissionManager.vbv7R8m3OTuPQ0pn7we == null;

    internal static GroupPermissionManager V0TduCmNoeJpJFU3g0n() => GroupPermissionManager.vbv7R8m3OTuPQ0pn7we;

    internal static bool Gyv8wfm0tckOaoELdyQ([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static object kvEmmlmZXroY3JkH4ds(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int s2o8YRmAe1J9Pe5CTJ2([In] object obj0) => ((List<GroupPermission>) obj0).Count;

    internal static void ULGmBams1JU0IwAFbRw([In] object obj0, [In] object obj1) => ((GroupPermission) obj0).Group = (IUserGroup) obj1;

    internal static Guid XkZ2jvm7OagW0npYMII([In] object obj0) => ((Permission) obj0).Id;

    internal static void iNaLtTmWjjMMRb30bVi([In] object obj0, Guid value) => ((GroupPermission) obj0).PermissionId = value;

    internal static object YQjF41mrXm9GqdxiUtl([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static void EoC19TmSp53DiZEjuwA([In] object obj0, [In] object obj1) => ((ISession) obj0).SaveOrUpdate(obj1);

    internal static void myRMnRmY2xsvVM2Q6U7([In] object obj0) => ((ISession) obj0).Flush();

    internal static void M6EE2rmyD3MvT6whvRr([In] object obj0, [In] object obj1) => ((IGroupPermissionEventHandler) obj0).PostChange((GroupPermissionEventArgs) obj1);

    internal static object DcKRntmVDmwil1rEuNf([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object H9JUyqmlElk8ABs9f5j([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Type CSxubwmfXFZnTNKQ9D5([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object SSl4fBm4Jjqr0Mi1chg([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object i9E8G3mc3EyM4RRrMs4([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object idiV0QmP2XHnYqOCrFu([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object UcoyYMmQ8qsqYN7MIt6([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static void csM7LTm8CdNYeGQONGP() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
