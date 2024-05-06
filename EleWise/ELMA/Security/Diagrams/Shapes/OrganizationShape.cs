// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Shapes.OrganizationShape
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Diagrams.Shapes
{
  [Serializable]
  public abstract class OrganizationShape : NCompositeShape
  {
    private Color strokeColor;
    private Color fillColor;
    private OrgShapeMode mode;
    internal static OrganizationShape neSVg8NeApDQ69B1I0Z;

    public OrganizationShape()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      this.\u002Ector(OrgShapeMode.Main);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OrganizationShape(OrgShapeMode mode)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0)
        num1 = 2;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            OrganizationShape.hPTULF0UEs3kViwO6RL((object) this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 2 : 9;
            continue;
          case 2:
            Color color1;
            switch (mode)
            {
              case OrgShapeMode.Main:
                color1 = Color.Gray;
                break;
              case OrgShapeMode.Preview:
                color1 = Color.Silver;
                break;
              default:
                color1 = Color.LightGreen;
                break;
            }
            this.strokeColor = color1;
            num1 = 8;
            continue;
          case 3:
            OrganizationShape.EaBigw0ucTOcAvP5ftX((object) this.Style, (object) new NStrokeStyle(this.strokeColor));
            num2 = 7;
            break;
          case 4:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 2;
            continue;
          case 5:
            if (mode == OrgShapeMode.Main)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 1 : 0;
              continue;
            }
            goto label_13;
          case 6:
            OrganizationShape.dHp9gfNzkT1SeixxVUT(OrganizationShape.tHM79bNH0TrruQVssQp((object) this), (object) new NColorFillStyle(this.fillColor));
            num1 = 3;
            continue;
          case 7:
            OrganizationShape.NpjkUk0bSfkwqBVcVRN(OrganizationShape.P2qDmG0wu67bWMrT3s6(OrganizationShape.tHM79bNH0TrruQVssQp((object) this)), new NLength(2));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 0 : 0;
            continue;
          case 8:
            Color color2;
            switch (mode)
            {
              case OrgShapeMode.Main:
                color2 = Color.FromArgb(240, 240, 240);
                break;
              case OrgShapeMode.Preview:
                color2 = OrganizationShape.xlXtUjN25KxprAH78hW(248, 248, 248);
                break;
              default:
                color2 = OrganizationShape.xlXtUjN25KxprAH78hW(248, (int) byte.MaxValue, 248);
                break;
            }
            this.fillColor = color2;
            num1 = 6;
            continue;
          case 9:
            goto label_19;
          default:
            OrganizationShape.p7gRPv0KDsyNxb9Kljk((object) this);
            num2 = 5;
            break;
        }
        num1 = num2;
      }
label_19:
      return;
label_13:;
    }

    public virtual void AddProtection()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        NAbilities nabilities;
        NInteractionStyle ninteractionStyle;
        while (true)
        {
          switch (num2)
          {
            case 1:
              OrganizationShape.pZMUgo0m9gTgSKQPWdp((object) this, ninteractionStyle);
              num2 = 2;
              continue;
            case 2:
              goto label_3;
            case 3:
              nabilities.ResizeY = true;
              num2 = 8;
              continue;
            case 4:
              nabilities.ResizeX = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 3 : 0;
              continue;
            case 5:
              nabilities = OrganizationShape.QyEtxa0RR75aUypPWQG((object) this);
              num2 = 4;
              continue;
            case 6:
              OrganizationShape.uFQx3t0o6QH32NF133A((object) this, nabilities);
              num2 = 7;
              continue;
            case 7:
              ninteractionStyle = OrganizationShape.gHXlwb0tevAC2hIB1MV((object) this);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 0 : 0;
              continue;
            case 8:
              goto label_8;
            default:
              ninteractionStyle.Mask = InteractionStyleMask.None;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 1 : 1;
              continue;
          }
        }
label_8:
        nabilities.InplaceEdit = false;
        num1 = 6;
      }
label_3:;
    }

    protected Color StrokeColor => this.strokeColor;

    protected Color FillColor => this.fillColor;

    protected override void CreateDefaultLabels()
    {
      int num = 1;
      OrgShapeLabel orgShapeLabel;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (this.mode != OrgShapeMode.Main)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            OrganizationShape.mJ1Sw00awKRlnCFnhCI(OrganizationShape.KVrUOt06lmDN67WyHh2((object) this), OrganizationShape.q3tElH0DmHX3XggETCG((object) orgShapeLabel));
            num = 5;
            continue;
          case 3:
            OrganizationShape.uPd0sU0kBOXdnRZV5m0(OrganizationShape.KVrUOt06lmDN67WyHh2((object) this), (object) orgShapeLabel);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 1 : 2;
            continue;
          case 4:
            orgShapeLabel = new OrgShapeLabel("", Guid.Empty, Nevron.Diagram.NMargins.Empty);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 3 : 3;
            continue;
          case 5:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_5:
      return;
label_2:
      return;
label_9:;
    }

    public virtual void AddPorts()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AddPort(ContentAlignment.MiddleLeft, (string) OrganizationShape.fifX780xQibaBqWpdkf(-296013529 ^ -296001113));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          case 2:
            this.AddPort(ContentAlignment.BottomCenter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1310136491 - -570921450 ^ -739235405));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 1 : 1;
            continue;
          case 3:
            this.AddPort(ContentAlignment.TopCenter, (string) OrganizationShape.fifX780xQibaBqWpdkf(-1028265253 << 4 ^ 727645494));
            num = 2;
            continue;
          case 4:
            goto label_2;
          default:
            this.AddPort(ContentAlignment.BottomRight, z2jc63fLkugS1X8Q9N.tE1kD1vbB(266768307 ^ 266788641));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 4 : 3;
            continue;
        }
      }
