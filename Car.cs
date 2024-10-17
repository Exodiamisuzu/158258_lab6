namespace lab6
{
    public class Car
    {
        private string _make;
        private string _model;
        private string _colour;
        private readonly string _registrationNumber;

        public Car(string make, string model, string colour, string registrationNumber)
        {
            _make = make;
            _model = model;
            _colour = colour;
            _registrationNumber = registrationNumber;
        }

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
        }

        public string Make
        {
            get { return _make; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _make = value;
                }
                else
                {
                    throw new ArgumentException("Make cannot be empty or null.");
                }
            }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public string GetCarDetails()
        {
            return $"Car Details: Make = {_make}, Model = {_model}, Colour = {_colour}, Registration Number = {_registrationNumber}";
        }
    }
}


/*namespace lab6
{
    public class Car
    {
        // 数据成员
        private string _make;
        private string _model;
        private string _colour;
        private readonly string _registrationNumber;

        // 构造函数初始化数据成员
        public Car(string make, string model, string colour, string registrationNumber) =>
            (_make, _model, _colour, _registrationNumber) = (make, model, colour, registrationNumber);

        // 只读属性用于获取注册号
        public string RegistrationNumber => _registrationNumber;

        // 属性 'make' 仅在有值时允许设置
        public string Make
        {
            get => _make;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _make = value;
                }
                else
                {
                    throw new ArgumentException("Make cannot be empty or null.");
                }
            }
        }

        // 属性 'model'
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        // 属性 'colour'
        public string Colour
        {
            get => _colour;
            set => _colour = value;
        }

        // 输出汽车信息的方法
        public string GetCarDetails() =>
            $"Car Details: Make = {_make}, Model = {_model}, Colour = {_colour}, Registration Number = {_registrationNumber}";
    }
}
*/
