// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AbstractCAdEST
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>CAdES-T</summary>
  public abstract class AbstractCAdEST : IDigitalSignatureType
  {
    /// <summary>Uid</summary>
    public const string UID_S = "{01985977-5BED-4847-B310-26643A33586F}";
    private static AbstractCAdEST aHvZSxLzgcWlJ9EIQOp;

    /// <inheritdoc />
    public virtual Guid Uid => new Guid((string) AbstractCAdEST.l1Wi3i2bvtNYlL4IIly(386642440 ^ 386573904));

    /// <inheritdoc />
    public virtual string DisplayName => (string) AbstractCAdEST.eE61cs2KsIis8b1075F(AbstractCAdEST.l1Wi3i2bvtNYlL4IIly(--353012470 ^ 353082974));

    /// <inheritdoc />
    public virtual string Code => (string) AbstractCAdEST.l1Wi3i2bvtNYlL4IIly(-522456341 ^ -522525103);

    /// <inheritdoc />
    public abstract IEnumerable<Guid> Providers { get; }

    protected AbstractCAdEST()
    {
      AbstractCAdEST.cSt87R2UkNZg0BmS8dZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object l1Wi3i2bvtNYlL4IIly(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CiZ3iS2ueAMJ1QtJ9y2() => AbstractCAdEST.aHvZSxLzgcWlJ9EIQOp == null;

    internal static AbstractCAdEST kHtUkJ2wIl6BJBwn8d8() => AbstractCAdEST.aHvZSxLzgcWlJ9EIQOp;

    internal static object eE61cs2KsIis8b1075F([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void cSt87R2UkNZg0BmS8dZ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
