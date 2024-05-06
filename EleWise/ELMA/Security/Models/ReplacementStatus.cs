// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.ReplacementStatus
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Статус замещения</summary>
  [DefaultValueUid("aaf05103-52a6-4724-a340-76cd2de74b1f")]
  [Uid("0ae225a8-01a2-464e-ad37-35972aaf467d")]
  [DisplayName(typeof (__Resources_ReplacementStatus), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  public enum ReplacementStatus
  {
    /// <summary>Активен</summary>
    [Uid("aaf05103-52a6-4724-a340-76cd2de74b1f"), DisplayName(typeof (__Resources_ReplacementStatus), "P_Active_DisplayName")] Active,
    /// <summary>Удален</summary>
    [DisplayName(typeof (__Resources_ReplacementStatus), "P_Delete_DisplayName"), Uid("1631194f-8fa9-457f-9e88-dc9054381c14")] Delete,
  }
}
