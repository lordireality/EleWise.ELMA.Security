// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Events.SecurityCacheSetIdEventArgs
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Events
{
  /// <summary>
  /// Аргументы события возникающего при изменении групп пользователей и оргструктур
  /// </summary>
  public class SecurityCacheSetIdEventArgs : AuditEventArgs
  {
    private static SecurityCacheSetIdEventArgs Nir5bkJ5ijxxaxQoWhQ;

    /// <summary>ctor</summary>
    public SecurityCacheSetIdEventArgs()
    {
      SecurityCacheSetIdEventArgs.ryTUYXJGy1oLqbi5TPL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 8;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.OrganizationItemAddUsers = Enumerable.Empty<Tuple<long, long>>();
            num = 5;
            continue;
          case 3:
            this.GroupRemoveOrganizationItems = Enumerable.Empty<Tuple<long, long>>();
            num = 4;
            continue;
          case 4:
            this.GroupAddGroups = Enumerable.Empty<Tuple<long, long>>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
            continue;
          case 5:
            this.OrganizationItemRemoveUsers = Enumerable.Empty<Tuple<long, long>>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 1 : 1;
            continue;
          case 6:
            this.GroupAddOrganizationItems = Enumerable.Empty<Tuple<long, long>>();
            num = 3;
            continue;
          case 7:
            this.GroupRemoveUsers = Enumerable.Empty<Tuple<long, long>>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 4 : 6;
            continue;
          case 8:
            this.GroupAddUsers = Enumerable.Empty<Tuple<long, long>>();
            num = 7;
            continue;
          default:
            this.GroupRemoveGroups = Enumerable.Empty<Tuple<long, long>>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Признак, что было произведено полное обновление таблицы прав доступа
    /// </summary>
    public bool FullUpdate
    {
      get => this.\u003CFullUpdate\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFullUpdate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
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

    /// <summary>
    /// Добавленные пользователи в группы при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: GroupId, UserId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> GroupAddUsers { get; internal set; }

    /// <summary>
    /// Удаленные пользователи из групп при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: GroupId, UserId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> GroupRemoveUsers { get; internal set; }

    /// <summary>
    /// Добавленные элементы оргструктуры в группы при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: GroupId, OrganizationItemId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> GroupAddOrganizationItems { get; internal set; }

    /// <summary>
    /// Удаленные элементы оргструктуры из групп при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: GroupId, OrganizationItemId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> GroupRemoveOrganizationItems { get; internal set; }

    /// <summary>
    /// Добавленные группы в группы при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: GroupId, GroupId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> GroupAddGroups { get; internal set; }

    /// <summary>
    /// Удаленные группы из групп при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: GroupId, GroupId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> GroupRemoveGroups { get; internal set; }

    /// <summary>
    /// Добавленные пользователи в элементы оргструктуры при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: OrganizationItemId, UserId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> OrganizationItemAddUsers { get; internal set; }

    /// <summary>
    /// Удаленные пользователи из элементов оргструктуры при частичном обновлении табличцы прав доступа
    /// <para>возвращаются пары: OrganizationItemId, UserId</para>
    /// </summary>
    public IEnumerable<Tuple<long, long>> OrganizationItemRemoveUsers { get; internal set; }

    internal static void ryTUYXJGy1oLqbi5TPL() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool atqWwdJdT2u3CZg0VUR() => SecurityCacheSetIdEventArgs.Nir5bkJ5ijxxaxQoWhQ == null;

    internal static SecurityCacheSetIdEventArgs Dt8gEsJELUGNY1u9AJy() => SecurityCacheSetIdEventArgs.Nir5bkJ5ijxxaxQoWhQ;
  }
}
