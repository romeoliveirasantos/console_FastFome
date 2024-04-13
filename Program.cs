using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


namespace FastFome
{
    class Program
    {
        //lista para armazenar pedidos
        static Dictionary<string, (decimal price, int quantity)> pedidos = new Dictionary<string, (decimal, int)>();



        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        //método menu principal
        static void MenuPrincipal()
        {

            Console.Clear();
            //iniciando o programa            
            Console.WriteLine("Bem-vindo(a) ao FastFome seu fast food favorito.\n");
            Console.WriteLine("Esolha uma opção e faça seu pedido!");
            Console.WriteLine("1 - Burguers");
            Console.WriteLine("2 - Acompanhamentos");
            Console.WriteLine("3 - Bebidas");
            Console.WriteLine("4 - Checkout");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------");
            Console.Write("Digite: ");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 1:
                    MenuBurguers();
                    break;
                case 2:
                    MenuAcompanhamentos();
                    break;
                case 3:
                    MenuBebidas();
                    break;
                case 4:
                    Checkout();
                    break;
                case 5:
                    Console.WriteLine("Te vejo na proxima!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Thread.Sleep(500);
                    System.Environment.Exit(0);
                    break;
                default:
                    MenuPrincipal();
                    break;
            }
        }

        //cardápio de hamburguers
        static void MenuBurguers()
        {
            Console.Clear();
            Console.WriteLine("Menu de burgers, digite a opção da sua escolhida:");
            Console.WriteLine("1 - Burger de picanha");
            Console.WriteLine("2 - Burger Catufrango");
            Console.WriteLine("3 - Burger de toscana");
            Console.WriteLine("4 - Burger tripleX");
            Console.WriteLine("5 - Burger monster");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            Console.Write("Digite: ");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    BurguerPicanha();
                    break;
                case 2:
                    BurguerCatuFrango();
                    break;
                case 3:
                    BurguerToscano();
                    break;
                case 4:
                    BurguerXXX();
                    break;
                case 5:
                    BurguerMonster();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    MenuPrincipal();
                    break;
            }
            //ingredientes burguer de picanha
            static void BurguerPicanha()
            {
                Console.Clear();
                string carne = "220g de picanha bovina";
                string pao = "Pão brioche";
                Console.WriteLine($"Ingredientes:\n{carne}\n30g de queijo cheddar\nAlface americano\nTomates frescos em rodela\nPicles frescos\nCebola roxa\nMolho especial da casa\n{pao} selado na manteiga");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Confirmar escolha");
                Console.WriteLine("0 - Voltar ao Cardapio");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                if (res == 1)
                {
                    Console.Clear();
                    SaveOrder("Burger Picanha", 32.40m);
                    Console.WriteLine("Registramos sua escolha com sucesso.");
                    Thread.Sleep(2000);
                    MenuBurguers();

                }
                else if (res == 0)
                {
                    MenuBurguers();
                }
            }
            //ingredientes burguer de frango e catupiry
            static void BurguerCatuFrango()
            {
                Console.Clear();
                string carne = "220g peito de frango";
                string pao = "Pão gergelim";
                Console.WriteLine($"Ingredientes:\n{carne}\n50g de mussarela empanada\nAcelga picada\nTomates frescos em rodela\nCebola\nMolho especial da casa\n{pao} selado na manteiga");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Confirmar escolha");
                Console.WriteLine("0 - Voltar ao Cardapio");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                if (res == 1)
                {
                    Console.Clear();
                    SaveOrder("Burger Catufrango", 35.99m);
                    Console.WriteLine("Registramos sua escolha com sucesso.");
                    Thread.Sleep(2000);
                    MenuBurguers();
                }
                else if (res == 0)
                {
                    MenuBurguers();
                }
            }
            //ingredientes burguer de linguiça toscana
            static void BurguerToscano()
            {
                Console.Clear();
                string carne = "220g de linguiça toscana moida";
                string pao = "Pão australiano";
                Console.WriteLine($"Ingredientes:\n{carne}\n50g de catupiry empanado\nmolho campanha(vinagrete)\nPicles frescos\nMolho especial da casa\n{pao} selado na manteiga");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Confirmar escolha");
                Console.WriteLine("0 - Voltar ao Cardapio");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                if (res == 1)
                {
                    Console.Clear();
                    SaveOrder("Burger Toscano", 31.90m);
                    Console.WriteLine("Registramos sua escolha com sucesso.");
                    Thread.Sleep(2000);
                    MenuBurguers();
                }
                else if (res == 0)
                {
                    MenuBurguers();
                }
            }
            //ingredientes burguer Triple X
            static void BurguerXXX()
            {
                Console.Clear();
                string carne = "3 hamburguers de 100g de alcatra bovina";
                string pao = "Pão brioche";
                Console.WriteLine($"Ingredientes:\n{carne}\n40g de mussarela\nPicles frescos\nCebola roxa\nMolho especial da casa\n{pao} selado na manteiga");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Confirmar escolha");
                Console.WriteLine("0 - Voltar ao Cardapio");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                if (res == 1)
                {
                    Console.Clear();
                    SaveOrder("Burger Triple X", 45.99m);
                    Console.WriteLine("Registramos sua escolha com sucesso.");
                    Thread.Sleep(2000);
                    MenuBurguers();
                }
                else if (res == 0)
                {
                    MenuBurguers();
                }
            }
            //ingredientes burguer Monster
            static void BurguerMonster()
            {
                Console.Clear();
                string carne = "100g de peito de frango, 100g de calabresa moida";
                string pao = "Pão americano";
                Console.WriteLine($"Ingredientes:\n{carne}\n30g de queijo cheddar\nCatupiry original\nCebola\nMolho especial da casa\n{pao} selado na manteiga");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Confirmar escolha");
                Console.WriteLine("0 - Voltar ao Cardapio");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                if (res == 1)
                {
                    Console.Clear();
                    SaveOrder("Burger Monster", 42.90m);
                    Console.WriteLine("Registramos sua escolha com sucesso.");
                    Thread.Sleep(2000);
                    MenuBurguers();
                }
                else if (res == 0)
                {
                    MenuBurguers();
                }
            }
        }
        //cardápio de acompanhamentos
        static void MenuAcompanhamentos()
        {
            Console.Clear();
            Console.WriteLine("Menu de acompanhamentos, digite a opção escolhida:");
            Console.WriteLine("1 - Batatas");
            Console.WriteLine("2 - Salgados");
            Console.WriteLine("3 - Pastéis");
            Console.WriteLine("4 - HotDogs");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            Console.Write("Digite: ");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    MenuBatatas();
                    break;
                case 2:
                    MenuSalgados();
                    break;
                case 3:
                    MenuPasteis();
                    break;
                case 4:
                    MenuHotDogs();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    MenuPrincipal();
                    break;
            }

