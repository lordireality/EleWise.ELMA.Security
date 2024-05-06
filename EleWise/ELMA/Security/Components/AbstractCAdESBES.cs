// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AbstractCAdESBES
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
  /// <summary>CAdES-BES</summary>
  public abstract class AbstractCAdESBES : IDigitalSignatureType
  {
    /// <summary>Uid</summary>
    public const string UID_S = "{ED5FCF1C-B73F-4961-B671-7B26D1C1E0ED}";
    private static AbstractCAdESBES tcBHkwLeSIINZsWKWun;

    /// <inheritdoc />
    public virtual Guid Uid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-404268492 ^ -404338198));

    /// <inheritdoc />
    public virtual string DisplayName => (string) AbstractCAdESBES.wOwuA6LHVwyLUYdOMxe(AbstractCAdESBES.S5aC95L2ct0xIaFkKrp(658384612 ^ 658453194));

    /// <inheritdoc />
    public virtual string Code => (string) AbstractCAdESBES.S5aC95L2ct0xIaFkKrp(-617657301 ^ -617719697);

    /// <inheritdoc />
    public abstract IEnumerable<Guid> Providers { get; }

    protected AbstractCAdESBES()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OGKcVGLnF0n1WiPP4JY() => AbstractCAdESBES.tcBHkwLeSIINZsWKWun == null;

    internal static AbstractCAdESBES XHielLLLSJ6l3j37OEc() => AbstractCAdESBES.tcBHkwLeSIINZsWKWun;

    internal static object S5aC95L2ct0xIaFkKrp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wOwuA6LHVwyLUYdOMxe([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
