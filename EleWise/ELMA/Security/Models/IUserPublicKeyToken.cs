// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserPublicKeyToken
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
  /// <summary>Токен пользователя</summary>
  [FilterType(typeof (IUserPublicKeyTokenFilter))]
  [Filterable]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ShowInCatalogList(false)]
  [ImplementationUid("43d71923-4f4d-487e-b5fd-194ec9f74509")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [DisplayFormat(null)]
  [DisplayName(typeof (__Resources_IUserPublicKeyToken), "DisplayName")]
  [EleWise.ELMA.Model.Attributes.Uid("3b70fbaf-eb4c-46d5-a841-5f8e7a9748fb")]
  [TitleProperty("5e9ca1f5-8706-4ba3-b1ac-27b1d85bf898")]
  [Entity("UserPublicKeyToken")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>7d04e5ac-edf3-4759-93f3-d68d82376a65</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [MetadataType(typeof (EntityMetadata))]
  public interface IUserPublicKeyToken : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_Uid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("45c973d4-b388-4ee5-9433-2737ed563e7b")]
    Guid Uid { get; set; }

    /// <summary>Пользователь</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_User_DisplayName")]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("b0313769-297e-4c16-8732-723dcc5e72b5")]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    IUser User { get; set; }

    /// <summary>Дата создания</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [NotNull]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("c0bb8f0a-9179-4e20-902b-44a8272bdffd")]
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_CreationDate_DisplayName")]
    [DateTimeSettings(FieldName = "CreationDate", SetCurrentDate = true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime CreationDate { get; set; }

    /// <summary>Публичный ключ</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "PublicKey", MaxValueString = "2000")]
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_PublicKey_DisplayName")]
    [Order(4)]
    [StringRangeLength(0, "2000")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("ace993d7-fdd0-4448-a988-e0bf3c9dc3d1")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    string PublicKey { get; set; }

    /// <summary>Идентификатор устройства</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("9103d2d7-385f-4135-9f01-a15c3a5cb39f")]
    [StringSettings(FieldName = "DeviceId", MaxValueString = "2000")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(5)]
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_DeviceId_DisplayName")]
    [StringRangeLength(0, "2000")]
    string DeviceId { get; set; }

    /// <summary>Дата последнего использования</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("a9b2de09-3d8a-4a89-bd61-7f9dc1d8ab77")]
    [CanBeNull]
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_LastLogonDate_DisplayName")]
    [DateTimeSettings(FieldName = "LastLogonDate")]
    DateTime? LastLogonDate { get; set; }

    /// <summary>Наименование</summary>
    [DisplayName(typeof (__Resources_IUserPublicKeyToken), "P_Name_DisplayName")]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [StringRangeLength(0, "2000")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("5e9ca1f5-8706-4ba3-b1ac-27b1d85bf898")]
    [Filterable]
    [StringSettings(FieldName = "Name", MaxValueString = "2000")]
    [Order(1)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    string Name { get; set; }
  }
}
