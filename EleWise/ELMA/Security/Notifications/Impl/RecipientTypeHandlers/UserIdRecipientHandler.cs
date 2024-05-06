// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Notifications.Impl.RecipientTypeHandlers.UserIdRecipientHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Notifications.Impl.RecipientTypeHandlers
{
  /// <summary>
  /// Обработчик получателей оповещения для типа "Id пользователя"
  /// </summary>
  [Component]
  internal class UserIdRecipientHandler : INotificationRecipientTypeHandler
  {
    private static UserIdRecipientHandler GVLdjvlFXOBKmcPrOLl;

    /// <summary>Менеджер пользователей</summary>
    public UserManager UserManager
    {
      get => this.\u003CUserManager\u003Ek__BackingField;
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
              this.\u003CUserManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 0 : 0;
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

    /// <summary>
    /// Имя типа получателя сообщения (соответствует имени в шаблоне)
    /// </summary>
    public string Name => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454922792);

    /// <summary>Получить список получателей (пользователей)</summary>
    /// <param name="value">Значение</param>
    /// <returns>Список получателей (пользователей)</returns>
    public IEnumerable<object> GetRecipients(object value)
    {
      Contract.ServiceNotNull((object) this.UserManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1290337431 ^ 1290305543));
      if (value == null)
        return (IEnumerable<object>) new object[0];
      if (value is long[])
        return (IEnumerable<object>) this.UserManager.FindByIdArray(value as long[]);
      long int64;
      try
      {
        int64 = Convert.ToInt64(value);
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958977588 ^ -1958993050), value, (object) value.GetType().FullName), ex);
      }
      EleWise.ELMA.Security.Models.IUser user = this.UserManager.Load(int64);
      if (user == null)
        return (IEnumerable<object>) new object[0];
      return (IEnumerable<object>) new object[1]
      {
        (object) user
      };
    }

    public UserIdRecipientHandler()
    {
      UserIdRecipientHandler.z170AmlgC0BBkOpgHKH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VyZJs9lvTw6oZIRkHCT() => UserIdRecipientHandler.GVLdjvlFXOBKmcPrOLl == null;

    internal static UserIdRecipientHandler qCbvlBlqeTiqudMKXCu() => UserIdRecipientHandler.GVLdjvlFXOBKmcPrOLl;

    internal static void z170AmlgC0BBkOpgHKH() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
