using System;
namespace Problem_4
{
    class Poll
    {
        Person[] member; 

        public Poll(int list)   //специальный конструктор для создания введоного числа объектов
        {
            member = new Person[list];
        }

        public void AddMember(int i, string[] name, int[] age)
        {
            member[i] = new Person(name[i], age[i]);
        }
        public void GetInfo()
        {
            for (int i = 0; i < member.Length; i++)
            {

                Console.WriteLine($"{member[i].Name}  {member[i].Age}");
            }

        }//конструктор для вывода 

        public void Output(int n, Poll op)
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (op.member[i].Age > 30) { k++; }
            }

            Person[] sorted = new Person[k];

            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (op.member[i].Age > 30)
                {
                    sorted[r] = new Person();
                    r++;
                }
            }

            r = 0;
            for (int i = 0; i < n; i++)
            {
                if (op.member[i].Age > 30)
                {
                    sorted[r].Name = op.member[i].Name;
                    sorted[r].Age = op.member[i].Age;
                    r++;
                }
            }

            int p = sorted[0].Name.Length;
            for (int h = 0; h < n * (n-1) ; h++)
            {
                for (int i = 0; i < k; i++)
                {

                    for (int q = i + 1; q < k; q++)
                    {

                        if (sorted[i].Name.Length > sorted[q].Name.Length)
                        {
                            p = sorted[q].Name.Length;
                        }
                        else
                        {
                            p = sorted[i].Name.Length; 
                        }
                        for (int j = 0; j < p; j++)
                        {


                            if (sorted[i].Name[j] > sorted[q].Name[j])
                            {
                                Person t = new Person(sorted[i].Name, sorted[i].Age);
                                sorted[i].Name = sorted[q].Name;
                                sorted[i].Age = sorted[q].Age;
                                sorted[q].Name = t.Name;
                                sorted[q].Age = t.Age;
                                if (j == 0) { i++; }
                            }

                            else if (sorted[i].Name[j] < sorted[q].Name[j])
                            {
                                Person t = new Person(sorted[q].Name, sorted[q].Age);
                                sorted[q].Name = sorted[i].Name;
                                sorted[q].Age = sorted[i].Age;
                                sorted[i].Name = t.Name;
                                sorted[i].Age = t.Age;
                                if (j == 0) { i++; }
                            }



                        }

                    }
                }
            }


            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{sorted[i].Name} {sorted[i].Age}");
            }
        }



    }
}


