using System;

namespace _15.Partial__Nested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Partial là kỹ thuật phân chia code lưu ở nhiều file mã nguồn khác nhau, khi biên dịch thì
             * nó tổng hợp lại thành một. Kỹ thuật này dùng tử khóa partial khi định nghĩa class, giao diện
             * struct
             * 
             * Kỹ thuật phân chia code ra thành nhiều file có thể gặp khi: 
             * - dự án lớn, những lớp mã nguồn dài cần chỉa tách ra thành nhiều file có thể đơn giuản là
             * gộp các chức nâng giống nhau thành một file, hoặc làm việc nhóm mỗi lập trình viên làm việc 
             * trên một file - sau đó khi biên dịch nó tự tổng hợp thành một class hoàn chỉnh 
             * -khi làm việc với các IDE, nó có thể phát sinh ra code một cách tự động, code được thêm vào lớp 
             * được lưu ở một file mã nguồn khác mà không cần chỉnh sử file code ban đầu
             */
            Product prodduct = new Product();
            prodduct.Name = "Nguyễn Trọng Bằng";
            prodduct.Age = 21;

            /*
             * Tuy properties Name và Age ở hai item .cs khác nhau nhưng đều có thể 
             *truy cập được cùng nhau do chúng có từ khóa partial và tên class giống nhau
             *
             *Lưu ý khi dùng partial 
             *-trong định nghĩa ở tất cả các phần phải có từ khóa partial 
             *Từ khóa partial  có thể đặt ngay trước từ khóa class
             */
            prodduct.callMyMethod(prodduct.Name); 

            /*
             * Lớp lồng nhau (Kiểu Nested) trong C#
             * 
             */
           
        }
    }
}
