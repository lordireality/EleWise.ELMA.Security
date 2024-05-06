// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.UserSecuritySetHelper
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System;

namespace EleWise.ELMA.Security
{
  public static class UserSecuritySetHelper
  {
    private static UserSecuritySetHelper aN3PltDHDMhIKYpurds;

    /// <summary>Проверяет, является ли маска группой</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool IsGroup(long? id)
    {
      if (!id.HasValue)
        return false;
      long? nullable1 = id;
      long? nullable2 = nullable1.HasValue ? new long?(nullable1.GetValueOrDefault() & 144115188075855872L) : new long?();
      long num = 0;
      return !(nullable2.GetValueOrDefault() == num & nullable2.HasValue);
    }

    /// <summary>Проверяет, является ли маска группой</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool IsUser(long? id)
    {
      if (!id.HasValue)
        return false;
      long? nullable1 = id;
      long? nullable2 = nullable1.HasValue ? new long?(nullable1.GetValueOrDefault() & 72057594037927936L) : new long?();
      long num = 0;
      return !(nullable2.GetValueOrDefault() == num & nullable2.HasValue);
    }

    /// <summary>Проверяет, является ли маска , маской отдела</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool IsDepartament(long? id)
    {
      if (!id.HasValue)
        return false;
      long? nullable1 = id;
      long? nullable2 = nullable1.HasValue ? new long?(nullable1.GetValueOrDefault() & 216172782113783808L) : new long?();
      long num = 0;
      return !(nullable2.GetValueOrDefault() == num & nullable2.HasValue);
    }

    /// <summary>Проверяет, является ли маска , маской должности</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool IsPost(long? id)
    {
      if (!id.HasValue)
        return false;
      long? nullable1 = id;
      long? nullable2 = nullable1.HasValue ? new long?(nullable1.GetValueOrDefault() & 216172782113783808L) : new long?();
      long num = 0;
      return !(nullable2.GetValueOrDefault() == num & nullable2.HasValue);
    }

    /// <summary>Маска по пользователю</summary>
    public static long UserMask => 72057594037927936;

    /// <summary>Маска по отделу</summary>
    public static long GroupMask => 144115188075855872;

    /// <summary>Маска по группе</summary>
    public static long OrganizationItemMask => 216172782113783808;

    public static long GetGroupMask(long id) => id | 144115188075855872L;

    public static long GetOrganizationItemMask(long id) => id | 216172782113783808L;

    [Obsolete("Следует использовать GetOrganizationItemMask вместо GetPostMask", false)]
    public static long GetPostMask(long id) => id | 216172782113783808L;

    public static long GetUserMask(long id) => id | 72057594037927936L;

    internal static bool IL5YDLDzVl9uuSOqiON() => UserSecuritySetHelper.aN3PltDHDMhIKYpurds == null;

    internal static UserSecuritySetHelper a6vBvVauvbZfNhhN9Yy() => UserSecuritySetHelper.aN3PltDHDMhIKYpurds;
  }
}
