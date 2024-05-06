// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.SecurityService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security
{
  /// <summary>Сервис асинхронной проверки привилегий пользователя</summary>
  [Service(Scope = ServiceScope.Shell)]
  public class SecurityService : NHManagerBase, ISecurityServiceAsync, ISecurityService
  {
    private readonly Func<IEnumerable<IPermissionsDelegate>> permissionsDelegates;
    private readonly IAuthenticationService authorizationImportService;
    private readonly IPermissionManagmentService permissionManagmentService;
    private readonly RunWithElevatedPrivilegiesService _runWithElevatedPrivilegiesService;
    private readonly IEnumerable<IGlobalPermissionsDelegate> globalPermissionsDelegates;
    private readonly ITransformationProvider transformationProvider;
    internal static SecurityService csampaKK66tf5jaqJ5i;

    /// <inheritdoc />
    public async Task RunWithElevatedPrivilegiesAsync(Func<Task> action)
    {
      int num1 = 4;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_45;
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 0;
            continue;
          case 2:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 5;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 2;
              else
                goto label_10;
label_8:
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_12;
                  case 3:
                    goto label_3;
                  case 4:
                    goto label_10;
                  default:
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 1 : 1;
                    continue;
                }
              }
label_12:
              bool skip;
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = 11;
                else
                  goto label_26;
label_14:
                while (true)
                {
                  TaskAwaiter taskAwaiter;
                  TaskAwaiter awaiter;
                  switch (num4)
                  {
                    case 1:
                      taskAwaiter = awaiter;
                      num4 = 16;
                      continue;
                    case 2:
                    case 14:
                      awaiter.GetResult();
                      num4 = 9;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      SecurityService.\u003CRunWithElevatedPrivilegiesAsync\u003Ed__0.oikiCCwoDpgruTMnmoC7((object) this.RunWithElevatedPrivilegiesService, true);
                      num4 = 10;
                      continue;
                    case 4:
                      goto label_38;
                    case 5:
                    case 10:
                      // ISSUE: reference to a compiler-generated method
                      awaiter = SecurityService.\u003CRunWithElevatedPrivilegiesAsync\u003Ed__0.CwcMhZwoaqBpew61u2WY((object) action());
                      num4 = 7;
                      continue;
                    case 6:
                      taskAwaiter = new TaskAwaiter();
                      num4 = 12;
                      continue;
                    case 7:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 2 : 0;
                        continue;
                      }
                      break;
                    case 8:
                    case 11:
                      awaiter = taskAwaiter;
                      num4 = 6;
                      continue;
                    case 9:
                      goto label_3;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 14 : 5;
                      continue;
                    case 13:
                      goto label_26;
                    case 15:
                      if (skip)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 5 : 2;
                        continue;
                      }
                      goto case 3;
                    case 16:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SecurityService.\u003CRunWithElevatedPrivilegiesAsync\u003Ed__0>(ref awaiter, this);
                      num4 = 4;
                      continue;
                  }
                  // ISSUE: explicit reference operation
                  // ISSUE: reference to a compiler-generated field
                  (^this).\u003C\u003E1__state = num2 = 0;
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 0;
                }
label_38:
                return;
label_26:
                skip = this.RunWithElevatedPrivilegiesService.Turned;
                num4 = 15;
                goto label_14;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        SecurityService.\u003CRunWithElevatedPrivilegiesAsync\u003Ed__0.oikiCCwoDpgruTMnmoC7((object) this.RunWithElevatedPrivilegiesService, false);
                        num5 = 3;
                        continue;
                      case 2:
                      case 3:
                        goto label_37;
                      default:
                        if (skip)
                        {
                          num5 = 2;
                          continue;
                        }
                        goto case 1;
                    }
                  }
                }
label_37:;
              }
label_10:
              skip = false;
              num3 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0)
              {
                num3 = 0;
                goto label_8;
              }
              else
                goto label_8;
            }
            catch (Exception ex)
            {
              int num6 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_34;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = 2;
                    continue;
                }
              }
label_34:
              return;
            }
          default:
            goto label_42;
        }
      }
label_45:
      return;
label_42:;
    }

    /// <inheritdoc />
    public async Task RunBySystemUserAsync(Func<Task> action)
    {
      int num1 = 4;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_43:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_40;
          case 3:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 5 : 4;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 3 : 1;
              else
                goto label_5;
label_4:
              EleWise.ELMA.Security.Models.IUser user;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_43;
                  case 2:
                  case 3:
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 5 : 1;
                    continue;
                  case 4:
                    goto label_5;
                  case 5:
                    goto label_10;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityService.\u003CRunBySystemUserAsync\u003Ed__1.UR6981wojymD6Qr3li6L()).Load(SecurityConstants.SystemUserUid);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    SecurityService.\u003CRunBySystemUserAsync\u003Ed__1.TkdliYwoNsqOFBQhiOD1((object) this.authorizationImportService, (object) user);
                    num3 = 2;
                    continue;
                }
              }
label_10:
              IUser currentUser;
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 1 : 1;
                else
                  goto label_15;
label_13:
                TaskAwaiter awaiter;
                while (true)
                {
                  TaskAwaiter taskAwaiter;
                  int num5;
                  switch (num4)
                  {
                    case 1:
                    case 9:
                      awaiter = taskAwaiter;
                      num4 = 10;
                      continue;
                    case 2:
                      if (!awaiter.IsCompleted)
                      {
                        num4 = 11;
                        continue;
                      }
                      goto case 8;
                    case 3:
                      goto label_43;
                    case 4:
                      goto label_15;
                    case 5:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SecurityService.\u003CRunBySystemUserAsync\u003Ed__1>(ref awaiter, this);
                      num4 = 7;
                      continue;
                    case 6:
                      taskAwaiter = awaiter;
                      num5 = 5;
                      break;
                    case 7:
                      goto label_37;
                    case 8:
                      awaiter.GetResult();
                      num4 = 3;
                      continue;
                    case 10:
                      taskAwaiter = new TaskAwaiter();
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 0;
                      continue;
                    case 11:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 3 : 6;
                      continue;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = 8;
                      break;
                  }
                  num4 = num5;
                }
