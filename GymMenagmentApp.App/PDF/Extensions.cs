namespace GymMenagmentApp.App.PDF
{
    public static class Extensions
    {
        public static float ToDpi(this float centimeters)
        {
            return (float)((centimeters / 2.54) * 72);
        }
    }
}
