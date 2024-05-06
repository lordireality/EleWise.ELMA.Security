// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.CryptoActionsService
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

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис криптодействий</summary>
  [Service]
  public class CryptoActionsService : ICryptoActionsService
  {
    internal static CryptoActionsService QMqpaXW6bMpOylWXpjX;

    public IEnumerable<ICryptoAction> CryptoActions { get; set; }

    public Guid[] ActionUids
    {
      get
      {
        IEnumerable<ICryptoAction> cryptoActions = this.CryptoActions;
        Func<ICryptoAction, Guid> func = CryptoActionsService.\u003C\u003Ec.\u003C\u003E9__5_0;
        Func<ICryptoAction, Guid> selector;
        if (func == null)
          CryptoActionsService.\u003C\u003Ec.\u003C\u003E9__5_0 = selector = (Func<ICryptoAction, Guid>) (c => CryptoActionsService.\u003C\u003Ec.bQFoiww3KoLCmCjsHcBF((object) c));
        else
          goto label_1;
label_3:
        return cryptoActions.Select<ICryptoAction, Guid>(selector).ToArray<Guid>();
label_1:
        selector = func;
        goto label_3;
      }
    }

    public bool IsProvidersEquals(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            user1 = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      return this.CryptoActions.Select<ICryptoAction, ICryptoProviderServiceBase>((Func<ICryptoAction, ICryptoProviderServiceBase>) (a => a.CryptoService)).Where<ICryptoProviderServiceBase>((Func<ICryptoProviderServiceBase, bool>) (s => s != null)).Select<ICryptoProviderServiceBase, string>((Func<ICryptoProviderServiceBase, string>) (s => s.GetUserProviderName(user1))).Distinct<string>().Count<string>() == 1;
    }

    public CryptoActionsService()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vrNUFIWkZ7Dv7SvOZi0() => CryptoActionsService.QMqpaXW6bMpOylWXpjX == null;

    internal static CryptoActionsService dg6W7mWDSdgWGewYZrI() => CryptoActionsService.QMqpaXW6bMpOylWXpjX;
  }
}
