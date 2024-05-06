// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.ExternalMembershipInstancesSettingsModule
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>
  /// Модуль настроек внешних модулей авторизации IExternalMembershipModule
  /// </summary>
  [Component]
  internal class ExternalMembershipInstancesSettingsModule : 
    GlobalSettingsModuleBase<ExternalMembershipInstancesSettings>
  {
    public static Guid UID;
    private static ExternalMembershipInstancesSettingsModule n7NVW5HT3I1BKh4lMlr;

    public override string ModuleNamespace => (string) ExternalMembershipInstancesSettingsModule.GFRCPFHq8U2Nh5y2qXf(-340788466 ^ -340796614);

    public override Guid ModuleGuid => ExternalMembershipInstancesSettingsModule.UID;

    /// <summary>Название модуля</summary>
    public override string ModuleName => (string) ExternalMembershipInstancesSettingsModule.cNe3k9HgeYs7Sejqpgr(ExternalMembershipInstancesSettingsModule.GFRCPFHq8U2Nh5y2qXf(1053060681 ^ 1053127865));

    public ExternalMembershipInstancesSettingsModule()
    {
      ExternalMembershipInstancesSettingsModule.iuPtQ5HJ5rqya0FwQgA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExternalMembershipInstancesSettingsModule()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExternalMembershipInstancesSettingsModule.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617026523 ^ 616958195));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 0 : 0;
            continue;
          case 2:
            ExternalMembershipInstancesSettingsModule.iuPtQ5HJ5rqya0FwQgA();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object GFRCPFHq8U2Nh5y2qXf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CyxDPyHFZMmhj9dDWTV() => ExternalMembershipInstancesSettingsModule.n7NVW5HT3I1BKh4lMlr == null;

    internal static ExternalMembershipInstancesSettingsModule IP5HUQHvnVb15t4Dg4s() => ExternalMembershipInstancesSettingsModule.n7NVW5HT3I1BKh4lMlr;

    internal static object cNe3k9HgeYs7Sejqpgr([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void iuPtQ5HJ5rqya0FwQgA() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
