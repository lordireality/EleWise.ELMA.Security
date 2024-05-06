// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.SecurityPrivilegeUsersAccessGroup
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security
{
  [Component]
  public class SecurityPrivilegeUsersAccessGroup : IPrivilegeModuleAccessGroup
  {
    private static SecurityPrivilegeUsersAccessGroup tWoRKqDkqchFew71yn5;

    public Guid ModuleUid => __ModuleInfo.UID;

    public Guid UserGroupUid => SecurityConstants.PrivilegeUsersGroupUid;

    public SecurityPrivilegeUsersAccessGroup()
    {
      SecurityPrivilegeUsersAccessGroup.jCJUn6DxhEBTVleVk9L();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void jCJUn6DxhEBTVleVk9L() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool zDvSuyDD7hIVRYVm9T0() => SecurityPrivilegeUsersAccessGroup.tWoRKqDkqchFew71yn5 == null;

    internal static SecurityPrivilegeUsersAccessGroup zXjGLBDaph33Qc5TDU2() => SecurityPrivilegeUsersAccessGroup.tWoRKqDkqchFew71yn5;
  }
}
