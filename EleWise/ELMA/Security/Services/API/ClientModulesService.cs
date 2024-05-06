// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.ClientModulesService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services.API
{
  [Service(Type = ComponentType.Server)]
  internal class ClientModulesService : IClientModulesService
  {
    private readonly ClientSessionDataSetsManager sessionDataSetsManager;
    private static ClientModulesService YEKVjvYHXyfn8lKYJRg;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Security.Services.API.ClientModulesService" />.
    /// </summary>
    public ClientModulesService(
      ClientSessionDataSetsManager sessionDataSetsManager)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.sessionDataSetsManager = sessionDataSetsManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public EleWise.ELMA.API.Models.IClientSessionDataSets GetSessionModules(
      string sessionToken)
    {
      return (EleWise.ELMA.API.Models.IClientSessionDataSets) this.sessionDataSetsManager.FindByToken(sessionToken);
    }

    public bool UpdateDataSets(string sessionToken, List<Guid> dataSets)
    {
      if (sessionToken == null || sessionToken.Length != 128)
        return false;
      EleWise.ELMA.Security.Models.API.IClientSessionDataSets byToken = this.sessionDataSetsManager.FindByToken(sessionToken);
      if (dataSets != null && dataSets.Count > 0)
      {
        if (byToken == null)
          byToken = new InstanceOf<EleWise.ELMA.Security.Models.API.IClientSessionDataSets>()
          {
            New = {
              SessionToken = sessionToken
            }
          }.New;
        byToken.DataSets = dataSets.Count > 0 ? dataSets : (List<Guid>) null;
        this.sessionDataSetsManager.Save(byToken);
      }
      else if (byToken != null)
        this.sessionDataSetsManager.Delete(byToken);
      return true;
    }

    internal static bool IJde8pYzGkrkKxgiKPp() => ClientModulesService.YEKVjvYHXyfn8lKYJRg == null;

    internal static ClientModulesService N2ifJjyuq4mutkHwOYN() => ClientModulesService.YEKVjvYHXyfn8lKYJRg;
  }
}
