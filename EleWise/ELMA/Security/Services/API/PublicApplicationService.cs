// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.PublicApplicationService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Threading;

namespace EleWise.ELMA.Security.Services.API
{
  /// <summary>
  /// Сервис внешних приложений, использует модели из <see cref="N:EleWise.ELMA.Security.Models.API" />
  /// </summary>
  [Service(Type = ComponentType.Server)]
  public class PublicApplicationService : IPublicApplicationService
  {
    internal const int TokenLength = 128;
    internal static byte[] IPadPublicHashCode;
    internal static byte[] IPadKPIPublicHashCode;
    private readonly IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager;
    private readonly PublicApplicationTokenManager applicationTokenManager;
    private readonly Dictionary<string, IPublicApplicationAuthValidator> authValidators;
    internal static readonly Guid AppUid_ECM;
    internal static readonly Guid AppUid_Agent;
    internal static readonly Guid AppUid_Designer;
    internal static readonly Guid AppUid_KPI;
    /// <summary>Идентификатор приложения сервера разработки</summary>
    internal static readonly Guid AppUid_DevServer;
    internal const string DefaultApplicationAuthor = "ELMA";
    internal const string DefaultApplicationSite = "http://www.elma-bpm.ru";
    /// <summary>
    /// Время задано на 15 мая 2300, чтобы продлять в определенных версиях.
    /// </summary>
    internal static readonly DateTime DefaultApplicationExpireDateTime;
    /// <summary>Вечное время токена</summary>
    internal static readonly DateTime DefaultApplicationInfiniteExpireDateTime;
    internal static PublicApplicationService ExfsFdyUoH6poWAOHbT;

    /// <summary>Логгер</summary>
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
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
    /// Инициализирует новый экземпляр класса <see cref="T:System.Object" />.
    /// </summary>
    public PublicApplicationService(
      IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager,
      PublicApplicationTokenManager applicationTokenManager)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.authValidators = new Dictionary<string, IPublicApplicationAuthValidator>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.applicationManager = applicationManager;
      this.applicationTokenManager = applicationTokenManager;
      PublicApplicationService.CheckedCache = (IDictionary<Type, bool>) new ConcurrentDictionary<Type, bool>();
    }

    internal static IEnumerable<PublicApplicationService.DefaultSystemApplication> DefaultApplications => (IEnumerable<PublicApplicationService.DefaultSystemApplication>) new PublicApplicationService.DefaultSystemApplication[5]
    {
      new PublicApplicationService.DefaultSystemApplication(PublicApplicationService.AppUid_Agent, z2jc63fLkugS1X8Q9N.tE1kD1vbB(784628100 ^ 784602070), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-468111058 ^ -468100282)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1608997871), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-468111058 ^ -468100120), PublicApplicationService.DefaultApplicationExpireDateTime, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-906676699 ^ -906666797)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550662126), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841234253)),
      new PublicApplicationService.DefaultSystemApplication(PublicApplicationService.AppUid_Designer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331096084), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901664654)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340806022), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901662802), PublicApplicationService.DefaultApplicationInfiniteExpireDateTime, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1013954274 ^ 1013963738)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1762575989 ^ 1762569201), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1527733619 - 442652394 ^ -1970395861)),
      new PublicApplicationService.DefaultSystemApplication(PublicApplicationService.AppUid_DevServer, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1743015995 ^ -1743011709), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1207559533 ^ 1207536177)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112589856), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-192923496 ^ 192916897), PublicApplicationService.DefaultApplicationInfiniteExpireDateTime, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1310136491 - -570921450 ^ -739240269)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(781628008 - 11982093 ^ 769634947), z2jc63fLkugS1X8Q9N.tE1kD1vbB(213026252 ^ 213054736)),
      new PublicApplicationService.DefaultSystemApplication(PublicApplicationService.AppUid_ECM, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110885667 - -1624984630 ^ -559109435)), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-757186336 ^ -757190350)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(386642440 ^ 386662268), z2jc63fLkugS1X8Q9N.tE1kD1vbB(2086891181 ^ 2086863979), PublicApplicationService.DefaultApplicationExpireDateTime, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1115268484 ^ -1115281310)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169304548), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-315619370 - -1325004768 ^ 1009355992)),
      new PublicApplicationService.DefaultSystemApplication(PublicApplicationService.AppUid_KPI, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859386589)), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(213026252 ^ 213053938)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976429324), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~248518394 ^ -248544317), PublicApplicationService.DefaultApplicationExpireDateTime, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1424960806 ^ -1424972206)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123898511), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629935560 ^ -1103494022 ^ 1682539418))
    };

    internal void CreateDefaultPublicApplications()
    {
      int num1 = 2;
      IUnitOfWork unitOfWork;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_93;
          case 1:
            goto label_3;
          case 2:
            unitOfWork = (IUnitOfWork) PublicApplicationService.TGV3TyytW95oyM9FmO3((object) "");
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 1;
            continue;
          default:
            goto label_88;
        }
      }
label_93:
      return;
label_88:
      return;
