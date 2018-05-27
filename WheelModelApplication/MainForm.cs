using System;
using System.Linq;
using System.Windows.Forms;
using WheelModelLibrary;

namespace WheelModelApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                var speed = double.Parse(speedTextBox.Text);
                var height = double.Parse(heightTextBox.Text);
                var u = double.Parse(uTextBox.Text);
                var i = double.Parse(iTextBox.Text);
                var r = double.Parse(rTextBox.Text);
                var omega = double.Parse(omegaTextBox.Text);
                var k = double.Parse(kTextBox.Text);
                var m = double.Parse(mTextBox.Text);
                var g = double.Parse(gTextBox.Text);

                var startT = double.Parse(startTTextBox.Text);
                var endT = double.Parse(EndTTextBox.Text);
                var dt = double.Parse(dtTextBox.Text);

                var model = new WheelModel
                {
                    Func = x => Math.Sin(x),
                    Speed = speed,
                    Height = height,
                    U = u,
                    I = i,
                    R = r,
                    Omega = omega,
                    K = k,
                    M = m,
                    G = g
                };

                var datas = model.Process(startT, endT, dt);

                outputTextBox.Text = string.Join(Environment.NewLine, datas.Select(data => 
                    $"T: {data.T:F2}. S: {data.S:F2}. Y0: {data.Y0:F2}. y0': {data.DeltaY0:F2}. y0'': {data.DeltaDeltaY0:F2}. N: {data.N:F2}. Y: {data.Y:F2}. Y': {data.DeltaY:F2}. Y'': {data.DeltaDeltaY:F2}"));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Exception:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