label_37:
                return;
label_15:
                awaiter = this.RunWithElevatedPrivilegiesAsync(action).GetAwaiter();
                num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0)
                {
                  num4 = 2;
                  goto label_13;
                }
                else
                  goto label_13;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num6 = 4;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 2:
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        SecurityService.\u003CRunBySystemUserAsync\u003Ed__1.zM1XbNwo0MRfjhkqtTVP((object) this.authorizationImportService);
                        num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 1 : 1;
                        continue;
                      case 4:
                        if (currentUser == null)
                        {
                          num6 = 3;
                          continue;
                        }
                        goto case 5;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        SecurityService.\u003CRunBySystemUserAsync\u003Ed__1.TkdliYwoNsqOFBQhiOD1((object) this.authorizationImportService, (object) currentUser);
                        num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_32;
                    }
                  }
                }
label_32:;
              }
label_5:
              // ISSUE: reference to a compiler-generated method
              currentUser = (IUser) SecurityService.\u003CRunBySystemUserAsync\u003Ed__1.zR6V1Fwo3L3go3GXE1kT((object) this.authorizationImportService);
              num3 = 6;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0)
              {
                num3 = 4;
                goto label_4;
              }
              else
                goto label_4;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0)
                num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_33;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 2;
                    continue;
                }
              }
label_33:
              return;
            }
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 2 : 2;
            continue;
        }
      }
label_40:;
    }

    /// <inheritdoc />
    public async Task RunByUserAsync(IUser user, Func<Task> action)
    {
      int num1 = 3;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 5 : 4;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_41;
          case 5:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 3;
              else
                goto label_30;
label_7:
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    SecurityService.\u003CRunByUserAsync\u003Ed__2.vX9N5bwoWMRWZ9O883mV((object) this.authorizationImportService, (object) user);
                    num3 = 2;
                    continue;
                  case 2:
                  case 3:
                    num3 = 4;
                    continue;
                  case 4:
                    goto label_9;
                  case 5:
                    goto label_30;
                  default:
                    goto label_3;
                }
              }
label_9:
              IUser currentUser;
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 0 : 0;
                else
                  goto label_15;
label_11:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 5:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 7 : 4;
                      continue;
                    case 2:
                      if (awaiter.IsCompleted)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 8;
                    case 3:
                      taskAwaiter = new TaskAwaiter();
                      num4 = 11;
                      continue;
                    case 4:
                      goto label_38;
                    case 6:
                      goto label_15;
                    case 7:
                      goto label_3;
                    case 8:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = 10;
                      continue;
                    case 10:
                      taskAwaiter = awaiter;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 12 : 11;
                      continue;
                    case 11:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 5;
                      continue;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SecurityService.\u003CRunByUserAsync\u003Ed__2>(ref awaiter, this);
                      num4 = 4;
                      continue;
                    default:
                      awaiter = taskAwaiter;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 3 : 0;
                      continue;
                  }
                }
label_38:
                return;
label_15:
                // ISSUE: reference to a compiler-generated method
                awaiter = SecurityService.\u003CRunByUserAsync\u003Ed__2.Ae3D5WworFd1TukruflF((object) action());
                num4 = 2;
                goto label_11;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num5 = 3;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                      case 4:
                        goto label_29;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        SecurityService.\u003CRunByUserAsync\u003Ed__2.vX9N5bwoWMRWZ9O883mV((object) this.authorizationImportService, (object) currentUser);
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 1 : 1;
                        continue;
                      case 3:
                        if (currentUser != null)
                        {
                          num5 = 2;
                          continue;
                        }
                        break;
                    }
                    // ISSUE: reference to a compiler-generated method
                    SecurityService.\u003CRunByUserAsync\u003Ed__2.ziN4DFwoSVc6gCTnJjma((object) this.authorizationImportService);
                    num5 = 4;
                  }
                }
label_29:;
              }
label_30:
              // ISSUE: reference to a compiler-generated method
              currentUser = (IUser) SecurityService.\u003CRunByUserAsync\u003Ed__2.ojt8FOwo7Pp3c15VTDAU((object) this.authorizationImportService);
              num3 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0)
              {
                num3 = 0;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num6 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
                num6 = 2;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_34;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_33;
                }
              }
label_34:
              return;
label_33:
              return;
            }
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = 4;
            continue;
        }
      }
