// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ReplacementPeriodJobRepository
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
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

namespace EleWise.ELMA.Security
{
  /// <summary>Сервис для замещений</summary>
  [Component(Type = ComponentType.WebServer)]
  public class ReplacementPeriodJobRepository : ISchedulerJobRepository
  {
    internal static ReplacementPeriodJobRepository px08GrkTYD1M44FFbeL;

    public ICollection<ISchedulerJob> GetSchedulerJobs() => (ICollection<ISchedulerJob>) new ISchedulerJob[1]
    {
      (ISchedulerJob) new ReplacementPeriodJobRepository.ReplacementPeriodJob()
    };

    public ReplacementPeriodJobRepository()
    {
      ReplacementPeriodJobRepository.orWl8lkqwpMrYiHFmmA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void orWl8lkqwpMrYiHFmmA() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool R51G9pkFrEA89uTQop3() => ReplacementPeriodJobRepository.px08GrkTYD1M44FFbeL == null;

    internal static ReplacementPeriodJobRepository Uk6sPrkvArIvBxSmRQB() => ReplacementPeriodJobRepository.px08GrkTYD1M44FFbeL;

    private class ReplacementPeriodJob : SchedulerJobBase
    {
      private readonly object _trigger;
      private ICollection<IJob> _jobs;
      internal static object vHBtP6wkmvd4Sfkp8gvF;

      public ReplacementPeriodJob()
      {
        ReplacementPeriodJobRepository.ReplacementPeriodJob.WfjUe9wkDnYOCONuePAi();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              NthIncludedDayTrigger includedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings()
              {
                ScheduleType = ScheduleType.Daily,
                DailySettings = new DailySettings()
                {
                  EveryDay = 1,
                  OnlyWorkDays = false
                },
                StartDate = ReplacementPeriodJobRepository.ReplacementPeriodJob.oyrHSpwkalxUe3Aix894().AddMinutes(10.0),
                OvertimeToRun = ReplacementPeriodJobRepository.ReplacementPeriodJob.VtKCwPwkxjUerbCTIFcj(1.0)
              }, (IProductionSchedule) ReplacementPeriodJobRepository.ReplacementPeriodJob.mCbOxSwkCUQQNJbcbpKa((object) Locator.GetServiceNotNull<IProductionCalendarService>()));
              ReplacementPeriodJobRepository.ReplacementPeriodJob.MxUwfOwkjAm6KhpHuiAv((object) includedDayTrigger, ReplacementPeriodJobRepository.ReplacementPeriodJob.lsUA7rwk3sTBnEUkKxuF(ReplacementPeriodJobRepository.ReplacementPeriodJob.boleAewki9LyHks6U8e1(-1640694811 << 2 ^ 2027084868)));
              ReplacementPeriodJobRepository.ReplacementPeriodJob.aut31wwkN1cwVDTkV0oV((object) includedDayTrigger, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1055964645 ^ 1056016885)));
              this._trigger = (object) includedDayTrigger;
              num = 2;
              continue;
            case 2:
              this._jobs = (ICollection<IJob>) new List<IJob>()
              {
                (IJob) new ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl(),
                (IJob) new ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl()
              };
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      public override ITrigger Trigger => (ITrigger) this._trigger;

      public override ICollection<IJob> Jobs => this._jobs;

      internal static void WfjUe9wkDnYOCONuePAi() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static DateTime oyrHSpwkalxUe3Aix894() => DateTime.Today;

      internal static TimeSpan VtKCwPwkxjUerbCTIFcj([In] double obj0) => TimeSpan.FromDays(obj0);

