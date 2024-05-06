// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryFunctionResults.CurrentUserQueryResult
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.QueryFunctionResults
{
  [Component]
  public class CurrentUserQueryResult : IQueryFunctionResult, IEQLFunction
  {
    internal static CurrentUserQueryResult PfyGDACr5XdJmSfDrTq;

    public string FunctionName => (string) CurrentUserQueryResult.Jvm1NPCyiiHA2oM1lia(-278393783 ^ -278379229);

    public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameters.Length == 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id;
label_5:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1658561670 << 4 ^ 767167602), (object) this.FunctionName),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123910111)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1290337431 ^ 1290320005), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(false)
        }
      }
    };

    public CurrentUserQueryResult()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Jvm1NPCyiiHA2oM1lia(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool l4hZ5KCSVDvPE1mRF5X() => CurrentUserQueryResult.PfyGDACr5XdJmSfDrTq == null;

    internal static CurrentUserQueryResult djNjBRCY394jjggPOML() => CurrentUserQueryResult.PfyGDACr5XdJmSfDrTq;
  }
}