label_3:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        PublicApplicationService.\u003C\u003Ec__DisplayClass24_0 cDisplayClass240 = new PublicApplicationService.\u003C\u003Ec__DisplayClass24_0();
        int num2 = 3;
        EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication1;
        IEnumerator<EleWise.ELMA.Security.Models.API.IPublicClientSession> enumerator1;
        IEnumerator<PublicApplicationService.DefaultSystemApplication> enumerator2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_85;
            case 1:
              try
              {
label_68:
                if (PublicApplicationService.f6tG3kyYVi6clZmvhig((object) enumerator2))
                  goto label_56;
                else
                  goto label_69;
label_47:
                EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication2;
                PublicApplicationService.DefaultSystemApplication current;
                EleWise.ELMA.Security.Models.API.IPublicApplicationToken applicationToken;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.applicationManager.Save(publicApplication2);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 7 : 16;
                      continue;
                    case 2:
                      applicationToken = this.applicationTokenManager.LoadOrNull(current.TokenUid);
                      num3 = 5;
                      continue;
                    case 3:
                      PublicApplicationService.dRyeXgy6iZOVTr2e02M((object) publicApplication2, PublicApplicationService.YAGVdnymS7A8yRGYqmt((object) current));
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 3 : 6;
                      continue;
                    case 4:
                      goto label_68;
                    case 5:
                      if (applicationToken == null)
                      {
                        num3 = 10;
                        continue;
                      }
                      goto case 23;
                    case 6:
                    case 21:
                      publicApplication2.Name = (string) PublicApplicationService.uQJW3yykdem3fpo5fxU((object) current);
                      num3 = 9;
                      continue;
                    case 7:
                      PublicApplicationService.wl7UBDy3gai91k92hPR((object) publicApplication2, true);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 1 : 1;
                      continue;
                    case 8:
                      goto label_44;
                    case 9:
                      PublicApplicationService.vJdPOAyaJBLGvHesiND((object) publicApplication2, PublicApplicationService.o4TSh9yDG2GiUbUE5qf((object) current));
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 20 : 19;
                      continue;
                    case 10:
                      applicationToken = this.applicationTokenManager.Create();
                      num3 = 11;
                      continue;
                    case 11:
                      PublicApplicationService.sP3su9yN3EUFtMyB4p5((object) applicationToken, PublicApplicationService.tqj5SIyjbXvPvA2EW3a((object) current));
                      num3 = 23;
                      continue;
                    case 12:
                      this.applicationTokenManager.Save(applicationToken);
                      num3 = 4;
                      continue;
                    case 13:
                      publicApplication2 = this.applicationManager.Create();
                      num3 = 3;
                      continue;
                    case 14:
                      publicApplication2 = this.applicationManager.LoadOrNull(current.Uid);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 15 : 15;
                      continue;
                    case 15:
                      if (publicApplication2 != null)
                      {
                        num3 = 21;
                        continue;
                      }
                      goto case 13;
                    case 16:
                      this.ActivateInternal(publicApplication2);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 2 : 0;
                      continue;
                    case 17:
                      PublicApplicationService.kRrCGRy7OsG6duO5ce7((object) applicationToken, PublicApplicationService.W2HX0yysjrKmnK1S8tL(PublicApplicationService.hp5TgHyZFf9Sqe2o5kU((object) current), PublicApplicationService.Jp75atyAqn4n0qYyYhe((object) applicationToken)) ? PublicApplicationService.hp5TgHyZFf9Sqe2o5kU((object) current) : PublicApplicationService.Jp75atyAqn4n0qYyYhe((object) applicationToken));
                      num3 = 22;
                      continue;
                    case 18:
                      PublicApplicationService.RtLTV3yiDD4JNvALmDk((object) publicApplication2, PublicApplicationService.qPQ1DNyCIOiatvixFJM((object) current));
                      num3 = 7;
                      continue;
                    case 19:
                      PublicApplicationService.i04GhWySWHeIhK060nx((object) applicationToken, true);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 12 : 10;
                      continue;
                    case 20:
                      PublicApplicationService.R3bCYLyxNxb4AUwYVTF((object) publicApplication2, (object) current.Author);
                      num3 = 18;
                      continue;
                    case 22:
                      PublicApplicationService.r1swvLyrUEbh8krtM0i((object) applicationToken, PublicApplicationService.Nq3MAUyWPV8dC0HaiBV((object) current));
                      num3 = 19;
                      continue;
                    case 23:
                      PublicApplicationService.PeWocjy0pfwkbWv7sw7((object) applicationToken, (object) publicApplication2);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 17;
                      continue;
                    default:
                      goto label_56;
                  }
                }
label_56:
                current = enumerator2.Current;
                num3 = 14;
                goto label_47;
label_69:
                num3 = 8;
                goto label_47;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 2 : 2;
                else
                  goto label_77;
label_75:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_77:
                PublicApplicationService.qYhwD0yyDItit9D10MS((object) enumerator2);
                num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0)
                {
                  num4 = 0;
                  goto label_75;
                }
                else
                  goto label_75;
              }
            case 2:
              try
              {
label_28:
                if (enumerator1.MoveNext())
                  goto label_31;
                else
                  goto label_29;
label_10:
                IEnumerator<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken> enumerator3;
                EleWise.ELMA.Security.Models.API.IPublicClientSession current;
                // ISSUE: variable of a compiler-generated type
                PublicApplicationService.\u003C\u003Ec__DisplayClass24_1 cDisplayClass241;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_31;
                    case 2:
                    case 7:
                      goto label_28;
                    case 3:
                      PublicClientCacheTokenManager instance = PublicClientCacheTokenManager.Instance;
                      ParameterExpression parameterExpression = (ParameterExpression) PublicApplicationService.VCRaoUy8qvyCHjEGZRU(typeof (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken), PublicApplicationService.BHD0q8yVPuxbtO3n1fv(-1028265253 << 4 ^ 727614090));
                      // ISSUE: method reference
                      // ISSUE: type reference
                      // ISSUE: field reference
                      Expression<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, bool>> condition = Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientCacheToken, bool>>((Expression) PublicApplicationService.i7YOh7yQatQd0YWqRO2(PublicApplicationService.rYWZ8eyfRYRPrg51vZ0((object) parameterExpression, (object) (MethodInfo) PublicApplicationService.n9mip8yls5gHy41iqKI(__methodref (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken.get_Session))), PublicApplicationService.Phv8dAyPUiLEuSTL7mw((object) Expression.Constant((object) cDisplayClass241, PublicApplicationService.qRIgx9y4SNuMYK5HQNS(__typeref (PublicApplicationService.\u003C\u003Ec__DisplayClass24_1))), (object) FieldInfo.GetFieldFromHandle(__fieldref (PublicApplicationService.\u003C\u003Ec__DisplayClass24_1.session)))), parameterExpression);
                      enumerator3 = instance.Find(condition).GetEnumerator();
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 4 : 4;
                      continue;
                    case 4:
                      try
                      {
label_15:
                        if (PublicApplicationService.f6tG3kyYVi6clZmvhig((object) enumerator3))
                          goto label_13;
                        else
                          goto label_16;
label_12:
                        int num6;
                        switch (num6)
                        {
                          case 1:
                            goto label_15;
                          case 2:
                            break;
                          default:
                            goto label_27;
                        }
label_13:
                        PublicApplicationService.j4IYZ2y5JjY6JD8au1N((object) enumerator3.Current);
                        num6 = 1;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0)
                        {
                          num6 = 0;
                          goto label_12;
                        }
                        else
                          goto label_12;
label_16:
                        num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 0;
                        goto label_12;
                      }
                      finally
                      {
                        if (enumerator3 != null)
                        {
                          int num7 = 0;
                          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0)
                            num7 = 0;
                          while (true)
                          {
                            switch (num7)
                            {
                              case 1:
                                goto label_22;
                              default:
                                PublicApplicationService.qYhwD0yyDItit9D10MS((object) enumerator3);
                                num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 1 : 1;
                                continue;
                            }
                          }
                        }
label_22:;
                      }
                    case 5:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass241 = new PublicApplicationService.\u003C\u003Ec__DisplayClass24_1();
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 2 : 8;
                      continue;
                    case 6:
