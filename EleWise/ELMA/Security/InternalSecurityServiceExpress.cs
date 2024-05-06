// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InternalSecurityServiceExpress
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Security
{
  internal class InternalSecurityServiceExpress : 
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
    private static InternalSecurityServiceExpress iJxuAlRVbMWMp03bEye;

    uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => InternalSecurityServiceExpress.A3CgHaR4ABeUYF9yiMe((object) this);

    uint IConcurrentLicenseInfoOwner.UsedPrivilegeCount => InternalSecurityServiceExpress.yHBAcjRchYNn1gB2NHd((object) this);

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
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 0 : 0;
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
              if (InternalSecurityServiceExpress.QeaTyXRQKPup4iQmlyp((object) Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name, InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(554338340 ^ 554348394)))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 0 : 0;
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
      if (Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331077212))
        throw new LicenseException();
      base.CheckUserToAuthenticate(user, isAlreadyLoggedFunc, isCurrentPrivilegeFunc, otherUsersCountFunc);
    }

    protected override bool CanCreateNewUser()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!InternalSecurityServiceExpress.QeaTyXRQKPup4iQmlyp((object) Locator.GetServiceNotNull<IMainDatabaseProvider>().GetType().Name, InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(-94240706 ^ -94230672)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 1 : 0;
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
      return base.CanCreateNewUser();
    }

    Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string) InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(--2002186503 ^ 2002179697));

    string ILicensedUnit.GetRegistrationKey()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 0;
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
      int num1 = 20;
      while (true)
      {
        int num2 = num1;
        byte licSubType1;
        LicenseStatus status;
        ushort licCount1;
        ushort privilegeLicCount1;
        DateTime? expirationDate1;
        byte licType1;
        while (true)
        {
          ushort licCount2;
          ushort privilegeLicCount2;
          byte licType2;
          byte licSubType2;
          DateTime? expirationDate2;
          byte num3;
          byte num4;
          int num5;
          int num6;
          switch (num2)
          {
            case 2:
              num5 = (int) licType2;
              goto label_57;
            case 3:
              goto label_47;
            case 4:
              goto label_33;
            case 5:
label_45:
              if ((int) licCount1 == (int) licCount2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 12 : 14;
                continue;
              }
              goto label_36;
            case 6:
              num6 = (int) licType1;
              goto label_55;
            case 7:
              goto label_8;
            case 8:
              goto label_53;
            case 9:
            case 10:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 2 : 4;
              continue;
            case 11:
              if (expirationDate1.HasValue)
              {
                num2 = 27;
                continue;
              }
              break;
            case 12:
              if (licType1 == (byte) 2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 11 : 2;
                continue;
              }
              break;
            case 13:
              goto label_27;
            case 14:
              if ((int) privilegeLicCount1 <= (int) privilegeLicCount2)
              {
                num2 = 16;
                continue;
              }
              goto case 9;
            case 15:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 3;
              continue;
            case 16:
              goto label_32;
            case 17:
              if (licType2 != (byte) 2)
              {
                num2 = 2;
                continue;
              }
              num5 = 1;
              goto label_57;
            case 18:
              goto label_3;
            case 19:
              if (this.DecodeActivationKey(key, out status, out licCount1, out privilegeLicCount1, out licType1, out licSubType1, out expirationDate1))
              {
                if (this.lastAppliedActKey == null)
                  goto case 15;
                else
                  goto label_23;
              }
              else
                goto label_49;
            case 20:
              this.InitLicense();
              num2 = 19;
              continue;
            case 21:
              if (expirationDate1.Value > expirationDate2.Value)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 1 : 1;
                continue;
              }
              break;
            case 22:
              goto label_5;
            case 23:
              if ((int) num3 >= (int) num4)
              {
                if ((int) num3 > (int) num4)
                {
                  num2 = 22;
                  continue;
                }
                if ((int) licSubType1 > (int) licSubType2)
                {
                  num2 = 26;
                  continue;
                }
                if ((int) licSubType1 >= (int) licSubType2)
                {
                  if (licType1 != (byte) 1)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 12;
                    continue;
                  }
                  goto case 11;
                }
                else
                {
                  num2 = 7;
                  continue;
                }
              }
              else
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 8 : 3;
                continue;
              }
            case 24:
              this.DecodeActivationKey(this.lastAppliedActKey, out LicenseStatus _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate2);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 28 : 23;
              continue;
            case 25:
              goto label_21;
            case 26:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 25;
              continue;
            case 27:
              if (!expirationDate2.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
                continue;
              }
              goto case 21;
            case 28:
              if (licType1 != (byte) 2)
              {
                num2 = 6;
                continue;
              }
              num6 = 1;
              goto label_55;
            case 29:
              goto label_16;
            default:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 8 : 13;
              continue;
          }
          if ((int) licCount1 > (int) licCount2)
          {
            num2 = 10;
            continue;
          }
          goto label_45;
label_55:
          num3 = (byte) num6;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 17 : 5;
          continue;
label_57:
          num4 = (byte) num5;
          num2 = 23;
        }
label_23:
        num1 = 24;
        continue;
label_49:
        num1 = 29;
        continue;
label_53:
        this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
        num1 = 18;
      }
label_47:
      return;
label_33:
      return;
label_8:
      return;
label_27:
      return;
label_32:
      return;
label_3:
      return;
label_5:
      return;
label_21:
      return;
label_16:
      return;
