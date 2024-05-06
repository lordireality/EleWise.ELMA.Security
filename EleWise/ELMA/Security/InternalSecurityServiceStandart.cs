// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InternalSecurityServiceStandart
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
  internal class InternalSecurityServiceStandart : 
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
    private static InternalSecurityServiceStandart vSGgsTolcdya66rKn0P;

    uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => InternalSecurityServiceStandart.B1ZHCxocAvOddlk1Yu8((object) this);

    uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => InternalSecurityServiceStandart.FnDdh4oPhsoQ3AinZnX((object) this);

    void IInternalSecurityService.CheckUserToAuthenticate(
      [NotNull] EleWise.ELMA.Security.Models.IUser user,
      Func<bool> isAlreadyLoggedFunc,
      Func<int, bool> isCurrentPrivilegeFunc,
      Func<int> otherUsersCountFunc)
    {
      this.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
    }

    bool IInternalSecurityService.CanCreateNewUser() => this.CanCreateNewUser();

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
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
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
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if ((string) InternalSecurityServiceStandart.W5UW8toQ9YrVc1SKQNG((object) Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()) != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1341618464 ^ -1341608338))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
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
      if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629935560 ^ -1103494022 ^ 1682562764))
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
            if (!InternalSecurityServiceStandart.h6clWTo5P5mxgg2M0WJ(InternalSecurityServiceStandart.W5UW8toQ9YrVc1SKQNG((object) Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType()), InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(-2143851882 - 923330995 ^ 1227794541)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 0;
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
      throw new LicenseException();
label_5:
      return base.CanCreateNewUser();
    }

    Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string) InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(--353012470 ^ 353021312));

    string ILicensedUnit.GetRegistrationKey()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.registrationKey;
    }

    void ILicensedUnit.ApplyActivationKey(string key)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        byte licType1;
        byte num3;
        while (true)
        {
          LicenseStatus status;
          ushort licCount1;
          ushort privilegeLicCount1;
          DateTime? expirationDate1;
          byte licSubType1;
          byte licSubType2;
          byte licType2;
          byte num4;
          DateTime? expirationDate2;
          ushort privilegeLicCount2;
          ushort licCount2;
          int num5;
          switch (num2)
          {
            case 1:
              this.DecodeActivationKey(this.lastAppliedActKey, out LicenseStatus _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate2);
              num2 = 14;
              continue;
            case 2:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 4 : 22;
              continue;
            case 3:
              num5 = (int) licType2;
              break;
            case 4:
              if (!InternalSecurityServiceStandart.GfuuH4od1yBJpd7ZRQc(expirationDate1.Value, expirationDate2.Value))
              {
                num2 = 10;
                continue;
              }
              goto case 19;
            case 5:
              if ((int) licCount1 == (int) licCount2)
              {
                num2 = 26;
                continue;
              }
              goto label_7;
            case 6:
              goto label_20;
            case 7:
              if (licType1 != (byte) 1)
              {
                num2 = 28;
                continue;
              }
              goto case 23;
            case 8:
              goto label_35;
            case 9:
              goto label_38;
            case 10:
              if ((int) licCount1 <= (int) licCount2)
              {
                num2 = 5;
                continue;
              }
              goto case 20;
            case 11:
              goto label_41;
            case 12:
              if (this.DecodeActivationKey(key, out status, out licCount1, out privilegeLicCount1, out licType1, out licSubType1, out expirationDate1))
              {
                if (this.lastAppliedActKey != null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 1;
                  continue;
                }
                goto default;
              }
              else
              {
                num2 = 27;
                continue;
              }
            case 13:
              this.InitLicense();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 12 : 9;
              continue;
            case 14:
              if (licType1 != (byte) 2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 4 : 25;
                continue;
              }
              goto label_55;
            case 15:
              goto label_8;
            case 16:
              if ((int) num3 >= (int) num4)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 19 : 24;
                continue;
              }
              goto case 2;
            case 17:
              if (expirationDate2.HasValue)
              {
                num2 = 4;
                continue;
              }
              goto case 19;
            case 18:
              goto label_14;
            case 19:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 11;
              continue;
            case 20:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 12 : 30;
              continue;
            case 21:
              if (licType2 != (byte) 2)
              {
                num2 = 3;
                continue;
              }
              num5 = 1;
              break;
            case 22:
              goto label_9;
            case 23:
              if (expirationDate1.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 2 : 17;
                continue;
              }
              goto case 10;
            case 24:
              if ((int) num3 <= (int) num4)
              {
                if ((int) licSubType1 > (int) licSubType2)
                {
                  num2 = 29;
                  continue;
                }
                if ((int) licSubType1 >= (int) licSubType2)
                {
                  num2 = 7;
                  continue;
                }
                goto label_26;
              }
              else
              {
                num2 = 15;
                continue;
              }
            case 25:
              goto label_23;
            case 26:
              if ((int) privilegeLicCount1 <= (int) privilegeLicCount2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 6 : 9;
                continue;
              }
              goto case 20;
            case 27:
              goto label_46;
            case 28:
              if (licType1 == (byte) 2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 18 : 23;
                continue;
              }
              goto case 10;
            case 29:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 18 : 15;
              continue;
            case 30:
              goto label_3;
            default:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 8;
              continue;
          }
          num4 = (byte) num5;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 8 : 16;
        }
