// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Scheduling.RemoveExpiredRefreshTokenJobRepository
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.JWT.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.JWT.Scheduling
{
  /// <summary>Сервис для очистки устаревших токенов и сессий</summary>
  [Component(Type = ComponentType.WebServer)]
  internal sealed class RemoveExpiredRefreshTokenJobRepository : ISchedulerJobRepository
  {
    private readonly IProductionCalendarService productionCalendar;
    private readonly IRefreshTokenService refreshTokenService;
    internal static RemoveExpiredRefreshTokenJobRepository K4HS9eqjlrD71pQT8ce;

    /// <summary>Ctor</summary>
    /// <param name="productionCalendar">Производственный календарь</param>
    /// <param name="refreshTokenService">Сервис для работы с токенами обновления авторизации</param>
    public RemoveExpiredRefreshTokenJobRepository(
      IProductionCalendarService productionCalendar,
      IRefreshTokenService refreshTokenService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.productionCalendar = productionCalendar;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.refreshTokenService = refreshTokenService;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc cref="M:EleWise.ELMA.Scheduling.ISchedulerJobRepository.GetSchedulerJobs" />
    public ICollection<ISchedulerJob> GetSchedulerJobs() => (ICollection<ISchedulerJob>) new List<ISchedulerJob>()
    {
      (ISchedulerJob) new RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob(this.productionCalendar, this.refreshTokenService)
    };

    internal static bool iR54CfqNUPLoVsOhvfM() => RemoveExpiredRefreshTokenJobRepository.K4HS9eqjlrD71pQT8ce == null;

    internal static RemoveExpiredRefreshTokenJobRepository sUHmA9q0cvBVhkrUqxK() => RemoveExpiredRefreshTokenJobRepository.K4HS9eqjlrD71pQT8ce;

    private class RemoveExpiredRefreshTokenJob : SchedulerJobBase
    {
      private readonly object trigger;
      private readonly ICollection<IJob> jobs;
      internal static object J7BBeYwy3u7Od8JtpCd5;

      public RemoveExpiredRefreshTokenJob(
        IProductionCalendarService productionCalendar,
        IRefreshTokenService refreshTokenService)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 5;
        NthIncludedDayTrigger includedDayTrigger;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              includedDayTrigger.Id = new Guid((string) RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.qApJYewysS7PSe9vCiNi(386642440 ^ 386566836));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 4 : 1;
              continue;
            case 2:
              RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JKw12CwyWwmP2VNbEiZg((object) includedDayTrigger, RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.NmRu7uwy7nSZgce3m5Ul(RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.qApJYewysS7PSe9vCiNi(-1115268484 ^ -1115200962)));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 1;
              continue;
            case 3:
              this.jobs = (ICollection<IJob>) new List<IJob>()
              {
                (IJob) new RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl(refreshTokenService)
              };
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 0 : 0;
              continue;
            case 4:
              this.trigger = (object) includedDayTrigger;
              num = 3;
              continue;
            case 5:
              includedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings()
              {
                ScheduleType = ScheduleType.Daily,
                DailySettings = new DailySettings()
                {
                  EveryDay = 1,
                  OnlyWorkDays = false
                },
                StartDate = RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JZfcOUwy0AFYbLbHhTKx().AddMinutes(10.0),
                OvertimeToRun = RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.yX1bBJwyZSmVGAABJ7Ur(3.0)
              }, (IProductionSchedule) RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.TbRRqCwyAtWEHpddvLoP((object) productionCalendar));
              num = 2;
              continue;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_8:;
      }

      public override ITrigger Trigger => (ITrigger) this.trigger;

      public override ICollection<IJob> Jobs => this.jobs;

      internal static DateTime JZfcOUwy0AFYbLbHhTKx() => DateTime.Today;

      internal static TimeSpan yX1bBJwyZSmVGAABJ7Ur([In] double obj0) => TimeSpan.FromHours(obj0);

      internal static object TbRRqCwyAtWEHpddvLoP([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

      internal static object qApJYewysS7PSe9vCiNi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object NmRu7uwy7nSZgce3m5Ul([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void JKw12CwyWwmP2VNbEiZg([In] object obj0, [In] object obj1) => ((NthIncludedDayTrigger) obj0).Name = (string) obj1;

      internal static bool XidA4dwyj84V218UVf9s() => RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.J7BBeYwy3u7Od8JtpCd5 == null;

      internal static RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob UQEGCgwyNvpbJSn36Pok() => (RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob) RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.J7BBeYwy3u7Od8JtpCd5;

      private class JobImpl : IJob
      {
        private readonly object refreshTokenService;
        internal static object HCv6gsw4LbkPjxvDi8B3;

        public JobImpl(IRefreshTokenService refreshTokenService)
        {
          RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl.ehk7FYw4zgIWi08M2Lpl();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0)
            num = 0;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              default:
                this.refreshTokenService = (object) refreshTokenService;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 1 : 1;
                continue;
            }
          }
label_3:;
        }

        public Guid Id => new Guid((string) RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl.tYsNg6wcuwCPmvoMZFFq(1458233619 ^ 1458287731));

        public string Name => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562609787));

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                ((IRefreshTokenService) this.refreshTokenService).RemoveExpired();
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          JobResult jobResult = new JobResult();
          RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl.dIvfLwwcwZGJaOYspGMu((object) jobResult, JobStatus.Success);
          RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl.FE0tqLwcbEqbcPJ2oGLZ((object) jobResult, true);
          return jobResult;
        }

        internal static void ehk7FYw4zgIWi08M2Lpl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

        internal static bool zhKWZFw42CYHY5WVf1P9() => RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl.HCv6gsw4LbkPjxvDi8B3 == null;

        internal static RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl FHelVvw4Hu1XoULGiWtp() => (RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl) RemoveExpiredRefreshTokenJobRepository.RemoveExpiredRefreshTokenJob.JobImpl.HCv6gsw4LbkPjxvDi8B3;

        internal static object tYsNg6wcuwCPmvoMZFFq(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static void dIvfLwwcwZGJaOYspGMu([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static void FE0tqLwcbEqbcPJ2oGLZ([In] object obj0, [In] bool obj1) => ((JobResult) obj0).NoSaveResult = obj1;
      }
    }
  }
}