label_36:;
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
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
            continue;
          case 2:
            this.InitLicense();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            this.initializedStatus = InternalSecurityServiceExpress.SQqwYnR8x96e3aLfKyt((object) this.licenseInfo);
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
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
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
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 0 : 0;
            continue;
          case 2:
            InternalSecurityServiceExpress.fyOUBFR51ijo7jFsoVi((object) this.licenseInfo, status);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 3 : 2;
            continue;
          case 3:
            goto label_2;
          default:
            this.DecodeActivationKey(this.lastAppliedActKey, out status, out ushort _, out ushort _, out byte _, out byte _, out DateTime? _);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    byte[] ILicensedUnit.GetActivationToken() => (byte[]) null;

    ActivationToken IActivationTokenContainer.GetActivationToken()
    {
      int num1 = 3;
      uint[] numArray1;
      byte licSubType;
      MemoryStream output;
      while (true)
      {
        int num2 = num1;
        byte index1;
        byte num3;
        ulong[] numArray2;
        while (true)
        {
          byte[] numArray3;
          uint num4;
          byte licType;
          ushort num5;
          ushort privilegeLicCount;
          ushort licCount;
          SHA1 shA1;
          byte num6;
          int index2;
          int num7;
          int num8;
          TimeSpan timeSpan;
          int index3;
          DateTime? expirationDate;
          LicenseStatus status;
          int num9;
          ulong[] numArray4;
          byte[] numArray5;
          switch (num2)
          {
            case 1:
            case 14:
              if (num7 >= numArray3.Length)
              {
                num2 = 8;
                continue;
              }
              goto case 6;
            case 2:
              this.DecodeActivationKey(this.lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
              num2 = 25;
              continue;
            case 3:
              this.InitLicense();
              num2 = 2;
              continue;
            case 4:
label_38:
              if (licSubType != (byte) 1)
              {
                num2 = 17;
                continue;
              }
              numArray4 = new ulong[9]
              {
                0UL,
                (ulong) num4,
                (ulong) licCount,
                (ulong) licType,
                (ulong) num5,
                0UL,
                (ulong) num6,
                (ulong) licSubType,
                (ulong) privilegeLicCount
              };
              goto label_103;
            case 5:
              shA1 = (SHA1) InternalSecurityServiceExpress.KekuZURGlMWJHPqRNcV();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 6 : 7;
              continue;
            case 6:
              index2 = numArray3.Length - num7 - 1;
              num2 = 24;
              continue;
            case 7:
              try
              {
                int num10 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0)
                  num10 = 1;
                MemoryStream stream;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      stream = new MemoryStream();
                      num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_8;
                  }
                }
label_8:
                try
                {
                  Action<ulong> action = (Action<ulong>) (v =>
                  {
                    int num11 = 1;
                    while (true)
                    {
                      switch (num11)
                      {
                        case 0:
                          goto label_2;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          InternalSecurityServiceExpress.\u003C\u003Ec__DisplayClass19_0.oV0CTRwtEBFh5RO1jbSM((object) stream, InternalSecurityServiceExpress.\u003C\u003Ec__DisplayClass19_0.XHnPc2wtdxU0jH55WmLQ(v), 0, 8);
                          num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_4;
                      }
                    }
label_2:
                    return;
label_4:;
                  });
                  int num12 = 9;
                  while (true)
                  {
                    switch (num12)
                    {
                      case 1:
                        action((ulong) licType);
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 9 : 10;
                        continue;
                      case 2:
                        action(InternalSecurityServiceExpress.QWQadGRX5HyT9kPFQmc());
                        num12 = 8;
                        continue;
                      case 3:
                        action((ulong) licSubType);
                        num12 = 6;
                        continue;
                      case 4:
                        action(0UL);
                        num12 = 2;
                        continue;
                      case 5:
                        action((ulong) licCount);
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 1;
                        continue;
                      case 6:
                        action((ulong) privilegeLicCount);
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 0 : 0;
                        continue;
                      case 7:
                        goto label_38;
                      case 8:
                        if (licSubType == (byte) 1)
                        {
                          num12 = 3;
                          continue;
                        }
                        break;
                      case 9:
                        action((ulong) num4);
                        num12 = 5;
                        continue;
                      case 10:
                        action((ulong) num5);
                        num12 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 3 : 4;
                        continue;
                    }
                    num6 = shA1.ComputeHash(stream.ToArray())[0];
                    num12 = 7;
                  }
                }
                finally
                {
                  if (stream != null)
                  {
                    int num13 = 0;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0)
                      num13 = 0;
                    while (true)
                    {
                      switch (num13)
                      {
                        case 1:
                          goto label_27;
                        default:
                          InternalSecurityServiceExpress.VdAS0mR9voSvUEsD09c((object) stream);
                          num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_27:;
                }
              }
              finally
              {
                if (shA1 != null)
                {
                  int num14 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0)
                    num14 = 1;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        InternalSecurityServiceExpress.VdAS0mR9voSvUEsD09c((object) shA1);
                        num14 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_33;
                    }
                  }
                }
label_33:;
              }
            case 8:
              output = new MemoryStream();
              num2 = 9;
              continue;
            case 9:
              goto label_46;
            case 10:
              num7 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 1 : 1;
              continue;
            case 11:
              num9 = 0;
              break;
            case 12:
              timeSpan = InternalSecurityServiceExpress.f3iNGIREakYaZYc22br(expirationDate.Value, new DateTime(2000, 1, 1));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
              continue;
            case 13:
              numArray2[(int) index1] = numArray2[(int) index1] >> 1;
              num2 = 20;
              continue;
            case 15:
              if (licSubType != (byte) 1)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 3 : 22;
                continue;
              }
              numArray5 = new byte[128]
              {
                (byte) 2,
                (byte) 1,
                (byte) 3,
                (byte) 6,
                (byte) 6,
                (byte) 3,
                (byte) 1,
                (byte) 2,
                (byte) 1,
                (byte) 5,
                (byte) 1,
                (byte) 2,
                (byte) 2,
                (byte) 1,
                (byte) 5,
                (byte) 1,
                (byte) 7,
                (byte) 1,
                (byte) 4,
                (byte) 8,
                (byte) 8,
                (byte) 4,
                (byte) 1,
                (byte) 7,
                (byte) 8,
                (byte) 4,
                (byte) 1,
                (byte) 5,
                (byte) 5,
                (byte) 1,
                (byte) 4,
                (byte) 8,
                (byte) 1,
                (byte) 6,
                (byte) 1,
                (byte) 4,
                (byte) 4,
                (byte) 1,
                (byte) 6,
                (byte) 1,
                (byte) 4,
                (byte) 8,
                (byte) 7,
                (byte) 5,
                (byte) 5,
                (byte) 7,
                (byte) 8,
                (byte) 4,
                (byte) 1,
                (byte) 2,
                (byte) 1,
                (byte) 0,
                (byte) 0,
                (byte) 1,
                (byte) 2,
                (byte) 1,
                (byte) 3,
                (byte) 8,
                (byte) 0,
                (byte) 1,
                (byte) 1,
                (byte) 0,
                (byte) 8,
                (byte) 3,
                (byte) 2,
                (byte) 8,
                (byte) 0,
                (byte) 3,
                (byte) 3,
                (byte) 0,
                (byte) 8,
                (byte) 2,
                (byte) 7,
                (byte) 4,
                (byte) 1,
                (byte) 6,
                (byte) 6,
                (byte) 1,
                (byte) 4,
                (byte) 7,
                (byte) 8,
                (byte) 1,
                (byte) 4,
                (byte) 2,
                (byte) 2,
                (byte) 4,
                (byte) 1,
                (byte) 8,
                (byte) 2,
                (byte) 4,
                (byte) 1,
                (byte) 5,
                (byte) 5,
                (byte) 1,
                (byte) 4,
                (byte) 2,
                (byte) 3,
                (byte) 2,
                (byte) 8,
                (byte) 0,
                (byte) 0,
                (byte) 8,
                (byte) 2,
                (byte) 3,
                (byte) 1,
                (byte) 5,
                (byte) 2,
                (byte) 6,
                (byte) 6,
                (byte) 2,
                (byte) 5,
                (byte) 1,
                (byte) 8,
                (byte) 1,
                (byte) 5,
                (byte) 7,
                (byte) 7,
                (byte) 5,
                (byte) 1,
                (byte) 8,
                (byte) 5,
                (byte) 1,
                (byte) 4,
                (byte) 5,
                (byte) 5,
                (byte) 4,
                (byte) 1,
                (byte) 5
              };
              goto label_105;
            case 16:
              ++num7;
              num2 = 14;
              continue;
            case 17:
              numArray4 = new ulong[7]
              {
                0UL,
                (ulong) num4,
                (ulong) licCount,
                (ulong) licType,
                (ulong) num5,
                0UL,
                (ulong) num6
              };
              goto label_103;
            case 18:
              goto label_93;
            case 19:
              num8 = num7 % 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 9 : 18;
              continue;
            case 20:
              numArray1[index3] = numArray1[index3] | (uint) num3 << num8;
              num2 = 16;
              continue;
            case 21:
              goto label_91;
            case 22:
              byte[] numArray6 = new byte[96];
              // ISSUE: field reference
              InternalSecurityServiceExpress.RExI9BR1XbDMREGcv5E((object) numArray6, __fieldref (\u003CPrivateImplementationDetails\u003E.\u003590509759D722E30F9B9139DC405B39FAD6DBD5B));
              numArray5 = numArray6;
              goto label_105;
            case 23:
              if (!expirationDate.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 11 : 9;
                continue;
              }
              goto case 12;
            case 24:
              index1 = numArray3[index2];
              num2 = 27;
              continue;
            case 25:
              if (status != LicenseStatus.Activated)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 16 : 28;
                continue;
              }
              num4 = InternalSecurityServiceExpress.GuJLocRdxiTcgtbpCJs(new Guid((string) InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(386642440 ^ 386635214)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 23 : 12;
              continue;
            case 26:
              numArray1 = new uint[numArray3.Length / 32];
              num2 = 10;
              continue;
            case 27:
              index3 = index2 / 32;
              num2 = 19;
              continue;
            case 28:
              goto label_96;
            default:
              num9 = (int) (ushort) timeSpan.TotalDays;
              break;
          }
          num5 = (ushort) num9;
          num2 = 5;
          continue;
label_103:
          numArray2 = numArray4;
          num2 = 15;
          continue;
label_105:
          numArray3 = numArray5;
          num2 = 26;
        }
