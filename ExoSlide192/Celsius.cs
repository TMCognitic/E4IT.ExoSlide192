namespace ExoSlide192
{
    struct Celsius
    {
        public double Temperature;

        public Fahrenheit ToFahrenheit()
        {
            return new Fahrenheit() { Temperature = Temperature * 1.8 + 32 };
        }
    }
}
