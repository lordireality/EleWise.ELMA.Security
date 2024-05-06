// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.Settings.ComplexExecutorSettings
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Types.Settings
{
  /// <summary>
  /// Настройки выбора для котрола выбора пользователей и групп
  /// </summary>
  public class ComplexExecutorSettings : TypeSettings
  {
    internal static ComplexExecutorSettings UlFcJtxDxDsOYbalAFB;

    /// <summary>Настройки пользователей</summary>
    public EntityUserSettings UserSettings
    {
      get => this.\u003CUserSettings\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUserSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Настрйки групп</summary>
    public EntitySettings GroupSettings
    {
      get => this.\u003CGroupSettings\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CGroupSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public ComplexExecutorSettings()
    {
      ComplexExecutorSettings.ypIM6ixCmsEN3YrCfWv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mtkkI6xa5f3EyELGZia() => ComplexExecutorSettings.UlFcJtxDxDsOYbalAFB == null;

    internal static ComplexExecutorSettings PTuPdgxxCNssGxcaacZ() => ComplexExecutorSettings.UlFcJtxDxDsOYbalAFB;

    internal static void ypIM6ixCmsEN3YrCfWv() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
