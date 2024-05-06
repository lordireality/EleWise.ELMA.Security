// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.AuthTokenMap
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>Мапинг NHibernate для класса AuthToken</summary>
  internal class AuthTokenMap : ClassMapping<AuthToken>
  {
    internal static AuthTokenMap yLoNEvf2EAAOILquJdO;

    /// <summary>Ctor</summary>
    public AuthTokenMap()
    {
      AuthTokenMap.msA97x4uPrbecnpt3bl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.Table(z2jc63fLkugS1X8Q9N.tE1kD1vbB(384582979 ^ 384583679));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
            continue;
          case 2:
            ParameterExpression parameterExpression1 = (ParameterExpression) AuthTokenMap.PeJH7I4RV5XpfUcufBL(typeof (AuthToken), AuthTokenMap.RCpNAL4b85wCprN1IA2(1687460816 ^ 1687467236));
            // ISSUE: method reference
            Expression<Func<AuthToken, DateTime>> property = Expression.Lambda<Func<AuthToken, DateTime>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) AuthTokenMap.cvgu8L4Uc5v5p9KeWoy(__methodref (AuthToken.get_ExpireDate))), parameterExpression1);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action = AuthTokenMap.\u003C\u003Ec.\u003C\u003E9__0_4;
            Action<IPropertyMapper> mapping;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              AuthTokenMap.\u003C\u003Ec.\u003C\u003E9__0_4 = mapping = (Action<IPropertyMapper>) (p => p.Type<DateTimeNHType>());
            }
            else
              goto label_10;
label_9:
            this.Property<DateTime>(property, mapping);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 3 : 2;
            continue;
label_10:
            mapping = action;
            goto label_9;
          case 3:
            goto label_7;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = Expression.Parameter(AuthTokenMap.Lgq8aU4wQSrNB4fv3av(__typeref (AuthToken)), (string) AuthTokenMap.RCpNAL4b85wCprN1IA2(-1702973981 - 773209001 ^ 1818778894));
            // ISSUE: method reference
            this.Property<long>(Expression.Lambda<Func<AuthToken, long>>((Expression) AuthTokenMap.gVsJVt4KhjQIt13NOGC((object) parameterExpression2, (object) (MethodInfo) AuthTokenMap.cvgu8L4Uc5v5p9KeWoy(__methodref (AuthToken.get_UserId))), parameterExpression2));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 2 : 2;
            continue;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = Expression.Parameter(AuthTokenMap.Lgq8aU4wQSrNB4fv3av(__typeref (AuthToken)), (string) AuthTokenMap.RCpNAL4b85wCprN1IA2(~-272519830 ^ 272530849));
            // ISSUE: method reference
            this.Id<Guid>(Expression.Lambda<Func<AuthToken, Guid>>((Expression) AuthTokenMap.gVsJVt4KhjQIt13NOGC((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AuthToken.get_Uid))), parameterExpression3), (Action<IIdMapper>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    AuthTokenMap.\u003C\u003Ec.dXxT3hwZk4Lr8i58Dva4((object) i, (object) Generators.GuidComb);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 4 : 1;
            continue;
        }
      }
label_7:;
    }

    internal static void msA97x4uPrbecnpt3bl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static Type Lgq8aU4wQSrNB4fv3av([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object RCpNAL4b85wCprN1IA2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object gVsJVt4KhjQIt13NOGC([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object cvgu8L4Uc5v5p9KeWoy([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object PeJH7I4RV5XpfUcufBL([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static bool fvlqQAfHTy1mOQLAIeR() => AuthTokenMap.yLoNEvf2EAAOILquJdO == null;

    internal static AuthTokenMap skZl0sfzEf0k6kDp3Om() => AuthTokenMap.yLoNEvf2EAAOILquJdO;
  }
}
