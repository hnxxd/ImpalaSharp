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

namespace ImpalaSharp.Thrift.Beeswax
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class BeeswaxException : TException, TBase
  {
    private string _message;
    private string _log_context;
    private QueryHandle _handle;
    private int _errorCode;
    private string _SQLState;

    public string Message
    {
      get
      {
        return _message;
      }
      set
      {
        __isset.message = true;
        this._message = value;
      }
    }

    public string Log_context
    {
      get
      {
        return _log_context;
      }
      set
      {
        __isset.log_context = true;
        this._log_context = value;
      }
    }

    public QueryHandle Handle
    {
      get
      {
        return _handle;
      }
      set
      {
        __isset.handle = true;
        this._handle = value;
      }
    }

    public int ErrorCode
    {
      get
      {
        return _errorCode;
      }
      set
      {
        __isset.errorCode = true;
        this._errorCode = value;
      }
    }

    public string SQLState
    {
      get
      {
        return _SQLState;
      }
      set
      {
        __isset.SQLState = true;
        this._SQLState = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool message;
      public bool log_context;
      public bool handle;
      public bool errorCode;
      public bool SQLState;
    }

    public BeeswaxException() {
      this._errorCode = 0;
      this.__isset.errorCode = true;
      this._SQLState = "     ";
      this.__isset.SQLState = true;
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
              Message = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Log_context = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              Handle = new QueryHandle();
              Handle.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              ErrorCode = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              SQLState = iprot.ReadString();
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
      TStruct struc = new TStruct("BeeswaxException");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Message != null && __isset.message) {
        field.Name = "message";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Message);
        oprot.WriteFieldEnd();
      }
      if (Log_context != null && __isset.log_context) {
        field.Name = "log_context";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Log_context);
        oprot.WriteFieldEnd();
      }
      if (Handle != null && __isset.handle) {
        field.Name = "handle";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        Handle.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.errorCode) {
        field.Name = "errorCode";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ErrorCode);
        oprot.WriteFieldEnd();
      }
      if (SQLState != null && __isset.SQLState) {
        field.Name = "SQLState";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SQLState);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("BeeswaxException(");
      sb.Append("Message: ");
      sb.Append(Message);
      sb.Append(",Log_context: ");
      sb.Append(Log_context);
      sb.Append(",Handle: ");
      sb.Append(Handle== null ? "<null>" : Handle.ToString());
      sb.Append(",ErrorCode: ");
      sb.Append(ErrorCode);
      sb.Append(",SQLState: ");
      sb.Append(SQLState);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