label_93:
        num3 = (byte) (numArray2[(int) index1] & 1UL);
        num1 = 13;
      }
label_46:
      ActivationToken activationToken1;
      try
      {
        int num15 = 5;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0)
          num15 = 5;
        while (true)
        {
          byte[] numArray7;
          ActivationToken activationToken2;
          BinaryWriter writer;
          switch (num15)
          {
            case 1:
              goto label_91;
            case 2:
              if (numArray7 == null)
              {
                num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 1 : 3;
                continue;
              }
              activationToken2 = new ActivationToken();
              InternalSecurityServiceExpress.erxRnaRpfSIS23ld6mT((object) activationToken2, (object) numArray7);
              break;
            case 3:
              activationToken2 = (ActivationToken) null;
              break;
            case 4:
label_70:
              numArray7 = (byte[]) InternalSecurityServiceExpress.OQUwUSRBCND7XPnuZGZ((object) output);
              num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 1 : 2;
              continue;
            case 5:
              writer = new BinaryWriter((Stream) output);
              num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
              continue;
            default:
              try
              {
                Action<string> action = (Action<string>) (s =>
                {
                  int num16 = 2;
                  while (true)
                  {
                    int num17 = num16;
                    byte[] buffer;
                    while (true)
                    {
                      string str1;
                      switch (num17)
                      {
                        case 1:
                          str1 = "";
                          break;
                        case 2:
                          string str2 = s;
                          if (str2 == null)
                          {
                            num17 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 1 : 1;
                            continue;
                          }
                          str1 = str2;
                          break;
                        case 3:
                          goto label_10;
                        case 4:
                          if (buffer.Length <= (int) short.MaxValue)
                          {
                            writer.Write((short) buffer.Length);
                            num17 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
                            continue;
                          }
                          num17 = 5;
                          continue;
                        case 5:
                          goto label_3;
                        case 6:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          buffer = (byte[]) InternalSecurityServiceExpress.\u003C\u003Ec__DisplayClass19_1.KeGgoAwthKpZ7iM4PsyN(InternalSecurityServiceExpress.\u003C\u003Ec__DisplayClass19_1.W9li8WwtMoptZhPBVK5Z(), (object) s);
                          num17 = 4;
                          continue;
                        default:
                          goto label_5;
                      }
                      s = str1;
                      num17 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 2 : 6;
                    }
label_5:
                    writer.Write(buffer);
                    num16 = 3;
                  }
label_10:
                  return;
label_3:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new Exception((string) InternalSecurityServiceExpress.\u003C\u003Ec__DisplayClass19_1.KGHjCJwtpdlvEBeCmthA(InternalSecurityServiceExpress.\u003C\u003Ec__DisplayClass19_1.Mg2XOcwtBncdqsMhLtly(1095474805 ^ 155418997 ^ 1208561670), (object) s));
                });
                int num18 = 4;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0)
                  num18 = 9;
                int index;
                uint[] numArray8;
                ILicensedUnitComponentInfo unitComponentInfo;
                uint num19;
                while (true)
                {
                  switch (num18)
                  {
                    case 1:
                    case 2:
                      if (index >= numArray8.Length)
                      {
                        num18 = 3;
                        continue;
                      }
                      goto case 11;
                    case 3:
                      goto label_70;
                    case 4:
                      numArray8 = numArray1;
                      num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 6 : 4;
                      continue;
                    case 5:
                      ++index;
                      num18 = 2;
                      continue;
                    case 6:
                      index = 0;
                      num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 1 : 1;
                      continue;
                    case 7:
                      InternalSecurityServiceExpress.NMRdcaRhmqsHv96aY7V((object) output, (object) BitConverter.GetBytes(num19), 0, 4);
                      num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 4 : 5;
                      continue;
                    case 8:
                      unitComponentInfo = (ILicensedUnitComponentInfo) this;
                      num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 0 : 0;
                      continue;
                    case 9:
                      writer.Write(licSubType == (byte) 1 ? (byte) 1 : (byte) 0);
                      num18 = 8;
                      continue;
                    case 10:
                      action(unitComponentInfo == null ? "" : unitComponentInfo.GetComponentVersion());
                      num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 2 : 4;
                      continue;
                    case 11:
                      num19 = numArray8[index];
                      num18 = 7;
                      continue;
                    default:
                      action(unitComponentInfo != null ? (string) InternalSecurityServiceExpress.Fb2S7gRMVjb46ZDAYaH((object) unitComponentInfo) : "");
                      num18 = 10;
                      continue;
                  }
                }
              }
              finally
              {
                int num20;
                if (writer == null)
                  num20 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 0 : 0;
                else
                  goto label_68;
label_67:
                switch (num20)
                {
                  case 1:
                    break;
                  default:
                }
label_68:
                InternalSecurityServiceExpress.VdAS0mR9voSvUEsD09c((object) writer);
                num20 = 2;
                goto label_67;
              }
          }
          activationToken1 = activationToken2;
          num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 1 : 0;
        }
      }
      finally
      {
        if (output != null)
        {
          int num21 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0)
            num21 = 0;
          while (true)
          {
            switch (num21)
            {
              case 1:
                goto label_81;
              default:
                InternalSecurityServiceExpress.VdAS0mR9voSvUEsD09c((object) output);
                num21 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_81:;
      }
label_91:
      return activationToken1;
label_96:
      return (ActivationToken) null;
    }

    private void InitLicense()
    {
      int num1 = 4;
      InternalSecurityServiceExpress securityServiceExpress;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_19;
          case 1:
            goto label_2;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_21;
          case 4:
            if (this.initialized)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 3 : 1;
              continue;
            }
            securityServiceExpress = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 2 : 2;
            continue;
          default:
            goto label_16;
        }
      }
