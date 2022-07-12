using NubankClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NubankClone.ViewModels
{
    public class HelpMeViewModel
    {
        public ObservableCollection<ItemsHelpMe> Items { get; private set; }

        public HelpMeViewModel()
        {
            Items = new ObservableCollection<ItemsHelpMe>();
            Items.Add(new ItemsHelpMe { Topic="App do Nubank", Description="Saiba mais sobre a tela inicial do seu app"});
            Items.Add(new ItemsHelpMe { Topic = "Pix", Description = "Saiba mais sobre Pix no Nubank" });
            Items.Add(new ItemsHelpMe { Topic = "Nubank Ultravioleta", Description = "Conheça tudo sobre nosso novo cartão" });
            Items.Add(new ItemsHelpMe { Topic = "NuInvest", Description = "Informações gerais sobre o NuInvest" });
            Items.Add(new ItemsHelpMe { Topic = "Débito Automático", Description = "Saiba mais sobre o Débito Automático Nubank" });
            Items.Add(new ItemsHelpMe { Topic = "Débito automático da fatura do cartão de crédito", Description = "Saiba mais sobre o débito automático da fatura do seu cartão de crédito" });
            Items.Add(new ItemsHelpMe { Topic = "Fundos de Investimentos", Description = "Fundos de Investimentos do Nubank" });
            Items.Add(new ItemsHelpMe { Topic = "Seguros do Nubank", Description = "Saiba mais sobre os seguros oferecidos pelo Nubank" });
            Items.Add(new ItemsHelpMe { Topic = "Seguro de vida", Description = "Conheça mais sobre o Nubank Vida" });
            Items.Add(new ItemsHelpMe { Topic = "Seguro de celular", Description = "Saiba mais sobre o Celular Seguro Nubank" });
            Items.Add(new ItemsHelpMe { Topic = "Coronavírus", Description = "Dúvidas sobre o coronavírus? Veja aqui" });
            Items.Add(new ItemsHelpMe { Topic = "Auxílio Emergencial", Description = "Dúvidas sobre o Auxílio Emergencial? Veja aqui" });
            Items.Add(new ItemsHelpMe { Topic = "Novidades", Description = "Tudo sobre o Nubank e nossos produtos" });
            Items.Add(new ItemsHelpMe { Topic = "Conta", Description = "Conheça tudo sobre a nossa conta digital" });
            Items.Add(new ItemsHelpMe { Topic = "Cartão de Crédito Conta PJ", Description = "Tire suas dúvidas sobre cartão de crédito para pessoa jurídica" });
            Items.Add(new ItemsHelpMe { Topic = "Cartão de Crédito", Description = "Conheça as funcionalidades do Cartão de Crédito" });
            Items.Add(new ItemsHelpMe { Topic = "Pagar Fatura", Description = "Descubra como e onde pagar a sua fatura" });
            Items.Add(new ItemsHelpMe { Topic = "Boleto", Description = "Tire suas dúvidas sobre boletos" });
            Items.Add(new ItemsHelpMe { Topic = "Parcelar Fatura", Description = "Veja como parcelar sua fatura" });
            Items.Add(new ItemsHelpMe { Topic = "Limite de Crédito", Description = "Tire suas dúvidas sobre seu limite de crédito" });
            Items.Add(new ItemsHelpMe { Topic = "Cartão Virtual", Description = "Conheça as funcionalidades do cartão virtual" });
            Items.Add(new ItemsHelpMe { Topic = "Rewards", Description = "Tudo sobre o nosso programa de fidelidade" });
            Items.Add(new ItemsHelpMe { Topic = "Fatura atrasada", Description = "Saiba sobre suas opções de pagamento" });
            Items.Add(new ItemsHelpMe { Topic = "Empréstimo atrasado", Description = "Informações sobre seu empréstimo em atraso" });
            Items.Add(new ItemsHelpMe { Topic = "Compras com o cartão", Description = "Informações sobre suas compras no cartão" });
            Items.Add(new ItemsHelpMe { Topic = "Problemas com compras na função crédito", Description = "Dúvidas sobre cancelamento e estorno?" });
            Items.Add(new ItemsHelpMe { Topic = "Problemas com compras na função débito ou saques", Description = "Dúvidas sobre cancelamento e estorno?" });
            Items.Add(new ItemsHelpMe { Topic = "Produção e entrega do cartão", Description = "Informações sobre o recebimento do cartão" });
            Items.Add(new ItemsHelpMe { Topic = "Empréstimo Pessoal", Description = "Tire suas dúvidas sobre empréstimo pessoal" });
            Items.Add(new ItemsHelpMe { Topic = "Empréstimo com Portabilidade de Salário", Description = "Tire suas dúvidas sobre o empréstimo com taxas menores" });
            Items.Add(new ItemsHelpMe { Topic = "Compras no exterior", Description = "Cotação, conversão, IOF e Spread" });
            Items.Add(new ItemsHelpMe { Topic = "Dados da sua conta", Description = "Dados cadastrais e senhas" });
            Items.Add(new ItemsHelpMe { Topic = "Pagamentos no WhatsApp", Description = "Tudo sobre pagamentos que acontecem direto nas redes sociais" });
            Items.Add(new ItemsHelpMe { Topic = "Segurança", Description = "Tudo sobre a proteção da sua conta" });
            Items.Add(new ItemsHelpMe { Topic = "Opções de Depósito na sua conta", Description = "Informações sobre aplicações em RDB" });
            Items.Add(new ItemsHelpMe { Topic = "Conta PJ", Description = "Conheça nossa conta para pessoa jurídica" });
            Items.Add(new ItemsHelpMe { Topic = "Open Banking", Description = "Saiba mais sobre Open Banking" });
            Items.Add(new ItemsHelpMe { Topic = "Sobre o Nubank", Description = "Junte-se à nossa revolução!" });
            Items.Add(new ItemsHelpMe { Topic = "Tela de rendimentos", Description = "Informações sobre a tela de rendimentos da sua conta" });
            Items.Add(new ItemsHelpMe { Topic = "Resgate Planejado", Description = "Informações gerais sobre o Resgate Planejado na conta" });
            Items.Add(new ItemsHelpMe { Topic = "Doações", Description = "Faça doações para instituições usando seu cartão de crédito" });
            Items.Add(new ItemsHelpMe { Topic = "LGPD - Privacidade", Description = "Saiba como exercer os seus direitos" });
            Items.Add(new ItemsHelpMe { Topic = "Construir Limite", Description = "Informações sobre aplicações em RDB" });
            Items.Add(new ItemsHelpMe { Topic = "Reemissão de Cartão", Description = "Saiba tudo sobre como pedir uma nova via do seu cartão" });
            Items.Add(new ItemsHelpMe { Topic = "Notificações", Description = "Dúvidas sobre notificações e comunicações?" });
            Items.Add(new ItemsHelpMe { Topic = "Cadastro Positivo", Description = "Saiba tudo sobre o cadastro positivo" });
            Items.Add(new ItemsHelpMe { Topic = "Mastercard", Description = "Saiba mais sobre a Mastercard e seus benefícios" });
            Items.Add(new ItemsHelpMe { Topic = "Domicílio Bancário", Description = "Receber da maquininha na conta do Nubank" });

        }
    }

}
