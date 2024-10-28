using Microsoft.VisualBasic;
using System;

namespace _8.Day_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Lập trình hướng đối tượng (object-oriented programming - oop), là kỹ thuật lập trình mà điều cốt yếu cần trừu 
             * tượng hóa các vấn đề thành các đối tượng (đối tượng có dữ liệu và các ứng xử)
             * Kỹ thuật OOP có 4 tính chất 
             * 
             * 
             * Tính đóng gói (encapsulation) là việc bao gói dữ liệu và các phương thức thao tác dữ liệu vào cùng một lớp.
             * Các dữ liệu của đối tượng sẽ được bảo về và chỉ có thể truy cập thông qua các phương thức (getter/setter) của lớp đó
             * Mục đích: bảo vệ dữ liệu, ngăn không cho các phần bên ngoài truy cập trực tiếp vào thuộc tính của đối tượng, 
             * tránh việc dữ liệu bị thay đổi không mong muốn
             * 
             * Tính kế thừa (inheritance) là việc cho phép một lớp (lớp con) thừa hưởng các thuộc tính và phương thức của một lớp khác
             * (lớp cha). Điều này giúp tái sử dụng mã nguồn và giảm thiểu việc viết lại mã 
             * Mục đích: Tái sử dụng mã, tạo mối quan hệ phân cấp giữa các lớp và cho phép mở rộng tính năng dễ dàng 
             * 
             * Tính đa hình (Polymorphism) là việc cho phép các đối tượng khác nhau có thể phản hồi lại cùng một thông điệp hoặc lời
             * gọi hàm theo các cách khác nhau, tùy thuộc vào kiểu đối tượng thực sự,
             * Mục đích: Tạo ra tính linh hoạt, giúp các đối tượng có thể sử dụng cùng một tên phương thức nhưng có cách thực hiện khác nhau
             * 
             * 
             * Tính trừu tượng hóa (Abstraction): là quá trình ẩn đi các chi tiết không cần thiết và chỉ giữ lại các tính năng 
             * cần thiết của đối tượng giúp đơn giản hóa vấn đề.
             * Mục đích: tập trung vào các tính năng cốt  lõi của đối tượng, giảm đi sự phức tạp và tạo ra một giao diện dễ
             * hiểu cho người sử dụng
             * Ví dụ: class xe có các phương thức như diChuyen(), phanh() mà không cần tiết lộ chi tiết cách hoạt động bên trong
             * của phương thức này, Các lớp con như XeDap, XeHoi sẽ triển khai cụ thể các phương thức này theo cách riêng
             * 
             * Khái niệm chung về Class trong C#
             * 
             * trong lập trình hướng đối tượng, lớp (class) là một kiểu dữ liệu tham chiếu nó định nghĩa một tập hợp các biến
             * (trường dữ liệu, thuộc tính ) và phương thức (gọi chúng là các member - thanh viên lớp)
             * 
             * từ đó sinh ra các đối tượng, mỗi đối tượng có giá trị cụ thể ( lưu tỏng thành viên biến, thuộc tính ). Các 
             * phương thức (method) - định nghĩa ra các ứng xử của đối tượng - dựa theo dữ liệu của chúng 
             * 
             * Khai báo class, và sử dụng class
             * KHi giải quyết các vấn đề thực tiễn, các vấn đề cần giải quyết bạn cần tìm cách trừu tượng hóa nó thành vấn đề
             * tổng quát, như nó có các đặc tính gì, ứng xử của nó ra sao... Từ đó mới có thể định nghĩa ra class để hiện thực 
             * hóa vấn đề trừu tượng được 
             * 
             * Cú pháp cơ bản như sau: 
             * <Access Modifiers> class Class_Name{
             *      //khai báo các data member ( thuộc tính, biến dữ liệu ) 
             *      //khai báo các thành viên hàm (method)
             * }
             * 
             * Trong đó Access Modifiers áp dụng khai báo cho lớp có thể là: public  hoặc internal (mặc định nếu không khai báo,
             * giới hạn truy cập trong cùng assembly - chương trình)
             * Nếu class con khai báo lồng trong một lớp khác còn có thể sử dụng private
             * 
             * Khai báo và khởi tạo thành viên dữ liệu (biến, trường dữ liệu) giống với khai báo biến thuông thường, nhưng có thêm
             * Access Modifiers để quy định cấp độ truy cập. Đối với thành viên lớp (biến, thuộc tính, phương thức ) thì có thể 
             * áp dụng các access modifers
             * -public
             * -protected: chỉ truy cập trong nội bộ lớp hay các lớp kế thừa 
             * -private(mặc định)
             * -internal: chỉ truy cập được trong cùng assembly(dll, exe)
             * -protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa 
             * -private protected: truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly
             * 
             * Tạo và sử dụng đối tượng
             * như đã nói ở trên, class là một kiểu dữ liệu, nên để sử dụng nó có thể khai báo với biến kiểu dữ liệu là tên lớp
             * do bạn định nghĩa. Để tạo ra đối tượng lớp thì dùng từ khóa new với cú pháp new ClassName();
             * 
             * Toán tử dấu chấm (.) trong lập trình hướng đối tượng được gọi là toán tử truy cập thành viên (member access operator)
             * Toán tử này được sử dụng để truy cập các thuộc tính (properties), phương thức (methods), và trường (fields) của một đối
             * tượng hoặc lớp
             * 
             * Sau khi đối tượng (object) được tạo ra, bạn có thể truy cập đến các thuộc tính, trường dữ liệu và 
             * phương thưc của đối tượng đó bằng ký hiệu . theo quy tắc 
             * object.ten_thuoc_tinh hay object.ten_phuongthuc
             * 
             * Từ khóa this 
             * từ khóa this dùng trong các phương thức của lớp, nó tham chiếu đến đối tượng hiện tại sinh ra từ lớp. Sử dụng this để 
             * tường minh, tránh sự không rõ ràng khi truy cập thuộc tính, phương thức hoặc để lấy đối tượng lớp làm tham số cho các 
             * thành phần khác
             * 
             * 
             * Trường (Filed)
             * -Định nghĩa: Trường là một biến được khai báo trực tiếp trong một lớp hoặc cấu trúc (class hoăc struct) để lưu
             * trữ dữ liệu cho đối tượng hoặc lớp 
             * -phạm vi truy cập: thông thường các trường có phạm vi truy cập là private hoặc protected để ẩn chi tiết bên 
             * trong và bảo vệ dữ liệu. Tuy nhiên chúng cũng có thể là public
             * -tính chất: các trường cũ có thể là tĩnh (static) hoặc thuộc về đối tượng cụ thể
             * 
             * Thuộc tính (property) 
             * -định nghĩa: thuộc tính là các thành phần cho phép truy cập các trường của lớp thông qua phương thức 
             * get và set. Thuộc tính thường được sử dụng để điều khiển truy cập đến dữ liệu bên trong, bảo vệ các trường 
             * và cung cấp một giao diện công khai để lấy hoặc đặt giá trị 
             * -phạm vi truy cập: các thuộc tính thường có phạm vi truy cập public, giúp người bên ngoài có thể truy cập mà 
             * không can thiệp trức tiếp vào các trường
             * -tính chất các thuộc tính có thể có các thuộc tính đọc(get-only), ghi(set-only) hoặc cả hai (get-set)
             * 
             * Khi nào sử dụng Field
             * 1.Dữ liệu nội bộ: 
             * -nếu bạn chỉ cần lưu trữ dữ liệu cho mục đích nội bộ trong lớp và không cần cung cấp quyền truy cập cho bên ngoài
             * bạn có thể sử dụng field
             * 2.Hiệu suất:
             * -Field có thể cung cấp hiệu suất tốt hơn khi so với property vì bạn đang truy cập trực tiếp vào bộ nhớ mà không 
             * có overhead từ phương thức getter/setter. Tuy nhiên hầu hết trong các tình huống sự kahcs biệt về hiệu 
             * suất không đang kể
             * 3.Khi không cần logic
             * -nếu bạn không cần thực hiện bất kỳ logic nào khi lấy hoặc đặt giá trịm và chỉ đơn giản là cần một noi lưu trữ giá trị 
             * trường có thể là lựa chọn phù hợp
             * 
             * Khi nào sử udnjg Property 
             * 1.Kiểm soát truy cập:
             * -sử dụng property khi bạn cần kiểm soát cách mà giá trị được lấy hoặc đặt. Bạn có thể chỉ định getter là public và setter
             * là private để ngăn chặn việc thay đổi giá trị từ bên ngoài 
             * 2.Chứa logic:
             * -nếu bạn cần thực hiện một số logic từ truy cập hoặc cập nhập giá trị, bạn nên sử dụng thuộc tính. Điều này cho phép
             * bạn dễ dàng thêm logic mà không thay đổi cách mà dữ liệu được truy cập từ bên ngoài 
             * 3.Hỗ trợ dữ liệu tương tác:
             * -sử udnjg thuộc tính khi bạn cần dữ liệu tương tác với các công cụ hoặc thư viện khác như (Entity Framwork) vì chúng thường
             * yêu cầu sử dụng thuộc tính công khai để ánh xạ dữ liệu 
             * 4.Dễ dàng thay đổi trong tương lai
             * -sử dụng thuộc tính giúp mã của bạn dễ dàng bảo trì và thay đổi tỏng tương lai.Nếu bạn quyết định thêm logic vào việc
             * lấy hoặc cập nhập giá trị sau này, bạn có thểm diều đó mà không làm hỏng mã bên ngoài
             * 
             * 
             * PHương thức khởi tạo -Constructor
             * là phương thức của lớp, nó được thi hành ngay khi đối uotnjw được tạo ra bởi toán tử (new), phương thức khởi tạo có tên 
             * trùng với tên của lớp, không có kiểu trả về, bạn có thể tạo nhiều phương thức khởi tạo - các phương thức này đều có cùng 
             * tên với tên lớp như tham số khác nhau. Lúc này khi khởi tạo đối tượng với toán tử new tùy tham số khởi tạo mà nó sẽ gọi phương
             * thức khởi tạo tương ứng
             * Mục đích: là để khởi tạo các giá trị mặc định hoặc thiết lập trạng thái ban đầu cho các thuộc tính của đối tượng
             * 
             * Quá tải (Overloading) phương thức 
             * Kỹ thuật quá tải phương thức (Method Overloading) là cách thức triển khai khái niệm tính đa hình của lập trình hướng đối 
             * tượng. Quá tải phương thức là các phương thức có cùng tên nhưng tham số khác nhau(hàm có thể trả về kiểu dữ liệu khác nhau)
             * Tính đa hình (polymorphism) là cách ứng xử của đối tượng - ứng xử này là khác nhau tùy thuộc vào tình huống cụ thể
             * 
             * Tính đóng gói mục đích hạn chế tối đa việc can thiệp trực tiếp vào dữ liệu , hoặc thi hành các tác vụ nội bộ của đối tượng
             * Nói cách khác, một đối tượng là hộp đen đối với các thành phần bên ngoài, nó chỉ cho phép bên ngoài tương tác với nó ở 
             * một số phương thức thuộc tính, trường dữ liệu nhất định - hạn chế
             * 
             * C# triển khai tính đóng gói này chính là sử dụng các Access Modifiers: public, private, protected, internal khi khai báo 
             * lớp, method, property, field
             * 
             * Khi lập trình cố gawngstoois đa ẩn thông tin ra bên ngoài lớp càng nhiều càng tốt để đảm bảo tính đóng gói của kỹ thuật
             * lập trình OOP, nó giúp cho code dễ bảo trì và giám sát lỗi
             * 
             * Thuộc tính trong lớp
             * Trường dữ liệu (field) - khai báo như biến trong lớp, nó là thành viên của class , nó là biến. Trường dữ liệu có thể sử
             * dụng bởi các phương thức trong lớp, hoặc nếu nó public nó có thể truy cập từ bên ngoài nhưng cách hay hơn để đảm bảo 
             * tính đón gói khi cần try cập thuộc tính hãy sử udnjg phương thức còn bản thân thuộc là private
             * 
             * Thuộc tính, bộ truy cập accesstor setter/getter
             * Ngoài cách sử dụng field, thì khai báo property tương tự nhưng nó có cơ chế accessor(bộ truy cập) một cơ chế hết sứclinh
             * hoạt khi bạn đọc/ghi duwx liệu vào thuộc tính.
             * 
             * Thuộc tính accessor có thể khai báo thiếu set hoặc get, nếu thiếu set nó trở thành loại chỉ đọc (readonly).
             * Sử dụng set rất tiện lợi cho thao tác kiểm trả tính hợp lệ của dữ liệu khi gán, hoặc tự động thực hiện một số
             * tác vụ mối khi dữ liệu được gán
             */
           
        }
    }
    public class NhanVien {
        private string hoTen;//đây là một trường (field)
        public string HoTen { get; set; }//đây là một thuộc tính (property)
       
        
    }

}
