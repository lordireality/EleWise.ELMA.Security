// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AbstractDefaultDigitalSignatureType
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Тип электронной подписи по умолчанию</summary>
  /// <remarks>Имееют все криптопровайдеры</remarks>
  public abstract class AbstractDefaultDigitalSignatureType : IDigitalSignatureType
  {
    /// <summary>Uid</summary>
    public const string UID_S = "{AB3C2165-B5A3-4B24-929F-7E0D5183DB19}";
    internal static AbstractDefaultDigitalSignatureType fMDrPi2DFI3KduNwS7V;

    /// <inheritdoc />
    public virtual Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1596821387 ^ -1596758765));

    /// <inheritdoc />
    public virtual string DisplayName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1762575989 ^ 1762644931);

    /// <inheritdoc />
    public virtual string Code => (string) AbstractDefaultDigitalSignatureType.EQWZyc2CeOF8rP0Your(1690569372 >> 6 ^ 26347002);

    /// <inheritdoc />
    public abstract IEnumerable<Guid> Providers { get; }

    protected AbstractDefaultDigitalSignatureType()
    {
      AbstractDefaultDigitalSignatureType.GjSDmB2i20ns3G66OIZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool B0dAX72a3jRX2M6gClu() => AbstractDefaultDigitalSignatureType.fMDrPi2DFI3KduNwS7V == null;

    internal static AbstractDefaultDigitalSignatureType bCgYNX2xcxuNqJDcUM6() => AbstractDefaultDigitalSignatureType.fMDrPi2DFI3KduNwS7V;

    internal static object EQWZyc2CeOF8rP0Your(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void GjSDmB2i20ns3G66OIZ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
