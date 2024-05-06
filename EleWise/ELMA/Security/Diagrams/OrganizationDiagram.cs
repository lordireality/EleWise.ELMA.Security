// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.OrganizationDiagram
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;

namespace EleWise.ELMA.Security.Diagrams
{
  /// <summary>Диаграмма оргструктуры</summary>
  [XmlRoot("OrganizationDiagram")]
  [XmlExport]
  [Serializable]
  public class OrganizationDiagram : EleWise.ELMA.Diagrams.Diagram
  {
    /// <summary>Имя формата для буфера обмена</summary>
    public const string ClipboardFormatNameConst = "OrganizationDiagramClipboardData";
    internal static OrganizationDiagram NgUIs53IIYYRJjPBtWv;

    public OrganizationDiagram()
    {
      OrganizationDiagram.Ig3lDR3L6Wde7mCAcSb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected OrganizationDiagram(SerializationInfo info, StreamingContext context)
    {
      OrganizationDiagram.Ig3lDR3L6Wde7mCAcSb();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Имя формата для буфера обмена</summary>
    public override string ClipboardFormatName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1762575989 ^ 1762563693);

    public event EventHandler ElementRemoving
    {
      add
      {
        int num = 3;
        EventHandler comparand;
        EventHandler eventHandler1;
        EventHandler eventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (eventHandler2 == comparand)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 2 : 4;
                continue;
              }
              goto case 2;
            case 2:
              comparand = eventHandler2;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
              continue;
            case 3:
              eventHandler2 = this.ElementRemoving;
              num = 2;
              continue;
            case 4:
              goto label_2;
            case 5:
              eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ElementRemoving, eventHandler1, comparand);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 0;
              continue;
            default:
              eventHandler1 = (EventHandler) OrganizationDiagram.euKYi632NArqs59Tm4p((object) comparand, (object) value);
              num = 5;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num1 = 5;
        while (true)
        {
          int num2 = num1;
          EventHandler eventHandler1;
          EventHandler comparand;
          EventHandler eventHandler2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_3;
              case 2:
                eventHandler1 = comparand - value;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 0 : 0;
                continue;
              case 3:
                if (eventHandler2 == comparand)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 0;
                  continue;
                }
                goto label_6;
              case 4:
                goto label_6;
              case 5:
                eventHandler2 = this.ElementRemoving;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 4 : 2;
                continue;
              default:
                eventHandler2 = Interlocked.CompareExchange<EventHandler>(ref this.ElementRemoving, eventHandler1, comparand);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 1 : 3;
                continue;
            }
          }
label_6:
          comparand = eventHandler2;
          num1 = 2;
        }
label_3:;
      }
    }

    /// <summary>Элемент добавлен</summary>
    protected new void InvokeElementInserted(object sender, EventArgs e)
    {
      int num = 2;
      EventHandler elementRemoving;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (elementRemoving != null)
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 2:
            elementRemoving = this.ElementRemoving;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 1 : 1;
            continue;
          case 3:
            elementRemoving(sender, e);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    public bool AllowNodeRemoving
    {
      get => this.\u003CAllowNodeRemoving\u003Ek__BackingField;
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
              this.\u003CAllowNodeRemoving\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 0;
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

    public bool NeedNodeRemoving
    {
      get => this.\u003CNeedNodeRemoving\u003Ek__BackingField;
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
              this.\u003CNeedNodeRemoving\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
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

    protected override void NodeRemoving(NChildNodeCancelEventArgs args)
    {
      int num = 3;
      Element element;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AllowNodeRemoving = false;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.NeedNodeRemoving)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 5 : 4;
              continue;
            }
            goto case 1;
          case 3:
            this.ExtractShapeAndElement(args.Child, out NShape _, out element);
            num = 2;
            continue;
          case 4:
            OrganizationDiagram.ONY6yi3HyHTdokVAwTB((object) args, true);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 6 : 3;
            continue;
          case 5:
            goto label_7;
          case 6:
            goto label_2;
          default:
            this.InvokeElementInserted((object) element, EventArgs.Empty);
            num = 4;
            continue;
        }
      }
label_7:
      return;
label_2:;
    }

    internal static void Ig3lDR3L6Wde7mCAcSb() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool yNl5EW3es6c2iKrZZl6() => OrganizationDiagram.NgUIs53IIYYRJjPBtWv == null;

    internal static OrganizationDiagram Yr6ARi3nSRu1srHERc9() => OrganizationDiagram.NgUIs53IIYYRJjPBtWv;

    internal static object euKYi632NArqs59Tm4p([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static void ONY6yi3HyHTdokVAwTB([In] object obj0, [In] bool obj1) => ((CancelEventArgs) obj0).Cancel = obj1;
  }
}
