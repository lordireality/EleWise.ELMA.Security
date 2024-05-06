// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserGroup
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
using Iesi.Collections.Generic;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Группа пользователей</summary>
  [TitleProperty("5fe8e631-b7b3-4846-a3d7-a9292e300067")]
  [AllowCreateHeirs(true)]
  [DisplayFormat("{$Name}")]
  [ActionsType(typeof (UserGroupActions))]
  [CopyAction(CopyAction.ByRef)]
  [FilterType(typeof (IUserGroupFilter))]
  [ImplementationUid("cf104645-72b9-4ef6-866c-8add9312fd9d")]
  [CacheEntity]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>92e9a0f3-f9a3-4103-855b-beb1f469ce31</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Filterable]
  [Entity("UserGroup")]
  [ShowInCatalogList(false)]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [MetadataType(typeof (EntityMetadata))]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [DisplayName("SR.M('Группа пользователей')")]
  [EleWise.ELMA.Model.Attributes.Uid("72c9994a-cd4e-4746-ac50-5f454b450231")]
  public interface IUserGroup : IEntity<long>, IEntity, IIdentified, IInheritable
  {
    /// <summary>Уникальный идентификатор</summary>
    [GuidSettings(FieldName = "Uid")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [RequiredField]
    [EntityProperty]
    [DisplayName("SR.M('Уникальный идентификатор')")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("b5b7a00f-2be3-4fb3-9847-630325ba5b5c")]
    [Required(true)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Имя группы</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [DisplayName("SR.M('Имя группы')")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [ShowInTable(true)]
    [FastSearch(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [EntityProperty]
    [StringRangeLength(0, "2000")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("5fe8e631-b7b3-4846-a3d7-a9292e300067")]
    [Order(1)]
    [Required(true)]
    [RequiredField]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "Name", MaxValueString = "2000")]
    string Name { get; set; }

    /// <summary>Описание</summary>
    [Order(2)]
    [StringSettings(FieldName = "Description", MultiLine = true)]
    [EleWise.ELMA.Model.Attributes.Uid("874bfe35-88ff-4c06-aa8d-791d1beaa1de")]
    [ShowInTable(true)]
    [EntityProperty]
    [FastSearch(true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName("SR.M('Описание')")]
    string Description { get; set; }

    /// <summary>Автор создания</summary>
    [DisplayName("SR.M('Автор создания')")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [ShowInTable(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("f3a20b0b-04da-4649-9dfe-6c0e8b6211dd")]
    [EntityProperty]
    [PropertyHandler("b05ac6bd-eb8b-474a-a796-b53831a9967e")]
    [EntityUserSettings(FieldName = "CreationAuthor")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    IUser CreationAuthor { get; set; }

    /// <summary>Дата создания</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [PropertyHandler("d0c00d8a-e003-427d-9942-f52cfb77b0f0")]
    [DisplayName("SR.M('Дата создания')")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [ShowInTable(true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [RequiredField]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("883fa46a-bb96-4268-9616-b418ed82ceb1")]
    [EntityProperty]
    [NotNull]
    [DateTimeSettings(FieldName = "CreationDate", SetCurrentDate = true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [Required(true)]
    DateTime CreationDate { get; set; }

    /// <summary>Автор последнего изменения</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [PropertyHandler("d152e660-1ee9-4b5f-a614-df280e5b3f98")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(5)]
    [EleWise.ELMA.Model.Attributes.Uid("dc367482-a600-499e-8aea-50e8ddcc6cdd")]
    [EntityUserSettings(FieldName = "ChangeAuthor")]
    [DisplayName("SR.M('Автор последнего изменения')")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    IUser ChangeAuthor { get; set; }

    /// <summary>Дата последнего изменения</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName("SR.M('Дата последнего изменения')")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("09ec106d-41d8-438f-be13-2d50987f1dd9")]
    [PropertyHandler("12a6c5c4-12f8-4b2e-b7ea-5438974a2d25")]
    [CanBeNull]
    [DateTimeSettings(FieldName = "ChangeDate")]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    DateTime? ChangeDate { get; set; }

    /// <summary>Группы</summary>
    [EleWise.ELMA.Model.Attributes.Uid("921731d9-9f6d-4b6f-8558-63c48ed7c74e")]
    [Order(8)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
    [DisplayName("SR.M('Группы')")]
    [EntitySettings(ChildColumnName = "ChildId", ParentColumnName = "ParentId", RelationTableName = "UserGroup_Groups_Map", RelationType = RelationType.ManyToMany)]
    ISet<IUserGroup> Groups { get; set; }

    /// <summary>Пользователи</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(7)]
    [DisplayName("SR.M('Пользователи')")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EleWise.ELMA.Model.Attributes.Uid("2b84634b-6121-4500-b454-d56a923fae3b")]
    [EntityUserSettings(ChildColumnName = "UserId", ParentColumnName = "GroupId", RelationTableName = "UserGroup_User_Map", RelationType = RelationType.ManyToMany)]
    ISet<IUser> Users { get; set; }

    /// <summary>Элементы оргструктуры</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName("SR.M('Элементы оргструктуры')")]
    [Order(9)]
    [EleWise.ELMA.Model.Attributes.Uid("bd24bbdc-5864-459f-801b-6456215619dc")]
    [OrganizationItemSettings(ChildColumnName = "OrgItemId", ParentColumnName = "GroupId", RelationTableName = "UserGroup_OrgItem_Map", RelationType = RelationType.ManyToMany)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
    ISet<IOrganizationItem> OrganizationItems { get; set; }

    /// <summary>GroupsHash</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Groupable(false)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [Sortable(false)]
    [Order(10)]
    [EleWise.ELMA.Model.Attributes.Uid("369d7637-fa89-41bb-a8e0-8921514bfb4f")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName("SR.M('GroupsHash')")]
    [StringSettings(FieldName = "GroupsHash")]
    string GroupsHash { get; set; }

    /// <summary>UsersHash</summary>
    [EleWise.ELMA.Model.Attributes.Uid("aa4aecf1-0dff-4d84-8e4d-bde4cff2b86e")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Groupable(false)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [Sortable(false)]
    [Order(11)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [StringSettings(FieldName = "UsersHash")]
    [DisplayName("SR.M('UsersHash')")]
    string UsersHash { get; set; }

    /// <summary>OrganizationItemsHash</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Groupable(false)]
    [Sortable(false)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [Order(12)]
    [EleWise.ELMA.Model.Attributes.Uid("e92a68df-5a13-4951-8738-973e03864eb7")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringSettings(FieldName = "OrganizationItemsHash")]
    [DisplayName("SR.M('OrganizationItemsHash')")]
    string OrganizationItemsHash { get; set; }

    /// <summary>Системная группа</summary>
    /// <remarks>
    /// Если группа является системной, то польователь не может ее изменять
    /// </remarks>
    [Sortable(false)]
    [EleWise.ELMA.Model.Attributes.Description("SR.M('Если группа является системной, то польователь не может ее изменять')")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Groupable(false)]
    [BoolSettings(FieldName = "IsSystem")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [Required(true)]
    [RequiredField]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName("SR.M('Системная группа')")]
    [EleWise.ELMA.Model.Attributes.Uid("89edea1d-3d60-43fd-bbff-cf4ef431fc8d")]
    [Order(13)]
    [NotNull]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    bool IsSystem { get; set; }

    /// <summary>Группа по умолчанию</summary>
    /// <remarks>
    /// Добавлять эту группу всем вновь создаваемым пользователям
    /// </remarks>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Description("SR.M('Добавлять эту группу всем вновь создаваемым пользователям')")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [Required(true)]
    [NotNull]
    [DisplayName("SR.M('Группа по умолчанию')")]
    [RequiredField]
    [BoolSettings(FieldName = "AddToNewUser")]
    [EleWise.ELMA.Model.Attributes.Uid("b0af28e5-659c-40dd-b421-3041dd983e50")]
    [Order(14)]
    bool AddToNewUser { get; set; }
  }
}