label_23:
        int num6 = (int) licType1;
        goto label_56;
label_55:
        num6 = 1;
label_56:
        num3 = (byte) num6;
        num1 = 21;
      }
label_20:
      return;
label_35:
      return;
label_38:
      return;
label_41:
      return;
label_8:
      return;
label_14:
      return;
label_9:
      return;
label_46:
      return;
label_3:
      return;
label_26:
      return;
label_7:;
    }

    void ILicensedUnit.CompleteLicensingInitialize()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.licensingInitialized = true;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
            continue;
          case 2:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            this.initializedStatus = InternalSecurityServiceStandart.hedfd1oEHuOZmdasReY((object) this.licenseInfo);
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
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
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
      int num = 1;
      LicenseStatus status;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            InternalSecurityServiceStandart.S81bmkoGHIOEKHdIIEx((object) this.licenseInfo, status);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 2 : 0;
            continue;
          default:
            this.DecodeActivationKey(this.lastAppliedActKey, out status, out ushort _, out ushort _, out byte _, out byte _, out DateTime? _);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 3 : 3;
            continue;
        }
      }
label_2:;
    }

    byte[] ILicensedUnit.GetActivationToken() => (byte[]) null;

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num1 = 18;
      MemoryStream output;
      uint[] numArray1;
      byte licSubType;
      while (true)
      {
        int num2 = num1;
        int index1;
        int num3;
        byte[] numArray2;
        byte index2;
        ulong[] numArray3;
        byte num4;
        while (true)
        {
          int index3;
          uint unitHashCode;
          ushort licCount;
          byte licType;
          ushort num5;
          byte num6;
          LicenseStatus status;
          ushort privilegeLicCount;
          DateTime? expirationDate;
          SHA1 shA1;
          int num7;
          TimeSpan timeSpan;
          byte[] numArray4;
          int num8;
          ulong[] numArray5;
          switch (num2)
          {
            case 1:
              num8 = (int) (ushort) timeSpan.TotalDays;
              break;
            case 2:
              goto label_88;
            case 3:
              output = new MemoryStream();
              num2 = 28;
              continue;
            case 4:
              index2 = numArray2[index1];
              num2 = 10;
              continue;
            case 5:
              if (!expirationDate.HasValue)
              {
                num2 = 6;
                continue;
              }
              goto case 25;
            case 6:
              num8 = 0;
              break;
            case 7:
              shA1 = (SHA1) InternalSecurityServiceStandart.S30bEaoX967xe5VJB95();
              num2 = 15;
              continue;
            case 8:
              ++num3;
              num2 = 16;
              continue;
            case 9:
              numArray1 = new uint[numArray2.Length / 32];
              num2 = 22;
              continue;
            case 10:
              index3 = index1 / 32;
              num2 = 19;
              continue;
            case 11:
            case 16:
              if (num3 >= numArray2.Length)
              {
                num2 = 3;
                continue;
              }
              goto label_99;
            case 12:
              numArray5 = new ulong[7]
              {
                0UL,
                (ulong) unitHashCode,
                (ulong) licCount,
                (ulong) licType,
                (ulong) num5,
                0UL,
                (ulong) num6
              };
              goto label_103;
            case 13:
              numArray3[(int) index2] = numArray3[(int) index2] >> 1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 26 : 5;
              continue;
            case 14:
              goto label_46;
            case 15:
              try
              {
                int num9 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0)
                  num9 = 1;
                MemoryStream stream;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      stream = new MemoryStream();
                      num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_53;
                  }
                }
label_53:
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
                          InternalSecurityServiceStandart.\u003C\u003Ec__DisplayClass19_0.diFjk1wmKEtwP1GYhd6b((object) stream, InternalSecurityServiceStandart.\u003C\u003Ec__DisplayClass19_0.qxV0PKwmbcm9QYmsNfEC(v), 0, 8);
                          num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  });
                  int num11 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0)
                    num11 = 1;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        action((ulong) unitHashCode);
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 0 : 0;
                        continue;
                      case 2:
                        action((ulong) num5);
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 7 : 4;
                        continue;
                      case 3:
                        action((ulong) privilegeLicCount);
                        num11 = 9;
                        continue;
                      case 4:
                        action(InternalSecurityServiceStandart.YxnZPho9xpZvQZOwDrL());
                        num11 = 6;
                        continue;
                      case 5:
                        action((ulong) licSubType);
                        num11 = 3;
                        continue;
                      case 6:
                        if (licSubType == (byte) 1)
                        {
                          num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 5 : 0;
                          continue;
                        }
                        goto case 9;
                      case 7:
                        action(0UL);
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 2 : 4;
                        continue;
                      case 8:
                        goto label_44;
                      case 9:
                        num6 = (byte) InternalSecurityServiceStandart.yXiroYoMZ7lDH2IdpqD((object) shA1, InternalSecurityServiceStandart.pPnUl8o1J3Q8Yp0beFo((object) stream))[0];
                        num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 8 : 0;
                        continue;
                      case 10:
                        action((ulong) licType);
                        num11 = 2;
                        continue;
                      default:
                        action((ulong) licCount);
                        num11 = 10;
                        continue;
                    }
                  }
                }
                finally
                {
                  int num12;
                  if (stream == null)
                    num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
                  else
                    goto label_71;
label_70:
                  switch (num12)
                  {
                    case 2:
                      break;
                    default:
                  }
label_71:
                  InternalSecurityServiceStandart.KWNeCUohKkRAwBWuBq6((object) stream);
                  num12 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0)
                  {
                    num12 = 1;
                    goto label_70;
                  }
                  else
                    goto label_70;
                }
              }
              finally
              {
                if (shA1 != null)
                {
                  int num13 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0)
                    num13 = 0;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        goto label_79;
                      default:
                        InternalSecurityServiceStandart.KWNeCUohKkRAwBWuBq6((object) shA1);
                        num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_79:;
              }
            case 17:
              this.DecodeActivationKey(this.lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
              num2 = 21;
              continue;
            case 18:
              this.InitLicense();
              num2 = 17;
              continue;
            case 19:
              num7 = num3 % 32;
              num2 = 2;
              continue;
            case 20:
label_44:
              if (licSubType != (byte) 1)
              {
                num2 = 12;
                continue;
              }
              numArray5 = new ulong[9]
              {
                0UL,
                (ulong) unitHashCode,
                (ulong) licCount,
                (ulong) licType,
                (ulong) num5,
                0UL,
                (ulong) num6,
                (ulong) licSubType,
                (ulong) privilegeLicCount
              };
              goto label_103;
            case 21:
              if (status == LicenseStatus.Activated)
              {
                unitHashCode = ActivationKeyHelper.GetUnitHashCode(new Guid((string) InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(-1596821387 ^ -1596827431)));
                num2 = 5;
                continue;
              }
              num2 = 24;
              continue;
            case 22:
              goto label_43;
            case 23:
              goto label_99;
            case 24:
              goto label_4;
            case 25:
              timeSpan = expirationDate.Value - new DateTime(2000, 1, 1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 1 : 1;
              continue;
            case 26:
              numArray1[index3] = numArray1[index3] | (uint) num4 << num7;
              num2 = 8;
              continue;
            case 27:
              byte[] numArray6 = new byte[96];
              // ISSUE: field reference
              InternalSecurityServiceStandart.NU5u9GoBOhqg9e19WBX((object) numArray6, __fieldref (\u003CPrivateImplementationDetails\u003E.\u003590509759D722E30F9B9139DC405B39FAD6DBD5B));
              numArray4 = numArray6;
              goto label_105;
            case 28:
              goto label_7;
            default:
              if (licSubType != (byte) 1)
              {
                num2 = 27;
                continue;
              }
              numArray4 = new byte[128];
              // ISSUE: field reference
              InternalSecurityServiceStandart.NU5u9GoBOhqg9e19WBX((object) numArray4, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0032A2CCDEE39142917481EA5BE16417B39BC6FA354));
              goto label_105;
          }
          num5 = (ushort) num8;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 7 : 2;
          continue;
