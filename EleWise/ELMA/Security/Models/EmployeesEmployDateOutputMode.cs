// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.EmployeesEmployDateOutputMode
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Режим отображения дней принятия на работу сотрудников</summary>
  [DisplayName(typeof (__Resources_EmployeesEmployDateOutputMode), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("a35a7445-09be-445b-9c81-341960221f82")]
  public enum EmployeesEmployDateOutputMode
  {
    /// <summary>День назад</summary>
    [DisplayName(typeof (__Resources_EmployeesEmployDateOutputMode), "P_DayBehind_DisplayName"), Uid("125c5f35-01a6-4c33-8406-6134d15b35d0")] DayBehind,
    /// <summary>Неделю назад</summary>
    [Uid("f070f1b7-3faf-4928-a808-058a92fb2542"), DisplayName(typeof (__Resources_EmployeesEmployDateOutputMode), "P_WeekBehind_DisplayName")] WeekBehind,
    /// <summary>Месяц назад</summary>
    [DisplayName(typeof (__Resources_EmployeesEmployDateOutputMode), "P_MonthBehind_DisplayName"), Uid("8ec7398e-fa46-4237-939e-5586cf860784")] MonthBehind,
    /// <summary>С начала года</summary>
    [DisplayName(typeof (__Resources_EmployeesEmployDateOutputMode), "P_AfterTheYear_DisplayName"), Uid("c2bcf8a1-c36c-4122-878b-fc3dc57aa986")] AfterTheYear,
  }
}
