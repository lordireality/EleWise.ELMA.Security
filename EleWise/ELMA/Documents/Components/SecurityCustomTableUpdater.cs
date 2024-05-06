// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Documents.Components.SecurityCustomTableUpdater
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Documents.Components
{
  /// <summary>
  /// Реализация точки расширения для получения структуры пользовательских таблиц в модуле безопасности
  /// </summary>
  [Component]
  internal sealed class SecurityCustomTableUpdater : ICustomTableUpdater
  {
    private static SecurityCustomTableUpdater tchVkkgjxDCxIM2Rg0;

    /// <inheritdoc />
    public IDictionary<string, IEnumerable<string>> GetCustomTablesStructure() => (IDictionary<string, IEnumerable<string>>) new Dictionary<string, IEnumerable<string>>()
    {
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-296013529 ^ -296012955),
        (IEnumerable<string>) new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868768509),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1212037053 ^ -1727812018 ^ -784491655),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053060331),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(911364681 ^ 911364325)
        }
      },
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1013954274 ^ 1013953630),
        (IEnumerable<string>) new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807814393),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1780597820 ^ 1780598430),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(784628100 ^ 784628520)
        }
      }
    };

    public SecurityCustomTableUpdater()
    {
      SecurityCustomTableUpdater.vQtEkyeynhLSiWrD0H();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void vQtEkyeynhLSiWrD0H() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool t8AqbgJZasgZMxyPi3() => SecurityCustomTableUpdater.tchVkkgjxDCxIM2Rg0 == null;

    internal static SecurityCustomTableUpdater w0W8ECIV1KpmjLMMsX() => SecurityCustomTableUpdater.tchVkkgjxDCxIM2Rg0;
  }
}
