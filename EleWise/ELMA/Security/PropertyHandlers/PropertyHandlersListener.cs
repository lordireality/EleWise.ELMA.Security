// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PropertyHandlers.PropertyHandlersListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.PropertyHandlers
{
  /// <summary>
  /// Прослушиватель событий для основных обработчиков свойств
  /// </summary>
  /// <remarks>Используются обработчики: автор создания и изменения</remarks>
  [Component]
  public class PropertyHandlersListener : EntityEventsListener
  {
    private IContextBoundVariableService contextBoundVariableService;
    private static PropertyHandlersListener k3xRO7COXSQqIdhsAom;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService">IContextBoundVariableService</param>
    public PropertyHandlersListener(
      IContextBoundVariableService contextBoundVariableService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num = 7;
      PropertyMetadata propertyMetadata;
      IEntity entity;
      EntityMetadata entityMetadata;
      int index;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = Array.IndexOf<string>((string[]) PropertyHandlersListener.g8EUMkCe4gw2bR7sw6u(PropertyHandlersListener.y6dRyVCIOlFIJN44CCl((object) @event)), (string) PropertyHandlersListener.O7D0jXCnC8MwQGhqxvC((object) propertyMetadata));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          case 3:
            goto label_19;
          case 4:
            if (entityMetadata != null)
            {
              num = 14;
              continue;
            }
            goto label_19;
          case 5:
            PropertyHandlersActivation.ActivateOnCreate(entity);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 11 : 1;
            continue;
          case 6:
            if (entity != null)
            {
              num = 5;
              continue;
            }
            goto label_14;
          case 7:
            entity = PropertyHandlersListener.lK5nJ8CvfCL4uZbKn4O((object) @event) as IEntity;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 2 : 6;
            continue;
          case 8:
            goto label_17;
          case 9:
            PropertyHandlersListener.rfJSIDCLyP2VA3luZTc((object) @event)[index] = obj;
            num = 8;
            continue;
          case 10:
            if (propertyMetadata != null)
            {
              num = 12;
              continue;
            }
            goto label_17;
          case 11:
            entityMetadata = PropertyHandlersListener.irvsSVCqOGfxWmOarst(@event.Entity.GetType(), true, true) as EntityMetadata;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 4;
            continue;
          case 12:
            obj = PropertyHandlersListener.qDVhWQCJTO16021yHvy((object) entity, PropertyHandlersListener.wr5LmcCgpo79TmnGnHf((object) propertyMetadata));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 1 : 1;
            continue;
          case 13:
            goto label_12;
          case 14:
            List<PropertyMetadata> properties = entityMetadata.Properties;
            // ISSUE: reference to a compiler-generated field
            Func<PropertyMetadata, bool> func1 = PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<PropertyMetadata, bool> predicate1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate1 = (Func<PropertyMetadata, bool>) (p =>
              {
                List<PropertyHandlerInfo> handlers = p.Handlers;
                // ISSUE: reference to a compiler-generated field
                Func<PropertyHandlerInfo, bool> func2 = PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_1;
                Func<PropertyHandlerInfo, bool> predicate2;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_1 = predicate2 = (Func<PropertyHandlerInfo, bool>) (h => PropertyHandlersListener.\u003C\u003Ec.HGxjckwD8BpgvvhI2j71((object) h) == CreationAuthorPropertyHandler.UID);
                }
                else
                  goto label_1;
label_3:
                return handlers.FirstOrDefault<PropertyHandlerInfo>(predicate2) != null;
label_1:
                predicate2 = func2;
                goto label_3;
              });
            }
            else
              goto label_23;
label_22:
            propertyMetadata = properties.FirstOrDefault<PropertyMetadata>(predicate1);
            num = 10;
            continue;
label_23:
            predicate1 = func1;
            goto label_22;
          default:
            if (index >= 0)
            {
              num = 9;
              continue;
            }
            goto label_12;
        }
      }
label_12:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(19590779 ^ 19571923), PropertyHandlersListener.O7D0jXCnC8MwQGhqxvC((object) propertyMetadata)));
label_14:
      return false;
label_17:
      return false;
