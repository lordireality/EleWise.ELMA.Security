// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ICertificateCryptoAction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>Криптодействие по работе с сертификатами</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface ICertificateCryptoAction : ICryptoAction
  {
    /// <summary>Поддерживает ли только серт-т по умолчанию?</summary>
    bool SupportOnlyDefaultCertificate { get; }

    /// <summary>Поддерживает другие устройства</summary>
    bool SupportOtherDevices { get; }

    /// <summary>Есть права у пользователя?</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    bool HasPermission(EleWise.ELMA.Security.Models.IUser user);

    /// <summary>Есть права у пользователя?</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="msg">Сообщение</param>
    /// <returns></returns>
    bool HasPermission(EleWise.ELMA.Security.Models.IUser user, out string msg);

    /// <summary>
    /// Возможно ли зарегистрировать сертифкат для этого действия?
    /// </summary>
    /// <returns></returns>
    bool CanRegisterCertificate(out string msg);

    /// <summary>Возможно ли отвязать сертификат от этого действия:?</summary>
    /// <returns></returns>
    bool CanUnregisterCertificate(IUserCertificate cert, out string msg);

    /// <summary>Вкл/выкл доверенные</summary>
    /// <param name="user"></param>
    /// <param name="enabled"></param>
    void EnableTrusted(EleWise.ELMA.Security.Models.IUser user, bool enabled);
  }
}
