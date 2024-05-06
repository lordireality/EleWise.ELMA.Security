// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Db.SecurityDbStructure
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Diagrams.Elements;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Properties;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Db
{
  /// <summary>Структура БД для модуля "Безопасность"</summary>
  public class SecurityDbStructure : DbStructureExtension
  {
    private bool _systemUserCreated;
    private static Guid DigitalSignatureSettingsModuleUid;
    private static SecurityDbStructure bfxeBwnrw2KmH4d9Nh7;

    /// <summary>Все провайдеры</summary>
    public override Guid ProviderUid => Guid.Empty;

    /// <summary>
    /// Ссылки на преобразователи БД, от которых зависит данный преобразователь
    /// </summary>
    public override Type[] References => new Type[1]
    {
      SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (CoreDbStructure))
    };

    /// <summary>Создать таблицу GroupPermissions</summary>
    public void CreateGroupPermissions()
    {
      int num = 3;
      ITransformationProvider serviceNotNull;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1608980123 ^ -1608916713)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 1 : 2;
            continue;
          case 4:
            SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 1 : 1;
            continue;
          default:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table2, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(384582979 ^ 384650545));
            table2.Columns = new List<Column>()
            {
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1530848604 ^ 1530847466), DbType.Int64, ColumnProperty.PrimaryKey),
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1212789817 - 1827404527 ^ 1254771390), DbType.Guid, ColumnProperty.PrimaryKey)
            };
            table1 = table2;
            num = 4;
            continue;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <summary>Создание таблицы UserSecuritySetCache</summary>
    public void CreateUserSecuritySetCacheTable7()
    {
      int num = 12;
      ITransformationProvider serviceNotNull;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2;
      while (true)
      {
        switch (num)
        {
          case 1:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table3 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table3, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1457346863 ^ -1457339299));
            table3.Columns = new List<Column>()
            {
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1095474805 ^ 155418997 ^ 1208490708), DbType.Int64, ColumnProperty.NotNull),
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1457346863 ^ -1457339255), DbType.Int32),
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1254421137 >> 4 ^ -78400902), DbType.Int64),
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1762575989 ^ 1762643825), DbType.Int64)
            };
            table2 = table3;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 0 : 0;
            continue;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = 16;
            continue;
          case 3:
          case 13:
            if (SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362629317)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 8 : 2;
              continue;
            }
            goto case 1;
          case 4:
            SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-901653144 ^ -901660700), (object) new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1341618464 ^ -1341550620), DbType.Int64));
            num = 14;
            continue;
          case 5:
            SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 10 : 13;
            continue;
          case 6:
          case 17:
            if (!SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-817081027 ^ 243500131 ^ -1043352782), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1841261835 ^ 1841193999)))
            {
              num = 7;
              continue;
            }
            goto case 3;
          case 7:
            SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1801131332 >> 4 ^ 112579384), (object) new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-278393783 ^ -278330035), DbType.Int64));
            num = 3;
            continue;
          case 8:
            if (!serviceNotNull.ColumnExists((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1277802350 ^ -1277810146), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277536143)))
            {
              num = 4;
              continue;
            }
            goto label_12;
          case 9:
            goto label_10;
          case 10:
            this.CreateHistoryUserSecuritySetCacheTable((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(617710536 ^ 617646850));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 1 : 2;
            continue;
          case 11:
            this.CreateUserSecuritySetCacheTable((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1100789287 - 1555711667 ^ -454858782));
            num = 10;
            continue;
          case 12:
            this.CreateUserSecuritySetCacheTable((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-404268492 ^ -404284974));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 7 : 11;
            continue;
          case 14:
            goto label_21;
          case 15:
            table1 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table()
            {
              Name = (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-340788466 ^ -340813470),
              Columns = new List<Column>()
              {
                new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-550634672 ^ -550633852), DbType.Int64, ColumnProperty.NotNull),
                new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(554338340 ^ 554363516), DbType.Int32),
                new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454922792), DbType.Int64),
                new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(839394233 ^ 839412525), DbType.Int64),
                new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-814831182 ^ -814830588), DbType.Int64),
                new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1958138283 - -279956781 ^ -1678118266), DbType.Int64)
              }
            };
            num = 5;
            continue;
          case 16:
            if (SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(--1207559533 ^ 1207535361)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 6 : 6;
              continue;
            }
            goto case 15;
          default:
            serviceNotNull.AddTable(table2);
            num = 9;
            continue;
        }
      }
label_10:
      return;
label_21:
      return;
label_12:;
    }

    /// <summary>
    /// Создание таблицы HistoryUserSecuritySetCache, для хранения истории изменения таблицы UserSecuritySetCache
    /// </summary>
    /// <param name="tableName"></param>
    private void CreateHistoryUserSecuritySetCacheTable(string tableName)
    {
      switch (1)
      {
        case 1:
          try
          {
            ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            int num = 2;
            List<Column> columnList;
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  columnList.Add(new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(784628100 ^ 784628520), DbType.Int64));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
                  continue;
                case 2:
                  if (SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, (object) tableName))
                  {
                    num = 11;
                    continue;
                  }
                  goto case 6;
                case 3:
                  columnList.Add(new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053035537), DbType.Int32));
                  num = 8;
                  continue;
                case 4:
                  columnList.Add(new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1788783669 - 1293477238 ^ 1212705665), DbType.Int64));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 1 : 1;
                  continue;
                case 5:
                  columnList.Add(new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(44166125 ^ 44165455), DbType.String, 36));
                  num = 3;
                  continue;
                case 6:
                  columnList = new List<Column>();
                  num = 4;
                  continue;
                case 7:
                  SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table1);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 10 : 2;
                  continue;
                case 8:
                  EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
                  SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table2, (object) tableName);
                  table2.Columns = columnList;
                  table1 = table2;
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 7 : 7;
                  continue;
                case 9:
                  columnList.Add(new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1751467293 ^ -1751403545), DbType.Int64));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 5 : 5;
                  continue;
                case 10:
                  goto label_18;
                case 11:
                  goto label_11;
                case 12:
                  columnList.Add(new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(868767899 ^ 868769069), DbType.Int64));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 3 : 9;
                  continue;
                default:
                  columnList.Add(new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(266768307 ^ 266782503), DbType.Int64));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 1 : 12;
                  continue;
              }
            }
label_18:
            break;
label_11:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
      }
    }

    private void CreateUserSecuritySetCacheTable(string tableName)
    {
      int num1 = 37;
      while (true)
      {
        int num2 = num1;
        Column column1;
        ITransformationProvider serviceNotNull;
        Column column2;
        while (true)
        {
          bool flag1;
          bool flag2;
          Column column3;
          Column column4;
          Column column5;
          EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table;
          bool flag3;
          bool flag4;
          bool flag5;
          bool flag6;
          int num3;
          int num4;
          int num5;
          int num6;
          int num7;
          int num8;
          switch (num2)
          {
            case 1:
            case 12:
            case 27:
            case 28:
            case 29:
              num3 = 1;
              goto label_70;
            case 2:
label_18:
              if (!flag2)
                goto case 4;
              else
                goto label_19;
            case 3:
              goto label_53;
            case 4:
              table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table()
              {
                Name = tableName,
                Columns = new List<Column>()
                {
                  new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1095474805 ^ 155418997 ^ 1208555012), DbType.Int64, ColumnProperty.NotNull),
                  new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55877372), DbType.Int64, ColumnProperty.NotNull),
                  column2,
                  column3,
                  column4,
                  column5,
                  column1
                }
              };
              num2 = 22;
              continue;
            case 5:
              if (flag5)
              {
                num2 = 9;
                continue;
              }
              goto case 11;
            case 6:
              column3 = new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1958977588 ^ -1958914338), DbType.Boolean);
              num2 = 19;
              continue;
            case 7:
              if (flag2)
              {
                num2 = 39;
                continue;
              }
              num4 = 0;
              break;
            case 8:
              if (!flag5)
              {
                num2 = 27;
                continue;
              }
              goto case 31;
            case 9:
            case 25:
              if (!flag6)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 35 : 32;
                continue;
              }
              goto case 33;
            case 10:
              goto label_41;
            case 11:
              serviceNotNull.AddColumn(tableName, column4);
              num2 = 25;
              continue;
            case 13:
              num3 = !flag3 ? 1 : 0;
              goto label_70;
            case 14:
              goto label_26;
            case 15:
              if (flag2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 23 : 5;
                continue;
              }
              num5 = 0;
              goto label_66;
            case 16:
              num6 = 0;
              goto label_68;
            case 17:
              column1 = new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-901653144 ^ -901721020), DbType.Int32);
              num2 = 18;
              continue;
            case 18:
              if (!flag2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 6 : 16;
                continue;
              }
              goto case 30;
            case 19:
              if (flag2)
              {
                num2 = 44;
                continue;
              }
              num7 = 0;
              goto label_64;
            case 20:
              SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, (object) tableName, (object) column2);
              num2 = 5;
              continue;
            case 21:
              if (!flag4)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 28 : 20;
                continue;
              }
              goto case 8;
            case 22:
              SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table);
              num2 = 3;
              continue;
            case 23:
              num5 = SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, SecurityDbStructure.SvdsgQnQj3Wtmp6JDNH((object) column5)) ? 1 : 0;
              goto label_66;
            case 24:
              if (!flag2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 1 : 1;
                continue;
              }
              goto case 21;
            case 26:
              goto label_50;
            case 30:
              num6 = SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, SecurityDbStructure.SvdsgQnQj3Wtmp6JDNH((object) column1)) ? 1 : 0;
              goto label_68;
            case 31:
              if (!flag6)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 12 : 7;
                continue;
              }
              goto default;
            case 32:
              num8 = SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, (object) column4.Name) ? 1 : 0;
              goto label_62;
            case 33:
              if (flag1)
                goto case 40;
              else
                goto label_17;
            case 34:
              column5 = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499948196), DbType.Int64);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 13 : 15;
              continue;
            case 35:
              serviceNotNull.AddColumn(tableName, column3);
              num2 = 33;
              continue;
            case 36:
              flag2 = SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, (object) tableName);
              num2 = 10;
              continue;
            case 37:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 25 : 36;
              continue;
            case 38:
              goto label_49;
            case 39:
              num4 = SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, SecurityDbStructure.SvdsgQnQj3Wtmp6JDNH((object) column2)) ? 1 : 0;
              break;
            case 40:
              if (flag3)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 5 : 14;
                continue;
              }
              goto label_24;
            case 41:
              if (flag2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 15 : 32;
                continue;
              }
              num8 = 0;
              goto label_62;
            case 42:
              column4 = new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(384582979 ^ 384581877), DbType.Int64);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 41 : 39;
              continue;
            case 43:
              SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, (object) tableName, (object) column5);
              num2 = 40;
              continue;
            case 44:
              num7 = SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, (object) column3.Name) ? 1 : 0;
              goto label_64;
            case 45:
              goto label_24;
            case 46:
              if (!flag4)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 4 : 20;
                continue;
              }
              goto case 5;
            default:
              if (!flag1)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 18 : 29;
                continue;
              }
              goto case 13;
          }
          flag4 = num4 != 0;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 42 : 20;
          continue;
