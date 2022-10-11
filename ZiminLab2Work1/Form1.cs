namespace ZiminLab2Work1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trainHourArrive.Text = Properties.Settings.Default.trainHourArrive.ToString();
            trainMinArrive.Text = Properties.Settings.Default.trainMinArrive.ToString();
            trainHourDep.Text = Properties.Settings.Default.trainHourDep.ToString();
            trainMinDep.Text = Properties.Settings.Default.trainMinDep.ToString();
            passHourArrive.Text = Properties.Settings.Default.passHourArrive.ToString();
            passMinArrive.Text = Properties.Settings.Default.passMinArrive.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trainHourArrive; int trainMinArrive;
            int trainHourDep; int trainMinDep;
            int passHourArrive; int passMinArrive;
            try
            {
                trainHourArrive = int.Parse(this.trainHourArrive.Text);
                trainMinArrive = int.Parse(this.trainMinArrive.Text);
                trainHourDep = int.Parse(this.trainHourDep.Text);
                trainMinDep = int.Parse(this.trainMinDep.Text);
                passHourArrive = int.Parse(this.passHourArrive.Text);
                passMinArrive = int.Parse(this.passMinArrive.Text);
            }
            catch (Exception)
            {

                return;
            }

            Properties.Settings.Default.trainHourArrive = trainHourArrive;
            Properties.Settings.Default.trainMinArrive = trainMinArrive;
            Properties.Settings.Default.trainHourDep = trainHourDep;
            Properties.Settings.Default.trainMinDep = trainMinDep;
            Properties.Settings.Default.passHourArrive = passHourArrive;
            Properties.Settings.Default.passMinArrive = passMinArrive;
            Properties.Settings.Default.Save();

               var timeTrainArrival = Logic.GetTime(trainHourArrive, trainMinArrive);
            var timeTrainDeparture = Logic.GetTime(trainHourDep,trainMinDep);
            var timePasArrive = Logic.GetTime(passHourArrive, passMinArrive);

            this.TimeResult.Text = Logic.Compare(timeTrainArrival, timeTrainDeparture, timePasArrive);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static string Compare(int timeTrainArrival, int timeTrainDeparture, int timePassenger)
        {
            string outMessage = "";
            if (timeTrainArrival > timeTrainDeparture)
            {
                timeTrainDeparture += 24 * 60;
                timePassenger += 24 * 60;
            }

            if (timeTrainArrival <= timePassenger && timePassenger <= timeTrainDeparture)
            {
                outMessage = "Поезд будет стоять на платформе во время прихода пассажира";
            }
            else
            {
                outMessage = "Поезд не будет стоять на платформе во время прихода пассажира";
            }

            return outMessage;
        }

        public static int GetTime(int hour, int minutes)
        {
            int time = hour * 60 + minutes;

            return time;
        }
    }
}