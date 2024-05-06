// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Components.SecurityChapterBuilder
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Components;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.BPMApps;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Deploy.Components
{
  /// <summary>
  /// Расширение формирования раздела объектов безопасности BPM App
  /// </summary>
  [Component(Order = 100)]
  internal sealed class SecurityChapterBuilder : BPMAppChapterBuilder
  {
    private readonly UserGroupManager userGroupManager;
    internal static SecurityChapterBuilder hTVcgAezs2uOSf23RVI;

    /// <summary>Ctor</summary>
    /// <param name="userGroupManager">Менеджер групп пользователей</param>
    public SecurityChapterBuilder(UserGroupManager userGroupManager)
    {
      SecurityChapterBuilder.s9HFuanbD70a5b5xHxD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.userGroupManager = userGroupManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    protected override IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate> BuilderTemplate => (IEnumerable<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>) new List<BPMAppChapterBuilder.BPMAppChapterBuilderTemplate>()
    {
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(SecurityExportConsts.ExportExtensionUidUserGroup, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272586539)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(631805505 ^ 631870379)),
      new BPMAppChapterBuilder.BPMAppChapterBuilderTemplate(SecurityExportConsts.ExportExtensionUidOrgstructure, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788783669 - 1293477238 ^ 1212771245)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550699652))
    };

    /// <inheritdoc />
    public override IEnumerable<DeployTreeNode> GetChapterNodes(
      BPMAppManifest manifest,
      IChapterParameters parameters)
    {
      Contract.ArgumentNotNull((object) manifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053124727));
      List<DeployTreeNode> chapterNodes = new List<DeployTreeNode>();
      DeployTreeNode node1 = this.CreateNode(SecurityExportConsts.ExportExtensionUidOrgstructure.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534172473)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-404268492 ^ -404333544));
      DeployTreeNode node2 = this.CreateNode(SecurityExportConsts.ExportExtensionUidUserGroup.ToString(), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--353012470 ^ 353079112)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053125539));
      if (!(manifest.GetChapter(SecurityExportConsts.ExportExtensionUid) is SecurityBAChapter chapter) || !chapter.ExportFullOrgstructure && (chapter.UserGroups == null || chapter.UserGroups.Count == 0))
      {
        if (parameters.WithEmptyChapters)
        {
          chapterNodes.Add(node1);
          chapterNodes.Add(node2);
        }
        return (IEnumerable<DeployTreeNode>) chapterNodes;
      }
      if (chapter.ExportFullOrgstructure)
      {
        node1.Children.Add(this.CreateNode(node1.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224767710), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081702110)), ""));
        node1.Count = node1.Children.Count;
        chapterNodes.Add(node1);
      }
      else if (parameters.WithEmptyChapters)
        chapterNodes.Add(node1);
      if (chapter.UserGroups != null && chapter.UserGroups.Count > 0)
      {
        List<DeployTreeNode> source = new List<DeployTreeNode>();
        foreach (UserGroupBAItem userGroup1 in chapter.UserGroups)
        {
          IUserGroup userGroup2 = this.userGroupManager.LoadOrNull(userGroup1.Uid);
          if (userGroup2 != null)
            source.Add(this.CreateNode(userGroup1.Uid.ToString(), userGroup2.Name, ""));
        }
        if (parameters.WithEmptyChapters || source.Count > 0)
        {
          node2.Children.AddRange<DeployTreeNode>((IEnumerable<DeployTreeNode>) source.OrderBy<DeployTreeNode, string>((Func<DeployTreeNode, string>) (n => n.Text), (IComparer<string>) StringComparer.CurrentCultureIgnoreCase));
          node2.Count = node2.Children.Count;
          chapterNodes.Add(node2);
        }
      }
      return (IEnumerable<DeployTreeNode>) chapterNodes;
    }

    internal static void s9HFuanbD70a5b5xHxD() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool JmAwX1nuLNjIn5UiiaG() => SecurityChapterBuilder.hTVcgAezs2uOSf23RVI == null;

    internal static SecurityChapterBuilder Tpj9Nunwa4VnwnBjKc2() => SecurityChapterBuilder.hTVcgAezs2uOSf23RVI;
  }
}
