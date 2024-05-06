// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.PublicSignatureService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.Security.Cryptography;
using EleWise.ELMA.Web.Service;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Security.Services.API
{
  /// <summary>Сервис для работы с подписью запросов Public API</summary>
  [EleWise.ELMA.ComponentModel.Service]
  internal sealed class PublicSignatureService : IPublicSignatureService
  {
    private readonly IHmacService HmacService;
    private readonly IEcdhService EcdhService;
    internal static PublicSignatureService UNBIaFYWkgVUI4dtjW5;

    /// <summary>Ctor</summary>
    /// <param name="hmacService">Сервис реализующий подписание HMAC</param>
    /// <param name="ecdhService">Сервис реализующий согласование ключа по стандарту ECDH</param>
    public PublicSignatureService(IHmacService hmacService, IEcdhService ecdhService)
    {
      PublicSignatureService.W7ih5IYY28TSWN1DQie();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.EcdhService = ecdhService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 1 : 1;
            continue;
          default:
            this.HmacService = hmacService;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Проверка подписи запроса</summary>
    /// <param name="session">Сессия</param>
    /// <returns>Результат проверки</returns>
    public bool CheckRequestSignature(EleWise.ELMA.API.Models.IPublicClientSession session)
    {
      int num1 = 4;
      string signature;
      string normalizedRequest;
      EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              normalizedRequest = this.GetNormalizedRequest();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 0 : 8;
              continue;
            case 3:
              publicClientSession = session as EleWise.ELMA.Security.Models.API.IPublicClientSession;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 6 : 7;
              continue;
            case 4:
              goto label_5;
            case 5:
              goto label_7;
            case 6:
              goto label_11;
            case 7:
              if (publicClientSession != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            case 8:
              signature = (string) PublicSignatureService.mO4tLYYfmTUePWIimpS(PublicSignatureService.TGFgueYy0foQDrwmfcB(-550634672 ^ -550661812));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 1;
              continue;
            default:
              if (PublicSignatureService.JwPQKAYlHdXEsjd50MG((object) publicClientSession) != null)
              {
                num2 = 5;
                continue;
              }
              goto label_11;
          }
        }
label_5:
        PublicSignatureService.PGWHZEYVRXekwGoR187((object) session, PublicSignatureService.TGFgueYy0foQDrwmfcB(1076316568 ^ 1076306834));
        num1 = 3;
        continue;
label_7:
        if (publicClientSession.Secret.Length != 0)
          num1 = 2;
        else
          goto label_11;
      }
label_4:
      return this.HmacService.CheckSignature(normalizedRequest, publicClientSession.Secret, signature);
label_11:
      return true;
    }

    /// <summary>
    /// Первичное согласование информации для подписи при создание сессии
    /// </summary>
    /// <returns>Ключевая пара</returns>
    public IEcdhKey ProcessAuthInfo()
    {
      int num = 5;
      IEcdhKey ecdhKey;
      string hex;
      string str;
      byte[] byteArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) PublicSignatureService.iOe16uYcdaSYEUGvhis(PublicSignatureService.zkbhlkY4caqnDZ2xemU((object) this.EcdhService, (object) ecdhKey.PublicKey));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 2 : 0;
            continue;
          case 2:
            this.SetResponseHeader((string) PublicSignatureService.TGFgueYy0foQDrwmfcB(-1277472395 ^ -1277478039), str);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 0;
            continue;
          case 3:
            if (ecdhKey != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 4:
            if (!string.IsNullOrEmpty(hex))
            {
              byteArray = PublicSignatureService.HexStringToByteArray((object) hex);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 2 : 6;
              continue;
            }
            num = 7;
            continue;
          case 5:
            hex = (string) PublicSignatureService.mO4tLYYfmTUePWIimpS(PublicSignatureService.TGFgueYy0foQDrwmfcB(-347045778 ^ -347018638));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 4 : 2;
            continue;
          case 6:
            ecdhKey = this.EcdhService.DeriveKeyMaterial(byteArray);
            num = 3;
            continue;
          case 7:
            goto label_7;
          default:
            goto label_9;
        }
      }
