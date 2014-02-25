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

namespace ImpalaSharp.Thrift.Hive
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Version : TBase
  {
    private string _version2;
    private string _comments;

    public string Version2
    {
      get
      {
        return _version2;
      }
      set
      {
        __isset.version2 = true;
        this._version2 = value;
      }
    }

    public string Comments
    {
      get
      {
        return _comments;
      }
      set
      {
        __isset.comments = true;
        this._comments = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool version2;
      public bool comments;
    }

    public Version() {
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
              Version2 = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Comments = iprot.ReadString();
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
      TStruct struc = new TStruct("Version");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Version2 != null && __isset.version2) {
        field.Name = "version2";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Version2);
        oprot.WriteFieldEnd();
      }
      if (Comments != null && __isset.comments) {
        field.Name = "comments";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Comments);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Version(");
      sb.Append("Version2: ");
      sb.Append(Version2);
      sb.Append(",Comments: ");
      sb.Append(Comments);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