label_2:;
    }

    public void AddPort(ContentAlignment align, string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddPort(new NContentAlignment(align), name);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AddPort(float percX, float percY, string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddPort(new NContentAlignment(percX, percY), name);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AddPort(NContentAlignment align, string name)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            object obj = OrganizationShape.OIrP1O0CptH9g0wubd2((object) this);
            NRotatedBoundsPort node = new NRotatedBoundsPort(OrganizationShape.q3tElH0DmHX3XggETCG((object) this), align);
            OrganizationShape.ChMF3J0jaggRd3kdeB4((object) node, (object) name);
            ((NDiagramElementCollection) obj).AddChild((INNode) node);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 0 : 0;
            continue;
          case 2:
            OrganizationShape.z2KStR03IeQV8Qlx8Z8((object) this.Ports, false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            OrganizationShape.pFs5kc0iLJ2lyxvwIb3((object) this, ShapeElementsMask.Ports);
            num = 2;
            continue;
          case 5:
            if (OrganizationShape.OIrP1O0CptH9g0wubd2((object) this) == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 3 : 4;
              continue;
            }
            goto case 2;
          default:
            OrganizationShape.z2KStR03IeQV8Qlx8Z8(OrganizationShape.OIrP1O0CptH9g0wubd2((object) this), true);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool oIMjnXNnqqORpKTdy5S() => OrganizationShape.neSVg8NeApDQ69B1I0Z == null;

    internal static OrganizationShape A07ib4NLmBNsCnIZ7Fm() => OrganizationShape.neSVg8NeApDQ69B1I0Z;

    internal static Color xlXtUjN25KxprAH78hW([In] int obj0, [In] int obj1, [In] int obj2) => Color.FromArgb(obj0, obj1, obj2);

    internal static object tHM79bNH0TrruQVssQp([In] object obj0) => (object) ((NStyleableElement) obj0).Style;

    internal static void dHp9gfNzkT1SeixxVUT([In] object obj0, [In] object obj1) => ((NStyle) obj0).FillStyle = (NFillStyle) obj1;

    internal static void EaBigw0ucTOcAvP5ftX([In] object obj0, [In] object obj1) => ((NStyle) obj0).StrokeStyle = (NStrokeStyle) obj1;

    internal static object P2qDmG0wu67bWMrT3s6([In] object obj0) => (object) ((NStyle) obj0).StrokeStyle;

    internal static void NpjkUk0bSfkwqBVcVRN([In] object obj0, [In] NLength obj1) => ((NStrokeStyle) obj0).Width = obj1;

    internal static void p7gRPv0KDsyNxb9Kljk([In] object obj0) => ((OrganizationShape) obj0).AddProtection();

    internal static void hPTULF0UEs3kViwO6RL([In] object obj0) => ((OrganizationShape) obj0).AddPorts();

    internal static NAbilities QyEtxa0RR75aUypPWQG([In] object obj0) => ((NDiagramElement) obj0).Protection;

    internal static void uFQx3t0o6QH32NF133A([In] object obj0, [In] NAbilities obj1) => ((NDiagramElement) obj0).Protection = obj1;

    internal static NInteractionStyle gHXlwb0tevAC2hIB1MV([In] object obj0) => ((NShape) obj0).InteractionStyle;

    internal static void pZMUgo0m9gTgSKQPWdp([In] object obj0, [In] NInteractionStyle obj1) => ((NShape) obj0).InteractionStyle = obj1;

    internal static object KVrUOt06lmDN67WyHh2([In] object obj0) => (object) ((NShape) obj0).Labels;

    internal static void uPd0sU0kBOXdnRZV5m0([In] object obj0, [In] object obj1) => ((NDiagramElementCollection) obj0).AddChild((INNode) obj1);

    internal static Guid q3tElH0DmHX3XggETCG([In] object obj0) => ((NDiagramElement) obj0).UniqueId;

    internal static void mJ1Sw00awKRlnCFnhCI([In] object obj0, [In] Guid obj1) => ((NLabelCollection) obj0).DefaultLabelUniqueId = obj1;

    internal static object fifX780xQibaBqWpdkf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OIrP1O0CptH9g0wubd2([In] object obj0) => (object) ((NShape) obj0).Ports;

    internal static bool pFs5kc0iLJ2lyxvwIb3([In] object obj0, [In] ShapeElementsMask obj1) => ((NShape) obj0).CreateShapeElements(obj1);

    internal static void z2KStR03IeQV8Qlx8Z8([In] object obj0, [In] bool obj1) => ((NDiagramElementCollection) obj0).AutoGenerateUniqueNames = obj1;

    internal static void ChMF3J0jaggRd3kdeB4([In] object obj0, [In] object obj1) => ((NDiagramElement) obj0).Name = (string) obj1;
  }
}