label_27:
                      PublicApplicationService.j4IYZ2y5JjY6JD8au1N((object) current);
                      num5 = 2;
                      continue;
                    case 8:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass241.session = current;
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 3 : 3;
                      continue;
                    case 9:
                      goto label_40;
                    default:
                      if (current == null)
                      {
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 7 : 6;
                        continue;
                      }
                      goto case 5;
                  }
                }
label_29:
                num5 = 9;
                goto label_10;
label_31:
                current = enumerator1.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0)
                {
                  num5 = 0;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        PublicApplicationService.qYhwD0yyDItit9D10MS((object) enumerator1);
                        num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_38;
                    }
                  }
                }
label_38:;
              }
            case 3:
              enumerator2 = PublicApplicationService.DefaultApplications.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 1;
              continue;
            case 4:
              this.applicationManager.Delete(publicApplication1);
              num2 = 11;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass240.androidApp == null)
              {
                num2 = 12;
                continue;
              }
              goto case 13;
            case 6:
label_40:
              // ISSUE: reference to a compiler-generated field
              this.applicationManager.Delete(cDisplayClass240.androidApp);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 9 : 1;
              continue;
            case 7:
              if (publicApplication1 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 4 : 8;
                continue;
              }
              goto case 4;
            case 8:
            case 11:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass240.androidApp = this.applicationManager.LoadOrNull(new Guid((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(-1341618464 ^ -1341591504)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 5;
              continue;
            case 9:
            case 12:
              PublicApplicationService.cvxMS4ydG19Ji9rxNoO((object) unitOfWork);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
              continue;
            case 10:
label_44:
              publicApplication1 = this.applicationManager.LoadOrNull(new Guid((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(-1743015995 ^ -1743005375)));
              num2 = 7;
              continue;
            case 13:
              ParameterExpression parameterExpression1;
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              enumerator1 = PublicClientSessionManager.Instance.Find(Expression.Lambda<Func<EleWise.ELMA.Security.Models.API.IPublicClientSession, bool>>((Expression) PublicApplicationService.i7YOh7yQatQd0YWqRO2(PublicApplicationService.rYWZ8eyfRYRPrg51vZ0((object) parameterExpression1, (object) (MethodInfo) PublicApplicationService.n9mip8yls5gHy41iqKI(__methodref (EleWise.ELMA.Security.Models.API.IPublicClientSession.get_Application))), PublicApplicationService.Phv8dAyPUiLEuSTL7mw(PublicApplicationService.Ko7riqycUaNs5ul7mOt((object) cDisplayClass240, PublicApplicationService.qRIgx9y4SNuMYK5HQNS(__typeref (PublicApplicationService.\u003C\u003Ec__DisplayClass24_0))), (object) FieldInfo.GetFieldFromHandle(__fieldref (PublicApplicationService.\u003C\u003Ec__DisplayClass24_0.androidApp)))), parameterExpression1)).GetEnumerator();
              num2 = 2;
              continue;
            default:
              goto label_81;
          }
        }
label_85:
        return;
label_81:;
      }
      catch (Exception ex)
      {
        int num9 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0)
          num9 = 1;
        while (true)
        {
          switch (num9)
          {
            case 0:
              goto label_79;
            case 1:
              PublicApplicationService.Y1O91LyE05uOImdnTIy((object) this.Logger, (object) ex);
              num9 = 2;
              continue;
            case 2:
              PublicApplicationService.UNJv3WyGVBU7jbMAWKi((object) unitOfWork);
              num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
              continue;
            default:
              goto label_76;
          }
        }
label_79:
        return;
label_76:;
      }
      finally
      {
        if (unitOfWork != null)
        {
          int num10 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0)
            num10 = 1;
          while (true)
          {
            switch (num10)
            {
              case 1:
                PublicApplicationService.qYhwD0yyDItit9D10MS((object) unitOfWork);
                num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 0 : 0;
                continue;
              default:
                goto label_95;
            }
          }
        }
label_95:;
      }
    }

    internal bool RemoveApplicationInternal(EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              goto label_6;
            case 2:
              goto label_3;
            case 4:
              if (publicApplication == null)
              {
                num2 = 3;
                continue;
              }
              break;
          }
          if (publicApplication.IsSystem)
            num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 1 : 1;
          else
            break;
        }
        this.applicationManager.Delete(publicApplication);
        num1 = 2;
      }
label_3:
      return true;
label_6:
      return false;
    }

    internal bool ActivateInternal(EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.applicationManager.Save(publicApplication);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (publicApplication != null)
            {
              publicApplication.IsActive = true;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 1;
              continue;
            }
            num = 2;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return false;
label_7:
      return true;
    }

    internal bool DeActivateInternal(EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.applicationManager.Save(publicApplication);
            num = 4;
            continue;
          case 2:
            publicApplication.IsActive = false;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 1 : 0;
            continue;
          case 3:
            if (publicApplication != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return true;
label_5:
      return false;
    }

    internal static string GenerateApplicationToken(Guid applicationUid, DateTime expire) => (string) PublicApplicationService.GJCP5DyXa3optxM2d5U((object) (applicationUid.ToString((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(-819366706 ^ -819377348)) + (object) expire.Ticks));

    internal EleWise.ELMA.Security.Models.API.IPublicApplicationToken CreateApplicationTokenInternal(
      EleWise.ELMA.Security.Models.API.IPublicApplication application,
      DateTime expire,
      bool isSystem = false)
    {
      int num1 = 2;
      EleWise.ELMA.Security.Models.API.IPublicApplicationToken applicationTokenInternal;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (PublicApplicationService.W3ET2Gy1pTEJj2Zc3Qv(expire, PublicApplicationService.yk7PUUy9unJahtxQYau()))
              {
                num2 = 4;
                continue;
              }
              applicationTokenInternal = this.applicationTokenManager.Create();
              num2 = 7;
              continue;
            case 2:
              if (application != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 1 : 1;
                continue;
              }
              goto label_9;
            case 3:
              goto label_14;
            case 4:
              goto label_9;
            case 5:
              PublicApplicationService.r1swvLyrUEbh8krtM0i((object) applicationTokenInternal, PublicApplicationService.oF96fvyhNUEirIt7RB7(PublicApplicationService.C3jIYxyMaAI3QVtHc3P((object) application), expire));
              num2 = 6;
              continue;
            case 6:
              PublicApplicationService.i04GhWySWHeIhK060nx((object) applicationTokenInternal, isSystem);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 8 : 6;
              continue;
            case 7:
              PublicApplicationService.PeWocjy0pfwkbWv7sw7((object) applicationTokenInternal, (object) application);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 0;
              continue;
            case 8:
              goto label_5;
            default:
              PublicApplicationService.kRrCGRy7OsG6duO5ce7((object) applicationTokenInternal, expire);
              num2 = 5;
              continue;
          }
        }
label_5:
        this.applicationTokenManager.Save(applicationTokenInternal);
        num1 = 3;
      }
