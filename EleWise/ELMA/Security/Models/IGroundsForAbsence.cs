// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IGroundsForAbsence
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Основание для отсутствия на рабочем месте</summary>
  [TitleProperty("6dcb9430-bdda-43da-98a1-ff0716d4176c")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>f6f82f64-bae9-4078-a5fc-719ab65813e7</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("GroundsForAbsence")]
  [EleWise.ELMA.Model.Attributes.Uid("a79c6d13-4dba-4d51-a1e8-3f5a407985e4")]
  [DisplayName(typeof (__Resources_IGroundsForAbsence), "DisplayName")]
  [DisplayFormat(null)]
  [MetadataType(typeof (EntityMetadata))]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(true)]
  [FilterType(typeof (IGroundsForAbsenceFilter))]
  [ImplementationUid("22110e9d-290a-4801-9de7-9a80caef27dd")]
  [Filterable]
  public interface IGroundsForAbsence : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [NotNull]
    [SystemProperty]
    [DisplayName(typeof (__Resources_IGroundsForAbsence), "P_Uid_DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("58cf5f27-0c6e-4d1c-8f79-ccf8a99b5e46")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    Guid Uid { get; set; }

    /// <summary>Наименование</summary>
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("6dcb9430-bdda-43da-98a1-ff0716d4176c")]
    [Order(1)]
    [EntityProperty]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IGroundsForAbsence), "P_Name_DisplayName")]
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Filterable]
    [StringSettings(FieldName = "Name")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [FastSearch(true)]
    string Name { get; set; }
  }
}
