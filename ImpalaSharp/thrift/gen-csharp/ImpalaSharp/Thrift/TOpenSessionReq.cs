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
  public partial class TOpenSessionReq : TBase
  {
    private string _username;
    private string _password;
    private Dictionary<string, string> _configuration;

    /// <summary>
    /// 
    /// <seealso cref="TProtocolVersion"/>
    /// </summary>
    public TProtocolVersion Client_protocol { get; set; }

    public string Username
    {
      get
      {
        return _username;
      }
      set
      {
        __isset.username = true;
        this._username = value;
      }
    }

    public string Password
    {
      get
      {
        return _password;
      }
      set
      {
        __isset.password = true;
        this._password = value;
      }
    }

    public Dictionary<string, string> Configuration
    {
      get
      {
        return _configuration;
      }
      set
      {
        __isset.configuration = true;
        this._configuration = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool username;
      public bool password;
      public bool configuration;
    }

    public TOpenSessionReq() {
      this.Client_protocol = TProtocolVersion.HIVE_CLI_SERVICE_PROTOCOL_V1;
    }

    public TOpenSessionReq(TProtocolVersion client_protocol) : this() {
      this.Client_protocol = client_protocol;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_client_protocol = false;
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
            if (field.Type == TType.I32) {
              Client_protocol = (TProtocolVersion)iprot.ReadI32();
              isset_client_protocol = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Username = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Password = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Map) {
              {
                Configuration = new Dictionary<string, string>();
                TMap _map62 = iprot.ReadMapBegin();
                for( int _i63 = 0; _i63 < _map62.Count; ++_i63)
                {
                  string _key64;
                  string _val65;
                  _key64 = iprot.ReadString();
                  _val65 = iprot.ReadString();
                  Configuration[_key64] = _val65;
                }
                iprot.ReadMapEnd();
              }
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
      if (!isset_client_protocol)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TOpenSessionReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "client_protocol";
      field.Type = TType.I32;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32((int)Client_protocol);
      oprot.WriteFieldEnd();
      if (Username != null && __isset.username) {
        field.Name = "username";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Username);
        oprot.WriteFieldEnd();
      }
      if (Password != null && __isset.password) {
        field.Name = "password";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Password);
        oprot.WriteFieldEnd();
      }
      if (Configuration != null && __isset.configuration) {
        field.Name = "configuration";
        field.Type = TType.Map;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, Configuration.Count));
          foreach (string _iter66 in Configuration.Keys)
          {
            oprot.WriteString(_iter66);
            oprot.WriteString(Configuration[_iter66]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TOpenSessionReq(");
      sb.Append("Client_protocol: ");
      sb.Append(Client_protocol);
      sb.Append(",Username: ");
      sb.Append(Username);
      sb.Append(",Password: ");
      sb.Append(Password);
      sb.Append(",Configuration: ");
      sb.Append(Configuration);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
