// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.API.IPublicClientCacheToken
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
  /// <summary>Токен кэша для запроса</summary>
  /// <remarks>
  /// Создается для каждого уникального запроса в каждой сессии
  /// </remarks>
  [DisplayName(typeof (__Resources_IPublicClientCacheToken), "DisplayName")]
  [Uid("0197546b-b371-4dd7-9c92-ac64c02bf0aa")]
  [Description(typeof (__Resources_IPublicClientCacheToken), "Description")]
  [TitleProperty("f9c8f420-167c-4a53-81a4-e0643b841c0e")]
  [DisplayFormat(null)]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>d05096de-85bf-4175-a00d-82710abd4afe</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [Filterable]
  [MetadataType(typeof (EntityMetadata))]
  [Entity("PublicClientCacheToken")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInTypeTree(false)]
  [NonUnique]
  [CacheEntity]
  [FilterType(typeof (IPublicClientCacheTokenFilter))]
  [ImplementationUid("ce0353fa-19fa-4c2a-bfe4-a40624492d50")]
  [ShowInDesigner(false)]
  [InterfaceImplementation("EleWise.ELMA.API.Models.IPublicClientCacheToken")]
  public interface IPublicClientCacheToken : 
    IEntity<long>,
    IEntity,
    IIdentified,
    EleWise.ELMA.API.Models.IPublicClientCacheToken
  {
    /// <summary>Сессия</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [Required(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "2cdaf156-7742-4294-89cb-2ad63250efd8")]
    [Uid("4e682316-4c15-4a81-b7de-abc0cfd84c93")]
    [Filterable]
    [DisplayName(typeof (__Resources_IPublicClientCacheToken), "P_Session_DisplayName")]
    [RequiredField]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Session")]
    IPublicClientSession Session { get; set; }

    /// <summary>Ключ токена</summary>
    /// <remarks>Создается из значения</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Required(true)]
    [EntityProperty]
    [Filterable]
    [NotNull]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Uid("2c25b3c3-e50c-4f77-85eb-4d8d672d5e8d")]
    [Order(1)]
    [DisplayName(typeof (__Resources_IPublicClientCacheToken), "P_TokenKey_DisplayName")]
    [Description(typeof (__Resources_IPublicClientCacheToken), "P_TokenKey_Description")]
    [GuidSettings(FieldName = "TokenKey")]
    [RequiredField]
    new Guid TokenKey { get; set; }

    /// <summary>Значение токена</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "TokenValue")]
    [RequiredField]
    [Uid("f9c8f420-167c-4a53-81a4-e0643b841c0e")]
    [Order(2)]
    [Required(true)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [DisplayName(typeof (__Resources_IPublicClientCacheToken), "P_TokenValue_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    new string TokenValue { get; set; }

    /// <summary>Время последнего доступа</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Order(3)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [Required(true)]
    [NotNull]
    [DisplayName(typeof (__Resources_IPublicClientCacheToken), "P_LastAccess_DisplayName")]
    [RequiredField]
    [DateTimeSettings(FieldName = "LastAccess")]
    [Uid("83ce0601-ca4e-47af-9c63-712969a5aa85")]
    new DateTime LastAccess { get; set; }
  }
}