label_62:
          flag5 = num8 != 0;
          num2 = 6;
          continue;
label_64:
          flag6 = num7 != 0;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 34 : 11;
          continue;
label_66:
          flag1 = num5 != 0;
          num2 = 17;
          continue;
label_68:
          flag3 = num6 != 0;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 24 : 6;
          continue;
label_70:
          if (num3 != 0)
            goto label_18;
          else
            goto label_71;
        }
label_17:
        num1 = 43;
        continue;
label_19:
        num1 = 46;
        continue;
label_24:
        SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, (object) tableName, (object) column1);
        num1 = 38;
        continue;
label_41:
        column2 = new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1702973981 - 773209001 ^ 1818769092), DbType.Int64);
        num1 = 7;
        continue;
label_71:
        num1 = 26;
      }
label_53:
      return;
label_26:
      return;
label_50:
      return;
label_49:;
    }

    /// <summary>Создание таблицы UserSecuritySetCacheTest</summary>
    public void CreateUserSecuritySetCacheTestTable4()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CreateUserSecuritySetCacheTestTable((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1859356887 ^ -1859289505));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 0 : 0;
            continue;
          case 2:
            this.CreateUserSecuritySetCacheTestTable((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(2110195605 ^ 2110131927));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void CreateUserSecuritySetCacheTestTable(string tableName)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider serviceNotNull;
        Column column1;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
        while (true)
        {
          Column column2;
          bool flag1;
          Column column3;
          bool flag2;
          bool flag3;
          bool flag4;
          int num3;
          int num4;
          int num5;
          int num6;
          switch (num2)
          {
            case 1:
            case 12:
              num4 = 1;
              goto label_48;
            case 2:
              num3 = 0;
              break;
            case 3:
              column1 = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899827991), DbType.Int64);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 30 : 11;
              continue;
            case 4:
              serviceNotNull.AddColumn(tableName, column2);
              num2 = 10;
              continue;
            case 5:
              column2 = new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028265253 << 4 ^ 727688354), DbType.Boolean);
              num2 = 14;
              continue;
            case 6:
              num5 = serviceNotNull.ColumnExists(tableName, (string) SecurityDbStructure.SvdsgQnQj3Wtmp6JDNH((object) column2)) ? 1 : 0;
              goto label_46;
            case 7:
              num4 = !flag2 ? 1 : 0;
              goto label_48;
            case 8:
              flag4 = serviceNotNull.TableExists(tableName);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 5 : 19;
              continue;
            case 9:
              goto label_5;
            case 10:
              goto label_38;
            case 11:
              if (!flag1)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 1 : 1;
                continue;
              }
              goto case 7;
            case 13:
              SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, (object) tableName, (object) column3);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 12 : 26;
              continue;
            case 14:
              if (!flag4)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 23 : 10;
                continue;
              }
              goto case 6;
            case 15:
              if (flag2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 22 : 2;
                continue;
              }
              goto case 4;
            case 16:
              goto label_24;
            case 17:
              num6 = 0;
              goto label_44;
            case 18:
              goto label_28;
            case 19:
              column3 = new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1341618464 ^ -1341603298), DbType.Int64);
              num2 = 24;
              continue;
            case 20:
              if (flag4)
                goto case 21;
              else
                goto label_34;
            case 21:
              if (flag3)
              {
                num2 = 11;
                continue;
              }
              goto case 1;
            case 22:
              goto label_26;
            case 23:
              num5 = 0;
              goto label_46;
            case 24:
              if (!flag4)
              {
                num2 = 2;
                continue;
              }
              goto default;
            case 25:
            case 26:
              if (flag1)
                goto case 15;
              else
                goto label_9;
            case 27:
              goto label_11;
            case 28:
              num6 = serviceNotNull.ColumnExists(tableName, (string) SecurityDbStructure.SvdsgQnQj3Wtmp6JDNH((object) column1)) ? 1 : 0;
              goto label_44;
            case 29:
label_18:
              if (!flag4)
              {
                num2 = 31;
                continue;
              }
              if (flag3)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 25 : 21;
                continue;
              }
              goto case 13;
            case 30:
              if (!flag4)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 12 : 17;
                continue;
              }
              goto case 28;
            case 31:
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
              SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table2, (object) tableName);
              table2.Columns = new List<Column>()
              {
                new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272587665), DbType.Int64, ColumnProperty.NotNull),
                new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-696756495 ^ -696757155), DbType.Int64, ColumnProperty.NotNull),
                column1,
                column3,
                column2
              };
              table1 = table2;
              num2 = 16;
              continue;
            case 32:
              goto label_35;
            default:
              num3 = serviceNotNull.ColumnExists(tableName, (string) SecurityDbStructure.SvdsgQnQj3Wtmp6JDNH((object) column3)) ? 1 : 0;
              break;
          }
          flag3 = num3 != 0;
          num2 = 3;
          continue;
label_44:
          flag1 = num6 != 0;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 5 : 5;
          continue;
label_46:
          flag2 = num5 != 0;
          num2 = 20;
          continue;
label_48:
          if (num4 == 0)
            num2 = 18;
          else
            goto label_18;
        }
label_5:
        serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
        num1 = 8;
        continue;
label_9:
        num1 = 32;
        continue;
label_24:
        SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table1);
        num1 = 27;
        continue;
label_34:
        num1 = 12;
        continue;
label_35:
        SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, (object) tableName, (object) column1);
        num1 = 15;
      }
label_38:
      return;
label_28:
      return;
label_26:
      return;
label_11:;
    }

    /// <summary>
    /// Создание таблицы для очереди обновления UserSecuritySetCache
    /// </summary>
    public void CreateUpdateUserSecuritySetCacheQueueTable()
    {
      int num = 1;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            ITransformationProvider transformationProvider = serviceNotNull;
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-624171910 - 757669187 ^ -1381852581));
            table.Columns = new List<Column>()
            {
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(784628100 ^ 784628518), DbType.Guid),
              new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(447286529 ^ 447304623), DbType.DateTime),
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-617657301 ^ -617671967), DbType.String, int.MaxValue)
            };
            SecurityDbStructure.t4ZWEfn8swj7Bo5qEVg((object) table, false);
            SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) transformationProvider, (object) table);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 2;
            continue;
          case 4:
            goto label_3;
          default:
            if (!SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1859356887 ^ -1859376571)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 3 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_8:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>Создание пользователей по умолчанию</summary>
    public void CreateAdminUsers()
    {
      int num = 7;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            SecurityDbStructure.ReoHwJnEeHtl5HMH46d((object) UserSecurityProfileManager.Instance.CreateProfile(user, string.Empty), true);
            num = 2;
            continue;
          case 2:
            user.EmployDate = new DateTime?(SecurityDbStructure.s2bGcKnGpc2mFC8OTtr());
            num = 3;
            continue;
          case 3:
            SecurityDbStructure.UxAh8FnXHbo3gpfuErs((object) user, (object) EleWise.ELMA.SR.T((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(2047763786 ^ 1536686658 ^ 563648200)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 8;
            continue;
          case 4:
            SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) user);
            num = 10;
            continue;
          case 5:
            user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).Create();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
            continue;
          case 6:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 2 : 5;
              continue;
            }
            goto label_14;
          case 7:
            user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.AdminUserUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 6 : 1;
            continue;
          case 8:
            SecurityDbStructure.tdPfpbn1fgogiqDTdkU((object) user, SecurityDbStructure.tjWggDn9AICDbEZ5ZMG(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(213026252 ^ 213043384)));
            num = 9;
            continue;
          case 9:
            SecurityDbStructure.fQMYj0nMtchdgRF89CM((object) user, SecurityConstants.AdminUserUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 3 : 4;
            continue;
          case 10:
            goto label_2;
          default:
            SecurityDbStructure.kJJJJandayU3OlxfWsA((object) user, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1751467293 ^ -1751403695));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return;
