// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PropertyHandlers.ChangeAuthorPropertyHandler
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
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.PropertyHandlers
{
  /// <summary>Обработчик свойства "Автор последнего изменения"</summary>
  [Component(Order = 250)]
  public class ChangeAuthorPropertyHandler : TypedPropertyHandler
  {
    /// <summary>UID данного обработчика</summary>
    public const string UID_S = "{D152E660-1EE9-4B5F-A614-DF280E5B3F98}";
    /// <summary>UID данного обработчика</summary>
    public static readonly Guid UID;
    internal static ChangeAuthorPropertyHandler ag55xlCVoRR7t1dKDnk;

    /// <summary>Уникальный идентификатор обработчика</summary>
    public override Guid Uid => ChangeAuthorPropertyHandler.UID;

    /// <summary>Имя обработчика (для текущей культуры)</summary>
    public override string Name => (string) ChangeAuthorPropertyHandler.idoovDCct6ZE2XLcNtN(ChangeAuthorPropertyHandler.tN4ZpEC4yuOvBP867tE(1433051380 + 1051547170 ^ -1810383194));

    /// <summary>Uid типа, для которого предназначен обработчик</summary>
    protected override Guid? TypeUid => new Guid?(EntityDescriptor.UID);

    /// <summary>Uid подтипа, для которого предназначен обработчик</summary>
    protected override Guid? SubTypeUid => new Guid?(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841245981)));

    public ChangeAuthorPropertyHandler()
    {
      ChangeAuthorPropertyHandler.T6haSaCPHcO51pr3Oum();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ChangeAuthorPropertyHandler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ChangeAuthorPropertyHandler.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17837901 ^ -17852069));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object tN4ZpEC4yuOvBP867tE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object idoovDCct6ZE2XLcNtN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool O2Ei2GClMxNEjp0wlLH() => ChangeAuthorPropertyHandler.ag55xlCVoRR7t1dKDnk == null;

    internal static ChangeAuthorPropertyHandler Gb18KSCfc68TwCj8esu() => ChangeAuthorPropertyHandler.ag55xlCVoRR7t1dKDnk;

    internal static void T6haSaCPHcO51pr3Oum() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