      internal static object mCbOxSwkCUQQNJbcbpKa([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

      internal static object boleAewki9LyHks6U8e1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object lsUA7rwk3sTBnEUkKxuF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void MxUwfOwkjAm6KhpHuiAv([In] object obj0, [In] object obj1) => ((NthIncludedDayTrigger) obj0).Name = (string) obj1;

      internal static void aut31wwkN1cwVDTkV0oV([In] object obj0, [In] Guid obj1) => ((NthIncludedDayTrigger) obj0).Id = obj1;

      internal static bool QGTqeuwk6y9SmeoIdCF1() => ReplacementPeriodJobRepository.ReplacementPeriodJob.vHBtP6wkmvd4Sfkp8gvF == null;

      internal static ReplacementPeriodJobRepository.ReplacementPeriodJob JkRA7gwkkV8U1FEAccwd() => (ReplacementPeriodJobRepository.ReplacementPeriodJob) ReplacementPeriodJobRepository.ReplacementPeriodJob.vHBtP6wkmvd4Sfkp8gvF;

      private class ReplacementJobImpl : IJob
      {
        internal static object o8PSQLw4mGBhelTytEp5;

        private ReplacementManager Manager => (ReplacementManager) ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.curqJew4DXCGZgakS3Na();

        public Guid Id => new Guid((string) ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.gw4WAPw4a9LLkTA1we0s(1762575989 ^ 1762628941));

        public string Name => (string) ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.TW7vXow4x5URHlTgKK7o(ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.gw4WAPw4a9LLkTA1we0s(1458233619 ^ 1458287255));

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.BQTPRuw4CPrVKFV0Armm((object) this.Manager);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          JobResult jobResult = new JobResult();
          ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.vOMRbAw4igFov8GkOCL8((object) jobResult, JobStatus.Success);
          ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.JbanUcw43v6E1GT22Ty1((object) jobResult, ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.TW7vXow4x5URHlTgKK7o(ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.gw4WAPw4a9LLkTA1we0s(841533798 << 6 ^ -1976366526)));
          return jobResult;
        }

        public ReplacementJobImpl()
        {
          ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.afKhrcw4jWP6w0DtI5g7();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static object curqJew4DXCGZgakS3Na() => (object) ReplacementManager.Instance;

        internal static object gw4WAPw4a9LLkTA1we0s(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static bool W9MBZSw46G0tDEK4k3yr() => ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.o8PSQLw4mGBhelTytEp5 == null;

        internal static ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl FYV2D6w4kHHG50iB7F3f() => (ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl) ReplacementPeriodJobRepository.ReplacementPeriodJob.ReplacementJobImpl.o8PSQLw4mGBhelTytEp5;

        internal static object TW7vXow4x5URHlTgKK7o([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

        internal static void BQTPRuw4CPrVKFV0Armm([In] object obj0) => ((ReplacementManager) obj0).ConversionPlanReplacement();

        internal static void vOMRbAw4igFov8GkOCL8([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static void JbanUcw43v6E1GT22Ty1([In] object obj0, [In] object obj1) => ((JobResult) obj0).Information = (string) obj1;

        internal static void afKhrcw4jWP6w0DtI5g7() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      }

      private class AbsenceJobImpl : IJob
      {
        private static object zGxnO2w4NEM5IPpASA5f;

        private AbsenceManager Manager => (AbsenceManager) ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.WjOVWow4A1ttarDWatKw();

        public Guid Id => new Guid((string) ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.QyH1A9w4s2pcmnSqV7JG(839394233 ^ 839479383));

        public string Name => EleWise.ELMA.SR.T((string) ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.QyH1A9w4s2pcmnSqV7JG(-206147790 ^ -206095608));

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.gt8CTFw47MTFUdKC1PHg((object) this.Manager);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_3:
          JobResult jobResult = new JobResult();
          ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.SvhZ7sw4WefEu2h3X0b6((object) jobResult, JobStatus.Success);
          ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.vkLOIOw4S3xaTI0BRhEf((object) jobResult, ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.ltUfyrw4rjOHwx7aspTS(ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.QyH1A9w4s2pcmnSqV7JG(-1807813747 ^ -1807767553)));
          return jobResult;
        }

        public AbsenceJobImpl()
        {
          ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.aCLT8Gw4YMaUTtbo8P6b();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static object WjOVWow4A1ttarDWatKw() => (object) AbsenceManager.Instance;

        internal static object QyH1A9w4s2pcmnSqV7JG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static bool qXoNb3w40wTJI844Vqs4() => ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.zGxnO2w4NEM5IPpASA5f == null;

        internal static ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl yO13XMw4ZP5WkJiLrlw6() => (ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl) ReplacementPeriodJobRepository.ReplacementPeriodJob.AbsenceJobImpl.zGxnO2w4NEM5IPpASA5f;

        internal static void gt8CTFw47MTFUdKC1PHg([In] object obj0) => ((AbsenceManager) obj0).UpdateAbsencesCache();

        internal static void SvhZ7sw4WefEu2h3X0b6([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static object ltUfyrw4rjOHwx7aspTS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

        internal static void vkLOIOw4S3xaTI0BRhEf([In] object obj0, [In] object obj1) => ((JobResult) obj0).Information = (string) obj1;

        internal static void aCLT8Gw4YMaUTtbo8P6b() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      }
    }
  }
}
