// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.API.IClientSessionDataSets
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Models.API
{
  /// <summary>Привязанные к сессии клиента наборы данных</summary>
  /// <remarks>
  /// Наборы данных, привязанные к сессии клиента при первой синхронизации
  /// </remarks>
  [ShowInDesigner(false)]
  [ShowInTypeTree(false)]
  [InterfaceImplementation("EleWise.ELMA.API.Models.IClientSessionDataSets")]
  [MetadataType(typeof (EntityMetadata))]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>2d2fd8cc-4ed5-4f4c-a45c-e800c3727344</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Uid("6dd8c438-8b06-4af9-9300-f7e1eae65b45")]
  [Entity("ClientSessionDataSets")]
  [DisplayName(typeof (__Resources_IClientSessionDataSets), "DisplayName")]
  [DisplayFormat(null)]
  [Description(typeof (__Resources_IClientSessionDataSets), "Description")]
  [NonUnique]
  [ImplementationUid("392794f7-bf11-42ac-bdc4-e74f2d133af0")]
  [FilterType(typeof (IClientSessionDataSetsFilter))]
  [CacheEntity]
  [ShowInCatalogList(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [Filterable]
  [EntityMetadataType(EntityMetadataType.Interface)]
  public interface IClientSessionDataSets : 
    IEntity<long>,
    IEntity,
    IIdentified,
    EleWise.ELMA.API.Models.IClientSessionDataSets
  {
    /// <summary>Токен сессии</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "SessionToken", MaxValueString = "128")]
    [Required(true)]
    [Uid("6de6d64f-9656-4a1e-b00c-51cc72491df5")]
    [DisplayName(typeof (__Resources_IClientSessionDataSets), "P_SessionToken_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [RequiredField]
    [StringRangeLength(0, "128")]
    new string SessionToken { get; set; }

    /// <summary>DataSets</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
    [Order(1)]
    [Uid("1ea0acf0-195b-49c4-875a-f971d47421c7")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IClientSessionDataSets), "P_DataSets_DisplayName")]
    [ListOfSimpleTypeSettings(FieldName = "DataSets", SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    new List<Guid> DataSets { get; set; }
  }
}
