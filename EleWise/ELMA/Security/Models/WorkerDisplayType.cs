// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.WorkerDisplayType
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Тип отображения исполнителя</summary>
  [MetadataAccessLevel(MetadataAccessLevel.EleWise)]
  [Uid("{3801A448-48D8-41D4-926F-38DC5AC6B80A}")]
  [MetadataType(typeof (EnumMetadata))]
  [DisplayName(typeof (__Resources_WorkerDisplayType), "DisplayName")]
  public enum WorkerDisplayType
  {
    /// <summary>Название должности</summary>
    [Uid("{A9B02885-1F64-4595-BA0E-81285AF2F416}"), DisplayName(typeof (__Resources_WorkerDisplayType), "P_Job_DisplayName"), MetadataAccessLevel(MetadataAccessLevel.EleWise)] Job,
    /// <summary>ФИО сотрудника</summary>
    [MetadataAccessLevel(MetadataAccessLevel.EleWise), DisplayName(typeof (__Resources_WorkerDisplayType), "P_UserName_DisplayName"), Uid("{A754A5D4-B629-4794-9CB0-FB6A213D907E}")] UserName,
    /// <summary>Другое</summary>
    [MetadataAccessLevel(MetadataAccessLevel.EleWise), DisplayName(typeof (__Resources_WorkerDisplayType), "P_Custom_DisplayName"), Uid("{8A5BEBB9-5B17-4540-867F-A0ADB2CE5E67}")] Custom,
  }
}
