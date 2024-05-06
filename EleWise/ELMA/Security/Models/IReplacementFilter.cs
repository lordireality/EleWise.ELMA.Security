// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IReplacementFilter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Фильтр для объекта "Замещение"</summary>
  [FilterFor(typeof (IReplacement))]
  public interface IReplacementFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Замещаемый"</summary>
    IUser SourceUser { get; set; }

    /// <summary>Фильтр для свойства "Замещающий"</summary>
    IUser TargetUser { get; set; }

    /// <summary>Фильтр для свойства "Дата начала"</summary>
    DateTimeRange StartDate { get; set; }

    /// <summary>Фильтр для свойства "Статус"</summary>
    ReplacementStatus? Status { get; set; }

    /// <summary>Фильтр для свойства "Дата завершения"</summary>
    DateTimeRange EndDate { get; set; }
  }
}
