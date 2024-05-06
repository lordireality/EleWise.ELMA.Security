// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Types.Settings.EntityUserSettings
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Security.Types.Settings
{
  /// <summary>Настройки типа "Сущность-&gt;Пользователь"</summary>
  [Serializable]
  public class EntityUserSettings : EntitySettings
  {
    internal static EntityUserSettings n1re1Qx77b4IrfUZUR9;

    /// <summary>Ctor</summary>
    public EntityUserSettings()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected EntityUserSettings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Показывать часовой пояс, если он отличается от часового пояса текущего пользователя
    /// </summary>
    [DefaultValue(false)]
    [XmlElement("ShowDifferentTimeZone")]
    public bool ShowDifferentTimeZone
    {
      get => this.\u003CShowDifferentTimeZone\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CShowDifferentTimeZone\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Признак, что для свойства активировано сохранение замещенного пользователя
    /// </summary>
    [XmlElement("Replaceable")]
    [JsonSerializationIgnore]
    [DefaultValue(false)]
    public bool Replaceable
    {
      get => this.\u003CReplaceable\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReplaceable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Уникальный идентификатор свойства, в котором хранится замещаемый пользователь
    /// </summary>
    [XmlIgnore]
    public Guid ReplacedUserPropertyUid
    {
      get => this.\u003CReplacedUserPropertyUid\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReplacedUserPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Ограничения для выбора исполнителей</summary>
    [XmlIgnore]
    public virtual List<Worker> Workers { get; set; }

    /// <summary>Ограничения для выбора исполнителей</summary>
    [DefaultValue(null)]
    [XmlElement("Workers")]
    [JsonSerializationIgnore]
    public virtual string WorkersSerialized
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (this.Workers == null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              case 2:
                goto label_7;
              case 3:
                goto label_5;
              default:
                goto label_6;
            }
          }
label_7:
          if (EntityUserSettings.uncgQBxSHLX0iSIXQWG((object) this.Workers) == 0)
            num1 = 4;
          else
            break;
        }
label_5:
        return (string) EntityUserSettings.kH4wkXxYis64O7EEtm0((object) new WorkerListContainer(this.Workers), false);
label_6:
        return (string) null;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!EntityUserSettings.ipxod0xyUs9YWDwLbmr((object) value))
              {
                this.Workers = ClassSerializationHelper.DeserializeObjectByXml<WorkerListContainer>(value, false).Workers;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 3 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              goto label_2;
            default:
              this.Workers = (List<Worker>) null;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 2 : 0;
              continue;
          }
        }
label_3:
        return;
label_2:;
      }
    }

    /// <summary>
    /// Уникальный идентификатор свойства, в котором хранится замещаемый пользователь (для сериализации)
    /// </summary>
    [JsonSerializationIgnore]
    [DefaultValue("")]
    [XmlElement("ReplacedUserPropertyUid")]
    public string ReplacedUserPropertyUidStr
    {
      get
      {
        int num = 2;
        Guid replacedUserPropertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (EntityUserSettings.j0Yu5wxVgOen75H09fF(this.ReplacedUserPropertyUid, Guid.Empty))
              {
                replacedUserPropertyUid = this.ReplacedUserPropertyUid;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 1 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return "";
label_4:
        return replacedUserPropertyUid.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.ReplacedUserPropertyUid = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Отображать в списке заблокированных пользователей</summary>
    [DefaultValue(false)]
    public bool ShowBlock
    {
      get => this.\u003CShowBlock\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CShowBlock\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Нужно ли проверять замещения</summary>
    [DefaultValue(false)]
    public bool CheckReplacement
    {
      get => this.\u003CCheckReplacement\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCheckReplacement\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Задает выражение, которое возращает дату начала, свзянную с выбором пользователя
    /// </summary>
    [XmlIgnore]
    public string ReplacementStartDateClientFunction
    {
      get => this.\u003CReplacementStartDateClientFunction\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReplacementStartDateClientFunction\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Задает выражение, которое возращает дату окончания, свзянную с выбором пользователя
    /// </summary>
    [XmlIgnore]
    public string ReplacementEndDateClientFunction
    {
      get => this.\u003CReplacementEndDateClientFunction\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReplacementEndDateClientFunction\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
    {
      base.SerializeToJsonObject(jsonObject);
      if (this.Workers == null || this.Workers.Count <= 0)
        return;
      SerializableList<object> serializableList = new SerializableList<object>();
      foreach (Worker worker in this.Workers)
      {
        SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
        serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908180700)] = (object) worker.WorkerType;
        serializableDictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440357975)] = (object) worker.WorkerId;
        serializableList.Add((object) serializableDictionary);
      }
      jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1254421137 >> 4 ^ -78384240)] = (object) serializableList;
    }

    public override void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
    {
      base.DeserializeFromJsonObject(jsonObject);
      object obj1;
      if (jsonObject == null || !jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1095474805 ^ 155418997 ^ 1208507462), out obj1))
        return;
      if (this.Workers == null)
        this.Workers = new List<Worker>();
      else
        this.Workers.Clear();
      if (!(obj1 is IEnumerable enumerable))
        return;
      foreach (object obj2 in enumerable)
      {
        object obj3;
        object obj4;
        Guid result1;
        long result2;
        if (obj2 is IDictionary<string, object> dictionary && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-624171910 - 757669187 ^ -1381858259), out obj3) && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696773181), out obj4) && obj3 != null && obj4 != null && Guid.TryParse(obj3.ToString(), out result1) && long.TryParse(obj4.ToString(), out result2))
          this.Workers.Add(new Worker()
          {
            WorkerType = result1,
            WorkerId = result2
          });
      }
    }

    public override bool Equals(object obj)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        EntityUserSettings entityUserSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              if (entityUserSettings == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 4;
                continue;
              }
              break;
            case 3:
              goto label_3;
            case 4:
              goto label_5;
          }
          if (entityUserSettings.CheckReplacement == this.CheckReplacement)
            num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 1 : 0;
          else
            goto label_5;
        }
