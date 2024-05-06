// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.PropertyPermissionsChangedEventArgs
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Services
{
  public class PropertyPermissionsChangedEventArgs : EventArgs
  {
    private static PropertyPermissionsChangedEventArgs D5HiKGSVj47lHRtc2yx;

    public PropertyPermissionsChangedEventArgs(Type modelType)
    {
      PropertyPermissionsChangedEventArgs.ABpAsdS4wIQVInMp4Y0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ModelType = modelType;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public Type ModelType
    {
      get => this.\u003CModelType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CModelType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 0 : 0;
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

    internal static void ABpAsdS4wIQVInMp4Y0() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool lEZXY6Sl6yLA3Z4ugHY() => PropertyPermissionsChangedEventArgs.D5HiKGSVj47lHRtc2yx == null;

    internal static PropertyPermissionsChangedEventArgs eaaj3SSfIK7LhEq36HB() => PropertyPermissionsChangedEventArgs.D5HiKGSVj47lHRtc2yx;
  }
}
