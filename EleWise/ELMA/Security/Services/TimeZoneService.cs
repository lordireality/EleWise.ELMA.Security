// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.TimeZoneService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис для работы с часовыми поясами</summary>
  [Service]
  public class TimeZoneService : ITimeZoneService
  {
    internal static TimeZoneService IxmRlwYwo5GoaSAIrLv;

    /// <summary>Служба аутентификации системы</summary>
    [NotNull]
    public IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 0 : 0;
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

    /// <summary>Хранилище бинарных данных</summary>
    [NotNull]
    public IBLOBStore BLOBStore
    {
      get => this.\u003CBLOBStore\u003Ek__BackingField;
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
              this.\u003CBLOBStore\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
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

    /// <summary>Часовой пояс текущего пользователя в ключевой локали</summary>
    public TimeZoneModel CurrentUserTimeZone
    {
      get
      {
        int num = 2;
        EleWise.ELMA.Security.Models.IUser currentUser;
        while (true)
        {
          switch (num)
          {
            case 1:
              currentUser = this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
              num = 4;
              continue;
            case 2:
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_7;
            case 4:
              if (currentUser == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 1 : 3;
                continue;
              }
              goto label_6;
            default:
              goto label_6;
          }
        }
label_6:
        return ContextVars.GetOrAdd<TimeZoneModel>((string) TimeZoneService.aE1XSsYUbdbjRlqWeI5(-909559362 ^ -398405015 ^ 562662445), (Func<TimeZoneModel>) (() => (TimeZoneModel) TimeZoneService.\u003C\u003Ec__DisplayClass9_0.jE9UrFwNMUOLCQTIn8oh((object) currentUser)));
label_7:
        return (TimeZoneModel) TimeZoneService.zIxPvEYRK6met7ZMb3C();
      }
    }

    /// <summary>
    /// Получить блокированное смещение часового пояса текущего пользователя
    /// </summary>
    /// <returns></returns>
    public long? GetBlockedTimeZoneOffset()
    {
      EleWise.ELMA.Security.Models.IUser currentUser = this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
      byte[] bytes = currentUser != null ? this.BLOBStore.LoadOrNull(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1310136491 - -570921450 ^ -739241687), (object) currentUser.Id)) : (byte[]) null;
      if (bytes != null)
      {
        try
        {
          return ClassSerializationHelper.DeserializeObject(bytes) as long?;
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1780597820 ^ 1780591720), (object) currentUser.Id), ex);
        }
      }
      return new long?((long) TZ.ServerOffset);
    }

    /// <summary>Получить часовой пояс пользователя</summary>
    /// <param name="user">EleWise.ELMA.Security.IUser</param>
    /// <returns></returns>
    public TimeZoneModel GetUserTimeZone(EleWise.ELMA.Security.IUser user)
    {
      int num1 = 1;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (user == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 2:
              goto label_5;
            case 3:
              if (user1 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 2 : 0;
                continue;
              }
              goto label_6;
            default:
              goto label_9;
          }
        }
label_10:
        user1 = user as EleWise.ELMA.Security.Models.IUser;
        num1 = 3;
      }
label_5:
      throw new ArgumentException((string) TimeZoneService.tvCb6gYodX6YfATVWDe((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1053060681 ^ 1053034163), (object) new object[1]
      {
        (object) typeof (EleWise.ELMA.Security.Models.IUser).FullName
      }));
label_6:
      return (TimeZoneModel) TimeZoneService.pZ9EYWYtucyoknW1XMS((object) user1);
label_9:
      throw new ArgumentNullException((string) TimeZoneService.aE1XSsYUbdbjRlqWeI5(1687460816 ^ 1687456680));
    }

    /// <summary>
    /// Использовать методы расширения <see cref="M:EleWise.ELMA.TZ.ToClientDateTime(System.DateTime,EleWise.ELMA.TZSettings)" />
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <param name="settings">Настройки преобразования</param>
    /// <returns>Пользовательское время</returns>
    public DateTime ToClientDateTime(DateTime runtimeDateTime, TZSettings settings = null)
    {
      int num = 4;
      int? nullable1;
      while (true)
      {
        int? nullable2;
        int? nullable3;
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            if (!this.IsServerTimeZoneDetermined(nullable1))
            {
              if (!this.IsClientRuntimeSideTransformationValid(runtimeDateTime, nullable1))
              {
                num = 8;
                continue;
              }
              goto label_5;
            }
            else
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 2 : 5;
              continue;
            }
          case 3:
            if (TimeZoneService.Xl93BaY6YSTWPQrR2tR((object) settings) == TZSettings.TZType.WithoutOffset)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
            if (TimeZoneService.GMP6hAYmMRpe1qEoEP8((object) settings, (object) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 0 : 3;
              continue;
            }
            break;
          case 5:
            goto label_7;
          case 6:
            nullable2 = new int?();
            num = 7;
            continue;
          case 7:
            nullable3 = nullable2;
            goto label_22;
          case 8:
            goto label_4;
          case 9:
            goto label_16;
          case 10:
label_6:
            nullable3 = new int?(TimeZoneService.W7j0IqYD8KcFN3yHuqF((object) settings));
            goto label_22;
          default:
            if (!this.IsRuntimeTimeZoneDetermined(nullable1))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 1 : 2;
              continue;
            }
            goto label_16;
        }
        if (TimeZoneService.hPQgqeYk29G8aVYep2X((object) settings, (object) null))
        {
          num = 6;
          continue;
        }
        goto label_6;
