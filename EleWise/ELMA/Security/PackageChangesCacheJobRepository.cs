// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PackageChangesCacheJobRepository
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Properties;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Работа по пересчету кэша первоначального сбора изменений
  /// </summary>
  [Component(Type = ComponentType.WebServer)]
  public class PackageChangesCacheJobRepository : ISchedulerJobRepository
  {
    private static PackageChangesCacheJobRepository juh9iBbfF52EYXCOMs2;

    /// <summary>Получение работа</summary>
    /// <returns></returns>
    public ICollection<ISchedulerJob> GetSchedulerJobs() => (ICollection<ISchedulerJob>) new List<ISchedulerJob>()
    {
      (ISchedulerJob) new PackageChangesCacheJobRepository.PackageChangesCacheJob()
    };

    public PackageChangesCacheJobRepository()
    {
      PackageChangesCacheJobRepository.zYCkOcbPWy4l1PFvgLa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void zYCkOcbPWy4l1PFvgLa() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool emxfOBb438JV3x0r1oP() => PackageChangesCacheJobRepository.juh9iBbfF52EYXCOMs2 == null;

    internal static PackageChangesCacheJobRepository uf9DxZbclVOYby0Wek2() => PackageChangesCacheJobRepository.juh9iBbfF52EYXCOMs2;

    private class PackageChangesCacheJob : SchedulerJobBase
    {
      private readonly object trigger;
      private readonly ICollection<IJob> jobs;
      private static object GkM9qmwRS961CqxarkX1;

      public PackageChangesCacheJob()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0)
          num = 1;
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
                RepeatSettings = new RepeatSettings()
                {
                  Enabled = true,
                  RepeatEvery = TimeSpan.FromMinutes(10.0),
                  RepeatTo = TimeSpan.FromHours(24.0)
                },
                StartDate = PackageChangesCacheJobRepository.PackageChangesCacheJob.Vw5DTjwRVUEJlcN4c2Yy()
              }, (IProductionSchedule) PackageChangesCacheJobRepository.PackageChangesCacheJob.rW3hFIwRl07JojkZ418R((object) Locator.GetServiceNotNull<IProductionCalendarService>()));
              includedDayTrigger.Name = (string) PackageChangesCacheJobRepository.PackageChangesCacheJob.Dy7NsCwR4vVFRvnr2ITF(PackageChangesCacheJobRepository.PackageChangesCacheJob.HrRpQ2wRfQUTvfkHaXqV(44166125 ^ 44090939));
              PackageChangesCacheJobRepository.PackageChangesCacheJob.eAIFjmwRcrpa17Lr9c7Z((object) includedDayTrigger, new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1055964645 ^ 1056019373)));
              this.trigger = (object) includedDayTrigger;
              num = 2;
              continue;
            case 2:
              this.jobs = (ICollection<IJob>) new List<IJob>()
              {
                (IJob) new PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl()
              };
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      public override ITrigger Trigger => (ITrigger) this.trigger;

      public override ICollection<IJob> Jobs => this.jobs;

      internal static DateTime Vw5DTjwRVUEJlcN4c2Yy() => DateTime.Today;

      internal static object rW3hFIwRl07JojkZ418R([In] object obj0) => (object) ((IProductionCalendarService) obj0).GetGlobalProductionSchedule();

      internal static object HrRpQ2wRfQUTvfkHaXqV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object Dy7NsCwR4vVFRvnr2ITF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void eAIFjmwRcrpa17Lr9c7Z([In] object obj0, [In] Guid obj1) => ((NthIncludedDayTrigger) obj0).Id = obj1;

      internal static bool JeKeNHwRYFSx9oILytDK() => PackageChangesCacheJobRepository.PackageChangesCacheJob.GkM9qmwRS961CqxarkX1 == null;

      internal static PackageChangesCacheJobRepository.PackageChangesCacheJob WtBqLvwRynN5B5ys1ixR() => (PackageChangesCacheJobRepository.PackageChangesCacheJob) PackageChangesCacheJobRepository.PackageChangesCacheJob.GkM9qmwRS961CqxarkX1;

      private class JobImpl : IJob
      {
        private object securityService;
        private object packageChangesManager;
        internal static object UFRKTBwfFpXan2sMhU1Q;

        private ISecurityService SecurityService
        {
          get
          {
            int num = 1;
            ISecurityService serviceNotNull;
            object securityService;
            while (true)
            {
              switch (num)
              {
                case 1:
                  securityService = this.securityService;
                  if (securityService == null)
                  {
                    num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
                    continue;
                  }
                  goto label_2;
                case 2:
                  goto label_6;
                default:
                  this.securityService = (object) (serviceNotNull = Locator.GetServiceNotNull<ISecurityService>());
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 2 : 2;
                  continue;
              }
            }
label_2:
            return (ISecurityService) securityService;
label_6:
            return serviceNotNull;
          }
        }

        private PackageChangesManager PackageChangesManager
        {
          get
          {
            int num = 1;
            PackageChangesManager serviceNotNull;
            object packageChangesManager;
            while (true)
            {
              switch (num)
              {
                case 1:
                  packageChangesManager = this.packageChangesManager;
                  if (packageChangesManager == null)
                  {
                    num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_2;
                case 2:
                  goto label_6;
                default:
                  this.packageChangesManager = (object) (serviceNotNull = Locator.GetServiceNotNull<PackageChangesManager>());
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 2 : 0;
                  continue;
              }
            }
label_2:
            return (PackageChangesManager) packageChangesManager;
label_6:
            return serviceNotNull;
          }
        }

        /// <inheritdoc />
        public Guid Id => new Guid((string) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.xhSDVAwfgYdXRD5wiVef(-1115268484 ^ -1115223546));

        /// <inheritdoc />
        public string Name => (string) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.KOifApwfJRUmTL1cgM25(PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.xhSDVAwfgYdXRD5wiVef(1095474805 ^ 155418997 ^ 1208569798));

        /// <inheritdoc />
        public Image Icon => (Image) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.db75aAwfIKyJqBPdaq1G();

        /// <inheritdoc />
        public JobResult Do(DateTime dateToRun)
        {
          int num1 = 1;
          JobResult jobResult;
          PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl jobImpl;
          DateTime dateToRun1;
          while (true)
          {
            switch (num1)
            {
              case 1:
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 0 : 0;
                continue;
              case 2:
                PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.rNEJqZwfeZiKTuJ0OE9q((object) this.SecurityService, (object) (Action) (() =>
                {
                  int num2 = 1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        jobResult = jobImpl.DoJob(dateToRun1);
                        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num1 = 3;
                continue;
              case 3:
                goto label_4;
              case 4:
                dateToRun1 = dateToRun;
                num1 = 5;
                continue;
              case 5:
                jobResult = (JobResult) null;
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 1 : 2;
                continue;
              default:
                jobImpl = this;
                num1 = 4;
                continue;
            }
          }
label_4:
          return jobResult;
        }

        private JobResult DoJob(DateTime dateToRun)
        {
          int num1 = 9;
          List<EleWise.ELMA.Security.Models.IUser>.Enumerator enumerator;
          int valueFromSettings1;
          JobResult jobResult1;
          List<EleWise.ELMA.Security.Models.IUser> list;
          int valueFromSettings2;
          while (true)
          {
            switch (num1)
            {
              case 1:
                try
                {
label_6:
                  if (enumerator.MoveNext())
                    goto label_8;
                  else
                    goto label_7;
label_3:
                  EleWise.ELMA.Security.Models.IUser current;
                  int num2;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        goto label_24;
                      case 2:
                        goto label_8;
                      case 3:
                        this.PackageChangesManager.CreateCacheForUser(current);
                        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
                        continue;
                      case 4:
                        if (current != null)
                        {
                          num2 = 3;
                          continue;
                        }
                        goto label_6;
                      default:
                        goto label_6;
                    }
                  }
label_7:
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 1;
                  goto label_3;
label_8:
                  current = enumerator.Current;
                  num2 = 4;
                  goto label_3;
                }
                finally
                {
                  enumerator.Dispose();
                  int num3 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0)
                    num3 = 0;
                  switch (num3)
                  {
                    default:
                  }
                }
              case 2:
                enumerator = list.GetEnumerator();
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 1 : 1;
                continue;
              case 3:
label_24:
                jobResult1 = new JobResult();
                num1 = 11;
                continue;
              case 4:
                list = this.PackageChangesManager.GetTopUsersForPrepare(valueFromSettings1).ToList<EleWise.ELMA.Security.Models.IUser>();
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 10 : 10;
                continue;
              case 5:
                goto label_16;
              case 6:
                PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.S6e557wf2gcMnQjNmTi1((object) jobResult1, JobStatus.Success);
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 0;
                continue;
              case 7:
                PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.TiNgJjwfn6bB8yanpbDC((object) this.PackageChangesManager, valueFromSettings2);
                num1 = 4;
                continue;
              case 8:
                valueFromSettings1 = this.GetValueFromSettings(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587512765), 1);
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 1 : 7;
                continue;
              case 9:
                valueFromSettings2 = this.GetValueFromSettings(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-617657301 ^ -617734859), 10);
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 8 : 6;
                continue;
              case 10:
                if (PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.Gj5Om5wfL4Yasg7ivhEm((object) list) != 0)
                {
                  num1 = 2;
                  continue;
                }
                goto label_16;
              case 11:
                JobResult jobResult2 = jobResult1;
                object obj;
                if (PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.Gj5Om5wfL4Yasg7ivhEm((object) list) != 1)
                  obj = PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.fHCNOdwfHQZjXe7Liq02(PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.xhSDVAwfgYdXRD5wiVef(1687460816 ^ 1687538136), (object) new object[1]
                  {
                    (object) string.Join<EleWise.ELMA.Security.Models.IUser>((string) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.xhSDVAwfgYdXRD5wiVef(-696756495 ^ -696755491), (IEnumerable<EleWise.ELMA.Security.Models.IUser>) list)
                  });
                else
                  obj = PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.fHCNOdwfHQZjXe7Liq02(PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.xhSDVAwfgYdXRD5wiVef(266768307 ^ 266853649), (object) new object[1]
                  {
                    PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.QIu9VLwfzkTI9e1Rk2SZ((object) list.First<EleWise.ELMA.Security.Models.IUser>())
                  });
                PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.Y5RJpww4uPbHk54syPX1((object) jobResult2, obj);
                num1 = 6;
                continue;
              default:
                goto label_19;
            }
          }
label_16:
          JobResult jobResult3 = new JobResult();
          jobResult3.Information = (string) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.KOifApwfJRUmTL1cgM25(PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.xhSDVAwfgYdXRD5wiVef(658384612 ^ 658470730));
          PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.S6e557wf2gcMnQjNmTi1((object) jobResult3, JobStatus.Success);
          return jobResult3;
label_19:
          return jobResult1;
        }

        private int GetValueFromSettings(string key, int defaultValue)
        {
          int num = 7;
          int result;
          while (true)
          {
            string s;
            switch (num)
            {
              case 1:
                result = defaultValue;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 3 : 2;
                continue;
              case 2:
                if (PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.PDfoElw4bF4fGCvT96bh((object) s))
                {
                  num = 4;
                  continue;
                }
                break;
              case 3:
                goto label_7;
              case 4:
              case 5:
                if (result < 0)
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 1;
                  continue;
                }
                goto label_7;
              case 6:
                s = (string) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.mvlldLw4wT5kenqjOoub((object) key, (object) null);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 2 : 1;
                continue;
              case 7:
                result = -1;
                num = 6;
                continue;
            }
            int.TryParse(s, out result);
            num = 5;
          }
