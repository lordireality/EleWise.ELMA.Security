// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InternalSecurityServiceOracle
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Security
{
  internal class InternalSecurityServiceOracle : 
    InternalSecurityServiceBase,
    IInternalSecurityService,
    ILicensedUnit,
    IWorkplaceLicenseInfoOwner,
    IConcurrentLicenseInfoOwner,
    IActivationTokenContainer
  {
    private bool initialized;
    private bool licensingInitialized;
    private string lastAppliedActKey;
    private string registrationKey;
    private ConcurrentLicenseInfo licenseInfo;
    private LicenseStatus initializedStatus;
    private static InternalSecurityServiceOracle w1xYkwRzp118vDFV8bi;

    uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => this.UsedLicenseCount;

    uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => InternalSecurityServiceOracle.U8LExdobXTt3ypnwQMb((object) this);

    void IInternalSecurityService.CheckUserToAuthenticate(
      [NotNull] EleWise.ELMA.Security.Models.IUser user,
      Func<bool> isAlreadyLoggedFunc,
      Func<int, bool> isCurrentPrivilegeFunc,
      Func<int> otherUsersCountFunc)
    {
      this.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
    }

    bool IInternalSecurityService.CanCreateNewUser() => InternalSecurityServiceOracle.iSUbpNoKt4tSnXiPAQf((object) this);

    protected override void Check(
      out byte licSubType,
      out ushort licCount,
      out ushort privilegeCount)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Check(__ModuleInfo.UID, new LicensedUnitBase.DecodeConcurrentActivationKeyAction(this.DecodeLastActivationKey), out licSubType, out licCount, out privilegeCount);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected override uint UsedLicenseCount
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (!InternalSecurityServiceOracle.v5RVwnooD4CYeyVjvnb(InternalSecurityServiceOracle.gMNMGcoUrK9vCLaJJdp((object) Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()), InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(-347045778 ^ -347035536)))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        throw new LicenseException();
label_5:
        return base.UsedLicenseCount;
      }
    }

    protected override void CheckUserToAuthenticate(
      [NotNull] EleWise.ELMA.Security.Models.IUser user,
      Func<bool> isAlreadyLoggedFunc,
      Func<int, bool> isCurrentPrivilegeFunc,
      Func<int> otherUsersCountFunc)
    {
      if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1596821387 ^ -1596827541))
        throw new LicenseException();
      base.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
    }

    protected override bool CanCreateNewUser()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!InternalSecurityServiceOracle.v5RVwnooD4CYeyVjvnb(InternalSecurityServiceOracle.gMNMGcoUrK9vCLaJJdp((object) Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()), InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(617710536 ^ 617720790)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      throw new LicenseException();
label_3:
      return base.CanCreateNewUser();
    }

    Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string) InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(-1341618464 ^ -1341611626));

    string ILicensedUnit.GetRegistrationKey()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.registrationKey;
    }

    void ILicensedUnit.ApplyActivationKey(string key)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        byte num3;
        byte licType1;
        while (true)
        {
          byte num4;
          LicenseStatus status;
          ushort licCount1;
          ushort privilegeLicCount1;
          DateTime? expirationDate1;
          byte licType2;
          byte licSubType1;
          ushort privilegeLicCount2;
          byte licSubType2;
          DateTime? expirationDate2;
          ushort licCount2;
          int num5;
          switch (num2)
          {
            case 1:
            case 20:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType2, licSubType1);
              num2 = 30;
              continue;
            case 2:
              if (!expirationDate2.HasValue)
              {
                num2 = 20;
                continue;
              }
              goto case 3;
            case 3:
              if (!InternalSecurityServiceOracle.n1D4LNotmloTuZEoGhH(expirationDate1.Value, expirationDate2.Value))
              {
                num2 = 15;
                continue;
              }
              goto case 1;
            case 4:
              goto label_8;
            case 5:
              goto label_27;
            case 6:
              goto label_7;
            case 7:
              if (this.lastAppliedActKey == null)
              {
                num2 = 13;
                continue;
              }
              this.DecodeActivationKey(this.lastAppliedActKey, out LicenseStatus _, out licCount2, out privilegeLicCount2, out licType1, out licSubType2, out expirationDate2);
              num2 = 18;
              continue;
            case 8:
              if ((int) num4 >= (int) num3)
              {
                num2 = 11;
                continue;
              }
              goto case 12;
            case 9:
            case 29:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType2, licSubType1);
              num2 = 32;
              continue;
            case 10:
              goto label_18;
            case 11:
              if ((int) num4 <= (int) num3)
              {
                num2 = 33;
                continue;
              }
              goto label_37;
            case 12:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType2, licSubType1);
              num2 = 6;
              continue;
            case 13:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType2, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 21 : 2;
              continue;
            case 14:
            case 15:
              if ((int) licCount1 > (int) licCount2)
              {
                num2 = 9;
                continue;
              }
              goto case 31;
            case 16:
              if (this.DecodeActivationKey(key, out status, out licCount1, out privilegeLicCount1, out licType2, out licSubType1, out expirationDate1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 7 : 6;
                continue;
              }
              goto label_33;
            case 17:
              this.InitLicense();
              num2 = 16;
              continue;
            case 18:
              if (licType2 != (byte) 2)
              {
                num2 = 19;
                continue;
              }
              num5 = 1;
              break;
            case 19:
              num5 = (int) licType2;
              break;
            case 21:
              goto label_38;
            case 22:
              if ((int) privilegeLicCount1 <= (int) privilegeLicCount2)
              {
                num2 = 24;
                continue;
              }
              goto case 9;
            case 23:
              if (licType1 != (byte) 2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
                continue;
              }
              goto label_58;
            case 24:
              goto label_49;
            case 25:
              goto label_15;
            case 26:
              if (!expirationDate1.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 14 : 5;
                continue;
              }
              goto case 2;
            case 27:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType2, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 5 : 0;
              continue;
            case 28:
              if (licType2 == (byte) 2)
              {
                num2 = 26;
                continue;
              }
              goto case 14;
            case 30:
              goto label_22;
            case 31:
              if ((int) licCount1 == (int) licCount2)
              {
                num2 = 22;
                continue;
              }
              goto label_6;
            case 32:
              goto label_51;
            case 33:
              if ((int) licSubType1 > (int) licSubType2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 27 : 21;
                continue;
              }
              if ((int) licSubType1 >= (int) licSubType2)
              {
                if (licType2 != (byte) 1)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 16 : 28;
                  continue;
                }
                goto case 26;
              }
              else
              {
                num2 = 10;
                continue;
              }
            default:
              goto label_53;
          }
          num4 = (byte) num5;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 9 : 23;
        }
