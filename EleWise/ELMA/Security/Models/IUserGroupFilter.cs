// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserGroupFilter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Фильтр для объекта "Группа пользователей"</summary>
  [FilterFor(typeof (IUserGroup))]
  public interface IUserGroupFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Группа по умолчанию"</summary>
    bool? AddToNewUser { get; set; }

    /// <summary>Список возможных групп</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Uid("cdc37d3c-90d0-4b18-b736-670b0802ef9c")]
    [CustomFilterProperty]
    [Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
    [DisplayName("SR.M('Список возможных групп')")]
    [AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<EleWise.ELMA.Security.Models.Worker>")]
    List<Worker> Workers { get; set; }
  }
}
