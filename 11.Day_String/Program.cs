using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace _11.Day_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            /*
             * String - chuỗi ký tự c#
             * 
             * Chuỗi là một tập hợp các ký tự sắp xếp có vị trí, nó chính là một mảng các ký tự, kiểu dữ liệu chuỗi đó là 
             * string, lớp biểu diễn các chuỗi là System.String 
             * Chuỗi như là mảng mà phần tử mảng là các ký tự, nên có thể truy cập mảng bằng index để đọc ký tự
             */
            string test = "Nguyen Trong Bang";
            foreach (var item in test)
            {
                if (item == 'T')
                {
                    Console.WriteLine("Trong tên có chứa ký tự T");
                }
            }
            Console.WriteLine(test[4]);//có thể truy xuất các phần tử trong mảng string qua index
            /*
             * Viết chuỗi nguyên bản với ký hiệu @ trong C#
             * khi viết chuỗi trong cặp dấu nháy kép "", thì các ký tự đặc biệt được xử lý với ký hiệu \
             * 
             */
            string s = "C:\\Abc\\xyz";//nội dung thực tế là C:\Abc\xyz . Hiểu nôm na là các ký tự đặc biết muốn được thể hiện
            //trên code thì phải đứng sau dấu \
            /*
             * Nếu muốn viết chuỗi cố định, nội dung nguyên bản cho biết sẽ không dùng \ để xử lý ký  tự đặc biệt thì 
             * thêm @ vào đầu chuỗi
             */
            string a = @"Ký tự đặc biệt như \ sẽ khong cần phải đưng sau \ khi có thêm @ đưng đầu";
            /*
             * Bằng ký hiệu @ chuỗi viết thế nào thì nội dung thực tế sẽ như vậy, ngoài trừ hai kí tự "" chuyển thành 
             * một ký tự  ""
             */
            Console.WriteLine(@"""Hello my friend""");
            /*
             * Chèn thêm biểu thức vào chuỗi với ký hiệu $ trong C#
             * khi viết chuỗi có ký tựu $ phía trước thì trong chuỗi đó có thể chèn các biểu thức vào chỗ có cặp {} : {biểu thức}
             * 
             */
            int a1 = 10;
            int b = 20;
            string s1 = $"kết quả {a1}/{b} là {a1 / b}";
            /*
             * Ngoài ra bạn có thể căn lề, định dạng số, ngày tháng ... tương tự như chuỗi định dạng 
             */

            Console.WriteLine($"{"VòngLặp",10} {"Chẵn/Lẻ",-5}");
            for (int i = 8; i < 15; i++)
            {
                string chanle = (i % 2 == 0) ? "Chẵn" : "Lẻ";
                Console.WriteLine($"{i,10} {chanle,-5}");
            }
            string stringA = "Xin Chao";
            string stringB = "cac ban";

            //method nối các chuỗi liệt kê ở tham số lại với nhau
            string concactString = string.Concat(stringA, stringB);
            Console.WriteLine(concactString);

            //Convert các đối tượng thành chuỗi và chèn chúng vào chuỗi định dạng được chỉ ra
            string formatString = String.Format("Chào {0}, {0} oi hôm nay {1} roi", stringA, stringB);
            Console.WriteLine(formatString);

            //Tìm vị trí (đầu tiên) của ký tự hoặc chuỗi ký tự trong chuỗi 
            Console.WriteLine(stringA.IndexOf('n'));

            //tìm vị trí (cuối) của ký tự hoặc chuỗi ký tự trong chuỗi
            Console.WriteLine(stringA.LastIndexOf('a'));

            //tạo chuỗi = chèn chuỗi này vào chuỗi khác, vị trí chuỗi cần chỉ ra
            var s2 = stringA.Insert(3, " tất cả");
            Console.WriteLine(s2);

            //Split Trả về mảng các chuỗi con được chia từ chuỗi gốc bởi ký tự chia chỉ định, chuỗi chia chỉ định
            //var s = "Nguyễn Văn A".Split(' '); // s tương đương mảng {"Nguyễn","Văn", "A"}
            //ToLower Sinh chuỗi mới bằng cách chuyển các ký tự thành chữ thường
            //ToUpper Sinh chuỗi mới bằng cách chuyển các ký tự thành chữ in
            //Trim Sinh chuỗi mới bằng cách loại bỏ khoảng trắng(hoặc chỉ định) ở đầu và cuối
            //Substring Lấy ra chuỗi con từ chuỗi chính -chuỗi con lấy từ vị trí chỉ ra đến cuối hoặc theo độ dài
            //string s = stringA.Substring(4); // s = "chào,"
            // string x = stringA.Substring(0, 3); // s = "Xin" (dài 3)


        }
    }
}