label_7:
          return result;
        }

        public JobImpl()
        {
          PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.BGaTnVw4KqlN4WBuh76F();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool bCd9DNwfvDffJRNUqnUf() => PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.UFRKTBwfFpXan2sMhU1Q == null;

        internal static PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl STVpebwfq5ayiyGjHxot() => (PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl) PackageChangesCacheJobRepository.PackageChangesCacheJob.JobImpl.UFRKTBwfFpXan2sMhU1Q;

        internal static object xhSDVAwfgYdXRD5wiVef(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object KOifApwfJRUmTL1cgM25([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

        internal static object db75aAwfIKyJqBPdaq1G() => (object) Resources.ELMA;

        internal static void rNEJqZwfeZiKTuJ0OE9q([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunBySystemUser((Action) obj1);

        internal static void TiNgJjwfn6bB8yanpbDC([In] object obj0, int count) => ((PackageChangesManager) obj0).CreatePackageChangesForUser(count);

        internal static int Gj5Om5wfL4Yasg7ivhEm([In] object obj0) => ((List<EleWise.ELMA.Security.Models.IUser>) obj0).Count;

        internal static void S6e557wf2gcMnQjNmTi1([In] object obj0, [In] JobStatus obj1) => ((JobResult) obj0).Status = obj1;

        internal static object fHCNOdwfHQZjXe7Liq02([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

        internal static object QIu9VLwfzkTI9e1Rk2SZ([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).UserName;

        internal static void Y5RJpww4uPbHk54syPX1([In] object obj0, [In] object obj1) => ((JobResult) obj0).Information = (string) obj1;

        internal static object mvlldLw4wT5kenqjOoub([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.GetSetting((string) obj0, (string) obj1);

        internal static bool PDfoElw4bF4fGCvT96bh([In] object obj0) => string.IsNullOrEmpty((string) obj0);

        internal static void BGaTnVw4KqlN4WBuh76F() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      }
    }
  }
}
