using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuanLyCuaHang
{
  public  class Cls_Product
    {
        string maSanPham, tenSanPham;

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }
        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }
        int soLuong, donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
      //Properties

      //Constructor
      
      //Method
      /// <summary>
      /// Nhập thông tin một sản phẩm
      /// </summary>
      public void Input()
      {
          Console.Write("Nhap ma san pham: ");
          maSanPham = Console.ReadLine();
          Console.Write("Nhap ten san pham: ");
          tenSanPham = Console.ReadLine();
          Console.Write("Nhap so luong: ");
          soLuong =Convert.ToInt32( Console.ReadLine());
          Console.Write("Nhap don gia: ");
          donGia =Convert.ToInt32(Console.ReadLine());
          Console.Write("Nhap ngay: ");
          ngayNhap =Convert.ToDateTime( Console.ReadLine());

      }
      /// <summary>
      /// Phương thức Xuất thông tin của sản phẩm
      /// </summary>
      public void Output()
      {
          Console.WriteLine("ID: {0}- proName: {1}-Date: {2}-Quantity: {3}-Price: {4}-Money :{5:N0} VNĐ",maSanPham,tenSanPham,ngayNhap,soLuong,donGia,CalMoney());
      }
      /// <summary>
      /// Phương thức tính tiền
      /// </summary>
      /// <returns>Tiền của sản phẩm theo công thức Soluong*dongia</returns>
      public int CalMoney()
      {
          return soLuong * donGia;
      }
      /// <summary>
      /// Phuong thức ghi nội dung vào file Nhi Phân
      /// </summary>
      /// <param name="bW"></param>
      public void WriteToFile(BinaryWriter bW)
      {
          bW.Write(maSanPham);
          bW.Write(tenSanPham);
          bW.Write(soLuong);
          bW.Write(donGia);
          bW.Write(ngayNhap.ToShortDateString());
      }
      /// <summary>
      /// Đọc nội dung file nhị phân 
      /// </summary>
      /// <param name="bR"></param>
      public void ReadForFile(BinaryReader bR)
      {
          maSanPham = bR.ReadString();
          maSanPham = bR.ReadString();
          soLuong = bR.ReadInt32();
          donGia = bR.ReadInt32();
          ngayNhap = Convert.ToDateTime(bR.ReadString());
          
      }
    }
}
