// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.UserExtensions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Security.Models
{
  public static class UserExtensions
  {
    private static UserExtensions zgScOhQBfrapQRr1t2R;

    /// <summary>Проверить, активна ли учетная запись пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static bool IsActive([NotNull] this IUser user) => UserExtensions.fiBs5KQFnJt199qTXSl(UserExtensions.GWYXJRQTESOtaD4IhvW(), (object) user);

    /// <summary>Блокировать учетную запись пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static void Block([NotNull] this IUser user)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            UserExtensions.IekZ6FQvIDMSfDjApCC(UserExtensions.GWYXJRQTESOtaD4IhvW(), (object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 0 : 0;
            continue;
          case 2:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            goto label_5;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_2:
      return;
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1433051380 + 1051547170 ^ -1810372754));
    }

    /// <summary>Разблокировать учетную запись пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static void UnBlock([NotNull] this IUser user)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_5;
          case 2:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 1;
              continue;
            }
            UserExtensions.laULFYQgqQgstnUNHSA(UserExtensions.GWYXJRQTESOtaD4IhvW(), (object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_5:
      throw new ArgumentNullException((string) UserExtensions.gHRWKGQqtfIDfQ9ufIT(-404268492 ^ -404272564));
    }

    /// <summary>Полное имя (например, Иванов Иван Иванович)</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static string GetFullName(this IUser user)
    {
      int num1 = 21;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        string str1;
        while (true)
        {
          string str2;
          object obj;
          switch (num2)
          {
            case 1:
              if (UserExtensions.yMU9HYQIY1P08YyWGcU((object) str1) <= 0)
              {
                num2 = 11;
                continue;
              }
              goto case 6;
            case 2:
              if (UserExtensions.gRdrv2QHtCnTX0krDmX((object) stringBuilder) > 0)
              {
                num2 = 4;
                continue;
              }
              goto label_25;
            case 3:
              if (UserExtensions.yMU9HYQIY1P08YyWGcU((object) str1) <= 0)
                goto case 19;
              else
                goto label_13;
            case 4:
              stringBuilder.Append((string) UserExtensions.gHRWKGQqtfIDfQ9ufIT(-29763048 >> 5 ^ -942278));
              num2 = 9;
              continue;
            case 5:
              if (UserExtensions.yMU9HYQIY1P08YyWGcU((object) str1) > 0)
              {
                num2 = 15;
                continue;
              }
              goto case 10;
            case 6:
              if (stringBuilder.Length > 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 14 : 11;
                continue;
              }
              goto case 8;
            case 7:
            case 12:
              goto label_29;
            case 8:
              UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, (object) str1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
              continue;
            case 9:
              goto label_25;
            case 10:
              if (UserExtensions.NUEVR4QnxDwGleT0iqa((object) user) != null)
              {
                obj = UserExtensions.RfI6pDQLcLrgRbW3xu6((object) user.FirstName);
                break;
              }
              goto label_7;
            case 13:
              obj = (object) string.Empty;
              break;
            case 14:
              stringBuilder.Append((string) UserExtensions.gHRWKGQqtfIDfQ9ufIT(2016571091 >> 5 ^ 63029916));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 8 : 4;
              continue;
            case 15:
              UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, (object) str1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 5 : 10;
              continue;
            case 16:
              str2 = string.Empty;
              goto label_40;
            case 17:
              goto label_17;
            case 18:
              if (user.LastName == null)
              {
                num2 = 17;
                continue;
              }
              goto label_35;
            case 19:
              if (UserExtensions.gRdrv2QHtCnTX0krDmX((object) stringBuilder) != 0)
              {
                num2 = 7;
                continue;
              }
              goto case 22;
            case 20:
              goto label_14;
            case 21:
              if (user != null)
              {
                stringBuilder = new StringBuilder();
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 18 : 16;
                continue;
              }
              num2 = 20;
              continue;
            case 22:
              UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, UserExtensions.hFwnDaQz1xnAt33UWsO((object) user));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 12 : 1;
              continue;
            default:
              if (UserExtensions.AKhE0dQ2IQjgPTknO1O((object) user) == null)
              {
                num2 = 16;
                continue;
              }
              str2 = user.MiddleName.Trim();
              goto label_40;
          }
          str1 = (string) obj;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 0 : 1;
          continue;
label_40:
          str1 = str2;
          num2 = 3;
        }
label_7:
        num1 = 13;
        continue;
label_13:
        num1 = 2;
        continue;
label_17:
        string str3 = string.Empty;
        goto label_36;
label_25:
        UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, (object) str1);
        num1 = 19;
        continue;
