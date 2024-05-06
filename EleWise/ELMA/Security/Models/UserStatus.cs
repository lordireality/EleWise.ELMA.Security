// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.UserStatus
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Статус учетной записи пользователя</summary>
  [DisplayName(typeof (__Resources_UserStatus), "DisplayName")]
  [Uid("c9c37f37-f3f9-4e4d-b222-686bac63f049")]
  [MetadataType(typeof (EnumMetadata))]
  public enum UserStatus
  {
    /// <summary>Активна</summary>
    [DisplayName(typeof (__Resources_UserStatus), "P_Active_DisplayName"), Uid("16ca2fed-8273-4f19-82b3-ebc4fff7e118"), Image(typeof (UserStatus), "user", 16, ImageFormatType.IconPack, false)] Active = 0,
    /// <summary>Заблокирована</summary>
    [Uid("50a2a1de-fc9b-4d6d-b779-bb52fcd7b480"), Image(typeof (UserStatus), "user_blocked", 16, ImageFormatType.IconPack, false), DisplayName(typeof (__Resources_UserStatus), "P_Blocked_DisplayName")] Blocked = 1,
    /// <summary>Не подтверждена</summary>
    [Uid("1c186d5f-9ab7-4251-ab86-b57a914f91c1"), DisplayName(typeof (__Resources_UserStatus), "P_NotConfirmed_DisplayName"), Image(typeof (UserStatus), "user_warning", 16, ImageFormatType.IconPack, false)] NotConfirmed = 10, // 0x0000000A
    /// <summary>Системная</summary>
    [Image(typeof (UserStatus), "user_settings", 16, ImageFormatType.IconPack, false), Uid("6ee3218c-18de-4743-86d4-97e9bf806aba"), DisplayName(typeof (__Resources_UserStatus), "P_System_DisplayName")] System = 100, // 0x00000064
  }
}
