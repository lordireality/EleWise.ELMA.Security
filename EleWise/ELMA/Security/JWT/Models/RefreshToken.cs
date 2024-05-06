// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Models.RefreshToken
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.JWT.Models
{
  /// <summary>Токен авторизации</summary>
  public class RefreshToken
  {
    private static RefreshToken aZ2AuBqYDrtl44a2BRm;

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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 0 : 0;
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

    /// <summary>Токен приложения</summary>
    public virtual string ApplicationToken
    {
      get => this.\u003CApplicationToken\u003Ek__BackingField;
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
              this.\u003CApplicationToken\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
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

    public RefreshToken()
    {
      RefreshToken.yI2HumqlXUFG1KZQHOZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool aJxIXlqyFdnwSRX3fUt() => RefreshToken.aZ2AuBqYDrtl44a2BRm == null;

    internal static RefreshToken sgchqMqVQ4y5ZfSIrEJ() => RefreshToken.aZ2AuBqYDrtl44a2BRm;

    internal static void yI2HumqlXUFG1KZQHOZ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    /// <summary>Названия для структуры данных</summary>
    internal static class Tables
    {
      /// <summary>Имя таблицы</summary>
      public const string TableName = "Sys_RefreshToken";

      /// <summary>Имена столбцов</summary>
      public static class Fields
      {
        /// <summary>Имя столбца идентификатора</summary>
        public const string Uid = "Uid";
        /// <summary>Имя столбца с идентификатором пользователя</summary>
        public const string UserId = "UserId";
        /// <summary>Имя столбца с токеном приложения</summary>
        public const string ApplicationToken = "ApplicationToken";
        /// <summary>Имя столбца со сроком действия токена</summary>
        public const string ExpireDate = "ExpireDate";
      }
    }
  }
}
