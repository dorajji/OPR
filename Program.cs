using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex_11__2_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            CreatePersons();
            Application.Run(new Form1());

            void CreatePersons()
            {
                string[] first_name = ["Екатерина", "Ольга", "Ксения", "Вероника", "Кристина", "Марина", "Вера", "Надежда", "Любовь", "Мария"];
                string[] second_name = ["Иванова", "Козлова", "Ткачева", "Колесникова", "Блохина", "Кузнецова", "Молчанова", "Воробьева", "Ершова", "Рябова"];
                string[] znak = ["Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец"];
                Random r = new Random();
                FileInfo file = new FileInfo(@"C:\Users\krole\Desktop\Info.txt");
                StreamWriter sw = file.CreateText();
                int znak_;
                Znak[] persons = new Znak[10];
                for (int i = 0; i < 10; i++)
                {
                    persons[i] = new Znak();
                    persons[i].name = $"{first_name[r.Next(10)]} {second_name[r.Next(10)]}";
                    znak_ = r.Next(12);
                    persons[i].znak = znak[znak_];
                    persons[i].date = new DateTime(r.Next(1950, 2024), znak_ + 1, r.Next(19) + 1);
                    sw.WriteLine(persons[i].ToString());
                }
                sw.Close();
            }
        }
    }
    
    public struct Znak
    {
        public string name;
        public string znak;
        public DateTime date;
        public static Znak[] ToList(string file)
        {
            string date_;
            Znak[] person = new Znak[10];
            StreamReader sr = new StreamReader(file);
            for (int i = 0; i < 10; i++)
            {
                person[i].name = sr.ReadLine();
                person[i].znak = sr.ReadLine();
                date_ = sr.ReadLine();
                int a = Convert.ToInt32(date_.Substring(0, 2));
                int b = Convert.ToInt32(date_.Substring(3, 2));
                int c = Convert.ToInt32(date_.Substring(6, 4));
                person[i].date = new DateTime(c, b, a);
            }
            sr.Close();
            return person;
        }
        public static Znak[] Sort(Znak[] person)
        {
            DateTime[] date_list = new DateTime[10];
            Znak[] person_ = person;
            DateTime temp1;
            Znak temp2;
            for (int i = 0; i < 10; i++)
            {
                date_list[i] = person[i].date;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (DateTime.Compare(date_list[j], date_list[j + 1]) == -1)
                    {
                        temp1 = date_list[j + 1];
                        date_list[j + 1] = date_list[j];
                        date_list[j] = temp1;
                        temp2 = person_[j + 1];
                        person_[j + 1] = person_[j];
                        person_[j] = temp2;
                    }
                }
            }
            return person_;
        }
        public override string ToString()
        {
            return $"{name}\n{znak}\n{date.ToString().Substring(0, 10)}";
        }
    }
}