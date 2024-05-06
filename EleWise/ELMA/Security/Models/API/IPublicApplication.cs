// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.API.IPublicApplication
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
using Iesi.Collections.Generic;
using System;

namespace EleWise.ELMA.Security.Models.API
{
  /// <summary>Внешнее приложение</summary>
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [Entity("PublicApplication")]
  [FilterType(typeof (IPublicApplicationFilter))]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>c10ecc37-a1a3-4136-9ea0-e024185d199e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [InterfaceImplementation("EleWise.ELMA.API.Models.IPublicApplication")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [Filterable]
  [CacheEntity]
  [ImplementationUid("fa3fc7fc-6535-4f4f-a5b9-996a7e95166b")]
  [ShowInDesigner(false)]
  [TitleProperty("889bac17-f1d5-47c7-b687-436d4884cd0d")]
  [ShowInTypeTree(false)]
  [DisplayFormat(null)]
  [EleWise.ELMA.Model.Attributes.Uid("1817c965-17ce-4463-86b5-08deb0f4b04e")]
  [DisplayName(typeof (__Resources_IPublicApplication), "DisplayName")]
  [MetadataType(typeof (EntityMetadata))]
  public interface IPublicApplication : IEntity<long>, IEntity, IIdentified, EleWise.ELMA.API.Models.IPublicApplication
  {
    /// <summary>Уникальный идентификатор</summary>
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("2b7545eb-1a14-4463-b2e4-db75f4ea1621")]
    [NotNull]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_Uid_DisplayName")]
    new Guid Uid { get; set; }

    /// <summary>Наименование</summary>
    [DisplayName(typeof (__Resources_IPublicApplication), "P_Name_DisplayName")]
    [RequiredField]
    [EleWise.ELMA.Model.Attributes.Uid("889bac17-f1d5-47c7-b687-436d4884cd0d")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Required(true)]
    [Order(1)]
    [StringSettings(FieldName = "Name")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [FastSearch(true)]
    new string Name { get; set; }

    /// <summary>Описание</summary>
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("238ae522-8845-43d3-8dfa-e67a0a9ba149")]
    [Order(2)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_Description_DisplayName")]
    [StringSettings(FieldName = "Description", MultiLine = true)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Sortable(false)]
    new string Description { get; set; }

    /// <summary>Авторство приложения</summary>
    [StringSettings(FieldName = "Author")]
    [RequiredField]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_Author_DisplayName")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [EleWise.ELMA.Model.Attributes.Uid("c83026a2-0ef4-4e26-a72f-b881352c8195")]
    [Order(3)]
    [Required(true)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    new string Author { get; set; }

    /// <summary>Сайт приложения</summary>
    [EleWise.ELMA.Model.Attributes.Uid("87ad3542-e4b5-4df2-af03-79c2d2e295a5")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [Order(4)]
    [Required(true)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [RequiredField]
    [StringSettings(FieldName = "Site")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_Site_DisplayName")]
    new string Site { get; set; }

    /// <summary>Активно</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_IsActive_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("d74c80f3-b17e-4d33-bba4-f44df4d57b8f")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [BoolSettings(FieldName = "IsActive")]
    [Required(true)]
    [Order(5)]
    [RequiredField]
    [NotNull]
    [EntityProperty]
    [Filterable]
    bool IsActive { get; set; }

    /// <summary>Токены</summary>
    [Sortable(false)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("b8ff9e3c-d694-4028-988e-a1fdb8880346")]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_Tokens_DisplayName")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "69334e6e-2d55-4665-94e1-1de241bfa9ce")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [EntitySettings(CascadeMode = CascadeMode.AllDeleteOrphan, KeyColumnUidStr = "bfec7811-b7c0-47c8-9f0b-8e085c9a2f00", RelationType = RelationType.OneToMany)]
    ISet<IPublicApplicationToken> Tokens { get; set; }

    /// <summary>Системное</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [DisplayName(typeof (__Resources_IPublicApplication), "P_IsSystem_DisplayName")]
    [NotNull]
    [Order(7)]
    [EleWise.ELMA.Model.Attributes.Uid("0d651796-34dc-4f60-8c0b-ac825bc23960")]
    [BoolSettings(FieldName = "IsSystem")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [Required(true)]
    [RequiredField]
    bool IsSystem { get; set; }
  }
}
