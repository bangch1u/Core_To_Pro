using System;

namespace _2.Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Các toán tử số học trong C#
             * Toán tử đó là các kí hiệu ( + - * / % && !...) được dùng để thi hành các tính toán
             * về toán học hay biểu thức logic
             * 
             * Trong C# hỗ trợ những toán tử về số học sau:
             * + phép cộng 
             * - phép trừ
             * * phép nhân
             * "/" phép chia : Nếu số chia và số bị chia thì phép toán / sẽ lấy phần nguyên.
             * Nếu muốn lấy giá trị thực chính xác cần chuyển số chia hoặc số bị chia thành số thực.
             * % phép chia lấy dư (modules)
             */
            Console.WriteLine($"Phép toán chia sẽ lấy phần nguyên khi kiêu dữ liệu int {1/2}");
            Console.WriteLine($"Phép toán chia sẽ ra kết quả chính xác khi kiêu dữ liệu là số thực {1/2.2}");
            
            Console.WriteLine($"Phep chia nay se lay du {8%3}");
            /*
             * Thứ tự ưu tiên của các toán tử trong biểu thức 
             * Một số biểu thức có thể có nhiều số hạng, kết hợp lại bởi nhiều toán tử và ký hiệu (),
             * lúc này cần biết thự tự ưu tiên để tính được chính xác giá trị biểu thức 
             * Trong biểu thức, toán tử nào có độ ưu tiên cao hơn sẽ được itnhs trước
             * 
             * Độ ưu tiên từ cao xuống tháp là: 1 trong ngoặc (), 2 số mũ - căn, 3 nhân hoặc chia * /,
             * 4 cộng hoặc trừ + -
             * 
             * Toán tử gán trong c# 
             * Toán tử gán, dùng để gán giá trị(biểu thức giá trị) vào biến.
             * 
             * = toán tử gán: gán biểu thức bên phải của = vào biến biến trái
             * += toán tử cộng thêm: công thêm vào biến bên trái += giá trị bên phải 
             * -= toán tử trừ bớt: bớt đi giá trị biến bên trái của -= một lượng bằng biểu thức bên phải 
             * *= toán tử nhân với: a *= b tương đương a = a * b
             * "/=" toán tử chia : a /= b tương đương a = a / b
             * %=  toán tử gán modulde: a %= b tương đương a = a % b
             * 
             * Toán tử tăng ++ và giảm -- trong c#
             * Toán tử ++ thêm vào biến 1 đơn vị, còn -- bớt đi một đơn vị toán tử này có thể
             * viết bên trái hoặc bên phải biến
             * 
             * Nếu biến độc lập thì viết ++ hoặc -- bên trái hay bên phải không có khác biệt.
             * Tuy nhiên trong biểu thức thì có sự khác biệt
             * 
             * Nếu viết trước ++x thì toán tử ++ thi hành trước rồi mới áp dùng vào biểu thức, nếu 
             * viết sau dạng x++ thì biểu thức thi hành xong mới đến ++ (tương tự --)
             * 
             */
            int a = 5;
            Console.WriteLine($"Đây là a ban đầu {a}");
            int b = 2 * a++; // b = 10, a = 6
            Console.WriteLine(b);//biểu thức sẽ được thi hành trước sau đó mới đến a++
            Console.WriteLine($"Đây là a: {a}");
            int d = 5;
            int c = 2 * ++d;
            Console.WriteLine(c);//++d sẽ được thi hành trước sau đó mới đến biểu thức thi hành
            Console.WriteLine($"Đây là a: {d}");
        }
    }
}
