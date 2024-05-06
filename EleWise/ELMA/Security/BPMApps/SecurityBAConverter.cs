// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.BPMApps.SecurityBAConverter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.DTO.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.BPMApps
{
  [Component(Order = 100)]
  public class SecurityBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportOrgStructUid;
    private static readonly Guid _exportUserGroupUid;
    private static SecurityBAConverter ODElXkwu5OVmwBUSnieL;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        SecurityBAChapter securityBaChapter1;
        SecurityExportSetting securityExportSetting;
        List<Guid>.Enumerator enumerator1;
        HashSet<Guid> guidSet;
        Dictionary<Guid, UserGroupDTO> dictionary1;
        List<long>.Enumerator enumerator2;
        Dictionary<long, UserGroupDTO> dictionary2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_31;
            case 1:
              SecurityBAConverter.B2ivcuwuXwdtC1WECx4f((object) settings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55949308));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 6 : 2;
              continue;
            case 2:
              SecurityBAConverter.B2ivcuwuXwdtC1WECx4f((object) bpmAppManifest, SecurityBAConverter.QEODlvwuGRi4aB2W6ye0(839394233 ^ 839452725));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 1 : 0;
              continue;
            case 3:
            case 5:
            case 17:
label_3:
              if (!SecurityBAConverter.vSyZSxwuO4sI2KslaF7V((object) securityBaChapter1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 4 : 4;
                continue;
              }
              goto case 11;
            case 4:
              if (securityBaChapter1.UserGroups == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 30 : 4;
                continue;
              }
              goto case 31;
            case 6:
              object obj;
              if (!settings.CustomSettings.TryGetValue(SecurityExportConsts.ExportExtensionUid, out obj))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
                continue;
              }
              securityExportSetting = obj as SecurityExportSetting;
              num2 = 12;
              continue;
            case 7:
              goto label_30;
            case 8:
              ICollection<UserGroupDTO> all = Locator.GetServiceNotNull<IUserGroupDTOManager>().FindAll();
              // ISSUE: reference to a compiler-generated field
              Func<UserGroupDTO, UserGroupDTO> func = SecurityBAConverter.\u003C\u003Ec.\u003C\u003E9__0_1;
              Func<UserGroupDTO, UserGroupDTO> elementSelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                SecurityBAConverter.\u003C\u003Ec.\u003C\u003E9__0_1 = elementSelector = (Func<UserGroupDTO, UserGroupDTO>) (g => g);
              }
              else
                goto label_75;
label_74:
              dictionary2 = all.ToDictionary<UserGroupDTO, long, UserGroupDTO>((Func<UserGroupDTO, long>) (g => g.Id), elementSelector);
              // ISSUE: reference to a compiler-generated method
              dictionary1 = all.ToDictionary<UserGroupDTO, Guid>((Func<UserGroupDTO, Guid>) (g => SecurityBAConverter.\u003C\u003Ec.UhjSPJwfDJeFvjV4IWf1((object) g)));
              num2 = 23;
              continue;
label_75:
              elementSelector = func;
              goto label_74;
            case 9:
              if (securityExportSetting.UserGroupsIds != null)
                goto case 8;
              else
                goto label_46;
            case 10:
              SecurityBAChapter securityBaChapter2 = new SecurityBAChapter();
              securityBaChapter2.Uid = SecurityExportConsts.ExportExtensionUid;
              securityBaChapter1 = securityBaChapter2;
              num2 = 14;
              continue;
            case 11:
              SecurityBAConverter.kJpCFmwuF9ugEkBFiATi((object) bpmAppManifest, (object) securityBaChapter1);
              num2 = 32;
              continue;
            case 12:
              if (securityExportSetting == null)
              {
                num2 = 7;
                continue;
              }
              SecurityBAConverter.JDJ67swu12hKlSfxF1Qn((object) bpmAppManifest, SecurityBAConverter._exportOrgStructUid, SecurityBAConverter.fHlvwfwu9lq9c6PAmnSh((object) securityExportSetting));
              num2 = 29;
              continue;
            case 13:
            case 20:
label_33:
              if (securityExportSetting.UserGroupsUids == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 17 : 7;
                continue;
              }
              goto case 28;
            case 14:
              if (!SecurityBAConverter.fHlvwfwu9lq9c6PAmnSh((object) securityExportSetting))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 2 : 21;
                continue;
              }
              goto case 26;
            case 15:
              if (SecurityBAConverter.JQLLgPwuMSxepgTWtX1O((object) securityExportSetting))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 9 : 9;
                continue;
              }
              goto case 3;
            case 16:
              enumerator2 = securityExportSetting.UserGroupsIds.GetEnumerator();
              num2 = 27;
              continue;
            case 18:
              if (securityExportSetting.UserGroupsUids == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 1 : 3;
                continue;
              }
              goto case 8;
            case 19:
            case 21:
              securityBaChapter1.UserGroups = new List<UserGroupBAItem>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 15 : 14;
              continue;
            case 22:
              goto label_72;
            case 23:
              guidSet = new HashSet<Guid>();
              num2 = 24;
              continue;
            case 24:
              if (securityExportSetting.UserGroupsIds == null)
              {
                num2 = 20;
                continue;
              }
              goto case 16;
            case 25:
              try
              {
label_17:
                if (enumerator1.MoveNext())
                  goto label_19;
                else
                  goto label_18;
label_16:
                Guid current;
                UserGroupDTO userGroupDto;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 4:
                      goto label_17;
                    case 2:
                      goto label_19;
                    case 3:
                      if (dictionary1.TryGetValue(current, out userGroupDto))
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 5 : 2;
                        continue;
                      }
                      goto label_17;
                    case 5:
                      if (!guidSet.Add(SecurityBAConverter.oTE9W4wuBiK9I5DVwZbm((object) userGroupDto)))
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 6;
                    case 6:
                      List<UserGroupBAItem> userGroups = securityBaChapter1.UserGroups;
                      UserGroupBAItem userGroupBaItem = new UserGroupBAItem();
                      SecurityBAConverter.itVDWlwupkX9EQC6abup((object) userGroupBaItem, SecurityBAConverter.oTE9W4wuBiK9I5DVwZbm((object) userGroupDto));
                      userGroups.Add(userGroupBaItem);
                      num3 = 4;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_18:
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 0 : 0;
                goto label_16;
label_19:
                current = enumerator1.Current;
                num3 = 3;
                goto label_16;
              }
              finally
              {
                enumerator1.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 26:
              SecurityBAConverter.H21YqNwuhj9OauhRcvNo((object) securityBaChapter1, true);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 19 : 1;
              continue;
            case 27:
              try
              {
label_54:
                if (enumerator2.MoveNext())
                  goto label_50;
                else
                  goto label_55;
label_48:
                long current;
                UserGroupDTO userGroupDto;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (dictionary2.TryGetValue(current, out userGroupDto))
                      {
                        num5 = 2;
                        continue;
                      }
                      goto label_54;
                    case 2:
                      if (guidSet.Add(userGroupDto.Uid))
                      {
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 5 : 1;
                        continue;
                      }
                      goto label_54;
                    case 3:
                      goto label_50;
                    case 4:
                      goto label_33;
                    case 5:
                      List<UserGroupBAItem> userGroups = securityBaChapter1.UserGroups;
                      UserGroupBAItem userGroupBaItem = new UserGroupBAItem();
                      userGroupBaItem.Uid = SecurityBAConverter.oTE9W4wuBiK9I5DVwZbm((object) userGroupDto);
                      userGroups.Add(userGroupBaItem);
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_54;
                  }
                }
label_50:
                current = enumerator2.Current;
                num5 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0)
                {
                  num5 = 1;
                  goto label_48;
                }
                else
                  goto label_48;
