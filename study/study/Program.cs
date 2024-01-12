

namespace study
{
    public class Program
    {

        static int Sum(int value1, int value2)
        {

            int result = value1 + value2;

            return result;

        }


        public static void Main(string[] args)
        {

            fish fish1 = new fish()
            {
                source = "슈크림",
                price = 500
            };

            fish fish2 = new fish() { 
                source = "팥",
                price = 300
            };

            int fish1_2 = fish1.price * 2;
            int fish2_3 = fish2.price * 3;

           int Sumresult = Sum(fish1_2, fish2_3);

            //// See https://aka.ms/new-console-template for more information
            Console.WriteLine("1번값을 입력해주세요.");


            //string value1 = Console.ReadLine();

            //bool isInt = Int32.TryParse(value1, out int intvalue1);

            //if (!isInt) {



            //    Console.WriteLine("숫자를 입력해주세요!");

            //    return;

            //}

            ////int intvalue1 = Convert.ToInt32(value1);


            //Console.WriteLine("2번값을 입력해주세요.");

            //string value2 = Console.ReadLine();



            ////string name = "정명호";

            //Console.WriteLine(value1 + "값과" + value2 + "값을 더합니다.");

            //int intvalue2 = Convert.ToInt32(value2);



            //Console.WriteLine(intvalue1 + intvalue2);




        }



    }
}



