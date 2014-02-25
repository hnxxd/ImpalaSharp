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
  public partial class TGetCatalogsReq : TBase
  {

    public TSessionHandle SessionHandle { get; set; }

    public TGetCatalogsReq() {
    }

    public TGetCatalogsReq(TSessionHandle sessionHandle) : this() {
      this.SessionHandle = sessionHandle;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_sessionHandle = false;
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
              SessionHandle = new TSessionHandle();
              SessionHandle.Read(iprot);
              isset_sessionHandle = true;
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
      if (!isset_sessionHandle)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TGetCatalogsReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "sessionHandle";
      field.Type = TType.Struct;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      SessionHandle.Write(oprot);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TGetCatalogsReq(");
      sb.Append("SessionHandle: ");
      sb.Append(SessionHandle== null ? "<null>" : SessionHandle.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
