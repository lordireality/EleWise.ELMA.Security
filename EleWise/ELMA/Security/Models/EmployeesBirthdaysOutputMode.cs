// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.EmployeesBirthdaysOutputMode
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Режим отображения дней рождения сотрудников</summary>
  [DisplayName(typeof (__Resources_EmployeesBirthdaysOutputMode), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("23e063d0-b8a9-4332-930b-24c759246c78")]
  public enum EmployeesBirthdaysOutputMode
  {
    /// <summary>Сегодня</summary>
    [DisplayName(typeof (__Resources_EmployeesBirthdaysOutputMode), "P_Today_DisplayName"), Uid("cc488948-e7f3-4e73-8264-01548e4327a9")] Today,
    /// <summary>Неделю вперед</summary>
    [DisplayName(typeof (__Resources_EmployeesBirthdaysOutputMode), "P_WeekAhead_DisplayName"), Uid("6f526827-e204-4f8e-863e-a7732ec6da48")] WeekAhead,
    /// <summary>Месяц вперед</summary>
    [Uid("64c7288d-4fdf-4650-84ee-e8e28af86e12"), DisplayName(typeof (__Resources_EmployeesBirthdaysOutputMode), "P_MonthAhead_DisplayName")] MonthAhead,
    /// <summary>До конца года</summary>
    [Uid("06733079-20c8-4680-abf4-48281a95ea47"), DisplayName(typeof (__Resources_EmployeesBirthdaysOutputMode), "P_BeforeTheYear_DisplayName")] BeforeTheYear,
  }
}
