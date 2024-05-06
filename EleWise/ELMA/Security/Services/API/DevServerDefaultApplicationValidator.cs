// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.DevServerDefaultApplicationValidator
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Services.API
{
  /// <summary>Валидатор токена сервера разработки</summary>
  [Component]
  internal class DevServerDefaultApplicationValidator : DefaultApplicationValidator
  {
    internal static DevServerDefaultApplicationValidator x0eq3SVWKrGmf7mK84c;

    /// <inheritdoc />
    protected override Guid AppUid => PublicApplicationService.AppUid_DevServer;

    public DevServerDefaultApplicationValidator()
    {
      DevServerDefaultApplicationValidator.R37C76VYtkFjPslOq39();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void R37C76VYtkFjPslOq39() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool Pg9PsFVrRQxJg05FUTq() => DevServerDefaultApplicationValidator.x0eq3SVWKrGmf7mK84c == null;

    internal static DevServerDefaultApplicationValidator VMZlrYVSyFqOBIv1vhL() => DevServerDefaultApplicationValidator.x0eq3SVWKrGmf7mK84c;
  }
}
