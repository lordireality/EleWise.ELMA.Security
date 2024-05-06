// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Models.RefreshTokenDbStructureProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.JWT.Models
{
  /// <summary>Провайдер мапинга NHibernate для класса RefreshToken</summary>
  [Component(Type = ComponentType.Server)]
  internal class RefreshTokenDbStructureProvider : IEntityMappingProvider, IInitHandler
  {
    internal static RefreshTokenDbStructureProvider hDdCXqqZDOWiioWpUTR;

    /// <summary>Получить типы содержащие мапинг</summary>
    /// <returns>Коллекция типов</returns>
    public IEnumerable<Type> GetMappingTypes() => (IEnumerable<Type>) new Type[1]
    {
      typeof (RefreshTokenMap)
    };

    /// <inheritdoc />
    public void Init()
    {
    }

    /// <inheritdoc />
    public void InitComplete() => this.CreateStructure();

    private void CreateStructure()
    {
      int num = 3;
      ITransformationProvider serviceNotNull;
      Table table1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            goto label_2;
          case 2:
            if (RefreshTokenDbStructureProvider.I2MEyHqWSdYZ1u2duOh((object) serviceNotNull, RefreshTokenDbStructureProvider.rSfBsHq7awtoAo9cg1y(2016571091 >> 5 ^ 63017268)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 3:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = 2;
            continue;
          case 4:
            Table table2 = new Table();
            RefreshTokenDbStructureProvider.zchWiOqrDMRZ4l6hgM1((object) table2, RefreshTokenDbStructureProvider.rSfBsHq7awtoAo9cg1y(1290337431 ^ 1290338005));
            table2.Columns = new List<Column>()
            {
              new Column((string) RefreshTokenDbStructureProvider.rSfBsHq7awtoAo9cg1y(~-1362653258 ^ 1362653931), DbType.Guid, ColumnProperty.PrimaryKey),
              new Column((string) RefreshTokenDbStructureProvider.rSfBsHq7awtoAo9cg1y(978908330 << 6 ^ -1774376916), DbType.Int64),
              new Column((string) RefreshTokenDbStructureProvider.rSfBsHq7awtoAo9cg1y(784628100 ^ 784628494), DbType.DateTime),
              new Column((string) RefreshTokenDbStructureProvider.rSfBsHq7awtoAo9cg1y(~-1362653258 ^ 1362653743), DbType.StringFixedLength, 250)
            };
            table1 = table2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 5 : 4;
            continue;
          case 5:
            RefreshTokenDbStructureProvider.NLlywsqS0AhX8TP4YtD((object) serviceNotNull, (object) table1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_2:
      return;
label_9:;
    }

    public RefreshTokenDbStructureProvider()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object rSfBsHq7awtoAo9cg1y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool I2MEyHqWSdYZ1u2duOh([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void zchWiOqrDMRZ4l6hgM1([In] object obj0, [In] object obj1) => ((Table) obj0).Name = (string) obj1;

    internal static void NLlywsqS0AhX8TP4YtD([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((Table) obj1);

    internal static bool A0JtoRqAFDvb3WyeOfr() => RefreshTokenDbStructureProvider.hDdCXqqZDOWiioWpUTR == null;

    internal static RefreshTokenDbStructureProvider ub3YavqsMyvI4YqwUBP() => RefreshTokenDbStructureProvider.hDdCXqqZDOWiioWpUTR;
  }
}
