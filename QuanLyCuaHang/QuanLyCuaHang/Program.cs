using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHang
{
    class Program
    {
        static string path = @"C:/Users/CIA/Desktop/QuanLyCuaHang/QuanLyCuaHang/ListProduct.dat";
        static string chon = string.Empty;
        static Cls_ListProduct _ListProduct = new Cls_ListProduct();
       static void menu()
        {
            Console.WriteLine("1. Them 1 san pham vao danh sach");
            Console.WriteLine("2. Tim kiem san pham theo ten");
            Console.WriteLine("3. Ghi file danh sach san pham");
            Console.WriteLine("4. Doc file danh sach san pham");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon chuc nang:");
        }
       static void SearchByName(Cls_ListProduct _ListProduct)
       {
           Console.WriteLine("Nhap ten sp can tim");
           string tensp = Console.ReadLine();
           List<Cls_Product> Listsearch = new List<Cls_Product>();
           Listsearch = _ListProduct.SearchByNameProduct(tensp);
           if (Listsearch.Count > 0)
           {
               _ListProduct.PrintListProduct(Listsearch);
           }
           else
           {
               Console.WriteLine("Khong co san pham can tim");
           }
       }
       static void SearchByName()
       {
           Console.WriteLine("Nhap ten sp can tim");
           string tensp = Console.ReadLine();
           List<Cls_Product> Listsearch = new List<Cls_Product>();
           Listsearch = _ListProduct.SearchByNameProduct(tensp);
           if (Listsearch.Count > 0)
           {
               _ListProduct.PrintListProduct(Listsearch);
           }
           else
           {
               Console.WriteLine("Khong co san pham can tim");
           }
       }
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                          _ListProduct.AddProduct();
                          _ListProduct.PrintListProduct();
                        break;
                    case "2":
                        SearchByName(_ListProduct);
                        SearchByName();
                        break;
                    case "3":
                        _ListProduct.SaveToFile(path);
                        _ListProduct.PrintListProduct();
                        break;
                    case "4":
                        _ListProduct.ReadForFile(path);
                        _ListProduct.PrintListProduct();
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}