label_103:
          numArray3 = numArray5;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 0 : 0;
          continue;
label_105:
          numArray2 = numArray4;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 9 : 7;
        }
label_43:
        num3 = 0;
        num1 = 11;
        continue;
label_88:
        num4 = (byte) (numArray3[(int) index2] & 1UL);
        num1 = 13;
        continue;
label_99:
        index1 = numArray2.Length - num3 - 1;
        num1 = 4;
      }
label_4:
      return (ActivationToken) null;
label_7:
      ActivationToken activationToken1;
      try
      {
        int num14 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0)
          num14 = 0;
        while (true)
        {
          byte[] numArray7;
          ActivationToken activationToken2;
          BinaryWriter writer;
          switch (num14)
          {
            case 1:
              try
              {
                Action<string> action = (Action<string>) (s =>
                {
                  int num15 = 1;
                  while (true)
                  {
                    byte[] buffer;
                    string str1;
                    switch (num15)
                    {
                      case 1:
                        string str2 = s;
                        if (str2 == null)
                        {
                          num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
                          continue;
                        }
                        str1 = str2;
                        break;
                      case 2:
                        if (buffer.Length > (int) short.MaxValue)
                        {
                          num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 1 : 3;
                          continue;
                        }
                        writer.Write((short) buffer.Length);
                        num15 = 5;
                        continue;
                      case 3:
                        goto label_7;
                      case 4:
                        goto label_2;
                      case 5:
                        writer.Write(buffer);
                        num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 2 : 4;
                        continue;
                      case 6:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        buffer = (byte[]) InternalSecurityServiceStandart.\u003C\u003Ec__DisplayClass19_1.FyDwV2wm6uUu5yWduOTV(InternalSecurityServiceStandart.\u003C\u003Ec__DisplayClass19_1.bkglY9wmmd1QxqsEAnBM(), (object) s);
                        num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 1 : 2;
                        continue;
                      default:
                        str1 = "";
                        break;
                    }
                    s = str1;
                    num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 6 : 2;
                  }
label_2:
                  return;
label_7:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new Exception((string) InternalSecurityServiceStandart.\u003C\u003Ec__DisplayClass19_1.XCEPrxwmDUg657xrYRnw(InternalSecurityServiceStandart.\u003C\u003Ec__DisplayClass19_1.sh6A6OwmkwUNCOx9SeNJ(-617657301 ^ -617716947), (object) s));
                });
                int num16 = 11;
                int index;
                uint[] numArray8;
                ILicensedUnitComponentInfo unitComponentInfo;
                uint num17;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                      action(unitComponentInfo == null ? "" : (string) InternalSecurityServiceStandart.ueeqf2oOXU72U2wxFaN((object) unitComponentInfo));
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 0 : 0;
                      continue;
                    case 2:
                    case 5:
                      if (index >= numArray8.Length)
                      {
                        num16 = 3;
                        continue;
                      }
                      goto case 10;
                    case 3:
                      goto label_12;
                    case 4:
                      unitComponentInfo = (ILicensedUnitComponentInfo) this;
                      num16 = 9;
                      continue;
                    case 6:
                      InternalSecurityServiceStandart.Fq9KZPoTeUVtp9vd2bi((object) output, (object) BitConverter.GetBytes(num17), 0, 4);
                      num16 = 7;
                      continue;
                    case 7:
                      ++index;
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 5 : 5;
                      continue;
                    case 8:
                      index = 0;
                      num16 = 2;
                      continue;
                    case 9:
                      action(unitComponentInfo == null ? "" : (string) InternalSecurityServiceStandart.atnPctopgZF2jWcasPe((object) unitComponentInfo));
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 0 : 1;
                      continue;
                    case 10:
                      num17 = numArray8[index];
                      num16 = 6;
                      continue;
                    case 11:
                      writer.Write(licSubType == (byte) 1 ? (byte) 1 : (byte) 0);
                      num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 1 : 4;
                      continue;
                    default:
                      numArray8 = numArray1;
                      num16 = 8;
                      continue;
                  }
                }
              }
              finally
              {
                int num18;
                if (writer == null)
                  num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 0 : 0;
                else
                  goto label_31;
label_30:
                switch (num18)
                {
                  case 2:
                    break;
                  default:
                }
label_31:
                InternalSecurityServiceStandart.KWNeCUohKkRAwBWuBq6((object) writer);
                num18 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0)
                {
                  num18 = 1;
                  goto label_30;
                }
                else
                  goto label_30;
              }
            case 2:
              activationToken2 = (ActivationToken) null;
              break;
            case 3:
label_12:
              numArray7 = (byte[]) InternalSecurityServiceStandart.pPnUl8o1J3Q8Yp0beFo((object) output);
              num14 = 4;
              continue;
            case 4:
              if (numArray7 == null)
              {
                num14 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 2 : 0;
                continue;
              }
              ActivationToken activationToken3 = new ActivationToken();
              InternalSecurityServiceStandart.IYTiImoFxI5YeeE6IaU((object) activationToken3, (object) numArray7);
              activationToken2 = activationToken3;
              break;
            case 5:
              goto label_46;
            default:
              writer = new BinaryWriter((Stream) output);
              num14 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 1;
              continue;
          }
          activationToken1 = activationToken2;
          num14 = 5;
        }
      }
      finally
      {
        int num19;
        if (output == null)
          num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 0 : 0;
        else
          goto label_39;
label_38:
        switch (num19)
        {
          case 2:
            break;
          default:
        }
label_39:
        InternalSecurityServiceStandart.KWNeCUohKkRAwBWuBq6((object) output);
        num19 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0)
        {
          num19 = 1;
          goto label_38;
        }
        else
          goto label_38;
      }
label_46:
      return activationToken1;
    }

    private void InitLicense()
    {
      int num1 = 1;
      InternalSecurityServiceStandart securityServiceStandart;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!this.initialized)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 0 : 0;
              continue;
            }
            goto label_16;
          case 2:
            goto label_20;
          case 3:
            goto label_2;
          case 4:
            goto label_22;
          case 5:
            lockTaken = false;
            num1 = 3;
            continue;
          default:
            securityServiceStandart = this;
            num1 = 5;
            continue;
        }
      }
label_20:
      return;
label_22:
      return;
label_2:
      try
      {
        Monitor.Enter((object) securityServiceStandart, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0)
          num2 = 4;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo((object) this);
              InternalSecurityServiceStandart.S81bmkoGHIOEKHdIIEx((object) concurrentLicenseInfo, LicenseStatus.NotActivated);
              this.licenseInfo = concurrentLicenseInfo;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 3 : 3;
              continue;
            case 2:
              goto label_11;
            case 3:
              this.initialized = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 0 : 0;
              continue;
            case 4:
              if (this.initialized)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 2 : 1;
                continue;
              }
              goto case 5;
            case 5:
              this.registrationKey = (string) InternalSecurityServiceStandart.BfABCIovaqdrGpNAqYA((ushort) 1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 1 : 1;
              continue;
            default:
              goto label_7;
          }
        }
label_15:
        return;
label_11:
        return;
label_7:
        return;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = 2;
        else
          goto label_17;
