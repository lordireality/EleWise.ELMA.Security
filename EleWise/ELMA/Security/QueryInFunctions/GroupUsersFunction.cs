// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryInFunctions.GroupUsersFunction
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
  internal class GroupUsersFunction : IQueryInFunction, IEQLFunction
  {
    private static GroupUsersFunction lybwsQxH9Hg8cqoVXoj;

    public string FunctionName => (string) GroupUsersFunction.rI9pOTCwbi8ddmRgonJ(--1207559533 ^ 1207542767);

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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (ICriterion) GroupUsersFunction.Xy2yP9CRfH2MqLO9OWq(GroupUsersFunction.Cxd1nkCUPsqT1rGPj7f(GroupUsersFunction.rI9pOTCwbi8ddmRgonJ(-1691384762 ^ -1691367624), (object) new object[6]
      {
        (object) propName,
        GroupUsersFunction.Piic1BCKvDUutAwYN3g(GroupUsersFunction.ox0NMICb2TJ1oQvCxY3((object) serviceNotNull), GroupUsersFunction.rI9pOTCwbi8ddmRgonJ(-206147790 ^ -206148194)),
        GroupUsersFunction.Piic1BCKvDUutAwYN3g(GroupUsersFunction.ox0NMICb2TJ1oQvCxY3((object) serviceNotNull), GroupUsersFunction.rI9pOTCwbi8ddmRgonJ(1690209562 ^ 116876444 ^ 1648994912)),
        (object) ((Dialect) GroupUsersFunction.ox0NMICb2TJ1oQvCxY3((object) serviceNotNull)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-817081027 ^ 243500131 ^ -1043344152)),
        parameters[0],
        (object) alias
      }));
label_3:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454940080), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-814831182 ^ -814813400))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587450449)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(839394233 ^ 839411627), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(false)
        }
      }
    };

    public GroupUsersFunction()
    {
      GroupUsersFunction.zQOE0VCoeZfrQJsL43Y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object rI9pOTCwbi8ddmRgonJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CVkI56xz8Ib755fbJ5W() => GroupUsersFunction.lybwsQxH9Hg8cqoVXoj == null;

    internal static GroupUsersFunction NmWcEfCuZ5eTRLAu7ZK() => GroupUsersFunction.lybwsQxH9Hg8cqoVXoj;

    internal static object ox0NMICb2TJ1oQvCxY3([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object Piic1BCKvDUutAwYN3g([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object Cxd1nkCUPsqT1rGPj7f([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object Xy2yP9CRfH2MqLO9OWq([In] object obj0) => (object) NHQueryExtensions.Sql((string) obj0);

    internal static void zQOE0VCoeZfrQJsL43Y() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
