// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.ComplexExecutorInfo
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Components;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Инфа по исолнителю</summary>
  public class ComplexExecutorInfo
  {
    private IUser _user;
    private IUserGroup _group;
    internal static ComplexExecutorInfo pIIhMg4n6lTXHDOIeX1;

    /// <summary>Значение с префиксом</summary>
    public string PrefixedValue
    {
      get => this.\u003CPrefixedValue\u003Ek__BackingField;
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
              this.\u003CPrefixedValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    public ComplexExecutorInfo()
    {
      ComplexExecutorInfo.xMhRQk4H3wx6TH0KdLf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="user"></param>
    public ComplexExecutorInfo(IUser user)
    {
      ComplexExecutorInfo.xMhRQk4H3wx6TH0KdLf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.PrefixedValue = string.Format((string) ComplexExecutorInfo.Y9uXag4zdiCcc1fynsh(-17837901 ^ -17869355), ComplexExecutorInfo.LPHjRycu5ugcX963T9I(ComplexExecutorInfo.Y9uXag4zdiCcc1fynsh(-550634672 ^ -550633832)), (object) user.Id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="group"></param>
    public ComplexExecutorInfo(IUserGroup group)
    {
      ComplexExecutorInfo.xMhRQk4H3wx6TH0KdLf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.PrefixedValue = string.Format((string) ComplexExecutorInfo.Y9uXag4zdiCcc1fynsh(266768307 ^ 266734293), ComplexExecutorInfo.LPHjRycu5ugcX963T9I(ComplexExecutorInfo.Y9uXag4zdiCcc1fynsh(-2143851882 - 923330995 ^ 1227752853)), (object) group.Id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Пользователь</summary>
    public IUser User
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 2:
              if (this._user != null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            case 3:
              if (!string.IsNullOrEmpty(this.PrefixedValue))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 4 : 3;
                continue;
              }
              goto label_4;
            case 4:
              this._user = BaseEntityUserTypeSelector.LoadEntity(this.PrefixedValue, InterfaceActivator.TypeOf<IUser>()) as IUser;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return this._user;
      }
    }

    /// <summary>Группа</summary>
    public IUserGroup UserGroup
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 3:
              case 5:
                goto label_3;
              case 2:
                if (this._group != null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 0 : 1;
                  continue;
                }
                break;
              case 4:
                goto label_6;
            }
            if (string.IsNullOrEmpty(this.PrefixedValue))
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 3 : 3;
            else
              break;
          }
label_6:
          this._group = BaseEntityUserTypeSelector.LoadEntity(this.PrefixedValue, InterfaceActivator.TypeOf<IUserGroup>()) as IUserGroup;
          num1 = 5;
        }
label_3:
        return this._group;
      }
    }

    internal static bool q9HoqB4LVZIw7r5ZgCs() => ComplexExecutorInfo.pIIhMg4n6lTXHDOIeX1 == null;

    internal static ComplexExecutorInfo y2AsNd42uScQXsyxE9L() => ComplexExecutorInfo.pIIhMg4n6lTXHDOIeX1;

    internal static void xMhRQk4H3wx6TH0KdLf() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object Y9uXag4zdiCcc1fynsh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object LPHjRycu5ugcX963T9I([In] object obj0) => (object) BaseEntityUserTypeSelector.GetFullPrefix((string) obj0);
  }
}
