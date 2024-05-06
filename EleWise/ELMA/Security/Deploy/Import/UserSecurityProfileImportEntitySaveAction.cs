// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.UserSecurityProfileImportEntitySaveAction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>
  /// Действия, выполняемые при сохранении сущности Профиль безопасности пользователя
  /// </summary>
  internal class UserSecurityProfileImportEntitySaveAction : EntityImportSaveActions
  {
    /// <summary>UID типа сущности User</summary>
    public static readonly Guid UID;
    internal static UserSecurityProfileImportEntitySaveAction XJhlXlejsVs6cNGogfp;

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == UserSecurityProfileImportEntitySaveAction.UID;

    /// <inheritdoc />
    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      return false;
    }

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        XmlReader reader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              UserSecurityProfileImportEntitySaveAction.GB0SwHeAU7sjWUBisDn((object) reader);
              num2 = 9;
              continue;
            case 2:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) UserSecurityProfileImportEntitySaveAction.K9NC9Me7TbV9rbNw42i(-819366706 ^ -819431812))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 3 : 5;
              continue;
            case 3:
              reader.Read();
              num2 = 8;
              continue;
            case 4:
              reader = data.Reader;
              num2 = 3;
              continue;
            case 5:
              goto label_13;
            case 6:
              UserSecurityProfileImportEntitySaveAction.l3GHj3eZK55XX4fp2dG((object) reader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 1 : 1;
              continue;
            case 7:
              int content = (int) reader.MoveToContent();
              num2 = 10;
              continue;
            case 8:
              reader.MoveToElement();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 3 : 6;
              continue;
            case 9:
            case 10:
              if (UserSecurityProfileImportEntitySaveAction.VhGbQhesKQbtuVR8en7((object) reader) == XmlNodeType.EndElement)
              {
                num2 = 2;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        reader.Skip();
        num1 = 7;
      }
label_13:;
    }

    /// <inheritdoc />
    public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
    {
    }

    public UserSecurityProfileImportEntitySaveAction()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UserSecurityProfileImportEntitySaveAction()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserSecurityProfileImportEntitySaveAction.UID = InterfaceActivator.UID<IUserSecurityProfile>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
            continue;
          case 2:
            UserSecurityProfileImportEntitySaveAction.pneow3eWjUMLw4k3lMf();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool bItfIBeN2SwgIgW0k5Z() => UserSecurityProfileImportEntitySaveAction.XJhlXlejsVs6cNGogfp == null;

    internal static UserSecurityProfileImportEntitySaveAction WkX9Wae0bX58SpAj1OE() => UserSecurityProfileImportEntitySaveAction.XJhlXlejsVs6cNGogfp;

    internal static bool l3GHj3eZK55XX4fp2dG([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool GB0SwHeAU7sjWUBisDn([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static XmlNodeType VhGbQhesKQbtuVR8en7([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object K9NC9Me7TbV9rbNw42i(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void pneow3eWjUMLw4k3lMf() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
