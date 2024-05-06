// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Deploy.Import.UserGroupImportEntitySaveAction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Security.Deploy.Import
{
  /// <summary>
  /// 
  /// </summary>
  public class UserGroupImportEntitySaveAction : EntityImportSaveActions
  {
    /// <summary>UID типа сущности UserGroup</summary>
    public static readonly Guid UID;
    private static UserGroupImportEntitySaveAction ArsXg2I9SASekryCIQl;

    public override bool IsSupported(Guid typeGuid) => UserGroupImportEntitySaveAction.zLRkZkIhsZ0Tc8B8NAG(typeGuid, UserGroupImportEntitySaveAction.UID);

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      string uidPropName = InterfaceActivator.PropertyName<IUserGroup>((Expression<Func<IUserGroup, object>>) (userGroup => (object) userGroup.Uid));
      if (propValues.ContainsKey(uidPropName))
      {
        string key = InterfaceActivator.PropertyName<IUserGroup>((Expression<Func<IUserGroup, object>>) (userGroup => userGroup.Users));
        if (propValues.ContainsKey(key) && ModelHelper.GetEntityManager(UserGroupImportEntitySaveAction.UID).LoadOrNull(Guid.Parse(propValues[uidPropName] as string)) is IUserGroup userGroup1)
        {
          SerializableList<object> propValue = propValues[key] as SerializableList<object>;
          foreach (EleWise.ELMA.Security.Models.IUser user in (IEnumerable<EleWise.ELMA.Security.Models.IUser>) userGroup1.Users)
          {
            string userStringUid = user.Uid.ToString();
            SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
            serializableDictionary.Add(uidPropName, (object) userStringUid);
            // ISSUE: reference to a compiler-generated method
            if (propValue.FirstOrDefault<object>((Func<object, bool>) (it => UserGroupImportEntitySaveAction.\u003C\u003Ec__DisplayClass2_1.ut40EewVEPuYhNxMTbGn((object) ((it as SerializableDictionary<string, object>)[uidPropName] as string), (object) userStringUid))) == null)
              propValue.Add((object) serializableDictionary);
          }
          propValues[key] = (object) propValue;
        }
      }
      return base.CanBeSaved(propValues, data);
    }

    /// <summary>
    /// 
    /// </summary>
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 24;
      while (true)
      {
        int num2 = num1;
        XmlReader xmlReader;
        Guid result1;
        string title;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Guid.TryParse(xmlReader.ReadString(), out result1);
              num2 = 17;
              continue;
            case 2:
            case 3:
              if (UserGroupImportEntitySaveAction.jsHlBSIzfg26LsYv0PX((object) xmlReader) == XmlNodeType.EndElement)
              {
                num2 = 13;
                continue;
              }
              goto case 8;
            case 4:
              goto label_25;
            case 5:
              object obj1 = UserGroupImportEntitySaveAction.d7RgQJIvcr2ZVWpAT8k((object) xmlReader);
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) UserGroupImportEntitySaveAction.MnkPEwIJgvhxGL8GX1V(UserGroupImportEntitySaveAction.SC05hSIq5CepAofQ8yH(__typeref (IUserGroup)), UserGroupImportEntitySaveAction.uPeyBZIge8VXiDjCnLP(-1880054609 ^ -1879988733));
              // ISSUE: method reference
              string str1 = LinqUtils.NameOf<IUserGroup>(Expression.Lambda<Func<IUserGroup, object>>((Expression) UserGroupImportEntitySaveAction.iFbPElIeEU8PSWodsKY((object) parameterExpression1, (object) (MethodInfo) UserGroupImportEntitySaveAction.VCdJWgII0UKallXYx7O(__methodref (IUserGroup.get_Name))), parameterExpression1));
              if (UserGroupImportEntitySaveAction.mOYRETInH9LCfiRaHuK(obj1, (object) str1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 25 : 10;
                continue;
              }
              goto case 15;
            case 6:
              UserGroupImportEntitySaveAction.lxfea9ITfXU1uWbJKUB((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 28 : 6;
              continue;
            case 7:
              title = "";
              num2 = 9;
              continue;
            case 8:
              if (!UserGroupImportEntitySaveAction.owO8S7IFALNixSMvsAL((object) xmlReader))
              {
                num2 = 15;
                continue;
              }
              goto case 5;
            case 9:
              xmlReader.Read();
              num2 = 4;
              continue;
            case 10:
              goto label_30;
            case 11:
            case 14:
            case 22:
              xmlReader.Skip();
              num2 = 21;
              continue;
            case 12:
              UserGroupImportEntitySaveAction.gJpkplIOvo43POL8NNE((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 1;
              continue;
            case 13:
              if (UserGroupImportEntitySaveAction.S13XTaeuWnxaotVlweo(result1, new Guid()))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 8 : 20;
                continue;
              }
              goto label_28;
            case 15:
            case 29:
            case 30:
              if (!xmlReader.IsStartElement())
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 7 : 14;
                continue;
              }
              goto case 18;
            case 16:
              result1 = Guid.Empty;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 7 : 0;
              continue;
            case 17:
              UserGroupImportEntitySaveAction.lxfea9ITfXU1uWbJKUB((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 11 : 7;
              continue;
            case 18:
              object obj2 = UserGroupImportEntitySaveAction.d7RgQJIvcr2ZVWpAT8k((object) xmlReader);
              ParameterExpression parameterExpression2 = (ParameterExpression) UserGroupImportEntitySaveAction.MnkPEwIJgvhxGL8GX1V(typeof (IUserGroup), UserGroupImportEntitySaveAction.uPeyBZIge8VXiDjCnLP(-296013529 ^ -296078453));
              // ISSUE: method reference
              // ISSUE: type reference
              string str2 = LinqUtils.NameOf<IUserGroup>(Expression.Lambda<Func<IUserGroup, object>>((Expression) UserGroupImportEntitySaveAction.IQy0ucIHpdmgdeyw6js((object) Expression.Property((Expression) parameterExpression2, (MethodInfo) UserGroupImportEntitySaveAction.VCdJWgII0UKallXYx7O(__methodref (IUserGroup.get_Uid))), UserGroupImportEntitySaveAction.SC05hSIq5CepAofQ8yH(__typeref (object))), parameterExpression2));
              if (UserGroupImportEntitySaveAction.mOYRETInH9LCfiRaHuK(obj2, (object) str2))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 19:
              goto label_21;
            case 20:
              goto label_35;
            case 21:
              int content = (int) xmlReader.MoveToContent();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 2 : 2;
              continue;
            case 23:
              xmlReader = (XmlReader) UserGroupImportEntitySaveAction.gkgGdiIpLGdgk7gjIgE((object) data);
              num2 = 16;
              continue;
            case 24:
              if (UserGroupImportEntitySaveAction.oFdUrmIB2KsyxWJitio((object) data) != null)
              {
                num2 = 23;
                continue;
              }
              goto label_18;
            case 25:
              if (UserGroupImportEntitySaveAction.b4NMi1ILnuiXyjSIdKV((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 30 : 8;
                continue;
              }
              goto case 26;
            case 26:
              UserGroupImportEntitySaveAction.gJpkplIOvo43POL8NNE((object) xmlReader);
              num2 = 19;
              continue;
            case 27:
              UserGroupImportEntitySaveAction.lxfea9ITfXU1uWbJKUB((object) xmlReader);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 22 : 4;
              continue;
            case 28:
              UserGroupImportEntitySaveAction.gJpkplIOvo43POL8NNE((object) xmlReader);
              num2 = 3;
              continue;
            default:
              if (UserGroupImportEntitySaveAction.b4NMi1ILnuiXyjSIdKV((object) xmlReader))
                goto case 11;
              else
                goto label_24;
          }
        }
label_21:
        title = (string) UserGroupImportEntitySaveAction.JjDajGI2r4O0VwpHyTk((object) xmlReader);
        num1 = 27;
        continue;
label_24:
        num1 = 12;
        continue;
label_25:
        UserGroupImportEntitySaveAction.gJpkplIOvo43POL8NNE((object) xmlReader);
        num1 = 6;
        continue;
label_35:
        ((BPMAppManifestFakeChapter) UserGroupImportEntitySaveAction.ArAYoCeb3OVsljOxUac(UserGroupImportEntitySaveAction.zigscLewTQXG2SO0PUn(UserGroupImportEntitySaveAction.oFdUrmIB2KsyxWJitio((object) data)), SecurityExportConsts.ExportExtensionUidUserGroup, (object) "")).GetOrCreateItemByUid(result1, title);
        num1 = 10;
      }
label_30:
      return;
label_28:
      return;
label_18:;
    }

    public UserGroupImportEntitySaveAction()
    {
      UserGroupImportEntitySaveAction.XUOHTveKsdUJreJtjTm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UserGroupImportEntitySaveAction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            UserGroupImportEntitySaveAction.XUOHTveKsdUJreJtjTm();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            UserGroupImportEntitySaveAction.UID = InterfaceActivator.UID<IUserGroup>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool zLRkZkIhsZ0Tc8B8NAG([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool JUyDGdI1rKYKTjjmBRU() => UserGroupImportEntitySaveAction.ArsXg2I9SASekryCIQl == null;

    internal static UserGroupImportEntitySaveAction UWw4ReIMPD8uHSIet8J() => UserGroupImportEntitySaveAction.ArsXg2I9SASekryCIQl;

    internal static object oFdUrmIB2KsyxWJitio([In] object obj0) => (object) ((ImportTestReadData) obj0).ConfigImportSettings;

    internal static object gkgGdiIpLGdgk7gjIgE([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool gJpkplIOvo43POL8NNE([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool lxfea9ITfXU1uWbJKUB([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool owO8S7IFALNixSMvsAL([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object d7RgQJIvcr2ZVWpAT8k([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static Type SC05hSIq5CepAofQ8yH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object uPeyBZIge8VXiDjCnLP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MnkPEwIJgvhxGL8GX1V([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object VCdJWgII0UKallXYx7O([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object iFbPElIeEU8PSWodsKY([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool mOYRETInH9LCfiRaHuK([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool b4NMi1ILnuiXyjSIdKV([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object JjDajGI2r4O0VwpHyTk([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static object IQy0ucIHpdmgdeyw6js([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static XmlNodeType jsHlBSIzfg26LsYv0PX([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool S13XTaeuWnxaotVlweo([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object zigscLewTQXG2SO0PUn([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;

    internal static object ArAYoCeb3OVsljOxUac([In] object obj0, [In] Guid obj1, [In] object obj2) => (object) ((BPMAppFakeManifest) obj0).GetOrCreateChapterByUid(obj1, (string) obj2);

    internal static void XUOHTveKsdUJreJtjTm() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
