// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.AssignedRoleStereotypeManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  public class AssignedRoleStereotypeManager : EntityManager<IAssignedRoleStereotype, long>
  {
    internal static AssignedRoleStereotypeManager ArNV0MXsdvKt75Bn0ku;

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            type = InterfaceActivator.TypeOf<IAssignedRoleStereotype>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      exportRule1.ParentType = type;
      AssignedRoleStereotypeManager.bbI2nAXSM3n6y0CEctb((object) exportRule1, AssignedRoleStereotypeManager.XsBmTnXrph5iXFe5oyW(2016571091 >> 5 ^ 62988104));
      exportRule1.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      AssignedRoleStereotypeManager.d4fpOVXYUmPWXWTbBfH((object) exportRule2, type);
      exportRule2.PropertyName = (string) AssignedRoleStereotypeManager.XsBmTnXrph5iXFe5oyW(1290337431 ^ 1290301463);
      exportRule2.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      exportRule3.ParentType = type;
      AssignedRoleStereotypeManager.bbI2nAXSM3n6y0CEctb((object) exportRule3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(213026252 ^ 213026670));
      exportRule3.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule3);
      return exportRuleList;
    }

    public AssignedRoleStereotypeManager()
    {
      AssignedRoleStereotypeManager.xIyIKCXybCx6GRrrUI9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object XsBmTnXrph5iXFe5oyW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void bbI2nAXSM3n6y0CEctb([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void d4fpOVXYUmPWXWTbBfH([In] object obj0, [In] Type obj1) => ((ExportRule) obj0).ParentType = obj1;

    internal static bool s96ckQX7FVrvU2Se1Vn() => AssignedRoleStereotypeManager.ArNV0MXsdvKt75Bn0ku == null;

    internal static AssignedRoleStereotypeManager f8bg1EXWZjO6Afxc1xa() => AssignedRoleStereotypeManager.ArNV0MXsdvKt75Bn0ku;

    internal static void xIyIKCXybCx6GRrrUI9() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
