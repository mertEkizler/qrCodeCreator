using MessagingToolkit.QRCode.Codec;

namespace qrCodeCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            var qrCodeBitmap = qrCodeEncoder.Encode(textBox1.Text);

            pictureBox1.Image = qrCodeBitmap;
        }
    }
}