// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.OrganizationItemType
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Тип элемента оргструктуры</summary>
  [DisplayName(typeof (__Resources_OrganizationItemType), "DisplayName")]
  [Uid("6557e077-71cd-4f73-b23a-eed2447ef0b0")]
  [MetadataType(typeof (EnumMetadata))]
  public enum OrganizationItemType
  {
    /// <summary>Отдел</summary>
    [DisplayName(typeof (__Resources_OrganizationItemType), "P_Department_DisplayName"), Uid("f4e4d32f-b8c2-43db-b385-293c60f180d9")] Department,
    /// <summary>Должность</summary>
    [DisplayName(typeof (__Resources_OrganizationItemType), "P_Position_DisplayName"), Uid("327b0966-8f7c-4a0d-b59e-4a60cf165271")] Position,
    /// <summary>Группа сотрудников</summary>
    [DisplayName(typeof (__Resources_OrganizationItemType), "P_EmployeeGroup_DisplayName"), Uid("b98d9657-f0b0-4dae-b0f9-a6bfd0074e9a")] EmployeeGroup,
    /// <summary>Вложенная структура</summary>
    /// <remarks>Вложенная структура</remarks>
    [DisplayName(typeof (__Resources_OrganizationItemType), "P_NestedStructure_DisplayName"), Description(typeof (__Resources_OrganizationItemType), "P_NestedStructure_Description"), Uid("d66ebd4f-f30b-4cb9-a9ce-9c6ac231dddd")] NestedStructure,
  }
}