label_53:
        int num6 = (int) licType1;
        goto label_59;
label_58:
        num6 = 1;
label_59:
        num3 = (byte) num6;
        num1 = 8;
      }
label_8:
      return;
label_27:
      return;
label_7:
      return;
label_18:
      return;
label_38:
      return;
label_49:
      return;
label_15:
      return;
label_22:
      return;
label_51:
      return;
label_37:
      return;
label_33:
      return;
label_6:;
    }

    void ILicensedUnit.CompleteLicensingInitialize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.initializedStatus = InternalSecurityServiceOracle.DbQXLKomCmg6nEH13HW((object) this.licenseInfo);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 2;
            continue;
          default:
            this.licensingInitialized = true;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    ILicenseInfo ILicensedUnit.GetLicenseInfo()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ILicenseInfo) this.licenseInfo;
    }

    void ILicensedUnit.UpdateLicenseInfo()
    {
      int num = 2;
      LicenseStatus status;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DecodeActivationKey(this.lastAppliedActKey, out status, out ushort _, out ushort _, out byte _, out byte _, out DateTime? _);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
            continue;
          case 2:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            InternalSecurityServiceOracle.fxYmQ1o6YJfgZvvfEEF((object) this.licenseInfo, status);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    byte[] ILicensedUnit.GetActivationToken() => (byte[]) null;

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num1 = 19;
      uint[] numArray1;
      byte licSubType;
      MemoryStream output;
      while (true)
      {
        int num2 = num1;
        uint unitHashCode;
        ulong[] numArray2;
        byte licType;
        ushort privilegeLicCount;
        byte num3;
        ushort licCount;
        ushort num4;
        while (true)
        {
          int num5;
          LicenseStatus status;
          int index1;
          byte num6;
          int num7;
          byte index2;
          byte[] numArray3;
          int index3;
          SHA1 shA1;
          DateTime? expirationDate;
          TimeSpan timeSpan;
          byte[] numArray4;
          int num8;
          switch (num2)
          {
            case 1:
              index1 = index3 / 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 21 : 19;
              continue;
            case 2:
              try
              {
                int num9 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0)
                  num9 = 1;
                MemoryStream stream;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      stream = new MemoryStream();
                      num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_18;
                  }
                }
label_18:
                try
                {
                  Action<ulong> action = (Action<ulong>) (v =>
                  {
                    int num10 = 1;
                    while (true)
                    {
                      switch (num10)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          InternalSecurityServiceOracle.\u003C\u003Ec__DisplayClass19_0.Io8br2wtq1nFISFLYg8K((object) stream, InternalSecurityServiceOracle.\u003C\u003Ec__DisplayClass19_0.XUMyqIwtvA95ikHcDpJd(v), 0, 8);
                          num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  });
                  int num11 = 3;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0)
                    num11 = 1;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        action((ulong) licType);
                        num11 = 9;
                        continue;
                      case 2:
                        action((ulong) licCount);
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 1;
                        continue;
                      case 3:
                        action((ulong) unitHashCode);
                        num11 = 2;
                        continue;
                      case 4:
                        num3 = (byte) InternalSecurityServiceOracle.TB0NPLoatX4caN8qpQu((object) shA1, InternalSecurityServiceOracle.NaRJWBoDLNp4bxHMan5((object) stream))[0];
                        num11 = 10;
                        continue;
                      case 5:
                        action(InternalSecurityServiceOracle.GHN());
                        num11 = 8;
                        continue;
                      case 6:
                        action((ulong) privilegeLicCount);
                        num11 = 4;
                        continue;
                      case 7:
                        action(0UL);
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 5 : 5;
                        continue;
                      case 8:
                        if (licSubType == (byte) 1)
                        {
                          num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 0 : 0;
                          continue;
                        }
                        goto case 4;
                      case 9:
                        action((ulong) num4);
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 7;
                        continue;
                      case 10:
                        goto label_96;
                      default:
                        action((ulong) licSubType);
                        num11 = 6;
                        continue;
                    }
                  }
                }
                finally
                {
                  if (stream != null)
                  {
                    int num12 = 0;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0)
                      num12 = 0;
                    while (true)
                    {
                      switch (num12)
                      {
                        case 1:
                          goto label_38;
                        default:
                          stream.Dispose();
                          num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 1;
                          continue;
                      }
                    }
                  }
label_38:;
                }
              }
              finally
              {
                int num13;
                if (shA1 == null)
                  num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 1 : 0;
                else
                  goto label_42;
label_41:
                switch (num13)
                {
                  case 1:
                  case 2:
                }
label_42:
                InternalSecurityServiceOracle.pH1Mk5oxWWMaLODw14v((object) shA1);
                num13 = 2;
                goto label_41;
              }
            case 3:
              goto label_59;
            case 4:
              num8 = (int) (ushort) timeSpan.TotalDays;
              break;
            case 5:
            case 7:
              if (num5 >= numArray3.Length)
              {
                num2 = 20;
                continue;
              }
              goto case 6;
            case 6:
              index3 = numArray3.Length - num5 - 1;
              num2 = 14;
              continue;
            case 8:
              numArray1 = new uint[numArray3.Length / 32];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 25 : 26;
              continue;
            case 9:
              numArray2[(int) index2] = numArray2[(int) index2] >> 1;
              num2 = 22;
              continue;
            case 10:
