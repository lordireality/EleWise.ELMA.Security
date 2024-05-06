// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.DepartmentShape
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Shapes
{
  [Serializable]
  public class DepartmentShape : OrganizationShape
  {
    private static DepartmentShape kfPgSONrrMFGHTHkRgg;

    public DepartmentShape()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      this.\u002Ector(OrgShapeMode.Main);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DepartmentShape(OrgShapeMode mode)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(mode);
      int num1 = 4;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0)
        num1 = 0;
      float num2;
      NRectanglePath nrectanglePath1;
      NRectanglePath nrectanglePath2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nrectanglePath2 = new NRectanglePath(12f * num2, 4f * num2, 8f * num2, 4f * num2);
            num1 = 6;
            continue;
          case 2:
            nrectanglePath1 = new NRectanglePath(0.0f, 0.0f, 32f * num2, 32f * num2);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
            continue;
          case 3:
            DepartmentShape.GSt6JENcP7d2TMhNYm7((object) this.Primitives, (object) nrectanglePath1);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 8 : 0;
            continue;
          case 4:
            num2 = 1f;
            num1 = 2;
            continue;
          case 5:
            DepartmentShape.NaX3n2NyoTFE9N0rgh5((object) this.Primitives, (object) nrectanglePath2);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 6 : 7;
            continue;
          case 6:
            nrectanglePath2.Style = new NStyle();
            num1 = 11;
            continue;
          case 7:
            this.Primitives.AddChild((INNode) new NLinePath(20f * num2, 18f * num2, 23f * num2, 18f * num2));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 10 : 9;
            continue;
          case 8:
            goto label_3;
          case 9:
            DepartmentShape.NaX3n2NyoTFE9N0rgh5(DepartmentShape.gmChWyNVbMTxS4l76bs((object) this), (object) new NRectanglePath(4f * num2, 0.0f, 24f * num2, 32f * num2));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 1 : 0;
            continue;
          case 10:
            DepartmentShape.lAvr1UN4sXSykmhVcJo((object) this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 3 : 0;
            continue;
          case 11:
            DepartmentShape.yhnGPbNf9sdgGsrGSX5(DepartmentShape.IBPlI6Nlo2NCxWvoimG((object) nrectanglePath2), (object) new NStrokeStyle(this.StrokeColor));
            num1 = 5;
            continue;
          default:
            DepartmentShape.NaX3n2NyoTFE9N0rgh5((object) this.Primitives, (object) nrectanglePath1);
            num1 = 9;
            continue;
        }
      }
label_3:;
    }

    internal static bool TRc6qlNSsvIoydQbZX5() => DepartmentShape.kfPgSONrrMFGHTHkRgg == null;

    internal static DepartmentShape MaHT6gNY0IDumrUCMZv() => DepartmentShape.kfPgSONrrMFGHTHkRgg;

    internal static void NaX3n2NyoTFE9N0rgh5([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).AddChild((INNode) obj1);

    internal static object gmChWyNVbMTxS4l76bs([In] object obj0) => (object) ((NCompositeShape) obj0).Primitives;

    internal static object IBPlI6Nlo2NCxWvoimG([In] object obj0) => (object) ((NStyleableElement) obj0).Style;

    internal static void yhnGPbNf9sdgGsrGSX5([In] object obj0, [In] object obj1) => ((NStyle) obj0).StrokeStyle = (NStrokeStyle) obj1;

    internal static bool lAvr1UN4sXSykmhVcJo([In] object obj0) => ((NAggregateModel) obj0).UpdateModelBounds();

    internal static void GSt6JENcP7d2TMhNYm7([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).RemoveChild((INNode) obj1);
  }
}
