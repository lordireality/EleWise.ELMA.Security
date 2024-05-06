// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IPersonalGroup
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
  /// <summary>Набор пользователей</summary>
  /// <remarks>
  /// Наборы пользователей/групп создаваемые пользователями самостоятельно
  /// </remarks>
  [Filterable]
  [ImplementationUid("843bc077-cf01-4bd1-aeb4-5ff9a84b62a3")]
  [ShowInCatalogList(false)]
  [FilterType(typeof (IPersonalGroupFilter))]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>51f66284-6bcb-4610-a5ad-f4ad478f06f5</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [DisplayName("SR.M('Набор пользователей')")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [TitleProperty("4fd1e379-fb9c-4e3f-ac7d-fb0c7e362858")]
  [DisplayFormat(null)]
  [Description("SR.M('Наборы пользователей/групп создаваемые пользователями самостоятельно')")]
  [Entity("PersonalGroup")]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("f4e0fcab-a604-4ff2-ad5d-2ea1987aa76e")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  public interface IPersonalGroup : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [EleWise.ELMA.Model.Attributes.Uid("7a0f7fe2-dae4-4b12-b8c5-b06329a5d60c")]
    [GuidSettings(FieldName = "Uid")]
    [NotNull]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [DisplayName("SR.M('Уникальный идентификатор')")]
    [EntityProperty]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Пользователь</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Required(true)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("0258083a-809b-4e44-8fd7-2db5dea34b85")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [RequiredField]
    [DisplayName("SR.M('Пользователь')")]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Owner")]
    IUser Owner { get; set; }

    /// <summary>Название</summary>
    [DisplayName("SR.M('Название')")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Visible)]
    [Required(true)]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("4fd1e379-fb9c-4e3f-ac7d-fb0c7e362858")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [StringRangeLength(0, "2000")]
    [RequiredField]
    [StringSettings(FieldName = "Name", MaxValueString = "2000")]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [EntityProperty]
    [FastSearch(true)]
    string Name { get; set; }

    /// <summary>Пользователи</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityUserSettings(CascadeMode = CascadeMode.SaveUpdate, ChildColumnName = "UserId", ParentColumnName = "PersonalGroupId", RelationTableName = "M_PersonalGroup_Users", RelationType = RelationType.ManyToMany)]
    [DisplayName("SR.M('Пользователи')")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("f1d843d3-74bf-43bc-97ea-624971b87e3b")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [Order(3)]
    ISet<IUser> Users { get; set; }

    /// <summary>Группы</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, ChildColumnName = "GroupId", ParentColumnName = "PersonalGroupId", RelationTableName = "M_PersonalGroup_Groups", RelationType = RelationType.ManyToMany)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "72c9994a-cd4e-4746-ac50-5f454b450231")]
    [DisplayName("SR.M('Группы')")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("79480abf-af17-4a47-abfe-a709f3ad33c3")]
    [Order(4)]
    ISet<IUserGroup> Groups { get; set; }
  }
}