label_14:;
    }

    /// <summary>Создание системных пользователей</summary>
    public void CreateSystemUsers()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              UserSecurityProfileManager.Instance.CreateProfile(user, string.Empty);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 15 : 8;
              continue;
            case 2:
              goto label_5;
            case 3:
              SecurityDbStructure.tdPfpbn1fgogiqDTdkU((object) user, (object) EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690569372 >> 6 ^ 26434910)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 8 : 12;
              continue;
            case 4:
              SecurityDbStructure.UxAh8FnXHbo3gpfuErs((object) user, (object) EleWise.ELMA.SR.T((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-617657301 ^ -617724455)));
              num2 = 3;
              continue;
            case 5:
              this._systemUserCreated = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 11 : 9;
              continue;
            case 6:
              user = UserManager.Instance.Create();
              num2 = 14;
              continue;
            case 7:
              if (user != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 8:
              user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.SystemUserUid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 7 : 7;
              continue;
            case 9:
              SecurityDbStructure.sQqbTQnBsw7ovG1QrQm((object) user, UserStatus.System);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 13 : 9;
              continue;
            case 10:
              user.Save();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 5 : 0;
              continue;
            case 12:
              SecurityDbStructure.fQMYj0nMtchdgRF89CM((object) user, SecurityConstants.SystemUserUid);
              num2 = 9;
              continue;
            case 13:
              SecurityDbStructure.cTRbCOnp1shEug9u7Lb((object) user, (object) this.CreateSystemUserPhoto());
              num2 = 10;
              continue;
            case 14:
              user.UserName = (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1744916777 - 891549337 ^ 853300046);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 1;
              continue;
            case 15:
              user.EmployDate = new DateTime?(DateTime.Now);
              num2 = 4;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        ((ISession) SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) "")).Flush();
        num1 = 2;
      }
label_5:;
    }

    /// <summary>Обновление системных пользователей</summary>
    internal void UpdateSystemUsers2()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_18;
          case 1:
            goto label_17;
          case 2:
            if (!this._systemUserCreated)
            {
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_15;
        }
      }
label_18:
      return;
label_17:
      return;
label_15:
      return;
label_3:
      try
      {
        EleWise.ELMA.Security.Models.IUser user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.SystemUserUid);
        int num2 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0)
          num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 3 : 3;
              continue;
            case 2:
              if (user != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 3:
              goto label_11;
            default:
              SecurityDbStructure.cTRbCOnp1shEug9u7Lb((object) user, (object) this.CreateSystemUserPhoto());
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 0 : 1;
              continue;
          }
        }
label_11:
        return;
label_6:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_2;
            case 1:
              SecurityDbStructure.I8Vsa2nFmuhXj0AlHVQ(SecurityDbStructure.EIEFu7nTD2UJI1NTWRi(), (object) EleWise.ELMA.SR.T((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1028265253 << 4 ^ 727689140)), (object) ex);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 0 : 0;
              continue;
            default:
              goto label_22;
          }
        }
label_2:
        return;
label_22:;
      }
    }

    private BinaryFile CreateSystemUserPhoto()
    {
      int num = 1;
      IMimeMappingService serviceNotNull;
      BinaryFile systemUserPhoto;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 0 : 0;
            continue;
          case 2:
            SecurityDbStructure.wEIZDZnLWLVyTEvAboa(SecurityDbStructure.q4mWexnnogw7VS9dbM2(), (object) systemUserPhoto);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_5;
          default:
            systemUserPhoto = (BinaryFile) SecurityDbStructure.dG77l5nePGylqvxBhxi(SecurityDbStructure.OXVKn2nIcB9QmO7QPNL(SecurityDbStructure.zUc6O2nJ6qG5NY1LyB0(SecurityDbStructure.M9HmbqnqTqs0ohx1KOF(SecurityDbStructure.GF9P3hnvVrXdV9vAnws(), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(4869926 >> 3 ^ 541590)), SecurityDbStructure.UphLaengvUgFOZKi3pk((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1788783669 - 1293477238 ^ 1212769479))), (object) Resources.SystemUser));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return systemUserPhoto;
    }

    /// <summary>
    /// Авторизуем пользователя admin на время преобразования базы
    /// </summary>
    public void SignInAdminUsers()
    {
      int num = 4;
      while (true)
      {
        EleWise.ELMA.Security.Models.IUser user;
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_2;
          case 3:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 2 : 1;
              continue;
            }
            break;
          case 4:
            user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.AdminUserUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 3 : 3;
            continue;
        }
        SecurityDbStructure.NIjnOin2NA8Ex9YCCaZ((object) Locator.GetServiceNotNull<IAuthenticationService>(), (object) user);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 1 : 1;
      }
label_7:
      return;
label_2:;
    }

    /// <summary>Создание группы "Администраторы"</summary>
    public void CreateAdminGroups()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        IUserGroup userGroup1;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (user != null)
              {
                num2 = 4;
                continue;
              }
              goto label_10;
            case 2:
              goto label_7;
            case 3:
              goto label_10;
            case 4:
              InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
              instanceOf.New.Name = (string) SecurityDbStructure.WhAVXjLU7hRspiVaFwV((object) SecurityConstants.AdminGroupDescriptor);
              SecurityDbStructure.u2YC44Loj23iAwYgN7j((object) instanceOf.New, SecurityDbStructure.s2LERYLR4LWoTaQeekq((object) SecurityConstants.AdminGroupDescriptor));
              SecurityDbStructure.jTKcfWLtWyfFEYJKLTg((object) instanceOf.New, (object) user);
              IUserGroup userGroup2 = instanceOf.New;
              HashedSet<EleWise.ELMA.Security.Models.IUser> hashedSet = new HashedSet<EleWise.ELMA.Security.Models.IUser>();
              hashedSet.Add(user);
              userGroup2.Users = (ISet<EleWise.ELMA.Security.Models.IUser>) hashedSet;
              userGroup1 = instanceOf.New;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 0 : 0;
              continue;
            case 5:
              if (userGroup1 == null)
              {
                num2 = 7;
                continue;
              }
              goto label_15;
            case 6:
              UserGroupManager instance = UserGroupManager.Instance;
              ParameterExpression parameterExpression = (ParameterExpression) SecurityDbStructure.NHETJLnHH3pn8SV1fMS(typeof (IUserGroup), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(2016571091 >> 5 ^ 63029260));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<IUserGroup, bool>> condition = Expression.Lambda<Func<IUserGroup, bool>>((Expression) SecurityDbStructure.xwBTw3Lbh3ExYhXlvmG(SecurityDbStructure.vkfp68nzUdPMA0rCd8G((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserGroup.get_Uid))), SecurityDbStructure.JlFjgPLwJGUpALd0q6W((object) null, SecurityDbStructure.xXbJMrLuWK43wvILlNe(__fieldref (SecurityConstants.AdminGroupUid))), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression);
              userGroup1 = instance.Find(condition).FirstOrDefault<IUserGroup>();
              num2 = 5;
              continue;
            case 7:
              user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.AdminUserUid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 1 : 1;
              continue;
            case 8:
              SecurityDbStructure.lywyICL6GvVXje178Bu((object) userGroup1, true);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 10 : 4;
              continue;
            case 9:
              ((ISession) SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) "")).Flush();
              num2 = 2;
              continue;
            case 10:
              SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) userGroup1);
              num2 = 9;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        SecurityDbStructure.hmQ6mWLmogaTWqYXbIA((object) userGroup1, SecurityConstants.AdminGroupUid);
        num1 = 8;
      }
label_7:
      return;
label_10:
      throw new InvalidOperationException((string) SecurityDbStructure.aocJXcLK5Cbxx0Ly31R(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-801309555 ^ -801245677), (object) new object[1]
      {
        (object) SecurityConstants.AdminUserUid
      }));
    }

    /// <summary>Создание группы "Все пользователи"</summary>
    public void CreateAllUsersGroups()
    {
      int num = 6;
      while (true)
      {
        IUserGroup userGroup1;
        EleWise.ELMA.Security.Models.IUser user;
        switch (num)
        {
          case 1:
            SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) userGroup1);
            num = 2;
            continue;
          case 2:
            SecurityDbStructure.V2fKJoLxoanfqBgmZ37(SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) ""));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 4 : 1;
            continue;
          case 3:
            userGroup1.IsSystem = true;
            num = 8;
            continue;
          case 4:
            goto label_14;
          case 5:
            if (userGroup1 != null)
            {
              num = 9;
              continue;
            }
            break;
          case 6:
            userGroup1 = ((AbstractNHEntityManager<IUserGroup, long>) SecurityDbStructure.h6hDFBLk71ggiwxyBW3()).LoadOrNull(SecurityConstants.AllUsersGroupUid);
            num = 5;
            continue;
          case 7:
            if (user != null)
            {
              InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
              SecurityDbStructure.SFDs22LDkuyKExKb6sn((object) instanceOf.New, (object) SecurityConstants.AllUsersGroupDescriptor.Name);
              SecurityDbStructure.u2YC44Loj23iAwYgN7j((object) instanceOf.New, SecurityDbStructure.s2LERYLR4LWoTaQeekq((object) SecurityConstants.AllUsersGroupDescriptor));
              SecurityDbStructure.jTKcfWLtWyfFEYJKLTg((object) instanceOf.New, (object) user);
              IUserGroup userGroup2 = instanceOf.New;
              HashedSet<EleWise.ELMA.Security.Models.IUser> hashedSet = new HashedSet<EleWise.ELMA.Security.Models.IUser>();
              hashedSet.Add(user);
              userGroup2.Users = (ISet<EleWise.ELMA.Security.Models.IUser>) hashedSet;
              userGroup1 = instanceOf.New;
              num = 11;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 4 : 10;
            continue;
          case 8:
            SecurityDbStructure.JwXpStLaQw38S3poPvh((object) userGroup1, true);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 1 : 1;
            continue;
          case 9:
          case 11:
            SecurityDbStructure.hmQ6mWLmogaTWqYXbIA((object) userGroup1, SecurityConstants.AllUsersGroupUid);
            num = 3;
            continue;
          case 10:
            goto label_9;
        }
        user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.AdminUserUid);
        num = 7;
      }
label_14:
      return;
