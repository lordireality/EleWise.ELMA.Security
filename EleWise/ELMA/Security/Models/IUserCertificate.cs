// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserCertificate
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
  /// <summary>Сертификат пользователя</summary>
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ShowInCatalogList(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [FilterType(typeof (IUserCertificateFilter))]
  [ImplementationUid("49e55af8-94f2-4dbe-8c01-7f7bf32fa9c3")]
  [Filterable]
  [Entity("UserCertificate")]
  [DisplayName(typeof (__Resources_IUserCertificate), "DisplayName")]
  [DisplayFormat(null)]
  [TitleProperty("da71afe1-1373-4a26-b37c-b0c19e3e1c24")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>3cf4b093-d95c-4683-a0ff-d8c11c30e267</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("185a99c9-5515-4216-ab06-2b80f6e6bb58")]
  public interface IUserCertificate : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [EntityProperty]
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("162a3719-f078-4e9a-bfcc-4a8b7533a822")]
    [NotNull]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    Guid Uid { get; set; }

    /// <summary>Отпечаток</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "Thumbprint", MaxValueString = "500")]
    [EleWise.ELMA.Model.Attributes.Uid("9e4bce95-9fec-4259-bf99-0981316595a4")]
    [Order(3)]
    [StringRangeLength(0, "500")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_Thumbprint_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    string Thumbprint { get; set; }

    /// <summary>Пользователь</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_User_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Filterable]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
    [EleWise.ELMA.Model.Attributes.Uid("6dac57a1-3763-4a13-a601-d390dfd70a8d")]
    [Order(4)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    IUser User { get; set; }

    /// <summary>Дата создания</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_CreationDate_DisplayName")]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("b1dbdb23-e400-4692-bb7e-0df2f03a8103")]
    [NotNull]
    [DateTimeSettings(FieldName = "CreationDate", SetCurrentDate = true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime CreationDate { get; set; }

    /// <summary>Дата последнего использования</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_LastTouchDate_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("b6de924f-2026-450d-9e66-69a517467dcb")]
    [CanBeNull]
    [DateTimeSettings(FieldName = "LastTouchDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime? LastTouchDate { get; set; }

    /// <summary>Наименование</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("da71afe1-1373-4a26-b37c-b0c19e3e1c24")]
    [StringSettings(FieldName = "Name", MaxValueString = "2000")]
    [StringRangeLength(0, "2000")]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_Name_DisplayName")]
    string Name { get; set; }

    /// <summary>Крипто действие</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [CanBeNull]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("cbb27926-71cd-47e4-a8f9-41b2b07f32af")]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_CryptoActionGuid_DisplayName")]
    [GuidSettings(FieldName = "CryptoActionGuid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    Guid? CryptoActionGuid { get; set; }

    /// <summary>Криптопровайдер</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [CanBeNull]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("3a649f5e-6af5-497a-92b2-e9c38c7fe16f")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_CryptoProviderGuid_DisplayName")]
    [GuidSettings(FieldName = "CryptoProviderGuid")]
    Guid? CryptoProviderGuid { get; set; }

    /// <summary>Является сертификатом по умолчанию?</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [BoolSettings(FieldName = "IsDefault")]
    [EleWise.ELMA.Model.Attributes.Uid("daf1e9b3-9548-40f5-bec9-860c3a9e598b")]
    [EntityProperty]
    [Order(8)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [CanBeNull]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUserCertificate), "P_IsDefault_DisplayName")]
    bool? IsDefault { get; set; }
  }
}
