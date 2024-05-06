// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.TrustedDeviceService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Services.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Service(EnableInterceptors = false)]
  public class TrustedDeviceService : ITrustedDeviceService
  {
    public const string UID_S = "34a2fe2c-fd83-42d9-a0bf-59ebe665f4a5";
    public static Guid UID;
    internal static TrustedDeviceService rNcDlaDPP19lBccNXtY;

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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
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

    private bool IsDeviceValid(Guid deviceToken, string info, string user)
    {
      int num1 = 6;
      string stringToken;
      UserTrustedDevices blob;
      string hash;
      Guid deviceToken1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            blob = ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, user);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 2 : 7;
            continue;
          case 2:
            hash = PublicClientService.Generate128ByteToken(stringToken);
            num1 = 3;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_2;
          case 5:
            deviceToken1 = deviceToken;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 0;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 1 : 5;
            continue;
          case 7:
            if (blob != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          default:
            stringToken = this.GetStringToken(info, user);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 1 : 0;
            continue;
        }
      }
label_2:
      return false;
label_8:
      // ISSUE: reference to a compiler-generated method
      return blob.Tokens.Where<DeviceToken>((Func<DeviceToken, bool>) (x => (string) TrustedDeviceService.\u003C\u003Ec__DisplayClass6_0.Eig7aIwkeljsvwTGwZXm((object) x) == hash)).ToList<DeviceToken>().Any<DeviceToken>((Func<DeviceToken, bool>) (x =>
      {
        int num2 = 1;
        Guid guid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              guid = TrustedDeviceService.\u003C\u003Ec__DisplayClass6_0.dX8ZiYwkn8h6kfH8hKYI((object) x);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return guid.Equals(deviceToken1);
      }));
    }

    private string GetStringToken(string info, string user) => (string) TrustedDeviceService.U3UYgDDdKUsvsxayLpi((object) info, (object) user);

    private string GetUserInfo(IUser user = null)
    {
      int num = 2;
      Guid guid;
      while (true)
      {
        EleWise.ELMA.Security.Models.IUser user1;
        switch (num)
        {
          case 1:
            user1 = this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            break;
          case 2:
            if (!(user is EleWise.ELMA.Security.Models.IUser user2))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 0;
              continue;
            }
            user1 = user2;
            break;
          default:
            goto label_2;
        }
        guid = TrustedDeviceService.VhawoODEUice31uXfeg((object) user1);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 0;
      }
label_2:
      return guid.ToString((string) TrustedDeviceService.cUCS27DG0D66LwhXOcr(1100789287 - 1555711667 ^ -454930298));
    }

    /// <summary>Зарегистрировать использование</summary>
    /// <param name="deviceToken"></param>
    /// <param name="user"></param>
    private void RegisterUsage(string deviceToken, IUser user)
    {
      int num = 8;
      while (true)
      {
        UserTrustedDevices blob;
        DeviceToken deviceToken1;
        string userInfo;
        Guid guid;
        switch (num)
        {
          case 1:
            if (blob == null)
            {
              num = 4;
              continue;
            }
            goto case 12;
          case 2:
            if (deviceToken1 == null)
            {
              num = 6;
              continue;
            }
            goto case 10;
          case 3:
            goto label_12;
          case 4:
            goto label_10;
          case 5:
            goto label_9;
          case 6:
            goto label_2;
          case 7:
            if (!Guid.TryParse(deviceToken, out guid))
            {
              num = 5;
              continue;
            }
            break;
          case 8:
            num = 7;
            continue;
          case 9:
            ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).SetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo, blob);
            num = 3;
            continue;
          case 10:
            deviceToken1.LastLogonDate = new DateTime?(TrustedDeviceService.LrXgmQDXaM02su5bY6d());
            num = 9;
            continue;
          case 11:
            blob = ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 0 : 1;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated method
            deviceToken1 = blob.Tokens.FirstOrDefault<DeviceToken>((Func<DeviceToken, bool>) (x => TrustedDeviceService.\u003C\u003Ec__DisplayClass9_0.k8h3UowDu01b9730NFp3((object) x) == guid));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 0 : 2;
            continue;
        }
        userInfo = this.GetUserInfo(user);
        num = 11;
      }
label_12:
      return;
label_10:
      return;
label_9:
      return;
