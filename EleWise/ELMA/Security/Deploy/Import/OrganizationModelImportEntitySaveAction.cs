// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.OrganizationModelImportEntitySaveAction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Validation;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>
  /// 
  /// </summary>
  public class OrganizationModelImportEntitySaveAction : EntityImportSaveActions
  {
    /// <summary>UID типа сущности OrganizationModel</summary>
    public static readonly Guid UID;
    internal static OrganizationModelImportEntitySaveAction bL0ACoeru4UcksIDZVq;

    public override bool IsSupported(Guid typeGuid) => OrganizationModelImportEntitySaveAction.NObsJPey4R9SomPVr1E(typeGuid, OrganizationModelImportEntitySaveAction.UID);

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      if (propValues == null)
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227850691))));
        return false;
      }
      Guid result = Guid.Empty;
      if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362653931)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236517865)] != null)
        Guid.TryParse(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751467293 ^ -1751467967)].ToString(), out result);
      if (result == Guid.Empty)
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1207559533 ^ 1207494385))));
        return false;
      }
      IOrganizationModel organizationModel = Locator.GetServiceNotNull<OrganizationModelManager>().Load();
      if (organizationModel != null)
      {
        propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696757165)] = (object) organizationModel.Uid.ToString();
        data.ServiceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587531991) + organizationModel.Uid.ToString().ToLower(), SecurityExportConsts.ExportExtensionUidOrgstructure.ToString().ToLower());
      }
      else
        data.ServiceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1254421137 >> 4 ^ -78465824) + result.ToString().ToLower(), SecurityExportConsts.ExportExtensionUidOrgstructure.ToString().ToLower());
      return true;
    }

    public override void ExecPostSaveActions(
      IEntity entity,
      Type type,
      Dictionary<string, object> values,
      Dictionary<string, string> serviceData,
      LinksDictionary links)
    {
      OrganizationModelManager serviceNotNull = Locator.GetServiceNotNull<OrganizationModelManager>();
      IOrganizationModel organizationModel = serviceNotNull.Load();
      Logger.Log.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901719792));
      serviceNotNull.Publish(organizationModel);
      Logger.Log.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976345282));
    }

    /// <summary>
    /// Реализация тестового прохода по файлу конфигурации для чтения и проверки импортируемой оргструктуры
    /// </summary>
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 15;
      List<TestImportMessages> messages;
      IOrganizationModel organizationModel;
      OrganizationModelPublishWarning warning;
      while (true)
      {
        int num2 = num1;
        XmlReader xmlReader;
        Type type1;
        string str1;
        OrganizationSubDiagram organizationSubDiagram;
        string str2;
        OrganizationDiagram organizationDiagram;
        string str3;
        string str4;
        Type type2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (OrganizationModelImportEntitySaveAction.iYO4YyeG7pDReynyEhY((object) xmlReader.Name, OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(-1489118656 ^ 643054122 ^ -2123794452)))
              {
                num2 = 53;
                continue;
              }
              goto case 5;
            case 2:
              if (xmlReader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897230299)) == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 47 : 44;
                continue;
              }
              goto case 52;
            case 3:
