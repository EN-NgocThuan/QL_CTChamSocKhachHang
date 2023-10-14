using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("QL_Chamsockhachhang");
        public static IMongoCollection<KhachHang> collection = db.GetCollection<KhachHang>("QL_KhachHang");
        DataTable table;
        public DAL_KhachHang() { 
        
        
        }  

        //Tạo các column cho bảng khách hàng.Chú ý: các column có giá trị đơn
        public void createTableKhachHang(DataTable table)
        {
            table = new DataTable();//tạo mới table
            DataColumn column;
            //tạo các cột tương ứng .Thêm các cột đã tạo vào table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "makh";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "tenkh";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "diachi";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "sdt";
            table.Columns.Add(column);
        }
        //Tạo phương thức thêm các phần tử vào table .
        public void pushTableKhachHang(DataTable table, KhachHang data)
        {
            DataRow row = table.NewRow();//Tạo mới một Row
            //Thêm lần lượt dữ liệu vào các row[] tương ứng
            row["makh"] = data.makh;
            row["tenkh"] = data.tenkh;
            row["diachi"] = data.tenkh;
            row["sdt"] = data.tenkh;
            table.Rows.Add(row);
        }

        public DataTable GetData()
        {
            try
            {
                List<KhachHang> lst = collection.AsQueryable<KhachHang>().ToList();//Lấy dử liệu khách hàng
                createTableKhachHang(table);//tạo table khách hàng
                foreach(KhachHang item in lst)
                {
                    KhachHang kh = new KhachHang();
                    kh.makh = item.makh;
                    kh.tenkh = item.tenkh;
                    kh.diachi= item.diachi;
                    kh.sdt= item.sdt;
                    pushTableKhachHang(table, kh);
                }
                return table;
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }         
        }
    }
}
