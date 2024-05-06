// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IOrganizationItem
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
  /// <summary>Элемент оргструктуры</summary>
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>6a3df994-7968-415d-892a-31f9278a1594</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable, EleWise.ELMA.SDK")]
  [Entity("OrganizationItem")]
  [EleWise.ELMA.Model.Attributes.Uid("e502f586-afd4-4f55-bedb-f71028ffd302")]
  [MetadataType(typeof (EntityMetadata))]
  [DisplayFormat("{$Name}")]
  [DisplayName(typeof (__Resources_IOrganizationItem), "DisplayName")]
  [ShowInCatalogList(false)]
  [ImplementationUid("dfb7b232-140c-4aba-bff2-c5ccee293088")]
  [CacheEntity]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [CopyAction(CopyAction.ByRef)]
  public interface IOrganizationItem : IEntity<long>, IEntity, IIdentified, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор</summary>
    [RequiredField]
    [GuidSettings(FieldName = "Uid")]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_Uid_DisplayName")]
    [EntityProperty]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EleWise.ELMA.Model.Attributes.Uid("e9091819-d95f-4e37-af9c-a4a0efa7402b")]
    [NotNull]
    [SystemProperty]
    [Required(true)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    Guid Uid { get; set; }

    /// <summary>Тип элемента</summary>
    [EnumSettings(FieldName = "ItemType")]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_ItemType_DisplayName")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "6557e077-71cd-4f73-b23a-eed2447ef0b0")]
    [EleWise.ELMA.Model.Attributes.Uid("e6eb286a-dbf0-4e8e-b606-d422940cc3a4")]
    [EntityProperty]
    [NotNull]
    [Order(1)]
    OrganizationItemType ItemType { get; set; }

    /// <summary>Название</summary>
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [EntityProperty]
    [FastSearch(true)]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("cae9e784-5d4e-4f17-94f5-abfa9023feb3")]
    [StringSettings(FieldName = "Name", MaxValueString = "2000")]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_Name_DisplayName")]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [StringRangeLength(0, "2000")]
    string Name { get; set; }

    /// <summary>Элемент верхнего уровня</summary>
    [EntityProperty]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_ParentItem_DisplayName")]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("f8983979-45d6-411f-a505-770f381030a8")]
    [OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "ParentItem")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
    IOrganizationItem ParentItem { get; set; }

    /// <summary>Назначенный пользователь</summary>
    /// <remarks>
    /// Пользователь, назначенный на элемент оргструктуры с типом "Должность"
    /// </remarks>
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "UserId")]
    [EleWise.ELMA.Model.Attributes.Uid("be1f5c48-fa8f-4bf0-ae4c-0ecdfd88052e")]
    [Order(4)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Description(typeof (__Resources_IOrganizationItem), "P_User_Description")]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_User_DisplayName")]
    IUser User { get; set; }

    /// <summary>Назначенные пользователи</summary>
    /// <remarks>
    /// Пользователи, назначенные на элемент оргструктуры с типом "Группа сотрудников"
    /// </remarks>
    [EntityProperty]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Description(typeof (__Resources_IOrganizationItem), "P_Users_Description")]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_Users_DisplayName")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [Order(5)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("08f27ddc-aed6-4a7e-9745-befd0b354b1b")]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, ChildColumnName = "UserId", ParentColumnName = "OrganizationItemId", RelationTableName = "OrganizationItemUsers", RelationType = RelationType.ManyToMany)]
    ISet<IUser> Users { get; set; }

    /// <summary>UsersHash</summary>
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [EntityProperty]
    [StringSettings(FieldName = "UsersHash")]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_UsersHash_DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("28d68012-b2c4-4366-ba7b-73b317d49b8c")]
    [Order(6)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Sortable(false)]
    [Groupable(false)]
    string UsersHash { get; set; }

    /// <summary>Элементы нижнего уровня</summary>
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [EntityProperty]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
    [OrganizationItemSettings(CascadeMode = CascadeMode.SaveUpdate, KeyColumnUidStr = "f8983979-45d6-411f-a505-770f381030a8", RelationType = RelationType.OneToMany)]
    [EleWise.ELMA.Model.Attributes.Uid("4d68a5ae-1c1a-4b84-bfd1-e34e0d73240f")]
    [Order(7)]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_SubItems_DisplayName")]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    ISet<IOrganizationItem> SubItems { get; set; }

    /// <summary>Признак удаления</summary>
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_IsDeleted_DisplayName")]
    [Order(8)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [BoolSettings(FieldName = "IsDeleted")]
    [EleWise.ELMA.Model.Attributes.Uid("18e81d76-bfd2-460d-bdaf-aa5a0da66657")]
    [NotNull]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    new bool IsDeleted { get; set; }

    /// <summary>Реально удалить сущность из базы</summary>
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("9d3972d9-8a2e-4326-a27c-4f16d81d3a1a")]
    [Order(9)]
    [EntityProperty]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IOrganizationItem), "P_HardDelete_DisplayName")]
    [BoolSettings(FieldName = "HardDelete")]
    [View(ItemType = EleWise.ELMA.Model.Views.ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    new bool HardDelete { get; set; }
  }
}
