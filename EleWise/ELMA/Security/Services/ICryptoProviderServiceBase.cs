// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ICryptoProviderServiceBase
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Models.Crypto;
using System;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Интерфейс базового сервиса криптопровайдеров</summary>
  public interface ICryptoProviderServiceBase
  {
    /// <summary>Uid провайдера по умолчанию (из глоб. настроек)</summary>
    Guid DefaultProviderUid { get; }

    /// <summary>Uid провайдер для пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user);

    /// <summary>Имя провайдер для пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    string GetUserProviderName(EleWise.ELMA.Security.Models.IUser user);

    /// <summary>Uid провайдер для пользователя</summary>
    /// <param name="user"></param>
    /// <param name="onlyProfile"></param>
    /// <returns></returns>
    Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile);

    /// <summary>Uid провайдер для текущего пользователя</summary>
    /// <returns></returns>
    Guid GetCurrentUserProviderUid();

    /// <summary>Uid провайдер для текущего пользователя</summary>
    /// <param name="onlyProfile"></param>
    /// <returns></returns>
    Guid GetCurrentUserProviderUid(bool onlyProfile);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text">Данные</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="encoding">Кодировка</param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя или провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user">Пользователь</param>
    /// <param name="providerUid">Uid провайдера, если не null, то в приоритете</param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? providerUid,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для текущего пользователя)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      string signature,
      bool checkSignatureOnly);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для текущего пользователя)
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      BinaryFile file,
      string signature,
      bool checkSignatureOnly);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="providerUid">Uid провайдера, если не null, то в приоритете</param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="providerUid">Uid провайдера, если не null, то в приоритете</param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      BinaryFile file,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="providerUid">Uid провайдера, если не null, то в приоритете</param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      BinaryFile file,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного пользователя)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с известной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid,
      string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для пользователя или указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="user"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? providerUid,
      out string encoding);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid);

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для текущего пользователя)
    /// </summary>
    /// <param name="content">Исходные данные</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного пользователя)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid);

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного пользователя или провайдера)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? providerUid);
  }
}
