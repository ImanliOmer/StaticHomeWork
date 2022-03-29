using System;

namespace Static.Model
{
    internal class User : IAcount
    {
        public string Fullname { get; set; }
        public string Gmail { get; set; }
        private string _password;
        private static int _id;
        public int Id { get; }

        public string Password 
        {
            get
            {
                return _password;
            }


            set 
            {
                if (PasswordChecker(value) == true)//emindeyilem
                {

                    Console.WriteLine("şifrədə minimum 8 character olmalıdır\n" +
                        "şifrədə ən az 1 böyük hərf olmalıdır\n" +
                       "şifrədə ən az 1 kiçik hərf olmalıdır\n" +
                      " şifrədə ən az 1 rəqəm olmalıdır");
                    return;
                } 

                _password = value;
                Console.WriteLine("password set");
                Console.WriteLine();
                return;

            }
            


        }


        public User()
        {
            Id++;
            _id=Id;
        }


        public bool PasswordChecker(string password)
        {
            bool result = false;
            bool t = false;
            bool t2 = false;
            bool t3 = false;
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsLower(password[i]) == true)
                    {
                        t = true;
                    }


                    if ((char.IsUpper(password[i]) == true))
                    {
                        t2 = true;
                    }


                    if ((char.IsDigit(password[i])== true))
                    {
                        t3 = true;
                    }
                }
                result = t&&t2&&t3;
            }
            return result;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User Id: {Id}\n" +
                $"User Fullname: {Fullname}\n" +
                $"User Gmail{Gmail}\n");
               
        }
    }


    interface IAcount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();

    }


}
