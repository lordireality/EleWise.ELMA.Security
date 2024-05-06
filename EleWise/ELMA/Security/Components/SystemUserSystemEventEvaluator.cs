// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.SystemUserSystemEventEvaluator
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  [Component]
  internal class SystemUserSystemEventEvaluator : IHistoryModelEvaluator
  {
    internal static SystemUserSystemEventEvaluator nGSV6iwulw5ioXpaGf4S;

    public void Evaluate(IHistoryBaseModel historyModel)
    {
      int num = 2;
      while (true)
      {
        EleWise.ELMA.Security.Models.IUser user;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (historyModel is SystemHistoryModel)
            {
              user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SystemUserSystemEventEvaluator.A5bmaxwuc8IJhpJfgpGt()).Load(SecurityConstants.SystemUserUid);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 3 : 5;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
          case 5:
            if (SystemUserSystemEventEvaluator.oeCM8nwuPKW3b7OKgWhP((object) historyModel) != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 4 : 1;
              continue;
            }
            break;
        }
        SystemUserSystemEventEvaluator.smXNTuwuQVZZO0fVhn7L((object) historyModel, (object) user);
        num = 3;
      }
label_3:
      return;
label_5:
      return;
label_2:;
    }

    public SystemUserSystemEventEvaluator()
    {
      SystemUserSystemEventEvaluator.hwLZh5wu8Dhbrsp5a57V();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object A5bmaxwuc8IJhpJfgpGt() => (object) UserManager.Instance;

    internal static object oeCM8nwuPKW3b7OKgWhP([In] object obj0) => (object) ((IHistoryBaseModel) obj0).ActionAuthor;

    internal static void smXNTuwuQVZZO0fVhn7L([In] object obj0, [In] object obj1) => ((IHistoryBaseModel) obj0).ActionAuthor = (EleWise.ELMA.Security.IUser) obj1;

    internal static bool YBFSOkwufj8aYVGVfIVe() => SystemUserSystemEventEvaluator.nGSV6iwulw5ioXpaGf4S == null;

    internal static SystemUserSystemEventEvaluator DMJ0K3wu4NPUvWymKjSv() => SystemUserSystemEventEvaluator.nGSV6iwulw5ioXpaGf4S;

    internal static void hwLZh5wu8Dhbrsp5a57V() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
