using System;

namespace _1_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            
            //Console.WriteLine("Hello World!");
            //biến trong c#: dùng để lưu các giá trị dữ liệu vào bộ nhớ, giá trị lưu trữ vào đó có thể 
            /*đọc và thay đổi bởi chương trình c# khi chạy. Để dùng biến, trước tiên 
             * phải đặt một cái tên cho biến và chỉ ra biến đó sẽ lưu loại dữ liệu nào 
             * việc này gọi là khai báo 
             * 
             * Khi đặt tên biến cần lưu ý: Tên biến có thể chứa chữ ký số và ký tự, nhưng ký tự đầu tiên
             * biến không được dùng số, tên biến trong c# có phân biệt chữ hoa và chữ thường. 
             * 
             * Khai báo biến để khai báo biến bạn cần chỉ ra dữ liệu của biến
             *  Các kiểu dữ liệu cơ bản trong c#:
             *  int: kiểu số nguyên (có dấu, dùng 32 bit biểu diễn từ -2,147,483,648 đến 2,147,483,647
             *  sbyte: kiểu số nguyên (có dấu, dùng 8 bit biểu diễn từ -128 đến 127
             *  byte: kiểu số nguyên (không dấu dùng 8 bit biểu diễn từ 0 đến 255)
             *  short: kiểu số nguyên (có dấu dùng 16 bit biểu diễn từ 0 đến 65,535)
             *  long kiểu số nguyên (có dấu dùng 64 bit biểu diễn từ  -9,223,372,036,854,775,808 đến 9,223,372,036,854,775,807)
             *  ulong: kiểu số nguyên (không dấu dùng 64 bit biểu diễn từ 0 đến 18,446,744,073,709,551,615)
             *  float : số thực chấm động (dùng 32 bit biểu diễn phù hợp số có bảy chữ số, độ chính xác số chấm chấm động
             *  1.5 × 10−45 đến 3.4 × 1038)
             *  double số thực chấm động (dùng 64 bit biểu diễn)
             *  decimal số thực chấm động (dùng 128 bit biểu diễn)
             *  char một ký tự (dùng 16 bit biểu diễn ký tự Unicode)
             *  bool kiểu logic (chỉ nhận giá trị false hoặc true)
             *  string chuỗi (xâu) ký tự (tập hợp các ký tự theo thứ tự - một văn bản text)
             *  object đối tượng biểu diễn các đối tượng C# nó là kiểu cơ sở - mọi đối tượng c# đều kế thừa từ kiểu này
             *  
             *  Xuất dữ liệu ra màn hình Console
             *  thư viện lớp c# cung cấp sẵn một lớp  tên là Console (System.Console) trong đó có chứa một số phương thức 
             *  tĩnh để nhập/ xuất dữ liệu với màn hình dòng lệnh terminal. Một số phương thức bạn có thể sử dụng ngay 
             *  trong việc in dữ liệu đó là: 
             * 
             */
           
            
            //thuộc tính gán màu chữ xuất ra (ForegroundColor)        
            Console.ForegroundColor = ConsoleColor.Green;

            //màn hình sẽ in ra giá trị " Hello" và sau đó xuống dòng
            Console.WriteLine("Hello");
            //thuộc tính reset đưa console về màu mặc định
            Console.ResetColor();
            /// màn hình sẽ in ra giá trị "Hello my friend!" nhưng không xuống dòng mới
            Console.Write("Hello my friend!");
            Console.WriteLine("KHông xuống dòng nè!");

            //bạn có thể dùng format string để tạo ra chuỗi in nhằm giảm thiểu dòng code 

            int a = 123;
            double b = 567.123;
            Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);
            //trong chuỗi định dạng trên chỗ nào có ký tự {0} thì sẽ thuộc thay thế bởi tham số thứ nhất a, 
            // và kí hiệu {1} thì thay thế bởi tham số thứ 2 b

            //ngoài ra cũng định dạng để chèn cả một biểu thức vào vị trí ấn định trong chuỗi, nếu trước kí 
            //hiệu chuỗi điền ký tự $, thì trong chuỗi chố nào muốn thay thế bằng biểu thức thì viết  
            //biểu thức tại đó và bọc trong cặp {}

            Console.WriteLine($"Biến a = {a}, biến b = {b} - tích là {a * b}");


            /*
             * NHập dữ liệu trong c#
             * có hàm Console.ReadLine() cho phép nhập dữ liệu đến khi nhấn Enter, hàm này trả 
             * về chuỗi mà người dùng nhập vào. Tương tự hàm Console.ReadKey() trả về ngay thông tin 
             * phím bấm khi người dùng bấm,
             */
            string userLogin;
            Console.Write("Nhập username: " );
            userLogin = Console.ReadLine();
            Console.WriteLine($"tên nhập vào là : {userLogin}");

            /*
             * Chuyển kiểu dữ liệu 
             * Mặc định hàm Console.ReadLine() trả về string nếu muốn chuỗi đó nhập xong 
             * chuyển thành các dữ liệu khác như int, float thì cần hàm chuyển kiểu đó là 
             * Convert.ToInt32(value) chuyển value thanhfkieeur int 
             * Convert.ToDouble(value) chuyển value thành kiểu double
             *
             * Khai báo kiểu ngầm định với var
             * Mặc định c# khi khai báo biến cần phải chỉ rõ một cách tường minh kiểu dữ liệu (int, float...)
             * của biến. Để linh hoạt, C# còn có một cơ chế khai báo biển với từ khóa var,
             * mà không cần chỉ rõ ngay kiểu dữ liệu của biến mà kiểu của biến được xác định theo kiểu biểu 
             * thức gán vào biến ngay sau đó (cũng có nghĩa là phải khởi tạo ngay)
             * 
             * 
             */
            var bien1 = 3.14; // biến sẽ có kiểu double 
            var bien2 = 3; // biến sẽ có kiểu int 
            var bien3 = "biến khai báo với var phải khởi tạo ngay"; // string
            var bien4 = (5 < 4); //bool
            /*
             * Hằng số trong C#
             * hằng số lưu trữ các giá trị mà không thay đổi được nữa , dùng từ khóa const để khai báo hằng 
             * số 
             */
            const string MON = "Thứ hai";
            Console.WriteLine(MON);
        }
    }
}
