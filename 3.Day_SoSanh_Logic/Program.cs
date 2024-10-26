using System;

namespace _3.Day_SoSanh_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Toán tử so sánh logic và các câu lệnh if switch trong c#
             * == so sánh bằng 
             * > so sánh lơn hơn 
             * >= so sánh lơn hơn hoặc bằng 
             * < so sánh nhỏ hơn 
             * <= so sánh nhỏ hơn hoặc bằng 
             * != so sánh khác 
             * 
             * Các toán tử logic 
             * các toán toán tử logic thực hiện trên các số hạng kiểu bool và trả về kết quả bool
             * là true hoặc false
             * 
             * && phép toán VÀ - trả về true nếu cả hai số hạng đều true, còn lại trả về false
             * || phép toán HOẶC - trả về true nếu 1 trong hai số hạng là true, còn lại false
             * ! Viết trước số hạng, giá tị trả về true nếu số hạng là false và ngược lại
             * 
             * Câu lệnh if
             * if(điều_kiện)
             * câu lệnh;
             * 
             * hoặc thi hành cả khối lệnh 
             * if(điều_kiện)
             * {
             *      các_câu_lệnh;
             *  }
             *  
             *  if(điều_kiện)
             *  {
             *      các câu lệnh;//được thực hiện nếu điều_kiện đúng
             *  }
             *  else
             *  {
             *      các_câu lệnh;//được thực hiện nếu điều_kiện sai
             *  }
             *  
             *  Câu lệnh ba thành phần với toán tử ?
             *  
             *  
             */
            
            int age = 18;
            //khi viết
            var mgs = (age >= 18) ? "Đủ điều kiện" : "Không đủ điều kiện";
            Console.WriteLine(mgs);

            //tương đương với 
            string mgs2;
            if(age >= 18)
            {
                mgs2 = "Đủ điều kiện";
            }
            else
            {
                mgs2 = "Không đủ điều kiện";
            }
            Console.WriteLine(mgs2);

            //ví dụ tìm số lớn nhất trong các số a, b, c
            var a = 2;
            var b = 3.1;
            var c = 2;
            var max = a >= b ? a >= c ? a : c : b >= c ? b : c;
            //viết tường minh hơn
            //max = (a > = b) ? ( a >= c ? a : c) : (b >= c ? b : c)
            Console.WriteLine(max); ;
            if(a >= b)
            {
                if(a >= c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }else
            {
                if(b >= c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }
            //? tượng trưng cho điều kiện trong if(), còn : thì sẽ lại else

            /*
             * Câu lệnh rẽ nhành switch
             * Câu lệnh switch...case áp dụng cho cấu trúc rẽ nhiều nhánh, nó thay thế cho nhiều câu lệnh
             * else if
             * switch(expr)
             * {
             *      case expr1:
             *          //các lệnh thi hành nếu expr == expr1
             *      break;
             *      case expr2:
             *          //các lệnh thi hành nếu expr == expr2
             *      break;
             *      //.....
             *      default:
             *      //..
             *      break;
             *  }
             *  Câu lệnh switch trên sẽ so sánh expr với các biểu thức sau từ khóa case là expr1, expr2....
             *  nếu bằng biểu thức nào thì bắt đầu thi hành lệnh từ khối case đó cho đến khi 
             *  gặp break (nếu không gặp break nó sẽ thi hành cho đến cuối)
             *  
             *  Nếu có khối default, nó sẽ thi hành nếu expr không rẽ nhành vào case nào.
             */
            int number = 2;
            switch (number)
            {
                case 1:
                    Console.WriteLine("number có giá trị một");
                    break;
                case 2:
                    Console.WriteLine("number có giá trị hai");
                    break;
                default:
                    Console.WriteLine("number khác một và hai");
                    break;

            }
            //In ra : number có giá trị hai
        }
    }
}
