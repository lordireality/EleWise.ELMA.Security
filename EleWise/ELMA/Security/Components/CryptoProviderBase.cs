// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CryptoProviderBase
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Базовый абстрактный класс работы с криптопровайдером</summary>
  public abstract class CryptoProviderBase : ICryptoProviderBase2, ICryptoProviderBase
  {
    internal static CryptoProviderBase tVDZMdHkpk88PtEBi2N;

    /// <summary>Uid провайдера</summary>
    public abstract Guid ProviderUid { get; }

    /// <summary>Отображаемое имя провайдера</summary>
    public virtual string DisplayName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              CryptoProviderBase.RMEHq9HC5JMJXruDP4y((object) this.Impl, CryptoProviderBase.ndNfBmHxvT5UQ63UVKc(1567399832 << 6 ^ 1529281550));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (string) CryptoProviderBase.xY8iljHiVJAgAkZ3Qph((object) this.Impl);
      }
    }

    /// <summary>Настройки провайдера</summary>
    public virtual CryptoProviderSettingsBase Settings
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              CryptoProviderBase.RMEHq9HC5JMJXruDP4y((object) this.Impl, CryptoProviderBase.ndNfBmHxvT5UQ63UVKc(-1788783669 - 1293477238 ^ 1212773467));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.Impl.Settings;
      }
    }

    /// <summary>Проверяет подпись</summary>
    /// <param name="originalData">Исходные данные</param>
    /// <param name="signedData">Подпись</param>
    /// <param name="verifySignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    public virtual IVerifyResult Verify(
      byte[] originalData,
      byte[] signedData,
      bool verifySignatureOnly)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CryptoProviderBase.RMEHq9HC5JMJXruDP4y((object) this.Impl, CryptoProviderBase.ndNfBmHxvT5UQ63UVKc(1053060681 ^ 1053127751));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IVerifyResult) CryptoProviderBase.qQ5jOOH3jC71YtRoyRW((object) this.Impl, (object) originalData, (object) signedData, verifySignatureOnly);
    }

    /// <summary>Вычисление хеша для подписания файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public virtual string GetFileHash(BinaryFile file)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CryptoProviderBase.RMEHq9HC5JMJXruDP4y((object) this.Impl, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899897007));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.Impl.GetFileHash(file);
    }

    /// <summary>Вычисление хеша для подписания файла</summary>
    /// <param name="file">Файл</param>
    /// <param name="algorithm">Алгоритм</param>
    /// <returns>Хэш</returns>
    public virtual string GetFileHash(BinaryFile file, string algorithm)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.Impl != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetFileHash(file);
label_3:
      return (string) CryptoProviderBase.LApSc0HjPxalJHOIL4P((object) this.Impl, (object) file, (object) algorithm);
    }

    /// <summary>Имплементация</summary>
    protected ICryptoProviderBase Impl
    {
      get => this.\u003CImpl\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CImpl\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    protected CryptoProviderBase()
    {
      CryptoProviderBase.YdAPupHN0ibD8t241E4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ndNfBmHxvT5UQ63UVKc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void RMEHq9HC5JMJXruDP4y([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object xY8iljHiVJAgAkZ3Qph([In] object obj0) => (object) ((ICryptoProviderBase) obj0).DisplayName;

    internal static bool RdtRArHD89DiwfPvF0q() => CryptoProviderBase.tVDZMdHkpk88PtEBi2N == null;

    internal static CryptoProviderBase f61Po3Haxrurd75TPsr() => CryptoProviderBase.tVDZMdHkpk88PtEBi2N;

    internal static object qQ5jOOH3jC71YtRoyRW(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool verifySignatureOnly)
    {
      return (object) ((ICryptoProviderBase) obj0).Verify((byte[]) obj1, (byte[]) obj2, verifySignatureOnly);
    }

    internal static object LApSc0HjPxalJHOIL4P([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICryptoProviderBase) obj0).GetFileHash((BinaryFile) obj1, (string) obj2);

    internal static void YdAPupHN0ibD8t241E4() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
