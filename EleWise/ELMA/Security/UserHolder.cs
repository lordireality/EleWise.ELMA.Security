// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.UserHolder
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security
{
  /// <summary>Сериализуемое хранилище для пользователей</summary>
  [Serializable]
  internal class UserHolder : EntityHolder<long, EleWise.ELMA.Security.Models.IUser>
  {
    private Guid _ticketId;
    private static UserHolder GGiqGyDvVv5dXE6arUv;

    /// <summary>Конструктор</summary>
    /// <param name="user">Пользователь системы</param>
    /// <param name="ticketId">ID тикета</param>
    public UserHolder(EleWise.ELMA.Security.Models.IUser user, Guid ticketId)
    {
      UserHolder.D8XRi3DJ4p0yOZG25KK();
      // ISSUE: explicit constructor call
      base.\u002Ector(user);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this._ticketId = ticketId;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public Guid TicketId => this._ticketId;

    internal static void D8XRi3DJ4p0yOZG25KK() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool nJ0AixDqps3lfE5spun() => UserHolder.GGiqGyDvVv5dXE6arUv == null;

    internal static UserHolder H1YjRvDg3lFvBTtKfAG() => UserHolder.GGiqGyDvVv5dXE6arUv;
  }
}