label_2:;
    }

    /// <summary>Создает токен устройства</summary>
    /// <param name="name"></param>
    /// <param name="deviceInfo"></param>
    /// <param name="user"></param>
    /// <param name="token">Токен, может быть сгенерирован автоматически</param>
    /// <returns></returns>
    private DeviceToken CreateDeviceToken(
      string deviceInfo,
      string name,
      IUser user = null,
      Guid? token = null)
    {
      string stringToken = this.GetStringToken(deviceInfo, this.GetUserInfo(user));
      return new DeviceToken()
      {
        CreationDate = DateTime.Now,
        Name = name,
        Token = token ?? Guid.NewGuid(),
        Hash = PublicClientService.Generate128ByteToken(stringToken)
      };
    }

    /// <summary>
    /// Добавить доверенное устройство для текущего авторизованного пользователя
    /// </summary>
    /// <param name="deviceInfo">Информация идентифицирующая устройство, она не должна меняться со временем</param>
    /// <param name="deviceName">Имя, которым назвать это устройство</param>
    /// <returns>Токен добавленного доверенного устройства, который нужен в дальнейшем для проверки</returns>
    public string AddDevice(string deviceInfo, string deviceName)
    {
      int num = 7;
      Guid token;
      while (true)
      {
        string userInfo;
        UserTrustedDevices userTrustedDevices1;
        DeviceToken deviceToken;
        UserTrustedDevices userTrustedDevices2;
        switch (num)
        {
          case 1:
            userTrustedDevices1.Tokens.Add(deviceToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 2 : 4;
            continue;
          case 2:
            token = deviceToken.Token;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 0 : 0;
            continue;
          case 3:
            userTrustedDevices2 = ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
            if (userTrustedDevices2 == null)
            {
              num = 5;
              continue;
            }
            break;
          case 4:
            ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).SetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo, userTrustedDevices1);
            num = 2;
            continue;
          case 5:
            userTrustedDevices2 = new UserTrustedDevices();
            break;
          case 6:
            userInfo = this.GetUserInfo();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 3 : 2;
            continue;
          case 7:
            deviceToken = this.CreateDeviceToken(deviceInfo, deviceName);
            num = 6;
            continue;
          default:
            goto label_2;
        }
        userTrustedDevices1 = userTrustedDevices2;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 0 : 1;
      }
label_2:
      return token.ToString((string) TrustedDeviceService.cUCS27DG0D66LwhXOcr(-1527733619 - 442652394 ^ -1970375599));
    }

    /// <summary>Проверить доверенное устройство</summary>
    /// <param name="deviceToken">Токен устройства</param>
    /// <param name="deviceInfo">Информация идентифицирующая устройство</param>
    /// <param name="user">Пользователь, для которого осуществляется проверка</param>
    /// <returns><c>true</c>, если устройство прошло проверку</returns>
    public bool CheckDevice(string deviceToken, string deviceInfo, IUser user)
    {
      int num = 2;
      Guid result;
      bool flag1;
      bool flag2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!Guid.TryParse(deviceToken, out result))
            {
              num = 3;
              continue;
            }
            goto case 6;
          case 2:
            flag2 = this.TrustedLogonEnabled(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_10;
          case 4:
            this.RegisterUsage(deviceToken, user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 0 : 0;
            continue;
          case 5:
            if (flag1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 4 : 2;
              continue;
            }
            goto label_9;
          case 6:
            flag1 = this.IsDeviceValid(result, deviceInfo, this.GetUserInfo(user));
            num = 5;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return !flag2 | flag1;
label_10:
      return !flag2;
    }

    /// <summary>Удалить устройство</summary>
    /// <param name="deviceToken"></param>
    /// <param name="user"></param>
    public void DeleteDevice(string deviceToken, IUser user)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        UserTrustedDevices blob;
        DeviceToken deviceToken1;
        string userInfo;
        Guid guid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              blob = ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
              num2 = 10;
              continue;
            case 2:
              goto label_12;
            case 3:
              blob.Tokens.Remove(deviceToken1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              userInfo = this.GetUserInfo(user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 1 : 1;
              continue;
            case 6:
              if (deviceToken1 != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 2 : 3;
                continue;
              }
              goto label_5;
            case 7:
              if (!Guid.TryParse(deviceToken, out guid))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 8 : 9;
                continue;
              }
              goto case 5;
            case 8:
              num2 = 7;
              continue;
            case 9:
              goto label_18;
            case 10:
              if (blob == null)
              {
                num2 = 2;
                continue;
              }
              goto case 11;
            case 11:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              deviceToken1 = blob.Tokens.FirstOrDefault<DeviceToken>((Func<DeviceToken, bool>) (x => TrustedDeviceService.\u003C\u003Ec__DisplayClass13_0.cUPJAYwDovfVt88lDuxU(TrustedDeviceService.\u003C\u003Ec__DisplayClass13_0.ztm9tbwDRfVmEHfZnwgY((object) x), guid)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 6 : 6;
              continue;
            default:
              goto label_13;
          }
        }
label_13:
        ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).SetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo, blob);
        num1 = 4;
      }
label_12:
      return;
label_3:
      return;
label_18:
      return;
