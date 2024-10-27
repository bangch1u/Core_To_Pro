using System;

namespace _6.Day_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Khai báo phương thức trong C#
             * Phương thức (method, gần giống với function trong lập trình hướng thủ tục)
             * trong C# là một nhóm các lệnh nhằm thực hiện một tác vụ nào đó, dùng phương thức 
             * để sử dụng lại code, dễ dàng kiểm tra và bảo trì ứng dụng. Phương thức có thể thuộc 
             * về một đối tượng nào đó, hoặc không tuy nhiên khai báo phương thức thì phải khai báo 
             * trong một lớp nào đó.
             * 
             * Class (lớp) là một cách tổ chức code của lập trình hướng đối tượng
             * 
             * Cú pháp khai báo một phương thức cơ bản như sau: 
             * <Access Modifiers> <return type> <name_method> (<parameters>)
             * {
             *      //các câu lệnh trong phương thức 
             * }
             * 
             * Access Modifiers cho biết cấp độ được phép truy cập đến hàm này,
             * có các mức độ như public, private, protect, internal... Nếu thiếu thành phần này thì 
             * mặc định coi là internal (truy cập được ở các file cùng assemble cùng file code).Ngoài
             * ra nếu cho từ khóa static ở trước Access Modifiers thì phương thức (hàm) đó gọi là 
             * Phương thức tĩnh (static method)-(Truy cập được mà không cần tạo đối tượng), thường
             * dùng kèm với Access Modify tên phublic để tạo các hàm chức năng tiện ích.
             * 
             * return type là kiểu trả về của hàm như int, double, string... nếu hàm không có kiểu trả về
             * thì để từ khóa void 
             * 
             * name_method tên của phương thức 
             * 
             * parameters là các tham số của hàm nếu có, các tham số khai báo theo mẫu kiểu tên như 
             * int thamso1, nhiều tham số thì cách nhau bởi dấu ,
             * 
             * cuối cùng là phần thân hàm {}, trong đó chứa các câu lệnh mà khi hàm được gọi nó sẽ thi hành 
             * theo logic của code từ đầu đến cuối hoặc khi gặp lệnh return value(với value là giá trị, 
             * đói tượng, biểu thức có cùng kiểu trả về của hàm) 
             * 
             */
            Console.WriteLine(tong(1,2));



            /*
             * Gọi phương thức trong c#
             * 
             * để gọi, thực thi phương thức ta chỉ việc viết tên đầy đủ của phương thức và truyền tham số như ở khai báo
             * 
             * Tham số trong phương thức 
             * phương thức có thể khai báo không tham số, một hoặc nhiều tham số.
             * 
             * Tham số có giá trị mặc định 
             * Nếu muốn gọi phương thức có các tham số, mà mong muốn tham số đó sẽ nhận giá trị mặc định khi không được 
             * truyền giá trị thì khai báo tham số khởi tạo ngay cho nó một giá trị mặc định bằng phép gán = 
             * 
             */
            Console.WriteLine(tong());

            /*
             * Truyền tham số với tên
             * Khi gọi phương thức như các ví dụ trên, bạn truyền các tham số bằng cách điền giá trị tham số sau tên phương thức
             * - các tham số viết  đúng thứ tự khi nó được khai báo 
             * 
             * Trong c# nó còn có cơ cheess truyền tham số bằng cách chỉ tên và giá trị khi gọi theo cấu trúc tên:giá-trị
             * nếu có nhiều tham số thì cấu trúc cách nhau bởi dấu , điều này giúp cho việc không phải viết đúng thứ tự như 
             * khai báo, có tên khi gọi nên dễ đọc hơn
             */

            Console.WriteLine(tong(a:3, b:4));

            /*
             * Truyền tham số tham chiếu và tham trị c#
             * 
             *Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu 
             *
             *  -tham trị là cách thức mặc định ta đã sử dụng ở phần trên. Có nghĩa là gán tham số bằng một biến, thì giá trị 
             *  của biến được copy và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài  không 
             *  hề ảnh hưởng.
             *  
             *  -tham chiếu thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp(tham chiếu) chứ không tạo ra một biến 
             *  cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài. Để sử dụng được tham chiếu thì khai báo
             *  tham số ở phương thức, cũng như khi gọi cần thêm từ khóa ref
             *  
             *  Tham số là các đối tượng lớp, mặc định là tham chiếu.
             */
            int value1 = 3;
            int value2 = 4;
            Console.WriteLine(refTong(ref value1, d:value2));//tham chiếu cần dùng ref ở đầu các tham số, nó sẽ làm thay đối 
            //giá trị của tham số  truyền vào đó. (Lưu ý giá trị tham số truyền vào phải là biến)
            //còn tham trị sẽ chỉ lấy bản copy của tham số đó và không làm thay đối giá trị của tham số.
            Console.WriteLine("Đây là value1: "+ value1);
            Console.WriteLine("Đây là value2: "+ value2);

            /*
             * Tham chiếu với out
             * Ngoài dùng từ khóa ref trong khai báo tham chiếu, bạn cũng có thể thay nó bằng từ khóa out,
             * điểm khác biệt duy nhất là nếu dùng từ khóa out thì tham số không cần phải khởi tạo khi truyền cho phương thức
             * còn dùng ref thì biến làm tham số phải khởi tạo
             */
             int value3;
             int value4 = 6;
            /*
             * Vì các tham số truyền vào không cần khởi tạo nên do đó bắt buộc khi kết thúc method có chưa đối số dùng tham 
             * chiếu out phải được gán giá trị cho tham số truyền vào.
             */
            Console.WriteLine(outTong(out value3));
            Console.WriteLine("Đây là value3: " + value3);

            /*
             * Phương thức đệ quy
             * Đệ quy là phương thức khai báo, trong thân của nó có gọi lại chính nó. Ví dụ cổ điển cho ứng dụng đệ quy 
             * là tính giai thừa của một số 5! = 5.4.3.2.1
             * 
             * 
             */
         
        }
        static int tong(int a = 0, int b = 0) => a + b;
        static int refTong(ref int c, int d) => ++c + d;  
        static int outTong(out int e) => e=10;  
        static int giaiThua(int a)
        {
            if(a == 1)
            {
                return 1;//kết thúc đệ quy
            }
            return a * giaiThua(a - 1);
        }
    }
}
