// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.API.IPublicClientSession
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

namespace EleWise.ELMA.Security.Models.API
{
  /// <summary>Постоянная сессия клиента</summary>
  /// <remarks>
  /// Сессия должна создаваться один раз для пары приложение - пользователь. Ключ сессии - это токен авторизации
  /// </remarks>
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [CacheEntity]
  [FilterType(typeof (IPublicClientSessionFilter))]
  [NonUnique]
  [Filterable]
  [ImplementationUid("f3ee68d7-fc22-4d1d-a9f1-48dc3b4123e1")]
  [Entity("PublicClientSession")]
  [Description(typeof (__Resources_IPublicClientSession), "Description")]
  [DisplayFormat(null)]
  [TitleProperty("6401a97e-d06b-46f0-8f3d-c722491efe6b")]
  [MetadataType(typeof (EntityMetadata))]
  [Uid("2cdaf156-7742-4294-89cb-2ad63250efd8")]
  [DisplayName(typeof (__Resources_IPublicClientSession), "DisplayName")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>b3de4a23-7d29-4286-bc8d-ccf7e7c994c8</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [InterfaceImplementation("EleWise.ELMA.API.Models.IPublicClientSession")]
  [ShowInDesigner(false)]
  [ShowInTypeTree(false)]
  public interface IPublicClientSession : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IPublicClientSession
  {
    /// <summary>Токен авторизации</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Uid("5f732fc8-5328-42d8-bf54-46f7e9d58339")]
    [Filterable]
    [NotNull]
    [EntityProperty]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_AuthToken_DisplayName")]
    [GuidSettings(FieldName = "AuthToken")]
    [RequiredField]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Required(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    new Guid AuthToken { get; set; }

    /// <summary>Токен авторизации клиента</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_ClientToken_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [Order(1)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Filterable]
    [RequiredField]
    [Required(true)]
    [Uid("0fddf46f-81b4-4ab6-9cdb-c3617e41e627")]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ClientToken")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "69334e6e-2d55-4665-94e1-1de241bfa9ce")]
    IPublicApplicationToken ClientToken { get; set; }

    /// <summary>Приложение</summary>
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "1817c965-17ce-4463-86b5-08deb0f4b04e")]
    [Required(true)]
    [Order(2)]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_Application_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Application")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Filterable]
    [EntityProperty]
    [Uid("ab0693ca-302a-467e-8350-1ca6e78ee8e0")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [RequiredField]
    IPublicApplication Application { get; set; }

    /// <summary>Авторизованный пользователь</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_AuthUser_DisplayName")]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [Required(true)]
    [Order(3)]
    [Uid("423fe569-d9c0-44b6-953e-65c53c8456c4")]
    [RequiredField]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "AuthUser")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EntityProperty]
    EleWise.ELMA.Security.Models.IUser AuthUser { get; set; }

    /// <summary>Время последнего обращения</summary>
    /// <remarks>Обновляется при обращении к сессии</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Description(typeof (__Resources_IPublicClientSession), "P_LastAccess_Description")]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_LastAccess_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Required(true)]
    [NotNull]
    [Order(4)]
    [RequiredField]
    [DateTimeSettings(FieldName = "LastAccess")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [EntityProperty]
    [Uid("dbd5d4ab-fc5b-4efe-a00d-cf9cbc31a623")]
    [Filterable]
    new DateTime LastAccess { get; set; }

    /// <summary>Токен сессии</summary>
    [Order(5)]
    [Uid("6401a97e-d06b-46f0-8f3d-c722491efe6b")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [Required(true)]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_SessionToken_DisplayName")]
    [StringRangeLength(0, "128")]
    [RequiredField]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [StringSettings(FieldName = "SessionToken", MaxValueString = "128")]
    [EntityProperty]
    [Filterable]
    new string SessionToken { get; set; }

    /// <summary>Последний запрос изменений</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_LastChangesPackage_DisplayName")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Order(6)]
    [Uid("b86ae295-32b5-4662-a742-88e20e1ca9f3")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [BlobSettings(FieldName = "LastChangesPackage")]
    new byte[] LastChangesPackage { get; set; }

    /// <summary>Секрет сессии</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [BlobSettings(FieldName = "Secret")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Order(7)]
    [Uid("37c12433-9bd8-4fea-8cc9-ca3ea11d09e8")]
    [Property("1911b22d-0ce2-4743-832f-6a44cb0357fe")]
    [Sortable(false)]
    [DisplayName(typeof (__Resources_IPublicClientSession), "P_Secret_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    byte[] Secret { get; set; }
  }
}
