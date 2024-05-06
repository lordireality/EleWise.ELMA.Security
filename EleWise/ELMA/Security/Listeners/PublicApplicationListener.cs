// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.PublicApplicationListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models.API;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Listeners
{
  internal class PublicApplicationListener : EntityEventsListener
  {
    private static PublicApplicationListener dZT9kVAYeY4UMP43IBq;

    public override bool OnPreDelete(PreDeleteEvent @event)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        IPublicApplicationToken applicationToken;
        IPublicApplication publicApplication;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_10;
            case 3:
              if (!PublicApplicationListener.iSIR3nAf9OYfImMqN4x((object) applicationToken))
              {
                num2 = 5;
                continue;
              }
              goto label_10;
            case 4:
              if (applicationToken == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 6:
              if (publicApplication.IsSystem)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 1;
                continue;
              }
              goto case 9;
            case 7:
              if (publicApplication == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 9 : 3;
                continue;
              }
              goto case 6;
            case 8:
              goto label_5;
            case 9:
              applicationToken = PublicApplicationListener.qvkhAJAlNobnqCsIlRE((object) @event) as IPublicApplicationToken;
              num2 = 4;
              continue;
            default:
              goto label_11;
          }
        }
label_5:
        publicApplication = PublicApplicationListener.qvkhAJAlNobnqCsIlRE((object) @event) as IPublicApplication;
        num1 = 7;
      }
label_8:
      return true;
label_10:
      return true;
label_11:
      return false;
    }

    public PublicApplicationListener()
    {
      PublicApplicationListener.EBoCVgA48J5qtJ03TUY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object qvkhAJAlNobnqCsIlRE([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static bool iSIR3nAf9OYfImMqN4x([In] object obj0) => ((IPublicApplicationToken) obj0).IsSystem;

    internal static bool VgcP4ZAyiwsPJ5W6XaY() => PublicApplicationListener.dZT9kVAYeY4UMP43IBq == null;

    internal static PublicApplicationListener VbulGtAVue3A0WAtObF() => PublicApplicationListener.dZT9kVAYeY4UMP43IBq;

    internal static void EBoCVgA48J5qtJ03TUY() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
