using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listislemler
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            txtgiris.Focus();
            lstillerA.Items.Add("Samsun");
            lstillerA.Items.Add("Sinop");
            lstillerA.Items.Add("Mersin");
            lstillerA.Items.Add("Ankara");
            lstillerA.Items.Add("İstanbul");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            var eklenecekDeger = txtgiris.Text;
            lstillerA.Items.Add(eklenecekDeger);
            txtgiris.Clear();
            txtgiris.Focus();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            var secilenIndeksler = lstillerA.SelectedIndices;
            if (secilenIndeksler.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz İl seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

         for (int i =secilenIndeksler.Count-1; i >= 0; i--)
            {
                lstillerA.Items.RemoveAt(secilenIndeksler[i]);
            }

        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            var secilenIndeskler = lstillerA.SelectedIndices;
            if(secilenIndeskler.Count <= 0)
            {
                MessageBox.Show("Aktarılacak İl Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (int item in secilenIndeskler)
            {
                listiilerB.Items.Add(lstillerA.Items[item]);

            }
            for(int i =secilenIndeskler.Count -1; i >= 0; i--)
            {
                lstillerA.Items.RemoveAt(secilenIndeskler[i]);
            }
        }

        private void txtgiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                btnekle_Click(sender,e);
            }
        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            var SecilenIcerik = lstillerA.SelectedItems;
           if(SecilenIcerik.Count <= 0)
           {
                MessageBox.Show("İl seçimi yapılmamıştır.", "Hata", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
                return;
           }
            var mesaj = string.Empty;
            foreach(var item in SecilenIcerik)
            {
                mesaj = mesaj + $"{item}\n";
            }
            MessageBox.Show(mesaj,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return;
        }

        private void btngerial_Click(object sender, EventArgs e)
        {
            var secilenIndeskler = listiilerB.SelectedIndices;
            if (secilenIndeskler.Count <= 0)
            {
                MessageBox.Show("Aktarılacak İl Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (int item in secilenIndeskler)
            {
                lstillerA.Items.Add(listiilerB.Items[item]);

            }
            for (int i = secilenIndeskler.Count - 1; i >= 0; i--)
            {
                listiilerB.Items.RemoveAt(secilenIndeskler[i]);
            }
        }

        private void lstillerA_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstillerA.SelectedItems.Count > 0) 
            {
                lstillerA.DoDragDrop(lstillerA, DragDropEffects.Move);
            }
        }

        private void listiilerB_DragOver(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if(tasinanData != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listiilerB_DragDrop(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            var secilenIndeksler = tasinanData.SelectedIndices;

            foreach (int item in secilenIndeksler) 
            {
                listiilerB.Items.Add(lstillerA.Items[item]);
            }
            for (int i = secilenIndeksler.Count - 1; i >= 0; i--)
            {
                lstillerA.Items.RemoveAt(secilenIndeksler[i]);
            }
        }

        private void listiilerB_MouseDown(object sender, MouseEventArgs e)
        {

            if (listiilerB.SelectedItems.Count > 0)
            {
                lstillerA.DoDragDrop(listiilerB, DragDropEffects.Move);
            }
        }

        private void lstillerA_DragDrop(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            var secilenIndeksler = tasinanData.SelectedIndices;

            foreach (int item in secilenIndeksler)
            {
                lstillerA.Items.Add(listiilerB.Items[item]);
            }
            for (int i = secilenIndeksler.Count - 1; i >= 0; i--)
            {
                listiilerB.Items.RemoveAt(secilenIndeksler[i]);
            }
        }

        private void lstillerA_DragOver(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if (tasinanData != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
