using System;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace _17.Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Delegate(hàm ủy quyền) là một kiểu dữ liệu, nó dùng để tham chiếu (trỏ đến) đến các hàm 
             * có tham số và kiểu trả về phù hợp với khai báo kiểu. Khi dùng đến delegate bạn có thể gán 
             * nó vào một, nhiều mehtod có sự tương thích về tham số, kiểu trả về, sau đó dùng nó để ogij mehtod
             * có thẻ dùng delegate để xây dựng các hàm callback đặc biệt là các Event
             * 
             * Để khai báo một delegate, khai báo giốn như cách khai báo phương thức nhưng có thêm từ khóa
             * delegate và không có thân method
             * 
             * Khi đã có ShowLog, nó dùng như một kiểu dữ liệu để khai báo các biến, các variable này có thể
             * gán vào nó các hàm có sự tương đồng về tham số và kiểu trả về với khai báo delegate
             * 
             */
            ShowLog showLog;
            /*
             * Thi hành delegate 
             * Sau khi biến delegate được gán hàm vào, có thể dùng biến delegate để thi hành bằng cách gọi 
             * 
             * varDelegate.Invoke(các-tham-số) hoặc varDelegate(các-tham-số)
             * 
             * Tạo 2 phương thức Info và Warning có tham số giống với ShowLog, nghĩa là có một tham số
             * kiểu string, trả về void:
             * 
             * Do Info, Warning có tương đồng về tham số với delegate trên, nên hai hàm này có thể dùng 
             * để gán vào biến kiểu ShowLog
             */
            TestShowLog();
            Program p = new Program();
            showLog = p.In;
            showLog("Bằng Chiu");

            /*
             * Gán nhiều phương thức vào delegate
             * Khi dùng delegate chạy một phương thức, cần đảm báo biến delegate đó đã được 
             * gán phương thức(biến khác null)
             */

            /*
             * Func và Action là hai mẫu delegate định nghĩa sẵn giúp bạn nhanh chóng tạo ra biến 
             * kiểu delegate mà không mất công khai báo
             * 
             * Kiểu cuối cùng trong khai báo Func là kiểu trả về của hàm,, có thể thiếu tham 
             * số nhưng không được thiếu kiểu trả về
             */
            Func<int, string, bool> bien1; // int và string là parameter còn bool là kiểu trả về

            bien1 = testFunc;
            Console.WriteLine(bien1(1, "1"));
            Console.WriteLine(bien1(1, "c"));

            /*
             * Sử dụng Action
             * Action tương tự như Func, điều khác duy nhất là nó không có kiểu trả về 
             * 
             */
            Action<int, int, int> bien2;
            bien2 = testAction;
            bien2(1, 2, 3);

            /*
             * Sử dụng Delegate làm tham số hàm
             * Có thể sử dụng delegate làm parameter của method, nó có vai trò như những 
             * hàm callback linh hoạt
             */
             TinhTong(5, 6 , (x) => Console.WriteLine($"hello {x}"));
            TinhTong(1, 2, MyCallback);
            
            Action<int> bien3;
            bien3 = (e) => Console.WriteLine("can " + e);
            bien3(5);
            //khi truyền action hoặc func gán với một method nào đó thì có nghĩa là 
            //delegate đó đã được ủy quyền để gọi cách hoạt động trong method đó
        }
        public static void MyCallback(string result)
        {
            Console.WriteLine($"hello {result}");
        }
        public static void TinhTong(int a, int b, Action<string> callback)
        {
            int c = a + b;
            callback(c.ToString());
        }
        public static void testAction(int a, int b, int c)
        {
            Console.WriteLine(a + b  + c);
        }
        public static bool testFunc(int a, string c)
        {
            if(a.ToString() == c)
            {
                return true;
            }
            else { return false; }
        }

        public delegate void ShowLog(string message);
        static public void Info(string s) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Infor: {0}", s));
            Console.ResetColor();
        }
        static public void Warning(string s) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Warning: {0}", s));
            Console.ResetColor();
        }
        public void In(string e)
        {
            Console.WriteLine("đẹp trai" + e);
            e = e + "hello";
            Console.WriteLine(e);


        }
        public static void TestShowLog()
        {
            ShowLog showLog;
            showLog = Info;
            showLog("Thông báo");

            showLog = Warning;
            showLog("Thông báo");

        }
        
    }
}
