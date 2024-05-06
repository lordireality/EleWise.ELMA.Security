// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ICryptoProviderBase2
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Files;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>
  /// Расширение интерфейса <see cref="T:EleWise.ELMA.Security.Extensions.ICryptoProviderBase" />
  /// </summary>
  public interface ICryptoProviderBase2 : ICryptoProviderBase
  {
    /// <summary>Получить хэш файла</summary>
    /// <param name="file">Файл</param>
    /// <param name="algorithm">Алгоритм</param>
    /// <returns>Хэш</returns>
    string GetFileHash(BinaryFile file, string algorithm);
  }
}