label_55:
                num5 = 4;
                goto label_48;
              }
              finally
              {
                enumerator2.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 28:
              enumerator1 = securityExportSetting.UserGroupsUids.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 25 : 1;
              continue;
            case 29:
              SecurityBAConverter.JDJ67swu12hKlSfxF1Qn((object) bpmAppManifest, SecurityBAConverter._exportUserGroupUid, SecurityBAConverter.JQLLgPwuMSxepgTWtX1O((object) securityExportSetting));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 10 : 8;
              continue;
            case 30:
              goto label_63;
            case 31:
              if (SecurityBAConverter.dRYN7ywuT6E3XNcbsoNC((object) securityBaChapter1.UserGroups) <= 0)
              {
                num2 = 22;
                continue;
              }
              goto case 11;
            case 32:
              goto label_59;
            default:
              goto label_49;
          }
        }
label_46:
        num1 = 18;
      }
label_31:
      return;
label_30:
      return;
label_72:
      return;
label_63:
      return;
label_59:
      return;
label_49:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 10;
      List<UserGroupBAItem>.Enumerator enumerator;
      SecurityExportSetting securityExportSetting;
      Dictionary<Guid, UserGroupDTO> dictionary;
      SecurityBAChapter securityBaChapter;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (securityBaChapter != null)
            {
              num1 = 4;
              continue;
            }
            goto case 14;
          case 2:
            securityExportSetting.ExportUserGroups = SecurityBAConverter.wQSg9MwuvdRtZBS3JOvE((object) bpmAppManifest, SecurityBAConverter._exportUserGroupUid, SecurityBAConverter.JQLLgPwuMSxepgTWtX1O((object) securityExportSetting));
            num1 = 3;
            continue;
          case 3:
            securityBaChapter = SecurityBAConverter.aUudCHwugaTEHAACMajr((object) bpmAppManifest, SecurityExportConsts.ExportExtensionUid) as SecurityBAChapter;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 1 : 1;
            continue;
          case 4:
            if (securityBaChapter.UserGroups != null)
            {
              num1 = 12;
              continue;
            }
            goto case 14;
          case 5:
            enumerator = securityBaChapter.UserGroups.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 11 : 2;
            continue;
          case 6:
            ICollection<UserGroupDTO> all = Locator.GetServiceNotNull<IUserGroupDTOManager>().FindAll();
            // ISSUE: reference to a compiler-generated field
            Func<UserGroupDTO, Guid> func = SecurityBAConverter.\u003C\u003Ec.\u003C\u003E9__1_0;
            Func<UserGroupDTO, Guid> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              SecurityBAConverter.\u003C\u003Ec.\u003C\u003E9__1_0 = keySelector = (Func<UserGroupDTO, Guid>) (g => g.Uid);
            }
            else
              goto label_34;
label_33:
            dictionary = all.ToDictionary<UserGroupDTO, Guid, UserGroupDTO>(keySelector, (Func<UserGroupDTO, UserGroupDTO>) (g => g));
            num1 = 5;
            continue;
label_34:
            keySelector = func;
            goto label_33;
          case 7:
            securityExportSetting.UserGroupsUids = new List<Guid>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 1 : 6;
            continue;
          case 8:
            securityExportSetting = new SecurityExportSetting();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
            continue;
          case 9:
            Contract.ArgumentNotNull((object) settings, (string) SecurityBAConverter.QEODlvwuGRi4aB2W6ye0(-1711335411 ^ -1711393887));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 8 : 6;
            continue;
          case 10:
            Contract.ArgumentNotNull((object) bpmAppManifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562610267));
            num1 = 9;
            continue;
          case 11:
            try
            {
label_4:
              if (enumerator.MoveNext())
                goto label_9;
              else
                goto label_5;
label_3:
              UserGroupDTO userGroupDto;
              UserGroupBAItem current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_19;
                  case 2:
                    securityExportSetting.UserGroupsIds.Add(userGroupDto.Id);
                    num2 = 3;
                    continue;
                  case 3:
                    securityExportSetting.UserGroupsUids.Add(SecurityBAConverter.oTE9W4wuBiK9I5DVwZbm((object) userGroupDto));
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 0 : 5;
                    continue;
                  case 4:
                    goto label_9;
                  case 5:
                    goto label_4;
                  default:
                    if (dictionary.TryGetValue(SecurityBAConverter.knmTDHwuJGf2d9puuG8C((object) current), out userGroupDto))
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_4;
                }
              }
