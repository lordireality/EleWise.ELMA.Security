// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.SecurityCacheUnitOfWorkListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  [Component(Order = 2147483647)]
  internal class SecurityCacheUnitOfWorkListener : IUnitOfWorkEventListener
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private readonly UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager;
    private readonly IEnumerable<IUserSecuritySetCacheUpdateExtension> userSecuritySetCacheUpdateExtensions;
    internal static SecurityCacheUnitOfWorkListener NQbJUfsJJCdENCoIr8L;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService">Интерфейс сервиса работы со значениями переменных в рамках контекста (например, веб-запроса)</param>
    /// <param name="updateUserSecuritySetCacheQueueManager">Служба для управления очередью обновления UserSecuritySetCache</param>
    /// <param name="userSecuritySetCacheUpdateExtensions">Точки расширения для обработки событий обновления UserSecuritySetCache</param>
    public SecurityCacheUnitOfWorkListener(
      IContextBoundVariableService contextBoundVariableService,
      UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager,
      IEnumerable<IUserSecuritySetCacheUpdateExtension> userSecuritySetCacheUpdateExtensions)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.contextBoundVariableService = contextBoundVariableService;
      this.updateUserSecuritySetCacheQueueManager = updateUserSecuritySetCacheQueueManager;
      this.userSecuritySetCacheUpdateExtensions = userSecuritySetCacheUpdateExtensions;
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users;
        Dictionary<IUserGroup, GroupUpdate> groups;
        Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_10;
            case 3:
              this.contextBoundVariableService.TryGetValue<Dictionary<IUserGroup, GroupUpdate>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447306085), out groups);
              num2 = 4;
              continue;
            case 4:
              goto label_9;
            case 5:
              this.updateUserSecuritySetCacheQueueManager.ExecuteUpdate(users, groups, organizationItems, SecurityCacheUnitOfWorkListener.IxEJDhs2ZOoNE302Tks((object) unitOfWork));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
              continue;
            case 6:
              this.contextBoundVariableService.TryGetValue<Dictionary<EleWise.ELMA.Security.Models.IUser, byte>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081755634), out users);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 3 : 0;
              continue;
            case 7:
              this.updateUserSecuritySetCacheQueueManager.ExecuteFullUpdate();
              num2 = 2;
              continue;
            case 8:
              num2 = 6;
              continue;
            case 9:
              if (!SecurityCacheUnitOfWorkListener.lftuoHsLPpE8WbXl6SW((object) this.contextBoundVariableService.GetOrAdd<SecurityCacheListener.UpdateFlag>((string) SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(1124861159 ^ 1124880613), (Func<SecurityCacheListener.UpdateFlag>) (() => SecurityCacheListener.UpdateFlag.False))))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 1 : 8;
                continue;
              }
              goto case 7;
            default:
              this.userSecuritySetCacheUpdateExtensions.ForEach<IUserSecuritySetCacheUpdateExtension>((Action<IUserSecuritySetCacheUpdateExtension>) (c =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      c.OnUpdate(users, groups, organizationItems);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 1;
              continue;
          }
        }
label_9:
        this.contextBoundVariableService.TryGetValue<Dictionary<IOrganizationItem, OrganizationItemUpdate>>((string) SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(-1324692970 << 3 ^ -2007628302), out organizationItems);
        num1 = 5;
      }
label_4:
      return;
label_10:;
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.contextBoundVariableService.Set((string) SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(789532496 ^ 1575286436 ^ 1928063596), (object) SecurityCacheListener.UpdateFlag.False);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 0 : 0;
            continue;
          case 2:
            SecurityCacheUnitOfWorkListener.BxGKHUsHN0Dost7HFGB((object) this.contextBoundVariableService, SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(-1440374117 ^ -1440352295));
            num = 4;
            continue;
          case 3:
            SecurityCacheUnitOfWorkListener.BxGKHUsHN0Dost7HFGB((object) this.contextBoundVariableService, SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(1124861159 ^ 1124880515));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 2 : 0;
            continue;
          case 4:
            goto label_2;
          case 5:
            SecurityCacheUnitOfWorkListener.BxGKHUsHN0Dost7HFGB((object) this.contextBoundVariableService, SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(581409346 ^ 581422742));
            num = 3;
            continue;
          default:
            this.contextBoundVariableService.Set((string) SecurityCacheUnitOfWorkListener.ivskyEsnURqq0oW0x3V(1212037053 ^ -1727812018 ^ -784478735), (object) SecurityCacheListener.UpdateFlag.False);
            num = 5;
            continue;
        }
      }
label_2:;
    }

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    internal static object ivskyEsnURqq0oW0x3V(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool lftuoHsLPpE8WbXl6SW([In] object obj0) => ((SecurityCacheListener.UpdateFlag) obj0).Enabled;

    internal static Guid IxEJDhs2ZOoNE302Tks([In] object obj0) => ((IUnitOfWork) obj0).Uid;

    internal static bool C5RD81sINRjqcCwd5c8() => SecurityCacheUnitOfWorkListener.NQbJUfsJJCdENCoIr8L == null;

    internal static SecurityCacheUnitOfWorkListener I1g0LNseigVyf6UAqZB() => SecurityCacheUnitOfWorkListener.NQbJUfsJJCdENCoIr8L;

    internal static void BxGKHUsHN0Dost7HFGB([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Remove((string) obj1);
  }
}
