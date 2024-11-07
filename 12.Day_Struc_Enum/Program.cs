using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace _12.Day_Struc_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Struct kiểu dữ liệu cấu trúc (còn gọi là structure) - kiểu dữ liệu này tạo thành khi ta muốn gộp 
             * các dữ liệu có liên quan thành một nhóm (đóng gói dữ liệu ). ĐỂ tạo ra kiểu dữ liệu cấu trúc dùng đến
             * từ khóa struct với khai báo khá giống khai báo class, tuy nhiên struct là  thuộc nhóm kiểu giá trị C# chứ 
             * không phải kiểu tham chiếu (Do đó, truyền tham số dùng struct là tham trị) Trong struct có thể
             * chứa: trường dữ liệu, thuộc tính, phương thức khởi tạo, hằng số, các phương thức, toán tử, sự kiện.
             * 
             * Thông thường sử dụng struct để gộp một nhóm nhỏ các dữ liệu, mục đích chính là lưu trữ dữ liệu  rất hạn
             * chế tạo ra các ứng xử trên struct (các method)
             * 
             * Do là kiểu giá trị (tham trị) với các trường dữ liệu, nên có thể khai báo - khởi tạo 
             * các trường và sử dụng như kiểu giá trị
             */
            Product prodcutA; // 
            Product prodcutB;
            prodcutA.Name = "Nguyễn Trọng Bằng";
            prodcutA.Price = 100;
            prodcutB = prodcutA;
            prodcutB.Name = "Đạt đụt";
            Console.WriteLine(prodcutA.Name);//sẽ không bị thay đổi giá trị, vì kiểu struct là kiểu tham chiếu
            //chỉ copy giá trị chứ không cùng tham chiếu đến một địa chỉ như kiểu tham chiếu
            P p = new P();
            /*
             * Phương thức khởi tạo struct
             * 
             * Trong struct cũng có constructor như class, nó dùng để khởi tạo giá trị các field or properties. 
             * khi có method constructor muốn run nó thì phải used toán tử new để có bản thực thi của struct.
             * Một lưu ý là phương thức khởi tọa bắt buộc phải khởi tạo toàn bộ thành viên dữ liệu (field, prop) 
             * có trong struct
             * 
             * Properties in struct 
             * 
             * Trong struct cũng có thể khai báo các properties, chỉ cần lưu ý đã có thuộc tính thì 
             * bắt buộc phải khởi tạo nó một cách tường minh nếu không sẽ lỗi
             * 
             * Sự khác nhau giữu class và struct 
             * 
             * Struct phù hợp khi muốn gom một lượng nhỏ các biến kiểu nguyên thuy (int, float...) thuộc tính
             * lại với nhau. Class thì dùng khi các diễn tả đối tượng chứa các biến, thuộc tính và 
             * xử lý dữ liệu phức tạp 
             * 
             * Struct có thể dùng khai bóa biến mà khồng cần  thao tác tạo đối tượng (không cần toán tử new). Biến 
             * kiểu Struct là tham trị(copy value) còn biến class là tham chiếu (trỏ tới địa chỉ tham chiếu),
             * struct được lưu ở bộ nhớ stack, còn đối tượng được sinh ra bởi class được lưu ở bộ nhớ heap 
             * -bộ nhớ heap được quản lý, giám sát, thu hồi tự động bởi GC
             * 
             * Sử dụng kiểu liệt kê (Enumeration Type) - enum 
             *Kiểu liệt kê (enum) khai bóa một tập hợp các const(hằng số) có tên. Mặc định value của các hằng số này 
             *là kiểu int và bắt đầu từ 0 trở đi trong khai báo kiểu liệt kê. Enum thuộc dạng kiểu giá trị như
             *struct. Để khai báo một kiểu liệt kê thì dùng từ khóa enum
             *
             *
             *Mặc định enum sẽ thiết lập tên các khai báo sẽ nhận giá trị tương ứng từ 0, 1, 2... 
             *Tuy nhiên, bạn có thể gán một tên nào đó với giá trị cụ thể
             *
             *Để nhận giá trị enum - bạn dùng toán tử. rồi đến tên phần tử
             */
            int a = Convert.ToInt32(HocLuc.TrungBinh);
            /*
             * KHai báo kiểu enum rất phù hợp khi giá trị của biến nhận một giá trị const trong tập const hữu hạn nào
             * đó. Như danh sách các ngày trong week, status online /offline và đặc biệt hay dùng Enum 
             * với switch
             */
            static void test_enum()
            {

                HocLuc hocluc = HocLuc.Kha; // khai báo biến hocluc kiểu enum và khởi tạo giá trị bằng HocLuc.Kha
                switch (hocluc)
                {
                    case HocLuc.Kem:
                        Console.WriteLine("Học lực kém");
                        break;
                    case HocLuc.Kha:
                        Console.WriteLine("Học lực Kha");
                        break;
                    case HocLuc.Gioi:
                        Console.WriteLine("Học lực Giỏi");
                        break;
                    default:
                        Console.WriteLine("Học lực TB");
                        break;

                }
            }
        }
       
      
    }
    public struct Product
    {
        public string Name; // product field name
        public decimal Price; // product fied price
        public Product(string _name)
        {
            // trong cấu trúc có bao nhiêu trường dữ liệu, thuộc tính
            // phải khởi tạo hết trong hàm tạo (thiếu sẽ lỗi)
            Name = _name;
            Price = 100;
        }

        //information method
        public override string ToString()
        {
            return $"{Name}: {Price}";
        }
    }
    public class P
    {
        public int Id;
    }
    enum HocLuc { Kem, TrungBinh, Kha = 5, Gioi }; // do kha có value = 5, nên tiếp theo gioi là 6
}
