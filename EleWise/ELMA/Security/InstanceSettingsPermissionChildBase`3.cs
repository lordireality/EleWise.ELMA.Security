// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.InstanceSettingsPermissionChildBase`3
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Security
{
  public abstract class InstanceSettingsPermissionChildBase<ET, PET, PT> : 
    InstanceSettingsPermissionBase<PET, PT>,
    IInstanceSettingsPermissionChild,
    IInstanceSettingsPermission
    where ET : class
    where PET : class
    where PT : class, IInstanceSettingsPermissionHolder
  {
    private readonly string parentPropertyName;

    protected InstanceSettingsPermissionChildBase(
      Expression<Func<PT, PET>> targetExpression,
      Expression<Func<ET, PET>> parentExpression)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(targetExpression);
      this.parentPropertyName = LinqUtils.NameOf<ET, PET>(parentExpression);
    }

    public abstract Guid GetParentPermissionId(Guid childPermissionId);

    public override Type EntityType => InterfaceActivator.TypeOf<ET>();

    public virtual string ParentPropertyName => this.parentPropertyName;
  }
}
