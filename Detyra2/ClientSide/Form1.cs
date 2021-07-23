using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSide
{



    public partial class Form1 : Form
    {
        static string abc1 = "C:\\publicKey.xml";
        static string abc2 = "C:\\privateKey.xml";
        static string _publicKey = System.IO.File.ReadAllText(abc1);
        static string _privateKey = System.IO.File.ReadAllText(abc2);
        static string _myRsaKeys = _publicKey;
        private string _senderPublicKey = _privateKey;
