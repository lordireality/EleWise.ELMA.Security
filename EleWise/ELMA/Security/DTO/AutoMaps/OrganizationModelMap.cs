// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.AutoMaps.OrganizationModelMap
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Security.DTO.AutoMaps
{
  /// <summary>Преобразователь модели и DTO оргструктуры</summary>
  public class OrganizationModelMap : BidirectionalMap<IOrganizationModel, OrganizationModelDTO>
  {
    private static OrganizationModelMap boihgc3d33JXcsItLd9;

    protected override void InitReverseMap(
      IMappingExpression<OrganizationModelDTO, IOrganizationModel> map)
    {
      base.InitReverseMap(map);
      map.ForMember<EleWise.ELMA.Security.Models.IUser>((Expression<Func<IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>) (organizationModel => organizationModel.CreationAuthor), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>) (o => o.Ignore()));
      map.ForMember<DateTime>((Expression<Func<IOrganizationModel, DateTime>>) (organizationModel => organizationModel.CreationDate), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, DateTime>>) (o => o.Ignore()));
      map.ForMember<EleWise.ELMA.Security.Models.IUser>((Expression<Func<IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>) (organizationModel => organizationModel.ChangeAuthor), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, EleWise.ELMA.Security.Models.IUser>>) (o => o.Ignore()));
      map.ForMember<DateTime?>((Expression<Func<IOrganizationModel, DateTime?>>) (organizationModel => organizationModel.ChangeDate), (Action<IMemberConfigurationExpression<OrganizationModelDTO, IOrganizationModel, DateTime?>>) (o => o.Ignore()));
    }

    public OrganizationModelMap()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UC9cLG3EudWRkGvOCMQ() => OrganizationModelMap.boihgc3d33JXcsItLd9 == null;

    internal static OrganizationModelMap huXalg3GUYA4Qus8UZb() => OrganizationModelMap.boihgc3d33JXcsItLd9;
  }
}
