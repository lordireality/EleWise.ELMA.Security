// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryInFunctions.GetChiefByUserFunction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.QueryInFunctions
{
  [Component]
  internal class GetChiefByUserFunction : IQueryInFunction, IEQLFunction
  {
    internal static GetChiefByUserFunction XQJZemxhwE9JMmwHKkJ;

    public string FunctionName => (string) GetChiefByUserFunction.gqCS3dxOPBO4FwKi9Ci(--1207559533 ^ 1207542065);

    public ICriterion GetCriterion(
      string alias,
      EntityMetadata metadata,
      string propName,
      object[] parameters)
    {
      int num = 2;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parameters.Length != 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 1;
              continue;
            }
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (ICriterion) NHQueryExtensions.Sql((string) GetChiefByUserFunction.TrEfb7xvRFoyHh1YZwv(GetChiefByUserFunction.gqCS3dxOPBO4FwKi9Ci(-1424960806 ^ -1424976218), (object) new object[6]
      {
        (object) propName,
        GetChiefByUserFunction.fRcPArxF9dRlHRuoKPq(GetChiefByUserFunction.aSRUrFxTjPCm4yXiNG3((object) serviceNotNull), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370690681)),
        GetChiefByUserFunction.fRcPArxF9dRlHRuoKPq(GetChiefByUserFunction.aSRUrFxTjPCm4yXiNG3((object) serviceNotNull), GetChiefByUserFunction.gqCS3dxOPBO4FwKi9Ci(1458233619 ^ 1458217717)),
        GetChiefByUserFunction.fRcPArxF9dRlHRuoKPq(GetChiefByUserFunction.aSRUrFxTjPCm4yXiNG3((object) serviceNotNull), GetChiefByUserFunction.gqCS3dxOPBO4FwKi9Ci(-94240706 ^ -94223168)),
        parameters[0],
        (object) alias
      }));
label_5:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(978908330 << 6 ^ -1774358620), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112587884))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123910913)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1640694811 << 2 ^ 2027137926), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(false)
        }
      }
    };

    public GetChiefByUserFunction()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object gqCS3dxOPBO4FwKi9Ci(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool lr1N6vxBf39ltgFiNrs() => GetChiefByUserFunction.XQJZemxhwE9JMmwHKkJ == null;

    internal static GetChiefByUserFunction KuKFnExprFtYmxQK2I4() => GetChiefByUserFunction.XQJZemxhwE9JMmwHKkJ;

    internal static object aSRUrFxTjPCm4yXiNG3([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object fRcPArxF9dRlHRuoKPq([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object TrEfb7xvRFoyHh1YZwv([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);
  }
}
