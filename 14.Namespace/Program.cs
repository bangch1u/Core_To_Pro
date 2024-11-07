using System;
using A.B;
namespace _14.Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Namespace là cách tổ chức code (các class, giao diện, cấu trúc, ...) thành những nhóm, tạo ra 
             * phạm vi hoạt động của các thành phần trong nhóm
             * 
             * Namespace: khai báo một phạm vi, nó chứa tập hợp các đối tượng liên quan nhau, nhằm mục đích
             * tổ chức code khoa học, dễ quản lý và đặc biệt là tránh xung đột về tên. 
             * (bạn có thể khai bóa hai lớp tên giống nhau nhưng nằm ở hai namespcae khác nhau)
             * 
             * Cách khai báo tạo ra một namespace mới: sử dụng từ khóa namespcae và chỉ ra tên namespace muốn tạo mới
             * các thành phần khai báo trong namespace này (class, interface, struct..) được định nghĩa trong 
             * khối {}
             * 
             * Một namespace bạn có thể định nghĩa ở nhiều file code(.cs) khác nhau. Khi muốn sử dụng các thành phần của
             * namespace nào đó, thì dùng từ khóa using ở đầu file code để chỉ thị nạp namespace này vào 
             * 
             * Namespace System; là namespace cơ sở hệ thống của .NET, nên hầu như mọi chương trình đều có 
             * đoạn code using Systems; ở đầu
             * 
             * Các thành phần được khai báo tỏng một namespace: namespace con, class, các giao diện interfacae c#,
             * các cấu trúc - struct C#, enum, delegate C#
             * 
             * Namespace lồng nhau, nhiều cấp
             * Các namespace cũng có thể khai báo lồng nhau, nhiều cấp sau đó dùng ký hiệu . để truy cập đến namespace
             * mong muốn
             * 
             * Thư viện .NET cung cấp rất nhiều namespcae - mỗi namespace là tập hợp các class, struct về một 
             * vấn đề nào đó
             */
        }
    }
}

namespace A
{
    // Định nghĩa các lớp, cấu trúc ...
    namespace B
    {
        // Định nghĩa các lớp, cấu trúc ...
    }
}
