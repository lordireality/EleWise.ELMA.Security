// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.OrganizationItemFindMode
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Режим поиска по оргструктуре</summary>
  [DefaultValueUid("48ff3773-ca34-4476-97a2-3e82b874c891")]
  [Uid("da2d0b29-7b1c-4e2b-b0f0-9675da93e54d")]
  [DisplayName(typeof (__Resources_OrganizationItemFindMode), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  public enum OrganizationItemFindMode
  {
    /// <summary>По дереву оргструктуры</summary>
    /// <remarks>
    /// Поиск ведется по дереву оргструктуры, начиная с указнной должности
    /// </remarks>
    [DisplayName(typeof (__Resources_OrganizationItemFindMode), "P_ByTree_DisplayName"), Description(typeof (__Resources_OrganizationItemFindMode), "P_ByTree_Description"), Uid("48ff3773-ca34-4476-97a2-3e82b874c891")] ByTree,
    /// <summary>По должности</summary>
    /// <remarks>Поиск ведется по полному совпадению должности</remarks>
    [Description(typeof (__Resources_OrganizationItemFindMode), "P_ByItem_Description"), DisplayName(typeof (__Resources_OrganizationItemFindMode), "P_ByItem_DisplayName"), Uid("6698dc6f-86eb-48d9-8fab-c30ba6274acc")] ByItem,
  }
}