label_35:
        str3 = ((string) UserExtensions.yo1jZHQJ1E4UxS0LdA7((object) user)).Trim();
label_36:
        str1 = str3;
        num1 = 5;
      }
label_14:
      throw new ArgumentNullException((string) UserExtensions.gHRWKGQqtfIDfQ9ufIT(-1527733619 - 442652394 ^ -1970381861));
label_29:
      return (string) UserExtensions.RfI6pDQLcLrgRbW3xu6((object) stringBuilder.ToString());
    }

    /// <summary>Короткое имя (например, Иванов И.И.)</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static string GetShortName(this IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277476595));
label_3:
      return (string) UserExtensions.gjLGnF8wmc8wB4W99cm(UserExtensions.tTjL668uPODmiAdBMs1((object) user), UserExtensions.yo1jZHQJ1E4UxS0LdA7((object) user), (object) user.FirstName, UserExtensions.AKhE0dQ2IQjgPTknO1O((object) user), UserExtensions.hFwnDaQz1xnAt33UWsO((object) user));
    }

    /// <summary>Короткое имя (например, Иванов И.И.)</summary>
    /// <param name="uid">Уникальный идентификатор пользователя.</param>
    /// <param name="lastName">Фамилия.</param>
    /// <param name="firstName">Имя.</param>
    /// <param name="middleName">Отчество.</param>
    /// <param name="userName">Учётная запись.</param>
    /// <returns></returns>
    public static string GetShortName(
      Guid uid,
      string lastName,
      string firstName,
      string middleName,
      string userName)
    {
      int num1 = 13;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        string str1;
        while (true)
        {
          string str2;
          object obj;
          switch (num2)
          {
            case 1:
              UserExtensions.NALpOG8UP95ycV7r8uh((object) stringBuilder, (object) str1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 2 : 5;
              continue;
            case 2:
              UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, (object) userName);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 1 : 21;
              continue;
            case 3:
              str2 = string.Empty;
              break;
            case 4:
              if (!UserExtensions.NTugZy8KcaZFB4624ji((object) firstName, UserExtensions.gHRWKGQqtfIDfQ9ufIT(-1958977588 ^ -1958997320)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 10 : 22;
                continue;
              }
              goto label_26;
            case 5:
            case 17:
              if (stringBuilder.Length != 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 8 : 8;
                continue;
              }
              goto case 2;
            case 6:
            case 27:
              if (firstName == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 1 : 10;
                continue;
              }
              obj = UserExtensions.RfI6pDQLcLrgRbW3xu6((object) firstName);
              goto label_43;
            case 7:
              if (lastName == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 1 : 3;
                continue;
              }
              str2 = lastName.Trim();
              break;
            case 8:
            case 21:
              goto label_31;
            case 9:
              if (UserExtensions.yMU9HYQIY1P08YyWGcU((object) str1) > 0)
              {
                num2 = 20;
                continue;
              }
              goto default;
            case 10:
              obj = (object) string.Empty;
              goto label_43;
            case 11:
              UserExtensions.NALpOG8UP95ycV7r8uh((object) stringBuilder, (object) str1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
              continue;
            case 12:
              if (UserExtensions.gVRa0U8bsnD85AHU4O1(uid, SecurityConstants.AdminUserUid))
              {
                num2 = 4;
                continue;
              }
              goto case 22;
            case 13:
              if (!UserExtensions.gVRa0U8bsnD85AHU4O1(uid, SecurityConstants.SystemUserUid))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 7 : 12;
                continue;
              }
              goto label_9;
            case 14:
              if (UserExtensions.yMU9HYQIY1P08YyWGcU((object) str1) <= 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 17 : 1;
                continue;
              }
              goto case 15;
            case 15:
              if (UserExtensions.gRdrv2QHtCnTX0krDmX((object) stringBuilder) > 0)
              {
                num2 = 16;
                continue;
              }
              goto case 1;
            case 16:
              stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(978908330 << 6 ^ -1774355606));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 1 : 1;
              continue;
            case 18:
              goto label_26;
            case 19:
              goto label_9;
            case 20:
              if (stringBuilder.Length > 0)
              {
                num2 = 23;
                continue;
              }
              goto case 11;
            case 22:
              stringBuilder = new StringBuilder();
              num2 = 7;
              continue;
            case 23:
              UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--306199571 ^ 306212345));
              num2 = 11;
              continue;
            case 24:
              goto label_32;
            case 25:
              if (UserExtensions.yMU9HYQIY1P08YyWGcU((object) str1) <= 0)
              {
                num2 = 6;
                continue;
              }
              goto case 26;
            case 26:
              UserExtensions.UacvViQev8LQQmgo3Zn((object) stringBuilder, (object) str1);
              num2 = 27;
              continue;
            default:
              if (middleName == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 24 : 0;
                continue;
              }
              goto label_44;
          }
          str1 = str2;
          num2 = 25;
          continue;
