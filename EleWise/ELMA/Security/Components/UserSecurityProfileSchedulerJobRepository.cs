// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.UserSecurityProfileSchedulerJobRepository
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>
  /// Обновление параметров авторизации пользователей (UserSecurityProfile)
  /// </summary>
  [Component]
  internal class UserSecurityProfileSchedulerJobRepository : ISchedulerJobRepository
  {
    private readonly IProductionCalendarService productionCalendarService;
    private readonly UserSecurityProfileManager userSecurityProfileManager;
    private readonly UserGroupManager userGroupManager;
    private readonly ILazy<SecuritySettingsModule> securitySettingsModule;
    private static UserSecurityProfileSchedulerJobRepository iVZyT8zfHNAQ7cG5pRy;

    /// <summary>ctor</summary>
    /// <param name="productionCalendarService">Интерфейс сервиса производственного календаря</param>
    /// <param name="userSecurityProfileManager">Менеджер профилей безопасности пользователей</param>
    /// <param name="userGroupManager">Менеджер групп пользователей</param>
    /// <param name="securitySettingsModule">Настройки безопасности</param>
    public UserSecurityProfileSchedulerJobRepository(
      IProductionCalendarService productionCalendarService,
      UserSecurityProfileManager userSecurityProfileManager,
      UserGroupManager userGroupManager,
      ILazy<SecuritySettingsModule> securitySettingsModule)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.productionCalendarService = productionCalendarService;
      this.userSecurityProfileManager = userSecurityProfileManager;
      this.userGroupManager = userGroupManager;
      this.securitySettingsModule = securitySettingsModule;
    }

    /// <inheritdoc />
    public ICollection<ISchedulerJob> GetSchedulerJobs()
    {
      if (!this.securitySettingsModule.IsRegistered)
        return (ICollection<ISchedulerJob>) Array.Empty<ISchedulerJob>();
      return (ICollection<ISchedulerJob>) new ISchedulerJob[3]
      {
        (ISchedulerJob) new UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob(this.productionCalendarService, this.userSecurityProfileManager, this.securitySettingsModule.Value.Settings, this.userGroupManager),
        (ISchedulerJob) new UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob(this.productionCalendarService, this.userSecurityProfileManager, this.securitySettingsModule.Value.Settings),
        (ISchedulerJob) new UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob(this.productionCalendarService, this.userSecurityProfileManager, this.securitySettingsModule.Value.Settings)
      };
    }

    private static TimeSpan GetTimeSpan(int period)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (period > 15)
            {
              if (period <= 90)
              {
                num = 3;
                continue;
              }
              if (period <= 1440)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 1 : 1;
              continue;
            }
          case 3:
            goto label_9;
          default:
            goto label_7;
        }
      }
label_2:
      return UserSecurityProfileSchedulerJobRepository.MFo1YdzPvvjFCjm3SQC(1.0);
label_7:
      return UserSecurityProfileSchedulerJobRepository.U45BWwzQ9ogN7I6CFuY(1.0);
label_8:
      return UserSecurityProfileSchedulerJobRepository.U45BWwzQ9ogN7I6CFuY(4.0);
