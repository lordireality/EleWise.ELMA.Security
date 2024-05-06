// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.OrgArtifactGroupElementShape
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using Nevron;
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
  public class OrgArtifactGroupElementShape : NCompositeShape
  {
    private Color fillColor;
    private OrgShapeMode mode;
    internal static OrgArtifactGroupElementShape vNKv5djnahkErxcJvQ5;

    public OrgArtifactGroupElementShape()
    {
      OrgArtifactGroupElementShape.bITcX7jHiHykAk5BFVN();
      // ISSUE: explicit constructor call
      this.\u002Ector(OrgShapeMode.Main);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected override void CreateDefaultLabels()
    {
      int num = 9;
      NBoundsLabel nboundsLabel;
      NStyle nstyle;
      while (true)
      {
        switch (num)
        {
          case 1:
            OrgArtifactGroupElementShape.CpvTm8No1sIYVHNX1TF((object) nboundsLabel, (object) nstyle);
            num = 3;
            continue;
          case 2:
            OrgArtifactGroupElementShape.oZDyoINkKJLqHsvXdNG((object) this.Labels, OrgArtifactGroupElementShape.st4htVN6RYjFahB2djn((object) nboundsLabel));
            num = 7;
            continue;
          case 3:
            OrgArtifactGroupElementShape.A2PijqNm0mvrluHEAXN(OrgArtifactGroupElementShape.Aba73INtZQVMqPyGG8U((object) this), (object) nboundsLabel);
            num = 2;
            continue;
          case 4:
            OrgArtifactGroupElementShape.ffsAFNNRpdMKM9AIEWt(OrgArtifactGroupElementShape.EVEeEMNbSotWfZ7oLAk((object) nstyle), new NPointL(0, -3));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 1 : 1;
            continue;
          case 5:
            nstyle = new NStyle();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 0;
            continue;
          case 6:
            OrgArtifactGroupElementShape.RK9gW2NUwcDELD4VNqG(OrgArtifactGroupElementShape.BaEEa5NKUvmGRiSTW8k(OrgArtifactGroupElementShape.EVEeEMNbSotWfZ7oLAk((object) nstyle)), VertAlign.Bottom);
            num = 4;
            continue;
          case 7:
            goto label_2;
          case 8:
            nboundsLabel = new NBoundsLabel((string) OrgArtifactGroupElementShape.l5DkNGjzwwIV6QYvm9b(-901653144 ^ -901646012), Guid.Empty, Nevron.Diagram.NMargins.Empty);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 5 : 3;
            continue;
          case 9:
            if (this.mode == OrgShapeMode.Main)
            {
              num = 8;
              continue;
            }
            goto label_13;
          default:
            OrgArtifactGroupElementShape.fE5ZQZNw7wxPN3yOqNE((object) nstyle, (object) new NTextStyle(new Font(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880091293 >> 4 ^ -54985318), 13f), OrgArtifactGroupElementShape.dAYKRsNujcScDi3uqA7(95, 95, 95)));
            num = 6;
            continue;
        }
      }
label_2:
      return;
label_13:;
    }

    public OrgArtifactGroupElementShape(OrgShapeMode mode)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 10;
      NCustomPath ncustomPath;
      NStyle nstyle;
      while (true)
      {
        switch (num)
        {
          case 1:
            OrgArtifactGroupElementShape.x8Y7AANZhfZICDVnNp6(OrgArtifactGroupElementShape.XnmywnNNq13v5mDvkum((object) nstyle), 1);
            num = 4;
            continue;
          case 2:
            nstyle.StrokeStyle = new NStrokeStyle(this.StrokeWidth, Color.Silver);
            num = 13;
            continue;
          case 3:
            OrgArtifactGroupElementShape.B53LEANjycacM1NCKHG((object) nstyle, (object) new NColorFillStyle(OrgArtifactGroupElementShape.ArxF2HN3Jmv93smr6iV()));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 2;
            continue;
          case 4:
            OrgArtifactGroupElementShape.KwEVoDNA19icZodXRHq((object) nstyle.StrokeStyle, 65304);
            num = 11;
            continue;
          case 5:
            nstyle = new NStyle();
            num = 3;
            continue;
          case 6:
            this.DefaultWidth = 164f;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 0 : 9;
            continue;
          case 7:
            goto label_2;
          case 8:
            OrgArtifactGroupElementShape.A2PijqNm0mvrluHEAXN(OrgArtifactGroupElementShape.X1kdVKNsI7PEWAjyFh8((object) this), (object) ncustomPath);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 0 : 0;
            continue;
          case 9:
            OrgArtifactGroupElementShape.AojwCSNa2Im3nkVjhMb((object) this, RouteObstacleType.RouteThrough);
            num = 12;
            continue;
          case 10:
            OrgArtifactGroupElementShape.igatn0NDDoSkVaLkvtJ((object) this, 96f);
            num = 6;
            continue;
          case 11:
            OrgArtifactGroupElementShape.CpvTm8No1sIYVHNX1TF((object) ncustomPath, (object) nstyle);
            num = 8;
            continue;
          case 12:
            ncustomPath = new NCustomPath((GraphicsPath) OrgArtifactGroupElementShape.ca8J9bNiCU5sGQQxmki(0.0f, 0.0f, this.DefaultWidth, OrgArtifactGroupElementShape.OOYLZrNxeyo8TBx1xjm((object) this), OrgArtifactGroupElementShape.CbkKwGNCOxFZFQKcjvD((object) this)), PathType.ClosedFigure);
            num = 5;
            continue;
          case 13:
            OrgArtifactGroupElementShape.LkX6dfN0J4Duj23IeV3(OrgArtifactGroupElementShape.XnmywnNNq13v5mDvkum((object) nstyle), LinePattern.Custom);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 1 : 1;
            continue;
          default:
            this.UpdateModelBounds();
            num = 7;
            continue;
        }
      }
label_2:;
    }

    protected virtual Color StartColor => Color.White;

    protected virtual float StrokeWidth => 2f;

    private float DefaultWidth
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 0;
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

    private static GraphicsPath CreatePath(
      float x,
      float y,
      float w,
      float h,
      float radius)
    {
      int num1 = 2;
      float num2;
      float num3;
      float x1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            x1 = x + w - num2;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
            continue;
          case 2:
            num2 = radius * 2f;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            num3 = y + h - num2;
            num1 = 3;
            continue;
        }
      }
