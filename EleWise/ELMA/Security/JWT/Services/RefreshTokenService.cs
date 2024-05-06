// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.JWT.Services.RefreshTokenService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.JWT.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Linq;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.JWT.Services
{
  /// <inheritdoc cref="T:EleWise.ELMA.Security.JWT.Services.IRefreshTokenService" />
  [Service]
  internal class RefreshTokenService : IRefreshTokenService
  {
    private readonly ICacheService cacheService;
    private readonly ISessionProvider sessionProvider;
    private readonly IJwtTokenService jwtTokenService;
    private readonly byte[] secret;
    private static RefreshTokenService K5BOyqvh9lnaumUsXrm;

    /// <summary>Ctor</summary>
    /// <param name="cacheService">Сервис работы с кэшем</param>
    /// <param name="sessionProvider">Провайдер сессии</param>
    /// <param name="jwtTokenService">Сервис для работы с JWT токенами</param>
    public RefreshTokenService(
      ICacheService cacheService,
      ISessionProvider sessionProvider,
      IJwtTokenService jwtTokenService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      byte[] numArray = new byte[32];
      // ISSUE: field reference
      RefreshTokenService.pMBOjqvOpJwRQjNp3dG((object) numArray, __fieldref (\u003CPrivateImplementationDetails\u003E.FAC8E4C2F98B10A205C63FEE202CE3A65ADCD437));
      this.secret = numArray;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.cacheService = cacheService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 2 : 2;
            continue;
          case 2:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 1 : 3;
            continue;
          case 3:
            this.jwtTokenService = jwtTokenService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <inheritdoc />
    [Transaction]
    public virtual string CreateToken(AuthInfoContainer authInfo)
    {
      int num = 6;
      IDictionary<string, string> dictionary;
      RefreshToken token;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.TokenToCache(token, this.TokenDuration);
            num = 3;
            continue;
          case 3:
            dictionary = authInfo.ToDictionary();
            num = 4;
            continue;
          case 4:
            dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841274285), RefreshTokenService.KkEEUsveUAdlHFrXYHE((object) token).ToString());
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 1 : 1;
            continue;
          case 5:
            RefreshToken refreshToken = new RefreshToken();
            RefreshTokenService.WBU4gOvqhs1CZcOxva8((object) refreshToken, RefreshTokenService.MLgirPvvJLcNWM8mgVc((object) authInfo));
            RefreshTokenService.YBDAUTvJAfHx7kdKBKe((object) refreshToken, RefreshTokenService.bPlPCfvgjt1Vq6eC93M((object) authInfo));
            RefreshTokenService.wRynIfvI1plbFMfZuXn((object) refreshToken, DateTime.Now.Add(this.TokenDuration));
            token = refreshToken;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
            continue;
          case 6:
            RefreshTokenService.yTgBquvFWqbAoR3g86J((object) authInfo, RefreshTokenService.ekJdNivTfr6CbDck6Fa(-522456341 ^ -522511049));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 2 : 5;
            continue;
          default:
            this.Session.Save((object) token);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return this.jwtTokenService.CreateToken(dictionary, this.secret, this.TokenDuration).ToString();
    }

    /// <inheritdoc />
    [Transaction]
    public virtual AuthInfoContainer GetAuthInfo(string refreshToken)
    {
      int num = 6;
      IDictionary<string, string> validatedPayload;
      Guid guid;
      string key;
      RefreshToken token;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            goto label_14;
          case 3:
            if (!this.cacheService.TryGetValue<object>(key, (string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(1245871191 - 2145700088 ^ -899857831), out object _))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 9 : 7;
              continue;
            }
            goto case 4;
          case 4:
            this.RemoveToken(guid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 2 : 2;
            continue;
          case 5:
            validatedPayload = this.jwtTokenService.GetValidatedPayload(refreshToken, this.secret);
            num = 10;
            continue;
          case 6:
            RefreshTokenService.OlNkBHvnjGehFMUKlT3((object) refreshToken, RefreshTokenService.ekJdNivTfr6CbDck6Fa(-1743015995 ^ -1743036519));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 5 : 3;
            continue;
          case 7:
            goto label_9;
          case 8:
            key = (string) RefreshTokenService.Yf9FKAv2U4xius1ZDKo(guid);
            num = 3;
            continue;
          case 9:
            token = this.Session.Get<RefreshToken>((object) guid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 0 : 0;
            continue;
          case 10:
            Contract.CheckWithMessage<ArgumentException>((validatedPayload.ContainsKey((string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(781628008 - 11982093 ^ 769601021)) ? 1 : 0) != 0, (string) RefreshTokenService.GtltERvLIFyYpANATkC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1596821387 ^ -1596817215), (object) new object[1]
            {
              RefreshTokenService.ekJdNivTfr6CbDck6Fa(1100789287 - 1555711667 ^ -454910168)
            }));
            num = 11;
            continue;
          case 11:
            guid = Guid.Parse(validatedPayload[(string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(-404268492 ^ -404247918)]);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 12 : 7;
            continue;
          case 12:
            validatedPayload.Remove((string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(-340788466 ^ -340849752));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 8 : 1;
            continue;
          default:
            if (token == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 7 : 4;
              continue;
            }
            this.RemoveToken(token);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 1 : 1;
            continue;
        }
      }
label_9:
      return (AuthInfoContainer) null;
label_11:
      return validatedPayload.ToAuthInfo();
label_14:
      return validatedPayload.ToAuthInfo();
    }

    /// <inheritdoc />
    [Transaction]
    public virtual void Revoke(AuthInfoContainer authInfo)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        RefreshTokenService.\u003C\u003Ec__DisplayClass10_0 cDisplayClass100;
        List<Guid>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
label_10:
                if (enumerator.MoveNext())
                  goto label_12;
                else
                  goto label_11;
label_8:
                string str;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      RefreshTokenService.fdDiQRqtnnfqv7hnFsb((object) this.cacheService, (object) str, RefreshTokenService.ekJdNivTfr6CbDck6Fa(-340788466 ^ -340850168));
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 2 : 2;
                      continue;
                    case 2:
                      goto label_10;
                    case 3:
                      goto label_12;
                    default:
                      goto label_5;
                  }
                }
