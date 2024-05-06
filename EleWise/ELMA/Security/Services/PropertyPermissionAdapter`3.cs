// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.PropertyPermissionAdapter`3
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Базовый класс для редактирования настроек прав доступа к справочникам
  /// </summary>
  /// <typeparam name="TOwner"></typeparam>
  /// <typeparam name="TPropertyProfile"></typeparam>
  /// <typeparam name="TPropertyAccess"></typeparam>
  public abstract class PropertyPermissionAdapter<TOwner, TPropertyProfile, TPropertyAccess> : 
    IPropertyPermissionAdapter,
    IClassMetadataPropertyPermissionAdapter
    where TOwner : class, IPropertyOwnerProfile
    where TPropertyProfile : class, IAbstractPropertyProfile
    where TPropertyAccess : class, IAbstractPropertyAccess
  {
    private static object ybu6mDSSSQN4aRxu5GB;

    public virtual bool IsSupportedOwnerType(Type ownerType) => typeof (TOwner).IsAssignableFrom(ownerType);

    public virtual bool IsSupportedProfileType(Type profileType) => typeof (TPropertyProfile).IsAssignableFrom(profileType);

    public abstract bool IsSupportedModelType(Type modelType);

    IEnumerable<IAbstractPropertyProfile> IPropertyPermissionAdapter.GetPropertyProfiles(
      IPropertyOwnerProfile owner)
    {
      return this.GetPropertyProfiles((TOwner) owner).Cast<IAbstractPropertyProfile>();
    }

    /// <summary>Возвращает метаданные справочника</summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    IEntityMetadata IPropertyPermissionAdapter.GetMetadata(
      IAbstractPropertyProfile profile)
    {
      return this.GetMetadata((TPropertyProfile) profile) as IEntityMetadata;
    }

    /// <summary>Возвращает метаданные справочника</summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    IEntityMetadata IPropertyPermissionAdapter.GetMetadata(
      IPropertyOwnerProfile owner)
    {
      return this.GetMetadata((TOwner) owner) as IEntityMetadata;
    }

    IMetadata IClassMetadataPropertyPermissionAdapter.GetBaseMetadata(
      IAbstractPropertyProfile profile)
    {
      return this.GetMetadata((TPropertyProfile) profile);
    }

    IMetadata IClassMetadataPropertyPermissionAdapter.GetBaseMetadata(
      IPropertyOwnerProfile owner)
    {
      return this.GetMetadata((TOwner) owner);
    }

    IEnumerable<IPropertyMetadata> IPropertyPermissionAdapter.GetPropertyMetadataList(
      IPropertyOwnerProfile owner)
    {
      return this.GetPropertyMetadataList((TOwner) owner);
    }

    IAbstractPropertyProfile IPropertyPermissionAdapter.CreateProfile(
      IPropertyOwnerProfile owner,
      Guid propertyUid)
    {
      return (IAbstractPropertyProfile) this.CreateProfile((TOwner) owner, propertyUid);
    }

    void IPropertyPermissionAdapter.SaveProfiles(
      IPropertyOwnerProfile owner,
      IEnumerable<IAbstractPropertyProfile> profiles)
    {
      this.SaveProfiles((TOwner) owner, profiles.Cast<TPropertyProfile>());
    }

    IEnumerable<IAbstractPropertyAccess> IPropertyPermissionAdapter.GetAccesses(
      Type modelType)
    {
      return this.GetAccesses(modelType).Cast<IAbstractPropertyAccess>();
    }

    public abstract IEntityMetadata GetMetadata(
      Type modelType,
      bool includeInheritedProperties);

    public abstract IEnumerable<Type> GetChildTypes(Type modelType);

    public abstract event EventHandler<PropertyPermissionsChangedEventArgs> PermissionsChanged;

    public abstract Guid GetHidePermissionId();

    public abstract Guid GetViewPermissionId();

    public abstract Guid GetEditPermissionId();

    protected abstract IEnumerable<TPropertyProfile> GetPropertyProfiles(TOwner owner);

    /// <summary>
    /// Получить метаданные объекта по профилю принадлежащего ему свойства
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    protected abstract IMetadata GetMetadata(TOwner owner);

    /// <summary>
    /// Получить метаданные объекта по профилю принадлежащего ему свойства
    /// </summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    protected abstract IMetadata GetMetadata(TPropertyProfile profile);

    protected abstract IEnumerable<IPropertyMetadata> GetPropertyMetadataList(
      TOwner owner);

    protected abstract TPropertyProfile CreateProfile(TOwner owner, Guid propertyUid);

    protected abstract void SaveProfiles(TOwner owner, IEnumerable<TPropertyProfile> profiles);

    protected abstract IEnumerable<TPropertyAccess> GetAccesses(Type modelType);

    protected PropertyPermissionAdapter()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BaKNwZSYKPjotp2DEyC() => PropertyPermissionAdapter<TOwner, TPropertyProfile, TPropertyAccess>.ybu6mDSSSQN4aRxu5GB == null;

    internal static object LQWRXGSyPFlcuAYTNBN() => PropertyPermissionAdapter<TOwner, TPropertyProfile, TPropertyAccess>.ybu6mDSSSQN4aRxu5GB;
  }
}
