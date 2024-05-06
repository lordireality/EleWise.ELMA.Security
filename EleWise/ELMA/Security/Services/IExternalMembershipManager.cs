// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IExternalMembershipManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Settings;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс общего сервиса работы с внешними модулями авторизации IExternalMembershipModule и провайдерами авторизации IExternalMembershipService
  /// </summary>
  public interface IExternalMembershipManager
  {
    /// <summary>Все модули авторизации</summary>
    IEnumerable<IExternalMembershipModule> Modules { get; set; }

    /// <summary>
    /// Получение внешнего модуля авторизации по уникальному идентификатору
    /// </summary>
    IExternalMembershipModule GetModule(Guid moduleUid);

    /// <summary>Сохранить настройки модуля авторизации</summary>
    void SaveSettings(IExternalMembershipModuleSettings settings);

    /// <summary>Загрузить настройки модуля авторизации</summary>
    IExternalMembershipModuleSettings LoadSettings(Guid instanceUid);

    /// <summary>Удалить настройки модуля авторизации</summary>
    void DeleteSettings(Guid moduleUid, Guid instanceUid);

    /// <summary>Загрузить все настройки всех модулей авторизации</summary>
    IEnumerable<IExternalMembershipModuleSettings> GetAllSettings();

    /// <summary>Создать настройки по умолчанию для модуля авторизации</summary>
    IExternalMembershipModuleSettings CreateDefaultSettings(
      IExternalMembershipModule module);

    /// <summary>Создать настройки по умолчанию для модуля авторизации</summary>
    IExternalMembershipModuleSettings CreateDefaultSettings(
      Func<IExternalMembershipModuleSettings> createDefaultSettingsFunc);

    /// <summary>Поиск пользователей по подстроке</summary>
    /// <param name="searchString">Строка поиска</param>
    /// <param name="authProviderGuid">Uid Провайдера авторизации</param>
    /// <returns>Список пользователей</returns>
    IEnumerable<IUser> FindUsers(string searchString, Guid authProviderGuid);

    string Name(Guid authProviderGuid);

    Dictionary<Guid, string> GetAllName();

    /// <summary>Синхронизировать данные о пользователе</summary>
    void Sync(IUser user, Guid authProviderGuid);

    /// <summary>Проверить авторизацию пользователя</summary>
    /// <returns><c>true</c>, если пользователь успешно авторизован</returns>
    void ValidateUser(UserValidationContext validationContext, Guid authProviderGuid);
  }
}
