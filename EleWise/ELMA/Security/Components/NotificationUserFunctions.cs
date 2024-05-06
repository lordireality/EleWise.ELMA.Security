// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.NotificationUserFunctions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Функции для отображения в шаблоне данных пользователя</summary>
  [Component]
  public class NotificationUserFunctions : INotificationFunctions
  {
    internal static NotificationUserFunctions Kur0tUH2D1wJGCgbCw7;

    /// <summary>
    /// Генерирует строку из короткого имени пользователя.
    /// Параметр 1 - Пользователь.
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue UserShortName(FunctionEvaluationContext context)
    {
      int num = 1;
      NotificationUserFunctions.UserField userField;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationUserFunctions.ExtractUserField((object) context, out userField);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (FormatedValue) NotificationUserFunctions.wAXKWQzuwvG3AUQ7v91((object) context, userField);
    }

    private static FormatedValue GenerateUserShortName(
      object context,
      NotificationUserFunctions.UserField userField)
    {
      int num = 4;
      StringBuilder stringBuilder;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationUserFunctions.yZvsaTzRQ5cPa6FIMlE((object) stringBuilder, (object) userField.ShortName);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 1 : 2;
            continue;
          case 3:
            NotificationUserFunctions.yZvsaTzRQ5cPa6FIMlE((object) stringBuilder, NotificationUserFunctions.v5jRjczULQ3cVGbKSGD(NotificationUserFunctions.pHjJXAzKMN2YevNjGcC(1780597820 ^ 1780539208), (object) str, (object) userField.Id, (object) userField.ShortName));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 0 : 0;
            continue;
          case 4:
            int renderMode = (int) ((GenerationContext) NotificationUserFunctions.xbOG8mzwZ8Drn9Ue0ac(context)).GetRenderMode();
            str = "";
            if (Locator.Initialized)
            {
              CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
              if (service != null)
                str = (string) NotificationUserFunctions.FwYah1zbVgeVUQ6tjvb((object) service.Settings);
            }
            stringBuilder = new StringBuilder();
            if (renderMode == 1)
            {
              num = 3;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      return new FormatedValue((object) new HtmlString(stringBuilder.ToString()));
    }

    private static void ExtractUserField(
      object context,
      out NotificationUserFunctions.UserField userField)
    {
      int num = 4;
      while (true)
      {
        EleWise.ELMA.Security.Models.IUser user;
        FormatedValue formatedValue1;
        FormatedValue formatedValue2;
        switch (num)
        {
          case 1:
            if (formatedValue1 == null)
            {
              num = 8;
              continue;
            }
            user = NotificationUserFunctions.HVSalLzt2ZPPrdto8qv((object) formatedValue1) as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 2;
            continue;
          case 2:
            if (user != null)
            {
              userField = new NotificationUserFunctions.UserField()
              {
                Id = user.Id.ToString(),
                ShortName = (string) NotificationUserFunctions.ihHF50zmTG0oHUrj0Rf((object) user)
              };
              num = 5;
              continue;
            }
            num = 6;
            continue;
          case 3:
            if (NotificationUserFunctions.IEoaTvzoRaaYVP3Muy7((object) ((FunctionEvaluationContext) context).Parameters) >= 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 4:
            userField = new NotificationUserFunctions.UserField();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 1 : 3;
            continue;
          case 5:
            goto label_2;
          case 6:
            goto label_12;
          case 7:
            formatedValue2 = (FormatedValue) null;
            break;
          case 8:
            goto label_10;
          default:
            formatedValue2 = ((FunctionEvaluationContext) context).Parameters[0];
            break;
        }
        formatedValue1 = formatedValue2;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 1 : 0;
      }
label_2:
      return;
label_12:
      return;
label_10:;
    }

    public NotificationUserFunctions()
    {
      NotificationUserFunctions.Q9Of3fz6GcKVNJ517TL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object wAXKWQzuwvG3AUQ7v91(
      [In] object obj0,
      NotificationUserFunctions.UserField userField)
    {
      return (object) NotificationUserFunctions.GenerateUserShortName(obj0, userField);
    }

    internal static bool QWcCvKHHWokglL2LeUj() => NotificationUserFunctions.Kur0tUH2D1wJGCgbCw7 == null;

    internal static NotificationUserFunctions B4c4kyHzIFyKBJvy7Qy() => NotificationUserFunctions.Kur0tUH2D1wJGCgbCw7;

    internal static object xbOG8mzwZ8Drn9Ue0ac([In] object obj0) => (object) ((FunctionEvaluationContext) obj0).GenerationContext;

    internal static object FwYah1zbVgeVUQ6tjvb([In] object obj0) => (object) ((CommonSettings) obj0).ApplicationBaseUrl;

    internal static object pHjJXAzKMN2YevNjGcC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object v5jRjczULQ3cVGbKSGD([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object yZvsaTzRQ5cPa6FIMlE([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int IEoaTvzoRaaYVP3Muy7([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static object HVSalLzt2ZPPrdto8qv([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object ihHF50zmTG0oHUrj0Rf([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).GetShortName();

    internal static void Q9Of3fz6GcKVNJ517TL() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    private struct UserField
    {
      internal static object EwVYnswl6IkotqniQPgZ;

      public string Id
      {
        get => this.\u003CId\u003Ek__BackingField;
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
                this.\u003CId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 0 : 0;
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

      public string ShortName
      {
        get => this.\u003CShortName\u003Ek__BackingField;
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
                this.\u003CShortName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
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

      internal static bool uKb1opwlktMiGlyeNYAF() => NotificationUserFunctions.UserField.EwVYnswl6IkotqniQPgZ == null;

      internal static object QlCa0ywlDJu1SnaHm2SJ() => NotificationUserFunctions.UserField.EwVYnswl6IkotqniQPgZ;
    }
  }
}
