// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.OrganizationModelPublishWarning
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Security
{
  /// <summary>Ошибка публикации оргструктуры</summary>
  [Serializable]
  public class OrganizationModelPublishWarning : Exception
  {
    internal static OrganizationModelPublishWarning hFDFynKeZFLMjej6ONw;

    public OrganizationModelPublishWarning()
    {
      OrganizationModelPublishWarning.sRuCaTK2snGQ3Q1ASmt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OrganizationModelPublishWarning(string message)
    {
      OrganizationModelPublishWarning.sRuCaTK2snGQ3Q1ASmt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OrganizationModelPublishWarning(string message, Exception innerException)
    {
      OrganizationModelPublishWarning.sRuCaTK2snGQ3Q1ASmt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected OrganizationModelPublishWarning(SerializationInfo info, StreamingContext context)
    {
      OrganizationModelPublishWarning.sRuCaTK2snGQ3Q1ASmt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.mess = (List<OrganizationValidationMessage>) OrganizationModelPublishWarning.p6XcWkKz9R1cGZKtEfy((object) info, OrganizationModelPublishWarning.hQIxeqKHbNmuN0qbGBJ(1534797734 ^ 1534802042), typeof (List<OrganizationValidationMessage>));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Идентификаторы элементов оргструктуры, из-за которых возникла ошибка
    /// </summary>
    public List<OrganizationValidationMessage> mess { get; set; }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.GetObjectData(info, context);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            info.AddValue((string) OrganizationModelPublishWarning.hQIxeqKHbNmuN0qbGBJ(4869926 >> 3 ^ 611896), (object) this.mess);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void sRuCaTK2snGQ3Q1ASmt() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool a5UROFKnBZFtBn8SebE() => OrganizationModelPublishWarning.hFDFynKeZFLMjej6ONw == null;

    internal static OrganizationModelPublishWarning R7tbq2KLCcs2EI7eYWK() => OrganizationModelPublishWarning.hFDFynKeZFLMjej6ONw;

    internal static object hQIxeqKHbNmuN0qbGBJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object p6XcWkKz9R1cGZKtEfy([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);
  }
}
