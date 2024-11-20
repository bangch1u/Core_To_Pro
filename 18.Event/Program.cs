using System;

namespace _18.Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Các sự kiện (Event) là cơ chế để một object của class này thông báo đến 
             * object khác có điều gì đó mà class khác quan tâm vừa xảy ra. Class mà từ đó 
             * gửi đi Event gọi tên nó là publisher và các class nhận được event đó gọi là 
             * subsriber 
             * 
             * Để làm được việc này nó hoạt động giống hệt co chế delegate, thực tế trong.Net
             * các Event xây dựng với nên tảng chính là delegate
             */
        }
    }
}