label_43:
          str1 = (string) obj;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 9 : 2;
        }
label_32:
        object obj1 = (object) string.Empty;
        goto label_45;
label_44:
        obj1 = UserExtensions.RfI6pDQLcLrgRbW3xu6((object) middleName);
label_45:
        str1 = (string) obj1;
        num1 = 14;
      }
label_9:
      return lastName;
label_26:
      return lastName;
label_31:
      return (string) UserExtensions.RfI6pDQLcLrgRbW3xu6((object) stringBuilder.ToString());
    }

    /// <summary>
    /// Сокращенная запись двойного, тройного и т.д. имени, фамилии или отчества.
    /// (примеры: Мамин-Сибиряк -&gt; М.-С. , Ольга-Софья -&gt; О.-С.)
    /// </summary>
    /// <param name="name">Составной элемент в ФИО: имя или фамилия, либо отчество.</param>
    public static string GetShortCompoundName(string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (string.IsNullOrEmpty(name))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return string.Empty;
label_3:
      StringBuilder stringBuilder = new StringBuilder();
      UserExtensions.NALpOG8UP95ycV7r8uh((object) stringBuilder, (object) name);
      return stringBuilder.ToString();
    }

    /// <summary>
    /// Полное имя и должность (например, <value>Иванов Иван Иванович (Директор)</value>)
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static string GetFullNamePosition(this IUser user)
    {
      int num = 4;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_10;
          case 3:
            str1 = (string) UserExtensions.DtBaBF8RSvFlk8ug0gn((object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 5 : 2;
            continue;
          case 4:
            if (user != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 5:
            str2 = (string) UserExtensions.ROKeK08ogQG2GH3GIhE((object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
            continue;
          case 6:
            str1 = (string) UserExtensions.OamRFx8mH0jPljx1vit((object) str1, UserExtensions.gHRWKGQqtfIDfQ9ufIT(-206147790 ^ -206118686), (object) str2, UserExtensions.gHRWKGQqtfIDfQ9ufIT(2110195605 ^ 2110228557));
            num = 2;
            continue;
          default:
            if (!UserExtensions.Jr0iPy8taAekG2G58Gk((object) str2))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 3 : 6;
              continue;
            }
            goto label_10;
        }
      }
label_2:
      throw new ArgumentNullException((string) UserExtensions.gHRWKGQqtfIDfQ9ufIT(617710536 ^ 617714608));
label_10:
      return (string) UserExtensions.RfI6pDQLcLrgRbW3xu6((object) str1);
    }

    /// <summary>Получить список должностей пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static string GetPositions(this IUser user)
    {
      int num = 5;
      string positions;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (UserExtensions.K3qket86COLbPqr4nAH((object) user.OrganizationItems) <= 0)
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 2:
            if (UserExtensions.K3qket86COLbPqr4nAH((object) user.OrganizationGroups) <= 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 4:
            goto label_7;
          case 5:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 4 : 2;
              continue;
            }
            positions = (string) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 0 : 1;
            continue;
          case 6:
            object separator = UserExtensions.gHRWKGQqtfIDfQ9ufIT(-1341618464 ^ -1341617460);
            // ISSUE: reference to a compiler-generated method
            List<string> list1 = user.OrganizationItems.Select<IOrganizationItem, string>((Func<IOrganizationItem, string>) (item => (string) UserExtensions.\u003C\u003Ec.oK7KuUwZ4s2b0LDO2NgL((object) item))).ToList<string>();
            ISet<IOrganizationItem> organizationGroups = user.OrganizationGroups;
            // ISSUE: reference to a compiler-generated field
            Func<IOrganizationItem, string> func = UserExtensions.\u003C\u003Ec.\u003C\u003E9__8_1;
            Func<IOrganizationItem, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              UserExtensions.\u003C\u003Ec.\u003C\u003E9__8_1 = selector = (Func<IOrganizationItem, string>) (item => item.Name);
            }
            else
              goto label_2;
label_14:
            List<string> list2 = organizationGroups.Select<IOrganizationItem, string>(selector).ToList<string>();
            IOrderedEnumerable<string> values = list1.Union<string>((IEnumerable<string>) list2).OrderBy<string, string>((Func<string, string>) (s => s));
            positions = string.Join((string) separator, (IEnumerable<string>) values);
            num = 3;
            continue;
label_2:
            selector = func;
            goto label_14;
          default:
            goto label_9;
        }
      }
