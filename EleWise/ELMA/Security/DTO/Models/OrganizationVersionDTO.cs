// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Models.OrganizationVersionDTO
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.DTO.Models
{
  /// <summary>DTO с информацией о версии модели оргструктуры</summary>
  [Serializable]
  public class OrganizationVersionDTO : EntityDTO<int>
  {
    private static OrganizationVersionDTO svvCtXiOrw4sSYpeQ44;

    /// <summary>Дата создания</summary>
    public virtual DateTime CreationDate
    {
      get => this.\u003CCreationDate\u003Ek__BackingField;
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
              this.\u003CCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
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

    /// <summary>Автор</summary>
    public virtual string CreationAuthor
    {
      get => this.\u003CCreationAuthor\u003Ek__BackingField;
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
              this.\u003CCreationAuthor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 0 : 0;
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

    /// <summary>Описание версии</summary>
    public virtual string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 0 : 0;
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

    public OrganizationVersionDTO()
    {
      OrganizationVersionDTO.kNu4bdivrVgb2OV8tdQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jb1WC8iT5ry2kFXZxwZ() => OrganizationVersionDTO.svvCtXiOrw4sSYpeQ44 == null;

    internal static OrganizationVersionDTO RAAh8diFC0VPtsKojao() => OrganizationVersionDTO.svvCtXiOrw4sSYpeQ44;

    internal static void kNu4bdivrVgb2OV8tdQ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