label_7:
      return (IEcdhKey) null;
label_9:
      return ecdhKey;
    }

    private static byte[] HexStringToByteArray(object hex)
    {
      int num1 = 5;
      byte[] byteArray;
      int num2;
      int num3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 += 2;
            num1 = 7;
            continue;
          case 2:
          case 7:
            if (num2 >= num3)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 3:
            byteArray[num2 / 2] = PublicSignatureService.QHQVAwY8dipjGtB6yUp(PublicSignatureService.fRXwgaYQ7UVOOFIrnUl(hex, num2, 2), 16);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 1 : 1;
            continue;
          case 4:
            byteArray = new byte[num3 / 2];
            num1 = 6;
            continue;
          case 5:
            num3 = PublicSignatureService.PvxsGZYPiN7q0K8dynK(hex);
            num1 = 4;
            continue;
          case 6:
            num2 = 0;
            num1 = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return byteArray;
    }

    private static string ByteArrayToString(object ba) => ((string) PublicSignatureService.nDQAxcY57h4Q6wEYV56(ba)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617713646), "");

    private string GetVerb()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (WebOperationContext.Current == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (string) PublicSignatureService.Lvqg1gYGxPxDWOLXGqS(PublicSignatureService.JPPUfXYECnmjbaBvFSJ(PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V()));
label_5:
      return string.Empty;
    }

    private string GetNormalizedRequest()
    {
      int num = 2;
      string resource;
      string queryParams;
      string verb;
      Dictionary<string, string> headers;
      string contentType;
      byte[] requestBody;
      while (true)
      {
        string str;
        switch (num)
        {
          case 1:
            requestBody = this.GetRequestBody();
            num = 6;
            continue;
          case 2:
            verb = this.GetVerb();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          case 4:
            queryParams = this.GetQueryParams();
            num = 3;
            continue;
          case 5:
            headers = this.GetHeaders((ICollection<string>) PublicSignatureService.qFEMNiYXyu4r5kbx3Fl((object) APIRouteProvider.GetRequestHeader((string) PublicSignatureService.TGFgueYy0foQDrwmfcB(-1277802350 ^ -1277812064)), (object) new char[2]
            {
              ',',
              ';'
            }));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 2 : 7;
            continue;
          case 6:
            if (PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V() == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 0 : 0;
              continue;
            }
            str = ((WebOperationContext) PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V()).IncomingRequest.ContentType;
            break;
          case 7:
            resource = this.GetResource();
            num = 4;
            continue;
          default:
            str = string.Empty;
            break;
        }
        contentType = str;
        num = 5;
      }
label_4:
      return this.HmacService.GetNormalizedMessage(verb, resource, queryParams, headers, contentType, requestBody);
    }

    private Dictionary<string, string> GetHeaders(ICollection<string> headerNames) => headerNames.ToDictionary<string, string, string>((Func<string, string>) (hn => hn), (Func<string, string>) (hn => (string) PublicSignatureService.\u003C\u003Ec.ooT7TEw0wydLvertO9YB((object) hn)));

    private string GetResource()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V() != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) PublicSignatureService.gbWNFHY1tBrPedcGFc2((object) ((UriTemplateMatch) PublicSignatureService.OY85jvY9KIYOH0FuCKP(PublicSignatureService.JPPUfXYECnmjbaBvFSJ(PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V()))).RequestUri);
