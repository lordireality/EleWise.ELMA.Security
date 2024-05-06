// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Models.OrganizationItemDTO
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.DTO.Models
{
  /// <summary>DTO для элемнента оргструктуры</summary>
  [Serializable]
  public class OrganizationItemDTO : 
    EntityDTO<long, IOrganizationItem>,
    IIdentity,
    IGenericIdentity<Guid>
  {
    public const string UID_S = "e502f586-afd4-4f55-bedb-f71028ffd302";
    public const string IMPL_UID_S = "dfb7b232-140c-4aba-bff2-c5ccee293088";
    private static OrganizationItemDTO qAJhgkiX8D2C9IiccjY;

    /// <summary>Уникальный идентификатор типа элемента оргструктуры</summary>
    public static Guid MetadataUid => new Guid((string) OrganizationItemDTO.cUYveEiMSnGs3SKcsij(-1958977588 ^ -1958997670));

    /// <summary>
    /// Уникальный идентификатор метаданных реализации элемента оргструктуры
    /// </summary>
    public static Guid ImplMetadataUid => new Guid((string) OrganizationItemDTO.cUYveEiMSnGs3SKcsij(1762575989 ^ 1762560151));

    /// <summary>Название</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
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

    /// <summary>Идентификатор родительского элемента</summary>
    public long ParentItemId
    {
      get => this.\u003CParentItemId\u003Ek__BackingField;
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
              this.\u003CParentItemId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 0 : 0;
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

    /// <summary>Тип элемента</summary>
    public OrganizationItemType ItemType
    {
      get => this.\u003CItemType\u003Ek__BackingField;
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
              this.\u003CItemType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 0 : 0;
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

    /// <summary>Подчиненные элементы оргструктуры</summary>
    public List<OrganizationItemDTO> Items { get; set; }

    /// <summary>Уникальный идентификатор</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 0 : 0;
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

    /// <summary>Конструктор</summary>
    public OrganizationItemDTO()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<OrganizationItemDTO>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    Guid IGenericIdentity<Guid>.Id => this.Uid;

    internal static object cUYveEiMSnGs3SKcsij(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool aXYDqsi9Z6w15Ss4nrv() => OrganizationItemDTO.qAJhgkiX8D2C9IiccjY == null;

    internal static OrganizationItemDTO FGK4S9i1uRrZiBKtkVs() => OrganizationItemDTO.qAJhgkiX8D2C9IiccjY;
  }
}
