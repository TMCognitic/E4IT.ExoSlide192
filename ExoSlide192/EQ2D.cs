namespace ExoSlide192
{
    struct EQ2D
    {
        public double A, B, C;

        //Coder de manière défensive
        public bool Resoudre(out double? x1, out double? x2)
        {
            x1 = x2 = null;

            if(A == 0)
            {
                return false;
            }

            double delta = Math.Pow(B, 2) - 4 * A * C;

            if(delta < 0)
            {
                return false;
            }

            x1 = (-B - Math.Sqrt(delta)) / (2 * A);
            x2 = (-B + Math.Sqrt(delta)) / (2 * A);
            return true;
        }

        //Coder de manière aggressive
        //public bool Resoudre(out double? x1, out double? x2)
        //{
        //    x1 = x2 = null;          

        //    double delta = Math.Pow(B, 2) - 4 * A * C;

        //    if (A != 0 && delta >= 0)
        //    {
        //        x1 = (-B - Math.Sqrt(delta)) / (2 * A);
        //        x2 = (-B + Math.Sqrt(delta)) / (2 * A);
        //        return true;
        //    }

        //    return false;            
        //}
    }

}
