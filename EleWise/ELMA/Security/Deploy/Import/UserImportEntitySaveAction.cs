// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.UserImportEntitySaveAction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>
  /// Действия, выполняемые при сохранении сущности Пользователь
  /// </summary>
  internal class UserImportEntitySaveAction : EntityImportSaveActions
  {
    /// <summary>UID типа сущности User</summary>
    public static readonly Guid UID;
    internal static UserImportEntitySaveAction Q9ILDseUv9EQKZYaNqU;

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => UserImportEntitySaveAction.LJ0Fyjet5gfWwVXonP7(typeGuid, UserImportEntitySaveAction.UID);

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
      int num1 = 9;
      XmlReader xmlReader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            int num2 = (int) UserImportEntitySaveAction.D0DghTeae25MIG8aKfu((object) xmlReader);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 3 : 2;
            continue;
          case 2:
            UserImportEntitySaveAction.a67GCKe6tg93dpVmMQU((object) xmlReader);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 5 : 3;
            continue;
          case 3:
          case 5:
            if (UserImportEntitySaveAction.vE8QjQex9FBOAFrZObO((object) xmlReader) == XmlNodeType.EndElement)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 4:
            UserImportEntitySaveAction.Jjt9TVekCBEULJ5P672((object) xmlReader);
            num1 = 2;
            continue;
          case 6:
            UserImportEntitySaveAction.ztFLqUeDVhXFyZ7vo4K((object) xmlReader);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 1 : 1;
            continue;
          case 7:
            goto label_4;
          case 8:
            xmlReader.Read();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 10 : 8;
            continue;
          case 9:
            xmlReader = (XmlReader) UserImportEntitySaveAction.LsnomeemayIdf2DR52i((object) data);
            num1 = 8;
            continue;
          case 10:
            UserImportEntitySaveAction.a67GCKe6tg93dpVmMQU((object) xmlReader);
            num1 = 4;
            continue;
          default:
            result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, (string) UserImportEntitySaveAction.w5geJbeiGQOkPMyWqBH(UserImportEntitySaveAction.vhnLrXeCxFgvmjCKOSK(-315619370 - -1325004768 ^ 1009319172))));
            num1 = 7;
            continue;
        }
      }
label_4:;
    }

    /// <inheritdoc />
    public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
    {
    }

    public UserImportEntitySaveAction()
    {
      UserImportEntitySaveAction.PFCuVGe30tjZ56JtgYl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UserImportEntitySaveAction()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserImportEntitySaveAction.UID = InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 0 : 0;
            continue;
          case 2:
            UserImportEntitySaveAction.PFCuVGe30tjZ56JtgYl();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool LJ0Fyjet5gfWwVXonP7([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool TKu3bZeRyKHjAiPPBPK() => UserImportEntitySaveAction.Q9ILDseUv9EQKZYaNqU == null;

    internal static UserImportEntitySaveAction Y5JPGleofHHkALrb1bH() => UserImportEntitySaveAction.Q9ILDseUv9EQKZYaNqU;

    internal static object LsnomeemayIdf2DR52i([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool a67GCKe6tg93dpVmMQU([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool Jjt9TVekCBEULJ5P672([In] object obj0) => ((XmlReader) obj0).Read();

    internal static void ztFLqUeDVhXFyZ7vo4K([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType D0DghTeae25MIG8aKfu([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static XmlNodeType vE8QjQex9FBOAFrZObO([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object vhnLrXeCxFgvmjCKOSK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object w5geJbeiGQOkPMyWqBH([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void PFCuVGe30tjZ56JtgYl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