label_14:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_17:
        InternalSecurityServiceStandart.wwNfh9oqU1T8qleFLW9((object) securityServiceStandart);
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0)
        {
          num3 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
label_16:;
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
      int num1 = 1;
      ulong num2;
      while (true)
      {
        int num3 = num1;
        int index;
        char ch;
        char[] chArray;
        while (true)
        {
          switch (num3)
          {
            case 1:
              num2 = 0UL;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_30;
            case 3:
label_31:
              ++index;
              num3 = 8;
              continue;
            case 4:
              ch = chArray[index];
              num3 = 7;
              continue;
            case 5:
              index = 0;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 6 : 2;
              continue;
            case 6:
            case 8:
              if (index >= chArray.Length)
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 2 : 2;
                continue;
              }
              goto case 4;
            case 7:
              try
              {
                uint VolumeSerialNumber = 0;
                int num4 = 11;
                StringBuilder VolumeNameBuffer;
                int num5;
                uint FileSystemFlags;
                StringBuilder FileSystemNameBuffer;
                int num6;
                uint MaximumComponentLength;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 2:
                      if (num6 >= 48)
                      {
                        num4 = 8;
                        continue;
                      }
                      goto case 6;
                    case 3:
                      object obj = InternalSecurityServiceStandart.ofokXeogAruL2WSSCAf((object) ch.ToString(), InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(-1788054269 >> 5 ^ -55882818));
                      InternalSecurityServiceStandart.GetVolumeInformation((string) obj, VolumeNameBuffer, (uint) InternalSecurityServiceStandart.EfBQ1NoJQLRlSEg5PUl((object) VolumeNameBuffer), ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, FileSystemNameBuffer, (uint) FileSystemNameBuffer.Capacity);
                      if (InternalSecurityServiceStandart.GetDriveType((string) obj) == 3U)
                      {
                        num4 = 16;
                        continue;
                      }
                      goto label_31;
                    case 4:
                      num2 = 1UL;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 12 : 2;
                      continue;
                    case 5:
                      FileSystemFlags = 0U;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 14 : 14;
                      continue;
                    case 6:
                      num5 = num6 % 32;
                      num4 = 10;
                      continue;
                    case 7:
                      num6 = 0;
                      num4 = 2;
                      continue;
                    case 8:
                      if (num2 == 0UL)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 4 : 4;
                        continue;
                      }
                      goto label_30;
                    case 9:
                      ++num6;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 1 : 0;
                      continue;
                    case 10:
                      if (num6 % 2 == 0)
                      {
                        num4 = 17;
                        continue;
                      }
                      goto case 15;
                    case 11:
                      MaximumComponentLength = 0U;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 13 : 18;
                      continue;
                    case 12:
                      goto label_30;
                    case 13:
                      num2 = num2 << 1 | (ulong) (VolumeSerialNumber >> num5 & 1U);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 9;
                      continue;
                    case 14:
                      FileSystemNameBuffer = new StringBuilder(256);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 1 : 3;
                      continue;
                    case 15:
                      num5 = (num5 + num6 / 16) % 32;
                      num4 = 13;
                      continue;
                    case 16:
                      if (VolumeSerialNumber != 0U)
                      {
                        num4 = 7;
                        continue;
                      }
                      goto label_31;
                    case 17:
                      num5 = 31 - num5;
                      num4 = 15;
                      continue;
                    case 18:
                      VolumeNameBuffer = new StringBuilder(256);
                      num4 = 5;
                      continue;
                    default:
                      goto label_31;
                  }
                }
              }
              catch
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    goto label_31;
                }
              }
            default:
              goto label_36;
          }
        }
label_36:
        chArray = new char[24]
        {
          'C',
          'D',
          'E',
          'F',
          'G',
          'H',
          'I',
          'J',
          'K',
          'L',
          'M',
          'N',
          'O',
          'P',
          'Q',
          'R',
          'S',
          'T',
          'U',
          'V',
          'W',
          'X',
          'Y',
          'Z'
        };
        num1 = 5;
      }
label_30:
      return num2;
    }

    private static string GenerateRegistrationKey(ushort algorithm)
    {
      int num1 = 24;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index1;
        ulong[] numArray1;
        byte index2;
        int num3;
        int num4;
        byte[] numArray2;
        int index3;
        string str;
        byte num5;
        ulong num6;
        int index4;
        uint[] numArray3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 21:
              if (num3 >= numArray2.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 7 : 25;
                continue;
              }
              goto case 14;
            case 2:
            case 17:
              str = (string) InternalSecurityServiceStandart.ofokXeogAruL2WSSCAf(InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(334323849 << 5 ^ 2108424962), (object) str);
              num2 = 18;
              continue;
            case 3:
            case 19:
              if (index1 >= numArray3.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 4:
              ++index1;
              num2 = 3;
              continue;
            case 5:
              ++num3;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 21 : 21;
              continue;
            case 6:
              InternalSecurityServiceStandart.QQee1AoeF2ShOV2AQvZ((object) stringBuilder, (object) str);
              num2 = 4;
              continue;
            case 7:
              num5 = (byte) (numArray1[(int) index2] & 1UL);
              num2 = 16;
              continue;
            case 8:
              str = numArray3[index1].ToString();
              num2 = 22;
              continue;
            case 9:
              num4 = num3 % 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 0 : 7;
              continue;
            case 10:
              index4 = index3 / 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 9 : 4;
              continue;
            case 11:
              num3 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 1 : 1;
              continue;
            case 12:
              numArray2 = new byte[64]
              {
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 0
              };
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 15 : 20;
              continue;
            case 13:
              goto label_8;
            case 14:
              index3 = numArray2.Length - num3 - 1;
              num2 = 26;
              continue;
            case 15:
              numArray3[index4] = numArray3[index4] | (uint) num5 << num4;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 5 : 2;
              continue;
            case 16:
              numArray1[(int) index2] = numArray1[(int) index2] >> 1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 15 : 12;
              continue;
            case 18:
            case 22:
              if (InternalSecurityServiceStandart.ExVKwaoIgIVKZ3fdopL((object) str) < 10)
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 20:
              numArray3 = new uint[numArray2.Length / 32];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 8 : 11;
              continue;
            case 23:
              numArray1 = new ulong[2]
              {
                num6,
                (ulong) algorithm
              };
              num2 = 12;
              continue;
            case 24:
              num6 = InternalSecurityServiceStandart.YxnZPho9xpZvQZOwDrL();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 21 : 23;
              continue;
            case 25:
              stringBuilder = new StringBuilder();
              num2 = 13;
              continue;
            case 26:
              goto label_18;
            default:
              goto label_5;
          }
        }
