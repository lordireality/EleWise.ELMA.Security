// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PropertyHandlers.PropertyHandlersActivation
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.PropertyHandlers
{
  /// <summary>
  /// Перехватчик активации сущностей.
  /// Активирует свойство Автор создания
  /// </summary>
  [Component]
  internal class PropertyHandlersActivation : IEntityActivationHandler
  {
    private static PropertyHandlersActivation BlQl6oCGK81oQ0ZR5PQ;

    /// <summary>Заполнить свойства сущности</summary>
    /// <param name="entity">Сущность</param>
    public static void ActivateOnCreate(IEntity entity)
    {
      int num = 6;
      IUser currentUser;
      PropertyMetadata propertyMetadata;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 0 : 0;
            continue;
          case 2:
            if (PropertyHandlersActivation.RSWngiChOxUxuf9Kb3e((object) entity, PropertyHandlersActivation.ED7re2CMHR6b5r4f4nU((object) propertyMetadata)) == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 1 : 0;
              continue;
            }
            goto label_10;
          case 3:
            goto label_3;
          case 4:
            goto label_13;
          case 5:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 8;
              continue;
            }
            goto label_16;
          case 6:
            entityMetadata = PropertyHandlersActivation.CnLniKC148LtLlTs2nZ(entity.GetType(), true, true) as EntityMetadata;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 5 : 2;
            continue;
          case 7:
            if (propertyMetadata == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          case 8:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Handlers.FirstOrDefault<PropertyHandlerInfo>((Func<PropertyHandlerInfo, bool>) (h => PropertyHandlersActivation.\u003C\u003Ec.FX4tHHwDfg3WJnY46Y7X(PropertyHandlersActivation.\u003C\u003Ec.VodxphwDltAXhdFRgx1y((object) h), CreationAuthorPropertyHandler.UID))) != null));
            num = 7;
            continue;
          case 9:
            goto label_2;
          default:
            PropertyHandlersActivation.Edl1vHCBxPsPOt7xLHD((object) entity, PropertyHandlersActivation.ED7re2CMHR6b5r4f4nU((object) propertyMetadata), (object) currentUser);
            num = 9;
            continue;
        }
      }
label_3:
      return;
label_13:
      return;
label_2:
      return;
label_10:
      return;
label_16:;
    }

    public void OnActivating(IEntity entity) => PropertyHandlersActivation.FBkke2CpPpYvqIKKG2C((object) entity);

    public void OnActivated(IEntity entity)
    {
    }

    public PropertyHandlersActivation()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object CnLniKC148LtLlTs2nZ([In] Type obj0, [In] bool obj1, [In] bool obj2) => (object) MetadataLoader.LoadMetadata(obj0, obj1, obj2);

    internal static Guid ED7re2CMHR6b5r4f4nU([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object RSWngiChOxUxuf9Kb3e([In] object obj0, [In] Guid obj1) => ((IEntity) obj0).GetPropertyValue(obj1);

    internal static void Edl1vHCBxPsPOt7xLHD([In] object obj0, [In] Guid obj1, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(obj1, obj2);

    internal static bool l2ApZcCXu4CY7DMpJ0W() => PropertyHandlersActivation.BlQl6oCGK81oQ0ZR5PQ == null;

    internal static PropertyHandlersActivation WpCQulC9wxrhFEnCZ0c() => PropertyHandlersActivation.BlQl6oCGK81oQ0ZR5PQ;

    internal static void FBkke2CpPpYvqIKKG2C([In] object obj0) => PropertyHandlersActivation.ActivateOnCreate((IEntity) obj0);
  }
}
