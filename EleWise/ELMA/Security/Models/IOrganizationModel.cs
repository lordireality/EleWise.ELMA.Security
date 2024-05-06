// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IOrganizationModel
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
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Types.Settings;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Модель оргструктуры</summary>
  /// <remarks>Модель определенной версии оргструктуры</remarks>
  [IdType("d6b44bce-b236-424d-aa74-d80da3c8db75")]
  [Entity("OrganizationModel")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>698630b9-e398-4dfa-8edc-19349e1be0eb</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ImplementationUid("a847e9c1-72f1-47e3-b992-05d690b5c7a6")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ShowInCatalogList(false)]
  [DisplayName(typeof (__Resources_IOrganizationModel), "DisplayName")]
  [EleWise.ELMA.Model.Attributes.Uid("d8723c93-0e32-4859-912c-4256a7d3ee9b")]
  [MetadataType(typeof (EntityMetadata))]
  [TitleProperty("a54381ca-41bc-48b5-8133-7304c8765a81")]
  [DisplayFormat("Ver.{Id}")]
  [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IOrganizationModel), "Description")]
  public interface IOrganizationModel : IEntity<int>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("1bbdc9f5-d0bf-4c30-a9d2-9ce2958b5b9a")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_Uid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    Guid Uid { get; set; }

    /// <summary>Диаграмма</summary>
    [EleWise.ELMA.Model.Attributes.Uid("ede12070-0ae2-4ad1-a1cf-e8eb98ebce0c")]
    [OrganizationDiagramTypeSettings(FieldName = "Diagram")]
    [Property("c977bd31-07d1-4ba2-ab9c-5049d363a923")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_Diagram_DisplayName")]
    [Order(2)]
    [EntityProperty]
    OrganizationDiagram Diagram { get; set; }

    /// <summary>Описание</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("2f05ac61-0051-4035-be7f-6f3b2420dfe4")]
    [StringRangeLength(0, "255")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_Description_DisplayName")]
    [EntityProperty]
    [StringSettings(FieldName = "Description", MaxValueString = "255", MultiLine = true)]
    string Description { get; set; }

    /// <summary>Дата создания</summary>
    /// <remarks>Дата создания (черновика) или дата публикации</remarks>
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IOrganizationModel), "P_CreationDate_Description")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_CreationDate_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [NotNull]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("bcc16d1e-b653-4a9f-8dcb-20d76f66e18f")]
    [Required(true)]
    [RequiredField]
    [DateTimeSettings(FieldName = "CreationDate", SetCurrentDate = true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime CreationDate { get; set; }

    /// <summary>Автор создания</summary>
    /// <remarks>Автор создания (для черновика) или автор публикации</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IOrganizationModel), "P_CreationAuthor_Description")]
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("839729f2-5e6a-4627-a1fb-6a617399feff")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_CreationAuthor_DisplayName")]
    [EntityUserSettings(FieldName = "CreationAuthor")]
    IUser CreationAuthor { get; set; }

    /// <summary>Наименование</summary>
    [CalculateType(PropertyCalculateType.CSScript)]
    [StringSettings(FieldName = "Name")]
    [CalculateScript("Id > 1 ? \"Organization v.\" + (Id - 1) : \"Organization draft\"")]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("a54381ca-41bc-48b5-8133-7304c8765a81")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Required(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [FastSearch(true)]
    [EntityProperty]
    [Filterable]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_Name_DisplayName")]
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    string Name { get; set; }

    /// <summary>Дата изменения</summary>
    /// <remarks>Дата изменения черновика</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IOrganizationModel), "P_ChangeDate_Description")]
    [CanBeNull]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("8d5a1b94-7264-42e8-914b-9630720f8916")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_ChangeDate_DisplayName")]
    [DateTimeSettings(FieldName = "ChangeDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime? ChangeDate { get; set; }

    /// <summary>Автор изменения</summary>
    /// <remarks>Автор изменения черновика</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Filterable]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("8a7d3cf5-80c4-4c94-abf9-f5955d9e5a02")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IOrganizationModel), "P_ChangeAuthor_Description")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_ChangeAuthor_DisplayName")]
    [EntityUserSettings(FieldName = "ChangeAuthor")]
    IUser ChangeAuthor { get; set; }

    /// <summary>SubDiagrams</summary>
    /// <remarks>Диаграмы вложенных оргструктур</remarks>
    [OrganizationSubDiagramTypeSettings(FieldName = "SubDiagrams")]
    [DisplayName(typeof (__Resources_IOrganizationModel), "P_SubDiagrams_DisplayName")]
    [Property("1f571770-0498-4192-a076-c987a3a265f8")]
    [EleWise.ELMA.Model.Attributes.Uid("2411b2cd-f507-4616-864f-fd4fd90e4368")]
    [Order(8)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IOrganizationModel), "P_SubDiagrams_Description")]
    OrganizationSubDiagram SubDiagrams { get; set; }
  }
}