label_8:
        index1 = 0;
        num1 = 19;
        continue;
label_18:
        index2 = numArray2[index3];
        num1 = 10;
      }
label_5:
      return (string) InternalSecurityServiceStandart.za2CwBon0DEYq3TtPoL((object) stringBuilder.ToString());
    }

    private static string FormatKey(object key)
    {
      int num1 = 8;
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
              ++index;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 4 : 5;
              continue;
            case 2:
            case 5:
              if (index >= charArray.Length)
              {
                num2 = 3;
                continue;
              }
              goto case 11;
            case 3:
              goto label_8;
            case 4:
            case 9:
              stringBuilder.Append(charArray[index]);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_14;
            case 7:
              goto label_15;
            case 8:
              if (key != null)
              {
                num2 = 7;
                continue;
              }
              goto label_14;
            case 10:
              charArray = ((string) key).ToCharArray();
              num2 = 12;
              continue;
            case 11:
              if (index <= 0)
              {
                num2 = 9;
                continue;
              }
              goto case 13;
            case 12:
              index = 0;
              num2 = 2;
              continue;
            case 13:
              if (index % 5 == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            default:
              InternalSecurityServiceStandart.gaO6FKoL2gVwZ1QMbKn((object) stringBuilder, '-');
              num2 = 4;
              continue;
          }
        }
label_15:
        stringBuilder = new StringBuilder();
        num1 = 10;
      }
