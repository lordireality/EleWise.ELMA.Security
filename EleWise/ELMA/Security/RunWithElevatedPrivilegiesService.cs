// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.RunWithElevatedPrivilegiesService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Сервис, влияющий на результат проверки прав в текущем контексте
  /// </summary>
  [Service]
  public class RunWithElevatedPrivilegiesService
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private static RunWithElevatedPrivilegiesService s6ajLSkgTy4c9oudfIr;

    public RunWithElevatedPrivilegiesService(
      IContextBoundVariableService contextBoundVariableService)
    {
      RunWithElevatedPrivilegiesService.c44p3dkeeA79yTlABpU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Включен ли сервис, т.е. будет ли производиться проверка прав в текущем контексте
    /// </summary>
    public bool Turned
    {
      get
      {
        bool flag;
        return this.contextBoundVariableService.TryGetValue<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1095474805 ^ 155418997 ^ 1208493394), out flag) & flag;
      }
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
              RunWithElevatedPrivilegiesService.QLdkjvkL3uchnHS2yyG((object) this.contextBoundVariableService, RunWithElevatedPrivilegiesService.LKbeCEknusqS5R60J9L(1185105284 ^ 1185120214), (object) value);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 0 : 0;
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

    internal static void c44p3dkeeA79yTlABpU() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool WFlSghkJKNDo2eGmHuM() => RunWithElevatedPrivilegiesService.s6ajLSkgTy4c9oudfIr == null;

    internal static RunWithElevatedPrivilegiesService CJjq1ZkIUNrf8AUdyIs() => RunWithElevatedPrivilegiesService.s6ajLSkgTy4c9oudfIr;

    internal static object LKbeCEknusqS5R60J9L(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void QLdkjvkL3uchnHS2yyG([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);
  }
}
