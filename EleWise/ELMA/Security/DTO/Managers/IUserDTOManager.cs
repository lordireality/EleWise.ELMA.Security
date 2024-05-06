// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.IUserDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>Менеджер пользователей для работы через Remoting</summary>
  public interface IUserDTOManager : IConfigurationService
  {
    /// <summary>Загрузить пользователя</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns></returns>
    UserDTO LoadOrNull(long id);
  }
}
