namespace Caf
{
    internal class Pensione
    {
        int anniAttivita;

        public int AnniAttivita { get => anniAttivita; set => anniAttivita = value; }

        public bool calcAll(int userAnniAttivita, int userEta)
        {
            anniAttivita = userAnniAttivita;

            if (anniAttivita + userEta >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int anniMancanti(int userAnniAttivita, int userEta)
        {
            anniAttivita = userAnniAttivita;

            int result = 100 - (anniAttivita + userEta);

            return result;
        }
    }
}
