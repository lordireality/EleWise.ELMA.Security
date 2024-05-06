// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.DefaultApplicationValidator
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services.API
{
  internal abstract class DefaultApplicationValidator : IPublicApplicationAuthValidator
  {
    internal static DefaultApplicationValidator OWTp1DVkcknYGbPHheo;

    public virtual string AppToken => PublicApplicationService.DefaultApplications.First<PublicApplicationService.DefaultSystemApplication>((Func<PublicApplicationService.DefaultSystemApplication, bool>) (a => DefaultApplicationValidator.bDhIkaVidtx5ZkH5fcL(DefaultApplicationValidator.iPxsO7VCNfgHkBQWtmn((object) a), this.AppUid))).DefaultToken;

    /// <summary>Идентификатор приложения</summary>
    protected abstract Guid AppUid { get; }

    public virtual bool Validate(IUser user) => true;

    protected DefaultApplicationValidator()
    {
      DefaultApplicationValidator.SeRp5pVxRBqAcZsYc7Y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AX0L6SVDE1LUmdgSYC3() => DefaultApplicationValidator.OWTp1DVkcknYGbPHheo == null;

    internal static DefaultApplicationValidator TDsm5wVaMyHrRA1pANQ() => DefaultApplicationValidator.OWTp1DVkcknYGbPHheo;

    internal static void SeRp5pVxRBqAcZsYc7Y() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static Guid iPxsO7VCNfgHkBQWtmn([In] object obj0) => ((PublicApplicationService.DefaultSystemApplication) obj0).Uid;

    internal static bool bDhIkaVidtx5ZkH5fcL([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