label_22:
        nullable1 = nullable3;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 0 : 0;
      }
label_4:
      return TimeZoneService.AqK7AOYaHIEi8snmbw9(runtimeDateTime, DateTimeKind.Unspecified);
label_5:
      return DateTime.SpecifyKind(runtimeDateTime.AddMinutes((double) this.GetDiffBtClientDtAndRuntimeDt(nullable1)), DateTimeKind.Unspecified);
label_7:
      return TimeZoneService.DRbjhRYxQafGfTdoZSh(runtimeDateTime);
label_13:
      return DateTime.SpecifyKind(runtimeDateTime, DateTimeKind.Unspecified);
label_16:
      return TimeZoneService.AqK7AOYaHIEi8snmbw9(runtimeDateTime, DateTimeKind.Unspecified);
    }

    /// <summary>
    /// Использовать методы расширения <see cref="M:EleWise.ELMA.TZ.ToRuntimeDateTimeFromServer(System.DateTime)" />
    /// </summary>
    /// <param name="clientDateTime">Пользовательское время</param>
    /// <param name="settings">Настройки преобразования</param>
    /// <returns>Локальное время</returns>
    public DateTime ToRuntimeDateTimeFromClient(
      DateTime clientDateTime,
      TZSettings settings = null)
    {
      int num1 = 10;
      int? nullable1;
      while (true)
      {
        int num2 = num1;
        int? nullable2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
              goto label_11;
            case 3:
              if (TimeZoneService.Xl93BaY6YSTWPQrR2tR((object) settings) == TZSettings.TZType.WithoutOffset)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 2 : 2;
                continue;
              }
              goto case 9;
            case 4:
              goto label_3;
            case 5:
              goto label_8;
            case 6:
              if (!this.IsServerTimeZoneDetermined(nullable1))
              {
                if (!this.IsClientRuntimeSideTransformationValid(clientDateTime, nullable1))
                {
                  num2 = 5;
                  continue;
                }
                goto label_9;
              }
              else
              {
                num2 = 4;
                continue;
              }
            case 7:
              goto label_16;
            case 8:
              goto label_14;
            case 9:
              if (TimeZoneService.hPQgqeYk29G8aVYep2X((object) settings, (object) null))
              {
                nullable2 = new int?();
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 1 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
              continue;
            case 10:
              if (!TimeZoneService.GMP6hAYmMRpe1qEoEP8((object) settings, (object) null))
              {
                num2 = 9;
                continue;
              }
              goto case 3;
            default:
              goto label_19;
          }
        }
label_14:
        if (!this.IsRuntimeTimeZoneDetermined(nullable1))
        {
          num1 = 6;
          continue;
        }
        goto label_16;
label_19:
        int? nullable3 = new int?(TimeZoneService.W7j0IqYD8KcFN3yHuqF((object) settings));
        goto label_23;
label_22:
        nullable3 = nullable2;
label_23:
        nullable1 = nullable3;
        num1 = 8;
      }
label_3:
      return TimeZoneService.mk8xWRYCvOGEhFBU3PY(clientDateTime);
label_8:
      return TimeZoneService.AqK7AOYaHIEi8snmbw9(clientDateTime, DateTimeKind.Unspecified);
label_9:
      return TimeZoneService.AqK7AOYaHIEi8snmbw9(clientDateTime.AddMinutes((double) -this.GetDiffBtClientDtAndRuntimeDt(nullable1)), DateTimeKind.Local);
label_11:
      return TimeZoneService.AqK7AOYaHIEi8snmbw9(clientDateTime, DateTimeKind.Unspecified);
