// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.API.Service.v1.SecurityService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.API.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace EleWise.ELMA.Security.API.Service.v1
{
  [Component]
  [ServiceKnownType("GetGlobalKnownTypes", typeof (ServiceKnownTypeHelper))]
  [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
  [Uid("{7D7AC1D8-68EA-4946-A9AC-EA2258B67626}")]
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = 2147483647)]
  public class SecurityService : ISecurityService, IPublicAPIWebService
  {
    public const string GuidS = "{7D7AC1D8-68EA-4946-A9AC-EA2258B67626}";
    public static Guid Guid;
    private static SecurityService cXTIiPJF2FwWhrHa1Uk;

    public ILogger Logger => (ILogger) SecurityService.FPNfQrJgu5l5SC4H3WL();

    public SubordinateUsersResponse GetSubordinateUsers()
    {
      SubordinateUsersResponse subordinateUsers;
      switch (1)
      {
        case 1:
          try
          {
            EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0)
              num = 0;
            IEnumerable<EleWise.ELMA.Security.Models.IUser> source;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                case 2:
                  SubordinateUsersResponse subordinateUsersResponse = new SubordinateUsersResponse();
                  SecurityService.o3rAJUJIy6w7bZWKWsC((object) subordinateUsersResponse, (object) source.Select<EleWise.ELMA.Security.Models.IUser, long>((Func<EleWise.ELMA.Security.Models.IUser, long>) (u => u.Id)).ToArray<long>());
                  subordinateUsers = subordinateUsersResponse;
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 1 : 1;
                  continue;
                default:
                  IEnumerable<EleWise.ELMA.Security.Models.IUser> subordinateByUser = ((UserManager) SecurityService.KL0SO7JJH0m0nghggQy()).GetSubordinateByUser(currentUser);
                  // ISSUE: reference to a compiler-generated field
                  Func<EleWise.ELMA.Security.Models.IUser, bool> func = SecurityService.\u003C\u003Ec.\u003C\u003E9__4_0;
                  Func<EleWise.ELMA.Security.Models.IUser, bool> predicate;
                  if (func == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    SecurityService.\u003C\u003Ec.\u003C\u003E9__4_0 = predicate = (Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => SecurityService.\u003C\u003Ec.Cffpg7wy5qILZMBQZhNX((object) u) == UserStatus.Active);
                  }
                  else
                    goto label_18;
label_7:
                  source = subordinateByUser.Where<EleWise.ELMA.Security.Models.IUser>(predicate);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 2;
                  continue;
label_18:
                  predicate = func;
                  goto label_7;
              }
            }
          }
          catch (FaultException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0)
              num = 0;
            switch (num)
            {
              default:
                throw;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_17;
                default:
                  this.Logger.Error((object) ex);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 1 : 0;
                  continue;
              }
            }
label_17:
            throw PublicServiceException.CreateWebFault((string) SecurityService.SRhN7jJecqNDohRMwV3((object) ex), 500);
          }
      }
label_1:
      return subordinateUsers;
    }

    public bool AddUserToGroup(long userId, Guid userGroupUid)
    {
      bool group;
      switch (1)
      {
        case 1:
          try
          {
            int num = 2;
            IUserGroup userGroup;
            EleWise.ELMA.Security.Models.IUser user;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                case 2:
                  if (SecurityService.rM0X7RJn78amqlUtSGB((object) Locator.GetServiceNotNull<EleWise.ELMA.Security.ISecurityService>(), (object) PermissionProvider.AccessManagmentPermission))
                  {
                    userGroup = UserGroupManager.Instance.Load(userGroupUid);
                    num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 0 : 0;
                    continue;
                  }
                  num = 6;
                  continue;
                case 3:
                  userGroup.Users.Add(user);
                  num = 5;
                  continue;
                case 4:
                  if (!userGroup.Users.All<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => u.Id != user.Id)))
                  {
                    num = 7;
                    continue;
                  }
                  goto case 3;
                case 5:
                  SecurityService.KC1xGcJHyQU7AFlTlCw((object) userGroup);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 8 : 7;
                  continue;
                case 6:
                  goto label_5;
                case 7:
                case 8:
                  group = true;
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 1 : 1;
                  continue;
                default:
                  user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecurityService.KL0SO7JJH0m0nghggQy()).Load(userId);
                  num = 4;
                  continue;
              }
            }
label_5:
            throw new SecurityException((string) SecurityService.BnPjCkJ2luePcpc3REQ(SecurityService.oWQvbZJLeobayGnETla(-1596821387 ^ -1596755869)));
          }
          catch (FaultException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0)
              num = 0;
            switch (num)
            {
              default:
                throw;
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  SecurityService.N9KFAGJzLQAhQ6ZPZOe((object) this.Logger, (object) ex);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_22;
              }
            }
label_22:
            throw SecurityService.W35n5uIuFL7V0qyPLKa(SecurityService.SRhN7jJecqNDohRMwV3((object) ex), 500);
          }
      }
label_1:
      return group;
    }

    public SecurityService()
    {
      SecurityService.hudDpfIwln9E3Gw9fBl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SecurityService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SecurityService.hudDpfIwln9E3Gw9fBl();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SecurityService.Guid = new Guid((string) SecurityService.oWQvbZJLeobayGnETla(617026523 ^ 616960817));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object FPNfQrJgu5l5SC4H3WL() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static object KL0SO7JJH0m0nghggQy() => (object) UserManager.Instance;

    internal static void o3rAJUJIy6w7bZWKWsC([In] object obj0, [In] object obj1) => ((SubordinateUsersResponse) obj0).Ids = (long[]) obj1;

    internal static object SRhN7jJecqNDohRMwV3([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static bool ogu37wJvufqgUJFiAM5() => SecurityService.cXTIiPJF2FwWhrHa1Uk == null;

    internal static SecurityService JWLVdlJqWKydLawCMlx() => SecurityService.cXTIiPJF2FwWhrHa1Uk;

    internal static bool rM0X7RJn78amqlUtSGB([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.ISecurityService) obj0).HasPermission((Permission) obj1);

    internal static object oWQvbZJLeobayGnETla(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BnPjCkJ2luePcpc3REQ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void KC1xGcJHyQU7AFlTlCw([In] object obj0) => ((IEntity) obj0).Save();

    internal static void N9KFAGJzLQAhQ6ZPZOe([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object W35n5uIuFL7V0qyPLKa([In] object obj0, [In] int obj1) => (object) PublicServiceException.CreateWebFault((string) obj0, obj1);

    internal static void hudDpfIwln9E3Gw9fBl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
