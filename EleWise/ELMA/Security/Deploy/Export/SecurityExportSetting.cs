// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Export.SecurityExportSetting
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Deploy.Export
{
  /// <summary>Конфигурация экспорта Security</summary>
  [Serializable]
  public class SecurityExportSetting
  {
    private static SecurityExportSetting iu4MSnIjwUSNZfQiN4J;

    public SecurityExportSetting()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ExportUserGroups = true;
            num = 3;
            continue;
          case 2:
            this.ExportOrgModel = false;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 1 : 0;
            continue;
          case 3:
            this.UserGroupsIds = new List<long>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            this.UserGroupsUids = new List<Guid>();
            num = 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Флаг переноса оргструктуры</summary>
    public bool ExportOrgModel
    {
      get => this.\u003CExportOrgModel\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExportOrgModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Флаг переноса групп пользователей</summary>
    public bool ExportUserGroups
    {
      get => this.\u003CExportUserGroups\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExportUserGroups\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>id-ки груп пользователей</summary>
    [Obsolete("Используй UserGroupsUids")]
    public List<long> UserGroupsIds { get; set; }

    /// <summary>id-ки груп пользователей</summary>
    public List<Guid> UserGroupsUids { get; set; }

    internal static bool zaEVwkINcj4setVUU9Z() => SecurityExportSetting.iu4MSnIjwUSNZfQiN4J == null;

    internal static SecurityExportSetting kYEtLGI0PsqcRIiGSRa() => SecurityExportSetting.iu4MSnIjwUSNZfQiN4J;
  }
}
