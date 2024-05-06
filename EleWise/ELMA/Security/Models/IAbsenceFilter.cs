// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IAbsenceFilter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Фильтр для объекта "Отсутствие пользователя"</summary>
  [FilterFor(typeof (IAbsence))]
  public interface IAbsenceFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Дата начала"</summary>
    DateTimeRange StartDate { get; set; }

    /// <summary>Фильтр для свойства "Дата завершения"</summary>
    DateTimeRange EndDate { get; set; }

    /// <summary>Фильтр для свойства "Комментарий"</summary>
    string Description { get; set; }

    /// <summary>Фильтр для свойства "Статус"</summary>
    AbsenceStatus? Status { get; set; }

    /// <summary>
    /// Фильтр для свойства "Основание для отсутствия на рабочем месте"
    /// </summary>
    ISet<IGroundsForAbsence> Grounds { get; set; }

    /// <summary>Отсутствующий (старый)</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Obsolete("Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Users", true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"Obsolete\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:string\">Устаревшее свойство, будет удалено в ближайших версиях. Используйте свойство Users</Value>\r\n    </Parameter>\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">true</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Uid("20d8dc15-ba6a-4429-a489-efcacda74478")]
    [CustomFilterProperty]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [DisplayName(typeof (__Resources_IAbsence), "FP_User_DisplayName")]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
    IUser User { get; set; }

    /// <summary>Отсутствующий</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IAbsence), "FP_Users_DisplayName")]
    [Uid("df69a44a-8476-4ab8-8049-4757cde0facc")]
    [CustomFilterProperty]
    [Order(1)]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, ChildColumnName = "Child", ParentColumnName = "Parent", RelationType = RelationType.ManyToMany)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    ISet<IUser> Users { get; set; }
  }
}