label_41:;
    }

    public IComplexCacheService ComplexCacheService
    {
      get => this.\u003CComplexCacheService\u003Ek__BackingField;
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
              this.\u003CComplexCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 0 : 0;
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
    /// <param name="permissionsDelegates">Делегаты привилегий</param>
    /// <param name="authorizationImportService">Служба аутентификации системы</param>
    /// <param name="permissionManagmentService">Управление привилегиями: манипуляции со списком</param>
    /// <param name="_runWithElevatedPrivilegiesService">Сервис, влияющий на результат проверки прав в текущем контексте</param>
    /// <param name="globalPermissionsDelegates">Делегаты глобальных привилегий</param>
    /// <param name="transformationProvider">Провайдер преобразования БД</param>
    public SecurityService(
      Func<IEnumerable<IPermissionsDelegate>> permissionsDelegates,
      IAuthenticationService authorizationImportService,
      IPermissionManagmentService permissionManagmentService,
      RunWithElevatedPrivilegiesService _runWithElevatedPrivilegiesService,
      IEnumerable<IGlobalPermissionsDelegate> globalPermissionsDelegates,
      ITransformationProvider transformationProvider)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.permissionsDelegates = permissionsDelegates;
      this._runWithElevatedPrivilegiesService = _runWithElevatedPrivilegiesService;
      this.authorizationImportService = authorizationImportService;
      this.permissionManagmentService = permissionManagmentService;
      this.globalPermissionsDelegates = globalPermissionsDelegates;
      this.transformationProvider = transformationProvider;
    }

    public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService
    {
      get => this.\u003CRunWithElevatedPrivilegiesService\u003Ek__BackingField;
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
              this.\u003CRunWithElevatedPrivilegiesService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 0 : 0;
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

    public RunWithSoftDeletableService RunWithSoftDeletableService
    {
      get => this.\u003CRunWithSoftDeletableService\u003Ek__BackingField;
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
              this.\u003CRunWithSoftDeletableService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
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

    /// <summary>Отключить настройки безопасности</summary>
    internal static bool DisableSecurityBySettings => EleWise.ELMA.SR.GetSetting<bool>((string) SecurityService.oRykG7KoJGvTmAX4TtM(-901653144 ^ -901659198));

    [PublicApiNodeId("SecurityServicesApi")]
    public bool HasPermission(IUser user, Permission permission)
    {
      int num1 = 3;
      IEnumerator<IGlobalPermissionsDelegate> enumerator;
      Guid[] guidArray1;
      while (true)
      {
        Guid[] guidArray2;
        SecurityService securityService;
        long userId;
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            securityService = this;
            num1 = 15;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_8;
          case 5:
            goto label_24;
          case 6:
            guidArray2 = this.ComplexCacheService.GetOrAdd<Guid[]>((string) SecurityService.CZiRCBKkuYZVJEhAw4P((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112568344), (object) userId), (string) SecurityService.CZiRCBKkuYZVJEhAw4P((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340794722), (object) userId), (string) SecurityService.oRykG7KoJGvTmAX4TtM(-979995965 << 4 ^ 1499936160), (Func<Guid[]>) (() => securityService.GetUserPermissions(userId)));
            break;
          case 7:
            if (user == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 0;
              continue;
            }
            if (!SecurityService.jqUFi2KmYdV409oOpWq((object) permission, (object) null))
            {
              num1 = 10;
              continue;
            }
            goto label_26;
          case 8:
            if (!SecurityService.DisableSecurityBySettings)
            {
              num1 = 7;
              continue;
            }
            goto label_3;
          case 9:
            if (!((IEnumerable<Guid>) guidArray1).Contains<Guid>(SecurityService.Ugqx37KDeOSvp2GWqWg((object) permission)))
            {
              enumerator = this.globalPermissionsDelegates.GetEnumerator();
              num1 = 11;
              continue;
            }
            num1 = 4;
            continue;
          case 10:
            if (SecurityService.x3GF2DK6CLKtnwbBUfO((object) permission) == PermissionType.Global)
            {
              userId = ((IEntity<long>) user).Id;
              num1 = 14;
              continue;
            }
            num1 = 5;
            continue;
          case 11:
            goto label_10;
          case 12:
            goto label_39;
          case 13:
            goto label_26;
          case 14:
            if (this.ComplexCacheService != null)
            {
              num1 = 6;
              continue;
            }
            guidArray2 = this.GetUserPermissions(userId);
            break;
          case 15:
            if (!SecurityService.xTHdwNKtMrsnFwdbcHo((object) this._runWithElevatedPrivilegiesService))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 2 : 8;
              continue;
            }
            goto label_3;
          default:
            goto label_33;
        }
        guidArray1 = guidArray2;
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 9;
      }
label_3:
      return true;
label_8:
      return true;
label_10:
      bool flag;
      try
      {
label_14:
        if (SecurityService.Pmko4pKahskUtaPAbZl((object) enumerator))
          goto label_16;
        else
          goto label_15;
label_11:
        int num2;
        switch (num2)
        {
          case 1:
          case 2:
            goto label_14;
          case 3:
            goto label_40;
          case 4:
            goto label_39;
          case 5:
            goto label_16;
        }
label_12:
        flag = true;
        num2 = 3;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0)
        {
          num2 = 2;
          goto label_11;
        }
        else
          goto label_11;
label_15:
        num2 = 4;
        goto label_11;
label_16:
        if (!enumerator.Current.HasPermission(user, permission, (IEnumerable<Guid>) guidArray1))
        {
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 1 : 1;
          goto label_11;
        }
        else
          goto label_12;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 0;
        else
          goto label_21;
label_20:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_21:
        SecurityService.crVlvxKx180EsICw1iI((object) enumerator);
        num3 = 2;
        goto label_20;
      }
label_40:
      return flag;
label_24:
      throw new ArgumentException((string) SecurityService.oRykG7KoJGvTmAX4TtM(554338340 ^ 554340544), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169282374));
label_26:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(-1640694811 << 2 ^ 2027157336));
label_33:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(581409346 ^ 581405242));
label_39:
      return false;
    }

    /// <summary>Получить глобальные привилегии пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Уникальные идентификаторы привилегий</returns>
    internal Guid[] GetUserGlobalPermissions(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 2;
      SecurityService securityService;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            securityService = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 3 : 2;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 0 : 1;
            continue;
          case 3:
            user1 = user;
            num1 = 4;
            continue;
          case 4:
            SecurityService.T9kgesKCiqXqAKskIj4((object) user1, SecurityService.oRykG7KoJGvTmAX4TtM(-1440374117 ^ -1440369949));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      IEnumerable<Permission> source1 = this.permissionManagmentService.GetPermissions().Where<Permission>((Func<Permission, bool>) (i => i.PermissionType == PermissionType.Global));
      HashSet<Guid> userPermissions = ((IEnumerable<Guid>) this.GetUserPermissions(user1.Id)).ToHashSet<Guid>();
      Func<Permission, bool> predicate = (Func<Permission, bool>) (i =>
      {
        int num2 = 3;
        Permission i1;
        // ISSUE: variable of a compiler-generated type
        SecurityService.\u003C\u003Ec__DisplayClass25_0 cDisplayClass250;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (!userPermissions.Contains(SecurityService.\u003C\u003Ec__DisplayClass25_0.ypsQe0woPe9NfueyEJGC((object) i1)))
              {
                num2 = 4;
                continue;
              }
              goto label_6;
            case 2:
              cDisplayClass250 = this;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
              continue;
            case 3:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 1 : 2;
              continue;
            case 4:
              goto label_5;
            default:
              i1 = i;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 1 : 0;
              continue;
          }
        }
label_5:
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        return securityService.globalPermissionsDelegates.Any<IGlobalPermissionsDelegate>((Func<IGlobalPermissionsDelegate, bool>) (j => j.HasPermission((IUser) cDisplayClass250.user, i1, (IEnumerable<Guid>) cDisplayClass250.userPermissions)));
label_6:
        return true;
      });
      IEnumerable<Permission> source2 = source1.Where<Permission>(predicate);
      // ISSUE: reference to a compiler-generated field
      Func<Permission, Guid> func = SecurityService.\u003C\u003Ec.\u003C\u003E9__25_2;
      Func<Permission, Guid> selector;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        SecurityService.\u003C\u003Ec.\u003C\u003E9__25_2 = selector = (Func<Permission, Guid>) (i => i.Id);
      }
      else
        goto label_7;
