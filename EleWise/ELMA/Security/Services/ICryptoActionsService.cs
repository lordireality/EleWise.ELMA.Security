// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ICryptoActionsService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Интерфейс сервиса криптодействий</summary>
  public interface ICryptoActionsService
  {
    /// <summary>Все действия пользователя имеют один и тот провайдер</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    bool IsProvidersEquals(EleWise.ELMA.Security.Models.IUser user);

    /// <summary>Uid'ы действий</summary>
    Guid[] ActionUids { get; }
  }
}
