// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IUserFilter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Types.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Фильтр для объекта "Пользователь"</summary>
  [FilterFor(typeof (IUser))]
  public interface IUserFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Учетная запись"</summary>
    string UserName { get; set; }

    /// <summary>Фильтр для свойства "Имя"</summary>
    string FirstName { get; set; }

    /// <summary>Фильтр для свойства "Отчество"</summary>
    string MiddleName { get; set; }

    /// <summary>Фильтр для свойства "Фамилия"</summary>
    string LastName { get; set; }

    /// <summary>Фильтр для свойства "E-Mail"</summary>
    string EMail { get; set; }

    /// <summary>Фильтр для свойства "Дата рождения"</summary>
    DateTimeRange BirthDate { get; set; }

    /// <summary>Фильтр для свойства "Дата приема на работу"</summary>
    DateTimeRange EmployDate { get; set; }

    /// <summary>Фильтр для свойства "Рабочий телефон"</summary>
    string WorkPhone { get; set; }

    /// <summary>Фильтр для свойства "Мобильный телефон"</summary>
    string MobilePhone { get; set; }

    /// <summary>Фильтр для свойства "Номер комнаты"</summary>
    string RoomNumber { get; set; }

    /// <summary>Фильтр для свойства "Skype"</summary>
    string Skype { get; set; }

    /// <summary>Фильтр для свойства "ICQ"</summary>
    string ICQ { get; set; }

    /// <summary>Фильтр для свойства "Jabber ID"</summary>
    string JabberID { get; set; }

    /// <summary>Фильтр для свойства "Провайдер авторизации"</summary>
    Guid? AuthProviderGuid { get; set; }

    /// <summary>Элемент оргструктуры</summary>
    [OrganizationItemSettings(FieldName = "OrganizationItem")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "FP_OrganizationItem_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [CustomFilterProperty]
    [Uid("b0b9d3a7-d192-44c3-b4f4-0cd1cff30eab")]
    [Property("72ed98ca-f260-4671-9bcd-ff1d80235f47", "e502f586-afd4-4f55-bedb-f71028ffd302")]
    IOrganizationItem OrganizationItem { get; set; }

    /// <summary>Список возможных пользователей</summary>
    [DisplayName(typeof (__Resources_IUser), "FP_Workers_DisplayName")]
    [AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<EleWise.ELMA.Security.Models.Worker>")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [CustomFilterProperty]
    [Order(1)]
    [Uid("fc6fe5f1-bab3-40cc-b7dc-223bae1f5451")]
    List<Worker> Workers { get; set; }

    /// <summary>Показывать блокированных</summary>
    /// <remarks>Нужно ли выбирать заблокированных пользователей</remarks>
    [NotNull]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [BoolSettings(FieldName = "ShowBlock")]
    [Order(2)]
    [Description(typeof (__Resources_IUser), "FP_ShowBlock_Description")]
    [CustomFilterProperty]
    [Uid("45afd2a7-23bf-4803-9eed-fdf060563641")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "FP_ShowBlock_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    bool ShowBlock { get; set; }

    /// <summary>Показать только замещения</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [BoolSettings(FieldName = "ShowOnlyReplacement")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [DisplayName(typeof (__Resources_IUser), "FP_ShowOnlyReplacement_DisplayName")]
    [Uid("e3d9875e-1c0b-4715-b84a-b5e18e4946da")]
    [CustomFilterProperty]
    [Order(3)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [NotNull]
    bool ShowOnlyReplacement { get; set; }

    /// <summary>Режим поиска по оргструктуре</summary>
    [DisplayName(typeof (__Resources_IUser), "FP_OrganizationItemFindMode_DisplayName")]
    [EnumSettings(DefaultValueStr = "48ff3773-ca34-4476-97a2-3e82b874c891", FieldName = "OrganizationItemFindMode")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [Order(4)]
    [CustomFilterProperty]
    [NotNull]
    [Uid("239dc1d7-101a-4a98-a4a2-659531fc9b27")]
    [Property("849c1ac9-4d46-4194-8cbb-43f84adf9c17", "da2d0b29-7b1c-4e2b-b0f0-9675da93e54d")]
    OrganizationItemFindMode OrganizationItemFindMode { get; set; }

    /// <summary>Показать только подчиненных</summary>
    [BoolSettings(FieldName = "ShowOnlySubordinate")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [DisplayName(typeof (__Resources_IUser), "FP_ShowOnlySubordinate_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [CustomFilterProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Uid("f9ad0e41-2f65-43c3-b92f-eae02c78a339")]
    [NotNull]
    [Order(5)]
    bool ShowOnlySubordinate { get; set; }

    /// <summary>Показать только подчиненных и себя</summary>
    [Uid("99684bab-79b8-4815-aac4-6700684d6d66")]
    [CustomFilterProperty]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [Order(6)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Visible)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Visible)]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    [NotNull]
    [DisplayName(typeof (__Resources_IUser), "FP_ShowOnlySubordinateAndSelf_DisplayName")]
    [BoolSettings(FieldName = "ShowOnlySubordinateAndSelf")]
    bool ShowOnlySubordinateAndSelf { get; set; }

    /// <summary>Элементы оргуструктуры</summary>
    [Order(7)]
    [Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
    [Uid("6e4a9815-5d59-46c9-addb-8c4c2c7be054")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [CustomFilterProperty]
    [ListOfSimpleTypeSettings(FieldName = "OrganizationItemIds", SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IUser), "FP_OrganizationItemIds_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    List<long> OrganizationItemIds { get; set; }

    /// <summary>Идентификаторы пользователей</summary>
    [CustomFilterProperty]
    [Uid("9cfcb0dd-f9b0-46e0-bed1-1cc3aed4ad5b")]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [Order(8)]
    [DisplayName(typeof (__Resources_IUser), "FP_UserIds_DisplayName")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
    [ListOfSimpleTypeSettings(FieldName = "UserIds", SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3")]
    [Sortable(false)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    List<long> UserIds { get; set; }

    /// <summary>День рождения в течение года</summary>
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Filter, Visibility = Visibility.Hidden)]
    [Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
    [CustomFilterProperty]
    [Uid("c7b40f52-00f2-4aca-b2b7-a40760f8b7de")]
    [Order(9)]
    [DisplayName(typeof (__Resources_IUser), "FP_YearlyBirthDate_DisplayName")]
    [DateTimeSettings(FieldName = "YearlyBirthDate")]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = false, ViewType = ViewType.List, Visibility = Visibility.Hidden)]
    [View(ItemType = ItemType.Default, ReadOnly = true, ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
    DateTimeRange YearlyBirthDate { get; set; }
  }
}
