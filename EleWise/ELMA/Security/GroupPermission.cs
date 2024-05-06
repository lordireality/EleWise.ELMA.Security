// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.GroupPermission
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  public class GroupPermission
  {
    private static GroupPermission My1IJWmmqSQEiZyMgIU;

    public virtual IUserGroup Group
    {
      get => this.\u003CGroup\u003Ek__BackingField;
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
              this.\u003CGroup\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 0 : 0;
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

    public virtual Guid PermissionId
    {
      get => this.\u003CPermissionId\u003Ek__BackingField;
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
              this.\u003CPermissionId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
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

    public virtual bool Equals(GroupPermission other)
    {
      int num = 2;
      Guid permissionId;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this == other)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 3 : 3;
              continue;
            }
            if (object.Equals(GroupPermission.InMQoRmD00i9XUkS6x0((object) other), (object) this.Group))
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 2:
            if (other != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 1;
              continue;
            }
            goto label_5;
          case 3:
            goto label_8;
          case 4:
            permissionId = other.PermissionId;
            num = 5;
            continue;
          case 5:
            goto label_3;
          default:
            goto label_5;
        }
      }
label_3:
      return permissionId.Equals(this.PermissionId);
label_4:
      return false;
label_5:
      return false;
label_8:
      return true;
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          case 3:
            goto label_2;
          case 4:
            goto label_8;
          case 5:
            goto label_9;
          default:
            if (this != obj)
            {
              // ISSUE: type reference
              if (!GroupPermission.RXnOqUmxWTWsKxORKAr(obj.GetType(), GroupPermission.RIrSyqmah3Js5gpSl08(__typeref (GroupPermission))))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 4 : 5;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = 3;
              continue;
            }
        }
      }
label_2:
      return true;
label_5:
      return false;
label_8:
      return false;
label_9:
      return GroupPermission.klUjCBmCKTCb2PueYVN((object) this, (object) (GroupPermission) obj);
    }

    public override int GetHashCode()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.Group == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      int num2 = 0;
      goto label_6;
label_5:
      num2 = GroupPermission.InMQoRmD00i9XUkS6x0((object) this).GetHashCode();
label_6:
      return num2 * 397 ^ GroupPermission.E9WZABmiNkVveUQn8R0((object) this).GetHashCode();
    }

    public GroupPermission()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xGxSyqm6jOvQIb1QSpr() => GroupPermission.My1IJWmmqSQEiZyMgIU == null;

    internal static GroupPermission h7QZKSmkf5Runjjdsbi() => GroupPermission.My1IJWmmqSQEiZyMgIU;

    internal static object InMQoRmD00i9XUkS6x0([In] object obj0) => (object) ((GroupPermission) obj0).Group;

    internal static Type RIrSyqmah3Js5gpSl08([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool RXnOqUmxWTWsKxORKAr([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool klUjCBmCKTCb2PueYVN([In] object obj0, [In] object obj1) => ((GroupPermission) obj0).Equals((GroupPermission) obj1);

    internal static Guid E9WZABmiNkVveUQn8R0([In] object obj0) => ((GroupPermission) obj0).PermissionId;
  }
}
