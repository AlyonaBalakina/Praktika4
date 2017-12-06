//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Класс_и_обьект
//{
//    // public private protected
//    public class User
//    {
//        //int long Guid 
//        private int _id;
//        private string login;
//        private string password;
//        private Car car;

//        // модификатор доступа Название класса (аргументы) {тело}
//        public User()
//        {

//        }

//        //конструктор котрый вызывается один раз при создании любого кол-ва обьектов
//        static User()
//        {
//            // инициализация статический значений
//        }
//        public User(int id) // любое кол-во элементов
//        {
//            _id = id;
//        }

//        // модификатор доступа - возвращаемый тип-Глагол_описывающий действие-(аргументы) {тело}
//        public string GetLogin()
//        {
//            return login;
//        }
//        public void SetLogin(string login)
//        {
//            this.login = login;
//        }
//        public void SetId(int id)
//        {
//            _id = id;
//        }
//        public void ToDo(out string text)
//        {
//            text = "aaaa";
//        }
//        public void ToDo(string str, string num = "aaaa")
//        {
//            Sum(1, 2, 3, 4, 5);
//            Sum(1);
//            Sum(1, 2, 3);
//        }
//        public void Sum(params int[] numbers)
//        {

//        }

//    }
//}