label_19:
      return false;
    }

    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num1 = 5;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        int num2 = num1;
        int index;
        EleWise.ELMA.Security.IUser currentUser;
        IEntity entity;
        EntityMetadata metadata;
        PreUpdateEvent event1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              PropertyHandlersListener.HKevQJCHMwnvIAEUTtB((object) entity, PropertyHandlersListener.wr5LmcCgpo79TmnGnHf((object) propertyMetadata), (object) currentUser);
              num2 = 10;
              continue;
            case 2:
              metadata = MetadataLoader.LoadMetadata(PropertyHandlersListener.lK5nJ8CvfCL4uZbKn4O((object) event1).GetType()) as EntityMetadata;
              num2 = 13;
              continue;
            case 3:
              goto label_5;
            case 4:
              event1 = @event;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 2 : 1;
              continue;
            case 5:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 4 : 1;
              continue;
            case 6:
              goto label_13;
            case 7:
              goto label_3;
            case 8:
            case 11:
              goto label_24;
            case 9:
              List<PropertyMetadata> properties = metadata.Properties;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyMetadata, bool> func = PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__3_0;
              Func<PropertyMetadata, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__3_0 = predicate = (Func<PropertyMetadata, bool>) (p => p.Handlers.FirstOrDefault<PropertyHandlerInfo>((Func<PropertyHandlerInfo, bool>) (h => PropertyHandlersListener.\u003C\u003Ec.iOuvMPwD5TDrL6xQIxjv(PropertyHandlersListener.\u003C\u003Ec.HGxjckwD8BpgvvhI2j71((object) h), ChangeAuthorPropertyHandler.UID))) != null);
              }
              else
                goto label_28;
label_27:
              propertyMetadata = properties.FirstOrDefault<PropertyMetadata>(predicate);
              num2 = 6;
              continue;
label_28:
              predicate = func;
              goto label_27;
            case 10:
              index = Array.IndexOf<string>((string[]) PropertyHandlersListener.g8EUMkCe4gw2bR7sw6u(PropertyHandlersListener.y6dRyVCIOlFIJN44CCl((object) event1)), (string) PropertyHandlersListener.O7D0jXCnC8MwQGhqxvC((object) propertyMetadata));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
              continue;
            case 12:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!((ComponentManager) PropertyHandlersListener.cdqB8vC2rEiPf06M2xM()).GetExtensionPoints<IChangePropertyHandlerIgnoreProvider>().Where<IChangePropertyHandlerIgnoreProvider>((Func<IChangePropertyHandlerIgnoreProvider, bool>) (p => PropertyHandlersListener.\u003C\u003Ec__DisplayClass3_0.hEjRgNwD1Y542b2X20dP((object) p, PropertyHandlersListener.\u003C\u003Ec__DisplayClass3_0.I5G1vlwD9QAIpttGBKcg((object) metadata)))).Select<IChangePropertyHandlerIgnoreProvider, bool>((Func<IChangePropertyHandlerIgnoreProvider, bool>) (p => PropertyHandlersListener.\u003C\u003Ec__DisplayClass3_0.llJM3QwDM7ecE2atrJQF((object) p, (object) event1))).ToList<bool>().Contains(true))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 2 : 18;
                continue;
              }
              goto label_22;
            case 13:
              entity = PropertyHandlersListener.lK5nJ8CvfCL4uZbKn4O((object) event1) as IEntity;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 14 : 14;
              continue;
            case 14:
              if (metadata == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 11 : 2;
                continue;
              }
              goto case 16;
            case 15:
              goto label_22;
            case 16:
              if (entity != null)
              {
                num2 = 9;
                continue;
              }
              goto label_24;
            case 17:
              goto label_4;
            case 18:
              currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.IUser>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 0 : 1;
              continue;
            default:
              if (index >= 0)
              {
                num2 = 17;
                continue;
              }
              goto label_3;
          }
        }
label_4:
        PropertyHandlersListener.NYnJFQiuQOM143L2aTu((object) event1)[index] = (object) currentUser;
        num1 = 3;
        continue;
label_13:
        if (propertyMetadata != null)
          num1 = 12;
        else
          goto label_5;
      }