label_8:
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
      int num1 = 15;
      bool flag;
      while (true)
      {
        int num2 = num1;
        int index1;
        string[] strArray;
        string str1;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_5:
              ++index1;
              num2 = 13;
              continue;
            case 2:
              licSubType = (byte) 0;
              num2 = 12;
              continue;
            case 3:
              index1 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              strArray = (string[]) InternalSecurityServiceStandart.deTMRqo2a6R6DeMdURR((object) key, new Guid((string) InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(-1257514304 ^ -1257508244)));
              num2 = 3;
              continue;
            case 6:
              str1 = strArray[index1];
              num2 = 11;
              continue;
            case 7:
              status = LicenseStatus.NotActivated;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 8 : 9;
              continue;
            case 8:
              try
              {
                ulong num3 = 9127403095191219830;
                int num4 = 27;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0)
                  num4 = 19;
                while (true)
                {
                  int num5;
                  ulong[] numArray1;
                  byte index2;
                  byte num6;
                  int num7;
                  uint[] numArray2;
                  int index3;
                  int index4;
                  int num8;
                  string str2;
                  int num9;
                  ulong num10;
                  ulong num11;
                  int index5;
                  int[] numArray3;
                  int index6;
                  DateTime dateTime;
                  int num12;
                  byte[] numArray4;
                  ushort num13;
                  byte[] numArray5;
                  ulong[] numArray6;
                  switch (num4)
                  {
                    case 1:
                      index6 = numArray4.Length - num12 - 1;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 40 : 28;
                      continue;
                    case 2:
                      numArray2[index5] = InternalSecurityServiceStandart.gSkXg1oz0GdCwZABLbM(InternalSecurityServiceStandart.v74n7NoHbT4Q3Pw1Cqe((object) str2, index5 * 10, 10));
                      num4 = 28;
                      continue;
                    case 3:
                    case 12:
                      if (index4 >= numArray2.Length)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 2 : 8;
                        continue;
                      }
                      goto case 20;
                    case 4:
                      ++num8;
                      num4 = 15;
                      continue;
                    case 5:
                      numArray3 = new int[numArray1.Length];
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 46 : 45;
                      continue;
                    case 6:
                      num7 = numArray3[(int) index2];
                      num4 = 43;
                      continue;
                    case 7:
                      if (num9 > 63)
                      {
                        num4 = 44;
                        continue;
                      }
                      goto case 45;
                    case 8:
                      if (numArray2.Length != 4)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 18 : 30;
                        continue;
                      }
                      numArray5 = new byte[128];
                      // ISSUE: field reference
                      InternalSecurityServiceStandart.NU5u9GoBOhqg9e19WBX((object) numArray5, __fieldref (\u003CPrivateImplementationDetails\u003E.F3843D02A302AFCF602795DFEC50175EB12BDC23));
                      goto label_74;
                    case 9:
                    case 21:
                      if (index5 >= numArray2.Length)
                      {
                        num4 = 49;
                        continue;
                      }
                      goto case 2;
                    case 10:
                      status = LicenseStatus.Activated;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 53 : 26;
                      continue;
                    case 11:
                      ref DateTime? local = ref expirationDate;
                      DateTime? nullable;
                      if (licType != (byte) 1 && licType != (byte) 2)
                      {
                        nullable = new DateTime?();
                      }
                      else
                      {
                        dateTime = new DateTime(2000, 1, 1);
                        nullable = new DateTime?(dateTime.AddDays((double) num13));
                      }
                      local = nullable;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 9 : 13;
                      continue;
                    case 13:
                      if (!expirationDate.HasValue)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 24 : 5;
                        continue;
                      }
                      goto case 23;
                    case 14:
                    case 15:
                      if (num8 >= 32)
                      {
                        num5 = 31;
                        break;
                      }
                      goto case 35;
                    case 16:
                      if (InternalSecurityServiceStandart.GfuuH4od1yBJpd7ZRQc(dateTime.Date, expirationDate.Value))
                      {
                        num4 = 52;
                        continue;
                      }
                      goto case 24;
                    case 17:
                      goto label_5;
                    case 18:
                      if (num9 < 0)
                      {
                        num4 = 19;
                        continue;
                      }
                      goto case 7;
                    case 19:
                      num9 = 0;
                      num4 = 7;
                      continue;
                    case 20:
                      num8 = 0;
                      num5 = 14;
                      break;
                    case 22:
                      num13 = (ushort) numArray1[3];
                      num4 = 11;
                      continue;
                    case 23:
                      dateTime = DateTime.Now;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 13 : 16;
                      continue;
                    case 24:
                    case 25:
                      flag = true;
                      num4 = 36;
                      continue;
                    case 26:
                      privilegeLicCount = numArray2.Length == 4 ? (ushort) numArray1[5] : (ushort) 0;
                      num4 = 38;
                      continue;
                    case 27:
                      str2 = str1.Replace((string) InternalSecurityServiceStandart.ge5nUoo8qVG05jw2suF(2047763786 ^ 1536686658 ^ 563712814), "");
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 50 : 42;
                      continue;
                    case 28:
                      ++index5;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 2 : 9;
                      continue;
                    case 29:
                      index5 = 0;
                      num4 = 21;
                      continue;
                    case 30:
                      byte[] numArray7 = new byte[96];
                      // ISSUE: field reference
                      InternalSecurityServiceStandart.NU5u9GoBOhqg9e19WBX((object) numArray7, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0032B6AB1C097496DECB417A5B914D605D171C62F34));
                      numArray5 = numArray7;
                      goto label_74;
                    case 31:
                      ++index4;
                      num4 = 3;
                      continue;
                    case 32:
                      if ((long) InternalSecurityServiceStandart.YxnZPho9xpZvQZOwDrL() == (long) num11)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 10 : 9;
                        continue;
                      }
                      goto label_5;
                    case 33:
                      index2 = numArray4[index6];
                      num5 = 6;
                      break;
                    case 34:
                      if (numArray2.Length != 4)
                      {
                        num5 = 55;
                        break;
                      }
                      numArray6 = new ulong[6];
                      goto label_76;
                    case 35:
                      num9 = (index4 * 1249 + num8 * 3571) % 64;
                      num4 = 18;
                      continue;
                    case 36:
                      goto label_4;
                    case 37:
                      numArray2[index4] = numArray2[index4] ^ (uint) num10 << num8;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 1 : 4;
                      continue;
                    case 38:
                      licType = (byte) numArray1[2];
                      num4 = 48;
                      continue;
                    case 39:
                      num6 = (byte) (numArray2[index3] & 1U);
                      num4 = 51;
                      continue;
                    case 40:
                      index3 = index6 / 32;
                      num5 = 33;
                      break;
                    case 41:
                    case 47:
                      if (num12 >= numArray4.Length)
                      {
                        num4 = 54;
                        continue;
                      }
                      goto case 1;
                    case 42:
                      ++num12;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 38 : 41;
                      continue;
                    case 43:
                      ++numArray3[(int) index2];
                      num4 = 39;
                      continue;
                    case 44:
                      num9 = 63;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 36 : 45;
                      continue;
                    case 45:
                      num10 = num3 >> num9 & 1UL;
                      num4 = 37;
                      continue;
                    case 46:
                      num12 = 0;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 27 : 47;
                      continue;
                    case 48:
                      licSubType = numArray2.Length == 4 ? (byte) 1 : (byte) 0;
                      num5 = 22;
                      break;
                    case 49:
                      index4 = 0;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 12 : 0;
                      continue;
                    case 50:
                      numArray2 = new uint[InternalSecurityServiceStandart.ExVKwaoIgIVKZ3fdopL((object) str2) / 10];
                      num4 = 29;
                      continue;
                    case 51:
                      numArray2[index3] = numArray2[index3] >> 1;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 0 : 0;
                      continue;
                    case 52:
                      status = LicenseStatus.DateExpired;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 25 : 19;
                      continue;
                    case 53:
                      licCount = (ushort) numArray1[1];
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 12 : 26;
                      continue;
                    case 54:
                      num11 = numArray1[0];
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 31 : 32;
                      continue;
                    case 55:
                      numArray6 = new ulong[5];
                      goto label_76;
                    default:
                      numArray1[(int) index2] = numArray1[(int) index2] | (ulong) num6 << num7;
                      num5 = 42;
                      break;
                  }
                  num4 = num5;
                  continue;
