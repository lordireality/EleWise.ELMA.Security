// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ProfilePermissionResolver
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Services
{
  [Component]
  internal class ProfilePermissionResolver : IProfilePermission
  {
    public ProfilePermissionResolver(
      IEnumerable<IPermissionProvider> permissionProviders)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.ProfilePermissionDescriptors = (IEnumerable<ProfilePermissionDescriptor>) permissionProviders.SelectMany<IPermissionProvider, Permission>((Func<IPermissionProvider, IEnumerable<Permission>>) (p => p.GetPermissions())).Where<Permission>((Func<Permission, bool>) (p => ProfilePermissionResolver.\u003C\u003Ec.Ql3ohpwNLlYeyIT4qC6d(ProfilePermissionResolver.\u003C\u003Ec.amwJlAwNnpJt2JNP9vQ2((object) p), (object) null))).Select<Permission, ProfilePermissionDescriptor>((Func<Permission, ProfilePermissionDescriptor>) (p => new ProfilePermissionDescriptor((Permission) ProfilePermissionResolver.\u003C\u003Ec.amwJlAwNnpJt2JNP9vQ2((object) p), p))).ToArray<ProfilePermissionDescriptor>();
    }

    public IEnumerable<ProfilePermissionDescriptor> ProfilePermissionDescriptors { get; private set; }
  }
}
