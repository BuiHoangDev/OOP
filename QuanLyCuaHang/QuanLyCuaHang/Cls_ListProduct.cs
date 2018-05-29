using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuanLyCuaHang
{
   public class Cls_ListProduct
    {
      // ArrayList _listProduct;//= new ArrayList();
    public   List<Cls_Product> _ListProduct;// = new List<Cls_SanPham>();

       public Cls_ListProduct()
       {
           _ListProduct = new List<Cls_Product>();
       }

       public void AddProduct()
       {
           string chon = string.Empty ;
           Cls_Product _product ;
           do
           {
               _product = new Cls_Product();
               _product.Input();
               _ListProduct.Add(_product);
               Console.WriteLine("Ban co muon nhap tiep khong Y/N");
             chon = Console.ReadLine();
           } while (chon.ToLower().Equals("y"));
       }
       public List<Cls_Product> SearchByNameProduct(string proName)
       {
           List<Cls_Product> _list = new List<Cls_Product>();
           foreach (Cls_Product item in _ListProduct)
           {
               if(item.TenSanPham.Equals(proName))
               {
                   _list.Add(item);
               }
           }
           return _list;
       }
       public List<Cls_Product> DeleteByNameProduct(string proName)
       {
           List<Cls_Product> _list = new List<Cls_Product>();
           foreach (Cls_Product item in _ListProduct)
           {
               if (item.TenSanPham.Equals(proName))
               {
                   _ListProduct.Remove(item);
               }
           }
           return _list;
       }
       public void PrintListProduct(List<Cls_Product> list)
       {
           foreach (Cls_Product item in list)
           {
               item.Output();
           }
       }
       /// <summary>
       /// In truoc tiep danh sach cua ListProduct
       /// </summary>
       public void PrintListProduct()
       {
           foreach (Cls_Product item in _ListProduct)
           {
               item.Output();
           }
       }
       public void SaveToFile(string path)
       {
           using(FileStream fs=new FileStream(path,FileMode.Create,FileAccess.Write,FileShare.Write))
           {
               using(BinaryWriter bW=new BinaryWriter(fs))
               {
                   foreach (Cls_Product item in _ListProduct)
                   {
                       item.WriteToFile(bW);   
                   }
               }
           }
       }
       public void ReadForFile(string path)
       {
           _ListProduct.Clear();
           using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
           {
               using (BinaryReader bW = new BinaryReader(fs))
               {
                   Cls_Product _product;
                   while (bW.PeekChar()!=-1)
                   {
                       _product = new Cls_Product();
                       _product.ReadForFile(bW);
                       _ListProduct.Add(_product);
                   }
               }
           }
       }
    }
}
