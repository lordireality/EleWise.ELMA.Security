// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Models.RefreshTokenMap
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.JWT.Models
{
  /// <summary>Мапинг NHibernate для класса RefreshToken</summary>
  internal sealed class RefreshTokenMap : ClassMapping<RefreshToken>
  {
    internal static RefreshTokenMap MpHhGFqf4YwSWcIs1MJ;

    /// <summary>Ctor</summary>
    public RefreshTokenMap()
    {
      RefreshTokenMap.zSLTJKqPXXudawlPcrd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_8;
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(RefreshTokenMap.ancGrWq5CNClVC9FkTZ(__typeref (RefreshToken)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--306199571 ^ 306189095));
            // ISSUE: method reference
            this.Property<long>(Expression.Lambda<Func<RefreshToken, long>>((Expression) RefreshTokenMap.XDVHcaqGBm4aWPS4kwD((object) parameterExpression1, (object) (MethodInfo) RefreshTokenMap.JrxT8sqE2P8O6DTr2wJ(__methodref (RefreshToken.get_UserId))), parameterExpression1));
            num1 = 2;
            continue;
          case 2:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = Expression.Parameter(RefreshTokenMap.ancGrWq5CNClVC9FkTZ(__typeref (RefreshToken)), (string) RefreshTokenMap.xCPDgyqQ3nRIggtJrMo(1013954274 ^ 1013946838));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<RefreshToken, string>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) RefreshTokenMap.JrxT8sqE2P8O6DTr2wJ(__methodref (RefreshToken.get_ApplicationToken))), parameterExpression2));
            num1 = 4;
            continue;
          case 3:
            RefreshTokenMap.rlJpyLq8M9AVs08FP2V((object) this, RefreshTokenMap.xCPDgyqQ3nRIggtJrMo(784628100 ^ 784628678));
            num1 = 5;
            continue;
          case 4:
            ParameterExpression parameterExpression3;
            // ISSUE: method reference
            this.Property<DateTime>(Expression.Lambda<Func<RefreshToken, DateTime>>((Expression) RefreshTokenMap.XDVHcaqGBm4aWPS4kwD((object) parameterExpression3, (object) (MethodInfo) RefreshTokenMap.JrxT8sqE2P8O6DTr2wJ(__methodref (RefreshToken.get_ExpireDate))), parameterExpression3), (Action<IPropertyMapper>) (p => p.Type<DateTimeNHType>()));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
            continue;
          case 5:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) RefreshTokenMap.yR8M0PqdUfkgwpX8gVI(RefreshTokenMap.ancGrWq5CNClVC9FkTZ(__typeref (RefreshToken)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1115268484 ^ -1115261624));
            // ISSUE: method reference
            Expression<Func<RefreshToken, Guid>> idProperty = Expression.Lambda<Func<RefreshToken, Guid>>((Expression) RefreshTokenMap.XDVHcaqGBm4aWPS4kwD((object) parameterExpression4, (object) (MethodInfo) RefreshTokenMap.JrxT8sqE2P8O6DTr2wJ(__methodref (RefreshToken.get_Uid))), parameterExpression4);
            // ISSUE: reference to a compiler-generated field
            Action<IIdMapper> action = RefreshTokenMap.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IIdMapper> idMapper;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              RefreshTokenMap.\u003C\u003Ec.\u003C\u003E9__0_1 = idMapper = (Action<IIdMapper>) (i =>
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
                      RefreshTokenMap.\u003C\u003Ec.F4MxLFwy4e1mD7eKGCdA((object) i, (object) Generators.GuidComb);
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_12;
label_10:
            this.Id<Guid>(idProperty, idMapper);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 1;
            continue;
label_12:
            idMapper = action;
            goto label_10;
          default:
            goto label_3;
        }
      }
label_8:
      return;
label_3:;
    }

    internal static void zSLTJKqPXXudawlPcrd() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object xCPDgyqQ3nRIggtJrMo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void rlJpyLq8M9AVs08FP2V([In] object obj0, [In] object obj1) => __nonvirtual (((ClassCustomizer<RefreshToken>) obj0).Table((string) obj1));

    internal static Type ancGrWq5CNClVC9FkTZ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object yR8M0PqdUfkgwpX8gVI([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object JrxT8sqE2P8O6DTr2wJ([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object XDVHcaqGBm4aWPS4kwD([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool NGVSpdq4msUU5jKa2Pa() => RefreshTokenMap.MpHhGFqf4YwSWcIs1MJ == null;

    internal static RefreshTokenMap sq8qe6qcGqEZlMV1PUe() => RefreshTokenMap.MpHhGFqf4YwSWcIs1MJ;
  }
}
