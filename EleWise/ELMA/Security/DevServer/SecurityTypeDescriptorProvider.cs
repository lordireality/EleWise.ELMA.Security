// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DevServer.SecurityTypeDescriptorProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.DevServer.TypeDescriptors;
using EleWise.ELMA.Security.Types;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.DevServer
{
  /// <inheritdoc />
  internal sealed class SecurityTypeDescriptorProvider : ITypeDescriptorProvider
  {
    private static SecurityTypeDescriptorProvider f0rnWxI6h4t0XZm7uZg;

    /// <inheritdoc />
    public IEnumerable<Type> GetTypeDescriptors() => (IEnumerable<Type>) new Type[4]
    {
      typeof (EntityUserDescriptor),
      typeof (OrganizationDiagramTypeDescriptor),
      typeof (OrganizationSubDiagramTypeDescriptor),
      typeof (OrganizationItemDescriptor)
    };

    public SecurityTypeDescriptorProvider()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QL6qZfIkgEwRrfDJKTY() => SecurityTypeDescriptorProvider.f0rnWxI6h4t0XZm7uZg == null;

    internal static SecurityTypeDescriptorProvider EB38KRID1TC7ffnUtMp() => SecurityTypeDescriptorProvider.f0rnWxI6h4t0XZm7uZg;
  }
}