label_3:
        entityUserSettings = obj as EntityUserSettings;
        num1 = 2;
      }
label_4:
      return base.Equals(obj);
label_5:
      return false;
    }

    protected override void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            TypeSerializationDescriptorBuilder descriptorBuilder1 = new TypeSerializationDescriptorBuilder(descriptor);
            object itemName1 = EntityUserSettings.lhEU1cxf2KJj2wYLWY7(-906676699 ^ -906660509);
            // ISSUE: reference to a compiler-generated field
            Action<TypeSerializationDescriptorBuilder> action1 = EntityUserSettings.\u003C\u003Ec.\u003C\u003E9__43_0;
            Action<TypeSerializationDescriptorBuilder> builder1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityUserSettings.\u003C\u003Ec.\u003C\u003E9__43_0 = builder1 = (Action<TypeSerializationDescriptorBuilder>) (i =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_6;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      object obj = EntityUserSettings.\u003C\u003Ec.QnhQuFwDswMHdG3PMfYC((object) i.Description((string) EntityUserSettings.\u003C\u003Ec.DAB2lDwDAm3QUeBaR83W(EntityUserSettings.\u003C\u003Ec.dEa1xswDZaj9vsH9lI0d(-1640694811 << 2 ^ 2027084744))), (object) null);
                      // ISSUE: reference to a compiler-generated method
                      object itemName2 = EntityUserSettings.\u003C\u003Ec.dEa1xswDZaj9vsH9lI0d(1780597820 ^ 1780582182);
                      // ISSUE: reference to a compiler-generated field
                      Action<TypeSerializationDescriptorBuilder> action2 = EntityUserSettings.\u003C\u003Ec.\u003C\u003E9__43_1;
                      Action<TypeSerializationDescriptorBuilder> builder2;
                      if (action2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        EntityUserSettings.\u003C\u003Ec.\u003C\u003E9__43_1 = builder2 = (Action<TypeSerializationDescriptorBuilder>) (i2 =>
                        {
                          int num5 = 1;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: type reference
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                EntityUserSettings.\u003C\u003Ec.edCBgkwDrtuFFuRKEB3W((object) i2.Description((string) EntityUserSettings.\u003C\u003Ec.jPMesBwD7v9HGjcxZevt(EntityUserSettings.\u003C\u003Ec.dEa1xswDZaj9vsH9lI0d(-1527733619 - 442652394 ^ -1970307325), (object) new object[2]
                                {
                                  EntityUserSettings.\u003C\u003Ec.dEa1xswDZaj9vsH9lI0d(1848373724 >> 1 ^ 924169848),
                                  EntityUserSettings.\u003C\u003Ec.dEa1xswDZaj9vsH9lI0d(-906676699 ^ -906659489)
                                })), EntityUserSettings.\u003C\u003Ec.YhfI8ywDWLn7aLGfSMbd(__typeref (Guid)));
                                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        });
                      }
                      else
                        goto label_10;
label_5:
                      TypeSerializationDescriptorBuilder descriptorBuilder2 = ((TypeSerializationDescriptorBuilder) obj).ItemWithDescriptor((string) itemName2, builder2);
                      // ISSUE: reference to a compiler-generated method
                      object itemName3 = EntityUserSettings.\u003C\u003Ec.dEa1xswDZaj9vsH9lI0d(-696756495 ^ -696773181);
                      // ISSUE: reference to a compiler-generated field
                      Action<TypeSerializationDescriptorBuilder> action3 = EntityUserSettings.\u003C\u003Ec.\u003C\u003E9__43_2;
                      Action<TypeSerializationDescriptorBuilder> builder3;
                      if (action3 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        EntityUserSettings.\u003C\u003Ec.\u003C\u003E9__43_2 = builder3 = (Action<TypeSerializationDescriptorBuilder>) (i2 =>
                        {
                          int num6 = 1;
                          while (true)
                          {
                            switch (num6)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                i2.Description((string) EntityUserSettings.\u003C\u003Ec.DAB2lDwDAm3QUeBaR83W((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1324692970 << 3 ^ -2007538210))).Type(typeof (long));
                                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        });
                      }
                      else
                        goto label_9;
label_8:
                      descriptorBuilder2.ItemWithDescriptor((string) itemName3, builder3);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
                      continue;
label_9:
                      builder3 = action3;
                      goto label_8;
label_10:
                      builder2 = action2;
                      goto label_5;
                    default:
                      goto label_3;
                  }
                }
