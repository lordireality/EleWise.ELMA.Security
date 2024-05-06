// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.TrustedDeviceType
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Тип доверенного устройства</summary>
  [MetadataType(typeof (EnumMetadata))]
  [Uid("fbcf2a36-81c7-44ce-bb0f-37015940c32f")]
  [DisplayName(typeof (__Resources_TrustedDeviceType), "DisplayName")]
  [DefaultValueUid("932a727d-3933-487e-b607-fed6b05282bb")]
  public enum TrustedDeviceType
  {
    /// <summary>Простое устройство</summary>
    [DisplayName(typeof (__Resources_TrustedDeviceType), "P_TrustedDevice_DisplayName"), Uid("932a727d-3933-487e-b607-fed6b05282bb")] TrustedDevice,
    /// <summary>Токен</summary>
    [DisplayName(typeof (__Resources_TrustedDeviceType), "P_Token_DisplayName"), Uid("2d2b18b8-30cd-422d-ab44-80366872f00a")] Token,
    /// <summary>Сертификат</summary>
    [DisplayName(typeof (__Resources_TrustedDeviceType), "P_Certificate_DisplayName"), Uid("5ab0301a-bdd6-444e-9f3b-90de846e76fe")] Certificate,
  }
}