label_5:;
    }

    /// <summary>Ищет токены устройства по заданному deviceInfo</summary>
    /// <param name="deviceInfo"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public string[] GetDeviceTokens(string deviceInfo, IUser user = null)
    {
      int num1 = 6;
      string userInfo;
      string stringToken;
      List<DeviceToken> list;
      UserTrustedDevices blob;
      string hash;
      while (true)
      {
        switch (num1)
        {
          case 1:
            list = blob.Tokens.Where<DeviceToken>((Func<DeviceToken, bool>) (x => x.Hash == hash)).ToList<DeviceToken>();
            num1 = 8;
            continue;
          case 2:
            goto label_2;
          case 3:
            hash = (string) TrustedDeviceService.Hdus4WD9RkkDOsbEiUa((object) stringToken);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 1;
            continue;
          case 4:
            if (blob != null)
            {
              stringToken = this.GetStringToken(deviceInfo, userInfo);
              num1 = 3;
              continue;
            }
            num1 = 2;
            continue;
          case 5:
            userInfo = this.GetUserInfo(user);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 0 : 0;
            continue;
          case 6:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 5 : 5;
            continue;
          case 7:
            goto label_13;
          case 8:
            if (!list.Any<DeviceToken>())
            {
              num1 = 7;
              continue;
            }
            goto label_14;
          default:
            blob = ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
            num1 = 4;
            continue;
        }
      }
label_2:
      return new string[0];
label_13:
      return new string[0];
label_14:
      return list.Select<DeviceToken, string>((Func<DeviceToken, string>) (x =>
      {
        int num2 = 1;
        Guid guid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              guid = TrustedDeviceService.\u003C\u003Ec.aonB7QwDiRBu8tbW2Bee((object) x);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return guid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-404268492 ^ -404265530));
      })).ToArray<string>();
    }

    /// <summary>Возвращает список доверенных устройств</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public List<DeviceToken> GetDevices(IUser user)
    {
      string userInfo = this.GetUserInfo(user);
      UserTrustedDevices blob = DataAccessManager.BLOBManager.GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
      return blob == null ? new List<DeviceToken>() : blob.Tokens;
    }

    /// <summary>Вход только с доверенных устройств</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public bool TrustedLogonEnabled(IUser user = null)
    {
      int num = 1;
      UserTrustedDevices blob;
      string userInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            userInfo = this.GetUserInfo(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (blob == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 2 : 0;
              continue;
            }
            goto label_6;
          default:
            blob = DataAccessManager.BLOBManager.GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 1 : 3;
            continue;
        }
      }
label_5:
      return false;
label_6:
      return TrustedDeviceService.SG1RETD1KxG6eWHcrbr((object) blob);
    }

    /// <summary>Установить режим входа</summary>
    /// <param name="user"></param>
    /// <param name="enabled"></param>
    public void SetTrustedLogon(IUser user, bool enabled)
    {
      int num = 1;
      while (true)
      {
        UserTrustedDevices userTrustedDevices1;
        string userInfo;
        UserTrustedDevices userTrustedDevices2;
        switch (num)
        {
          case 1:
            userInfo = this.GetUserInfo(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).SetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo, userTrustedDevices1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 2 : 0;
            continue;
          case 4:
            TrustedDeviceService.gInwPcDMB7hmrx1O0ZR((object) userTrustedDevices1, enabled);
            num = 3;
            continue;
          case 5:
            userTrustedDevices2 = new UserTrustedDevices();
            break;
          default:
            userTrustedDevices2 = ((IBLOBDataManager) TrustedDeviceService.tvJSiaD5MXRmuPc4HXP()).GetBLOB<UserTrustedDevices>(TrustedDeviceService.UID, userInfo);
            if (userTrustedDevices2 == null)
            {
              num = 5;
              continue;
            }
            break;
        }
        userTrustedDevices1 = userTrustedDevices2;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 4 : 1;
      }
label_2:;
    }

    public TrustedDeviceService()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TrustedDeviceService()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TrustedDeviceService.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1207559533 ^ 1207556757));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool HpQXALDQWxCu1Yh3gWN() => TrustedDeviceService.rNcDlaDPP19lBccNXtY == null;

    internal static TrustedDeviceService DaLNssD8rcEkjyv9Yk5() => TrustedDeviceService.rNcDlaDPP19lBccNXtY;

    internal static object tvJSiaD5MXRmuPc4HXP() => (object) DataAccessManager.BLOBManager;

    internal static object U3UYgDDdKUsvsxayLpi([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Guid VhawoODEUice31uXfeg([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Uid;

    internal static object cUCS27DG0D66LwhXOcr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime LrXgmQDXaM02su5bY6d() => DateTime.Now;

    internal static object Hdus4WD9RkkDOsbEiUa([In] object obj0) => (object) PublicClientService.Generate128ByteToken((string) obj0);

    internal static bool SG1RETD1KxG6eWHcrbr([In] object obj0) => ((UserTrustedDevices) obj0).LogonFromTrustedDevicesOnly;

    internal static void gInwPcDMB7hmrx1O0ZR([In] object obj0, bool value) => ((UserTrustedDevices) obj0).LogonFromTrustedDevicesOnly = value;
  }
}