label_3:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) PropertyHandlersListener.g5B77JCzdXJA7fmnQbW(-522456341 ^ -522471357), PropertyHandlersListener.O7D0jXCnC8MwQGhqxvC((object) propertyMetadata)));
label_5:
      return false;
label_22:
      return false;
label_24:
      return false;
    }

    public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
    {
      int num1 = 4;
      IUserGroup group;
      uint? maxGroupUsersCount;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          UntypedISetProxy groupUsers;
          UntypedISetProxy untypedIsetProxy1;
          UntypedISetProxy untypedIsetProxy2;
          IUserGroup userGroup;
          switch (num2)
          {
            case 1:
              goto label_31;
            case 2:
              if ((long) UserGroupManager.GetLicensedGroupUsers((IEnumerable) groupUsers) <= (long) maxGroupUsersCount.Value)
              {
                num2 = 21;
                continue;
              }
              goto label_15;
            case 3:
              if (PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event) == null)
                goto case 15;
              else
                goto label_26;
            case 4:
              PropertyHandlersListener.qBJ79YiwUObMjZ4Qe8D((object) this, (object) @event);
              num2 = 3;
              continue;
            case 5:
              untypedIsetProxy1 = new UntypedISetProxy(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 4 : 13;
              continue;
            case 6:
              goto label_30;
            case 7:
              if (PropertyHandlersListener.wNVwSyitEQjC6cyCNOM((object) untypedIsetProxy2) <= 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 1 : 1;
                continue;
              }
              goto label_38;
            case 8:
              goto label_29;
            case 9:
              goto label_19;
            case 10:
              maxGroupUsersCount = ((UserGroupManager) PropertyHandlersListener.ELXBNPiUTP0FZimLnkq()).GetMaxGroupUsersCount(group);
              num2 = 20;
              continue;
            case 11:
              if (untypedIsetProxy2 != null)
              {
                num2 = 7;
                continue;
              }
              goto label_5;
            case 12:
              if (group == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 4 : 23;
                continue;
              }
              goto case 10;
            case 13:
              if (untypedIsetProxy1 != null)
                goto case 26;
              else
                goto label_44;
            case 14:
              userGroup = PropertyHandlersListener.rfL9xViKQZ9nRFBnPtG(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event)) as IUserGroup;
              break;
            case 15:
              userGroup = (IUserGroup) null;
              break;
            case 16:
              goto label_39;
            case 17:
              untypedIsetProxy2 = new UntypedISetProxy(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event));
              num2 = 11;
              continue;
            case 18:
            case 21:
            case 30:
              if (!((string) PropertyHandlersListener.HfqweQiR8M5IYd6VLBe(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event)) == (string) PropertyHandlersListener.g5B77JCzdXJA7fmnQbW(--353012470 ^ 353026344)))
              {
                num2 = 22;
                continue;
              }
              goto case 5;
            case 19:
              groupUsers = new UntypedISetProxy((object) @event.Collection);
              num2 = 27;
              continue;
            case 20:
              if (!maxGroupUsersCount.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 6 : 4;
                continue;
              }
              goto case 25;
            case 22:
            case 24:
              if (!PropertyHandlersListener.v6OVLcioyMLIeHZmk2p(PropertyHandlersListener.HfqweQiR8M5IYd6VLBe(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1677147940 ^ 1677161444)))
              {
                num2 = 8;
                continue;
              }
              goto case 17;
            case 23:
              goto label_18;
            case 25:
              if (PropertyHandlersListener.HfqweQiR8M5IYd6VLBe(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event)) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 17 : 29;
                continue;
              }
              goto label_37;
            case 26:
              if (PropertyHandlersListener.wNVwSyitEQjC6cyCNOM((object) untypedIsetProxy1) > 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 9 : 8;
                continue;
              }
              goto case 22;
            case 27:
              if (groupUsers == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 18 : 8;
                continue;
              }
              goto case 2;
            case 28:
              goto label_38;
            case 29:
              if (!PropertyHandlersListener.v6OVLcioyMLIeHZmk2p(PropertyHandlersListener.HfqweQiR8M5IYd6VLBe(PropertyHandlersListener.engrNkibgHFfZ5VQAhD((object) @event)), PropertyHandlersListener.g5B77JCzdXJA7fmnQbW(1530848604 ^ 1530834526)))
              {
                num2 = 30;
                continue;
              }
              goto case 19;
            default:
              goto label_15;
          }
          group = userGroup;
          num2 = 12;
        }