label_9:
      return source2.Select<Permission, Guid>(selector).ToArray<Guid>();
label_7:
      selector = func;
      goto label_9;
    }

    private Guid[] GetUserPermissions(long userId)
    {
      int num1 = 2;
      List<Guid> list;
      SecurityService securityService;
      while (true)
      {
        switch (num1)
        {
          case 1:
            securityService = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            list = ((ICriteria) SecurityService.b4qnP8KNGdJ3SDG60Wf(SecurityService.a9VsTHK3ZS9FqrbiFf1((object) this.Session.CreateCriteria<GroupPermission>(), (object) Expression.Sql(string.Format((string) SecurityService.oRykG7KoJGvTmAX4TtM(-1743015995 ^ -1743014365), SecurityService.iL31dSKiNfoca2jAE29((object) this.transformationProvider, SecurityService.oRykG7KoJGvTmAX4TtM(84189367 + 1997579375 ^ 2081775388), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331076470))), (object) userId, (IType) NHibernateUtil.Int64)), (object) new IProjection[1]
            {
              (IProjection) SecurityService.lflQpAKjsAABiOuANPb(SecurityService.oRykG7KoJGvTmAX4TtM(1433051380 + 1051547170 ^ -1810371216))
            })).List<Guid>().ToList<Guid>();
            num1 = 3;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated method
      IEnumerable<Permission> source1 = list.Select<Guid, Permission>((Func<Guid, Permission>) (id => (Permission) SecurityService.\u003C\u003Ec__DisplayClass26_0.FEtV2TwoTJD8ahdQ7bU1((object) securityService.permissionManagmentService, id)));
      // ISSUE: reference to a compiler-generated field
      Func<Permission, bool> func = SecurityService.\u003C\u003Ec.\u003C\u003E9__26_1;
      Func<Permission, bool> predicate1;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        SecurityService.\u003C\u003Ec.\u003C\u003E9__26_1 = predicate1 = (Func<Permission, bool>) (p => SecurityService.\u003C\u003Ec.fCAJ2bwo16JSxVeHlVCP((object) p, (object) null));
      }
      else
        goto label_8;
label_7:
      IEnumerable<Permission> source2 = source1.Where<Permission>(predicate1);
      List<Guid> uids = list;
      Func<Permission, bool> predicate2 = (Func<Permission, bool>) (p =>
      {
        int num2 = 4;
        Permission permission;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_10;
            case 3:
              if (!p.CheckModuleAccess)
              {
                num2 = 2;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              permission = (Permission) SecurityService.\u003C\u003Ec__DisplayClass26_0.daP8FBwoFt0HNbIZhpxK((object) securityService.permissionManagmentService, (object) p.ModuleUid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
              continue;
            case 4:
              if (!string.IsNullOrEmpty(p.ModuleUid))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 3 : 3;
                continue;
              }
              goto label_10;
            default:
              // ISSUE: reference to a compiler-generated method
              if (!SecurityService.\u003C\u003Ec__DisplayClass26_0.h97tx9wovhlTRfa8qeTs((object) permission, (object) null))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 1;
                continue;
              }
              goto label_9;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated method
        return uids.Contains(SecurityService.\u003C\u003Ec__DisplayClass26_0.Q5lH8iwoqYYgLjkRb6Q1((object) permission));
label_9:
        return true;
label_10:
        return true;
      });
      return source2.Where<Permission>(predicate2).Select<Permission, Guid>((Func<Permission, Guid>) (p => p.Id)).ToArray<Guid>();
label_8:
      predicate1 = func;
      goto label_7;
    }

    /// <summary>Сбросить кэш пермишенов</summary>
    public void ResetPermissionsCache()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ComplexCacheService.RefreshTimestamp((string) SecurityService.oRykG7KoJGvTmAX4TtM(-389167216 ^ -389161472));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 0 : 0;
            continue;
          case 2:
            if (this.ComplexCacheService != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    /// <summary>Сбросить кэш пермишенов для пользователя</summary>
    public void ResetPermissions4UserCache(long userId)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_2;
          case 2:
            if (this.ComplexCacheService == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            this.ComplexCacheService.RefreshTimestamp(SecurityService.oRykG7KoJGvTmAX4TtM(447286529 ^ 447288465).ToString() + (object) userId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    [PublicApiNodeId("SecurityServicesApi")]
    public bool HasPermission(Permission permission)
    {
      int num = 5;
      IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            user = (IUser) SecurityService.qTk9pNKZ8kt7OBRgaIm((object) this.authorizationImportService);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (!SecurityService.g5tqSMK0QpOCy1p68FB())
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 1 : 2;
              continue;
            }
            goto label_2;
          case 5:
            if (!this._runWithElevatedPrivilegiesService.Turned)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 4 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_2:
      return true;
label_8:
      return false;
label_9:
      return this.HasPermission(user, permission);
    }

    public bool HasPermission(IUser user, Permission permission, System.Type type) => this.HasPermission(user, permission, type, false);

    public bool HasPermission(IUser user, Permission permission, System.Type type, bool skipAdmin)
    {
      int num = 6;
      Permission permissionForBase;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_12;
          case 2:
            goto label_17;
          case 3:
            if (permissionForBase != (Permission) null)
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 4:
            if (SecurityService.jqUFi2KmYdV409oOpWq((object) permission, (object) null))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 1 : 1;
              continue;
            }
            if (!SecurityService.Oiqwa7KAPcVqgg2ltlg(type, (System.Type) null))
            {
              permissionForBase = this.permissionManagmentService.GetPermissionForBase(permission, type);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 3 : 2;
              continue;
            }
            num = 9;
            continue;
          case 5:
            if (SecurityService.g5tqSMK0QpOCy1p68FB())
            {
              num = 2;
              continue;
            }
            if (user != null)
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 6:
            if (!this._runWithElevatedPrivilegiesService.Turned)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 5 : 2;
              continue;
            }
            goto label_17;
          case 7:
            if (SecurityService.x3GF2DK6CLKtnwbBUfO((object) permission) == PermissionType.Global)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
              continue;
            }
            goto label_23;
          case 8:
            permission = permissionForBase;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 6 : 7;
            continue;
          case 9:
            goto label_10;
          case 10:
            goto label_7;
          default:
            goto label_22;
        }
      }
