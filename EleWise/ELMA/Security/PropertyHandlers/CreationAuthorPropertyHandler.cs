// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PropertyHandlers.CreationAuthorPropertyHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.PropertyHandlers
{
  /// <summary>Обработчик свойства "Автор"</summary>
  [Component(Order = 150)]
  internal class CreationAuthorPropertyHandler : TypedPropertyHandler
  {
    /// <summary>UID данного обработчика</summary>
    public const string UID_S = "{B05AC6BD-EB8B-474A-A796-B53831A9967E}";
    /// <summary>UID данного обработчика</summary>
    public static readonly Guid UID;
    private static CreationAuthorPropertyHandler bi8xEDCQXNFipav6E6b;

    /// <summary>Уникальный идентификатор обработчика</summary>
    public override Guid Uid => CreationAuthorPropertyHandler.UID;

    /// <summary>Имя обработчика (для текущей культуры)</summary>
    public override string Name => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2016571091 >> 5 ^ 63035726));

    /// <summary>Uid типа, для которого предназначен обработчик</summary>
    protected override Guid? TypeUid => new Guid?(EntityDescriptor.UID);

    /// <summary>Uid подтипа, для которого предназначен обработчик</summary>
    protected override Guid? SubTypeUid => new Guid?(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2086891181 ^ 2086874299)));

    public CreationAuthorPropertyHandler()
    {
      CreationAuthorPropertyHandler.DLlFFbCdyFMMbLl1u4S();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CreationAuthorPropertyHandler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CreationAuthorPropertyHandler.DLlFFbCdyFMMbLl1u4S();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CreationAuthorPropertyHandler.UID = new Guid((string) CreationAuthorPropertyHandler.eBneQcCErc8lwiemRYR(2086891181 ^ 2086872309));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool x6ZnyLC8kR1k0ZXYst6() => CreationAuthorPropertyHandler.bi8xEDCQXNFipav6E6b == null;

    internal static CreationAuthorPropertyHandler V4pmc6C5JYqnSJP2U7K() => CreationAuthorPropertyHandler.bi8xEDCQXNFipav6E6b;

    internal static void DLlFFbCdyFMMbLl1u4S() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object eBneQcCErc8lwiemRYR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