label_9:
      throw new InvalidOperationException((string) SecurityDbStructure.aocJXcLK5Cbxx0Ly31R(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-29763048 >> 5 ^ -998322), (object) new object[1]
      {
        (object) SecurityConstants.AdminUserUid
      }));
    }

    /// <summary>Создание группы "Конфигурирование ELMA"</summary>
    public void CreateConfiguringGroup()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        IUserGroup userGroup;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              object obj = SecurityDbStructure.h6hDFBLk71ggiwxyBW3();
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) SecurityDbStructure.NHETJLnHH3pn8SV1fMS(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IUserGroup)), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-404268492 ^ -404289202));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<IUserGroup, bool>> condition = Expression.Lambda<Func<IUserGroup, bool>>((Expression) Expression.Equal((Expression) SecurityDbStructure.vkfp68nzUdPMA0rCd8G((object) parameterExpression, (object) (MethodInfo) SecurityDbStructure.u8dwHpLCUT8G4aRoVoA(__methodref (IUserGroup.get_Uid))), (Expression) Expression.Field((Expression) null, (FieldInfo) SecurityDbStructure.xXbJMrLuWK43wvILlNe(__fieldref (SecurityConstants.ConfiguringGroupUid))), false, (MethodInfo) SecurityDbStructure.u8dwHpLCUT8G4aRoVoA(__methodref (Guid.op_Equality))), parameterExpression);
              userGroup = ((AbstractNHEntityManager<IUserGroup, long>) obj).Find(condition).FirstOrDefault<IUserGroup>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 0 : 0;
              continue;
            case 2:
              SecurityDbStructure.hmQ6mWLmogaTWqYXbIA((object) userGroup, SecurityConstants.ConfiguringGroupUid);
              num2 = 8;
              continue;
            case 3:
              InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
              instanceOf.New.Name = (string) SecurityDbStructure.WhAVXjLU7hRspiVaFwV((object) SecurityConstants.ConfiguringGroupDescriptor);
              SecurityDbStructure.u2YC44Loj23iAwYgN7j((object) instanceOf.New, SecurityDbStructure.s2LERYLR4LWoTaQeekq((object) SecurityConstants.ConfiguringGroupDescriptor));
              SecurityDbStructure.jTKcfWLtWyfFEYJKLTg((object) instanceOf.New, (object) user);
              instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>) new HashedSet<EleWise.ELMA.Security.Models.IUser>();
              userGroup = instanceOf.New;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 2 : 1;
              continue;
            case 4:
              userGroup.Save();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 6 : 9;
              continue;
            case 5:
              goto label_13;
            case 6:
              goto label_15;
            case 7:
              if (user != null)
              {
                num2 = 3;
                continue;
              }
              goto label_6;
            case 8:
              goto label_14;
            case 9:
              SecurityDbStructure.V2fKJoLxoanfqBgmZ37(SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) ""));
              num2 = 5;
              continue;
            case 10:
              goto label_6;
            default:
              if (userGroup == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 6 : 3;
                continue;
              }
              goto case 2;
          }
        }
label_14:
        SecurityDbStructure.lywyICL6GvVXje178Bu((object) userGroup, true);
        num1 = 4;
        continue;
label_15:
        user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityDbStructure.fDOJ00n5d9WNIYZuIs4()).LoadOrNull(SecurityConstants.AdminUserUid);
        num1 = 7;
      }
label_13:
      return;
label_6:
      throw new InvalidOperationException((string) SecurityDbStructure.aocJXcLK5Cbxx0Ly31R(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1200636245 >> 6 ^ 18828187), (object) new object[1]
      {
        (object) SecurityConstants.AdminUserUid
      }));
    }

    /// <summary>Создание группы "Управление пользователями ELMA"</summary>
    public void CreateUsersManagementGroup()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        IUserGroup userGroup;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) userGroup);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 9 : 6;
              continue;
            case 2:
              InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
              SecurityDbStructure.SFDs22LDkuyKExKb6sn((object) instanceOf.New, SecurityDbStructure.WhAVXjLU7hRspiVaFwV((object) SecurityConstants.UsersManagementGroupDescriptor));
              SecurityDbStructure.u2YC44Loj23iAwYgN7j((object) instanceOf.New, SecurityDbStructure.s2LERYLR4LWoTaQeekq((object) SecurityConstants.UsersManagementGroupDescriptor));
              SecurityDbStructure.jTKcfWLtWyfFEYJKLTg((object) instanceOf.New, (object) user);
              instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>) new HashedSet<EleWise.ELMA.Security.Models.IUser>();
              userGroup = instanceOf.New;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 8 : 1;
              continue;
            case 3:
              goto label_12;
            case 4:
              userGroup.IsSystem = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 1 : 0;
              continue;
            case 5:
              goto label_7;
            case 6:
              if (userGroup == null)
              {
                num2 = 10;
                continue;
              }
              goto case 8;
            case 7:
              object obj = SecurityDbStructure.h6hDFBLk71ggiwxyBW3();
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) SecurityDbStructure.NHETJLnHH3pn8SV1fMS(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IUserGroup)), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(150349507 - 521039768 ^ -370678703));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<IUserGroup, bool>> condition = Expression.Lambda<Func<IUserGroup, bool>>((Expression) Expression.Equal((Expression) SecurityDbStructure.vkfp68nzUdPMA0rCd8G((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserGroup.get_Uid))), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (SecurityConstants.UsersManagementGroupUid))), false, (MethodInfo) SecurityDbStructure.u8dwHpLCUT8G4aRoVoA(__methodref (Guid.op_Equality))), parameterExpression);
              userGroup = ((AbstractNHEntityManager<IUserGroup, long>) obj).Find(condition).FirstOrDefault<IUserGroup>();
              num2 = 6;
              continue;
            case 8:
              SecurityDbStructure.hmQ6mWLmogaTWqYXbIA((object) userGroup, SecurityConstants.UsersManagementGroupUid);
              num2 = 4;
              continue;
            case 9:
              goto label_8;
            case 10:
              user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 0;
              continue;
            default:
              if (user != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 0 : 2;
                continue;
              }
              goto label_12;
          }
        }
label_8:
        SecurityDbStructure.V2fKJoLxoanfqBgmZ37((object) Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
        num1 = 5;
      }
label_7:
      return;
label_12:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(631805505 ^ 631872735), (object) SecurityConstants.AdminUserUid));
    }

    /// <summary>Простановка признака "Является начальником отдела"</summary>
    public void UpdateOrganizationModelChiefs()
    {
      int num1 = 3;
      IOrganizationModel organizationModel;
      IEnumerator<DepartmentElement> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_34:
            organizationModel.Save();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 8;
            continue;
          case 2:
            if (organizationModel.Id <= 0)
            {
              num1 = 4;
              continue;
            }
            goto case 7;
          case 3:
            organizationModel = (IOrganizationModel) SecurityDbStructure.znHE3IL3shvi6bO4cFl(SecurityDbStructure.NkYDxRLi0F49jLqhYMN());
            num1 = 2;
            continue;
          case 4:
            goto label_35;
          case 5:
            goto label_25;
          case 6:
            enumerator = ((IEnumerable) SecurityDbStructure.FY11StLNJHk0mRCC8wj(SecurityDbStructure.eTKYe0LjB3WtOXi2EO1((object) organizationModel))).OfType<DepartmentElement>().GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
            continue;
          case 7:
            if (organizationModel.Diagram != null)
            {
              num1 = 6;
              continue;
            }
            goto label_28;
          case 8:
            goto label_31;
          default:
            try
            {
label_11:
              if (enumerator.MoveNext())
                goto label_7;
              else
                goto label_12;
label_6:
              DepartmentElement current;
              int num2;
              while (true)
              {
                PositionElement positionElement1;
                PositionElement positionElement2;
                switch (num2)
                {
                  case 1:
                    if (((string) SecurityDbStructure.pMDeyML0S0DCKwmUDt7((object) positionElement1)).StartsWith(EleWise.ELMA.SR.T((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(711486506 ^ 711550758))))
                    {
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 7 : 9;
                      continue;
                    }
                    goto label_11;
                  case 2:
                    goto label_7;
                  case 3:
                    if (positionElement1 == null)
                    {
                      num2 = 7;
                      continue;
                    }
                    goto case 5;
                  case 4:
                    goto label_34;
                  case 5:
                    if (SecurityDbStructure.pMDeyML0S0DCKwmUDt7((object) positionElement1) != null)
                    {
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 1 : 0;
                      continue;
                    }
                    goto label_11;
                  case 6:
                    if (current.Composition == null)
                    {
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 0 : 0;
                      continue;
                    }
                    positionElement2 = current.Composition.OfType<PositionElement>().FirstOrDefault<PositionElement>();
                    break;
                  case 7:
                  case 8:
                    goto label_11;
                  case 9:
                    positionElement1.IsChief = true;
                    num2 = 8;
                    continue;
                  default:
                    positionElement2 = (PositionElement) null;
                    break;
                }
                positionElement1 = positionElement2;
                num2 = 3;
              }
label_7:
              current = enumerator.Current;
              num2 = 6;
              goto label_6;
label_12:
              num2 = 4;
              goto label_6;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
              else
                goto label_26;
label_24:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_26:
              SecurityDbStructure.PZ0hvKLZJTHwcKclZId((object) enumerator);
              num3 = 2;
              goto label_24;
            }
        }
      }
label_35:
      return;
label_25:
      return;
label_31:
      return;
label_28:;
    }

    /// <summary>Создать таблицу PublicCacheData</summary>
    public void CreatePublicCacheTables()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider serviceNotNull;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table1);
              num2 = 5;
              continue;
            case 4:
              goto label_8;
            case 5:
              goto label_9;
            default:
              if (!SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(658384612 ^ 658433084)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 1 : 4;
                continue;
              }
              goto label_3;
          }
        }
label_8:
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
        SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table2, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1324692970 << 3 ^ -2007592344));
        table2.Columns = new List<Column>()
        {
          new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-617657301 ^ -617640239), DbType.Int64, ColumnProperty.PrimaryKey),
          new Column((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(334323849 << 5 ^ 2108478046), DbType.Int64, ColumnProperty.PrimaryKey)
        };
        table1 = table2;
        num1 = 3;
      }
