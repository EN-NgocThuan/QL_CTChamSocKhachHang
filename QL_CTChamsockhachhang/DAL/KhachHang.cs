using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL
{
    public class KhachHang
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public int _id { get; set; }
        [BsonElement("makh")]
        public string makh { get; set; }
        [BsonElement("tenkh")]
        public string tenkh { get; set;}
        [BsonElement("diachi")]
        public string diachi { get; set; }
        [BsonElement("sdt")]
        public string sdt { get; set; }
        [BsonElement("danhgia")]
        public List<DanhGia> danhgia { get; set; }
    }
    public class DanhGia
    {
        public string masp { get; set;}
        public string tensp { get; set; }
        public string loaidg { get; set; }
        public string danhgiasp { get; set;}
        public string tt { get; set; }
    }
}
