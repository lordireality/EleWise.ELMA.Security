// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryInFunctions.GetUserSubordinateFunction
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
  internal class GetUserSubordinateFunction : IQueryInFunction, IEQLFunction
  {
    private static GetUserSubordinateFunction RYCdQvxq11pf3Ka065R;

    public string FunctionName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1310136491 - -570921450 ^ -739230549);

    public ICriterion GetCriterion(
      string alias,
      EntityMetadata metadata,
      string propName,
      object[] parameters)
    {
      int num = 1;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameters.Length == 1)
            {
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 1 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentException();
label_6:
      return (ICriterion) GetUserSubordinateFunction.pfIdQ4x2oa4u3U7H2Xq(GetUserSubordinateFunction.YGFU46xLAKr740yNTap(GetUserSubordinateFunction.cCgGZmxI1FDduN8dxFr(-206147790 ^ -206165362), (object) new object[6]
      {
        (object) propName,
        GetUserSubordinateFunction.jAt2hDxeh6ZBLGRpfvH((object) serviceNotNull.Dialect, GetUserSubordinateFunction.cCgGZmxI1FDduN8dxFr(1567399832 << 6 ^ 1529324286)),
        GetUserSubordinateFunction.jAt2hDxeh6ZBLGRpfvH(GetUserSubordinateFunction.m9wnvaxnWJgCunhQ9hM((object) serviceNotNull), GetUserSubordinateFunction.cCgGZmxI1FDduN8dxFr(-517128429 ^ -517112587)),
        (object) serviceNotNull.Dialect.QuoteIfNeeded((string) GetUserSubordinateFunction.cCgGZmxI1FDduN8dxFr(-1751467293 ^ -1751467953)),
        parameters[0],
        (object) alias
      }));
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--353012470 ^ 353030098), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-404268492 ^ -404283636))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277487309)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1530848604 ^ 1530831182), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(false)
        }
      }
    };

    public GetUserSubordinateFunction()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool I0cpF4xgxsyBSo8Q38H() => GetUserSubordinateFunction.RYCdQvxq11pf3Ka065R == null;

    internal static GetUserSubordinateFunction hTKsusxJdUZaHSCiqJB() => GetUserSubordinateFunction.RYCdQvxq11pf3Ka065R;

    internal static object cCgGZmxI1FDduN8dxFr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jAt2hDxeh6ZBLGRpfvH([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object m9wnvaxnWJgCunhQ9hM([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object YGFU46xLAKr740yNTap([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object pfIdQ4x2oa4u3U7H2Xq([In] object obj0) => (object) NHQueryExtensions.Sql((string) obj0);
  }
}
