// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CryptoProviderSettingsModuleBase`2
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Базовый модуль настроек криптопровайдера</summary>
  /// <typeparam name="TSettings"></typeparam>
  /// <typeparam name="TProvider"></typeparam>
  public abstract class CryptoProviderSettingsModuleBase<TSettings, TProvider> : 
    GlobalSettingsModuleBase<TSettings>
    where TSettings : CryptoProviderSettingsBase, new()
    where TProvider : CryptoProviderBase
  {
    private static object QHefSrHds18daPGayuL;

    /// <summary>Криптопровайдер</summary>
    public TProvider Provider => Locator.GetService<TProvider>();

    protected CryptoProviderSettingsModuleBase()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xUJxyUHE79e43g2mRxb() => CryptoProviderSettingsModuleBase<TSettings, TProvider>.QHefSrHds18daPGayuL == null;

    internal static object Gsac2yHGwYaE8Whn6Tj() => CryptoProviderSettingsModuleBase<TSettings, TProvider>.QHefSrHds18daPGayuL;
  }
}
