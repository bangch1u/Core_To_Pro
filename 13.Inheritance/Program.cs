using System;

namespace _13.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Inheritance (kế thừa)
             * 
             * Inheritance là 1 trong 4 khía cạnh của OOP:
             * OOP: 
             * - Encapsulation (đóng gói)
             * - Abstraction (trừu tượng)
             * - Inheritance (kế thừa) 
             * - Polymorphism (đa hình)
             * 
             * Inheritance là khả năng cho phép chúng ta định nghĩa moojt class mới dựa trên một class có sẵn.
             * Inheritance giúp cho việc mở rộng code - bảo trì dễ hơn
             * 
             * Class cơ sở: là class mà được class khác kế thừa
             * Class kế thừa: là class kế thừa lại properties, method từ class cơ sở
             * 
             * 
             */
            Cat cat = new Cat("Bongjour");
            cat.ShowLegs();             // Phương thức này kế thừa từ lớp cơ sở
            cat.Eat();                  // phương thức của riêng Cat

            // Legs: 4
            // Mouse

            /*
             * C# không hỗ trợ đa kế thừa ( mỗi clas kế thừa chỉ có một lớp cơ sở) 
             * 
             * Thành viên được bảo vệ (protected) của class cơ sở 
             * 
             * Access Modifiers: không phải tất cả các thành viên của class cha có thể truy cập được từ 
             * class con. Các thành viên, khi khai bóa nó có thể có  các Modify như public, private, protected
             * internal
             */
            Animal a = new Cat("Konichiwa");
            //a.Legs không thể truy cập được do đã được bảo vệ protected
            a.ShowLegs();
            /*
             * Trong kỹ thuật lập trình OOP, để đảm báo Encapsulation (đóng gói) các thành viên (properties, method)
             * class cơ sở thường khai báo là protected, có nghĩa là truy cập được bởi class kế thừa - nhưng không
             * thể truy cập được bên ngoài class
             */

            /*
             * Lớp niêm phong sealed
             * Trong lập trình OOP là một lớp không thể bị kế thừa (Inheritance). Khi một class được đánh dấu là sealed
             * các class khác không thể inherit từ class đó, điều này giúp ngừng việc tạo ra các class con 
             * từ lớp niêm phong. Việc sử dụng lớp niêm phong (sealed) có thể help kiểm soát và bảo vệ mã nguồn
             * khỏi việc mở rộng ngoài ý muốn
             * 
             */
            
        }
    }

    class  Animal
    {
        protected int Legs { get; set; } // chỉ có thể truy cập được nếu kế thừa từ lớp này
        public float Weigh { get; set; }
        public Animal(string Hello)
        {
            Console.WriteLine(Hello);//khi animal được khởi tạo sẽ hello 
        }

        public void  ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");
           
        }
    }
    class Cat : Animal
    {
        public string food;      // thuộc tính mới thêm

        public Cat(string abc) : base(abc) // base(abc) là chỉ ra hàm constructor của class cha sẽ chạy, đó là hàm có 1 tham số và giá trị tham số được truyền vào
        {
            Legs = 4;           // Thuộc tính Legs có sẵn - vì nó kế thừa từ Animal
            food = "Mouse";
        }

        public void Eat()
        {
            Console.WriteLine(food);
            
        }
    }
    sealed class NiemPhong
    {
        public string id;
    }
    //class MuonKeThuaNiemPhong : NiemPhong // sẽ failed vì class NiemPhong đã bị (sealed class)- ngăn chặn kế thừa
    //{
    //    public string hihi;
    //}
}