label_74:
                  numArray4 = numArray5;
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 29 : 34;
                  continue;
label_76:
                  numArray1 = numArray6;
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 5 : 1;
                }
              }
              catch
              {
                int num14 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0)
                  num14 = 0;
                switch (num14)
                {
                  default:
                    goto label_5;
                }
              }
            case 9:
              licCount = (ushort) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 10 : 9;
              continue;
            case 10:
              licType = (byte) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 5 : 4;
              continue;
            case 11:
              if (str1 != null)
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 12:
              privilegeLicCount = (ushort) 0;
              num2 = 7;
              continue;
            case 14:
              expirationDate = new DateTime?();
              num2 = 2;
              continue;
            case 15:
              goto label_9;
            default:
              if (index1 >= strArray.Length)
              {
                num2 = 4;
                continue;
              }
              goto case 6;
          }
        }
label_9:
        this.InitLicense();
        num1 = 14;
      }
label_3:
      return false;
label_4:
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

    public InternalSecurityServiceStandart()
    {
      InternalSecurityServiceStandart.WDoGI2tuOpViwnbDsQo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static uint B1ZHCxocAvOddlk1Yu8([In] object obj0) => ((InternalSecurityServiceBase) obj0).UsedLicenseCount;

    internal static uint FnDdh4oPhsoQ3AinZnX([In] object obj0) => ((InternalSecurityServiceBase) obj0).UsedPrivilegeCount;

    internal static bool IepJKmofG3rFm1ZYH6i() => InternalSecurityServiceStandart.vSGgsTolcdya66rKn0P == null;

    internal static InternalSecurityServiceStandart bf9bkfo4IaIumyoN3Bb() => InternalSecurityServiceStandart.vSGgsTolcdya66rKn0P;

    internal static object W5UW8toQ9YrVc1SKQNG([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object ge5nUoo8qVG05jw2suF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool h6clWTo5P5mxgg2M0WJ([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool GfuuH4od1yBJpd7ZRQc([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static LicenseStatus hedfd1oEHuOZmdasReY([In] object obj0) => ((LicenseInfo) obj0).Status;

    internal static void S81bmkoGHIOEKHdIIEx([In] object obj0, [In] LicenseStatus obj1) => ((LicenseInfo) obj0).Status = obj1;

    internal static object S30bEaoX967xe5VJB95() => (object) SHA1.Create();

    internal static ulong YxnZPho9xpZvQZOwDrL() => InternalSecurityServiceStandart.GHN();

    internal static object pPnUl8o1J3Q8Yp0beFo([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static object yXiroYoMZ7lDH2IdpqD([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static void KWNeCUohKkRAwBWuBq6([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void NU5u9GoBOhqg9e19WBX([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static object atnPctopgZF2jWcasPe([In] object obj0) => (object) ((ILicensedUnitComponentInfo) obj0).GetComponentId();

    internal static object ueeqf2oOXU72U2wxFaN([In] object obj0) => (object) ((ILicensedUnitComponentInfo) obj0).GetComponentVersion();

    internal static void Fq9KZPoTeUVtp9vd2bi([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static void IYTiImoFxI5YeeE6IaU([In] object obj0, [In] object obj1) => ((ActivationToken) obj0).Token = (byte[]) obj1;

    internal static object BfABCIovaqdrGpNAqYA(ushort algorithm) => (object) InternalSecurityServiceStandart.GenerateRegistrationKey(algorithm);

    internal static void wwNfh9oqU1T8qleFLW9([In] object obj0) => Monitor.Exit(obj0);

    internal static object ofokXeogAruL2WSSCAf([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int EfBQ1NoJQLRlSEg5PUl([In] object obj0) => ((StringBuilder) obj0).Capacity;

    internal static int ExVKwaoIgIVKZ3fdopL([In] object obj0) => ((string) obj0).Length;

    internal static object QQee1AoeF2ShOV2AQvZ([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object za2CwBon0DEYq3TtPoL([In] object obj0) => (object) InternalSecurityServiceStandart.FormatKey(obj0);

    internal static object gaO6FKoL2gVwZ1QMbKn([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static object deTMRqo2a6R6DeMdURR([In] object obj0, [In] Guid obj1) => (object) ActivationKeyHelper.GetUnitActivationKeys((string) obj0, obj1);

    internal static object v74n7NoHbT4Q3Pw1Cqe([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static uint gSkXg1oz0GdCwZABLbM([In] object obj0) => uint.Parse((string) obj0);

    internal static void WDoGI2tuOpViwnbDsQo() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
