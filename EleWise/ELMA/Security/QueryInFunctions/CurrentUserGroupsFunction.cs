// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryInFunctions.CurrentUserGroupsFunction
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
using EleWise.ELMA.Security.Services;
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
  internal class CurrentUserGroupsFunction : IQueryInFunction, IEQLFunction
  {
    internal static CurrentUserGroupsFunction ugZ5mdx82ECtE6RjLGA;

    public string FunctionName => (string) CurrentUserGroupsFunction.QOukuHxEtAfgJaGYPRM(631805505 ^ 631821593);

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
            goto label_3;
          case 2:
            if (parameters.Length == 0)
            {
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ICriterion) CurrentUserGroupsFunction.nvr81Ux10A69LaWbZ9j(CurrentUserGroupsFunction.Cq6ATux9KQyZKmRjHHV(CurrentUserGroupsFunction.QOukuHxEtAfgJaGYPRM(-814831182 ^ -814814516), (object) new object[6]
      {
        (object) propName,
        (object) ((Dialect) CurrentUserGroupsFunction.oALIk4xGOCCBm5eBA06((object) serviceNotNull)).QuoteIfNeeded((string) CurrentUserGroupsFunction.QOukuHxEtAfgJaGYPRM(-880091293 >> 4 ^ -55007168)),
        (object) ((Dialect) CurrentUserGroupsFunction.oALIk4xGOCCBm5eBA06((object) serviceNotNull)).QuoteIfNeeded((string) CurrentUserGroupsFunction.QOukuHxEtAfgJaGYPRM(1677147940 ^ 1677163714)),
        CurrentUserGroupsFunction.eRmi6wxXxQry1xLBq9H(CurrentUserGroupsFunction.oALIk4xGOCCBm5eBA06((object) serviceNotNull), CurrentUserGroupsFunction.QOukuHxEtAfgJaGYPRM(1940240517 ^ 974551502 ^ 1236517863)),
        (object) AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id,
        (object) alias
      }));
label_3:
      throw new ArgumentException();
    }

    public IEnumerable<EQLFunction> GetEqlFunctions() => (IEnumerable<EQLFunction>) new EQLFunction[1]
    {
      new EQLFunction()
      {
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362637915), (object) this.FunctionName),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-906676699 ^ -906661371)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(384582979 ^ 384565585), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<IUserGroup>(false)
        }
      }
    };

    public CurrentUserGroupsFunction()
    {
      CurrentUserGroupsFunction.XmQ2chxMNnYhj7BsXqp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object QOukuHxEtAfgJaGYPRM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool f5ZZLFx5kT6jT1erFNh() => CurrentUserGroupsFunction.ugZ5mdx82ECtE6RjLGA == null;

    internal static CurrentUserGroupsFunction gCxLVcxdePEZdAoDS2S() => CurrentUserGroupsFunction.ugZ5mdx82ECtE6RjLGA;

    internal static object oALIk4xGOCCBm5eBA06([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object eRmi6wxXxQry1xLBq9H([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object Cq6ATux9KQyZKmRjHHV([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object nvr81Ux10A69LaWbZ9j([In] object obj0) => (object) NHQueryExtensions.Sql((string) obj0);

    internal static void XmQ2chxMNnYhj7BsXqp() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
