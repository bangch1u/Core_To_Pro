using System;

namespace _4.Day_For_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Vòng lặp trong C# for do while và câu lệnh break continue
             * 
             * Vòng lặp for nhằm tạo ra một cấu trúc, thi hành khối lệnh nào đó một số lần chỉ định
             * for (khởi_tạo; điều_kiện; cập_nhập)
             * {
             *      //các câu lệnh trong khối
             *  }
             *  
             *  Câu lệnh này sẽ hoạt động như sau:
             *  1 đầu tiên nó thi hành câu lệnh khởi_tạo, thường chỗ này ta khởi tạo bộ đếm 
             *  vòng lặp như int i = 1; j = 10;
             *  2 kiểm tra biểu thức logic điều_kiện, nếu true thì bắt đầu thi hành khối 
             *  lệnh {...} sau đó sang 3, nếu false thì thoát vòng lặp 
             *  3 thi hành biểu thức cập_nhập, chỗ này ta thường dùng để tăng - giảm bộ
             *  đếm như i++; thi hành xong thì quay lại 2
             *  
             *  trong for bạn có thể không có khởi_tạo, điều_kiện, cập_nhập nhưng dấu ; ngăn 
             *  cách chúng vẫn phải có và quy trình các bước của for ở trên sẽ bỏ qua bước đó
             *  mà thực hiện bước tiếp theo luôn
             *  
             */
            //ví dụ , thiếu khởi_tạo và cập_nhập sẽ bỏ qua bước 1 và 3: 
            int j = 10;
            for(;j <= 20;)
            {
                Console.WriteLine("Số j = " + j);
                j += 2;
            }
            /*
             * KHi viết thiếu các thành phần như trên hết sức lưu ý để đảm bảo khởi tạo và 
             * lặp số lần hữu hạn, nếu không dễ dần tới vòng lặp vô tận ví dụ vòng lặp vô tận
             * for (; ;) {}
             * hoặc
             * for (; ;);
             * 
             * 
             * Vòng lặp while c#
             * cú pháp:
             * while (điều kiện)
             * {
             *      //lặp nếu điều_kiện bằng true
             *  }
             *  
             *  câu lệnh này đầu tiên kiểm tra điều_kiện nếu bằng true thi hành khối lệnh nếu false
             *  thoát vòng lặp, thi hành xong lại kiểm tra lại điều_kiện và nếu vẫn bằng true
             *  lại thi hành khối lệnh ... cứ thế cho đến khi điều_kiện là false
             *  
             *  cần lưu ý, viết vòng lặp cần đảm bảo lặp số lần hữu hạn (điều_kiện bằng false sau số
             *  lần lặp mong muốn
             *  
             *  Vòng lặp do...while 
             *  cú pháp:
             *  do
             *  {
             *      //khối lệnh
             *  }
             *  while (điều_kiện);
             *  
             *  vòng lặp này khác while ở chỗ, nó thi hành khối lệnh trước, sau đó mới kiểm tra
             *  điều_kiện, kiểm tra thấy điều_kiện vẫn true thì lặp tiếp
             *  
             *  Vòng lặp do...while khối lệnh lặp bao giờ cũng được thực hiện ít nhất một lần
             *  
             *  Lệnh break và continue trong c#
             *  Hai lệnh break và continue hỗ trợ việc điều hướng các vòng lặp 
             *  
             *  Trong vòng lặp, nếu gặp break vòng lặp sẽ thoát ngay lập tức - và chuyển đến các 
             *  câu lệnh sau vòng lặp 
             *  
             *  Trong vòng lặp, nếu gặp continue thì tương đương việc đến cuối khối lệnh của lần lặp đó
             *  (bắt đầu thực hiện lần lặp mới ngay)
             *  
             */
        }
    }
}
