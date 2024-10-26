using System;
using System.Collections.Generic;
using System.Linq;
namespace _5.Day_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Mảng trong lập trình C#
             * 
             *Mảng - khai báo mảng trong c#
             *Mảng  là một cấu trúc dữ liệu được sử dụng để lưu trữ một tập dữ liệu cùng 
             *kiểu. 
             *
             *Cú pháp khai báo biến mảng là chỉ ra kiểu phần tử mảng - tiếp theo là kí tự []
             *
             *int[] bienMang; // khai bao bien mang kieu phan tu la int (chua khoi tao)
             *
             *Khoi tao mang
             *Muon khoi tạo đối tượng mảng để gán vào biến mảng thì thực hiện như sau 
             * 
             */
            int[] bienMang;
            bienMang = new int[5];

            //có thể khởi tạo ngay khi khai báo int[] = new int[5];
            string[] studentNames = new string[5];

            //khởi tạo new datatype[n] tạo ra mảng có kiểu datatype và có thể lưu n phần tử

            /*
             * Khi khởi tạo - nó tạo ra mảng có số phần tử chỉ định, các phần tử của mảng 
             * có giá trị khởi tạo mặc định tùy vào kiểu dữ liệu sau đó bạn có thể cần gán 
             * giá trị lưu trữ trong các phần tử. C# hỗ trợ ngay khi khởi tạo mảng ta gán luôn các 
             * giá trị cụ thể vào mảng bằng các mở ra ký hiệu {} trong nó liệt kê các giá trị lưu 
             * trữ của mảng
             */
            string[] productNames = new string[3] { "Iphone", "SamSung", "Nokia" };

            //Khi mảng được khai báo và khởi tạo luôn như vậy, không nhất thiết phải chỉ ra
            //số lượng phần tử ở [] vì số lượng phần tử sẽ lấy theo số giá trị khởi tạo trong {}
            string[] productNames2 = new string[] { "Iphone", "SamSung", "Nokia" };
            //cách này thậm chí còn có thể bỏ luôn cả toán tử new thì nó cũng ngầm định sử dụng 
            //khởi tạo như trên
            string[] productNames3 = { "Iphone", "SamSung", "Nokia" };

            //các giá trị khởi tạo gán cho phần tử mảng được liệt kê cách nhau bởi dấu , và đặt trong {}

            /*
             *Truy  cập phần tử mảng 
             *các phần tử mảng được truy cập thông qua ký hiệu biến-mảng[chỉ-số], trong đó
             *chỉ-số là thứ tự của phần tử trong mảng, các phần tử mảng có chỉ số từ 0 trở đi
             *
             *Thuộc tính và phương thức đối tượng mảng
             *
             *Các biến mảng thực chất được tạo ra từ lớp có lớp cơ sở là System.Array, nên nó 
             *có các thuộc tính phương thức của lớp này. Một số thuộc tính và phương 
             *thức như sau:
             *
             *Length: thuộc tính cho biết số lượng phần tử trong mảng 
             *Rank: thuộc tính cho biết số chiều mảng 
             *Clone(): Copy (Nhân bản) đối tượng mảng
             *GetValue(index) lấy giá trị phần tử trong mảng 
             *Min(): Trả về giá trị nhỏ nhất trong mảng 
             *Max(): Trả về giá trị lớn nhất trong mảng 
             *Sum(): Trả về giá trị tổng cộng các phần tử
             *
             *Chú ý: cần nạp thư viện Linq bằng using System.Linq; để có thể sủ dụng được method
             *Max(), Min(), Sum();
             *
             *
             */
            int[] vidu = { 3, 6, 7, 2, 9 };//mảng 1 chiều
                                           //int[,] vidu2 = { { 2, 3 }, { 3, 4 } };//mảng 2 chiều
                                           //Console.WriteLine(vidu.Rank);
                                           //Console.WriteLine(vidu2.Rank);

            int[] copyVidu1 = (int[])vidu.Clone();// bắt buộc phải ép kiểu khi sử dụng clone() để nhân bản
            foreach (int i in copyVidu1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Giá trị ở  vị trí số 3 trong mảng vidu: " + vidu.GetValue(2));

            Console.WriteLine("Giá trị min trong vidu " + vidu.Min());
            Console.WriteLine("Giá trị max trong vidu " + vidu.Max());
            Console.WriteLine("Tong cac phan tu trong vidu " + vidu.Sum());

            /*
             * Một số phương thức tĩnh trong Array áp dụng vào mảng như: 
             * Array.BinarySearch(array, value): tìm kiếm phần tử trong mảng đã được sắp 
             * xếp, trả về chỉ số (vị trí) của phần tử nếu tìm thấy
             */
            Console.WriteLine("Mang vidu đã được sắp xếp từ lớn -> nhỏ");
            Console.WriteLine("Phần tử 7 có vị trí (chỉ số) là: " + Array.BinarySearch(vidu, 7));

            //CopyTo(array, indexStart): sao chép phần tử mảng này sang mảng khác
            // Sao chép từ chỉ số 2 của mảng vidu
            int[] copyViduBangMethodCopyTo = new int[6];
            vidu.CopyTo(copyViduBangMethodCopyTo, 1);

            // In ra các phần tử trong mảng copyViduBangMethodCopyTo
            foreach (var item in copyViduBangMethodCopyTo)
            {
                Console.WriteLine(item);
            }
            //giải thích: tất cả phần tử trong mảng vidu sẽ được copy và paste vào
            //mảng copyViduBangMethodCopyTo từ vị trí số 2 trong chính mảng copyViduBangMethodCopyTo

            //Array.Clear(array, index, length): Thiết lập phần tử mảng nhận giá trị mặc định
            //Array.Clear(vidu, 1, 3);
            Console.WriteLine("------------------------------");
            foreach (var item in vidu)
            {
                Console.WriteLine(item);
            }
            //giải thích: sẽ chuyển hết giá trị của các phần tử trong mảng vidu từ vị trí 2
            // thành có giá trị 0 (giá trị default).

            //int index = Array.IndexOf(array, value): tìm chỉ số của phần tử  trong mảng 
            int index = Array.IndexOf(vidu, 7);
            Console.WriteLine(index);

            //Array.Sort(array) sắp xếp tăng dần
            Array.Sort(vidu);
            foreach (var item in vidu)
            {
                Console.WriteLine(item);
            }
            //Array.Reverse(array) đảo ngược array
            Array.Reverse(vidu);
            foreach (var item in vidu)
            {
                Console.WriteLine(item);
            }
            int[] numbers = { 5, 3, 8, 1, 2, 7 };
            Array.Sort(numbers, 1, 4); // Sắp xếp các phần tử từ chỉ số 1 đến 1 + 4 - 1

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }




        }
    }
}
