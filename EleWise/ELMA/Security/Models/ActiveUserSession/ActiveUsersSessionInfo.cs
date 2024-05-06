// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.ActiveUserSession.ActiveUsersSessionInfo
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models.ActiveUserSession
{
  /// <summary>Информация о пользователях и их активных сессий</summary>
  internal class ActiveUsersSessionInfo
  {
    private static ActiveUsersSessionInfo yQNrTsdzycoXD0N0GLQ;

    /// <summary>Количество активных сессий текущего пользователя</summary>
    public int? LoginCount { get; set; }

    /// <summary>
    /// Количество пользователей, у которых есть активные сессии
    /// </summary>
    public int? TotalLoginCount { get; set; }

    public ActiveUsersSessionInfo()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gDG0H3EurOnXRHqNQxB() => ActiveUsersSessionInfo.yQNrTsdzycoXD0N0GLQ == null;

    internal static ActiveUsersSessionInfo pEU6bbEwHYOT7V5U1lN() => ActiveUsersSessionInfo.yQNrTsdzycoXD0N0GLQ;
  }
}
