using System;

namespace _10.Day_ThamChieu_ThamTri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * 
             * 
             * Kiểu tham trị và kiểu tham chiếu là hai nhóm chính phân loại kiểu dữ liệu của c#.
             * Một biến kiểu tham trị thì biến đó sẽ luuw giá trị của đối tượng lưu trữ, khác với kiểu tham
             * chiếu biến chứa địa chị trỏ đến nơi lưu đối tượng thưc.Kiểu tham trị mặc định trong các phép
             * toán gán, truyền tham số phương thức, kể cả trả về hàm - thì giá trị được sao chép
             * 
             * 
             * Khi biến thuộc các kiểu sau, mặc định nó ứng xử là kiểu tham trị 
             * -các kiểu số nguyên như int, byte,long...
             * -các kiểu số thực như float, double, decimal
             * -kiểu bool, kiểu char
             * -kiểu cấu trúc struct
             * -kiểu liệt kê enum
             * -kiểu tuple
             * 
             * 
             * Kiểu tham chiếu trong C#
             * Các biến kiểu tham chiếu nó chứa tham chiếu (địa chỉ nhớ) trỏ đến dữ liệu (là đối tượng), với
             * kiểu tham chiếu hai biến, hay nhiều biến có tên khác nhau có thể cùng trỏ đến cùng một đối
             * tượng, khi đó dùng biến nào truy cập, tác động vào đối tượng đều mang lại kết quả như nhau.
             * 
             * Như vậy khi dùng kiểu tham chiếu, truyền dữ liệu trong hàm hay các phép gán thì không phải là
             * copy đối tượng hay giá trị mà chỉ truyền tham chiếu (địa chỉ nhớ)
             * 
             * Những biến có keieur sau thì nó là kiểu tham chiếu:
             * -biến kiểu lớp (class), các lớp thư viện hoặc lớp do bạn định nghĩa 
             * -biến kiểu delegate
             * -biến kiểu interface, các giao diện từ thư viện hoặc tự định nghĩa
             * -biến kiểu dynamic
             * -biến kiểu object
             * -biến kiểu string
             */
            Student a = new Student("Nguyen Van A");
            Console.WriteLine(a.Name);
            Student b;
            //khi gán , tham chiếu không sao chép giá trị mà tham chiếu địa chỉ 
            //nên có thể có a là b, b là a, b thay đổi nghĩa là a thay đổi
            b = a;
            b.Name = "Nguyen Van B";
            Console.WriteLine(a.Name);

            a.Name = "Nguyen Van C";
            Console.WriteLine(b.Name);
            Console.WriteLine(a.Name);
        }

    }
    class Student
    {
        public string Name;//field
        public Student(string name)//constructor
        {
            this.Name = name;
        }

    }


}
