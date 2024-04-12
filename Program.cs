using BancoReal;

Usuario joao = new Usuario("João", 1000);
joao.Sacar(300);
joao.Depositar(500);
joao.Imprimir();
Usuario maria = new Usuario("Maria", 2000);
maria.Depositar(700);
maria.Sacar(300);
joao.Depositar(300);


maria.Imprimir();
joao.Imprimir();