label_7:
      throw new ArgumentNullException((string) UserExtensions.gHRWKGQqtfIDfQ9ufIT(-1691384762 ^ -1691380674));
label_9:
      return positions;
    }

    /// <summary>
    /// Получить список должностей пользователя с учетом прав на назначение
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static string GetSetPositions(this IUser user)
    {
      int num = 1;
      string setPositions;
      while (true)
      {
        switch (num)
        {
          case 1:
            setPositions = (string) UserExtensions.ROKeK08ogQG2GH3GIhE((object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            if (UserExtensions.hiSFXH8kaRm4T5xAkCj((object) Locator.GetServiceNotNull<ISecurityService>(), (object) PermissionProvider.UserManagmentPermission))
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 4:
            goto label_6;
          default:
            if (!UserExtensions.Jr0iPy8taAekG2G58Gk((object) setPositions))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 1 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_6:
      return (string) UserExtensions.l6Qqmi8aHCuuwvI5dsr(UserExtensions.tEfvcM8DSmEETbUPLmY(UserExtensions.gHRWKGQqtfIDfQ9ufIT(2016571091 >> 5 ^ 62987432)), UserExtensions.tEfvcM8DSmEETbUPLmY(UserExtensions.gHRWKGQqtfIDfQ9ufIT(1567399832 << 6 ^ 1529309678)));
label_7:
      return setPositions;
    }

    /// <summary>
    /// Короткое имя и должность (например, <c>Иванов И.И. (Директор)</c>)
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>user</c></exception>
    public static string GetShortNamePosition(this IUser user)
    {
      int num = 5;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = (string) UserExtensions.OamRFx8mH0jPljx1vit((object) str1, UserExtensions.gHRWKGQqtfIDfQ9ufIT(-1788054269 >> 5 ^ -55841672), (object) str2, UserExtensions.gHRWKGQqtfIDfQ9ufIT(554338340 ^ 554305532));
            num = 3;
            continue;
          case 2:
            str2 = (string) UserExtensions.ROKeK08ogQG2GH3GIhE((object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_10;
          case 4:
            str1 = (string) UserExtensions.rHGoGU8xSPuR92FcHdy((object) user);
            num = 2;
            continue;
          case 5:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 4 : 4;
              continue;
            }
            goto label_2;
          case 6:
            goto label_2;
          default:
            if (!UserExtensions.Jr0iPy8taAekG2G58Gk((object) str2))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 1 : 0;
              continue;
            }
            goto label_10;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-192923496 ^ 192927519));
label_10:
      return (string) UserExtensions.RfI6pDQLcLrgRbW3xu6((object) str1);
    }

    /// <summary>Инфа по замещениям</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public static string GetReplacementsAbsencesText(this IUser user)
    {
      int num = 5;
      IAbsence absence;
      IReplacement replacement;
      IUser user1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (absence != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          case 3:
            IList<IAbsence> absences = AbsenceManager.Instance.GetAbsences((EleWise.ELMA.Security.IUser) user);
            // ISSUE: reference to a compiler-generated field
            Func<IAbsence, DateTime> func = UserExtensions.\u003C\u003Ec.\u003C\u003E9__11_0;
            Func<IAbsence, DateTime> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              UserExtensions.\u003C\u003Ec.\u003C\u003E9__11_0 = keySelector = (Func<IAbsence, DateTime>) (k => UserExtensions.\u003C\u003Ec.Rok2cPwZciZuW1FeT8g1((object) k));
            }
            else
              goto label_14;
label_13:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            absence = absences.OrderBy<IAbsence, DateTime>(keySelector).FirstOrDefault<IAbsence>((Func<IAbsence, bool>) (k => UserExtensions.\u003C\u003Ec.uX7fi7wZQiXE6X6lYboQ(k.EndDate, UserExtensions.\u003C\u003Ec.UAvy64wZPcgPXAdm46rZ())));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 1 : 1;
            continue;
label_14:
            keySelector = func;
            goto label_13;
          case 4:
            if (replacement == null)
            {
              num = 3;
              continue;
            }
            break;
          case 5:
            replacement = ((ReplacementManager) UserExtensions.YW5ckh8CL51AikscoE0()).GetReplacementsReadOnly((EleWise.ELMA.Security.IUser) user).FirstOrDefault<IReplacement>();
            num = 4;
            continue;
          case 6:
            goto label_10;
        }
        user1 = ((AbstractNHEntityManager<IUser, long>) UserExtensions.GWYXJRQTESOtaD4IhvW()).Load(((IEntity<long>) UserExtensions.Qbe0HX8idjGkJXAFqcw((object) replacement)).Id);
        num = 6;
      }
label_6:
      return (string) UserExtensions.RE2hQI8NLKEHyZHeFtO(UserExtensions.gHRWKGQqtfIDfQ9ufIT(908197830 ^ 908160942), (object) new object[2]
      {
        (object) UserExtensions.Wjv0hN80LYtWgCx7w4G((object) absence),
        (object) UserExtensions.HH1b7i8ZE641ddHalpZ((object) absence)
      });
label_7:
      return "";
label_10:
      return (string) UserExtensions.RE2hQI8NLKEHyZHeFtO(UserExtensions.gHRWKGQqtfIDfQ9ufIT(1534797734 ^ 1534834594), (object) new object[3]
      {
        UserExtensions.DtBaBF8RSvFlk8ug0gn((object) user1),
        (object) UserExtensions.JBGnIi83AQLvvEHVnZi((object) replacement),
        (object) UserExtensions.J1qEr98jFKhthg8uD2Q((object) replacement)
      });
    }

    /// <summary>
    /// Назначить пользователя на указанные должности. Существующие должности пользователя остаются.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="organizationItems">Должности, на которые нужно назначить</param>
    public static void Appoint(this IUser user, params IOrganizationItem[] organizationItems)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((UserManager) UserExtensions.GWYXJRQTESOtaD4IhvW()).Appoint(user, organizationItems);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Назначить пользователя на указанные должности с удалением с прежних должностей.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="organizationItems">Должности, на которые нужно назначить</param>
    public static void SetAppointments(
      this IUser user,
      IEnumerable<IOrganizationItem> organizationItems)
    {
      UserManager.Instance.SetAppointments(user, organizationItems);
    }

    /// <summary>Проверяет возможность смены пароля пользователю</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public static bool AllowChangePassword([NotNull] this IUser user) => user.AllowChangePassword(out string _);

    /// <summary>Проверяет возможность смены пароля пользователю</summary>
    /// <param name="user"></param>
    /// <param name="error">Возращается ошибка, если пароль поменять нельзя, в противном случае null</param>
    /// <returns></returns>
    public static bool AllowChangePassword([NotNull] this IUser user, out string error)
    {
      int num = 8;
      ISecurityService service;
      IUser currentUser;
      while (true)
      {
        switch (num)
        {
          case 1:
            currentUser = AuthenticationService.GetCurrentUser<IUser>();
            num = 11;
            continue;
          case 2:
            goto label_11;
          case 3:
            if (!service.HasPermission(PermissionProvider.DenyPasswordResetPermission))
            {
              error = (string) null;
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_19;
          case 5:
            error = (string) UserExtensions.tEfvcM8DSmEETbUPLmY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-880091293 >> 4 ^ -55034630));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 2 : 2;
            continue;
          case 6:
            goto label_4;
          case 7:
            error = (string) UserExtensions.tEfvcM8DSmEETbUPLmY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(711486506 ^ 711523470));
            num = 6;
            continue;
          case 8:
            if (UserExtensions.uF5Mha8s2olWt97QOeb(UserExtensions.fLECFA8A1yR9uYuwd93((object) Locator.GetService<IMembershipService>(), (object) user)))
            {
              service = Locator.GetService<ISecurityService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 1 : 1;
              continue;
            }
            num = 7;
            continue;
          case 9:
            if (currentUser.Id != user.Id)
            {
              num = 12;
              continue;
            }
            goto case 3;
          case 10:
            goto label_6;
          case 11:
            if (currentUser == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 2 : 3;
              continue;
            }
            goto case 9;
          case 12:
            if (!UserExtensions.hiSFXH8kaRm4T5xAkCj((object) service, (object) PermissionProvider.UserManagmentPermission))
            {
              num = 5;
              continue;
            }
            goto case 3;
          default:
            error = (string) UserExtensions.tEfvcM8DSmEETbUPLmY(UserExtensions.gHRWKGQqtfIDfQ9ufIT(-624171910 - 757669187 ^ -1381869999));
            num = 10;
            continue;
        }
      }
