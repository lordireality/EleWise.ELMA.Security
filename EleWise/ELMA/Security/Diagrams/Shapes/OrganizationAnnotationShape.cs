// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.OrganizationAnnotationShape
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Shapes
{
  [Serializable]
  public class OrganizationAnnotationShape : OrganizationShape
  {
    private Color strokeColor;
    private OrgShapeMode mode;
    private static OrganizationAnnotationShape sEgMUTjakFfWm0Fun3j;

    public OrganizationAnnotationShape()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      this.\u002Ector(OrgShapeMode.Main);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected override void CreateDefaultLabels()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        NStyle nstyle;
        NBoundsLabel nboundsLabel;
        while (true)
        {
          switch (num2)
          {
            case 1:
              OrganizationAnnotationShape.Nb92jWjNZu7gRMO1FEP((object) this.Labels, (object) nboundsLabel);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 8 : 7;
              continue;
            case 2:
              goto label_10;
            case 3:
              goto label_3;
            case 4:
              if (this.mode != OrgShapeMode.Main)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 3 : 1;
                continue;
              }
              goto label_8;
            case 5:
              OrganizationAnnotationShape.PptMtvjjjcetPrepf15((object) nboundsLabel, (object) nstyle);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 1 : 1;
              continue;
            case 6:
              nstyle = new NStyle();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 7 : 2;
              continue;
            case 7:
              OrganizationAnnotationShape.CD18kPj3KoHwRCMKcmI((object) nstyle, (object) new NTextStyle(new Font((string) OrganizationAnnotationShape.feBCHGjihyvHHa7Sl1y(1013954274 ^ 1013966478), 13f), Color.FromArgb(95, 95, 95)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 2 : 5;
              continue;
            case 8:
              OrganizationAnnotationShape.RGBNbsjA09LOQb4vPv3(OrganizationAnnotationShape.kVkjldj0ykyNdUMYuGa((object) this), OrganizationAnnotationShape.qQQhVrjZ4OEmrStiqBI((object) nboundsLabel));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 2 : 2;
              continue;
            default:
              goto label_8;
          }
        }
label_8:
        nboundsLabel = new NBoundsLabel((string) OrganizationAnnotationShape.feBCHGjihyvHHa7Sl1y(1762575989 ^ 1762563625), Guid.Empty, Nevron.Diagram.NMargins.Empty);
        num1 = 6;
      }
label_10:
      return;
label_3:;
    }

    public OrganizationAnnotationShape(OrgShapeMode mode)
    {
      OrganizationAnnotationShape.z2UBunjs3dyytyenZqG();
      // ISSUE: explicit constructor call
      base.\u002Ector(mode);
      int num = 23;
      NStyle nstyle1;
      NCustomPath ncustomPath1;
      NStyle nstyle2;
      NRectanglePath nrectanglePath;
      NCustomPath ncustomPath2;
      while (true)
      {
        switch (num)
        {
          case 1:
            nstyle1 = new NStyle();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 4 : 11;
            continue;
          case 2:
            OrganizationAnnotationShape.TLTaj4j7Doqn8FHP4Y1((object) this, 32f);
            num = 16;
            continue;
          case 3:
            OrganizationAnnotationShape.wbOT8Oj5GYIKN1XpoRX(OrganizationAnnotationShape.qvuSMPjSkvCNOCykPAT((object) this), (object) nrectanglePath);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 22 : 8;
            continue;
          case 4:
          case 20:
            nrectanglePath = new NRectanglePath(0.0f, 0.0f, OrganizationAnnotationShape.xOerHZjrtfRVnLvkx29((object) this), this.DefaultHeight);
            num = 7;
            continue;
          case 5:
            if (mode == OrgShapeMode.Main)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 15 : 1;
              continue;
            }
            goto case 2;
          case 6:
            nstyle2 = new NStyle();
            num = 19;
            continue;
          case 7:
            OrganizationAnnotationShape.Nb92jWjNZu7gRMO1FEP(OrganizationAnnotationShape.qvuSMPjSkvCNOCykPAT((object) this), (object) nrectanglePath);
            num = 14;
            continue;
          case 8:
            ((NStrokeStyle) OrganizationAnnotationShape.PDlq7vjVeS06skQ3PFG(OrganizationAnnotationShape.OjhbWqjYWGSEs6Jr3f9((object) this))).Width = new NLength(2);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
            continue;
          case 9:
            OrganizationAnnotationShape.PptMtvjjjcetPrepf15((object) ncustomPath2, (object) nstyle2);
            num = 17;
            continue;
          case 10:
            ncustomPath1 = new NCustomPath((GraphicsPath) OrganizationAnnotationShape.VSMgEXjQaI8hbKRvMOW(0.0f, 0.0f, OrganizationAnnotationShape.xOerHZjrtfRVnLvkx29((object) this), OrganizationAnnotationShape.GGtAefjlRmrdcl53ncc((object) this)), PathType.ClosedFigure);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 1 : 1;
            continue;
          case 11:
            OrganizationAnnotationShape.bMDtDJjy446inGrddEW((object) nstyle1, (object) new NColorFillStyle(OrganizationAnnotationShape.hrsKTRj4GWlb0X0QsV2()));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 18 : 13;
            continue;
          case 12:
            OrganizationAnnotationShape.Nb92jWjNZu7gRMO1FEP((object) this.Primitives, (object) ncustomPath1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 13 : 9;
            continue;
          case 13:
            OrganizationAnnotationShape.u3yJU2j8MoO3yKIYWLh((object) this);
            num = 3;
            continue;
          case 14:
            OrganizationAnnotationShape.bMDtDJjy446inGrddEW(OrganizationAnnotationShape.OjhbWqjYWGSEs6Jr3f9((object) this), (object) new NColorFillStyle(Color.Transparent));
            num = 25;
            continue;
          case 15:
            OrganizationAnnotationShape.TLTaj4j7Doqn8FHP4Y1((object) this, 64f);
            num = 24;
            continue;
          case 16:
            OrganizationAnnotationShape.q88UH3jWyfo1lsbttFa((object) this, 24f);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 13 : 20;
            continue;
          case 17:
            OrganizationAnnotationShape.Nb92jWjNZu7gRMO1FEP(OrganizationAnnotationShape.qvuSMPjSkvCNOCykPAT((object) this), (object) ncustomPath2);
            num = 10;
            continue;
          case 18:
            nstyle1.StrokeStyle = new NStrokeStyle(this.StrokeWidth, this.StrokeColor);
            num = 26;
            continue;
          case 19:
            nstyle2.FillStyle = (NFillStyle) new NColorFillStyle(OrganizationAnnotationShape.hrsKTRj4GWlb0X0QsV2());
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 1 : 21;
            continue;
          case 21:
            nstyle2.StrokeStyle = new NStrokeStyle(OrganizationAnnotationShape.NFdVysjcF0nwr6xIe36((object) this), OrganizationAnnotationShape.i2GRfRjP4pvY55t9Lrm((object) this));
            num = 9;
            continue;
          case 22:
            goto label_19;
          case 23:
            if (mode != OrgShapeMode.Preview)
            {
              num = 5;
              continue;
            }
            goto case 15;
          case 24:
            OrganizationAnnotationShape.q88UH3jWyfo1lsbttFa((object) this, 164f);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 4 : 2;
            continue;
          case 25:
            ((NStyle) OrganizationAnnotationShape.OjhbWqjYWGSEs6Jr3f9((object) this)).StrokeStyle = new NStrokeStyle(this.strokeColor);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 8 : 3;
            continue;
          case 26:
            ncustomPath1.Style = nstyle1;
            num = 12;
            continue;
          default:
            ncustomPath2 = new NCustomPath((GraphicsPath) OrganizationAnnotationShape.bOlppAjfGgcHxVkBPGY(0.0f, 0.0f, OrganizationAnnotationShape.xOerHZjrtfRVnLvkx29((object) this), OrganizationAnnotationShape.GGtAefjlRmrdcl53ncc((object) this)), PathType.ClosedFigure);
            num = 6;
            continue;
        }
      }
label_19:;
    }

    public override void AddProtection()
    {
    }

    public override void AddPorts()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              OrganizationAnnotationShape.rHer7LjGbEjjAjH9WgW((object) this.Ports, false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              OrganizationAnnotationShape.rHer7LjGbEjjAjH9WgW(OrganizationAnnotationShape.shKgl0jdlswGKbmsuJb((object) this), true);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 1 : 2;
              continue;
            case 4:
              OrganizationAnnotationShape.qcB5MujEgAALCXV04KU((object) this, ShapeElementsMask.Ports);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 1 : 1;
              continue;
            case 5:
              if (OrganizationAnnotationShape.shKgl0jdlswGKbmsuJb((object) this) != null)
                goto case 1;
              else
                goto label_6;
            default:
              object obj = OrganizationAnnotationShape.shKgl0jdlswGKbmsuJb((object) this);
              NRotatedBoundsPort nrotatedBoundsPort = new NRotatedBoundsPort(this.UniqueId, ContentAlignment.MiddleLeft);
              OrganizationAnnotationShape.AX0vohjXuLjLj1luBIo((object) nrotatedBoundsPort, OrganizationAnnotationShape.feBCHGjihyvHHa7Sl1y(-347045778 ^ -347025170));
              OrganizationAnnotationShape.Nb92jWjNZu7gRMO1FEP(obj, (object) nrotatedBoundsPort);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 3 : 0;
              continue;
          }
        }
