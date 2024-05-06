// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InternalSecurityService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  internal class InternalSecurityService : 
    ComplexLicensedUnit<IInternalSecurityService>,
    IInternalSecurityService,
    ILicensedUnit,
    IWorkplaceLicenseInfoOwner,
    IConcurrentLicenseInfoOwner
  {
    internal static InternalSecurityService YMv3IyRs5hAaPhYBCd5;

    public InternalSecurityService()
    {
      InternalSecurityService.G46j22Rr6miJhFn726h();
      // ISSUE: explicit constructor call
      base.\u002Ector((IInternalSecurityService) new InternalSecurityServiceExpress(), (IInternalSecurityService) new InternalSecurityServiceStandart(), (IInternalSecurityService) new InternalSecurityServiceOracle());
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => InternalSecurityService.xMNy2URS73KXV77kubk((object) this.ActiveUnit);

    uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => InternalSecurityService.pLs70URYVFObJt9DSp8((object) this.ActiveUnit);

    void IInternalSecurityService.CheckUserToAuthenticate(
      [NotNull] EleWise.ELMA.Security.Models.IUser user,
      Func<bool> isAlreadyLoggedFunc,
      Func<int, bool> isCurrentPrivilegeFunc,
      Func<int> otherUsersCountFunc)
    {
      this.ActiveUnit.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
    }

    bool IInternalSecurityService.CanCreateNewUser() => InternalSecurityService.O1MlvtRyU5RvhRmjj6M((object) this.ActiveUnit);

    internal static void G46j22Rr6miJhFn726h() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool zxIwfoR7VPiw84XyqFY() => InternalSecurityService.YMv3IyRs5hAaPhYBCd5 == null;

    internal static InternalSecurityService aavymwRWXNk8ttaPQhQ() => InternalSecurityService.YMv3IyRs5hAaPhYBCd5;

    internal static uint xMNy2URS73KXV77kubk([In] object obj0) => ((IWorkplaceLicenseInfoOwner) obj0).UsedLicenseCount;

    internal static uint pLs70URYVFObJt9DSp8([In] object obj0) => ((IConcurrentLicenseInfoOwner) obj0).UsedPrivilegeCount;

    internal static bool O1MlvtRyU5RvhRmjj6M([In] object obj0) => ((IInternalSecurityService) obj0).CanCreateNewUser();
  }
}
