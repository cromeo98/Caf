namespace Caf
{
    internal class Naspi
    {
        const int MESIMINIMI = 12;
        double netWorth;
        int mesiOccupazione;

        public Naspi(double netWorth, int mesiOccupazione)
        {
            this.netWorth = netWorth;
            this.mesiOccupazione = mesiOccupazione;
        }

        public bool checkAnniOccupazione()
        {
            if (mesiOccupazione >= MESIMINIMI)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double calcAll()
        {
            if (mesiOccupazione >= 24)
            {
                double result = netWorth * 70 / 100;
                if (result >= 1200)
                {
                    return 1200;
                }
                else
                {
                    return result;
                }
            }
            else if (mesiOccupazione < 24 && mesiOccupazione >= MESIMINIMI)
            {
                double result = netWorth * 40 / 100;
                if (result >= 1200)
                {
                    return 1200;
                }
                else
                {
                    return result;
                }
            }
            else
            {
                double result = 0;
                return result;
            }
        }
    }
}