label_4:
      return false;
label_6:
      return false;
label_11:
      return false;
label_19:
      return true;
    }

    /// <summary>
    /// Проверяет учет оргструктуры для назначения задач
    /// Разрешается назначать задачи непосредственному начальнику, подчиненным и одноранговым сотрудникам
    /// </summary>
    /// <param name="user"></param>
    /// <param name="executor"></param>
    /// <returns></returns>
    public static bool CheckOrganizationItem([NotNull] this IUser user, [NotNull] IUser executor)
    {
      int num1 = 3;
      IUser executor1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!((UserManager) UserExtensions.GWYXJRQTESOtaD4IhvW()).IsSubordinateUser(user, executor1))
            {
              num1 = 4;
              continue;
            }
            goto label_6;
          case 2:
            executor1 = executor;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_5;
          default:
            if (user.Id != executor1.Id)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 1 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return ((IEnumerable<IOrganizationItem>) user.OrganizationItems.ToArray<IOrganizationItem>()).Union<IOrganizationItem>((IEnumerable<IOrganizationItem>) user.OrganizationGroups).Any<IOrganizationItem>((Func<IOrganizationItem, bool>) (organizationItem =>
      {
        int num3 = 12;
        bool flag;
        while (true)
        {
          int num4 = num3;
          IOrganizationItem organizationItem2;
          IOrganizationItem organizationItem1;
          // ISSUE: variable of a compiler-generated type
          UserExtensions.\u003C\u003Ec__DisplayClass16_0 cDisplayClass160;
          while (true)
          {
            switch (num4)
            {
              case 1:
                organizationItem1 = organizationItem;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 14 : 0;
                continue;
              case 2:
                if (organizationItem2 != null)
                {
                  num4 = 7;
                  continue;
                }
                goto label_8;
              case 3:
                if (organizationItem2 != null)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 0 : 0;
                  continue;
                }
                goto case 2;
              case 4:
                goto label_19;
              case 5:
                flag |= organizationItem2.SubItems.Any<IOrganizationItem>((Func<IOrganizationItem, bool>) (department =>
                {
                  int num5 = 2;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (UserExtensions.\u003C\u003Ec__DisplayClass16_1.IqAUFnwZBdHtfy6UpExt((object) department) == OrganizationItemType.NestedStructure)
                        {
                          num5 = 3;
                          continue;
                        }
                        goto case 4;
                      case 2:
                        if (department.ItemType != OrganizationItemType.Department)
                        {
                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 1 : 1;
                          continue;
                        }
                        goto case 3;
                      case 3:
                        department = department.SubItems.FirstOrDefault<IOrganizationItem>();
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 4 : 3;
                        continue;
                      case 4:
                        if (department != null)
                        {
                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_11;
                      case 5:
                        goto label_11;
                      default:
                        if (department == organizationItem1)
                        {
                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 3 : 5;
                          continue;
                        }
                        goto label_12;
                    }
                  }
label_11:
                  return false;
label_12:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  return ((UserExtensions.\u003C\u003Ec__DisplayClass16_1.V8X33kwZp8nIlMQYZTrk((object) department) == cDisplayClass160.executor ? 1 : 0) | (department.Users != null ? (department.Users.Contains(cDisplayClass160.executor) ? 1 : 0) : 0)) != 0;
                }));
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 4 : 4;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated method
                organizationItem2 = (IOrganizationItem) UserExtensions.\u003C\u003Ec__DisplayClass16_0.WMYOnFwZGOnMmAoMYHKl((object) organizationItem2);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 2 : 1;
                continue;
              case 7:
                // ISSUE: reference to a compiler-generated method
                flag |= UserExtensions.\u003C\u003Ec__DisplayClass16_0.U1VpyewZXNrmuiaenPvp((object) organizationItem2) == executor1;
                num4 = 5;
                continue;
              case 8:
                goto label_8;
              case 9:
                // ISSUE: reference to a compiler-generated method
                if (UserExtensions.\u003C\u003Ec__DisplayClass16_0.Q1xhDWwZEjvTTL81kHf6((object) organizationItem2) != OrganizationItemType.NestedStructure)
                  goto case 2;
                else
                  goto label_4;
              case 10:
                organizationItem2 = organizationItem1.ParentItem;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 3 : 1;
                continue;
              case 11:
                cDisplayClass160 = this;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 1;
                continue;
              case 12:
                goto label_10;
              case 13:
                goto label_16;
              case 14:
                if (organizationItem1.Users != null)
                {
                  num4 = 13;
                  continue;
                }
                goto label_23;
              default:
                // ISSUE: reference to a compiler-generated method
                if (UserExtensions.\u003C\u003Ec__DisplayClass16_0.Q1xhDWwZEjvTTL81kHf6((object) organizationItem2) != OrganizationItemType.Department)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 2 : 9;
                  continue;
                }
                goto case 6;
            }
          }
label_4:
          num3 = 6;
          continue;
label_10:
          num3 = 11;
          continue;
label_16:
          int num6 = organizationItem1.Users.Contains(executor1) ? 1 : 0;
          goto label_24;
label_23:
          num6 = 0;
label_24:
          flag = num6 != 0;
          num3 = 10;
        }