label_96:
              if (licSubType != (byte) 1)
              {
                num2 = 28;
                continue;
              }
              goto label_102;
            case 11:
              if (status == LicenseStatus.Activated)
              {
                num2 = 23;
                continue;
              }
              goto label_4;
            case 12:
              if (licSubType != (byte) 1)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
                continue;
              }
              byte[] numArray5 = new byte[128];
              // ISSUE: field reference
              InternalSecurityServiceOracle.OR5PDWoCP46v8mYLjPe((object) numArray5, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0032A2CCDEE39142917481EA5BE16417B39BC6FA354));
              numArray4 = numArray5;
              goto label_105;
            case 13:
              timeSpan = InternalSecurityServiceOracle.sNoeoNokdfjhMVwvgMe(expirationDate.Value, new DateTime(2000, 1, 1));
              num2 = 4;
              continue;
            case 14:
              index2 = numArray3[index3];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 1 : 0;
              continue;
            case 15:
              if (expirationDate.HasValue)
              {
                num2 = 13;
                continue;
              }
              num8 = 0;
              break;
            case 16:
              num6 = (byte) (numArray2[(int) index2] & 1UL);
              num2 = 9;
              continue;
            case 17:
              ++num5;
              num2 = 5;
              continue;
            case 18:
              this.DecodeActivationKey(this.lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 11;
              continue;
            case 19:
              this.InitLicense();
              num2 = 18;
              continue;
            case 20:
              output = new MemoryStream();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 3;
              continue;
            case 21:
              num7 = num5 % 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 8 : 16;
              continue;
            case 22:
              numArray1[index1] = numArray1[index1] | (uint) num6 << num7;
              num2 = 17;
              continue;
            case 23:
              unitHashCode = ActivationKeyHelper.GetUnitHashCode(new Guid((string) InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(~123928154 ^ -123917925)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 15 : 13;
              continue;
            case 24:
              goto label_4;
            case 25:
              shA1 = SHA1.Create();
              num2 = 2;
              continue;
            case 26:
              num5 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 7 : 5;
              continue;
            case 27:
              goto label_8;
            case 28:
              goto label_47;
            default:
              numArray4 = new byte[96];
              // ISSUE: field reference
              InternalSecurityServiceOracle.OR5PDWoCP46v8mYLjPe((object) numArray4, __fieldref (\u003CPrivateImplementationDetails\u003E.\u003590509759D722E30F9B9139DC405B39FAD6DBD5B));
              goto label_105;
          }
          num4 = (ushort) num8;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 25 : 18;
          continue;
label_105:
          numArray3 = numArray4;
          num2 = 8;
        }
label_47:
        ulong[] numArray6 = new ulong[7]
        {
          0UL,
          (ulong) unitHashCode,
          (ulong) licCount,
          (ulong) licType,
          (ulong) num4,
          0UL,
          (ulong) num3
        };
        goto label_103;
label_102:
        numArray6 = new ulong[9]
        {
          0UL,
          (ulong) unitHashCode,
          (ulong) licCount,
          (ulong) licType,
          (ulong) num4,
          0UL,
          (ulong) num3,
          (ulong) licSubType,
          (ulong) privilegeLicCount
        };
label_103:
        numArray2 = numArray6;
        num1 = 12;
      }
label_4:
      return (ActivationToken) null;
label_8:
      ActivationToken activationToken1;
      return activationToken1;
label_59:
      try
      {
        int num14 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0)
          num14 = 0;
        while (true)
        {
          byte[] array;
          ActivationToken activationToken2;
          BinaryWriter writer;
          switch (num14)
          {
            case 1:
              activationToken2 = (ActivationToken) null;
              break;
            case 2:
              goto label_8;
            case 3:
              try
              {
                Action<string> action = (Action<string>) (s =>
                {
                  int num15 = 5;
                  while (true)
                  {
                    byte[] bytes;
                    string str1;
                    switch (num15)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        InternalSecurityServiceOracle.\u003C\u003Ec__DisplayClass19_1.LP4IKtwt2m9PiKnYrVMi((object) writer, (object) bytes);
                        num15 = 7;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        bytes = ((Encoding) InternalSecurityServiceOracle.\u003C\u003Ec__DisplayClass19_1.gXA6Grwtey6buxdX6LM7()).GetBytes(s);
                        num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 3 : 6;
                        continue;
                      case 3:
                        goto label_2;
                      case 4:
                        str1 = "";
                        break;
                      case 5:
                        string str2 = s;
                        if (str2 == null)
                        {
                          num15 = 4;
                          continue;
                        }
                        str1 = str2;
                        break;
                      case 6:
                        if (bytes.Length <= (int) short.MaxValue)
                        {
                          num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_2;
                      case 7:
                        goto label_9;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        InternalSecurityServiceOracle.\u003C\u003Ec__DisplayClass19_1.ebcxNkwtLPcDwLB21VjZ((object) writer, (short) bytes.Length);
                        num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 1;
                        continue;
                    }
                    s = str1;
                    num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 2 : 0;
                  }
label_9:
                  return;
label_2:
                  // ISSUE: reference to a compiler-generated method
                  throw new Exception((string) InternalSecurityServiceOracle.\u003C\u003Ec__DisplayClass19_1.nSyV5Qwtn6bv8Ybfbd0E(-1596821387 ^ -1596760205) + s);
                });
                int num16 = 7;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0)
                  num16 = 9;
                uint[] numArray7;
                int index;
                ILicensedUnitComponentInfo unitComponentInfo;
                uint num17;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                      index = 0;
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 1 : 5;
                      continue;
                    case 2:
                      action(unitComponentInfo != null ? (string) InternalSecurityServiceOracle.ywS4qoo3YkKg0Kj9lwM((object) unitComponentInfo) : "");
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 7 : 0;
                      continue;
                    case 3:
                      output.Write((byte[]) InternalSecurityServiceOracle.kjPSqwoj68LeyxXgqXY(num17), 0, 4);
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 0 : 0;
                      continue;
                    case 4:
                    case 5:
                      if (index >= numArray7.Length)
                      {
                        num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 1 : 11;
                        continue;
                      }
                      goto case 6;
                    case 6:
                      num17 = numArray7[index];
                      num16 = 3;
                      continue;
                    case 7:
                      numArray7 = numArray1;
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 1 : 0;
                      continue;
                    case 8:
                      action(unitComponentInfo == null ? "" : unitComponentInfo.GetComponentId());
                      num16 = 2;
                      continue;
                    case 9:
                      InternalSecurityServiceOracle.luWL5CoivqnP8N7bDGZ((object) writer, licSubType == (byte) 1 ? (byte) 1 : (byte) 0);
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 10 : 10;
                      continue;
                    case 10:
                      unitComponentInfo = (ILicensedUnitComponentInfo) this;
                      num16 = 8;
                      continue;
                    case 11:
                      goto label_62;
                    default:
                      ++index;
                      num16 = 4;
                      continue;
                  }
                }
              }
              finally
              {
                int num18;
                if (writer == null)
                  num18 = 2;
                else
                  goto label_80;
label_79:
                switch (num18)
                {
                  case 1:
                    break;
                  default:
                }
label_80:
                InternalSecurityServiceOracle.pH1Mk5oxWWMaLODw14v((object) writer);
                num18 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0)
                {
                  num18 = 0;
                  goto label_79;
                }
                else
                  goto label_79;
              }
            case 4:
