// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Scheduling.RemoveExpiredPublicCachePeriodJobRepository
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Scheduling
{
  /// <summary>Сервис для очистки устаревших токенов и сессий</summary>
  [Component(Type = ComponentType.WebServer)]
  public class RemoveExpiredPublicCachePeriodJobRepository : ISchedulerJobRepository
  {
    internal static RemoveExpiredPublicCachePeriodJobRepository b3F7mZZQJ1lTgJgsMSe;

    public ICollection<ISchedulerJob> GetSchedulerJobs() => (ICollection<ISchedulerJob>) new List<ISchedulerJob>()
    {
      (ISchedulerJob) new RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob()
    };

    public RemoveExpiredPublicCachePeriodJobRepository()
    {
      RemoveExpiredPublicCachePeriodJobRepository.EqD1KqZdm506xjdZm7Z();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void EqD1KqZdm506xjdZm7Z() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool ttDcvOZ8poPNS8C1CM7() => RemoveExpiredPublicCachePeriodJobRepository.b3F7mZZQJ1lTgJgsMSe == null;

    internal static RemoveExpiredPublicCachePeriodJobRepository LP7Qc2Z5XTwUkZt1XhY() => RemoveExpiredPublicCachePeriodJobRepository.b3F7mZZQJ1lTgJgsMSe;

    private class RemoveExpiredPublicCachePeriodJob : SchedulerJobBase
    {
      private readonly object trigger;
      private readonly ICollection<IJob> jobs;
      internal static object lRQgPtwDg83qYxlKjf56;

      public RemoveExpiredPublicCachePeriodJob()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              NthIncludedDayTrigger includedDayTrigger = new NthIncludedDayTrigger(new NthIncludedDaySettings()
              {
                ScheduleType = ScheduleType.Daily,
                DailySettings = new DailySettings()
                {
                  EveryDay = 1,
                  OnlyWorkDays = false
                },
                StartDate = RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.V0DScEwDe4FJPdKxneJu().AddMinutes(10.0),
                OvertimeToRun = RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.A4vOThwDne48DsTWWEnA(3.0)
              }, (IProductionSchedule) RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.EcjtiFwDLSfeiilbTVQn((object) Locator.GetServiceNotNull<IProductionCalendarService>()));
              RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.SAQ1fHwDHJcnBVNSBNHh((object) includedDayTrigger, RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.LOMypHwD2pGEYAp9aJ08((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617657806)));
              RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.DLp3SMwauwSpQAxKfplK((object) includedDayTrigger, new Guid((string) RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.O1Fq9YwDzoewOnniAISx(1801131332 >> 4 ^ 112494388)));
              this.trigger = (object) includedDayTrigger;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 0 : 0;
              continue;
            default:
              this.jobs = (ICollection<IJob>) new List<IJob>()
              {
                (IJob) new RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl()
              };
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public override ITrigger Trigger => (ITrigger) this.trigger;

      public override ICollection<IJob> Jobs => this.jobs;

      internal static DateTime V0DScEwDe4FJPdKxneJu() => DateTime.Today;

      internal static TimeSpan A4vOThwDne48DsTWWEnA([In] double obj0) => TimeSpan.FromHours(obj0);

      internal static object EcjtiFwDLSfeiilbTVQn([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

      internal static object LOMypHwD2pGEYAp9aJ08([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void SAQ1fHwDHJcnBVNSBNHh([In] object obj0, [In] object obj1) => ((NthIncludedDayTrigger) obj0).Name = (string) obj1;

      internal static object O1Fq9YwDzoewOnniAISx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void DLp3SMwauwSpQAxKfplK([In] object obj0, [In] Guid obj1) => ((NthIncludedDayTrigger) obj0).Id = obj1;

      internal static bool GccefqwDJJQ5m39MIe6u() => RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.lRQgPtwDg83qYxlKjf56 == null;

      internal static RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob axwRp0wDIt1AUjCGycO1() => (RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob) RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.lRQgPtwDg83qYxlKjf56;

      private class JobImpl : IJob
      {
        private static object RAcjfvw4yEFYtNwT2H94;

        public Guid Id => new Guid((string) RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.lipnOlw4frlNZNwnE7Zm(978908330 << 6 ^ -1774420448));

        public string Name => (string) RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.nwuLuQw44bkjGUthpKYQ(RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.lipnOlw4frlNZNwnE7Zm(-617657301 ^ -617735993));

        public Image Icon => (Image) null;

        public JobResult Do(DateTime dateToRun)
        {
          int num1 = 3;
          IPublicCacheService cacheSvc;
          int expiredDayCount;
          IPublicClientService sessionSvc;
          while (true)
          {
            switch (num1)
            {
              case 1:
                goto label_9;
              case 2:
                expiredDayCount = EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29763048 >> 5 ^ -1008666), 10);
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 5 : 2;
                continue;
              case 3:
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 2 : 1;
                continue;
              case 4:
                cacheSvc = Locator.GetServiceNotNull<IPublicCacheService>();
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 0 : 0;
                continue;
              case 5:
                if (expiredDayCount < 10)
                {
                  num1 = 7;
                  continue;
                }
                goto case 4;
              case 6:
                Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies((Action) (() =>
                {
                  int num2 = 1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.\u003C\u003Ec__DisplayClass6_0.Xa3lc2wcT5seZfvnl8fH((object) cacheSvc, RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.\u003C\u003Ec__DisplayClass6_0.l91WDGwcOZ5vFDcfZTK1((double) expiredDayCount));
                        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.\u003C\u003Ec__DisplayClass6_0.ANt1xAwcFMcG692iSugi((object) sessionSvc, RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.\u003C\u003Ec__DisplayClass6_0.l91WDGwcOZ5vFDcfZTK1((double) expiredDayCount));
                        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 2 : 2;
                        continue;
                    }
                  }
label_2:;
                }));
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 1;
                continue;
              case 7:
                expiredDayCount = 10;
                num1 = 4;
                continue;
              default:
                sessionSvc = Locator.GetServiceNotNull<IPublicClientService>();
                num1 = 6;
                continue;
            }
          }
label_9:
          return new JobResult()
          {
            Status = JobStatus.Success,
            NoSaveResult = true
          };
        }

        public JobImpl()
        {
          TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static object lipnOlw4frlNZNwnE7Zm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static bool yNMvWbw4VOpIiQx3TWXc() => RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.RAcjfvw4yEFYtNwT2H94 == null;

        internal static RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl GyR9Jww4lQGY1KJvjfl5() => (RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl) RemoveExpiredPublicCachePeriodJobRepository.RemoveExpiredPublicCachePeriodJob.JobImpl.RAcjfvw4yEFYtNwT2H94;

        internal static object nwuLuQw44bkjGUthpKYQ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
      }
    }
  }
}
