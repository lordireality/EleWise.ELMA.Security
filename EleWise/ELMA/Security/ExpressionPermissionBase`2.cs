// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExpressionPermissionBase`2
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EleWise.ELMA.Security
{
  public abstract class ExpressionPermissionBase<ET, PT> : IInstanceExpressionPermission
    where PT : class, IInstanceExpressionPermissionHolder, IEntity
  {
    private ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptor[] acessProperties;
    internal static object dtEXBvmTF5Lq7MY6Gvh;

    public virtual Type EntityType => typeof (ET);

    public Type PermissionType => typeof (PT);

    public virtual IPropertyExpressionDescriptor[] AccessExpressions
    {
      get
      {
        int num = 3;
        IPropertyExpressionDescriptor[] acessProperties;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.acessProperties = this.AccesspropertiesExpressions();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
              continue;
            case 3:
              if (this.acessProperties == null)
              {
                num = 2;
                continue;
              }
              break;
          }
          acessProperties = (IPropertyExpressionDescriptor[]) this.acessProperties;
          num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 0 : 1;
        }
label_2:
        return acessProperties;
      }
    }

    protected abstract ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptor[] AccesspropertiesExpressions();

    public virtual IEnumerable GetPermissionCollection(object target) => (IEnumerable) this.GetPermissionPersistenceCollection((ET) target);

    protected abstract ICollection<PT> GetPermissionPersistenceCollection(ET target);

    public virtual string PermissionsTable => InterfaceActivator.TypeOf<PT>().Name;

    protected ExpressionPermissionBase()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool GlhVV6mFEOAFJHidind() => ExpressionPermissionBase<ET, PT>.dtEXBvmTF5Lq7MY6Gvh == null;

    internal static object vb5JDjmvFryp5idmblx() => ExpressionPermissionBase<ET, PT>.dtEXBvmTF5Lq7MY6Gvh;

    protected class PropertyExpressionDescriptor : IPropertyExpressionDescriptor
    {
      private readonly Expression<Func<ET, object>> expression;
      private readonly string name;
      private readonly Func<ET, object> accessor;
      private readonly Func<object, object> accessorViaObject;
      private readonly bool allowChief;
      private static object UaC45DwmIS3r6MwQJusj;

      public PropertyExpressionDescriptor(Expression<Func<ET, object>> expression, bool allowChief = false)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.expression = expression;
        this.name = expression.ToString();
        this.accessor = expression.Compile();
        this.accessorViaObject = (Func<object, object>) (o => this.accessor((ET) o));
        this.allowChief = allowChief;
      }

      /// <summary>Имя</summary>
      public virtual string Name => this.name;

      public Func<object, object> Accessor => this.accessorViaObject;

      public bool AllowChief => this.allowChief;

      internal static bool E5GcQqwmeTNphaaTLNus() => ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptor.UaC45DwmIS3r6MwQJusj == null;

      internal static object LwZ5kBwmnv0FS544U2Ku() => ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptor.UaC45DwmIS3r6MwQJusj;
    }

    /// <summary>Выражение получения значения</summary>
    protected class PropertyExpressionDescriptorWithInstanceUid : 
      ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptor,
      IPropertyExpressionDescriptorWithInstanceUid,
      IPropertyExpressionDescriptor
    {
      private readonly Func<ET, string> accessorGetInstanceUid;
      private readonly Func<object, string> accessorViaUid;
      private readonly PermissionRoleType roleType;
      private static object WrRRlHwmLpH3UWxjgxur;

      /// <summary>ctor</summary>
      /// <param name="expression">Выражение получения значения</param>
      /// <param name="roleType">Роль, по которой выдается привилегия</param>
      /// <param name="allowChief">Выдавать ли права начальнику подчиненного</param>
      public PropertyExpressionDescriptorWithInstanceUid(
        Expression<Func<ET, object>> expression,
        PermissionRoleType roleType,
        bool allowChief = false)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector(expression, allowChief);
        this.roleType = roleType;
      }

      /// <summary>ctor</summary>
      /// <param name="expression">Выражение получения значения</param>
      /// <param name="expressionGetInstanceUid">Выражение получения значения UID экземпляра</param>
      /// <param name="roleType">Роль, по которой выдается привилегия</param>
      /// <param name="allowChief">Выдавать ли права начальнику подчиненного</param>
      public PropertyExpressionDescriptorWithInstanceUid(
        Expression<Func<ET, object>> expression,
        Expression<Func<ET, string>> expressionGetInstanceUid,
        PermissionRoleType roleType,
        bool allowChief = false)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector(expression, allowChief);
        this.roleType = roleType;
        this.accessorGetInstanceUid = expressionGetInstanceUid.Compile();
        this.accessorViaUid = (Func<object, string>) (o => this.accessorGetInstanceUid((ET) o));
      }

      /// <summary>Роль, по которой выдается привилегия</summary>
      public PermissionRoleType RoleType => this.roleType;

      /// <summary>
      /// Получить составное выражение роли и идентификатора сущности
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public string GetExpressionName(object obj)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.accessorViaUid == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return this.Name + this.accessorViaUid(obj);
label_5:
        return this.Name;
      }

      internal static bool svChDNwm232JVJUFc0xI() => ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptorWithInstanceUid.WrRRlHwmLpH3UWxjgxur == null;

      internal static object xMl28twmHdrgpOych2xY() => ExpressionPermissionBase<ET, PT>.PropertyExpressionDescriptorWithInstanceUid.WrRRlHwmLpH3UWxjgxur;
    }
  }
}
