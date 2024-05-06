// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.AssignedRoleTypeModel
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models
{
  public class AssignedRoleTypeModel
  {
    private readonly PermissionRoleType permissionRoleType;
    private readonly IEntity value;
    internal static AssignedRoleTypeModel KrGybtQ4MAX4lU2vAdn;

    public AssignedRoleTypeModel(PermissionRoleType permissionRoleType, IEntity value)
    {
      AssignedRoleTypeModel.elWxBMQQokvANProMkq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.value = value;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 1 : 0;
            continue;
          default:
            this.permissionRoleType = permissionRoleType;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public PermissionRoleType PermissionRoleType => this.permissionRoleType;

    public IEntity Value => this.value;

    internal static void elWxBMQQokvANProMkq() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool oa2vneQcXa4WrKDT1Xi() => AssignedRoleTypeModel.KrGybtQ4MAX4lU2vAdn == null;

    internal static AssignedRoleTypeModel W0lVKnQPvClqhjxdUD2() => AssignedRoleTypeModel.KrGybtQ4MAX4lU2vAdn;
  }
}
