// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.SecurityImportExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>Расширение импорта конфигурации для объектов Security</summary>
  [Component]
  public class SecurityImportExtension : ConfigImportExtension
  {
    private static SecurityImportExtension onDVNOee080IqQjkJDe;

    public override void OnPreStartImport(PreStartImportParameters parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SecurityImportExtension.qLOfBke2BEox20tUdKR((object) this, (object) parameters);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Locator.GetServiceNotNull<RunWithElevatedPrivilegiesService>().Turned = true;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    public SecurityImportExtension()
    {
      SecurityImportExtension.D2TMnPeHo9lsv3jVBgc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void qLOfBke2BEox20tUdKR([In] object obj0, [In] object obj1) => __nonvirtual (((ConfigImportExtension) obj0).OnPreStartImport((PreStartImportParameters) obj1));

    internal static bool EAiQygenErB884heN1h() => SecurityImportExtension.onDVNOee080IqQjkJDe == null;

    internal static SecurityImportExtension LJ23beeLuoqu3T9Swi1() => SecurityImportExtension.onDVNOee080IqQjkJDe;

    internal static void D2TMnPeHo9lsv3jVBgc() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