label_5:
      return string.Empty;
    }

    private byte[] GetRequestBody()
    {
      int num1 = 3;
      XmlDictionaryReader dictionaryReader;
      while (true)
      {
        int num2 = num1;
        Message message;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              goto label_20;
            case 3:
              if (PublicSignatureService.uP5PSBYMiq3lFvCw155() == null)
              {
                num2 = 2;
                continue;
              }
              message = (Message) PublicSignatureService.GumtRwYBLYTdbVbyTU9(PublicSignatureService.NkgioXYhwgBcIv4Bl5E(PublicSignatureService.uP5PSBYMiq3lFvCw155()));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_22;
            case 5:
              goto label_19;
            default:
              if (!PublicSignatureService.Og47iSYp9Nv9IbhUjqx((object) message))
              {
                dictionaryReader = (XmlDictionaryReader) PublicSignatureService.C1CrDcYOwXkFIMf3Cm9((object) message);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 1 : 1;
                continue;
              }
              goto label_18;
          }
        }
label_18:
        num1 = 4;
      }
label_5:
      byte[] requestBody;
      try
      {
        int num3;
        if (!dictionaryReader.Read())
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 3 : 2;
        else
          goto label_8;
label_7:
        string str;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_8;
            case 2:
            case 4:
              goto label_19;
            case 5:
              requestBody = (byte[]) PublicSignatureService.MmE7i7YFtb3nRPtvGsQ((object) Encoding.UTF8, (object) str);
              num3 = 2;
              continue;
            default:
              requestBody = (byte[]) null;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 1 : 4;
              continue;
          }
        }
label_8:
        str = (string) PublicSignatureService.Jys7kdYTCPTkUwEmcHV((object) dictionaryReader);
        num3 = 5;
        goto label_7;
      }
      finally
      {
        int num4;
        if (dictionaryReader == null)
          num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 2 : 2;
        else
          goto label_14;
label_13:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_14:
        PublicSignatureService.Xjyo0cYvc5eOKZIihlL((object) dictionaryReader);
        num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0)
        {
          num4 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
label_19:
      return requestBody;
label_20:
      return (byte[]) null;
label_22:
      return (byte[]) null;
    }

    private string GetQueryParams()
    {
      int num = 3;
      object obj;
      HttpRequestMessageProperty requestMessageProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((MessageProperties) PublicSignatureService.tINN2JYqR6Iflt4YvyD(PublicSignatureService.uP5PSBYMiq3lFvCw155())).TryGetValue((string) PublicSignatureService.zff4k6Yg1IG4qd4oCZN(), out obj))
            {
              num = 5;
              continue;
            }
            goto label_10;
          case 2:
            goto label_10;
          case 3:
            if (PublicSignatureService.uP5PSBYMiq3lFvCw155() == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 2 : 1;
              continue;
            }
            goto case 1;
          case 4:
            if (requestMessageProperty != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 5:
            requestMessageProperty = obj as HttpRequestMessageProperty;
            num = 4;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return requestMessageProperty.QueryString;
label_10:
      return string.Empty;
    }

    private void SetResponseHeader(string headerName, string value)
    {
      int num = 1;
      HttpResponseMessageProperty responseMessageProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V() != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
              continue;
            }
            responseMessageProperty = new HttpResponseMessageProperty();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 5 : 4;
            continue;
          case 2:
            goto label_6;
          case 3:
            PublicSignatureService.yYMsnRY2686k0oa1ETR(PublicSignatureService.Usmm34YnHUJEtx1brRs(PublicSignatureService.uP5PSBYMiq3lFvCw155()), PublicSignatureService.Qqnp9iYLCmdFkZuqM66(), (object) responseMessageProperty);
            num = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            ((NameValueCollection) PublicSignatureService.B9sGW2Ye0tTSrlDSrJ6((object) responseMessageProperty)).Add(headerName, value);
            num = 3;
            continue;
          default:
            ((NameValueCollection) PublicSignatureService.D3HrglYItc5hlZVdBR5(PublicSignatureService.s1g89rYJxvsvL8xg6Pv(PublicSignatureService.SnZ2EcYd1XW4Ik6sQ4V()))).Add(headerName, value);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 1 : 2;
            continue;
        }
      }
label_6:
      return;
