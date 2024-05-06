// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.BPMApps.SecurityBAChapter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.BPMApps;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.Security.BPMApps
{
  public class SecurityBAChapter : BPMAppManifestChapter
  {
    internal static SecurityBAChapter zeeoVhwuHeIJwdhKkPVN;

    /// <summary>Экспортировать всю оргструктуру</summary>
    [DefaultValue(false)]
    [XmlElement("ExportFullOrgstructure")]
    public bool ExportFullOrgstructure
    {
      get => this.\u003CExportFullOrgstructure\u003Ek__BackingField;
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
              this.\u003CExportFullOrgstructure\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 0 : 0;
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

    /// <summary>Группы пользователей</summary>
    [XmlArray("UserGroups")]
    [DefaultValue(null)]
    public List<UserGroupBAItem> UserGroups { get; set; }

    public SecurityBAChapter()
    {
      SecurityBAChapter.OFAuHjwwwbOyF9S4YHKh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EdpfC9wuzRW8b6QfbpNw() => SecurityBAChapter.zeeoVhwuHeIJwdhKkPVN == null;

    internal static SecurityBAChapter LeElRLwwuFWWMyAyrRky() => SecurityBAChapter.zeeoVhwuHeIJwdhKkPVN;

    internal static void OFAuHjwwwbOyF9S4YHKh() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
