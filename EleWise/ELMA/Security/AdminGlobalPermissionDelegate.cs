// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.AdminGlobalPermissionDelegate
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security
{
  [Component]
  internal class AdminGlobalPermissionDelegate : IGlobalPermissionsDelegate
  {
    private static AdminGlobalPermissionDelegate COPG9HbYdSWSBxsZ6vG;

    public ISecurityService SecurityService => Locator.GetService<ISecurityService>();

    public bool HasPermission(
      IUser user,
      Permission permission,
      IEnumerable<Guid> userPermissionUids)
    {
      // ISSUE: reference to a compiler-generated method
      return !(permission == (Permission) null) && permission.AdminPermissions != null && permission.AdminPermissions.Length != 0 && ((IEnumerable<Permission>) permission.AdminPermissions).Any<Permission>((Func<Permission, bool>) (p => AdminGlobalPermissionDelegate.\u003C\u003Ec__DisplayClass2_0.MbbPekwRruiZvWU3yQw1((object) this.SecurityService, (object) user, (object) p)));
    }

    public AdminGlobalPermissionDelegate()
    {
      AdminGlobalPermissionDelegate.Bb59f5blfWA3edhlKIk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void Bb59f5blfWA3edhlKIk() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool DfeuiFby4aZv5eAQpeQ() => AdminGlobalPermissionDelegate.COPG9HbYdSWSBxsZ6vG == null;

    internal static AdminGlobalPermissionDelegate umH23LbVNl2kNYSAV3Z() => AdminGlobalPermissionDelegate.COPG9HbYdSWSBxsZ6vG;
  }
}
