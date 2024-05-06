// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.UserGroupActions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Действия для объекта "Группа пользователей"</summary>
  public class UserGroupActions : DefaultEntityActions
  {
    /// <summary>Редактирование</summary>
    [DisplayName("SR.M('Редактирование')")]
    [Uid("9b1a90a6-b841-43ae-a5b3-5ddc2fce4a8b")]
    public const string Edit = "9b1a90a6-b841-43ae-a5b3-5ddc2fce4a8b";
    private static Guid _editGuid;
    internal static UserGroupActions UJUsddQkGxOw7MaM3qv;

    /// <summary>ctor</summary>
    protected UserGroupActions()
    {
      UserGroupActions.AZIxBYQx2qnq8x7rbM9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Редактирование</summary>
    public static Guid EditGuid => UserGroupActions._editGuid;

    static UserGroupActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserGroupActions._editGuid = new Guid((string) UserGroupActions.EDFtUfQClvPqlo3q84O(552500104 ^ 552531402));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
            continue;
          case 2:
            UserGroupActions.AZIxBYQx2qnq8x7rbM9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void AZIxBYQx2qnq8x7rbM9() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool Xu91ILQDCb0Sv16GUs1() => UserGroupActions.UJUsddQkGxOw7MaM3qv == null;

    internal static UserGroupActions CnSdhXQaxFHnqUf2Ld0() => UserGroupActions.UJUsddQkGxOw7MaM3qv;

    internal static object EDFtUfQClvPqlo3q84O(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