label_8:
        return false;
label_19:
        return flag;
      }));
label_6:
      return true;
    }

    private static void AppendShortCompoundName(object builder, object name)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        bool flag;
        int index;
        string[] strArray;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 6:
              if (index >= strArray.Length)
              {
                num2 = 16;
                continue;
              }
              goto case 4;
            case 2:
              if (flag)
              {
                num2 = 12;
                continue;
              }
              goto case 5;
            case 3:
              index = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 6;
              continue;
            case 4:
              str = strArray[index];
              num2 = 2;
              continue;
            case 5:
              UserExtensions.UacvViQev8LQQmgo3Zn(builder, UserExtensions.gHRWKGQqtfIDfQ9ufIT(784628100 ^ 784627106));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 2 : 13;
              continue;
            case 7:
            case 10:
              ++index;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 1 : 0;
              continue;
            case 8:
              goto label_11;
            case 9:
              if (string.IsNullOrEmpty((string) name))
              {
                num2 = 8;
                continue;
              }
              flag = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_19;
            case 12:
            case 13:
              if (UserExtensions.Jr0iPy8taAekG2G58Gk((object) str))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 7 : 3;
                continue;
              }
              goto case 15;
            case 14:
              flag = false;
              num2 = 10;
              continue;
            case 15:
              UserExtensions.UacvViQev8LQQmgo3Zn(builder, UserExtensions.z8SRjA8WHKRGovSAy6r(UserExtensions.RfI6pDQLcLrgRbW3xu6((object) str), 0, 1));
              num2 = 14;
              continue;
            case 16:
              UserExtensions.UacvViQev8LQQmgo3Zn(builder, UserExtensions.gHRWKGQqtfIDfQ9ufIT(-814831182 ^ -814810838));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 11 : 8;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        strArray = (string[]) UserExtensions.x2xWfX87IYxbpKopxhl(name, (object) new char[1]
        {
          '-'
        });
        num1 = 3;
      }
