// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.PersonalGroupManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер персональных групп пользователей</summary>
  public class PersonalGroupManager : EntityManager<IPersonalGroup, long>
  {
    internal static PersonalGroupManager pfBntVhTDDeyTGdPssF;

    /// <summary>
    /// 
    /// </summary>
    [NotNull]
    public static PersonalGroupManager Instance => Locator.GetServiceNotNull<PersonalGroupManager>();

    public PersonalGroupManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mOfIKLhF2FkDmFcpyBx() => PersonalGroupManager.pfBntVhTDDeyTGdPssF == null;

    internal static PersonalGroupManager CjcvJnhvJYJGZFNfJrA() => PersonalGroupManager.pfBntVhTDDeyTGdPssF;
  }
}
