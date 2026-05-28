using System.Net.Sockets;
using Common;

namespace ClientPB
{
    public partial class Form1 : Form
    {
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;
        private string _clientId;
        private int _currentWorldId = -1;
        private WorldState _currentWorld;
        private int _selectedColor = 1;
        private int _cellSize = 10;
        private DateTime _lastPixelTime = DateTime.MinValue;
        private Dictionary<int, string> _availableWorlds = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnColor5_Click(object sender, EventArgs e)
        {

        }
    }
    class WorldItem
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