label_4:
      GraphicsPath path = new GraphicsPath();
      OrgArtifactGroupElementShape.wjggkmN7dKpha87LgGa((object) path, x1, num3, num2, num2, 0.0f, 90f);
      OrgArtifactGroupElementShape.wjggkmN7dKpha87LgGa((object) path, x, num3, num2, num2, 90f, 90f);
      OrgArtifactGroupElementShape.wjggkmN7dKpha87LgGa((object) path, x, y, num2, num2, 180f, 90f);
      path.AddArc(x1, y, num2, num2, 270f, 90f);
      OrgArtifactGroupElementShape.It5xlfNW1EaO8uJFmgm((object) path);
      return path;
    }

    protected virtual float Radius => 8f;

    internal static void bITcX7jHiHykAk5BFVN() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool rujTDKjLJmuLSIiZASl() => OrgArtifactGroupElementShape.vNKv5djnahkErxcJvQ5 == null;

    internal static OrgArtifactGroupElementShape EY7TdJj28kFXNgIZIwh() => OrgArtifactGroupElementShape.vNKv5djnahkErxcJvQ5;

    internal static object l5DkNGjzwwIV6QYvm9b(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Color dAYKRsNujcScDi3uqA7([In] int obj0, [In] int obj1, [In] int obj2) => Color.FromArgb(obj0, obj1, obj2);

    internal static void fE5ZQZNw7wxPN3yOqNE([In] object obj0, [In] object obj1) => ((NStyle) obj0).TextStyle = (NTextStyle) obj1;

    internal static object EVEeEMNbSotWfZ7oLAk([In] object obj0) => (object) ((NStyle) obj0).TextStyle;

    internal static object BaEEa5NKUvmGRiSTW8k([In] object obj0) => (object) ((NTextStyle) obj0).StringFormatStyle;

    internal static void RK9gW2NUwcDELD4VNqG([In] object obj0, [In] VertAlign obj1) => ((NStringFormatStyle) obj0).VertAlign = obj1;

    internal static void ffsAFNNRpdMKM9AIEWt([In] object obj0, [In] NPointL obj1) => ((NTextStyle) obj0).Offset = obj1;

    internal static void CpvTm8No1sIYVHNX1TF([In] object obj0, [In] object obj1) => ((NStyleableElement) obj0).Style = (NStyle) obj1;

    internal static object Aba73INtZQVMqPyGG8U([In] object obj0) => (object) ((NShape) obj0).Labels;

    internal static void A2PijqNm0mvrluHEAXN([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).AddChild((INNode) obj1);

    internal static Guid st4htVN6RYjFahB2djn([In] object obj0) => ((NDiagramElement) obj0).UniqueId;

    internal static void oZDyoINkKJLqHsvXdNG([In] object obj0, [In] Guid obj1) => ((NLabelCollection) obj0).DefaultLabelUniqueId = obj1;

    internal static void igatn0NDDoSkVaLkvtJ([In] object obj0, float value) => ((OrgArtifactGroupElementShape) obj0).DefaultHeight = value;

    internal static void AojwCSNa2Im3nkVjhMb([In] object obj0, [In] RouteObstacleType obj1) => ((NShape) obj0).RouteObstacleType = obj1;

    internal static float OOYLZrNxeyo8TBx1xjm([In] object obj0) => ((OrgArtifactGroupElementShape) obj0).DefaultHeight;

    internal static float CbkKwGNCOxFZFQKcjvD([In] object obj0) => ((OrgArtifactGroupElementShape) obj0).Radius;

    internal static object ca8J9bNiCU5sGQQxmki(float x, float y, float w, float h, float radius) => (object) OrgArtifactGroupElementShape.CreatePath(x, y, w, h, radius);

    internal static Color ArxF2HN3Jmv93smr6iV() => Color.Transparent;

    internal static void B53LEANjycacM1NCKHG([In] object obj0, [In] object obj1) => ((NStyle) obj0).FillStyle = (NFillStyle) obj1;

    internal static object XnmywnNNq13v5mDvkum([In] object obj0) => (object) ((NStyle) obj0).StrokeStyle;

    internal static void LkX6dfN0J4Duj23IeV3([In] object obj0, [In] LinePattern obj1) => ((NStrokeStyle) obj0).Pattern = obj1;

    internal static void x8Y7AANZhfZICDVnNp6([In] object obj0, [In] int obj1) => ((NStrokeStyle) obj0).Factor = obj1;

    internal static void KwEVoDNA19icZodXRHq([In] object obj0, [In] int obj1) => ((NStrokeStyle) obj0).CustomPattern = obj1;

    internal static object X1kdVKNsI7PEWAjyFh8([In] object obj0) => (object) ((NCompositeShape) obj0).Primitives;

    internal static void wjggkmN7dKpha87LgGa(
      [In] object obj0,
      [In] float obj1,
      [In] float obj2,
      [In] float obj3,
      [In] float obj4,
      [In] float obj5,
      [In] float obj6)
    {
      ((GraphicsPath) obj0).AddArc(obj1, obj2, obj3, obj4, obj5, obj6);
    }

    internal static void It5xlfNW1EaO8uJFmgm([In] object obj0) => ((GraphicsPath) obj0).CloseAllFigures();
  }
}
