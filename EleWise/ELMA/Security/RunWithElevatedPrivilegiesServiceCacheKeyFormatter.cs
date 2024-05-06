// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.RunWithElevatedPrivilegiesServiceCacheKeyFormatter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Компонент, изменяющий ключ кэша в зависимости от работы сервиса <see cref="T:EleWise.ELMA.Security.RunWithElevatedPrivilegiesService" />
  /// </summary>
  [Component]
  public class RunWithElevatedPrivilegiesServiceCacheKeyFormatter : ICacheKeyFormatter
  {
    private readonly RunWithElevatedPrivilegiesService service;
    private static RunWithElevatedPrivilegiesServiceCacheKeyFormatter SHBqkGk26G0dZ5FDR6t;

    /// <summary>Ctor</summary>
    /// <param name="service"></param>
    public RunWithElevatedPrivilegiesServiceCacheKeyFormatter(
      RunWithElevatedPrivilegiesService service)
    {
      RunWithElevatedPrivilegiesServiceCacheKeyFormatter.qv5bBjDuCWTLElTghki();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.service = service;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string Format(string cacheKey, InvocationParameters invocation)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!RunWithElevatedPrivilegiesServiceCacheKeyFormatter.s5thIFDwNR4XZaXbWnZ((object) this.service))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (string) RunWithElevatedPrivilegiesServiceCacheKeyFormatter.VnIaUwDK2iOPc3asnua((object) cacheKey, RunWithElevatedPrivilegiesServiceCacheKeyFormatter.k7wqIGDbFyGGTiwsg02(-110921701 >> 6 ^ -1722562));
label_3:
      return cacheKey;
    }

    internal static void qv5bBjDuCWTLElTghki() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool Dd2EW6kHaf9Ch8oT4ys() => RunWithElevatedPrivilegiesServiceCacheKeyFormatter.SHBqkGk26G0dZ5FDR6t == null;

    internal static RunWithElevatedPrivilegiesServiceCacheKeyFormatter TQKKS7kz0PCB5aZ4cSD() => RunWithElevatedPrivilegiesServiceCacheKeyFormatter.SHBqkGk26G0dZ5FDR6t;

    internal static bool s5thIFDwNR4XZaXbWnZ([In] object obj0) => ((RunWithElevatedPrivilegiesService) obj0).Turned;

    internal static object k7wqIGDbFyGGTiwsg02(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VnIaUwDK2iOPc3asnua([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
