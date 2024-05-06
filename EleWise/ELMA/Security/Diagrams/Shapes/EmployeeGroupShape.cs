// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.EmployeeGroupShape
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Shapes
{
  [Serializable]
  public class EmployeeGroupShape : OrganizationShape
  {
    private static EmployeeGroupShape JJ8pyENPE1myi3Ky3dw;

    public EmployeeGroupShape()
    {
      EmployeeGroupShape.QxZy71N5S5rJV1lr0m6();
      // ISSUE: explicit constructor call
      this.\u002Ector(OrgShapeMode.Main);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EmployeeGroupShape(OrgShapeMode mode)
    {
      EmployeeGroupShape.QxZy71N5S5rJV1lr0m6();
      // ISSUE: explicit constructor call
      base.\u002Ector(mode);
      int num1 = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0)
        num1 = 3;
      float num2;
      NRectanglePath nrectanglePath;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            nrectanglePath = new NRectanglePath(0.0f, 0.0f, 32f * num2, 32f * num2);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 3 : 6;
            continue;
          case 3:
            num2 = 1f;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 2 : 0;
            continue;
          case 4:
            EmployeeGroupShape.eMcbsGN9hJHn1UvRaio(EmployeeGroupShape.cWskOINdIRljtn99CPS((object) this), (object) nrectanglePath);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 1;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 0 : 0;
            continue;
          case 6:
            EmployeeGroupShape.dnUEYtNE0NsEleCcBv4(EmployeeGroupShape.cWskOINdIRljtn99CPS((object) this), (object) nrectanglePath);
            num1 = 5;
            continue;
          case 7:
            OrganizationShapes.RenderHumanShape(this.Primitives, 4f * num2, 8f * num2, 0.75f * num2, this.StrokeColor, this.FillColor);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 2 : 9;
            continue;
          case 8:
            EmployeeGroupShape.lgPvJONGPnYwCJusI9G(EmployeeGroupShape.cWskOINdIRljtn99CPS((object) this), 15f * num2, 0.0f, 1f * num2, this.StrokeColor, this.FillColor);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 7;
            continue;
          case 9:
            EmployeeGroupShape.gP2qmHNXuSis9HAG2Jc((object) this);
            num1 = 4;
            continue;
          default:
            EmployeeGroupShape.lgPvJONGPnYwCJusI9G(EmployeeGroupShape.cWskOINdIRljtn99CPS((object) this), 0.0f, 0.0f, 1f * num2, this.StrokeColor, this.FillColor);
            num1 = 8;
            continue;
        }
      }
label_3:;
    }

    internal static void QxZy71N5S5rJV1lr0m6() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool FEpovgNQD82Nm6S3sHM() => EmployeeGroupShape.JJ8pyENPE1myi3Ky3dw == null;

    internal static EmployeeGroupShape HP7WMVN8aeMEDxEihQ7() => EmployeeGroupShape.JJ8pyENPE1myi3Ky3dw;

    internal static object cWskOINdIRljtn99CPS([In] object obj0) => (object) ((NCompositeShape) obj0).Primitives;

    internal static void dnUEYtNE0NsEleCcBv4([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).AddChild((INNode) obj1);

    internal static void lgPvJONGPnYwCJusI9G(
      [In] object obj0,
      float dx,
      float dy,
      float scale,
      Color strokeColor,
      Color fillColor)
    {
      OrganizationShapes.RenderSmallHumanShape((NPrimitiveModelCollection) obj0, dx, dy, scale, strokeColor, fillColor);
    }

    internal static bool gP2qmHNXuSis9HAG2Jc([In] object obj0) => ((NAggregateModel) obj0).UpdateModelBounds();

    internal static void eMcbsGN9hJHn1UvRaio([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).RemoveChild((INNode) obj1);
  }
}