label_2:;
    }

    internal static void W7ih5IYY28TSWN1DQie() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool BngIC8YrJMve51LSvNH() => PublicSignatureService.UNBIaFYWkgVUI4dtjW5 == null;

    internal static PublicSignatureService wMilRKYSj8g9g8DhYkF() => PublicSignatureService.UNBIaFYWkgVUI4dtjW5;

    internal static object TGFgueYy0foQDrwmfcB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void PGWHZEYVRXekwGoR187([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object JwPQKAYlHdXEsjd50MG([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).Secret;

    internal static object mO4tLYYfmTUePWIimpS([In] object obj0) => (object) APIRouteProvider.GetRequestHeader((string) obj0);

    internal static object zkbhlkY4caqnDZ2xemU([In] object obj0, [In] object obj1) => (object) ((IEcdhService) obj0).DotNetToUncompressed((byte[]) obj1);

    internal static object iOe16uYcdaSYEUGvhis([In] object obj0) => (object) PublicSignatureService.ByteArrayToString(obj0);

    internal static int PvxsGZYPiN7q0K8dynK([In] object obj0) => ((string) obj0).Length;

    internal static object fRXwgaYQ7UVOOFIrnUl([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static byte QHQVAwY8dipjGtB6yUp([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static object nDQAxcY57h4Q6wEYV56([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object SnZ2EcYd1XW4Ik6sQ4V() => (object) WebOperationContext.Current;

    internal static object JPPUfXYECnmjbaBvFSJ([In] object obj0) => (object) ((WebOperationContext) obj0).IncomingRequest;

    internal static object Lvqg1gYGxPxDWOLXGqS([In] object obj0) => (object) ((IncomingWebRequestContext) obj0).Method;

    internal static object qFEMNiYXyu4r5kbx3Fl([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object OY85jvY9KIYOH0FuCKP([In] object obj0) => (object) ((IncomingWebRequestContext) obj0).UriTemplateMatch;

    internal static object gbWNFHY1tBrPedcGFc2([In] object obj0) => (object) ((Uri) obj0).AbsolutePath;

    internal static object uP5PSBYMiq3lFvCw155() => (object) OperationContext.Current;

    internal static object NkgioXYhwgBcIv4Bl5E([In] object obj0) => (object) ((OperationContext) obj0).RequestContext;

    internal static object GumtRwYBLYTdbVbyTU9([In] object obj0) => (object) ((RequestContext) obj0).RequestMessage;

    internal static bool Og47iSYp9Nv9IbhUjqx([In] object obj0) => ((Message) obj0).IsEmpty;

    internal static object C1CrDcYOwXkFIMf3Cm9([In] object obj0) => (object) ((Message) obj0).GetReaderAtBodyContents();

    internal static object Jys7kdYTCPTkUwEmcHV([In] object obj0) => (object) ((XmlReader) obj0).ReadContentAsString();

    internal static object MmE7i7YFtb3nRPtvGsQ([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static void Xjyo0cYvc5eOKZIihlL([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object tINN2JYqR6Iflt4YvyD([In] object obj0) => (object) ((OperationContext) obj0).IncomingMessageProperties;

    internal static object zff4k6Yg1IG4qd4oCZN() => (object) HttpRequestMessageProperty.Name;

    internal static object s1g89rYJxvsvL8xg6Pv([In] object obj0) => (object) ((WebOperationContext) obj0).OutgoingResponse;

    internal static object D3HrglYItc5hlZVdBR5([In] object obj0) => (object) ((OutgoingWebResponseContext) obj0).Headers;

    internal static object B9sGW2Ye0tTSrlDSrJ6([In] object obj0) => (object) ((HttpResponseMessageProperty) obj0).Headers;

    internal static object Usmm34YnHUJEtx1brRs([In] object obj0) => (object) ((OperationContext) obj0).OutgoingMessageProperties;

    internal static object Qqnp9iYLCmdFkZuqM66() => (object) HttpResponseMessageProperty.Name;

    internal static void yYMsnRY2686k0oa1ETR([In] object obj0, [In] object obj1, [In] object obj2) => ((MessageProperties) obj0).Add((string) obj1, obj2);
  }
}