label_19:
      return;
label_21:
      return;
label_16:
      return;
label_2:
      try
      {
        Monitor.Enter((object) securityServiceExpress, ref lockTaken);
        int num2 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0)
          num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
              this.registrationKey = (string) InternalSecurityServiceExpress.X5oVg3RO9G5TJ1Ymiu5((ushort) 1);
              num2 = 4;
              continue;
            case 2:
              if (this.initialized)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 3 : 3;
                continue;
              }
              goto case 1;
            case 3:
              goto label_7;
            case 4:
              ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo((object) this);
              InternalSecurityServiceExpress.fyOUBFR51ijo7jFsoVi((object) concurrentLicenseInfo, LicenseStatus.NotActivated);
              this.licenseInfo = concurrentLicenseInfo;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 5 : 3;
              continue;
            case 5:
              this.initialized = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_12:
        return;
label_7:
        return;
label_5:;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 1 : 1;
        else
          goto label_17;
label_15:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_17:
        InternalSecurityServiceExpress.KMjC6dRTolS4Yb33NHN((object) securityServiceExpress);
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0)
        {
          num3 = 0;
          goto label_15;
        }
        else
          goto label_15;
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
      int num1 = 7;
      ulong num2;
      int index;
      char[] chArray1;
      char ch;
      while (true)
      {
        switch (num1)
        {
          case 1:
            index = 0;
            num1 = 3;
            continue;
          case 2:
          case 3:
            if (index >= chArray1.Length)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 4:
label_5:
            ++index;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 2 : 2;
            continue;
          case 5:
            try
            {
              uint VolumeSerialNumber = 0;
              int num3 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
                num3 = 1;
              int num4;
              int num5;
              StringBuilder FileSystemNameBuffer;
              StringBuilder VolumeNameBuffer;
              uint MaximumComponentLength;
              uint FileSystemFlags;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    MaximumComponentLength = 0U;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 3;
                    continue;
                  case 2:
                  case 12:
                    if (num4 >= 48)
                    {
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 5 : 8;
                      continue;
                    }
                    goto case 19;
                  case 3:
                    VolumeNameBuffer = new StringBuilder(256);
                    num3 = 14;
                    continue;
                  case 4:
                    num5 = 31 - num5;
                    num3 = 9;
                    continue;
                  case 5:
                  case 11:
                    goto label_2;
                  case 6:
                    goto label_5;
                  case 7:
                    ++num4;
                    num3 = 12;
                    continue;
                  case 8:
                    if (num2 != 0UL)
                    {
                      num3 = 5;
                      continue;
                    }
                    goto case 15;
                  case 9:
                    num5 = (num5 + num4 / 16) % 32;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
                    continue;
                  case 10:
                    if (VolumeSerialNumber != 0U)
                    {
                      num3 = 16;
                      continue;
                    }
                    goto label_5;
                  case 13:
                    FileSystemNameBuffer = new StringBuilder(256);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 14 : 18;
                    continue;
                  case 14:
                    FileSystemFlags = 0U;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 5 : 13;
                    continue;
                  case 15:
                    num2 = 1UL;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 11 : 6;
                    continue;
                  case 16:
                    num4 = 0;
                    num3 = 2;
                    continue;
                  case 17:
                    if (num4 % 2 == 0)
                    {
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 2 : 4;
                      continue;
                    }
                    goto case 9;
                  case 18:
                    object obj = InternalSecurityServiceExpress.OMT5dcRFxrnotXFBgTW((object) ch.ToString(), InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(-1028265253 << 4 ^ 727614886));
                    InternalSecurityServiceExpress.GetVolumeInformation((string) obj, VolumeNameBuffer, (uint) VolumeNameBuffer.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, FileSystemNameBuffer, (uint) FileSystemNameBuffer.Capacity);
                    if (InternalSecurityServiceExpress.GetDriveType((string) obj) == 3U)
                    {
                      num3 = 10;
                      continue;
                    }
                    goto label_5;
                  case 19:
                    num5 = num4 % 32;
                    num3 = 17;
                    continue;
                  default:
                    num2 = num2 << 1 | (ulong) (VolumeSerialNumber >> num5 & 1U);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 7 : 4;
                    continue;
                }
              }
            }
            catch
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0)
                num6 = 0;
              switch (num6)
              {
                default:
                  goto label_5;
              }
            }
          case 6:
            char[] chArray2 = new char[24];
            // ISSUE: field reference
            InternalSecurityServiceExpress.RExI9BR1XbDMREGcv5E((object) chArray2, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0039A504FB7A5500CBA32FE333D0392DBF00E81582F));
            chArray1 = chArray2;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 0 : 1;
            continue;
          case 7:
            num2 = 0UL;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 6 : 2;
            continue;
          case 8:
            ch = chArray1[index];
            num1 = 5;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return num2;
    }

    private static string GenerateRegistrationKey(ushort algorithm)
    {
      int num1 = 19;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        uint[] numArray1;
        int index1;
        byte num3;
        int num4;
        int index2;
        int index3;
        string str;
        ulong num5;
        ulong[] numArray2;
        byte index4;
        byte[] numArray3;
        int num6;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 20:
              if (index3 >= numArray1.Length)
              {
                num2 = 16;
                continue;
              }
              goto case 24;
            case 2:
              byte[] numArray4 = new byte[64];
              // ISSUE: field reference
              InternalSecurityServiceExpress.RExI9BR1XbDMREGcv5E((object) numArray4, __fieldref (\u003CPrivateImplementationDetails\u003E.FD3F148DA31DE202E19855BF74F986A0DDC9F29F));
              numArray3 = numArray4;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 0 : 0;
              continue;
            case 3:
              index1 = index2 / 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 3 : 8;
              continue;
            case 4:
              num3 = (byte) (numArray2[(int) index4] & 1UL);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 17 : 9;
              continue;
            case 5:
            case 25:
              str = (string) InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(631805505 ^ 631800931) + str;
              num2 = 9;
              continue;
            case 6:
              index4 = numArray3[index2];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 3 : 3;
              continue;
            case 7:
              index3 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 11 : 20;
              continue;
            case 8:
              num4 = num6 % 32;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 4 : 0;
              continue;
            case 9:
            case 12:
              if (str.Length < 10)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 3 : 5;
                continue;
              }
              goto case 10;
            case 10:
              InternalSecurityServiceExpress.tNKhx6RvQ3maSfbTknK((object) stringBuilder, (object) str);
              num2 = 21;
              continue;
            case 11:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 7 : 6;
              continue;
            case 13:
              numArray1[index1] = numArray1[index1] | (uint) num3 << num4;
              num2 = 15;
              continue;
            case 14:
              num6 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 12 : 23;
              continue;
            case 15:
              ++num6;
              num2 = 26;
              continue;
            case 16:
              goto label_13;
            case 17:
              numArray2[(int) index4] = numArray2[(int) index4] >> 1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 13 : 8;
              continue;
            case 18:
              goto label_14;
            case 19:
              num5 = InternalSecurityServiceExpress.QWQadGRX5HyT9kPFQmc();
              num2 = 18;
              continue;
            case 21:
              ++index3;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 1;
              continue;
            case 22:
            case 27:
              goto label_12;
            case 23:
            case 26:
              if (num6 < numArray3.Length)
              {
                num2 = 27;
                continue;
              }
              goto case 11;
            case 24:
              str = numArray1[index3].ToString();
              num2 = 12;
              continue;
            default:
              numArray1 = new uint[numArray3.Length / 32];
              num2 = 14;
              continue;
          }
        }
