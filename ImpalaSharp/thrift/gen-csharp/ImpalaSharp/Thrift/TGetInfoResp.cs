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
  public partial class TGetInfoResp : TBase
  {

    public TStatus Status { get; set; }

    public TGetInfoValue InfoValue { get; set; }

    public TGetInfoResp() {
    }

    public TGetInfoResp(TStatus status, TGetInfoValue infoValue) : this() {
      this.Status = status;
      this.InfoValue = infoValue;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_status = false;
      bool isset_infoValue = false;
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
            if (field.Type == TType.Struct) {
              Status = new TStatus();
              Status.Read(iprot);
              isset_status = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              InfoValue = new TGetInfoValue();
              InfoValue.Read(iprot);
              isset_infoValue = true;
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
      if (!isset_status)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_infoValue)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TGetInfoResp");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "status";
      field.Type = TType.Struct;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      Status.Write(oprot);
      oprot.WriteFieldEnd();
      field.Name = "infoValue";
      field.Type = TType.Struct;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      InfoValue.Write(oprot);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TGetInfoResp(");
      sb.Append("Status: ");
      sb.Append(Status== null ? "<null>" : Status.ToString());
      sb.Append(",InfoValue: ");
      sb.Append(InfoValue== null ? "<null>" : InfoValue.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
