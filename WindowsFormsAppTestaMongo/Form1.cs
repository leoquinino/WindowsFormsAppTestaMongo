using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestaMongo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtURLConexao.Text = ComboConexao.Text;

            MongoClient client = new MongoClient(txtURLConexao.Text);

            MessageBox.Show("Conexão");

            //conectando ao banco de dados
            var database = client.GetDatabase(txtBancoDados.Text);

            IMongoCollection<ProdutosServicos> colecao = database.GetCollection<ProdutosServicos>("ProdutosServicos");

            ListarProdutos(colecao);


            //IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("ProdutosServicos");

            // Created with Studio 3T, the IDE for MongoDB - https://studio3t.com/

            //BsonDocument filter = new BsonDocument();


            
            MessageBox.Show("testado");
        }


        private static void ListarProdutos(IMongoCollection<ProdutosServicos> colecao)
        {
            var filtro = Builders<ProdutosServicos>.Filter.Empty;
            var produtos = colecao.Find<ProdutosServicos>(filtro).ToList();
            produtos.ForEach(x =>
            {
                Console.WriteLine(string.Concat("Descricao: ", x.Descricao));

            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
        
}
