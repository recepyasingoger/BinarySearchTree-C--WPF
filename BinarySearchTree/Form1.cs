using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        public Form1() // RECEP
        {
            InitializeComponent();
            INIT();
        }
        float MAX_X;
        float MAX_Y;
        BST b;
        node BulunanNode = null;
        void INIT() // kurucu metot
        {
            MAX_X = .95f * pbTree.Width;// picture boxta konumu
            MAX_Y = Node_Kutu * 4; // picture boxta konumu
            b = new BST();
            
        }
        public void DrawTree(Graphics g, node curr, float sol, float sag, float y, nodetipi nt, int lvlCount)
        {
            
            if (curr == null) // veri yoksa 
                return;
            var mid = (sol + sag) / 2;
            DrawTree(g, curr.sol, sol, mid, y + MAX_Y, nodetipi.Sol, lvlCount + 1);
            DrawTree(g, curr.sag, mid, sag, y + MAX_Y, nodetipi.Sag, lvlCount + 1);
            drawNode(g, curr, sol, sag, mid, y, nt, lvlCount);
        }
        Pen node = new Pen(Brushes.White), // kutu beyaz
        nodeBulma = new Pen(Brushes.GreenYellow); // node bulununca kutunun rengi yeşil
        Pen nodeYazı = new Pen(Brushes.Green); // yazının rengi
        Pen nodeCizgi = new Pen(Brushes.Green,2F); // cizgi rengi ve kalınlığı
        public void drawNode(Graphics g, node n, float L, float R, float x, float y, nodetipi nt, int lvlNum)
        {
           
          
            float size = Node_Kutu * 3;
            Font drawFont = new Font("Arial", 16); // Kutunun içindeki yazı özellikleri
            switch (nt)
            {
                case nodetipi.Sol:  // soldaki elemana çizgi çekme
                    g.DrawLine(nodeCizgi, x + size / 2, y + size / 2, R + size / 2, y - MAX_Y + size / 2);
                    break;
                case nodetipi.Sag: // sagdaki elemana çizgi çekme
                    g.DrawLine(nodeCizgi, x + size / 2, y + size / 2, L + size / 2, y - MAX_Y + size / 2);
                    break;
                case nodetipi.Kök: // kökse çizgi çekilmez
                    break;
                default:
                    break;
            }
            if (n == BulunanNode) // node bulunursa kutu boyanır
                g.FillRectangle(nodeBulma.Brush, x, y, size, size);

            else
                g.FillRectangle(node.Brush, x, y, size, size); 
            g.DrawString(n.deger.ToString(), drawFont, nodeYazı.Brush, (x + size / 8), y + size / 4); // kutunun içindeki yazının konumu
        }
        public enum nodetipi
        {
           Sol, Sag, Kök
        }
        
        float Node_Kutu = 15f;
        void agacıguncelle() // YUSUF
        {
            label2.Text = "";
            var elemanlar = b.elemanekle(order.inorder);
            foreach (var eleman in elemanlar)
            {
                label2.Text += eleman + " ";
            }
            label3.Text = "";
            var elemanlar1 = b.elemanekle(order.preorder);
            foreach (var eleman in elemanlar1)
            {
                label3.Text += eleman + " ";
            }
            label4.Text = "";
            var elemanlar2 = b.elemanekle(order.postorder);
            foreach (var eleman in elemanlar2)
            {
                label4.Text += eleman + " ";
            }
            pbTree.Refresh();
            var g = pbTree.CreateGraphics();
            DrawTree(g, b.root, MAX_X * .50f, MAX_X, MAX_Y, nodetipi.Kök, 1);
        }
        private void Ekle_Click(object sender, EventArgs e) // ekle butonu
        {
            var deger = int.Parse(tbNode.Text);
            b.ekle(deger);
            agacıguncelle();
        }
       
     
        private void Form1_Load(object sender, EventArgs e)
        {
            agacıguncelle();
        }
        private void Sil_Click(object sender, EventArgs e) // sil butonu
        {
            var deger = int.Parse(tbNode.Text);
            b.Sil(deger);
            agacıguncelle();
        }
        private void Ara_Click(object sender, EventArgs e) // ara butonu
        {
            BulunanNode = b.bul(int.Parse(tbNode.Text));
            agacıguncelle();
        }
        private void gunaButton1_Click(object sender, EventArgs e) // agacı kaldır butonu
        {
            b.Temizle();
            agacıguncelle();
        }
       
    }
}
