// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IReplacement
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
  /// <summary>Замещение</summary>
  [EleWise.ELMA.Model.Attributes.Uid("c4fbe20f-1114-4198-a307-31b65cc84635")]
  [DisplayName(typeof (__Resources_IReplacement), "DisplayName")]
  [Filterable]
  [MetadataType(typeof (EntityMetadata))]
  [ShowInCatalogList(false)]
  [Entity("Replacement")]
  [IdType("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
  [InterfaceImplementation("EleWise.ELMA.Model.Entities.ISoftDeletable")]
  [TableView("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<TableView xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Uid>79387294-b217-42f7-b3e4-57deb55aaf08</Uid>\r\n  <ViewType>List</ViewType>\r\n</TableView>")]
  [ImplementationUid("3d38182c-23ed-4dce-b7dc-6bf08214e7a7")]
  [FilterType(typeof (IReplacementFilter))]
  [DisplayFormat(null)]
  [EntityMetadataType(EntityMetadataType.Interface)]
  [CacheEntity]
  public interface IReplacement : IEntity<long>, IEntity, IIdentified, ISoftDeletable
  {
    /// <summary>Уникальный идентификатор</summary>
    [NotNull]
    [DisplayName(typeof (__Resources_IReplacement), "P_Uid_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [GuidSettings(FieldName = "Uid")]
    [EleWise.ELMA.Model.Attributes.Uid("1d3fd8cc-4da4-4470-a6e3-f61a885bc65e")]
    [SystemProperty]
    [Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
    Guid Uid { get; set; }

    /// <summary>Замещаемый</summary>
    /// <remarks>Замещаемый пользователь</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Description(typeof (__Resources_IReplacement), "P_SourceUser_Description")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Order(1)]
    [EleWise.ELMA.Model.Attributes.Uid("f6e09e20-c523-4c6e-97aa-0e2fa64cab0b")]
    [DisplayName(typeof (__Resources_IReplacement), "P_SourceUser_DisplayName")]
    [Required(true)]
    [RequiredField]
    [EntityUserSettings(FieldName = "SourceUser")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    IUser SourceUser { get; set; }

    /// <summary>Замещающий</summary>
    /// <remarks>Замещающий пользователь</remarks>
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "cfdeb03c-35e9-45e7-aad8-037d83888f73")]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Description(typeof (__Resources_IReplacement), "P_TargetUser_Description")]
    [DisplayName(typeof (__Resources_IReplacement), "P_TargetUser_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [RequiredField]
    [Required(true)]
    [Order(2)]
    [EleWise.ELMA.Model.Attributes.Uid("66afd3e6-655a-4acd-af32-8963fc609c45")]
    [Filterable]
    [EntityUserSettings(FieldName = "TargetUser")]
    IUser TargetUser { get; set; }

    /// <summary>Дата начала</summary>
    /// <remarks>Дата начала замещения</remarks>
    [NotNull]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IReplacement), "P_StartDate_DisplayName")]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [DateTimeSettings(FieldName = "StartDate", SetCurrentDate = true, ShowTime = false)]
    [RequiredField]
    [Description(typeof (__Resources_IReplacement), "P_StartDate_Description")]
    [Order(3)]
    [Required(true)]
    [EleWise.ELMA.Model.Attributes.Uid("2c33b6fa-725b-4933-9ac8-e44d673c081a")]
    DateTime StartDate { get; set; }

    /// <summary>Дублировать сообщения</summary>
    /// <remarks>
    /// Дублировать или нет сообщения Замещаемому, если "Да" - сообщения уходят Замещаемому и Замещающему.
    /// </remarks>
    [BoolSettings(DefaultValueStr = "True", FieldName = "DuplicateMessage")]
    [EleWise.ELMA.Model.Attributes.Uid("8ef56168-3258-4ae2-8329-4dd3fc763d2a")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [Order(5)]
    [CanBeNull]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IReplacement), "P_DuplicateMessage_DisplayName")]
    [Description(typeof (__Resources_IReplacement), "P_DuplicateMessage_Description")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    bool? DuplicateMessage { get; set; }

    /// <summary>Предварительное замещение</summary>
    /// <remarks>
    /// Количество рабочих дней, за которое требуется выполнять механизм замещения (переназначение задач, информирование пользователей и т.п.) до фактической даты начала замещения
    /// </remarks>
    [RangeValue(0, 9223372036854775807)]
    [Int64Settings(DefaultValueStr = "0", FieldName = "PreReplace", MinValue = 0)]
    [Property("d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [Required(true)]
    [Order(6)]
    [EleWise.ELMA.Model.Attributes.Uid("280c2329-5b96-4781-9811-e66641ed3adf")]
    [NotNull]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IReplacement), "P_PreReplace_DisplayName")]
    [Description(typeof (__Resources_IReplacement), "P_PreReplace_Description")]
    [EntityProperty]
    [RequiredField]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    long PreReplace { get; set; }

    /// <summary>Статус</summary>
    /// <remarks>Статус замещения, служебное свойство</remarks>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(7)]
    [EntityProperty]
    [Filterable]
    [Description(typeof (__Resources_IReplacement), "P_Status_Description")]
    [EleWise.ELMA.Model.Attributes.Uid("2ca33d24-7efe-47a4-a59d-20253eb34bb1")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "0ae225a8-01a2-464e-ad37-35972aaf467d")]
    [NotNull]
    [Required(true)]
    [RequiredField]
    [DisplayName(typeof (__Resources_IReplacement), "P_Status_DisplayName")]
    [EnumSettings(DefaultValueStr = "aaf05103-52a6-4724-a340-76cd2de74b1f", FieldName = "Status")]
    ReplacementStatus Status { get; set; }

    /// <summary>Дата завершения</summary>
    /// <remarks>Дата завершения замещения</remarks>
    [Property("dac9211e-e02b-47cd-8868-89a3bfc0f749")]
    [DateTimeSettings(FieldName = "EndDate", SetCurrentDate = true, ShowTime = false)]
    [DisplayName(typeof (__Resources_IReplacement), "P_EndDate_DisplayName")]
    [Order(4)]
    [EleWise.ELMA.Model.Attributes.Uid("b657ade8-9b4a-465a-9c2b-9ad508793ee7")]
    [Required(true)]
    [NotNull]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [RequiredField]
    [Filterable]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Description(typeof (__Resources_IReplacement), "P_EndDate_Description")]
    DateTime EndDate { get; set; }

    /// <summary>IsDeleted</summary>
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [NotNull]
    [Order(8)]
    [EleWise.ELMA.Model.Attributes.Uid("0aeccdf1-75bc-4da5-b9f7-c5ae7d0f0d61")]
    [DisplayName(typeof (__Resources_IReplacement), "P_IsDeleted_DisplayName")]
    [BoolSettings(FieldName = "IsDeleted")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    new bool IsDeleted { get; set; }

    /// <summary>HardDelete</summary>
    [Order(9)]
    [NotNull]
    [EleWise.ELMA.Model.Attributes.Uid("31523458-f78b-4800-bb29-6637e04e2cc3")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [EntityProperty]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IReplacement), "P_HardDelete_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [BoolSettings(FieldName = "HardDelete")]
    new bool HardDelete { get; set; }
  }
}
