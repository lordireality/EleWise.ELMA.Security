// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.UserEntityUserTypeSelector
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Выбор пользователей</summary>
  [Component(Order = 10)]
  public class UserEntityUserTypeSelector : BaseEntityUserTypeSelector
  {
    public const string PREFIX = "User";
    internal static UserEntityUserTypeSelector Ai5wEkzBtUjsultooEV;

    public override Type EntityType => InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>();

    public override string Prefix => (string) UserEntityUserTypeSelector.xEKa0QzT70Kv8CBLlJ3(-1640694811 << 2 ^ 2027154012);

    public override string DisplayName => (string) UserEntityUserTypeSelector.V1T4UszFAn3MvwCdl3K((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696748681));

    public override List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value) => new List<EleWise.ELMA.Security.Models.IUser>()
    {
      (EleWise.ELMA.Security.Models.IUser) this.GetEntity(value)
    };

    public UserEntityUserTypeSelector()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object xEKa0QzT70Kv8CBLlJ3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool cN2EdVzphbVV2BrZwxM() => UserEntityUserTypeSelector.Ai5wEkzBtUjsultooEV == null;

    internal static UserEntityUserTypeSelector wEE2VPzOqnDtdAp803n() => UserEntityUserTypeSelector.Ai5wEkzBtUjsultooEV;

    internal static object V1T4UszFAn3MvwCdl3K([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
