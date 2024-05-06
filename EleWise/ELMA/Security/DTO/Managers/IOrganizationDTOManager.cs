// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.IOrganizationDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>Менеджер оргструктуры для работы через Remoting</summary>
  public interface IOrganizationDTOManager : IConfigurationService
  {
    /// <summary>Загрузить черновик модели оргструктуры</summary>
    /// <returns>Модель оргструктуры</returns>
    OrganizationModelDTO LoadOrNull();

    /// <summary>Загрузить модель оргструктуры указанной версии</summary>
    /// <param name="id">Id версии оргструктуры</param>
    /// <returns>Модель оргструктуры</returns>
    OrganizationModelDTO LoadOrNull(int id);

    /// <summary>Загрузить опубликованную версию оргструктуры</summary>
    /// <returns>Опубликованная версия оргструктуры или null</returns>
    OrganizationModelDTO LoadPublishedOrNull();

    /// <summary>Сохранить черновик оргструктуры</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <returns></returns>
    void Save(OrganizationModelDTO organizationModel);

    /// <summary>Опубликовать оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <returns>Id опубликованной версии</returns>
    int Publish(OrganizationModelDTO organizationModel);

    /// <summary>Опубликовать оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <param name="warning">Ошибка публикации оргструктуры</param>
    /// <returns>Id опубликованной версии, warning - список предупреждений </returns>
    int Publish(OrganizationModelDTO organizationModel, out OrganizationModelPublishWarning warning);

    /// <summary>Проверить оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <returns>Id проверенной версии</returns>
    int Validate(OrganizationModelDTO organizationModel);

    /// <summary>Проверить оргструктуру</summary>
    /// <param name="organizationModel">Модель оргструктуры</param>
    /// <param name="warning">Ошибка публикации оргструктуры</param>
    /// <returns>Id проверенной версии, warning - список предупреждений </returns>
    int Validate(
      OrganizationModelDTO organizationModel,
      out OrganizationModelPublishWarning warning);

    /// <summary>Найти все версии оргструктуры</summary>
    /// <returns>Список версий оргструктуры</returns>
    ICollection<OrganizationVersionDTO> FindAllVersions();

    /// <summary>Номер текущей версии оргструктуры</summary>
    int CurrentVersion { get; }
  }
}