label_16:
      return DateTime.SpecifyKind(clientDateTime, DateTimeKind.Local);
    }

    /// <summary>Сдвиг локального часового пояса</summary>
    /// <param name="customClientTimeZoneOffset">Произвольный сдвиг часового пояса в минутах</param>
    /// <returns></returns>
    private bool IsRuntimeTimeZoneDetermined(int? customClientTimeZoneOffset = null) => this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) == 0;

    /// <summary>Сдвиг серверного часового пояса</summary>
    /// <param name="customClientTimeZoneOffset">Произвольный сдвиг часового пояса в минутах</param>
    /// <returns></returns>
    private bool IsServerTimeZoneDetermined(int? customClientTimeZoneOffset = null)
    {
      if (!customClientTimeZoneOffset.HasValue)
        return this.CurrentUserTimeZone.Offset == TZ.ServerOffset;
      int? nullable = customClientTimeZoneOffset;
      int serverOffset = TZ.ServerOffset;
      return nullable.GetValueOrDefault() == serverOffset & nullable.HasValue;
    }

    /// <summary>
    /// Получить разницу между пользовательским смещением и локальным смещением
    /// <!--(b-a)=-(a-b)-->
    /// </summary>
    /// <param name="customTimeZoneOffset">Произвольный сдвиг часового пояса в минутах</param>
    /// <returns></returns>
    private int GetDiffBtClientDtAndRuntimeDt(int? customTimeZoneOffset = null) => !customTimeZoneOffset.HasValue ? ContextVars.GetOrAdd<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801336045), (Func<int>) (() => TimeZoneService.jsPIQvY3Q6sPfk7wt9p((object) this.CurrentUserTimeZone) - TZ.RuntimeOffset)) : customTimeZoneOffset.Value - TZ.RuntimeOffset;

    /// <summary>
    /// Получить максимальный порог значения времени для преобразования
    /// </summary>
    /// <param name="customClientTimeZoneOffset">Произвольный сдвиг часового пояса в минутах</param>
    /// <returns></returns>
    private DateTime GetMaxTheshold(int? customClientTimeZoneOffset = null)
    {
      Func<DateTime> val = (Func<DateTime>) (() =>
      {
        int num = 1;
        DateTime maxValue;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) > 0)
              {
                maxValue = DateTime.MaxValue;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 2;
                continue;
              }
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_2;
          }
        }
label_2:
        return DateTime.MaxValue;
label_6:
        return maxValue.AddMinutes((double) -this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset));
      });
      return customClientTimeZoneOffset.HasValue ? ContextVars.GetOrAdd<DateTime>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(4869926 >> 3 ^ 598066), val) : val();
    }

    /// <summary>
    /// Получить минимальный порог значения времени для преобразования
    /// </summary>
    /// <param name="customClientTimeZoneOffset">Произвольный сдвиг часового пояса в минутах</param>
    /// <returns></returns>
    private DateTime GetMinTheshold(int? customClientTimeZoneOffset = null)
    {
      Func<DateTime> val = (Func<DateTime>) (() =>
      {
        int num = 2;
        DateTime minValue;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) >= 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 0;
                continue;
              }
              minValue = DateTime.MinValue;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return minValue.AddMinutes((double) -this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset));
label_5:
        return DateTime.MinValue;
      });
      return customClientTimeZoneOffset.HasValue ? ContextVars.GetOrAdd<DateTime>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776409954), val) : val();
    }

    /// <summary>Значение времени допустимо для преобразования</summary>
    /// <param name="dateTime">Время</param>
    /// <param name="customClientTimeZoneOffset">Произвольный сдвиг часового пояса в минутах</param>
    /// <returns></returns>
    private bool IsClientRuntimeSideTransformationValid(
      DateTime dateTime,
      int? customClientTimeZoneOffset = null)
    {
      if (dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue)
        return false;
      if (this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) > 0)
        return dateTime < this.GetMaxTheshold(customClientTimeZoneOffset);
      return this.GetDiffBtClientDtAndRuntimeDt(customClientTimeZoneOffset) >= 0 || dateTime > this.GetMinTheshold(customClientTimeZoneOffset);
    }

    public TimeZoneService()
    {
      TimeZoneService.K7DwlNYifqC0ni5ChyA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LNZ3wxYbdRRaFYW9nvn() => TimeZoneService.IxmRlwYwo5GoaSAIrLv == null;

    internal static TimeZoneService TMdhrvYKgxy9vrpX6Ha() => TimeZoneService.IxmRlwYwo5GoaSAIrLv;

    internal static object aE1XSsYUbdbjRlqWeI5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zIxPvEYRK6met7ZMb3C() => (object) TZ.ServerTimeZone;

    internal static object tvCb6gYodX6YfATVWDe([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object pZ9EYWYtucyoknW1XMS([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).TimeZone;

    internal static bool GMP6hAYmMRpe1qEoEP8([In] object obj0, [In] object obj1) => (TZSettings) obj0 != (TZSettings) obj1;

    internal static TZSettings.TZType Xl93BaY6YSTWPQrR2tR([In] object obj0) => ((TZSettings) obj0).Type;

    internal static bool hPQgqeYk29G8aVYep2X([In] object obj0, [In] object obj1) => (TZSettings) obj0 == (TZSettings) obj1;

    internal static int W7j0IqYD8KcFN3yHuqF([In] object obj0) => ((TZSettings) obj0).Offset;

    internal static DateTime AqK7AOYaHIEi8snmbw9([In] DateTime obj0, [In] DateTimeKind obj1) => DateTime.SpecifyKind(obj0, obj1);

    internal static DateTime DRbjhRYxQafGfTdoZSh([In] DateTime obj0) => obj0.ToServerDateTime();

    internal static DateTime mk8xWRYCvOGEhFBU3PY([In] DateTime obj0) => obj0.ToRuntimeDateTimeFromServer();

    internal static void K7DwlNYifqC0ni5ChyA() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static int jsPIQvY3Q6sPfk7wt9p([In] object obj0) => ((TimeZoneModel) obj0).Offset;
  }
}
