// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.AdminPermissionsDelegate
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Проверка наличия права на админские привилегии</summary>
  [Component]
  internal class AdminPermissionsDelegate : IPermissionsDelegate
  {
    internal static AdminPermissionsDelegate n9fGW8bdyLEBxuYtZwX;

    public ISecurityService SecurityService
    {
      get => this.\u003CSecurityService\u003Ek__BackingField;
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
              this.\u003CSecurityService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 0;
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

    public bool CanCheckPermissions(Type type, Permission permission)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (permission.AdminPermissions != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          case 3:
            if (!(permission != (Permission) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 2 : 1;
              continue;
            }
            goto case 1;
          default:
            goto label_4;
        }
      }
label_4:
      return AdminPermissionsDelegate.xYQOp6bXxiqSriBTid8((object) permission).Length != 0;
label_5:
      return false;
    }

    public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
    {
      int num1 = 1;
      bool? orDefault;
      string name;
      AdminPermissionsDelegate permissionsDelegate;
      IUser user1;
      object target1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 0 : 0;
            continue;
          case 2:
            user1 = user;
            num1 = 12;
            continue;
          case 3:
            goto label_2;
          case 4:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 1 : 5;
            continue;
          case 5:
            goto label_6;
          case 6:
            if (!orDefault.HasValue)
            {
              num1 = 4;
              continue;
            }
            goto label_3;
          case 7:
            name = (string) AdminPermissionsDelegate.DtQkVEbhJIur1j2CfZM((object) new object[6]
            {
              AdminPermissionsDelegate.BTSIVTb9GCyJ5y4Q1TG(1212037053 ^ -1727812018 ^ -784494613),
              user1 != null ? user1.GetId() : AdminPermissionsDelegate.BTSIVTb9GCyJ5y4Q1TG(-1958138283 - -279956781 ^ -1678184984),
              AdminPermissionsDelegate.BTSIVTb9GCyJ5y4Q1TG(978908330 << 6 ^ -1774371594),
              !AdminPermissionsDelegate.PnOcOCb1yibGtWFav82((object) permission, (object) null) ? AdminPermissionsDelegate.BTSIVTb9GCyJ5y4Q1TG(~248518394 ^ -248512657) : (object) AdminPermissionsDelegate.DbsXbTbMJH2Abs3Ea70((object) permission).ToString(),
              AdminPermissionsDelegate.BTSIVTb9GCyJ5y4Q1TG(150349507 - 521039768 ^ -370695843),
              target1 != null ? (object) target1.GetHashCode().ToString() : AdminPermissionsDelegate.BTSIVTb9GCyJ5y4Q1TG(44166125 ^ 44170631)
            });
            num1 = 9;
            continue;
          case 8:
            goto label_16;
          case 9:
            orDefault = ContextVars.GetOrDefault<bool?>(name);
            num1 = 6;
            continue;
          case 10:
            if (!skipAdmin)
            {
              if (this.CanCheckPermissions((Type) null, permission))
              {
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 7 : 4;
                continue;
              }
              goto label_25;
            }
            else
            {
              num1 = 8;
              continue;
            }
          case 11:
            goto label_25;
          case 12:
            target1 = target;
            num1 = 10;
            continue;
          case 13:
            goto label_3;
          default:
            permissionsDelegate = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      bool flag;
      return flag;
label_3:
      return orDefault.Value;
label_6:
      try
      {
        ContextVars.Set<bool?>(name, new bool?(false));
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            default:
              // ISSUE: reference to a compiler-generated method
              flag = ((IEnumerable<Permission>) AdminPermissionsDelegate.xYQOp6bXxiqSriBTid8((object) permission)).Any<Permission>((Func<Permission, bool>) (p => AdminPermissionsDelegate.\u003C\u003Ec__DisplayClass5_0.gjZo6twRdwwlnAWXkOWR((object) permissionsDelegate.SecurityService, (object) user1, (object) p, target1, false)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        ContextVars.Set<bool?>(name, new bool?());
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_16:
      return false;
label_25:
      return false;
    }

    public AdminPermissionsDelegate()
    {
      AdminPermissionsDelegate.GiOpdAbB7niq0j7vb03();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool nDEe3rbEhUCrKlK5rMC() => AdminPermissionsDelegate.n9fGW8bdyLEBxuYtZwX == null;

    internal static AdminPermissionsDelegate lvCbS6bGWoKwjPvh3Sk() => AdminPermissionsDelegate.n9fGW8bdyLEBxuYtZwX;

    internal static object xYQOp6bXxiqSriBTid8([In] object obj0) => (object) ((Permission) obj0).AdminPermissions;

    internal static object BTSIVTb9GCyJ5y4Q1TG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool PnOcOCb1yibGtWFav82([In] object obj0, [In] object obj1) => (Permission) obj0 != (Permission) obj1;

    internal static Guid DbsXbTbMJH2Abs3Ea70([In] object obj0) => ((Permission) obj0).Id;

    internal static object DtQkVEbhJIur1j2CfZM([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static void GiOpdAbB7niq0j7vb03() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
