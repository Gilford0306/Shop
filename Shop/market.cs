//Задание 6
//Создайте класс «Магазин». Необходимо хранить в
//полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
//Реализуйте методы класса для ввода данных, вывода
//данных, реализуйте доступ к отдельным полям через
//методы класса.
using System;


namespace Shop
{
    internal class market
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                bool flag = true;
                foreach (var symbol in value)
                    if (!char.IsDigit(symbol))
                    {
                        flag = false;
                        break;
                    }

                if (value != String.Empty && flag == false)
                {
                    Console.WriteLine("Incorrect Phone only Digit");
                    return;
                }
                phone = value;

            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value != String.Empty && value.IndexOf('@') == -1)
                {
                    Console.WriteLine("Incorrect Email");
                    return;
                }
                email = value;
            }
        }

        public market()
        {
            Name = String.Empty;
            Address = String.Empty;
            Description = String.Empty;
            Phone = String.Empty;
            Email = String.Empty;
        }
        public market(string _Name, string _Address, string _Description, string _Phone, string _Email)
        {
            this.Name = _Name;
            this.Address = _Address;
            this.Description = _Description;
            this.Phone = _Phone;
            this.Email = _Email;
        }
        public override string ToString()
        {
            return String.Format("Name of shop: {0}\nAddress of shop: {1}\nDesription : {2}\nPhone: {3}\nEmail : {4} \n", Name, Address, Description ,Phone, Email);
        }
    }
}
