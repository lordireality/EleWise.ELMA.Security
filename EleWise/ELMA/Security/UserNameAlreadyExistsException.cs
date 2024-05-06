// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.UserNameAlreadyExistsException
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>Ошибка "Пользователь с таким логином уже существует"</summary>
  [Serializable]
  public sealed class UserNameAlreadyExistsException : Exception
  {
    private static UserNameAlreadyExistsException vTy5RBDI6KY7mP4TBOV;

    public string UserName
    {
      get => this.\u003CUserName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUserName\u003Ek__BackingField = value;
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

    /// <summary>Список Id пользователей с дублирующимся логином</summary>
    public List<IUser> Users { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public UserNameAlreadyExistsException(string login)
    {
      UserNameAlreadyExistsException.FPGqcNDLY3A78wKbG84();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) UserNameAlreadyExistsException.kLdho3D2KEBrUS5xcTV(-2008710664 - -232311158 ^ -1776415958), (object) login));
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Users = new List<IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 1 : 1;
            continue;
          default:
            this.UserName = login;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity">Проверяемый пользователь</param>
    /// <param name="users">Список пользователей с таким же логином</param>
    public UserNameAlreadyExistsException(IUser entity, List<IUser> users)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816108091 ^ -816091775), (object) entity.UserName));
      this.UserName = entity.UserName;
      this.Users = users;
    }

    internal static bool kiMVbBDe3S4xIc8AFSb() => UserNameAlreadyExistsException.vTy5RBDI6KY7mP4TBOV == null;

    internal static UserNameAlreadyExistsException zIwv25DnKSIQDbNt4Jv() => UserNameAlreadyExistsException.vTy5RBDI6KY7mP4TBOV;

    internal static void FPGqcNDLY3A78wKbG84() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object kLdho3D2KEBrUS5xcTV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
