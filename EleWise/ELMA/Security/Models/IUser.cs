// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUser
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using Iesi.Collections.Generic;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Пользователь</summary>
  /// <remarks>Пользователь системы</remarks>
  [FilterType(typeof (IUserFilter))]
  [ActionsType(typeof (UserActions))]
  [EleWise.ELMA.Model.Attributes.Uid("cfdeb03c-35e9-45e7-aad8-037d83888f73")]
  [ImplementationUid("18faf3ae-03c9-4e64-b02a-95dd63e54c4d")]
  [Filterable]
  [CacheEntity]
  [CopyAction(CopyAction.ByRef)]
  [InterfaceImplementation("EleWise.ELMA.Security.IUser")]
  [Image(typeof (IUser), "user", 16, ImageFormatType.IconPack, false)]
  [CustomCode(typeof (IUser), "EleWise.ELMA.Security.Models.User.CustomCodeTemplate.cs")]
  [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "Description")]
  [DisplayFormat("{$LastName} {$FirstName} {$MiddleName}")]
  [TitleProperty("c626c090-cdc6-4d63-8c4e-d979db67bf9c")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [SaveHistory]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>76f26227-02a5-47d6-8299-430c880e15cd</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("User")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [DisplayName(typeof (__Resources_IUser), "DisplayName")]
  [MetadataType(typeof (EntityMetadata))]
  public interface IUser : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.Security.IUser
  {
    /// <summary>Часовой пояс</summary>
    TimeZoneModel TimeZone { get; }

    /// <summary>Пароль</summary>
    [Obsolete("Использовать UserSecurityProfile.Password", true)]
    string Password { get; set; }

    /// <summary>Uid</summary>
    /// <remarks>Уникальный идентификатор</remarks>
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("f21f96ad-8bc7-4064-ae81-16f681f5cb73")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_Uid_Description")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    [RequiredField]
    [DisplayName(typeof (__Resources_IUser), "P_Uid_DisplayName")]
    Guid Uid { get; set; }

    /// <summary>Учетная запись</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_UserName_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [ShowInTable(true)]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [FastSearch(true)]
    [StringRangeLength(1, "255")]
    [Order(2)]
    [Required(true)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("9e6ab696-3e3f-4bba-99ab-29207e4769f7")]
    [StringSettings(FieldName = "UserName", MaxValueString = "255", MinValue = 1)]
    [RequiredField]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    new string UserName { get; set; }

    /// <summary>Имя</summary>
    [StringSettings(FieldName = "FirstName", MaxValueString = "255")]
    [Order(3)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("b4da886b-e9c3-41dd-9328-afc88b3b5e9e")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Filterable]
    [ShowInTable(true)]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [StringRangeLength(0, "255")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_FirstName_DisplayName")]
    string FirstName { get; set; }

    /// <summary>Отчество</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [FastSearch(true)]
    [DisplayName(typeof (__Resources_IUser), "P_MiddleName_DisplayName")]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("81a2f017-f6bb-4995-9d19-acd8355a29b4")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringRangeLength(0, "255")]
    [StringSettings(FieldName = "MiddleName", MaxValueString = "255")]
    [ShowInTable(true)]
    [EntityProperty]
    [Filterable]
    string MiddleName { get; set; }

    /// <summary>Фамилия</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "LastName", MaxValueString = "255")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("771eae42-f798-418a-912d-3ae70be25f7c")]
    [Order(5)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_LastName_DisplayName")]
    [StringRangeLength(0, "255")]
    [ShowInTable(true)]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [FastSearch(true)]
    string LastName { get; set; }

    /// <summary>ФИО</summary>
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("c626c090-cdc6-4d63-8c4e-d979db67bf9c")]
    [Order(6)]
    [DisplayName(typeof (__Resources_IUser), "P_FullName_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [StringSettings(FieldName = "FullName", MaxValueString = "2000")]
    [StringRangeLength(0, "2000")]
    [CalculateScript("this.GetFullName()")]
    [CalculateType(PropertyCalculateType.CSScript)]
    new string FullName { get; set; }

    /// <summary>E-Mail</summary>
    [DisplayName(typeof (__Resources_IUser), "P_EMail_DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [FastSearch(true)]
    [EleWise.ELMA.Model.Attributes.Uid("aacbd8ca-d8c2-4d94-ba5a-35cfe43e2efb")]
    [StringSettings(FieldName = "EMail")]
    [Order(7)]
    new string EMail { get; set; }

    /// <summary>Дата рождения</summary>
    [EleWise.ELMA.Model.Attributes.Uid("8b285821-a34a-4a3c-9a2f-f4c41ced92dd")]
    [EntityProperty]
    [CanBeNull]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_BirthDate_DisplayName")]
    [Order(8)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DateTimeSettings(FieldName = "BirthDate", ShowTime = false)]
    DateTime? BirthDate { get; set; }

    /// <summary>Дата приема на работу</summary>
    [CanBeNull]
    [Order(9)]
    [EleWise.ELMA.Model.Attributes.Uid("22492b25-c5e2-40bf-9ed3-4b1e72a38f8a")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [DisplayName(typeof (__Resources_IUser), "P_EmployDate_DisplayName")]
    [DateTimeSettings(FieldName = "EmployDate", SetCurrentDate = true, ShowTime = false)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    DateTime? EmployDate { get; set; }

    /// <summary>Рабочий телефон</summary>
    [StringSettings(FieldName = "WorkPhone")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EntityProperty]
    [DisplayName(typeof (__Resources_IUser), "P_WorkPhone_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(10)]
    [EleWise.ELMA.Model.Attributes.Uid("06f917f6-d7f9-4572-9198-4463ac68d6c9")]
    [Filterable]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    string WorkPhone { get; set; }

    /// <summary>Мобильный телефон</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_MobilePhone_DisplayName")]
    [EntityProperty]
    [Filterable]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "MobilePhone")]
    [FastSearch(true)]
    [EleWise.ELMA.Model.Attributes.Uid("222c4f83-382a-48df-a28a-1339324afac4")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Order(11)]
    string MobilePhone { get; set; }

    /// <summary>Номер комнаты</summary>
    [EleWise.ELMA.Model.Attributes.Uid("598f605f-f96d-4f35-b4a0-65cee6f71f06")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [StringSettings(FieldName = "RoomNumber")]
    [DisplayName(typeof (__Resources_IUser), "P_RoomNumber_DisplayName")]
    [Order(12)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntityProperty]
    string RoomNumber { get; set; }

    /// <summary>Описание</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(13)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("ac782895-46d6-4360-92a5-5e3165db25e7")]
    [DisplayName(typeof (__Resources_IUser), "P_Description_DisplayName")]
    [StringSettings(FieldName = "Description", MultiLine = true)]
    string Description { get; set; }

    /// <summary>Skype</summary>
    [ShowInTable(true)]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(14)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [StringSettings(FieldName = "Skype")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("6818966f-1986-4d3b-bb46-5d7758210d20")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_Skype_DisplayName")]
    string Skype { get; set; }

    /// <summary>ICQ</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "ICQ")]
    [DisplayName(typeof (__Resources_IUser), "P_ICQ_DisplayName")]
    [EntityProperty]
    [Order(15)]
    [EleWise.ELMA.Model.Attributes.Uid("bbb8b195-1322-4e1f-bd0f-4af4d9637f89")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [FastSearch(true)]
    [Filterable]
    string ICQ { get; set; }

    /// <summary>Jabber ID</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [FastSearch(true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(16)]
    [EleWise.ELMA.Model.Attributes.Uid("ce381fe1-90cc-41df-89dc-d77cc3fbdcfb")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_JabberID_DisplayName")]
    [StringSettings(FieldName = "JabberID")]
    string JabberID { get; set; }

    /// <summary>Провайдер авторизации</summary>
    /// <remarks>
    /// Метод авторизации пользователей. При нулевом значении - используется стандартная авторизация, при ненулевом - используется авторизация LDAP/AD
    /// </remarks>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [DisplayName(typeof (__Resources_IUser), "P_AuthProviderGuid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [Filterable]
    [Required(true)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Order(17)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("3216fd17-52b4-448f-962e-bba4dd431aa8")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_AuthProviderGuid_Description")]
    [GuidSettings(FieldName = "AuthProviderGuid")]
    [RequiredField]
    new Guid AuthProviderGuid { get; set; }

    /// <summary>Должности</summary>
    /// <remarks>Должности, которые занимает данный пользователь</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_OrganizationItems_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Sortable(false)]
    [Order(18)]
    [EleWise.ELMA.Model.Attributes.Uid("b12af3bd-e6ef-455d-b155-dbe3467ab5a0")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_OrganizationItems_Description")]
    [OrganizationItemSettings(KeyColumnUidStr = "be1f5c48-fa8f-4bf0-ae4c-0ecdfd88052e", RelationType = RelationType.OneToMany)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    ISet<IOrganizationItem> OrganizationItems { get; set; }

    /// <summary>Группы сотрудников</summary>
    /// <remarks>
    /// Группы сотрудников, в которые входит данный пользователь
    /// </remarks>
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
    [OrganizationItemSettings(KeyColumnUidStr = "08f27ddc-aed6-4a7e-9745-befd0b354b1b", RelationType = RelationType.ManyToManyInverse)]
    [Order(19)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("60eccd59-f2b4-4497-9837-c7077b1000a7")]
    [DisplayName(typeof (__Resources_IUser), "P_OrganizationGroups_DisplayName")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_OrganizationGroups_Description")]
    [Sortable(false)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    ISet<IOrganizationItem> OrganizationGroups { get; set; }

    /// <summary>Замещающий</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_ReplacementUser_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(20)]
    [EleWise.ELMA.Model.Attributes.Uid("8e0ba2c6-880d-4604-af61-c4f71accb066")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EntityUserSettings(FieldName = "ReplacementUser")]
    IUser ReplacementUser { get; set; }

    /// <summary>Окончание замещения</summary>
    /// <remarks>Дата окончания завершения замещения</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_EndReplacement_Description")]
    [DisplayName(typeof (__Resources_IUser), "P_EndReplacement_DisplayName")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(22)]
    [EleWise.ELMA.Model.Attributes.Uid("f5a9ee10-64bd-473b-b69b-f6bff9c98ac4")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DateTimeSettings(FieldName = "EndReplacement", ShowTime = false)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [CanBeNull]
    DateTime? EndReplacement { get; set; }

    /// <summary>Режим замещения</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [NotNull]
    [Order(23)]
    [EleWise.ELMA.Model.Attributes.Uid("3835e8a1-4d05-4fb8-921d-39209d37addc")]
    [DisplayName(typeof (__Resources_IUser), "P_ReplacementMode_DisplayName")]
    [EnumSettings(FieldName = "ReplacementMode")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "86788123-74ac-4149-96a8-0a7aae36d829")]
    ReplacementMode ReplacementMode { get; set; }

    /// <summary>Статус</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "c9c37f37-f3f9-4e4d-b222-686bac63f049")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUser), "P_Status_DisplayName")]
    [RequiredField]
    [EnumSettings(FieldName = "Status")]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("ddc8866a-4538-4887-9290-bdc9ad5bc939")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [NotNull]
    [Order(1)]
    UserStatus Status { get; set; }

    /// <summary>OrganizationGroupsHash</summary>
    /// <remarks>
    /// Хеш для отслеживания изменений коллекции OrganizationGroups
    /// </remarks>
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_OrganizationGroupsHash_Description")]
    [Sortable(false)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Groupable(false)]
    [DisplayName(typeof (__Resources_IUser), "P_OrganizationGroupsHash_DisplayName")]
    [Order(25)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Uid("8c3810ea-8d4a-42c2-b9c1-1c6fc378cffa")]
    [StringSettings(FieldName = "OrganizationGroupsHash")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    string OrganizationGroupsHash { get; set; }

    /// <summary>OrganizationItemsHash</summary>
    /// <remarks>
    /// Хеш для отслеживания изменений коллекции OrganizationItems
    /// </remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Uid("3007cdb8-5a25-41f2-8d00-90163727afb2")]
    [Order(26)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_OrganizationItemsHash_Description")]
    [DisplayName(typeof (__Resources_IUser), "P_OrganizationItemsHash_DisplayName")]
    [StringSettings(FieldName = "OrganizationItemsHash")]
    string OrganizationItemsHash { get; set; }

    /// <summary>Дублировать сообщения</summary>
    /// <remarks>
    /// Дублировать или нет сообщения Замещаемому, если "Да" - сообщения уходят Замещаемому и Замещающему.
    /// </remarks>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("eeed15e2-87e8-4ddc-ac4b-cddc43e8c21d")]
    [Order(21)]
    [CanBeNull]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [DisplayName(typeof (__Resources_IUser), "P_DuplicateMessage_DisplayName")]
    [BoolSettings(DefaultValueStr = "True", FieldName = "DuplicateMessage")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_DuplicateMessage_Description")]
    bool? DuplicateMessage { get; set; }

    /// <summary>Замещение</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "c4fbe20f-1114-4198-a307-31b65cc84635")]
    [Order(24)]
    [EleWise.ELMA.Model.Attributes.Uid("c8ba8cc5-76d9-4225-bec7-2a079bade072")]
    [EntitySettings(FieldName = "Replacement")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUser), "P_Replacement_DisplayName")]
    IReplacement Replacement { get; set; }

    /// <summary>Фотография</summary>
    [EntityProperty]
    [BinaryFileSettings(FieldName = "Photo")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_Photo_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(27)]
    [EleWise.ELMA.Model.Attributes.Uid("d6eed170-9e90-4917-8df3-ecfa2b686794")]
    [Property("289f266b-2805-457e-bce0-b0bcd4d38143")]
    BinaryFile Photo { get; set; }

    /// <summary>Локаль</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("df2d6377-eee4-468e-a291-99a38a93fb02")]
    [StringSettings(FieldName = "Lang", MaxValueString = "10")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName(typeof (__Resources_IUser), "P_Lang_DisplayName")]
    [StringRangeLength(0, "10")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(28)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    new string Lang { get; set; }

    /// <summary>E-mail формат</summary>
    /// <remarks>Формат сообщения e-mail</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "P_EmailFormat_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Order(29)]
    [EleWise.ELMA.Model.Attributes.Uid("2a7de1b7-5a88-4d62-a577-84fc466230e6")]
    [StringSettings(FieldName = "EmailFormat")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_EmailFormat_Description")]
    string EmailFormat { get; set; }

    /// <summary>Установлена системная локаль</summary>
    [DisplayName(typeof (__Resources_IUser), "P_IsSystemLocal_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [BoolSettings(FieldName = "IsSystemLocal")]
    [NotNull]
    [Order(30)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("afd1448a-7d47-4845-88f5-bb81cd541167")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    new bool IsSystemLocal { get; set; }

    /// <summary>Данные часового пояса</summary>
    /// <remarks>Сериализованный часовой пояс</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [Sortable(false)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUser), "P_TimeZoneData_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(31)]
    [EleWise.ELMA.Model.Attributes.Uid("f161285d-00be-4a8b-886f-45b4ee4d4da8")]
    [StringSettings(FieldName = "TimeZoneData", MaxValueString = "500")]
    [TableCellAlignment(LineAlignment.Center)]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_TimeZoneData_Description")]
    [StringRangeLength(0, "500")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    string TimeZoneData { get; set; }

    /// <summary>Дата блокировки</summary>
    /// <remarks>Дата устанавливается в момент блокировки пользователя</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUser), "P_BlockDate_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [CanBeNull]
    [Order(32)]
    [DateTimeSettings(FieldName = "BlockDate", ShowTime = false)]
    [EleWise.ELMA.Model.Attributes.Uid("b448b2c4-b852-4cae-aa84-26610f92425a")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IUser), "P_BlockDate_Description")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    DateTime? BlockDate { get; set; }
  }
}
