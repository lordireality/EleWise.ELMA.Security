// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.SecurityDeployHelper
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Deploy
{
  /// <summary>Расширение экспорта-импорта для объектов Security</summary>
  [Component]
  public class SecurityDeployHelper : ISecurityDeployHelperExtension
  {
    private static SecurityDeployHelper h6yvS2IafkaLFraZvOu;

    public EleWise.ELMA.Security.IUser LoadUserOrNull(long userId) => (EleWise.ELMA.Security.IUser) ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDeployHelper.W34BJiIiMdUcVW5bjJP()).LoadOrNull(userId);

    public SecurityDeployHelper()
    {
      SecurityDeployHelper.cLSTYxI3wpuGxaZYSkJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object W34BJiIiMdUcVW5bjJP() => (object) UserManager.Instance;

    internal static bool HCnh5TIx5GL4m3vWX14() => SecurityDeployHelper.h6yvS2IafkaLFraZvOu == null;

    internal static SecurityDeployHelper Vft6A0IC1w7I1BiwkD5() => SecurityDeployHelper.h6yvS2IafkaLFraZvOu;

    internal static void cLSTYxI3wpuGxaZYSkJ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