label_5:
      return;
label_9:
      return;
label_3:;
    }

    /// <summary>Создать таблицу PublicCacheData</summary>
    public void CreatePublicCacheFK()
    {
      int num = 1;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            goto label_6;
          case 4:
            ITransformationProvider transformationProvider = serviceNotNull;
            ForeignKey foreignKey = new ForeignKey();
            foreignKey.Columns = new List<string>()
            {
              (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1245871191 - 2145700088 ^ -899845723)
            };
            SecurityDbStructure.u2kAMVLARewuCLE7ERA((object) foreignKey, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(554338340 ^ 554322684));
            foreignKey.RefTableName = (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1457346863 ^ -1457279501);
            foreignKey.RefColumns = new List<string>()
            {
              (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1743015995 ^ -1743017455)
            };
            SecurityDbStructure.HuGvPfLsPItNqdxHpmj((object) foreignKey, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123830472));
            foreignKey.DeleteAction = EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint.Cascade;
            foreignKey.UpdateAction = EleWise.ELMA.Runtime.Db.Migrator.Framework.ForeignKeyConstraint.NoAction;
            transformationProvider.AddForeignKey(foreignKey);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 3 : 3;
            continue;
          default:
            if (SecurityDbStructure.X8xPErnl5yMCMN6VnVJ((object) serviceNotNull, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1341618464 ^ -1341635528)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 4 : 0;
              continue;
            }
            goto label_2;
        }
      }
label_8:
      return;
label_6:
      return;
label_2:;
    }

    /// <summary>
    /// Заполнить значения свойств IsDeleted и HardDelete у сущности OrganizationItem
    /// </summary>
    public void FillOrgItemSoftDeletable()
    {
      int num = 1;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
            continue;
          case 2:
            ITransformationProvider transformationProvider1 = serviceNotNull;
            object table1 = SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1028265253 << 4 ^ 727606380);
            string[] columns1 = new string[1];
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IOrganizationItem)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(839394233 ^ 839413817));
            // ISSUE: method reference
            // ISSUE: type reference
            columns1[0] = LinqUtils.NameOf<IOrganizationItem>(Expression.Lambda<Func<IOrganizationItem, object>>((Expression) Expression.Convert((Expression) SecurityDbStructure.vkfp68nzUdPMA0rCd8G((object) parameterExpression1, (object) (MethodInfo) SecurityDbStructure.u8dwHpLCUT8G4aRoVoA(__methodref (IOrganizationItem.get_HardDelete))), SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (object))), parameterExpression1));
            object[] values1 = new object[1]{ (object) 0 };
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) SecurityDbStructure.NHETJLnHH3pn8SV1fMS(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IOrganizationItem)), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-315619370 - -1325004768 ^ 1009364022));
            // ISSUE: method reference
            // ISSUE: type reference
            object where1 = SecurityDbStructure.zEHsVdLWTPTjlKqeEee((object) LinqUtils.NameOf<IOrganizationItem>(Expression.Lambda<Func<IOrganizationItem, object>>((Expression) SecurityDbStructure.GJ8BevL7nPUbLxsOFSE((object) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IOrganizationItem.get_HardDelete))), SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (object))), parameterExpression2)), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1751467293 ^ -1751404183));
            transformationProvider1.Update((string) table1, columns1, values1, (string) where1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 1 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            ITransformationProvider transformationProvider2 = serviceNotNull;
            object table2 = SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(711486506 ^ 711501302);
            string[] columns2 = new string[1];
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = Expression.Parameter(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IOrganizationItem)), (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1788054269 >> 5 ^ -55889880));
            // ISSUE: method reference
            // ISSUE: type reference
            columns2[0] = LinqUtils.NameOf<IOrganizationItem>(Expression.Lambda<Func<IOrganizationItem, object>>((Expression) Expression.Convert((Expression) SecurityDbStructure.vkfp68nzUdPMA0rCd8G((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IOrganizationItem.get_IsDeleted))), SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (object))), parameterExpression3));
            object[] values2 = new object[1]{ (object) 0 };
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) SecurityDbStructure.NHETJLnHH3pn8SV1fMS(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IOrganizationItem)), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-909559362 ^ -398405015 ^ 562673751));
            // ISSUE: method reference
            string where2 = LinqUtils.NameOf<IOrganizationItem>(Expression.Lambda<Func<IOrganizationItem, object>>((Expression) SecurityDbStructure.GJ8BevL7nPUbLxsOFSE((object) Expression.Property((Expression) parameterExpression4, (MethodInfo) SecurityDbStructure.u8dwHpLCUT8G4aRoVoA(__methodref (IOrganizationItem.get_IsDeleted))), typeof (object)), parameterExpression4)) + (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1596821387 ^ -1596752897);
            transformationProvider2.Update((string) table2, columns2, values2, where2);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Взять настройки центра сертификации из модуля DocFlow</summary>
    public void RetrieveCertificationAuthoritySettings()
    {
      switch (1)
      {
        case 1:
          try
          {
            string str = ((ISettingsManager) SecurityDbStructure.Qvrk47Lr7tJQ1MoyT0u()).GetString(SecurityDbStructure.DigitalSignatureSettingsModuleUid, (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-845204010 ^ 2052495102 ^ -1211586378));
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_8;
                case 1:
                  SecurityDbStructure.Oo1bSZLYIqvHburrMJX((object) DataAccessManager.SettingsManager, new Guid((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1880054609 ^ -1879986321)), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-340788466 ^ -340856688), (object) str);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
                  continue;
                case 2:
                  if (!SecurityDbStructure.BqARq6LSNeQO29itTTG((object) str))
                  {
                    num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 1 : 1;
                    continue;
                  }
                  goto label_4;
                default:
                  goto label_1;
              }
            }
label_8:
            break;
label_1:
            break;
label_4:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_15;
                default:
                  SecurityDbStructure.I8Vsa2nFmuhXj0AlHVQ((object) Logger.Log, (object) ex.Message, (object) ex);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 1 : 1;
                  continue;
              }
            }
label_15:
            break;
          }
      }
    }

    protected void DirectColumnConvert(string tableName, string columnName)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        string str1;
        string str2;
        ITransformationProvider serviceNotNull;
        string sql;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              if (!SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, (object) str1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 1 : 0;
                continue;
              }
              goto case 6;
            case 3:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = 2;
              continue;
            case 4:
              str2 = (string) SecurityDbStructure.TcNOetLyIf7uYq4uW28((object) Locator.GetServiceNotNull<DbModelUpdater>(), (object) tableName, (object) str1);
              num2 = 3;
              continue;
            case 5:
              str1 = columnName;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 2 : 4;
              continue;
            case 6:
              if (SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, (object) tableName, (object) str2))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 7:
              goto label_14;
            case 8:
              goto label_6;
            default:
              sql = (string) SecurityDbStructure.mmc72oLfDpYwjG2s8y4(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-110921701 >> 6 ^ -1801748), (object) new object[4]
              {
                SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), (object) tableName),
                SecurityDbStructure.WlPIQmLllReGRKuSJGs((object) serviceNotNull.Dialect, (object) str1),
                SecurityDbStructure.WlPIQmLllReGRKuSJGs((object) serviceNotNull.Dialect, (object) str2),
                SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(978908330 << 6 ^ -1774375084))
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 8 : 2;
              continue;
          }
        }
label_6:
        serviceNotNull.ExecuteNonQuery(sql);
        num1 = 7;
      }
label_4:
      return;
label_14:
      return;
label_3:;
    }

    /// <summary>
    ///  Изменение типа поля UserPublicKeyToken.PublicKey с BLOB на string(2000)
    /// </summary>
    public void UserPublicKeyConvert()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.DirectColumnConvert(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1341618464 ^ -1341551968), (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-29763048 >> 5 ^ -998728));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Изменение логинов пользователей, у которых имя отличается только регистром
    /// </summary>
    public void ChangeUserNames() => SecurityDbStructure.CGBsPXL4FKLIi2KYaOd(SecurityDbStructure.fDOJ00n5d9WNIYZuIs4());

    /// <summary>Создание таблицы для сессий пользователей.</summary>
    public void CreateActiveUserSessionTable3()
    {
      int num1 = 21;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider serviceNotNull;
        Column column1;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
        Column column2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SecurityDbStructure.hoCMVOnPSVTH52wtCb1((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-94240706 ^ -94239906), (object) column2);
              num2 = 13;
              continue;
            case 2:
              SecurityDbStructure.Bw3UaGn4usNaa05cLB6((object) serviceNotNull, (object) table1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 5 : 4;
              continue;
            case 3:
              if (serviceNotNull.TableExists((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(150349507 - 521039768 ^ -370690997)))
              {
                num2 = 6;
                continue;
              }
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
              table2.Columns = new List<Column>();
              SecurityDbStructure.aXpemfnfxaY1XnB44I1((object) table2, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(908197830 ^ 908197030));
              SecurityDbStructure.t4ZWEfn8swj7Bo5qEVg((object) table2, false);
              table1 = table2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 7 : 14;
              continue;
            case 4:
              table1.Columns.Add(column2);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 9 : 15;
              continue;
            case 5:
              goto label_3;
            case 6:
              if (!SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1257514304 ^ -1257514592), (object) column2.Name))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 1 : 1;
                continue;
              }
              goto case 13;
            case 7:
              goto label_22;
            case 8:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.LastActionDate, DbType.DateTime));
              num2 = 11;
              continue;
            case 9:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.UserId, DbType.Int64));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 18 : 11;
              continue;
            case 10:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.Status, DbType.Int32));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 4 : 0;
              continue;
            case 11:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.LastPingDate, DbType.DateTime));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 0 : 0;
              continue;
            case 12:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.CreationDate, DbType.DateTime));
              num2 = 8;
              continue;
            case 13:
              if (!SecurityDbStructure.IQYwjxncQAuLvCrTEYi((object) serviceNotNull, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(2086891181 ^ 2086890957), (object) column1.Name))
              {
                num2 = 19;
                continue;
              }
              goto label_29;
            case 14:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.TicketUid, DbType.Guid, ColumnProperty.PrimaryKey));
              num2 = 10;
              continue;
            case 15:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.SessionId, new ColumnType(DbType.String, (int) byte.MaxValue)));
              num2 = 9;
              continue;
            case 16:
              goto label_4;
            case 17:
              column1 = new Column(AuthenticatedSessionInfo.Db.Fields.SessionData, DbType.Binary);
              num2 = 3;
              continue;
            case 18:
              table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.RemoteAddress, new ColumnType(DbType.String, (int) byte.MaxValue)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 7 : 12;
              continue;
            case 19:
              serviceNotNull.AddColumn((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-845204010 ^ 2052495102 ^ -1211523000), column1);
              num2 = 16;
              continue;
            case 20:
              column2 = new Column(AuthenticatedSessionInfo.Db.Fields.Expiration, DbType.DateTime);
              num2 = 17;
              continue;
            case 21:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 13 : 20;
              continue;
            default:
              goto label_25;
          }
        }
