// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.IUserSecurityProfileEventHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>
  /// Расширение для обработки изменений UserSecurityProfile, проходящих прямыми запросами в БД
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IUserSecurityProfileEventHandler : IEventHandler
  {
    /// <summary>Разрешить авторизацию для указанных идентификаторов</summary>
    /// <param name="ids">Идентификаторы измененных UserSecurityProfile. Если null, то разрешена авторизация для всех</param>
    void AllowLogon(IEnumerable<long> ids = null);

    /// <summary>
    /// Сброс счетчика количества неудачных попыток для указанных идентификаторов
    /// </summary>
    /// <param name="ids">Идентификаторы измененных UserSecurityProfile. Если null, то счетчик был сброшен для всех</param>
    void ResetCountFailedLogon(IEnumerable<long> ids = null);

    /// <summary>Установлен флаг принудительного изменения пароля</summary>
    /// <param name="ids">Идентификаторы измененных UserSecurityProfile. Если null, то флаг был установлен для всех</param>
    void SetForcedChangePassword(IEnumerable<long> ids = null);
  }
}
