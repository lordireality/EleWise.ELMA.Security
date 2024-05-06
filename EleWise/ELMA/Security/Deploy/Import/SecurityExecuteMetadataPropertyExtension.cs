// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.SecurityExecuteMetadataPropertyExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>Обработка свойств при импорте для модуля Безопасности</summary>
  internal class SecurityExecuteMetadataPropertyExtension : BaseExecuteMetadataPropertyExtension
  {
    private OrganizationItemManager organizationItemManager;
    private UserGroupManager userGroupManager;
    internal static SecurityExecuteMetadataPropertyExtension guxFctI55chubNenUDW;

    /// <summary>Ctor</summary>
    /// <param name="organizationItemManager">Менеджер элементов оргструктуры</param>
    /// <param name="userGroupManager">Менеджер групп пользователей</param>
    public SecurityExecuteMetadataPropertyExtension(
      OrganizationItemManager organizationItemManager,
      UserGroupManager userGroupManager)
    {
      SecurityExecuteMetadataPropertyExtension.LHZgHOIGkDL2QVYGiX3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.organizationItemManager = organizationItemManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 0;
            continue;
          default:
            this.userGroupManager = userGroupManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public override void MetadataPropertyProcessing(
      IPropertyMetadata importedProperty,
      IPropertyMetadata baseProperty,
      ClassMetadata importedMetadata,
      ReadMetadataParameters parameters)
    {
      int num = 5;
      // ISSUE: variable of a compiler-generated type
      SecurityExecuteMetadataPropertyExtension.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30;
      // ISSUE: variable of a compiler-generated type
      SecurityExecuteMetadataPropertyExtension.\u003C\u003Ec__DisplayClass3_1 cDisplayClass31;
      EntityUserSettings entityUserSettings1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            IPropertyMetadata importedProperty1 = cDisplayClass30.importedProperty;
            object obj = importedProperty1 != null ? SecurityExecuteMetadataPropertyExtension.qurTgGIXy1HwndjW1hq((object) importedProperty1) : (object) null;
            EntityUserSettings entityUserSettings2;
            entityUserSettings1 = entityUserSettings2 = obj as EntityUserSettings;
            // ISSUE: reference to a compiler-generated field
            cDisplayClass30.entityUserSettings = entityUserSettings2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 8 : 11;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass30.entityUserSettings.Workers == null)
            {
              num = 13;
              continue;
            }
            goto case 9;
          case 3:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            cDisplayClass31.CS\u0024\u003C\u003E8__locals1.entityUserSettings.Workers.ForEach(new Action<Worker>(cDisplayClass31.\u003CMetadataPropertyProcessing\u003Eb__0));
            num = 14;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass30.parameters = parameters;
            num = 10;
            continue;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass30 = new SecurityExecuteMetadataPropertyExtension.\u003C\u003Ec__DisplayClass3_0();
            num = 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass30.importedMetadata = importedMetadata;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 1 : 1;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass31.workersForDel = new List<Worker>();
            num = 3;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass30.baseProperty = baseProperty;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 6 : 4;
            continue;
          case 9:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass31 = new SecurityExecuteMetadataPropertyExtension.\u003C\u003Ec__DisplayClass3_1();
            num = 12;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass30.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
            continue;
          case 11:
            if (entityUserSettings1 != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          case 12:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass31.CS\u0024\u003C\u003E8__locals1 = cDisplayClass30;
            num = 7;
            continue;
          case 13:
            goto label_4;
          case 14:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            cDisplayClass31.workersForDel.ForEach(new Action<Worker>(cDisplayClass31.CS\u0024\u003C\u003E8__locals1.\u003CMetadataPropertyProcessing\u003Eb__1));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 5 : 15;
            continue;
          case 15:
            goto label_20;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass30.importedProperty = importedProperty;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 2 : 8;
            continue;
        }
      }
label_4:
      return;
label_20:
      return;
label_2:;
    }

    internal static void LHZgHOIGkDL2QVYGiX3() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool ED12arId6tsA0HjYYVg() => SecurityExecuteMetadataPropertyExtension.guxFctI55chubNenUDW == null;

    internal static SecurityExecuteMetadataPropertyExtension f6iikPIEid9GeetIhVM() => SecurityExecuteMetadataPropertyExtension.guxFctI55chubNenUDW;

    internal static object qurTgGIXy1HwndjW1hq([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;
  }
}
