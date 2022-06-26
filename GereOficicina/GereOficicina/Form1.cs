using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereOficicina
{
    public partial class Form1 : Form
    {
        MinhaOficinaContainer db;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new MinhaOficinaContainer();
            lerdadosCliente();
            
        }
        private void lerdadosCliente()
        {
            if (db.Clientes.Count() != 0)
            {
                lbclientes.DataSource = null;
                lbclientes.DataSource = db.Clientes.ToList<Cliente>();
                TotalCliente();
            }
            else
            {
                lbclientes.DataSource = null;
                lbcarros.DataSource = null;
                lbservicos.DataSource = null;
                lbparcelas.DataSource = null;
            }
        }

        private void lerdadosCarros()
        {
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            if (ClienteSelecionado.Carros.Count() != 0)
            {
                lbcarros.DataSource = null;
                lbcarros.DataSource = ClienteSelecionado.Carros.ToList<Carro>();
            }
            else
            {
                lbcarros.DataSource = null;
                lbservicos.DataSource = null;
                lbparcelas.DataSource = null;
            }
        }
        private void lerdadosServicos()
        {
            Carro CarroSelecionado = lbcarros.SelectedItem as Carro;
            if (CarroSelecionado.Servicos.Count() != 0)
            {
                lbservicos.DataSource = null;
                lbservicos.DataSource = CarroSelecionado.Servicos.ToList<Servico>();
            }
            else
            {
                lbservicos.DataSource = null;
                lbparcelas.DataSource = null;
            }          
        }
        private void lerdadosParcelas()
        {
            Servico ServicoSelecionado = lbservicos.SelectedItem as Servico;
            if (ServicoSelecionado.Parcelas.Count() != 0)
            {
                lbparcelas.DataSource = null;
                lbparcelas.DataSource = ServicoSelecionado.Parcelas.ToList<Parcela>();
            }
            else
            {
                lbparcelas.DataSource = null;
            }

        }

        private void btncriarcliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtnovonome.Text, txtnovonif.Text);
            db.Clientes.Add(cliente);
            db.SaveChanges();
            lerdadosCliente();
            lbclientes.SelectedItem = cliente;
        }

        private void btncriarcarro_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro(txtmatricula.Text);
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            ClienteSelecionado.Carros.Add(carro);
            db.SaveChanges();
            lerdadosCliente();
            lbclientes.SelectedItem = ClienteSelecionado;
            lbcarros.SelectedItem = carro;
        }

        private void lbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lbclientes.SelectedIndex != -1)
            {
                Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
                lerdadosCarros();
                TotalCliente();
                txtnome.Text = ClienteSelecionado.Nome;
                txtnif.Text = ClienteSelecionado.NIF;
                    
            }
        }

        private void btncriarservico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico(cbtipo.Text);
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            Carro CarroSelecionado = lbcarros.SelectedItem as Carro;
            CarroSelecionado.Servicos.Add(servico);
            db.SaveChanges();
            lerdadosServicos();
            lbclientes.SelectedItem = ClienteSelecionado;
            lbcarros.SelectedItem = CarroSelecionado;
            lbservicos.SelectedItem = servico;
        }

        private void lbcarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbcarros.SelectedIndex != -1)
            {
                lerdadosServicos();
            }
            
        }

        private void btncriarparcela_Click(object sender, EventArgs e)
        {
            Parcela parcela = new Parcela(txtdescricao.Text, Convert.ToDouble(mtvalor.Text));
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            Carro CarroSelecionado = lbcarros.SelectedItem as Carro;
            Servico ServicoSelecionado = lbservicos.SelectedItem as Servico;
            ServicoSelecionado.Parcelas.Add(parcela);
            db.SaveChanges();
            lerdadosCliente();
            lbclientes.SelectedItem = ClienteSelecionado;
            lbcarros.SelectedItem = CarroSelecionado;
            lbservicos.SelectedItem = ServicoSelecionado;
            lbparcelas.SelectedItem = parcela;

        }

        private void TotalCliente()
        {
            double total = 0;
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            foreach (Carro carro in ClienteSelecionado.Carros.ToList<Carro>())
            {
                total += carro.TotalGasto();
            }

            labelgasto.Text = "€" + total.ToString();
        }

        private void lbservicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbservicos.SelectedIndex != -1)
            {
                lerdadosParcelas();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            ClienteSelecionado.Nome = txtnome.Text;
            ClienteSelecionado.NIF = txtnif.Text;
            db.SaveChanges();
            lerdadosCliente();

        }

        private void btnremoveparcelas_Click(object sender, EventArgs e)
        {
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            Carro CarroSelecionado = lbcarros.SelectedItem as Carro;
            Servico ServicoSelecionado = lbservicos.SelectedItem as Servico;
            Parcela ParcelaSelecionada = lbparcelas.SelectedItem as Parcela;
            db.Parcelas.Remove(ParcelaSelecionada);
            db.SaveChanges();
            lerdadosCliente(); 
            lbclientes.SelectedItem = ClienteSelecionado;
            lbcarros.SelectedItem = CarroSelecionado;
            lbservicos.SelectedItem = ServicoSelecionado;
        }

        private void btnremoveservicos_Click(object sender, EventArgs e)
        {
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            Carro CarroSelecionado = lbcarros.SelectedItem as Carro;
            Servico ServicoSelecionado = lbservicos.SelectedItem as Servico;
            foreach (Parcela parcela in ServicoSelecionado.Parcelas.ToList<Parcela>())
            {
                db.Parcelas.Remove(parcela);
            }
            db.Servicos.Remove(ServicoSelecionado);
            db.SaveChanges();
            lerdadosCliente();
            lbclientes.SelectedItem = ClienteSelecionado;
            lbcarros.SelectedItem = CarroSelecionado;
        }

        private void btnremovecarros_Click(object sender, EventArgs e)
        {
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            Carro CarroSelecionado = lbcarros.SelectedItem as Carro;
            foreach (Servico servico in CarroSelecionado.Servicos.ToList<Servico>())
            {
                foreach (Parcela parcela in servico.Parcelas.ToList<Parcela>())
                {
                    db.Parcelas.Remove(parcela);
                }

                db.Servicos.Remove(servico);
            }
            db.Carroes.Remove(CarroSelecionado);
            db.SaveChanges();
            lerdadosCliente();
            lbclientes.SelectedItem = ClienteSelecionado;

            
        }

        private void btnremoveclientes_Click(object sender, EventArgs e)
        {
            Cliente ClienteSelecionado = lbclientes.SelectedItem as Cliente;
            foreach (Carro carro in ClienteSelecionado.Carros.ToList<Carro>())
            {
                foreach (Servico servico in carro.Servicos.ToList<Servico>())
                {
                    foreach (Parcela parcela in servico.Parcelas.ToList<Parcela>())
                    {
                        db.Parcelas.Remove(parcela);
                    }
                    db.Servicos.Remove(servico);
                }
                db.Carroes.Remove(carro);
            }
            db.Clientes.Remove(ClienteSelecionado);
            db.SaveChanges();
            lerdadosCliente();               
        }
    }
}