label_12:
        index2 = numArray3.Length - num6 - 1;
        num1 = 6;
        continue;
label_14:
        numArray2 = new ulong[2]{ num5, (ulong) algorithm };
        num1 = 2;
      }
label_13:
      return (string) InternalSecurityServiceExpress.LQcOkQRquC6h8Nw96oP((object) stringBuilder.ToString());
    }

    private static string FormatKey(object key)
    {
      int num1 = 7;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        char[] chArray;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              goto label_13;
            case 2:
            case 13:
              if (index < chArray.Length)
              {
                num2 = 11;
                continue;
              }
              goto label_18;
            case 3:
              InternalSecurityServiceExpress.bHLu9hRJblau4nIyH6J((object) stringBuilder, '-');
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 1 : 0;
              continue;
            case 5:
              goto label_18;
            case 6:
              goto label_6;
            case 7:
              if (key == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 4 : 6;
                continue;
              }
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 0;
              continue;
            case 8:
              ++index;
              num2 = 13;
              continue;
            case 9:
              if (index % 5 != 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 4;
                continue;
              }
              goto case 3;
            case 10:
              index = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 2 : 0;
              continue;
            case 11:
            case 12:
              if (index > 0)
              {
                num2 = 9;
                continue;
              }
              goto label_13;
            default:
              goto label_5;
          }
        }
