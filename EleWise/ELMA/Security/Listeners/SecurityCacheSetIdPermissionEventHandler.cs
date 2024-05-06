// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.SecurityCacheSetIdPermissionEventHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Events;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  [Component]
  internal class SecurityCacheSetIdPermissionEventHandler : 
    ISecurityCacheSetIdEventHandler,
    IEventHandler
  {
    internal static SecurityCacheSetIdPermissionEventHandler IylTKKAAHNBYvR6rB65;

    public SecurityService SecurityService
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
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

    public void PostCacheSet(SecurityCacheSetIdEventArgs args)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_9;
          case 1:
            goto label_5;
          case 2:
            if (this.SecurityService == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 1 : 1;
              continue;
            }
            if (!SecurityCacheSetIdPermissionEventHandler.pgC23EAWuaOQ3jKPCbE((object) args))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 5 : 4;
              continue;
            }
            goto case 4;
          case 3:
            goto label_6;
          case 4:
            SecurityCacheSetIdPermissionEventHandler.vwZ2GxArtYG4cg7dVpC((object) this.SecurityService);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 0 : 0;
            continue;
          case 5:
            args.GroupAddUsers.Concat<Tuple<long, long>>(args.GroupRemoveUsers).Concat<Tuple<long, long>>(args.OrganizationItemAddUsers).Concat<Tuple<long, long>>(args.OrganizationItemRemoveUsers).Select<Tuple<long, long>, long>((Func<Tuple<long, long>, long>) (d => d.Item2)).ForEach<long>(new Action<long>(this.SecurityService.ResetPermissions4UserCache));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 3 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_9:
      return;
label_5:
      return;
label_6:
      return;
label_2:;
    }

    public SecurityCacheSetIdPermissionEventHandler()
    {
      SecurityCacheSetIdPermissionEventHandler.goXq3EASgkWZZK113jx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VpjGQmAsDjaJdC8pJbi() => SecurityCacheSetIdPermissionEventHandler.IylTKKAAHNBYvR6rB65 == null;

    internal static SecurityCacheSetIdPermissionEventHandler B5yxxJA7IPTAHAOdY2K() => SecurityCacheSetIdPermissionEventHandler.IylTKKAAHNBYvR6rB65;

    internal static bool pgC23EAWuaOQ3jKPCbE([In] object obj0) => ((SecurityCacheSetIdEventArgs) obj0).FullUpdate;

    internal static void vwZ2GxArtYG4cg7dVpC([In] object obj0) => ((SecurityService) obj0).ResetPermissionsCache();

    internal static void goXq3EASgkWZZK113jx() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
