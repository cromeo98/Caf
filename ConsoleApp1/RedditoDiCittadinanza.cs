namespace Caf
{
    internal class RedditoDiCittadinanza
    {
        double isee;
        double patrimonioImmobiliare;

        public RedditoDiCittadinanza(double isee, double patrimonioImmobiliare)
        {
            this.isee = isee;
            this.patrimonioImmobiliare = patrimonioImmobiliare;
        }

        public bool checkEta(int userEta)
        {
            if (userEta >= 26 && userEta <= 67)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkIsee()
        {
            if (isee < 9360)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkImmobili()
        {
            if (patrimonioImmobiliare < 30000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkAll(int userEta)
        {
            if (checkImmobili() && checkIsee() && checkEta(userEta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