label_11:
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
                goto label_8;
label_12:
                str = (string) RefreshTokenService.Yf9FKAv2U4xius1ZDKo(enumerator.Current);
                num3 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0)
                {
                  num3 = 1;
                  goto label_8;
                }
                else
                  goto label_8;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 2:
              // ISSUE: reference to a compiler-generated field
              RefreshTokenService.yTgBquvFWqbAoR3g86J((object) cDisplayClass100.authInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(978908330 << 6 ^ -1774336676));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b == 0 ? 0 : 0;
              continue;
            case 3:
label_5:
              IQueryable<RefreshToken> source1 = this.Session.Query<RefreshToken>();
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) RefreshTokenService.gO2sGQqoW9NmcpB7U16(RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshToken)), RefreshTokenService.ekJdNivTfr6CbDck6Fa(19590779 ^ 19579201));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<RefreshToken, bool>> predicate1 = Expression.Lambda<Func<RefreshToken, bool>>((Expression) Expression.AndAlso((Expression) RefreshTokenService.EpbcjdqUKnA96KPUGOL((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (RefreshToken.get_UserId))), RefreshTokenService.YlkCKOvzeCv611Ida41(RefreshTokenService.sdwjhRqbSe2EoqNBIQQ(RefreshTokenService.aCOW8pqu5xMNFCArT10((object) cDisplayClass100, RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0))), RefreshTokenService.iwg0ICqw6j9EO9VRnY6(__fieldref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0.authInfo))), (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AuthInfoContainer.get_UserId)))), (Expression) Expression.Equal((Expression) RefreshTokenService.YlkCKOvzeCv611Ida41((object) parameterExpression1, (object) (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (RefreshToken.get_ApplicationToken))), (Expression) Expression.Property((Expression) RefreshTokenService.sdwjhRqbSe2EoqNBIQQ(RefreshTokenService.aCOW8pqu5xMNFCArT10((object) cDisplayClass100, RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0))), RefreshTokenService.iwg0ICqw6j9EO9VRnY6(__fieldref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0.authInfo))), (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (AuthInfoContainer.get_ApplicationToken))))), parameterExpression1);
              source1.Where<RefreshToken>(predicate1).Delete<RefreshToken>();
              num2 = 6;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.authInfo = authInfo;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 2 : 1;
              continue;
            case 5:
              goto label_4;
            case 6:
              goto label_17;
            default:
              IQueryable<RefreshToken> source2 = this.Session.Query<RefreshToken>();
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = Expression.Parameter(RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshToken)), (string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(-550634672 ^ -550644630));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<RefreshToken, bool>> predicate2 = Expression.Lambda<Func<RefreshToken, bool>>((Expression) RefreshTokenService.alfAL8qR3mGUnEWR6sm(RefreshTokenService.EpbcjdqUKnA96KPUGOL(RefreshTokenService.YlkCKOvzeCv611Ida41((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (RefreshToken.get_UserId))), (object) Expression.Property((Expression) RefreshTokenService.sdwjhRqbSe2EoqNBIQQ(RefreshTokenService.aCOW8pqu5xMNFCArT10((object) cDisplayClass100, RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0))), RefreshTokenService.iwg0ICqw6j9EO9VRnY6(__fieldref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0.authInfo))), (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (AuthInfoContainer.get_UserId)))), RefreshTokenService.EpbcjdqUKnA96KPUGOL(RefreshTokenService.YlkCKOvzeCv611Ida41((object) parameterExpression2, (object) (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (RefreshToken.get_ApplicationToken))), (object) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass100, RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0))), (FieldInfo) RefreshTokenService.iwg0ICqw6j9EO9VRnY6(__fieldref (RefreshTokenService.\u003C\u003Ec__DisplayClass10_0.authInfo))), (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (AuthInfoContainer.get_ApplicationToken))))), parameterExpression2);
              IQueryable<RefreshToken> source3 = source2.Where<RefreshToken>(predicate2);
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) RefreshTokenService.gO2sGQqoW9NmcpB7U16(RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshToken)), RefreshTokenService.ekJdNivTfr6CbDck6Fa(-1711335411 ^ -1711327433));
              // ISSUE: method reference
              Expression<Func<RefreshToken, Guid>> selector = Expression.Lambda<Func<RefreshToken, Guid>>((Expression) RefreshTokenService.YlkCKOvzeCv611Ida41((object) parameterExpression3, (object) (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (RefreshToken.get_Uid))), parameterExpression3);
              enumerator = source3.Select<RefreshToken, Guid>(selector).ToList<Guid>().GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 1;
              continue;
          }
        }
