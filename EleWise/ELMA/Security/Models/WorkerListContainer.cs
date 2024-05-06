// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.WorkerListContainer
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Контейнер для списка исполнителей</summary>
  /// <remarks>Используется для сериализации списка исполнителей</remarks>
  [Component]
  public class WorkerListContainer : IXsiRoot
  {
    internal static WorkerListContainer CiI0jp5ObpBUlhQJRsD;

    /// <summary>Ctor</summary>
    public WorkerListContainer()
    {
      WorkerListContainer.VZnGxt5vOcVd1nFEIuo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Workers = new List<Worker>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Ctor</summary>
    /// <param name="workers">Список исполнителей</param>
    public WorkerListContainer(List<Worker> workers)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Workers = workers;
    }

    /// <summary>Список исполнителей</summary>
    public List<Worker> Workers { get; set; }

    internal static void VZnGxt5vOcVd1nFEIuo() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool HvG3Yb5TO69TS5Qhy3L() => WorkerListContainer.CiI0jp5ObpBUlhQJRsD == null;

    internal static WorkerListContainer D9UFLk5FVPU8iS4uUG5() => WorkerListContainer.CiI0jp5ObpBUlhQJRsD;
  }
}
