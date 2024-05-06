// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IAbsence
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
  /// <summary>Отсутствие пользователя</summary>
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>bb45dd47-ebce-4ba9-8797-e2caacc7b3bd</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [DisplayFormat(null)]
  [FilterType(typeof (IAbsenceFilter))]
  [CacheEntity]
  [DisplayName(typeof (__Resources_IAbsence), "DisplayName")]
  [EleWise.ELMA.Model.Attributes.Uid("f50c6471-7f79-4cf3-b45a-668dd964f20f")]
  [MetadataType(typeof (EntityMetadata))]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [ShowInCatalogList(false)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [Entity("Absence")]
  [ImplementationUid("7e545d8a-0a45-456b-9819-4d0db715f20d")]
  [Filterable]
  public interface IAbsence : IEntity<long>, IEntity, IIdentified
  {
    /// <summary>Уникальный идентификатор</summary>
    [DisplayName(typeof (__Resources_IAbsence), "P_Uid_DisplayName")]
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    [EleWise.ELMA.Model.Attributes.Uid("aa8f1339-0d99-47ee-97c8-e5b7683733aa")]
    [NotNull]
    [SystemProperty]
    Guid Uid { get; set; }

    /// <summary>Отсутствующий</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [RequiredField]
    [DisplayName(typeof (__Resources_IAbsence), "P_User_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [EntityProperty]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("6683a0b8-3462-4b41-bef8-9a92e1e81495")]
    [Required(true)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EntityUserSettings(FieldName = "User")]
    IUser User { get; set; }

    /// <summary>Дата начала</summary>
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IAbsence), "P_StartDate_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Filterable]
    [DateTimeSettings(FieldName = "StartDate", SetCurrentDate = true)]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("0e71c829-3414-48bb-90bf-2370760c9193")]
    [EntityProperty]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [Required(true)]
    [NotNull]
    DateTime StartDate { get; set; }

    /// <summary>Дата завершения</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IAbsence), "P_EndDate_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [RequiredField]
    [NotNull]
    [Order(3)]
    [EleWise.ELMA.Model.Attributes.Uid("69787341-f2c3-4b35-ac93-9cd361c49434")]
    [DateTimeSettings(FieldName = "EndDate", SetCurrentDate = true)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [Required(true)]
    DateTime EndDate { get; set; }

    /// <summary>Комментарий</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("52ea8244-9ba7-4104-af76-cbbecac6f2e9")]
    [Property("9b9aac17-22bb-425c-aa93-9c02c5146965")]
    [DisplayName(typeof (__Resources_IAbsence), "P_Description_DisplayName")]
    [StringSettings(FieldName = "Description", MultiLine = true)]
    string Description { get; set; }

    /// <summary>Статус</summary>
    /// <remarks>
    /// Служебное свойство, активно отстутствие пользователя или нет
    /// </remarks>
    [RequiredField]
    [EnumSettings(FieldName = "Status")]
    [EleWise.ELMA.Model.Attributes.Description(typeof (__Resources_IAbsence), "P_Status_Description")]
    [DisplayName(typeof (__Resources_IAbsence), "P_Status_DisplayName")]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("c19e6e1b-f31c-4e1b-be5d-8cc185f2f6fc")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "5af31f82-2104-4d1b-b028-a5996cad46e7")]
    [Required(true)]
    [Filterable]
    [EntityProperty]
    [Order(5)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    AbsenceStatus Status { get; set; }

    /// <summary>Основание для отсутствия на рабочем месте</summary>
    [EntitySettings(CascadeMode = CascadeMode.SaveUpdate, FieldName = "Grounds", GenerateListInFilter = true)]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "a79c6d13-4dba-4d51-a1e8-3f5a407985e4")]
    [DisplayName(typeof (__Resources_IAbsence), "P_Grounds_DisplayName")]
    [RequiredField]
    [Order(6)]
    [Filterable]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EleWise.ELMA.Model.Attributes.Uid("bfc51cbb-424c-4085-9841-aa1dcab965e0")]
    IGroundsForAbsence Grounds { get; set; }
  }
}
