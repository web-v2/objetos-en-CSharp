namespace objetos_en_CSharp
{
    public partial class Form1 : Form
    {
        AireAcondicionado aire1 = new AireAcondicionado();
        AireAcondicionado aire2 = new AireAcondicionado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            aire1.setMarca("Olimpo");
            aire1.setModelo("Inverter");
            aire1.setColor("red");
            aire1.setBtu(9000);
            aire1.setTemperatura(20);
            aire1.setVoltaje(220);

            aire2.setMarca("Sansumg");
            aire2.setModelo("Tropical Cold");
            aire2.setColor("blanco");
            aire2.setBtu(12000);
            aire2.setTemperatura(16);
            aire2.setVoltaje(110);

            label1.Text = aire1.getTemperatura().ToString() + "°C";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aire1.subirTemperatura();
            label1.Text = aire1.getTemperatura().ToString() + "°C";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aire1.bajarTemperatura();
            label1.Text = aire1.getTemperatura().ToString() + "°C";
        }
    }
}