// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ExclusionEntityNullifierSecurity
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Extensions
{
  [Component]
  internal class ExclusionEntityNullifierSecurity : IExclusionEntityNullifier
  {
    internal static ExclusionEntityNullifierSecurity M0Q3Trqp8BJtauBu1jt;

    public List<Guid> SetExclusion() => new List<Guid>()
    {
      InterfaceActivator.UID<IUserPublicKeyToken>(),
      InterfaceActivator.UID<IUserGroup>(),
      InterfaceActivator.UID<IOrganizationItem>(),
      InterfaceActivator.UID<IPersonalGroup>(),
      InterfaceActivator.UID<IUserCertificate>(),
      InterfaceActivator.UID<IOrganizationModel>(),
      InterfaceActivator.UID<EleWise.ELMA.Security.IUser>(),
      InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(),
      InterfaceActivator.UID<IAssignedRoleStereotype>()
    };

    public ExclusionEntityNullifierSecurity()
    {
      ExclusionEntityNullifierSecurity.N1nTLHqFcwpPpda8ki5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void N1nTLHqFcwpPpda8ki5() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool bR4H8dqOTlRlTXoAIRF() => ExclusionEntityNullifierSecurity.M0Q3Trqp8BJtauBu1jt == null;

    internal static ExclusionEntityNullifierSecurity w1qHHPqTUXdgJgmKpbo() => ExclusionEntityNullifierSecurity.M0Q3Trqp8BJtauBu1jt;
  }
}
