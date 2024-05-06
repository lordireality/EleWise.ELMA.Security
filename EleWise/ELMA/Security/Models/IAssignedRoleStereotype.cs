// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IAssignedRoleStereotype
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
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>AssignedRoleStereotype</summary>
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>083cb3d4-c385-49d7-b0b6-22ddbe4b4c3e</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [Entity("AssignedRoleStereotype")]
  [DisplayFormat(null)]
  [MetadataType(typeof (EntityMetadata))]
  [EleWise.ELMA.Model.Attributes.Uid("3778a904-313b-4b87-b655-8e45b715e137")]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [ImplementationUid("f071a2bc-aaf0-4d8f-a97d-4bf0855198ca")]
  [DisplayName(typeof (__Resources_IAssignedRoleStereotype), "DisplayName")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  public interface IAssignedRoleStereotype : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [GuidSettings(FieldName = "Uid")]
    [EleWise.ELMA.Model.Attributes.Uid("9b2b0d29-5731-419a-9271-0ac64bdcc69c")]
    [DisplayName(typeof (__Resources_IAssignedRoleStereotype), "P_Uid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [SystemProperty]
    [NotNull]
    Guid Uid { get; set; }

    /// <summary>GroupUid</summary>
    /// <remarks>Идентификаторт группы</remarks>
    [GuidSettings(FieldName = "GroupUid")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IAssignedRoleStereotype), "P_GroupUid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Description(typeof (__Resources_IAssignedRoleStereotype), "P_GroupUid_Description")]
    [EleWise.ELMA.Model.Attributes.Uid("6b56bc06-9461-457d-b687-96aa2ba81102")]
    [CanBeNull]
    [Required(true)]
    Guid? GroupUid { get; set; }

    /// <summary>PermissionUid</summary>
    /// <remarks>Идентификатор группы</remarks>
    [Required(true)]
    [GuidSettings(FieldName = "PermissionUid")]
    [CanBeNull]
    [RequiredField]
    [Description(typeof (__Resources_IAssignedRoleStereotype), "P_PermissionUid_Description")]
    [DisplayName(typeof (__Resources_IAssignedRoleStereotype), "P_PermissionUid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("06323394-6a9f-4154-bc8a-5c4412bce886")]
    Guid? PermissionUid { get; set; }
  }
}
