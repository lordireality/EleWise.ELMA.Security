// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExtensionPoints.IEntityPermissionAccessRequestProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для работы с запрашиваемыми правами по сущности
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  internal interface IEntityPermissionAccessRequestProvider
  {
    /// <summary>Можно ли использовать точку расширения</summary>
    /// <param name="typeUid">Уникальный идентификатор типа сущности</param>
    /// <returns><c>True</c>Если точку расширения можно использовать</returns>
    bool CanUse(Guid typeUid);

    /// <summary>Предоставить доступ</summary>
    /// <param name="entity">Сущность, к к оторой предоставляется доступ</param>
    /// <param name="grantedAccess">Список уникальных идентификаторов предоставляемых прав доступа</param>
    /// <param name="user">Пользователь, которому предоставляется доступ</param>
    void GrantAccess(object entity, IEnumerable<Permission> grantedAccess, EleWise.ELMA.Security.Models.IUser user);

    /// <summary>Получить тему для задачи предоставления доступа</summary>
    /// <param name="entity">Сущность, к которой запрашивается доступ</param>
    /// <returns>Тема задачи</returns>
    /// <remarks>
    /// В тему задачи прописывается название типа сущности, к которой запрашивается доступ, и наименование самой сущности
    /// Например
    /// - Предоставить доступ к документу "Picture.jpg"
    /// </remarks>
    string GetTaskSubject(object entity);

    /// <summary>
    /// Получить заголовок для создания задачи предоставления доступа
    /// </summary>
    /// <param name="entity">Сущность, к которой запрашивается доступ</param>
    /// <returns>Заголовок задачи</returns>
    /// <remarks>
    /// В заголовок задачи прописывается название типа сущности, к которой запрашивается доступ, и наименование самой сущности
    /// Например
    /// - Запрос прав доступа к документу "Picture.jpg"
    /// </remarks>
    string GetCreatingTaskHeader(object entity);

    /// <summary>
    /// Получить название типа сущности, к которой запрашивается доступ
    /// </summary>
    /// <param name="entity">Сущность, к которой запрашивается доступ</param>
    /// <returns>Название типа сущности</returns>
    string GetObjectTypeName(object entity);

    /// <summary>
    /// Получить список пользователей, которые могут предоставить доступ
    /// </summary>
    /// <param name="entityTypeUid">Уникальный идентификатор типа сущности</param>
    /// <param name="entityId">Идентификатор сущности</param>
    /// <returns>Список пользователей</returns>
    IEnumerable<EleWise.ELMA.Security.Models.IUser> GetAdmins(
      Guid entityTypeUid,
      long entityId);
  }
}
