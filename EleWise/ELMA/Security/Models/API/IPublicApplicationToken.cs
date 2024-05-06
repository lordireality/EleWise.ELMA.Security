// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.API.IPublicApplicationToken
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

namespace EleWise.ELMA.Security.Models.API
{
  /// <summary>Токен доступа публичного приложения</summary>
  [ShowInCatalogList(false)]
  [InterfaceImplementation("EleWise.ELMA.API.Models.IPublicApplicationToken")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>4bb573aa-665b-41bf-a73e-9e57118724ac</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("PublicApplicationToken")]
  [CacheEntity]
  [FilterType(typeof (IPublicApplicationTokenFilter))]
  [ImplementationUid("239503ef-06a0-440c-bd23-e873f5b47a69")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [Filterable]
  [ShowInDesigner(false)]
  [EleWise.ELMA.Model.Attributes.Uid("69334e6e-2d55-4665-94e1-1de241bfa9ce")]
  [MetadataType(typeof (EntityMetadata))]
  [DisplayName(typeof (__Resources_IPublicApplicationToken), "DisplayName")]
  [ShowInTypeTree(false)]
  [DisplayFormat(null)]
  public interface IPublicApplicationToken : 
    IEntity<long>,
    IEntity,
    IIdentified,
    EleWise.ELMA.API.Models.IPublicApplicationToken
  {
    /// <summary>Уникальный идентификатор</summary>
    [DisplayName(typeof (__Resources_IPublicApplicationToken), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("33179be2-1248-4e66-952b-1a50c458260f")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Приложение</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1817c965-17ce-4463-86b5-08deb0f4b04e")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Application")]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("bfec7811-b7c0-47c8-9f0b-8e085c9a2f00")]
    [Order(1)]
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Sortable(false)]
    [DisplayName(typeof (__Resources_IPublicApplicationToken), "P_Application_DisplayName")]
    IPublicApplication Application { get; set; }

    /// <summary>Токен</summary>
    [StringSettings(FieldName = "Token", MaxValueString = "128")]
    [RequiredField]
    [StringRangeLength(0, "128")]
    [EleWise.ELMA.Model.Attributes.Uid("4ad2eb4b-7c6d-48dc-89ff-71c2dcc7a4d7")]
    [Required(true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(2)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IPublicApplicationToken), "P_Token_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    new string Token { get; set; }

    /// <summary>Истекает</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IPublicApplicationToken), "P_Expire_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [NotNull]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("bcce6641-f826-4615-bed1-ca80ac215953")]
    [Required(true)]
    [RequiredField]
    [DateTimeSettings(FieldName = "Expire")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    new DateTime Expire { get; set; }

    /// <summary>Системный</summary>
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [BoolSettings(FieldName = "IsSystem")]
    [RequiredField]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("66aa129e-ed32-4e5a-a9c1-400234650afb")]
    [Order(4)]
    [NotNull]
    [Filterable]
    [EntityProperty]
    [DisplayName(typeof (__Resources_IPublicApplicationToken), "P_IsSystem_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    bool IsSystem { get; set; }
  }
}
