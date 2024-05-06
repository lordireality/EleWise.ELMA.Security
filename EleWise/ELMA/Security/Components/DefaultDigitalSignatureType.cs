// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.DefaultDigitalSignatureType
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Тип электронной подписи по умолчанию</summary>
  /// <remarks>Имееют все криптопровайдеры</remarks>
  [Component]
  public class DefaultDigitalSignatureType : AbstractDefaultDigitalSignatureType
  {
    private static DefaultDigitalSignatureType Ip8X2EHXYMH2JkdmWsV;

    /// <inheritdoc />
    public override IEnumerable<Guid> Providers => ComponentManager.Current.GetExtensionPoints<IAuthCryptoProvider>().Select<IAuthCryptoProvider, Guid>((Func<IAuthCryptoProvider, Guid>) (p => DefaultDigitalSignatureType.\u003C\u003Ec.V15Dm2wlmN5WEcWnu0Rn((object) p)));

    public DefaultDigitalSignatureType()
    {
      DefaultDigitalSignatureType.NALbwDHMyK4HeDFdCIi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void NALbwDHMyK4HeDFdCIi() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool BPBX8hH9D8uwsnygHVW() => DefaultDigitalSignatureType.Ip8X2EHXYMH2JkdmWsV == null;

    internal static DefaultDigitalSignatureType xBQYY9H1TNtbD7OpfI1() => DefaultDigitalSignatureType.Ip8X2EHXYMH2JkdmWsV;
  }
}