label_62:
              array = output.ToArray();
              num14 = 5;
              continue;
            case 5:
              if (array == null)
              {
                num14 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 1 : 1;
                continue;
              }
              ActivationToken activationToken3 = new ActivationToken();
              InternalSecurityServiceOracle.GSSbStoNfPOMlHiJIXN((object) activationToken3, (object) array);
              activationToken2 = activationToken3;
              break;
            default:
              writer = new BinaryWriter((Stream) output);
              num14 = 3;
              continue;
          }
          activationToken1 = activationToken2;
          num14 = 2;
        }
      }
      finally
      {
        if (output != null)
        {
          int num19 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0)
            num19 = 1;
          while (true)
          {
            switch (num19)
            {
              case 1:
                InternalSecurityServiceOracle.pH1Mk5oxWWMaLODw14v((object) output);
                num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 0 : 0;
                continue;
              default:
                goto label_94;
            }
          }
        }
label_94:;
      }
    }

    private void InitLicense()
    {
      int num1 = 1;
      InternalSecurityServiceOracle securityServiceOracle;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_3;
          case 1:
            if (!this.initialized)
            {
              securityServiceOracle = this;
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_20;
          case 3:
            lockTaken = false;
            num1 = 4;
            continue;
          case 4:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_20:
      return;
label_2:
      return;
label_6:
      try
      {
        Monitor.Enter((object) securityServiceOracle, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.initialized)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 2 : 0;
                continue;
              }
              goto label_9;
            case 2:
              this.registrationKey = (string) InternalSecurityServiceOracle.gRLxsOo0qc6bNIvcHKj((ushort) 1);
              num2 = 4;
              continue;
            case 3:
              goto label_15;
            case 4:
              ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo((object) this);
              InternalSecurityServiceOracle.fxYmQ1o6YJfgZvvfEEF((object) concurrentLicenseInfo, LicenseStatus.NotActivated);
              this.licenseInfo = concurrentLicenseInfo;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
              continue;
            default:
              this.initialized = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 3 : 3;
              continue;
          }
        }
label_15:
        return;
label_9:;
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_22;
              default:
                InternalSecurityServiceOracle.Cm7tB6oZTRYcQa5nXhq((object) securityServiceOracle);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_22:;
      }
    }

    [DllImport("kernel32.dll")]
    private static extern long GetVolumeInformation(
      string PathName,
      StringBuilder VolumeNameBuffer,
      uint VolumeNameSize,
      ref uint VolumeSerialNumber,
      ref uint MaximumComponentLength,
      ref uint FileSystemFlags,
      StringBuilder FileSystemNameBuffer,
      uint FileSystemNameSize);

    [DllImport("kernel32.dll")]
    private static extern uint GetDriveType(string lpRootPathName);

    private static ulong GHN()
    {
      int num1 = 2;
      ulong num2;
      while (true)
      {
        int num3 = num1;
        int index;
        char ch;
        char[] chArray1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              char[] chArray2 = new char[24];
              // ISSUE: field reference
              InternalSecurityServiceOracle.OR5PDWoCP46v8mYLjPe((object) chArray2, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0039A504FB7A5500CBA32FE333D0392DBF00E81582F));
              chArray1 = chArray2;
              num3 = 9;
              continue;
            case 2:
              num2 = 0UL;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 1;
              continue;
            case 4:
              try
              {
                uint VolumeSerialNumber = 0;
                int num4 = 3;
                while (true)
                {
                  int num5;
                  StringBuilder FileSystemNameBuffer;
                  int num6;
                  uint MaximumComponentLength;
                  int num7;
                  StringBuilder VolumeNameBuffer;
                  uint FileSystemFlags;
                  switch (num4)
                  {
                    case 1:
                    case 14:
                      goto label_3;
                    case 2:
                      ++num6;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 19 : 19;
                      continue;
                    case 3:
                      MaximumComponentLength = 0U;
                      num4 = 13;
                      continue;
                    case 4:
                      num6 = 0;
                      num5 = 16;
                      break;
                    case 5:
                      if (VolumeSerialNumber == 0U)
                      {
                        num4 = 14;
                        continue;
                      }
                      goto case 4;
                    case 6:
                      num2 = num2 << 1 | (ulong) (VolumeSerialNumber >> num7 & 1U);
                      num4 = 2;
                      continue;
                    case 7:
                    case 11:
                      goto label_32;
                    case 8:
                      if (num2 != 0UL)
                      {
                        num5 = 7;
                        break;
                      }
                      goto case 20;
                    case 9:
                      num7 = num6 % 32;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 0 : 0;
                      continue;
                    case 10:
                      num7 = (num7 + num6 / 16) % 32;
                      num4 = 6;
                      continue;
                    case 12:
                      FileSystemFlags = 0U;
                      num4 = 18;
                      continue;
                    case 13:
                      VolumeNameBuffer = new StringBuilder(256);
                      num5 = 12;
                      break;
                    case 15:
                      num7 = 31 - num7;
                      num4 = 10;
                      continue;
                    case 16:
                    case 19:
                      if (num6 >= 48)
                      {
                        num4 = 8;
                        continue;
                      }
                      goto case 9;
                    case 17:
                      string str = ch.ToString() + (string) InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(1013954274 ^ 1013948148);
                      InternalSecurityServiceOracle.GetVolumeInformation(str, VolumeNameBuffer, (uint) VolumeNameBuffer.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, FileSystemNameBuffer, (uint) InternalSecurityServiceOracle.tHdnpOoAmCTxPvcvg4j((object) FileSystemNameBuffer));
                      if (InternalSecurityServiceOracle.GetDriveType(str) == 3U)
                      {
                        num4 = 5;
                        continue;
                      }
                      goto label_3;
                    case 18:
                      FileSystemNameBuffer = new StringBuilder(256);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 17 : 1;
                      continue;
                    case 20:
                      num2 = 1UL;
                      num4 = 11;
                      continue;
                    default:
                      if (num6 % 2 == 0)
                      {
                        num4 = 15;
                        continue;
                      }
                      goto case 10;
                  }
                  num4 = num5;
                }
              }
              catch
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                    goto label_3;
                }
              }
            case 5:
            case 8:
              if (index < chArray1.Length)
              {
                num3 = 3;
                continue;
              }
              goto label_32;
            case 6:
              goto label_32;
            case 7:
label_3:
              ++index;
              num3 = 5;
              continue;
            case 9:
              goto label_33;
            default:
              ch = chArray1[index];
              num3 = 4;
              continue;
          }
        }
label_33:
        index = 0;
        num1 = 8;
      }
label_32:
      return num2;
    }

    private static string GenerateRegistrationKey(ushort algorithm)
    {
      int num1 = 3;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        string str;
        int index1;
        ulong[] numArray1;
        byte index2;
        int num3;
        int num4;
        byte[] numArray2;
        int index3;
        uint[] numArray3;
        ulong num5;
        int index4;
        byte num6;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              numArray1 = new ulong[2]
              {
                num5,
                (ulong) algorithm
              };
              num2 = 8;
              continue;
            case 3:
              num5 = InternalSecurityServiceOracle.U5OASHosQFjYAAfQC6U();
              num2 = 2;
              continue;
            case 4:
              ++index1;
              num2 = 14;
              continue;
            case 5:
              str = numArray3[index1].ToString();
              num2 = 15;
              continue;
            case 6:
              goto label_22;
            case 7:
            case 10:
              index3 = numArray2.Length - num3 - 1;
              num2 = 6;
              continue;
            case 8:
              byte[] numArray4 = new byte[64];
              // ISSUE: field reference
              InternalSecurityServiceOracle.OR5PDWoCP46v8mYLjPe((object) numArray4, __fieldref (\u003CPrivateImplementationDetails\u003E.FD3F148DA31DE202E19855BF74F986A0DDC9F29F));
              numArray2 = numArray4;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 25 : 14;
              continue;
            case 9:
              ++num3;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 6 : 12;
              continue;
            case 11:
              index4 = index3 / 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 12 : 18;
              continue;
            case 12:
            case 21:
              if (num3 >= numArray2.Length)
                goto case 20;
              else
                goto label_10;
            case 13:
            case 14:
              if (index1 >= numArray3.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 0;
                continue;
              }
              goto case 5;
            case 15:
            case 17:
              if (str.Length >= 10)
              {
                num2 = 19;
                continue;
              }
              goto case 23;
            case 16:
              index1 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 13 : 4;
              continue;
            case 18:
              num4 = num3 % 32;
              num2 = 22;
              continue;
            case 19:
              InternalSecurityServiceOracle.VZGac2oWkwybNpIfoRP((object) stringBuilder, (object) str);
              num2 = 4;
              continue;
            case 20:
              stringBuilder = new StringBuilder();
              num2 = 16;
              continue;
            case 22:
              num6 = (byte) (numArray1[(int) index2] & 1UL);
              num2 = 24;
              continue;
            case 23:
              str = (string) InternalSecurityServiceOracle.MNqGkSo7rdeomgOX1QI(InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(-110921701 >> 6 ^ -1728574), (object) str);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 17 : 9;
              continue;
            case 24:
              numArray1[(int) index2] = numArray1[(int) index2] >> 1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
              continue;
            case 25:
              numArray3 = new uint[numArray2.Length / 32];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 26 : 0;
              continue;
            case 26:
              goto label_28;
            default:
              numArray3[index4] = numArray3[index4] | (uint) num6 << num4;
              num2 = 9;
              continue;
          }
        }
label_10:
        num1 = 10;
        continue;
label_22:
        index2 = numArray2[index3];
        num1 = 11;
        continue;
label_28:
        num3 = 0;
        num1 = 21;
      }
label_5:
      return (string) InternalSecurityServiceOracle.vqDtX5or7fPCOCDM54Q((object) stringBuilder.ToString());
    }

    private static string FormatKey(object key)
    {
      int num1 = 5;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        char[] charArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              charArray = ((string) key).ToCharArray();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 11 : 4;
              continue;
            case 3:
            case 8:
              if (index <= 0)
              {
                num2 = 9;
                continue;
              }
              goto case 10;
            case 4:
              goto label_14;
            case 5:
              if (key == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 4;
                continue;
              }
              goto label_15;
            case 6:
              goto label_3;
            case 7:
            case 9:
              InternalSecurityServiceOracle.wtI88BoSa1c8Ja7uSia((object) stringBuilder, charArray[index]);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 1 : 0;
              continue;
            case 10:
              if (index % 5 == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 11:
              index = 0;
              num2 = 12;
              continue;
            case 12:
            case 13:
              if (index < charArray.Length)
              {
                num2 = 8;
                continue;
              }
              goto label_3;
            default:
              InternalSecurityServiceOracle.wtI88BoSa1c8Ja7uSia((object) stringBuilder, '-');
              num2 = 7;
              continue;
          }
        }