label_6:
                return;
label_3:;
              });
            }
            else
              goto label_8;
label_7:
            descriptorBuilder1.ItemWithDescriptor((string) itemName1, builder1);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
            continue;
label_8:
            builder1 = action1;
            goto label_7;
          case 2:
            EntityUserSettings.KD0SZZxlH7QIqUqJUyr((object) this, (object) descriptor);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:;
    }

    internal static bool emNoNVxWTv42OpKprOW() => EntityUserSettings.n1re1Qx77b4IrfUZUR9 == null;

    internal static EntityUserSettings AlGFk5xrQrYRQosjWKJ() => EntityUserSettings.n1re1Qx77b4IrfUZUR9;

    internal static int uncgQBxSHLX0iSIXQWG([In] object obj0) => ((List<Worker>) obj0).Count;

    internal static object kH4wkXxYis64O7EEtm0([In] object obj0, [In] bool obj1) => (object) ClassSerializationHelper.SerializeObjectByXml(obj0, obj1);

    internal static bool ipxod0xyUs9YWDwLbmr([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool j0Yu5wxVgOen75H09fF([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void KD0SZZxlH7QIqUqJUyr([In] object obj0, [In] object obj1) => __nonvirtual (((TypeSettings) obj0).GetSerializationDescriptor((TypeSerializationDescriptor) obj1));

    internal static object lhEU1cxf2KJj2wYLWY7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