label_6:
        num1 = 4;
      }
label_3:;
    }

    protected virtual Color StartColor => OrganizationAnnotationShape.FlNibhj9O3fDBxJUSvB();

    protected virtual float StrokeWidth => 0.5f;

    protected virtual float DefaultWidth
    {
      get => this.\u003CDefaultWidth\u003Ek__BackingField;
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
              this.\u003CDefaultWidth\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 0 : 0;
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

    protected virtual float DefaultHeight
    {
      get => this.\u003CDefaultHeight\u003Ek__BackingField;
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
              this.\u003CDefaultHeight\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 0;
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

    private static GraphicsPath CreatePath(float x, float y, float w, float h)
    {
      int num1 = 1;
      float num2;
      float num3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = x + w / 3f;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            num3 = y + h;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      GraphicsPath path = new GraphicsPath();
      OrganizationAnnotationShape.BALHyZj1kgDKuEC2QFH((object) path, num2, y, x, y);
      OrganizationAnnotationShape.BALHyZj1kgDKuEC2QFH((object) path, x, num3, num2, num3);
      return path;
    }

    private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
    {
      int num1 = 2;
      float num2;
      float num3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num3 = y + h;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
            continue;
          case 2:
            num2 = x + w;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      GraphicsPath pathBase = new GraphicsPath();
      OrganizationAnnotationShape.BALHyZj1kgDKuEC2QFH((object) pathBase, num2, y, x, y);
      OrganizationAnnotationShape.BALHyZj1kgDKuEC2QFH((object) pathBase, x, num3, num2, num3);
      OrganizationAnnotationShape.UqAHkZjM1m4d9JEk5G7((object) pathBase);
      return pathBase;
    }

    internal static bool LIegMfjxXLU9Nel2wLm() => OrganizationAnnotationShape.sEgMUTjakFfWm0Fun3j == null;

    internal static OrganizationAnnotationShape I9wbKQjCh4UQGDfutBR() => OrganizationAnnotationShape.sEgMUTjakFfWm0Fun3j;

    internal static object feBCHGjihyvHHa7Sl1y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void CD18kPj3KoHwRCMKcmI([In] object obj0, [In] object obj1) => ((NStyle) obj0).TextStyle = (NTextStyle) obj1;

    internal static void PptMtvjjjcetPrepf15([In] object obj0, [In] object obj1) => ((NStyleableElement) obj0).Style = (NStyle) obj1;

    internal static void Nb92jWjNZu7gRMO1FEP([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).AddChild((INNode) obj1);

    internal static object kVkjldj0ykyNdUMYuGa([In] object obj0) => (object) ((NShape) obj0).Labels;

    internal static Guid qQQhVrjZ4OEmrStiqBI([In] object obj0) => ((NDiagramElement) obj0).UniqueId;

    internal static void RGBNbsjA09LOQb4vPv3([In] object obj0, [In] Guid obj1) => ((NLabelCollection) obj0).DefaultLabelUniqueId = obj1;

    internal static void z2UBunjs3dyytyenZqG() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static void TLTaj4j7Doqn8FHP4Y1([In] object obj0, float value) => ((OrganizationAnnotationShape) obj0).DefaultHeight = value;

    internal static void q88UH3jWyfo1lsbttFa([In] object obj0, float value) => ((OrganizationAnnotationShape) obj0).DefaultWidth = value;

    internal static float xOerHZjrtfRVnLvkx29([In] object obj0) => ((OrganizationAnnotationShape) obj0).DefaultWidth;

    internal static object qvuSMPjSkvCNOCykPAT([In] object obj0) => (object) ((NCompositeShape) obj0).Primitives;

    internal static object OjhbWqjYWGSEs6Jr3f9([In] object obj0) => (object) ((NStyleableElement) obj0).Style;

    internal static void bMDtDJjy446inGrddEW([In] object obj0, [In] object obj1) => ((NStyle) obj0).FillStyle = (NFillStyle) obj1;

    internal static object PDlq7vjVeS06skQ3PFG([In] object obj0) => (object) ((NStyle) obj0).StrokeStyle;

    internal static float GGtAefjlRmrdcl53ncc([In] object obj0) => ((OrganizationAnnotationShape) obj0).DefaultHeight;

    internal static object bOlppAjfGgcHxVkBPGY(float x, float y, float w, float h) => (object) OrganizationAnnotationShape.CreatePathBase(x, y, w, h);

    internal static Color hrsKTRj4GWlb0X0QsV2() => Color.Transparent;

    internal static float NFdVysjcF0nwr6xIe36([In] object obj0) => ((OrganizationAnnotationShape) obj0).StrokeWidth;

    internal static Color i2GRfRjP4pvY55t9Lrm([In] object obj0) => ((OrganizationAnnotationShape) obj0).StartColor;

    internal static object VSMgEXjQaI8hbKRvMOW(float x, float y, float w, float h) => (object) OrganizationAnnotationShape.CreatePath(x, y, w, h);

    internal static bool u3yJU2j8MoO3yKIYWLh([In] object obj0) => ((NAggregateModel) obj0).UpdateModelBounds();

    internal static void wbOT8Oj5GYIKN1XpoRX([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).RemoveChild((INNode) obj1);

    internal static object shKgl0jdlswGKbmsuJb([In] object obj0) => (object) ((NShape) obj0).Ports;

    internal static bool qcB5MujEgAALCXV04KU([In] object obj0, [In] ShapeElementsMask obj1) => ((NShape) obj0).CreateShapeElements(obj1);

    internal static void rHer7LjGbEjjAjH9WgW([In] object obj0, [In] bool obj1) => ((NDiagramElementCollection) obj0).AutoGenerateUniqueNames = obj1;

    internal static void AX0vohjXuLjLj1luBIo([In] object obj0, [In] object obj1) => ((NDiagramElement) obj0).Name = (string) obj1;

    internal static Color FlNibhj9O3fDBxJUSvB() => Color.White;

    internal static void BALHyZj1kgDKuEC2QFH(
      [In] object obj0,
      [In] float obj1,
      [In] float obj2,
      [In] float obj3,
      [In] float obj4)
    {
      ((GraphicsPath) obj0).AddLine(obj1, obj2, obj3, obj4);
    }

    internal static void UqAHkZjM1m4d9JEk5G7([In] object obj0) => ((GraphicsPath) obj0).CloseAllFigures();
  }
}
