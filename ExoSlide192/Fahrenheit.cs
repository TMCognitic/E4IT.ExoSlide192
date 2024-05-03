namespace ExoSlide192
{
    struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius()
        {
            return new Celsius() { Temperature = (Temperature - 32) / 1.8 };
        }
    }
}
