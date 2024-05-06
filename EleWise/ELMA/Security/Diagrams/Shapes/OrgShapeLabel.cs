// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.OrgShapeLabel
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Shapes
{
  [Serializable]
  public class OrgShapeLabel : NBoundsLabel
  {
    internal static OrgShapeLabel pIyutW0yBdyfagswvIo;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public OrgShapeLabel()
    {
      OrgShapeLabel.kx5QiY0f7LKlFypM3vX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            OrgShapeLabel.zSvHb10P4Ex97QxhkGP(OrgShapeLabel.Hbs3N10cYeiUpq0tPPR((object) this), (object) new NTextStyle(new Font(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899816653), 13f)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 1 : 1;
            continue;
          default:
            OrgShapeLabel.PJKhSo04VrQTgaEBBYK((object) this, (object) new NStyle());
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public OrgShapeLabel(string text, Guid anchorUniqueId, Nevron.Diagram.NMargins margins)
    {
      OrgShapeLabel.kx5QiY0f7LKlFypM3vX();
      // ISSUE: explicit constructor call
      base.\u002Ector(text, anchorUniqueId, margins);
      int num = 2;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            OrgShapeLabel.PJKhSo04VrQTgaEBBYK((object) this, (object) new NStyle());
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
            continue;
          default:
            OrgShapeLabel.zSvHb10P4Ex97QxhkGP(OrgShapeLabel.Hbs3N10cYeiUpq0tPPR((object) this), (object) new NTextStyle(new Font((string) OrgShapeLabel.YQipmH0QU8X2MnZDUKI(~-1362653258 ^ 1362632741), 13f)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool GetDesiredSize(out NSizeF size) => this.GetDesiredSize(this.Text, out size);

    protected bool GetDesiredSize(string text, out NSizeF size)
    {
      int num1 = 2;
      Nevron.Diagram.NMargins nmargins;
      float num2;
      float num3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.MeasureStringInScene(text, (NTextStyle) OrgShapeLabel.axGuHV08ix1grqOwYtO((object) this), out size))
            {
              nmargins = OrgShapeLabel.q10ZHi05cr34oEsgmse((object) this);
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 1;
            continue;
          case 3:
            size.Height = (float) (100.0 * (double) size.Height / (100.0 - (double) num2));
            num1 = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            double top = (double) nmargins.Top;
            nmargins = OrgShapeLabel.q10ZHi05cr34oEsgmse((object) this);
            double bottom = (double) nmargins.Bottom;
            num2 = (float) (top + bottom);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 7 : 1;
            continue;
          case 6:
            nmargins = this.Margins;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 4 : 5;
            continue;
          case 7:
            size.Width = (float) (100.0 * (double) size.Width / (100.0 - (double) num3));
            num1 = 3;
            continue;
          default:
            double left = (double) nmargins.Left;
            nmargins = this.Margins;
            double right = (double) nmargins.Right;
            num3 = (float) (left + right);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 2 : 6;
            continue;
        }
      }
label_2:
      return true;
label_3:
      return false;
    }

    public bool GetDesiredBounds(string text, out NRectangleF modelBounds)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        NSizeF size;
        NRectangleF rectangle;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              if ((double) size.Height < 16.0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 1 : 1;
                continue;
              }
              goto case 7;
            case 3:
              this.GetDesiredSize(text, out size);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 2 : 0;
              continue;
            case 4:
              size.Height += 24f;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
              continue;
            case 5:
              modelBounds = OrgShapeLabel.q10ZHi05cr34oEsgmse((object) this).PercentDeflateRectangle(rectangle);
              num2 = 10;
              continue;
            case 6:
              size.Width = 64f;
              num2 = 8;
              continue;
            case 7:
              if ((double) size.Width < 64.0)
              {
                num2 = 6;
                continue;
              }
              goto case 8;
            case 8:
              size.Width += 32f;
              num2 = 4;
              continue;
            case 9:
              goto label_3;
            case 10:
              if (!modelBounds.IsEmpty)
              {
                num2 = 11;
                continue;
              }
              goto label_3;
            case 11:
              goto label_4;
            default:
              rectangle = new NRectangleF(new NPointF(32f, (float) ((32.0 - (double) size.Height) / 2.0)), new NSizeF(size.Width, size.Height));
              num2 = 5;
              continue;
          }
        }
label_16:
        size.Height = 16f;
        num1 = 7;
      }
label_3:
      return false;
label_4:
      return true;
    }

    public override bool GetWorldTextPaintInfo(string text, out NTextPaintInfo info)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        NPointF[] points;
        OrganizationShape organizationShape;
        BoxTextMode boxTextMode;
        NMatrix2DF nmatrix2Df;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 14:
            case 15:
              goto label_22;
            case 2:
              NRectangleF modelBounds;
              if (this.GetDesiredBounds(text, out modelBounds))
              {
                points = (NPointF[]) OrgShapeLabel.fNw7B90MHALCPN9VUh5(modelBounds);
                num2 = 13;
                continue;
              }
              goto label_13;
            case 3:
              nmatrix2Df.TransformPoints(points);
              num2 = 11;
              continue;
            case 4:
              goto label_28;
            case 5:
              if (OrgShapeLabel.mkTusr09MIPeXLLGBwh((object) text, OrgShapeLabel.BhCCTS0X7FT2sgXvmLY((object) text) - 1) == '\n')
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 2 : 4;
                continue;
              }
              goto case 2;
            case 7:
              if (boxTextMode == BoxTextMode.Wrap)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 0 : 0;
                continue;
              }
              goto case 20;
            case 8:
              organizationShape = OrgShapeLabel.uUUGoV0EubSgCML8eUJ((object) this, OrgShapeLabel.QNCeKa0d80MjV0yBnys((object) this)) as OrganizationShape;
              num2 = 21;
              continue;
            case 9:
              info = new NTextPaintInfo();
              num2 = 8;
              continue;
            case 10:
              goto label_16;
            case 11:
              info.InitFromBasisPoints(points, true);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 9 : 16;
              continue;
            case 12:
              goto label_4;
            case 13:
              nmatrix2Df = OrgShapeLabel.ms08CZ0hL8cOabnvsc5((object) organizationShape);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 3 : 1;
              continue;
            case 16:
              boxTextMode = OrgShapeLabel.GSVdr20BekJGtdPaKmW((object) this);
              num2 = 7;
              continue;
            case 17:
              if (!OrgShapeLabel.pJhZ5Z0Gyb50BZj2KBT((object) text))
              {
                num2 = 19;
                continue;
              }
              goto case 2;
            case 18:
              info.Mode = PaintTextMode.Stretch;
              num2 = 14;
              continue;
            case 19:
              if (OrgShapeLabel.mkTusr09MIPeXLLGBwh((object) text, OrgShapeLabel.BhCCTS0X7FT2sgXvmLY((object) text) - 1) != '\r')
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 5 : 4;
                continue;
              }
              goto label_28;
            case 20:
              if (boxTextMode != BoxTextMode.Stretch)
              {
                num2 = 15;
                continue;
              }
              goto case 18;
            case 21:
              if (organizationShape != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 8 : 17;
                continue;
              }
              goto label_16;
            default:
              info.Mode = PaintTextMode.Wrap;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 1 : 1;
              continue;
          }
        }