label_22:
        table1.Columns.Add(column1);
        num1 = 2;
        continue;
label_25:
        table1.Columns.Add(new Column(AuthenticatedSessionInfo.Db.Fields.LastActionInfo, new ColumnType(DbType.String, int.MaxValue)));
        num1 = 7;
      }
label_3:
      return;
label_4:
      return;
label_29:;
    }

    /// <summary>Создать группу привилегированных пользователей</summary>
    public void CreatePrivilegeUsersGroup()
    {
      int num = 6;
      IUserGroup userGroup;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            userGroup.Uid = SecurityConstants.PrivilegeUsersGroupUid;
            num = 8;
            continue;
          case 2:
            goto label_12;
          case 3:
            SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) userGroup);
            num = 10;
            continue;
          case 4:
            user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
            num = 9;
            continue;
          case 5:
            if (userGroup == null)
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 6:
            UserGroupManager instance = UserGroupManager.Instance;
            // ISSUE: type reference
            ParameterExpression parameterExpression = (ParameterExpression) SecurityDbStructure.NHETJLnHH3pn8SV1fMS(SecurityDbStructure.SgdpeTnyrVxEXrvF322(__typeref (IUserGroup)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1567399832 << 6 ^ 1529329018));
            // ISSUE: method reference
            // ISSUE: field reference
            // ISSUE: method reference
            Expression<Func<IUserGroup, bool>> condition = Expression.Lambda<Func<IUserGroup, bool>>((Expression) SecurityDbStructure.xwBTw3Lbh3ExYhXlvmG(SecurityDbStructure.vkfp68nzUdPMA0rCd8G((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserGroup.get_Uid))), SecurityDbStructure.JlFjgPLwJGUpALd0q6W((object) null, SecurityDbStructure.xXbJMrLuWK43wvILlNe(__fieldref (SecurityConstants.PrivilegeUsersGroupUid))), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression);
            userGroup = instance.Find(condition).FirstOrDefault<IUserGroup>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 5;
            continue;
          case 7:
            goto label_2;
          case 8:
            SecurityDbStructure.lywyICL6GvVXje178Bu((object) userGroup, true);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 3 : 0;
            continue;
          case 9:
            if (user != null)
            {
              InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
              SecurityDbStructure.SFDs22LDkuyKExKb6sn((object) instanceOf.New, SecurityDbStructure.iNVJDULcqky73at7SYC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617648054)));
              SecurityDbStructure.u2YC44Loj23iAwYgN7j((object) instanceOf.New, SecurityDbStructure.iNVJDULcqky73at7SYC(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(2016571091 >> 5 ^ 62955450)));
              SecurityDbStructure.jTKcfWLtWyfFEYJKLTg((object) instanceOf.New, (object) user);
              instanceOf.New.Users = (ISet<EleWise.ELMA.Security.Models.IUser>) new HashedSet<EleWise.ELMA.Security.Models.IUser>();
              userGroup = instanceOf.New;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 0 : 0;
              continue;
            }
            num = 2;
            continue;
          case 10:
            SecurityDbStructure.V2fKJoLxoanfqBgmZ37(SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) ""));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 7 : 0;
            continue;
          default:
            userGroup.Users.Add(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return;
label_12:
      throw new InvalidOperationException((string) SecurityDbStructure.aocJXcLK5Cbxx0Ly31R(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-206147790 ^ -206084692), (object) new object[1]
      {
        (object) SecurityConstants.AdminUserUid
      }));
    }

    /// <summary>Ограничить колонку с локалью по длине</summary>
    public void ConvertLangUserColumn()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SecurityDbStructure.AEP96YLPwcJGjibjrlZ((object) Locator.GetServiceNotNull<ITransformationProvider>(), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(908197830 ^ 908196366), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1596821387 ^ -1596752475), 10);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SecurityDbStructure.V2fKJoLxoanfqBgmZ37(SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) ""));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Установка локали по умолчанию</summary>
    public void SetDefaultLocalToUsers()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider serviceNotNull;
        string str;
        string sql;
        while (true)
        {
          switch (num2)
          {
            case 1:
              sql = string.Format((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-278393783 ^ -278330987), (object) ((Dialect) SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull)).QuoteIfNeeded((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-389167216 ^ -389168552)), (object) str, SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1324692970 << 3 ^ -2007540384)), SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(~123928154 ^ -123990029)));
              num2 = 9;
              continue;
            case 2:
              sql = (string) SecurityDbStructure.mmc72oLfDpYwjG2s8y4(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(2086891181 ^ 2086821997), (object) new object[4]
              {
                SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1859356887 ^ -1859357983)),
                (object) str,
                SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(658384612 ^ 658450610)),
                SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550701440))
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
              continue;
            case 3:
              sql = (string) SecurityDbStructure.mmc72oLfDpYwjG2s8y4(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1185105284 ^ 1185041392), (object) new object[4]
              {
                SecurityDbStructure.WlPIQmLllReGRKuSJGs((object) serviceNotNull.Dialect, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1958977588 ^ -1958979068)),
                (object) str,
                (object) ((Dialect) SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull)).QuoteIfNeeded((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(928696104 ^ 928762238)),
                SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1076316568 ^ 1076249672))
              });
              num2 = 4;
              continue;
            case 4:
              serviceNotNull.ExecuteNonQuery(sql);
              num2 = 2;
              continue;
            case 5:
              str = (string) SecurityDbStructure.GQoFelL8LpUH0PqBqvC(SecurityDbStructure.ajFyocLQ9vdDo0U2h8Y());
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 1;
              continue;
            case 6:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 3 : 5;
              continue;
            case 7:
              Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 8 : 6;
              continue;
            case 8:
              goto label_3;
            case 9:
              goto label_9;
            default:
              goto label_12;
          }
        }
label_9:
        serviceNotNull.ExecuteNonQuery(sql);
        num1 = 3;
        continue;
label_12:
        serviceNotNull.ExecuteNonQuery(sql);
        num1 = 7;
      }
label_3:;
    }

    /// <summary>
    /// Исправляем страрые культуры, которые без региональных настроек
    /// </summary>
    public void UpdateOldUsersCultures()
    {
      int num1 = 3;
      List<string> stringList;
      ITransformationProvider serviceNotNull;
      string sql;
      IDataReader dataReader;
      List<string>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_21:
              if (SecurityDbStructure.hF0o5qLXlfY73Lfn73w((object) dataReader))
                goto label_29;
              else
                goto label_22;
label_20:
              string str1;
              string str2;
              CultureInfo cultureInfo;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    stringList.Add(str1);
                    num2 = 3;
                    continue;
                  case 2:
                  case 3:
                  case 8:
                    goto label_21;
                  case 4:
                    cultureInfo = (CultureInfo) SecurityDbStructure.k2CqC6LGUJH3yTVKqVr((object) str2);
                    num2 = 5;
                    continue;
                  case 5:
                    str1 = (string) SecurityDbStructure.mmc72oLfDpYwjG2s8y4(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-404268492 ^ -404335258), (object) new object[4]
                    {
                      SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1880054609 ^ -1880055449)),
                      (object) ((Dialect) SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull)).QuoteIfNeeded((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-819366706 ^ -819431138)),
                      SecurityDbStructure.GQoFelL8LpUH0PqBqvC((object) cultureInfo),
                      (object) str2
                    });
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 1;
                    continue;
                  case 6:
                    goto label_15;
                  case 7:
                    goto label_28;
                  case 9:
                    if (SecurityDbStructure.D2jAHvLEaQH2iEmlqxk((object) str2, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(--1587467489 ^ 1587468487)))
                    {
                      num2 = 8;
                      continue;
                    }
                    goto case 4;
                  default:
                    goto label_29;
                }
              }
label_22:
              num2 = 6;
              goto label_20;
label_28:
              str2 = (string) SecurityDbStructure.zUWRsJLdcdvHVFJ1XsO(SecurityDbStructure.gpyPgyL5JykCmqqdbhH((object) dataReader, 0));
              num2 = 9;
              goto label_20;
