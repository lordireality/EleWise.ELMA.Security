﻿// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ModuleContainerEvents
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Extensions
{
  [Component]
  public class ModuleContainerEvents : IModuleContainerEvents
  {
    internal static ModuleContainerEvents XH8tyBgT8IRvJ0qo62S;

    public void Activated() => ModuleContainerEvents.pWn8Kbggsth9HThgOx8(ModuleContainerEvents.KaExcugqnyI6uZdMReL());

    public void Terminating()
    {
    }

    public ModuleContainerEvents()
    {
      ModuleContainerEvents.vWxb1ugJGVLmMBnIG7d();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object KaExcugqnyI6uZdMReL() => (object) UserManager.Instance;

    internal static void pWn8Kbggsth9HThgOx8([In] object obj0) => ((UserManager) obj0).NotifyChangeUserNames();

    internal static void vWxb1ugJGVLmMBnIG7d() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool fnpZqngFwQtVee8kYTP() => ModuleContainerEvents.XH8tyBgT8IRvJ0qo62S == null;

    internal static ModuleContainerEvents HCn5jNgvQGkEhwdH28n() => ModuleContainerEvents.XH8tyBgT8IRvJ0qo62S;
  }
}
