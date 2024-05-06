// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Entities.UserExport
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Xml;

namespace EleWise.ELMA.Deploy.Export.Entities
{
  /// <summary>Экспорт данных относящихся к профилю пользователя</summary>
  /// <remarks>
  /// Экспорт-импорт пользователей недоупустим в ELMA, попытки выгрузить должны быть пресечены. Данное расширение исключает из выгрузки инстансы объектов, относящихся к профилю пользователя.
  /// </remarks>
  [Component(Order = 500)]
  internal class UserExport : IExportDataExtension
  {
    private static readonly ILogger ExportLog;
    private static readonly IList<Guid> Uids;
    private static UserExport CdoLhqOHYZv2A3mwJQ;

    /// <inheritdoc />
    public virtual bool CheckMetadata(IMetadata metadata)
    {
      int num = 1;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityMetadata = metadata as EntityMetadata;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
          case 5:
            goto label_6;
          case 4:
            if (!UserExport.Uids.Contains(entityMetadata.ImplementationUid))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 1 : 5;
              continue;
            }
            goto label_5;
          default:
            if (entityMetadata == null)
            {
              num = 3;
              continue;
            }
            goto case 4;
        }
      }
label_5:
      return true;
label_6:
      return false;
    }

    /// <inheritdoc />
    public List<ClassMetadata> ExportObjects(
      XmlWriter writer,
      ClassMetadata metadata,
      List<DeployLogMessage> messages,
      List<ClassMetadata> wasExported,
      List<string> fileUids)
    {
      if (wasExported == null)
        wasExported = new List<ClassMetadata>();
      string str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458233375));
      messages.Add(new DeployLogMessage(DeployLogMessageType.Warn, str));
      UserExport.ExportLog.Error((object) str);
      wasExported.Add(metadata);
      return wasExported;
    }

    public UserExport()
    {
      UserExport.fsWa9LvZcaOUq29k8a();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UserExport()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            UserExport.fsWa9LvZcaOUq29k8a();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
            continue;
          case 2:
            UserExport.Uids = (IList<Guid>) new List<Guid>()
            {
              InterfaceActivator.UID<IUser>(),
              InterfaceActivator.UID<IUserSecurityProfile>()
            };
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            UserExport.ExportLog = Logger.GetLogger((string) UserExport.AiA5p6qxipaNbTIH3I(-979995965 << 4 ^ 1499934234));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool Xa9DYgToiONf0Q06CL() => UserExport.CdoLhqOHYZv2A3mwJQ == null;

    internal static UserExport ekVM8FFy59N6BEYFEE() => UserExport.CdoLhqOHYZv2A3mwJQ;

    internal static void fsWa9LvZcaOUq29k8a() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object AiA5p6qxipaNbTIH3I(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
