namespace Agentie.Classes
{
    internal class Agent
    {
        public int ID;
        public string Nume;
        public string Prenume;
        public double Salariul;
        private Form1 form;
        public Agent(Form1 form)
        {
            this.form = form;
        }
        public int Citire()
        {
            int.TryParse(form.tbId.Text, out ID);
            Nume = form.tbNume.Text;
            Prenume = form.tbPrenume.Text;
            double.TryParse(form.tbSalariu.Text, out Salariul);
            return 1;
        }
    }
}
