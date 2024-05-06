// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.Crypto.IVerifyResult
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

namespace EleWise.ELMA.Security.Models.Crypto
{
  /// <summary>Интерфейс результата проверки подписи</summary>
  public interface IVerifyResult
  {
    /// <summary>Рез-т проверки</summary>
    bool Verified { get; set; }

    /// <summary>Подписывающий</summary>
    ISigner Signer { get; set; }

    /// <summary>Текст ошибки</summary>
    string Error { get; set; }

    /// <summary>Текст предупреждения</summary>
    string Warning { get; set; }

    /// <summary>
    /// Проверить на валидность рез-т, если не валиден выкинуть исключение
    /// </summary>
    void ThrowIfNotVerified();

    /// <summary>Имя провайдера</summary>
    string ProviderName { get; set; }
  }
}