            static void MenuBatatas()
            {
                Console.Clear();
                Console.WriteLine("Porções de 400g.");
                Console.WriteLine("Digite a opção escolhida e confirme logo após.");
                Console.WriteLine("1 - Batata padrão - 400g de batata corte padrão - premium");
                Console.WriteLine("2 - Batata Crinkle - 400g de batata corte crinkle - 50g de bacon picado - Catupiry e Chedder");
                Console.WriteLine("3 - Batata padrão Mussa - 400g de batata corte padrão - Mussarela derretida");
                Console.WriteLine("4 - Batata rústica - 400g de batata rústica - Orégano - Mussarela e molho taste");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                switch (res)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        ConfirmOrder("Batata padrão", 25.99m);
                        MenuBatatas();
                        break;
                    case 2:
                        ConfirmOrder("Batata Crinkle", 29.99m);
                        MenuBatatas();
                        break;
                    case 3:
                        ConfirmOrder("Batata padrão Mussa", 19.99m);
                        MenuBatatas();
                        break;
                    case 4:
                        ConfirmOrder("Batata rústica", 30.99m);
                        MenuBatatas();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Thread.Sleep(1000);
                        break;
                }

            }
            static void MenuSalgados()
            {
                Console.Clear();
                Console.WriteLine("Porções de 5 unidades.");
                Console.WriteLine("Digite a opção escolhida e confirme logo após.");
                Console.WriteLine("1 - Coxinha frango - Massa de batata - Recheio de frango temperado desfiado");
                Console.WriteLine("2 - Coxinha de Catufrango - Massa de batata - Recheio de frango e catupiry original");
                Console.WriteLine("3 - Coxinha de calabresa - Massa de batata - Calabresa picada e mussarela");
                Console.WriteLine("4 - Bolovo - Massa de batata - Recheio de carne moida - Ovo cozido - Azeitonas e chedder");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                switch (res)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        ConfirmOrder("Coxinha de frango", 25.99m);
                        MenuSalgados();
                        break;
                    case 2:
                        ConfirmOrder("Coxinha de Catufrango", 29.99m);
                        MenuSalgados();
                        break;
                    case 3:
                        ConfirmOrder("Coxinha de calabresa", 19.99m);
                        MenuSalgados();
                        break;
                    case 4:
                        ConfirmOrder("Bolovo", 30.99m);
                        MenuSalgados();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Thread.Sleep(1000);
                        break;
                }

            }
            static void MenuPasteis()
            {
                Console.Clear();
                Console.WriteLine("Porções de 3 unidades - Tamanho médio: 21x12cm.");
                Console.WriteLine("Digite a opção escolhida e confirme logo após.");
                Console.WriteLine("1 - frango - Recheio de frango temperado desfiado - azeitonas");
                Console.WriteLine("2 - Catufrango - Recheio de frango e catupiry original - azeitonas");
                Console.WriteLine("3 - Calabresa - Calabresa picada - mussarela - azeitonas e orégano");
                Console.WriteLine("4 - Carne - Recheio de carne moida - Ovo cozido - Azeitonas e chedder");
                Console.WriteLine("5 - Carne e queijo - Recheio de carne moida - Azeitonas e mussarela");
                Console.WriteLine("6 - Pizza - Recheio de presunto - mussarela - tomate - azeitonas e orégano");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                switch (res)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        ConfirmOrder("frango", 45.99m);
                        MenuPasteis();
                        break;
                    case 2:
                        ConfirmOrder("Catufrango", 50.99m);
                        MenuPasteis();
                        break;
                    case 3:
                        ConfirmOrder("Calabresa", 47.99m);
                        MenuPasteis();
                        break;
                    case 4:
                        ConfirmOrder("Carne", 46.99m);
                        MenuPasteis();
                        break;
                    case 5:
                        ConfirmOrder("Carne e queijo", 48.99m);
                        MenuPasteis();
                        break;
                    case 6:
                        ConfirmOrder("Pizza", 44.99m);
                        MenuPasteis();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Thread.Sleep(1000);
                        break;
                }

            }
            static void MenuHotDogs()
            {
                Console.Clear();
                Console.WriteLine("Pão 100g prensado - Tamanho: 19cm.");
                Console.WriteLine("Digite a opção escolhida e confirme logo após.");
                Console.WriteLine("1 - Dog padrão - 2 salsichas - molho - purê temperado - batata palho.");
                Console.WriteLine("3 - CalaDog - 2 salsichas - Calabresa picada - mussarela - azeitonas - purê temperado e batata palho.");
                Console.WriteLine("4 - FranDog - 2 salsichas - molho - frango desfiado - purê temperado - catupiry e batata palho.");
                Console.WriteLine("5 - MonsterDog - 2 salsichas - molho - presunto e mussarela - ervilhas e milho - purê temperado - molho campanha(vinagrete)");
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.WriteLine("");
                Console.Write("Digite: ");
                short res = short.Parse(Console.ReadLine()!);

                switch (res)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        ConfirmOrder("Dog padrão", 15.99m);
                        MenuHotDogs();
                        break;
                    case 2:
                        ConfirmOrder("CalaDog", 16.99m);
                        MenuHotDogs();
                        break;
                    case 3:
                        ConfirmOrder("FranDog", 18.99m);
                        MenuHotDogs();
                        break;
                    case 4:
                        ConfirmOrder("MonsterDog", 20.99m);
                        MenuHotDogs();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Thread.Sleep(1000);
                        break;
                }

            }


        }
        static void MenuBebidas()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção escolhida e confirme logo após.");
            Console.WriteLine("1 - 350ml - 1L - 2L");
            Console.WriteLine("2 - Sucos naturais");
            Console.WriteLine("3 - Milkshakes");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            Console.WriteLine("");
            Console.Write("Digite: ");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    Bebidas350ml1l2l();
                    break;
                case 2:
                    BebidasNaturais();
                    break;
                case 3:
                    BebidasMilkshakes();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Thread.Sleep(1000);
                    break;
            }



        }
        static void Bebidas350ml1l2l()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada.");
            Console.WriteLine("1 - Fanta uva 350ML");
            Console.WriteLine("2 - Fanta laranja 350ML");
            Console.WriteLine("3 - Coca zero 350ML");
            Console.WriteLine("4 - Pepsi 350ML");
            Console.WriteLine("5 - Schweppes  350ML");
            Console.WriteLine("6 - Coca original 1L");
            Console.WriteLine("7 - Fanta Laranja 1L");
            Console.WriteLine("8 - Guaraná antartica 1L");
            Console.WriteLine("9 - Dolly guaraná 1L");
            Console.WriteLine("10 - Dolly laranja 1L");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    ConfirmOrder("Fanta uva 350ML", 4.99m);
                    Bebidas350ml1l2l();
                    break;
                case 2:
                    ConfirmOrder("Fanta laranja 350ML", 4.99m);
                    Bebidas350ml1l2l();
                    break;
                case 3:
                    ConfirmOrder("Coca-cola zero 350ML", 5.50m);
                    Bebidas350ml1l2l();
                    break;
                case 4:
                    ConfirmOrder("Pepsi 350ML", 5.50m);
                    Bebidas350ml1l2l();
                    break;
                case 5:
                    ConfirmOrder("Schweppes  350ML", 9.50m);
                    Bebidas350ml1l2l();
                    break;
                case 6:
                    ConfirmOrder("Coca-cola original 1L", 8.99m);
                    Bebidas350ml1l2l();
                    break;
                case 7:
                    ConfirmOrder("Fanta Laranja 1L", 8.99m);
                    Bebidas350ml1l2l();
                    break;
                case 8:
                    ConfirmOrder("Guaraná antartica 1L", 8.99m);
                    Bebidas350ml1l2l();
                    break;
                case 9:
                    ConfirmOrder("Dolly guaraná 1L", 7.99m);
                    Bebidas350ml1l2l();
                    break;
                case 10:
                    ConfirmOrder("Dolly laranja 1L", 7.99m);
                    Bebidas350ml1l2l();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Thread.Sleep(1000);
                    break;
            }
        }
        static void BebidasNaturais()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada.");
            Console.WriteLine("1 - Laranja 350ML");
            Console.WriteLine("1 - Limonada 350ML");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    ConfirmOrder("Suco natural Laranja 350ML", 6.99m);
                    BebidasNaturais();
                    break;
                case 2:
                    ConfirmOrder("Limonada natural 350ML", 5.99m);
                    BebidasNaturais();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Thread.Sleep(1000);
                    break;
            }


        }
        static void BebidasMilkshakes()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada.");
            Console.WriteLine("1 - Shake de chocolate 500ML");
            Console.WriteLine("2 - Shake de morango 500ML");
            Console.WriteLine("3 - Shake de nutela 500ML");
            Console.WriteLine("4 - Shake de baunilha com paçoca 500ML");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0:
                    MenuPrincipal();
                    break;
                case 1:
                    ConfirmOrder("Shake de chocolate 500ML", 22.99m);
                    BebidasMilkshakes();
                    break;
                case 2:
                    ConfirmOrder("Shake de morango 500ML", 19.99m);
                    BebidasMilkshakes();
                    break;
                case 3:
                    ConfirmOrder("Shake de nutela 500ML", 24.99m);
                    BebidasMilkshakes();
                    break;
                case 4:
                    ConfirmOrder("Shake de baunilha com paçoca 500ML", 26.99m);
                    BebidasMilkshakes();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Thread.Sleep(1000);
                    break;
            }
        }

        static void ConfirmOrder(string res, decimal preco)
        {
            Console.Clear();
            Console.WriteLine("1 - Confirmar escolha");
            Console.WriteLine("0 - Voltar ao Cardapio");
            Console.WriteLine("");
            Console.Write("Digite: ");
            short resConfirm = short.Parse(Console.ReadLine()!);
            Console.Clear();
            if (resConfirm == 1)
            {
                SaveOrder(res, preco);
                Console.WriteLine("Registramos sua escolha com sucesso.\n");
                Thread.Sleep(2000);
            }
            else
            {
                MenuPrincipal();
            }
        }


        static void SaveOrder(string pedido, decimal valor)
        {
            if (pedidos.ContainsKey(pedido))
            {
                var (price, quantity) = pedidos[pedido];
                pedidos[pedido] = (price, quantity + 1);
            }
            else
            {
                pedidos[pedido] = (valor, 1);
            }

            Console.WriteLine($"Pedido adicionado:\n\n{pedido}\nPreço: R$ {valor}\nQuantidade: {pedidos[pedido].quantity}");
        }


        static void Checkout()
        {
            Console.Clear();
            Console.WriteLine("Segue abaixo a lista dos seus pedidos:");
            Console.WriteLine("1 - Checkout pedido");
            Console.WriteLine("2 - Voltar ao menu");
            Console.WriteLine("");
            Console.Write("Digite: ");
            short res = short.Parse(Console.ReadLine()!);
            if (res == 1)
            {
                Payment();
            }
            else
            {
                MenuPrincipal();
            }
        }
        static void ExibirCheckout()
        {
            Console.Clear();
            decimal total = 0m;
            foreach (var item in pedidos)
            {
                string descricao = item.Key;
                decimal preco = item.Value.price;
                int quantidade = item.Value.quantity;
                decimal subtotal = preco * quantidade;
                Console.WriteLine($"{descricao} - {quantidade}x\nR${preco} cada\nSubtotal: R${subtotal}\n\n");
                total += subtotal;
            }
            if (total > 0)
            {
                Console.WriteLine($"Total a pagar: R$ {total}\n");
            }
            else
            {
                MenuPrincipal();
            }
        }
        static void Payment()
        {
            ExibirCheckout();
            Console.WriteLine("Escolha o método de pagamento:\n");
            Console.WriteLine("1 - Pix");
            Console.WriteLine("2 - Boleto bancário");
            Console.WriteLine("3 - Cartão de crédito");
            Console.WriteLine("4 - Cartão de débito");
            Console.WriteLine("0 - Voltar ao menu principal");
            Console.WriteLine("");
            Console.Write("Digite: ");
            short PaymentType = short.Parse(Console.ReadLine()!);

            Console.WriteLine($"\n\n\nPressione 'enter' para prosseguir.");
            Console.ReadKey();
            Console.Clear();
            switch (PaymentType)
            {
                case 0:
                    DescartaPedidos();
                    MenuPrincipal();
                    break;
                case 1:
                    Console.WriteLine("Método pix escolhido\n");
                    break;
                case 2:
                    Console.WriteLine("Método boleto escolhido\n");
                    break;
                case 3:
                    Console.WriteLine("Método credito escolhido\n");
                    break;
                case 4:
                    Console.WriteLine("Método débito escolhido\n");
                    break;

            }
        }
        static void DescartaPedidos()
        {
            Console.Clear();
            Console.WriteLine("Seu histórico de pedidos será descartado\nVocê terá que adicionar novamente.\n");
            Console.WriteLine("1 - Confirmar");
            Console.WriteLine("0 - Voltar ao Checkout");
            Console.WriteLine("");
            Console.Write("Digite: ");
            short resConfirm = short.Parse(Console.ReadLine()!);
            if (resConfirm == 1)
            {
                pedidos.Clear();
                Console.WriteLine("Você será direcionado(a) ao menu principal");
                Thread.Sleep(2000);
                MenuPrincipal();
            }
            else if (resConfirm == 0)
            {
                Payment();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                DescartaPedidos();
            }
        }
    }

}
