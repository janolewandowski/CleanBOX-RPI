using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Gpio;

namespace PrototypeRasbianV1._1
{
    public partial class Cleanbox : Form
    {
        private bool isLightON = false;
        private bool isUvON = false;
        public Cleanbox()
        {
            InitializeComponent();
            LightButton.Text = "Wyłączone";
            UvButton.Text = "Wyłączone";
        }

        private void LightButton_Click(object sender, EventArgs e)
        {
            try 
            {
                int pin = 16;
                var controller = new GpioController();
                if (isLightON)
                {
                    controller.OpenPin(pin, PinMode.Output);
                    controller.Write(pin, PinValue.Low);
                    isLightON = false;
                    LightButton.Text = "Wyłączone";
                    controller.ClosePin(pin);
                }
                else
                {
                    controller.OpenPin(pin, PinMode.Output);
                    controller.Write(pin, PinValue.High);
                    isLightON = true;
                    LightButton.Text = "Włączone";
                    controller.ClosePin(pin);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
           

        }

        private void UvButton_Click(object sender, EventArgs e)
        {
            try 
            {
                int pin = 18;
                var controller = new GpioController();
                
                if (isUvON)
                {
                    controller.OpenPin(pin, PinMode.Output);
                    controller.Write(pin, PinValue.Low);
                    isUvON = false;
                    UvButton.Text = "Wyłączone";
                    controller.ClosePin(pin);
                }
                else
                {
                    controller.OpenPin(pin, PinMode.Output);
                    controller.Write(pin, PinValue.High);
                    isUvON = true;
                    UvButton.Text = "Włączone";
                    controller.ClosePin(pin);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
          
        }
    }
}
