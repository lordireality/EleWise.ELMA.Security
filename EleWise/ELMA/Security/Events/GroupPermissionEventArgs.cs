// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Events.GroupPermissionEventArgs
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Events
{
  /// <summary>Аргументы события изменения групповых политик доступа</summary>
  public class GroupPermissionEventArgs : AuditEventArgs
  {
    private GroupPermission permission;
    private GroupPermissionOperation operation;
    private EleWise.ELMA.Security.Permission parentPermission;
    private static GroupPermissionEventArgs cjusjbJYo2pLGmE6Va6;

    public GroupPermissionEventArgs(
      GroupPermission permission,
      GroupPermissionOperation operation,
      EleWise.ELMA.Security.Permission parentPermission)
    {
      GroupPermissionEventArgs.d6AKflJlNofdqLRfhxh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.operation = operation;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 0 : 0;
            continue;
          case 2:
            this.permission = permission;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            this.parentPermission = parentPermission;
            num = 3;
            continue;
        }
      }
label_3:;
    }

    public GroupPermission Permission => this.permission;

    public GroupPermissionOperation Operation => this.operation;

    public EleWise.ELMA.Security.Permission ParentPermission => this.parentPermission;

    internal static void d6AKflJlNofdqLRfhxh() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool kiFE8UJy8YMOVu7SSCX() => GroupPermissionEventArgs.cjusjbJYo2pLGmE6Va6 == null;

    internal static GroupPermissionEventArgs Xp6wP0JVxTLTI2xgff7() => GroupPermissionEventArgs.cjusjbJYo2pLGmE6Va6;
  }
}