label_5:
        chArray = (char[]) InternalSecurityServiceExpress.M8whiDRgOQIaAUgkOl1(key);
        num1 = 10;
        continue;
label_13:
        stringBuilder.Append(chArray[index]);
        num1 = 8;
      }
label_6:
      return string.Empty;
label_18:
      return stringBuilder.ToString();
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
      int num1 = 9;
      bool flag;
      while (true)
      {
        int num2 = num1;
        int index1;
        string str1;
        string[] strArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              strArray = (string[]) InternalSecurityServiceExpress.JjHKDYRIgPXYkaoOjBe((object) key, new Guid((string) InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(-1788054269 >> 5 ^ -55884690)));
              num2 = 13;
              continue;
            case 2:
            case 15:
              if (index1 >= strArray.Length)
              {
                num2 = 4;
                continue;
              }
              goto case 14;
            case 3:
              goto label_3;
            case 4:
              goto label_6;
            case 5:
              if (str1 != null)
              {
                num2 = 11;
                continue;
              }
              goto label_3;
            case 6:
              licCount = (ushort) 0;
              num2 = 7;
              continue;
            case 7:
              licType = (byte) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 1 : 1;
              continue;
            case 8:
              goto label_4;
            case 9:
              goto label_5;
            case 10:
              licSubType = (byte) 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_10;
            case 12:
              status = LicenseStatus.NotActivated;
              num2 = 6;
              continue;
            case 13:
              index1 = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 2 : 0;
              continue;
            case 14:
              str1 = strArray[index1];
              num2 = 5;
              continue;
            default:
              privilegeLicCount = (ushort) 0;
              num2 = 12;
              continue;
          }
        }
