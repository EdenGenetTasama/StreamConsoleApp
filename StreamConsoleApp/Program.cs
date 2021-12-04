using System;
using System.IO;


namespace StreamConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileStream fileStreamOne = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/textTry", FileMode.Append);
            //using (StreamWriter writerOne = new StreamWriter(fileStreamOne))
            //{
            //   string firstName = Console.ReadLine();
            //    string lastName = Console.ReadLine();

            //    writerOne.WriteLine(firstName+" " + lastName);

            //}


            //FileStream fileStreamThree = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/text", FileMode.OpenOrCreate);
            //using (StreamWriter writerThree = new StreamWriter(fileStreamThree))
            //{
            //    writerThree.WriteLine("try to change two");
            //}

            //FileStream fileStreamSecond = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/textTwo", FileMode.CreateNew);
            //using (StreamWriter writerTwo = new StreamWriter(fileStreamSecond))
            //{
            //    writerTwo.WriteLine("Hello first Stream");
            //}


            /////////////////////////////////////////////////////////////////////////////////    שאלות  ///////////////////////////////////////////////////////////
            //צרו פונקציה שמקבלת מהמשתמש גיל ושומרת אותו בקובץ 

            //FunctionOneTesk(int.Parse(Console.ReadLine()));



            //צרו פונקציה שמבקלת מהמשתמש אימייל במידה והאורך גדול מ5 היא שומרת אותו בקובץ חדש
            //FunctionTwoTesk(Console.ReadLine());

            //

            /// שאלה שלישית:





            //READ LINE 
            //ReadFirstFunction();



            //5;
            //ReadSecondFunction();




            //6

            //GetSum(5, 9);



            //7:
            //CheakIfRandomNumExsist(int.Parse(Console.ReadLine()));




            //8:
            static void 




        }

        //1:
        static void FunctionOneTesk(int age)
        {
            FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/ages-file", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine(age);
            }
        }

        //2:


        static void FunctionTwoTesk(string email)
        {
            if (email.Length > 5)
            {
                FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/emails-file", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {

                    writer.WriteLine(email);

                }

            }
        }

        //3
        static void FunctionThreeTesk(int number)
        {
            FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/numbers-file", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                //if (number.length > 10)
                //{

                //}
            }
        }


        //READ 
        //static void ReadFirstFunction()
        //{
        //    FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/Person.txt", FileMode.Open);
        //    using (StreamReader readerOne = new StreamReader(fileStream))
        //    {
        //        Console.WriteLine(readerOne.ReadToEnd());
        //    }
        //}


        //5
        static void ReadSecondFunction()
        {
            FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/Cars.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        //6
        static void GetSum(int numOne , int numTwo)
        {
            FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/sumOfTwoNum", FileMode.Append);
            using (StreamWriter reader = new StreamWriter(fileStream))
            {
                reader.WriteLine(numOne + numTwo);
            }
        }

        //7

        static void CheakIfRandomNumExsist(int numberFromUser)
        {
            //numberFromUser = int.Parse(Console.ReadLine());
            Random rendomNum = new Random();
            int randomNumber = rendomNum.Next(1, 10);
            if (randomNumber == numberFromUser)
            {
                FileStream fileStream = new FileStream(@"C:/Users/edent/OneDrive/שולחן העבודה/טק קריירה/C#/02.12.2021/files/if randomNum", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(numberFromUser);
                    Console.WriteLine($"random Number:{randomNumber} . number From User{numberFromUser}");
                }
            }

            else
            {
                Console.WriteLine("LOSER");
            }

        }

    }



}
