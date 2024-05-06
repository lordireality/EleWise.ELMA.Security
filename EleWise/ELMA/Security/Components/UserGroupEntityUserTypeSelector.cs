// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.UserGroupEntityUserTypeSelector
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Выбор системных групп пользователей</summary>
  [Component(Order = 50)]
  public class UserGroupEntityUserTypeSelector : BaseEntityUserTypeSelector
  {
    public const string PREFIX = "UserGroup";
    internal static UserGroupEntityUserTypeSelector JUkynKzv6dBZfD1xluM;

    public override Type EntityType => InterfaceActivator.TypeOf<IUserGroup>();

    public override string Prefix => (string) UserGroupEntityUserTypeSelector.jgki4DzJ21LBih0S04M(617026523 ^ 617060013);

    public override string DisplayName => (string) UserGroupEntityUserTypeSelector.KKydFqzIxX7BBDydvPt((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55935190));

    public override List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value) => UserGroupManager.Instance.GetUsersByGroup(BaseEntityUserTypeSelector.GetObjectId(this.GetFullPrefix(), value)).Select<long, EleWise.ELMA.Security.Models.IUser>((Func<long, EleWise.ELMA.Security.Models.IUser>) (u => ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) UserGroupEntityUserTypeSelector.\u003C\u003Ec.q4hFeYwfuRxBM8gGyyWU()).Load(u))).ToList<EleWise.ELMA.Security.Models.IUser>();

    public UserGroupEntityUserTypeSelector()
    {
      UserGroupEntityUserTypeSelector.IVMM4qzeGH1rCC9mKuY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jgki4DzJ21LBih0S04M(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool UiApI4zqBD7okJ8PXiu() => UserGroupEntityUserTypeSelector.JUkynKzv6dBZfD1xluM == null;

    internal static UserGroupEntityUserTypeSelector sUxKuczgV11y9BUqpNC() => UserGroupEntityUserTypeSelector.JUkynKzv6dBZfD1xluM;

    internal static object KKydFqzIxX7BBDydvPt([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void IVMM4qzeGH1rCC9mKuY() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
