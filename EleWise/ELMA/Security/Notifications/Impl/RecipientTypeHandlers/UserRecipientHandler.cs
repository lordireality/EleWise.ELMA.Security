// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Notifications.Impl.RecipientTypeHandlers.UserRecipientHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Notifications.Impl.RecipientTypeHandlers
{
  /// <summary>
  /// Обработчик получателей оповещения для типа "Пользователь"
  /// </summary>
  [Component]
  internal class UserRecipientHandler : INotificationRecipientTypeHandler
  {
    internal static UserRecipientHandler y9eBFDlJ9M4WapF7mQD;

    /// <summary>
    /// Имя типа получателя сообщения (соответствует имени в шаблоне)
    /// </summary>
    public string Name => (string) UserRecipientHandler.qKRDUsln4X8pEZYvPxi(--180540780 ^ 180539556);

    /// <summary>Получить список получателей (пользователей)</summary>
    /// <param name="value">Значение</param>
    /// <returns>Список получателей (пользователей)</returns>
    public IEnumerable<object> GetRecipients(object value)
    {
      switch (value)
      {
        case null:
          return (IEnumerable<object>) new object[0];
        case IEnumerable enumerable:
          List<object> recipients = new List<object>();
          foreach (object obj in enumerable)
          {
            if (obj is IUser)
              recipients.Add((object) (IUser) obj);
          }
          return (IEnumerable<object>) recipients;
        case IUser _:
          if (!(value is IUser))
            return (IEnumerable<object>) new object[0];
          return (IEnumerable<object>) new object[1]
          {
            value
          };
        default:
          throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1567399832 << 6 ^ 1529322240), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123784958));
      }
    }

    public UserRecipientHandler()
    {
      UserRecipientHandler.y5h2S0lL3hIyAaOl8Lt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object qKRDUsln4X8pEZYvPxi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool uYCytglI4E1NlNeAkpO() => UserRecipientHandler.y9eBFDlJ9M4WapF7mQD == null;

    internal static UserRecipientHandler ujypr3lehHS7sCVaKEn() => UserRecipientHandler.y9eBFDlJ9M4WapF7mQD;

    internal static void y5h2S0lL3hIyAaOl8Lt() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
