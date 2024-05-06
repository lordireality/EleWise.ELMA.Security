// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IPersonalGroupFilter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Фильтр для объекта "Набор пользователей"</summary>
  [FilterFor(typeof (IPersonalGroup))]
  public interface IPersonalGroupFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Пользователь"</summary>
    [Uid("0258083a-809b-4e44-8fd7-2db5dea34b85")]
    IUser Owner { get; set; }

    /// <summary>Фильтр для свойства "Название"</summary>
    [Uid("4fd1e379-fb9c-4e3f-ac7d-fb0c7e362858")]
    string Name { get; set; }
  }
}
