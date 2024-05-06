// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Diagrams.Elements.OrganizationElement
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Diagrams.Elements
{
  /// <summary>Элемент оргструктуры</summary>
  [Serializable]
  public abstract class OrganizationElement : Element2D
  {
    private List<OrganizationElement> composition;
    internal static OrganizationElement cR3laTZW7tx04WRUljB;

    /// <summary>Количество сотрудников</summary>
    public string EmployeeCount
    {
      get => this.\u003CEmployeeCount\u003Ek__BackingField;
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
              this.\u003CEmployeeCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
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

    /// <summary>Состав отдела (или подчиненные для должности)</summary>
    public List<OrganizationElement> Composition
    {
      get => this.composition;
      set => this.composition = value;
    }

    /// <summary>Получить подчиненные элементы оргструктуры</summary>
    /// <returns>Список элементов оргструктуры</returns>
    public IList<OrganizationElement> GetChildElements()
    {
      List<OrganizationElement> childElements = new List<OrganizationElement>();
      if (this.OutputConnectors != null)
      {
        foreach (Connector outputConnector in this.OutputConnectors)
        {
          if (outputConnector.EndElement != null && outputConnector.EndElement is OrganizationElement endElement)
            childElements.Add(endElement);
        }
      }
      return (IList<OrganizationElement>) childElements;
    }

    public override void OnCopied(Dictionary<Guid, Element> copiedElements = null)
    {
      base.OnCopied(copiedElements);
      if (this.composition == null)
        return;
      foreach (OrganizationElement organizationElement in this.composition)
      {
        organizationElement.Uid = Guid.NewGuid();
        organizationElement.OnCopied(copiedElements);
      }
    }

    protected OrganizationElement()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.composition = new List<OrganizationElement>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bZbedOZrW50uvJFfD8l() => OrganizationElement.cR3laTZW7tx04WRUljB == null;

    internal static OrganizationElement rQGvsSZSyyM8CpTpXbK() => OrganizationElement.cR3laTZW7tx04WRUljB;
  }
}