label_26:
        num1 = 14;
        continue;
label_44:
        num1 = 24;
      }
label_31:
      return;
label_30:
      return;
label_29:
      return;
label_39:
      return;
label_18:
      return;
label_5:
      return;
label_15:
      throw new LicenseException(EleWise.ELMA.SR.T((string) PropertyHandlersListener.g5B77JCzdXJA7fmnQbW(-1540570615 - 1746246777 ^ 1008168654), (object) group.Name, (object) maxGroupUsersCount.Value));
label_19:
      throw new LicenseException((string) PropertyHandlersListener.uaMp9ji6LTk6R0KNdrB(PropertyHandlersListener.g5B77JCzdXJA7fmnQbW(--306199571 ^ 306212929), (object) new object[1]
      {
        PropertyHandlersListener.PpqgGoimebhufOWDde1((object) group)
      }));
label_38:
      throw new LicenseException((string) PropertyHandlersListener.uaMp9ji6LTk6R0KNdrB((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447299615), (object) new object[1]
      {
        PropertyHandlersListener.PpqgGoimebhufOWDde1((object) group)
      }));
label_37:;
    }

    internal static bool XsXOp1CTTZgPjeK3J0U() => PropertyHandlersListener.k3xRO7COXSQqIdhsAom == null;

    internal static PropertyHandlersListener NsrMMtCFgyBSit5iDgo() => PropertyHandlersListener.k3xRO7COXSQqIdhsAom;

    internal static object lK5nJ8CvfCL4uZbKn4O([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static object irvsSVCqOGfxWmOarst([In] Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static Guid wr5LmcCgpo79TmnGnHf([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object qDVhWQCJTO16021yHvy([In] object obj0, [In] Guid obj1) => ((IEntity) obj0).GetPropertyValue(obj1);

    internal static object y6dRyVCIOlFIJN44CCl([In] object obj0) => (object) ((AbstractPreDatabaseOperationEvent) obj0).Persister;

    internal static object g8EUMkCe4gw2bR7sw6u([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyNames;

    internal static object O7D0jXCnC8MwQGhqxvC([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object rfJSIDCLyP2VA3luZTc([In] object obj0) => (object) ((PreInsertEvent) obj0).State;

    internal static object cdqB8vC2rEiPf06M2xM() => (object) ComponentManager.Current;

    internal static void HKevQJCHMwnvIAEUTtB([In] object obj0, [In] Guid obj1, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(obj1, obj2);

    internal static object g5B77JCzdXJA7fmnQbW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NYnJFQiuQOM143L2aTu([In] object obj0) => (object) ((PreUpdateEvent) obj0).State;

    internal static void qBJ79YiwUObMjZ4Qe8D([In] object obj0, [In] object obj1) => __nonvirtual (((EntityEventsListener) obj0).OnPreUpdateCollection((PreCollectionUpdateEvent) obj1));

    internal static object engrNkibgHFfZ5VQAhD([In] object obj0) => (object) ((AbstractCollectionEvent) obj0).Collection;

    internal static object rfL9xViKQZ9nRFBnPtG([In] object obj0) => ((IPersistentCollection) obj0).Owner;

    internal static object ELXBNPiUTP0FZimLnkq() => (object) UserGroupManager.Instance;

    internal static object HfqweQiR8M5IYd6VLBe([In] object obj0) => (object) ((IPersistentCollection) obj0).Role;

    internal static bool v6OVLcioyMLIeHZmk2p([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static int wNVwSyitEQjC6cyCNOM([In] object obj0) => ((UntypedISetProxy) obj0).Count;

    internal static object PpqgGoimebhufOWDde1([In] object obj0) => (object) ((IUserGroup) obj0).Name;

    internal static object uaMp9ji6LTk6R0KNdrB([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);
  }
}