label_9:
      return (EleWise.ELMA.Security.Models.API.IPublicApplicationToken) null;
label_14:
      return applicationTokenInternal;
    }

    public IEnumerable<EleWise.ELMA.API.Models.IPublicApplication> Applications => (IEnumerable<EleWise.ELMA.API.Models.IPublicApplication>) this.applicationManager.FindAll();

    public bool CreateApplication(EleWise.ELMA.API.Models.IPublicApplication application)
    {
      int num = 10;
      EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication1;
      EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            PublicApplicationService.y1ZsgqyF2hmQxa5bjlX((object) publicApplication2, PublicApplicationService.bonIcqyTovyH6HygBfY((object) application));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
            continue;
          case 3:
            if (publicApplication1 != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 3 : 4;
              continue;
            }
            publicApplication2 = this.applicationManager.Create();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 12 : 6;
            continue;
          case 4:
            if (this.applicationManager.IsNew(publicApplication1))
            {
              this.applicationManager.Save(publicApplication1);
              num = 7;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 1;
            continue;
          case 5:
            PublicApplicationService.dRyeXgy6iZOVTr2e02M((object) publicApplication2, application.Uid);
            num = 14;
            continue;
          case 6:
            goto label_17;
          case 7:
            goto label_15;
          case 8:
            publicApplication2.Description = (string) PublicApplicationService.c45BSBypvgWMB86qLAu((object) application);
            num = 11;
            continue;
          case 9:
            publicApplication1 = application as EleWise.ELMA.Security.Models.API.IPublicApplication;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 3 : 1;
            continue;
          case 10:
            if (application != null)
            {
              num = 9;
              continue;
            }
            goto label_9;
          case 11:
            PublicApplicationService.Hx0BBKyOsR5APZMABMc((object) publicApplication2, false);
            num = 2;
            continue;
          case 12:
            publicApplication2.Author = (string) PublicApplicationService.WAsVa3yBiKwdv759FMa((object) application);
            num = 8;
            continue;
          case 13:
            goto label_9;
          case 14:
            this.applicationManager.Save(publicApplication2);
            num = 6;
            continue;
          default:
            PublicApplicationService.RtLTV3yiDD4JNvALmDk((object) publicApplication2, PublicApplicationService.kSX3kZyv16QpvVjkI22((object) application));
            num = 5;
            continue;
        }
      }
label_9:
      return false;
label_11:
      return false;
label_15:
      return true;
label_17:
      return true;
    }

    public bool RemoveApplication(Guid applicationUid)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!PublicApplicationService.EZdvtbyq1c5Nu4MdkPD(applicationUid, Guid.Empty))
            {
              publicApplication = this.applicationManager.LoadOrNull(applicationUid);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 1 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return this.RemoveApplicationInternal(publicApplication);
label_3:
      return false;
    }

    public bool IsActive(Guid applicationUid)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (publicApplication == null)
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 2:
            goto label_9;
          case 3:
            goto label_4;
          case 4:
            if (!PublicApplicationService.EZdvtbyq1c5Nu4MdkPD(applicationUid, Guid.Empty))
            {
              publicApplication = this.applicationManager.LoadOrNull(applicationUid);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 1 : 1;
              continue;
            }
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      return false;
label_8:
      return PublicApplicationService.J7G3pcygZJvVSdhKdae((object) publicApplication);
label_9:
      return false;
    }

    public bool Activate(Guid applicationUid)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (PublicApplicationService.EZdvtbyq1c5Nu4MdkPD(applicationUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 1;
              continue;
            }
            publicApplication = this.applicationManager.LoadOrNull(applicationUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_4:
      return false;
label_6:
      return this.ActivateInternal(publicApplication);
    }

    public bool DeActivate(Guid applicationUid)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.API.IPublicApplication publicApplication;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!PublicApplicationService.EZdvtbyq1c5Nu4MdkPD(applicationUid, Guid.Empty))
            {
              publicApplication = this.applicationManager.LoadOrNull(applicationUid);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return false;
label_4:
      return this.DeActivateInternal(publicApplication);
    }

    public EleWise.ELMA.API.Models.IPublicApplicationToken CreateToken(
      Guid applicationUid,
      DateTime expire)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.API.IPublicApplication application;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.IsActive(applicationUid))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_6;
          case 3:
            goto label_4;
          default:
            application = this.applicationManager.LoadOrNull(applicationUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      return (EleWise.ELMA.API.Models.IPublicApplicationToken) null;
label_6:
      return (EleWise.ELMA.API.Models.IPublicApplicationToken) this.CreateApplicationTokenInternal(application, expire);
    }

    public bool IsTokenValid(string applicationToken, out EleWise.ELMA.API.Models.IPublicApplicationToken token)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.API.IPublicApplicationToken applicationToken1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (applicationToken == null)
            {
              num = 11;
              continue;
            }
            goto case 8;
          case 2:
            token = (EleWise.ELMA.API.Models.IPublicApplicationToken) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 1 : 1;
            continue;
          case 3:
          case 11:
            goto label_15;
          case 4:
            if (!this.IsActive(((EleWise.ELMA.Security.Models.API.IPublicApplication) PublicApplicationService.kDxNGNyeHTKI1tQARvt((object) applicationToken1)).Uid))
            {
              num = 9;
              continue;
            }
            goto case 10;
          case 5:
            if (applicationToken1 != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 6:
            goto label_14;
          case 7:
          case 9:
            this.RemoveToken(applicationToken);
            num = 6;
            continue;
          case 8:
            if (PublicApplicationService.jjFCREyJ5H8udl01Xcg((object) applicationToken) == 128)
            {
              applicationToken1 = (EleWise.ELMA.Security.Models.API.IPublicApplicationToken) PublicApplicationService.OxLT8ryIlq4TLpbso2U((object) this.applicationTokenManager, (object) applicationToken);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 4 : 5;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 1 : 3;
            continue;
          case 10:
            token = (EleWise.ELMA.API.Models.IPublicApplicationToken) applicationToken1;
            num = 13;
            continue;
          case 12:
            if (PublicApplicationService.kDxNGNyeHTKI1tQARvt((object) applicationToken1) == null)
            {
              num = 7;
              continue;
            }
            goto case 4;
          case 13:
            goto label_4;
          default:
            if (PublicApplicationService.W2HX0yysjrKmnK1S8tL(PublicApplicationService.Jp75atyAqn4n0qYyYhe((object) applicationToken1), PublicApplicationService.yk7PUUy9unJahtxQYau()))
            {
              num = 12;
              continue;
            }
            goto case 7;
        }
      }