label_4:
        // ISSUE: object of a compiler-generated type is created
        cDisplayClass100 = new RefreshTokenService.\u003C\u003Ec__DisplayClass10_0();
        num1 = 4;
      }
label_17:;
    }

    /// <inheritdoc />
    [Transaction]
    public virtual void RemoveExpired()
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      RefreshTokenService.\u003C\u003Ec__DisplayClass11_0 cDisplayClass110;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass110.now = RefreshTokenService.B17LIlqm8E2IQvijq0a();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass110 = new RefreshTokenService.\u003C\u003Ec__DisplayClass11_0();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 2;
            continue;
          default:
            IQueryable<RefreshToken> source = this.Session.Query<RefreshToken>();
            // ISSUE: type reference
            ParameterExpression parameterExpression = (ParameterExpression) RefreshTokenService.gO2sGQqoW9NmcpB7U16(RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshToken)), RefreshTokenService.ekJdNivTfr6CbDck6Fa(-2143851882 - 923330995 ^ 1227796441));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            // ISSUE: method reference
            Expression<Func<RefreshToken, bool>> predicate = Expression.Lambda<Func<RefreshToken, bool>>((Expression) RefreshTokenService.JYKeInq6d1tPPUfxWfT((object) Expression.Property((Expression) parameterExpression, (MethodInfo) RefreshTokenService.U0TBCEqKU9eI6rGA8Pe(__methodref (RefreshToken.get_ExpireDate))), RefreshTokenService.sdwjhRqbSe2EoqNBIQQ(RefreshTokenService.aCOW8pqu5xMNFCArT10((object) cDisplayClass110, RefreshTokenService.ARq5JxvHLheQsREqfY4(__typeref (RefreshTokenService.\u003C\u003Ec__DisplayClass11_0))), RefreshTokenService.iwg0ICqw6j9EO9VRnY6(__fieldref (RefreshTokenService.\u003C\u003Ec__DisplayClass11_0.now))), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThan))), parameterExpression);
            source.Where<RefreshToken>(predicate).Delete<RefreshToken>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    private void TokenToCache(RefreshToken token, TimeSpan duration)
    {
      int num = 1;
      string key;
      while (true)
      {
        switch (num)
        {
          case 1:
            key = (string) RefreshTokenService.Yf9FKAv2U4xius1ZDKo(token.Uid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.cacheService.Insert<RefreshToken>(key, token, (string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(-880091293 >> 4 ^ -55026448), duration);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    private void RemoveToken(Guid tokenUid)
    {
      int num = 1;
      RefreshToken refreshToken;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) RefreshTokenService.Yf9FKAv2U4xius1ZDKo(tokenUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 0 : 0;
            continue;
          case 2:
            refreshToken = this.Session.Get<RefreshToken>((object) tokenUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 4 : 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (refreshToken != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 5 : 5;
              continue;
            }
            goto label_9;
          case 5:
            RefreshTokenService.e8MpEPqkyDrd6MyCeqo((object) this.Session, (object) refreshToken);
            num = 3;
            continue;
          default:
            RefreshTokenService.fdDiQRqtnnfqv7hnFsb((object) this.cacheService, (object) str, RefreshTokenService.ekJdNivTfr6CbDck6Fa(1185105284 ^ 1185133698));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return;
label_9:;
    }

    private void RemoveToken(RefreshToken token)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) RefreshTokenService.Yf9FKAv2U4xius1ZDKo(RefreshTokenService.KkEEUsveUAdlHFrXYHE((object) token));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 0;
            continue;
          case 2:
            RefreshTokenService.e8MpEPqkyDrd6MyCeqo((object) this.Session, (object) token);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            RefreshTokenService.fdDiQRqtnnfqv7hnFsb((object) this.cacheService, (object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1527733619 - 442652394 ^ -1970357595));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private static string GetTokenCacheKey(Guid token) => (string) RefreshTokenService.FrokYQqDTmO2jtinP3f((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1762575989 ^ 1762539345), (object) token);

    private TimeSpan TokenDuration => RefreshTokenService.kKTALsqaS9NYfPHETjx(EleWise.ELMA.SR.GetSetting<double>((string) RefreshTokenService.ekJdNivTfr6CbDck6Fa(84189367 + 1997579375 ^ 2081797128), 240.0));

    private ISession Session => (ISession) RefreshTokenService.T4VO6pqx55QBo9kCkAW((object) this.sessionProvider, (object) string.Empty);

    internal static void pMBOjqvOpJwRQjNp3dG([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static bool vdiHBkvB2uri4Iwr806() => RefreshTokenService.K5BOyqvh9lnaumUsXrm == null;

    internal static RefreshTokenService ThJpmkvpsxEPGirqtYC() => RefreshTokenService.K5BOyqvh9lnaumUsXrm;

    internal static object ekJdNivTfr6CbDck6Fa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void yTgBquvFWqbAoR3g86J([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static long MLgirPvvJLcNWM8mgVc([In] object obj0) => ((AuthInfoContainer) obj0).UserId;

    internal static void WBU4gOvqhs1CZcOxva8([In] object obj0, long value) => ((RefreshToken) obj0).UserId = value;

    internal static object bPlPCfvgjt1Vq6eC93M([In] object obj0) => (object) ((AuthInfoContainer) obj0).ApplicationToken;

    internal static void YBDAUTvJAfHx7kdKBKe([In] object obj0, [In] object obj1) => ((RefreshToken) obj0).ApplicationToken = (string) obj1;

    internal static void wRynIfvI1plbFMfZuXn([In] object obj0, DateTime value) => ((RefreshToken) obj0).ExpireDate = value;

    internal static Guid KkEEUsveUAdlHFrXYHE([In] object obj0) => ((RefreshToken) obj0).Uid;

    internal static void OlNkBHvnjGehFMUKlT3([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object GtltERvLIFyYpANATkC([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object Yf9FKAv2U4xius1ZDKo(Guid token) => (object) RefreshTokenService.GetTokenCacheKey(token);

    internal static Type ARq5JxvHLheQsREqfY4([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object YlkCKOvzeCv611Ida41([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object aCOW8pqu5xMNFCArT10([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object iwg0ICqw6j9EO9VRnY6([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object sdwjhRqbSe2EoqNBIQQ([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object U0TBCEqKU9eI6rGA8Pe([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object EpbcjdqUKnA96KPUGOL([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object alfAL8qR3mGUnEWR6sm([In] object obj0, [In] object obj1) => (object) Expression.AndAlso((Expression) obj0, (Expression) obj1);

    internal static object gO2sGQqoW9NmcpB7U16([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static void fdDiQRqtnnfqv7hnFsb([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Remove((string) obj1, (string) obj2);

    internal static DateTime B17LIlqm8E2IQvijq0a() => DateTime.Now;

    internal static object JYKeInq6d1tPPUfxWfT([In] object obj0, [In] object obj1, [In] bool obj2, [In] object obj3) => (object) Expression.LessThan((Expression) obj0, (Expression) obj1, obj2, (MethodInfo) obj3);

    internal static void e8MpEPqkyDrd6MyCeqo([In] object obj0, [In] object obj1) => ((ISession) obj0).Delete(obj1);

    internal static object FrokYQqDTmO2jtinP3f([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static TimeSpan kKTALsqaS9NYfPHETjx([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static object T4VO6pqx55QBo9kCkAW([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);
  }
}
