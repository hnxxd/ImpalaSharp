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
  public partial class Results : TBase
  {
    private bool _ready;
    private List<string> _columns;
    private List<string> _data;
    private long _start_row;
    private bool _has_more;

    public bool Ready
    {
      get
      {
        return _ready;
      }
      set
      {
        __isset.ready = true;
        this._ready = value;
      }
    }

    public List<string> Columns
    {
      get
      {
        return _columns;
      }
      set
      {
        __isset.columns = true;
        this._columns = value;
      }
    }

    public List<string> Data
    {
      get
      {
        return _data;
      }
      set
      {
        __isset.data = true;
        this._data = value;
      }
    }

    public long Start_row
    {
      get
      {
        return _start_row;
      }
      set
      {
        __isset.start_row = true;
        this._start_row = value;
      }
    }

    public bool Has_more
    {
      get
      {
        return _has_more;
      }
      set
      {
        __isset.has_more = true;
        this._has_more = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool ready;
      public bool columns;
      public bool data;
      public bool start_row;
      public bool has_more;
    }

    public Results() {
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
            if (field.Type == TType.Bool) {
              Ready = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Columns = new List<string>();
                TList _list4 = iprot.ReadListBegin();
                for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                {
                  string _elem6 = null;
                  _elem6 = iprot.ReadString();
                  Columns.Add(_elem6);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                Data = new List<string>();
                TList _list7 = iprot.ReadListBegin();
                for( int _i8 = 0; _i8 < _list7.Count; ++_i8)
                {
                  string _elem9 = null;
                  _elem9 = iprot.ReadString();
                  Data.Add(_elem9);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I64) {
              Start_row = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              Has_more = iprot.ReadBool();
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
      TStruct struc = new TStruct("Results");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ready) {
        field.Name = "ready";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Ready);
        oprot.WriteFieldEnd();
      }
      if (Columns != null && __isset.columns) {
        field.Name = "columns";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, Columns.Count));
          foreach (string _iter10 in Columns)
          {
            oprot.WriteString(_iter10);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Data != null && __isset.data) {
        field.Name = "data";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, Data.Count));
          foreach (string _iter11 in Data)
          {
            oprot.WriteString(_iter11);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.start_row) {
        field.Name = "start_row";
        field.Type = TType.I64;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Start_row);
        oprot.WriteFieldEnd();
      }
      if (__isset.has_more) {
        field.Name = "has_more";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Has_more);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Results(");
      sb.Append("Ready: ");
      sb.Append(Ready);
      sb.Append(",Columns: ");
      sb.Append(Columns);
      sb.Append(",Data: ");
      sb.Append(Data);
      sb.Append(",Start_row: ");
      sb.Append(Start_row);
      sb.Append(",Has_more: ");
      sb.Append(Has_more);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
