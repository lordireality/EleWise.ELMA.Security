// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AuthTokenDbStructureProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Провайдер мапинга NHibernate для класса AuthToken</summary>
  [Component(Type = ComponentType.Server)]
  internal class AuthTokenDbStructureProvider : IEntityMappingProvider, IInitHandler
  {
    private static AuthTokenDbStructureProvider HAIWOB24arE3NlPrjrO;

    /// <summary>Получить типы содержащие мапинг</summary>
    /// <returns>Коллекция типов</returns>
    public IEnumerable<Type> GetMappingTypes() => (IEnumerable<Type>) new Type[1]
    {
      typeof (AuthTokenMap)
    };

    /// <inheritdoc />
    public void Init()
    {
    }

    /// <inheritdoc />
    public void InitComplete() => this.CreateStructure();

    private void CreateStructure()
    {
      int num = 4;
      Table table1;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            Table table2 = new Table();
            AuthTokenDbStructureProvider.RiEy2l28ZT99J9Uq2yU((object) table2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1534797734 ^ 1534797082));
            table2.Columns = new List<Column>()
            {
              new Column((string) AuthTokenDbStructureProvider.iFWMgw2Q71B2X8cpGqZ(-468111058 ^ -468110452), DbType.Guid, ColumnProperty.PrimaryKey),
              new Column((string) AuthTokenDbStructureProvider.iFWMgw2Q71B2X8cpGqZ(~-1362653258 ^ 1362653925), DbType.Int64),
              new Column((string) AuthTokenDbStructureProvider.iFWMgw2Q71B2X8cpGqZ(978908330 << 6 ^ -1774376950), DbType.DateTime)
            };
            table1 = table2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 0 : 0;
            continue;
          case 3:
            if (!serviceNotNull.TableExists((string) AuthTokenDbStructureProvider.iFWMgw2Q71B2X8cpGqZ(-340788466 ^ -340788814)))
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 4:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 3;
            continue;
          default:
            serviceNotNull.AddTable(table1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return;
label_8:;
    }

    public AuthTokenDbStructureProvider()
    {
      AuthTokenDbStructureProvider.p2AIJX25Okk4QF9HeFQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object iFWMgw2Q71B2X8cpGqZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void RiEy2l28ZT99J9Uq2yU([In] object obj0, [In] object obj1) => ((Table) obj0).Name = (string) obj1;

    internal static bool dOXY1O2crXtTBGeGXMH() => AuthTokenDbStructureProvider.HAIWOB24arE3NlPrjrO == null;

    internal static AuthTokenDbStructureProvider CeAWS62PPqcyjvBXnXV() => AuthTokenDbStructureProvider.HAIWOB24arE3NlPrjrO;

    internal static void p2AIJX25Okk4QF9HeFQ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