label_9:
      return TimeSpan.FromMinutes(10.0);
    }

    internal static TimeSpan MFo1YdzPvvjFCjm3SQC([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static TimeSpan U45BWwzQ9ogN7I6CFuY([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static bool kt2xEjz4RXLJUlV5UF5() => UserSecurityProfileSchedulerJobRepository.iVZyT8zfHNAQ7cG5pRy == null;

    internal static UserSecurityProfileSchedulerJobRepository xw76CjzcvTr0hp1iCPo() => UserSecurityProfileSchedulerJobRepository.iVZyT8zfHNAQ7cG5pRy;

    private class ForcedChangePasswordJob : SchedulerJobBase
    {
      private static object LqlvAHwlaYfYeUHjRF09;

      public ForcedChangePasswordJob(
        IProductionCalendarService productionCalendarService,
        UserSecurityProfileManager userSecurityProfileManager,
        SecuritySettings settings,
        UserGroupManager userGroupManager)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              IJob[] jobArray;
              if (UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.znq17PwlA9DEXpwbWM9H((object) settings) > 0)
                jobArray = (IJob[]) new UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job[1]
                {
                  new UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job(userSecurityProfileManager, settings, userGroupManager)
                };
              else
                jobArray = Array.Empty<IJob>();
              this.Jobs = (ICollection<IJob>) jobArray;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
              continue;
            case 2:
              NthIncludedDayTrigger includedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings()
              {
                ScheduleType = ScheduleType.Daily,
                DailySettings = new DailySettings()
                {
                  EveryDay = 1,
                  OnlyWorkDays = false
                },
                RepeatSettings = new RepeatSettings()
                {
                  Enabled = true,
                  RepeatEvery = UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.KIpyvXwlibs7LFQ7q4hH(12.0),
                  RepeatTo = UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.KIpyvXwlibs7LFQ7q4hH(6.0)
                },
                StartDate = DateTime.Today.AddHours(2.0)
              }, (IProductionSchedule) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.ld3RC2wl3SwR80ptWZdA((object) productionCalendarService));
              UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.mDsA0Pwlj9gBpCUkyo6h((object) includedDayTrigger, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897211453)));
              UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.iJoqvjwlZs3BskBjosv4((object) includedDayTrigger, UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.xeX66Ywl0vsuRisQbDul(UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.BwhchuwlNlxy1jr9T6tg(1076316568 ^ 1076233386)));
              this.Trigger = (ITrigger) includedDayTrigger;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 1 : 0;
              continue;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:;
      }

      public override ITrigger Trigger { get; }

      public override ICollection<IJob> Jobs { get; }

      internal static TimeSpan KIpyvXwlibs7LFQ7q4hH([In] double obj0) => TimeSpan.FromHours(obj0);

      internal static object ld3RC2wl3SwR80ptWZdA([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

      internal static void mDsA0Pwlj9gBpCUkyo6h([In] object obj0, [In] Guid obj1) => ((NthIncludedDayTrigger) obj0).Id = obj1;

      internal static object BwhchuwlNlxy1jr9T6tg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object xeX66Ywl0vsuRisQbDul([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void iJoqvjwlZs3BskBjosv4([In] object obj0, [In] object obj1) => ((NthIncludedDayTrigger) obj0).Name = (string) obj1;

      internal static int znq17PwlA9DEXpwbWM9H([In] object obj0) => ((SecuritySettings) obj0).PeriodicityOfForcedChangePassword;

      internal static bool kbYPL6wlx8Oqcfo68oEs() => UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.LqlvAHwlaYfYeUHjRF09 == null;

      internal static UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob D7XhBowlClr8VnobndN6() => (UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.LqlvAHwlaYfYeUHjRF09;

      private class Job : IJob
      {
        private readonly object userSecurityProfileManager;
        private readonly object settings;
        private readonly object userGroupManager;
        internal static object qpUAOrwcokn1MWoXCLrv;

        public Job(
          UserSecurityProfileManager userSecurityProfileManager,
          SecuritySettings settings,
          UserGroupManager userGroupManager)
        {
          UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.NmknE0wc6Wn4F2ggcyPA();
          this.Id = new Guid((string) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.vudittwckgXQjEVBTf5U(-522456341 ^ -522541827));
          this.Name = (string) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.ho8P3VwcDZfKjZucyUSU(UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.vudittwckgXQjEVBTf5U(-29763048 >> 5 ^ -963376));
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.userGroupManager = (object) userGroupManager;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 2 : 1;
                continue;
              case 2:
                goto label_3;
              case 3:
                this.settings = (object) settings;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 1 : 1;
                continue;
              default:
                this.userSecurityProfileManager = (object) userSecurityProfileManager;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 3 : 1;
                continue;
            }
          }
label_3:;
        }

        public Guid Id { get; }

        public string Name { get; }

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                ((UserSecurityProfileManager) this.userSecurityProfileManager).SetForcedChangePasswordWithCheck(this.GetExcludedUsersId(), UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.JQ5HPrwcxWyv9LicHLhH((double) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.LvNGKtwcabsEHSDqjJEL(this.settings)));
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          JobResult jobResult = new JobResult();
          UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.R0v7YDwcCp0WClj91eYv((object) jobResult, JobStatus.Success);
          UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.LFRtWGwcinl48ZMJV9TB((object) jobResult, true);
          jobResult.Information = (string) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.ho8P3VwcDZfKjZucyUSU(UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.vudittwckgXQjEVBTf5U(658384612 ^ 658468998));
          return jobResult;
        }

        private ICollection<long> GetExcludedUsersId()
        {
          long exclusionGroupId = ((SecuritySettings) this.settings).ExclusionGroupId;
          return exclusionGroupId == 0L ? (ICollection<long>) null : (ICollection<long>) ((UserGroupManager) this.userGroupManager).GetUsersByGroup(exclusionGroupId).CastToListOrNull<long>();
        }

        internal static void NmknE0wc6Wn4F2ggcyPA() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

        internal static object vudittwckgXQjEVBTf5U(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object ho8P3VwcDZfKjZucyUSU([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

        internal static bool nFhno2wctVjH1bl6aWqe() => UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.qpUAOrwcokn1MWoXCLrv == null;

        internal static UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job ilxskvwcmdnULNLieuRN() => (UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job) UserSecurityProfileSchedulerJobRepository.ForcedChangePasswordJob.Job.qpUAOrwcokn1MWoXCLrv;

        internal static int LvNGKtwcabsEHSDqjJEL([In] object obj0) => ((SecuritySettings) obj0).PeriodicityOfForcedChangePassword;

        internal static TimeSpan JQ5HPrwcxWyv9LicHLhH([In] double obj0) => TimeSpan.FromDays(obj0);

        internal static void R0v7YDwcCp0WClj91eYv([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static void LFRtWGwcinl48ZMJV9TB([In] object obj0, [In] bool obj1) => ((JobResult) obj0).NoSaveResult = obj1;
      }
    }

    private class ResetCountFailedLogonJob : SchedulerJobBase
    {
      private static object mUIJkQwlsKGPR64fVlaS;

      public ResetCountFailedLogonJob(
        IProductionCalendarService productionCalendarService,
        UserSecurityProfileManager userSecurityProfileManager,
        SecuritySettings settings)
      {
        UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.qlg0pGwlruXhZsD4MBY0();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              IJob[] jobArray;
              if (UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.TCTtKawllEdtcIdCh13J((object) settings) > 0)
                jobArray = (IJob[]) new UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job[1]
                {
                  new UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job(userSecurityProfileManager, settings)
                };
              else
                jobArray = Array.Empty<IJob>();
              this.Jobs = (ICollection<IJob>) jobArray;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 1 : 1;
              continue;
            default:
              NthIncludedDayTrigger includedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings()
              {
                ScheduleType = ScheduleType.Daily,
                DailySettings = new DailySettings()
                {
                  EveryDay = 1,
                  OnlyWorkDays = false
                },
                RepeatSettings = new RepeatSettings()
                {
                  Enabled = true,
                  RepeatEvery = UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.El7RLRwlSnnranoYdpB4(settings.PeriodResetCountLogonAttempts),
                  RepeatTo = TimeSpan.FromHours(24.0)
                },
                StartDate = UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.GDl8GwwlYOwheqrRXT3x()
              }, productionCalendarService.GetGlobalProductionSchedule());
              includedDayTrigger.Id = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236438165));
              UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.GQuRCQwlV3YFqi7etb87((object) includedDayTrigger, (object) EleWise.ELMA.SR.T((string) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.JWOI0jwlyvdvC1lQKDk5(-201065280 ^ -201149718)));
              this.Trigger = (ITrigger) includedDayTrigger;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      public override ITrigger Trigger { get; }

      public override ICollection<IJob> Jobs { get; }

      internal static void qlg0pGwlruXhZsD4MBY0() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static TimeSpan El7RLRwlSnnranoYdpB4(int period) => UserSecurityProfileSchedulerJobRepository.GetTimeSpan(period);

      internal static DateTime GDl8GwwlYOwheqrRXT3x() => DateTime.Today;

      internal static object JWOI0jwlyvdvC1lQKDk5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void GQuRCQwlV3YFqi7etb87([In] object obj0, [In] object obj1) => ((NthIncludedDayTrigger) obj0).Name = (string) obj1;

      internal static int TCTtKawllEdtcIdCh13J([In] object obj0) => ((SecuritySettings) obj0).PeriodResetCountLogonAttempts;

      internal static bool OOwMSawl7Si5u4FvnrYg() => UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.mUIJkQwlsKGPR64fVlaS == null;

      internal static UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob ybExE2wlW7KU8IuQjjl8() => (UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.mUIJkQwlsKGPR64fVlaS;

      private class Job : IJob
      {
        private readonly object userSecurityProfileManager;
        private readonly object settings;
        internal static object XXXhYwwc3gDR2uyjFeA4;

        public Job(
          UserSecurityProfileManager userSecurityProfileManager,
          SecuritySettings settings)
        {
          TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
          this.Id = new Guid((string) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.PUoikawc0IKVrRm9y6Ak(--1207559533 ^ 1207481311));
          this.Name = (string) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.vf2soBwcZmYnJtj1UO65(UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.PUoikawc0IKVrRm9y6Ak(1055964645 ^ 1056041755));
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.userSecurityProfileManager = (object) userSecurityProfileManager;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                this.settings = (object) settings;
                num = 2;
                continue;
            }
          }
label_3:;
        }

        public Guid Id { get; }

        public string Name { get; }

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.NcBd5Cwc7dUKv5Ksa66x(this.userSecurityProfileManager, UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.BPP4G8wcs8MaURh1bDHu((double) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.LYEVxmwcAXQ93ewDKCai(this.settings)));
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          JobResult jobResult = new JobResult();
          UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.Xr1m2IwcWTWv0O33yHqt((object) jobResult, JobStatus.Success);
          UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.XQtCXRwcra3JE38Kt1Ql((object) jobResult, true);
          jobResult.Information = (string) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.vf2soBwcZmYnJtj1UO65(UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.PUoikawc0IKVrRm9y6Ak(447286529 ^ 447240803));
          return jobResult;
        }

        internal static object PUoikawc0IKVrRm9y6Ak(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object vf2soBwcZmYnJtj1UO65([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

        internal static bool Ptl8rVwcjb4gUhFpV3tq() => UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.XXXhYwwc3gDR2uyjFeA4 == null;

        internal static UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job Qvq16BwcNIOCudoRUZJa() => (UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job) UserSecurityProfileSchedulerJobRepository.ResetCountFailedLogonJob.Job.XXXhYwwc3gDR2uyjFeA4;

        internal static int LYEVxmwcAXQ93ewDKCai([In] object obj0) => ((SecuritySettings) obj0).PeriodResetCountLogonAttempts;

        internal static TimeSpan BPP4G8wcs8MaURh1bDHu([In] double obj0) => TimeSpan.FromMinutes(obj0);

        internal static void NcBd5Cwc7dUKv5Ksa66x([In] object obj0, TimeSpan period) => ((UserSecurityProfileManager) obj0).ResetCountFailedLogonAllWithCheck(period);

        internal static void Xr1m2IwcWTWv0O33yHqt([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static void XQtCXRwcra3JE38Kt1Ql([In] object obj0, [In] bool obj1) => ((JobResult) obj0).NoSaveResult = obj1;
      }
    }

    private class UnblockLogonUsersJob : SchedulerJobBase
    {
      internal static object iXRBjUwlfk6TloZcGQoH;

      public UnblockLogonUsersJob(
        IProductionCalendarService productionCalendarService,
        UserSecurityProfileManager userSecurityProfileManager,
        SecuritySettings settings)
      {
        UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.bHPei9wlPY2cd9XFvrKv();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              IJob[] jobArray;
              if (UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.tNDmWZwlQeusrFPNpX8d((object) settings) > 0)
                jobArray = (IJob[]) new UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job[1]
                {
                  new UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job(userSecurityProfileManager, settings)
                };
              else
                jobArray = Array.Empty<IJob>();
              this.Jobs = (ICollection<IJob>) jobArray;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
              continue;
            case 2:
              NthIncludedDayTrigger includedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings()
              {
                ScheduleType = ScheduleType.Daily,
                DailySettings = new DailySettings()
                {
                  EveryDay = 1,
                  OnlyWorkDays = false
                },
                RepeatSettings = new RepeatSettings()
                {
                  Enabled = true,
                  RepeatEvery = UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.zgmcs1wl8FdRr5Nl28Rc(UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.tNDmWZwlQeusrFPNpX8d((object) settings)),
                  RepeatTo = UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.qtrP3fwl5buN23lJ5Nnt(24.0)
                },
                StartDate = UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.en17Qiwld1pymMlgcc6h()
              }, (IProductionSchedule) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Hm10hGwlEvZOqxMvlAys((object) productionCalendarService));
              UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.raGFb6wlX53I1ukbiegB((object) includedDayTrigger, new Guid((string) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.ekoQNSwlG784vQl18hj1(-29763048 >> 5 ^ -1015342)));
              includedDayTrigger.Name = EleWise.ELMA.SR.T((string) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.ekoQNSwlG784vQl18hj1(1185105284 ^ 1185024714));
              this.Trigger = (ITrigger) includedDayTrigger;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 1 : 1;
              continue;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:;
      }

      public override ITrigger Trigger { get; }

      public override ICollection<IJob> Jobs { get; }

      internal static void bHPei9wlPY2cd9XFvrKv() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static int tNDmWZwlQeusrFPNpX8d([In] object obj0) => ((SecuritySettings) obj0).BlockingPeriod;

      internal static TimeSpan zgmcs1wl8FdRr5Nl28Rc(int period) => UserSecurityProfileSchedulerJobRepository.GetTimeSpan(period);

      internal static TimeSpan qtrP3fwl5buN23lJ5Nnt([In] double obj0) => TimeSpan.FromHours(obj0);

      internal static DateTime en17Qiwld1pymMlgcc6h() => DateTime.Today;

      internal static object Hm10hGwlEvZOqxMvlAys([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

      internal static object ekoQNSwlG784vQl18hj1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void raGFb6wlX53I1ukbiegB([In] object obj0, [In] Guid obj1) => ((NthIncludedDayTrigger) obj0).Id = obj1;

      internal static bool tZ5DKewl4qjG5t649xg7() => UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.iXRBjUwlfk6TloZcGQoH == null;

      internal static UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob nKTgJlwlcqTEQukJVbsr() => (UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.iXRBjUwlfk6TloZcGQoH;

      private class Job : IJob
      {
        private readonly object userSecurityProfileManager;
        private readonly object settings;
        private static object OkM9TKwcS6roNtFLy6Qj;

        public Job(
          UserSecurityProfileManager userSecurityProfileManager,
          SecuritySettings settings)
        {
          TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
          this.Id = new Guid((string) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.N6RMxwwcVD8Ag1bR9ROR(1053060681 ^ 1053112723));
          this.Name = (string) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.akG8NrwcllKOkNwu6A4i(UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.N6RMxwwcVD8Ag1bR9ROR(-979995965 << 4 ^ 1499886614));
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0)
            num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                this.userSecurityProfileManager = (object) userSecurityProfileManager;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                this.settings = (object) settings;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 2 : 1;
                continue;
            }
          }
label_3:;
        }

        public Guid Id { get; }

        public string Name { get; }

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.IIN5xHwccVyuxsVTlAhP(this.userSecurityProfileManager, UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.YHCfeYwc4NS62fjG07jq((double) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.Y0hINBwcfwrKr1SwYJI9(this.settings)));
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          JobResult jobResult = new JobResult();
          UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.xmuiB2wcPpWEHHfpohx1((object) jobResult, JobStatus.Success);
          UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.F6THx2wcQhiFgxTTDRyu((object) jobResult, true);
          UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.MfT9RLwc82xeh3b2k6lH((object) jobResult, UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.akG8NrwcllKOkNwu6A4i(UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.N6RMxwwcVD8Ag1bR9ROR(1658561670 << 4 ^ 767234176)));
          return jobResult;
        }

        internal static object N6RMxwwcVD8Ag1bR9ROR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object akG8NrwcllKOkNwu6A4i([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

        internal static bool GLDBlywcYDfOS9siBiHA() => UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.OkM9TKwcS6roNtFLy6Qj == null;

        internal static UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job nGTQRCwcyOuw1218YteX() => (UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job) UserSecurityProfileSchedulerJobRepository.UnblockLogonUsersJob.Job.OkM9TKwcS6roNtFLy6Qj;

        internal static int Y0hINBwcfwrKr1SwYJI9([In] object obj0) => ((SecuritySettings) obj0).BlockingPeriod;

        internal static TimeSpan YHCfeYwc4NS62fjG07jq([In] double obj0) => TimeSpan.FromMinutes(obj0);

        internal static void IIN5xHwccVyuxsVTlAhP([In] object obj0, TimeSpan period) => ((UserSecurityProfileManager) obj0).AllowLogonAllWithCheck(period);

        internal static void xmuiB2wcPpWEHHfpohx1([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static void F6THx2wcQhiFgxTTDRyu([In] object obj0, [In] bool obj1) => ((JobResult) obj0).NoSaveResult = obj1;

        internal static void MfT9RLwc82xeh3b2k6lH([In] object obj0, [In] object obj1) => ((JobResult) obj0).Information = (string) obj1;
      }
    }
  }
}
