// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserSecurityProfile
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
  /// <summary>Профиль безопасности пользователя</summary>
  [ShowInTypeTree(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ShowInCatalogList(false)]
  [DisplayName(typeof (__Resources_IUserSecurityProfile), "DisplayName")]
  [CopyAction(CopyAction.ByRef)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInDesigner(false)]
  [DisplayFormat(null)]
  [Entity("UserSecurityProfile")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>74dfa576-6d85-48d0-9228-9ce6b3fc1455</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ActionsType(typeof (UserSecurityProfileActions))]
  [CacheEntity]
  [ImplementationUid("35e3f240-be41-4c38-abac-1c6e1f457967")]
  [EleWise.ELMA.Model.Attributes.Uid("d63b1930-cbce-4d65-85a0-1a30b221bbbc")]
  [MetadataType(typeof (EntityMetadata))]
  public interface IUserSecurityProfile : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("f5168a72-a4a0-4944-ac07-750631886dd5")]
    [SystemProperty]
    [EntityProperty]
    Guid Uid { get; set; }

    /// <summary>Пользователь</summary>
    [Order(1)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("2390ebb1-537c-4651-b976-548e4fd654cd")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EntityProperty]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_User_DisplayName")]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "User")]
    IUser User { get; set; }

    /// <summary>Пароль</summary>
    [StringRangeLength(0, "2000")]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_Password_DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "Password", MaxValueString = "2000")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Uid("20da2488-5aef-4e2e-b60f-e6f2ef281d84")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Order(3)]
    string Password { get; set; }

    /// <summary>Принудительная смена пароля</summary>
    [Order(5)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "ForcedChangePassword")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("cb74bbad-a4ef-4231-bfe7-699172072bb4")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_ForcedChangePassword_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    bool ForcedChangePassword { get; set; }

    /// <summary>Дата/время последнего изменения пароля</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_LastDateChangePassword_DisplayName")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DateTimeSettings(FieldName = "LastDateChangePassword")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("789e7cae-bd1b-4368-96e8-ca00ffdcf039")]
    [Order(6)]
    [CanBeNull]
    DateTime? LastDateChangePassword { get; set; }

    /// <summary>Количество неудачных входов</summary>
    [Int64Settings(DefaultValueStr = "0", FieldName = "CountFailedLogon")]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_CountFailedLogon_DisplayName")]
    [Order(7)]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [EleWise.ELMA.Model.Attributes.Uid("445dc224-d780-44e3-a3b0-7cc6c8eb947f")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [NotNull]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    long CountFailedLogon { get; set; }

    /// <summary>Дата/время последнего неудачного входа</summary>
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_DateLastFailedLogon_DisplayName")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [CanBeNull]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [DateTimeSettings(FieldName = "DateLastFailedLogon")]
    [Order(8)]
    [EleWise.ELMA.Model.Attributes.Uid("8df416c8-96ea-4ae1-9a59-504dfaba4938")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    DateTime? DateLastFailedLogon { get; set; }

    /// <summary>Запретить вход</summary>
    /// <remarks>
    /// Выставляется по достижению лимита неудачных попыток входа
    /// </remarks>
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [NotNull]
    [Order(2)]
    [BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "DisallowLogon")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Description(typeof (__Resources_IUserSecurityProfile), "P_DisallowLogon_Description")]
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_DisallowLogon_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("19af9fd2-736c-496e-9ea1-539bc8e0e572")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    bool DisallowLogon { get; set; }

    /// <summary>Соль</summary>
    [DisplayName(typeof (__Resources_IUserSecurityProfile), "P_Salt_DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(4)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("779505ef-f18f-44e1-b243-3cc1f13eee5d")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [StringSettings(FieldName = "Salt")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    string Salt { get; set; }
  }
}
