// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AbsenceInitHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Кэширование "Отсутсвий" при запуске системы</summary>
  [Component]
  public class AbsenceInitHandler : IModuleContainerEvents
  {
    internal static AbsenceInitHandler ljh93oLq7eOYtrR8aCD;

    public void Activated() => ((AbsenceManager) AbsenceInitHandler.tQFSUVLI1kKF1Od2Qgo()).InitAbsenceCache();

    public void Terminating()
    {
    }

    public AbsenceInitHandler()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object tQFSUVLI1kKF1Od2Qgo() => (object) AbsenceManager.Instance;

    internal static bool ROdDTyLgyD1FgfpAH1V() => AbsenceInitHandler.ljh93oLq7eOYtrR8aCD == null;

    internal static AbsenceInitHandler wDQEADLJy4uor2y6Tl4() => AbsenceInitHandler.ljh93oLq7eOYtrR8aCD;
  }
}
