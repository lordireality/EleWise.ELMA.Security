// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Elements.PositionElement
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Security.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.Diagrams.Elements
{
  /// <summary>Должность в оргструктуре</summary>
  [Shape(typeof (PositionShape))]
  [Serializable]
  public class PositionElement : OrganizationElement
  {
    private static PositionElement ceDTnbZlNHIskmKuoTS;

    /// <summary>
    /// Признак, что данная должность является начальником отдела
    /// </summary>
    public bool IsChief
    {
      get => this.\u003CIsChief\u003Ek__BackingField;
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
              this.\u003CIsChief\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
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

    public override void InitNew()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.EmployeeCount = (string) PositionElement.e5vmfuZcOXcM5iqkkMK(1677147940 ^ 1677143352);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 0 : 0;
            continue;
          case 2:
            base.InitNew();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public PositionElement()
    {
      PositionElement.yMVrTnZP3eIIKutNV1n();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gRBIVVZfgaVBlWj3jUg() => PositionElement.ceDTnbZlNHIskmKuoTS == null;

    internal static PositionElement ETt8DUZ4x6C5kV64jxy() => PositionElement.ceDTnbZlNHIskmKuoTS;

    internal static object e5vmfuZcOXcM5iqkkMK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void yMVrTnZP3eIIKutNV1n() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
