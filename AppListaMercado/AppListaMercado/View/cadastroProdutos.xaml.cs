using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaMercado.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaMercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadastroProdutos : ContentPage
    {
        public cadastroProdutos()
        {
            InitializeComponent();
        }


        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            {
                Produto t = new Produto();
                t.Nome = txt_nome.Text;
                t.Qtd = txt_qtd.Text;
                t.Valor_Previsto = txt_valorprevisto.Text;
                t.Valor_Pago = txt_valorpago.Text;
                
                await App.DataBase.Save(t);
                await DisplayAlert("Tudo pronto", "O formulário foi concluido :)");
                await Navigation.PushAsync(new ListaProdutos());
            }
        }
    }
}  
        
