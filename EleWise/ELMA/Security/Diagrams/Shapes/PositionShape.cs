// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.PositionShape
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Shapes
{
  [Serializable]
  public class PositionShape : OrganizationShape
  {
    private static PositionShape Wayma10FrB5QakYTT31;

    public PositionShape()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      this.\u002Ector(OrgShapeMode.Main);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PositionShape(OrgShapeMode mode)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(mode);
      int num = 5;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0)
        num = 7;
      float scale;
      NRectanglePath nrectanglePath;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            PositionShape.Y4Jgrl0IaEpaBE7URXP((object) this);
            num = 3;
            continue;
          case 3:
            PositionShape.pTTYVx0ehh68MxnRJfO(PositionShape.HTfXjt0gJcCTWoimMSq((object) this), (object) nrectanglePath);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 1 : 1;
            continue;
          case 4:
            PositionShape.eOLm8q0JiicWtvGi76t(PositionShape.HTfXjt0gJcCTWoimMSq((object) this), (object) nrectanglePath);
            num = 5;
            continue;
          case 5:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
            continue;
          case 6:
            nrectanglePath = new NRectanglePath(0.0f, 0.0f, 32f * scale, 32f * scale);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 4 : 1;
            continue;
          case 7:
            scale = 1f;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 6 : 3;
            continue;
          default:
            OrganizationShapes.RenderHumanShape(this.Primitives, 1f, 1f, scale, this.StrokeColor, this.FillColor);
            num = 2;
            continue;
        }
      }
label_3:;
    }

    internal static bool Kr3CLM0v4HwhnBfFA5m() => PositionShape.Wayma10FrB5QakYTT31 == null;

    internal static PositionShape aVA8y30qauBX7lnI3pZ() => PositionShape.Wayma10FrB5QakYTT31;

    internal static object HTfXjt0gJcCTWoimMSq([In] object obj0) => (object) ((NCompositeShape) obj0).Primitives;

    internal static void eOLm8q0JiicWtvGi76t([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).AddChild((INNode) obj1);

    internal static bool Y4Jgrl0IaEpaBE7URXP([In] object obj0) => ((NAggregateModel) obj0).UpdateModelBounds();

    internal static void pTTYVx0ehh68MxnRJfO([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).RemoveChild((INNode) obj1);
  }
}