label_7:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751467293 ^ -1751471461));
label_10:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1403802000 ^ 1403800338));
label_12:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(1185105284 ^ 1185111368));
label_17:
      return true;
label_22:
      return this.HasPermission(user, permission);
label_23:
      return SecurityService.jqEnAVKsaFlFwxcpxg1((object) this.GetPermissionsDelegate(type, permission), (object) user, (object) permission, (object) type, skipAdmin);
    }

    public bool HasPermission(
      IUser user,
      Permission permission,
      System.Type type,
      PropertyInfo propertyInfo)
    {
      throw new NotImplementedException();
    }

    public bool HasPermission(IUser user, Permission permission, IPermissionTarget target) => throw new NotImplementedException();

    [PublicApiNodeId("SecurityServicesApi")]
    [ContextCache]
    public virtual bool HasPermission(
      IUser user,
      Permission permission,
      object target,
      bool skipAdmin = false)
    {
      int num = 11;
      System.Type type;
      while (true)
      {
        Permission permission1;
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
          case 10:
            goto label_9;
          case 3:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 12 : 13;
              continue;
            }
            if (!SecurityService.jqUFi2KmYdV409oOpWq((object) permission, (object) null))
            {
              if (target == null)
              {
                num = 9;
                continue;
              }
              type = target.CastAsRealType().GetType();
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 1 : 1;
            continue;
          case 4:
            permission1 = (Permission) SecurityService.eLLLcDK7tACwryjx86B((object) this.permissionManagmentService, (object) permission, type);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 8;
            continue;
          case 5:
            permission = permission1;
            num = 12;
            continue;
          case 6:
          case 12:
            if (SecurityService.x3GF2DK6CLKtnwbBUfO((object) permission) == PermissionType.Global)
            {
              num = 7;
              continue;
            }
            goto label_24;
          case 7:
            goto label_23;
          case 8:
            if (!SecurityService.j261eNKWghJg5UqgTaf((object) permission1, (object) null))
            {
              num = 6;
              continue;
            }
            goto case 5;
          case 9:
            goto label_12;
          case 11:
            if (SecurityService.xTHdwNKtMrsnFwdbcHo((object) this._runWithElevatedPrivilegiesService))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 7 : 10;
              continue;
            }
            break;
          case 13:
            goto label_20;
        }
        if (!SecurityService.g5tqSMK0QpOCy1p68FB())
          num = 3;
        else
          goto label_9;
      }
label_6:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(1124861159 ^ 1124867115));
label_9:
      return true;
label_12:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(-1277802350 ^ -1277799908));
label_20:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(-468111058 ^ -468115114));
label_23:
      return this.HasPermission(user, permission);
label_24:
      return SecurityService.jqEnAVKsaFlFwxcpxg1((object) this.GetPermissionsDelegate(type, permission), (object) user, (object) permission, SecurityService.x3GF2DK6CLKtnwbBUfO((object) permission) == PermissionType.Instance ? target : (object) type, skipAdmin);
    }

    public bool HasPermission(Permission permission, System.Type type, bool skipAdmin = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!SecurityService.xTHdwNKtMrsnFwdbcHo((object) this._runWithElevatedPrivilegiesService))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            if (SecurityService.g5tqSMK0QpOCy1p68FB())
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return true;
label_3:
      return this.HasPermission((IUser) SecurityService.qTk9pNKZ8kt7OBRgaIm((object) this.authorizationImportService), permission, type, skipAdmin);
    }

    [PublicApiNodeId("SecurityServicesApi")]
    public bool HasPermission(Permission permission, object target, bool skipAdmin = false)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_6;
          case 2:
            if (SecurityService.xTHdwNKtMrsnFwdbcHo((object) this._runWithElevatedPrivilegiesService))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (!SecurityService.g5tqSMK0QpOCy1p68FB())
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return true;
label_7:
      return this.HasPermission((IUser) SecurityService.qTk9pNKZ8kt7OBRgaIm((object) this.authorizationImportService), permission, target, skipAdmin);
    }

    [PublicApiNodeId("SecurityServicesApi")]
    public bool CanCheckPermission(Permission permission, object target)
    {
      int num1 = 6;
      System.Type type;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Permission permission1;
          switch (num2)
          {
            case 1:
              if (SecurityService.j261eNKWghJg5UqgTaf((object) permission1, (object) null))
              {
                num2 = 2;
                continue;
              }
              break;
            case 2:
              permission = permission1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 0 : 0;
              continue;
            case 3:
              type = SecurityService.XnGTqlKr9Ownabswk4w(target).GetType();
              num2 = 9;
              continue;
            case 4:
              goto label_14;
            case 5:
              if (target != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 3;
                continue;
              }
              goto label_6;
            case 6:
              goto label_10;
            case 7:
              goto label_3;
            case 8:
              goto label_6;
            case 9:
              permission1 = (Permission) SecurityService.eLLLcDK7tACwryjx86B((object) this.permissionManagmentService, (object) permission, type);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 1 : 1;
              continue;
          }
          if (permission.PermissionType != PermissionType.Global)
            num2 = 4;
          else
            goto label_15;
        }
label_10:
        if (!SecurityService.jqUFi2KmYdV409oOpWq((object) permission, (object) null))
          num1 = 5;
        else
          break;
      }
label_3:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(-315619370 - -1325004768 ^ 1009379194));
label_6:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--2002186503 ^ 2002185097));
label_14:
      return this.GetDelegateByType(type, permission) != null;
