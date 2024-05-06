// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Notifications.UserTemplateGeneratorFunctions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Notifications
{
  /// <summary>Функции работы с пользователями</summary>
  [Component]
  public class UserTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
  {
    private static UserTemplateGeneratorFunctions wZsxI9lMdbOrauoNh5Q;

    /// <summary>Получить сокращенное имя пользователя</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Пользователь (IUser)
    /// 
    /// Результат:
    ///     Возвращает короткое имя пользователя (например, Иванов И. И.)
    /// 
    /// Пример:
    ///     Пусть Iniciator - переменная типа "Пользователь".
    ///     Чтобы получить сокращенное имя пользователя:
    ///     {GetUserShortName({$Iniciator})}
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue GetUserShortName(FunctionEvaluationContext context)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (context.Parameters[0] == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 5 : 0;
              continue;
            }
            user = UserTemplateGeneratorFunctions.OiDGEAlOJUp1lA6lwxC((object) context.Parameters[0]) as EleWise.ELMA.Security.Models.IUser;
            num = 6;
            continue;
          case 3:
          case 5:
            goto label_10;
          case 4:
            if (UserTemplateGeneratorFunctions.Q1QWaFlpt2TO3K4ybtT((object) context.Parameters) < 1)
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 6:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (FormatedValue) null;
label_3:
      return new FormatedValue(UserTemplateGeneratorFunctions.eLqjlolT7Jk5FdElwTV((object) user));
label_10:
      return (FormatedValue) null;
    }

    public UserTemplateGeneratorFunctions()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static int Q1QWaFlpt2TO3K4ybtT([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static object OiDGEAlOJUp1lA6lwxC([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object eLqjlolT7Jk5FdElwTV([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).GetShortName();

    internal static bool IqDfUKlhLATX0E4Wmgm() => UserTemplateGeneratorFunctions.wZsxI9lMdbOrauoNh5Q == null;

    internal static UserTemplateGeneratorFunctions DinHeflBegsaHAe4el9() => UserTemplateGeneratorFunctions.wZsxI9lMdbOrauoNh5Q;
  }
}
