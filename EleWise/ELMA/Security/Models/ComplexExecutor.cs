// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.ComplexExecutor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Модель выбора исполнителя</summary>
  public class ComplexExecutor
  {
    internal static ComplexExecutor pMJkMQ4ghvI6bqJUBDO;

    /// <summary>Исполнители</summary>
    public List<ComplexExecutorInfo> Workers { get; set; }

    /// <summary>Список пользователей</summary>
    public List<IUser> Users => this.Workers == null ? new List<IUser>() : this.Workers.Where<ComplexExecutorInfo>((Func<ComplexExecutorInfo, bool>) (w => ComplexExecutor.\u003C\u003Ec.cm1uqPwZigF4k5FVyD9a((object) w) != null)).Select<ComplexExecutorInfo, IUser>((Func<ComplexExecutorInfo, IUser>) (w => (IUser) ComplexExecutor.\u003C\u003Ec.cm1uqPwZigF4k5FVyD9a((object) w))).ToList<IUser>();

    /// <summary>Список групп</summary>
    public List<IUserGroup> Groups => this.Workers == null ? new List<IUserGroup>() : this.Workers.Where<ComplexExecutorInfo>((Func<ComplexExecutorInfo, bool>) (w => ComplexExecutor.\u003C\u003Ec.PAqRFhwZ3Ckse3yNpT4S((object) w) != null)).Select<ComplexExecutorInfo, IUserGroup>((Func<ComplexExecutorInfo, IUserGroup>) (w => w.UserGroup)).ToList<IUserGroup>();

    /// <summary>Получить всех исполнителей</summary>
    /// <returns></returns>
    public List<IUser> CalcExecutors()
    {
      List<IUser> executors = new List<IUser>((IEnumerable<IUser>) this.Users);
      this.Groups.ForEach((Action<IUserGroup>) (g =>
      {
        int num1 = 1;
        IEnumerator<long> enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              enumerator = ((UserGroupManager) ComplexExecutor.\u003C\u003Ec__DisplayClass8_0.IsOE1swZA6p1nRAt8B95()).GetUsersByGroup(g.Id).GetEnumerator();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_22;
            default:
              goto label_3;
          }
        }
label_22:
        return;
label_3:
        try
        {
label_10:
          // ISSUE: reference to a compiler-generated method
          if (ComplexExecutor.\u003C\u003Ec__DisplayClass8_0.lpxoqbwZ7dofFg54hCGm((object) enumerator))
            goto label_6;
          else
            goto label_11;
label_5:
          IUser user1;
          int num2;
          long user;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_17;
              case 2:
                // ISSUE: reference to a compiler-generated method
                user1 = ((AbstractNHEntityManager<IUser, long>) ComplexExecutor.\u003C\u003Ec__DisplayClass8_0.uVvHakwZs4nrOPo6v5fL()).Load(user);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 6 : 4;
                continue;
              case 3:
                goto label_6;
              case 4:
                executors.Add(user1);
                num2 = 7;
                continue;
              case 5:
              case 7:
              case 8:
                goto label_10;
              case 6:
                if (user1.Status != UserStatus.Active)
                {
                  num2 = 5;
                  continue;
                }
                goto case 4;
              case 9:
                if (!executors.All<IUser>((Func<IUser, bool>) (e => e.Id != user)))
                {
                  num2 = 8;
                  continue;
                }
                goto case 2;
              default:
                user = enumerator.Current;
                num2 = 9;
                continue;
            }
          }
label_17:
          return;
label_6:
          num2 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0)
          {
            num2 = 0;
            goto label_5;
          }
          else
            goto label_5;
label_11:
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 1;
          goto label_5;
        }
        finally
        {
          if (enumerator != null)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_24;
                default:
                  // ISSUE: reference to a compiler-generated method
                  ComplexExecutor.\u003C\u003Ec__DisplayClass8_0.xGSP3iwZW6klRdQqtLuY((object) enumerator);
                  num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_24:;
        }
      }));
      return executors;
    }

    /// <summary>Ctor</summary>
    public ComplexExecutor()
    {
      ComplexExecutor.O7j7kA4eOqPa19gZIyT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Workers = new List<ComplexExecutorInfo>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static void O7j7kA4eOqPa19gZIyT() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool mUupnj4JaGFBqFnIVDL() => ComplexExecutor.pMJkMQ4ghvI6bqJUBDO == null;

    internal static ComplexExecutor k3dmJo4IOmJr152nw2T() => ComplexExecutor.pMJkMQ4ghvI6bqJUBDO;
  }
}