label_15:
      return true;
    }

    public bool CanCheckPermission(Permission permission, System.Type type)
    {
      int num = 7;
      Permission permission1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SecurityService.x3GF2DK6CLKtnwbBUfO((object) permission) == PermissionType.EntityType)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 3 : 4;
              continue;
            }
            goto label_11;
          case 2:
            goto label_13;
          case 3:
            permission = permission1;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_10;
          case 6:
            goto label_4;
          case 7:
            if (!SecurityService.jqUFi2KmYdV409oOpWq((object) permission, (object) null))
            {
              if (SecurityService.Oiqwa7KAPcVqgg2ltlg(type, (System.Type) null))
              {
                num = 2;
                continue;
              }
              permission1 = (Permission) SecurityService.eLLLcDK7tACwryjx86B((object) this.permissionManagmentService, (object) permission, type);
              num = 8;
              continue;
            }
            num = 6;
            continue;
          case 8:
            if (!SecurityService.j261eNKWghJg5UqgTaf((object) permission1, (object) null))
            {
              num = 5;
              continue;
            }
            goto case 3;
          default:
            if (SecurityService.x3GF2DK6CLKtnwbBUfO((object) permission) != PermissionType.Global)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 1;
              continue;
            }
            goto label_12;
        }
      }
label_4:
      throw new ArgumentNullException((string) SecurityService.oRykG7KoJGvTmAX4TtM(-816108091 ^ -816106231));
label_10:
      return this.GetDelegateByType(type, permission) != null;
label_11:
      return false;
label_12:
      return true;
label_13:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227790945));
    }

    [PublicApiNodeId("SecurityServicesApi")]
    public void RunWithElevatedPrivilegies(Action action)
    {
      int num1 = 2;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_3;
          case 2:
            flag = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 0 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_16:
      return;
label_11:
      return;
label_3:
      try
      {
        flag = SecurityService.xTHdwNKtMrsnFwdbcHo((object) this.RunWithElevatedPrivilegiesService);
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (flag)
              {
                num2 = 2;
                continue;
              }
              break;
            case 2:
            case 3:
              SecurityService.UqI5PFKYDI5TQrmgaAt((object) action);
              num2 = 4;
              continue;
            case 4:
              goto label_6;
          }
          SecurityService.RBfVckKSEWNLkfV2ljX((object) this.RunWithElevatedPrivilegiesService, true);
          num2 = 3;
        }
label_6:;
      }
      finally
      {
        if (!flag)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_18;
              default:
                this.RunWithElevatedPrivilegiesService.Turned = false;
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_18:;
      }
    }

    /// <summary>Запуск без фильтрации по пермишеннам и удалению</summary>
    /// <param name="action"></param>
    [PublicApiNodeId("SecurityServicesApi")]
    public void RunWithElevatedPrivilegiesAndWithDeleted(Action action)
    {
      int num1 = 2;
      bool flag1;
      bool flag2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            flag2 = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 0 : 0;
            continue;
          case 2:
            flag1 = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_20;
          default:
            goto label_4;
        }
      }
label_20:
      return;
label_4:
      try
      {
        flag1 = SecurityService.xTHdwNKtMrsnFwdbcHo((object) this.RunWithElevatedPrivilegiesService);
        int num2 = 6;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              action();
              num2 = 3;
              continue;
            case 2:
              SecurityService.o8RednKVVoxXfSOmd5T((object) this.RunWithSoftDeletableService, true);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_19;
            case 4:
              if (flag2)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 6:
              if (flag1)
              {
                num2 = 8;
                continue;
              }
              goto case 7;
            case 7:
              this.RunWithElevatedPrivilegiesService.Turned = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
              continue;
            default:
              flag2 = SecurityService.wxPEi8Kyy4pcOTALhcs((object) this.RunWithSoftDeletableService);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 4 : 2;
              continue;
          }
        }
label_19:;
      }
      finally
      {
        int num3;
        if (flag2)
          num3 = 4;
        else
          goto label_21;
label_18:
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_21;
            case 2:
              goto label_25;
            case 3:
            case 4:
              if (!flag1)
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 0 : 0;
                continue;
              }
              goto label_25;
            default:
              SecurityService.RBfVckKSEWNLkfV2ljX((object) this.RunWithElevatedPrivilegiesService, false);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 1 : 2;
              continue;
          }
        }
label_25:
label_21:
        SecurityService.o8RednKVVoxXfSOmd5T((object) this.RunWithSoftDeletableService, false);
        num3 = 3;
        goto label_18;
      }
    }

    /// <summary>Запустить с обычными привилегиями</summary>
    /// <param name="action"></param>
    [PublicApiNodeId("SecurityServicesApi")]
    public void RunWithUsualPrivilegies(Action action)
    {
      int num1 = 2;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            goto label_3;
          case 2:
            flag = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_15:
      return;
label_10:
      return;
label_3:
      try
      {
        flag = SecurityService.xTHdwNKtMrsnFwdbcHo((object) this.RunWithElevatedPrivilegiesService);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.RunWithElevatedPrivilegiesService.Turned = false;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 0 : 0;
              continue;
            case 2:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 4 : 1;
                continue;
              }
              goto case 1;
            case 3:
              goto label_9;
            default:
              SecurityService.UqI5PFKYDI5TQrmgaAt((object) action);
              num2 = 3;
              continue;
          }
        }
label_9:;
      }
      finally
      {
        if (flag)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_17;
              default:
                this.RunWithElevatedPrivilegiesService.Turned = true;
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_17:;
      }
    }

    /// <summary>
    /// Запустить код от имени системного пользователя с повышенными привилегиями.
    /// Внутри производится авторизация под системным пользователем и вызывается метод RunWithElevatedPrivilegies.
    /// </summary>
    /// <param name="action"></param>
    [PublicApiNodeId("SecurityServicesApi")]
    public void RunBySystemUser(Action action)
    {
      int num1 = 2;
      EleWise.ELMA.Security.Models.IUser user1;
      IUser user2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            user1 = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
            num1 = 3;
            continue;
          case 2:
            user2 = (IUser) SecurityService.qTk9pNKZ8kt7OBRgaIm((object) this.authorizationImportService);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 1;
            continue;
          case 3:
            SecurityService.fWq5chKlATdjpHDgqxr((object) this.authorizationImportService, (object) user1);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 1 : 4;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_13;
        }
      }
