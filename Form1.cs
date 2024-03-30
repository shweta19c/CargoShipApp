namespace CargoShipApp
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }

        private void updateUI()
        {
            //set all of the controls to match the ship properties
            progressBar1.Maximum = ship.Capacity;

            if (ship.getShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.getShipLoad();

            label_ShipLabel.Text = ship.ToString();

            //update labels count
            label_CycleCount.Text = ship.CycleCount.ToString();
            label_CarCount.Text = ship.CarCount.ToString();
            label_TruckCount.Text = ship.TruckCount.ToString();
            label_TrainCount.Text = ship.TrainCarCount.ToString();

            if (ship.overUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }
            if (ship.overUnder() > 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (ship.overUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }

        }

        private void track_MotorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_MotorCycles.Value;
            updateUI();
        }

        private void track_Cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_Cars.Value;
            updateUI();
        }

        private void track_Trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_Trucks.Value;
            updateUI();
        }

        private void track_Trains_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_Trains.Value;
            updateUI();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
