// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Export.SecurityExportExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Deploy.Export
{
  /// <summary>
  /// Расширение экспорта конфигурации для объектов Security
  /// </summary>
  [Component(Order = 100)]
  public class SecurityExportExtension : IConfigExportExtension
  {
    /// <summary>Билдер кастомных правил</summary>
    private ExportRuleBuilder<IUserGroup> customGroupExportRuleBuilder;
    private ExportRuleBuilder<IOrganizationModel> customOrgExportRuleBuilder;
    internal static SecurityExportExtension mgKqTHIreiaBTcvM6Rf;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        SecurityExportConsts.ExportExtensionUid,
        (object) new SecurityExportSetting()
      }
    };

    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AddCustomRules();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.AddExportObjectsCustom(parameters.Parameters, parameters.ServiceData, parameters.PacketEntities);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    private void AddCustomRules()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.customOrgExportRuleBuilder = new ExportRuleBuilder<IOrganizationModel>(new ExportRuleList());
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 3;
            continue;
          case 2:
            this.customGroupExportRuleBuilder = new ExportRuleBuilder<IUserGroup>(new ExportRuleList());
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 1 : 1;
            continue;
          case 3:
            ParameterExpression parameterExpression;
            // ISSUE: method reference
            SecurityExportExtension.MsmlYPIlJOShg4OqasK((object) this.customOrgExportRuleBuilder.Rule().ForPropertyName(Expression.Lambda<Func<IOrganizationModel, object>>((Expression) SecurityExportExtension.lVdkPIIVoHv4RT61tF4((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IOrganizationModel.get_Name))), parameterExpression)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    private void AddExportObjectsCustom(
      Dictionary<Guid, object> parameters,
      Dictionary<string, object> serviceData,
      List<PacketEntity> packetEntities)
    {
      if (!(parameters[SecurityExportConsts.ExportExtensionUid] is SecurityExportSetting parameter))
        return;
      bool exportOrgModel = parameter.ExportOrgModel;
      bool exportUserGroups = parameter.ExportUserGroups;
      ICollection<IUserGroup> all1 = Locator.GetServiceNotNull<UserGroupManager>().FindAll();
      if (all1 != null)
      {
        foreach (IUserGroup userGroup in (IEnumerable<IUserGroup>) all1)
          serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(386642440 ^ 386576430) + (object) userGroup.Id, (object) userGroup.Uid);
      }
      if (exportOrgModel)
        this.AddOrgModel(packetEntities);
      ICollection<IOrganizationItem> all2 = Locator.GetServiceNotNull<OrganizationItemManager>().FindAll();
      if (all2 != null)
      {
        foreach (IOrganizationItem organizationItem in (IEnumerable<IOrganizationItem>) all2)
          serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124927193) + (object) organizationItem.Id, (object) organizationItem.Uid);
      }
      if (!exportUserGroups)
        return;
      this.AddUserGroups(packetEntities, parameter);
    }

    /// <summary>Получить список сущностей для экспортируемого отчета</summary>
    /// <param name="group">Группа пользователей</param>
    /// <returns></returns>
    private List<IEntity> GetGroupsEntities(IUserGroup group)
    {
      ExportHelperBuilder<IUserGroup> exportHelperBuilder = ExportHelperBuilder.Create<IUserGroup>(group);
      exportHelperBuilder.ExportRuleList = this.customGroupExportRuleBuilder.ExportRules;
      return exportHelperBuilder.EntityExportList();
    }

    /// <summary>Добавляется пакеты выбранных групп</summary>
    /// <param name="packetEntities"></param>
    /// <param name="securityExportSetting"></param>
    private void AddUserGroups(
      List<PacketEntity> packetEntities,
      SecurityExportSetting securityExportSetting)
    {
      foreach (IUserGroup group in (IEnumerable<IUserGroup>) this.GetGroups(securityExportSetting))
      {
        PacketEntity packetEntity = new PacketEntity((IEntity) group);
        packetEntity.ExportRules = this.customGroupExportRuleBuilder.ExportRules;
        foreach (IEntity groupsEntity in this.GetGroupsEntities(group))
          packetEntity.SubEntities.Add(groupsEntity);
        packetEntities.Add(packetEntity);
      }
    }

    private ICollection<IUserGroup> GetGroups(
      SecurityExportSetting securityExportSetting)
    {
      UserGroupManager serviceNotNull = Locator.GetServiceNotNull<UserGroupManager>();
      List<IUserGroup> groups = new List<IUserGroup>();
      HashSet<Guid> guidSet = new HashSet<Guid>();
      foreach (long userGroupsId in securityExportSetting.UserGroupsIds)
      {
        IUserGroup userGroup = serviceNotNull.Load(userGroupsId);
        groups.Add(userGroup);
        guidSet.Add(userGroup.Uid);
      }
      foreach (Guid userGroupsUid in securityExportSetting.UserGroupsUids)
      {
        if (!guidSet.Contains(userGroupsUid))
        {
          IUserGroup userGroup = serviceNotNull.Load(userGroupsUid);
          groups.Add(userGroup);
          guidSet.Add(userGroup.Uid);
        }
      }
      return (ICollection<IUserGroup>) groups;
    }

    /// <summary>Получить список сущностей для экспортируемого отчета</summary>
    /// <param name="model"></param>
    /// <returns></returns>
    private List<IEntity> GetOrgEntities(IOrganizationModel model)
    {
      ExportHelperBuilder<IOrganizationModel> exportHelperBuilder = ExportHelperBuilder.Create<IOrganizationModel>(model);
      exportHelperBuilder.ExportRuleList = this.customOrgExportRuleBuilder.ExportRules;
      return exportHelperBuilder.EntityExportList();
    }

    /// <summary>Добавляется пакет оргмодели</summary>
    /// <param name="packetEntities"></param>
    private void AddOrgModel(List<PacketEntity> packetEntities)
    {
      IOrganizationModel model = Locator.GetServiceNotNull<OrganizationModelManager>().LoadPublishedOrNull();
      if (model == null)
        return;
      PacketEntity packetEntity = new PacketEntity((IEntity) model);
      packetEntity.ExportRules = this.customOrgExportRuleBuilder.ExportRules;
      foreach (IEntity orgEntity in this.GetOrgEntities(model))
        packetEntity.SubEntities.Add(orgEntity);
      packetEntities.Add(packetEntity);
    }

    public SecurityExportExtension()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.customGroupExportRuleBuilder = new ExportRuleBuilder<IUserGroup>(new ExportRuleList());
      this.customOrgExportRuleBuilder = new ExportRuleBuilder<IOrganizationModel>(new ExportRuleList());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ByV3TMISba5yhUE6Pcu() => SecurityExportExtension.mgKqTHIreiaBTcvM6Rf == null;

    internal static SecurityExportExtension Sm9U4dIYvCYdg9NS82N() => SecurityExportExtension.mgKqTHIreiaBTcvM6Rf;

    internal static object esMJAWIyC4FsSmWmShU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lVdkPIIVoHv4RT61tF4([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static void MsmlYPIlJOShg4OqasK([In] object obj0) => ((ExportRuleBuilderSelectAction<IOrganizationModel>) obj0).Ignore();
  }
}
