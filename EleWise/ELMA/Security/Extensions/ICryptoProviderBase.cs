// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ICryptoProviderBase
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Models.Crypto;
using System;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>Базовый интерфейс работы с криптопровайдером</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface ICryptoProviderBase
  {
    /// <summary>Uid провайдера</summary>
    Guid ProviderUid { get; }

    /// <summary>Отображаемое имя провайдера</summary>
    string DisplayName { get; }

    /// <summary>Настройки провайдера</summary>
    CryptoProviderSettingsBase Settings { get; }

    /// <summary>Проверяет подпись</summary>
    /// <param name="originalData">Исходные данные</param>
    /// <param name="signedData">Подпись</param>
    /// <param name="verifySignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    IVerifyResult Verify(
      byte[] originalData,
      byte[] signedData,
      bool verifySignatureOnly);

    /// <summary>Вычисление хеша для подписания файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    string GetFileHash(BinaryFile file);
  }
}