label_3:
        ++index1;
        num1 = 15;
        continue;
label_4:
        expirationDate = new DateTime?();
        num1 = 10;
        continue;
label_5:
        this.InitLicense();
        num1 = 8;
        continue;
label_10:
        try
        {
          ulong num3 = 14285381004231378591;
          int num4 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0)
            num4 = 2;
          while (true)
          {
            int num5;
            ulong[] numArray1;
            int index2;
            int num6;
            int num7;
            uint[] numArray2;
            int index3;
            byte num8;
            int num9;
            ulong num10;
            int index4;
            string str2;
            byte[] numArray3;
            int index5;
            int[] numArray4;
            byte index6;
            DateTime dateTime;
            ushort num11;
            int num12;
            ulong num13;
            byte[] numArray5;
            ulong[] numArray6;
            switch (num4)
            {
              case 1:
                index5 = numArray3.Length - num9 - 1;
                num4 = 8;
                continue;
              case 2:
                str2 = str1.Replace((string) InternalSecurityServiceExpress.q8fem7RPV18xPZjXBYn(-979995965 << 4 ^ 1499930646), "");
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
                continue;
              case 3:
                numArray2[index3] = numArray2[index3] >> 1;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 4 : 54;
                continue;
              case 4:
                if (num7 < 0)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 36 : 28;
                  continue;
                }
                goto case 34;
              case 5:
                num10 = num3 >> num7 & 1UL;
                num4 = 6;
                continue;
              case 6:
                numArray2[index2] = numArray2[index2] ^ (uint) num10 << num6;
                num4 = 37;
                continue;
              case 7:
                licType = (byte) numArray1[2];
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 26 : 29;
                continue;
              case 8:
                index3 = index5 / 32;
                num4 = 45;
                continue;
              case 9:
                num9 = 0;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 19 : 14;
                continue;
              case 10:
              case 20:
                if (index2 >= numArray2.Length)
                {
                  num4 = 49;
                  continue;
                }
                goto case 12;
              case 11:
              case 19:
                if (num9 >= numArray3.Length)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 15 : 15;
                  continue;
                }
                goto case 1;
              case 12:
                num6 = 0;
                num4 = 26;
                continue;
              case 13:
                numArray4 = new int[numArray1.Length];
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 9 : 2;
                continue;
              case 14:
              case 26:
                if (num6 >= 32)
                {
                  num5 = 24;
                  break;
                }
                goto case 31;
              case 15:
                num13 = numArray1[0];
                num4 = 48;
                continue;
              case 16:
                ++numArray4[(int) index6];
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 20 : 32;
                continue;
              case 17:
              case 33:
              case 50:
                flag = true;
                num4 = 53;
                continue;
              case 18:
                numArray5 = new byte[96];
                // ISSUE: field reference
                InternalSecurityServiceExpress.RExI9BR1XbDMREGcv5E((object) numArray5, __fieldref (\u003CPrivateImplementationDetails\u003E.\u0032B6AB1C097496DECB417A5B914D605D171C62F34));
                goto label_72;
              case 21:
                dateTime = InternalSecurityServiceExpress.El0ytuRLAXcjbUKIpgs();
                num5 = 35;
                break;
              case 22:
                num12 = numArray4[(int) index6];
                num5 = 16;
                break;
              case 23:
                numArray2[index4] = InternalSecurityServiceExpress.Bf073qRnM3AeQJ7rPmE(InternalSecurityServiceExpress.ADlAdBRe7KCy7TsIjxu((object) str2, index4 * 10, 10));
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 43 : 43;
                continue;
              case 24:
                ++index2;
                num4 = 10;
                continue;
              case 25:
                index4 = 0;
                num4 = 47;
                continue;
              case 27:
                privilegeLicCount = numArray2.Length == 4 ? (ushort) numArray1[5] : (ushort) 0;
                num4 = 7;
                continue;
              case 28:
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
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 46 : 32;
                continue;
              case 29:
                licSubType = numArray2.Length == 4 ? (byte) 1 : (byte) 0;
                num4 = 41;
                continue;
              case 30:
                num7 = 63;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 4 : 5;
                continue;
              case 31:
                num7 = (index2 * 1249 + num6 * 3571) % 64;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 3 : 4;
                continue;
              case 32:
                num8 = (byte) (numArray2[index3] & 1U);
                num4 = 3;
                continue;
              case 34:
                if (num7 > 63)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 30 : 17;
                  continue;
                }
                goto case 5;
              case 35:
                if (!InternalSecurityServiceExpress.LZV0p5R2XM7MLN8JvVH(dateTime.Date, expirationDate.Value))
                {
                  num4 = 33;
                  continue;
                }
                goto case 39;
              case 36:
                num7 = 0;
                num4 = 34;
                continue;
              case 37:
                ++num6;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 8 : 14;
                continue;
              case 38:
                if (numArray2.Length != 4)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 55 : 38;
                  continue;
                }
                numArray6 = new ulong[6];
                goto label_74;
              case 39:
                status = LicenseStatus.DateExpired;
                num4 = 50;
                continue;
              case 40:
                goto label_3;
              case 41:
                num11 = (ushort) numArray1[3];
                num4 = 28;
                continue;
              case 42:
                ++num9;
                num4 = 11;
                continue;
              case 43:
                ++index4;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 39 : 56;
                continue;
              case 44:
                index2 = 0;
                num4 = 20;
                continue;
              case 45:
                index6 = numArray3[index5];
                num5 = 22;
                break;
              case 46:
                if (!expirationDate.HasValue)
                {
                  num4 = 17;
                  continue;
                }
                goto case 21;
              case 47:
              case 56:
                if (index4 >= numArray2.Length)
                {
                  num4 = 44;
                  continue;
                }
                goto case 23;
              case 48:
                if ((long) InternalSecurityServiceExpress.QWQadGRX5HyT9kPFQmc() == (long) num13)
                {
                  num4 = 51;
                  continue;
                }
                goto label_3;
              case 49:
                if (numArray2.Length != 4)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 13 : 18;
                  continue;
                }
                byte[] numArray7 = new byte[128];
                // ISSUE: field reference
                InternalSecurityServiceExpress.RExI9BR1XbDMREGcv5E((object) numArray7, __fieldref (\u003CPrivateImplementationDetails\u003E.F3843D02A302AFCF602795DFEC50175EB12BDC23));
                numArray5 = numArray7;
                goto label_72;
              case 51:
                status = LicenseStatus.Activated;
                num4 = 52;
                continue;
              case 52:
                licCount = (ushort) numArray1[1];
                num4 = 27;
                continue;
              case 53:
                goto label_7;
              case 54:
                numArray1[(int) index6] = numArray1[(int) index6] | (ulong) num8 << num12;
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 22 : 42;
                continue;
              case 55:
                numArray6 = new ulong[5];
                goto label_74;
              default:
                numArray2 = new uint[str2.Length / 10];
                num4 = 25;
                continue;
            }
            num4 = num5;
            continue;
