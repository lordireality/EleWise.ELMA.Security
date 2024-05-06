// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.AuthToken
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Токен аутентификации</summary>
  public class AuthToken
  {
    internal static AuthToken Dr8mQ4fIiaHe0SMB6u9;

    /// <summary>Идентификатор</summary>
    public virtual Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор пользователя</summary>
    public virtual long UserId
    {
      get => this.\u003CUserId\u003Ek__BackingField;
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
              this.\u003CUserId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
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

    /// <summary>Срок действия токена</summary>
    public virtual DateTime ExpireDate
    {
      get => this.\u003CExpireDate\u003Ek__BackingField;
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
              this.\u003CExpireDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 0 : 0;
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

    public AuthToken()
    {
      AuthToken.VBo5HnfLRAHVOYByKHp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cjhK0QfeTOMac9LKErE() => AuthToken.Dr8mQ4fIiaHe0SMB6u9 == null;

    internal static AuthToken zwcSesfnmARe0to1Py9() => AuthToken.Dr8mQ4fIiaHe0SMB6u9;

    internal static void VBo5HnfLRAHVOYByKHp() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    /// <summary>Названия для структуры данных</summary>
    internal static class Tables
    {
      /// <summary>Имя таблицы</summary>
      public const string TableName = "Sys_AuthToken";

      /// <summary>Имена столбцов</summary>
      public static class Fields
      {
        /// <summary>Имя столбца идентификатора</summary>
        public const string Uid = "Uid";
        /// <summary>Имя столбца с идентификатором пользователя</summary>
        public const string UserId = "UserId";
        /// <summary>Имя столбца со сроком действия токена</summary>
        public const string ExpireDate = "ExpireDate";
      }
    }
  }
}