label_4:
      return true;
label_14:
      return false;
label_15:
      return false;
    }

    private IPublicApplicationAuthValidator GetDefaultApplicationValidator(
      string applicationToken)
    {
      int num1 = 9;
      IPublicApplicationAuthValidator validator;
      Dictionary<string, IPublicApplicationAuthValidator> authValidators;
      bool lockTaken;
      string str;
      string applicationToken1;
      while (true)
      {
        int num2 = num1;
        PublicApplicationService.DefaultSystemApplication systemApplication;
        IPublicApplicationAuthValidator[] array;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_28;
            case 2:
              goto label_40;
            case 3:
              if (!this.authValidators.TryGetValue(applicationToken1, out validator))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 21 : 14;
                continue;
              }
              goto label_37;
            case 4:
              if (array.Length == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 6 : 23;
                continue;
              }
              if (array.Length <= 1)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 10 : 6;
                continue;
              }
              goto case 16;
            case 5:
            case 11:
              if (PublicApplicationService.EZdvtbyq1c5Nu4MdkPD(PublicApplicationService.YAGVdnymS7A8yRGYqmt((object) systemApplication), PublicApplicationService.AppUid_KPI))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 3 : 15;
                continue;
              }
              goto case 6;
            case 6:
              authValidators = this.authValidators;
              num2 = 20;
              continue;
            case 7:
              goto label_8;
            case 8:
              applicationToken1 = applicationToken;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 3 : 3;
              continue;
            case 9:
              num2 = 8;
              continue;
            case 10:
              validator = ((IEnumerable<IPublicApplicationAuthValidator>) array).First<IPublicApplicationAuthValidator>();
              num2 = 18;
              continue;
            case 12:
              if (!PublicApplicationService.EZdvtbyq1c5Nu4MdkPD(systemApplication.Uid, PublicApplicationService.AppUid_ECM))
              {
                num2 = 5;
                continue;
              }
              goto case 13;
            case 13:
              PublicApplicationService.CheckIPadApplication((object) applicationToken1, (object) validator, (object) PublicApplicationService.IPadPublicHashCode);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 11 : 8;
              continue;
            case 14:
              goto label_34;
            case 15:
              PublicApplicationService.qc6fSWyzyglGeKj3ec9((object) applicationToken1, (object) validator, (object) PublicApplicationService.IPadKPIPublicHashCode);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 6 : 6;
              continue;
            case 16:
              str = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(784628100 ^ 784600666), ((IEnumerable<IPublicApplicationAuthValidator>) array).Select<IPublicApplicationAuthValidator, string>((Func<IPublicApplicationAuthValidator, string>) (p => p.GetType().FullName)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 22 : 16;
              continue;
            case 17:
              if (systemApplication != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 19 : 19;
                continue;
              }
              goto label_40;
            case 18:
              // ISSUE: reference to a compiler-generated method
              systemApplication = PublicApplicationService.DefaultApplications.FirstOrDefault<PublicApplicationService.DefaultSystemApplication>((Func<PublicApplicationService.DefaultSystemApplication, bool>) (a => PublicApplicationService.\u003C\u003Ec__DisplayClass39_0.aAxpM8w0WqBKxmemeJVC((object) a.DefaultToken, (object) applicationToken1)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 14 : 17;
              continue;
            case 19:
              if (!PublicApplicationService.cPyoCiyHcnu4FS5xL7o(PublicApplicationService.jB4SSBy2v0mCyFWRoFO((object) systemApplication), validator.GetType()))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 8 : 12;
                continue;
              }
              goto label_28;
            case 20:
              goto label_27;
            case 21:
              array = ((ComponentManager) PublicApplicationService.URB7DtynhXEotEr0907()).GetExtensionPoints<IPublicApplicationAuthValidator>().Where<IPublicApplicationAuthValidator>((Func<IPublicApplicationAuthValidator, bool>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (!string.IsNullOrEmpty((string) PublicApplicationService.\u003C\u003Ec__DisplayClass39_0.ghbAydw07TFkmRPsKfQp((object) p)))
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return ((string) PublicApplicationService.\u003C\u003Ec__DisplayClass39_0.ghbAydw07TFkmRPsKfQp((object) p)).Equals(applicationToken1, StringComparison.Ordinal);
label_3:
                return false;
              })).ToArray<IPublicApplicationAuthValidator>();
              num2 = 4;
              continue;
            case 22:
              goto label_35;
            case 23:
              goto label_23;
            default:
              goto label_37;
          }
        }
label_27:
        lockTaken = false;
        num1 = 7;
      }
label_8:
      try
      {
        Monitor.Enter((object) authValidators, ref lockTaken);
        int num4 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              this.authValidators[applicationToken1] = validator;
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
              continue;
            default:
              goto label_34;
          }
        }
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
        else
          goto label_15;
label_14:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_15:
        PublicApplicationService.ycU4xwVubXHDZqsmZmC((object) authValidators);
        num5 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0)
        {
          num5 = 2;
          goto label_14;
        }
        else
          goto label_14;
      }
label_23:
      throw new SecurityException((string) PublicApplicationService.vaWebfyLKKoyb8n1msw(PublicApplicationService.BHD0q8yVPuxbtO3n1fv(1245871191 - 2145700088 ^ -899824519), (object) new object[1]
      {
        (object) applicationToken1
      }));
label_28:
      throw new SecurityException((string) PublicApplicationService.vaWebfyLKKoyb8n1msw(PublicApplicationService.BHD0q8yVPuxbtO3n1fv(1245871191 - 2145700088 ^ -899822689), (object) new object[1]
      {
        (object) applicationToken1
      }));
label_34:
      return validator;
label_35:
      throw new SecurityException((string) PublicApplicationService.vaWebfyLKKoyb8n1msw(PublicApplicationService.BHD0q8yVPuxbtO3n1fv(658384612 ^ 658395394), (object) new object[2]
      {
        (object) applicationToken1,
        (object) str
      }));
label_37:
      return validator;
label_40:
      throw new SecurityException((string) PublicApplicationService.vaWebfyLKKoyb8n1msw(PublicApplicationService.BHD0q8yVPuxbtO3n1fv(--534238571 ^ 534227983), (object) new object[1]
      {
        (object) applicationToken1
      }));
    }

    private static void CheckIPadApplication(
      object applicationToken,
      object validator,
      object publicHashCode)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        FileStream fileStream;
        bool flag;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_29;
            case 2:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 1 : 0;
                continue;
              }
              goto label_22;
            case 3:
              flag = false;
              num2 = 7;
              continue;
            case 4:
              type = validator.GetType();
              num2 = 3;
              continue;
            case 5:
              goto label_20;
            case 6:
label_25:
              PublicApplicationService.CheckedCache.Add(type, flag);
              num2 = 2;
              continue;
            case 7:
              if (!PublicApplicationService.CheckedCache.TryGetValue(type, out flag))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 3 : 5;
                continue;
              }
              goto case 2;
            case 8:
              try
              {
                try
                {
                  byte[] numArray = (byte[]) PublicApplicationService.my5ZvtVbPWm7je0rVlS((object) new MD5CryptoServiceProvider(), (object) fileStream);
                  int num3 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0)
                    num3 = 0;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                      case 2:
                        flag = true;
                        num3 = 5;
                        continue;
                      case 3:
                        flag = false;
                        num3 = 4;
                        continue;
                      case 4:
                      case 5:
                        goto label_25;
                      default:
                        if (PublicApplicationService.PGNoIMVU1RmMGwsQ7ZE(publicHashCode, (object) numArray, PublicApplicationService.paD0vtVK9lhnB8UDFq0()))
                        {
                          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 1 : 1;
                          continue;
                        }
                        goto case 3;
                    }
                  }
                }
                finally
                {
                  PublicApplicationService.ecouUQVR7T7HhA1fTN4((object) fileStream);
                  int num4 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0)
                    num4 = 0;
                  switch (num4)
                  {
                    default:
                  }
                }
              }
              finally
              {
                int num5;
                if (fileStream == null)
                  num5 = 2;
                else
                  goto label_17;
label_16:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_17:
                fileStream.Dispose();
                num5 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0)
                {
                  num5 = 1;
                  goto label_16;
                }
                else
                  goto label_16;
              }
            default:
              goto label_22;
          }
        }
label_20:
        fileStream = new FileStream((string) PublicApplicationService.HPTvjXVw0AKVKnPUPGs((object) type.Assembly), FileMode.Open, FileAccess.Read);
        num1 = 8;
      }
label_29:
      return;
label_22:
      throw new SecurityException(EleWise.ELMA.SR.T((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(1185105284 ^ 1185102938), applicationToken));
    }

    public static IDictionary<Type, bool> CheckedCache { get; private set; }

    public bool HasUserAccess(string applicationToken, IUser user) => this.ValidateInternal(applicationToken, user);

    private bool ValidateInternal(string applicationToken, IUser user)
    {
      int num = 3;
      string applicationToken1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            applicationToken1 = applicationToken;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 4 : 2;
            continue;
          case 3:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated method
            if (PublicApplicationService.DefaultApplications.FirstOrDefault<PublicApplicationService.DefaultSystemApplication>((Func<PublicApplicationService.DefaultSystemApplication, bool>) (a => applicationToken1 == (string) PublicApplicationService.\u003C\u003Ec__DisplayClass46_0.fsWTbHw045VPgAJAKKBs((object) a))) == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return PublicApplicationService.Tyr5OAVoawTUaYyoEkb((object) this.GetDefaultApplicationValidator(applicationToken1), (object) user);
label_3:
      return true;
    }

    public bool UpdateToken(string applicationToken, DateTime expire)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.API.IPublicApplicationToken applicationToken1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (applicationToken != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              goto label_8;
            case 3:
              PublicApplicationService.kRrCGRy7OsG6duO5ce7((object) applicationToken1, expire);
              num2 = 5;
              continue;
            case 4:
              goto label_5;
            case 5:
              goto label_3;
            case 6:
              if (expire < PublicApplicationService.yk7PUUy9unJahtxQYau())
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 0 : 2;
                continue;
              }
              applicationToken1 = (EleWise.ELMA.Security.Models.API.IPublicApplicationToken) PublicApplicationService.OxLT8ryIlq4TLpbso2U((object) this.applicationTokenManager, (object) applicationToken);
              num2 = 7;
              continue;
            case 7:
              if (applicationToken1 != null)
              {
                num2 = 8;
                continue;
              }
              goto label_5;
            case 8:
              if (!PublicApplicationService.W3ET2Gy1pTEJj2Zc3Qv(PublicApplicationService.Jp75atyAqn4n0qYyYhe((object) applicationToken1), expire))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 4 : 4;
                continue;
              }
              goto case 3;
            case 9:
              goto label_4;
            default:
              if (PublicApplicationService.jjFCREyJ5H8udl01Xcg((object) applicationToken) == 128)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 2 : 6;
                continue;
              }
              goto label_8;
          }
        }
label_3:
        this.applicationTokenManager.Save(applicationToken1);
        num1 = 9;
      }
label_4:
      return true;
label_5:
      return false;
label_8:
      return false;
    }

    public bool RemoveToken(string applicationToken)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.API.IPublicApplicationToken applicationToken1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.applicationTokenManager.Delete(applicationToken1);
            num = 8;
            continue;
          case 2:
            if (PublicApplicationService.O2pjPYVtp2bwhlWnBZY((object) applicationToken1))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 3:
          case 7:
            goto label_6;
          case 4:
            if (applicationToken == null)
            {
              num = 3;
              continue;
            }
            goto case 6;
          case 5:
            if (applicationToken1 != null)
            {
              num = 2;
              continue;
            }
            goto label_12;
          case 6:
            if (PublicApplicationService.jjFCREyJ5H8udl01Xcg((object) applicationToken) == 128)
            {
              applicationToken1 = (EleWise.ELMA.Security.Models.API.IPublicApplicationToken) PublicApplicationService.OxLT8ryIlq4TLpbso2U((object) this.applicationTokenManager, (object) applicationToken);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 5 : 4;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 1 : 7;
            continue;
          case 8:
            goto label_11;
          default:
            goto label_12;
        }
      }
label_6:
      return false;
label_11:
      return true;
