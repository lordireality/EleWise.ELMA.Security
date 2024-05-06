// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.QueryInFunctions.UserGroupsFunction
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
  internal class UserGroupsFunction : IQueryInFunction, IEQLFunction
  {
    internal static UserGroupsFunction L51AU6CtB7VyH2DIXoV;

    public string FunctionName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(631805505 ^ 631820459);

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
            if (parameters.Length != 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
              continue;
            }
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 1 : 2;
            continue;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (ICriterion) UserGroupsFunction.n9HqZMCxEjqpGf3Ju9B(UserGroupsFunction.TgA9bkCaxns46kYa5d9(UserGroupsFunction.FKCLDrCkMOxiG9ZDZKL(-1958138283 - -279956781 ^ -1678197632), (object) new object[6]
      {
        (object) propName,
        (object) ((Dialect) UserGroupsFunction.nRoCmiCDgnZD1vc2i1A((object) serviceNotNull)).QuoteIfNeeded((string) UserGroupsFunction.FKCLDrCkMOxiG9ZDZKL(-1277472395 ^ -1277471549)),
        (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-278393783 ^ -278376529)),
        (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(658384612 ^ 658383944)),
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
        DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522471473), (object) this.FunctionName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1457346863 ^ -1457331223))),
        Description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-94240706 ^ -94222404)),
        Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(552500104 ^ 552484762), (object) this.FunctionName),
        Types = new Guid[1]
        {
          InterfaceActivator.UID<IUserGroup>(false)
        }
      }
    };

    public UserGroupsFunction()
    {
      UserGroupsFunction.xdEm3qCCcNKan8d9N1x();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zi81U8CmoRmww7LVOD0() => UserGroupsFunction.L51AU6CtB7VyH2DIXoV == null;

    internal static UserGroupsFunction LXKD0JC67d5kpD5QOCt() => UserGroupsFunction.L51AU6CtB7VyH2DIXoV;

    internal static object FKCLDrCkMOxiG9ZDZKL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nRoCmiCDgnZD1vc2i1A([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object TgA9bkCaxns46kYa5d9([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object n9HqZMCxEjqpGf3Ju9B([In] object obj0) => (object) NHQueryExtensions.Sql((string) obj0);

    internal static void xdEm3qCCcNKan8d9N1x() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
