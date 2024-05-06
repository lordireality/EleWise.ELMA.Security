// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.ReplacementMode
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Режим замещения</summary>
  [MetadataType(typeof (EnumMetadata))]
  [Uid("86788123-74ac-4149-96a8-0a7aae36d829")]
  [DisplayName(typeof (__Resources_ReplacementMode), "DisplayName")]
  public enum ReplacementMode
  {
    /// <summary>None</summary>
    [DisplayName(typeof (__Resources_ReplacementMode), "P_None_DisplayName"), Uid("a368a2da-1fe0-4d3c-9b58-0845652c790e")] None,
    /// <summary>Ручное замещение</summary>
    [Uid("006a6f8f-01ac-44ea-9ca0-85b7eeac4245"), DisplayName(typeof (__Resources_ReplacementMode), "P_ManualReplacement_DisplayName")] ManualReplacement,
    /// <summary>Автоматическое замещение</summary>
    [Uid("444d4c03-31c6-4c48-b595-242be806777e"), DisplayName(typeof (__Resources_ReplacementMode), "P_AutoReplacement_DisplayName")] AutoReplacement,
  }
}