label_12:
      return false;
    }

    static PublicApplicationService()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              PublicApplicationService.DefaultApplicationInfiniteExpireDateTime = new DateTime(3000, 1, 1);
              num2 = 4;
              continue;
            case 2:
              PublicApplicationService.AppUid_Agent = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1609002079));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 3 : 0;
              continue;
            case 3:
              PublicApplicationService.AppUid_Designer = new Guid((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(--2002186503 ^ 2002160151));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 5 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_7;
            case 6:
              PublicApplicationService.AppUid_ECM = new Guid((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(1185105284 ^ 1185103868));
              num2 = 2;
              continue;
            case 7:
              byte[] numArray1 = new byte[16];
              // ISSUE: field reference
              PublicApplicationService.LHOpqEV6saHrfGh0xQo((object) numArray1, __fieldref (\u003CPrivateImplementationDetails\u003E.FB632E2F32A497B2592FA6089BFB7FA1A7EFC669));
              PublicApplicationService.IPadPublicHashCode = numArray1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 10 : 10;
              continue;
            case 8:
              PublicApplicationService.L2h9OiVmA2vcjlcil2V();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 4 : 7;
              continue;
            case 9:
              PublicApplicationService.AppUid_DevServer = new Guid((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(1224834736 ^ 1224803608));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
              continue;
            case 10:
              byte[] numArray2 = new byte[16];
              // ISSUE: field reference
              PublicApplicationService.LHOpqEV6saHrfGh0xQo((object) numArray2, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0031C7E0940EABEF8F3BA9231721A0F62D6453FC8C5));
              PublicApplicationService.IPadKPIPublicHashCode = numArray2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 2 : 6;
              continue;
            default:
              PublicApplicationService.DefaultApplicationExpireDateTime = new DateTime(2300, 5, 15);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 1 : 1;
              continue;
          }
        }
label_7:
        PublicApplicationService.AppUid_KPI = new Guid((string) PublicApplicationService.BHD0q8yVPuxbtO3n1fv(911364681 ^ 911354133));
        num1 = 9;
      }