label_19:
              if (organizationDiagram == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 1 : 4;
                continue;
              }
              goto case 28;
            case 4:
              goto label_87;
            case 5:
            case 10:
            case 24:
            case 47:
            case 50:
            case 58:
              OrganizationModelImportEntitySaveAction.VmqO8ke91qFgWo6kYat((object) xmlReader);
              num2 = 38;
              continue;
            case 6:
              if ((string) OrganizationModelImportEntitySaveAction.GposIHeQa62xpM5y7qW((object) xmlReader) == (string) OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(-814831182 ^ -814842758))
              {
                num2 = 35;
                continue;
              }
              goto case 37;
            case 7:
              type1 = ReflectionType.GetType(str2.Substring(0, OrganizationModelImportEntitySaveAction.hQe7i4eplQYBAf3EfVi((object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696691731))));
              num2 = 34;
              continue;
            case 8:
              OrganizationModelImportEntitySaveAction.fG1Putec24iQYbygc1t((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 24 : 11;
              continue;
            case 9:
              str2 = xmlReader.Value;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 23 : 26;
              continue;
            case 11:
              warning = (OrganizationModelPublishWarning) null;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 13 : 8;
              continue;
            case 12:
              StringBuilder stringBuilder1 = new StringBuilder((string) OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(1200636245 >> 6 ^ 18826279));
              OrganizationModelImportEntitySaveAction.t0yFa1eTNh506O7aLa2((object) stringBuilder1, (object) str2);
              str1 = stringBuilder1.ToString();
              num2 = 32;
              continue;
            case 13:
              goto label_30;
            case 14:
              OrganizationModelImportEntitySaveAction.c0ntN2efks435tdWv7E(OrganizationModelImportEntitySaveAction.PdHt52elNcMYN899CJN(OrganizationModelImportEntitySaveAction.XRM9L4eVidr5VnuRLMA((object) data)), SecurityExportConsts.ExportExtensionUidOrgstructure, (object) "");
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 14 : 29;
              continue;
            case 15:
              if (OrganizationModelImportEntitySaveAction.XRM9L4eVidr5VnuRLMA((object) data) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 5 : 14;
                continue;
              }
              goto case 29;
            case 16:
              OrganizationModelImportEntitySaveAction.I5F5XqeqnEO19FR5foI((object) organizationModel, (object) organizationSubDiagram);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 4 : 11;
              continue;
            case 17:
              xmlReader.MoveToElement();
              num2 = 9;
              continue;
            case 18:
              if (string.IsNullOrWhiteSpace(str3))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 12 : 46;
                continue;
              }
              goto case 56;
            case 19:
              organizationModel.Diagram = organizationDiagram;
              num2 = 16;
              continue;
            case 20:
              OrganizationModelImportEntitySaveAction.fG1Putec24iQYbygc1t((object) xmlReader);
              num2 = 10;
              continue;
            case 21:
              str3 = (string) OrganizationModelImportEntitySaveAction.JRIlHleOwbCoZh3Ubqf((object) str3, 0, OrganizationModelImportEntitySaveAction.hQe7i4eplQYBAf3EfVi((object) str3, OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(-909559362 ^ -398405015 ^ 562622155)));
              num2 = 48;
              continue;
            case 22:
              xmlReader.Read();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 30 : 33;
              continue;
            case 23:
            case 46:
label_22:
              if (!OrganizationModelImportEntitySaveAction.fXnb6LevRfS7SCYOm4w((object) str2))
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 25:
              try
              {
                organizationDiagram = OrganizationModelImportEntitySaveAction.kgOulyeFpkVmCai2CcQ(type2, (object) str4, true) as OrganizationDiagram;
                int num3 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_22;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_22;
                    default:
                      messages.Add(new TestImportMessages(TestImportMessagesType.Error, ex.Message));
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
            case 26:
              OrganizationModelImportEntitySaveAction.eSn45medcAiMWvD3c6B((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 6 : 8;
              continue;
            case 27:
              xmlReader.MoveToElement();
              num2 = 41;
              continue;
            case 28:
              organizationModel = OrganizationModelManager.Instance.Create();
              num2 = 19;
              continue;
            case 29:
              xmlReader = (XmlReader) OrganizationModelImportEntitySaveAction.lyZe3re4xIqCFj93C4h((object) data);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 26 : 55;
              continue;
            case 30:
              str2 = "";
              num2 = 39;
              continue;
            case 31:
            case 36:
              if (OrganizationModelImportEntitySaveAction.MlN0QLeMhJU2IXvW5OH((object) xmlReader) == XmlNodeType.EndElement)
              {
                num2 = 43;
                continue;
              }
              goto case 42;
            case 32:
              try
              {
                organizationSubDiagram = OrganizationModelImportEntitySaveAction.kgOulyeFpkVmCai2CcQ(type1, (object) str1, true) as OrganizationSubDiagram;
                int num5 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_19;
                }
              }
              catch (Exception ex)
              {
                int num6 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0)
                  num6 = 1;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      messages.Add(new TestImportMessages(TestImportMessagesType.Error, ex.Message));
                      num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_19;
                  }
                }
              }
            case 33:
              OrganizationModelImportEntitySaveAction.fG1Putec24iQYbygc1t((object) xmlReader);
              num2 = 36;
              continue;
            case 34:
              str2 = (string) OrganizationModelImportEntitySaveAction.JRIlHleOwbCoZh3Ubqf((object) str2, 0, OrganizationModelImportEntitySaveAction.hQe7i4eplQYBAf3EfVi((object) str2, OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(1841261835 ^ 1841195031)));
              num2 = 12;
              continue;
            case 35:
              if (OrganizationModelImportEntitySaveAction.heEZgNe5W4HKc87baJ1((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 15 : 37;
                continue;
              }
              goto case 2;
            case 37:
            case 40:
            case 57:
              if (!xmlReader.IsStartElement())
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 38:
              int num7 = (int) OrganizationModelImportEntitySaveAction.z9Vs3we1kFvr5WJ3ZAH((object) xmlReader);
              num2 = 31;
              continue;
            case 39:
              xmlReader.Read();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 26 : 45;
              continue;
            case 41:
              str3 = (string) OrganizationModelImportEntitySaveAction.PZK4mVeEW5TosIKYUge((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 44 : 1;
              continue;
            case 42:
              if (OrganizationModelImportEntitySaveAction.Oe1FjiePsk0rt6M3rOE((object) xmlReader))
                goto case 6;
              else
                goto label_4;
            case 43:
              organizationDiagram = (OrganizationDiagram) null;
              num2 = 54;
              continue;
            case 44:
              OrganizationModelImportEntitySaveAction.eSn45medcAiMWvD3c6B((object) xmlReader);
              num2 = 20;
              continue;
            case 45:
              OrganizationModelImportEntitySaveAction.fG1Putec24iQYbygc1t((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 7 : 22;
              continue;
            case 48:
              StringBuilder stringBuilder2 = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17837901 ^ -17902191));
              OrganizationModelImportEntitySaveAction.t0yFa1eTNh506O7aLa2((object) stringBuilder2, (object) str3);
              str4 = stringBuilder2.ToString();
              num2 = 25;
              continue;
            case 49:
              str3 = "";
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 30 : 18;
              continue;
            case 51:
              goto label_86;
            case 52:
              OrganizationModelImportEntitySaveAction.eSn45medcAiMWvD3c6B((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 8 : 27;
              continue;
            case 53:
              if (OrganizationModelImportEntitySaveAction.heEZgNe5W4HKc87baJ1((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 35 : 50;
                continue;
              }
              goto default;
            case 54:
              organizationSubDiagram = (OrganizationSubDiagram) null;
              num2 = 18;
              continue;
            case 55:
              messages = result.Messages;
              num2 = 49;
              continue;
            case 56:
              type2 = OrganizationModelImportEntitySaveAction.RwxAr3eBFEC0yioI8bW(OrganizationModelImportEntitySaveAction.rRZoYZehAfbSXQNYwh9((object) str3, 0, str3.IndexOf((string) OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(1841261835 ^ 1841195031))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 21 : 11;
              continue;
            case 59:
              OrganizationModelImportEntitySaveAction.eSn45medcAiMWvD3c6B((object) xmlReader);
              num2 = 17;
              continue;
            default:
              if (OrganizationModelImportEntitySaveAction.qeUriaeXbQT4jsNHuAF((object) xmlReader, OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(-814831182 ^ -814764878)) == null)
              {
                num2 = 58;
                continue;
              }
              goto case 59;
          }
        }
label_4:
        num1 = 57;
      }
label_87:
      return;
label_86:
      return;
label_30:
      try
      {
        OrganizationModelManager.Instance.Validate(organizationModel, out warning);
        int num8 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0)
          num8 = 0;
        switch (num8)
        {
        }
      }
      catch (OrganizationModelPublishException ex)
      {
        int num9 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0)
          num9 = 1;
        while (true)
        {
          switch (num9)
          {
            case 1:
              if (ex.mess != null)
              {
                num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_60;
            case 3:
              messages.Add(new TestImportMessages(TestImportMessagesType.Error, (string) OrganizationModelImportEntitySaveAction.FMowsyeJfGNOHXZq0cm((object) ex)));
              num9 = 2;
              continue;
            case 4:
              List<TestImportMessages> testImportMessagesList = messages;
              List<OrganizationValidationMessage> mess = ex.mess;
              // ISSUE: reference to a compiler-generated field
              Func<OrganizationValidationMessage, bool> func = OrganizationModelImportEntitySaveAction.\u003C\u003Ec.\u003C\u003E9__5_0;
              Func<OrganizationValidationMessage, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                OrganizationModelImportEntitySaveAction.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<OrganizationValidationMessage, bool>) (m => OrganizationModelImportEntitySaveAction.\u003C\u003Ec.NgEt0dwVOjUT4YyrSlF3((object) m) == OrganizationValidationMessageType.Error);
              }
              else
                goto label_101;
label_43:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              IEnumerable<TestImportMessages> collection = mess.Where<OrganizationValidationMessage>(predicate).Select<OrganizationValidationMessage, TestImportMessages>((Func<OrganizationValidationMessage, TestImportMessages>) (message => new TestImportMessages(TestImportMessagesType.Error, (string) OrganizationModelImportEntitySaveAction.\u003C\u003Ec.llLxQewVv9TP4nVhWpIs(OrganizationModelImportEntitySaveAction.\u003C\u003Ec.iv1htkwVTG8aPl3uflJ2(1124861159 ^ 1124943945), (object) new object[1]
              {
                OrganizationModelImportEntitySaveAction.\u003C\u003Ec.nmNWH5wVFi4vC2C6uXtN((object) message)
              }))));
              testImportMessagesList.AddRange(collection);
              num9 = 5;
              continue;
label_101:
              predicate = func;
              goto label_43;
            case 5:
              goto label_58;
            default:
              if (OrganizationModelImportEntitySaveAction.udL8alegTvk2rsPVNys((object) ex.mess) != 0)
              {
                num9 = 4;
                continue;
              }
              goto case 3;
          }
        }
label_60:
        return;
label_58:;
      }
      catch (Exception ex)
      {
        int num10 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0)
          num10 = 0;
        while (true)
        {
          switch (num10)
          {
            case 1:
              goto label_54;
            default:
              messages.Add(new TestImportMessages(TestImportMessagesType.Error, (string) OrganizationModelImportEntitySaveAction.FMowsyeJfGNOHXZq0cm((object) ex)));
              num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 1 : 0;
              continue;
          }
        }
label_54:;
      }
    }

    public OrganizationModelImportEntitySaveAction()
    {
      OrganizationModelImportEntitySaveAction.J4kNuZeIM6UwfRyEt4t();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static OrganizationModelImportEntitySaveAction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            OrganizationModelImportEntitySaveAction.UID = new Guid((string) OrganizationModelImportEntitySaveAction.q6P8pne8xepEVoSZIPt(-816108091 ^ -816174921));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool NObsJPey4R9SomPVr1E([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool N4CqiveS8AcYQTd7vjW() => OrganizationModelImportEntitySaveAction.bL0ACoeru4UcksIDZVq == null;

    internal static OrganizationModelImportEntitySaveAction DnYFU4eYSnOjHqE32tb() => OrganizationModelImportEntitySaveAction.bL0ACoeru4UcksIDZVq;

    internal static object XRM9L4eVidr5VnuRLMA([In] object obj0) => (object) ((ImportTestReadData) obj0).ConfigImportSettings;

    internal static object PdHt52elNcMYN899CJN([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;

    internal static object c0ntN2efks435tdWv7E([In] object obj0, [In] Guid obj1, [In] object obj2) => (object) ((BPMAppFakeManifest) obj0).GetOrCreateChapterByUid(obj1, (string) obj2);

    internal static object lyZe3re4xIqCFj93C4h([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool fG1Putec24iQYbygc1t([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool Oe1FjiePsk0rt6M3rOE([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object GposIHeQa62xpM5y7qW([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static object q6P8pne8xepEVoSZIPt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool heEZgNe5W4HKc87baJ1([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static bool eSn45medcAiMWvD3c6B([In] object obj0) => ((XmlReader) obj0).Read();

    internal static object PZK4mVeEW5TosIKYUge([In] object obj0) => (object) ((XmlReader) obj0).Value;

    internal static bool iYO4YyeG7pDReynyEhY([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object qeUriaeXbQT4jsNHuAF([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static void VmqO8ke91qFgWo6kYat([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType z9Vs3we1kFvr5WJ3ZAH([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static XmlNodeType MlN0QLeMhJU2IXvW5OH([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object rRZoYZehAfbSXQNYwh9([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static Type RwxAr3eBFEC0yioI8bW([In] object obj0) => ReflectionType.GetType((string) obj0);

    internal static int hQe7i4eplQYBAf3EfVi([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object JRIlHleOwbCoZh3Ubqf([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object t0yFa1eTNh506O7aLa2([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object kgOulyeFpkVmCai2CcQ([In] Type obj0, [In] object obj1, [In] bool obj2) => ClassSerializationHelper.DeserializeObjectByXml(obj0, (string) obj1, obj2);

    internal static bool fXnb6LevRfS7SCYOm4w([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void I5F5XqeqnEO19FR5foI([In] object obj0, [In] object obj1) => ((IOrganizationModel) obj0).SubDiagrams = (OrganizationSubDiagram) obj1;

    internal static int udL8alegTvk2rsPVNys([In] object obj0) => ((List<OrganizationValidationMessage>) obj0).Count;

    internal static object FMowsyeJfGNOHXZq0cm([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void J4kNuZeIM6UwfRyEt4t() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
