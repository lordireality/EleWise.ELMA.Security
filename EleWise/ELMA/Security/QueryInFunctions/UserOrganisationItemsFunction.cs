// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryInFunctions.UserOrganisationItemsFunction
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
using EleWise.ELMA.Security.Models;
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
  internal class UserOrganisationItemsFunction : IQueryInFunction, IEQLFunction
  {
    private static UserOrganisationItemsFunction bXGe0ZCiiFrkUZF1ibF;

    public string FunctionName => (string) UserOrganisationItemsFunction.o1H4myCNNgXZ8vvGoKh(2110885667 - -1624984630 ^ -559112971);

    public ICriterion GetCriterion(
      string alias,
      EntityMetadata metadata,
      string propName,
      object[] parameters)
    {
      int num = 3;
      string str;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = 5;
            continue;
          case 2:
            if (parameters.Length == 2)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            if (parameters.Length != 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 2 : 2;
              continue;
            }
            break;
          case 4:
            if (parameters.Length == 2)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 5 : 6;
              continue;
            }
            goto case 1;
          case 5:
            goto label_3;
          case 6:
            if ((string) UserOrganisationItemsFunction.UvtuOKC0TkCBVNtGp1F((object) parameters[1].ToString()) == (string) UserOrganisationItemsFunction.o1H4myCNNgXZ8vvGoKh(-1640694811 << 2 ^ 2027136916))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 1 : 7;
              continue;
            }
            goto case 1;
          case 7:
            str = "";
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 0;
            continue;
        }
        str = (string) UserOrganisationItemsFunction.o1H4myCNNgXZ8vvGoKh(-1976147292 - 421656521 ^ 1897147649);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 1 : 4;
      }
label_3:
      return (ICriterion) UserOrganisationItemsFunction.N8ynGLC78cMJ4HJZpb8(UserOrganisationItemsFunction.EVNxf5CsTMlvaHgxL2H(UserOrganisationItemsFunction.o1H4myCNNgXZ8vvGoKh(-1277802350 ^ -1277820770), (object) new object[7]
      {
        (object) propName,
        UserOrganisationItemsFunction.Yj0s9xCABDQ7hPcl9eu(UserOrganisationItemsFunction.GoSeD9CZhvwGOCh149r((object) serviceNotNull), UserOrganisationItemsFunction.o1H4myCNNgXZ8vvGoKh(-1743015995 ^ -1743001775)),
        (object) ((Dialect) UserOrganisationItemsFunction.GoSeD9CZhvwGOCh149r((object) serviceNotNull)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--180540780 ^ 180524682)),
        UserOrganisationItemsFunction.Yj0s9xCABDQ7hPcl9eu((object) serviceNotNull.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-296013529 ^ -296012917)),
        parameters[0],
        (object) str,
        (object) alias
      }));
label_4:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272505407), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272504749)), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440355757))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331089398)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347028356), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<IOrganizationItem>(false)
        }
      }
    };

    public UserOrganisationItemsFunction()
    {
      UserOrganisationItemsFunction.XUjyFlCWlp67sQcaade();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object o1H4myCNNgXZ8vvGoKh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qNo7NDC36tnsD2uMJsa() => UserOrganisationItemsFunction.bXGe0ZCiiFrkUZF1ibF == null;

    internal static UserOrganisationItemsFunction hb9gjjCjOnWLR5hMnKK() => UserOrganisationItemsFunction.bXGe0ZCiiFrkUZF1ibF;

    internal static object UvtuOKC0TkCBVNtGp1F([In] object obj0) => (object) ((string) obj0).ToLowerInvariant();

    internal static object GoSeD9CZhvwGOCh149r([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object Yj0s9xCABDQ7hPcl9eu([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object EVNxf5CsTMlvaHgxL2H([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object N8ynGLC78cMJ4HJZpb8([In] object obj0) => (object) NHQueryExtensions.Sql((string) obj0);

    internal static void XUjyFlCWlp67sQcaade() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