label_3:;
    }

    internal static bool QYQ6WXyRxTDWCyU4CBB() => PublicApplicationService.ExfsFdyUoH6poWAOHbT == null;

    internal static PublicApplicationService HMMYb5yo7BEenm8hcGZ() => PublicApplicationService.ExfsFdyUoH6poWAOHbT;

    internal static object TGV3TyytW95oyM9FmO3([In] object obj0) => (object) UnitOfWork.New((string) obj0);

    internal static Guid YAGVdnymS7A8yRGYqmt([In] object obj0) => ((PublicApplicationService.DefaultSystemApplication) obj0).Uid;

    internal static void dRyeXgy6iZOVTr2e02M([In] object obj0, Guid value) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).Uid = value;

    internal static object uQJW3yykdem3fpo5fxU([In] object obj0) => (object) ((PublicApplicationService.DefaultSystemApplication) obj0).Name;

    internal static object o4TSh9yDG2GiUbUE5qf([In] object obj0) => (object) ((PublicApplicationService.DefaultSystemApplication) obj0).Description;

    internal static void vJdPOAyaJBLGvHesiND([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).Description = (string) obj1;

    internal static void R3bCYLyxNxb4AUwYVTF([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).Author = (string) obj1;

    internal static object qPQ1DNyCIOiatvixFJM([In] object obj0) => (object) ((PublicApplicationService.DefaultSystemApplication) obj0).Site;

    internal static void RtLTV3yiDD4JNvALmDk([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).Site = (string) obj1;

    internal static void wl7UBDy3gai91k92hPR([In] object obj0, bool value) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).IsSystem = value;

    internal static Guid tqj5SIyjbXvPvA2EW3a([In] object obj0) => ((PublicApplicationService.DefaultSystemApplication) obj0).TokenUid;

    internal static void sP3su9yN3EUFtMyB4p5([In] object obj0, Guid value) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).Uid = value;

    internal static void PeWocjy0pfwkbWv7sw7([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).Application = (EleWise.ELMA.Security.Models.API.IPublicApplication) obj1;

    internal static DateTime hp5TgHyZFf9Sqe2o5kU([In] object obj0) => ((PublicApplicationService.DefaultSystemApplication) obj0).TokenExpire;

    internal static DateTime Jp75atyAqn4n0qYyYhe([In] object obj0) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).Expire;

    internal static bool W2HX0yysjrKmnK1S8tL([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static void kRrCGRy7OsG6duO5ce7([In] object obj0, DateTime value) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).Expire = value;

    internal static object Nq3MAUyWPV8dC0HaiBV([In] object obj0) => (object) ((PublicApplicationService.DefaultSystemApplication) obj0).DefaultToken;

    internal static void r1swvLyrUEbh8krtM0i([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).Token = (string) obj1;

    internal static void i04GhWySWHeIhK060nx([In] object obj0, bool value) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).IsSystem = value;

    internal static bool f6tG3kyYVi6clZmvhig([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void qYhwD0yyDItit9D10MS([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object BHD0q8yVPuxbtO3n1fv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object n9mip8yls5gHy41iqKI([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object rYWZ8eyfRYRPrg51vZ0([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Type qRIgx9y4SNuMYK5HQNS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Ko7riqycUaNs5ul7mOt([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object Phv8dAyPUiLEuSTL7mw([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object i7YOh7yQatQd0YWqRO2([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object VCRaoUy8qvyCHjEGZRU([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static void j4IYZ2y5JjY6JD8au1N([In] object obj0) => ((IEntity) obj0).Delete();

    internal static void cvxMS4ydG19Ji9rxNoO([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static void Y1O91LyE05uOImdnTIy([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static void UNJv3WyGVBU7jbMAWKi([In] object obj0) => ((IUnitOfWork) obj0).Rollback();

    internal static object GJCP5DyXa3optxM2d5U([In] object obj0) => (object) PublicClientService.Generate128ByteToken((string) obj0);

    internal static DateTime yk7PUUy9unJahtxQYau() => DateTime.Now;

    internal static bool W3ET2Gy1pTEJj2Zc3Qv([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static Guid C3jIYxyMaAI3QVtHc3P([In] object obj0) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).Uid;

    internal static object oF96fvyhNUEirIt7RB7(Guid applicationUid, DateTime expire) => (object) PublicApplicationService.GenerateApplicationToken(applicationUid, expire);

    internal static object WAsVa3yBiKwdv759FMa([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicApplication) obj0).Author;

    internal static object c45BSBypvgWMB86qLAu([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicApplication) obj0).Description;

    internal static void Hx0BBKyOsR5APZMABMc([In] object obj0, bool value) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).IsActive = value;

    internal static object bonIcqyTovyH6HygBfY([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicApplication) obj0).Name;

    internal static void y1ZsgqyF2hmQxa5bjlX([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).Name = (string) obj1;

    internal static object kSX3kZyv16QpvVjkI22([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicApplication) obj0).Site;

    internal static bool EZdvtbyq1c5Nu4MdkPD([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool J7G3pcygZJvVSdhKdae([In] object obj0) => ((EleWise.ELMA.Security.Models.API.IPublicApplication) obj0).IsActive;

    internal static int jjFCREyJ5H8udl01Xcg([In] object obj0) => ((string) obj0).Length;

    internal static object OxLT8ryIlq4TLpbso2U([In] object obj0, [In] object obj1) => (object) ((PublicApplicationTokenManager) obj0).FindByToken((string) obj1);

    internal static object kDxNGNyeHTKI1tQARvt([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).Application;

    internal static object URB7DtynhXEotEr0907() => (object) ComponentManager.Current;

    internal static object vaWebfyLKKoyb8n1msw([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static Type jB4SSBy2v0mCyFWRoFO([In] object obj0) => ((PublicApplicationService.DefaultSystemApplication) obj0).ValidatorType;

    internal static bool cPyoCiyHcnu4FS5xL7o([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static void qc6fSWyzyglGeKj3ec9([In] object obj0, [In] object obj1, [In] object obj2) => PublicApplicationService.CheckIPadApplication(obj0, obj1, obj2);

    internal static void ycU4xwVubXHDZqsmZmC([In] object obj0) => Monitor.Exit(obj0);

    internal static object HPTvjXVw0AKVKnPUPGs([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static object my5ZvtVbPWm7je0rVlS([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object paD0vtVK9lhnB8UDFq0() => (object) StructuralComparisons.StructuralEqualityComparer;

    internal static bool PGNoIMVU1RmMGwsQ7ZE([In] object obj0, [In] object obj1, [In] object obj2) => ((IStructuralEquatable) obj0).Equals(obj1, (IEqualityComparer) obj2);

    internal static void ecouUQVR7T7HhA1fTN4([In] object obj0) => ((Stream) obj0).Close();

    internal static bool Tyr5OAVoawTUaYyoEkb([In] object obj0, [In] object obj1) => ((IPublicApplicationAuthValidator) obj0).Validate((IUser) obj1);

    internal static bool O2pjPYVtp2bwhlWnBZY([In] object obj0) => ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj0).IsSystem;

    internal static void L2h9OiVmA2vcjlcil2V() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static void LHOpqEV6saHrfGh0xQo([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal class DefaultSystemApplication : EleWise.ELMA.API.Models.IPublicApplication
    {
      private static PublicApplicationService.DefaultSystemApplication UYwVQiw0b2ycKrkF1Xke;

      /// <summary>
      /// Инициализирует новый экземпляр класса <see cref="T:System.Object" />.
      /// </summary>
      internal DefaultSystemApplication(
        Guid uid,
        string name,
        string description,
        string author,
        string site,
        DateTime tokenExpire,
        Guid tokenUid,
        string token,
        string validatorFullType)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.TokenExpire = tokenExpire;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 4;
              continue;
            case 2:
              this.Author = author;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 3 : 3;
              continue;
            case 3:
              this.Site = site;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 0 : 1;
              continue;
            case 4:
              this.TokenUid = tokenUid;
              num = 6;
              continue;
            case 5:
              this.Uid = uid;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 3 : 8;
              continue;
            case 6:
              this.DefaultToken = token;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 0 : 0;
              continue;
            case 7:
              this.Description = description;
              num = 2;
              continue;
            case 8:
              this.Name = name;
              num = 7;
              continue;
            case 9:
              goto label_2;
            default:
              this.ValidatorType = PublicApplicationService.DefaultSystemApplication.XgXlmtw0RRsPUDCXYRdi((object) validatorFullType);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 9 : 7;
              continue;
          }
        }
label_2:;
      }

      public Guid Uid
      {
        get => this.\u003CUid\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
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

      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 0;
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

      public string Description
      {
        get => this.\u003CDescription\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CDescription\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 0 : 0;
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

      public string Author
      {
        get => this.\u003CAuthor\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CAuthor\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 0;
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

      public string Site
      {
        get => this.\u003CSite\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CSite\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 0 : 0;
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

      public DateTime TokenExpire
      {
        get => this.\u003CTokenExpire\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CTokenExpire\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 0 : 0;
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

      public Guid TokenUid
      {
        get => this.\u003CTokenUid\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CTokenUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 0 : 0;
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

      public string DefaultToken
      {
        get => this.\u003CDefaultToken\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CDefaultToken\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 0 : 0;
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

      public Type ValidatorType
      {
        get => this.\u003CValidatorType\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CValidatorType\u003Ek__BackingField = value;
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

      internal static Type XgXlmtw0RRsPUDCXYRdi([In] object obj0) => ReflectionType.GetType((string) obj0);

      internal static bool QcyuC2w0Kbd6PvNV0GKh() => PublicApplicationService.DefaultSystemApplication.UYwVQiw0b2ycKrkF1Xke == null;

      internal static PublicApplicationService.DefaultSystemApplication W8dcE3w0UEUkwqZfIN6P() => PublicApplicationService.DefaultSystemApplication.UYwVQiw0b2ycKrkF1Xke;
    }

    [Component]
    internal class DefaultApplicationsInitHandler : IInitHandler
    {
      internal static PublicApplicationService.DefaultApplicationsInitHandler xUiS8ow0o0kbLFKaP1Iw;

      /// <summary>
      /// Начало инициализации (могут использоваться свойства ComponentManager.Current и ComponentManager.Builder)
      /// </summary>
      public void Init()
      {
      }

      /// <summary>Завершение инициализации (доступен Locator)</summary>
      public void InitComplete() => this.CreateDefaultPublicApplication();

      /// <summary>Создать публичные приложения по умолчанию</summary>
      internal void CreateDefaultPublicApplication()
      {
        int num = 1;
        PublicApplicationService service;
        while (true)
        {
          switch (num)
          {
            case 1:
              service = Locator.GetService<PublicApplicationService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              goto label_3;
            case 4:
              PublicApplicationService.DefaultApplicationsInitHandler.Svf1sOw06nRdbCRgviaj((object) service);
              num = 5;
              continue;
            case 5:
              PublicApplicationService.DefaultApplicationsInitHandler.XPmbPbw0kwtY0gtdIwyi((object) Locator.GetServiceNotNull<ISessionProvider>().GetSession(""));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 2 : 1;
              continue;
            default:
              if (service != null)
              {
                num = 4;
                continue;
              }
              goto label_2;
          }
        }
label_7:
        return;
label_3:
        return;
label_2:;
      }

      public DefaultApplicationsInitHandler()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void Svf1sOw06nRdbCRgviaj([In] object obj0) => ((PublicApplicationService) obj0).CreateDefaultPublicApplications();

      internal static void XPmbPbw0kwtY0gtdIwyi([In] object obj0) => ((ISession) obj0).Flush();

      internal static bool Q9Z2lTw0tWgYbFMqr3eJ() => PublicApplicationService.DefaultApplicationsInitHandler.xUiS8ow0o0kbLFKaP1Iw == null;

      internal static PublicApplicationService.DefaultApplicationsInitHandler VTdKjtw0mYcbsYxuD7wW() => PublicApplicationService.DefaultApplicationsInitHandler.xUiS8ow0o0kbLFKaP1Iw;
    }
  }
}
