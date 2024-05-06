// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.UserTrustedDevices
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Доверенные устройства пользователя</summary>
  [Serializable]
  public class UserTrustedDevices
  {
    internal static UserTrustedDevices NrGCKOce8dBMyE4dZGL;

    public UserTrustedDevices()
    {
      UserTrustedDevices.VcEFZGc2ScG5vQGOWHH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Tokens = new List<DeviceToken>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Вход только с доверенных устройств</summary>
    [DisplayName(typeof (UserTrustedDevices_SR), "TrustedLogonEnabled")]
    public bool LogonFromTrustedDevicesOnly
    {
      get => this.\u003CLogonFromTrustedDevicesOnly\u003Ek__BackingField;
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
              this.\u003CLogonFromTrustedDevicesOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 0 : 0;
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

    /// <summary>Токены доверенных устройств</summary>
    public List<DeviceToken> Tokens { get; set; }

    internal static void VcEFZGc2ScG5vQGOWHH() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool uN9R8jcnyvQ3eC8gyvp() => UserTrustedDevices.NrGCKOce8dBMyE4dZGL == null;

    internal static UserTrustedDevices krFhrhcLSeaXJr6Qm4u() => UserTrustedDevices.NrGCKOce8dBMyE4dZGL;
  }
}
