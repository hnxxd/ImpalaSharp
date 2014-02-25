/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace ImpalaSharp.Thrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TGetInfoValue : TBase
  {
    private string _stringValue;
    private short _smallIntValue;
    private int _integerBitmask;
    private int _integerFlag;
    private int _binaryValue;
    private long _lenValue;

    public string StringValue
    {
      get
      {
        return _stringValue;
      }
      set
      {
        __isset.stringValue = true;
        this._stringValue = value;
      }
    }

    public short SmallIntValue
    {
      get
      {
        return _smallIntValue;
      }
      set
      {
        __isset.smallIntValue = true;
        this._smallIntValue = value;
      }
    }

    public int IntegerBitmask
    {
      get
      {
        return _integerBitmask;
      }
      set
      {
        __isset.integerBitmask = true;
        this._integerBitmask = value;
      }
    }

    public int IntegerFlag
    {
      get
      {
        return _integerFlag;
      }
      set
      {
        __isset.integerFlag = true;
        this._integerFlag = value;
      }
    }

    public int BinaryValue
    {
      get
      {
        return _binaryValue;
      }
      set
      {
        __isset.binaryValue = true;
        this._binaryValue = value;
      }
    }

    public long LenValue
    {
      get
      {
        return _lenValue;
      }
      set
      {
        __isset.lenValue = true;
        this._lenValue = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool stringValue;
      public bool smallIntValue;
      public bool integerBitmask;
      public bool integerFlag;
      public bool binaryValue;
      public bool lenValue;
    }

    public TGetInfoValue() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              StringValue = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I16) {
              SmallIntValue = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              IntegerBitmask = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              IntegerFlag = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              BinaryValue = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I64) {
              LenValue = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TGetInfoValue");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (StringValue != null && __isset.stringValue) {
        field.Name = "stringValue";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(StringValue);
        oprot.WriteFieldEnd();
      }
      if (__isset.smallIntValue) {
        field.Name = "smallIntValue";
        field.Type = TType.I16;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(SmallIntValue);
        oprot.WriteFieldEnd();
      }
      if (__isset.integerBitmask) {
        field.Name = "integerBitmask";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(IntegerBitmask);
        oprot.WriteFieldEnd();
      }
      if (__isset.integerFlag) {
        field.Name = "integerFlag";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(IntegerFlag);
        oprot.WriteFieldEnd();
      }
      if (__isset.binaryValue) {
        field.Name = "binaryValue";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(BinaryValue);
        oprot.WriteFieldEnd();
      }
      if (__isset.lenValue) {
        field.Name = "lenValue";
        field.Type = TType.I64;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(LenValue);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TGetInfoValue(");
      sb.Append("StringValue: ");
      sb.Append(StringValue);
      sb.Append(",SmallIntValue: ");
      sb.Append(SmallIntValue);
      sb.Append(",IntegerBitmask: ");
      sb.Append(IntegerBitmask);
      sb.Append(",IntegerFlag: ");
      sb.Append(IntegerFlag);
      sb.Append(",BinaryValue: ");
      sb.Append(BinaryValue);
      sb.Append(",LenValue: ");
      sb.Append(LenValue);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
