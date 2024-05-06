// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CapiComAuthSettingsModule
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Модуль настроек CAPICOM провайдера</summary>
  [Component]
  public class CapiComAuthSettingsModule : 
    CryptoProviderSettingsModuleBase<CryptoProviderSettingsBase, CapiComAuthCryptoProvider>
  {
    private static CapiComAuthSettingsModule we2NdbHRvcrt1KSiryR;

    public override Guid ModuleGuid => new Guid((string) CapiComAuthSettingsModule.uliXrYHm2v0VWTEV3Nd(-1115268484 ^ -1115207162));

    public override string ModuleName => EleWise.ELMA.SR.T((string) CapiComAuthSettingsModule.uliXrYHm2v0VWTEV3Nd(658384612 ^ 658456410));

    public CapiComAuthSettingsModule()
    {
      CapiComAuthSettingsModule.DHF5qVH6uWCjmes0R5E();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object uliXrYHm2v0VWTEV3Nd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool VYZkweHoTBt2PJeScPy() => CapiComAuthSettingsModule.we2NdbHRvcrt1KSiryR == null;

    internal static CapiComAuthSettingsModule wZNKUsHtqJBlhRQECEA() => CapiComAuthSettingsModule.we2NdbHRvcrt1KSiryR;

    internal static void DHF5qVH6uWCjmes0R5E() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