label_72:
            numArray3 = numArray5;
            num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 38 : 13;
            continue;
label_74:
            numArray1 = numArray6;
            num4 = 13;
          }
        }
        catch
        {
          int num14 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0)
            num14 = 0;
          switch (num14)
          {
            default:
              goto label_3;
          }
        }
      }
label_6:
      return false;
label_7:
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

    public InternalSecurityServiceExpress()
    {
      InternalSecurityServiceExpress.bVk6IiRHGQtbluRdCIU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static uint A3CgHaR4ABeUYF9yiMe([In] object obj0) => ((InternalSecurityServiceBase) obj0).UsedLicenseCount;

    internal static uint yHBAcjRchYNn1gB2NHd([In] object obj0) => ((InternalSecurityServiceBase) obj0).UsedPrivilegeCount;

    internal static bool MooOowRlyQQoBHueify() => InternalSecurityServiceExpress.iJxuAlRVbMWMp03bEye == null;

    internal static InternalSecurityServiceExpress IaESTPRfjUYmT4UTJKj() => InternalSecurityServiceExpress.iJxuAlRVbMWMp03bEye;

    internal static object q8fem7RPV18xPZjXBYn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QeaTyXRQKPup4iQmlyp([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static LicenseStatus SQqwYnR8x96e3aLfKyt([In] object obj0) => ((LicenseInfo) obj0).Status;

    internal static void fyOUBFR51ijo7jFsoVi([In] object obj0, [In] LicenseStatus obj1) => ((LicenseInfo) obj0).Status = obj1;

    internal static uint GuJLocRdxiTcgtbpCJs([In] Guid obj0) => ActivationKeyHelper.GetUnitHashCode(obj0);

    internal static TimeSpan f3iNGIREakYaZYc22br([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static object KekuZURGlMWJHPqRNcV() => (object) SHA1.Create();

    internal static ulong QWQadGRX5HyT9kPFQmc() => InternalSecurityServiceExpress.GHN();

    internal static void VdAS0mR9voSvUEsD09c([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void RExI9BR1XbDMREGcv5E([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static object Fb2S7gRMVjb46ZDAYaH([In] object obj0) => (object) ((ILicensedUnitComponentInfo) obj0).GetComponentId();

    internal static void NMRdcaRhmqsHv96aY7V([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static object OQUwUSRBCND7XPnuZGZ([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static void erxRnaRpfSIS23ld6mT([In] object obj0, [In] object obj1) => ((ActivationToken) obj0).Token = (byte[]) obj1;

    internal static object X5oVg3RO9G5TJ1Ymiu5(ushort algorithm) => (object) InternalSecurityServiceExpress.GenerateRegistrationKey(algorithm);

    internal static void KMjC6dRTolS4Yb33NHN([In] object obj0) => Monitor.Exit(obj0);

    internal static object OMT5dcRFxrnotXFBgTW([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object tNKhx6RvQ3maSfbTknK([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object LQcOkQRquC6h8Nw96oP([In] object obj0) => (object) InternalSecurityServiceExpress.FormatKey(obj0);

    internal static object M8whiDRgOQIaAUgkOl1([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object bHLu9hRJblau4nIyH6J([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static object JjHKDYRIgPXYkaoOjBe([In] object obj0, [In] Guid obj1) => (object) ActivationKeyHelper.GetUnitActivationKeys((string) obj0, obj1);

    internal static object ADlAdBRe7KCy7TsIjxu([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static uint Bf073qRnM3AeQJ7rPmE([In] object obj0) => uint.Parse((string) obj0);

    internal static DateTime El0ytuRLAXcjbUKIpgs() => DateTime.Now;

    internal static bool LZV0p5R2XM7MLN8JvVH([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static void bVk6IiRHGQtbluRdCIU() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
