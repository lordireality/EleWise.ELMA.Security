// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IReplacementRule
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
using EleWise.ELMA.Security.Types.Settings;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Правило замещения пользователя</summary>
  [ShowInCatalogList(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [Entity("ReplacementRule")]
  [FilterType(typeof (IReplacementRuleFilter))]
  [ImplementationUid("de0f13ad-5e29-4b46-938a-e5cbb16a644d")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c65135e8-ad17-4d9c-8408-0b183de5114f</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [EleWise.ELMA.Model.Attributes.Uid("bd759aff-f117-40b2-9c01-16b689a6b063")]
  [MetadataType(typeof (EntityMetadata))]
  [Filterable]
  [Image(typeof (IReplacementRule), "replacement_rule", 16, ImageFormatType.IconPack, false)]
  [DisplayFormat(null)]
  [DisplayName(typeof (__Resources_IReplacementRule), "DisplayName")]
  public interface IReplacementRule : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [EleWise.ELMA.Model.Attributes.Uid("7badb04a-bc82-4870-8e8b-cadfc150baf3")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [NotNull]
    [GuidSettings(FieldName = "Uid")]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_Uid_DisplayName")]
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    Guid Uid { get; set; }

    /// <summary>Название</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Order(1)]
    [Required(true)]
    [StringSettings(FieldName = "Name")]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_Name_DisplayName")]
    [RequiredField]
    [EleWise.ELMA.Model.Attributes.Uid("14aebaaf-5284-4924-9883-8ae19a0843f3")]
    string Name { get; set; }

    /// <summary>Фильтр</summary>
    [EleWise.ELMA.Model.Attributes.Order(5)]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_Filter_DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("b0e1bebe-3d9b-4547-a365-cf180485b497")]
    [Property("66c7898b-e56b-49e0-bfb8-9f9c4a7a0c52")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [XmlSerializableObjectSettings(FieldName = "Filter")]
    object Filter { get; set; }

    /// <summary>Замещающий</summary>
    /// <remarks>Замещающий пользователь</remarks>
    [EleWise.ELMA.Model.Attributes.Uid("951adad8-7ded-4aa3-8029-140af5a44103")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Order(3)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [Required(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_TargetUser_DisplayName")]
    [Description(typeof (__Resources_IReplacementRule), "P_TargetUser_Description")]
    [EntityUserSettings(CopyAction = CopyAction.ByRef, FieldName = "TargetUser")]
    IUser TargetUser { get; set; }

    /// <summary>Свойство</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_PropertyUid_DisplayName")]
    [GuidSettings(FieldName = "PropertyUid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("341f1f33-cb0c-4baf-b928-12fe032fba3c")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Order(4)]
    Guid PropertyUid { get; set; }

    /// <summary>Порядок</summary>
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("9655e87d-09c3-4dbd-974e-5f5c4a61ff2f")]
    [EleWise.ELMA.Model.Attributes.Order(6)]
    [Property("d6b44bce-b236-424d-aa74-d80da3c8db75")]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_Order_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Int32Settings(FieldName = "Order")]
    int Order { get; set; }

    /// <summary>Замещение</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [RequiredField]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, CopyAction = CopyAction.ByRef, FieldName = "Replacement")]
    [Required(true)]
    [DisplayName(typeof (__Resources_IReplacementRule), "P_Replacement_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("a628ce64-9933-40af-a8a3-f34c55bdee93")]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [EntityProperty]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c4fbe20f-1114-4198-a307-31b65cc84635")]
    IReplacement Replacement { get; set; }
  }
}