label_29:
              if (SecurityDbStructure.gpyPgyL5JykCmqqdbhH((object) dataReader, 0) is DBNull)
              {
                num2 = 2;
                goto label_20;
              }
              else
                goto label_28;
            }
            finally
            {
              if (dataReader != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_37;
                    default:
                      SecurityDbStructure.PZ0hvKLZJTHwcKclZId((object) dataReader);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_37:;
            }
          case 2:
            sql = string.Format((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(781628008 - 11982093 ^ 769577557), SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1608980123 ^ -1608979283)), (object) ((Dialect) SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull)).QuoteIfNeeded((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1212789817 - 1827404527 ^ 1254841608)));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 0 : 0;
            continue;
          case 3:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num1 = 2;
            continue;
          case 4:
            goto label_35;
          case 5:
            dataReader = serviceNotNull.ExecuteQuery(sql, (Dictionary<string, object>) null);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 1 : 1;
            continue;
          case 6:
            try
            {
label_6:
              if (enumerator.MoveNext())
                goto label_8;
              else
                goto label_7;
label_5:
              string current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    serviceNotNull.ExecuteNonQuery(current);
                    num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_8;
                  case 3:
                    goto label_16;
                  default:
                    goto label_6;
                }
              }
label_7:
              num4 = 3;
              goto label_5;
label_8:
              current = enumerator.Current;
              num4 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0)
              {
                num4 = 0;
                goto label_5;
              }
              else
                goto label_5;
            }
            finally
            {
              enumerator.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 7:
label_16:
            SecurityDbStructure.V2fKJoLxoanfqBgmZ37(SecurityDbStructure.ymFo6NnOMlHfBeRjm7j((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) ""));
            num1 = 4;
            continue;
          case 8:
label_15:
            enumerator = stringList.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 6 : 4;
            continue;
          default:
            stringList = new List<string>();
            num1 = 5;
            continue;
        }
      }
label_35:;
    }

    /// <summary>
    /// Обновление настроек безопасности, связанных с криптопровайдерами
    /// </summary>
    public void UpdateSecurityCryptoSettings()
    {
      switch (1)
      {
        case 1:
          try
          {
            Guid uid1 = new Guid((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-2008710664 - -232311158 ^ -1776336722));
            int num = 4;
            Guid result;
            string str1;
            string input;
            string str2;
            string str3;
            string str4;
            Guid guid;
            while (true)
            {
              switch (num)
              {
                case 1:
                  str2 = ((ISettingsManager) SecurityDbStructure.Qvrk47Lr7tJQ1MoyT0u()).GetString(uid1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801246421));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 1 : 7;
                  continue;
                case 2:
                case 6:
                  object obj = SecurityDbStructure.Qvrk47Lr7tJQ1MoyT0u();
                  Guid uid2 = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690209562 ^ 116876444 ^ 1648949756));
                  Dictionary<string, string> strings = new Dictionary<string, string>();
                  strings.Add((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1331070742 ^ -1331140380), str4);
                  strings.Add((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(--353012470 ^ 353076532), str3);
                  string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1530848604 ^ 1530918298);
                  string str5;
                  if (!SecurityDbStructure.L6WRCLLMsC7EPd7kKKq((object) str2))
                  {
                    List<CertificationAuthorityInfo> certificationAuthorityInfoList = new List<CertificationAuthorityInfo>();
                    CertificationAuthorityInfo certificationAuthorityInfo = new CertificationAuthorityInfo();
                    SecurityDbStructure.wfUO1xLhXLfBL7sKW11((object) certificationAuthorityInfo, (object) str1);
                    certificationAuthorityInfo.Thumbprint = str2;
                    certificationAuthorityInfoList.Add(certificationAuthorityInfo);
                    str5 = ClassSerializationHelper.SerializeObjectByJson((object) certificationAuthorityInfoList);
                  }
                  else
                    str5 = string.Empty;
                  strings.Add(key, str5);
                  ((ISettingsManager) obj).SetStrings(uid2, (IDictionary<string, string>) strings);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 11 : 8;
                  continue;
                case 3:
                  goto label_27;
                case 4:
                  str1 = ((ISettingsManager) SecurityDbStructure.Qvrk47Lr7tJQ1MoyT0u()).GetString(uid1, (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-110921701 >> 6 ^ -1800578));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 1 : 1;
                  continue;
                case 5:
                  result = Guid.Empty;
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 14 : 3;
                  continue;
                case 7:
                  str3 = (string) SecurityDbStructure.eEvnGaL9aDU8sFNZUe2(SecurityDbStructure.Qvrk47Lr7tJQ1MoyT0u(), uid1, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1277472395 ^ -1277534537));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 5 : 0;
                  continue;
                case 8:
                  if (SecurityDbStructure.nbjPhWL1WBQ7wFaRwXl(result, guid))
                  {
                    num = 6;
                    continue;
                  }
                  goto case 15;
                case 9:
                case 13:
                  guid = new Guid((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1245871191 - 2145700088 ^ -899898511));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 7 : 8;
                  continue;
                case 10:
                  goto label_9;
                case 11:
                  goto label_8;
                case 12:
                  if (SecurityDbStructure.BqARq6LSNeQO29itTTG((object) input))
                  {
                    num = 3;
                    continue;
                  }
                  goto case 16;
                case 14:
                  input = (string) SecurityDbStructure.eEvnGaL9aDU8sFNZUe2(SecurityDbStructure.Qvrk47Lr7tJQ1MoyT0u(), SecurityDbStructure.DigitalSignatureSettingsModuleUid, SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1540570615 - 1746246777 ^ 1008085578));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
                  continue;
                case 15:
                  if (SecurityDbStructure.nbjPhWL1WBQ7wFaRwXl(result, Guid.Empty))
                  {
                    num = 2;
                    continue;
                  }
                  goto label_7;
                case 16:
                  if (Guid.TryParse(input, out result))
                  {
                    num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 9 : 7;
                    continue;
                  }
                  goto label_23;
                default:
                  str4 = (string) SecurityDbStructure.eEvnGaL9aDU8sFNZUe2((object) DataAccessManager.SettingsManager, SecurityDbStructure.DigitalSignatureSettingsModuleUid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2016571091 >> 5 ^ 62948216));
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 3 : 12;
                  continue;
              }
            }
label_27:
            break;
label_9:
            break;
label_8:
            break;
label_7:
            break;
label_23:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_6;
                default:
                  SecurityDbStructure.jRN25ELBVmyH6QR9M2Y(SecurityDbStructure.EIEFu7nTD2UJI1NTWRi(), (object) ex.Message);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 0 : 1;
                  continue;
              }
            }
label_6:
            break;
          }
      }
    }

    /// <summary>Заполнить в серт-тах криптопровайдер внутренним</summary>
    public void FillUserCertificateCryptoProvider()
    {
      int num = 3;
      ITransformationProvider serviceNotNull;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            sql = (string) SecurityDbStructure.hNRTWJLO02qrP0AnonZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2016571091 >> 5 ^ 62948254), (object) ((Dialect) SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull)).QuoteIfNeeded((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1489118656 ^ 643054122 ^ -2123828958)), SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(789532496 ^ 1575286436 ^ 1927981214)), SecurityDbStructure.XDnUUMLpbQueR27XFHh((object) serviceNotNull));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
            continue;
          case 3:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 0 : 2;
            continue;
          default:
            serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>()
            {
              {
                (string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1788783669 - 1293477238 ^ 1212776391),
                (object) new Guid((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(978908330 << 6 ^ -1774437638))
              }
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Заполнить действие серт-тов как серт-т для вход</summary>
    public void FillUserCertificateCryptoAction()
    {
      int num = 2;
      ITransformationProvider serviceNotNull;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            sql = (string) SecurityDbStructure.hNRTWJLO02qrP0AnonZ(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1341618464 ^ -1341549048), SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-315619370 - -1325004768 ^ 1009315582)), SecurityDbStructure.WlPIQmLllReGRKuSJGs(SecurityDbStructure.WF8ZXNLVriUPmY1k6HE((object) serviceNotNull), SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(1841261835 ^ 1841200297)), SecurityDbStructure.XDnUUMLpbQueR27XFHh((object) serviceNotNull));
            num = 3;
            continue;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 1;
            continue;
          case 3:
            serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>()
            {
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562625093),
                (object) AuthCryptoAction.UID
              }
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Заполнить значение "Основание для отсутствия на рабочем месте"
    /// </summary>
    internal void FillDefaultGroundsForAbsence()
    {
      int num1 = 2;
      Dictionary<Guid, string>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            enumerator = new Dictionary<Guid, string>()
            {
              {
                new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1403802000 ^ 1403863126)),
                (string) SecurityDbStructure.iNVJDULcqky73at7SYC(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-347045778 ^ -346975620))
              },
              {
                new Guid((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(--534238571 ^ 534169403)),
                (string) SecurityDbStructure.iNVJDULcqky73at7SYC(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(978908330 << 6 ^ -1774438372))
              },
              {
                new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629935560 ^ -1103494022 ^ 1682498692)),
                (string) SecurityDbStructure.iNVJDULcqky73at7SYC(SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-1958138283 - -279956781 ^ -1678120816))
              },
              {
                new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124931533)),
                EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(711486506 ^ 711556956))
              }
            }.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 1 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_10:
      return;
label_3:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_7;
label_4:
        KeyValuePair<Guid, string> current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_5;
            case 3:
              IGroundsForAbsence groundsForAbsence = InterfaceActivator.Create<IGroundsForAbsence>();
              SecurityDbStructure.q8Zh1ILTvl7eVDpWE1H((object) groundsForAbsence, current.Key);
              SecurityDbStructure.CrlIShLFBJM64TKJxXW((object) groundsForAbsence, (object) current.Value);
              SecurityDbStructure.xsopPpnheKbEFSOkHhS((object) groundsForAbsence);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_5:
        return;
label_7:
        num2 = 2;
        goto label_4;
