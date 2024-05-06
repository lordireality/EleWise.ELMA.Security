// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AbstractCAdESXLongType1
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
  /// <summary>CAdES-X Long Type 1</summary>
  public abstract class AbstractCAdESXLongType1 : IDigitalSignatureType
  {
    /// <summary>Uid</summary>
    public const string UID_S = "{A5B02E0E-D8AF-4D38-8585-07BF957257C3}";
    private static AbstractCAdESXLongType1 ofgCkt2RQwor5V4xjss;

    /// <inheritdoc />
    public virtual Guid Uid => new Guid((string) AbstractCAdESXLongType1.Scg70k2mRZeSYTNAvQJ(-1324692970 << 3 ^ -2007546758));

    /// <inheritdoc />
    public virtual string DisplayName => (string) AbstractCAdESXLongType1.U5vvUh26SNCsPqHDsTJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(928696104 ^ 928764466));

    /// <inheritdoc />
    public virtual string Code => z2jc63fLkugS1X8Q9N.tE1kD1vbB(2047763786 ^ 1536686658 ^ 563645004);

    /// <inheritdoc />
    public abstract IEnumerable<Guid> Providers { get; }

    protected AbstractCAdESXLongType1()
    {
      AbstractCAdESXLongType1.ryqQ592kfXTUyQRIJkP();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Scg70k2mRZeSYTNAvQJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QxjfXY2ojDyjAQ0SHZb() => AbstractCAdESXLongType1.ofgCkt2RQwor5V4xjss == null;

    internal static AbstractCAdESXLongType1 sRjqM52t91w5ldMYTng() => AbstractCAdESXLongType1.ofgCkt2RQwor5V4xjss;

    internal static object U5vvUh26SNCsPqHDsTJ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void ryqQ592kfXTUyQRIJkP() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
