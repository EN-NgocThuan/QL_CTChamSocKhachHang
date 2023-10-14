﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class CollectionKhachHang
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("QL_Chamsockhachhang");
        public static IMongoCollection<KhachHang> collection = db.GetCollection<KhachHang>("QL_KhachHang");
        DataTable tableKH;
        public CollectionKhachHang()
        {


        }

        //Tạo các column cho bảng khách hàng.Chú ý: các column có giá trị đơn
        public void createTableKhachHang(DataTable table)
        {
            DataColumn column;
            //tạo các cột tương ứng .Thêm các cột đã tạo vào table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mã khách hàng";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Tên khách hàng";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Địa chỉ";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Số điện thoại";
            table.Columns.Add(column);
        }
        //Tạo phương thức thêm các phần tử vào table .
        public static void pushTableKhachHang(DataTable table, KhachHang data)
        {
            DataRow row =table.NewRow();//Tạo mới một Row
            //Thêm lần lượt dữ liệu vào các row[] tương ứng
            row["Mã khách hàng"] = data.makh;
            row["Tên khách hàng"] = data.tenkh;
            row["Địa chỉ"] = data.diachi;
            row["Số điện thoại"] = data.sdt;
            table.Rows.Add(row);
        }

        public DataTable GetData()
        {
            try
            {
                List<KhachHang> lst = collection.AsQueryable<KhachHang>().ToList();//Lấy dử liệu khách hàng
                tableKH = new DataTable();
                createTableKhachHang(tableKH);//tạo table khách hàng
                foreach (KhachHang item in lst)
                {
                    KhachHang kh = new KhachHang();
                    kh.makh = item.makh;
                    kh.tenkh = item.tenkh;
                    kh.diachi = item.diachi;
                    kh.sdt = item.sdt;
                    pushTableKhachHang(tableKH, kh);
                }
                return tableKH;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //==========================================================================
        //             THÊM - XOÁ - SỬA KHÁCH HÀNG
        //==========================================================================

        //Thêm
        public bool addMember(KhachHang kh)
        {
            try
            {
                collection.InsertOne(kh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xoá
        public bool delMember(KhachHang kh)
        {
            try
            {
                var filter = Builders<KhachHang>.Filter.Eq(r => r.makh, kh.makh);
                collection.DeleteOneAsync(filter);
                return true;
            }
            catch { return false; }
        }
        //Sửa
        public bool editMember(KhachHang kh)
        {
            try
            {
                var filter = Builders<KhachHang>.Filter.Eq(r => r.makh, kh.makh);
                var update = Builders<KhachHang>.Update
                    .Set(r => r.tenkh,kh.tenkh).Set(r => r.diachi, kh.diachi).Set(r => r.sdt, kh.sdt);
                collection.UpdateOneAsync(filter,update);
                return true;
            }
            catch { return false; }
        }
    }
    public class KhachHang
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public String _id { get; set; }
        [BsonElement("makh")]
        public string makh { get; set; }
        [BsonElement("tenkh")]
        public string tenkh { get; set; }
        [BsonElement("diachi")]
        public string diachi { get; set; }
        [BsonElement("sdt")]
        public string sdt { get; set; }
        [BsonElement("danhgia")]
        public List<DanhGia> danhgia { get; set; }
    }
    public class DanhGia
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string loaidg { get; set; }
        public string danhgiasp { get; set; }
        public string tt { get; set; }
    }
}