label_5:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 1 : 1;
              goto label_3;
label_9:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0)
              {
                num2 = 0;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 12:
            securityExportSetting.UserGroupsIds = new List<long>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 7 : 2;
            continue;
          case 13:
            goto label_31;
          case 14:
label_19:
            settings.CustomSettings[SecurityExportConsts.ExportExtensionUid] = (object) securityExportSetting;
            num1 = 13;
            continue;
          default:
            SecurityBAConverter.iSr6RawuqYilwdGVgOam((object) securityExportSetting, SecurityBAConverter.wQSg9MwuvdRtZBS3JOvE((object) bpmAppManifest, SecurityBAConverter._exportOrgStructUid, securityExportSetting.ExportOrgModel));
            num1 = 2;
            continue;
        }
      }
label_31:;
    }

    public SecurityBAConverter()
    {
      SecurityBAConverter.VjLFbYwuIrShw3ormxQF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SecurityBAConverter()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SecurityBAConverter._exportUserGroupUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1780597820 ^ 1780541484));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 0 : 0;
            continue;
          case 2:
            SecurityBAConverter._exportOrgStructUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-110921701 >> 6 ^ -1792480));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 1 : 1;
            continue;
          case 3:
            SecurityBAConverter.VjLFbYwuIrShw3ormxQF();
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object QEODlvwuGRi4aB2W6ye0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void B2ivcuwuXwdtC1WECx4f([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool fHlvwfwu9lq9c6PAmnSh([In] object obj0) => ((SecurityExportSetting) obj0).ExportOrgModel;

    internal static void JDJ67swu12hKlSfxF1Qn([In] object obj0, [In] Guid obj1, [In] bool obj2) => ((BPMAppManifest) obj0).SetFlag(obj1, obj2);

    internal static bool JQLLgPwuMSxepgTWtX1O([In] object obj0) => ((SecurityExportSetting) obj0).ExportUserGroups;

    internal static void H21YqNwuhj9OauhRcvNo([In] object obj0, bool value) => ((SecurityBAChapter) obj0).ExportFullOrgstructure = value;

    internal static Guid oTE9W4wuBiK9I5DVwZbm([In] object obj0) => ((UserGroupDTO) obj0).Uid;

    internal static void itVDWlwupkX9EQC6abup([In] object obj0, [In] Guid obj1) => ((BPMAppManifestItem) obj0).Uid = obj1;

    internal static bool vSyZSxwuO4sI2KslaF7V([In] object obj0) => ((SecurityBAChapter) obj0).ExportFullOrgstructure;

    internal static int dRYN7ywuT6E3XNcbsoNC([In] object obj0) => ((List<UserGroupBAItem>) obj0).Count;

    internal static void kJpCFmwuF9ugEkBFiATi([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool nlWXB6wudFTgVgHnAwXp() => SecurityBAConverter.ODElXkwu5OVmwBUSnieL == null;

    internal static SecurityBAConverter P7ghl2wuEh5XYfOi91Vd() => SecurityBAConverter.ODElXkwu5OVmwBUSnieL;

    internal static bool wQSg9MwuvdRtZBS3JOvE([In] object obj0, [In] Guid obj1, [In] bool obj2) => ((BPMAppManifest) obj0).GetFlag(obj1, obj2);

    internal static void iSr6RawuqYilwdGVgOam([In] object obj0, bool value) => ((SecurityExportSetting) obj0).ExportOrgModel = value;

    internal static object aUudCHwugaTEHAACMajr([In] object obj0, [In] Guid obj1) => (object) ((BPMAppManifest) obj0).GetChapter(obj1);

    internal static Guid knmTDHwuJGf2d9puuG8C([In] object obj0) => ((BPMAppManifestItem) obj0).Uid;

    internal static void VjLFbYwuIrShw3ormxQF() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
