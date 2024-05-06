// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.API.Models.SubordinateUsersResponse
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Security.API.Models
{
  /// <summary>Ответ на запрос подчиненных пользователей</summary>
  [DataContract(Name = "SubordinateUsers")]
  [Serializable]
  public class SubordinateUsersResponse
  {
    internal static SubordinateUsersResponse XROWBEIb1U07tHE1t9e;

    [DataMember]
    public long[] Ids
    {
      get => this.\u003CIds\u003Ek__BackingField;
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
              this.\u003CIds\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
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

    public SubordinateUsersResponse()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dx0rBwIKn4JvIYc27J1() => SubordinateUsersResponse.XROWBEIb1U07tHE1t9e == null;

    internal static SubordinateUsersResponse khfVsBIUp65mhLF8Gsv() => SubordinateUsersResponse.XROWBEIb1U07tHE1t9e;
  }
}
