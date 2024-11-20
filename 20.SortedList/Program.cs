using System;
using System.Collections.Generic;

namespace _20.SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Nếu tập dữ liệu của bạn được sắp xếp dựa trên một key, thì bạn có thể dùng 
             * đến SortedList<TKey, TValue>. Lớp này sắp xếp dữ liệu dựa trên một key
             * 
             * Một đối tượng dữ liệu lưu vào SortedList dưới dạng cặp key-value, truy cập đến phần tử thông qua 
             * key hoặc thông qua vị trí (index) của dữ liệu trong danh sách. Chú ý, không 
             * cho phép trùng key
             * 
             * Các thuộc tính, method trong SortedList
             * 
             * Count: Thuộc tính cho biết số phần tử 
             * [key]: Indexer truy cập đến phần tử có key
             * Keys: Thuộc tính là danh sách các key trong danh sách sắp xếp 
             * Values: Thuộc tính lấy danh sách các giá trị trong danh sách 
             * Add(key, value): thêm một phần tử vào danh sách 
             * Remove(key): Xóa phần tử bằng key của nó 
             * Clear() Loại bỏ tất cả các phần tử khỏi danh sách 
             * ContainKey(key) kiểm tra có phần tử nào có khóa là key 
             * IndexOfKey(key) lấy chỉ số của phần tử có khóa là key 
             * IndexOfValue(value) Lấy chỉ số của phần tử có giá trị là value
             */
            var products = new SortedList<string, string>();
            products.Add("Inphone 4", "P-Iphone-6");
            products.Add("Laptop Abc", "P-Lap");
            products["Điện thoại Z"] = "P-Dienthoai";//thêm phần tử bằng Indexer


            Console.WriteLine("Tên và Mã");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