label_14:
      return;
label_13:
      return;
label_5:
      try
      {
        this.RunWithElevatedPrivilegies(action);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (user2 == null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 0 : 0;
        else
          goto label_15;
label_11:
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_15;
            case 2:
            case 3:
              goto label_17;
            default:
              this.authorizationImportService.SignOut();
              num3 = 2;
              continue;
          }
        }
label_17:
label_15:
        this.authorizationImportService.SetAuthenticatedUserForRequest(user2);
        num3 = 3;
        goto label_11;
      }
    }

    /// <summary>Запустить от имени пользователя</summary>
    /// <param name="user"></param>
    /// <param name="action"></param>
    [PublicApiNodeId("SecurityServicesApi")]
    public void RunByUser(IUser user, Action action)
    {
      int num1 = 1;
      IUser user1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            user1 = (IUser) SecurityService.qTk9pNKZ8kt7OBRgaIm((object) this.authorizationImportService);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          case 3:
            goto label_4;
          default:
            this.authorizationImportService.SetAuthenticatedUserForRequest(user);
            num1 = 3;
            continue;
        }
      }
label_14:
      return;
label_4:
      try
      {
        SecurityService.UqI5PFKYDI5TQrmgaAt((object) action);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (user1 != null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 1 : 0;
        else
          goto label_13;
label_10:
        while (true)
        {
          switch (num3)
          {
            case 1:
              SecurityService.fWq5chKlATdjpHDgqxr((object) this.authorizationImportService, (object) user1);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_13;
            default:
              goto label_15;
          }
        }
label_15:
label_13:
        this.authorizationImportService.SignOut();
        num3 = 2;
        goto label_10;
      }
    }

    /// <summary>Получить пользователей обладающие привилегиями</summary>
    /// <param name="permissions"></param>
    /// <param name="typeUid"></param>
    /// <param name="entityId"></param>
    /// <returns></returns>
    [PublicApiNodeId("SecurityServicesApi")]
    public List<IUser> GetUsersByPermissions(
      Guid typeUid,
      long entityId,
      List<Guid> permissions)
    {
      IEntityManager manager = EntityHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid));
      object entity = (object) null;
      this.RunWithElevatedPrivilegies((Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              entity = SecurityService.\u003C\u003Ec__DisplayClass44_0.eLHiZdwoeWWipvOiyuVF((object) manager, (object) entityId);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      IEnumerable<IInstanceSettingsPermission> extensionPoints = ComponentManager.Current.GetExtensionPoints<IInstanceSettingsPermission>(false);
      System.Type type = entity.CastAsRealType().GetType();
      // ISSUE: reference to a compiler-generated method
      IInstanceSettingsPermission instanceSettingsPermission = extensionPoints.FirstOrDefault<IInstanceSettingsPermission>((Func<IInstanceSettingsPermission, bool>) (p => SecurityService.\u003C\u003Ec__DisplayClass44_0.WEgh9RwonMCiGlLHDKYE(type, p.EntityType)));
      EntityMetadata entityMetadata = instanceSettingsPermission != null ? (EntityMetadata) MetadataLoader.LoadMetadata(instanceSettingsPermission.PermissionHolderType) : throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370692683), (object) type.Name));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      string fieldName = ((SimpleTypeSettings) (entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => SecurityService.\u003C\u003Ec__DisplayClass44_0.OR6tVvwoHOD21VqhrLLp(SecurityService.\u003C\u003Ec__DisplayClass44_0.earOQvwoLTwF0VmGCAMh((object) p), SecurityService.\u003C\u003Ec__DisplayClass44_0.zcM92vwo2C5FgaOEdXvL((object) instanceSettingsPermission)))) ?? throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751467293 ^ -1751473673)) + instanceSettingsPermission.TargetPropetyName)).Settings).FieldName;
      List<string> permParams = new List<string>();
      int[] i = new int[1];
      permissions.ForEach((Action<Guid>) (p =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ++i[0];
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              permParams.Add((string) SecurityService.\u003C\u003Ec__DisplayClass44_0.WMjnmnwtukgiF5Qrg1yr(SecurityService.\u003C\u003Ec__DisplayClass44_0.Qjdybkwozjn0mglIiedC(1053060681 ^ 1053114595), (object) i[0]));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }));
      string queryString = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-201065280 ^ -201070672), (object) this.transformationProvider.Dialect.QuoteIfNeeded(entityMetadata.TableName), (object) this.transformationProvider.Dialect.QuoteIfNeeded(fieldName), (object) entityId, (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370693593), (IEnumerable<string>) permParams));
      if (instanceSettingsPermission.AdminPermission != (Permission) null)
      {
        foreach (IUserGroup userGroup in Locator.GetServiceNotNull<GroupPermissionManager>().GetGroupsByPermission(instanceSettingsPermission.AdminPermission))
          queryString += string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331075592), (object) userGroup.Id);
      }
      ISQLQuery sqlQuery = this.Session.CreateSQLQuery(queryString);
      i[0] = 0;
      foreach (Guid permission in permissions)
      {
        sqlQuery.SetParameter<Guid>(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1608977265), (object) i[0]), permission);
        ++i[0];
      }
      // ISSUE: reference to a compiler-generated method
      return sqlQuery.CleanUpCache(false).List().Cast<object>().Select<object, IUser>((Func<object, IUser>) (u => (IUser) ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityService.\u003C\u003Ec.TXQrRZwoMsnEmHG7dGek()).Load(Convert.ToInt64(u)))).ToList<IUser>();
    }

    private IPermissionsDelegate GetPermissionsDelegate(
      System.Type type,
      Permission permission)
    {
      return this.GetDelegateByType(type, permission) ?? throw new InvalidOperationException((string) SecurityService.CH5a7JK4s6fRH8bTDHJ(SecurityService.NA23ZGKfWvl6kFRRNpp(SecurityService.oRykG7KoJGvTmAX4TtM(~248518394 ^ -248515333)), (object) type, (object) permission));
    }

    private IPermissionsDelegate GetDelegateByType(
      System.Type type,
      Permission permission)
    {
      int num = 4;
      List<IPermissionsDelegate> list;
      System.Type type1;
      Permission permission1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (SecurityService.aJGAB6KcnOAqZivFoBd((object) list) != 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            type1 = type;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 3 : 6;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
            list = this.permissionsDelegates().Where<IPermissionsDelegate>((Func<IPermissionsDelegate, bool>) (p => p.CanCheckPermissions(type1, permission1))).ToList<IPermissionsDelegate>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 2 : 2;
            continue;
          case 6:
            permission1 = permission;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 5 : 3;
            continue;
          case 7:
            goto label_6;
          default:
            if (SecurityService.aJGAB6KcnOAqZivFoBd((object) list) == 1)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return list[0];
label_4:
      return (IPermissionsDelegate) new SecurityService.ChainPermissionsDelegate((IEnumerable<IPermissionsDelegate>) list);
label_6:
      return (IPermissionsDelegate) null;
    }

    internal static bool Vm9fYMKU6S9mrN6jGIV() => SecurityService.csampaKK66tf5jaqJ5i == null;

    internal static SecurityService oma3ymKR8eCfE0B3ltX() => SecurityService.csampaKK66tf5jaqJ5i;

    internal static object oRykG7KoJGvTmAX4TtM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xTHdwNKtMrsnFwdbcHo([In] object obj0) => ((RunWithElevatedPrivilegiesService) obj0).Turned;

    internal static bool jqUFi2KmYdV409oOpWq([In] object obj0, [In] object obj1) => (Permission) obj0 == (Permission) obj1;

    internal static PermissionType x3GF2DK6CLKtnwbBUfO([In] object obj0) => ((Permission) obj0).PermissionType;

    internal static object CZiRCBKkuYZVJEhAw4P([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static Guid Ugqx37KDeOSvp2GWqWg([In] object obj0) => ((Permission) obj0).Id;

    internal static bool Pmko4pKahskUtaPAbZl([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void crVlvxKx180EsICw1iI([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void T9kgesKCiqXqAKskIj4([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object iL31dSKiNfoca2jAE29([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).TableFunction((string) obj1, (string) obj2);

    internal static object a9VsTHK3ZS9FqrbiFf1([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object lflQpAKjsAABiOuANPb([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object b4qnP8KNGdJ3SDG60Wf([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static bool g5tqSMK0QpOCy1p68FB() => SecurityService.DisableSecurityBySettings;

    internal static object qTk9pNKZ8kt7OBRgaIm([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static bool Oiqwa7KAPcVqgg2ltlg([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static bool jqEnAVKsaFlFwxcpxg1(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] bool obj4)
    {
      return ((IPermissionsDelegate) obj0).HasPermission((IUser) obj1, (Permission) obj2, obj3, obj4);
    }

    internal static object eLLLcDK7tACwryjx86B([In] object obj0, [In] object obj1, [In] System.Type obj2) => (object) ((IPermissionManagmentService) obj0).GetPermissionForBase((Permission) obj1, obj2);

    internal static bool j261eNKWghJg5UqgTaf([In] object obj0, [In] object obj1) => (Permission) obj0 != (Permission) obj1;

    internal static object XnGTqlKr9Ownabswk4w([In] object obj0) => obj0.CastAsRealType();

    internal static void RBfVckKSEWNLkfV2ljX([In] object obj0, bool value) => ((RunWithElevatedPrivilegiesService) obj0).Turned = value;

    internal static void UqI5PFKYDI5TQrmgaAt([In] object obj0) => ((Action) obj0)();

    internal static bool wxPEi8Kyy4pcOTALhcs([In] object obj0) => ((RunWithSoftDeletableService) obj0).Turned;

    internal static void o8RednKVVoxXfSOmd5T([In] object obj0, [In] bool obj1) => ((RunWithSoftDeletableService) obj0).Turned = obj1;

    internal static void fWq5chKlATdjpHDgqxr([In] object obj0, [In] object obj1) => ((IAuthenticationService) obj0).SetAuthenticatedUserForRequest((IUser) obj1);

    internal static object NA23ZGKfWvl6kFRRNpp([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object CH5a7JK4s6fRH8bTDHJ([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static int aJGAB6KcnOAqZivFoBd([In] object obj0) => ((List<IPermissionsDelegate>) obj0).Count;

    private class ChainPermissionsDelegate : IPermissionsDelegate
    {
      private readonly IEnumerable<IPermissionsDelegate> delegates;
      internal static object ieR15VwoR4OHddTAwRTZ;

      public ChainPermissionsDelegate(IEnumerable<IPermissionsDelegate> delegates)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.delegates = delegates != null ? delegates : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(581409346 ^ 581350614));
      }

      public bool CanCheckPermissions(System.Type type, Permission permission) => throw new NotImplementedException();

      public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
      {
        int num = 2;
        IUser user1;
        Permission permission1;
        object target1;
        bool skipAdmin1;
        while (true)
        {
          switch (num)
          {
            case 1:
              user1 = user;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 0 : 4;
              continue;
            case 2:
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 1 : 1;
              continue;
            case 3:
              skipAdmin1 = skipAdmin;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 2 : 5;
              continue;
            case 4:
              permission1 = permission;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_2;
            default:
              target1 = target;
              num = 3;
              continue;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return this.delegates.Any<IPermissionsDelegate>((Func<IPermissionsDelegate, bool>) (d => SecurityService.ChainPermissionsDelegate.\u003C\u003Ec__DisplayClass3_0.eZF0vtw4tVQdhWCYmCEk((object) d, (object) user1, (object) permission1, target1, skipAdmin1)));
      }

      internal static bool qQ6GyHwooaIE18LZPvg7() => SecurityService.ChainPermissionsDelegate.ieR15VwoR4OHddTAwRTZ == null;

      internal static SecurityService.ChainPermissionsDelegate G97Lyswot1jBuxC5V77X() => (SecurityService.ChainPermissionsDelegate) SecurityService.ChainPermissionsDelegate.ieR15VwoR4OHddTAwRTZ;
    }
  }
}
