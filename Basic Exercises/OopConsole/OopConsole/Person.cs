namespace OopConsole
{
    public class Person
    {
        string _firstName;
        string _lastName;
        int _age;
        string _height;
        int _weight;

        public string FirstName
        {
            get {
                return _firstName;
                }

            set 
            {
                _firstName = value;     
            }
        }

       

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string Introduce()
        {
            return $"Hi, i'm {FullName()}";
        }

        string FullName()
        {
            return $"{_firstName} {_lastName}";
        }

    }
}