label_11:
      return;
label_19:;
    }

    internal static object GWYXJRQTESOtaD4IhvW() => (object) UserManager.Instance;

    internal static bool fiBs5KQFnJt199qTXSl([In] object obj0, [In] object obj1) => ((UserManager) obj0).IsActive((IUser) obj1);

    internal static bool FpPJB6QpZjeIWpQRwNj() => UserExtensions.zgScOhQBfrapQRr1t2R == null;

    internal static UserExtensions j9PvSfQOwtIrdfUqD3G() => UserExtensions.zgScOhQBfrapQRr1t2R;

    internal static void IekZ6FQvIDMSfDjApCC([In] object obj0, [In] object obj1) => ((UserManager) obj0).Block((IUser) obj1);

    internal static object gHRWKGQqtfIDfQ9ufIT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void laULFYQgqQgstnUNHSA([In] object obj0, [In] object obj1) => ((UserManager) obj0).UnBlock((IUser) obj1);

    internal static object yo1jZHQJ1E4UxS0LdA7([In] object obj0) => (object) ((IUser) obj0).LastName;

    internal static int yMU9HYQIY1P08YyWGcU([In] object obj0) => ((string) obj0).Length;

    internal static object UacvViQev8LQQmgo3Zn([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object NUEVR4QnxDwGleT0iqa([In] object obj0) => (object) ((IUser) obj0).FirstName;

    internal static object RfI6pDQLcLrgRbW3xu6([In] object obj0) => (object) ((string) obj0).Trim();

    internal static object AKhE0dQ2IQjgPTknO1O([In] object obj0) => (object) ((IUser) obj0).MiddleName;

    internal static int gRdrv2QHtCnTX0krDmX([In] object obj0) => ((StringBuilder) obj0).Length;

    internal static object hFwnDaQz1xnAt33UWsO([In] object obj0) => (object) ((IUser) obj0).UserName;

    internal static Guid tTjL668uPODmiAdBMs1([In] object obj0) => ((IUser) obj0).Uid;

    internal static object gjLGnF8wmc8wB4W99cm(
      Guid uid,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) UserExtensions.GetShortName(uid, (string) obj1, (string) obj2, (string) obj3, (string) obj4);
    }

    internal static bool gVRa0U8bsnD85AHU4O1([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool NTugZy8KcaZFB4624ji([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void NALpOG8UP95ycV7r8uh([In] object obj0, [In] object obj1) => UserExtensions.AppendShortCompoundName(obj0, obj1);

    internal static object DtBaBF8RSvFlk8ug0gn([In] object obj0) => (object) ((IUser) obj0).GetFullName();

    internal static object ROKeK08ogQG2GH3GIhE([In] object obj0) => (object) ((IUser) obj0).GetPositions();

    internal static bool Jr0iPy8taAekG2G58Gk([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object OamRFx8mH0jPljx1vit([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);

    internal static int K3qket86COLbPqr4nAH([In] object obj0) => ((ICollection<IOrganizationItem>) obj0).Count;

    internal static bool hiSFXH8kaRm4T5xAkCj([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).HasPermission((Permission) obj1);

    internal static object tEfvcM8DSmEETbUPLmY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object l6Qqmi8aHCuuwvI5dsr([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object rHGoGU8xSPuR92FcHdy([In] object obj0) => (object) ((IUser) obj0).GetShortName();

    internal static object YW5ckh8CL51AikscoE0() => (object) ReplacementManager.Instance;

    internal static object Qbe0HX8idjGkJXAFqcw([In] object obj0) => (object) ((IReplacement) obj0).TargetUser;

    internal static DateTime JBGnIi83AQLvvEHVnZi([In] object obj0) => ((IReplacement) obj0).StartDate;

    internal static DateTime J1qEr98jFKhthg8uD2Q([In] object obj0) => ((IReplacement) obj0).EndDate;

    internal static object RE2hQI8NLKEHyZHeFtO([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static DateTime Wjv0hN80LYtWgCx7w4G([In] object obj0) => ((IAbsence) obj0).StartDate;

    internal static DateTime HH1b7i8ZE641ddHalpZ([In] object obj0) => ((IAbsence) obj0).EndDate;

    internal static object fLECFA8A1yR9uYuwd93([In] object obj0, [In] object obj1) => (object) ((IMembershipService) obj0).GetSettings((EleWise.ELMA.Security.IUser) obj1);

    internal static bool uF5Mha8s2olWt97QOeb([In] object obj0) => ((MembershipSettings) obj0).EnablePasswordReset;

    internal static object x2xWfX87IYxbpKopxhl([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object z8SRjA8WHKRGovSAy6r([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);
  }
}
