// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.FormHeaderImportSaveActions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>Действия для импорта заголовка формы</summary>
  public class FormHeaderImportSaveActions : EntityImportSaveActions
  {
    public static readonly Guid UID;
    internal static FormHeaderImportSaveActions ALATU5IfdEHAAUOdyvE;

    public override bool IsSupported(Guid typeGuid) => FormHeaderImportSaveActions.DLCycUIPDkG37MQJEdV(typeGuid, FormHeaderImportSaveActions.UID);

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      string key = LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.CreationAuthorId));
      if (propValues.ContainsKey(key) && propValues[key] != null)
      {
        EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
        if (user != null)
          propValues[key] = (object) user.Id;
      }
      return true;
    }

    public FormHeaderImportSaveActions()
    {
      FormHeaderImportSaveActions.O5O5lTIQye0as0S94yW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FormHeaderImportSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormHeaderImportSaveActions.UID = new Guid((string) FormHeaderImportSaveActions.r0kEMgI8Lgvs3U9amaf(1690569372 >> 6 ^ 26350194));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 0;
            continue;
          case 2:
            FormHeaderImportSaveActions.O5O5lTIQye0as0S94yW();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool DLCycUIPDkG37MQJEdV([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool X0sHguI4a6RSZ3Q0MDU() => FormHeaderImportSaveActions.ALATU5IfdEHAAUOdyvE == null;

    internal static FormHeaderImportSaveActions XqMph3IcWsChRbU79HL() => FormHeaderImportSaveActions.ALATU5IfdEHAAUOdyvE;

    internal static void O5O5lTIQye0as0S94yW() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object r0kEMgI8Lgvs3U9amaf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
