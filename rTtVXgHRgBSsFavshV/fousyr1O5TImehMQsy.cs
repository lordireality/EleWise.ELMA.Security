// Decompiled with JetBrains decompiler
// Type: rTtVXgHRgBSsFavshV.fousyr1O5TImehMQsy
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace rTtVXgHRgBSsFavshV
{
  internal class fousyr1O5TImehMQsy
  {
    internal static Module fou1syrO5;
    internal static fousyr1O5TImehMQsy XNd81rwcJ4yTKDWYGkSh;

    internal static void yFdwQDpXFuO(int typemdt)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        FieldInfo[] fields;
        int index;
        FieldInfo fieldInfo;
        Type type;
        MethodInfo methodInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
              if (index < fields.Length)
              {
                num2 = 5;
                continue;
              }
              goto label_6;
            case 2:
              fousyr1O5TImehMQsy.OH1egUwcz7kHL1XMyZmK((object) fieldInfo, (object) null, (object) (MulticastDelegate) fousyr1O5TImehMQsy.tp4nSAwcHRPFynS84kfb(type, (object) methodInfo));
              num2 = 4;
              continue;
            case 3:
              index = 0;
              num2 = !fousyr1O5TImehMQsy.EOprtKwcIwp5hpPZqg5K() ? 8 : 8;
              continue;
            case 4:
              ++index;
              num2 = fousyr1O5TImehMQsy.EOprtKwcIwp5hpPZqg5K() ? 1 : 1;
              continue;
            case 6:
              goto label_4;
            case 7:
              type = fousyr1O5TImehMQsy.ndJZNGwcnILdJI4us7Sp((object) fousyr1O5TImehMQsy.fou1syrO5, 33554432 + typemdt);
              num2 = 6;
              continue;
            case 9:
              methodInfo = (MethodInfo) fousyr1O5TImehMQsy.m5mJr2wc2bDmjD73REgj((object) fousyr1O5TImehMQsy.fou1syrO5, fousyr1O5TImehMQsy.JSkRbawcLd2A8pkwUQyr((object) fieldInfo) + 100663296);
              num2 = 2;
              continue;
            case 10:
              goto label_12;
            default:
              goto label_3;
          }
        }
label_3:
        fieldInfo = fields[index];
        num1 = 9;
        continue;
label_4:
        fields = type.GetFields();
        num1 = 3;
      }
label_12:
      return;
label_6:;
    }

    public fousyr1O5TImehMQsy()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (false)
        num = 0;
      switch (num)
      {
      }
    }

    static fousyr1O5TImehMQsy()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            fousyr1O5TImehMQsy.JaYb54wPuyjbXu0Qwe2l();
            num = false ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            fousyr1O5TImehMQsy.fou1syrO5 = (Module) fousyr1O5TImehMQsy.ETX7ELwPbtShygruLTYB((object) fousyr1O5TImehMQsy.Yp3bPRwPwe7wVlFYIbRe(__typeref (fousyr1O5TImehMQsy)).Assembly);
            num = true ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static Type ndJZNGwcnILdJI4us7Sp([In] object obj0, [In] int obj1) => ((Module) obj0).ResolveType(obj1);

    internal static int JSkRbawcLd2A8pkwUQyr([In] object obj0) => ((MemberInfo) obj0).MetadataToken;

    internal static object m5mJr2wc2bDmjD73REgj([In] object obj0, [In] int obj1) => (object) ((Module) obj0).ResolveMethod(obj1);

    internal static object tp4nSAwcHRPFynS84kfb([In] Type obj0, [In] object obj1) => (object) Delegate.CreateDelegate(obj0, (MethodInfo) obj1);

    internal static void OH1egUwcz7kHL1XMyZmK([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

    internal static bool EOprtKwcIwp5hpPZqg5K() => fousyr1O5TImehMQsy.XNd81rwcJ4yTKDWYGkSh == null;

    internal static fousyr1O5TImehMQsy pX8oBiwceYtVCbloT7eO() => fousyr1O5TImehMQsy.XNd81rwcJ4yTKDWYGkSh;

    internal static void JaYb54wPuyjbXu0Qwe2l() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static Type Yp3bPRwPwe7wVlFYIbRe([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ETX7ELwPbtShygruLTYB([In] object obj0) => (object) ((Assembly) obj0).ManifestModule;

    internal delegate void SFU4mbT3GMret7THonf(object o);
  }
}
