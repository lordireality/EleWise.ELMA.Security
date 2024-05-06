// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Elements.DepartmentElement
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Security.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Elements
{
  /// <summary>Отдел в оргструктуре</summary>
  [Shape(typeof (DepartmentShape))]
  [Serializable]
  public class DepartmentElement : OrganizationElement
  {
    private static DepartmentElement RgyAUDZktdMv9VIom1k;

    public override void InitNew()
    {
      int num = 1;
      PositionElement positionElement1;
      EmployeeGroupElement employeeGroupElement1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DepartmentElement.dJionlZxgComTHZTnET((object) this);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 0 : 0;
            continue;
          case 2:
            EmployeeGroupElement employeeGroupElement2 = new EmployeeGroupElement();
            DepartmentElement.DjlHyBZChUcpBcgVelx((object) employeeGroupElement2, DepartmentElement.tHue5jZN5aLbeCeMe4B());
            DepartmentElement.Y3IPEgZ0vUhpZifELeZ((object) employeeGroupElement2, DepartmentElement.NSqFU7Zjnx4ChjyVaD1(DepartmentElement.t6FJQYZ3hIwVbrFXokE(784628100 ^ 784607566)));
            employeeGroupElement1 = employeeGroupElement2;
            num = 3;
            continue;
          case 3:
            positionElement1.Composition.Add((OrganizationElement) employeeGroupElement1);
            num = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            this.Composition.Add((OrganizationElement) positionElement1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 2 : 0;
            continue;
          default:
            PositionElement positionElement2 = new PositionElement();
            DepartmentElement.DjlHyBZChUcpBcgVelx((object) positionElement2, Guid.NewGuid());
            DepartmentElement.hanC0jZixyu9yaRhRem((object) positionElement2, true);
            positionElement2.Name = (string) DepartmentElement.NSqFU7Zjnx4ChjyVaD1(DepartmentElement.t6FJQYZ3hIwVbrFXokE(-1702973981 - 773209001 ^ 1818763940));
            positionElement1 = positionElement2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 3 : 5;
            continue;
        }
      }
label_2:;
    }

    public DepartmentElement()
    {
      DepartmentElement.ocK0OcZZenBGPhLr0vY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void dJionlZxgComTHZTnET([In] object obj0) => __nonvirtual (((Element) obj0).InitNew());

    internal static void DjlHyBZChUcpBcgVelx([In] object obj0, [In] Guid obj1) => ((Element) obj0).Uid = obj1;

    internal static void hanC0jZixyu9yaRhRem([In] object obj0, bool value) => ((PositionElement) obj0).IsChief = value;

    internal static object t6FJQYZ3hIwVbrFXokE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NSqFU7Zjnx4ChjyVaD1([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Guid tHue5jZN5aLbeCeMe4B() => Guid.NewGuid();

    internal static void Y3IPEgZ0vUhpZifELeZ([In] object obj0, [In] object obj1) => ((Element) obj0).Name = (string) obj1;

    internal static bool BTfC3cZDN5UBsHgibpw() => DepartmentElement.RgyAUDZktdMv9VIom1k == null;

    internal static DepartmentElement Mg2ZAIZavXCpUou1TEO() => DepartmentElement.RgyAUDZktdMv9VIom1k;

    internal static void ocK0OcZZenBGPhLr0vY() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