label_13:
        num1 = 12;
        continue;
label_28:
        text = (string) OrgShapeLabel.rK0Top01Dpc1X7IZNm3((object) text, OrgShapeLabel.YQipmH0QU8X2MnZDUKI(-110921701 >> 6 ^ -1712776));
        num1 = 2;
      }
label_4:
      return false;
label_16:
      return false;
label_22:
      return true;
    }

    private static NPointF[] GetPoints(NRectangleF rect) => new NPointF[3]
    {
      rect.Center,
      new NPointF(rect.X, rect.Y),
      new NPointF(rect.Right, rect.Y)
    };

    internal static void kx5QiY0f7LKlFypM3vX() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static void PJKhSo04VrQTgaEBBYK([In] object obj0, [In] object obj1) => ((NStyleableElement) obj0).Style = (NStyle) obj1;

    internal static object Hbs3N10cYeiUpq0tPPR([In] object obj0) => (object) ((NStyleableElement) obj0).Style;

    internal static void zSvHb10P4Ex97QxhkGP([In] object obj0, [In] object obj1) => ((NStyle) obj0).TextStyle = (NTextStyle) obj1;

    internal static bool sqYEth0VUHqGQRkZ2nD() => OrgShapeLabel.pIyutW0yBdyfagswvIo == null;

    internal static OrgShapeLabel P7M6iV0lRg1yBMk0ksi() => OrgShapeLabel.pIyutW0yBdyfagswvIo;

    internal static object YQipmH0QU8X2MnZDUKI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object axGuHV08ix1grqOwYtO([In] object obj0) => (object) ((NStyleComposerElement) obj0).ComposeTextStyle();

    internal static Nevron.Diagram.NMargins q10ZHi05cr34oEsgmse([In] object obj0) => ((NBoundsLabel) obj0).Margins;

    internal static Guid QNCeKa0d80MjV0yBnys([In] object obj0) => ((NLabel) obj0).AnchorUniqueId;

    internal static object uUUGoV0EubSgCML8eUJ([In] object obj0, [In] Guid obj1) => (object) ((NLabel) obj0).GetAnchorModel(obj1);

    internal static bool pJhZ5Z0Gyb50BZj2KBT([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static int BhCCTS0X7FT2sgXvmLY([In] object obj0) => ((string) obj0).Length;

    internal static char mkTusr09MIPeXLLGBwh([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object rK0Top01Dpc1X7IZNm3([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object fNw7B90MHALCPN9VUh5(NRectangleF rect) => (object) OrgShapeLabel.GetPoints(rect);

    internal static NMatrix2DF ms08CZ0hL8cOabnvsc5([In] object obj0) => ((NTransformableElement) obj0).WorldTransform;

    internal static BoxTextMode GSVdr20BekJGtdPaKmW([In] object obj0) => ((NBoundsLabel) obj0).Mode;
  }
}
