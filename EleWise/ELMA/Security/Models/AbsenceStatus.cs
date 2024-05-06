// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.AbsenceStatus
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Статус отсутствия</summary>
  /// <remarks>Значения статуса отсутствия, служебное свойство</remarks>
  [Uid("5af31f82-2104-4d1b-b028-a5996cad46e7")]
  [MetadataType(typeof (EnumMetadata))]
  [Description(typeof (__Resources_AbsenceStatus), "Description")]
  [DisplayName(typeof (__Resources_AbsenceStatus), "DisplayName")]
  public enum AbsenceStatus
  {
    /// <summary>Активный</summary>
    [Uid("31ce659b-3c44-4baf-9802-ed7ac8eae908"), DisplayName(typeof (__Resources_AbsenceStatus), "P_Active_DisplayName")] Active,
    /// <summary>Отменен</summary>
    [Uid("3f5a4838-dc59-42df-895b-83b0f8070df9"), DisplayName(typeof (__Resources_AbsenceStatus), "P_Closed_DisplayName")] Closed,
    /// <summary>Черновик</summary>
    [Uid("043797c2-b8fa-4cc1-b26a-34486ebae0d3"), DisplayName(typeof (__Resources_AbsenceStatus), "P_Draft_DisplayName")] Draft,
  }
}
