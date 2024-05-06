// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Models.UserGroupDTOComparer
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.DTO.Models
{
  public class UserGroupDTOComparer : IEqualityComparer<UserGroupDTO>
  {
    private static UserGroupDTOComparer Yn4eYIizfEgEJtKWb9f;

    public bool Equals(UserGroupDTO x, UserGroupDTO y)
    {
      int num = 4;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (y != null)
            {
              guid = UserGroupDTOComparer.yxuBjq3bynrviCwbCdC((object) x);
              num = 5;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (x != y)
            {
              if (x == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 0;
                continue;
              }
              goto case 2;
            }
            else
            {
              num = 3;
              continue;
            }
          case 5:
            goto label_7;
          default:
            goto label_8;
        }
      }
label_2:
      return true;
label_7:
      return guid.Equals(UserGroupDTOComparer.yxuBjq3bynrviCwbCdC((object) y));
label_8:
      return false;
    }

    public int GetHashCode(UserGroupDTO obj)
    {
      int num = 1;
      Guid uid;
      while (true)
      {
        switch (num)
        {
          case 1:
            uid = obj.Uid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return uid.GetHashCode();
    }

    public UserGroupDTOComparer()
    {
      UserGroupDTOComparer.KSWP1E3KWVgQgc3EtS3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid yxuBjq3bynrviCwbCdC([In] object obj0) => ((UserGroupDTO) obj0).Uid;

    internal static bool NZq3673uRly4njiqc1D() => UserGroupDTOComparer.Yn4eYIizfEgEJtKWb9f == null;

    internal static UserGroupDTOComparer lEhyyV3wqZNyDpYIyy1() => UserGroupDTOComparer.Yn4eYIizfEgEJtKWb9f;

    internal static void KSWP1E3KWVgQgc3EtS3() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
