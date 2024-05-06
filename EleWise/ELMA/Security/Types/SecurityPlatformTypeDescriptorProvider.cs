// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.SecurityPlatformTypeDescriptorProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Types
{
  [Component]
  internal class SecurityPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
  {
    private static SecurityPlatformTypeDescriptorProvider fHP0gNxtqiCE5dRWCwY;

    public override IEnumerable<ITypeDescriptor> GetTypeDescriptors() => (IEnumerable<ITypeDescriptor>) new ITypeDescriptor[1]
    {
      this.CreateEntityDescriptor<EleWise.ELMA.Security.Models.IUser>()
    };

    public SecurityPlatformTypeDescriptorProvider()
    {
      SecurityPlatformTypeDescriptorProvider.zughf3xkd9lxyS6sOlL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void zughf3xkd9lxyS6sOlL() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool reXgK5xmfdDuYCSNBkC() => SecurityPlatformTypeDescriptorProvider.fHP0gNxtqiCE5dRWCwY == null;

    internal static SecurityPlatformTypeDescriptorProvider sI0L1sx6u4uSHgav4aB() => SecurityPlatformTypeDescriptorProvider.fHP0gNxtqiCE5dRWCwY;
  }
}
