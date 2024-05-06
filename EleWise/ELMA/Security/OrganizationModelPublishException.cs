// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.OrganizationModelPublishException
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
  public class OrganizationModelPublishException : Exception
  {
    private static OrganizationModelPublishException THif2oKOpuMmHgBr6hZ;

    public OrganizationModelPublishException()
    {
      OrganizationModelPublishException.R4Ml7DKviR4NW3Ip2eb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OrganizationModelPublishException(string message)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OrganizationModelPublishException(string message, Exception innerException)
    {
      OrganizationModelPublishException.R4Ml7DKviR4NW3Ip2eb();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected OrganizationModelPublishException(SerializationInfo info, StreamingContext context)
    {
      OrganizationModelPublishException.R4Ml7DKviR4NW3Ip2eb();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            // ISSUE: type reference
            this.mess = (List<OrganizationValidationMessage>) OrganizationModelPublishException.JkqHscKgTITN70935VG((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691378790), OrganizationModelPublishException.bY1FldKqwt400DHLClL(__typeref (List<OrganizationValidationMessage>)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
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
            OrganizationModelPublishException.hvrygHKJqOxiGtyR4BV((object) this, (object) info, context);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            OrganizationModelPublishException.y8pK5BKI49To4f1145d((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(4869926 >> 3 ^ 611896), (object) this.mess);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void R4Ml7DKviR4NW3Ip2eb() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool YdYaNDKT7l7g0CoR7he() => OrganizationModelPublishException.THif2oKOpuMmHgBr6hZ == null;

    internal static OrganizationModelPublishException C9ArweKF3GYUrgrUee5() => OrganizationModelPublishException.THif2oKOpuMmHgBr6hZ;

    internal static Type bY1FldKqwt400DHLClL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object JkqHscKgTITN70935VG([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void hvrygHKJqOxiGtyR4BV([In] object obj0, [In] object obj1, [In] StreamingContext obj2) => __nonvirtual (((Exception) obj0).GetObjectData((SerializationInfo) obj1, obj2));

    internal static void y8pK5BKI49To4f1145d([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
