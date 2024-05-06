// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserCryptoProfile
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Крипто настройки пользователя</summary>
  [DisplayName(typeof (__Resources_IUserCryptoProfile), "DisplayName")]
  [DisplayFormat(null)]
  [EleWise.ELMA.Model.Attributes.Uid("9906e130-eb5a-4221-b80e-db0e9e11dd5c")]
  [ShowInCatalogList(false)]
  [MetadataType(typeof (EntityMetadata))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [Entity("UserCryptoProfile")]
  [ShowInDesigner(false)]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>e327a04e-00d1-41eb-944e-d4a889a8118d</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ImplementationUid("eb3117da-3066-45ec-8219-863b988174d6")]
  public interface IUserCryptoProfile : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [DisplayName(typeof (__Resources_IUserCryptoProfile), "P_Uid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("ddb9ba60-7e41-415f-b4f1-95e6d49f1ba6")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Криптопровайдер авторизации</summary>
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [CanBeNull]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("b50a39be-0bd6-4a49-b2f7-d32fb11b74a4")]
    [DisplayName(typeof (__Resources_IUserCryptoProfile), "P_AuthCryptoProviderGuid_DisplayName")]
    [GuidSettings(FieldName = "AuthCryptoProviderGuid")]
    Guid? AuthCryptoProviderGuid { get; set; }

    /// <summary>Пользователь</summary>
    [DisplayName(typeof (__Resources_IUserCryptoProfile), "P_User_DisplayName")]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EleWise.ELMA.Model.Attributes.Uid("618eb431-2d0c-4fe0-a349-a411ceac5d75")]
    [Order(2)]
    IUser User { get; set; }

    /// <summary>Тип электронной подписи при авторизации</summary>
    [GuidSettings(FieldName = "AuthDigitalSignatureTypeGuid")]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [CanBeNull]
    [DisplayName(typeof (__Resources_IUserCryptoProfile), "P_AuthDigitalSignatureTypeGuid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Order(3)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Uid("c697c153-67df-4d9d-9dc7-ce58d2efc3d1")]
    Guid? AuthDigitalSignatureTypeGuid { get; set; }
  }
}