label_11:
        ++index;
        num1 = 13;
        continue;
label_15:
        stringBuilder = new StringBuilder();
        num1 = 2;
      }
label_3:
      return stringBuilder.ToString();
label_14:
      return string.Empty;
    }

    private bool DecodeLastActivationKey(
      out LicenseStatus status,
      out ushort licCount,
      out ushort privilegeLicCount,
      out byte licType,
      out byte licSubType,
      out DateTime? expirationDate)
    {
      return this.DecodeActivationKey(this.lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
    }

    private bool DecodeActivationKey(
      string key,
      out LicenseStatus status,
      out ushort licCount,
      out ushort privilegeLicCount,
      out byte licType,
      out byte licSubType,
      out DateTime? expirationDate)
    {
      int num1 = 7;
      bool flag;
      while (true)
      {
        int num2 = num1;
        int index1;
        string[] unitActivationKeys;
        string str1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              status = LicenseStatus.NotActivated;
              num2 = 2;
              continue;
            case 2:
              licCount = (ushort) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
              continue;
            case 3:
              unitActivationKeys = ActivationKeyHelper.GetUnitActivationKeys(key, new Guid((string) InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(-29763048 >> 5 ^ -923922)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 5 : 12;
              continue;
            case 4:
              privilegeLicCount = (ushort) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 1 : 0;
              continue;
            case 5:
            case 8:
              if (index1 >= unitActivationKeys.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 8 : 13;
                continue;
              }
              goto case 14;
            case 6:
              goto label_84;
            case 7:
              this.InitLicense();
              num2 = 6;
              continue;
            case 9:
              licSubType = (byte) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 1 : 4;
              continue;
            case 10:
              try
              {
                ulong num3 = 8722303306514871354;
                int num4 = 22;
                while (true)
                {
                  int num5;
                  int num6;
                  uint[] numArray1;
                  string str2;
                  int index2;
                  ulong num7;
                  int num8;
                  ulong[] numArray2;
                  byte index3;
                  byte num9;
                  int num10;
                  ushort num11;
                  byte[] numArray3;
                  int index4;
                  int index5;
                  DateTime dateTime;
                  int[] numArray4;
                  int num12;
                  int index6;
                  ulong num13;
                  ulong[] numArray5;
                  byte[] numArray6;
                  switch (num4)
                  {
                    case 1:
                    case 38:
                      if (num8 >= 32)
                      {
                        num5 = 31;
                        break;
                      }
                      goto case 25;
                    case 2:
                      status = LicenseStatus.DateExpired;
                      num4 = 14;
                      continue;
                    case 3:
                      privilegeLicCount = numArray1.Length == 4 ? (ushort) numArray2[5] : (ushort) 0;
                      num5 = 39;
                      break;
                    case 4:
                      ++numArray4[(int) index3];
                      num4 = 11;
                      continue;
                    case 5:
                    case 7:
                    case 14:
                      flag = true;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 49 : 39;
                      continue;
                    case 6:
                      numArray1[index2] = numArray1[index2] ^ (uint) num7 << num8;
                      num4 = 13;
                      continue;
                    case 8:
                    case 26:
                      if (num12 >= numArray3.Length)
                      {
                        num4 = 10;
                        continue;
                      }
                      goto case 54;
                    case 9:
                    case 29:
                      if (index2 >= numArray1.Length)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 28 : 9;
                        continue;
                      }
                      goto case 55;
                    case 10:
                      num13 = numArray2[0];
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 26 : 37;
                      continue;
                    case 11:
                      num9 = (byte) (numArray1[index6] & 1U);
                      num4 = 48;
                      continue;
                    case 12:
                      index5 = 0;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 11 : 21;
                      continue;
                    case 13:
                      ++num8;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 1 : 1;
                      continue;
                    case 15:
                      if (num6 > 63)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 14 : 45;
                        continue;
                      }
                      goto case 43;
                    case 16:
                      if (num6 < 0)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 50 : 20;
                        continue;
                      }
                      goto case 15;
                    case 17:
                      numArray5 = new ulong[5];
                      goto label_72;
                    case 18:
                      ++num12;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 8 : 5;
                      continue;
                    case 19:
                      index3 = numArray3[index4];
                      num4 = 46;
                      continue;
                    case 20:
                      numArray6 = new byte[96];
                      // ISSUE: field reference
                      InternalSecurityServiceOracle.OR5PDWoCP46v8mYLjPe((object) numArray6, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0032B6AB1C097496DECB417A5B914D605D171C62F34));
                      goto label_70;
                    case 21:
                    case 24:
                      if (index5 >= numArray1.Length)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 34;
                    case 22:
                      str2 = str1.Replace((string) InternalSecurityServiceOracle.Ne7Y54oR1dwBTUWnUCP(711486506 ^ 711483404), "");
                      num4 = 52;
                      continue;
                    case 23:
                      if (numArray1.Length != 4)
                      {
                        num4 = 17;
                        continue;
                      }
                      numArray5 = new ulong[6];
                      goto label_72;
                    case 25:
                      num6 = (index2 * 1249 + num8 * 3571) % 64;
                      num4 = 16;
                      continue;
                    case 27:
                      status = LicenseStatus.Activated;
                      num4 = 40;
                      continue;
                    case 28:
                      if (numArray1.Length != 4)
                      {
                        num4 = 20;
                        continue;
                      }
                      numArray6 = new byte[128]
                      {
                        (byte) 5,
                        (byte) 1,
                        (byte) 0,
                        (byte) 0,
                        (byte) 3,
                        (byte) 0,
                        (byte) 4,
                        (byte) 5,
                        (byte) 0,
                        (byte) 3,
                        (byte) 1,
                        (byte) 0,
                        (byte) 0,
                        (byte) 0,
                        (byte) 2,
                        (byte) 0,
                        (byte) 3,
                        (byte) 0,
                        (byte) 4,
                        (byte) 1,
                        (byte) 0,
                        (byte) 5,
                        (byte) 0,
                        (byte) 3,
                        (byte) 4,
                        (byte) 4,
                        (byte) 0,
                        (byte) 1,
                        (byte) 1,
                        (byte) 0,
                        (byte) 4,
                        (byte) 3,
                        (byte) 0,
                        (byte) 5,
                        (byte) 2,
                        (byte) 0,
                        (byte) 0,
                        (byte) 4,
                        (byte) 4,
                        (byte) 4,
                        (byte) 0,
                        (byte) 1,
                        (byte) 0,
                        (byte) 3,
                        (byte) 0,
                        (byte) 0,
                        (byte) 5,
                        (byte) 0,
                        (byte) 5,
                        (byte) 4,
                        (byte) 1,
                        (byte) 5,
                        (byte) 4,
                        (byte) 4,
                        (byte) 5,
                        (byte) 0,
                        (byte) 1,
                        (byte) 4,
                        (byte) 3,
                        (byte) 0,
                        (byte) 0,
                        (byte) 5,
                        (byte) 0,
                        (byte) 3,
                        (byte) 1,
                        (byte) 0,
                        (byte) 5,
                        (byte) 0,
                        (byte) 4,
                        (byte) 0,
                        (byte) 0,
                        (byte) 1,
                        (byte) 0,
                        (byte) 2,
                        (byte) 0,
                        (byte) 0,
                        (byte) 1,
                        (byte) 3,
                        (byte) 0,
                        (byte) 0,
                        (byte) 3,
                        (byte) 0,
                        (byte) 0,
                        (byte) 1,
                        (byte) 0,
                        (byte) 5,
                        (byte) 3,
                        (byte) 0,
                        (byte) 0,
                        (byte) 5,
                        (byte) 1,
                        (byte) 4,
                        (byte) 5,
                        (byte) 4,
                        (byte) 0,
                        (byte) 3,
                        (byte) 0,
                        (byte) 3,
                        (byte) 4,
                        (byte) 0,
                        (byte) 0,
                        (byte) 2,
                        (byte) 5,
                        (byte) 2,
                        (byte) 0,
                        (byte) 5,
                        (byte) 0,
                        (byte) 3,
                        (byte) 0,
                        (byte) 2,
                        (byte) 1,
                        (byte) 2,
                        (byte) 4,
                        (byte) 3,
                        (byte) 4,
                        (byte) 1,
                        (byte) 4,
                        (byte) 2,
                        (byte) 4,
                        (byte) 1,
                        (byte) 0,
                        (byte) 4,
                        (byte) 5,
                        (byte) 4,
                        (byte) 3,
                        (byte) 4,
                        (byte) 0,
                        (byte) 4
                      };
                      goto label_70;
                    case 30:
                      if (!expirationDate.HasValue)
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 53;
                    case 31:
                      ++index2;
                      num5 = 29;
                      break;
                    case 32:
                      index6 = index4 / 32;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 19 : 16;
                      continue;
                    case 33:
                      numArray2[(int) index3] = numArray2[(int) index3] | (ulong) num9 << num10;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 10 : 18;
                      continue;
                    case 34:
                      numArray1[index5] = InternalSecurityServiceOracle.l4RjexoybxmqwPTTvEG((object) str2.Substring(index5 * 10, 10));
                      num4 = 42;
                      continue;
                    case 35:
                      num12 = 0;
                      num4 = 26;
                      continue;
                    case 36:
                      num11 = (ushort) numArray2[3];
                      num4 = 51;
                      continue;
                    case 37:
                      if ((long) InternalSecurityServiceOracle.GHN() == (long) num13)
                      {
                        num4 = 27;
                        continue;
                      }
                      goto label_86;
                    case 39:
                      licType = (byte) numArray2[2];
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 43 : 44;
                      continue;
                    case 40:
                      licCount = (ushort) numArray2[1];
                      num4 = 3;
                      continue;
                    case 41:
                      if (!InternalSecurityServiceOracle.n1D4LNotmloTuZEoGhH(dateTime.Date, expirationDate.Value))
                      {
                        num4 = 7;
                        continue;
                      }
                      goto case 2;
                    case 42:
                      ++index5;
                      num4 = 24;
                      continue;
                    case 43:
                      num7 = num3 >> num6 & 1UL;
                      num4 = 6;
                      continue;
                    case 44:
                      licSubType = numArray1.Length == 4 ? (byte) 1 : (byte) 0;
                      num4 = 36;
                      continue;
                    case 45:
                      num6 = 63;
                      num4 = 43;
                      continue;
                    case 46:
                      num10 = numArray4[(int) index3];
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 1 : 4;
                      continue;
                    case 47:
                      numArray4 = new int[numArray2.Length];
                      num4 = 35;
                      continue;
                    case 48:
                      numArray1[index6] = numArray1[index6] >> 1;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 33 : 16;
                      continue;
                    case 49:
                      goto label_92;
                    case 50:
                      num6 = 0;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 15 : 4;
                      continue;
                    case 51:
                      ref DateTime? local = ref expirationDate;
                      DateTime? nullable;
                      if (licType != (byte) 1 && licType != (byte) 2)
                      {
                        nullable = new DateTime?();
                      }
                      else
                      {
                        dateTime = new DateTime(2000, 1, 1);
                        nullable = new DateTime?(dateTime.AddDays((double) num11));
                      }
                      local = nullable;
                      num5 = 30;
                      break;
                    case 52:
                      numArray1 = new uint[InternalSecurityServiceOracle.LuYtoKoYZ2nq5ZL3LRV((object) str2) / 10];
                      num4 = 12;
                      continue;
                    case 53:
                      dateTime = InternalSecurityServiceOracle.yYSFGUoVymyC97xXkKb();
                      num4 = 41;
                      continue;
                    case 54:
                      index4 = numArray3.Length - num12 - 1;
                      num4 = 32;
                      continue;
                    case 55:
                      num8 = 0;
                      num4 = 38;
                      continue;
                    case 56:
                      goto label_86;
                    default:
                      index2 = 0;
                      num4 = 9;
                      continue;
                  }
                  num4 = num5;
                  continue;
label_70:
                  numArray3 = numArray6;
                  num4 = 23;
                  continue;
label_72:
                  numArray2 = numArray5;
                  num4 = 47;
                }
              }
              catch
              {
                int num14 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0)
                  num14 = 0;
                switch (num14)
                {
                  default:
                    goto label_86;
                }
              }
            case 11:
              if (str1 != null)
              {
                num2 = 10;
                continue;
              }
              goto case 15;
            case 12:
              goto label_82;
            case 13:
              goto label_91;
            case 14:
              str1 = unitActivationKeys[index1];
              num2 = 11;
              continue;
            case 15:
label_86:
              ++index1;
              num2 = 5;
              continue;
            default:
              licType = (byte) 0;
              num2 = 3;
              continue;
          }
        }
label_82:
        index1 = 0;
        num1 = 8;
        continue;
label_84:
        expirationDate = new DateTime?();
        num1 = 9;
      }
label_91:
      return false;
label_92:
      return flag;
    }

    private void SetLastAppliedKey(
      string key,
      LicenseStatus newStatus,
      ushort newLicCount,
      ushort newPrivilegeCount,
      DateTime? newExpirationDate,
      byte newLicType,
      byte newSubType)
    {
      this.lastAppliedActKey = key;
      if (this.licensingInitialized && newStatus == LicenseStatus.Activated && this.initializedStatus != LicenseStatus.Activated)
        this.licenseInfo.Status = LicenseStatus.NeedRestart;
      else
        this.licenseInfo.Status = newStatus;
      this.licenseInfo.LicenseType = newLicType;
      this.licenseInfo.IsConcurrent = newSubType == (byte) 1;
      this.licenseInfo.WorkplaceCount = newLicCount >= (ushort) 65000 ? new uint?() : new uint?((uint) newLicCount);
      this.licenseInfo.PrivilegeCount = newPrivilegeCount >= (ushort) 65000 ? new uint?() : new uint?((uint) newPrivilegeCount);
      this.licenseInfo.TrialExpiration = newExpirationDate;
    }

    public InternalSecurityServiceOracle()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static uint U8LExdobXTt3ypnwQMb([In] object obj0) => ((InternalSecurityServiceBase) obj0).UsedPrivilegeCount;

    internal static bool iSUbpNoKt4tSnXiPAQf([In] object obj0) => ((InternalSecurityServiceBase) obj0).CanCreateNewUser();

    internal static bool HLMuBwouF9HgCtfTaCM() => InternalSecurityServiceOracle.w1xYkwRzp118vDFV8bi == null;

    internal static InternalSecurityServiceOracle JfCiORowEEG1Pfnfnf2() => InternalSecurityServiceOracle.w1xYkwRzp118vDFV8bi;

    internal static object gMNMGcoUrK9vCLaJJdp([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object Ne7Y54oR1dwBTUWnUCP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool v5RVwnooD4CYeyVjvnb([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool n1D4LNotmloTuZEoGhH([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static LicenseStatus DbQXLKomCmg6nEH13HW([In] object obj0) => ((LicenseInfo) obj0).Status;

    internal static void fxYmQ1o6YJfgZvvfEEF([In] object obj0, [In] LicenseStatus obj1) => ((LicenseInfo) obj0).Status = obj1;

    internal static TimeSpan sNoeoNokdfjhMVwvgMe([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static object NaRJWBoDLNp4bxHMan5([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static object TB0NPLoatX4caN8qpQu([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static void pH1Mk5oxWWMaLODw14v([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void OR5PDWoCP46v8mYLjPe([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static void luWL5CoivqnP8N7bDGZ([In] object obj0, [In] byte obj1) => ((BinaryWriter) obj0).Write(obj1);

    internal static object ywS4qoo3YkKg0Kj9lwM([In] object obj0) => (object) ((ILicensedUnitComponentInfo) obj0).GetComponentVersion();

    internal static object kjPSqwoj68LeyxXgqXY([In] uint obj0) => (object) BitConverter.GetBytes(obj0);

    internal static void GSSbStoNfPOMlHiJIXN([In] object obj0, [In] object obj1) => ((ActivationToken) obj0).Token = (byte[]) obj1;

    internal static object gRLxsOo0qc6bNIvcHKj(ushort algorithm) => (object) InternalSecurityServiceOracle.GenerateRegistrationKey(algorithm);

    internal static void Cm7tB6oZTRYcQa5nXhq([In] object obj0) => Monitor.Exit(obj0);

    internal static int tHdnpOoAmCTxPvcvg4j([In] object obj0) => ((StringBuilder) obj0).Capacity;

    internal static ulong U5OASHosQFjYAAfQC6U() => InternalSecurityServiceOracle.GHN();

    internal static object MNqGkSo7rdeomgOX1QI([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object VZGac2oWkwybNpIfoRP([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object vqDtX5or7fPCOCDM54Q([In] object obj0) => (object) InternalSecurityServiceOracle.FormatKey(obj0);

    internal static object wtI88BoSa1c8Ja7uSia([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static int LuYtoKoYZ2nq5ZL3LRV([In] object obj0) => ((string) obj0).Length;

    internal static uint l4RjexoybxmqwPTTvEG([In] object obj0) => uint.Parse((string) obj0);

    internal static DateTime yYSFGUoVymyC97xXkKb() => DateTime.Now;
  }
}
