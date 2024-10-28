using System;

namespace _9.Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             *Phương thức khởi tạo (constructor) 
             *
             *Khi một đối tượng của lớp (Class) hay cấu trúc (srtuct) được tạo, thì phương thức khởi tạo của lớp được gọi.
             *Phương thức khởi tạo có cùng tên với tên lớp, có thể có nhiều phương thức khởi tọa những mỗi phương thức khởi 
             *có các tham số khác nhau. Phương thức khởi tạo là nơi bạn khởi tạo các giá trị dữ liệu, nó giúp cho việc đọc
             *code dễ hơn và sử dụng lớp một cách mềm dẻo hơn. 
             *
             *Nếu bạn không xây dựng phương thức khởi tạo nào cho class, C# sẽ tạo ra một phương thức khởi tạo ngầm định,
             *nó thiết lập giá trị các thành viên dữ liệu nhận giá trị mặc định (tùy theo kiểu dữ liệu)
             *
             *Trong C# các lớp có tính kế thừa, một lớp có thể kế thừa lại các thuộc tính, phương thức từ lớp khác (lớp cơ
             *sở), lưu ý nếu class cha (cơ sở) có xây dựng phương thức khởi tạo, thì cần chỉ định rõ gọi phương thức khởi
             *tạo nào của lớp cơ sở (truyền tham số) khi phương thức khởi tạo lớp con thi hành.Thực hiện điều này bằng 
             *cách dùng từ khóa base ở khai báo tên phương thức
             *
             *
             *Phương thức khởi tạo tĩnh 
             *Bạn có thể xây dựng một phương thức khởi tạo không tham số có chỉ thị truy cập là static, phương thức 
             *khợi tạo này dùng để khởi tạo các thành viên dữ liệu tĩnh, nó tự động gọi khi tủy cập một thành 
             *viên dữ liệu tĩnh lần đầu
             */

        }
    }
    class Category
    {
        private string categoryName;
        public Category(string nameOfCategory)
        {
               categoryName = nameOfCategory;   
        }
        public Category(string nameOfCategory1, int he)
        {
            categoryName = nameOfCategory1;
            
        }
        public string Name
        {
            set => categoryName = value;    
            get => categoryName;
        }
    }
    class CategoryMobile : Category
    {
        private string desciption;

        public CategoryMobile(string nameOfCategory, string mota, int he) : base(nameOfCategory,he)
        {
            desciption = mota;
        }
        public string Desciption
        {
            set => desciption = value;
            get => desciption;
        }

    }

}