label_8:
        current = enumerator.Current;
        num2 = 3;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public SecurityDbStructure()
    {
      SecurityDbStructure.qHhbVjLv9Qifw4m0aci();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SecurityDbStructure()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SecurityDbStructure.DigitalSignatureSettingsModuleUid = new Guid((string) SecurityDbStructure.a4GWrBnVFI6f6J5PYTa(-468111058 ^ -468180292));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static Type SgdpeTnyrVxEXrvF322([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool guwBvynSr36DNe4gbHP() => SecurityDbStructure.bfxeBwnrw2KmH4d9Nh7 == null;

    internal static SecurityDbStructure Nnn5rOnYRWmRXOIhlBY() => SecurityDbStructure.bfxeBwnrw2KmH4d9Nh7;

    internal static object a4GWrBnVFI6f6J5PYTa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool X8xPErnl5yMCMN6VnVJ([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void aXpemfnfxaY1XnB44I1([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Name = (string) obj1;

    internal static void Bw3UaGn4usNaa05cLB6([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj1);

    internal static bool IQYwjxncQAuLvCrTEYi([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).ColumnExists((string) obj1, (string) obj2);

    internal static void hoCMVOnPSVTH52wtCb1([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).AddColumn((string) obj1, (Column) obj2);

    internal static object SvdsgQnQj3Wtmp6JDNH([In] object obj0) => (object) ((Column) obj0).Name;

    internal static void t4ZWEfn8swj7Bo5qEVg([In] object obj0, [In] bool obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Sequence = obj1;

    internal static object fDOJ00n5d9WNIYZuIs4() => (object) UserManager.Instance;

    internal static void kJJJJandayU3OlxfWsA([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.IUser) obj0).UserName = (string) obj1;

    internal static void ReoHwJnEeHtl5HMH46d([In] object obj0, bool value) => ((IUserSecurityProfile) obj0).ForcedChangePassword = value;

    internal static DateTime s2bGcKnGpc2mFC8OTtr() => DateTime.Now;

    internal static void UxAh8FnXHbo3gpfuErs([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.IUser) obj0).LastName = (string) obj1;

    internal static object tjWggDn9AICDbEZ5ZMG([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static void tdPfpbn1fgogiqDTdkU([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.IUser) obj0).FirstName = (string) obj1;

    internal static void fQMYj0nMtchdgRF89CM([In] object obj0, Guid value) => ((EleWise.ELMA.Security.Models.IUser) obj0).Uid = value;

    internal static void xsopPpnheKbEFSOkHhS([In] object obj0) => ((IEntity) obj0).Save();

    internal static void sQqbTQnBsw7ovG1QrQm([In] object obj0, UserStatus value) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status = value;

    internal static void cTRbCOnp1shEug9u7Lb([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.IUser) obj0).Photo = (BinaryFile) obj1;

    internal static object ymFo6NnOMlHfBeRjm7j([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object EIEFu7nTD2UJI1NTWRi() => (object) Logger.Log;

    internal static void I8Vsa2nFmuhXj0AlHVQ([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object GF9P3hnvVrXdV9vAnws() => (object) BinaryFile.CreateNew();

    internal static object M9HmbqnqTqs0ohx1KOF([In] object obj0, [In] object obj1) => (object) ((BinaryFileBuilder) obj0).Name((string) obj1);

    internal static object UphLaengvUgFOZKi3pk([In] object obj0, [In] object obj1) => (object) ((IMimeMappingService) obj0).GetTypeByExtension((string) obj1);

    internal static object zUc6O2nJ6qG5NY1LyB0([In] object obj0, [In] object obj1) => (object) ((BinaryFileBuilder) obj0).ContentType((string) obj1);

    internal static object OXVKn2nIcB9QmO7QPNL([In] object obj0, [In] object obj1) => (object) ((BinaryFileBuilder) obj0).Content((byte[]) obj1);

    internal static object dG77l5nePGylqvxBhxi([In] object obj0) => (object) ((BinaryFileBuilder) obj0).Build();

    internal static object q4mWexnnogw7VS9dbM2() => (object) DataAccessManager.FileManager;

    internal static object wEIZDZnLWLVyTEvAboa([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).SaveFile((BinaryFile) obj1);

    internal static void NIjnOin2NA8Ex9YCCaZ([In] object obj0, [In] object obj1) => ((IAuthenticationService) obj0).SetAuthenticatedUserForRequest((EleWise.ELMA.Security.IUser) obj1);

    internal static object NHETJLnHH3pn8SV1fMS([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object vkfp68nzUdPMA0rCd8G([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object xXbJMrLuWK43wvILlNe([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object JlFjgPLwJGUpALd0q6W([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object xwBTw3Lbh3ExYhXlvmG([In] object obj0, [In] object obj1, [In] bool obj2, [In] object obj3) => (object) Expression.Equal((Expression) obj0, (Expression) obj1, obj2, (MethodInfo) obj3);

    internal static object aocJXcLK5Cbxx0Ly31R([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object WhAVXjLU7hRspiVaFwV([In] object obj0) => (object) ((GroupDescriptor) obj0).Name;

    internal static object s2LERYLR4LWoTaQeekq([In] object obj0) => (object) ((GroupDescriptor) obj0).Description;

    internal static void u2YC44Loj23iAwYgN7j([In] object obj0, [In] object obj1) => ((IUserGroup) obj0).Description = (string) obj1;

    internal static void jTKcfWLtWyfFEYJKLTg([In] object obj0, [In] object obj1) => ((IUserGroup) obj0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static void hmQ6mWLmogaTWqYXbIA([In] object obj0, Guid value) => ((IUserGroup) obj0).Uid = value;

    internal static void lywyICL6GvVXje178Bu([In] object obj0, bool value) => ((IUserGroup) obj0).IsSystem = value;

    internal static object h6hDFBLk71ggiwxyBW3() => (object) UserGroupManager.Instance;

    internal static void SFDs22LDkuyKExKb6sn([In] object obj0, [In] object obj1) => ((IUserGroup) obj0).Name = (string) obj1;

    internal static void JwXpStLaQw38S3poPvh([In] object obj0, bool value) => ((IUserGroup) obj0).AddToNewUser = value;

    internal static void V2fKJoLxoanfqBgmZ37([In] object obj0) => ((ISession) obj0).Flush();

    internal static object u8dwHpLCUT8G4aRoVoA([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object NkYDxRLi0F49jLqhYMN() => (object) OrganizationModelManager.Instance;

    internal static object znHE3IL3shvi6bO4cFl([In] object obj0) => (object) ((OrganizationModelManager) obj0).Load();

    internal static object eTKYe0LjB3WtOXi2EO1([In] object obj0) => (object) ((IOrganizationModel) obj0).Diagram;

    internal static object FY11StLNJHk0mRCC8wj([In] object obj0) => (object) ((Diagram) obj0).Elements;

    internal static object pMDeyML0S0DCKwmUDt7([In] object obj0) => (object) ((Element) obj0).LocalizableName;

    internal static void PZ0hvKLZJTHwcKclZId([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void u2kAMVLARewuCLE7ERA([In] object obj0, [In] object obj1) => ((ForeignKey) obj0).TableName = (string) obj1;

    internal static void HuGvPfLsPItNqdxHpmj([In] object obj0, [In] object obj1) => ((ForeignKey) obj0).Name = (string) obj1;

    internal static object GJ8BevL7nPUbLxsOFSE([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object zEHsVdLWTPTjlKqeEee([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object Qvrk47Lr7tJQ1MoyT0u() => (object) DataAccessManager.SettingsManager;

    internal static bool BqARq6LSNeQO29itTTG([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void Oo1bSZLYIqvHburrMJX([In] object obj0, [In] Guid obj1, [In] object obj2, [In] object obj3) => ((ISettingsManager) obj0).SetString(obj1, (string) obj2, (string) obj3);

    internal static object TcNOetLyIf7uYq4uW28([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((DbModelUpdater) obj0).GetDeletingColumnTemporaryName((string) obj1, (string) obj2);

    internal static object WF8ZXNLVriUPmY1k6HE([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object WlPIQmLllReGRKuSJGs([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object mmc72oLfDpYwjG2s8y4([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static void CGBsPXL4FKLIi2KYaOd([In] object obj0) => ((UserManager) obj0).ChangeUserNames();

    internal static object iNVJDULcqky73at7SYC([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void AEP96YLPwcJGjibjrlZ([In] object obj0, [In] object obj1, [In] object obj2, [In] int obj3) => ((ITransformationProvider) obj0).ConvertColumnStringIfNeed((string) obj1, (string) obj2, obj3);

    internal static object ajFyocLQ9vdDo0U2h8Y() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static object GQoFelL8LpUH0PqBqvC([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object gpyPgyL5JykCmqqdbhH([In] object obj0, [In] int obj1) => ((IDataRecord) obj0)[obj1];

    internal static object zUWRsJLdcdvHVFJ1XsO([In] object obj0) => (object) Convert.ToString(obj0);

    internal static bool D2jAHvLEaQH2iEmlqxk([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object k2CqC6LGUJH3yTVKqVr([In] object obj0) => (object) CultureInfo.CreateSpecificCulture((string) obj0);

    internal static bool hF0o5qLXlfY73Lfn73w([In] object obj0) => ((IDataReader) obj0).Read();

    internal static object eEvnGaL9aDU8sFNZUe2([In] object obj0, [In] Guid obj1, [In] object obj2) => (object) ((ISettingsManager) obj0).GetString(obj1, (string) obj2);

    internal static bool nbjPhWL1WBQ7wFaRwXl([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool L6WRCLLMsC7EPd7kKKq([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void wfUO1xLhXLfBL7sKW11([In] object obj0, [In] object obj1) => ((CertificationAuthorityInfo) obj0).ServerAddress = (string) obj1;

    internal static void jRN25ELBVmyH6QR9M2Y([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object XDnUUMLpbQueR27XFHh([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object hNRTWJLO02qrP0AnonZ([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static void q8Zh1ILTvl7eVDpWE1H([In] object obj0, Guid value) => ((IGroundsForAbsence) obj0).Uid = value;

    internal static void CrlIShLFBJM64TKJxXW([In] object obj0, [In] object obj1) => ((IGroundsForAbsence) obj0).Name = (string) obj1;

    internal static void qHhbVjLv9Qifw4m0aci() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
