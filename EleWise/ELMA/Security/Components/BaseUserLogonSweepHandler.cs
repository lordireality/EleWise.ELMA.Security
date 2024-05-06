// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.BaseUserLogonSweepHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  [Obsolete("Not used", true)]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public abstract class BaseUserLogonSweepHandler : ISweepHandler
  {
    private DateTime lastDateExecute;
    private bool isExecuting;
    private int period;
    private static BaseUserLogonSweepHandler cDc5fxzkgRBCqYnRDyS;

    [Obsolete("Not used", true)]
    public SecuritySettings Settings => Locator.GetServiceNotNull<SecuritySettingsModule>().Settings;

    [Obsolete("Not used", true)]
    public UserSecurityProfileManager UserSecurityProfileManager
    {
      get => this.\u003CUserSecurityProfileManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUserSecurityProfileManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    [Obsolete("Not used", true)]
    public DateTime LastDateSuccessExecute
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              DateTime lastDateExecute = this.lastDateExecute;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 0 : 0;
              continue;
            case 2:
            case 4:
              goto label_6;
            case 3:
              this.lastDateExecute = BaseUserLogonSweepHandler.BXm495zCdunyScIXDEd();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 2 : 4;
              continue;
            default:
              if (!BaseUserLogonSweepHandler.Nv1MFrzxQZjgjX2lppy(this.lastDateExecute, DateTime.MinValue))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 2 : 2;
                continue;
              }
              goto case 3;
          }
        }
label_6:
        return this.lastDateExecute;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.lastDateExecute = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    [Obsolete("Not used", true)]
    public int Period
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.period <= 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return 0;
label_5:
        return this.period;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.period = value <= 0 ? 0 : value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    [Obsolete("Not used", true)]
    public virtual void SetPeriod()
    {
    }

    [Obsolete("Not used", true)]
    public virtual bool CheckPeriod()
    {
      int num = 6;
      DateTime dateSuccessExecute;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_16;
          case 3:
            dateSuccessExecute = this.LastDateSuccessExecute;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 1 : 0;
            continue;
          case 4:
            dateSuccessExecute = this.LastDateSuccessExecute;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 8 : 3;
            continue;
          case 5:
            goto label_13;
          case 6:
            if (this.Period <= 0)
            {
              num = 5;
              continue;
            }
            if (this.Period <= 15)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 0 : 0;
              continue;
            }
            if (this.Period > 90)
            {
              if (this.Period > 1440)
              {
                dateSuccessExecute = this.LastDateSuccessExecute;
                num = 7;
                continue;
              }
              num = 4;
              continue;
            }
            num = 3;
            continue;
          case 7:
            goto label_11;
          case 8:
            goto label_2;
          default:
            dateSuccessExecute = this.LastDateSuccessExecute;
            num = 2;
            continue;
        }
      }
label_2:
      return BaseUserLogonSweepHandler.SswC0WziwMwdChngIKd(dateSuccessExecute.AddHours(1.0), BaseUserLogonSweepHandler.BXm495zCdunyScIXDEd());
label_5:
      return BaseUserLogonSweepHandler.SswC0WziwMwdChngIKd(dateSuccessExecute.AddMinutes(10.0), DateTime.Now);
label_11:
      return BaseUserLogonSweepHandler.SswC0WziwMwdChngIKd(dateSuccessExecute.AddHours(4.0), BaseUserLogonSweepHandler.BXm495zCdunyScIXDEd());
label_13:
      return false;
label_16:
      return BaseUserLogonSweepHandler.SswC0WziwMwdChngIKd(dateSuccessExecute.AddMinutes(1.0), BaseUserLogonSweepHandler.BXm495zCdunyScIXDEd());
    }

    [Obsolete("Not used", true)]
    public virtual void DoWork()
    {
    }

    [Obsolete("Not used", true)]
    public virtual void Execute()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.isExecuting)
            {
              num1 = 4;
              continue;
            }
            goto case 5;
          case 2:
            BaseUserLogonSweepHandler.JW9BHFz3Y4lfM5Mu7N4((object) this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_23;
          case 5:
            if (!BaseUserLogonSweepHandler.T6nTEVzjg8FjfxudH6J((object) this))
            {
              num1 = 6;
              continue;
            }
            break;
          case 6:
            goto label_20;
          case 7:
            goto label_8;
        }
        this.isExecuting = true;
        num1 = 3;
      }
label_23:
      return;
label_20:
      return;
label_8:
      return;
label_5:
      try
      {
        BaseUserLogonSweepHandler.g1U2V3zN3T01RFV0EN1((object) this);
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_16;
            case 1:
              this.LastDateSuccessExecute = BaseUserLogonSweepHandler.BXm495zCdunyScIXDEd();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 0 : 0;
              continue;
            default:
              goto label_14;
          }
        }
label_16:
        return;
label_14:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_10;
            default:
              ((ILogger) BaseUserLogonSweepHandler.qCbqonz0b1NelInUwof()).Error((object) ex.Message, ex);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 1 : 0;
              continue;
          }
        }
label_10:;
      }
      finally
      {
        this.isExecuting = false;
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    protected BaseUserLogonSweepHandler()
    {
      BaseUserLogonSweepHandler.NFMdk2zZHvrXed1G2Qj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JrePFozDRPjY3kVd2eB() => BaseUserLogonSweepHandler.cDc5fxzkgRBCqYnRDyS == null;

    internal static BaseUserLogonSweepHandler RCt2ECzaWbs4Gc5Ct2n() => BaseUserLogonSweepHandler.cDc5fxzkgRBCqYnRDyS;

    internal static bool Nv1MFrzxQZjgjX2lppy([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

    internal static DateTime BXm495zCdunyScIXDEd() => DateTime.Now;

    internal static bool SswC0WziwMwdChngIKd([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static void JW9BHFz3Y4lfM5Mu7N4([In] object obj0) => ((BaseUserLogonSweepHandler) obj0).SetPeriod();

    internal static bool T6nTEVzjg8FjfxudH6J([In] object obj0) => ((BaseUserLogonSweepHandler) obj0).CheckPeriod();

    internal static void g1U2V3zN3T01RFV0EN1([In] object obj0) => ((BaseUserLogonSweepHandler) obj0).DoWork();

    internal static object qCbqonz0b1NelInUwof() => (object) Logger.Log;

    internal static void NFMdk2zZHvrXed1G2Qj() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
